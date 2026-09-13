using System.Data;
using System.Diagnostics;
using System.Threading.Tasks;
using DevExpress.CodeParser;
using DevExpress.XtraCharts.Commands;
using DevExpress.XtraReports.UI;
using SUTH.HealthCheckup.Domain.Enums;
using SUTH.HealthCheckup.WinFormsUI.Checkup.Api.Client;
using SUTH.HealthCheckup.WinFormsUI.Constants;
using SUTH.HealthCheckup.WinFormsUI.Functions;
using SUTH.HealthCheckup.WinFormsUI.Helpers;
using SUTH.HealthCheckup.WinFormsUI.Hosxp.Api.Client;
using SUTH.HealthCheckup.WinFormsUI.Interfaces;
using SUTH.HealthCheckup.WinFormsUI.Models;
using SUTH.HealthCheckup.WinFormsUI.Reports;
using CClass = SUTH.HealthCheckup.WinFormsUI.Constants.CheckupClass;
using CGroup = SUTH.HealthCheckup.WinFormsUI.Constants.CheckupGroup;
using CheckupStatus = SUTH.HealthCheckup.Domain.Enums.CheckupStatus;
using CkStatus = SUTH.HealthCheckup.WinFormsUI.Constants.CheckupStatus;
using Fn = SUTH.HealthCheckup.WinFormsUI.Functions.CheckupFunction;
using HxpClient = SUTH.HealthCheckup.WinFormsUI.Hosxp.Api.Client;
using IAuthenticationService = SUTH.HealthCheckup.WinFormsUI.Interfaces.IAuthenticationService;
using Image = System.Drawing.Image;
using PhysicalExaminationViewModel = SUTH.HealthCheckup.WinFormsUI.Checkup.Api.Client.PhysicalExaminationViewModel;
using Vb = Microsoft.VisualBasic;

namespace SUTH.HealthCheckup.WinFormsUI;
public partial class CheckupForm : DevExpress.XtraEditors.XtraForm
{
    private readonly int _checkupId;
    private readonly string _visitNumber;
    private readonly CheckupApiClient _checkupApiClient;
    private readonly HosxpApiClient _hosxpApiClient;
    public Checkup.Api.Client.CheckupViewModel CheckupViewModel;
    //private Hosxp.Api.Client.LabListViewModel _labListViewModel;
    //private Hosxp.Api.Client.XrayListViewModel _xrayViewModel;
    public SUTH.HealthCheckup.WinFormsUI.Checkup.Api.Client.PhysicalExaminationViewModel CheckupPEViewModel;
    // public CheckupItemListViewModel _otherItemGroups;
    private UpdateCheckupCommand updateCheckupCommand;
    private CheckupItemListViewModel checkupItemListViewModel;
    private readonly IAuthenticationService _authenticationService;
    private readonly IUserContext _userContext;
    //private List<LabXrayStruct> _labBloodChem;
    private bool _isCompleteData;
    private string _alertMessage;
    private string _checkupMessage;
    private string _lungMessage;
    private string _eyeMessage;
    private string _xrayMessage; 
    private string _audiogramMessage;
    private string _dentalMessage;
    private string _otherMessage;


    public struct LabXrayStruct
    {
        public string Code { get; set; }
        public string ResultItemName { get; set; }
        public string ResultValue { get; set; }
        public string ReferenceRange { get; set; }
        public string IsAbnormal { get; set; }
        public string ResultReport { get; set; }
        public string ReportText { get; set; }
        public string AccessionNumber { get; set; }
        public string DoctorResult { get; set; }
        public int Sort { get; set; }
        public int CheckupGroupId { get; set; }

    }

    public CheckupForm(int checkupId, string visitNumber, IUserContext userContext, CheckupApiClient checkupApiClient, HosxpApiClient hosxpApiClient, IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
        _checkupApiClient = checkupApiClient;
        _hosxpApiClient = hosxpApiClient;
        _checkupId = checkupId;
        _visitNumber = visitNumber;
        _userContext = userContext;
        InitializeComponent();
    }

    private async void CheckupForm_Load(object sender, EventArgs e)
    {
        updateCheckupCommand = new UpdateCheckupCommand();
        pnDotorConclusion.Width = 600;
        pnMainLab.Width = this.Width - 840;
        progressLoad.Size = new Size(this.Width, this.Height);
        progressLoad.Location = new Point(0, 0);
        progressLoad.Visible = true;

        BtnPrintReport.Visible = false;
        BtnPrintResultStudent.Visible = false;

        splitContainerControl1.SplitterPosition = 1000;

        _isCompleteData = true;
        _alertMessage = "";
        _checkupMessage = "";
        gridViewHearing.OptionsNavigation.EnterMoveNextColumn = false;

        CheckupViewModel = await _checkupApiClient.GetCheckupByVisitNumberAsync(_visitNumber);
        if (CheckupViewModel != null)
        {
            var labOrder = CheckupViewModel.LabOrder.ToList();
            var xrayOrder = CheckupViewModel.XrayOrder.ToList();
            var serviceOrder = CheckupViewModel.ServiceOrder.ToList();

            checkupItemListViewModel = await _checkupApiClient.GetCheckupItemListAsync(labOrder, xrayOrder, serviceOrder);

            progressLoad.Visible = false;
            ShowPatientInfo(CheckupViewModel.HospitalNumber);
            LoadPatientImage();
            BindProvinceToDDL();
            BindCareproviderToDDL(CheckupViewModel.ConclusionById, CheckupViewModel.PhysicalExaminationById);
            BindCheckupTypeToDDL(CheckupViewModel.CheckupTypeId);
            BindCheckupStatusToDDL(CheckupViewModel.Status);
            BindReferenceValueGAToDDL();
            //BindReferenceValueVisionToDDL(); ไม่ใช้แล้ว 23/12/2025 by Tee
            BindReferenceValueAudiogramToDDL();
            BindReferenceValueXrayToDDL();
            BindReferenceValueBodyCompositionToDDL();
            BindReferenceValueHandGripToDDL();
            BindReferenceValueQualitativeToDDL();

            LoadRecommendationTemplate();
            //BindNormalAbnormalLabResultDataToDDL(); ไม่ใช้แล้วแต่เก็บเอาไว้ก่อน
            progressLoad.Visible = false;
            GetVitalSign();
            //leIsAbnormal.NullText = "N";
            GetPhysicalExamination();
            GetBodyComposition();
            GetDental();
            GetLung();
            GetVision();
            GetAudiogram();
            var specialTests = CheckupViewModel?.SpecialTests.ToList() ?? [];
            GetOtherSpecial(specialTests);
            GetLab();
            var labs = CheckupViewModel?.Labs.ToList() ?? [];
            GetConfidential(labs);

            VisibleTabControl();
            //สรุปผลการตรวจสุขภาพและข้อเสนอแนะของแพทย์
            txtDoctorRecommend.Text = CheckupViewModel.Conclusion;

            if (string.IsNullOrEmpty(txtDoctorRecommend.Text))
                DisplayRecommendation();


            //_xrayViewModel = await Fn.HosxpGetXrayByVisitNumberAsync(CheckupViewModel?.visitNumber, this, _hosxpApiClient);
            //if (_xrayViewModel != null)
            //{
            //    var xrayCheckup = await FilterItemGroup(CClass.Xray, _xrayViewModel.Xrays.ToList());
            //    richX_ChestPA.Rtf = xrayCheckup.Where(x => x.Code == "X01").Select(x => x.ReportText).FirstOrDefault()?.ToString() ?? null;
            //    richX_Mammogram.Text = xrayCheckup.Where(x => x.Code == "MAMO").Select(x => x.ReportText).FirstOrDefault()?.ToString() ?? null;
            //    richX_AbdomenRemark.Text = xrayCheckup.Where(x => x.Code == "X02").Select(x => x.ReportText).FirstOrDefault()?.ToString() ?? null;
            //    richX_LowerAbdomenRemark.Text = xrayCheckup.Where(x => x.Code == "X03").Select(x => x.ReportText).FirstOrDefault()?.ToString() ?? null;
            //}

            //var xayList = await Fn.GetXrayListWithClassFromCheckupAPI(_visitNumber, this, _checkupApiClient);
            //if (xayList.Xrays.Count > 0)
            //{
            //    var xrayCheckup = FilterXrayByGroup(CClass.Xray, xayList);
            //    richX_ChestPA.Rtf = xrayCheckup.Where(x => x.Code == CheckupItemCode.ChestPAcheckup).Select(x => x.ReportText).FirstOrDefault()?.ToString() ?? null;
            //    richX_Mammogram.Text = xrayCheckup.Where(x => x.Code == CheckupItemCode.MAMO).Select(x => x.ReportText).FirstOrDefault()?.ToString() ?? null;
            //    richX_AbdomenRemark.Text = xrayCheckup.Where(x => x.Code == CheckupItemCode.UltrasoundWholeAbdomen).Select(x => x.ReportText).FirstOrDefault()?.ToString() ?? null;
            //    richX_UpperAbdomenRemark.Text = xrayCheckup.Where(x => x.Code == CheckupItemCode.UltrasoundUpperAbdomen).Select(x => x.ReportText).FirstOrDefault()?.ToString() ?? null;
            var xrays = CheckupViewModel?.Xrays.ToList() ?? [];
            GetXray(xrays);
            //    if (richX_ChestPA.Text != "")
            //    {
            //        btnPAC_PA.Visible = true;
            //    }
            //}

            var user = _userContext.CurrentUser;


            if (CheckupViewModel.Status == CkStatus.Pending)
            { BtnPrintReport.Visible = false; }
            else { BtnPrintReport.Visible = true; }

            if (CheckupViewModel.IsFinalized)
            {
                if (user.HasAdminRole)
                {
                    BtnTempSave.Visible = true;
                    //ปุ่ม finalize ถ้า final แล้วจะเห็นแค่ admin ที่มีสิทธิ์เปิดกลับมาให้แก้ไขได้อีก
                    BtnFinalizeSave.Text = "Unfinalize";
                    BtnPrintReport.Visible = true;
                }
                else
                {
                    BtnTempSave.Visible = false;
                    BtnFinalizeSave.Visible = false;
                    BtnPrintReport.Visible = true;
                    BtnPrintReport.Location = new Point(0, 0);
                }
            }
            else
            {
                BtnTempSave.Visible = true;
                //ถ้าสถานะปกติ จะเห็นแค่ หมอ กับ admin 
                if (user.HasAdminRole || user.HasDoctorRole)
                {
                    BtnFinalizeSave.Visible = true;
                }
                else
                {
                    BtnFinalizeSave.Visible = false;
                    BtnPrintReport.Location = new Point(130, 0);
                }
            }
            progressLoad.Visible = false;
        }
    }
    private void VisibleTabControl()
    {
        var user = _userContext.CurrentUser;

        if (user.HasDentistRole)
        {
            xtraTabPageDental.PageVisible = checkupItemListViewModel.CheckupItems.Any(i => i.CheckupGroup.CheckupClassCode == CGroup.Dental);
            xtraTabPageBodyComp.PageVisible = false;
            xtraTabPageVS.PageVisible = false;
            xtraTabPageAudiogram.PageVisible = false;
            xtraTabPageLung.PageVisible = false;
            xtraTabPageCBC.PageVisible = false;
            xtraTabPageBloodChem.PageVisible = false;
            xtraTabPageUA.PageVisible = false;
            xtraTabPageStoolExam.PageVisible = false;
            xtraTabPageStoolCulture.PageVisible = false;
            xtraTabPageSpecial.PageVisible = false;
            xtraTabPageXray.PageVisible = false;
            xtraTabPageOther.PageVisible = false;
            xtraTabPageConfidential.PageVisible = false;
            xtraTabControlMain.SelectedTabPage = xtraTabPageDental;
        }
        else
        {
            //xtraTabPageGA.PageVisible = checkupItemListViewModel.CheckupItems.Any(i => i.CheckupGroup.CheckupClassCode == CGroup.GeneralApprearance);
            xtraTabPageBodyComp.PageVisible = checkupItemListViewModel.CheckupItems.Any(i => i.CheckupGroup.CheckupClassCode == CGroup.BodyComposition);
            xtraTabPageDental.PageVisible = checkupItemListViewModel.CheckupItems.Any(i => i.CheckupGroup.CheckupClassCode == CGroup.Dental);
            xtraTabPageVS.PageVisible = checkupItemListViewModel.CheckupItems.Any(i => i.CheckupGroup.CheckupClassCode == CGroup.VisionScreening);
            xtraTabPageAudiogram.PageVisible = checkupItemListViewModel.CheckupItems.Any(i => i.CheckupGroup.CheckupClassCode == CGroup.Audiogram);
            xtraTabPageLung.PageVisible = checkupItemListViewModel.CheckupItems.Any(i => i.CheckupGroup.CheckupClassCode == CGroup.Lung);
            xtraTabPageCBC.PageVisible = checkupItemListViewModel.CheckupItems.Any(i => i.CheckupGroup.CheckupClassCode == CGroup.CBC);
            xtraTabPageBloodChem.PageVisible = checkupItemListViewModel.CheckupItems.Any(i => i.CheckupGroup.CheckupClassCode == CGroup.BloodChemistry);
            xtraTabPageUA.PageVisible = checkupItemListViewModel.CheckupItems.Any(i => i.CheckupGroup.CheckupClassCode == CGroup.Urine);
            xtraTabPageStoolExam.PageVisible = checkupItemListViewModel.CheckupItems.Any(i => i.CheckupGroup.CheckupClassCode == CGroup.StoolExam);
            xtraTabPageStoolCulture.PageVisible = checkupItemListViewModel.CheckupItems.Any(i => i.CheckupGroup.CheckupClassCode == CGroup.StoolCulture);
            xtraTabPageSpecial.PageVisible = checkupItemListViewModel.CheckupItems.Any(i => i.CheckupGroup.CheckupClassCode == CGroup.SpecialTest);
            xtraTabPageXray.PageVisible = checkupItemListViewModel.CheckupItems.Any(i => i.CheckupGroup.CheckupClassCode == CGroup.Xray);
            xtraTabPageOther.PageVisible = checkupItemListViewModel.CheckupItems.Any(i => i.CheckupGroup.CheckupClassCode == CGroup.OtherLab);
            xtraTabPageConfidential.PageVisible = checkupItemListViewModel.CheckupItems.Any(i => i.CheckupGroup.CheckupClassCode == CGroup.Confidential);
        }
    }

    //ไม่ใช้แล้วแต่เก็บเอาไว้ก่อน
    //private async void BindNormalAbnormalLabResultDataToDDL()
    //{
    //    var result = await _checkupApiClient.GetReferenceValueAbnormalByGroupAsync(ReferenceGroup.LAB);
    //    DoctorResultDdl.DataSource = result.ReferenceValues.ToList();
    //    DoctorResultDdl.DisplayMember = "Descriptions";
    //    DoctorResultDdl.ValueMember = "ValueCode";     
    //}

    private async void BindCareproviderToDDL(int conclusionById, int physicalExaminationById)
    {
        var doctors = await _checkupApiClient.GetCareProviderListAsync();
        ddlDoctor_PE.Properties.DataSource = doctors.CareProviders.ToList();
        ddlDoctor_PE.Properties.DisplayMember = "FullNameThai";
        ddlDoctor_PE.Properties.ValueMember = "Id";

        var doctorLogin = doctors.CareProviders.Where(x => x.Code == _authenticationService.CurrentUser.DoctorCode).Select(x => new { x.Id, x.FullNameThai }).FirstOrDefault();

        if (physicalExaminationById > 0)
        {
            ddlDoctor_PE.EditValue = physicalExaminationById;
        }
        else if (doctorLogin != null)
        {
            ddlDoctor_PE.EditValue = doctorLogin.Id;
        }

        ddlDoctor_Conclusion.Properties.DataSource = doctors.CareProviders.ToList();
        ddlDoctor_Conclusion.Properties.DisplayMember = "FullNameThai";
        ddlDoctor_Conclusion.Properties.ValueMember = "Id";

        if (conclusionById > 0)
        {
            ddlDoctor_Conclusion.EditValue = conclusionById;
        }
        else if (doctorLogin != null)
        {
            ddlDoctor_Conclusion.EditValue = doctorLogin.Id;
        }
    }

    private async void BindCheckupTypeToDDL(int checkupTypeId)
    {
        var types = await _checkupApiClient.GetCheckupTypeListAsync();
        ddlCheckupType.Properties.DataSource = types.CheckupTypes.ToList();
        ddlCheckupType.Properties.DisplayMember = "Name";
        ddlCheckupType.Properties.ValueMember = "Id";

        if (checkupTypeId > 0)
        {
            ddlCheckupType.EditValue = checkupTypeId;
        }
    }
    private void BindCheckupStatusToDDL(int status)
    {
        ddlStatus.Properties.DataSource = SmartEnumBindingHelper.ToDataSource(CheckupStatus.All);
        ddlStatus.Properties.DisplayMember = "Descriptions";
        ddlStatus.Properties.ValueMember = "ValueCode";

        if (status < Convert.ToInt32(CheckupStatus.Reported.Value))
        {
            ddlStatus.EditValue = Convert.ToInt32(CheckupStatus.InProgress.Value);
        }
        else
        {
            ddlStatus.EditValue = status;
        }
    }

    private void BindReferenceValueGAToDDL()
    {
        var generalItems = SmartEnumBindingHelper.ToDataSource(ExamResult.All);

        foreach (var ddl in new[]
        {
            ddlGA_LevelOfConsciousness, ddlGA_Abdomen, ddlGA_Extremties,
            ddlGA_Heen, ddlGA_Heart, ddlGA_LungChestBreast,
            ddlGA_Lymphoma, ddlGA_MouthAndThroat, ddlGA_Skin,
            ddlGA_Thyroid, ddlGA_Others
        })
        {
            ddl.Properties.DataSource = generalItems;
            ddl.Properties.DisplayMember = "Descriptions";
            ddl.Properties.ValueMember = "ValueCode";
        }
    }
    private void BindReferenceValueAudiogramToDDL()
    {
        var audioItems = SmartEnumBindingHelper.ToDataSource(HearingLossLevel.All);

        ddlEarsLeft.Properties.DataSource = audioItems;
        ddlEarsLeft.Properties.DisplayMember = "Descriptions";
        ddlEarsLeft.Properties.ValueMember = "ValueCode";

        ddlEarsRight.Properties.DataSource = audioItems;
        ddlEarsRight.Properties.DisplayMember = "Descriptions";
        ddlEarsRight.Properties.ValueMember = "ValueCode";
    }
    private void BindReferenceValueXrayToDDL()
    {
        var xrayItems = SmartEnumBindingHelper.ToDataSource(XrayResult.All);

        foreach (var ddl in new[]
        {
            ddlX_ChestPA, ddlX_Abdomen, ddlX_UpperAbdomen,
            ddlX_Echo, ddlEKG, ddlEST,
            ddlX_Mammogram, ddlX_USBreast
        })
        {
            ddl.Properties.DataSource = xrayItems;
            ddl.Properties.DisplayMember = "Descriptions";
            ddl.Properties.ValueMember = "ValueCode";
        }

        ddlABI.Properties.DataSource = SmartEnumBindingHelper.ToDataSource(AbiResult.All);
        ddlABI.Properties.DisplayMember = "Descriptions";
        ddlABI.Properties.ValueMember = "ValueCode";

        ddlBMD.Properties.DataSource = SmartEnumBindingHelper.ToDataSource(BmdResult.All);
        ddlBMD.Properties.DisplayMember = "Descriptions";
        ddlBMD.Properties.ValueMember = "ValueCode";
    }
    private void BindReferenceValueBodyCompositionToDDL()
    {
        var bodyItems = SmartEnumBindingHelper.ToDataSource(BodyResult.All);

        foreach (var ddl in new[]
        {
            ddlBmr,ddlBodyWater,ddlBodyFat,ddlVisceralFat,ddlFatRate,ddlMuscleMass
        })
        {
            ddl.Properties.DataSource = bodyItems;
            ddl.Properties.DisplayMember = "Descriptions";
            ddl.Properties.ValueMember = "ValueCode";
        }
    }
    private void BindReferenceValueHandGripToDDL()
    {
        ddlHandGrip.Properties.DataSource = SmartEnumBindingHelper.ToDataSource(HandGripResult.All);
        ddlHandGrip.Properties.DisplayMember = "Descriptions";
        ddlHandGrip.Properties.ValueMember = "ValueCode";
    }
    private void BindReferenceValueQualitativeToDDL()
    {
        var qItems = SmartEnumBindingHelper.ToDataSource(QualitativeResult.All);

        foreach (var ddl in new[]
        {
            ddlAmphetamine
        })
        {
            ddl.Properties.DataSource = qItems;
            ddl.Properties.DisplayMember = "Descriptions";
            ddl.Properties.ValueMember = "ValueCode";
        }
    }

