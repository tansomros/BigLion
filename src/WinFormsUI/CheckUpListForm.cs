using System.Data;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraNavBar;
using DevExpress.XtraReports.UI;
using SUTH.HealthCheckup.Domain.Enums;
using SUTH.HealthCheckup.WinFormsUI.Checkup.Api.Client;
using SUTH.HealthCheckup.WinFormsUI.Functions;
using SUTH.HealthCheckup.WinFormsUI.Helpers;
using SUTH.HealthCheckup.WinFormsUI.Hosxp.Api.Client;
using SUTH.HealthCheckup.WinFormsUI.Interfaces;
using SUTH.HealthCheckup.WinFormsUI.Reports;
using SUTH.HealthCheckup.WinFormsUI.Services;
// [Obsolete] RefGroup ถูกแทนที่ด้วย SmartEnum ใน Domain.Enums แล้ว
// using RefGroup = SUTH.HealthCheckup.WinFormsUI.Constants.ReferenceGroup;

namespace SUTH.HealthCheckup.WinFormsUI
{
    /// <summary>
    /// ฟอร์มย่อย สำหรับแสดงรายการผู้บริการตรวจสุขภาพ
    /// </summary>
    public partial class CheckUpListForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IFormFactory _formFactory;
        private readonly CheckupApiClient _checkupApiClient;
        private readonly HosxpApiClient _hosxpApiClient;
        private CheckupViewModelPaginatedList _checkupVisitList;
        private CheckupFilterCriteria _currentCheckupFilterCriteria;
        private readonly IUserContext _userContext;
        //private readonly ICheckupItemCacheSrvice _checkupItemCacheService;
        private int _totalPages = 0;

        public CheckUpListForm(
            IServiceProvider serviceProvider,
            IFormFactory formFactory,
            CheckupApiClient checkupApiClient,
            HosxpApiClient hosxpApiClient,
            IUserContext userContext
          )
        {
            // initilize service ที่ต้องใช้ก่อนที่จะ initialize component controls
            _serviceProvider = serviceProvider;
            _formFactory = formFactory;
            _checkupApiClient = checkupApiClient;
            _hosxpApiClient = hosxpApiClient;
            _userContext = userContext;
            //_checkupItemCacheService = checkupItemCacheService;
            InitializeComponent();
        }

