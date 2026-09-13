using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DevExpress.Charts.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ClosedXML.Excel;
using DevExpress.XtraGrid.Views.Grid;
using DocumentFormat.OpenXml.Wordprocessing;
using Newtonsoft.Json.Linq;
using SUTH.HealthCheckup.WinFormsUI.Checkup.Api.Client;

namespace SUTH.HealthCheckup.WinFormsUI.Functions;
public class SuthFunctions
{
    #region Class Message Box
    public static class Message
    {
        public static void Success(string message)
        {
            DevTools.FunctionBase.ShadowForm(new Forms.MessageBox(message, MessageTypes.Success, false), GlobalVariables._MAINFORM);
        }
        public static void Success(string message, bool autoClose)
        {
            DevTools.FunctionBase.ShadowForm(new Forms.MessageBox(message, MessageTypes.Success, autoClose), GlobalVariables._MAINFORM);
        }
        public static void Error(string message)
        {
            DevTools.FunctionBase.ShadowForm(new Forms.MessageBox(message, MessageTypes.Error, false), GlobalVariables._MAINFORM);
        }
        public static void Error(string message, bool showdetail)
        {
            DevTools.FunctionBase.ShadowForm(new Forms.MessageBox(message, MessageTypes.Error, false) { showDetail = showdetail }, GlobalVariables._MAINFORM);
        }
        public static void Info(string message)
        {
            DevTools.FunctionBase.ShadowForm(new Forms.MessageBox(message, MessageTypes.Info, false), GlobalVariables._MAINFORM);
        }
        public static void Warning(string message)
        {
            DevTools.FunctionBase.ShadowForm(new Forms.MessageBox(message, MessageTypes.Warning, false), GlobalVariables._MAINFORM);
        }
        public static DialogResult ConfirmDialog(string message)
        {
            return DevTools.FunctionBase.ShadowForm(new Forms.MessageBox(message, MessageTypes.ConfirmDialog, false), GlobalVariables._MAINFORM);
        }
    }
    //public static string GetErrorMessage(ApiException<ProblemDetails> ex)
    //{
    //    string message = "";

    //    if (ex.StatusCode == 404)
    //    {
    //        if (!ex.Result.Detail.Contains("ไม่พบข้อมูล"))
    //            message = "ไม่พบข้อมูลที่ระบุ\n";
    //        message += ex.Result.Detail;

    //    }
    //    else if (ex.StatusCode == 400)
    //    {
    //        ProblemDetails detail = ex.Result;

    //        if (detail.AdditionalProperties.Count > 0)
    //        {
    //            var error = detail.AdditionalProperties["errors"];

    //            var dictionnary = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, object>>(error.ToString());


    //            foreach (KeyValuePair<string, object> entry in dictionnary)
    //            {
    //                string[] detailValue = ((Newtonsoft.Json.Linq.JArray)entry.Value).ToObject<string[]>();

    //                message += entry.Key + ": " + string.Join(",", detailValue) + "\n";

    //            }
    //        }
    //        else
    //        {
    //            message = detail.Detail;
    //        }
    //    }
    //    else
    //    {
    //        ProblemDetails detail = ex.Result;
    //        message = string.IsNullOrEmpty(detail.Detail) ? ex.Message : detail.Detail;
    //    }

    //    return message;
    //}
    #endregion
    #region Class Convert
    public static class Convert
    {
        public static void InitDataTableColumnFromDataModel<T>(T model, DataTable dataTable) where T : new()
        {
            var properties = TypeDescriptor.GetProperties(model);
            foreach (PropertyDescriptor prop in properties)
            {
                Console.WriteLine(string.Format("Name: {0}, Type: {1}", prop.Name, prop.PropertyType));
                if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
                {
                    try
                    {
                        dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(string.Format("Exception: {0} {1}, {2}", prop.Name, prop.PropertyType, ex.Message));
                    }
                }
                else
                {
                    try
                    {
                        dataTable.Columns.Add(prop.Name, prop.PropertyType);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(string.Format("Exception: {0} {1}, {2}", prop.Name, prop.PropertyType, ex.Message));
                    }
                }
            }
        }
        public static DataTable ConvertIEnumerableToDatatable<T>(IEnumerable<T> items)
        {
            var firstItem = items.FirstOrDefault();
            if (firstItem == null)
                return new DataTable();
            DataTable table = new DataTable(TypeDescriptor.GetClassName(firstItem));
            object[] Values;
            int i;
            var properties = TypeDescriptor.GetProperties(firstItem);
            foreach (PropertyDescriptor property in properties)
            {
                table.Columns.Add(property.Name, property.PropertyType);
            }
            foreach (T oItem in items)
            {
                Values = new object[properties.Count];
                for (i = 0; i < properties.Count; i++)
                    Values[i] = properties[i].GetValue(oItem);
                table.Rows.Add(Values);
            }
            return table;
        }

