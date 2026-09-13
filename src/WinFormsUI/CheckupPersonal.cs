using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using SUTH.HealthCheckup.WinFormsUI.Checkup.Api.Client;
using SUTH.HealthCheckup.WinFormsUI.Functions;
namespace SUTH.HealthCheckup.WinFormsUI.Controllers
{
    public partial class CheckupPersonal : DevExpress.XtraEditors.XtraForm
    {
        //DataTable dtList = new DataTable();
        //ResultController ctlR = new ResultController();
        //readonly PatientController ctlP = new PatientController();

        private readonly CheckupApiClient _checkupApiClient;

        public CheckupPersonal(CheckupApiClient checkupApiClient)
        {
            InitializeComponent();

            _checkupApiClient = checkupApiClient;
        }

        private void frmCheckupPersonal_Load(object sender, EventArgs e)
        {
            progressLoad.Visible = true;
            progressLoad.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;
            //lblTitleName.Text = "รายการตรวจสุขภาพ : " + DataHelper.username;
            LoadCheckupList();
            progressLoad.Visible = false;
        }
        private void LoadCheckupList()
        {           
            //dtList = ctlP.PatientVisit_GetByUser(DataHelper.LoginUser);
            //grdData.DataSource = dtList;
        }
        
        private void grdData_DoubleClick(object sender, EventArgs e)
        {
            GlobalVariables.FagRPT = "CHKUPBOOK";
            GlobalVariables.Reportskey = "CHKUPBOOK";
            GlobalVariables.gPatientUID = Convert.ToInt64(gridViewData.GetFocusedRowCellValue("PatientUID"));
            GlobalVariables.gPatientVisitUID = Convert.ToInt64(gridViewData.GetFocusedRowCellValue("VisitNumber"));
            GlobalVariables.ReportTitle = "MEDICAL EXAMINATION REPORT";

            //ReportViewer fRptView = new ReportViewer();
            //fRptView.MdiParent = this.MdiParent;
            //fRptView.Show();

            //fRptView.TopMost = true;
        }

        private void gridViewData_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {

                if (gridViewData.GetRowCellValue(e.RowHandle, gridViewData.Columns[8]) != null)
                {

                    if (gridViewData.GetRowCellValue(e.RowHandle, gridViewData.Columns[8]).ToString() == "Finalized")
                    {

                        e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffcc");

                    }
                    else if (gridViewData.GetRowCellValue(e.RowHandle, gridViewData.Columns[8]).ToString() == "Submited")
                    {

                        e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml("#cdf1ff");
                    }
                    else
                    {

                    }

                }

                //if (gridViewData.GetRowCellValue(e.RowHandle, gridViewData.Columns[14]) != null)
                //{
                //    switch (gridViewData.GetRowCellValue(e.RowHandle, gridViewData.Columns[14]).ToString().Trim())
                //    {
                //        case "Completed":
                //        case "Reviewed":
                //            gridViewData.Columns[14].AppearanceCell.BackColor = System.Drawing.ColorTranslator.FromHtml("#c6ffdb");
                //            break;
                //        case "Awaiting Results":
                //            gridViewData.Columns[14].AppearanceCell.BackColor = System.Drawing.ColorTranslator.FromHtml("#fbd6d6");
                //            break;
                //        case "Partially Completed":
                //            gridViewData.Columns[14].AppearanceCell.BackColor = System.Drawing.ColorTranslator.FromHtml("#fffd5e");
                //            break;
                //        default:
                //            gridViewData.Columns[14].AppearanceCell.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                //            break;
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



            }
        }
    
        private void gridViewData_MouseDown(object sender, MouseEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) != Keys.Control)
            {
                GridView view = sender as GridView;
                GridHitInfo hi = view.CalcHitInfo(e.Location);
                try
                {
                    if (hi.Column.Name == "colPrint" && view.GetRowCellValue(hi.RowHandle, view.Columns["isReview"]).ToString() == "Y")
                    {
                        view.FocusedRowHandle = hi.RowHandle;
                        view.FocusedColumn = hi.Column;
                        view.ShowEditor();


                        GlobalVariables.FagRPT = "CHKUPBOOK";
                        GlobalVariables.Reportskey = "CHKUPBOOK";
                        GlobalVariables.gPatientUID = Convert.ToInt64(gridViewData.GetFocusedRowCellValue("PatientUID"));
                        GlobalVariables.gPatientVisitUID = Convert.ToInt64(gridViewData.GetFocusedRowCellValue("VisitNumber"));
                        GlobalVariables.ReportTitle = "MEDICAL EXAMINATION REPORT";

                        //ReportViewer fRptView = new ReportViewer();
                        //fRptView.MdiParent = this.MdiParent;
                        //fRptView.Show();


                        //fRptView.TopMost = true;

                    }


                }
                catch { }
            }


        }

        private void gridViewData_MouseMove(object sender, MouseEventArgs e)
        {
            GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            try
            {
                GridHitInfo hi = view.CalcHitInfo(e.X, e.Y);
                if (hi.RowHandle > 0)
                {
                if (hi.Column.Name == "colPrint" && view.GetRowCellValue(hi.RowHandle, view.Columns["isReview"]).ToString() == "Y")
                {
                    //if (e.X >= 20 && e.X <= 40)
                    //{
                    //if (hi.InGroupRow == false)
                    view.GridControl.Cursor = Cursors.Hand;
                    //}

                    //else
                    //{
                    //    view.GridControl.Cursor = Cursors.Default;
                    //}
                }
                else
                {
                    view.GridControl.Cursor = Cursors.Default;
                }
                }

            }
            catch
            {
                view.GridControl.Cursor = Cursors.Default;
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

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