        private async void CheckupListForm_Load(object sender, EventArgs e)
        {
            var user = _userContext.CurrentUser;
            if (user.HasDentistRole ==false && user.HasDoctorRole == false && user.HasNurseRole == false && user.HasAdminRole == false && user.IsBeCheckupGroup == false)
            {
                //กรณีไม่ใช่ จนท.ที่มีสิทธิ์ลงผล ให้แสดงเฉพาะ visit ตัวเอง  ติดไว้ก่อน  ใช้ EmployeeId มีใน patient and user login
                SplitContentControlMain.Panel1.Enabled = false;
                SplitContentControlMain.Collapsed = true;
                //ShowLoading(false);
                //MessageBox.Show($"ท่านไม่มีสิทธิ์ใช้งาน : กรุณาติดต่อแผนกเทคโนโลยีสารสนเทศ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }

            ShowLoading(true);
            DtpStartDate.EditValue = DateTime.Now.Date;
            dtpEndDate.EditValue = DateTime.Now.Date;
                                   
            /** เลือกวิธีการโหลดข้อมูลแบบไหนเหมาะกับหน้าจอ **/

            // แบบ โหลดข้อมูลจาก API พร้อมกันทีเดียวและ Bind เข้ากับ Control ทีละอัน
            await PararellelFetchDataAndBinding();

            // โหลดข้อมูลจาก API และ Bind เข้ากับ Control ทีละอัน
            // await ProgressiveFetchDataAndBinding();

            await FetchCheckupList();

            ShowLoading(false);
        }

        /// <summary>
        /// fetch ข้อมูลที่จำเป็นทั้งหมดพร้อมกันทีเดียวแบบขนาน (Parallel)
        /// ข้อดีคือ โหลดพร้อมกันทีเดียว ใช้เวลาตามงานที่ใช้เวลาในการโหลดมากที่สุด คือรองานที่ช้าที่สุด
        /// </summary>
        /// <returns></returns>
        private async Task PararellelFetchDataAndBinding()
        {
            // CheckupStatus ใช้ SmartEnum โดยตรง ไม่ต้อง fetch จาก API
            cboStatus.Properties.DataSource = SmartEnumBindingHelper.ToDataSource(CheckupStatus.All);
            cboStatus.Properties.DisplayMember = "Descriptions";
            cboStatus.Properties.ValueMember = "ValueCode";

            // ประกาศตัวแปรงานไว้ก่อนเพื่อเมื่อไหร่ที่งานเสร็จจะได้เอาค่าไป Bind ใส่ Control ได้
            var fetchCheckupTypeTask = _checkupApiClient.GetCheckupTypeListAsync();
            var fetchCompanyTask = _hosxpApiClient.GetCompanyListQueryAsync();
            //var fetchDoctorTask = _hosxpApiClient.GetDoctorListByPositionIdQueryAsync(1);
            var fetchDoctorTask = _checkupApiClient.GetCareProviderByTypeAsync(1);

            // ดึงข้อมูลจาก API พร้อมๆ กันทีเดียวแบบ (Parallel)
            await Task.WhenAll(
                fetchCheckupTypeTask,
                fetchCompanyTask,
                fetchDoctorTask);

            cboCheckupType.Properties.DataSource = fetchCheckupTypeTask.Result.CheckupTypes.ToList();
            cboCheckupType.Properties.DisplayMember = "Name";
            cboCheckupType.Properties.ValueMember = "Id";

            cboCompany.Properties.DataSource = fetchCompanyTask.Result.Company.ToList();
            cboCompany.Properties.DisplayMember = "Name";
            cboCompany.Properties.ValueMember = "CompanyId";

            cboCareprovider.Properties.DataSource = fetchDoctorTask.Result.CareProviders.ToList();
            cboCareprovider.Properties.DisplayMember = "FullNameThai";
            cboCareprovider.Properties.ValueMember = "Code";
            cboCareprovider.SelectAll();
        }

        /// <summary>
        /// fetch ข้อมูลที่จำเป็นและ bind เข้า control ที่ละอันๆ
        /// </summary>
        /// <returns></returns>
        private async Task ProgressiveFetchDataAndBinding()
        {
            await FetchAndBindCheckupStatus();
            await FetchAndBindCheckupType();
            await FetchAndBindCompany();
            await FetchAndBindCareProvider();
        }

        private Task FetchAndBindCheckupStatus()
        {
            cboStatus.Properties.DataSource = SmartEnumBindingHelper.ToDataSource(CheckupStatus.All);
            cboStatus.Properties.DisplayMember = "Descriptions";
            cboStatus.Properties.ValueMember = "ValueCode";
            return Task.CompletedTask;
        }

        private async Task FetchAndBindCheckupType()
        {
            var types = await _checkupApiClient.GetCheckupTypeListAsync();
            cboCheckupType.Properties.DataSource = types.CheckupTypes.ToList();
            cboCheckupType.Properties.DisplayMember = "Name";
            cboCheckupType.Properties.ValueMember = "Id";
        }

        private async Task FetchAndBindCompany()
        {
            var companyList = await _hosxpApiClient.GetCompanyListQueryAsync();
            cboCompany.Properties.DataSource = companyList.Company.ToList();
            cboCompany.Properties.DisplayMember = "Name";
            cboCompany.Properties.ValueMember = "CompanyId";
        }

        private async Task FetchAndBindCareProvider()
        {
            var doctorList = await _hosxpApiClient.GetDoctorListByPositionIdQueryAsync(1);
            cboCareprovider.Properties.DataSource = doctorList.Doctors.ToList();
            cboCareprovider.Properties.DisplayMember = "Name";
            cboCareprovider.Properties.ValueMember = "Code";
            cboCareprovider.SelectAll();
        }

        private async Task FetchCheckupList()
        {
            _currentCheckupFilterCriteria = BuildSearchCriteria();
            await FetchAndDisplayCheckups(_currentCheckupFilterCriteria);
        }

        private CheckupFilterCriteria BuildSearchCriteria()
        {
            var checkupFilterCriteria = new CheckupFilterCriteria
            {
                EmployeeId = string.Empty,
                SearchText = String.Empty,
                PageNumber = 1,
                PageSize = 5000,
            };

            if (int.TryParse(txtPageCurrent.Text, out int currentPage))
            {
                checkupFilterCriteria.PageNumber = currentPage;
            }

            var startDate = string.IsNullOrEmpty(DtpStartDate.Text)
                ? DateTime.Now.Date
                : DtpStartDate.DateTime;

            var endDate = string.IsNullOrEmpty(dtpEndDate.Text)
                ? DateTime.Now.Date
                : dtpEndDate.DateTime;

            checkupFilterCriteria.StartDate = startDate;
            checkupFilterCriteria.EndDate = endDate;

            if (int.TryParse(cboStatus.EditValue?.ToString(), out int checkupStatusId))
            {
                checkupFilterCriteria.StatusId = checkupStatusId;
            }

            if (int.TryParse(cboCompany.EditValue?.ToString(), out int companyId))
            {
                checkupFilterCriteria.CompanyId = companyId;
            }

            if (int.TryParse(cboCheckupType.EditValue?.ToString(), out int checkupTypeId))
            {
                checkupFilterCriteria.CheckupTypeId = checkupTypeId;
            }

            if (int.TryParse(cboCareprovider.EditValue?.ToString(), out int careProviderId))
            {
                checkupFilterCriteria.CareProviderId = careProviderId;
            }

            if (!string.IsNullOrEmpty(TxtSearch.Text))
            {
                checkupFilterCriteria.SearchText = TxtSearch.Text;
            }

            var user = _userContext.CurrentUser;
            if (user.HasDentistRole == false && user.HasDoctorRole == false && user.HasNurseRole == false && user.HasAdminRole == false && user.IsBeCheckupGroup == false)
            {
                checkupFilterCriteria.EmployeeId = user.EmployeeId;
            }

                return checkupFilterCriteria;
        }

        private async Task FetchAndDisplayCheckups(CheckupFilterCriteria criteria)
        {
            try
            {

                ShowLoading(true);

                _checkupVisitList = await _checkupApiClient.SearchCheckupListAsync(
                    criteria.StartDate.LocalDateTime,
                    criteria.EndDate.LocalDateTime,
                    criteria.StatusId,
                    criteria.CompanyId,
                    criteria.CheckupTypeId,
                    criteria.CareProviderId,
                    criteria.EmployeeId,
                    criteria.SearchText,
                    criteria.PageNumber,
                    criteria.PageSize);                          

                UpdatePaginationUI(criteria.PageNumber);
                UpdateGridData();
            }
            catch (Exception ex)
            {
                // Handle error appropriately
                MessageBox.Show($"เกิดช้อผิดพลาด, โหลดข้อมูลผู้รับบริการตรวจสุขภาพไม่ได้: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ShowLoading(false);
            }
        }

        private void UpdatePaginationUI(int currentPage)
        {
            _totalPages = _checkupVisitList.TotalPages;
            if (_totalPages == 0) _totalPages = 1;
            txtPageTotal.Text = _totalPages.ToString();
            txtPageCurrent.Text = currentPage.ToString();
        }

        private void UpdateGridData()
        {
            grdData.DataSource = _checkupVisitList.Items.ToList();
            grdData.RefreshDataSource();
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            _currentCheckupFilterCriteria = BuildSearchCriteria();
            await FetchAndDisplayCheckups(_currentCheckupFilterCriteria);
        }

        private void navBarData_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NavBarControl navBar = sender as NavBarControl;
                NavBarHitInfo hitInfo = navBar.CalcHitInfo(new Point(e.X, e.Y));

                if (hitInfo.InGroupCaption && (!hitInfo.InGroupButton))
                {
                    hitInfo.Group.Expanded = !hitInfo.Group.Expanded;
                }
            }
        }

