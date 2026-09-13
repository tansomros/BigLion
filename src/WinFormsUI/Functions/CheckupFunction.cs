using SUTH.HealthCheckup.WinFormsUI.Checkup.Api.Client;
using SUTH.HealthCheckup.WinFormsUI.Hosxp.Api.Client;
using CkpClient = SUTH.HealthCheckup.WinFormsUI.Checkup.Api.Client;
using HxpClient = SUTH.HealthCheckup.WinFormsUI.Hosxp.Api.Client;

namespace SUTH.HealthCheckup.WinFormsUI.Functions;
public class CheckupFunction
{
    public static string GetValidationErrorMessage(ApiClientException<ValidationProblemDetails> ex)
    {
        string message = "";

        if (ex.StatusCode == 404)
        {
            message = "ไม่พบข้อมูลที่ระบุ\n";//ex.Message;
            message += ex.Result.Detail;

        }
        else if (ex.StatusCode == 400)
        {
            ValidationProblemDetails detail = ex.Result;
            var error = detail.Errors;
            if (error != null && detail.Errors.Count > 0)
            {
                foreach (KeyValuePair<string, ICollection<string>> entry in error)
                {
                    if (entry.Value != null && entry.Value.Count > 0)
                    {
                        message += entry.Key + ": " + string.Join(",", entry.Value) + "; ";
                    }
                };
            }
            else
            {
                message = detail.Detail;
            }
        }
        else
        {
            message = ex.Message;
        }
        return message;
    }

    public static string GetProblemErrorMessage(ApiClientException<ProblemDetails> ex)
    {

        ProblemDetails detail = ex.Result;
        string message = string.Empty;
        if (detail != null)
        {
            message = string.Format($"Status : {detail.Status}, Detail : {detail.Detail}, Status : {detail.Status}");
        }
        return message;
    }

