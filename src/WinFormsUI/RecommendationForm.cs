using System.Data;
using DevExpress.XtraEditors.Controls;
using SUTH.HealthCheckup.WinFormsUI.Checkup.Api.Client;
using SUTH.HealthCheckup.WinFormsUI.Functions;
using SUTH.HealthCheckup.WinFormsUI.Interfaces;

namespace SUTH.HealthCheckup.WinFormsUI
{
    public partial class RecommendationForm
    {

        private readonly IServiceProvider _serviceProvider;
        private readonly IFormFactory _formFactory;
        private readonly CheckupApiClient _checkupApiClient;

        private RecommendationListViewModel _checkupRecommendationList;
        //private CheckupFilterCriteria _currentCheckupFilterCriteria;

        /// <summary>
        /// Required for WinForms Designer support. Do not use in production code.
        /// </summary>
        public RecommendationForm()
        {
            InitializeComponent();
        }

        public RecommendationForm(
           IServiceProvider serviceProvider,
           IFormFactory formFactory,
           CheckupApiClient checkupApiClient)
        {
            // initilize service ที่ต้องใช้ก่อนที่จะ initialize component controls
            _serviceProvider = serviceProvider;
            _formFactory = formFactory;
            _checkupApiClient = checkupApiClient;
            InitializeComponent();
        }

        // readonly RecommendController ctlLG = new RecommendController();
        //readonly CheckupController ctlLB = new CheckupController();

        private void frmReportMenu_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            progressLoad.Visible = false;

            txtCompareValue.Text = "";
            lblLowValue.Visible = true;
            lblHighValue.Visible = true;
            txtHighValue.Visible = true;
            txtLowValue.Visible = true;
            txtCompareValue.Visible = false;

            LoadType();
            LoadOption();
            LoadRecommendToGrid();
        }
        private async void LoadRecommendToGrid()
        {
            _checkupRecommendationList = await _checkupApiClient.GetRecommendationListAsync();
            grdData.DataSource = _checkupRecommendationList.Recommendations.ToList();
            grdData.RefreshDataSource();
            gridViewData.Columns[1].BestFit();
            gridViewData.Columns[2].BestFit();
            gridViewData.Columns[3].BestFit();
            gridViewData.Columns[4].BestFit();
            gridViewData.Columns[5].BestFit();
            gridViewData.Columns[6].BestFit();
            gridViewData.Columns[7].BestFit();
            gridViewData.Columns[12].BestFit();

        }

        private void LoadType()
        {
            CheckupInfoList cList = new CheckupInfoList();

            cList.Add(new Contact("B", "<> :Between"));
            cList.Add(new Contact("L", "< :Less than"));
            cList.Add(new Contact("G", "> :Greater than"));
            cList.Add(new Contact("E", "= :Equal"));
            cList.Add(new Contact("N", "!= :Not equal"));

            ddlCondition.Properties.DataSource = cList;
            ddlCondition.Properties.DisplayMember = "Name";
            ddlCondition.Properties.ValueMember = "ID";

            ddlCondition.Properties.Columns.Add(new LookUpColumnInfo("Name", "", 150));
        }

        private void LoadOption()
        {

            CheckupInfoList cList = new CheckupInfoList();

            cList.Add(new Contact("M", "Male"));
            cList.Add(new Contact("F", "Female"));
            //cList.Add(new Contact("G", "> :Greater than"));
            //cList.Add(new Contact("E", "= :Equal"));
            //cList.Add(new Contact("N", "!= :Not equal"));

            ddlSex.Properties.DataSource = cList;
            ddlSex.Properties.DisplayMember = "Name";
            ddlSex.Properties.ValueMember = "ID";

            ddlSex.Properties.Columns.Add(new LookUpColumnInfo("Name", "", 80));

        }

