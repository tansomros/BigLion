using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using DevExpress.XtraWaitForm;
using Microsoft.Extensions.Logging;
using SUTH.HealthCheckup.WinFormsUI.Checkup.Api.Client;
using SUTH.HealthCheckup.WinFormsUI.Functions;
using SUTH.HealthCheckup.WinFormsUI.Hosxp.Api.Client;
using SUTH.HealthCheckup.WinFormsUI.Interfaces;
using CheckupClient = SUTH.HealthCheckup.WinFormsUI.Checkup.Api.Client; 
using HosXPClient = SUTH.HealthCheckup.WinFormsUI.Hosxp.Api.Client;
using IAuthenticationService = SUTH.HealthCheckup.WinFormsUI.Interfaces.IAuthenticationService;

namespace SUTH.HealthCheckup.WinFormsUI;

public partial class SyncDataForm : DevExpress.XtraEditors.XtraForm
{

    //private readonly IHttpClientFactory _httpClientFactory;
    private ExecutionStatus _executionStatus;

    private readonly CheckupApiClient _checkupApiClient;
    private readonly HosxpApiClient _hosxpApiClient;

    DateTimeOffset _lastProcessedTime;
    DateTimeOffset _currentProcessingTime;

    private List<CheckupClient.CheckupViewModel> _checkupViewModels;
    private int _pastTimeInMinute = 60;

    public SyncDataForm(IUserContext userContext, CheckupApiClient checkupApiClient, HosxpApiClient hosxpApiClient)
    {
        _checkupApiClient = checkupApiClient;
        _hosxpApiClient = hosxpApiClient;
        _executionStatus = ExecutionStatus.Fail;
        InitializeComponent();
    }

    private void SyncDataForm_Load(object sender, EventArgs e)
    {
        DtpStartDate.EditValue = DateTime.Now.Date;
        DtpEndDate.EditValue = DateTime.Now.Date;
    }