        private void gridViewData_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {

                //if (gridViewData.GetRowCellValue(e.RowHandle, gridViewData.Columns[12]) != null)
                //{

                //    if (gridViewData.GetRowCellValue(e.RowHandle, gridViewData.Columns[12]).ToString() == "Finalized")
                //    {

                //        e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffcc");

                //    }
                //    else if (gridViewData.GetRowCellValue(e.RowHandle, gridViewData.Columns[12]).ToString() == "Submited")
                //    {

                //        e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml("#cdf1ff");
                //    }
                //    else
                //    {

                //    }

                //}
                //if (gridViewData.GetRowCellValue(e.RowHandle, gridViewData.Columns[15]) != null)
                //{

                //    switch (gridViewData.GetRowCellValue(e.RowHandle, gridViewData.Columns[15]).ToString().Trim())
                //    {
                //        case "Completed":
                //        case "Partially Completed":
                //        case "Reviewed":
                //            gridViewData.Columns[15].AppearanceCell.BackColor = System.Drawing.ColorTranslator.FromHtml("#c6ffdb");
                //            break;

                //        case "Awaiting Results":
                //            gridViewData.Columns[15].AppearanceCell.BackColor = System.Drawing.ColorTranslator.FromHtml("#fbd6d6");
                //            break;
                //        default:
                //            gridViewData.Columns[15].AppearanceCell.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                //            break;
                //    }

                //}
                //if (gridViewData.GetRowCellValue(e.RowHandle, gridViewData.Columns[16]) != null)
                //{
                //    switch (gridViewData.GetRowCellValue(e.RowHandle, gridViewData.Columns[16]).ToString().Trim())
                //    {
                //        case "Completed":
                //        case "Reviewed":
                //            gridViewData.Columns[16].AppearanceCell.BackColor = System.Drawing.ColorTranslator.FromHtml("#c6ffdb");
                //            break;
                //        case "Awaiting Results":
                //            gridViewData.Columns[16].AppearanceCell.BackColor = System.Drawing.ColorTranslator.FromHtml("#fbd6d6");
                //            break;
                //        case "Partially Completed":
                //            gridViewData.Columns[16].AppearanceCell.BackColor = System.Drawing.ColorTranslator.FromHtml("#fffd5e");
                //            break;
                //        default:
                //            gridViewData.Columns[16].AppearanceCell.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                //            break;
                //    }
                //}


            }
        }

        private async void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                _currentCheckupFilterCriteria.SearchText = TxtSearch.Text;
                await FetchAndDisplayCheckups(_currentCheckupFilterCriteria);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            DtpStartDate.EditValue = "";
            dtpEndDate.EditValue = "";
            cboStatus.EditValue = "";
            cboCheckupType.EditValue = "";
            cboCompany.EditValue = "";
            cboCareprovider.EditValue = "";
            TxtSearch.Text = "";

            // reset filter criteria
            _currentCheckupFilterCriteria = BuildSearchCriteria();
        }

        private async void gridViewData_MouseDown(object sender, MouseEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) != Keys.Control)
            {
                GridView view = sender as GridView;
                GridHitInfo hi = view.CalcHitInfo(e.Location);
                try
                {
                    if (hi.RowHandle > 0)
                    {

                        if (hi.Column.Name == "colPrint" && view.GetRowCellValue(hi.RowHandle, view.Columns["StatusName"]).ToString() == "InProgress")
                        {
                            //view.FocusedRowHandle = hi.RowHandle;
                            //view.FocusedColumn = hi.Column;
                            //view.ShowEditor();

                            CheckupReportViewModel reportData = await _checkupApiClient.CheckupReportAsync(gridViewData.GetFocusedRowCellValue("VisitNumber").ToString());
                            CheckupSummaryReport report = new CheckupSummaryReport();
                            report.DataSource = new List<CheckupReportViewModel> { reportData };
                            report.ShowPreviewDialog();

                            //GlobalVariables.FagRPT = "CHKUPBOOK";
                            //GlobalVariables.Reportskey = "CHKUPBOOK";
                            //GlobalVariables.gPatientUID = Convert.ToInt64(gridViewData.GetFocusedRowCellValue("PatientUID"));
                            //GlobalVariables.gPatientVisitUID = Convert.ToInt64(gridViewData.GetFocusedRowCellValue("VisitNumber"));
                            //GlobalVariables.ReportTitle = "MEDICAL EXAMINATION REPORT";
                        }
                    }
                }
                catch (Exception ex)  //when (ex.Message.Contains("404") || ex.Message.Contains("not found") || ex.Message.Contains("No resultset"))
                {
                    //Debug.WriteLine(ex.Message);
                    MessageBox.Show(this, gridViewData.GetFocusedRowCellValue("VisitNumber").ToString() + " : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblClose_MouseHover(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.Maroon;
        }

        private void gridViewData_DoubleClick(object sender, EventArgs e)
        {
            var selectedCheckup = _checkupVisitList.Items.Where(l =>
                l.VisitNumber == gridViewData.GetFocusedRowCellValue("VisitNumber").ToString()).FirstOrDefault();
            var checkupForm = _formFactory.Create<CheckupForm>(selectedCheckup.Id, selectedCheckup.VisitNumber);

            checkupForm.MdiParent = this.MdiParent;
            checkupForm.Show();
        }

        private async void cmdPageNext_Click(object sender, EventArgs e)
        {
            var currentPage = Convert.ToInt32(txtPageCurrent.Text);
            var nextPage = currentPage + 1;

            if (nextPage <= _totalPages)
            {
                _currentCheckupFilterCriteria.PageNumber = nextPage;
                await FetchAndDisplayCheckups(_currentCheckupFilterCriteria);
            }
        }

        private async void cmdPageBack_Click(object sender, EventArgs e)
        {
            var currentPage = Convert.ToInt32(txtPageCurrent.Text);
            var prevPage = currentPage - 1;

            if (prevPage >= 1)
            {
                _currentCheckupFilterCriteria.PageNumber = prevPage;
                await FetchAndDisplayCheckups(_currentCheckupFilterCriteria);
            }
        }

        private void cboStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                cboStatus.EditValue = null;
            }
        }

        private void cboCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                cboCompany.EditValue = null;
            }
        }

        private void cboCheckupType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                cboCheckupType.EditValue = null;
            }
        }

        private void cboCareprovider_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                cboCareprovider.EditValue = null;
            }
        }

        private void gridViewData_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "Row" && e.RowHandle >= 0)
            {
                e.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gridViewData_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Row" && e.IsGetData)
            {
                e.Value = e.ListSourceRowIndex + 1;
            }
        }

        private void ShowLoading(bool show)
        {
            if (show)
            {
                progressPanel1.Dock = DockStyle.Fill;
                progressPanel1.Show();
                progressPanel1.Visible = true;
                this.Cursor = Cursors.WaitCursor;
                //แสดงหมุนๆ
            }
            else
            {
                progressPanel1.Visible = false;
                this.Cursor = Cursors.Default;
                //หยุดแสดงหมุนๆ
            }
        }

        private async void btnPrvDate_Click(object sender, EventArgs e)
        {
            var startDate = string.IsNullOrEmpty(DtpStartDate.Text)
               ? DateTime.Now.Date
               : DtpStartDate.DateTime;
            startDate = startDate.AddDays(-1);
            var endDate = startDate;
            DtpStartDate.Text = startDate.Date.ToString("dd/M/yyyy");
            dtpEndDate.Text = endDate.Date.ToString("dd/M/yyyy");
            _currentCheckupFilterCriteria = BuildSearchCriteria();
            await FetchAndDisplayCheckups(_currentCheckupFilterCriteria);
        }

        private async void btnNextDate_Click(object sender, EventArgs e)
        {
            var endDate = string.IsNullOrEmpty(dtpEndDate.Text)
                ? DateTime.Now.Date
                : dtpEndDate.DateTime;
            endDate = endDate.AddDays(1);
            var startDate = endDate;
           
            DtpStartDate.Text = startDate.Date.ToString("dd/M/yyyy");
            dtpEndDate.Text = endDate.Date.ToString("dd/M/yyyy");

            _currentCheckupFilterCriteria = BuildSearchCriteria();
            await FetchAndDisplayCheckups(_currentCheckupFilterCriteria);
        }
    }

    public class CheckupFilterCriteria
    {
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public int StatusId { get; set; }
        public int CompanyId { get; set; }
        public int CheckupTypeId { get; set; }
        public int CareProviderId { get; set; }
        public string EmployeeId { get; set; }
        public string SearchText { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 5000;
    }
}
