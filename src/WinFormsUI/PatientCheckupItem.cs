using System.Data;
using SUTH.HealthCheckup.WinFormsUI.Functions;
namespace SUTH.HealthCheckup.WinFormsUI.Controllers
{
    public partial class PatientCheckupItem : Form
    {
        public PatientCheckupItem()
        {
            InitializeComponent();
        }

        //readonly CheckupController ctlMs = new CheckupController();
        //readonly PatientController ctlP = new PatientController();
        DataTable dt = new DataTable();  
        private void frmReportMenu_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            progressLoad.Visible = false;
            LoadCheckupGroup();

            dtpStartDate.EditValue = DateTime.Now.Date;
            dtpEndDate.EditValue = DateTime.Now.Date;
        }
              
        private void LoadCheckupGroup()
        {
             //dt = ctlMs.CheckupGroup_Get();          
            
            if (dt.Rows.Count > 0)
            {
            
                cboGroup.Properties.DataSource = dt;

                cboGroup.Properties.DisplayMember = "Name";
                cboGroup.Properties.ValueMember = "UID";
                DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "", 250);
                col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                cboGroup.Properties.Columns.Clear();
                cboGroup.Properties.Columns.Add(col);

                cboGroup.EditValue = "";    
            }
         

            dt = null;
        }

        private void LoadData()
        {

            string Bdate, Edate, ChkGroup;
            Bdate = "";
            Edate = "";
            ChkGroup = "";
            if (dtpStartDate.EditValue!=null) Bdate =GlobalFunctions.ConvertStrDate2DateQueryString(dtpStartDate.EditValue.ToString());
            if (dtpEndDate.EditValue != null) Edate = GlobalFunctions.ConvertStrDate2DateQueryString(dtpEndDate.EditValue.ToString());
            ChkGroup = cboGroup.EditValue.ToString();

            //dt = ctlMs.PatientCheckupItem_Get(Bdate, Edate, ChkGroup,txtSearch.Text);
            grdData.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
               
            }
            else
            {
                
            }
            dt = null;
        }

        private void cmdResultByItem_Click(object sender, EventArgs e)
        {
            progressLoad.Visible = true;
            LoadData();        
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadData();
            }
        }
    }
}