    private void ShowPatientInfo(string hn)
    {
        if (CheckupViewModel == null)
            return;

        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("th-TH");
        var dateString = CheckupViewModel.VisitDate.ToThaiDateString();

        lblHN.Text = string.Concat(CheckupViewModel.HospitalNumber);
        lblStaffID.Text = string.Concat(CheckupViewModel.Patient.EmployeeId);
        lblVisitNo.Text = string.Concat(CheckupViewModel.VisitNumber);
        lblVisitDate.Text = GlobalFunctions.DisplayStr2ShortDateTH(CheckupViewModel.VisitDate.ToString("dd/MM/yyyy", new System.Globalization.CultureInfo("th-TH")));
        lblPatientName.Text = string.Concat(CheckupViewModel.Patient.FullName);
        lblAge.Text = string.Concat(CheckupViewModel.AgeTextCheckup);
        lblGender.Text = string.Concat(CheckupViewModel.Patient.Gender);
        lblIdcard.Text = string.Concat(CheckupViewModel.Patient.NationId);
        lblDOB.Text = GlobalFunctions.DisplayStr2ShortDateTH(CheckupViewModel.Patient.BirthDate.ToString("dd/MM/yyyy", new System.Globalization.CultureInfo("th-TH")));

        lblNationality.Text = string.Concat(CheckupViewModel.Patient.Nationality);
        lblTel.Text = string.Concat(CheckupViewModel.Patient.TelephoneNumber);
        lblPayor.Text = string.Concat(CheckupViewModel.PayorName);
        lblCheckupType.Text = string.Concat(CheckupViewModel.CheckupType.Name);

        txtAddress.Text = string.Concat(CheckupViewModel.Patient.Address);
        ddlProvince.EditValue = string.Concat(CheckupViewModel.Patient.ProvinceId);
        BindDistrictToDDL();
        ddlDistrict.EditValue = string.Concat(CheckupViewModel.Patient.DistrictId);
        BindSubDistrictToDDL();
        ddlSubDistrict.EditValue = string.Concat(CheckupViewModel.Patient.SubDistrictId);

        txtZipCode.Text = string.Concat(CheckupViewModel.Patient.ZipCode);

        lblMedicalHistory.Text = string.Concat(CheckupViewModel.Patient.ChronicDisease);

    }

    private void GetVitalSign()
    {
        if (CheckupViewModel == null)
            return;

        lblWeight.Text = CheckupViewModel.Weight.ToString();
        lblHeight.Text = CheckupViewModel.Height.ToString();
        lblBMI.Text = CheckupViewModel.Bmi.ToString();
        lblTemperature.Text = CheckupViewModel.Temperature.ToString();
        lblPluse.Text = CheckupViewModel.PulseRate?.ToString() ?? "";
        lblRR.Text = CheckupViewModel.RespiratoryRate?.ToString() ?? "";
        lblBP.Text = String.Format("{0}/{1}", CheckupViewModel.SystolicBloodPresure?.ToString() ?? "", CheckupViewModel.DiastolicBloodPresure?.ToString() ?? "");
        //lblRh.Text = CheckupViewModel.Rh
        lblWaist.Text = CheckupViewModel.Waist.ToString();
        lblHips.Text = CheckupViewModel.Hips.ToString();
        optSmoking.EditValue = CheckupViewModel.IsSmoking;
        txtSmokingRemark.Text = CheckupViewModel.SmokingRemark == "ไม่สูบ" || CheckupViewModel.SmokingRemark == "สูบ" ? "" : CheckupViewModel.SmokingRemark;
        optAlcohol.EditValue = CheckupViewModel.IsAlcohol;
        txtAlcoholRemark.Text = CheckupViewModel.AlcoholRemark == "ไม่ดื่ม" || CheckupViewModel.AlcoholRemark == "ดื่ม" ? "" : CheckupViewModel.AlcoholRemark;

        lblMedicalHistory.Text = CheckupViewModel.Patient.ChronicDisease;
        lblDrugAllergy.Text = CheckupViewModel.Patient.DrugAllergy;
        lblBmiText.Text = GetBMICategory(Convert.ToDouble(lblBMI.Text));
        //lblBpText.Text = GetBPCategory(CheckupViewModel.SystolicBloodPresure ?? 0, CheckupViewModel.DiastolicBloodPresure ?? 0);
    }

    private async Task<List<LabXrayStruct>> FilterItemGroup(string labGroup, List<HxpClient.LabViewModel> hxpLabList)
    {
        List<LabXrayStruct> ret = [];
        var itemGroups = await Fn.GetCheckupItemByClassCodeAsync(labGroup, this, _checkupApiClient);
        if (itemGroups == null) return ret;
        var itemGroup = itemGroups.CheckupItems.ToList();

        ret = hxpLabList.Join(
            itemGroup,
            (Hosxp.Api.Client.LabViewModel labList) => labList.LabItemCode.ToString(),
            (CheckupItemViewModel itemGroup) => itemGroup.LabItemCode,
            (labList, itemGroup) => new LabXrayStruct
            {
                ResultItemName = itemGroup.DisplayName,
                ResultValue = labList.ResultValue,
                ReferenceRange = labList.ReferenceRange,
                IsAbnormal = labList.IsAbnormal,
            })
            .ToList(); //ต้องการข้อมูล Lab result เฉพาะ UA และใช้ชื่อ Lab จาก checkupItems ฝั่ง Checkup

        return ret;
    }

    public List<LabXrayStruct> FilterLabByGroup(string labGroup, List<Checkup.Api.Client.LabViewModel> labList)
    {
        if (labGroup == CClass.SpecialTest)
        {
            //ถ้ามี item ใหม่ๆ มาแล้ว error  
            var labSpecialNew = labList.Where(l => l.CheckupItem == null).ToList();
            var labSpecial = labList.Where(l => l.ClassCode == labGroup && l.CheckupItem != null).ToList();

            return labSpecial
        .Concat(labSpecialNew)
        .Select(l => new LabXrayStruct
        {
            ResultItemName = l.CheckupItem != null
                ? l.ItemName
                : l.LabItemNameRef,

            ResultValue = l.ResultValue,
            ReferenceRange = l.ReferenceRange,
            IsAbnormal = l.IsAbnormal,

            Sort = l.CheckupItem?.Sort ?? 0,
            CheckupGroupId = l.CheckupItem?.CheckupGroupId ?? 0
        })
        .OrderBy(l => l.CheckupGroupId)
        .ThenBy(l => l.Sort)
        .ToList();
            
            //    return labSpecial
            //    .Where(l => l.ClassCode == labGroup)
            //    .Select(l => new LabXrayStruct
            //    {
            //        ResultItemName = (l.CheckupItem != null) ? l.ItemName : l.LabItemNameRef,
            //        ResultValue = l.ResultValue,
            //        ReferenceRange = l.ReferenceRange,
            //        IsAbnormal = l.IsAbnormal,
            //        Sort = l.CheckupItem.Sort,
            //        CheckupGroupId = l.CheckupItem.CheckupGroupId
            //    }).OrderBy(l => l.CheckupGroupId).ThenBy(l => l.Sort)
            //    .ToList();
            
        }

        return labList
            .Where(l => l.ClassCode == labGroup)
            .Select(l => new LabXrayStruct
            {
                ResultItemName = l.ItemName,
                ResultValue = l.ResultValue,
                ReferenceRange = l.ReferenceRange,
                IsAbnormal = l.IsAbnormal,
                Sort = l.CheckupItem.Sort,
                CheckupGroupId = l.CheckupItem.CheckupGroupId,
            }).OrderBy(l => l.CheckupGroupId).ThenBy(l => l.Sort)
            .ToList();
    }

    private async Task<List<LabXrayStruct>> FilterItemGroup(string xrayGroup, List<HxpClient.XrayViewModel> hxpXrayList)
    {
        List<LabXrayStruct> ret = [];
        var itemGroups = await Fn.GetCheckupItemByClassCodeAsync(xrayGroup, this, _checkupApiClient);
        if (itemGroups == null) return ret;
        var itemGroup = itemGroups.CheckupItems.ToList();

        ret = hxpXrayList.Join(
            itemGroup,
            (Hosxp.Api.Client.XrayViewModel xrayList) => xrayList.HosxpItemCode.ToString(),
            (CheckupItemViewModel itemGroup) => itemGroup.LabItemCode,
            (xrayList, itemGroup) => new LabXrayStruct
            {
                Code = itemGroup.Code,
                ResultItemName = itemGroup.DisplayName,
                ResultValue = xrayList.ResultValue,
                ReportText = xrayList.ReportText,
                IsAbnormal = xrayList.IsAbnormal,
            })
            .ToList(); //ต้องการข้อมูล Lab result เฉพาะ UA และใช้ชื่อ Lab จาก checkupItems ฝั่ง Checkup

        return ret;
    }
    public List<LabXrayStruct> FilterXrayByGroup(string xrayGroup, List<SUTH.HealthCheckup.WinFormsUI.Checkup.Api.Client.XrayViewModel> xrayList)
    {
        return xrayList
            .Where(l => l.ClassCode == xrayGroup)
            .Select(l => new LabXrayStruct
            {
                ResultItemName = l.ItemName,
                ResultValue = l.ResultValue,
                AccessionNumber = l.AccessionNumber,
                ReportText = l.ReportText,
                IsAbnormal = l.IsAbnormal,
            })
            .ToList();
    }

    private void frmCheckupMain_SizeChanged(object sender, EventArgs e)
    {
        pnDotorConclusion.Width = 600;
        pnMainLab.Width = this.Width - 840;
    }

    private async void LoadPatientImage()
    {
        FileResponse patientImage = null;
        try
        {
            patientImage = await _hosxpApiClient.GetPatientImageAsync(CheckupViewModel.HospitalNumber);
        }
        catch (Exception)
        {
        }

        if (patientImage != null)
        {
            Image imageFromStream = Image.FromStream(patientImage.Stream);
            pictureEdit1.Image = imageFromStream;
        }
    }

    private async void LoadRecommendationTemplate()
    {
        var rcms = await _checkupApiClient.GetRecommendationTemplateListAsync();
        lstRecommendList.DataSource = rcms.RecommendationTemplates.ToList();
        lstRecommendList.DisplayMember = "Text";
        lstRecommendList.ValueMember = "Text";
    }

    private async void GetAudiogram()
    {
        var checkUpOrder = checkupItemListViewModel.CheckupItems.Any(i => i.CheckupGroup.Code == CGroup.Audiogram);
        xtraTabPageAudiogram.PageVisible = checkUpOrder;
        if (checkUpOrder)
        {
            var hearingList = new List<Checkup.Api.Client.HearingViewModel>();
            var audiogram = CheckupViewModel.Audiograms.FirstOrDefault();
            if (audiogram != null)
            {
                ddlEarsRight.EditValue = audiogram.RightResult;
                txtEarsRightRemark.Text = audiogram.RightResult;
                txtEarsLeftRemark.Text = audiogram.LeftResult;
                ddlEarsLeft.EditValue = audiogram.LeftResult;
                txtAudiogramSummary.Text = audiogram.ResultNote;

                var hearingListPage = await _checkupApiClient.GetHearingListByAudigramIdAsync(audiogram.Id, 1, 20);
                hearingList = hearingListPage.Items.ToList();
            }

            var hearingHertzs = await _checkupApiClient.GetHearingHertzListAsync(1, 20);
            var hearingHertzList = hearingHertzs.Items.ToList();


            var hearing = from Hz in hearingHertzList
                          join Hr in hearingList on Hz.Hertz equals Hr.Hertz into resultJoin
                          from Rh in resultJoin.DefaultIfEmpty()
                          select new Master.Hearing
                          {
                              Id = Rh?.Id,
                              Hertz = Hz.Hertz.ToString(),
                              RightHz = Rh?.RightHz.ToString(),
                              LeftHz = Rh?.LeftHz.ToString(),
                          };

            grdHearing.DataSource = hearing;
        }
    }