        public static bool ConvertToBoolean(object value)
        {
            try
            {
                bool rf;
                rf = System.Convert.ToBoolean(value);
                return rf;
            }
            catch
            {
                return false;
            }
        }
        public static Image ConvertFileToImage(string filename)
        {
            try
            {
                if (string.IsNullOrEmpty(filename)) return null;
                using (var fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    return Image.FromStream(fs);
                }
            }
            catch { return null; }
        }
    }
    #endregion
    #region Class Cryptography
    public static class Cryptography
    {
        public static string CreateMD5(string value)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(value);
                byte[] hasBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hasBytes.Length; i++)
                {
                    sb.Append(hasBytes[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }

        //public static string ByteToString(string value)
        //{
        //    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(value);
        //    var sb = new StringBuilder();
        //    foreach (var b in inputBytes)
        //    {
        //        sb.Append(b.ToString("X2"));
        //    }
        //    return sb.ToString();
        //}
        //public static bool IsValidMD5(string md5)
        //{
        //    return EasyEncryption.MD5.IsValidMD5(md5);
        //}
    }
    #endregion

    #region Functions
    #region Set validator
    public static ValidatorResultModel SetValidator(string jsonContent)
    {
        var properties = TypeDescriptor.GetProperties(new ValidatorResultModel());
        foreach (PropertyDescriptor prop in properties)
        {
            Console.WriteLine(prop.Name);
        }
        var validator = new ValidatorResultModel();
        JObject o = JObject.Parse(jsonContent);
        foreach (var x in o)
        {
            var cleantKey = System.Text.RegularExpressions.Regex.Replace(x.Key, @"[\[\]'\+]", string.Empty);
            validator.value = System.Text.RegularExpressions.Regex.Replace(x.Value.ToString(), @"["",\[\]\'\r\n+]", string.Empty);
            var keyArray = cleantKey.Split('.');
            if (keyArray.Count() > 1)
                validator.key = keyArray[1].Trim();
        }

        return validator;
    }
    public static List<string> ValidateData<T>(List<T> models, string key) where T : new()
    {
        List<string> errorList = new List<string>();
        ICollection<System.ComponentModel.DataAnnotations.ValidationResult> errResult = null;

        foreach (T item in models)
        {
            var name = item.GetType().GetProperties().Where(x => x.Name == key).First();
            foreach (var prop in item.GetType().GetProperties())
            {

                if (prop.PropertyType == typeof(object))
                    prop.SetValue(item, prop.GetValue(item).ToString());

            }
            var isValid = Validate(item, out errResult);
            if (!isValid)
            {
                foreach (var validateionResult in errResult)
                {
                    //errorList.Add(validateionResult.ErrorMessage);
                    // errorList.Add(string.Format("{0} : {1}", prop.Name, validateionResult.ErrorMessage));
                    errorList.Add(string.Format("{0}: {1}, [error] >> {2}", key, name.GetValue(item), validateionResult.ErrorMessage));
                }
            }
        }
        return errorList;
    }
    private static bool Validate<T>(T obj, out ICollection<ValidationResult> results)
    {
        results = new List<ValidationResult>();
        return System.ComponentModel.DataAnnotations.Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);
    }
    #endregion
    #region Add form in panel
    public static void FormInPanel(Panel panel, object _Form)
    {
        if (panel.Controls.Count > 0)
            panel.Controls.RemoveAt(0);
        Form f = _Form as Form;
        f.TopLevel = false;
        f.Dock = DockStyle.Fill;
        panel.Controls.Add(f);
        panel.Tag = f;
        f.Show();
    }
    #endregion
    #region Input box
    public static string InputBox(string caption)
    {
        Forms.InputBox inputBox = new Forms.InputBox(caption);
        if (DevTools.FunctionBase.ShadowForm(inputBox, GlobalVariables._MAINFORM) == System.Windows.Forms.DialogResult.OK)
            return inputBox.result;
        else
            return "";
    }
    public static string InputBox(string caption, string value)
    {
        Forms.InputBox inputBox = new Forms.InputBox(caption) { result = value };
        if (DevTools.FunctionBase.ShadowForm(inputBox, GlobalVariables._MAINFORM) == System.Windows.Forms.DialogResult.OK)
            return inputBox.result;
        else
            return "";
    }
    #endregion
    #region Grid View
    public static void GridviewClearRows(DevExpress.XtraGrid.Views.Grid.GridView view)
    {
        for (int i = 0; i < view.RowCount;)
            view.DeleteRow(i);
    }
    public static List<object> GetSelectRowCellValue(DevExpress.XtraGrid.Views.Grid.GridView view, string ColumnName)
    {
        List<object> _value = new List<object>();
        var rows = view.GetSelectedRows();
        foreach (int rowHandle in rows)
        {
            if (rowHandle >= 0)
            {
                _value.Add(view.GetRowCellDisplayText(rowHandle, ColumnName));
            }
        }
        return _value;
    }
    public static List<string> GetSelectRowCellValueWithoutEmpty(DevExpress.XtraGrid.Views.Grid.GridView view, string ColumnName)
    {
        List<string> _value = new List<string>();

        var rows = view.GetSelectedRows();

        foreach (int rowHandle in rows)
        {
            if (rowHandle >= 0)
            {
                if (!string.IsNullOrEmpty(view.GetRowCellDisplayText(rowHandle, ColumnName).ToString()))
                    _value.Add(view.GetRowCellDisplayText(rowHandle, ColumnName).ToString());
            }
        }
        return _value;
    }

