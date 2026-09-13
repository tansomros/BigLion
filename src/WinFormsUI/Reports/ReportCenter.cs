using System.Collections;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using DevTools;
using Newtonsoft.Json;
using SUTH.HealthCheckup.WinFormsUI.Checkup.Api.Client;
using SUTH.HealthCheckup.WinFormsUI.Functions;
using SUTH.HealthCheckup.WinFormsUI.Functions.CustomDatabase;
using SUTH.HealthCheckup.WinFormsUI.Interfaces;
using SUTH.HealthCheckup.WinFormsUI.Models;

namespace SUTH.HealthCheckup.WinFormsUI.Reports;
public partial class ReportCenter : DevExpress.XtraEditors.XtraForm
{
    #region variables
    List<CustomReportParameter> _reportParameters;
    //List<ReportTemplateViewModel> reportList = new List<ReportTemplateViewModel>();
    private readonly IUserContext _userContext;
    private readonly CheckupApiClient _checkupApiClient;
    private readonly IAuthenticationService _authenticationService;
    Form frmDlg;
    readonly DateEdit[] dtPicker = new DateEdit[4];
    readonly Label[] lblArray = new Label[20];
    Button btOK;
    //DevExpress.XtraEditors.ComboBox[] ComboBoxArray = new DevExpress.XtraEditors.ComboBox[4];
    DevExpress.XtraEditors.LookUpEdit[] ComboBoxArray = new LookUpEdit[4];
    DevExpress.XtraEditors.CheckedComboBoxEdit checkedCombo;
    readonly List<DevExpress.XtraEditors.TextEdit> lstTextBox = new List<TextEdit>();
     //Dictionary<string, object> _reportParameters = new Dictionary<string, object>();

    Point _location = new Point(48, 23);

    readonly List<string> _lstParameter = new List<string>();
    readonly List<string> _lstParameterDate = new List<string>();
    bool validDatetimePicker, validCombobox, validTextBox;
    string combo_command = "";
    Int32 subreportId = 0;
    //readonly DatabaseAccess dbAccess = new DatabaseAccess(); 