        private void EditData(RecommendationViewModel _RcmDataView)
        {
            DataTable dtE = new DataTable();
            lblLowValue.Text = "Low Value";
            //dtE = ctlLG.Recommend_GetByID(pID);
            if (_RcmDataView == null)
                return;                        

                this.lblID.Text = _RcmDataView.Id.ToString();
            txtCode.Text = _RcmDataView.Code;
                txtDescription.Text = _RcmDataView.Name;
            ddlCondition.EditValue = _RcmDataView.CheckType;

                switch (ddlCondition.EditValue.ToString())
                {
                    case "E":
                    case "N":
                        txtCompareValue.Text = _RcmDataView.CompareValue;
                        lblLowValue.Visible = true;
                        lblHighValue.Visible = false;
                        txtHighValue.Visible = false;
                        txtLowValue.Visible = false;
                        txtCompareValue.Visible = true;
                        lblLowValue.Text = "Compare Value";
                        txtCompareValue.Location = new Point(570, txtLowValue.Location.Y);

                        break;
                    default:
                        txtCompareValue.Text = "";
                        lblLowValue.Visible = true;
                        lblHighValue.Visible = true;
                        txtHighValue.Visible = true;
                        txtLowValue.Visible = true;
                        txtCompareValue.Visible = false;
                        lblLowValue.Text = "Low Value";
                        txtCompareValue.Visible = false;
                        break;
                }


                txtLowValue.Text = _RcmDataView.LowValue.ToString();
                txtHighValue.Text = _RcmDataView.HighValue.ToString();
                ddlSex.EditValue = _RcmDataView.SexCode;
             
                txtConclusionTH.Text = _RcmDataView.ConclusionTh;
                txtConclusionEN.Text = _RcmDataView.ConclusionEn;

                txtRcmTH.Text = _RcmDataView.RecommendTh;
                txtRcmEN.Text = _RcmDataView.RecommendEn;

                //dtpStartDate.EditValue = _RcmDataView.ActiveFrom;
                //dtpEndDate.EditValue = _RcmDataView.ActiveTo;

                chkStatus.Checked =  _RcmDataView.IsActive;            
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            string lblValidate = "";

            if (string.IsNullOrEmpty(txtCode.Text))
            {
                lblValidate += "- กรุณาระบุ item Code   <br />";


            }
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                lblValidate += "- กรุณาระบุ Checkup Name   <br />";


            }

            if (string.IsNullOrEmpty(txtLowValue.Text) | string.IsNullOrEmpty(txtHighValue.Text))
            {
                lblValidate += "- กรุณาระบุ Value ให้ครบถ้วน    <br />";

            }



            //int item = 0;


            if (string.IsNullOrEmpty(lblID.Text))
            {
                //item = ctlLG.Recommend_Add(txtCode.Text, txtDescription.Text, ddlCondition.EditValue.ToString(), txtCompareValue.Text,GlobalFunctions.StrNull2Dbl(txtLowValue.Text), GlobalFunctions.StrNull2Dbl(txtHighValue.Text), txtConclusionTH.Text, txtConclusionEN.Text, txtRcmTH.Text, txtRcmEN.Text,                    txtRcmShort.Text, ddlSex.EditValue.ToString(),GlobalFunctions.Boolean2ActiveStatus(chkStatus.Checked));

            }
            else
            {
                //item = ctlLG.Recommend_Update( GlobalFunctions.StrNull2Zero(lblID.Text), txtCode.Text, txtDescription.Text, ddlCondition.EditValue.ToString(), txtCompareValue.Text,GlobalFunctions.StrNull2Dbl(txtLowValue.Text), GlobalFunctions.StrNull2Dbl( txtHighValue.Text), txtConclusionTH.Text, txtConclusionEN.Text, txtRcmTH.Text,                    txtRcmEN.Text, txtRcmShort.Text, ddlSex.EditValue.ToString(), GlobalFunctions.Boolean2ActiveStatus(chkStatus.Checked));

            }

            LoadRecommendToGrid();

            MessageBox.Show("บันทึกข้อมูลเรียบร้อย");

        }
        
        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdFindCode_Click(object sender, EventArgs e)
        {
            LoadLabName();
        }
        private void LoadLabName()
        {
            DataTable dtf = new DataTable();
            //dtf = ctlLB.Checkup_GetLabItemBySearch(txtCode.Text);
            if (dtf.Rows.Count > 0)
            {
                txtCode.Text = string.Concat(dtf.Rows[0]["Code"]);
                lblItemName.Text = string.Concat(dtf.Rows[0]["Name"]);
            }
            dtf = null;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewData_DoubleClick(object sender, EventArgs e)
        {
            var selectedCheckup = _checkupRecommendationList.Recommendations.Where(l =>
               l.Id == Convert.ToInt32(gridViewData.GetFocusedRowCellValue("Id"))).FirstOrDefault();
           EditData(selectedCheckup);             
        }
    }


}

public class CheckupInfoList : System.Collections.CollectionBase {
    public Contact this[int index] 
    {
        get {return (Contact)(List[index]);}
        set {List[index] = value;}
    }
    

    public int Add(Contact value) {
        return List.Add(value);
    }

}


public class Contact
{
    private readonly string ID;
    private string name;
    public Contact(string _ID,string _name)
    {
        ID = _ID;
        name = _name;
    }

 
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}