    public static List<List<string>> GetSelectRowCellValueWithoutEmpty(DevExpress.XtraGrid.Views.Grid.GridView view, List<string> columnName, string filter)
    {
        List<List<string>> _value = new List<List<string>>();

        var rows = view.GetSelectedRows().Where(handle => view.IsDataRow(handle) && view.GetRowCellValue(handle, "SendType")?.ToString() == filter).ToArray(); ;
        //view.ActiveFilterString = filter;

        foreach (int rowHandle in rows)
        {
            if (rowHandle >= 0)
            {
                //if (!string.IsNullOrEmpty(view.GetRowCellDisplayText(rowHandle, ColumnName).ToString()))
                //    _value.Add(view.GetRowCellDisplayText(rowHandle, ColumnName).ToString());
                List<string> values = new List<string>();
                foreach (string column in columnName)
                {
                    if (!string.IsNullOrEmpty(view.GetRowCellDisplayText(rowHandle, column).ToString()))
                    {
                        values.Add(view.GetRowCellDisplayText(rowHandle, column).ToString());
                    }
                }
                _value.Add(values);
            }
        }
        view.ActiveFilterString = string.Empty;
        return _value;
    }
    public static List<string> GetAllRowCellValue(DevExpress.XtraGrid.Views.Grid.GridView view, string ColumnName)
    {
        List<string> _value = new List<string>();
        for (int rowHandle = 0; rowHandle < view.RowCount; rowHandle++)
        {
            if (rowHandle >= 0)
            {
                if (!string.IsNullOrEmpty(view.GetRowCellValue(rowHandle, ColumnName).ToString()))
                    _value.Add(view.GetRowCellValue(rowHandle, ColumnName).ToString());
            }
        }
        return _value;
    }
    #endregion
    #region Json
    public static string JsonDeserializeAsString(string jsonString)
    {
        //var j = JsonConvert.DeserializeObject(jsonString);
        return "";
    }
    #endregion