    int formHeigth = 20;
    #endregion
    public ReportCenter(IUserContext userContext, CheckupApiClient checkupApiClient, IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
        _checkupApiClient = checkupApiClient;
        _userContext = userContext;
        InitializeComponent();
    }
    #region Layout Control
    void InitializeFormDialog()
    {
        formHeigth = 20;

        frmDlg = new Form();
        frmDlg.StartPosition = FormStartPosition.CenterScreen;
        frmDlg.Width = 434;
        frmDlg.Height = 160; //165;            
        frmDlg.MaximizeBox = false;
        frmDlg.MinimizeBox = false;
        frmDlg.ShowIcon = false;
        frmDlg.ShowInTaskbar = false;
        frmDlg.Font = new Font("Segoe UI", 10);

        btOK = new System.Windows.Forms.Button();
        frmDlg.SuspendLayout();

        // 
        // btOK
        // 
        //btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        btOK.Location = new System.Drawing.Point(180, 85);
        btOK.Name = "btOK";
        btOK.Size = new System.Drawing.Size(76, 26);
        btOK.TabIndex = 2;
        btOK.Text = "OK";
        btOK.UseVisualStyleBackColor = true;
        btOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
        btOK.Click += new System.EventHandler(this.btOK_Click);

        frmDlg.Controls.Add(btOK);
        frmDlg.ResumeLayout(false);
    }
    private Control dateTimePicker(int index)
    {
        //formHeigth = 20;
        dtPicker[index] = new DateEdit();
        dtPicker[index].Name = "dt";
        dtPicker[index].Size = new Size(155, 20);
        dtPicker[index].Font = new Font("Segoe UI", 10);
        if (index == 0)
        {
            dtPicker[index].Location = _location;
            _location.X = 245;
            formHeigth = dtPicker[index].Height + 10;
        }
        else
        {
            dtPicker[index].Location = _location;
            if (index % 2 != 0)
            {
                _location.X = 48;
                _location.Y += 45;
            }
            else
            {
                _location.X = 245;
                formHeigth = formHeigth + dtPicker[index].Height + 10;
            }
        }
        //LocationY = dtPicker[index]._location.Y + dtPicker[index].Height;
        return dtPicker[index];
    }
    private Control comboBox(int index, string AccessibleName)
    {
        //ComboBoxArray[index] = new DevExpress.XtraEditors.ComboBox();
        //ComboBoxArray[index].Width = 352;
        //ComboBoxArray[index]._location = _location;
        //ComboBoxArray[index].Properties.Appearance.Font = new Font("Segoe UI", 10);
        //ComboBoxArray[index].Properties.AppearanceDropDown.Font = new Font("Segoe UI", 10);
        //ComboBoxArray[index].Properties.AccessibleName = AccessibleName;

        ComboBoxArray[index] = new LookUpEdit();
        ComboBoxArray[index].Width = 352;
        ComboBoxArray[index].Location = _location;
        ComboBoxArray[index].Properties.Appearance.Font = new Font("Segoe UI", 10);
        ComboBoxArray[index].Properties.AppearanceDropDown.Font = new Font("Segoe UI", 10);
        ComboBoxArray[index].Properties.NullText = "";
        //ComboBoxArray[index].Properties.Columns[0].Visible = false;
        ComboBoxArray[index].Properties.ShowHeader = false;
        ComboBoxArray[index].AccessibleName = AccessibleName;

        _location.Y += 45; //35
        formHeigth = formHeigth + 20;

        return ComboBoxArray[index];
    }
    private Control label(int index, Point LocXY, string TextName)
    {
        lblArray[index] = new Label();
        lblArray[index].Text = TextName;
        lblArray[index].AutoSize = true;
        //lblArray[index]._location = new Point(LocXY.X, LocXY.Y);
        return lblArray[index];
    }
    private Control CheckedComboBox(string AccessibleName)
    {
        //formHeigth = formHeigth + 20;
        checkedCombo = new DevExpress.XtraEditors.CheckedComboBoxEdit();
        checkedCombo.Width = 352;
        checkedCombo.Properties.Appearance.Font = new Font("Segoe UI", 10);
        checkedCombo.Properties.AppearanceDropDown.Font = new Font("Segoe UI", 10);
        checkedCombo.Location = _location;//new Point(48, LocationY + 10);
        checkedCombo.Properties.AccessibleName = AccessibleName;
        _location.Y += 45;
        formHeigth = formHeigth + 20;
        return checkedCombo;
    }
    private Control textBox(string AccessibleName)
    {
        TextEdit textBox = new TextEdit();
        textBox.Font = new Font("Segoe UI", 10);
        textBox.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center; // = HorizontalAlignment.Center;
        textBox.Location = _location; //new Point(48, LocationY + 10);
        textBox.AccessibleName = AccessibleName;
        _location.Y += 45;
        formHeigth = formHeigth + 20;
        lstTextBox.Add(textBox);
        return textBox;
    }
    private void RefreshLayout(int index, Control Ctrl)
    {
        if (lblArray[index].Width > 28)
        {
            int lblWidth = lblArray[index].Width - 33;
            Ctrl.Size = new Size(Ctrl.Width - lblWidth, Ctrl.Height);
            Ctrl.Location = new Point(Ctrl.Location.X + lblWidth, Ctrl.Location.Y);
        }

        int LocX = (Ctrl.Location.X - lblArray[index].Width) - 5;
        lblArray[index].Location = new Point(LocX, Ctrl.Location.Y + 4);
        if (Ctrl.Location.Y > 70)
        {
            frmDlg.Size = new Size(frmDlg.Width, frmDlg.Height + 40);
        }
    }
    #endregion