    public async static Task<CheckupItemListViewModel> GetCheckupItemByClassCodeAsync(string classCode, IWin32Window owner, CheckupApiClient checkupApiClient)
    {
        CheckupItemListViewModel items = null;
        try
        {
            items = await checkupApiClient.GetCheckupItemsByClassAsync(classCode);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            MessageBox.Show(owner, message, "GetCheckupItemGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            MessageBox.Show(owner, message, "GetCheckupItemGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        catch (ApiClientException ex)
        {
            MessageBox.Show(owner, ex.Message, "GetCheckupItemGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(owner, ex.Message, "GetCheckupItemGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return items;
    }

    public static async Task<HxpClient.LabListViewModel> HosxpGetLabByVisitNumberAsync(string visitNumber, IWin32Window owner, HosxpApiClient hosxpApiClient)
    {
        HxpClient.LabListViewModel labListViewModel = null;
        try
        {
            labListViewModel = await hosxpApiClient.GetLabByVisitNumberAsync(visitNumber); //ข้อมูล Lab result
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            MessageBox.Show(owner, message, "HosxpGetLabByVisitNumberAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            MessageBox.Show(owner, message, "HosxpGetLabByVisitNumberAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        catch (ApiClientException ex)
        {
            MessageBox.Show(owner, ex.Message, "HosxpGetLabByVisitNumberAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(owner, ex.Message, "HosxpGetLabByVisitNumberAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //

        return labListViewModel;
    }

    public static async Task<EyeViewModel> HosxpGetEYEByVisitNumberAsync(string visitNumber, IWin32Window owner, HosxpApiClient hosxpApiClient, bool hideMessage = false)
    {
        EyeViewModel eyeViewModel = null;
        try
        {
            eyeViewModel = await hosxpApiClient.GetEyeByVisitNumberAsync(visitNumber); //ข้อมูล Lab result
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            if(hideMessage)
                MessageBox.Show(owner, message, "HosxpGetEYEByVisitNumberAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            if (hideMessage)
                MessageBox.Show(owner, message, "HosxpGetEYEByVisitNumberAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        catch (ApiClientException ex)
        {
            if (hideMessage)
                MessageBox.Show(owner, ex.Message, "HosxpGetEYEByVisitNumberAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            if (hideMessage)
                MessageBox.Show(owner, ex.Message, "HosxpGetEYEByVisitNumberAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //

        return eyeViewModel;
    }

    public static async Task<List<CkpClient.XrayViewModel>> CheckupGetXrayList(string visitNumber, IWin32Window owner, CheckupApiClient checkupApiClient, bool hideMessage = false)
    {
        List<CkpClient.XrayViewModel> xrays = [];
        try
        {
            var xrayList = await checkupApiClient.GetXrayListAsync(visitNumber); //ข้อมูล Lab result
            xrays = xrayList.Xrays.ToList();
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            if (hideMessage)
                MessageBox.Show(owner, message, "CheckupGetXrayList", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            if (hideMessage)
                MessageBox.Show(owner, message, "CheckupGetXrayList", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        catch (ApiClientException ex)
        {
            if (hideMessage)
                MessageBox.Show(owner, ex.Message, "CheckupGetXrayList", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            if (hideMessage)
                MessageBox.Show(owner, ex.Message, "CheckupGetXrayList", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //

        return xrays;
    }

    public static async Task<Hosxp.Api.Client.XrayListViewModel> HosxpGetXrayByVisitNumberAsync(string visitNumber, IWin32Window owner, HosxpApiClient hosxpApiClient)
    {
        Hosxp.Api.Client.XrayListViewModel xrayListViewModel = null;
        try
        {
            xrayListViewModel = await hosxpApiClient.GetXrayByQueryAsync(visitNumber); //ข้อมูล Xray result
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            MessageBox.Show(owner, message, "GetXrayByQueryAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            MessageBox.Show(owner, message, "GetXrayByQueryAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        catch (ApiClientException ex)
        {
            MessageBox.Show(owner, ex.Message, "GetXrayByQueryAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(owner, ex.Message, "GetXrayByQueryAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //

        return xrayListViewModel;
    }    

    public static async Task CreatVisionAsync(IWin32Window owner, CheckupApiClient checkupApiClient, CreateVisionCommand command, bool hideMessage = false)
    {
        try
        {
            await checkupApiClient.CreateVisionAsync(command);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "CreateVisionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "CreateVisionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        catch (ApiClientException ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "CreateVisionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "CreateVisionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static async Task UpdateVisionAsync(
        IWin32Window owner, CheckupApiClient checkupApiClient
        , int visionId, UpdateVisionCommand command, bool hideMessage = false)
    {
        try
        {
            await checkupApiClient.UpdateVisionAsync(visionId, command);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "UpdateVisionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "UpdateVisionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        catch (ApiClientException ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "UpdateVisionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "UpdateVisionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static async Task UpsertVisionAsync(
        IWin32Window owner, CheckupApiClient checkupApiClient , UpsertVisionCommand command, bool hideMessage = false
        )
    {
        try
        {
            await checkupApiClient.UpsertVisionAsync(command);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "UpsertVisionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "UpsertVisionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        catch (ApiClientException ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "UpsertVisionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "UpsertVisionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static async Task UpdateCreateLabListAsync(IWin32Window owner, CheckupApiClient checkupApiClient, UpdateCreateLabListCommand command, bool hideMessage = false)
    {
        try
        {
            await checkupApiClient.BatchUpsertLabsAsync(command);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "CreateVisionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "CreateVisionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        catch (ApiClientException ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "CreateVisionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "CreateVisionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static async Task UpdateCreateXrayListAsync(IWin32Window owner, CheckupApiClient checkupApiClient, UpdateCreateXrayListCommand command, bool hideMessage = false)
    {
        try
        {
            await checkupApiClient.UpdateCreateXrayListAsync(command);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "CreateXrayAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "CreateXrayAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        catch (ApiClientException ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "CreateXrayAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "CreateXrayAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    public static async Task UpdateXrayListAsync(IWin32Window owner, CheckupApiClient checkupApiClient, UpdateXrayListCommand command, bool hideMessage = false)
    {
        try
        {
            await checkupApiClient.UpdateXrayListAsync(command);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "UpdateXrayAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "UpdateXrayAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        catch (ApiClientException ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "UpdateXrayAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "UpdateXrayAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    //public static async Task UpdateCreateSpecialTestListAsync(IWin32Window owner, CheckupApiClient checkupApiClient, UpdateCreateSpecialTestListCommand command, bool hideMessage = false)
    //{
    //    try
    //    {
    //        await checkupApiClient.UpdateCreateSpecialTestListAsync(command);
    //    }
    //    catch (ApiClientException<ValidationProblemDetails> ex)
    //    {
    //        string message = GetValidationErrorMessage(ex);
    //        if (!hideMessage)
    //            MessageBox.Show(owner, message, "CreateXraySpecialTabAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }
    //    catch (ApiClientException<ProblemDetails> ex)
    //    {
    //        string message = GetProblemErrorMessage(ex);
    //        if (!hideMessage)
    //            MessageBox.Show(owner, message, "CreateXraySpecialTabAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);

    //    }
    //    catch (ApiClientException ex)
    //    {
    //        if (!hideMessage)
    //            MessageBox.Show(owner, ex.Message, "CreateXraySpecialTabAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }
    //    catch (Exception ex)
    //    {
    //        if (!hideMessage)
    //            MessageBox.Show(owner, ex.Message, "CreateXraySpecialTabAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }
    //}

    public static async Task UpdateCreateSpecialTestListAsync(IWin32Window owner, CheckupApiClient checkupApiClient, UpdateCreateSpecialTestListCommand command, bool hideMessage = false)
    {
        try
        {
            await checkupApiClient.UpdateCreateSpecialTestListAsync(command);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "CreateSpecialTestAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "CreateSpecialTestAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        catch (ApiClientException ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "CreateSpecialTestAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "CreateSpecialTestAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static async Task CreatPhysicalExaminationAsync(IWin32Window owner, CheckupApiClient checkupApiClient, CreatePhysicalExaminationCommand command, bool hideMessage = false)
    {
        try
        {
            await checkupApiClient.CreatePhysicalExaminationsAsync(command);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "CreatePhysicalExaminationAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "CreatePhysicalExaminationAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        catch (ApiClientException ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "CreatePhysicalExaminationAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "CreatePhysicalExaminationAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static async Task UpdatePhysicalExaminationAsync(
        IWin32Window owner, CheckupApiClient checkupApiClient
        , int PhisicalExamId, UpdatePhysicalExaminationCommand command, bool hideMessage = false)
    {
        try
        {
            await checkupApiClient.UpdatePhysicalExaminationAsync(PhisicalExamId, command);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "UpdatePhysicalExaminationAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "UpdatePhysicalExaminationAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        catch (ApiClientException ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "UpdatePhysicalExaminationAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "UpdatePhysicalExaminationAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static async Task CreatLungAsync(IWin32Window owner, CheckupApiClient checkupApiClient, CreateLungCommand command, bool hideMessage = false)
    {
        try
        {
            await checkupApiClient.CreateLungAsync(command);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "CreateLungAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "CreateLungAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        catch (ApiClientException ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "CreateLungAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "CreateLungAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static async Task UpdateLungAsync(
        IWin32Window owner, CheckupApiClient checkupApiClient
        , int PhisicalExamId, UpdateLungCommand command, bool hideMessage = false)
    {
        try
        {
            await checkupApiClient.UpdateLungAsync(PhisicalExamId, command);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "UpdateLungAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "UpdateLungAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        catch (ApiClientException ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "UpdateLungAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "UpdateLungAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static async Task CreatBodyCompositionAsync(IWin32Window owner, CheckupApiClient checkupApiClient, CreateBodyCompositionCommand command, bool hideMessage = false)
    {
        try
        {
            await checkupApiClient.CreateBodyCompositionAsync(command);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "CreateBodyCompositionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "CreateBodyCompositionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        catch (ApiClientException ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "CreateBodyCompositionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "CreateBodyCompositionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static async Task UpdateBodyCompositionAsync(
        IWin32Window owner, CheckupApiClient checkupApiClient
        , int bodyCompositionId, UpdateBodyCompositionCommand command, bool hideMessage = false)
    {
        try
        {
            await checkupApiClient.UpdateBodyCompositionAsync(bodyCompositionId, command);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "UpdateBodyCompositionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "UpdateBodyCompositionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        catch (ApiClientException ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "UpdateBodyCompositionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "UpdateBodyCompositionAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    public static async Task CreatDentalAsync(IWin32Window owner, CheckupApiClient checkupApiClient, CreateDentalCommand command, bool hideMessage = false)
    {
        try
        {
            await checkupApiClient.CreateDentalAsync(command);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "CreateDentalAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "CreateDentalAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        catch (ApiClientException ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "CreateDentalAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "CreateDentalAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static async Task UpdateDentalAsync(
        IWin32Window owner, CheckupApiClient checkupApiClient
        , int DentalId, UpdateDentalCommand command, bool hideMessage = false)
    {
        try
        {
            await checkupApiClient.UpdateDentalAsync(DentalId, command);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "UpdateDentalAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            if (!hideMessage)
                MessageBox.Show(owner, message, "UpdateDentalAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        catch (ApiClientException ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "UpdateDentalAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            if (!hideMessage)
                MessageBox.Show(owner, ex.Message, "UpdateDentalAsync", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static async Task<CkpClient.LabListViewModel> GetLabListWithClassFromCheckupAPI(string visiNumber, IWin32Window owner, CheckupApiClient checkupApiClient)
    {
        var labList = new CkpClient.LabListViewModel();
        try
        {
            labList = await checkupApiClient.GetLabListWithClassAsync(visiNumber);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            MessageBox.Show(owner, message, "GetCheckupItemGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            MessageBox.Show(owner, message, "GetCheckupItemGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException ex)
        {
            MessageBox.Show(owner, ex.Message, "GetCheckupItemGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(owner, ex.Message, "GetCheckupItemGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return labList;
    }

    public static async Task<CkpClient.XrayListViewModel> GetXrayListWithClassFromCheckupAPI(string visiNumber, IWin32Window owner, CheckupApiClient checkupApiClient)
    {
        var xrayList = new CkpClient.XrayListViewModel();
        try
        {
            xrayList = await checkupApiClient.GetXrayListWithClassAsync(visiNumber);
        }
        catch (ApiClientException<ValidationProblemDetails> ex)
        {
            string message = GetValidationErrorMessage(ex);
            MessageBox.Show(owner, message, "GetCheckupItemGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException<ProblemDetails> ex)
        {
            string message = GetProblemErrorMessage(ex);
            MessageBox.Show(owner, message, "GetCheckupItemGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (ApiClientException ex)
        {
            MessageBox.Show(owner, ex.Message, "GetCheckupItemGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(owner, ex.Message, "GetCheckupItemGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return xrayList;
    }

}