    public static string GetAnShortText(string shortAn)
    {
        string value = "";
        if (shortAn.Contains("/"))
        {
            var subArray = shortAn.Split('/');
            if (!string.IsNullOrEmpty(subArray[0]) && subArray.Length > 1)
                value = string.Format("{0}{1}", subArray[0], subArray[1].PadLeft(7, '0'));
        }
        else
            value = shortAn;
        return value;
    }
    #endregion

    #region Export File
    public static void ExportToExcel(DevExpress.XtraGrid.GridControl Ctrl)
    {
        try
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2007)(.xlsx)|*.xlsx|Excel (2003) (.xls)|*.xls";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    var advOptions = new DevExpress.XtraPrinting.XlsxExportOptionsEx();
                    advOptions.AllowSortingAndFiltering = DevExpress.Utils.DefaultBoolean.True;
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            Ctrl.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            Ctrl.ExportToXlsx(exportFilePath, advOptions);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    //public static void ExportToExcelWithPostoneTemplate(DevExpress.XtraGrid.GridControl Ctrl)
    //{
    //    try
    //    {
    //        // 1. ดึงไฟล์ template จาก Resource ไปยัง Temp
    //        string templateFileName = "Postone_Template_1_2.xlsx";
    //        string tempPath = Path.Combine(Path.GetTempPath(), templateFileName);

    //        // Extract resource to temp (replace if exists)
    //        ExtractResourceToTemp(templateFileName, tempPath);

    //        using (SaveFileDialog saveDialog = new SaveFileDialog())
    //        {
    //            saveDialog.FileName = string.Format("Postone_{0}_{1}"
    //                , DateTime.Now.ToString("yyyyMMdd", new CultureInfo("en-US"))
    //                , DateTime.Now.ToString("HHmmss", new CultureInfo("en-US"))
    //                );
    //            saveDialog.Filter = "Excel (2007)(.xlsx)|*.xlsx";
    //            if (saveDialog.ShowDialog() != DialogResult.Cancel)
    //            {
    //                string exportFilePath = saveDialog.FileName;

    //                // โหลดไฟล์ template
    //                using (var workbook = new XLWorkbook(tempPath))
    //                {
    //                    var worksheet = workbook.Worksheet(1);

    //                    int rowNumber = 3; // เริ่มจากแถวที่ 3 (หลังหัวคอลัมน์)

    //                    GridView gridView = Ctrl.MainView as GridView;
    //                    gridView.Columns["ModifiedDatetime"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
    //                    // วนลูปข้อมูลจาก GridControl
    //                    for (int i = 0; i < Ctrl.MainView.RowCount; i++)
    //                    {
    //                        // กรองเฉพาะแถวที่มี LastTrackingNumber
    //                        var lastTrackingNumber = gridView.GetRowCellValue(i, "LastTrackingNumber")?.ToString();
    //                        if (string.IsNullOrWhiteSpace(lastTrackingNumber))
    //                            continue; // ข้ามแถวที่ไม่มีข้อมูล

    //                        // ตัวอย่างการเติมข้อมูล (ปรับตามคอลัมน์ของคุณ)
    //                        var codAccount = "0828544988";// gridView.GetRowCellValue(i, "CODAccount")?.ToString() ?? null;
    //                        var codObj = gridView.GetRowCellValue(i, "Cod")?.ToString() ?? null;
    //                        if (!int.TryParse(codObj, out int cod))
    //                        {
    //                            cod = 0;
    //                        }
    //                        var name = gridView.GetRowCellValue(i, "Name")?.ToString() ?? null;
    //                        var hn = gridView.GetRowCellValue(i, "Hn")?.ToString() ?? null;
    //                        var phone = gridView.GetRowCellValue(i, "ContactNumber")?.ToString() ?? null;
    //                        var address = gridView.GetRowCellValue(i, "Address")?.ToString() ?? null;
    //                        var postalCode = gridView.GetRowCellValue(i, "ZipCode")?.ToString() ?? null;