    private async void ReportCenter_Load(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Maximized;   

        var reports = await _checkupApiClient.GetReportTemplateListAsync();
        //var allRoleReport = await _checkupApiClient.GetRoleReportTemplateListAsync();

        // รายงานที่ถูกระบุสิทธิ์การใช้งาน
        //var roleReportIds = allRoleReport.Where(x => x.ReportTemplateIds != null).SelectMany(x => x.ReportTemplateIds).ToList();

        var user = _userContext.CurrentUser;
        // สิทธิ์ Admin
        if (user.HasAdminRole)
        {
            gridControlReportName.DataSource = reports.ReportTemplates;
            return;
        }
        // สิทธิ์การใช้งานรายงานตาม Login
        //var roleReport = await _checkupApiClient.GetUserRoleReportAccessibleAsync(CurrentUserService.Username);
        //if (!roleReport.Any())
        //{
        //    FunctionBase.MessageBox("ไม่พบสิทธิ์การเข้าใช้งาน", "แจ้งเตือน", MessageBoxIcon.Warning);
        //    return;
        //}

        // ตรวจสอบว่ามีสิทธิ์ในการมองเห็นรายงานทั้งหมด
        //if (roleReport.Any() && roleReport.First().Id == -1)
        //{
        //    // แยกรายงานที่ถูกระบุสิทธิ์ออกจากรายงานทั้งหมด
        //    reportList.AddRange(reports.Where(x => roleReportIds.Contains(Convert.ToInt32(x.Id)) == false && x.Active).OrderBy(o => o.Sort).ThenBy(t => t.ReportName).ToList());
        //    //gridControlReportName.DataSource = reportList;
        //    //return;
        //}

        //// สิทธิ์การเข้าถึงรายงานของ Login
        //var reportIds = roleReport.Where(x => x.Id != -1).SelectMany(x => x.ReportTemplateIds).ToList();
        //reportList.AddRange(reports.Where(x => reportIds.Contains(Convert.ToInt32(x.Id)) && x.Active).OrderBy(o => o.Sort).ThenBy(t => t.ReportName).ToList());

        //// เรียงลำดับรายงาน
        //reportList = reportList.OrderBy(o => o.Sort).ThenBy(t => t.ReportName).ToList();
        //gridControlReportName.DataSource = reportList;
    }

    private void viewReportName_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
    {
        if (e.Info is GridGroupRowInfo info)
        {
            info.GroupText = info.GroupValueText;
        }
    }