    private async void btnSync_Click(object sender, EventArgs e)
    {
        LblSuccess.Visible = false;
        ShowLoading(true);
        await SyncCheckupData();
        ShowLoading(false);
        LblSuccess.Visible = true; 
        MessageBox.Show(this, "Success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    private void ShowLoading(bool show)
    {
        if (show)
        {        
          
            progressBarControl1.Show();
            progressBarControl1.Visible = true;
            progressBarControl1.Position = progressBarControl1.Properties.Minimum;
            RunVariableIncrement(1);
            this.Cursor = Cursors.WaitCursor;
            //แสดงหมุนๆ
        }
        else
        {
            progressBarControl1.Visible = false;
            this.Cursor = Cursors.Default;           
            //หยุดแสดงหมุนๆ
        }
    }
    private void RunVariableIncrement(double pointStep)
    {
        double currentStep = progressBarControl1.Position;
        //double pointStep = (progressBarControl1.Properties.Maximum - progressBarControl1.Properties.Minimum) / 4;
        while (progressBarControl1.Position < pointStep)
        {
            currentStep += 1.5;
            progressBarControl1.Increment((int)Math.Ceiling(currentStep));
            progressBarControl1.Update();
            System.Threading.Thread.Sleep(100);
           
        }
    }

    private async Task SyncCheckupData()
    {
        _lastProcessedTime = new DateTimeOffset((((DateTime?)DtpStartDate.EditValue ?? DateTime.Now).Date));
        _currentProcessingTime = new DateTimeOffset((((DateTime?)DtpEndDate.EditValue ?? DateTime.Now).Date.AddDays(1).AddTicks(-1)));           

        await CheckupPatientSyncService();
        _checkupViewModels = await GetCheckupListAsync(_checkupApiClient, _lastProcessedTime, _currentProcessingTime);
        await ServiceOrderSyncService();  
        await LabSyncService();   
        await XraySyncService();
        RunVariableIncrement(100);
    }

    #region "Checkup Patient"


    //----------------------Patient------------------------

    public async Task<ExecutionStatus> CheckupPatientSyncService()
    {
        _executionStatus = ExecutionStatus.Fail;      
        //
        //Get new and update ckupovst
        //

        var newCheckupOvstList = await GetLatestUpdatedCheckupFromHosXPAsync(
            _hosxpApiClient, _lastProcessedTime, _currentProcessingTime
            );


        if (_executionStatus == ExecutionStatus.Fail) return _executionStatus;

        if (newCheckupOvstList.Checkups.Count > 0)
        {
                    
           //var visitNumbers = _checkupViewModels.Select(x => x.VisitNumber).ToHashSet();

            List<HosXPClient.CheckupViewModel> matchedOvstList;

            if (!string.IsNullOrWhiteSpace(TxtHospitalNumber.Text)) //ถ้าระบุ HN  
            {
                 matchedOvstList = newCheckupOvstList.Checkups.Where(x => x.HospitalNumber==TxtHospitalNumber.Text.Trim()).ToList();
            }
            else
            {
                 matchedOvstList = newCheckupOvstList.Checkups.ToList();
            }             

            var filterdCheckups = FilterDuplicatedCheckupFromCkupOvst(matchedOvstList.ToList());

            foreach (HosXPClient.CheckupViewModel hxpCkpVst in filterdCheckups)
            {

                int ckupPatientId = 0;
                var patient = hxpCkpVst.Patient;
                if (patient != null)
                {
                    ckupPatientId = await UpsertPatientCheckup(patient.HospitalNumber, patient, _checkupApiClient);
                }

                if (ckupPatientId != 0 && patient != null)
                {
                    var checkup = await GetCheckupByVisitNumberAsync(_checkupApiClient, hxpCkpVst.VisitNumber);

                    if (checkup == null)
                    {
                        await CreateCheckupAsync(hxpCkpVst, _checkupApiClient, ckupPatientId, patient);
                    }
                    else
                    {
                        await UpdateCheckupAsync(checkup, hxpCkpVst, _checkupApiClient, patient);
                    }
                }
                else
                {
                    // Debug.WriteLine("===Checkup Patient Service=== ไม่พบข้อมูล Patient ของ HN: {HospitalNumber} ", hxpCkpVst.HospitalNumber);
                }
            }
        }
        else
        {
            // Debug.WriteLine("===Checkup Patient Service=== There is no changed records.");
            //_processingStateSerivce.UpdateLastProcessedTimestampAsync(_currentProcessingTime);
        }

        return ExecutionStatus.Success;
    }

    private static List<HosXPClient.CheckupViewModel> FilterDuplicatedCheckupFromCkupOvst(List<HosXPClient.CheckupViewModel> hCheckups)
    {
        var ret = new List<HosXPClient.CheckupViewModel>();
        ret = hCheckups.GroupBy(x => new { x.VisitNumber }).Select(g => g.First()).ToList();
        return ret;
    }


    private async Task<HosXPClient.CheckupListViewModel> GetLatestUpdatedCheckupFromHosXPAsync(
        HosxpApiClient hosxpApiClient, DateTimeOffset lastProcessedTime, DateTimeOffset currentProcessingTime
        )
    {
        var newCheckupOvstList = new HosXPClient.CheckupListViewModel { Checkups = [] };

        try
        {
            var getLatestUpdatedCheckupListQuery = new GetLatestUpdatedCheckupListQuery
            {
                CurrentProcessingTime = currentProcessingTime,
                LastProcessedTime = lastProcessedTime,
            };
            newCheckupOvstList = await hosxpApiClient.GetLatestUpdatedCheckupAsync(getLatestUpdatedCheckupListQuery);
            _executionStatus = ExecutionStatus.Success;
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            Debug.WriteLine("===Checkup Patient Service=== GetLatestUpdatedCheckupFromHosXPAsync Fail. Exception: {message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            Debug.WriteLine("===Checkup Patient Service=== GetLatestUpdatedCheckupFromHosXPAsync Fail. Exception: {message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (ApiClientException ex)
        {
            Debug.WriteLine("===Checkup Patient Service=== GetLatestUpdatedCheckupFromHosXPAsync Fail. Exception: {message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (Exception ex)
        {
            Debug.WriteLine("===Checkup Patient Service=== GetLatestUpdatedCheckupFromHosXPAsync Fail. Exception: {message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }

        return newCheckupOvstList;
    }

    private async Task CreateCheckupAsync(
        HosXPClient.CheckupViewModel newckubVst, CheckupApiClient checkupApiClient, int patientId, CheckupPatientViewModel patient
        )
    {
        var labOrderList = new List<string>();
        labOrderList.AddRange(newckubVst.LabItemCodes.ToList());
        labOrderList.AddRange(newckubVst.LabItemGroupCodes.ToList());

        var createCheckupCommand = new CreateCheckupCommand
        {
            PatientId = patientId,
            CheckupTypeId = newckubVst.ServiceTypeId ?? 0,
            CheckupVisitId = newckubVst.Id,

            DiastolicBloodPresure = (int?)(newckubVst.VitalSign?.DiastolicBloodPressure ?? null),
            SystolicBloodPresure = (int?)(newckubVst.VitalSign?.SystolicBloodPressure ?? null),
            Height = newckubVst.VitalSign?.BodyHeight ?? (double)0,
            Weight = newckubVst.VitalSign?.BodyWeight ?? 0,
            PulseRate = (int?)newckubVst.VitalSign?.PulseRate,
            Temperature = newckubVst.VitalSign?.BodyTemperature ?? 0,
            RespiratoryRate = (int?)newckubVst.VitalSign?.RespiratoryRate ?? 0,

            HospitalNumber = newckubVst.HospitalNumber,
            IsLabResultReady = newckubVst.IsLabResultReady,
            IsXrayResultReady = newckubVst.IsXrayResultReady,

            PackageId = newckubVst.ProgramId ?? 0,
            PackageName = newckubVst.CkupProg?.CkupProgName ?? string.Empty,
            PayorName = newckubVst.PatientType ?? string.Empty,

            // แปลง VisitDate จาก พ.ศ. (HosXP) เป็น ค.ศ. (Checkup DB) 
            VisitDate = newckubVst.VisitDate.Value.Date.AddYears(543),
            VisitNumber = newckubVst.VisitNumber,
            VisitTime = DateTimeOffset.Now.TimeOfDay,
            // ใช้ VisitDate ที่แปลงเป็น ค.ศ. แล้วเพื่อคำนวณอายุ (BirthDate เป็น ค.ศ. อยู่แล้ว)
            Age = GetAgeAtCheckupDate(newckubVst.VisitDate, patient?.BirthDate),
            AgeText = GetAgeTestAtCheckupDate(newckubVst.VisitDate, patient?.BirthDate),

            LabOrder = labOrderList,
            XrayOrder = newckubVst.XrayItemCodes,
            ServiceOrder = newckubVst.FeeIcodes,

            Waist = newckubVst.VitalSign?.Waist ?? 0,
            IsSmoking = newckubVst.VitalSign?.IsSmoking,
            IsAlcohol = newckubVst.VitalSign?.IsDrinking,
            SmokingRemark = newckubVst.VitalSign?.SmokingRemark,
            AlcoholRemark = newckubVst.VitalSign?.DrinkingRemark,
        };

        try
        {
            await checkupApiClient.CreateCheckupAsync(createCheckupCommand);
            Debug.WriteLine("===Checkup Patient Service=== Visit " + newckubVst.VisitNumber + " has been sucessfully saved", newckubVst.VisitNumber);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            Debug.WriteLine("===Checkup Patient Service=== Fail to save " + newckubVst.VisitNumber + ". Exception: " + ex.Message);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            Debug.WriteLine("===Checkup Patient Service=== Fail to save " + newckubVst.VisitNumber + ". Title:  "+  ex.Message);
        }
        catch (ApiClientException ex)
        {
            Debug.WriteLine("===Checkup Patient Service=== Fail to save " + newckubVst.VisitNumber + ". Title:  "+  ex.Message);
        }
        catch (Exception ex)
        {
            Debug.WriteLine("===Checkup Patient Service=== Fail to save " + newckubVst.VisitNumber + ". Exception:  "+  ex.Message);
        }
    }

    private static int? GetAgeAtCheckupDate(DateTimeOffset? visitDate, DateTimeOffset? birthDatePatient)
    {
        if (visitDate == null || birthDatePatient == null)
        {
            return null;
        }


        DateTime visitDateNow = visitDate?.DateTime ?? new DateTime();
        DateTime birthDate = birthDatePatient?.DateTime ?? new DateTime();

        int years = visitDateNow.Year - birthDate.Year;
        int months = visitDateNow.Month - birthDate.Month;
        int days = visitDateNow.Day - birthDate.Day;

        if (days < 0)
        {
            months--;
            DateTime prevMonth = visitDateNow.AddMonths(-1);
            days += DateTime.DaysInMonth(prevMonth.Year, prevMonth.Month);
        }

        if (months < 0)
        {
            years--;
            months += 12;
        }

        //return $"{years} ปี {months} เดือน {days} วัน"
        return years;


    }

    private static string GetAgeTestAtCheckupDate(DateTimeOffset? visitDate, DateTimeOffset? birthDatePatient)
    {
        if (visitDate == null || birthDatePatient == null)
        {
            return null;
        }

        DateTime visitDateNow = visitDate?.DateTime ?? new DateTime();
        DateTime birthDate = birthDatePatient?.DateTime ?? new DateTime();

        int years = visitDateNow.Year - birthDate.Year;
        int months = visitDateNow.Month - birthDate.Month;
        int days = visitDateNow.Day - birthDate.Day;

        if (days < 0)
        {
            months--;
            DateTime prevMonth = visitDateNow.AddMonths(-1);
            days += DateTime.DaysInMonth(prevMonth.Year, prevMonth.Month);
        }

        if (months < 0)
        {
            years--;
            months += 12;
        }

        return $"{years} ปี {months} เดือน {days} วัน";
    }
    private static DateTime NormalizeToChristianEra(DateTime date)
    {
        return date.Year > 2400
            ? date.AddYears(-543)
            : date;
    }
    private async Task UpdateCheckupAsync(
        CheckupClient.CheckupViewModel checkup, HosXPClient.CheckupViewModel newCkubVst, CheckupApiClient checkupApiClient, CheckupPatientViewModel patient
        )
    {
        var labOrderList = new List<string>();
        labOrderList.AddRange(newCkubVst.LabItemCodes.ToList());
        labOrderList.AddRange(newCkubVst.LabItemGroupCodes.ToList());

        var updateCheckupFromSync = new UpdateCheckupFromSyncCommand  
        {
            Id = checkup.Id,
            VisitNumber = checkup.VisitNumber,
            CheckupVisitId = checkup.CheckupVisitId,
            HospitalNumber = checkup.HospitalNumber,

            // แปลง VisitDate จาก พ.ศ. (HosXP) เป็น ค.ศ. (Checkup DB)       
            //VisitDate = NormalizeToChristianEra(newCkubVst.VisitDate.Value.Date),
            //VisitTime = DateTimeOffset.Now.TimeOfDay,

            CheckupTypeId = newCkubVst.ServiceTypeId ?? 0,

            DiastolicBloodPresure = (int?)(newCkubVst.VitalSign?.DiastolicBloodPressure ?? null),
            SystolicBloodPresure = (int?)(newCkubVst.VitalSign?.SystolicBloodPressure ?? null),
            Height = newCkubVst.VitalSign?.BodyHeight ?? (double)0,
            Weight = newCkubVst.VitalSign?.BodyWeight ?? 0,
            PulseRate = (int?)newCkubVst.VitalSign?.PulseRate,
            Temperature = newCkubVst.VitalSign?.BodyTemperature ?? 0,
            RespiratoryRate = (int?)newCkubVst.VitalSign?.RespiratoryRate ?? 0,

            PackageId = newCkubVst.ProgramId ?? 0,
            PackageName = newCkubVst.CkupProg?.CkupProgName ?? string.Empty,
            PayorName = newCkubVst.PayorName ?? string.Empty,
            // ใช้ VisitDate ที่แปลงเป็น ค.ศ. แล้วเพื่อคำนวณอายุ (BirthDate เป็น ค.ศ. อยู่แล้ว)
            Age = GetAgeAtCheckupDate(newCkubVst.VisitDate, patient?.BirthDate),
            AgeText = GetAgeTestAtCheckupDate(newCkubVst.VisitDate, patient?.BirthDate),
            IsLabResultReady = newCkubVst.IsLabResultReady,
            IsXrayResultReady = newCkubVst.IsXrayResultReady,

            LabOrder = labOrderList,
            XrayOrder = newCkubVst.XrayItemCodes,
            ServiceOrder = newCkubVst.FeeIcodes,

            Waist = newCkubVst.VitalSign?.Waist ?? 0,
            IsSmoking = newCkubVst.VitalSign?.IsSmoking,
            IsAlcohol = newCkubVst.VitalSign?.IsDrinking,
            SmokingRemark = newCkubVst.VitalSign?.SmokingRemark,
            AlcoholRemark = newCkubVst.VitalSign?.DrinkingRemark,

        };

        try
        {
            await checkupApiClient.UpdateCheckupFromSyncAsync(checkup.Id, updateCheckupFromSync);
            Debug.WriteLine("===Checkup Patient Service=== Visit " + newCkubVst.VisitNumber + " has been sucessfully updated", newCkubVst.VisitNumber);
        }

        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            Debug.WriteLine("===Checkup Patient Service=== Fail to save " + newCkubVst.VisitNumber + ". Exception: "+ ex.Message);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            Debug.WriteLine("===Checkup Patient Service=== Fail to save " + newCkubVst.VisitNumber + ". Title:  "+  ex.Message);
        }
        catch (ApiClientException ex)
        {
            Debug.WriteLine("===Checkup Patient Service=== Fail to save " + newCkubVst.VisitNumber + ". Title:  "+  ex.Message);
        }
        catch (Exception ex)
        {
            Debug.WriteLine("===Checkup Patient Service=== Fail to save " + newCkubVst.VisitNumber + ". Exception:  "+  ex.Message);
        }
    }

    private async Task<int> CreatePatientCheckup(
        CheckupPatientViewModel patient, CheckupApiClient checkupApiClient
        )
    {
        var command = new CreatePatientFromWorkerCommand
        {
            FirstName = patient.FirstName,
            HospitalNumber = patient.HospitalNumber,
            Address = patient.Address,
            BirthDate = patient.BirthDate.AddYears(543),
            BloodGroup = patient.BloodGroup,
            District = patient.District,
            DrugAllergy = patient.DrugAllergy,
            EmployeeId = patient.EmployeeId,
            FullName = patient.FullName,
            Gender = patient.Gender,
            LastName = patient.LastName,
            Nationality = patient.Nationality,
            NationId = patient.NationId,
            Prefix = patient.Prefix,
            Province = patient.Province,
            Religion = patient.Religion,
            SubDistrict = patient.SubDistrict,
            TelephoneNumber = patient.TelephoneNumber,
            ZipCode = patient.ZipCode,
            ChronicDisease = patient.ActiveProblem,
        };

        int ckpPatienId = 0;
        try
        {
            ckpPatienId = await checkupApiClient.CreatePatientFromWorkerAsync(command);
            Debug.WriteLine("===Checkup Patient Service=== Patient {HospitalNumber} has been sucessfully saved", patient.HospitalNumber);
        }

        catch (ApiClientException<ValidationProblemDetails> ex)
        {

            Debug.WriteLine("===Checkup Patient Service=== Fail to save {HospitalNumber}. Exception: {message}", patient.HospitalNumber, ex.Message);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            Debug.WriteLine("===Checkup Patient Service=== Fail to save {HospitalNumber}. Exception: {message}", patient.HospitalNumber, ex.Message);
        }
        catch (ApiClientException ex)
        {
            Debug.WriteLine("===Checkup Patient Service=== Fail to save {HospitalNumber}. Exception: {message}", patient.HospitalNumber, ex.Message);
        }
        catch (Exception ex)
        {
            Debug.WriteLine("===Checkup Patient Service=== Fail to save {HospitalNumber}. Exception: {message}", patient.HospitalNumber, ex.Message);
        }

        return ckpPatienId;
    }

    private async Task<int> UpsertPatientCheckup(
        string hospitalNumber, CheckupPatientViewModel patient, CheckupApiClient checkupApiClient
        )
    {
        var command = new UpsertPatientFromWorkerCommand
        {
            FirstName = patient.FirstName,
            HospitalNumber = patient.HospitalNumber,
            Address = patient.Address,
            BirthDate = patient.BirthDate.AddYears(543),
            BloodGroup = patient.BloodGroup,
            District = patient.District,
            DrugAllergy = patient.DrugAllergy,
            EmployeeId = patient.EmployeeId,
            FullName = patient.FullName,
            Gender = patient.Gender,
            LastName = patient.LastName,
            Nationality = patient.Nationality,
            NationId = patient.NationId,
            Prefix = patient.Prefix,
            Province = patient.Province,
            Religion = patient.Religion,
            SubDistrict = patient.SubDistrict,
            TelephoneNumber = patient.TelephoneNumber,
            ZipCode = patient.ZipCode,
            ChronicDisease = patient.ActiveProblem,
        };

        int ckpPatienId = 0;
        try
        {
            ckpPatienId = await checkupApiClient.UpsertPatientFromWorkerAsync(hospitalNumber, command);
            Debug.WriteLine("===Checkup Patient Service=== Patient {HospitalNumber} has been sucessfully saved", patient.HospitalNumber);
        }

        catch (ApiClientException<ValidationProblemDetails> ex)
        {

            Debug.WriteLine("===Checkup Patient Service=== Fail to save {HospitalNumber}. Exception: {message}", patient.HospitalNumber, ex.Message);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {

            Debug.WriteLine("===Checkup Patient Service=== Fail to save {HospitalNumber}. Exception: {message}", patient.HospitalNumber, ex.Message);
        }
        catch (ApiClientException ex)
        {
            Debug.WriteLine("===Checkup Patient Service=== Fail to save {HospitalNumber}. Exception: {message}", patient.HospitalNumber, ex.Message);
        }
        catch (Exception ex)
        {
            Debug.WriteLine("===Checkup Patient Service=== Fail to save {HospitalNumber}. Exception: {message}", patient.HospitalNumber, ex.Message);
        }

        return ckpPatienId;
    }



    private async Task<CheckupClient.CheckupViewModel> GetCheckupByVisitNumberAsync(CheckupApiClient checkupApiClient, string visitNumber)
    {
        CheckupClient.CheckupViewModel visit = null;
        try
        {
            visit = await checkupApiClient.GetCheckupByVisitNumberAsync(visitNumber);

            _executionStatus = ExecutionStatus.Success;
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {

            Debug.WriteLine("===Checkup Patient Service=== GetCheckupByVisitNumberAsync Fail. Exception: {message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (ApiClientException<ProblemDetails> ex)
        {

            Debug.WriteLine("===Checkup Patient Service=== GetCheckupByVisitNumberAsync Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (ApiClientException ex)
        {
            Debug.WriteLine("===Checkup Patient Service=== GetCheckupByVisitNumberAsync Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (Exception ex)
        {
            Debug.WriteLine("===Checkup Patient Service=== GetCheckupByVisitNumberAsync Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }

        return visit;
    }

    //----------------End Patient and Checkup Visit--------------------------
    #endregion

    #region "Order"

    //-----------------Start Service Order ----------------------------------

    public async Task<ExecutionStatus> ServiceOrderSyncService()
    {

        //
        //Get checkup 
        //
        //var recentCheckupList = await GetCheckupListAsync(_checkupApiClient, _lastProcessedTime, _currentProcessingTime);
        if (_executionStatus == ExecutionStatus.Fail) return _executionStatus;
        List<string> vnList = _checkupViewModels.Select(s => s.VisitNumber).ToList();
        //
        //GetLatestLabOrderList
        //
        var labOrderList = await GetLatestLabOrderList(_hosxpApiClient, _lastProcessedTime, _currentProcessingTime, vnList);
        if (_executionStatus == ExecutionStatus.Fail) return _executionStatus;
        //
        //GetLatestXrayOrderList
        //
        var xrayOrderList = await GetLatestXrayOrderList(_hosxpApiClient, _lastProcessedTime, _currentProcessingTime, vnList);
        if (_executionStatus == ExecutionStatus.Fail) return _executionStatus;
        //
        //GetLatestServiceOrderList
        //
        var serviceOrderList = await GetLatestServiceOrderList(_hosxpApiClient, _lastProcessedTime, _currentProcessingTime, vnList);
        if (_executionStatus == ExecutionStatus.Fail) return _executionStatus;
        //
        //Process order all type
        //
        var vnLabList = labOrderList.Labs.Select(s => s.VisitNumber).ToList();
        var vnXrayList = xrayOrderList.XrayWorkers.Select(s => s.VisitNumber).ToList();
        var vnServList = serviceOrderList.ServiceOrders.Select(s => s.Vn).ToList();

        var mergeVnList = vnLabList.Union(vnXrayList).Union(vnServList);

        Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== Found changed records", mergeVnList.ToList().Count);
        Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== Processing changes...");

        //
        //Prepare 
        //
        var commandUpdateOrders = new List<UpdateCheckupLabXrayOrder>();
        foreach (var mergeVn in mergeVnList)
        {
            var updateOrder = new UpdateCheckupLabXrayOrder()
            {
                LabOrder = labOrderList.Labs.Where(s => s.VisitNumber == mergeVn)
                .Select(s => s.LabItemCode.ToString()).ToList(),
                XrayOrder = xrayOrderList.XrayWorkers.Where(s => s.VisitNumber == mergeVn)
                .Select(s => s.HosxpItemCode.ToString()).ToList(),
                ServiceOrder = serviceOrderList.ServiceOrders.Where(s => s.Vn == mergeVn)
                .Select(s => s.Icode.ToString()).ToList(),
                VisitNumber = mergeVn
            };

            commandUpdateOrders.Add(updateOrder);
        }

        var successStatus = await UpdateLabXrayServiceOrder(commandUpdateOrders, _checkupApiClient);      
        //_processingStateService.UpdateLastProcessedTimestampAsync(_currentProcessingTime);

        return ExecutionStatus.Success;
    }

    private async Task<List<Checkup.Api.Client.CheckupViewModel>> GetCheckupListAsync(
            CheckupApiClient checkupApiClient, DateTimeOffset lastProcessedTime, DateTimeOffset currentProcessingTime)
    {
        var recentCheckupList = new List<Checkup.Api.Client.CheckupViewModel>();
        try
        {

            Checkup.Api.Client.CheckupListViewModel checkupListViewmodel;

            if (string.IsNullOrWhiteSpace(TxtHospitalNumber.Text))
            {
                checkupListViewmodel = await checkupApiClient.GetCheckupListAsync(
              lastProcessedTime.LocalDateTime.Date, currentProcessingTime.LocalDateTime.Date);
            }
            else
            {
               checkupListViewmodel = await checkupApiClient._GetCheckupListByHospitalNumberAsync(
              lastProcessedTime.LocalDateTime.Date, currentProcessingTime.LocalDateTime.Date,TxtHospitalNumber.Text.Trim());
            }
              
            recentCheckupList = checkupListViewmodel.Checkups.ToList();
            _executionStatus = ExecutionStatus.Success;
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {            
            Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== GetCheckupListAsync Fail. Exception: {message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            
            Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== GetCheckupListAsync Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (ApiClientException ex)
        {
            Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== GetCheckupListAsync Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (Exception ex)
        {
            Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== GetCheckupListAsync Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }

        return recentCheckupList;
    }


    public async Task<ExecutionStatus> UpdateLabXrayServiceOrder(List<UpdateCheckupLabXrayOrder> orderList, CheckupApiClient checkupApiClient)
    {

        try
        {
            var command = new UpdateCheckupLabXrayOrderListCommand() { UpdateCheckupLabXrayOrders = orderList };
            await checkupApiClient.UpdateCheckupLabXrayOrderListCommandAsync(command);

            _executionStatus = ExecutionStatus.Success;
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            
            Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== UpdateLabXrayServiceOrder Fail. Exception: {message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            
            Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== UpdateLabXrayServiceOrder Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (ApiClientException ex)
        {
            Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== UpdateLabXrayServiceOrder Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (Exception ex)
        {
            Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== UpdateLabXrayServiceOrder Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }

        return _executionStatus;
    }

    public async Task<LabWorkerListViewModel> GetLatestLabOrderList(
        HosxpApiClient hosxpApiClient, DateTimeOffset lastProcessedTime, DateTimeOffset currentProcessingTime,
        List<string> visitNumberList

        )
    {

        var latetLabOrderList = new LabWorkerListViewModel();
        try
        {
            var query = new GetLatestUpdatedLabOrderListQuery()
            {
                CurrentProcessingTime = currentProcessingTime,
                LastProcessedTime = lastProcessedTime,
                VisitNumberList = visitNumberList
            };

            latetLabOrderList = await hosxpApiClient.GetLatestUpdatedLabOrderListAsync(query);
            _executionStatus = ExecutionStatus.Success;
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            
            Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== GetLatestLabOrderList Fail. Exception: {message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            
            Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== GetLatestLabOrderList Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (ApiClientException ex)
        {
            Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== GetLatestLabOrderList Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (Exception ex)
        {
            Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== GetLatestLabOrderList Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }

        return latetLabOrderList;
    }

    public async Task<XrayWorkerListViewModel> GetLatestXrayOrderList(
        HosxpApiClient hosxpApiClient, DateTimeOffset lastProcessedTime, DateTimeOffset currentProcessingTime,
        List<string> visitNumberList

        )
    {

        var latestXrayOrderList = new XrayWorkerListViewModel();
        try
        {
            var query = new GetLatestUpdatedXrayOrderListQuery()
            {
                CurrentProcessingTime = currentProcessingTime,
                LastProcessedTime = lastProcessedTime,
                VisitNumberList = visitNumberList
            };

            latestXrayOrderList = await hosxpApiClient.GetLatestUpdatedXrayOrderListAsync(query);
            _executionStatus = ExecutionStatus.Success;
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            
            Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== GetLatestLabOrderList Fail. Exception: {message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            
            Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== GetLatestLabOrderList Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (ApiClientException ex)
        {
            Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== GetLatestLabOrderList Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (Exception ex)
        {
            Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== GetLatestLabOrderList Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }

        return latestXrayOrderList;
    }

    public async Task<ServiceOrderListViewModel> GetLatestServiceOrderList(
        HosxpApiClient hosxpApiClient, DateTimeOffset lastProcessedTime, DateTimeOffset currentProcessingTime,
        List<string> visitNumberList

        )
    {

        var latestServiceOrderList = new ServiceOrderListViewModel();
        try
        {
            var query = new GetLatestUpdatedServiceOrderListQuery()
            {
                CurrentProcessingTime = currentProcessingTime,
                LastProcessedTime = lastProcessedTime,
                VisitNumberList = visitNumberList
            };

            latestServiceOrderList = await hosxpApiClient.GetLatestUpdatedServiceOrderListAsync(query);
            _executionStatus = ExecutionStatus.Success;
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            
            Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== GetLatestLabOrderList Fail. Exception: {message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            
            Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== GetLatestLabOrderList Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (ApiClientException ex)
        {
            Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== GetLatestLabOrderList Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (Exception ex)
        {
            Debug.WriteLine("===CheckupLabXrayServiceOrderItemList Service=== GetLatestLabOrderList Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }

        return latestServiceOrderList;
    }


    //----------------End of Service Order ----------------

    #endregion
    #region "Lab"

    public async Task<ExecutionStatus> LabSyncService()
    {
        _executionStatus = ExecutionStatus.Fail;       
        _pastTimeInMinute = 60;
        //
        //Get latest lab from hosXP
        //
        //var recentCheckupList = await GetCheckupListAsync(_checkupApiClient, _lastProcessedTime, _currentProcessingTime);

        if (_checkupViewModels == null) return _executionStatus;
        List<string> vnList = _checkupViewModels.Select(s => s.VisitNumber).ToList();
        //
        //lastProcessedTime ต้องปรับเวลาลบย้อยหลัง เพราะเวลา updatye_datetime ที่รายการ lab_order เกิดไม่ใช่เวลาปัจจุบัน
        //
        var adjustLastProcessedTime = _lastProcessedTime.AddMinutes(_pastTimeInMinute * -1);
        var newLabList = await GetLatestUpdatedLabFromHosXPAsync(
            _hosxpApiClient, adjustLastProcessedTime, _currentProcessingTime, vnList
            );
        if (_executionStatus == ExecutionStatus.Fail) return _executionStatus;

        if (newLabList.Labs.Count > 0)
        {
            var upsertList = newLabList.Labs.Select(
                s => new UpsertLabCommand
                {
                    VisitNumber = s.VisitNumber,
                    LabItemCode = s.LabItemCode,
                    IsAbnormal = s.IsAbnormal,
                    ResultValue = s.ResultValue,
                    ReferenceRange = s.ReferenceRange,
                    ResultDate = s.ResultDate.Value.Date,//.AddYears(543),
                    ResultTime = s.ResultTime ?? new TimeSpan(),
                    LabItemName = s.LabItemsNameRef,
                }
                ).ToList();

            await UpsertLatestLabWorker(upsertList, _checkupApiClient);
            if (_executionStatus == ExecutionStatus.Fail) return _executionStatus;           
        }
        else
        {
            Debug.WriteLine("===Lab Sync Service=== There is no changed records.");            
        }

        return ExecutionStatus.Success;
    }

    private async Task<LabWorkerListViewModel> GetLatestUpdatedLabFromHosXPAsync(
        HosxpApiClient hosxpApiClient, DateTimeOffset lastProcessedTime, DateTimeOffset currentProcessingTime
        , List<string> vnList
        )
    {
        var newLabList = new LabWorkerListViewModel { Labs = [] };

        try
        {
            var getLatestUpdatedLabListQuery = new GetLastestUpdatedLabListQuery
            {
                CurrentProcessingTime = currentProcessingTime,
                LastProcessedTime = lastProcessedTime,
                VisitNumberList = vnList
            };
            newLabList = await hosxpApiClient.GetLastestUpdatedLabListAsync(getLatestUpdatedLabListQuery);
            _executionStatus = ExecutionStatus.Success;
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {

            Debug.WriteLine("===Lab Sync Service=== GetLatestUpdatedCheckupFromHosXPAsync Fail. Exception: {message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            Debug.WriteLine("===Lab Sync Service=== GetLatestUpdatedCheckupFromHosXPAsync Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (ApiClientException ex)
        {
            Debug.WriteLine("===Lab Sync Service=== GetLatestUpdatedCheckupFromHosXPAsync Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (Exception ex)
        {
            Debug.WriteLine("===Lab Sync Service=== GetLatestUpdatedCheckupFromHosXPAsync Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }

        return newLabList;
    }

    //private async Task<List<Checkup.Api.Client.CheckupViewModel>> GetCheckupListAsync(
    //    CheckupApiClient checkupApiClient, DateTimeOffset lastProcessedTime, DateTimeOffset currentProcessingTime)
    //{
    //    var recentCheckupList = new List<Checkup.Api.Client.CheckupViewModel>();
    //    try
    //    {
    //        Checkup.Api.Client.CheckupListViewModel checkupListViewmodel = await checkupApiClient.GetCheckupListAsync(
    //            lastProcessedTime.LocalDateTime.Date
    //            , currentProcessingTime.LocalDateTime.Date
    //            );
    //        recentCheckupList = checkupListViewmodel.Checkups.ToList();
    //        _executionStatus = ExecutionStatus.Success;
    //    }
    //    catch (ApiClientException<ValidationProblemDetails> ex)
    //    {
    //        
    //         Debug.WriteLine("===Lab Sync Service=== GetCheckupListAsync Fail. Exception: {message}", message);
    //        _executionStatus = ExecutionStatus.Fail;
    //    }
    //    catch (ApiClientException<ProblemDetails> ex)
    //    {
    //        
    //         Debug.WriteLine("===Lab Sync Service=== GetCheckupListAsync Fail. Exception: {Message}", message);
    //        _executionStatus = ExecutionStatus.Fail;
    //    }
    //    catch (ApiClientException ex)
    //    {
    //         Debug.WriteLine("===Lab Sync Service=== GetCheckupListAsync Fail. Exception: {Message}", ex.Message);
    //        _executionStatus = ExecutionStatus.Fail;
    //    }
    //    catch (Exception ex)
    //    {
    //         Debug.WriteLine("===Lab Sync Service=== GetCheckupListAsync Fail. Exception: {Message}", ex.Message);
    //        _executionStatus = ExecutionStatus.Fail;
    //    }

    //    return recentCheckupList;
    //}

    private async Task UpsertLatestLabWorker(List<UpsertLabCommand> command, CheckupApiClient apiClient)
    {
        try
        {
            var upsertCommand = new UpsertLatestLabForWorkerCommand { UpsertList = command };
            await apiClient.SyncLabsFromWorkerAsync(upsertCommand);
            _executionStatus = ExecutionStatus.Success;
             Debug.WriteLine("===Lab Sync Service=== Lab {count} items have been sucessfully saved", command.Count);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            
            _executionStatus = ExecutionStatus.Fail;
             Debug.WriteLine("===Lab Sync Service=== Fail to save UpsertLatestLab. Exception: {message}", ex.Message);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            
            _executionStatus = ExecutionStatus.Fail;
             Debug.WriteLine("===Lab Sync Service=== Fail to save UpsertLatestLab. Exception: {message}",ex.Message);
        }
        catch (ApiClientException ex)
        {
            _executionStatus = ExecutionStatus.Fail;
             Debug.WriteLine("===Lab Sync Service=== Fail to save UpsertLatestLab. Exception: {message}", ex.Message);
        }
        catch (Exception ex)
        {
            _executionStatus = ExecutionStatus.Fail;
             Debug.WriteLine("===Lab Sync Service=== Fail to save UpsertLatestLab. Exception: {message}", ex.Message);
        }
    }

    #endregion
    #region "Xray"

    public async Task<ExecutionStatus> XraySyncService()
    {
        _executionStatus = ExecutionStatus.Fail;
        //
        //Get xray lab list
        //
        var adjustLastProcessedTime = _lastProcessedTime.AddMinutes(_pastTimeInMinute * -1);
        var xrayList = await GetLatestUpdatedXrayFromHosXPAsync(
            _hosxpApiClient, adjustLastProcessedTime, _currentProcessingTime
            );
        if (_executionStatus == ExecutionStatus.Fail) return _executionStatus;

        Debug.WriteLine("===Xray Sync Service=== Processing changes...");

        if (xrayList.XrayWorkers.Count > 0)
        {
            var upsertXrayList = xrayList.XrayWorkers.Select(
                s => new UpsertXrayCommand
                {
                    AccessionNumber = s.AccessionNumber,
                    HosxpItemCode = s.HosxpItemCode,
                    IsAbnormal = s.IsAbnormal,
                    ReportText = s.ReportText,
                    ResultReport = s.ResultReport,
                    ResultValue = s.ResultValue,
                    VisitNumber = s.VisitNumber,
                }).ToList();

            await UpsertLatestXrayWorker(upsertXrayList, _checkupApiClient);
            if (_executionStatus == ExecutionStatus.Fail) return _executionStatus;

             Debug.WriteLine("===Xray Sync Service=== Processing done...");
           
        }
        else
        {
             Debug.WriteLine("===Xray Sync Service=== There is no changed records.");
           
        }

        return ExecutionStatus.Success;
    }

    private async Task<XrayWorkerListViewModel> GetLatestUpdatedXrayFromHosXPAsync(
        HosxpApiClient hosxpApiClient, DateTimeOffset lastProcessedTime, DateTimeOffset currentProcessingTime
        )
    {
        var newXrayList = new XrayWorkerListViewModel { XrayWorkers = [] };

        try
        {
            var getLatestUpdatedXrayListQuery = new GetLatestUpdatedXrayListQuery
            {
                CurrentProcessingTime = currentProcessingTime,
                LastProcessedTime = lastProcessedTime,
            };
            newXrayList = await hosxpApiClient.GetLatestUpdatedXrayListAsync(getLatestUpdatedXrayListQuery);
            _executionStatus = ExecutionStatus.Success;
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            
             Debug.WriteLine("===Xray Sync Service=== GetLatestUpdatedXrayFromHosXPAsync Fail. Exception: {message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            
             Debug.WriteLine("===Xray Sync Service=== GetLatestUpdatedXrayFromHosXPAsync Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (ApiClientException ex)
        {
             Debug.WriteLine("===Xray Sync Service=== GetLatestUpdatedXrayFromHosXPAsync Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }
        catch (Exception ex)
        {
             Debug.WriteLine("===Xray Sync Service=== GetLatestUpdatedXrayFromHosXPAsync Fail. Exception: {Message}", ex.Message);
            _executionStatus = ExecutionStatus.Fail;
        }

        return newXrayList;
    }

    private async Task UpsertLatestXrayWorker(List<UpsertXrayCommand> command, CheckupApiClient apiClient)
    {
        try
        {
            var upsertCommand = new UpsertLatestXrayForWorkerCommand { UpsertXrayCommands = command };
            await apiClient.UpsertLatestXrayForWorkerAsync(upsertCommand);
            _executionStatus = ExecutionStatus.Success;
             Debug.WriteLine("===Xray Sync Service=== Xray {count} items have been sucessfully saved", command.Count);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            
            _executionStatus = ExecutionStatus.Fail;
             Debug.WriteLine("===Xray Sync Service=== Fail to save UpsertLatestXray. Exception: {message}", ex.Message);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            
            _executionStatus = ExecutionStatus.Fail;
             Debug.WriteLine("===Xray Sync Service=== Fail to save UpsertLatestXray. Exception: {message}", ex.Message);
        }
        catch (ApiClientException ex)
        {
            _executionStatus = ExecutionStatus.Fail;
             Debug.WriteLine("===Xray Sync Service=== Fail to save UpsertLatestXray. Exception: {message}", ex.Message);
        }
        catch (Exception ex)
        {
            _executionStatus = ExecutionStatus.Fail;
             Debug.WriteLine("===LaXrayb Sync Service=== Fail to save UpsertLatestXray. Exception: {message}", ex.Message);
        }
    }

    #endregion

   

}