    //                        // เติมข้อมูลลงในคอลัมน์ที่กำหนด
    //                        worksheet.Cell(rowNumber, 5).Value = "E";
    //                        worksheet.Cell(rowNumber, 7).Value = codAccount; // COD Account
    //                        worksheet.Cell(rowNumber, 8).Value = cod; // COD
    //                        worksheet.Cell(rowNumber, 10).Value = string.Format("{0}, {1}", name, hn); // ชื่อ-สกุล, Hn
    //                        worksheet.Cell(rowNumber, 11).Value = phone; // เบอร์โทร
    //                        worksheet.Cell(rowNumber, 12).Value = address; // ที่อยู่
    //                        worksheet.Cell(rowNumber, 13).Value = postalCode; // รหัสไปรษณีย์

    //                        rowNumber++;
    //                    }

    //                    // บันทึกไฟล์
    //                    workbook.SaveAs(exportFilePath);
    //                }

    //                if (File.Exists(exportFilePath))
    //                {
    //                    try
    //                    {
    //                        System.Diagnostics.Process.Start(exportFilePath);
    //                    }
    //                    catch
    //                    {
    //                        String msg = "ไฟล์ไม่สามารถเปิดได้\n\nPath: " + exportFilePath;
    //                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //                    }
    //                }
    //            }
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show(ex.Message);
    //    }
    //}