    private async void RunReport()
    {
        if (viewReportName.FocusedRowHandle < 0) return;

        _reportParameters = new List<CustomReportParameter>();
        lstTextBox.Clear();
        _lstParameter.Clear();
        _lstParameterDate.Clear();
        viewReportResult.Columns.Clear();
        gridControlReportResult.DataSource = null;
        gridControlReportResult.Focus();
        _location = new Point(48, 23);
        combo_command = "";
        try
        {
            DataTable dtResult = new DataTable();

            var ReportDetail = await _checkupApiClient.GetReportTemplateDetailAsync(Convert.ToInt32(viewReportName.GetFocusedRowCellValue(colReportUID).ToString()));

            if (ReportDetail.Details != null && ReportDetail.Details.Any())
            {
                int i = 0, indexComboBox = 0;
                var rowsComboBox = ReportDetail.Details.Select(r => r.ControlType.Equals("ComboBox")).ToList().FindAll(x => x.Equals(true));
                ComboBoxArray = new LookUpEdit[rowsComboBox.Count];

                var _chkCombo = ReportDetail.Details.Select(r => r.ControlType.Equals("CheckedComboBox")).ToList().FindAll(x => x.Equals(true));
                if (_chkCombo.Count > 0)
                    checkedCombo = new DevExpress.XtraEditors.CheckedComboBoxEdit();

                InitializeFormDialog();

                foreach (var item in ReportDetail.Details)
                {
                    _lstParameter.Add(item.Parameters);

                    switch (item.ControlType)
                    {
                        case "DateTimePicker":
                            frmDlg.Controls.Add(dateTimePicker(i));
                            frmDlg.Controls.Add(label(i, dtPicker[i].Location, item.Description));
                            dtPicker[i].EditValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
                            dtPicker[i].Properties.AccessibleName = item.Parameters;
                            RefreshLayout(i, dtPicker[i]);

                            _lstParameterDate.Add(item.Parameters);
                            break;
                        case "ComboBox":
                            frmDlg.Controls.Add(comboBox(indexComboBox, item.Parameters));
                            frmDlg.Controls.Add(label(i, ComboBoxArray[indexComboBox].Location, item.Description));
                            //frmDlg.Size = new Size(frmDlg.Width, frmDlg.Height + 25);
                            if (!string.IsNullOrEmpty(item.Sql))
                            {
                                ArrayList value = new ArrayList();
                                combo_command = item.Sql;
                                subreportId = item.Id;
                                //if (viewReportName.GetFocusedRowCellValue(colReportDB).ToString().ToUpper() == "HOSXP")
                                //{
                                //    Dictionary<object, object> param = new Dictionary<object, object>();
                                //    var paramcount = item.Sql.Split('@');
                                //    for (int ii = 0; ii > paramcount.Length; ii++)
                                //    {
                                //        param.Add(item.Parameters, DevTools.FunctionBase.ConvertToDateTimeString(dtPicker[ii].EditValue.ToString(), "yyyy-MM-dd"));
                                //    }
                                //}

                                ComboBoxArray[indexComboBox].Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = item.ValueMember, Caption = "Code", Visible = false });
                                ComboBoxArray[indexComboBox].Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo() { FieldName = item.DisplayMember, Caption = "Name" });
                                ComboBoxArray[indexComboBox].Properties.ValueMember = item.ValueMember;
                                ComboBoxArray[indexComboBox].Properties.DisplayMember = item.DisplayMember;
                                dtResult = GetDataToCombo(subreportId);
                                if (dtResult != null && dtResult.Rows.Count > 0)
                                {
                                    ComboBoxArray[indexComboBox].Properties.DataSource = dtResult;
                                    var bb = ComboBoxArray[indexComboBox].Properties.Columns;
                                }
                            }
                            break;
                        case "CheckedComboBox":
                            frmDlg.Controls.Add(CheckedComboBox(item.Parameters));
                            frmDlg.Controls.Add(label(i, checkedCombo.Location, item.Description));
                            if (!string.IsNullOrEmpty(item.Sql))
                            {
                                combo_command = item.Sql;
                                subreportId = item.Id;

                                checkedCombo.Properties.ValueMember = item.ValueMember;
                                checkedCombo.Properties.DisplayMember = item.DisplayMember;

                            }
                            RefreshLayout(i, checkedCombo);
                            dtResult = GetDataToCombo(subreportId);
                            //checkedCombo.Properties.DataSource = dtResult;
                            foreach (DataRow row in dtResult.Rows)
                            {
                                if (row.ItemArray.Length == 1)
                                    checkedCombo.Properties.Items.AddRange(row.ItemArray);
                                else
                                    checkedCombo.Properties.Items.Add(row.ItemArray[0], row.ItemArray[1].ToString());
                            }
                            break;
                        case "TextBox":
                            frmDlg.Controls.Add(textBox(item.Parameters));
                            foreach (var txtBox in lstTextBox)
                            {
                                frmDlg.Controls.Add(label(i, txtBox.Location, item.Description));
                                RefreshLayout(i, txtBox);
                            }
                            break;
                    }
                    i++;
                }

                validDatetimePicker = false;
                validCombobox = false;

                foreach (Control ctrl in frmDlg.Controls)
                {
                    if (ctrl is DateEdit)
                        validDatetimePicker = true;
                    if (ctrl is LookUpEdit)
                        validCombobox = true;
                    if (ctrl is TextEdit)
                        validTextBox = true;
                }

                frmDlg.AutoSize = true;
                frmDlg.Padding = new Padding(0, 0, 10, 0);
                frmDlg.AutoSize = false;

                if (formHeigth < 52) frmDlg.Size = new Size(frmDlg.Width, 160);
                else if (formHeigth < 100) frmDlg.Size = new Size(frmDlg.Width, 180);
                else frmDlg.Size = new Size(frmDlg.Width, 240);