    private void GetOtherSpecial(List<Checkup.Api.Client.SpecialTestViewModel> specialTest)
    {
        if (checkupItemListViewModel?.CheckupItems != null)
        {
            pnEKG.Visible = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.EKG);
            pnEST.Visible = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.EST);
            pnBMD.Visible = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.BMD);
            pnABI.Visible = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.ABI);
            pnHandGrip.Visible = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.HandGrip);

            //ในที่ประชุมแจ้งว่าไม่ใช้ เลยซ่อนไว้ก่อน ห้ามลบ เผื่อใช้ในอนาคต
            //PapSmear
            //chkVegina.Checked = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.PapSmear);
            //chkVegina.Enabled = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.PapSmear);

            //txtVegina.Enabled = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.PapSmear);
            ////End PapSmear

            ////LiquidBasedPap
            //chkPapSmear.Checked = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.PapSmear);
            //chkPapSmear.Enabled = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.PapSmear);

            //txtPapSmear.Enabled = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.PapSmear);
            //End LiquidBasedPap
            txtVegina.Text = "";
            txtPapSmear.Text = "";
        }

        if (specialTest.Count > 0)
        {
            txtEKGNote.Text = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.EKG)?.ResultReport;
            ddlEKG.EditValue = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.EKG)?.ResultValue;
            txtESTNote.Text = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.EST)?.ResultReport;
            ddlEST.EditValue = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.EST)?.ResultValue;
            txtBMDNote.Text = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.BMD)?.ResultReport;
            ddlBMD.EditValue = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.BMD)?.ResultValue;
            txtABINote.Text = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.ABI)?.ResultReport;
            ddlABI.EditValue = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.ABI)?.ResultValue;
            txtHandGripNote.Text = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.HandGrip)?.ResultReport;
            ddlHandGrip.EditValue = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.HandGrip)?.ResultValue;

            //ในที่ประชุมแจ้งว่าไม่ใช้ เลยซ่อนไว้ก่อน ห้ามลบ เผื่อใช้ในอนาคต
            //txtVegina.Text = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.VaginalExam)?.ResultReport;
            //txtPapSmear.Text = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.PapSmear)?.ResultReport;
        }
    }
    private void GetXray(List<Checkup.Api.Client.XrayViewModel> xrays)
    {
        if (checkupItemListViewModel?.CheckupItems != null)
        {
            pnXray.Visible = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.ChestPA);
            pnMamogram.Visible = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.Mammogram);
            pnAbdomenWhole.Visible = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.UltrasoundWholeAbdomen);
            pnAbdomenUpper.Visible = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.UltrasoundUpperAbdomen);
            pnBreast.Visible = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.UltrasoundBreast);

            ////ChestPA          
            //richX_ChestPA.Enabled = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.ChestPA);
            //btnPAC_PA.Visible = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.ChestPA);
            ////End Chest PA

            ////Mammogram

            //richX_Mammogram.Enabled = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.Mammogram);
            //btnPAC_Mammo.Visible = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.Mammogram);
            ////End Mammogram

            ////UltrasoundWholeAbdomen

            //richX_AbdomenRemark.Enabled = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.UltrasoundWholeAbdomen);
            //btnPAC_Abdomen.Visible = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.UltrasoundWholeAbdomen);
            ////UltrasoundWholeAbdomen

            ////UltrasoundUpperAbdomen

            //richX_UpperAbdomenRemark.Enabled = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.UltrasoundUpperAbdomen);
            //btnPAC_Upper.Visible = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.UltrasoundUpperAbdomen);
            ////End UltrasoundUpperAbdomen

            ////UltrasoundBreast

            //richX_USBreast.Enabled = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.UltrasoundBreast);
            //btnPAC_USBreast.Visible = checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.UltrasoundBreast);
            ////End UltrasoundBreast
        }

        if (xrays.Count > 0)
        {
            // 1. นำข้อมูลจาก specialTest มาแปลงเป็นกลุ่มตาม Code ของแต่ละรายการ โดยตัดค่า null ออกไปก่อน
            var xrayGroups = xrays
                .Where(s => s.CheckupItem?.Code != null)
                .GroupBy(s => s.CheckupItem.Code)
                .ToDictionary(g => g.Key, g => g.FirstOrDefault());

            // 2. ดึงข้อมูลแต่ละตัวออกมาพักไว้ในตัวแปร (ถ้าไม่มีข้อมูลในลิสต์ จะได้ค่า null อัตโนมัติ)
            var chest = xrayGroups.ContainsKey(CheckupItemCode.ChestPA) ? xrayGroups[CheckupItemCode.ChestPA] : null;
            var mammo = xrayGroups.ContainsKey(CheckupItemCode.Mammogram) ? xrayGroups[CheckupItemCode.Mammogram] : null;
            var abdomen = xrayGroups.ContainsKey(CheckupItemCode.UltrasoundWholeAbdomen) ? xrayGroups[CheckupItemCode.UltrasoundWholeAbdomen] : null;
            var upper = xrayGroups.ContainsKey(CheckupItemCode.UltrasoundUpperAbdomen) ? xrayGroups[CheckupItemCode.UltrasoundUpperAbdomen] : null;
            var breast = xrayGroups.ContainsKey(CheckupItemCode.UltrasoundBreast) ? xrayGroups[CheckupItemCode.UltrasoundBreast] : null;
            var echo = xrayGroups.ContainsKey(CheckupItemCode.Echo) ? xrayGroups[CheckupItemCode.Echo] : null;

            // 3. นำค่าที่ได้ไปผูกกับหน้าจอ (Controls)

            // Chest PA
            richX_ChestPA.Rtf = chest?.ReportText;
            ddlX_ChestPA.EditValue = chest?.IsAbnormal != null
    ? XrayResult.All.FirstOrDefault(x => x.AbnormalFlag == chest.IsAbnormal)?.Value
    : null;
            btnPAC_PA.Tag = chest?.AccessionNumber;

            // Mammogram
            richX_Mammogram.Rtf = mammo?.ReportText;
            ddlX_Mammogram.EditValue = mammo?.IsAbnormal != null
    ? XrayResult.All.FirstOrDefault(x => x.AbnormalFlag == mammo.IsAbnormal)?.Value
    : null;
            btnPAC_Mammo.Tag = mammo?.AccessionNumber;

            // Ultrasound Whole Abdomen
            richX_AbdomenRemark.Rtf = abdomen?.ReportText;
            ddlX_Abdomen.EditValue = abdomen?.IsAbnormal != null
    ? XrayResult.All.FirstOrDefault(x => x.AbnormalFlag == abdomen.IsAbnormal)?.Value
    : null;
            btnPAC_Abdomen.Tag = abdomen?.AccessionNumber;

            // Ultrasound Upper Abdomen
            richX_UpperAbdomenRemark.Rtf = upper?.ReportText;
            ddlX_UpperAbdomen.EditValue = upper?.IsAbnormal != null
    ? XrayResult.All.FirstOrDefault(x => x.AbnormalFlag == upper.IsAbnormal)?.Value
    : null;
            btnPAC_Upper.Tag = upper?.AccessionNumber;

            // Ultrasound Breast
            richX_USBreast.Rtf = breast?.ReportText;
            ddlX_USBreast.EditValue = breast?.IsAbnormal != null
    ? XrayResult.All.FirstOrDefault(x => x.AbnormalFlag == breast.IsAbnormal)?.Value
    : null;
            btnPAC_USBreast.Tag = breast?.AccessionNumber;

            //        // Echo ไม่มีตรวจแล้ว Checkup แจ้ง
            //        richX_EchoRemark.Rtf = echo?.ReportText;
            //        ddlX_Echo.EditValue = echo?.IsAbnormal != null
            //? XrayResult.All.FirstOrDefault(x => x.AbnormalFlag == echo.IsAbnormal)?.Value
            //: null;
            //        btnPAC_Echo.Tag = echo?.AccessionNumber;

            //richX_ChestPA.Rtf = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.ChestPA)?.ReportText;
            //richX_Mammogram.Rtf = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.Mammogram)?.ReportText;
            //richX_AbdomenRemark.Rtf = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.UltrasoundWholeAbdomen)?.ReportText;
            //richX_UpperAbdomenRemark.Rtf = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.UltrasoundUpperAbdomen)?.ReportText;
            //richX_USBreast.Rtf = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.UltrasoundBreast)?.ReportText;
            //richX_EchoRemark.Rtf = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.Echo)?.ReportText;

            //ddlX_ChestPA.EditValue = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.ChestPA)?.ResultValue;
            //ddlX_Mammogram.EditValue = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.Mammogram)?.ResultValue;
            //ddlX_Abdomen.EditValue = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.UltrasoundWholeAbdomen)?.ResultValue;
            //ddlX_UpperAbdomen.EditValue = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.UltrasoundUpperAbdomen)?.ResultValue;
            //ddlX_USBreast.EditValue = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.UltrasoundBreast)?.ResultValue;
            //ddlX_Echo.EditValue = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.Echo)?.ResultValue;

            //btnPAC_PA.Tag = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.ChestPA)?.AccessionNumber;
            //btnPAC_Mammo.Tag = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.Mammogram)?.AccessionNumber;
            //btnPAC_Abdomen.Tag = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.UltrasoundWholeAbdomen)?.AccessionNumber;
            //btnPAC_Upper.Tag = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.UltrasoundUpperAbdomen)?.AccessionNumber;
            //btnPAC_USBreast.Tag = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.UltrasoundBreast)?.AccessionNumber;
            //btnPAC_Echo.Tag = specialTest.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.Echo)?.AccessionNumber;

            var buttons = new[] { btnPAC_PA, btnPAC_Mammo, btnPAC_Abdomen, btnPAC_Upper, btnPAC_USBreast, btnPAC_Echo };
            foreach (var btn in buttons)
            {
                btn.Visible = !string.IsNullOrEmpty(btn.Tag?.ToString());
            }
            // if (btnPAC_PA.AccessibleName != null)
            //{
            //    btnPAC_PA.Visible = true;
            //}
        }
    }
    private void GetLab()
    {

        if (checkupItemListViewModel != null)
        {
            xtraTabPageUA.PageVisible = checkupItemListViewModel.CheckupItems.Any(c => c.CheckupGroup.CheckupClass.Code == CClass.UrineAnalysis);
            xtraTabPageCBC.PageVisible = checkupItemListViewModel.CheckupItems.Any(c => c.CheckupGroup.CheckupClass.Code == CClass.CBC);
            xtraTabPageBloodChem.PageVisible = checkupItemListViewModel.CheckupItems.Any(c => c.CheckupGroup.CheckupClass.Code == CClass.BloodChemistry);
            xtraTabPageStoolExam.PageVisible = checkupItemListViewModel.CheckupItems.Any(c => c.CheckupGroup.CheckupClass.Code == CClass.StoolExamination);
            xtraTabPageStoolCulture.PageVisible = checkupItemListViewModel.CheckupItems.Any(c => c.CheckupGroup.CheckupClass.Code == CClass.StoolCulture);
            xtraTabPageSpecial.PageVisible = checkupItemListViewModel.CheckupItems.Any(c => c.CheckupGroup.CheckupClass.Code == CClass.SpecialTest);
            xtraTabPageOther.PageVisible = checkupItemListViewModel.CheckupItems.Any(c => c.CheckupGroup.CheckupClass.Code == CClass.OtherTest);
            xtraTabPageConfidential.PageVisible = checkupItemListViewModel.CheckupItems.Any(c => c.CheckupGroup.CheckupClass.Code == CClass.Confidential);
        }
        else
        {

            xtraTabPageUA.PageVisible = false;
            xtraTabPageCBC.PageVisible = true;
            xtraTabPageBloodChem.PageVisible = true;
            xtraTabPageStoolExam.PageVisible = true;
            xtraTabPageStoolCulture.PageVisible = true;
            xtraTabPageSpecial.PageVisible = true;
            xtraTabPageConfidential.PageVisible = true;
        }


        var labList = CheckupViewModel.Labs.ToList();
        gridUrine.DataSource = FilterLabByGroup(CClass.UrineAnalysis, labList);
        grdCBC.DataSource = FilterLabByGroup(CClass.CBC, labList);
        gridBloodChemistry.DataSource = FilterLabByGroup(CClass.BloodChemistry, labList);
        gridStool.DataSource = FilterLabByGroup(CClass.StoolExamination, labList);
        gridStoolCulture.DataSource = FilterLabByGroup(CClass.StoolCulture, labList);
        grdSpecialTest.DataSource = FilterLabByGroup(CClass.SpecialTest, labList);
        grdConfidential.DataSource = FilterLabByGroup(CClass.Confidential, labList);
    }
    private void GetConfidential(List<Checkup.Api.Client.LabViewModel> labs)
    {
        if (labs.Count > 0)
        {
            ddlAmphetamine.EditValue = labs.FirstOrDefault(s => s.CheckupItem?.Code == CheckupItemCode.Amphetamine)?.ResultValue;
        }
    }

    private void gridViewCBC_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
    {
        if (e.RowHandle >= 0 && e.Column == gridViewCBC.Columns[1])
        {
            var value = gridViewCBC.GetRowCellValue(e.RowHandle, gridViewCBC.Columns[4]);
            if (value != null && value.ToString().Trim() == "Y")
            {
                e.Appearance.ForeColor = System.Drawing.ColorTranslator.FromHtml("#cc0000");
            }
        }
    }

    private void gridViewBloodChemistry_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
    {
        if (e.RowHandle >= 0 && e.Column == gridViewBloodChemistry.Columns[1])
        {
            var value = gridViewBloodChemistry.GetRowCellValue(e.RowHandle, gridViewBloodChemistry.Columns[4]);
            if (value != null && value.ToString().Trim() == "Y")
            {
                e.Appearance.ForeColor = System.Drawing.ColorTranslator.FromHtml("#cc0000");
            }
        }
    }

    private void gridViewUrine_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
    {
        if (e.RowHandle >= 0 && e.Column == gridViewUrine.Columns[1])
        {
            var value = gridViewUrine.GetRowCellValue(e.RowHandle, gridViewUrine.Columns[4]);
            if (value != null && value.ToString().Trim() == "Y")
            {
                e.Appearance.ForeColor = System.Drawing.ColorTranslator.FromHtml("#cc0000");
            }
        }
    }

    private void gridViewStool_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
    {
        if (e.RowHandle >= 0 && e.Column == gridViewStool.Columns[1])
        {
            var value = gridViewStool.GetRowCellValue(e.RowHandle, gridViewStool.Columns[4]);
            if (value != null && value.ToString().Trim() == "Y")
            {
                e.Appearance.ForeColor = System.Drawing.ColorTranslator.FromHtml("#cc0000");
            }
        }
    }

    private void gridViewStoolCulture_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
    {
        if (e.RowHandle >= 0 && e.Column == gridViewStoolCulture.Columns[1])
        {
            var value = gridViewStoolCulture.GetRowCellValue(e.RowHandle, gridViewStoolCulture.Columns[4]);
            if (value != null && value.ToString().Trim() == "Y")
            {
                e.Appearance.ForeColor = System.Drawing.ColorTranslator.FromHtml("#cc0000");
            }
        }
    }

    private void grdViewSpecialTest_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
    {
        if (e.RowHandle >= 0 && e.Column == grdViewSpecialTest.Columns[1])
        {
            var value = grdViewSpecialTest.GetRowCellValue(e.RowHandle, grdViewSpecialTest.Columns[4]);
            if (value != null && value.ToString().Trim() == "Y")
            {
                e.Appearance.ForeColor = System.Drawing.ColorTranslator.FromHtml("#cc0000");
            }
        }
    }

    private void grdViewConfidential_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
    {
        if (e.RowHandle >= 0 && e.Column == grdViewConfidential.Columns[1])
        {
            var value = grdViewConfidential.GetRowCellValue(e.RowHandle, grdViewConfidential.Columns[4]);
            if (value != null && value.ToString().Trim() == "Y")
            {
                e.Appearance.ForeColor = System.Drawing.ColorTranslator.FromHtml("#cc0000");
            }
        }
    }

    private void lstRecommendList_DoubleClick(object sender, EventArgs e)
    {

        txtDoctorRecommend.Text += Vb.Constants.vbCrLf + string.Concat(lstRecommendList.SelectedValue);
    }

    private void lstRecommendList_SelectedValueChanged(object sender, EventArgs e)
    {
        if (lstRecommendList.SelectedValue != null)
        {
            HighlightDoctorSuggestionText(lstRecommendList.SelectedValue.ToString());
        }
    }
    private void HighlightDoctorSuggestionText(string sSearch)
    {
        int startSelect, endSelect;
        startSelect = 0;
        endSelect = 0;
        txtDoctorRecommend.DeselectAll();
        startSelect = txtDoctorRecommend.Text.IndexOf(sSearch);
        endSelect = sSearch.Length;
        if (startSelect >= 0) txtDoctorRecommend.Select(startSelect, endSelect);
    }

    private void txtSearchRecommendation_KeyDown(object sender, KeyEventArgs e)
    {

        if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter)
        {
            if (txtSearchRecommendation.Text.Length >= 3)
            {
                HighlightDoctorSuggestionText(txtSearchRecommendation.Text);
            }
        }
    }

    private void cmdClose_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    public async Task SaveVisionAsync()
    {
        if (checkupItemListViewModel.CheckupItems.Any(c => c.CheckupGroup.Code == CGroup.VisionScreening))
        {
            //_ = int.TryParse(txtVS_PressureLeft.Text, out int eyeballLeft);
            //_ = int.TryParse(txtVS_PressureRight.Text, out int eyeballRight);
            //int? pressureLeft = (eyeballLeft == 0) ? null : eyeballLeft;
            //int? pressureRight = (eyeballRight == 0) ? null : eyeballRight;

            if (optVisionLeftResult.EditValue == null || optVisionRightResult.EditValue == null)
            {                
                _eyeMessage = "- ผลการตรวจสายตา \n\r";
                return;
            }


            string retinaLeft, retinaRight;
            if (chkRetinaWait.Checked == true)
            {
                retinaLeft = "รอจักษุแพทย์อ่านผล";
                retinaRight = "รอจักษุแพทย์อ่านผล";
            }
            else
            {
                retinaLeft = txtVS_RetinaLeft.Text;
                retinaRight = txtVS_RetinaRight.Text;
            }

            var command = new UpsertVisionCommand
            {
                VisitNumber = _visitNumber,
                CheckupId = _checkupId,
                CheckupClassCode = CClass.VisionScreening,
                ColorBlind = optVS_ColorBlind.EditValue?.ToString(),
                //PH_Left_Result = ddlPH_VisibilityLeft.EditValue?.ToString(),
                PH_Left_Value = txtPH_VisibilityLeft.Text,
                //PH_Right_Result = ddlPH_VisibilityRight.EditValue?.ToString(),
                PH_Right_Value = txtPH_VisibilityRight.Text,
                PressureLeft = txtVS_PressureLeft.Text,
                PressureRight = txtVS_PressureRight.Text,
                //ResultNote = "ทดสอบ",//รอถาม
                RetinaLeft = retinaLeft,
                RetinaRight = retinaLeft,
                Squint = optVS_Squint.EditValue?.ToString(),
                //VA_Left_Result = ddlVS_VisibilityLeft.EditValue?.ToString(),
                VA_Left_Value = txtVS_VisibilityLeft.Text,
                //VA_Right_Result = ddlVS_VisibilityRight.EditValue?.ToString(),
                VA_Right_Value = txtVS_VisibilityRight.Text,
                Vision3D = optVS_3D.EditValue?.ToString(),
                VisionLeftResult = optVisionLeftResult.EditValue?.ToString(),
                VisionRightResult = optVisionRightResult.EditValue?.ToString(),
                VisualField = optVS_VisualField.EditValue?.ToString(),
            };

            await Fn.UpsertVisionAsync(this, _checkupApiClient, command);
        }
    }

    private async Task SaveAudiogram()
    {
        if (checkupItemListViewModel.CheckupItems.Any(c => c.CheckupGroup.Code == CGroup.Audiogram))
        {
            if (ddlEarsRight.EditValue.ToString() == "" && ddlEarsLeft.EditValue.ToString() == "")
            {               
                _audiogramMessage = "- ผลการตรวจการได้ยิน \n\r";
                return;

                //MessageBox.Show(this, "กรุณาระบุตัวเลือกตรวจ Audiograms", "โปรดระบุ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //ถ้าไม่ลงผลก็ไม่บันทึก ให้ผ่านไปเลย
            }

            try
            {
                var audiogram = CheckupViewModel.Audiograms.FirstOrDefault();
                var items = await Fn.GetCheckupItemByClassCodeAsync(CClass.Audiogram, this, _checkupApiClient);
                var checkupItems = items.CheckupItems.ToList();

                if (audiogram == null) //ถ้าไม่มีให้ทำการ Create
                {
                    var audiogramCreate = new CreateAudiogramCommand()
                    {
                        CheckupId = _checkupId,
                        CheckupItemId = checkupItems.Select(c => c.Id).FirstOrDefault(),
                        VisitNumber = _visitNumber,
                        LeftNote = txtEarsLeftRemark.Text,
                        RightNote = txtEarsRightRemark.Text,
                        LeftResult = ddlEarsLeft.EditValue.ToString(),
                        RightResult = ddlEarsRight.EditValue.ToString(),
                        ResultNote = txtAudiogramSummary.Text
                        //String.Format("{0},{1}", txtEarsRightRemark.Text, txtEarsLeftRemark.Text)
                    };

                    var audiogramId = await _checkupApiClient.CreateAudiogramAsync(audiogramCreate);

                    //var hearingHertzs = (List<SUTH.Checkup.Api.Client.HearingViewModel>) grdHearing.DataSource;
                    //CreateHearingListCommand  hearingHertzList = new ();
                    var hearingHertzs = new List<CreateHearingCommand>();

                    for (int i = 0; i < gridViewHearing.DataRowCount; i++)
                    {
                        var hearingHertz = new CreateHearingCommand()
                        {
                            AudiogramId = audiogramId,
                            Hertz = int.Parse(gridViewHearing.GetRowCellValue(i, "Hertz")?.ToString()),
                            LeftHz = double.Parse(gridViewHearing.GetRowCellValue(i, "LeftHz")?.ToString() ?? "0"),
                            RightHz = double.Parse(gridViewHearing.GetRowCellValue(i, "RightHz")?.ToString() ?? "0"),
                        };
                        hearingHertzs.Add(hearingHertz);
                    }

                    var hearingHertzList = new CreateHearingListCommand
                    {
                        CreateHearingCommand = hearingHertzs
                    };

                    await _checkupApiClient.CreateHearingListAsync(hearingHertzList);
                }

                else
                {

                    var audiogramUpdate = new UpdateAudiogramCommand()
                    {
                        Id = audiogram.Id,
                        CheckupId = CheckupViewModel.Id,
                        LeftNote = txtEarsLeftRemark.Text,
                        RightNote = txtEarsRightRemark.Text,
                        LeftResult = ddlEarsLeft.EditValue.ToString(),
                        RightResult = ddlEarsRight.EditValue.ToString(),
                        ResultNote = txtAudiogramSummary.Text // String.Format("{0},{1}", txtEarsRightRemark.Text, txtEarsLeftRemark.Text)
                    };
                    var hearingHertzs = new List<UpdateHearingCommand>();

                    for (int i = 0; i < gridViewHearing.DataRowCount; i++)
                    {
                        var hearingHertz = new UpdateHearingCommand()
                        {
                            Id = int.Parse(gridViewHearing.GetRowCellValue(i, "Id")?.ToString()),
                            Hertz = int.Parse(gridViewHearing.GetRowCellValue(i, "Hertz")?.ToString()),
                            LeftHz = double.Parse(gridViewHearing.GetRowCellValue(i, "LeftHz")?.ToString() ?? "0"),
                            RightHz = double.Parse(gridViewHearing.GetRowCellValue(i, "RightHz")?.ToString() ?? "0"),
                        };
                        hearingHertzs.Add(hearingHertz);
                    }
                    audiogramUpdate.HearingUpdateCommand = hearingHertzs;
                    await _checkupApiClient.UpdateAudiogramAsync(audiogram.Id, audiogramUpdate);

                }

            }
            catch (ApiClientException<ValidationProblemDetails> ex)
            {
                string message = Fn.GetValidationErrorMessage(ex);
                MessageBox.Show(this, message, "CreateHearing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ApiClientException<ProblemDetails> ex)
            {
                string message = Fn.GetProblemErrorMessage(ex);
                MessageBox.Show(this, message, "GetCheckupItemGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (SUTH.HealthCheckup.WinFormsUI.Hosxp.Api.Client.ApiClientException ex)
            {
                MessageBox.Show(this, ex.Message, "GetCheckupItemGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "GetCheckupItemGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private  void BtnTempSave_Click(object sender, EventArgs e)
    {
        SaveCheckupData();
    }

    private  async void BtnFinalizeSave_Click(object sender, EventArgs e)
    {    
        var confirmMessage = CheckupViewModel.IsFinalized
            ? "ต้องการยกเลิกสถานะ Finalized ใช่หรือไม่?"
            : "ต้องการเปลี่ยนสถานะเป็น Finalized ใช่หรือไม่?";

        var confirmResult = MessageBox.Show(this, confirmMessage, "ยืนยันการเปลี่ยนสถานะ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (confirmResult == DialogResult.No)
        {
            return;
        }

        var finalStatus = false;
        //ปุ่ม finalize ถ้าสถานะปกติ จะเห็นแค่ หมอ กับ admin แต่่ถ้า final แล้วจะเห็นแค่ admin ที่มีสิทธิ์เปิดกลับมาให้แก้ไขได้อีก
        if (CheckupViewModel.IsFinalized) //ถ้าสถานะปัจจุบันคือ Finalized แล้วให้แก้กลับมาเป็น ปกติ  โดย admin เท่านั้นที่จะเห็นปุ่มนี้
        {
            finalStatus = false;
            BtnFinalizeSave.Text = "Finalize";
        }
        else
        {          
            finalStatus = true;
            BtnFinalizeSave.Text = "Unfinalize";
        }

        var command = new UpdateFinalizeStatusCommand
            {
                VisitNumber = lblVisitNo.Text,
                Finalized = finalStatus,                
            };
       
        await _checkupApiClient.UpdateFinalizeStatusAsync(command);
               
    }

    private async void SaveCheckupData()
    {
        _alertMessage = "";
        _audiogramMessage = "";
        _dentalMessage = "";
        _eyeMessage = "";
        _lungMessage = "";
        _otherMessage = "";
        _xrayMessage = "";
        _checkupMessage = "";
        _isCompleteData = true;
        await SavePatientAddressAsync();
        await SaveCheckupResult();

        var user = _userContext.CurrentUser;
        var message = "";
        if (user.HasDoctorRole || user.HasAdminRole || user.IsBeCheckupGroup)
        {
            _alertMessage = _checkupMessage + _lungMessage + _eyeMessage + _xrayMessage + _audiogramMessage + _dentalMessage + _otherMessage;

            if (!_isCompleteData)
            {
                _isCompleteData = true; 
                message = "ท่านยังไม่ได้บันทึกผลการตรวจ \n\r" + _alertMessage;
                SuthFunctions.Message.Warning(message);
                //MessageBox.Show(this, message, "บันทึกข้อมูลไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
        }
        else if (user.HasDentistRole && !string.IsNullOrEmpty(_dentalMessage))
        {
            message = "ท่านยังไม่ได้บันทึกผลการตรวจ \n\r" + _dentalMessage;
            SuthFunctions.Message.Warning(message);
            //MessageBox.Show(this, message, "บันทึกข้อมูลไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (user.HasDentistRole)
        { 
            SuthFunctions.Message.Success("บันทึกข้อมูลสำเร็จ"); 
            //MessageBox.Show(this, "บันทึกข้อมูลสำเร็จ", "บันทึกข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var command = BuildCheckupDataForUpdate();
        await UpdateCheckup(command);
        await SaveReport();
    } 
    private async Task SaveCheckupResult()
    {
        if (string.IsNullOrEmpty(ddlCheckupType.EditValue?.ToString()))
        {
            _isCompleteData = false;
            _checkupMessage += "- ประเภทการตรวจ \n\r";
        }      

        await SaveVisionAsync();
        await SavePhysicalExamAsync();
        await SaveLungAsync();
        await SaveBodyCompositionAsync();
        await SaveDentalAsync();     
        await SaveXrayTab();
        await SaveOtherSpecial();
        await SaveAudiogram();
        await SaveConfidential();

   //_otherItemGroups = await Fn.GetCheckupItemByClassCodeAsync(CClass.OtherTest, this, _checkupApiClient);
        //await SaveGridviewLab();

        //var checkupStatus = int.Parse(Domain.Enums.CheckupStatus.Pending.Value);
        //var user = _userContext.CurrentUser;

        //if (user.HasDoctorRole)
        //{
        //    if (!_isCompleteData)
        //    {
        //        _isCompleteData = true;
        //        checkupStatus = int.Parse(Domain.Enums.CheckupStatus.Pending.Value);
        //        var message = "ท่านยังไม่ได้บันทึกผลการตรวจ \n\r" + _alertMessage;
        //        MessageBox.Show(this, message, "บันทึกข้อมูลไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    else
        //    {
        //        checkupStatus = int.Parse(Domain.Enums.CheckupStatus.InProgress.Value);
        //    }
        //}
        //else
        //{
        //    checkupStatus = int.Parse(Domain.Enums.CheckupStatus.Pending.Value);
        //}
        //_isCompleteData = true;
        //var command = BuildCheckupDataForUpdate(checkupStatus,false);
        //await UpdateCheckup(command);
    }

    public async Task SaveGridviewLab()
    {
        var updatCreateList = new List<CreateLabCommand>();
        for (int i = 0; i < gridViewUrine.DataRowCount; i++)
        {
            updatCreateList.Add(new CreateLabCommand
            {
                CheckupId = CheckupViewModel.Id,
                Comments = gridViewUrine.GetRowCellValue(i, "Comment")?.ToString(),
                IsAbnormal = gridViewUrine.GetRowCellValue(i, "IsAbnormal")?.ToString(),
                LabItemCode = gridViewUrine.GetRowCellValue(i, "LabItemCode")?.ToString(),
                ReferenceRange = gridViewUrine.GetRowCellValue(i, "ReferenceRange")?.ToString(),
                ResultDate = DateTime.Now,
                ResultTime = DateTime.Now.TimeOfDay,
                ResultValue = gridViewUrine.GetRowCellValue(i, "ResultValue")?.ToString(),
                VisitNumber = CheckupViewModel.VisitNumber,
            });
        }

        for (int i = 0; i < gridViewCBC.DataRowCount; i++)
        {
            updatCreateList.Add(new CreateLabCommand
            {
                CheckupId = CheckupViewModel.Id,
                Comments = gridViewCBC.GetRowCellValue(i, "Comment")?.ToString(),
                IsAbnormal = gridViewCBC.GetRowCellValue(i, "IsAbnormal")?.ToString(),
                LabItemCode = gridViewCBC.GetRowCellValue(i, "LabItemCode")?.ToString(),
                ReferenceRange = gridViewCBC.GetRowCellValue(i, "ReferenceRange")?.ToString(),
                ResultDate = DateTime.Now,
                ResultTime = DateTime.Now.TimeOfDay,
                ResultValue = gridViewCBC.GetRowCellValue(i, "ResultValue")?.ToString(),
                VisitNumber = CheckupViewModel.VisitNumber,
            });
        }

        string sAbNormal, sDoctorResult;
        sAbNormal = "";
        sDoctorResult = "";

        for (int i = 0; i < gridViewBloodChemistry.DataRowCount; i++)
        {

            sAbNormal = gridViewBloodChemistry.GetRowCellValue(i, "IsAbnormal").ToString(); //มาจาก Database 
            sDoctorResult = gridViewBloodChemistry.GetRowCellValue(i, "DoctorResult").ToString(); //มาจากแพทย์ลงผล

            if (sDoctorResult == ExamResult.Abnormal.Value) //ถ้าหมอลงว่าผิดปกติ
            {
                if (sAbNormal == "N" || sAbNormal == "-" || sAbNormal == "") //แต่ผลจาก HIS ปกติ
                {
                    sDoctorResult = "Y";
                }
                else //ถ้าผลจาก HIS ไม่ปกติ ให้คงค่าเดิมไว้
                {
                    sDoctorResult = sAbNormal;
                }
            }
            else //ถ้าหมอลงว่าปกติ ก็ลงผลว่าปกติเลย
            {
                sDoctorResult = "N";
            }

            updatCreateList.Add(new CreateLabCommand
            {
                CheckupId = CheckupViewModel.Id,
                Comments = gridViewBloodChemistry.GetRowCellValue(i, "Comment")?.ToString(),
                LabItemCode = gridViewBloodChemistry.GetRowCellValue(i, "LabItemCode")?.ToString(),
                ReferenceRange = gridViewBloodChemistry.GetRowCellValue(i, "ReferenceRange")?.ToString(),
                ResultDate = DateTime.Now,
                ResultTime = DateTime.Now.TimeOfDay,
                ResultValue = gridViewBloodChemistry.GetRowCellValue(i, "ResultValue")?.ToString(),
                VisitNumber = CheckupViewModel.VisitNumber,
                IsAbnormal = sDoctorResult,
            });
        }

        for (int i = 0; i < gridViewStool.DataRowCount; i++)
        {
            updatCreateList.Add(new CreateLabCommand
            {
                CheckupId = CheckupViewModel.Id,
                Comments = gridViewStool.GetRowCellValue(i, "Comment")?.ToString(),
                IsAbnormal = gridViewStool.GetRowCellValue(i, "IsAbnormal")?.ToString(),
                LabItemCode = gridViewStool.GetRowCellValue(i, "LabItemCode")?.ToString(),
                ReferenceRange = gridViewStool.GetRowCellValue(i, "ReferenceRange")?.ToString(),
                ResultDate = DateTime.Now,
                ResultTime = DateTime.Now.TimeOfDay,
                ResultValue = gridViewStool.GetRowCellValue(i, "ResultValue")?.ToString(),
                VisitNumber = CheckupViewModel.VisitNumber,
            });
        }

        for (int i = 0; i < gridViewStoolCulture.DataRowCount; i++)
        {
            updatCreateList.Add(new CreateLabCommand
            {
                CheckupId = CheckupViewModel.Id,
                Comments = gridViewStoolCulture.GetRowCellValue(i, "Comment")?.ToString(),
                IsAbnormal = gridViewStoolCulture.GetRowCellValue(i, "IsAbnormal")?.ToString(),
                LabItemCode = gridViewStoolCulture.GetRowCellValue(i, "LabItemCode")?.ToString(),
                ReferenceRange = gridViewStoolCulture.GetRowCellValue(i, "ReferenceRange")?.ToString(),
                ResultDate = DateTime.Now,
                ResultTime = DateTime.Now.TimeOfDay,
                ResultValue = gridViewStoolCulture.GetRowCellValue(i, "ResultValue")?.ToString(),
                VisitNumber = CheckupViewModel.VisitNumber,
            });
        }

        for (int i = 0; i < grdViewSpecialTest.DataRowCount; i++)
        {
            updatCreateList.Add(new CreateLabCommand
            {
                CheckupId = CheckupViewModel.Id,
                Comments = grdViewSpecialTest.GetRowCellValue(i, "Comment")?.ToString(),
                IsAbnormal = grdViewSpecialTest.GetRowCellValue(i, "IsAbnormal")?.ToString(),
                LabItemCode = grdViewSpecialTest.GetRowCellValue(i, "LabItemCode")?.ToString(),
                ReferenceRange = grdViewSpecialTest.GetRowCellValue(i, "ReferenceRange")?.ToString(),
                ResultDate = DateTime.Now,
                ResultTime = DateTime.Now.TimeOfDay,
                ResultValue = grdViewSpecialTest.GetRowCellValue(i, "ResultValue")?.ToString(),
                VisitNumber = CheckupViewModel.VisitNumber,
            });
        }

        for (int i = 0; i < grdViewConfidential.DataRowCount; i++)
        {
            updatCreateList.Add(new CreateLabCommand
            {
                CheckupId = CheckupViewModel.Id,
                Comments = grdViewConfidential.GetRowCellValue(i, "Comment")?.ToString(),
                IsAbnormal = grdViewConfidential.GetRowCellValue(i, "IsAbnormal")?.ToString(),
                LabItemCode = grdViewConfidential.GetRowCellValue(i, "LabItemCode")?.ToString(),
                ReferenceRange = grdViewConfidential.GetRowCellValue(i, "ReferenceRange")?.ToString(),
                ResultDate = DateTime.Now,
                ResultTime = DateTime.Now.TimeOfDay,
                ResultValue = grdViewConfidential.GetRowCellValue(i, "ResultValue")?.ToString(),
                VisitNumber = CheckupViewModel.VisitNumber,
            });
        }


        var command = new UpdateCreateLabListCommand { UpdateCreateList = updatCreateList };
        await Fn.UpdateCreateLabListAsync(this, _checkupApiClient, command);
    }

    public async Task SaveXrayTab()
    {
        var checkupViewModelXrays = CheckupViewModel?.Xrays.ToList() ?? [];
        var xrayItemGroups = await Fn.GetCheckupItemByClassCodeAsync(CClass.Xray, this, _checkupApiClient);
        if (xrayItemGroups != null)
        {
            var updateXrayList = new List<UpdateXrayCommand>();
            var createXrayList = new List<CreateXrayCommand>();

            var chestPACheckupItem = xrayItemGroups.CheckupItems.FirstOrDefault(s => s.Code == CheckupItemCode.ChestPA);
            if (chestPACheckupItem != null && checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.ChestPA))
            {

                if (string.IsNullOrEmpty(ddlX_ChestPA.EditValue?.ToString()))
                {
                    //ไม่ได้ลงผล
                    _isCompleteData = false;
                    _xrayMessage += "- ผลการตรวจ Chest PA \n\r";
                }
                else
                {

                    if (checkupViewModelXrays.Any(c => c.CheckupItemId == chestPACheckupItem.Id))
                    {
                        updateXrayList.Add(
                            new UpdateXrayCommand
                            {
                                Id = checkupViewModelXrays.First(c => c.CheckupItemId == chestPACheckupItem.Id).Id,
                                CheckupId = CheckupViewModel.Id,
                                CheckupItemId = chestPACheckupItem.Id,
                                IsAbnormal = string.IsNullOrWhiteSpace(ddlX_ChestPA.EditValue?.ToString()) ? null : XrayResult.FromValue(ddlX_ChestPA.EditValue.ToString()).AbnormalFlag,
                                //ReportText = richX_ChestPA.Rtf,
                                ResultReport = richX_ChestPA.Text,
                                ResultValue = ddlX_ChestPA.EditValue?.ToString(),
                                //VisitNumber = CheckupViewModel.VisitNumber,
                                //AccessionNumber = "AccessionNumber"
                            }
                        );
                    }
                    else
                    {
                        createXrayList.Add(
                            new CreateXrayCommand
                            {
                                CheckupId = CheckupViewModel.Id,
                                CheckupItemId = chestPACheckupItem.Id,
                                IsAbnormal = string.IsNullOrWhiteSpace(ddlX_ChestPA.EditValue?.ToString()) ? null : XrayResult.FromValue(ddlX_ChestPA.EditValue.ToString()).AbnormalFlag,
                                ReportText = string.Empty,
                                ResultReport = richX_ChestPA.Text,
                                ResultValue = ddlX_ChestPA.EditValue?.ToString(),
                                VisitNumber = CheckupViewModel.VisitNumber,
                                AccessionNumber = string.Empty
                            }
                        );
                    }
                }
            }

            var uWholeAbdomenItem = xrayItemGroups.CheckupItems.FirstOrDefault(s => s.Code == CheckupItemCode.UltrasoundWholeAbdomen);
            if (uWholeAbdomenItem != null && checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.UltrasoundWholeAbdomen))
            {
                if (string.IsNullOrEmpty(ddlX_Abdomen.EditValue?.ToString()))
                {
                    //ไม่ได้ลงผล
                    //_isCompleteData = false;
                    //_alertMessage += "- ผลการตรวจ Abdomen \n\r";
                }
                else
                {

                    if (checkupViewModelXrays.Any(c => c.CheckupItemId == uWholeAbdomenItem.Id))
                    {
                        updateXrayList.Add(
                            new UpdateXrayCommand
                            {
                                CheckupId = CheckupViewModel.Id,
                                CheckupItemId = uWholeAbdomenItem.Id,
                                IsAbnormal = string.IsNullOrWhiteSpace(ddlX_Abdomen.EditValue?.ToString()) ? null : XrayResult.FromValue(ddlX_Abdomen.EditValue.ToString()).AbnormalFlag,
                                //ReportText = richX_AbdomenRemark.Rtf,
                                ResultReport = richX_AbdomenRemark.Text,
                                ResultValue = ddlX_Abdomen.EditValue?.ToString(),
                                //VisitNumber = CheckupViewModel.VisitNumber,
                                //AccessionNumber = "AccessionNumber"
                            }
                        );
                    }
                    else
                    {
                        createXrayList.Add(
                            new CreateXrayCommand
                            {
                                CheckupId = CheckupViewModel.Id,
                                CheckupItemId = uWholeAbdomenItem.Id,
                                IsAbnormal = string.IsNullOrWhiteSpace(ddlX_Abdomen.EditValue?.ToString()) ? null : XrayResult.FromValue(ddlX_Abdomen.EditValue.ToString()).AbnormalFlag,
                                ReportText = string.Empty,
                                ResultReport = richX_AbdomenRemark.Text,
                                ResultValue = ddlX_Abdomen.EditValue?.ToString(),
                                VisitNumber = CheckupViewModel.VisitNumber,
                                AccessionNumber = string.Empty
                            }
                        );
                    }
                }
            }

            //var echoItem = xrayItemGroups.CheckupItems.FirstOrDefault(s => s.Code == CheckupItemCode.Echo);
            //if (echoItem != null && checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.Echo))
            //{
            //    if (checkupViewModelXrays.Any(c => c.CheckupItemId == echoItem.Id))
            //    {
            //        updateXrayList.Add(
            //            new UpdateXrayCommand
            //            {
            //                CheckupId = CheckupViewModel.Id,
            //                CheckupItemId = echoItem.Id,
            //                IsAbnormal = XrayResult.FromValue(ddlX_Echo.EditValue?.ToString())?.AbnormalFlag,
            //                //ReportText = richX_EchoRemark.Rtf,
            //                ResultReport = richX_EchoRemark.Text,
            //                ResultValue = ddlX_Echo.EditValue?.ToString(),
            //                //VisitNumber = CheckupViewModel.VisitNumber,
            //                //AccessionNumber = "AccessionNumber"
            //            }
            //        );
            //    }
            //    else
            //    {
            //        createXrayList.Add(
            //            new CreateXrayCommand
            //            {
            //                CheckupId = CheckupViewModel.Id,
            //                CheckupItemId = echoItem.Id,
            //                IsAbnormal = XrayResult.FromValue(ddlX_Echo.EditValue?.ToString())?.AbnormalFlag,
            //                ReportText = richX_EchoRemark.Text,
            //                ResultReport = string.Empty,
            //                ResultValue = ddlX_Echo.EditValue?.ToString(),
            //                VisitNumber = CheckupViewModel.VisitNumber,
            //                AccessionNumber = string.Empty
            //            }
            //        );
            //    }
            //}


            var uUpperAbdomen = xrayItemGroups.CheckupItems.FirstOrDefault(s => s.Code == CheckupItemCode.UltrasoundUpperAbdomen);
            if (uUpperAbdomen != null && checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.UltrasoundUpperAbdomen))
            {
                if (string.IsNullOrEmpty(ddlX_UpperAbdomen.EditValue?.ToString()))
                {
                    //ไม่ได้ลงผล
                    //_isCompleteData = false;
                    //_alertMessage += "- ผลการตรวจ U/S Upper abdomen \n\r";
                }
                else
                {
                    if (checkupViewModelXrays.Any(c => c.CheckupItemId == uUpperAbdomen.Id))
                    {
                        updateXrayList.Add(
                            new UpdateXrayCommand
                            {
                                CheckupId = CheckupViewModel.Id,
                                CheckupItemId = uUpperAbdomen.Id,
                                IsAbnormal = string.IsNullOrWhiteSpace(ddlX_UpperAbdomen.EditValue?.ToString()) ? null : XrayResult.FromValue(ddlX_UpperAbdomen.EditValue.ToString()).AbnormalFlag,
                                //ReportText = richX_UpperAbdomenRemark.Rtf,
                                ResultReport = richX_UpperAbdomenRemark.Text,
                                ResultValue = ddlX_UpperAbdomen.EditValue?.ToString(),
                                //VisitNumber = CheckupViewModel.VisitNumber,
                                //AccessionNumber = "AccessionNumber"
                            }
                        );
                    }
                    else
                    {
                        createXrayList.Add(
                            new CreateXrayCommand
                            {
                                CheckupId = CheckupViewModel.Id,
                                CheckupItemId = uUpperAbdomen.Id,
                                IsAbnormal = string.IsNullOrWhiteSpace(ddlX_UpperAbdomen.EditValue?.ToString()) ? null : XrayResult.FromValue(ddlX_UpperAbdomen.EditValue.ToString()).AbnormalFlag,
                                ReportText = string.Empty,
                                ResultReport = richX_UpperAbdomenRemark.Text,
                                ResultValue = ddlX_UpperAbdomen.EditValue?.ToString(),
                                VisitNumber = CheckupViewModel.VisitNumber,
                                AccessionNumber = string.Empty
                            }
                        );
                    }
                }
            }


            var mamoItem = xrayItemGroups.CheckupItems.FirstOrDefault(s => s.Code == CheckupItemCode.Mammogram);
            if (mamoItem != null && checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.Mammogram))
            {
                if (string.IsNullOrEmpty(ddlX_Mammogram.EditValue?.ToString()))
                {
                    ////ไม่ได้ลงผล
                    //_isCompleteData = false;
                    //_alertMessage += "- ผลการตรวจ Mammogram \n\r";
                }
                else
                {

                    if (checkupViewModelXrays.Any(c => c.CheckupItemId == mamoItem.Id))
                    {
                        updateXrayList.Add(
                            new UpdateXrayCommand
                            {
                                CheckupId = CheckupViewModel.Id,
                                CheckupItemId = mamoItem.Id,
                                IsAbnormal = string.IsNullOrWhiteSpace(ddlX_Mammogram.EditValue?.ToString()) ? null : XrayResult.FromValue(ddlX_Mammogram.EditValue.ToString()).AbnormalFlag,
                                //ReportText = richX_Mammogram.Rtf,
                                ResultReport = string.Empty,
                                ResultValue = ddlX_Mammogram.EditValue?.ToString(),
                                //VisitNumber = CheckupViewModel.VisitNumber,
                                //AccessionNumber = "AccessionNumber"
                            }
                        );
                    }
                    else
                    {
                        createXrayList.Add(
                            new CreateXrayCommand
                            {
                                CheckupId = CheckupViewModel.Id,
                                CheckupItemId = mamoItem.Id,
                                IsAbnormal = string.IsNullOrWhiteSpace(ddlX_Mammogram.EditValue?.ToString()) ? null : XrayResult.FromValue(ddlX_Mammogram.EditValue.ToString()).AbnormalFlag,
                                ReportText = string.Empty,
                                ResultReport = string.Empty,
                                ResultValue = ddlX_Mammogram.EditValue?.ToString(),
                                VisitNumber = CheckupViewModel.VisitNumber,
                                AccessionNumber = string.Empty
                            }
                        );
                    }
                }
            }


            var ultrasoundBreatItem = xrayItemGroups.CheckupItems.FirstOrDefault(s => s.Code == CheckupItemCode.UltrasoundBreast);
            if (ultrasoundBreatItem != null && checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.UltrasoundBreast))
            {
                if (string.IsNullOrEmpty(ddlX_USBreast.EditValue?.ToString()))
                {
                    ////ไม่ได้ลงผล
                    //_isCompleteData = false;
                    //_alertMessage += "- ผลการตรวจ U/S Breast \n\r";
                }
                else
                {
                    if (checkupViewModelXrays.Any(c => c.CheckupItemId == ultrasoundBreatItem.Id))
                    {
                        updateXrayList.Add(
                            new UpdateXrayCommand
                            {
                                CheckupId = CheckupViewModel.Id,
                                CheckupItemId = ultrasoundBreatItem.Id,
                                IsAbnormal = string.IsNullOrWhiteSpace(ddlX_USBreast.EditValue?.ToString()) ? null : XrayResult.FromValue(ddlX_USBreast.EditValue.ToString()).AbnormalFlag,
                                //ReportText = richX_USBreast.Rtf,
                                ResultReport = richX_USBreast.Text,
                                ResultValue = ddlX_USBreast.EditValue?.ToString(),
                                //VisitNumber = CheckupViewModel.VisitNumber,
                                //AccessionNumber = "AccessionNumber"
                            }
                        );
                    }
                    else
                    {
                        createXrayList.Add(
                            new CreateXrayCommand
                            {
                                CheckupId = CheckupViewModel.Id,
                                CheckupItemId = ultrasoundBreatItem.Id,
                                IsAbnormal = string.IsNullOrWhiteSpace(ddlX_USBreast.EditValue?.ToString()) ? null : XrayResult.FromValue(ddlX_USBreast.EditValue.ToString()).AbnormalFlag,
                                ReportText = string.Empty,
                                ResultReport = richX_USBreast.Text,
                                ResultValue = ddlX_USBreast.EditValue?.ToString(),
                                VisitNumber = CheckupViewModel.VisitNumber,
                                AccessionNumber = string.Empty
                            }
                        );
                    }
                }
            }


            if (updateXrayList.Count > 0)
            {
                var command = new UpdateXrayListCommand { XrayList = updateXrayList };
                await Fn.UpdateXrayListAsync(this, _checkupApiClient, command);
            }

            if (createXrayList.Count > 0)
            {
                var command = new UpdateCreateXrayListCommand { XrayList = createXrayList };
                await Fn.UpdateCreateXrayListAsync(this, _checkupApiClient, command);
            }
        }
    }
    public async Task SaveOtherSpecial()
    {
        var checkupViewModelOthers = checkupItemListViewModel?.CheckupItems.Where(c => c.CheckupGroup.Code == CGroup.OtherLab).ToList() ?? [];
        //var checkupViewModelObstetrics = checkupItemListViewModel?.CheckupItems.Where(c => c.CheckupGroup.Code == CGroup.PelvicExam).ToList() ?? [];
        var ortherTestItemGroups = await Fn.GetCheckupItemByClassCodeAsync(CClass.OtherTest, this, _checkupApiClient);
        //var obstetricExamItemGroups = await Fn.GetCheckupItemByClassCodeAsync(CClass.ObstetricExam, this, _checkupApiClient);

        if (checkupViewModelOthers != null)
        {
            var updateCreateSpecialTestList = new List<CreateSpecialTestCommand>();
            var ekgItem = ortherTestItemGroups.CheckupItems.FirstOrDefault(s => s.Code == CheckupItemCode.EKG);

            if (ekgItem != null && checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.EKG))
            {
                if (string.IsNullOrEmpty(ddlEKG.EditValue?.ToString()))
                {
                    //ไม่ได้ลงผล 
                    _otherMessage += "- ผลการตรวจ EKG \n\r";
                    _isCompleteData = false;
                }
                else
                {
                    updateCreateSpecialTestList.Add(
                            new CreateSpecialTestCommand
                            {
                                CheckupId = CheckupViewModel.Id,
                                CheckupItemId = ekgItem.Id,
                                IsAbnormal = string.IsNullOrWhiteSpace(ddlEKG.EditValue?.ToString()) ? null : XrayResult.FromValue(ddlEKG.EditValue.ToString()).AbnormalFlag,
                                ResultReport = txtEKGNote.Text,
                                ResultValue = ddlEKG.EditValue?.ToString(),
                                VisitNumber = CheckupViewModel.VisitNumber
                            }
                        );
                }
            }
            var estItem = ortherTestItemGroups.CheckupItems.FirstOrDefault(s => s.Code == CheckupItemCode.EST);

            if (estItem != null && checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.EST))
            {
                if (string.IsNullOrEmpty(ddlEST.EditValue?.ToString()))
                {
                    //ไม่ได้ลงผล 
                    _otherMessage += "- ผลการตรวจ EST \n\r";
                    _isCompleteData = false;
                }
                else
                {
                    updateCreateSpecialTestList.Add(
                        new CreateSpecialTestCommand
                        {
                            CheckupId = CheckupViewModel.Id,
                            CheckupItemId = estItem.Id,
                            IsAbnormal = string.IsNullOrWhiteSpace(ddlEST.EditValue?.ToString()) ? null : XrayResult.FromValue(ddlEST.EditValue.ToString()).AbnormalFlag,
                            ResultReport = txtESTNote.Text,
                            ResultValue = ddlEST.EditValue?.ToString(),
                            VisitNumber = CheckupViewModel.VisitNumber
                        }
                    );


                }
            }

            var bmdItem = ortherTestItemGroups.CheckupItems.FirstOrDefault(s => s.Code == CheckupItemCode.BMD);
            if (bmdItem != null && checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.BMD))
            {
                if (string.IsNullOrEmpty(ddlBMD.EditValue?.ToString()))
                {
                    //ไม่ได้ลงผล
                    _otherMessage += "- ผลการตรวจ BMD \n\r";
                    _isCompleteData = false;
                }
                else
                {

                    updateCreateSpecialTestList.Add(
                        new CreateSpecialTestCommand
                        {
                            CheckupId = CheckupViewModel.Id,
                            CheckupItemId = bmdItem.Id,
                            IsAbnormal = string.IsNullOrWhiteSpace(ddlBMD.EditValue?.ToString()) ? null : BmdResult.FromValue(ddlBMD.EditValue.ToString()).AbnormalFlag,
                            ResultReport = txtBMDNote.Text,
                            ResultValue = ddlBMD.EditValue?.ToString(),
                            VisitNumber = CheckupViewModel.VisitNumber
                        }
                    );
                }
            }
            var abiItem = ortherTestItemGroups.CheckupItems.FirstOrDefault(s => s.Code == CheckupItemCode.ABI);
            if (abiItem != null && checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.ABI))
            {
                if (string.IsNullOrEmpty(ddlABI.EditValue?.ToString()))
                {
                    //ไม่ได้ลงผล 
                    _otherMessage += "- ผลการตรวจ ABI \n\r";
                    _isCompleteData = false;
                }
                else
                {

                    updateCreateSpecialTestList.Add(
                        new CreateSpecialTestCommand
                        {
                            CheckupId = CheckupViewModel.Id,
                            CheckupItemId = abiItem.Id,
                            IsAbnormal = string.IsNullOrWhiteSpace(ddlABI.EditValue?.ToString()) ? null : AbiResult.FromValue(ddlABI.EditValue.ToString()).AbnormalFlag,
                            ResultReport = txtABINote.Text,
                            ResultValue = ddlABI.EditValue?.ToString(),
                            VisitNumber = CheckupViewModel.VisitNumber
                        }
                    );
                }
            }
            var handItem = ortherTestItemGroups.CheckupItems.FirstOrDefault(s => s.Code == CheckupItemCode.HandGrip);
            if (handItem != null && checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.HandGrip))
            {

                if (string.IsNullOrEmpty(ddlHandGrip.EditValue?.ToString()))
                {
                    //ไม่ได้ลงผล
                    _isCompleteData = false;
                    _otherMessage += "- ผลการตรวจ แรงบีบมือ \n\r";
                    _isCompleteData = false;
                }
                else
                {


                    updateCreateSpecialTestList.Add(
                        new CreateSpecialTestCommand
                        {
                            CheckupId = CheckupViewModel.Id,
                            CheckupItemId = handItem.Id,
                            IsAbnormal = string.IsNullOrWhiteSpace(ddlHandGrip.EditValue?.ToString()) ? null : HandGripResult.FromValue(ddlHandGrip.EditValue.ToString()).AbnormalFlag,
                            ResultReport = txtHandGripNote.Text,
                            ResultValue = ddlHandGrip.EditValue?.ToString(),
                            VisitNumber = CheckupViewModel.VisitNumber
                        }
                    );
                }
            }
            //ในที่ประชุมแจ้งว่าไม่ใช้ เลยซ่อนไว้ก่อน ห้ามลบ เผื่อใช้ในอนาคต
            //var liquidBasedPapItem = obstetricExamItemGroups.CheckupItems.FirstOrDefault(s => s.Code == CheckupItemCode.PapSmear);
            //if (liquidBasedPapItem != null && checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.PapSmear))
            //{
            //    updateCreateSpecialTestList.Add(
            //        new CreateSpecialTestCommand
            //        {
            //            CheckupId = CheckupViewModel.Id,
            //            CheckupItemId = liquidBasedPapItem.Id,
            //            IsAbnormal = string.Empty,
            //            
            //            ResultReport = txtVegina.Text,
            //            ResultValue = string.Empty,
            //            visitNumber = CheckupViewModel.visitNumber
            //        }
            //    );
            //}

            //var papSmearItem = obstetricExamItemGroups.CheckupItems.FirstOrDefault(s => s.Code == CheckupItemCode.PapSmear);
            //if (papSmearItem != null && checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.PapSmear))
            //{
            //    updateCreateSpecialTestList.Add(
            //        new CreateSpecialTestCommand
            //        {
            //            CheckupId = CheckupViewModel.Id,
            //            CheckupItemId = papSmearItem.Id,
            //            IsAbnormal = string.Empty,
            //            ResultReport = txtPapSmear.Text,
            //            ResultValue = string.Empty,
            //            visitNumber = CheckupViewModel.visitNumber
            //        }
            //    );
            //}

            var command = new UpdateCreateSpecialTestListCommand { SpecialTestList = updateCreateSpecialTestList };
            if (command.SpecialTestList.Count > 0)
            {
                await Fn.UpdateCreateSpecialTestListAsync(this, _checkupApiClient, command);
            }
        }
    }
    public async Task SaveConfidential()
    {
        var checkupViewModelLabs = CheckupViewModel?.Labs.ToList() ?? [];
        var labItemGroups = await Fn.GetCheckupItemByClassCodeAsync(CClass.Confidential, this, _checkupApiClient);
        if (labItemGroups != null)
        {
            var updateLabList = new List<CreateLabCommand>();
            var createLabList = new List<CreateLabCommand>();

            var amphetamine = labItemGroups.CheckupItems.FirstOrDefault(s => s.Code == CheckupItemCode.Amphetamine);
            if (amphetamine != null && checkupItemListViewModel.CheckupItems.Any(c => c.Code == CheckupItemCode.Amphetamine))
            {
                if (checkupViewModelLabs.Any(c => c.CheckupItemId == amphetamine.Id))
                {
                    updateLabList.Add(
                        new CreateLabCommand
                        {
                            VisitNumber = CheckupViewModel.VisitNumber,
                            CheckupId = CheckupViewModel.Id,
                            LabItemCode = amphetamine.LabItemCode,
                            LabItemName = amphetamine.DisplayName,
                            ResultValue = ddlAmphetamine.EditValue?.ToString(),
                            ReferenceRange = QualitativeResult.Negative.Value,
                            IsAbnormal = ddlAmphetamine.EditValue == null ? string.Empty :
             (ddlAmphetamine.EditValue.ToString() == "Positive" ? "Y" : "N"),
                            ResultDate = DateTime.Now.Date,
                            ResultTime = DateTime.Now.TimeOfDay
                        }
                    );
                }
                else
                {
                    createLabList.Add(
                        new CreateLabCommand
                        {
                            VisitNumber = CheckupViewModel.VisitNumber,
                            CheckupId = CheckupViewModel.Id,
                            LabItemCode = amphetamine.LabItemCode,
                            LabItemName = amphetamine.DisplayName,
                            ResultValue = ddlAmphetamine.EditValue?.ToString(),
                            ReferenceRange = QualitativeResult.Negative.Value,
                            IsAbnormal = ddlAmphetamine.EditValue == null ? string.Empty :
             (ddlAmphetamine.EditValue.ToString() == "Positive" ? "Y" : "N"),
                            ResultDate = DateTime.Now.Date,
                            ResultTime = DateTime.Now.TimeOfDay
                        }
                    );
                }
            }
            if (updateLabList.Count > 0)
            {
                var command = new UpdateCreateLabListCommand { UpdateCreateList = updateLabList };
                await Fn.UpdateCreateLabListAsync(this, _checkupApiClient, command);
            }

            if (createLabList.Count > 0)
            {
                var command = new UpdateCreateLabListCommand { UpdateCreateList = createLabList };
                await Fn.UpdateCreateLabListAsync(this, _checkupApiClient, command);
            }

        }
    }
    private UpdateCheckupCommand BuildCheckupDataForUpdate()
    {
        var command = new UpdateCheckupCommand
        {
            Id = CheckupViewModel.Id,           
            SaveDate = DateTimeOffset.Now.DateTime.ToUniversalTime(),
            //IsFinalized = false,
        };

        if (int.TryParse(ddlDoctor_PE.EditValue?.ToString(), out int physicalExaminationById))
        {
            command.PhysicalExaminationById = physicalExaminationById;
        }

        if (int.TryParse(ddlDoctor_Conclusion.EditValue?.ToString(), out int conclusionById))
        {
            command.ConclusionById = conclusionById;
        }

        if (!string.IsNullOrEmpty(txtDoctorRecommend?.EditValue?.ToString()))
        {
            command.Conclusion = txtDoctorRecommend?.EditValue?.ToString();
        }

        command.IsSmoking = optSmoking.EditValue as bool?;
        command.Smoking = txtSmokingRemark.Text;
        command.IsAlcohol = optAlcohol.EditValue as bool?;
        command.Alcohol = txtAlcoholRemark.Text;     

        if (int.TryParse(ddlStatus.EditValue?.ToString(), out int chkStatus))
        {
            command.Status = chkStatus;
        }
        //if (finalStatus == true)
        //{
        //    command.FinalizedDate = DateTimeOffset.Now.DateTime.ToUniversalTime();
        //}

        if (int.TryParse(ddlCheckupType.EditValue?.ToString(), out int checkupTypeId))
        {
            command.CheckupTypeId = checkupTypeId;
        }

        return command;
    }

    public async Task UpdateCheckup(UpdateCheckupCommand command)
    {
        if (
            command.Id != 0 &&
            command.PhysicalExaminationById != 0 &&
            command.ConclusionById != 0 &&
            !string.IsNullOrEmpty(command.Conclusion))
        {
            try
            {
                ShowLoading(true);
                await _checkupApiClient.UpdateCheckupAsync(command.Id, command, cancellationToken: CancellationToken.None);
                SuthFunctions.Message.Success("บันทึกข้อมูลสำเร็จ");
                //MessageBox.Show(this, "บันทึกข้อมูลสำเร็จ", "บันทึกข้อมูลสำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ApiClientException<ValidationProblemDetails> ex)
            {
                string message = Fn.GetValidationErrorMessage(ex);
                MessageBox.Show(this, message, "บันทึกข้อมูลไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ApiClientException<ProblemDetails> ex)
            {
                string message = Fn.GetProblemErrorMessage(ex);
                MessageBox.Show(this, message, "บันทึกข้อมูลไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ApiClientException ex)
            {
                MessageBox.Show(this, ex.Message, "บันทึกข้อมูลไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "บันทึกข้อมูลไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ShowLoading(false);
            }
        }
        else
        {
            SuthFunctions.Message.Warning("กรุณาระบุข้อมูลให้ครบถ้วน 1.แพทย์ผู้ตรวจร่างการ 2.แพทย์สรุปผล 3.ข้อความสรุปผล");

            //MessageBox.Show(this, "กรุณาระบุข้อมูลให้ครบถ้วน 1.แพทย์ผู้ตรวจร่างการ 2.แพทย์สรุปผล 3.ข้อความสรุปผล", "บันทึกข้อมูลไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ShowLoading(bool show)
    {
        if (show)
        {
            this.Cursor = Cursors.WaitCursor;
            //แสดงหมุนๆ
        }
        else
        {
            this.Cursor = Cursors.Default;
            //หยุดแสดงหมุนๆ
        }
    }
    private async void GetPhysicalExamination()
    {
        PhysicalExaminationViewModel checkupPE;

        try
        {
            checkupPE = await _checkupApiClient.GetPhysicalExaminationByVisitNumberAsync(_visitNumber);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            checkupPE = null;
        }

        if (checkupPE != null)
        {
            ddlGA_LevelOfConsciousness.EditValue = checkupPE.Ga;
            ddlGA_Heen.EditValue = checkupPE.Heent;
            ddlGA_MouthAndThroat.EditValue = checkupPE.Mouth;
            ddlGA_Lymphoma.EditValue = checkupPE.Lymph;
            ddlGA_Thyroid.EditValue = checkupPE.Thyroid;
            ddlGA_LungChestBreast.EditValue = checkupPE.Chest;
            ddlGA_Heart.EditValue = checkupPE.Heart;
            ddlGA_Abdomen.EditValue = checkupPE.Abdomen;
            ddlGA_Extremties.EditValue = checkupPE.Ext;
            ddlGA_Skin.EditValue = checkupPE.Skin;
            ddlGA_Others.EditValue = checkupPE.Other;

            txtGA_LevelOfConsciousne.Text = checkupPE.GaText;
            txtGA_Heen.Text = checkupPE.HeentText;
            txtGA_MouthAndThroat.Text = checkupPE.MouthText;
            txtGA_Lymphoma.Text = checkupPE.LymphText;
            txtGA_Thyroid.Text = checkupPE.ThyroidText;
            txtGA_LungChestBreast.Text = checkupPE.ChestText;
            txtGA_Heart.Text = checkupPE.HeartText;
            txtGA_Abdomen.Text = checkupPE.AbdomenText;
            txtGA_Extremties.Text = checkupPE.ExtText;
            txtGA_Skin.Text = checkupPE.SkinText;
            txtGA_Others.Text = checkupPE.OtherText;
        }
    }

    public void GetVision()
    {
        var checkupOrder = checkupItemListViewModel.CheckupItems.Any(i => i.CheckupGroup.Code == CGroup.VisionScreening);
        var checkupOrderOccupation = checkupItemListViewModel.CheckupItems.Any(i => i.Code == CheckupItemCode.VisionOccupation);
        groupBoxOccupation.Visible = checkupOrderOccupation;

        if (checkupOrder == false && checkupOrderOccupation)
            xtraTabPageVS.PageVisible = true;
        else
            xtraTabPageVS.PageVisible = checkupOrder;

        if (checkupOrder)
        {
            var vision = CheckupViewModel.Visions.FirstOrDefault();
            if (vision != null)
            {
                txtVS_VisibilityLeft.Text = vision.VA_Left_Value;
                //ddlVS_VisibilityLeft.EditValue = vision.VA_Left_Result;
                txtPH_VisibilityLeft.Text = vision.PH_Left_Value;
                //ddlPH_VisibilityLeft.EditValue = vision.PH_Left_Result;

                txtVS_VisibilityRight.Text = vision.VA_Right_Value;
                //ddlVS_VisibilityRight.EditValue = vision.VA_Right_Result;
                txtPH_VisibilityRight.Text = vision.PH_Right_Value;
                //ddlPH_VisibilityRight.EditValue = vision.PH_Right_Result;


                optVS_ColorBlind.EditValue = vision.ColorBlind;

                txtVS_PressureLeft.Text = vision.PressureLeft;
                txtVS_PressureRight.Text = vision.PressureRight;

                txtVS_RetinaLeft.Text = vision.RetinaLeft;
                txtVS_RetinaRight.Text = vision.RetinaRight;

                optVS_Squint.EditValue = vision.Squint;
                optVS_3D.EditValue = vision.Vision3D;
                optVisionLeftResult.EditValue = vision.VisionLeftResult;
                optVisionRightResult.EditValue = vision.VisionRightResult;
                optVS_VisualField.EditValue = vision.VisualField;
            }
        }
    }


    public async Task SavePhysicalExamAsync()
    {
        PhysicalExaminationViewModel physicalExamViewModel = null;
        try
        {
            physicalExamViewModel = await _checkupApiClient.GetPhysicalExaminationByVisitNumberAsync(_visitNumber);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            physicalExamViewModel = null;
        }

        if (physicalExamViewModel == null)
        {
            var command = new CreatePhysicalExaminationCommand
            {
                VisitNumber = _visitNumber,
                CheckupId = _checkupId,
                CheckupItemId = CheckupItemId.PhysicalExamination,
                Ga = ddlGA_LevelOfConsciousness.EditValue?.ToString(),
                Heent = ddlGA_Heen.EditValue?.ToString(),
                Mouth = ddlGA_MouthAndThroat.EditValue?.ToString(),
                Lymph = ddlGA_Lymphoma.EditValue?.ToString(),
                Thyroid = ddlGA_Thyroid.EditValue?.ToString(),
                Chest = ddlGA_LungChestBreast.EditValue?.ToString(),
                Heart = ddlGA_Heart.EditValue?.ToString(),
                Abdomen = ddlGA_Abdomen.EditValue?.ToString(),
                Ext = ddlGA_Extremties.EditValue?.ToString(),
                Skin = ddlGA_Skin.EditValue?.ToString(),
                Other = ddlGA_Others.EditValue?.ToString(),

                GaText = txtGA_LevelOfConsciousne.Text,
                HeentText = txtGA_Heen.Text,
                MouthText = txtGA_MouthAndThroat.Text,
                LymphText = txtGA_Lymphoma.Text,
                ThyroidText = txtGA_Thyroid.Text,
                ChestText = txtGA_LungChestBreast.Text,
                HeartText = txtGA_Heart.Text,
                AbdomenText = txtGA_Abdomen.Text,
                ExtText = txtGA_Extremties.Text,
                SkinText = txtGA_Skin.Text,
                OtherText = txtGA_Others.Text,
            };

            await Fn.CreatPhysicalExaminationAsync(this, _checkupApiClient, command);
        }
        else
        {
            var command = new UpdatePhysicalExaminationCommand
            {
                Id = physicalExamViewModel.Id,
                CheckupId = _checkupId,
                CheckupItemId = CheckupItemId.PhysicalExamination,
                Ga = ddlGA_LevelOfConsciousness.EditValue?.ToString(),
                Heent = ddlGA_Heen.EditValue?.ToString(),
                Mouth = ddlGA_MouthAndThroat.EditValue?.ToString(),
                Lymph = ddlGA_Lymphoma.EditValue?.ToString(),
                Thyroid = ddlGA_Thyroid.EditValue?.ToString(),
                Chest = ddlGA_LungChestBreast.EditValue?.ToString(),
                Heart = ddlGA_Heart.EditValue?.ToString(),
                Abdomen = ddlGA_Abdomen.EditValue?.ToString(),
                Ext = ddlGA_Extremties.EditValue?.ToString(),
                Skin = ddlGA_Skin.EditValue?.ToString(),
                Other = ddlGA_Others.EditValue?.ToString(),

                GaText = txtGA_LevelOfConsciousne.Text,
                HeentText = txtGA_Heen.Text,
                MouthText = txtGA_MouthAndThroat.Text,
                LymphText = txtGA_Lymphoma.Text,
                ThyroidText = txtGA_Thyroid.Text,
                ChestText = txtGA_LungChestBreast.Text,
                HeartText = txtGA_Heart.Text,
                AbdomenText = txtGA_Abdomen.Text,
                ExtText = txtGA_Extremties.Text,
                SkinText = txtGA_Skin.Text,
                OtherText = txtGA_Others.Text,

                IsActive = true,

            };
            await Fn.UpdatePhysicalExaminationAsync(this, _checkupApiClient, physicalExamViewModel.Id, command);
        }


    }
    public async Task SavePatientAddressAsync()
    {
        var address = new UpdateAdressPatientCommand
        {
            Id = CheckupViewModel.Patient.Id,
            Address = txtAddress.Text,
            ProvinceId = ddlProvince.EditValue.ToString(),
            ZipCode = txtZipCode.Text,
            DistrictId = ddlDistrict.EditValue.ToString(),
            SubDistrictId = ddlSubDistrict.EditValue.ToString(),
        };
        await _checkupApiClient.UpdatePatientAddressAsync(CheckupViewModel.Patient.Id, address);
    }

    private async void BindProvinceToDDL()
    {
        var province = await _checkupApiClient.GetProvincesAsync();
        ddlProvince.Properties.DataSource = province.Provinces.ToList();
        ddlProvince.Properties.DisplayMember = "Name";
        ddlProvince.Properties.ValueMember = "ProvinceId";
    }
    private async void BindDistrictToDDL()
    {
        var district = await _checkupApiClient.GetDistrictsAsync(ddlProvince.EditValue.ToString());
        ddlDistrict.Properties.DataSource = district.Districts.ToList();
        ddlDistrict.Properties.DisplayMember = "Name";
        ddlDistrict.Properties.ValueMember = "DistrictId";
    }
    private async void BindSubDistrictToDDL()
    {
        var subDistrict = await _checkupApiClient.GetSubDistrictsAsync(ddlDistrict.EditValue.ToString());
        ddlSubDistrict.Properties.DataSource = subDistrict.SubDistricts.ToList();
        ddlSubDistrict.Properties.DisplayMember = "Name";
        ddlSubDistrict.Properties.ValueMember = "SubDistrictId";
    }

    private async void GetBodyComposition()
    {
        xtraTabPageBodyComp.PageVisible = checkupItemListViewModel.CheckupItems.Any(i => i.Code == CheckupItemCode.BodyComposition);
        Checkup.Api.Client.BodyCompositionViewModel checkupBodyComposition; try
        {
            checkupBodyComposition = await _checkupApiClient.GetBodyCompositionByVisitNumberAsync(_visitNumber);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            checkupBodyComposition = null;
        }
        if (checkupBodyComposition != null)
        {
            ddlBmr.EditValue = checkupBodyComposition.Bmr;
            txtBmrNote.Text = checkupBodyComposition.BmrNote;
            ddlBodyWater.EditValue = checkupBodyComposition.BodyWater;
            txtBodyWaterNote.Text = checkupBodyComposition.BodyWaterNote;
            ddlVisceralFat.EditValue = checkupBodyComposition.VisceralFat;
            txtVisceralFatNote.Text = checkupBodyComposition.VisceralFatNote;
            ddlBodyFat.EditValue = checkupBodyComposition.BodyFat;
            txtBodyFatNote.Text = checkupBodyComposition.BodyFatNote;
        }
    }

    private async void GetDental()
    {
        xtraTabPageDental.PageVisible = checkupItemListViewModel.CheckupItems.Any(i => i.Code == CheckupItemCode.Dental);
        Checkup.Api.Client.DentalViewModel checkupDental; try
        {
            checkupDental = await _checkupApiClient.GetDentalByVisitNumberAsync(_visitNumber);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            checkupDental = null;
        }
        if (checkupDental != null)
        {
            optDentalResult.EditValue = checkupDental.ResultValue;
            txtDetalResultNote.Text = checkupDental.ResultNote;
            if (checkupDental.ResultValue == "Normal")
            {
                DisableDentalControl(false);
            }
            else
            {
                chkScaling.Checked = checkupDental.Scaling;
                chkGingivitis.Checked = checkupDental.Gingivitis;
                chkDecay.Checked = checkupDental.Decay;
                chkFluoride.Checked = checkupDental.Fluoride;
                chkSealant.Checked = checkupDental.Sealant;
                chkFilling.Checked = checkupDental.Filling;
                chkExtraction.Checked = checkupDental.Extraction;
                txtSealantNote.Text = checkupDental.SealantNote;
                txtFillingNote.Text = checkupDental.FillingNote;
                txtExtractionNote.Text = checkupDental.ExtractionNote;
                DisableDentalControl(true);
            }

        }
    }

    private void DisableDentalControl(bool sKey)
    {
        chkScaling.Enabled = sKey;
        chkGingivitis.Enabled = sKey;
        chkDecay.Enabled = sKey;
        chkFluoride.Enabled = sKey;
        chkSealant.Enabled = sKey;
        chkFilling.Enabled = sKey;
        chkExtraction.Enabled = sKey;
        txtSealantNote.Enabled = sKey;
        txtFillingNote.Enabled = sKey;
        txtExtractionNote.Enabled = sKey;
    }

    private async void GetLung()
    {

        xtraTabPageLung.PageVisible = checkupItemListViewModel.CheckupItems.Any(i => i.Code == CheckupItemCode.Lung);

        Checkup.Api.Client.LungViewModel checkupLung;

        try
        {
            checkupLung = await _checkupApiClient.GetLungByVisitNumberAsync(_visitNumber);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            checkupLung = null;
        }

        if (checkupLung != null)
        {
            txtFVC.Text = checkupLung.Fvc.ToString();
            txtFVC_Rate.Text = checkupLung.FvC_Rate.ToString();
            txtFEV1.Text = checkupLung.FeV1.ToString();
            txtFEV1_Rate.Text = checkupLung.FeV1_Rate.ToString();

            optLungResult.EditValue = checkupLung.ResultAbnormal;

            if (checkupLung.ResultAbnormal == ExamResult.Abnormal.Value)
            {
                if (checkupLung.RestrictionAbnormal == ExamResult.Abnormal.Value)
                {
                    chkRestrictionAbnormal.Checked = true;
                    optRestrictionLevel.EditValue = checkupLung.RestrictionLevel;
                }
                if (checkupLung.ObstructionAbnormal == ExamResult.Abnormal.Value)
                {
                    chkObstruction.Checked = true;
                    optObstructionLevel.EditValue = checkupLung.ObstructionLevel;
                }
                if (checkupLung.CombineAbnormal == ExamResult.Abnormal.Value)
                {
                    chkMixed.Checked = true;
                }
            }

            if (checkupLung.IsConsult == "Y")
            {
                chkConsult.Checked = true;
            }
            txtLungRecommend.Text = checkupLung.ResultNote.ToString();
        }
    }

    public async Task SaveLungAsync()
    {

        Checkup.Api.Client.LungViewModel lungViewModel = null;
        try
        {
            lungViewModel = await _checkupApiClient.GetLungByVisitNumberAsync(_visitNumber);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            lungViewModel = null;
        }
        double fvc = 0.0;
        double.TryParse(txtFVC.Text, out fvc);

        double fvcRate = 0.0;
        double.TryParse(txtFVC_Rate.Text, out fvcRate);

        double fev = 0.0;
        double.TryParse(txtFEV1.Text, out fev);

        double fevRate = 0.0;
        double.TryParse(txtFEV1_Rate.Text, out fevRate);

        string resultValue = "";
        if (optLungResult.EditValue != null)
        {            
            resultValue = optLungResult.EditValue.ToString();
        }

        if (checkupItemListViewModel.CheckupItems.Any(c => c.CheckupGroup.Code == CGroup.Lung))
        {
            if (fev <= 0 || fevRate <= 0 || fvcRate <= 0)
            {
                _isCompleteData = false;
                _lungMessage += "- ระบุค่า %FVC , FEV1 , %FEV1 ให้ครบถ้วน \n\r";
                return;
            }
            if (optLungResult.EditValue == null)
            {
                _isCompleteData = false;
                _lungMessage += "- ผลการตรวจสมรรถภาพปอด \n\r";
                return;
            }

            if (lungViewModel == null)
            {
                var command = new CreateLungCommand
                {
                    VisitNumber = _visitNumber,
                    CheckupId = _checkupId,
                    CheckupItemId = CheckupItemId.PFT,
                    ResultAbnormal = resultValue,
                    Fvc = fvc,
                    FvC_Rate = fvcRate,
                    FeV1 = fev,
                    FeV1_Rate = fevRate,
                    RestrictionAbnormal = GlobalFunctions.ConvertTrueToYes(chkRestrictionAbnormal.Checked),
                    RestrictionLevel = string.Concat(optObstructionLevel.EditValue),
                    ObstructionAbnormal = GlobalFunctions.ConvertTrueToYes(chkObstruction.Checked),
                    ObstructionLevel = string.Concat(optObstructionLevel.EditValue),
                    CombineAbnormal = GlobalFunctions.ConvertTrueToYes(chkMixed.Checked),
                    IsConsult = GlobalFunctions.ConvertTrueToYes(chkConsult.Checked),
                    ResultNote = string.Concat(txtLungRecommend.Text),
                };

                await Fn.CreatLungAsync(this, _checkupApiClient, command);
            }
            else
            {
                var command = new UpdateLungCommand
                {
                    Id = lungViewModel.Id,
                    VisitNumber = _visitNumber,
                    CheckupId = _checkupId,
                    CheckupItemId = CheckupItemId.PFT,
                    ResultAbnormal = resultValue,
                    Fvc = fvc,
                    FvC_Rate = fvcRate,
                    FeV1 = fev,
                    FeV1_Rate = fevRate,

                    RestrictionAbnormal = GlobalFunctions.ConvertTrueToYes(chkRestrictionAbnormal.Checked),
                    RestrictionLevel = string.Concat(optObstructionLevel.EditValue),
                    ObstructionAbnormal = GlobalFunctions.ConvertTrueToYes(chkObstruction.Checked),
                    ObstructionLevel = string.Concat(optObstructionLevel.EditValue),
                    CombineAbnormal = GlobalFunctions.ConvertTrueToYes(chkMixed.Checked),
                    IsConsult = GlobalFunctions.ConvertTrueToYes(chkConsult.Checked),
                    ResultNote = string.Concat(txtLungRecommend.Text),
                    IsActive = true,

                };
                await Fn.UpdateLungAsync(this, _checkupApiClient, lungViewModel.Id, command);
            }
        }
    }

    public async Task SaveBodyCompositionAsync()
    {

        Checkup.Api.Client.BodyCompositionViewModel bodyCompositionViewModel = null;
        try
        {
            bodyCompositionViewModel = await _checkupApiClient.GetBodyCompositionByVisitNumberAsync(_visitNumber);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            bodyCompositionViewModel = null;
        }

        if (checkupItemListViewModel.CheckupItems.Any(c => c.Code == CGroup.BodyComposition))  //ถ้าไม่มีตรวจ ไม่ทำการ save      
        {
            if (bodyCompositionViewModel == null)
            {
                var command = new CreateBodyCompositionCommand
                {
                    VisitNumber = _visitNumber,
                    CheckupId = _checkupId,
                    CheckupItemId = CheckupItemId.BodyComposition,
                    Bmr = ddlBmr.EditValue.ToString(),
                    BmrNote = txtBmrNote.Text,
                    BodyWater = ddlBodyWater.EditValue.ToString(),
                    BodyWaterNote = txtBodyWaterNote.Text,
                    VisceralFat = ddlVisceralFat.EditValue.ToString(),
                    VisceralFatNote = txtVisceralFatNote.Text,
                    BodyFat = ddlBodyFat.EditValue.ToString(),
                    BodyFatNote = txtBodyFatNote.Text,
                    FatRate = ddlFatRate.EditValue.ToString(),
                    FatRateNote = txtFatRateNote.Text,
                    MuscleMass = ddlMuscleMass.EditValue.ToString(),
                    MuscleMassNote = txtMuscleNote.Text,
                };

                await Fn.CreatBodyCompositionAsync(this, _checkupApiClient, command);
            }
            else
            {
                var command = new UpdateBodyCompositionCommand
                {
                    Id = bodyCompositionViewModel.Id,
                    VisitNumber = _visitNumber,
                    CheckupId = _checkupId,
                    CheckupItemId = CheckupItemId.BodyComposition,
                    Bmr = ddlBmr.EditValue.ToString(),
                    BmrNote = txtBmrNote.Text,
                    BodyWater = ddlBodyWater.EditValue.ToString(),
                    BodyWaterNote = txtBodyWaterNote.Text,
                    VisceralFat = ddlVisceralFat.EditValue.ToString(),
                    VisceralFatNote = txtVisceralFatNote.Text,
                    BodyFat = ddlBodyFat.EditValue.ToString(),
                    BodyFatNote = txtBodyFatNote.Text,
                    FatRate = ddlFatRate.EditValue.ToString(),
                    FatRateNote = txtFatRateNote.Text,
                    MuscleMass = ddlMuscleMass.EditValue.ToString(),
                    MuscleMassNote = txtMuscleNote.Text,
                    IsActive = true,
                };
                await Fn.UpdateBodyCompositionAsync(this, _checkupApiClient, bodyCompositionViewModel.Id, command);
            }
        }
    }


    public async Task SaveDentalAsync()
    {
        if (xtraTabPageDental.PageVisible == false) return; //ถ้าแท็บไม่แสดงแปลว่าไม่มีตรวจ ไม่ทำการ save        

            Checkup.Api.Client.DentalViewModel DentalViewModel = null;
        try
        {
            DentalViewModel = await _checkupApiClient.GetDentalByVisitNumberAsync(_visitNumber);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            DentalViewModel = null;
        }

        if (checkupItemListViewModel.CheckupItems.Any(c => c.Code == CGroup.Dental))
        {
            if (string.IsNullOrEmpty(optDentalResult.EditValue?.ToString()))
            {
                _isCompleteData = false;
                _dentalMessage += "- การตรวจฟัน \n\r" + _alertMessage;
                return;
            }


            if (DentalViewModel == null)
            {
                var command = new CreateDentalCommand
                {
                    VisitNumber = _visitNumber,
                    CheckupId = _checkupId,
                    CheckupItemId = CheckupItemId.Dental,
                    ResultValue = optDentalResult.EditValue.ToString(),
                    ResultNote = txtDetalResultNote.Text,   
                    Scaling = chkScaling.Checked,
                    Gingivitis = chkGingivitis.Checked ,
                    Decay = chkDecay.Checked,
                    Fluoride = chkFluoride.Checked ,
                    Sealant = chkSealant.Checked,
                    Filling = chkFilling.Checked ,
                    Extraction = chkExtraction.Checked,
                    SealantNote = txtSealantNote.Text,
                    FillingNote = txtFillingNote.Text,
                    ExtractionNote = txtExtractionNote.Text 
                };

                await Fn.CreatDentalAsync(this, _checkupApiClient, command);
            }
            else
            {
                var command = new UpdateDentalCommand
                {
                    Id = DentalViewModel.Id,
                    VisitNumber = _visitNumber,
                    CheckupId = _checkupId,
                    CheckupItemId = CheckupItemId.Dental,
                    ResultValue = optDentalResult.EditValue.ToString(),
                    ResultNote = txtDetalResultNote.Text,
                    Scaling = chkScaling.Checked,
                    Gingivitis = chkGingivitis.Checked,
                    Decay = chkDecay.Checked,
                    Fluoride = chkFluoride.Checked,
                    Sealant = chkSealant.Checked,
                    Filling = chkFilling.Checked,
                    Extraction = chkExtraction.Checked,
                    SealantNote = txtSealantNote.Text,
                    FillingNote = txtFillingNote.Text,
                    ExtractionNote = txtExtractionNote.Text,
                    IsActive = true,
                };
                await Fn.UpdateDentalAsync(this, _checkupApiClient, DentalViewModel.Id, command);
            }
        }
    }


    private async void cmdSaveAddress_Click(object sender, EventArgs e)
    {
        await SavePatientAddressAsync();
        SuthFunctions.Message.Success("บันทึกที่อยู่สำเร็จ");
        //MessageBox.Show(this, "บันทึกที่อยู่สำเร็จ", "บันทึกที่อยู่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void ddlProvince_EditValueChanged(object sender, EventArgs e)
    {
        BindDistrictToDDL();
    }

    private void ddlDistrict_EditValueChanged(object sender, EventArgs e)
    {
        BindSubDistrictToDDL();
    }

      private async void BtnPrintReport_Click(object sender, EventArgs e)
    {
        //if (string.IsNullOrEmpty(ddlCheckupType.EditValue?.ToString()))
        //{
        //    _isCompleteData = false;
        //    var message = "ท่านยังไม่ได้บันทึกประเภทการตรวจ \n\r" + _alertMessage;
        //    MessageBox.Show(this, message, "บันทึกข้อมูลไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    return;
        //}

        //await SaveReport(); //By Tee 29/01/2026

        //var lab = await _checkupApiClient.GetLabListByGroupAsync(lblVisitNo.Text, CGroup.WhiteBloodCell);

        //var reportLab = new subLab();
        //reportLab.DataSource = lab;
        //reportLab.ShowPreview();

        CheckupReportViewModel reportData = await _checkupApiClient.CheckupReportAsync(lblVisitNo.Text);
        CheckupSummaryReport report = new CheckupSummaryReport();
        report.DataSource = new List<CheckupReportViewModel> { reportData };
        report.ShowPreviewDialog();

    }
    //By Tee 29/01/2026
    private async Task SaveReport()
    {
        string Sexx;
        string VisitNumber = lblVisitNo.Text;
        Checkup.Api.Client.CheckupReportViewModel dataReport;

        try
        {

            if (lblGender.Text == "ชาย")
            {
                Sexx = "M";
            }
            else if (lblGender.Text == "หญิง")
            {
                Sexx = "F";
            }
            else
            {
                Sexx = "";
            }

            string BmiReport = GetBMICategory(Convert.ToDouble(lblBMI.Text));
            string BpReport = "";//GetBPCategory(CheckupViewModel.SystolicBloodPresure ?? 0, CheckupViewModel.DiastolicBloodPresure ?? 0);

            //โลหิตวิทยา
            string Hemoglobin = await GetConclusionSafely(VisitNumber, CheckupItemCode.Hemoglobin, Sexx, CompareType.Numberic) ?? string.Empty;
            string HCT = await GetConclusionSafely(VisitNumber, CheckupItemCode.HCT, Sexx, CompareType.Numberic) ?? string.Empty;
            string HbReport = "";
            if (Hemoglobin != "")
            {
                HbReport = Hemoglobin;
            }
            else HbReport = HCT;


            //WBC จำนวนเม็ดเลือดขาว
            string WbcReport = await GetConclusionSafely(VisitNumber, CheckupItemCode.WBC, Sexx, CompareType.Numberic) ?? string.Empty;
            //เกร็ดเลือด
            string PlateletCount = await GetConclusionSafely(VisitNumber, CheckupItemCode.PlateletCount, Sexx, CompareType.Numberic) ?? string.Empty;

            //น้ำตาล
            string Fbs = await GetConclusionSafely(VisitNumber, CheckupItemCode.FBS, Sexx, CompareType.Numberic) ?? string.Empty;
            string HBA1C = await GetConclusionSafely(VisitNumber, CheckupItemCode.HbA1C, Sexx, CompareType.Numberic) ?? string.Empty;
            string FbsReport = string.IsNullOrEmpty(HBA1C) ? Fbs : string.Concat(Fbs, Environment.NewLine, HBA1C);

            //Lipid ตรวจไขมัน
            string Cholesterol = await GetConclusionSafely(VisitNumber, CheckupItemCode.Cholesterol, Sexx, CompareType.Numberic) ?? string.Empty;
            string HDL = await GetConclusionSafely(VisitNumber, CheckupItemCode.HDL, Sexx, CompareType.Numberic) ?? string.Empty;
            string LDL = await GetConclusionSafely(VisitNumber, CheckupItemCode.LDL, Sexx, CompareType.Numberic) ?? string.Empty;
            string Triglyceride = await GetConclusionSafely(VisitNumber, CheckupItemCode.Triglyceride, Sexx, CompareType.Numberic) ?? string.Empty;

            string LipidReport = BuildLabGroup("ไขมันในเลือดอยู่ในเกณฑ์ปกติ", Cholesterol, Triglyceride, HDL, LDL);

            //string LipidReport =string.Concat( Cholesterol, " , ", Triglyceride, " , ", HDL , " , ", LDL );
            //string LipidReport = string.Join(" , ", new[] { Cholesterol }.Concat(new[] { Triglyceride, HDL, LDL }.Where(x => !string.IsNullOrEmpty(x) && x != "ปกติ" && x != "Normal")));

            //ยูริก
            string UricReport = await GetConclusionSafely(VisitNumber, CheckupItemCode.Uric, Sexx, CompareType.Numberic);

            //ไต
            string BUN = await GetConclusionSafely(VisitNumber, CheckupItemCode.BUN, Sexx, CompareType.Numberic);
            string Creatinine = await GetConclusionSafely(VisitNumber, CheckupItemCode.Creatinine, Sexx, CompareType.Numberic);
            string eGFR = await GetConclusionSafely(VisitNumber, CheckupItemCode.eGFR, Sexx, CompareType.Numberic);
            string RenalReport = BuildLabGroup("การทำงานของไตอยู่ในเกณฑ์ปกติ", Creatinine, eGFR, BUN);

            //ตับ
            string SGOT = await GetConclusionSafely(VisitNumber, CheckupItemCode.SGOT, Sexx, CompareType.Numberic);
            string SGPT = await GetConclusionSafely(VisitNumber, CheckupItemCode.SGPT, Sexx, CompareType.Numberic);
            string ALP = await GetConclusionSafely(VisitNumber, CheckupItemCode.ALP, Sexx, CompareType.Numberic); // ALP ในตับ
            string LiverReport = BuildLabGroup("การทำงานของตับอยู่ในเกณฑ์ปกติ", SGOT, SGPT, ALP);

            //if (SGOT == "เอนไซม์ SGOT ในตับอยู่ในเกณฑ์ปกติ" && ALP == "เอนไซม์ ALP ในตับอยู่ในเกณฑ์ปกติ" && SGPT == "เอนไซม์ SGPT ในตับอยู่ในเกณฑ์ปกติ")
            //{
            //    LiverReport = "การทำงานของตับอยู่ในเกณฑ์ปกติ";
            //}
            //else
            //{
            //    LiverReport = string.Concat(SGOT ,Environment.NewLine , SGPT, Environment.NewLine, ALP);
            //} 

            //Hepatitis          
            string HBAg = await GetConclusionSafely(VisitNumber, CheckupItemCode.HBAg, Sexx, CompareType.Text);
            string HBAn = await GetConclusionSafely(VisitNumber, CheckupItemCode.HBAn, Sexx, CompareType.Text);
            //string HCV = await GetConclusionSafely(visitNumber, CheckupItemCode.HCI, sexx, CompareType.Numberic);           
            string HepatitisReport = BuildConclusionReport(HBAg, HBAn);

            //ไทรอยด์
            string FT3 = await GetConclusionSafely(VisitNumber, CheckupItemCode.FreeT3, Sexx, CompareType.Numberic);
            string FT4 = await GetConclusionSafely(VisitNumber, CheckupItemCode.FreeT4, Sexx, CompareType.Numberic);
            string TSH = await GetConclusionSafely(VisitNumber, CheckupItemCode.TSH, Sexx, CompareType.Numberic);
            string ThyroidReport = FT3 + FT4 + TSH;
            //string T4 = await GetConclusionSafely(visitNumber, CheckupItemCode.AFP, sexx, CompareType.Numberic);

            //คัดกรองมะเร็ง Cancer
            string AFP = await GetConclusionSafely(VisitNumber, CheckupItemCode.AFP, Sexx, CompareType.Numberic); //มะเร็งตับ
            string CEA = await GetConclusionSafely(VisitNumber, CheckupItemCode.CEA, Sexx, CompareType.Numberic); //มะเร็งลำใส้       
            string PSA = await GetConclusionSafely(VisitNumber, CheckupItemCode.PSA, Sexx, CompareType.Numberic); //มะเร็งต่อมลูกหมาก          
            string CA125 = await GetConclusionSafely(VisitNumber, CheckupItemCode.CA125, Sexx, CompareType.Numberic); //มะเร็งรังไข่           
            string CA199 = await GetConclusionSafely(VisitNumber, CheckupItemCode.CA199, Sexx, CompareType.Numberic); //มะเร็งตับอ่อน
            string ImmunologyReport = BuildConclusionReportNewLine(AFP, CEA, PSA, CA125, CA199);
            //string CA153 = await GetConclusionSafely(visitNumber, CheckupItemCode.AFP, sexx, CompareType.Numberic);

            string UrineReport = "ไม่ตรวจ";
            if (xtraTabPageUA.PageVisible == true)
            {
                UrineReport = txtUrineSummary.Text;
            }
            else
            {
                UrineReport = "ไม่ตรวจ";
            }

            string StoolReport = "ไม่ตรวจ";
            if (xtraTabPageStoolExam.PageVisible == true)
            {
                StoolReport = txtStoolSummary.Text;
            }
            else
            {
                StoolReport = "ไม่ตรวจ";
            }

            string AudiogramReport = "";
            if (xtraTabPageAudiogram.PageVisible == true)
            {
                AudiogramReport = txtAudiogramSummary.Text;
            }
            else
            {
                AudiogramReport = "ไม่ตรวจ";
            }

            string DentalReport = ""; //ยังไม่เสร็จต้องกลับมาแก้
            if (xtraTabPageDental.PageVisible == true)
            {
                if (string.IsNullOrEmpty(optDentalResult.EditValue?.ToString()))
                {                  
                    _dentalMessage += "- การตรวจฟัน \n\r" + _alertMessage; 
                    return;
                }

                if (optDentalResult.EditValue.ToString() == "Normal") 
                {           
                    DentalReport = "ปกติ";        
                    if (txtDetalResultNote.Text != "")
                    {
                        DentalReport += " : " + txtDetalResultNote.Text;
                    }
                } 
                else
                {
                    if (chkGingivitis.Checked || chkDecay.Checked) DentalReport = "ตรวจพบ : ";                    
                    if (chkGingivitis.Checked) DentalReport += "เหงือกอักเสบ ";
                    if (chkDecay.Checked) DentalReport += "ฟันผุ ";

                    if (chkScaling.Checked || chkFluoride.Checked || chkSealant.Checked || chkFilling.Checked || chkExtraction.Checked) DentalReport += "แนะนำ :";
                    if (chkFilling.Checked) DentalReport += " อุดฟัน " + txtFillingNote.Text;
                    if (chkExtraction.Checked) DentalReport += " ถอนฟัน " + txtExtractionNote.Text;
                    if (chkScaling.Checked) DentalReport += " ขูดหินปูน ";                   
                    if (chkFluoride.Checked) DentalReport += " เคลือบฟลูออไรด์ ";
                    if (chkSealant.Checked) DentalReport += " เคลือบหลุมร่องฟัน " + txtSealantNote.Text;              

                    if (txtDetalResultNote.Text != "")
                    {
                        DentalReport += Environment.NewLine + txtDetalResultNote.Text;
                    } 
                }                     
            }
            else
            {
                DentalReport = "ไม่ตรวจ";
            }

            string CbcReport = "";
            if (xtraTabPageCBC.PageVisible == true)
            {
                CbcReport = txtCbcSummary.Text;
            }
            else
            {
                CbcReport = "ไม่ตรวจ";
            }

            string LungReport = "";
            if (xtraTabPageLung.PageVisible == true)
            {
                LungReport = "";

                if (optLungResult.EditValue != null && optLungResult.EditValue.ToString() == "Normal")
                {
                    LungReport = "ปกติ" + "\n";
                }
                else
                {
                    if (chkRestrictionAbnormal.Checked) LungReport = "ผิดปกติแบบจำกัดการขยายตัว (Restriction)" + optRestrictionLevel.Text + "\n";
                    if (chkObstruction.Checked) LungReport = LungReport + "ผิดปกติแบบอุดกั้น  (Obstruction)" + optObstructionLevel.Text + "\n";
                    if (chkMixed.Checked) LungReport = LungReport + "ผิดปกติแบบผสม (Mixed)" + "\n";
                }

                if (chkConsult.Checked) LungReport = LungReport + "ควรปรึกษาแพทย์" + "\n";

                LungReport = LungReport + txtLungRecommend.Text;
            }
            else
            {
                LungReport = "ไม่ตรวจ";
            }


            //string ALB = await _checkupApiClient.GetConclusionAsync(visitNumber, CheckupItemCode.AFP, sexx, CompareType.Numberic);
            //string Aluminium = await _checkupApiClient.GetConclusionAsync(visitNumber, CheckupItemCode.AFP, sexx, CompareType.Numberic);

            //string HbReport = await _checkupApiClient.GetConclusionAsync(visitNumber, CheckupItemCode.Hemoglobin, sexx, CompareType.Numberic);

            //string PlateletReport = await _checkupApiClient.GetConclusionAsync(visitNumber, CheckupItemCode.PlateletCount, sexx, CompareType.Numberic);

            //string LipidReport = await _checkupApiClient.GetConclusionAsync(visitNumber, CheckupItemCode.SGPT, sexx, CompareType.Numberic);
            //string EOS = await _checkupApiClient.GetConclusionAsync(visitNumber, CheckupItemCode.AFP, sexx, CompareType.Numberic);       
            //string MCV = await _checkupApiClient.GetConclusionAsync(visitNumber, CheckupItemCode.AFP, sexx, CompareType.Numberic);

            try
            {
                dataReport = await _checkupApiClient.CheckupReportAsync(lblVisitNo.Text);
            }
            catch (Exception ex)  //when (ex.Message.Contains("404") || ex.Message.Contains("not found") || ex.Message.Contains("No resultset"))
            {
                Debug.WriteLine(ex.Message);
                dataReport = null;
            }

            if (dataReport == null)
            {
                var reportCreate = new CreateReportCommand()
                {
                    CheckupId = _checkupId,
                    VisitNumber = _visitNumber,
                    HospitalNumber = CheckupViewModel.HospitalNumber,
                    VisitDate = CheckupViewModel.VisitDate,
                    VisitTime = CheckupViewModel.VisitTime.ToString().Left(5),
                    CheckupTypeId = Convert.ToInt32(ddlCheckupType.EditValue),   //CheckupViewModel.CheckupTypeId,                 
                    PayorName = CheckupViewModel.PayorName,
                    PackageId = CheckupViewModel.PackageId,
                    PackageName = CheckupViewModel.PackageName,
                    AgeCheckup = CheckupViewModel.AgeCheckup,
                    AgeTextCheckup = CheckupViewModel.AgeTextCheckup,
                    PatientId = CheckupViewModel.Patient.Id,
                    Weight = CheckupViewModel.Weight,
                    Height = CheckupViewModel.Height,
                    Temperature = CheckupViewModel.Temperature,
                    DiastolicBloodPresure = CheckupViewModel.DiastolicBloodPresure,
                    SystolicBloodPresure = CheckupViewModel.SystolicBloodPresure,
                    PulseRate = CheckupViewModel.PulseRate,
                    RespiratoryRate = CheckupViewModel.RespiratoryRate,                     
                    PhysicalExaminationBy = ddlDoctor_PE.Text.ToString(),
                    ConclusionBy = ddlDoctor_Conclusion.Text.ToString(),
                    Conclusion = txtDoctorRecommend.Text,

                    //SpecialConclusion = SpecialConclusion,
                    BmiReport = BmiReport,
                    BpReport = BpReport,
                    AudiogramReport = AudiogramReport,
                    DentalReport = DentalReport,
                    HbReport = HbReport,
                    WbcReport = WbcReport,
                    PlateletReport = PlateletCount,
                    CbcReport = CbcReport,
                    FbsReport = FbsReport,
                    LipidReport = LipidReport,
                    UricReport = UricReport,
                    RenalReport = RenalReport,
                    LiverReport = LiverReport,
                    HepatitisReport = HepatitisReport,
                    ThyroidReport = ThyroidReport,
                    ImmunologyReport = ImmunologyReport,
                    UrineReport = UrineReport,
                    StoolReport = StoolReport,

                };
                var reportId = await _checkupApiClient.CreateReportAsync(reportCreate);
            }
            else
            {


                var reportUpdate = new UpdateReportCommand()
                {

                    VisitNumber = _visitNumber,
                    CheckupTypeId = Convert.ToInt32(ddlCheckupType.EditValue),
                    PhysicalExaminationBy = ddlDoctor_PE.Text.ToString(),
                    ConclusionBy = ddlDoctor_Conclusion.Text.ToString(),
                    Conclusion = txtDoctorRecommend.Text,

                    //CheckupId = _checkupId,
                    //HospitalNumber = CheckupViewModel.HospitalNumber,
                    //VisitDate = CheckupViewModel.VisitDate,
                    //VisitTime = CheckupViewModel.VisitTime.ToString().Left(5),

                    PayorName = CheckupViewModel.PayorName,
                    PackageId = CheckupViewModel.PackageId,
                    PackageName = CheckupViewModel.PackageName,
                    //AgeCheckup = CheckupViewModel.AgeCheckup,
                    //AgeTextCheckup = CheckupViewModel.AgeTextCheckup,
                    //PatientId = CheckupViewModel.Patient.Id,
                    Weight = CheckupViewModel.Weight,
                    Height = CheckupViewModel.Height,
                    Temperature = CheckupViewModel.Temperature,
                    DiastolicBloodPresure = CheckupViewModel.DiastolicBloodPresure,
                    SystolicBloodPresure = CheckupViewModel.SystolicBloodPresure,
                    PulseRate = CheckupViewModel.PulseRate,
                    RespiratoryRate = CheckupViewModel.RespiratoryRate,

                    BmiReport = BmiReport,
                    BpReport = BpReport,
                    AudiogramReport = AudiogramReport,
                    DentalReport = DentalReport,
                    HbReport = HbReport,
                    WbcReport = WbcReport,
                    PlateletReport = PlateletCount,
                    CbcReport = CbcReport,
                    FbsReport = FbsReport,
                    LipidReport = LipidReport,
                    UricReport = UricReport,
                    RenalReport = RenalReport,
                    LiverReport = LiverReport,
                    HepatitisReport = HepatitisReport,
                    ThyroidReport = ThyroidReport,
                    ImmunologyReport = ImmunologyReport,
                    UrineReport = UrineReport,
                    StoolReport = StoolReport,

                };
                await _checkupApiClient.UpdateReportAsync(lblVisitNo.Text, reportUpdate);
            }
            BtnPrintReport.Visible = true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            MessageBox.Show(this, ex.Message, "บันทึกรายงานไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dataReport = null;
        }
    }

    private async void DisplayRecommendation()
    {
        string recommedations;
        recommedations = "";
        string sexx;
        string visitNumber = lblVisitNo.Text;
        var recList = new List<string>();

        try
        {

            if (lblGender.Text == "ชาย")
            {
                sexx = "M";
            }
            else if (lblGender.Text == "หญิง")
            {
                sexx = "F";
            }
            else
            {
                sexx = "";
            }

            string bmi = "";
            if (Convert.ToDouble(lblBMI.Text) >= 23)
            {
                bmi = await GetRecommendationValueSafely(visitNumber, CheckupItemCode.BMI, "", lblBMI.Text) ?? string.Empty;
            }
            if (!string.IsNullOrWhiteSpace(bmi)) recList.Add($"- {bmi.Trim()}");

            string bp = "";
            if (CheckupViewModel.SystolicBloodPresure >= 130 || CheckupViewModel.DiastolicBloodPresure >= 90)
            {
                bp = await GetRecommendationValueSafely(visitNumber, CheckupItemCode.BP, "", CheckupViewModel.SystolicBloodPresure.ToString()) ?? string.Empty;
            }
            if (!string.IsNullOrWhiteSpace(bp)) recList.Add($"- {bp.Trim()}");


            string hemoglobin = await GetRecommendationSafely(visitNumber, CheckupItemCode.Hemoglobin, sexx, CompareType.Numberic) ?? string.Empty;
            string htc = await GetRecommendationSafely(visitNumber, CheckupItemCode.HCT, sexx, CompareType.Numberic) ?? string.Empty;

            if (hemoglobin != "")
            {
                recList.Add($"- {hemoglobin.Trim()}");
            }
            else if (!string.IsNullOrWhiteSpace(htc)) recList.Add($"- {htc.Trim()}");

            //RBC จำนวนเม็ดเลือดขาว
            string rbc = await GetRecommendationSafely(visitNumber, CheckupItemCode.RBC, sexx, CompareType.Numberic) ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(rbc)) recList.Add($"- {rbc.Trim()}");

            //WBC จำนวนเม็ดเลือดขาว
            string wbc = await GetRecommendationSafely(visitNumber, CheckupItemCode.WBC, sexx, CompareType.Numberic) ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(wbc)) recList.Add($"- {wbc.Trim()}");
            //เกร็ดเลือด
            string plateletCount = await GetRecommendationSafely(visitNumber, CheckupItemCode.PlateletCount, sexx, CompareType.Numberic) ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(plateletCount)) recList.Add($"- {plateletCount.Trim()}");

            //น้ำตาล
            string fbs = await GetRecommendationSafely(visitNumber, CheckupItemCode.FBS, sexx, CompareType.Numberic) ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(fbs)) recList.Add($"- {fbs.Trim()}");
            //string HBA1C = await GetRecommendationSafely(visitNumber, CheckupItemCode.HbA1C, sexx, CompareType.Numberic) ?? string.Empty;
            //string Fbs = string.IsNullOrEmpty(HBA1C) ? Fbs : string.Concat(Fbs, " , ", HBA1C);

            //Lipid ตรวจไขมัน
            string cholesterol = await GetRecommendationSafely(visitNumber, CheckupItemCode.Cholesterol, sexx, CompareType.Numberic) ?? string.Empty;
            string hdl = await GetRecommendationSafely(visitNumber, CheckupItemCode.HDL, sexx, CompareType.Numberic) ?? string.Empty;
            string ldl = await GetRecommendationSafely(visitNumber, CheckupItemCode.LDL, sexx, CompareType.Numberic) ?? string.Empty;
            string triglyceride = await GetRecommendationSafely(visitNumber, CheckupItemCode.Triglyceride, sexx, CompareType.Numberic) ?? string.Empty;
            //string lipid = BuildLabGroup("", cholesterol, triglyceride, hdl, ldl);
            if (!string.IsNullOrWhiteSpace(cholesterol)) recList.Add($"- {cholesterol.Trim()}");
            if (!string.IsNullOrWhiteSpace(hdl)) recList.Add($"- {hdl.Trim()}");
            if (!string.IsNullOrWhiteSpace(ldl)) recList.Add($"- {ldl.Trim()}");
            if (!string.IsNullOrWhiteSpace(triglyceride)) recList.Add($"- {triglyceride.Trim()}");

            //ยูริก
            string uric = await GetRecommendationSafely(visitNumber, CheckupItemCode.Uric, sexx, CompareType.Numberic);
            if (!string.IsNullOrWhiteSpace(uric)) recList.Add($"- {uric.Trim()}");

            //ไต
            string bun = await GetRecommendationSafely(visitNumber, CheckupItemCode.BUN, sexx, CompareType.Numberic);
            string creatinine = await GetRecommendationSafely(visitNumber, CheckupItemCode.Creatinine, sexx, CompareType.Numberic);
            string egfr = await GetRecommendationSafely(visitNumber, CheckupItemCode.eGFR, sexx, CompareType.Numberic);
            if (!string.IsNullOrWhiteSpace(bun)) recList.Add($"- {bun.Trim()}");
            if (!string.IsNullOrWhiteSpace(creatinine)) recList.Add($"- {creatinine.Trim()}");
            if (!string.IsNullOrWhiteSpace(egfr)) recList.Add($"- {egfr.Trim()}");

            //ตับ
            string sgot = await GetRecommendationSafely(visitNumber, CheckupItemCode.SGOT, sexx, CompareType.Numberic);
            string sgpt = await GetRecommendationSafely(visitNumber, CheckupItemCode.SGPT, sexx, CompareType.Numberic);
            string alp = await GetRecommendationSafely(visitNumber, CheckupItemCode.ALP, sexx, CompareType.Numberic); // ALP ในตับ

            if (!string.IsNullOrWhiteSpace(sgot)) recList.Add($"- {sgot.Trim()}");
            if (!string.IsNullOrWhiteSpace(sgpt)) recList.Add($"- {sgpt.Trim()}");
            if (!string.IsNullOrWhiteSpace(alp)) recList.Add($"- {alp.Trim()}");


            //Hepatitis          
            string HBAg = await GetRecommendationSafely(visitNumber, CheckupItemCode.HBAg, sexx, CompareType.Text);
            string HBAn = await GetRecommendationSafely(visitNumber, CheckupItemCode.HBAn, sexx, CompareType.Text);
            //string HCV = await GetRecommendationSafely(visitNumber, CheckupItemCode.HCI, sexx, CompareType.Numberic);
            //if (!string.IsNullOrWhiteSpace(HBAg)) recList.Add($"- {HBAg.Trim()}");
            //if (!string.IsNullOrWhiteSpace(HBAn)) recList.Add($"- {HBAn.Trim()}");


            //ไทรอยด์
            string FT3 = await GetRecommendationSafely(visitNumber, CheckupItemCode.FreeT3, sexx, CompareType.Numberic);
            string FT4 = await GetRecommendationSafely(visitNumber, CheckupItemCode.FreeT4, sexx, CompareType.Numberic);
            string TSH = await GetRecommendationSafely(visitNumber, CheckupItemCode.TSH, sexx, CompareType.Numberic);
            string ThyroidReport = FT3 + FT4 + TSH;
            //if (!string.IsNullOrWhiteSpace(ThyroidReport)) recList.Add($"- {ThyroidReport.Trim()}");

            //คัดกรองมะเร็ง Cancer
            string AFP = await GetRecommendationSafely(visitNumber, CheckupItemCode.AFP, sexx, CompareType.Numberic); //มะเร็งตับ
            string CEA = await GetRecommendationSafely(visitNumber, CheckupItemCode.CEA, sexx, CompareType.Special); //มะเร็งลำใส้       
            string PSA = await GetRecommendationSafely(visitNumber, CheckupItemCode.PSA, sexx, CompareType.Numberic); //มะเร็งต่อมลูกหมาก          
            string CA125 = await GetRecommendationSafely(visitNumber, CheckupItemCode.CA125, sexx, CompareType.Special); //มะเร็งรังไข่           
            string CA199 = await GetRecommendationSafely(visitNumber, CheckupItemCode.CA199, sexx, CompareType.Special); //มะเร็งตับอ่อน

            if (!string.IsNullOrWhiteSpace(HBAg)) recList.Add($"- {HBAg.Trim()}");
            if (!string.IsNullOrWhiteSpace(HBAn)) recList.Add($"- {HBAn.Trim()}");
            if (!string.IsNullOrWhiteSpace(FT3)) recList.Add($"- {FT3.Trim()}");
            if (!string.IsNullOrWhiteSpace(FT4)) recList.Add($"- {FT4.Trim()}");
            if (!string.IsNullOrWhiteSpace(TSH)) recList.Add($"- {TSH.Trim()}");

            if (!string.IsNullOrWhiteSpace(AFP)) recList.Add($"- {AFP.Trim()}");
            if (!string.IsNullOrWhiteSpace(CEA)) recList.Add($"- {CEA.Trim()}");
            if (!string.IsNullOrWhiteSpace(PSA)) recList.Add($"- {PSA.Trim()}");
            if (!string.IsNullOrWhiteSpace(CA125)) recList.Add($"- {CA125.Trim()}");
            if (!string.IsNullOrWhiteSpace(CA199)) recList.Add($"- {CA199.Trim()}");

            // รวมทุกอย่างเข้าด้วยกัน คั่นด้วยการขึ้นบรรทัดใหม่
            recommedations = string.Join("\r\n", recList);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }

        txtDoctorRecommend.Text = recommedations;

    }


    public static string BuildConclusionReport(params string[] values)
    {
        var nonEmptyValues = values.Where(v => !string.IsNullOrEmpty(v)).ToList();
        return string.Join(" , ", nonEmptyValues);
    }
    public static string BuildConclusionReportNewLine(params string[] values)
    {
        var nonEmptyValues = values.Where(v => !string.IsNullOrEmpty(v)).ToList();
        return string.Join(Environment.NewLine, nonEmptyValues);
    }
    private async Task<string> GetConclusionSafely(string visitNumber, string itemCode, string sexx, string compareType)
    {
        try
        {
            return await _checkupApiClient.GetConclusionAsync(visitNumber, itemCode, sexx, compareType);
        }
        catch (Exception ex) when (ex.Message.Contains("404") || ex.Message.Contains("not found") || ex.Message.Contains("No resultset"))
        {
            return string.Empty;
        }
    }
    private async Task<string> GetRecommendationSafely(string visitNumber, string itemCode, string sexx, string compareType)
    {
        try
        {
            return await _checkupApiClient.GetRecommendationAsync(visitNumber, itemCode, sexx, compareType);
        }
        catch (Exception ex) when (ex.Message.Contains("404") || ex.Message.Contains("not found") || ex.Message.Contains("No resultset"))
        {
            return string.Empty;
        }
    }
    private async Task<string> GetRecommendationValueSafely(string visitNumber, string itemCode, string sexx, string value)
    {
        try
        {
            return await _checkupApiClient.GetRecommendationByValueAsync(visitNumber, itemCode, sexx, value);
        }
        catch (Exception ex) when (ex.Message.Contains("404") || ex.Message.Contains("not found") || ex.Message.Contains("No resultset"))
        {
            return string.Empty;
        }
    }

    private static string GetBMICategory(double bmi)
    {
        if (bmi < 18.5)
            return "น้ำหนักต่ำกว่าเกณฑ์ (Underweight)";
        else if (bmi >= 18.5 && bmi < 23)
            return "น้ำหนักสมส่วน (Normal weight)";
        else if (bmi >= 23 && bmi < 25)
            return "น้ำหนักเกินมาตรฐาน (Overweight)";
        else if (bmi >= 25 && bmi < 30)
            return "น้ำหนักเกินมาตรฐานระดับ 1 (Overweight Level 1)"; //"อ้วน (Obese)";        
        else
            return "น้ำหนักเกินมาตรฐานระดับ 2 (Overweight Level 2)";  //"อ้วนมาก (Extremely Obese)";
    }
    private static string GetBPCategory(int sbp, int dbp)
    {
        // ตรวจสอบค่า SBP และ DBP ตามเกณฑ์ของ WHO และ American Heart Association
        if (sbp < 90 || dbp < 60)
            return "ความดันต่ำ (Hypotension)";
        else if (sbp >= 90 && sbp < 120 && dbp >= 60 && dbp < 80)
            return "ความดันปกติ (Normal)";
        else if (sbp >= 120 && sbp < 130 && dbp < 80)
            return "ความดันสูงระดับเสี่ยง (Elevated)";
        else if (sbp >= 130 && sbp < 140 || dbp >= 80 && dbp < 90)
            return "ความดันสูงระดับ 1 (Hypertension Stage 1)";
        else if (sbp >= 140 && sbp < 180 || dbp >= 90 && dbp < 120)
            return "ความดันสูงระดับ 2 (Hypertension Stage 2)";
        else if (sbp >= 180 || dbp >= 120)
            return "ความดันสูงระดับ 3 (Hypertension Stage 3) หรือภาวะความดันสูงฉุกเฉิน";
        else
            return "";
    }

    string BuildLabGroup(string normaltext, string main, params string[] others)
    {
        Func<string, bool> isNormal = x =>
            string.IsNullOrEmpty(x) ||
            x.IndexOf("อยู่ในเกณฑ์ปกติ", StringComparison.OrdinalIgnoreCase) >= 0 ||
            x.IndexOf("Normal", StringComparison.OrdinalIgnoreCase) >= 0;

        if (string.IsNullOrEmpty(main) && (others == null || others.All(string.IsNullOrEmpty)))
            return "ไม่ตรวจ";

        // ถ้าทุกตัวปกติ
        if (isNormal(main) && others.All(isNormal))
            return normaltext;


        // ถ้าไม่ปกติ → แสดง Cholesterol + ตัวที่ผิดปกติ
        return string.Join(Environment.NewLine,
            new[] { main }
            .Concat(others.Where(x => !isNormal(x))));
    }

    public static void OpenUrl(string hn, string accessionNumber)
    {
        string url;

        if (accessionNumber == "")
        {
            url = "http://localhost:9090?QueryMode=PID&Value=" + hn;
        }
        else
        {
            url = "http://localhost:9090?QueryMode=AN&Value=" + accessionNumber;
        }


        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
        catch (System.ComponentModel.Win32Exception)
        {
            // สำหรับกรณีฉุกเฉิน หรือบาง OS ที่ยังเจอปัญหา
            // จะบังคับเปิดด้วย cmd.exe ของ Windows โดยตรง
            if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Windows))
            {
                url = url.Replace("&", "^&"); // ป้องกันปัญหาเครื่องหมาย & ใน Command Prompt
                Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
            }
            else
            {
                throw;
            }
        }
    }
    private void btnPAC_PA_Click(object sender, EventArgs e)
    {
        OpenUrl(lblHN.Text, btnPAC_PA.Tag.ToString());
    }

    private void btnPAC_Echo_Click(object sender, EventArgs e)
    {
        OpenUrl(lblHN.Text, btnPAC_Echo.Tag.ToString());
    }

    private void btnPAC_Abdomen_Click(object sender, EventArgs e)
    {
        OpenUrl(lblHN.Text, btnPAC_Abdomen.Tag.ToString());
    }

    private void btnPAC_Upper_Click(object sender, EventArgs e)
    {
        OpenUrl(lblHN.Text, btnPAC_Upper.Tag.ToString());
    }

    private void btnPAC_USBreast_Click(object sender, EventArgs e)
    {
        OpenUrl(lblHN.Text, btnPAC_USBreast.Tag.ToString());
    }

    private void btnPAC_Mammo_Click(object sender, EventArgs e)
    {
        OpenUrl(lblHN.Text, btnPAC_Mammo.Tag.ToString());
    }

    private void gridViewHearing_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            int rowHandle = view.FocusedRowHandle;
            var col = view.FocusedColumn;

            e.Handled = true;
            // Column 3 -> ไป Column 2 แถวถัดไป      
            if (col.FieldName == "RightHz")
            {
                view.FocusedColumn = view.Columns["LeftHz"];
            }
            // Column 2 -> ไป Column 3
            else if (col.FieldName == "LeftHz")
            {
                view.FocusedRowHandle = rowHandle + 1;
                view.FocusedColumn = view.Columns["RightHz"];
            }
            view.ShowEditor();
        }
    }

    private void optDentalResult_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (optDentalResult.SelectedIndex == 0)
        {
            DisableDentalControl(false);
        }
        else { 
            DisableDentalControl(true);
            if (txtDetalResultNote.Text.Trim() == "ไม่มีฟันผุแนะนำขุดหินปูน") txtDetalResultNote.Text = "";
        }
    }
}