    // ฟังก์ชัน Extract Resource ไป Temp
    //private static void ExtractResourceToTemp(string resourceName, string outputPath)
    //{
    //    try
    //    {
    //        // ลบไฟล์เก่าถ้ามีอยู่
    //        byte[] resourceContent = Properties.Resources.Postone_Template_1_2; // Your embedded resource
    //        File.WriteAllBytes(outputPath, resourceContent);
    //        //if (!File.Exists(outputPath))
    //        //{
    //        //    byte[] resourceContent = Properties.Resources.Postone_Template_1_2; // Your embedded resource
    //        //    File.WriteAllBytes(outputPath, resourceContent);
    //        //}
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show($"ข้อผิดพลาดในการ Extract Resource: {ex.Message}", "Error!",
    //            MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }
    //}

    public static List<(string Name, string Tracking)> ReadExcelData(string filePath)
    {
        List<(string Name, string Tracking)> data = new List<(string, string)>();

        try
        {
            // ตรวจสอบข้อมูลเริ่มต้นของไฟล์เพื่อดูว่าเป็น HTML หรือไม่
            string firstBytes = "";
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                byte[] buffer = new byte[100];
                int read = stream.Read(buffer, 0, buffer.Length);
                firstBytes = Encoding.UTF8.GetString(buffer, 0, read).TrimStart('\uFEFF', ' ', '\r', '\n', '\t');
            }

            bool isHtml = firstBytes.StartsWith("<html", StringComparison.OrdinalIgnoreCase) ||
                          firstBytes.StartsWith("<table", StringComparison.OrdinalIgnoreCase) ||
                          firstBytes.StartsWith("<!doctype", StringComparison.OrdinalIgnoreCase) ||
                          firstBytes.StartsWith("<tr", StringComparison.OrdinalIgnoreCase);

            if (isHtml)
            {
                string fileContent = File.ReadAllText(filePath, Encoding.UTF8);
                data = ParseHtmlTable(fileContent);

                // หากไม่พบข้อมูล (อาจมีปัญหาเรื่องการถอดรหัสภาษาไทย) ให้ลองใช้ Encoding Windows-874
                if (data.Count == 0)
                {
                    try
                    {
                        string fallbackContent = File.ReadAllText(filePath, Encoding.GetEncoding("windows-874"));
                        data = ParseHtmlTable(fallbackContent);
                    }
                    catch { }
                }
            }
            else
            {
                // กรณีที่เป็นไฟล์ Excel (.xlsx) จริง ให้ใช้ ClosedXML ตามเดิม
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1);

                    // วนลูปผ่านทุกแถว (เริ่มจากแถวที่ 2 เพื่อข้ามหัวคอลัมน์)
                    foreach (var row in worksheet.Rows())
                    {
                        if (row.RowNumber() == 1) continue; // ข้ามหัวคอลัมน์

                        // หาคอลัมน์ที่ต้องการ
                        var nameCell = row.FirstCell().Worksheet.Cell(row.RowNumber(),
                            GetColumnNumber(worksheet, "ชื่อผู้รับ"));
                        var trackingCell = row.FirstCell().Worksheet.Cell(row.RowNumber(),
                            GetColumnNumber(worksheet, "Tracking"));

                        string name = nameCell.Value.ToString();
                        string tracking = trackingCell.Value.ToString();

                        if (!string.IsNullOrWhiteSpace(name) || !string.IsNullOrWhiteSpace(tracking))
                        {
                            data.Add((name, tracking));
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"ข้อผิดพลาด: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return data;
    }

    private static List<(string Name, string Tracking)> ParseHtmlTable(string htmlContent)
    {
        List<(string Name, string Tracking)> parsedData = new List<(string, string)>();

        var rxRow = new Regex(@"<tr\b[^>]*>(.*?)<\/tr>", RegexOptions.IgnoreCase | RegexOptions.Singleline);
        var rxCell = new Regex(@"<td\b[^>]*>(.*?)<\/td>", RegexOptions.IgnoreCase | RegexOptions.Singleline);

        var rows = rxRow.Matches(htmlContent);
        if (rows.Count == 0) return parsedData;

        int nameColIndex = -1;
        int trackingColIndex = -1;
        bool foundHeaders = false;

        foreach (Match rowMatch in rows)
        {
            var rowContent = rowMatch.Groups[1].Value;
            var cells = rxCell.Matches(rowContent);

            List<string> cellValues = new List<string>();
            foreach (Match cellMatch in cells)
            {
                cellValues.Add(StripHtmlTags(cellMatch.Groups[1].Value));
            }

            if (cellValues.Count == 0) continue;

            if (!foundHeaders)
            {
                // ค้นหาคอลัมน์ที่สอดคล้องกับหัวตาราง
                for (int i = 0; i < cellValues.Count; i++)
                {
                    string header = cellValues[i];
                    if (header.Equals("ชื่อผู้รับ", StringComparison.OrdinalIgnoreCase))
                    {
                        nameColIndex = i;
                    }
                    else if (header.Equals("Tracking", StringComparison.OrdinalIgnoreCase))
                    {
                        trackingColIndex = i;
                    }
                }

                if (nameColIndex != -1 || trackingColIndex != -1)
                {
                    foundHeaders = true;
                }
            }
            else
            {
                // อ่านข้อมูลในแถวนั้นๆ
                string name = nameColIndex != -1 && nameColIndex < cellValues.Count ? cellValues[nameColIndex] : "";
                string tracking = trackingColIndex != -1 && trackingColIndex < cellValues.Count ? cellValues[trackingColIndex] : "";

                //// ล้างชื่อผู้รับถ้ามีรหัส HN ต่อท้าย เช่น "นาย สมชาย, 12345678" -> "นาย สมชาย"
                //if (!string.IsNullOrEmpty(name) && name.Contains(","))
                //{
                //    name = name.Split(',')[0].Trim();
                //}

                if (!string.IsNullOrWhiteSpace(name) || !string.IsNullOrWhiteSpace(tracking))
                {
                    parsedData.Add((name, tracking));
                }
            }
        }

        return parsedData;
    }

    private static string StripHtmlTags(string html)
    {
        if (string.IsNullOrEmpty(html)) return "";
        var text = html.Replace("&nbsp;", " ").Replace("&amp;", "&");
        text = Regex.Replace(text, @"<[^>]*>", "");
        return text.Trim();
    }

    // ฟังก์ชันหาหมายเลขคอลัมน์จากชื่อคอลัมน์
    private static int GetColumnNumber(IXLWorksheet worksheet, string columnName)
    {
        for (int col = 1; col <= worksheet.Columns().Count(); col++)
        {
            if (worksheet.Cell(1, col).Value.ToString() == columnName)
                return col;
        }
        return -1; // ไม่พบ
    }

    #endregion
}

public class ValidatorResultModel
{
    public string key { get; set; }
    public object value { get; set; }
}