                frmDlg.ShowDialog();
            }
            else
            {
                //RunProcess();
            }
        }
        catch (Exception ex)
        {
            SuthFunctions.Message.Error(ex.Message);
        }

    }

    #region Event Control
    private void DateTimePicker_ValueChanged(object sender, EventArgs e)
    {
        if (checkedCombo != null)
            if (checkedCombo.Visible)
            {
                var dtResult = GetDataToCombo(subreportId);
                checkedCombo.Properties.Items.Clear();
                foreach (DataRow row in dtResult.Rows)
                    checkedCombo.Properties.Items.Add(row.ItemArray[0], row.ItemArray[1].ToString());
            }
    }

    private  void btOK_Click(object sender, EventArgs e)
    {
        GetValueControl();
        RunProcess();
    }
    #endregion
    #region Functions
    private void RunProcess()
    {
        var id = viewReportName.GetFocusedRowCellValue(colReportUID).ToString();
        string errMessage = "";

        FunctionBase.Waitform(() => errMessage = RunReport(Convert.ToInt32(id)), GlobalVariables._MAINFORM);

        //ActivityLogReportCreateCommand log = new ActivityLogReportCreateCommand();
        //log.IpAddress = GlobalVariables.IPAdress;
        //log.ClientName = GlobalVariables.ComputerName;
        //log.Operation = "VIEW";
        //log.ReportName = viewReportName.GetFocusedRowCellValue(colReportName).ToString();
        //log.UserCode = CurrentUserService.Username;
        //_checkupApiClient.CreateLogReportAsync(log);

        if (!string.IsNullOrEmpty(errMessage))
            MessageBox.Show(errMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        if (frmDlg != null)
            frmDlg.Close();
    }

    private DataTable GetDataToCombo(Int64 Id)
    {
        DataTable dtResult = new DataTable();
        Dictionary<string, object> param = new Dictionary<string, object>();
        int ii = 0;
        foreach (var item in _lstParameterDate)
        {
            param.Add(item, DevTools.FunctionBase.ConvertToDateTimeString(dtPicker[ii].EditValue?.ToString() ?? "", "yyyy-MM-dd"));
            ii++;
        }
        var tb = Task.Run(async () => await _checkupApiClient.ExecuteReportAsync(Convert.ToInt32(Id), "", param)); //CustomCommand.ExecuteSubReport(Id,dbAccess.ToString(), param));
        tb.Wait();
        if (tb.Result.DataResult != null)
        {
            var deserialized = JsonConvert.DeserializeObject(tb.Result.DataResult.ToString(), typeof(DataTable));
            if (deserialized is DataTable dt) dtResult = dt;
        }

        tb.Dispose();

        return dtResult;
    }

    private void btExcelExport_Click(object sender, EventArgs e)
    {
        if (viewReportResult.RowCount > 0)
        {
            SuthFunctions.ExportToExcel(gridControlReportResult);
            //ActivityLogReportCreateCommand log = new ActivityLogReportCreateCommand();
            //log.IpAddress = GlobalVariables.IPAdress;
            //log.ClientName = GlobalVariables.ComputerName;
            //log.Operation = "EXPORT";
            //log.ReportName = viewReportName.GetFocusedRowCellValue(colReportName).ToString();
            //log.UserCode = CurrentUserService.Username;
            //_checkupApiClient.CreateLogReportAsync(log);
        }
    }

    private void repositoryItemButtonRun_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
    {
        RunReport();
    }

    private void btRunReport_Click(object sender, EventArgs e)
    {

    }

    private void viewReportName_DoubleClick(object sender, EventArgs e)
    {
        if (viewReportName.FocusedRowHandle > 0)
            RunReport();
    }

    private string RunReport(Int32 Id)
    {
        Application.DoEvents();
        string error = "";
        DataTable dtResult = new DataTable();
        CustomReportResultViewModel result = new CustomReportResultViewModel();

        var t = Task.Run(async () => await _checkupApiClient.GetReportTemplateIdAsync(Id));
        t.Wait();
        var report = t.Result;
        t.Dispose();
        var tb = Task.Run(() =>
        {
            try
            {               
                    dtResult = CustomReportHelpers.Checkup.FromSql(report.SqlText, _reportParameters);
                           
            }        
            catch (Exception ex)
            {
                error = ex.Message;
            }
        });
        tb.Wait();
        if (result.Result != null)
        {
            dtResult = (DataTable)JsonConvert.DeserializeObject(result.Result.ToString(), (typeof(DataTable)));
        }
        tb.Dispose();

        if (!string.IsNullOrWhiteSpace(error)) return error;
        if (dtResult == null || dtResult.Rows.Count == 0) return "";
        gridControlReportResult.BeginInvoke(new MethodInvoker(delegate
        {
            DataTable dt = dtResult.Clone();
            try
            {
                dt.Rows.Add(dtResult.Rows[0].ItemArray);
                gridControlReportResult.DataSource = dt;
                viewReportResult.BestFitColumns();
            }
            catch { }
            gridControlReportResult.DataSource = dtResult;
        }));
        return "";
    }

    private void btnBestFitColumn_Click(object sender, EventArgs e)
    {
        viewReportResult.BestFitColumns();
    }

    private void btnPreview_Click(object sender, EventArgs e)
    {
        try
        {
            var rpt = XtraReport.FromFile(viewReportName.GetFocusedRowCellDisplayText("ReportFileName"));
            rpt.ShowPreviewDialog();

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void ReportDesigner_ValidateCustomSql(object sender, DevExpress.XtraReports.UserDesigner.ValidateSqlEventArgs e)
    {
        e.Valid = true;
    }
    private void GetValueControl()
    {
        if (validDatetimePicker == true)
        {
            //if(dtPicker.Where(x => x != null).Count() > 1)
            //{
            //    SetReportParameter(dtPicker[0].Properties.AccessibleName, string.Format("'{0}'", DevTools.FunctionBase.ConvertToDateTimeString(dtPicker[0].EditValue.ToString(), "yyyy-MM-dd 00:00:00")));
            //    SetReportParameter(dtPicker[1].Properties.AccessibleName, string.Format("'{0}'", DevTools.FunctionBase.ConvertToDateTimeString(dtPicker[1].EditValue.ToString(), "yyyy-MM-dd 23:59:59")));
            //}
            //else
            //{
            //    SetReportParameter(dtPicker[0].Properties.AccessibleName, string.Format("'{0}'", DevTools.FunctionBase.ConvertToDateTimeString(dtPicker[0].EditValue.ToString(), "yyyy-MM-dd")));
            //}

            foreach (var dtp in dtPicker.Where(x => x != null).ToList())
            {
                SetReportParameter(dtp.Properties.AccessibleName, string.Format("'{0}'", DevTools.FunctionBase.ConvertToDateTimeString(dtp.EditValue.ToString(), "yyyy-MM-dd")));
            }
        }
        if (validCombobox == true)
        {
            foreach (var cbo in ComboBoxArray.Where(x => x != null).ToList())
            {
                SetReportParameter(cbo.Properties.AccessibleName, cbo.EditValue);
            }
        }

        if (checkedCombo != null)
            if (checkedCombo.Visible)
            {
                var items = checkedCombo.Properties.Items.GetCheckedValues();
                if (items.Any())
                {
                    var values = items.Select(x => string.Format("'{0}'", x)).ToList();
                    SetReportParameter(checkedCombo.Properties.AccessibleName, string.Join(",", values));
                }
            }
        if (validTextBox)
        {
            foreach (var txtBox in lstTextBox)
            {
                var value = string.Format("'{0}'", txtBox.Text);
                SetReportParameter(txtBox.Properties.AccessibleName, value);
            }
        }
        frmDlg.Hide();
    }
    private void SetReportParameter(string keyname, object value)
    {
        _reportParameters.Add(new CustomReportParameter
        {
            Name = keyname,
            Value = value
        });
    }
    #endregion
}
