using SUTH.HealthCheckup.WinFormsUI.Properties;

namespace SUTH.HealthCheckup.WinFormsUI
{
partial class frmCheckUpMainXX : System.Windows.Forms.Form
{

	//Form overrides dispose to clean up the component list.
	[System.Diagnostics.DebuggerNonUserCode()]
	protected override void Dispose(bool disposing)
	{
		try {
			if (disposing && components != null) {
				components.Dispose();
			}
		} finally {
			base.Dispose(disposing);
		}
	}

	//Required by the Windows Form Designer

	private System.ComponentModel.IContainer components;
        //NOTE: The following procedure is required by the Windows Form Designer
        //It can be modified using the Windows Form Designer.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckUpMainXX));
            leIsAbnormal = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            cmdPrintResultBook = new DevExpress.XtraEditors.SimpleButton();
            cmdFinalize = new DevExpress.XtraEditors.SimpleButton();
            cmdTempSave = new DevExpress.XtraEditors.SimpleButton();
            panel1 = new Panel();
            panel5 = new Panel();
            lstRecommendList = new DevExpress.XtraEditors.ListBoxControl();
            panel2 = new Panel();
            txtSearchRecommendation = new DevExpress.XtraEditors.SearchControl();
            pnDoctorSummary = new Panel();
            panel7 = new Panel();
            txtResult_DoctorRecommend = new DevExpress.XtraEditors.MemoEdit();
            panel6 = new Panel();
            label30 = new Label();
            ddlDoctor_Conclusion = new DevExpress.XtraEditors.LookUpEdit();
            label31 = new Label();
            ddlDoctor_PE = new DevExpress.XtraEditors.LookUpEdit();
            pnPE = new Panel();
            ddlGA_LevelOfConsciousne = new DevExpress.XtraEditors.LookUpEdit();
            txtGA_Others = new DevExpress.XtraEditors.TextEdit();
            txtGA_Skin = new DevExpress.XtraEditors.TextEdit();
            txtGA_Extremties = new DevExpress.XtraEditors.TextEdit();
            txtGA_Abdomen = new DevExpress.XtraEditors.TextEdit();
            txtGA_Heart = new DevExpress.XtraEditors.TextEdit();
            txtGA_LungChestBreast = new DevExpress.XtraEditors.TextEdit();
            txtGA_Thyroid = new DevExpress.XtraEditors.TextEdit();
            txtGA_Lymphoma = new DevExpress.XtraEditors.TextEdit();
            txtGA_MouthAndThroat = new DevExpress.XtraEditors.TextEdit();
            txtGA_EareAndNose = new DevExpress.XtraEditors.TextEdit();
            txtGA_Eye = new DevExpress.XtraEditors.TextEdit();
            txtGA_HeadAndFace = new DevExpress.XtraEditors.TextEdit();
            txtGA_LevelOfConsciousne = new DevExpress.XtraEditors.TextEdit();
            ddlGA_Others = new DevExpress.XtraEditors.LookUpEdit();
            label52 = new Label();
            ddlGA_Skin = new DevExpress.XtraEditors.LookUpEdit();
            ddlGA_Extremties = new DevExpress.XtraEditors.LookUpEdit();
            ddlGA_Abdomen = new DevExpress.XtraEditors.LookUpEdit();
            ddlGA_Heart = new DevExpress.XtraEditors.LookUpEdit();
            ddlGA_LungChestBreast = new DevExpress.XtraEditors.LookUpEdit();
            ddlGA_Thyroid = new DevExpress.XtraEditors.LookUpEdit();
            ddlGA_Lymphoma = new DevExpress.XtraEditors.LookUpEdit();
            ddlGA_MouthAndThroat = new DevExpress.XtraEditors.LookUpEdit();
            ddlGA_EareAndNose = new DevExpress.XtraEditors.LookUpEdit();
            ddlGA_Eye = new DevExpress.XtraEditors.LookUpEdit();
            label46 = new Label();
            label47 = new Label();
            label48 = new Label();
            label49 = new Label();
            label50 = new Label();
            label51 = new Label();
            label44 = new Label();
            label45 = new Label();
            label42 = new Label();
            label43 = new Label();
            ddlGA_HeadAndFace = new DevExpress.XtraEditors.LookUpEdit();
            label41 = new Label();
            label40 = new Label();
            label39 = new Label();
            label38 = new Label();
            chkNoCheck = new CheckBox();
            panel8 = new Panel();
            txtVS_SummaryRemark = new DevExpress.XtraEditors.TextEdit();
            label54 = new Label();
            ddlVS_Summary = new DevExpress.XtraEditors.LookUpEdit();
            pnVision = new Panel();
            panel21 = new Panel();
            ddlVS_Blind = new DevExpress.XtraEditors.LookUpEdit();
            txtVS_BlindRemark = new DevExpress.XtraEditors.TextEdit();
            label37 = new Label();
            label53 = new Label();
            label55 = new Label();
            label56 = new Label();
            panel3 = new Panel();
            label57 = new Label();
            ddlVS_RetinaRight = new DevExpress.XtraEditors.LookUpEdit();
            txtVS_VisibilityRight = new DevExpress.XtraEditors.TextEdit();
            ddlVS_VisibilityRight = new DevExpress.XtraEditors.LookUpEdit();
            txtVS_RetinaRight = new DevExpress.XtraEditors.TextEdit();
            ddlVS_EyeballRight = new DevExpress.XtraEditors.LookUpEdit();
            txtVS_EyeballRight = new DevExpress.XtraEditors.TextEdit();
            panel4 = new Panel();
            label58 = new Label();
            txtVS_VisibilityLeft = new DevExpress.XtraEditors.TextEdit();
            ddlVS_VisibilityLeft = new DevExpress.XtraEditors.LookUpEdit();
            txtVS_RetinaLeft = new DevExpress.XtraEditors.TextEdit();
            ddlVS_EyeballLeft = new DevExpress.XtraEditors.LookUpEdit();
            ddlVS_RetinaLeft = new DevExpress.XtraEditors.LookUpEdit();
            txtVS_EyeballLeft = new DevExpress.XtraEditors.TextEdit();
            pnAudio = new Panel();
            ddlEarsLeftRemark = new DevExpress.XtraEditors.TextEdit();
            ddlEarsLeft = new DevExpress.XtraEditors.LookUpEdit();
            ddlEarsRightRemark = new DevExpress.XtraEditors.TextEdit();
            ddlEarsRight = new DevExpress.XtraEditors.LookUpEdit();
            label59 = new Label();
            label60 = new Label();
            pnBloodChem = new Panel();
            gridBloodChemistry = new DevExpress.XtraGrid.GridControl();
            gridViewBloodChemistry = new DevExpress.XtraGrid.Views.Grid.GridView();
            colBC_ItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            colBC_ResultValue = new DevExpress.XtraGrid.Columns.GridColumn();
            colBC_UOM = new DevExpress.XtraGrid.Columns.GridColumn();
            colBC_Reference = new DevExpress.XtraGrid.Columns.GridColumn();
            colBC_IsAbnormal = new DevExpress.XtraGrid.Columns.GridColumn();
            colBC_Summary = new DevExpress.XtraGrid.Columns.GridColumn();
            colBC_ItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colBC_GroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            colBC_UID = new DevExpress.XtraGrid.Columns.GridColumn();
            pnStool2 = new Panel();
            txtST_DoctorRecommend = new TextBox();
            ddlST_Summary = new DevExpress.XtraEditors.LookUpEdit();
            label17 = new Label();
            label18 = new Label();
            pnStool = new Panel();
            gridStool = new DevExpress.XtraGrid.GridControl();
            gridViewStool = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemMemoEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit9 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit10 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
            pnStoolCulture = new Panel();
            gridStoolCulture = new DevExpress.XtraGrid.GridControl();
            gridViewStoolCulture = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemMemoEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit11 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            gridColumn35 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit12 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            gridColumn36 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn37 = new DevExpress.XtraGrid.Columns.GridColumn();
            panel10 = new Panel();
            txtUA_DoctorRecommend = new TextBox();
            ddlUA_Summary = new DevExpress.XtraEditors.LookUpEdit();
            label14 = new Label();
            label13 = new Label();
            pnUA = new Panel();
            gridUrine = new DevExpress.XtraGrid.GridControl();
            gridViewUrine = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn47 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn48 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemMemoEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            gridColumn49 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn50 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn51 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit13 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            gridColumn52 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit14 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            gridColumn53 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn54 = new DevExpress.XtraGrid.Columns.GridColumn();
            pnCBC2 = new Panel();
            txtCBC_DoctorRecommend = new TextBox();
            ddlCBC_Summary = new DevExpress.XtraEditors.LookUpEdit();
            label15 = new Label();
            label16 = new Label();
            pnCBC = new Panel();
            grdCBC = new DevExpress.XtraGrid.GridControl();
            gridViewCBC = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemMemoEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            pnXray = new Panel();
            btnPAC_USBreast = new DevExpress.XtraEditors.SimpleButton();
            btnX_USBreast = new DevExpress.XtraEditors.SimpleButton();
            txtX_USBreast = new DevExpress.XtraEditors.MemoEdit();
            ddlX_USBreast = new DevExpress.XtraEditors.LookUpEdit();
            lblUsBreast = new Label();
            btnPAC_Lower = new DevExpress.XtraEditors.SimpleButton();
            btnPAC_Mammo = new DevExpress.XtraEditors.SimpleButton();
            btnPAC_Upper = new DevExpress.XtraEditors.SimpleButton();
            btnPAC_Echo = new DevExpress.XtraEditors.SimpleButton();
            btnPAC_Abdomen = new DevExpress.XtraEditors.SimpleButton();
            btnPAC_PA = new DevExpress.XtraEditors.SimpleButton();
            btnX_Lower = new DevExpress.XtraEditors.SimpleButton();
            btnX_Mammo = new DevExpress.XtraEditors.SimpleButton();
            btnX_Upper = new DevExpress.XtraEditors.SimpleButton();
            btnX_Abdomen = new DevExpress.XtraEditors.SimpleButton();
            btnX_Echo = new DevExpress.XtraEditors.SimpleButton();
            btnX_PA = new DevExpress.XtraEditors.SimpleButton();
            txtX_LowerAbdomenRemark = new DevExpress.XtraEditors.MemoEdit();
            ddlX_LowerAbdomen = new DevExpress.XtraEditors.LookUpEdit();
            lblLowerAbdomen = new Label();
            txtX_Mammogram = new DevExpress.XtraEditors.MemoEdit();
            ddlX_Mammogram = new DevExpress.XtraEditors.LookUpEdit();
            txtX_EchoRemark = new DevExpress.XtraEditors.MemoEdit();
            ddlX_Echo = new DevExpress.XtraEditors.LookUpEdit();
            txtX_UpperAbdomenRemark = new DevExpress.XtraEditors.MemoEdit();
            txtX_ChestPA = new DevExpress.XtraEditors.MemoEdit();
            ddlX_UpperAbdomen = new DevExpress.XtraEditors.LookUpEdit();
            ddlX_ChestPA = new DevExpress.XtraEditors.LookUpEdit();
            txtX_AbdomenRemark = new DevExpress.XtraEditors.MemoEdit();
            ddlX_Abdomen = new DevExpress.XtraEditors.LookUpEdit();
            lblAbdomen = new Label();
            lblChestPA = new Label();
            lblUpperAbdomen = new Label();
            lblHeart = new Label();
            lblMammogram = new Label();
            pnSpecial = new Panel();
            grdSpecialTest = new DevExpress.XtraGrid.GridControl();
            grdViewSpecialTest = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn38 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn39 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            gridColumn40 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn41 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn42 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            gridColumn43 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            gridColumn44 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn45 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn46 = new DevExpress.XtraGrid.Columns.GridColumn();
            pnTechnicOther = new Panel();
            btnPAC_BMD = new DevExpress.XtraEditors.SimpleButton();
            txtPapSmear = new DevExpress.XtraEditors.MemoEdit();
            chkPapSmear = new DevExpress.XtraEditors.CheckEdit();
            txtVegina = new DevExpress.XtraEditors.MemoEdit();
            chkVegina = new DevExpress.XtraEditors.CheckEdit();
            lblEKG = new Label();
            txtX_EKGResult = new DevExpress.XtraEditors.MemoEdit();
            ddlX_EKG = new DevExpress.XtraEditors.LookUpEdit();
            txtX_BMDRemark = new DevExpress.XtraEditors.MemoEdit();
            lblEST = new Label();
            ddlX_BMD = new DevExpress.XtraEditors.LookUpEdit();
            lblABI = new Label();
            lblBMD = new Label();
            ddlX_EST = new DevExpress.XtraEditors.LookUpEdit();
            txtX_ABIRemark = new DevExpress.XtraEditors.MemoEdit();
            ddlX_ABI = new DevExpress.XtraEditors.LookUpEdit();
            txtX_ESTRemark = new DevExpress.XtraEditors.MemoEdit();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemMemoEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit8 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            colLabHead = new DevExpress.XtraGrid.Columns.GridColumn();
            colBlank = new DevExpress.XtraGrid.Columns.GridColumn();
            colLabItem = new DevExpress.XtraGrid.Columns.GridColumn();
            colResult = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            colUnitofMeasure = new DevExpress.XtraGrid.Columns.GridColumn();
            colReference = new DevExpress.XtraGrid.Columns.GridColumn();
            colSymbo = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            colCritical = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            colGroupOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            colPrintOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            colComments = new DevExpress.XtraGrid.Columns.GridColumn();
            colTime = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            groupControl8 = new DevExpress.XtraEditors.GroupControl();
            txtZipCode = new DevExpress.XtraEditors.TextEdit();
            ddlProvince = new DevExpress.XtraEditors.LookUpEdit();
            label65 = new Label();
            label64 = new Label();
            txtAddress = new DevExpress.XtraEditors.MemoEdit();
            label63 = new Label();
            groupControlPE = new DevExpress.XtraEditors.GroupControl();
            lblMedicalHistory = new Label();
            lblRh = new Label();
            lblABO = new Label();
            lblBP = new Label();
            lblRR = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            lblPluse = new Label();
            lblTemperature = new Label();
            lblBMI = new Label();
            lblShape = new Label();
            lblWaist = new Label();
            lblHeight = new Label();
            lblWeight = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            dockManager1 = new DevExpress.XtraBars.Docking.DockManager(components);
            barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(components);
            imageCollection1 = new DevExpress.Utils.ImageCollection(components);
            dockPanelPatient = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            label5 = new Label();
            lblReligion = new Label();
            ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            lblPayor = new Label();
            label9 = new Label();
            lblStaffID = new Label();
            label3 = new Label();
            lblVisitDate = new Label();
            label8 = new Label();
            lblVisitNo = new Label();
            label7 = new Label();
            lblDateVN = new Label();
            lblVN = new Label();
            lblTel = new Label();
            label1 = new Label();
            lblPatientName = new Label();
            label4 = new Label();
            label2 = new Label();
            label61 = new Label();
            label62 = new Label();
            label66 = new Label();
            label67 = new Label();
            lblHN = new Label();
            lblDOB = new Label();
            lblAge = new Label();
            lblGender = new Label();
            lblIdcard = new Label();
            lblNationality = new Label();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanelGA = new DevExpress.XtraBars.Docking.DockPanel();
            controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            pnButton = new DevExpress.XtraEditors.PanelControl();
            cmdPrintResultStudent = new DevExpress.XtraEditors.SimpleButton();
            panel9 = new Panel();
            cmdAdminSave = new DevExpress.XtraEditors.SimpleButton();
            cmdClose = new DevExpress.XtraEditors.SimpleButton();
            cmdPrintResultNew = new DevExpress.XtraEditors.SimpleButton();
            cmdPrintResultOld = new DevExpress.XtraEditors.SimpleButton();
            cmdPrintResultBookCover = new DevExpress.XtraEditors.SimpleButton();
            dockPanelPE = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            dockPanelVision = new DevExpress.XtraBars.Docking.DockPanel();
            controlContainer2 = new DevExpress.XtraBars.Docking.ControlContainer();
            dockPanelAudiogram = new DevExpress.XtraBars.Docking.DockPanel();
            controlContainer3 = new DevExpress.XtraBars.Docking.ControlContainer();
            dockPanelSpecial = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel8_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            dockPanelCBC = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel12_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            dockPanelBloodChemistry = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            dockPanelUA = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel11_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            dockPanelStool = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel10_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            dockPanelStoolCulture = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel9_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            dockPanelXray = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel7_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            dockPanelEKG = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel6_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            dockPanelConfidential = new DevExpress.XtraBars.Docking.DockPanel();
            controlContainer5 = new DevExpress.XtraBars.Docking.ControlContainer();
            pnConfidential = new Panel();
            grdConfidential = new DevExpress.XtraGrid.GridControl();
            grdViewConfidential = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn55 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn56 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemMemoEdit8 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            gridColumn57 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn58 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn59 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit15 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            gridColumn60 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit16 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            gridColumn61 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn62 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn63 = new DevExpress.XtraGrid.Columns.GridColumn();
            dockPanelDoctor = new DevExpress.XtraBars.Docking.DockPanel();
            controlContainer4 = new DevExpress.XtraBars.Docking.ControlContainer();
            dockPanelAddress = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel4_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            dockPanelReference = new DevExpress.XtraBars.Docking.DockPanel();
            dockPanel5_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            lblVisitNumber = new Label();
            lblUpdBy = new Label();
            lblLastUpd = new Label();
            label68 = new Label();
            label27 = new Label();
            lblDocumentStatus = new Label();
            label12 = new Label();
            label19 = new Label();
            lblPatientVisitUID = new Label();
            label11 = new Label();
            lblPatientUID = new Label();
            panelContainerLeft = new DevExpress.XtraBars.Docking.DockPanel();
            panelContainerResult = new DevExpress.XtraBars.Docking.DockPanel();
            progressLoad = new Panel();
            picLoading = new PictureBox();
            lblWait = new Label();
            dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            ((System.ComponentModel.ISupportInitialize)leIsAbnormal).BeginInit();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lstRecommendList).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSearchRecommendation.Properties).BeginInit();
            pnDoctorSummary.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtResult_DoctorRecommend.Properties).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ddlDoctor_Conclusion.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlDoctor_PE.Properties).BeginInit();
            pnPE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ddlGA_LevelOfConsciousne.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_Others.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_Skin.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_Extremties.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_Abdomen.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_Heart.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_LungChestBreast.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_Thyroid.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_Lymphoma.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_MouthAndThroat.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_EareAndNose.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_Eye.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_HeadAndFace.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_LevelOfConsciousne.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_Others.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_Skin.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_Extremties.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_Abdomen.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_Heart.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_LungChestBreast.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_Thyroid.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_Lymphoma.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_MouthAndThroat.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_EareAndNose.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_Eye.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_HeadAndFace.Properties).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtVS_SummaryRemark.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlVS_Summary.Properties).BeginInit();
            pnVision.SuspendLayout();
            panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ddlVS_Blind.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtVS_BlindRemark.Properties).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ddlVS_RetinaRight.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtVS_VisibilityRight.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlVS_VisibilityRight.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtVS_RetinaRight.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlVS_EyeballRight.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtVS_EyeballRight.Properties).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtVS_VisibilityLeft.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlVS_VisibilityLeft.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtVS_RetinaLeft.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlVS_EyeballLeft.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlVS_RetinaLeft.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtVS_EyeballLeft.Properties).BeginInit();
            pnAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ddlEarsLeftRemark.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlEarsLeft.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlEarsRightRemark.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlEarsRight.Properties).BeginInit();
            pnBloodChem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridBloodChemistry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewBloodChemistry).BeginInit();
            pnStool2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ddlST_Summary.Properties).BeginInit();
            pnStool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridStool).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewStool).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemMemoEdit5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit10).BeginInit();
            pnStoolCulture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridStoolCulture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewStoolCulture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemMemoEdit6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit12).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ddlUA_Summary.Properties).BeginInit();
            pnUA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridUrine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewUrine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemMemoEdit7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit14).BeginInit();
            pnCBC2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ddlCBC_Summary.Properties).BeginInit();
            pnCBC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdCBC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewCBC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemMemoEdit3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit6).BeginInit();
            pnXray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtX_USBreast.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_USBreast.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtX_LowerAbdomenRemark.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_LowerAbdomen.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtX_Mammogram.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_Mammogram.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtX_EchoRemark.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_Echo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtX_UpperAbdomenRemark.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtX_ChestPA.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_UpperAbdomen.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_ChestPA.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtX_AbdomenRemark.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_Abdomen.Properties).BeginInit();
            pnSpecial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdSpecialTest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdViewSpecialTest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemMemoEdit2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit4).BeginInit();
            pnTechnicOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPapSmear.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkPapSmear.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtVegina.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkVegina.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtX_EKGResult.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_EKG.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtX_BMDRemark.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_BMD.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_EST.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtX_ABIRemark.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_ABI.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtX_ESTRemark.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemMemoEdit4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemMemoEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl8).BeginInit();
            groupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtZipCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlProvince.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAddress.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControlPE).BeginInit();
            groupControlPE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dockManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barAndDockingController1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageCollection1).BeginInit();
            dockPanelPatient.SuspendLayout();
            dockPanel1_Container.SuspendLayout();
            ribbonClientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            dockPanel2.SuspendLayout();
            dockPanelGA.SuspendLayout();
            controlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnButton).BeginInit();
            pnButton.SuspendLayout();
            panel9.SuspendLayout();
            dockPanelPE.SuspendLayout();
            dockPanel2_Container.SuspendLayout();
            dockPanelVision.SuspendLayout();
            controlContainer2.SuspendLayout();
            dockPanelAudiogram.SuspendLayout();
            controlContainer3.SuspendLayout();
            dockPanelSpecial.SuspendLayout();
            dockPanel8_Container.SuspendLayout();
            dockPanelCBC.SuspendLayout();
            dockPanel12_Container.SuspendLayout();
            dockPanelBloodChemistry.SuspendLayout();
            dockPanel3_Container.SuspendLayout();
            dockPanelUA.SuspendLayout();
            dockPanel11_Container.SuspendLayout();
            dockPanelStool.SuspendLayout();
            dockPanel10_Container.SuspendLayout();
            dockPanelStoolCulture.SuspendLayout();
            dockPanel9_Container.SuspendLayout();
            dockPanelXray.SuspendLayout();
            dockPanel7_Container.SuspendLayout();
            dockPanelEKG.SuspendLayout();
            dockPanel6_Container.SuspendLayout();
            dockPanelConfidential.SuspendLayout();
            controlContainer5.SuspendLayout();
            pnConfidential.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdConfidential).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdViewConfidential).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemMemoEdit8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit16).BeginInit();
            dockPanelDoctor.SuspendLayout();
            controlContainer4.SuspendLayout();
            dockPanelAddress.SuspendLayout();
            dockPanel4_Container.SuspendLayout();
            dockPanelReference.SuspendLayout();
            dockPanel5_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            progressLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLoading).BeginInit();
            SuspendLayout();
            // 
            // leIsAbnormal
            // 
            leIsAbnormal.Appearance.Font = new Font("Segoe UI", 10F);
            leIsAbnormal.Appearance.Options.UseFont = true;
            leIsAbnormal.AppearanceDropDown.Font = new Font("Segoe UI", 10F);
            leIsAbnormal.AppearanceDropDown.Options.UseFont = true;
            leIsAbnormal.AutoHeight = false;
            leIsAbnormal.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            leIsAbnormal.LookAndFeel.SkinName = "Office 2010 Blue";
            leIsAbnormal.LookAndFeel.UseDefaultLookAndFeel = false;
            leIsAbnormal.Name = "leIsAbnormal";
            leIsAbnormal.NullText = "";
            // 
            // cmdPrintResultBook
            // 
            cmdPrintResultBook.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cmdPrintResultBook.Appearance.ForeColor = Color.White;
            cmdPrintResultBook.Appearance.Options.UseFont = true;
            cmdPrintResultBook.Appearance.Options.UseForeColor = true;
            cmdPrintResultBook.ImageOptions.Image = (Image)resources.GetObject("cmdPrintResultBook.ImageOptions.Image");
            cmdPrintResultBook.Location = new Point(600, 4);
            cmdPrintResultBook.LookAndFeel.SkinMaskColor = Color.FromArgb(0, 102, 102);
            cmdPrintResultBook.LookAndFeel.SkinName = "DevExpress Dark Style";
            cmdPrintResultBook.LookAndFeel.UseDefaultLookAndFeel = false;
            cmdPrintResultBook.Name = "cmdPrintResultBook";
            cmdPrintResultBook.Size = new Size(177, 27);
            cmdPrintResultBook.TabIndex = 12;
            cmdPrintResultBook.Text = "สมุดรายงานผล (รูปเล่ม)";
            cmdPrintResultBook.Click += cmdPrintResultBook_Click;
            // 
            // cmdFinalize
            // 
            cmdFinalize.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cmdFinalize.Appearance.ForeColor = Color.White;
            cmdFinalize.Appearance.Options.UseFont = true;
            cmdFinalize.Appearance.Options.UseForeColor = true;
            cmdFinalize.ImageOptions.Image = Resources.star_orange;
            cmdFinalize.Location = new Point(112, 4);
            cmdFinalize.LookAndFeel.SkinMaskColor = Color.FromArgb(128, 128, 255);
            cmdFinalize.LookAndFeel.SkinName = "DevExpress Dark Style";
            cmdFinalize.LookAndFeel.UseDefaultLookAndFeel = false;
            cmdFinalize.Name = "cmdFinalize";
            cmdFinalize.Size = new Size(100, 27);
            cmdFinalize.TabIndex = 11;
            cmdFinalize.Text = "Finalize";
            cmdFinalize.Click += cmdFinalize_Click;
            // 
            // cmdTempSave
            // 
            cmdTempSave.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cmdTempSave.Appearance.ForeColor = Color.White;
            cmdTempSave.Appearance.Options.UseFont = true;
            cmdTempSave.Appearance.Options.UseForeColor = true;
            cmdTempSave.ImageOptions.Image = (Image)resources.GetObject("cmdTempSave.ImageOptions.Image");
            cmdTempSave.Location = new Point(6, 4);
            cmdTempSave.LookAndFeel.SkinMaskColor = SystemColors.HotTrack;
            cmdTempSave.LookAndFeel.SkinName = "DevExpress Dark Style";
            cmdTempSave.LookAndFeel.UseDefaultLookAndFeel = false;
            cmdTempSave.Name = "cmdTempSave";
            cmdTempSave.Size = new Size(100, 27);
            cmdTempSave.TabIndex = 10;
            cmdTempSave.Text = "Save";
            cmdTempSave.Click += cmdTempSave_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 335);
            panel1.Name = "panel1";
            panel1.Size = new Size(1486, 218);
            panel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(lstRecommendList);
            panel5.Location = new Point(0, 35);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(5, 5, 10, 10);
            panel5.Size = new Size(371, 224);
            panel5.TabIndex = 55;
            // 
            // lstRecommendList
            // 
            lstRecommendList.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            lstRecommendList.Appearance.Font = new Font("Segoe UI", 9.5F);
            lstRecommendList.Appearance.Options.UseFont = true;
            lstRecommendList.Dock = DockStyle.Fill;
            lstRecommendList.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            lstRecommendList.HorizontalScrollbar = true;
            lstRecommendList.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick;
            lstRecommendList.Location = new Point(5, 5);
            lstRecommendList.LookAndFeel.SkinName = "Office 2016 Colorful";
            lstRecommendList.LookAndFeel.UseDefaultLookAndFeel = false;
            lstRecommendList.Name = "lstRecommendList";
            lstRecommendList.Size = new Size(356, 209);
            lstRecommendList.SortOrder = SortOrder.Ascending;
            lstRecommendList.TabIndex = 0;
            lstRecommendList.SelectedValueChanged += lstRecommendList_SelectedValueChanged;
            lstRecommendList.DoubleClick += lstRecommendList_DoubleClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtSearchRecommendation);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(359, 35);
            panel2.TabIndex = 54;
            // 
            // txtSearchRecommendation
            // 
            txtSearchRecommendation.Client = lstRecommendList;
            txtSearchRecommendation.Dock = DockStyle.Fill;
            txtSearchRecommendation.EditValue = "";
            txtSearchRecommendation.Location = new Point(5, 5);
            txtSearchRecommendation.Name = "txtSearchRecommendation";
            txtSearchRecommendation.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            txtSearchRecommendation.Properties.Appearance.Options.UseFont = true;
            txtSearchRecommendation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Repository.ClearButton(), new DevExpress.XtraEditors.Repository.SearchButton() });
            txtSearchRecommendation.Properties.Client = lstRecommendList;
            txtSearchRecommendation.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtSearchRecommendation.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtSearchRecommendation.Size = new Size(349, 24);
            txtSearchRecommendation.TabIndex = 53;
            txtSearchRecommendation.KeyDown += txtSearchRecommendation_KeyDown;
            // 
            // pnDoctorSummary
            // 
            pnDoctorSummary.AutoScroll = true;
            pnDoctorSummary.BackColor = Color.Transparent;
            pnDoctorSummary.Controls.Add(panel7);
            pnDoctorSummary.Controls.Add(panel6);
            pnDoctorSummary.Dock = DockStyle.Top;
            pnDoctorSummary.Font = new Font("Segoe UI", 10F);
            pnDoctorSummary.Location = new Point(0, 0);
            pnDoctorSummary.Name = "pnDoctorSummary";
            pnDoctorSummary.Size = new Size(1486, 335);
            pnDoctorSummary.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtResult_DoctorRecommend);
            panel7.Location = new Point(0, 36);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(5);
            panel7.Size = new Size(393, 299);
            panel7.TabIndex = 51;
            // 
            // txtResult_DoctorRecommend
            // 
            txtResult_DoctorRecommend.Dock = DockStyle.Fill;
            txtResult_DoctorRecommend.EditValue = "";
            txtResult_DoctorRecommend.Location = new Point(5, 5);
            txtResult_DoctorRecommend.Name = "txtResult_DoctorRecommend";
            txtResult_DoctorRecommend.Properties.Appearance.BackColor = Color.FromArgb(255, 255, 200);
            txtResult_DoctorRecommend.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            txtResult_DoctorRecommend.Properties.Appearance.Options.UseBackColor = true;
            txtResult_DoctorRecommend.Properties.Appearance.Options.UseFont = true;
            txtResult_DoctorRecommend.Properties.HideSelection = false;
            txtResult_DoctorRecommend.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtResult_DoctorRecommend.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtResult_DoctorRecommend.Size = new Size(383, 289);
            txtResult_DoctorRecommend.TabIndex = 45;
            // 
            // panel6
            // 
            panel6.Controls.Add(label30);
            panel6.Controls.Add(ddlDoctor_Conclusion);
            panel6.Controls.Add(label31);
            panel6.Controls.Add(ddlDoctor_PE);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1486, 36);
            panel6.TabIndex = 50;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(2, 8);
            label30.Name = "label30";
            label30.Size = new Size(113, 19);
            label30.TabIndex = 46;
            label30.Text = "แพทย์ผู้ตรวจร่างกาย";
            // 
            // ddlDoctor_Conclusion
            // 
            ddlDoctor_Conclusion.EditValue = "";
            ddlDoctor_Conclusion.Location = new Point(399, 5);
            ddlDoctor_Conclusion.Name = "ddlDoctor_Conclusion";
            ddlDoctor_Conclusion.Properties.Appearance.BackColor = Color.FromArgb(255, 255, 200);
            ddlDoctor_Conclusion.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlDoctor_Conclusion.Properties.Appearance.Options.UseBackColor = true;
            ddlDoctor_Conclusion.Properties.Appearance.Options.UseFont = true;
            ddlDoctor_Conclusion.Properties.AppearanceDropDown.Font = new Font("Segoe UI", 10F);
            ddlDoctor_Conclusion.Properties.AppearanceDropDown.Options.UseFont = true;
            ddlDoctor_Conclusion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlDoctor_Conclusion.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlDoctor_Conclusion.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlDoctor_Conclusion.Properties.NullText = "";
            ddlDoctor_Conclusion.Properties.ShowFooter = false;
            ddlDoctor_Conclusion.Properties.ShowHeader = false;
            ddlDoctor_Conclusion.Size = new Size(183, 24);
            ddlDoctor_Conclusion.TabIndex = 49;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(307, 8);
            label31.Name = "label31";
            label31.Size = new Size(86, 19);
            label31.TabIndex = 47;
            label31.Text = "แพทย์ผู้สรุปผล";
            // 
            // ddlDoctor_PE
            // 
            ddlDoctor_PE.EditValue = "";
            ddlDoctor_PE.Location = new Point(118, 5);
            ddlDoctor_PE.Name = "ddlDoctor_PE";
            ddlDoctor_PE.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlDoctor_PE.Properties.Appearance.Options.UseFont = true;
            ddlDoctor_PE.Properties.AppearanceDropDown.Font = new Font("Segoe UI", 10F);
            ddlDoctor_PE.Properties.AppearanceDropDown.Options.UseFont = true;
            ddlDoctor_PE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlDoctor_PE.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlDoctor_PE.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlDoctor_PE.Properties.NullText = "";
            ddlDoctor_PE.Properties.ShowFooter = false;
            ddlDoctor_PE.Properties.ShowHeader = false;
            ddlDoctor_PE.Size = new Size(183, 24);
            ddlDoctor_PE.TabIndex = 48;
            // 
            // pnPE
            // 
            pnPE.AutoScroll = true;
            pnPE.Controls.Add(ddlGA_LevelOfConsciousne);
            pnPE.Controls.Add(txtGA_Others);
            pnPE.Controls.Add(txtGA_Skin);
            pnPE.Controls.Add(txtGA_Extremties);
            pnPE.Controls.Add(txtGA_Abdomen);
            pnPE.Controls.Add(txtGA_Heart);
            pnPE.Controls.Add(txtGA_LungChestBreast);
            pnPE.Controls.Add(txtGA_Thyroid);
            pnPE.Controls.Add(txtGA_Lymphoma);
            pnPE.Controls.Add(txtGA_MouthAndThroat);
            pnPE.Controls.Add(txtGA_EareAndNose);
            pnPE.Controls.Add(txtGA_Eye);
            pnPE.Controls.Add(txtGA_HeadAndFace);
            pnPE.Controls.Add(txtGA_LevelOfConsciousne);
            pnPE.Controls.Add(ddlGA_Others);
            pnPE.Controls.Add(label52);
            pnPE.Controls.Add(ddlGA_Skin);
            pnPE.Controls.Add(ddlGA_Extremties);
            pnPE.Controls.Add(ddlGA_Abdomen);
            pnPE.Controls.Add(ddlGA_Heart);
            pnPE.Controls.Add(ddlGA_LungChestBreast);
            pnPE.Controls.Add(ddlGA_Thyroid);
            pnPE.Controls.Add(ddlGA_Lymphoma);
            pnPE.Controls.Add(ddlGA_MouthAndThroat);
            pnPE.Controls.Add(ddlGA_EareAndNose);
            pnPE.Controls.Add(ddlGA_Eye);
            pnPE.Controls.Add(label46);
            pnPE.Controls.Add(label47);
            pnPE.Controls.Add(label48);
            pnPE.Controls.Add(label49);
            pnPE.Controls.Add(label50);
            pnPE.Controls.Add(label51);
            pnPE.Controls.Add(label44);
            pnPE.Controls.Add(label45);
            pnPE.Controls.Add(label42);
            pnPE.Controls.Add(label43);
            pnPE.Controls.Add(ddlGA_HeadAndFace);
            pnPE.Controls.Add(label41);
            pnPE.Controls.Add(label40);
            pnPE.Controls.Add(label39);
            pnPE.Controls.Add(label38);
            pnPE.Controls.Add(chkNoCheck);
            pnPE.Dock = DockStyle.Fill;
            pnPE.Location = new Point(0, 0);
            pnPE.Name = "pnPE";
            pnPE.Size = new Size(1486, 494);
            pnPE.TabIndex = 2;
            // 
            // ddlGA_LevelOfConsciousne
            // 
            ddlGA_LevelOfConsciousne.EditValue = "";
            ddlGA_LevelOfConsciousne.Location = new Point(238, 62);
            ddlGA_LevelOfConsciousne.Name = "ddlGA_LevelOfConsciousne";
            ddlGA_LevelOfConsciousne.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            ddlGA_LevelOfConsciousne.Properties.Appearance.Options.UseFont = true;
            ddlGA_LevelOfConsciousne.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlGA_LevelOfConsciousne.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlGA_LevelOfConsciousne.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlGA_LevelOfConsciousne.Properties.NullText = "";
            ddlGA_LevelOfConsciousne.Size = new Size(160, 24);
            ddlGA_LevelOfConsciousne.TabIndex = 8;
            // 
            // txtGA_Others
            // 
            txtGA_Others.EditValue = "";
            txtGA_Others.Location = new Point(404, 374);
            txtGA_Others.Name = "txtGA_Others";
            txtGA_Others.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            txtGA_Others.Properties.Appearance.Options.UseFont = true;
            txtGA_Others.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtGA_Others.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtGA_Others.Size = new Size(376, 24);
            txtGA_Others.TabIndex = 47;
            // 
            // txtGA_Skin
            // 
            txtGA_Skin.EditValue = "";
            txtGA_Skin.Location = new Point(404, 348);
            txtGA_Skin.Name = "txtGA_Skin";
            txtGA_Skin.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            txtGA_Skin.Properties.Appearance.Options.UseFont = true;
            txtGA_Skin.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtGA_Skin.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtGA_Skin.Size = new Size(376, 24);
            txtGA_Skin.TabIndex = 46;
            // 
            // txtGA_Extremties
            // 
            txtGA_Extremties.EditValue = "";
            txtGA_Extremties.Location = new Point(404, 322);
            txtGA_Extremties.Name = "txtGA_Extremties";
            txtGA_Extremties.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            txtGA_Extremties.Properties.Appearance.Options.UseFont = true;
            txtGA_Extremties.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtGA_Extremties.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtGA_Extremties.Size = new Size(376, 24);
            txtGA_Extremties.TabIndex = 45;
            // 
            // txtGA_Abdomen
            // 
            txtGA_Abdomen.EditValue = "";
            txtGA_Abdomen.Location = new Point(404, 296);
            txtGA_Abdomen.Name = "txtGA_Abdomen";
            txtGA_Abdomen.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            txtGA_Abdomen.Properties.Appearance.Options.UseFont = true;
            txtGA_Abdomen.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtGA_Abdomen.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtGA_Abdomen.Size = new Size(376, 24);
            txtGA_Abdomen.TabIndex = 44;
            // 
            // txtGA_Heart
            // 
            txtGA_Heart.EditValue = "";
            txtGA_Heart.Location = new Point(404, 270);
            txtGA_Heart.Name = "txtGA_Heart";
            txtGA_Heart.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            txtGA_Heart.Properties.Appearance.Options.UseFont = true;
            txtGA_Heart.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtGA_Heart.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtGA_Heart.Size = new Size(376, 24);
            txtGA_Heart.TabIndex = 43;
            // 
            // txtGA_LungChestBreast
            // 
            txtGA_LungChestBreast.EditValue = "";
            txtGA_LungChestBreast.Location = new Point(404, 245);
            txtGA_LungChestBreast.Name = "txtGA_LungChestBreast";
            txtGA_LungChestBreast.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            txtGA_LungChestBreast.Properties.Appearance.Options.UseFont = true;
            txtGA_LungChestBreast.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtGA_LungChestBreast.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtGA_LungChestBreast.Size = new Size(376, 24);
            txtGA_LungChestBreast.TabIndex = 42;
            // 
            // txtGA_Thyroid
            // 
            txtGA_Thyroid.EditValue = "";
            txtGA_Thyroid.Location = new Point(404, 218);
            txtGA_Thyroid.Name = "txtGA_Thyroid";
            txtGA_Thyroid.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            txtGA_Thyroid.Properties.Appearance.Options.UseFont = true;
            txtGA_Thyroid.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtGA_Thyroid.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtGA_Thyroid.Size = new Size(376, 24);
            txtGA_Thyroid.TabIndex = 41;
            // 
            // txtGA_Lymphoma
            // 
            txtGA_Lymphoma.EditValue = "";
            txtGA_Lymphoma.Location = new Point(404, 193);
            txtGA_Lymphoma.Name = "txtGA_Lymphoma";
            txtGA_Lymphoma.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            txtGA_Lymphoma.Properties.Appearance.Options.UseFont = true;
            txtGA_Lymphoma.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtGA_Lymphoma.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtGA_Lymphoma.Size = new Size(376, 24);
            txtGA_Lymphoma.TabIndex = 40;
            // 
            // txtGA_MouthAndThroat
            // 
            txtGA_MouthAndThroat.EditValue = "";
            txtGA_MouthAndThroat.Location = new Point(404, 166);
            txtGA_MouthAndThroat.Name = "txtGA_MouthAndThroat";
            txtGA_MouthAndThroat.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            txtGA_MouthAndThroat.Properties.Appearance.Options.UseFont = true;
            txtGA_MouthAndThroat.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtGA_MouthAndThroat.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtGA_MouthAndThroat.Size = new Size(376, 24);
            txtGA_MouthAndThroat.TabIndex = 39;
            // 
            // txtGA_EareAndNose
            // 
            txtGA_EareAndNose.EditValue = "";
            txtGA_EareAndNose.Location = new Point(404, 141);
            txtGA_EareAndNose.Name = "txtGA_EareAndNose";
            txtGA_EareAndNose.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            txtGA_EareAndNose.Properties.Appearance.Options.UseFont = true;
            txtGA_EareAndNose.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtGA_EareAndNose.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtGA_EareAndNose.Size = new Size(376, 24);
            txtGA_EareAndNose.TabIndex = 38;
            // 
            // txtGA_Eye
            // 
            txtGA_Eye.EditValue = "";
            txtGA_Eye.Location = new Point(404, 114);
            txtGA_Eye.Name = "txtGA_Eye";
            txtGA_Eye.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            txtGA_Eye.Properties.Appearance.Options.UseFont = true;
            txtGA_Eye.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtGA_Eye.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtGA_Eye.Size = new Size(376, 24);
            txtGA_Eye.TabIndex = 37;
            // 
            // txtGA_HeadAndFace
            // 
            txtGA_HeadAndFace.EditValue = "";
            txtGA_HeadAndFace.Location = new Point(404, 88);
            txtGA_HeadAndFace.Name = "txtGA_HeadAndFace";
            txtGA_HeadAndFace.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            txtGA_HeadAndFace.Properties.Appearance.Options.UseFont = true;
            txtGA_HeadAndFace.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtGA_HeadAndFace.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtGA_HeadAndFace.Size = new Size(376, 24);
            txtGA_HeadAndFace.TabIndex = 36;
            // 
            // txtGA_LevelOfConsciousne
            // 
            txtGA_LevelOfConsciousne.EditValue = "";
            txtGA_LevelOfConsciousne.Location = new Point(404, 62);
            txtGA_LevelOfConsciousne.Name = "txtGA_LevelOfConsciousne";
            txtGA_LevelOfConsciousne.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            txtGA_LevelOfConsciousne.Properties.Appearance.Options.UseFont = true;
            txtGA_LevelOfConsciousne.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtGA_LevelOfConsciousne.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtGA_LevelOfConsciousne.Size = new Size(376, 24);
            txtGA_LevelOfConsciousne.TabIndex = 35;
            // 
            // ddlGA_Others
            // 
            ddlGA_Others.EditValue = "";
            ddlGA_Others.Location = new Point(238, 374);
            ddlGA_Others.Name = "ddlGA_Others";
            ddlGA_Others.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            ddlGA_Others.Properties.Appearance.Options.UseFont = true;
            ddlGA_Others.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlGA_Others.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlGA_Others.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlGA_Others.Properties.NullText = "";
            ddlGA_Others.Size = new Size(160, 24);
            ddlGA_Others.TabIndex = 33;
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Font = new Font("Segoe UI", 9.75F);
            label52.Location = new Point(13, 378);
            label52.Name = "label52";
            label52.Size = new Size(73, 17);
            label52.TabIndex = 32;
            label52.Text = "อื่นๆ/Others";
            // 
            // ddlGA_Skin
            // 
            ddlGA_Skin.EditValue = "";
            ddlGA_Skin.Location = new Point(238, 348);
            ddlGA_Skin.Name = "ddlGA_Skin";
            ddlGA_Skin.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            ddlGA_Skin.Properties.Appearance.Options.UseFont = true;
            ddlGA_Skin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlGA_Skin.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlGA_Skin.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlGA_Skin.Properties.NullText = "";
            ddlGA_Skin.Size = new Size(160, 24);
            ddlGA_Skin.TabIndex = 31;
            // 
            // ddlGA_Extremties
            // 
            ddlGA_Extremties.EditValue = "";
            ddlGA_Extremties.Location = new Point(238, 322);
            ddlGA_Extremties.Name = "ddlGA_Extremties";
            ddlGA_Extremties.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            ddlGA_Extremties.Properties.Appearance.Options.UseFont = true;
            ddlGA_Extremties.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlGA_Extremties.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlGA_Extremties.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlGA_Extremties.Properties.NullText = "";
            ddlGA_Extremties.Size = new Size(160, 24);
            ddlGA_Extremties.TabIndex = 30;
            // 
            // ddlGA_Abdomen
            // 
            ddlGA_Abdomen.EditValue = "";
            ddlGA_Abdomen.Location = new Point(238, 296);
            ddlGA_Abdomen.Name = "ddlGA_Abdomen";
            ddlGA_Abdomen.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            ddlGA_Abdomen.Properties.Appearance.Options.UseFont = true;
            ddlGA_Abdomen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlGA_Abdomen.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlGA_Abdomen.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlGA_Abdomen.Properties.NullText = "";
            ddlGA_Abdomen.Size = new Size(160, 24);
            ddlGA_Abdomen.TabIndex = 29;
            // 
            // ddlGA_Heart
            // 
            ddlGA_Heart.EditValue = "";
            ddlGA_Heart.Location = new Point(238, 270);
            ddlGA_Heart.Name = "ddlGA_Heart";
            ddlGA_Heart.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            ddlGA_Heart.Properties.Appearance.Options.UseFont = true;
            ddlGA_Heart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlGA_Heart.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlGA_Heart.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlGA_Heart.Properties.NullText = "";
            ddlGA_Heart.Size = new Size(160, 24);
            ddlGA_Heart.TabIndex = 28;
            // 
            // ddlGA_LungChestBreast
            // 
            ddlGA_LungChestBreast.EditValue = "";
            ddlGA_LungChestBreast.Location = new Point(238, 244);
            ddlGA_LungChestBreast.Name = "ddlGA_LungChestBreast";
            ddlGA_LungChestBreast.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            ddlGA_LungChestBreast.Properties.Appearance.Options.UseFont = true;
            ddlGA_LungChestBreast.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlGA_LungChestBreast.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlGA_LungChestBreast.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlGA_LungChestBreast.Properties.NullText = "";
            ddlGA_LungChestBreast.Size = new Size(160, 24);
            ddlGA_LungChestBreast.TabIndex = 27;
            // 
            // ddlGA_Thyroid
            // 
            ddlGA_Thyroid.EditValue = "";
            ddlGA_Thyroid.Location = new Point(238, 218);
            ddlGA_Thyroid.Name = "ddlGA_Thyroid";
            ddlGA_Thyroid.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            ddlGA_Thyroid.Properties.Appearance.Options.UseFont = true;
            ddlGA_Thyroid.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlGA_Thyroid.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlGA_Thyroid.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlGA_Thyroid.Properties.NullText = "";
            ddlGA_Thyroid.Size = new Size(160, 24);
            ddlGA_Thyroid.TabIndex = 26;
            // 
            // ddlGA_Lymphoma
            // 
            ddlGA_Lymphoma.EditValue = "";
            ddlGA_Lymphoma.Location = new Point(238, 192);
            ddlGA_Lymphoma.Name = "ddlGA_Lymphoma";
            ddlGA_Lymphoma.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            ddlGA_Lymphoma.Properties.Appearance.Options.UseFont = true;
            ddlGA_Lymphoma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlGA_Lymphoma.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlGA_Lymphoma.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlGA_Lymphoma.Properties.NullText = "";
            ddlGA_Lymphoma.Size = new Size(160, 24);
            ddlGA_Lymphoma.TabIndex = 25;
            // 
            // ddlGA_MouthAndThroat
            // 
            ddlGA_MouthAndThroat.EditValue = "";
            ddlGA_MouthAndThroat.Location = new Point(238, 166);
            ddlGA_MouthAndThroat.Name = "ddlGA_MouthAndThroat";
            ddlGA_MouthAndThroat.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            ddlGA_MouthAndThroat.Properties.Appearance.Options.UseFont = true;
            ddlGA_MouthAndThroat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlGA_MouthAndThroat.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlGA_MouthAndThroat.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlGA_MouthAndThroat.Properties.NullText = "";
            ddlGA_MouthAndThroat.Size = new Size(160, 24);
            ddlGA_MouthAndThroat.TabIndex = 24;
            // 
            // ddlGA_EareAndNose
            // 
            ddlGA_EareAndNose.EditValue = "";
            ddlGA_EareAndNose.Location = new Point(238, 140);
            ddlGA_EareAndNose.Name = "ddlGA_EareAndNose";
            ddlGA_EareAndNose.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            ddlGA_EareAndNose.Properties.Appearance.Options.UseFont = true;
            ddlGA_EareAndNose.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlGA_EareAndNose.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlGA_EareAndNose.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlGA_EareAndNose.Properties.NullText = "";
            ddlGA_EareAndNose.Size = new Size(160, 24);
            ddlGA_EareAndNose.TabIndex = 23;
            // 
            // ddlGA_Eye
            // 
            ddlGA_Eye.EditValue = "";
            ddlGA_Eye.Location = new Point(238, 114);
            ddlGA_Eye.Name = "ddlGA_Eye";
            ddlGA_Eye.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            ddlGA_Eye.Properties.Appearance.Options.UseFont = true;
            ddlGA_Eye.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlGA_Eye.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlGA_Eye.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlGA_Eye.Properties.NullText = "";
            ddlGA_Eye.Size = new Size(160, 24);
            ddlGA_Eye.TabIndex = 22;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Font = new Font("Segoe UI", 9.75F);
            label46.Location = new Point(13, 352);
            label46.Name = "label46";
            label46.Size = new Size(78, 17);
            label46.TabIndex = 21;
            label46.Text = "ผิวหนัง (Skin)";
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Font = new Font("Segoe UI", 9.75F);
            label47.Location = new Point(13, 300);
            label47.Name = "label47";
            label47.Size = new Size(117, 17);
            label47.TabIndex = 20;
            label47.Text = "ช่องท้อง (Abdomen)";
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Font = new Font("Segoe UI", 9.75F);
            label48.Location = new Point(13, 274);
            label48.Name = "label48";
            label48.Size = new Size(76, 17);
            label48.TabIndex = 19;
            label48.Text = "หัวใจ (Heart)";
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Font = new Font("Segoe UI", 9.75F);
            label49.Location = new Point(13, 326);
            label49.Name = "label49";
            label49.Size = new Size(119, 17);
            label49.TabIndex = 18;
            label49.Text = "แขน,ขา (Extremties)";
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Font = new Font("Segoe UI", 9.5F);
            label50.Location = new Point(13, 248);
            label50.Name = "label50";
            label50.Size = new Size(216, 17);
            label50.TabIndex = 17;
            label50.Text = "ปอด,หน้าอก,เต้านม (Lung,Chest,Breast)";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Font = new Font("Segoe UI", 9.75F);
            label51.Location = new Point(13, 222);
            label51.Name = "label51";
            label51.Size = new Size(123, 17);
            label51.TabIndex = 16;
            label51.Text = "ต่อมไทรอยด์ (Thyroid)";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Segoe UI", 9.75F);
            label44.Location = new Point(13, 196);
            label44.Name = "label44";
            label44.Size = new Size(159, 17);
            label44.TabIndex = 15;
            label44.Text = "ต่อมน้ำเหลือง (Lymph Node)";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Segoe UI", 9.75F);
            label45.Location = new Point(13, 144);
            label45.Name = "label45";
            label45.Size = new Size(111, 17);
            label45.TabIndex = 14;
            label45.Text = "หู,จมูก (Ears,Nose)";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 9.75F);
            label42.Location = new Point(13, 118);
            label42.Name = "label42";
            label42.Size = new Size(53, 17);
            label42.TabIndex = 13;
            label42.Text = "ตา (Eye)";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Segoe UI", 9.75F);
            label43.Location = new Point(13, 170);
            label43.Name = "label43";
            label43.Size = new Size(136, 17);
            label43.TabIndex = 12;
            label43.Text = "ปาก,คอ (Mouth,Throat)";
            // 
            // ddlGA_HeadAndFace
            // 
            ddlGA_HeadAndFace.EditValue = "";
            ddlGA_HeadAndFace.Location = new Point(238, 88);
            ddlGA_HeadAndFace.Name = "ddlGA_HeadAndFace";
            ddlGA_HeadAndFace.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            ddlGA_HeadAndFace.Properties.Appearance.Options.UseFont = true;
            ddlGA_HeadAndFace.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlGA_HeadAndFace.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlGA_HeadAndFace.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlGA_HeadAndFace.Properties.NullText = "";
            ddlGA_HeadAndFace.Size = new Size(160, 24);
            ddlGA_HeadAndFace.TabIndex = 11;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Segoe UI", 9.75F);
            label41.Location = new Point(13, 92);
            label41.Name = "label41";
            label41.Size = new Size(130, 17);
            label41.TabIndex = 10;
            label41.Text = "ศีรษะ,หน้า (Head,Face)";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Segoe UI", 9.75F);
            label40.Location = new Point(13, 65);
            label40.Name = "label40";
            label40.Size = new Size(213, 17);
            label40.TabIndex = 9;
            label40.Text = "สติสัมปชัญญะ (Level Of Consciousne)";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Segoe UI", 9.75F);
            label39.Location = new Point(480, 40);
            label39.Name = "label39";
            label39.Size = new Size(52, 17);
            label39.TabIndex = 7;
            label39.Text = "Remark";
            label39.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 9.75F);
            label38.Location = new Point(297, 40);
            label38.Name = "label38";
            label38.Size = new Size(68, 17);
            label38.TabIndex = 6;
            label38.Text = "ผลการตรวจ";
            label38.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chkNoCheck
            // 
            chkNoCheck.AutoSize = true;
            chkNoCheck.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            chkNoCheck.ForeColor = Color.FromArgb(239, 91, 35);
            chkNoCheck.Location = new Point(16, 12);
            chkNoCheck.Name = "chkNoCheck";
            chkNoCheck.Size = new Size(257, 24);
            chkNoCheck.TabIndex = 2;
            chkNoCheck.Text = "ผู้รับบริการสละสิทธิ์การตรวจร่างกาย";
            chkNoCheck.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.BackColor = Color.LemonChiffon;
            panel8.Controls.Add(txtVS_SummaryRemark);
            panel8.Controls.Add(label54);
            panel8.Controls.Add(ddlVS_Summary);
            panel8.Location = new Point(97, 168);
            panel8.Name = "panel8";
            panel8.Size = new Size(583, 62);
            panel8.TabIndex = 58;
            // 
            // txtVS_SummaryRemark
            // 
            txtVS_SummaryRemark.EditValue = "";
            txtVS_SummaryRemark.Location = new Point(162, 24);
            txtVS_SummaryRemark.Name = "txtVS_SummaryRemark";
            txtVS_SummaryRemark.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            txtVS_SummaryRemark.Properties.Appearance.Options.UseFont = true;
            txtVS_SummaryRemark.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtVS_SummaryRemark.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtVS_SummaryRemark.Properties.NullValuePrompt = "HN, Name , LastName";
            txtVS_SummaryRemark.Size = new Size(415, 24);
            txtVS_SummaryRemark.TabIndex = 53;
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label54.Location = new Point(5, 3);
            label54.Name = "label54";
            label54.Size = new Size(123, 19);
            label54.TabIndex = 17;
            label54.Text = "สรุปผลการตรวจตา";
            // 
            // ddlVS_Summary
            // 
            ddlVS_Summary.EditValue = "";
            ddlVS_Summary.Location = new Point(5, 23);
            ddlVS_Summary.Name = "ddlVS_Summary";
            ddlVS_Summary.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlVS_Summary.Properties.Appearance.Options.UseFont = true;
            ddlVS_Summary.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlVS_Summary.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlVS_Summary.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlVS_Summary.Properties.NullText = "";
            ddlVS_Summary.Size = new Size(151, 24);
            ddlVS_Summary.TabIndex = 52;
            // 
            // pnVision
            // 
            pnVision.AutoScroll = true;
            pnVision.Controls.Add(panel8);
            pnVision.Controls.Add(panel21);
            pnVision.Controls.Add(label37);
            pnVision.Controls.Add(label53);
            pnVision.Controls.Add(label55);
            pnVision.Controls.Add(label56);
            pnVision.Controls.Add(panel3);
            pnVision.Controls.Add(panel4);
            pnVision.Dock = DockStyle.Top;
            pnVision.Font = new Font("Segoe UI", 10F);
            pnVision.Location = new Point(0, 0);
            pnVision.Name = "pnVision";
            pnVision.Size = new Size(1486, 322);
            pnVision.TabIndex = 0;
            // 
            // panel21
            // 
            panel21.BackColor = Color.AliceBlue;
            panel21.Controls.Add(ddlVS_Blind);
            panel21.Controls.Add(txtVS_BlindRemark);
            panel21.Location = new Point(96, 129);
            panel21.Name = "panel21";
            panel21.Size = new Size(584, 32);
            panel21.TabIndex = 59;
            // 
            // ddlVS_Blind
            // 
            ddlVS_Blind.EditValue = "";
            ddlVS_Blind.Location = new Point(7, 4);
            ddlVS_Blind.Name = "ddlVS_Blind";
            ddlVS_Blind.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlVS_Blind.Properties.Appearance.Options.UseFont = true;
            ddlVS_Blind.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlVS_Blind.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlVS_Blind.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlVS_Blind.Properties.NullText = "";
            ddlVS_Blind.Size = new Size(150, 24);
            ddlVS_Blind.TabIndex = 44;
            // 
            // txtVS_BlindRemark
            // 
            txtVS_BlindRemark.EditValue = "";
            txtVS_BlindRemark.Location = new Point(163, 4);
            txtVS_BlindRemark.Name = "txtVS_BlindRemark";
            txtVS_BlindRemark.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            txtVS_BlindRemark.Properties.Appearance.Options.UseFont = true;
            txtVS_BlindRemark.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtVS_BlindRemark.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtVS_BlindRemark.Properties.NullValuePrompt = "HN, Name , LastName";
            txtVS_BlindRemark.Size = new Size(415, 24);
            txtVS_BlindRemark.TabIndex = 47;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(10, 95);
            label37.Name = "label37";
            label37.Size = new Size(78, 19);
            label37.TabIndex = 19;
            label37.Text = "จอประสาทตา";
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.Location = new Point(10, 130);
            label53.Name = "label53";
            label53.Size = new Size(54, 19);
            label53.TabIndex = 18;
            label53.Text = "ตาบอดสี";
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.Location = new Point(10, 65);
            label55.Name = "label55";
            label55.Size = new Size(83, 19);
            label55.TabIndex = 16;
            label55.Text = "ความดันลูกตา";
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.Location = new Point(10, 35);
            label56.Name = "label56";
            label56.Size = new Size(69, 19);
            label56.TabIndex = 15;
            label56.Text = "การมองเห็น";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Honeydew;
            panel3.Controls.Add(label57);
            panel3.Controls.Add(ddlVS_RetinaRight);
            panel3.Controls.Add(txtVS_VisibilityRight);
            panel3.Controls.Add(ddlVS_VisibilityRight);
            panel3.Controls.Add(txtVS_RetinaRight);
            panel3.Controls.Add(ddlVS_EyeballRight);
            panel3.Controls.Add(txtVS_EyeballRight);
            panel3.Font = new Font("Segoe UI", 10F);
            panel3.Location = new Point(389, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(291, 114);
            panel3.TabIndex = 56;
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.BackColor = Color.Transparent;
            label57.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label57.Location = new Point(5, 3);
            label57.Name = "label57";
            label57.Size = new Size(49, 19);
            label57.TabIndex = 54;
            label57.Text = "ตาขวา";
            // 
            // ddlVS_RetinaRight
            // 
            ddlVS_RetinaRight.EditValue = "";
            ddlVS_RetinaRight.Location = new Point(165, 83);
            ddlVS_RetinaRight.Name = "ddlVS_RetinaRight";
            ddlVS_RetinaRight.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlVS_RetinaRight.Properties.Appearance.Options.UseFont = true;
            ddlVS_RetinaRight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlVS_RetinaRight.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlVS_RetinaRight.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlVS_RetinaRight.Properties.NullText = "";
            ddlVS_RetinaRight.Size = new Size(120, 24);
            ddlVS_RetinaRight.TabIndex = 48;
            // 
            // txtVS_VisibilityRight
            // 
            txtVS_VisibilityRight.EditValue = "";
            txtVS_VisibilityRight.Location = new Point(9, 23);
            txtVS_VisibilityRight.Name = "txtVS_VisibilityRight";
            txtVS_VisibilityRight.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            txtVS_VisibilityRight.Properties.Appearance.Options.UseFont = true;
            txtVS_VisibilityRight.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtVS_VisibilityRight.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtVS_VisibilityRight.Properties.NullValuePrompt = "HN, Name , LastName";
            txtVS_VisibilityRight.Size = new Size(150, 24);
            txtVS_VisibilityRight.TabIndex = 37;
            // 
            // ddlVS_VisibilityRight
            // 
            ddlVS_VisibilityRight.EditValue = "";
            ddlVS_VisibilityRight.Location = new Point(165, 23);
            ddlVS_VisibilityRight.Name = "ddlVS_VisibilityRight";
            ddlVS_VisibilityRight.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlVS_VisibilityRight.Properties.Appearance.Options.UseFont = true;
            ddlVS_VisibilityRight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlVS_VisibilityRight.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlVS_VisibilityRight.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlVS_VisibilityRight.Properties.NullText = "";
            ddlVS_VisibilityRight.Size = new Size(120, 24);
            ddlVS_VisibilityRight.TabIndex = 36;
            // 
            // txtVS_RetinaRight
            // 
            txtVS_RetinaRight.EditValue = "";
            txtVS_RetinaRight.Location = new Point(9, 83);
            txtVS_RetinaRight.Name = "txtVS_RetinaRight";
            txtVS_RetinaRight.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            txtVS_RetinaRight.Properties.Appearance.Options.UseFont = true;
            txtVS_RetinaRight.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtVS_RetinaRight.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtVS_RetinaRight.Properties.NullValuePrompt = "HN, Name , LastName";
            txtVS_RetinaRight.Size = new Size(150, 24);
            txtVS_RetinaRight.TabIndex = 49;
            // 
            // ddlVS_EyeballRight
            // 
            ddlVS_EyeballRight.EditValue = "";
            ddlVS_EyeballRight.Location = new Point(165, 53);
            ddlVS_EyeballRight.Name = "ddlVS_EyeballRight";
            ddlVS_EyeballRight.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlVS_EyeballRight.Properties.Appearance.Options.UseFont = true;
            ddlVS_EyeballRight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlVS_EyeballRight.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlVS_EyeballRight.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlVS_EyeballRight.Properties.NullText = "";
            ddlVS_EyeballRight.Size = new Size(120, 24);
            ddlVS_EyeballRight.TabIndex = 40;
            // 
            // txtVS_EyeballRight
            // 
            txtVS_EyeballRight.EditValue = "";
            txtVS_EyeballRight.Location = new Point(9, 53);
            txtVS_EyeballRight.Name = "txtVS_EyeballRight";
            txtVS_EyeballRight.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            txtVS_EyeballRight.Properties.Appearance.Options.UseFont = true;
            txtVS_EyeballRight.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtVS_EyeballRight.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtVS_EyeballRight.Properties.NullValuePrompt = "HN, Name , LastName";
            txtVS_EyeballRight.Size = new Size(150, 24);
            txtVS_EyeballRight.TabIndex = 41;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LavenderBlush;
            panel4.Controls.Add(label58);
            panel4.Controls.Add(txtVS_VisibilityLeft);
            panel4.Controls.Add(ddlVS_VisibilityLeft);
            panel4.Controls.Add(txtVS_RetinaLeft);
            panel4.Controls.Add(ddlVS_EyeballLeft);
            panel4.Controls.Add(ddlVS_RetinaLeft);
            panel4.Controls.Add(txtVS_EyeballLeft);
            panel4.Font = new Font("Segoe UI", 10F);
            panel4.Location = new Point(96, 13);
            panel4.Name = "panel4";
            panel4.Size = new Size(291, 114);
            panel4.TabIndex = 57;
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label58.Location = new Point(3, 3);
            label58.Name = "label58";
            label58.Size = new Size(50, 19);
            label58.TabIndex = 55;
            label58.Text = "ตาซ้าย";
            // 
            // txtVS_VisibilityLeft
            // 
            txtVS_VisibilityLeft.EditValue = "";
            txtVS_VisibilityLeft.Location = new Point(7, 23);
            txtVS_VisibilityLeft.Name = "txtVS_VisibilityLeft";
            txtVS_VisibilityLeft.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            txtVS_VisibilityLeft.Properties.Appearance.Options.UseFont = true;
            txtVS_VisibilityLeft.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtVS_VisibilityLeft.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtVS_VisibilityLeft.Properties.NullValuePrompt = "HN, Name , LastName";
            txtVS_VisibilityLeft.Size = new Size(150, 24);
            txtVS_VisibilityLeft.TabIndex = 39;
            // 
            // ddlVS_VisibilityLeft
            // 
            ddlVS_VisibilityLeft.EditValue = "";
            ddlVS_VisibilityLeft.Location = new Point(163, 23);
            ddlVS_VisibilityLeft.Name = "ddlVS_VisibilityLeft";
            ddlVS_VisibilityLeft.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlVS_VisibilityLeft.Properties.Appearance.Options.UseFont = true;
            ddlVS_VisibilityLeft.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlVS_VisibilityLeft.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlVS_VisibilityLeft.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlVS_VisibilityLeft.Properties.NullText = "";
            ddlVS_VisibilityLeft.Size = new Size(120, 24);
            ddlVS_VisibilityLeft.TabIndex = 38;
            // 
            // txtVS_RetinaLeft
            // 
            txtVS_RetinaLeft.EditValue = "";
            txtVS_RetinaLeft.Location = new Point(7, 83);
            txtVS_RetinaLeft.Name = "txtVS_RetinaLeft";
            txtVS_RetinaLeft.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            txtVS_RetinaLeft.Properties.Appearance.Options.UseFont = true;
            txtVS_RetinaLeft.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtVS_RetinaLeft.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtVS_RetinaLeft.Properties.NullValuePrompt = "HN, Name , LastName";
            txtVS_RetinaLeft.Size = new Size(150, 24);
            txtVS_RetinaLeft.TabIndex = 51;
            // 
            // ddlVS_EyeballLeft
            // 
            ddlVS_EyeballLeft.EditValue = "";
            ddlVS_EyeballLeft.Location = new Point(163, 53);
            ddlVS_EyeballLeft.Name = "ddlVS_EyeballLeft";
            ddlVS_EyeballLeft.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlVS_EyeballLeft.Properties.Appearance.Options.UseFont = true;
            ddlVS_EyeballLeft.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlVS_EyeballLeft.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlVS_EyeballLeft.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlVS_EyeballLeft.Properties.NullText = "";
            ddlVS_EyeballLeft.Size = new Size(120, 24);
            ddlVS_EyeballLeft.TabIndex = 42;
            // 
            // ddlVS_RetinaLeft
            // 
            ddlVS_RetinaLeft.EditValue = "";
            ddlVS_RetinaLeft.Location = new Point(163, 83);
            ddlVS_RetinaLeft.Name = "ddlVS_RetinaLeft";
            ddlVS_RetinaLeft.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlVS_RetinaLeft.Properties.Appearance.Options.UseFont = true;
            ddlVS_RetinaLeft.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlVS_RetinaLeft.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlVS_RetinaLeft.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlVS_RetinaLeft.Properties.NullText = "";
            ddlVS_RetinaLeft.Size = new Size(120, 24);
            ddlVS_RetinaLeft.TabIndex = 50;
            // 
            // txtVS_EyeballLeft
            // 
            txtVS_EyeballLeft.EditValue = "";
            txtVS_EyeballLeft.Location = new Point(7, 53);
            txtVS_EyeballLeft.Name = "txtVS_EyeballLeft";
            txtVS_EyeballLeft.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            txtVS_EyeballLeft.Properties.Appearance.Options.UseFont = true;
            txtVS_EyeballLeft.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtVS_EyeballLeft.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtVS_EyeballLeft.Properties.NullValuePrompt = "HN, Name , LastName";
            txtVS_EyeballLeft.Size = new Size(150, 24);
            txtVS_EyeballLeft.TabIndex = 43;
            // 
            // pnAudio
            // 
            pnAudio.AutoScroll = true;
            pnAudio.Controls.Add(ddlEarsLeftRemark);
            pnAudio.Controls.Add(ddlEarsLeft);
            pnAudio.Controls.Add(ddlEarsRightRemark);
            pnAudio.Controls.Add(ddlEarsRight);
            pnAudio.Controls.Add(label59);
            pnAudio.Controls.Add(label60);
            pnAudio.Dock = DockStyle.Top;
            pnAudio.Font = new Font("Segoe UI", 10F);
            pnAudio.Location = new Point(0, 0);
            pnAudio.Name = "pnAudio";
            pnAudio.Size = new Size(1486, 86);
            pnAudio.TabIndex = 0;
            // 
            // ddlEarsLeftRemark
            // 
            ddlEarsLeftRemark.EditValue = "";
            ddlEarsLeftRemark.Location = new Point(219, 41);
            ddlEarsLeftRemark.Name = "ddlEarsLeftRemark";
            ddlEarsLeftRemark.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlEarsLeftRemark.Properties.Appearance.Options.UseFont = true;
            ddlEarsLeftRemark.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlEarsLeftRemark.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlEarsLeftRemark.Properties.NullValuePrompt = "HN, Name , LastName";
            ddlEarsLeftRemark.Size = new Size(460, 24);
            ddlEarsLeftRemark.TabIndex = 59;
            // 
            // ddlEarsLeft
            // 
            ddlEarsLeft.EditValue = "";
            ddlEarsLeft.Location = new Point(53, 42);
            ddlEarsLeft.Name = "ddlEarsLeft";
            ddlEarsLeft.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlEarsLeft.Properties.Appearance.Options.UseFont = true;
            ddlEarsLeft.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlEarsLeft.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlEarsLeft.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlEarsLeft.Properties.NullText = "";
            ddlEarsLeft.Size = new Size(160, 24);
            ddlEarsLeft.TabIndex = 58;
            // 
            // ddlEarsRightRemark
            // 
            ddlEarsRightRemark.EditValue = "";
            ddlEarsRightRemark.Location = new Point(219, 15);
            ddlEarsRightRemark.Name = "ddlEarsRightRemark";
            ddlEarsRightRemark.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlEarsRightRemark.Properties.Appearance.Options.UseFont = true;
            ddlEarsRightRemark.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlEarsRightRemark.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlEarsRightRemark.Properties.NullValuePrompt = "HN, Name , LastName";
            ddlEarsRightRemark.Size = new Size(460, 24);
            ddlEarsRightRemark.TabIndex = 57;
            // 
            // ddlEarsRight
            // 
            ddlEarsRight.EditValue = "";
            ddlEarsRight.Location = new Point(53, 15);
            ddlEarsRight.Name = "ddlEarsRight";
            ddlEarsRight.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlEarsRight.Properties.Appearance.Options.UseFont = true;
            ddlEarsRight.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlEarsRight.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlEarsRight.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlEarsRight.Properties.NullText = "";
            ddlEarsRight.Size = new Size(160, 24);
            ddlEarsRight.TabIndex = 56;
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.Location = new Point(10, 18);
            label59.Name = "label59";
            label59.Size = new Size(37, 19);
            label59.TabIndex = 55;
            label59.Text = "หูขวา";
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.Location = new Point(10, 45);
            label60.Name = "label60";
            label60.Size = new Size(39, 19);
            label60.TabIndex = 54;
            label60.Text = "หูซ้าย";
            // 
            // pnBloodChem
            // 
            pnBloodChem.AutoScroll = true;
            pnBloodChem.Controls.Add(gridBloodChemistry);
            pnBloodChem.Dock = DockStyle.Fill;
            pnBloodChem.Location = new Point(0, 0);
            pnBloodChem.Name = "pnBloodChem";
            pnBloodChem.Size = new Size(1486, 553);
            pnBloodChem.TabIndex = 0;
            // 
            // gridBloodChemistry
            // 
            gridBloodChemistry.EmbeddedNavigator.Margin = new Padding(4);
            gridBloodChemistry.Font = new Font("Segoe UI", 8F);
            gridBloodChemistry.Location = new Point(0, 0);
            gridBloodChemistry.LookAndFeel.SkinName = "Office 2010 Blue";
            gridBloodChemistry.LookAndFeel.UseDefaultLookAndFeel = false;
            gridBloodChemistry.MainView = gridViewBloodChemistry;
            gridBloodChemistry.Margin = new Padding(0);
            gridBloodChemistry.Name = "gridBloodChemistry";
            gridBloodChemistry.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { leIsAbnormal });
            gridBloodChemistry.Size = new Size(1208, 553);
            gridBloodChemistry.TabIndex = 4;
            gridBloodChemistry.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewBloodChemistry });
            // 
            // gridViewBloodChemistry
            // 
            gridViewBloodChemistry.Appearance.GroupRow.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gridViewBloodChemistry.Appearance.GroupRow.Options.UseFont = true;
            gridViewBloodChemistry.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridViewBloodChemistry.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewBloodChemistry.Appearance.Row.Font = new Font("Segoe UI", 10F);
            gridViewBloodChemistry.Appearance.Row.Options.UseFont = true;
            gridViewBloodChemistry.Appearance.Row.Options.UseTextOptions = true;
            gridViewBloodChemistry.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewBloodChemistry.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colBC_ItemName, colBC_ResultValue, colBC_UOM, colBC_Reference, colBC_IsAbnormal, colBC_Summary, colBC_ItemCode, colBC_GroupName, colBC_UID });
            gridViewBloodChemistry.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridViewBloodChemistry.GridControl = gridBloodChemistry;
            gridViewBloodChemistry.GroupCount = 1;
            gridViewBloodChemistry.GroupFormat = "[#image]{1} {2}";
            gridViewBloodChemistry.Name = "gridViewBloodChemistry";
            gridViewBloodChemistry.OptionsBehavior.AutoExpandAllGroups = true;
            gridViewBloodChemistry.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            gridViewBloodChemistry.OptionsSelection.EnableAppearanceFocusedRow = false;
            gridViewBloodChemistry.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            gridViewBloodChemistry.OptionsView.ShowGroupPanel = false;
            gridViewBloodChemistry.OptionsView.ShowIndicator = false;
            gridViewBloodChemistry.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(colBC_GroupName, DevExpress.Data.ColumnSortOrder.Ascending) });
            gridViewBloodChemistry.RowStyle += gridViewBloodChemistry_RowStyle;
            // 
            // colBC_ItemName
            // 
            colBC_ItemName.AppearanceCell.Options.UseTextOptions = true;
            colBC_ItemName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            colBC_ItemName.Caption = "Test";
            colBC_ItemName.FieldName = "ResultItemName";
            colBC_ItemName.Name = "colBC_ItemName";
            colBC_ItemName.OptionsColumn.AllowEdit = false;
            colBC_ItemName.Visible = true;
            colBC_ItemName.VisibleIndex = 0;
            colBC_ItemName.Width = 350;
            // 
            // colBC_ResultValue
            // 
            colBC_ResultValue.AppearanceCell.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            colBC_ResultValue.AppearanceCell.Options.UseFont = true;
            colBC_ResultValue.AppearanceCell.Options.UseTextOptions = true;
            colBC_ResultValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colBC_ResultValue.Caption = "Result";
            colBC_ResultValue.FieldName = "ResultValue";
            colBC_ResultValue.Name = "colBC_ResultValue";
            colBC_ResultValue.OptionsColumn.AllowEdit = false;
            colBC_ResultValue.Visible = true;
            colBC_ResultValue.VisibleIndex = 1;
            colBC_ResultValue.Width = 103;
            // 
            // colBC_UOM
            // 
            colBC_UOM.Caption = "UOM";
            colBC_UOM.FieldName = "UnitOfMeasure";
            colBC_UOM.Name = "colBC_UOM";
            colBC_UOM.OptionsColumn.AllowEdit = false;
            colBC_UOM.Visible = true;
            colBC_UOM.VisibleIndex = 2;
            colBC_UOM.Width = 86;
            // 
            // colBC_Reference
            // 
            colBC_Reference.AppearanceCell.Options.UseTextOptions = true;
            colBC_Reference.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colBC_Reference.Caption = "Reference Range";
            colBC_Reference.FieldName = "ReferenceRange";
            colBC_Reference.Name = "colBC_Reference";
            colBC_Reference.OptionsColumn.AllowEdit = false;
            colBC_Reference.Visible = true;
            colBC_Reference.VisibleIndex = 3;
            colBC_Reference.Width = 129;
            // 
            // colBC_IsAbnormal
            // 
            colBC_IsAbnormal.FieldName = "IsAbnormal";
            colBC_IsAbnormal.Name = "colBC_IsAbnormal";
            colBC_IsAbnormal.OptionsColumn.AllowEdit = false;
            // 
            // colBC_Summary
            // 
            colBC_Summary.AppearanceCell.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            colBC_Summary.AppearanceCell.Options.UseFont = true;
            colBC_Summary.AppearanceCell.Options.UseTextOptions = true;
            colBC_Summary.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colBC_Summary.AppearanceHeader.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            colBC_Summary.AppearanceHeader.Options.UseFont = true;
            colBC_Summary.Caption = "ลงผลการตรวจ";
            colBC_Summary.ColumnEdit = leIsAbnormal;
            colBC_Summary.FieldName = "NormalTXT";
            colBC_Summary.Name = "colBC_Summary";
            colBC_Summary.Visible = true;
            colBC_Summary.VisibleIndex = 4;
            colBC_Summary.Width = 330;
            // 
            // colBC_ItemCode
            // 
            colBC_ItemCode.FieldName = "ResultItemCode";
            colBC_ItemCode.Name = "colBC_ItemCode";
            colBC_ItemCode.OptionsColumn.AllowEdit = false;
            // 
            // colBC_GroupName
            // 
            colBC_GroupName.Caption = "CheckupGroupName";
            colBC_GroupName.FieldName = "CheckupGroupName";
            colBC_GroupName.FieldNameSortGroup = "DisplayOrderGroup";
            colBC_GroupName.Name = "colBC_GroupName";
            colBC_GroupName.Visible = true;
            colBC_GroupName.VisibleIndex = 5;
            // 
            // colBC_UID
            // 
            colBC_UID.Caption = "UID";
            colBC_UID.FieldName = "UID";
            colBC_UID.Name = "colBC_UID";
            // 
            // pnStool2
            // 
            pnStool2.Controls.Add(txtST_DoctorRecommend);
            pnStool2.Controls.Add(ddlST_Summary);
            pnStool2.Controls.Add(label17);
            pnStool2.Controls.Add(label18);
            pnStool2.Dock = DockStyle.Top;
            pnStool2.Font = new Font("Segoe UI", 9F);
            pnStool2.Location = new Point(0, 460);
            pnStool2.Name = "pnStool2";
            pnStool2.Size = new Size(1486, 54);
            pnStool2.TabIndex = 11;
            // 
            // txtST_DoctorRecommend
            // 
            txtST_DoctorRecommend.Font = new Font("Segoe UI", 10F);
            txtST_DoctorRecommend.Location = new Point(195, 22);
            txtST_DoctorRecommend.Name = "txtST_DoctorRecommend";
            txtST_DoctorRecommend.Size = new Size(497, 25);
            txtST_DoctorRecommend.TabIndex = 37;
            txtST_DoctorRecommend.Text = "ผลการตรวจอุจจาระอยู่ในเกณฑ์ปกติ";
            // 
            // ddlST_Summary
            // 
            ddlST_Summary.EditValue = "";
            ddlST_Summary.Location = new Point(9, 22);
            ddlST_Summary.Name = "ddlST_Summary";
            ddlST_Summary.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlST_Summary.Properties.Appearance.Options.UseFont = true;
            ddlST_Summary.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlST_Summary.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlST_Summary.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlST_Summary.Properties.NullText = "";
            ddlST_Summary.Size = new Size(180, 24);
            ddlST_Summary.TabIndex = 9;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10F);
            label17.Location = new Point(191, 3);
            label17.Name = "label17";
            label17.Size = new Size(152, 19);
            label17.TabIndex = 1;
            label17.Text = "แสดงแปลผลในใบรายงานผล";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10F);
            label18.Location = new Point(6, 3);
            label18.Name = "label18";
            label18.Size = new Size(172, 19);
            label18.TabIndex = 0;
            label18.Text = "ผลการตรวจจากความเห็นแพทย์";
            // 
            // pnStool
            // 
            pnStool.AutoScroll = true;
            pnStool.Controls.Add(gridStool);
            pnStool.Dock = DockStyle.Top;
            pnStool.Location = new Point(0, 0);
            pnStool.Name = "pnStool";
            pnStool.Size = new Size(1486, 460);
            pnStool.TabIndex = 10;
            // 
            // gridStool
            // 
            gridStool.Location = new Point(0, 0);
            gridStool.LookAndFeel.SkinName = "Office 2010 Blue";
            gridStool.LookAndFeel.UseDefaultLookAndFeel = false;
            gridStool.MainView = gridViewStool;
            gridStool.Name = "gridStool";
            gridStool.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemMemoEdit5, repositoryItemCheckEdit9, repositoryItemCheckEdit10 });
            gridStool.Size = new Size(1318, 460);
            gridStool.TabIndex = 7;
            gridStool.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewStool });
            // 
            // gridViewStool
            // 
            gridViewStool.Appearance.GroupRow.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gridViewStool.Appearance.GroupRow.Options.UseFont = true;
            gridViewStool.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridViewStool.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewStool.Appearance.Row.Font = new Font("Segoe UI", 10F);
            gridViewStool.Appearance.Row.Options.UseFont = true;
            gridViewStool.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            gridViewStool.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn22, gridColumn23, gridColumn24, gridColumn25, gridColumn26, gridColumn27, gridColumn28, gridColumn29 });
            gridViewStool.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridViewStool.GridControl = gridStool;
            gridViewStool.GroupFormat = "{0} [#image]{1} {2}";
            gridViewStool.Name = "gridViewStool";
            gridViewStool.OptionsBehavior.AutoExpandAllGroups = true;
            gridViewStool.OptionsBehavior.Editable = false;
            gridViewStool.OptionsDetail.EnableMasterViewMode = false;
            gridViewStool.OptionsSelection.InvertSelection = true;
            gridViewStool.OptionsView.ColumnAutoWidth = false;
            gridViewStool.OptionsView.RowAutoHeight = true;
            gridViewStool.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            gridViewStool.OptionsView.ShowGroupExpandCollapseButtons = false;
            gridViewStool.OptionsView.ShowGroupPanel = false;
            gridViewStool.OptionsView.ShowIndicator = false;
            gridViewStool.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            gridViewStool.RowStyle += gridViewStool_RowStyle;
            // 
            // gridColumn22
            // 
            gridColumn22.Caption = "Test";
            gridColumn22.FieldName = "ResultItemName";
            gridColumn22.Name = "gridColumn22";
            gridColumn22.Visible = true;
            gridColumn22.VisibleIndex = 0;
            gridColumn22.Width = 240;
            // 
            // gridColumn23
            // 
            gridColumn23.AppearanceCell.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gridColumn23.AppearanceCell.Options.UseFont = true;
            gridColumn23.AppearanceCell.Options.UseTextOptions = true;
            gridColumn23.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn23.Caption = "Result";
            gridColumn23.ColumnEdit = repositoryItemMemoEdit5;
            gridColumn23.FieldName = "ResultValue";
            gridColumn23.Name = "gridColumn23";
            gridColumn23.Visible = true;
            gridColumn23.VisibleIndex = 1;
            gridColumn23.Width = 120;
            // 
            // repositoryItemMemoEdit5
            // 
            repositoryItemMemoEdit5.Name = "repositoryItemMemoEdit5";
            // 
            // gridColumn24
            // 
            gridColumn24.AppearanceCell.Options.UseTextOptions = true;
            gridColumn24.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn24.Caption = "UOM";
            gridColumn24.FieldName = "UnitOfMeasure";
            gridColumn24.Name = "gridColumn24";
            gridColumn24.Visible = true;
            gridColumn24.VisibleIndex = 2;
            gridColumn24.Width = 120;
            // 
            // gridColumn25
            // 
            gridColumn25.AppearanceCell.Options.UseTextOptions = true;
            gridColumn25.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn25.Caption = "Reference";
            gridColumn25.FieldName = "ReferenceRange";
            gridColumn25.Name = "gridColumn25";
            gridColumn25.Visible = true;
            gridColumn25.VisibleIndex = 3;
            gridColumn25.Width = 100;
            // 
            // gridColumn26
            // 
            gridColumn26.ColumnEdit = repositoryItemCheckEdit9;
            gridColumn26.FieldName = "IsAbnormal";
            gridColumn26.Name = "gridColumn26";
            gridColumn26.OptionsColumn.ShowCaption = false;
            gridColumn26.Visible = true;
            gridColumn26.VisibleIndex = 4;
            gridColumn26.Width = 20;
            // 
            // repositoryItemCheckEdit9
            // 
            repositoryItemCheckEdit9.AutoHeight = false;
            repositoryItemCheckEdit9.AutoWidth = true;
            repositoryItemCheckEdit9.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            repositoryItemCheckEdit9.ImageOptions.ImageChecked = (Image)resources.GetObject("repositoryItemCheckEdit9.ImageOptions.ImageChecked");
            repositoryItemCheckEdit9.ImageOptions.ImageGrayed = (Image)resources.GetObject("repositoryItemCheckEdit9.ImageOptions.ImageGrayed");
            repositoryItemCheckEdit9.ImageOptions.ImageUnchecked = (Image)resources.GetObject("repositoryItemCheckEdit9.ImageOptions.ImageUnchecked");
            repositoryItemCheckEdit9.Name = "repositoryItemCheckEdit9";
            repositoryItemCheckEdit9.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            repositoryItemCheckEdit9.ValueChecked = "H";
            repositoryItemCheckEdit9.ValueGrayed = "N";
            repositoryItemCheckEdit9.ValueUnchecked = "L";
            // 
            // gridColumn27
            // 
            gridColumn27.ColumnEdit = repositoryItemCheckEdit10;
            gridColumn27.FieldName = "IsAbnormal";
            gridColumn27.Name = "gridColumn27";
            gridColumn27.OptionsColumn.ShowCaption = false;
            gridColumn27.Visible = true;
            gridColumn27.VisibleIndex = 5;
            gridColumn27.Width = 20;
            // 
            // repositoryItemCheckEdit10
            // 
            repositoryItemCheckEdit10.AutoHeight = false;
            repositoryItemCheckEdit10.AutoWidth = true;
            repositoryItemCheckEdit10.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            repositoryItemCheckEdit10.ImageOptions.ImageChecked = (Image)resources.GetObject("repositoryItemCheckEdit10.ImageOptions.ImageChecked");
            repositoryItemCheckEdit10.ImageOptions.ImageGrayed = (Image)resources.GetObject("repositoryItemCheckEdit10.ImageOptions.ImageGrayed");
            repositoryItemCheckEdit10.ImageOptions.ImageUnchecked = (Image)resources.GetObject("repositoryItemCheckEdit10.ImageOptions.ImageUnchecked");
            repositoryItemCheckEdit10.Name = "repositoryItemCheckEdit10";
            repositoryItemCheckEdit10.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            repositoryItemCheckEdit10.ValueChecked = "HH";
            repositoryItemCheckEdit10.ValueGrayed = "N";
            repositoryItemCheckEdit10.ValueUnchecked = "LL";
            // 
            // gridColumn28
            // 
            gridColumn28.Caption = "PrintOrder";
            gridColumn28.FieldName = "PrintOrder";
            gridColumn28.Name = "gridColumn28";
            gridColumn28.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            // 
            // gridColumn29
            // 
            gridColumn29.Caption = "Comment";
            gridColumn29.FieldName = "Comment";
            gridColumn29.Name = "gridColumn29";
            gridColumn29.Visible = true;
            gridColumn29.VisibleIndex = 6;
            gridColumn29.Width = 170;
            // 
            // pnStoolCulture
            // 
            pnStoolCulture.AutoScroll = true;
            pnStoolCulture.Controls.Add(gridStoolCulture);
            pnStoolCulture.Dock = DockStyle.Fill;
            pnStoolCulture.Location = new Point(0, 0);
            pnStoolCulture.Name = "pnStoolCulture";
            pnStoolCulture.Size = new Size(1486, 553);
            pnStoolCulture.TabIndex = 0;
            // 
            // gridStoolCulture
            // 
            gridStoolCulture.Location = new Point(0, 0);
            gridStoolCulture.LookAndFeel.SkinName = "Office 2010 Blue";
            gridStoolCulture.LookAndFeel.UseDefaultLookAndFeel = false;
            gridStoolCulture.MainView = gridViewStoolCulture;
            gridStoolCulture.Name = "gridStoolCulture";
            gridStoolCulture.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemMemoEdit6, repositoryItemCheckEdit11, repositoryItemCheckEdit12 });
            gridStoolCulture.Size = new Size(1405, 559);
            gridStoolCulture.TabIndex = 7;
            gridStoolCulture.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewStoolCulture });
            // 
            // gridViewStoolCulture
            // 
            gridViewStoolCulture.Appearance.GroupRow.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gridViewStoolCulture.Appearance.GroupRow.Options.UseFont = true;
            gridViewStoolCulture.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridViewStoolCulture.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewStoolCulture.Appearance.Row.Font = new Font("Segoe UI", 10F);
            gridViewStoolCulture.Appearance.Row.Options.UseFont = true;
            gridViewStoolCulture.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            gridViewStoolCulture.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn30, gridColumn31, gridColumn32, gridColumn33, gridColumn34, gridColumn35, gridColumn36, gridColumn37 });
            gridViewStoolCulture.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridViewStoolCulture.GridControl = gridStoolCulture;
            gridViewStoolCulture.GroupFormat = "{0} [#image]{1} {2}";
            gridViewStoolCulture.Name = "gridViewStoolCulture";
            gridViewStoolCulture.OptionsBehavior.AutoExpandAllGroups = true;
            gridViewStoolCulture.OptionsBehavior.Editable = false;
            gridViewStoolCulture.OptionsDetail.EnableMasterViewMode = false;
            gridViewStoolCulture.OptionsSelection.InvertSelection = true;
            gridViewStoolCulture.OptionsView.ColumnAutoWidth = false;
            gridViewStoolCulture.OptionsView.RowAutoHeight = true;
            gridViewStoolCulture.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            gridViewStoolCulture.OptionsView.ShowGroupExpandCollapseButtons = false;
            gridViewStoolCulture.OptionsView.ShowGroupPanel = false;
            gridViewStoolCulture.OptionsView.ShowIndicator = false;
            gridViewStoolCulture.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            gridViewStoolCulture.RowStyle += gridViewStoolCulture_RowStyle;
            // 
            // gridColumn30
            // 
            gridColumn30.Caption = "Test";
            gridColumn30.FieldName = "ResultItemName";
            gridColumn30.Name = "gridColumn30";
            gridColumn30.Visible = true;
            gridColumn30.VisibleIndex = 0;
            gridColumn30.Width = 240;
            // 
            // gridColumn31
            // 
            gridColumn31.AppearanceCell.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gridColumn31.AppearanceCell.Options.UseFont = true;
            gridColumn31.AppearanceCell.Options.UseTextOptions = true;
            gridColumn31.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn31.Caption = "Result";
            gridColumn31.ColumnEdit = repositoryItemMemoEdit6;
            gridColumn31.FieldName = "ResultValue";
            gridColumn31.Name = "gridColumn31";
            gridColumn31.Visible = true;
            gridColumn31.VisibleIndex = 1;
            gridColumn31.Width = 120;
            // 
            // repositoryItemMemoEdit6
            // 
            repositoryItemMemoEdit6.Name = "repositoryItemMemoEdit6";
            // 
            // gridColumn32
            // 
            gridColumn32.AppearanceCell.Options.UseTextOptions = true;
            gridColumn32.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn32.Caption = "UOM";
            gridColumn32.FieldName = "UnitOfMeasure";
            gridColumn32.Name = "gridColumn32";
            gridColumn32.Visible = true;
            gridColumn32.VisibleIndex = 2;
            gridColumn32.Width = 120;
            // 
            // gridColumn33
            // 
            gridColumn33.AppearanceCell.Options.UseTextOptions = true;
            gridColumn33.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn33.Caption = "Reference";
            gridColumn33.FieldName = "ReferenceRange";
            gridColumn33.Name = "gridColumn33";
            gridColumn33.Visible = true;
            gridColumn33.VisibleIndex = 3;
            gridColumn33.Width = 100;
            // 
            // gridColumn34
            // 
            gridColumn34.ColumnEdit = repositoryItemCheckEdit11;
            gridColumn34.FieldName = "IsAbnormal";
            gridColumn34.Name = "gridColumn34";
            gridColumn34.OptionsColumn.ShowCaption = false;
            gridColumn34.Visible = true;
            gridColumn34.VisibleIndex = 4;
            gridColumn34.Width = 20;
            // 
            // repositoryItemCheckEdit11
            // 
            repositoryItemCheckEdit11.AutoHeight = false;
            repositoryItemCheckEdit11.AutoWidth = true;
            repositoryItemCheckEdit11.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            repositoryItemCheckEdit11.ImageOptions.ImageChecked = (Image)resources.GetObject("repositoryItemCheckEdit11.ImageOptions.ImageChecked");
            repositoryItemCheckEdit11.ImageOptions.ImageGrayed = (Image)resources.GetObject("repositoryItemCheckEdit11.ImageOptions.ImageGrayed");
            repositoryItemCheckEdit11.ImageOptions.ImageUnchecked = (Image)resources.GetObject("repositoryItemCheckEdit11.ImageOptions.ImageUnchecked");
            repositoryItemCheckEdit11.Name = "repositoryItemCheckEdit11";
            repositoryItemCheckEdit11.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            repositoryItemCheckEdit11.ValueChecked = "H";
            repositoryItemCheckEdit11.ValueGrayed = "N";
            repositoryItemCheckEdit11.ValueUnchecked = "L";
            // 
            // gridColumn35
            // 
            gridColumn35.ColumnEdit = repositoryItemCheckEdit12;
            gridColumn35.FieldName = "IsAbnormal";
            gridColumn35.Name = "gridColumn35";
            gridColumn35.OptionsColumn.ShowCaption = false;
            gridColumn35.Visible = true;
            gridColumn35.VisibleIndex = 5;
            gridColumn35.Width = 20;
            // 
            // repositoryItemCheckEdit12
            // 
            repositoryItemCheckEdit12.AutoHeight = false;
            repositoryItemCheckEdit12.AutoWidth = true;
            repositoryItemCheckEdit12.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            repositoryItemCheckEdit12.ImageOptions.ImageChecked = (Image)resources.GetObject("repositoryItemCheckEdit12.ImageOptions.ImageChecked");
            repositoryItemCheckEdit12.ImageOptions.ImageGrayed = (Image)resources.GetObject("repositoryItemCheckEdit12.ImageOptions.ImageGrayed");
            repositoryItemCheckEdit12.ImageOptions.ImageUnchecked = (Image)resources.GetObject("repositoryItemCheckEdit12.ImageOptions.ImageUnchecked");
            repositoryItemCheckEdit12.Name = "repositoryItemCheckEdit12";
            repositoryItemCheckEdit12.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            repositoryItemCheckEdit12.ValueChecked = "HH";
            repositoryItemCheckEdit12.ValueGrayed = "N";
            repositoryItemCheckEdit12.ValueUnchecked = "LL";
            // 
            // gridColumn36
            // 
            gridColumn36.Caption = "PrintOrder";
            gridColumn36.FieldName = "PrintOrder";
            gridColumn36.Name = "gridColumn36";
            gridColumn36.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            // 
            // gridColumn37
            // 
            gridColumn37.Caption = "Comment";
            gridColumn37.FieldName = "Comment";
            gridColumn37.Name = "gridColumn37";
            gridColumn37.Visible = true;
            gridColumn37.VisibleIndex = 6;
            gridColumn37.Width = 170;
            // 
            // panel10
            // 
            panel10.Controls.Add(txtUA_DoctorRecommend);
            panel10.Controls.Add(ddlUA_Summary);
            panel10.Controls.Add(label14);
            panel10.Controls.Add(label13);
            panel10.Dock = DockStyle.Top;
            panel10.Font = new Font("Segoe UI", 10F);
            panel10.Location = new Point(0, 460);
            panel10.Name = "panel10";
            panel10.Size = new Size(1486, 61);
            panel10.TabIndex = 7;
            // 
            // txtUA_DoctorRecommend
            // 
            txtUA_DoctorRecommend.Location = new Point(195, 22);
            txtUA_DoctorRecommend.Name = "txtUA_DoctorRecommend";
            txtUA_DoctorRecommend.Size = new Size(497, 25);
            txtUA_DoctorRecommend.TabIndex = 38;
            txtUA_DoctorRecommend.Text = "ผลการตรวจปัสสาวะอยู่ในเกณฑ์ปกติ";
            // 
            // ddlUA_Summary
            // 
            ddlUA_Summary.EditValue = "";
            ddlUA_Summary.Location = new Point(9, 22);
            ddlUA_Summary.Name = "ddlUA_Summary";
            ddlUA_Summary.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlUA_Summary.Properties.Appearance.Options.UseFont = true;
            ddlUA_Summary.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlUA_Summary.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlUA_Summary.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlUA_Summary.Properties.NullText = "";
            ddlUA_Summary.Size = new Size(180, 24);
            ddlUA_Summary.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(191, 3);
            label14.Name = "label14";
            label14.Size = new Size(152, 19);
            label14.TabIndex = 1;
            label14.Text = "แสดงแปลผลในใบรายงานผล";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 3);
            label13.Name = "label13";
            label13.Size = new Size(172, 19);
            label13.TabIndex = 0;
            label13.Text = "ผลการตรวจจากความเห็นแพทย์";
            // 
            // pnUA
            // 
            pnUA.AutoScroll = true;
            pnUA.Controls.Add(gridUrine);
            pnUA.Dock = DockStyle.Top;
            pnUA.Location = new Point(0, 0);
            pnUA.Name = "pnUA";
            pnUA.Size = new Size(1486, 460);
            pnUA.TabIndex = 6;
            // 
            // gridUrine
            // 
            gridUrine.Location = new Point(0, 0);
            gridUrine.LookAndFeel.SkinName = "Office 2010 Blue";
            gridUrine.LookAndFeel.UseDefaultLookAndFeel = false;
            gridUrine.MainView = gridViewUrine;
            gridUrine.Name = "gridUrine";
            gridUrine.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemMemoEdit7, repositoryItemCheckEdit13, repositoryItemCheckEdit14 });
            gridUrine.Size = new Size(1339, 460);
            gridUrine.TabIndex = 7;
            gridUrine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewUrine });
            // 
            // gridViewUrine
            // 
            gridViewUrine.Appearance.GroupRow.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gridViewUrine.Appearance.GroupRow.Options.UseFont = true;
            gridViewUrine.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridViewUrine.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewUrine.Appearance.Row.Font = new Font("Segoe UI", 10F);
            gridViewUrine.Appearance.Row.Options.UseFont = true;
            gridViewUrine.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            gridViewUrine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn47, gridColumn48, gridColumn49, gridColumn50, gridColumn51, gridColumn52, gridColumn53, gridColumn54 });
            gridViewUrine.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridViewUrine.GridControl = gridUrine;
            gridViewUrine.GroupFormat = "{0} [#image]{1} {2}";
            gridViewUrine.Name = "gridViewUrine";
            gridViewUrine.OptionsBehavior.AutoExpandAllGroups = true;
            gridViewUrine.OptionsBehavior.Editable = false;
            gridViewUrine.OptionsDetail.EnableMasterViewMode = false;
            gridViewUrine.OptionsSelection.InvertSelection = true;
            gridViewUrine.OptionsView.ColumnAutoWidth = false;
            gridViewUrine.OptionsView.RowAutoHeight = true;
            gridViewUrine.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            gridViewUrine.OptionsView.ShowGroupExpandCollapseButtons = false;
            gridViewUrine.OptionsView.ShowGroupPanel = false;
            gridViewUrine.OptionsView.ShowIndicator = false;
            gridViewUrine.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            gridViewUrine.RowStyle += gridViewUrine_RowStyle;
            // 
            // gridColumn47
            // 
            gridColumn47.Caption = "Test";
            gridColumn47.FieldName = "ResultItemName";
            gridColumn47.Name = "gridColumn47";
            gridColumn47.Visible = true;
            gridColumn47.VisibleIndex = 0;
            gridColumn47.Width = 240;
            // 
            // gridColumn48
            // 
            gridColumn48.AppearanceCell.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gridColumn48.AppearanceCell.Options.UseFont = true;
            gridColumn48.AppearanceCell.Options.UseTextOptions = true;
            gridColumn48.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn48.Caption = "Result";
            gridColumn48.ColumnEdit = repositoryItemMemoEdit7;
            gridColumn48.FieldName = "ResultValue";
            gridColumn48.Name = "gridColumn48";
            gridColumn48.Visible = true;
            gridColumn48.VisibleIndex = 1;
            gridColumn48.Width = 120;
            // 
            // repositoryItemMemoEdit7
            // 
            repositoryItemMemoEdit7.Name = "repositoryItemMemoEdit7";
            // 
            // gridColumn49
            // 
            gridColumn49.AppearanceCell.Options.UseTextOptions = true;
            gridColumn49.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn49.Caption = "UOM";
            gridColumn49.FieldName = "UnitOfMeasure";
            gridColumn49.Name = "gridColumn49";
            gridColumn49.Visible = true;
            gridColumn49.VisibleIndex = 2;
            gridColumn49.Width = 120;
            // 
            // gridColumn50
            // 
            gridColumn50.AppearanceCell.Options.UseTextOptions = true;
            gridColumn50.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn50.Caption = "Reference";
            gridColumn50.FieldName = "ReferenceRange";
            gridColumn50.Name = "gridColumn50";
            gridColumn50.Visible = true;
            gridColumn50.VisibleIndex = 3;
            gridColumn50.Width = 100;
            // 
            // gridColumn51
            // 
            gridColumn51.ColumnEdit = repositoryItemCheckEdit13;
            gridColumn51.FieldName = "IsAbnormal";
            gridColumn51.Name = "gridColumn51";
            gridColumn51.OptionsColumn.ShowCaption = false;
            gridColumn51.Visible = true;
            gridColumn51.VisibleIndex = 4;
            gridColumn51.Width = 20;
            // 
            // repositoryItemCheckEdit13
            // 
            repositoryItemCheckEdit13.AutoHeight = false;
            repositoryItemCheckEdit13.AutoWidth = true;
            repositoryItemCheckEdit13.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            repositoryItemCheckEdit13.ImageOptions.ImageChecked = (Image)resources.GetObject("repositoryItemCheckEdit13.ImageOptions.ImageChecked");
            repositoryItemCheckEdit13.ImageOptions.ImageGrayed = (Image)resources.GetObject("repositoryItemCheckEdit13.ImageOptions.ImageGrayed");
            repositoryItemCheckEdit13.ImageOptions.ImageUnchecked = (Image)resources.GetObject("repositoryItemCheckEdit13.ImageOptions.ImageUnchecked");
            repositoryItemCheckEdit13.Name = "repositoryItemCheckEdit13";
            repositoryItemCheckEdit13.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            repositoryItemCheckEdit13.ValueChecked = "H";
            repositoryItemCheckEdit13.ValueGrayed = "N";
            repositoryItemCheckEdit13.ValueUnchecked = "L";
            // 
            // gridColumn52
            // 
            gridColumn52.ColumnEdit = repositoryItemCheckEdit14;
            gridColumn52.FieldName = "IsAbnormal";
            gridColumn52.Name = "gridColumn52";
            gridColumn52.OptionsColumn.ShowCaption = false;
            gridColumn52.Visible = true;
            gridColumn52.VisibleIndex = 5;
            gridColumn52.Width = 20;
            // 
            // repositoryItemCheckEdit14
            // 
            repositoryItemCheckEdit14.AutoHeight = false;
            repositoryItemCheckEdit14.AutoWidth = true;
            repositoryItemCheckEdit14.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            repositoryItemCheckEdit14.ImageOptions.ImageChecked = (Image)resources.GetObject("repositoryItemCheckEdit14.ImageOptions.ImageChecked");
            repositoryItemCheckEdit14.ImageOptions.ImageGrayed = (Image)resources.GetObject("repositoryItemCheckEdit14.ImageOptions.ImageGrayed");
            repositoryItemCheckEdit14.ImageOptions.ImageUnchecked = (Image)resources.GetObject("repositoryItemCheckEdit14.ImageOptions.ImageUnchecked");
            repositoryItemCheckEdit14.Name = "repositoryItemCheckEdit14";
            repositoryItemCheckEdit14.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            repositoryItemCheckEdit14.ValueChecked = "HH";
            repositoryItemCheckEdit14.ValueGrayed = "N";
            repositoryItemCheckEdit14.ValueUnchecked = "LL";
            // 
            // gridColumn53
            // 
            gridColumn53.Caption = "PrintOrder";
            gridColumn53.FieldName = "PrintOrder";
            gridColumn53.Name = "gridColumn53";
            gridColumn53.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            // 
            // gridColumn54
            // 
            gridColumn54.Caption = "Comment";
            gridColumn54.FieldName = "Comment";
            gridColumn54.Name = "gridColumn54";
            gridColumn54.Visible = true;
            gridColumn54.VisibleIndex = 6;
            gridColumn54.Width = 170;
            // 
            // pnCBC2
            // 
            pnCBC2.Controls.Add(txtCBC_DoctorRecommend);
            pnCBC2.Controls.Add(ddlCBC_Summary);
            pnCBC2.Controls.Add(label15);
            pnCBC2.Controls.Add(label16);
            pnCBC2.Dock = DockStyle.Top;
            pnCBC2.Font = new Font("Segoe UI", 10F);
            pnCBC2.Location = new Point(0, 460);
            pnCBC2.Name = "pnCBC2";
            pnCBC2.Size = new Size(1486, 296);
            pnCBC2.TabIndex = 9;
            // 
            // txtCBC_DoctorRecommend
            // 
            txtCBC_DoctorRecommend.Location = new Point(195, 22);
            txtCBC_DoctorRecommend.Name = "txtCBC_DoctorRecommend";
            txtCBC_DoctorRecommend.Size = new Size(497, 25);
            txtCBC_DoctorRecommend.TabIndex = 37;
            txtCBC_DoctorRecommend.Text = "ความสมบูรณ์ของเม็ดเลือดอยู่ในเกณฑ์ปกติ";
            // 
            // ddlCBC_Summary
            // 
            ddlCBC_Summary.EditValue = "";
            ddlCBC_Summary.Location = new Point(9, 22);
            ddlCBC_Summary.Name = "ddlCBC_Summary";
            ddlCBC_Summary.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlCBC_Summary.Properties.Appearance.Options.UseFont = true;
            ddlCBC_Summary.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlCBC_Summary.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlCBC_Summary.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlCBC_Summary.Properties.NullText = "";
            ddlCBC_Summary.Size = new Size(180, 24);
            ddlCBC_Summary.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(191, 3);
            label15.Name = "label15";
            label15.Size = new Size(152, 19);
            label15.TabIndex = 1;
            label15.Text = "แสดงแปลผลในใบรายงานผล";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 3);
            label16.Name = "label16";
            label16.Size = new Size(172, 19);
            label16.TabIndex = 0;
            label16.Text = "ผลการตรวจจากความเห็นแพทย์";
            // 
            // pnCBC
            // 
            pnCBC.AutoScroll = true;
            pnCBC.Controls.Add(grdCBC);
            pnCBC.Dock = DockStyle.Top;
            pnCBC.Location = new Point(0, 0);
            pnCBC.Name = "pnCBC";
            pnCBC.Size = new Size(1486, 460);
            pnCBC.TabIndex = 8;
            // 
            // grdCBC
            // 
            grdCBC.Location = new Point(0, 0);
            grdCBC.LookAndFeel.SkinName = "Office 2010 Blue";
            grdCBC.LookAndFeel.UseDefaultLookAndFeel = false;
            grdCBC.MainView = gridViewCBC;
            grdCBC.Name = "grdCBC";
            grdCBC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemMemoEdit3, repositoryItemCheckEdit5, repositoryItemCheckEdit6 });
            grdCBC.Size = new Size(1033, 460);
            grdCBC.TabIndex = 6;
            grdCBC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewCBC });
            // 
            // gridViewCBC
            // 
            gridViewCBC.Appearance.GroupRow.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gridViewCBC.Appearance.GroupRow.Options.UseFont = true;
            gridViewCBC.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridViewCBC.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewCBC.Appearance.Row.Font = new Font("Segoe UI", 10F);
            gridViewCBC.Appearance.Row.Options.UseFont = true;
            gridViewCBC.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            gridViewCBC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn3, gridColumn4, gridColumn5, gridColumn6, gridColumn7, gridColumn8, gridColumn11, gridColumn10 });
            gridViewCBC.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridViewCBC.GridControl = grdCBC;
            gridViewCBC.GroupFormat = "{0} [#image]{1} {2}";
            gridViewCBC.Name = "gridViewCBC";
            gridViewCBC.OptionsBehavior.AutoExpandAllGroups = true;
            gridViewCBC.OptionsBehavior.Editable = false;
            gridViewCBC.OptionsDetail.EnableMasterViewMode = false;
            gridViewCBC.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridViewCBC.OptionsSelection.InvertSelection = true;
            gridViewCBC.OptionsView.ColumnAutoWidth = false;
            gridViewCBC.OptionsView.EnableAppearanceOddRow = true;
            gridViewCBC.OptionsView.RowAutoHeight = true;
            gridViewCBC.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            gridViewCBC.OptionsView.ShowGroupExpandCollapseButtons = false;
            gridViewCBC.OptionsView.ShowGroupPanel = false;
            gridViewCBC.OptionsView.ShowIndicator = false;
            gridViewCBC.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            gridViewCBC.RowStyle += grdViewCBC_RowStyle;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "Test";
            gridColumn3.FieldName = "ResultItemName";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 0;
            gridColumn3.Width = 240;
            // 
            // gridColumn4
            // 
            gridColumn4.AppearanceCell.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gridColumn4.AppearanceCell.Options.UseFont = true;
            gridColumn4.AppearanceCell.Options.UseTextOptions = true;
            gridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn4.Caption = "Result";
            gridColumn4.ColumnEdit = repositoryItemMemoEdit3;
            gridColumn4.FieldName = "ResultValue";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 1;
            gridColumn4.Width = 120;
            // 
            // repositoryItemMemoEdit3
            // 
            repositoryItemMemoEdit3.Name = "repositoryItemMemoEdit3";
            // 
            // gridColumn5
            // 
            gridColumn5.AppearanceCell.Options.UseTextOptions = true;
            gridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn5.Caption = "UOM";
            gridColumn5.FieldName = "UnitOfMeasure";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 2;
            gridColumn5.Width = 120;
            // 
            // gridColumn6
            // 
            gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn6.Caption = "Reference";
            gridColumn6.FieldName = "ReferenceRange";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 3;
            gridColumn6.Width = 100;
            // 
            // gridColumn7
            // 
            gridColumn7.ColumnEdit = repositoryItemCheckEdit5;
            gridColumn7.FieldName = "IsAbnormal";
            gridColumn7.Name = "gridColumn7";
            gridColumn7.OptionsColumn.ShowCaption = false;
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 4;
            gridColumn7.Width = 20;
            // 
            // repositoryItemCheckEdit5
            // 
            repositoryItemCheckEdit5.AutoHeight = false;
            repositoryItemCheckEdit5.AutoWidth = true;
            repositoryItemCheckEdit5.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            repositoryItemCheckEdit5.ImageOptions.ImageChecked = (Image)resources.GetObject("repositoryItemCheckEdit5.ImageOptions.ImageChecked");
            repositoryItemCheckEdit5.ImageOptions.ImageGrayed = (Image)resources.GetObject("repositoryItemCheckEdit5.ImageOptions.ImageGrayed");
            repositoryItemCheckEdit5.ImageOptions.ImageUnchecked = (Image)resources.GetObject("repositoryItemCheckEdit5.ImageOptions.ImageUnchecked");
            repositoryItemCheckEdit5.Name = "repositoryItemCheckEdit5";
            repositoryItemCheckEdit5.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            repositoryItemCheckEdit5.ValueChecked = "H";
            repositoryItemCheckEdit5.ValueGrayed = "N";
            repositoryItemCheckEdit5.ValueUnchecked = "L";
            // 
            // gridColumn8
            // 
            gridColumn8.ColumnEdit = repositoryItemCheckEdit6;
            gridColumn8.FieldName = "IsAbnormal";
            gridColumn8.Name = "gridColumn8";
            gridColumn8.OptionsColumn.ShowCaption = false;
            gridColumn8.Visible = true;
            gridColumn8.VisibleIndex = 5;
            gridColumn8.Width = 20;
            // 
            // repositoryItemCheckEdit6
            // 
            repositoryItemCheckEdit6.AutoHeight = false;
            repositoryItemCheckEdit6.AutoWidth = true;
            repositoryItemCheckEdit6.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            repositoryItemCheckEdit6.ImageOptions.ImageChecked = (Image)resources.GetObject("repositoryItemCheckEdit6.ImageOptions.ImageChecked");
            repositoryItemCheckEdit6.ImageOptions.ImageGrayed = (Image)resources.GetObject("repositoryItemCheckEdit6.ImageOptions.ImageGrayed");
            repositoryItemCheckEdit6.ImageOptions.ImageUnchecked = (Image)resources.GetObject("repositoryItemCheckEdit6.ImageOptions.ImageUnchecked");
            repositoryItemCheckEdit6.Name = "repositoryItemCheckEdit6";
            repositoryItemCheckEdit6.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            repositoryItemCheckEdit6.ValueChecked = "HH";
            repositoryItemCheckEdit6.ValueGrayed = "N";
            repositoryItemCheckEdit6.ValueUnchecked = "LL";
            // 
            // gridColumn11
            // 
            gridColumn11.Caption = "Comment";
            gridColumn11.FieldName = "Comment";
            gridColumn11.Name = "gridColumn11";
            gridColumn11.Visible = true;
            gridColumn11.VisibleIndex = 6;
            gridColumn11.Width = 170;
            // 
            // gridColumn10
            // 
            gridColumn10.Caption = "PrintOrder";
            gridColumn10.FieldName = "PrintOrder";
            gridColumn10.Name = "gridColumn10";
            gridColumn10.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            // 
            // pnXray
            // 
            pnXray.AutoScroll = true;
            pnXray.Controls.Add(btnPAC_USBreast);
            pnXray.Controls.Add(btnX_USBreast);
            pnXray.Controls.Add(txtX_USBreast);
            pnXray.Controls.Add(ddlX_USBreast);
            pnXray.Controls.Add(lblUsBreast);
            pnXray.Controls.Add(btnPAC_Lower);
            pnXray.Controls.Add(btnPAC_Mammo);
            pnXray.Controls.Add(btnPAC_Upper);
            pnXray.Controls.Add(btnPAC_Echo);
            pnXray.Controls.Add(btnPAC_Abdomen);
            pnXray.Controls.Add(btnPAC_PA);
            pnXray.Controls.Add(btnX_Lower);
            pnXray.Controls.Add(btnX_Mammo);
            pnXray.Controls.Add(btnX_Upper);
            pnXray.Controls.Add(btnX_Abdomen);
            pnXray.Controls.Add(btnX_Echo);
            pnXray.Controls.Add(btnX_PA);
            pnXray.Controls.Add(txtX_LowerAbdomenRemark);
            pnXray.Controls.Add(ddlX_LowerAbdomen);
            pnXray.Controls.Add(lblLowerAbdomen);
            pnXray.Controls.Add(txtX_Mammogram);
            pnXray.Controls.Add(ddlX_Mammogram);
            pnXray.Controls.Add(txtX_EchoRemark);
            pnXray.Controls.Add(ddlX_Echo);
            pnXray.Controls.Add(txtX_UpperAbdomenRemark);
            pnXray.Controls.Add(txtX_ChestPA);
            pnXray.Controls.Add(ddlX_UpperAbdomen);
            pnXray.Controls.Add(ddlX_ChestPA);
            pnXray.Controls.Add(txtX_AbdomenRemark);
            pnXray.Controls.Add(ddlX_Abdomen);
            pnXray.Controls.Add(lblAbdomen);
            pnXray.Controls.Add(lblChestPA);
            pnXray.Controls.Add(lblUpperAbdomen);
            pnXray.Controls.Add(lblHeart);
            pnXray.Controls.Add(lblMammogram);
            pnXray.Dock = DockStyle.Fill;
            pnXray.Font = new Font("Segoe UI", 10F);
            pnXray.Location = new Point(0, 0);
            pnXray.Name = "pnXray";
            pnXray.Size = new Size(1486, 553);
            pnXray.TabIndex = 0;
            // 
            // btnPAC_USBreast
            // 
            btnPAC_USBreast.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnPAC_USBreast.Cursor = Cursors.Hand;
            btnPAC_USBreast.ImageOptions.Image = Resources.xray32px;
            btnPAC_USBreast.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btnPAC_USBreast.Location = new Point(351, 593);
            btnPAC_USBreast.Name = "btnPAC_USBreast";
            btnPAC_USBreast.Size = new Size(24, 33);
            btnPAC_USBreast.TabIndex = 75;
            btnPAC_USBreast.Visible = false;
            btnPAC_USBreast.Click += btnPAC_USBreast_Click;
            // 
            // btnX_USBreast
            // 
            btnX_USBreast.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnX_USBreast.Cursor = Cursors.Hand;
            btnX_USBreast.ImageOptions.Image = Resources.printpreview;
            btnX_USBreast.Location = new Point(320, 595);
            btnX_USBreast.Name = "btnX_USBreast";
            btnX_USBreast.Size = new Size(25, 33);
            btnX_USBreast.TabIndex = 74;
            btnX_USBreast.Click += btnX_USBreast_Click;
            // 
            // txtX_USBreast
            // 
            txtX_USBreast.EditValue = "";
            txtX_USBreast.Location = new Point(5, 628);
            txtX_USBreast.Name = "txtX_USBreast";
            txtX_USBreast.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            txtX_USBreast.Properties.Appearance.Options.UseFont = true;
            txtX_USBreast.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtX_USBreast.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtX_USBreast.Size = new Size(370, 109);
            txtX_USBreast.TabIndex = 73;
            // 
            // ddlX_USBreast
            // 
            ddlX_USBreast.EditValue = "";
            ddlX_USBreast.Location = new Point(5, 598);
            ddlX_USBreast.Name = "ddlX_USBreast";
            ddlX_USBreast.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            ddlX_USBreast.Properties.Appearance.Options.UseFont = true;
            ddlX_USBreast.Properties.AppearanceDropDown.Font = new Font("Segoe UI", 9.75F);
            ddlX_USBreast.Properties.AppearanceDropDown.Options.UseFont = true;
            ddlX_USBreast.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlX_USBreast.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlX_USBreast.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlX_USBreast.Properties.NullText = "";
            ddlX_USBreast.Size = new Size(309, 24);
            ddlX_USBreast.TabIndex = 72;
            // 
            // lblUsBreast
            // 
            lblUsBreast.AutoSize = true;
            lblUsBreast.Font = new Font("Segoe UI", 9.75F);
            lblUsBreast.Location = new Point(5, 578);
            lblUsBreast.Name = "lblUsBreast";
            lblUsBreast.Size = new Size(223, 17);
            lblUsBreast.TabIndex = 71;
            lblUsBreast.Text = "อัลตราซาวนด์เต้านม (Ultrasound Breast)";
            // 
            // btnPAC_Lower
            // 
            btnPAC_Lower.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnPAC_Lower.Cursor = Cursors.Hand;
            btnPAC_Lower.ImageOptions.Image = Resources.xray32px;
            btnPAC_Lower.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btnPAC_Lower.Location = new Point(748, 445);
            btnPAC_Lower.Name = "btnPAC_Lower";
            btnPAC_Lower.Size = new Size(24, 24);
            btnPAC_Lower.TabIndex = 70;
            btnPAC_Lower.Visible = false;
            btnPAC_Lower.Click += btnPAC_Lower_Click;
            // 
            // btnPAC_Mammo
            // 
            btnPAC_Mammo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnPAC_Mammo.Cursor = Cursors.Hand;
            btnPAC_Mammo.ImageOptions.Image = Resources.xray32px;
            btnPAC_Mammo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btnPAC_Mammo.Location = new Point(351, 445);
            btnPAC_Mammo.Name = "btnPAC_Mammo";
            btnPAC_Mammo.Size = new Size(24, 24);
            btnPAC_Mammo.TabIndex = 69;
            btnPAC_Mammo.Visible = false;
            btnPAC_Mammo.Click += btnPAC_Mammo_Click;
            // 
            // btnPAC_Upper
            // 
            btnPAC_Upper.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnPAC_Upper.Cursor = Cursors.Hand;
            btnPAC_Upper.ImageOptions.Image = Resources.xray32px;
            btnPAC_Upper.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btnPAC_Upper.Location = new Point(748, 235);
            btnPAC_Upper.Name = "btnPAC_Upper";
            btnPAC_Upper.Size = new Size(24, 24);
            btnPAC_Upper.TabIndex = 68;
            btnPAC_Upper.Visible = false;
            btnPAC_Upper.Click += btnPAC_Upper_Click;
            // 
            // btnPAC_Echo
            // 
            btnPAC_Echo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnPAC_Echo.Cursor = Cursors.Hand;
            btnPAC_Echo.ImageOptions.Image = Resources.xray32px;
            btnPAC_Echo.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btnPAC_Echo.Location = new Point(351, 235);
            btnPAC_Echo.Name = "btnPAC_Echo";
            btnPAC_Echo.Size = new Size(24, 24);
            btnPAC_Echo.TabIndex = 67;
            btnPAC_Echo.Visible = false;
            btnPAC_Echo.Click += btnPAC_Echo_Click;
            // 
            // btnPAC_Abdomen
            // 
            btnPAC_Abdomen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnPAC_Abdomen.Cursor = Cursors.Hand;
            btnPAC_Abdomen.ImageOptions.Image = Resources.xray32px;
            btnPAC_Abdomen.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btnPAC_Abdomen.Location = new Point(748, 30);
            btnPAC_Abdomen.Name = "btnPAC_Abdomen";
            btnPAC_Abdomen.Size = new Size(24, 24);
            btnPAC_Abdomen.TabIndex = 66;
            btnPAC_Abdomen.Visible = false;
            btnPAC_Abdomen.Click += btnPAC_Abdomen_Click;
            // 
            // btnPAC_PA
            // 
            btnPAC_PA.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnPAC_PA.Cursor = Cursors.Hand;
            btnPAC_PA.ImageOptions.Image = Resources.xray32px;
            btnPAC_PA.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btnPAC_PA.Location = new Point(351, 30);
            btnPAC_PA.Name = "btnPAC_PA";
            btnPAC_PA.Size = new Size(24, 24);
            btnPAC_PA.TabIndex = 65;
            btnPAC_PA.Visible = false;
            btnPAC_PA.Click += btnPAC_PA_Click;
            // 
            // btnX_Lower
            // 
            btnX_Lower.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnX_Lower.Cursor = Cursors.Hand;
            btnX_Lower.ImageOptions.Image = Resources.printpreview;
            btnX_Lower.Location = new Point(717, 445);
            btnX_Lower.Name = "btnX_Lower";
            btnX_Lower.Size = new Size(25, 24);
            btnX_Lower.TabIndex = 64;
            btnX_Lower.Click += btnX_Lower_Click;
            // 
            // btnX_Mammo
            // 
            btnX_Mammo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnX_Mammo.Cursor = Cursors.Hand;
            btnX_Mammo.ImageOptions.Image = Resources.printpreview;
            btnX_Mammo.Location = new Point(320, 445);
            btnX_Mammo.Name = "btnX_Mammo";
            btnX_Mammo.Size = new Size(25, 24);
            btnX_Mammo.TabIndex = 63;
            btnX_Mammo.Click += btnX_Mammo_Click;
            // 
            // btnX_Upper
            // 
            btnX_Upper.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnX_Upper.Cursor = Cursors.Hand;
            btnX_Upper.ImageOptions.Image = Resources.printpreview;
            btnX_Upper.Location = new Point(717, 235);
            btnX_Upper.Name = "btnX_Upper";
            btnX_Upper.Size = new Size(25, 24);
            btnX_Upper.TabIndex = 62;
            btnX_Upper.Click += btnX_Upper_Click;
            // 
            // btnX_Abdomen
            // 
            btnX_Abdomen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnX_Abdomen.Cursor = Cursors.Hand;
            btnX_Abdomen.ImageOptions.Image = Resources.printpreview;
            btnX_Abdomen.Location = new Point(717, 30);
            btnX_Abdomen.Name = "btnX_Abdomen";
            btnX_Abdomen.Size = new Size(25, 24);
            btnX_Abdomen.TabIndex = 61;
            btnX_Abdomen.Click += btnX_Abdomen_Click;
            // 
            // btnX_Echo
            // 
            btnX_Echo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnX_Echo.Cursor = Cursors.Hand;
            btnX_Echo.ImageOptions.Image = Resources.printpreview;
            btnX_Echo.Location = new Point(320, 235);
            btnX_Echo.Name = "btnX_Echo";
            btnX_Echo.Size = new Size(25, 24);
            btnX_Echo.TabIndex = 60;
            btnX_Echo.Click += btnX_Echo_Click;
            // 
            // btnX_PA
            // 
            btnX_PA.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnX_PA.Cursor = Cursors.Hand;
            btnX_PA.ImageOptions.Image = Resources.printpreview;
            btnX_PA.Location = new Point(320, 30);
            btnX_PA.Name = "btnX_PA";
            btnX_PA.Size = new Size(25, 24);
            btnX_PA.TabIndex = 59;
            btnX_PA.Click += btnX_PA_Click;
            // 
            // txtX_LowerAbdomenRemark
            // 
            txtX_LowerAbdomenRemark.EditValue = "";
            txtX_LowerAbdomenRemark.Location = new Point(400, 475);
            txtX_LowerAbdomenRemark.Name = "txtX_LowerAbdomenRemark";
            txtX_LowerAbdomenRemark.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            txtX_LowerAbdomenRemark.Properties.Appearance.Options.UseFont = true;
            txtX_LowerAbdomenRemark.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtX_LowerAbdomenRemark.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtX_LowerAbdomenRemark.Size = new Size(370, 100);
            txtX_LowerAbdomenRemark.TabIndex = 58;
            // 
            // ddlX_LowerAbdomen
            // 
            ddlX_LowerAbdomen.EditValue = "";
            ddlX_LowerAbdomen.Location = new Point(400, 445);
            ddlX_LowerAbdomen.Name = "ddlX_LowerAbdomen";
            ddlX_LowerAbdomen.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            ddlX_LowerAbdomen.Properties.Appearance.Options.UseFont = true;
            ddlX_LowerAbdomen.Properties.AppearanceDropDown.Font = new Font("Segoe UI", 9.75F);
            ddlX_LowerAbdomen.Properties.AppearanceDropDown.Options.UseFont = true;
            ddlX_LowerAbdomen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlX_LowerAbdomen.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlX_LowerAbdomen.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlX_LowerAbdomen.Properties.NullText = "";
            ddlX_LowerAbdomen.Size = new Size(311, 24);
            ddlX_LowerAbdomen.TabIndex = 57;
            // 
            // lblLowerAbdomen
            // 
            lblLowerAbdomen.AutoSize = true;
            lblLowerAbdomen.Font = new Font("Segoe UI", 9.75F);
            lblLowerAbdomen.Location = new Point(400, 425);
            lblLowerAbdomen.Name = "lblLowerAbdomen";
            lblLowerAbdomen.Size = new Size(323, 17);
            lblLowerAbdomen.TabIndex = 56;
            lblLowerAbdomen.Text = "อัลตราซาวด์ช่องท้องส่วนล่าง (Ultrasound Lower Abdomen)";
            // 
            // txtX_Mammogram
            // 
            txtX_Mammogram.EditValue = "";
            txtX_Mammogram.Location = new Point(5, 475);
            txtX_Mammogram.Name = "txtX_Mammogram";
            txtX_Mammogram.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            txtX_Mammogram.Properties.Appearance.Options.UseFont = true;
            txtX_Mammogram.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtX_Mammogram.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtX_Mammogram.Size = new Size(370, 100);
            txtX_Mammogram.TabIndex = 51;
            // 
            // ddlX_Mammogram
            // 
            ddlX_Mammogram.EditValue = "";
            ddlX_Mammogram.Location = new Point(5, 445);
            ddlX_Mammogram.Name = "ddlX_Mammogram";
            ddlX_Mammogram.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            ddlX_Mammogram.Properties.Appearance.Options.UseFont = true;
            ddlX_Mammogram.Properties.AppearanceDropDown.Font = new Font("Segoe UI", 9.75F);
            ddlX_Mammogram.Properties.AppearanceDropDown.Options.UseFont = true;
            ddlX_Mammogram.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlX_Mammogram.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlX_Mammogram.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlX_Mammogram.Properties.NullText = "";
            ddlX_Mammogram.Size = new Size(309, 24);
            ddlX_Mammogram.TabIndex = 48;
            // 
            // txtX_EchoRemark
            // 
            txtX_EchoRemark.EditValue = "";
            txtX_EchoRemark.Location = new Point(5, 265);
            txtX_EchoRemark.Name = "txtX_EchoRemark";
            txtX_EchoRemark.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            txtX_EchoRemark.Properties.Appearance.Options.UseFont = true;
            txtX_EchoRemark.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtX_EchoRemark.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtX_EchoRemark.Size = new Size(370, 140);
            txtX_EchoRemark.TabIndex = 47;
            // 
            // ddlX_Echo
            // 
            ddlX_Echo.EditValue = "";
            ddlX_Echo.Location = new Point(5, 235);
            ddlX_Echo.Name = "ddlX_Echo";
            ddlX_Echo.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            ddlX_Echo.Properties.Appearance.Options.UseFont = true;
            ddlX_Echo.Properties.AppearanceDropDown.Font = new Font("Segoe UI", 9.75F);
            ddlX_Echo.Properties.AppearanceDropDown.Options.UseFont = true;
            ddlX_Echo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlX_Echo.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlX_Echo.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlX_Echo.Properties.NullText = "";
            ddlX_Echo.Size = new Size(309, 24);
            ddlX_Echo.TabIndex = 45;
            // 
            // txtX_UpperAbdomenRemark
            // 
            txtX_UpperAbdomenRemark.EditValue = "";
            txtX_UpperAbdomenRemark.Location = new Point(400, 265);
            txtX_UpperAbdomenRemark.Name = "txtX_UpperAbdomenRemark";
            txtX_UpperAbdomenRemark.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            txtX_UpperAbdomenRemark.Properties.Appearance.Options.UseFont = true;
            txtX_UpperAbdomenRemark.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtX_UpperAbdomenRemark.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtX_UpperAbdomenRemark.Size = new Size(370, 140);
            txtX_UpperAbdomenRemark.TabIndex = 44;
            // 
            // txtX_ChestPA
            // 
            txtX_ChestPA.EditValue = "";
            txtX_ChestPA.Location = new Point(5, 60);
            txtX_ChestPA.Name = "txtX_ChestPA";
            txtX_ChestPA.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            txtX_ChestPA.Properties.Appearance.Options.UseFont = true;
            txtX_ChestPA.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtX_ChestPA.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtX_ChestPA.Size = new Size(370, 140);
            txtX_ChestPA.TabIndex = 43;
            // 
            // ddlX_UpperAbdomen
            // 
            ddlX_UpperAbdomen.EditValue = "";
            ddlX_UpperAbdomen.Location = new Point(400, 235);
            ddlX_UpperAbdomen.Name = "ddlX_UpperAbdomen";
            ddlX_UpperAbdomen.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            ddlX_UpperAbdomen.Properties.Appearance.Options.UseFont = true;
            ddlX_UpperAbdomen.Properties.AppearanceDropDown.Font = new Font("Segoe UI", 9.75F);
            ddlX_UpperAbdomen.Properties.AppearanceDropDown.Options.UseFont = true;
            ddlX_UpperAbdomen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlX_UpperAbdomen.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlX_UpperAbdomen.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlX_UpperAbdomen.Properties.NullText = "";
            ddlX_UpperAbdomen.Size = new Size(311, 24);
            ddlX_UpperAbdomen.TabIndex = 42;
            // 
            // ddlX_ChestPA
            // 
            ddlX_ChestPA.EditValue = "";
            ddlX_ChestPA.Location = new Point(5, 30);
            ddlX_ChestPA.Name = "ddlX_ChestPA";
            ddlX_ChestPA.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            ddlX_ChestPA.Properties.Appearance.Options.UseFont = true;
            ddlX_ChestPA.Properties.AppearanceDropDown.Font = new Font("Segoe UI", 9.75F);
            ddlX_ChestPA.Properties.AppearanceDropDown.Options.UseFont = true;
            ddlX_ChestPA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlX_ChestPA.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlX_ChestPA.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlX_ChestPA.Properties.NullText = "";
            ddlX_ChestPA.Size = new Size(309, 24);
            ddlX_ChestPA.TabIndex = 41;
            // 
            // txtX_AbdomenRemark
            // 
            txtX_AbdomenRemark.EditValue = "";
            txtX_AbdomenRemark.Location = new Point(400, 60);
            txtX_AbdomenRemark.Name = "txtX_AbdomenRemark";
            txtX_AbdomenRemark.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            txtX_AbdomenRemark.Properties.Appearance.Options.UseFont = true;
            txtX_AbdomenRemark.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtX_AbdomenRemark.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtX_AbdomenRemark.Size = new Size(370, 140);
            txtX_AbdomenRemark.TabIndex = 40;
            // 
            // ddlX_Abdomen
            // 
            ddlX_Abdomen.EditValue = "";
            ddlX_Abdomen.Location = new Point(400, 30);
            ddlX_Abdomen.Name = "ddlX_Abdomen";
            ddlX_Abdomen.Properties.Appearance.Font = new Font("Segoe UI", 9.75F);
            ddlX_Abdomen.Properties.Appearance.Options.UseFont = true;
            ddlX_Abdomen.Properties.AppearanceDropDown.Font = new Font("Segoe UI", 9.75F);
            ddlX_Abdomen.Properties.AppearanceDropDown.Options.UseFont = true;
            ddlX_Abdomen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlX_Abdomen.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlX_Abdomen.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlX_Abdomen.Properties.NullText = "";
            ddlX_Abdomen.Size = new Size(311, 24);
            ddlX_Abdomen.TabIndex = 39;
            // 
            // lblAbdomen
            // 
            lblAbdomen.AutoSize = true;
            lblAbdomen.Font = new Font("Segoe UI", 9.75F);
            lblAbdomen.Location = new Point(400, 10);
            lblAbdomen.Name = "lblAbdomen";
            lblAbdomen.Size = new Size(286, 17);
            lblAbdomen.TabIndex = 6;
            lblAbdomen.Text = "อัลตร้าซาวด์ช่องท้อง (Ultrasound Whole Abdomen)";
            // 
            // lblChestPA
            // 
            lblChestPA.AutoSize = true;
            lblChestPA.Font = new Font("Segoe UI", 9.75F);
            lblChestPA.Location = new Point(5, 10);
            lblChestPA.Name = "lblChestPA";
            lblChestPA.Size = new Size(187, 17);
            lblChestPA.TabIndex = 5;
            lblChestPA.Text = "เอกซ์เรย์ปอด (Chest PA check up)";
            // 
            // lblUpperAbdomen
            // 
            lblUpperAbdomen.AutoSize = true;
            lblUpperAbdomen.Font = new Font("Segoe UI", 9.75F);
            lblUpperAbdomen.Location = new Point(400, 215);
            lblUpperAbdomen.Name = "lblUpperAbdomen";
            lblUpperAbdomen.Size = new Size(322, 17);
            lblUpperAbdomen.TabIndex = 4;
            lblUpperAbdomen.Text = "อัลตราซาวด์ช่องท้องส่วนบน (Ultrasound Upper Abdomen)";
            // 
            // lblHeart
            // 
            lblHeart.AutoSize = true;
            lblHeart.Font = new Font("Segoe UI", 9.75F);
            lblHeart.Location = new Point(5, 215);
            lblHeart.Name = "lblHeart";
            lblHeart.Size = new Size(200, 17);
            lblHeart.TabIndex = 3;
            lblHeart.Text = "อัลตราซาวด์หัวใจ (Echocardiogram)";
            // 
            // lblMammogram
            // 
            lblMammogram.AutoSize = true;
            lblMammogram.Font = new Font("Segoe UI", 9.75F);
            lblMammogram.Location = new Point(5, 425);
            lblMammogram.Name = "lblMammogram";
            lblMammogram.Size = new Size(195, 17);
            lblMammogram.TabIndex = 1;
            lblMammogram.Text = "คัดกรองมะเร็งเต้านม (Mammogram)";
            // 
            // pnSpecial
            // 
            pnSpecial.BackColor = Color.White;
            pnSpecial.Controls.Add(grdSpecialTest);
            pnSpecial.Dock = DockStyle.Fill;
            pnSpecial.Location = new Point(0, 0);
            pnSpecial.Name = "pnSpecial";
            pnSpecial.Size = new Size(1486, 553);
            pnSpecial.TabIndex = 1;
            // 
            // grdSpecialTest
            // 
            grdSpecialTest.Location = new Point(0, 0);
            grdSpecialTest.LookAndFeel.SkinName = "Office 2010 Blue";
            grdSpecialTest.LookAndFeel.UseDefaultLookAndFeel = false;
            grdSpecialTest.MainView = grdViewSpecialTest;
            grdSpecialTest.Name = "grdSpecialTest";
            grdSpecialTest.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemMemoEdit2, repositoryItemCheckEdit3, repositoryItemCheckEdit4 });
            grdSpecialTest.Size = new Size(1379, 559);
            grdSpecialTest.TabIndex = 7;
            grdSpecialTest.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { grdViewSpecialTest });
            // 
            // grdViewSpecialTest
            // 
            grdViewSpecialTest.Appearance.GroupRow.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grdViewSpecialTest.Appearance.GroupRow.Options.UseFont = true;
            grdViewSpecialTest.Appearance.HeaderPanel.Options.UseTextOptions = true;
            grdViewSpecialTest.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            grdViewSpecialTest.Appearance.Row.Font = new Font("Segoe UI", 10F);
            grdViewSpecialTest.Appearance.Row.Options.UseFont = true;
            grdViewSpecialTest.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            grdViewSpecialTest.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn38, gridColumn39, gridColumn40, gridColumn41, gridColumn42, gridColumn43, gridColumn44, gridColumn45, gridColumn46 });
            grdViewSpecialTest.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            grdViewSpecialTest.GridControl = grdSpecialTest;
            grdViewSpecialTest.GroupCount = 1;
            grdViewSpecialTest.GroupFormat = "[#image]{1} {2}";
            grdViewSpecialTest.Name = "grdViewSpecialTest";
            grdViewSpecialTest.OptionsBehavior.AutoExpandAllGroups = true;
            grdViewSpecialTest.OptionsBehavior.Editable = false;
            grdViewSpecialTest.OptionsDetail.EnableMasterViewMode = false;
            grdViewSpecialTest.OptionsView.ColumnAutoWidth = false;
            grdViewSpecialTest.OptionsView.RowAutoHeight = true;
            grdViewSpecialTest.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            grdViewSpecialTest.OptionsView.ShowGroupPanel = false;
            grdViewSpecialTest.OptionsView.ShowIndicator = false;
            grdViewSpecialTest.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            grdViewSpecialTest.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(gridColumn46, DevExpress.Data.ColumnSortOrder.Ascending) });
            grdViewSpecialTest.RowStyle += grdViewSpecialTest_RowStyle;
            // 
            // gridColumn38
            // 
            gridColumn38.Caption = "Test";
            gridColumn38.FieldName = "ResultItemName";
            gridColumn38.Name = "gridColumn38";
            gridColumn38.Visible = true;
            gridColumn38.VisibleIndex = 0;
            gridColumn38.Width = 240;
            // 
            // gridColumn39
            // 
            gridColumn39.AppearanceCell.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gridColumn39.AppearanceCell.Options.UseFont = true;
            gridColumn39.AppearanceCell.Options.UseTextOptions = true;
            gridColumn39.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn39.Caption = "Result";
            gridColumn39.ColumnEdit = repositoryItemMemoEdit2;
            gridColumn39.FieldName = "ResultValue";
            gridColumn39.Name = "gridColumn39";
            gridColumn39.Visible = true;
            gridColumn39.VisibleIndex = 1;
            gridColumn39.Width = 120;
            // 
            // repositoryItemMemoEdit2
            // 
            repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // gridColumn40
            // 
            gridColumn40.AppearanceCell.Options.UseTextOptions = true;
            gridColumn40.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn40.Caption = "UOM";
            gridColumn40.FieldName = "UnitOfMeasure";
            gridColumn40.Name = "gridColumn40";
            gridColumn40.Visible = true;
            gridColumn40.VisibleIndex = 2;
            gridColumn40.Width = 120;
            // 
            // gridColumn41
            // 
            gridColumn41.AppearanceCell.Options.UseTextOptions = true;
            gridColumn41.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn41.Caption = "Reference";
            gridColumn41.FieldName = "ReferenceRange";
            gridColumn41.Name = "gridColumn41";
            gridColumn41.Visible = true;
            gridColumn41.VisibleIndex = 3;
            gridColumn41.Width = 100;
            // 
            // gridColumn42
            // 
            gridColumn42.ColumnEdit = repositoryItemCheckEdit3;
            gridColumn42.FieldName = "IsAbnormal";
            gridColumn42.Name = "gridColumn42";
            gridColumn42.OptionsColumn.ShowCaption = false;
            gridColumn42.Visible = true;
            gridColumn42.VisibleIndex = 4;
            gridColumn42.Width = 20;
            // 
            // repositoryItemCheckEdit3
            // 
            repositoryItemCheckEdit3.AutoHeight = false;
            repositoryItemCheckEdit3.AutoWidth = true;
            repositoryItemCheckEdit3.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            repositoryItemCheckEdit3.ImageOptions.ImageChecked = (Image)resources.GetObject("repositoryItemCheckEdit3.ImageOptions.ImageChecked");
            repositoryItemCheckEdit3.ImageOptions.ImageGrayed = (Image)resources.GetObject("repositoryItemCheckEdit3.ImageOptions.ImageGrayed");
            repositoryItemCheckEdit3.ImageOptions.ImageUnchecked = (Image)resources.GetObject("repositoryItemCheckEdit3.ImageOptions.ImageUnchecked");
            repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            repositoryItemCheckEdit3.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            repositoryItemCheckEdit3.ValueChecked = "H";
            repositoryItemCheckEdit3.ValueGrayed = "N";
            repositoryItemCheckEdit3.ValueUnchecked = "L";
            // 
            // gridColumn43
            // 
            gridColumn43.ColumnEdit = repositoryItemCheckEdit4;
            gridColumn43.FieldName = "IsAbnormal";
            gridColumn43.Name = "gridColumn43";
            gridColumn43.OptionsColumn.ShowCaption = false;
            gridColumn43.Visible = true;
            gridColumn43.VisibleIndex = 5;
            gridColumn43.Width = 20;
            // 
            // repositoryItemCheckEdit4
            // 
            repositoryItemCheckEdit4.AutoHeight = false;
            repositoryItemCheckEdit4.AutoWidth = true;
            repositoryItemCheckEdit4.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            repositoryItemCheckEdit4.ImageOptions.ImageChecked = (Image)resources.GetObject("repositoryItemCheckEdit4.ImageOptions.ImageChecked");
            repositoryItemCheckEdit4.ImageOptions.ImageGrayed = (Image)resources.GetObject("repositoryItemCheckEdit4.ImageOptions.ImageGrayed");
            repositoryItemCheckEdit4.ImageOptions.ImageUnchecked = (Image)resources.GetObject("repositoryItemCheckEdit4.ImageOptions.ImageUnchecked");
            repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            repositoryItemCheckEdit4.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            repositoryItemCheckEdit4.ValueChecked = "HH";
            repositoryItemCheckEdit4.ValueGrayed = "N";
            repositoryItemCheckEdit4.ValueUnchecked = "LL";
            // 
            // gridColumn44
            // 
            gridColumn44.Caption = "PrintOrder";
            gridColumn44.FieldName = "PrintOrder";
            gridColumn44.Name = "gridColumn44";
            gridColumn44.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            // 
            // gridColumn45
            // 
            gridColumn45.Caption = "Comment";
            gridColumn45.FieldName = "Comment";
            gridColumn45.Name = "gridColumn45";
            gridColumn45.Visible = true;
            gridColumn45.VisibleIndex = 6;
            gridColumn45.Width = 170;
            // 
            // gridColumn46
            // 
            gridColumn46.Caption = "CheckupGroupName";
            gridColumn46.FieldName = "CheckupGroupName";
            gridColumn46.Name = "gridColumn46";
            gridColumn46.Visible = true;
            gridColumn46.VisibleIndex = 7;
            // 
            // pnTechnicOther
            // 
            pnTechnicOther.AutoScroll = true;
            pnTechnicOther.Controls.Add(btnPAC_BMD);
            pnTechnicOther.Controls.Add(txtPapSmear);
            pnTechnicOther.Controls.Add(chkPapSmear);
            pnTechnicOther.Controls.Add(txtVegina);
            pnTechnicOther.Controls.Add(chkVegina);
            pnTechnicOther.Controls.Add(lblEKG);
            pnTechnicOther.Controls.Add(txtX_EKGResult);
            pnTechnicOther.Controls.Add(ddlX_EKG);
            pnTechnicOther.Controls.Add(txtX_BMDRemark);
            pnTechnicOther.Controls.Add(lblEST);
            pnTechnicOther.Controls.Add(ddlX_BMD);
            pnTechnicOther.Controls.Add(lblABI);
            pnTechnicOther.Controls.Add(lblBMD);
            pnTechnicOther.Controls.Add(ddlX_EST);
            pnTechnicOther.Controls.Add(txtX_ABIRemark);
            pnTechnicOther.Controls.Add(ddlX_ABI);
            pnTechnicOther.Controls.Add(txtX_ESTRemark);
            pnTechnicOther.Dock = DockStyle.Fill;
            pnTechnicOther.Font = new Font("Segoe UI", 10F);
            pnTechnicOther.Location = new Point(0, 0);
            pnTechnicOther.Name = "pnTechnicOther";
            pnTechnicOther.Size = new Size(1486, 553);
            pnTechnicOther.TabIndex = 0;
            // 
            // btnPAC_BMD
            // 
            btnPAC_BMD.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            btnPAC_BMD.Cursor = Cursors.Hand;
            btnPAC_BMD.ImageOptions.Image = Resources.xray32px;
            btnPAC_BMD.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            btnPAC_BMD.Location = new Point(351, 235);
            btnPAC_BMD.Name = "btnPAC_BMD";
            btnPAC_BMD.Size = new Size(24, 24);
            btnPAC_BMD.TabIndex = 66;
            btnPAC_BMD.Visible = false;
            btnPAC_BMD.Click += btnPAC_BMD_Click;
            // 
            // txtPapSmear
            // 
            txtPapSmear.EditValue = "ผลการตรวจคัดกรองมะเร็งปากมดลูกจะส่งตามที่ผู้ป่วยแสดงความจำนง";
            txtPapSmear.Location = new Point(400, 455);
            txtPapSmear.Name = "txtPapSmear";
            txtPapSmear.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            txtPapSmear.Properties.Appearance.Options.UseFont = true;
            txtPapSmear.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtPapSmear.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtPapSmear.Size = new Size(370, 120);
            txtPapSmear.TabIndex = 57;
            // 
            // chkPapSmear
            // 
            chkPapSmear.Location = new Point(400, 425);
            chkPapSmear.Name = "chkPapSmear";
            chkPapSmear.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            chkPapSmear.Properties.Appearance.Options.UseFont = true;
            chkPapSmear.Properties.Caption = "ผลการคัดกรองมะเร็งปากมดลูก";
            chkPapSmear.Properties.LookAndFeel.SkinName = "VS2010";
            chkPapSmear.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            chkPapSmear.Size = new Size(315, 23);
            chkPapSmear.TabIndex = 59;
            // 
            // txtVegina
            // 
            txtVegina.EditValue = "ตามคำแนะนำของสูตินารีแพทย์";
            txtVegina.Location = new Point(5, 454);
            txtVegina.Name = "txtVegina";
            txtVegina.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            txtVegina.Properties.Appearance.Options.UseFont = true;
            txtVegina.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtVegina.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtVegina.Size = new Size(370, 121);
            txtVegina.TabIndex = 36;
            // 
            // chkVegina
            // 
            chkVegina.Location = new Point(5, 425);
            chkVegina.Name = "chkVegina";
            chkVegina.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            chkVegina.Properties.Appearance.Options.UseFont = true;
            chkVegina.Properties.Caption = "ผลการตรวจภายใน";
            chkVegina.Properties.LookAndFeel.SkinName = "VS2010";
            chkVegina.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            chkVegina.Size = new Size(312, 23);
            chkVegina.TabIndex = 58;
            // 
            // lblEKG
            // 
            lblEKG.AutoSize = true;
            lblEKG.Location = new Point(5, 10);
            lblEKG.Name = "lblEKG";
            lblEKG.Size = new Size(184, 19);
            lblEKG.TabIndex = 0;
            lblEKG.Text = "ผลการตรวจคลื่นไฟฟ้าหัวใจ (EKG)";
            // 
            // txtX_EKGResult
            // 
            txtX_EKGResult.EditValue = "";
            txtX_EKGResult.Location = new Point(5, 60);
            txtX_EKGResult.Name = "txtX_EKGResult";
            txtX_EKGResult.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            txtX_EKGResult.Properties.Appearance.Options.UseFont = true;
            txtX_EKGResult.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtX_EKGResult.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtX_EKGResult.Size = new Size(370, 140);
            txtX_EKGResult.TabIndex = 38;
            // 
            // ddlX_EKG
            // 
            ddlX_EKG.EditValue = "";
            ddlX_EKG.Location = new Point(5, 30);
            ddlX_EKG.Name = "ddlX_EKG";
            ddlX_EKG.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlX_EKG.Properties.Appearance.Options.UseFont = true;
            ddlX_EKG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlX_EKG.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlX_EKG.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlX_EKG.Properties.NullText = "";
            ddlX_EKG.Size = new Size(370, 24);
            ddlX_EKG.TabIndex = 37;
            // 
            // txtX_BMDRemark
            // 
            txtX_BMDRemark.EditValue = "";
            txtX_BMDRemark.Location = new Point(5, 265);
            txtX_BMDRemark.Name = "txtX_BMDRemark";
            txtX_BMDRemark.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            txtX_BMDRemark.Properties.Appearance.Options.UseFont = true;
            txtX_BMDRemark.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtX_BMDRemark.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtX_BMDRemark.Size = new Size(370, 140);
            txtX_BMDRemark.TabIndex = 55;
            // 
            // lblEST
            // 
            lblEST.AutoSize = true;
            lblEST.Location = new Point(400, 10);
            lblEST.Name = "lblEST";
            lblEST.Size = new Size(268, 19);
            lblEST.TabIndex = 2;
            lblEST.Text = "การตรวจสมรรถภาพหัวใจด้วยการวิ่งสายพาน (EST)";
            // 
            // ddlX_BMD
            // 
            ddlX_BMD.EditValue = "";
            ddlX_BMD.Location = new Point(5, 235);
            ddlX_BMD.Name = "ddlX_BMD";
            ddlX_BMD.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlX_BMD.Properties.Appearance.Options.UseFont = true;
            ddlX_BMD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlX_BMD.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlX_BMD.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlX_BMD.Properties.NullText = "";
            ddlX_BMD.Size = new Size(338, 24);
            ddlX_BMD.TabIndex = 54;
            // 
            // lblABI
            // 
            lblABI.AutoSize = true;
            lblABI.Location = new Point(400, 215);
            lblABI.Name = "lblABI";
            lblABI.Size = new Size(344, 19);
            lblABI.TabIndex = 1;
            lblABI.Text = "ตรวจความแข็งตัวของหลอดเลือด (Ankle-brachial index (ABI))";
            // 
            // lblBMD
            // 
            lblBMD.AutoSize = true;
            lblBMD.Location = new Point(5, 215);
            lblBMD.Name = "lblBMD";
            lblBMD.Size = new Size(247, 19);
            lblBMD.TabIndex = 53;
            lblBMD.Text = "ผลการตรวจความหนาแน่นของกระดูก ( BMD)";
            // 
            // ddlX_EST
            // 
            ddlX_EST.EditValue = "";
            ddlX_EST.Location = new Point(400, 30);
            ddlX_EST.Name = "ddlX_EST";
            ddlX_EST.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlX_EST.Properties.Appearance.Options.UseFont = true;
            ddlX_EST.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlX_EST.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlX_EST.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlX_EST.Properties.NullText = "";
            ddlX_EST.Size = new Size(370, 24);
            ddlX_EST.TabIndex = 46;
            // 
            // txtX_ABIRemark
            // 
            txtX_ABIRemark.EditValue = "";
            txtX_ABIRemark.Location = new Point(400, 265);
            txtX_ABIRemark.Name = "txtX_ABIRemark";
            txtX_ABIRemark.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            txtX_ABIRemark.Properties.Appearance.Options.UseFont = true;
            txtX_ABIRemark.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtX_ABIRemark.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtX_ABIRemark.Size = new Size(370, 140);
            txtX_ABIRemark.TabIndex = 52;
            // 
            // ddlX_ABI
            // 
            ddlX_ABI.EditValue = "";
            ddlX_ABI.Location = new Point(400, 235);
            ddlX_ABI.Name = "ddlX_ABI";
            ddlX_ABI.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlX_ABI.Properties.Appearance.Options.UseFont = true;
            ddlX_ABI.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlX_ABI.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlX_ABI.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlX_ABI.Properties.NullText = "";
            ddlX_ABI.Size = new Size(370, 24);
            ddlX_ABI.TabIndex = 49;
            // 
            // txtX_ESTRemark
            // 
            txtX_ESTRemark.EditValue = "";
            txtX_ESTRemark.Location = new Point(400, 60);
            txtX_ESTRemark.Name = "txtX_ESTRemark";
            txtX_ESTRemark.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            txtX_ESTRemark.Properties.Appearance.Options.UseFont = true;
            txtX_ESTRemark.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtX_ESTRemark.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtX_ESTRemark.Size = new Size(370, 139);
            txtX_ESTRemark.TabIndex = 50;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Test";
            gridColumn2.FieldName = "ResultItemName";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 0;
            gridColumn2.Width = 240;
            // 
            // gridColumn9
            // 
            gridColumn9.AppearanceCell.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gridColumn9.AppearanceCell.Options.UseFont = true;
            gridColumn9.AppearanceCell.Options.UseTextOptions = true;
            gridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn9.Caption = "Result";
            gridColumn9.ColumnEdit = repositoryItemMemoEdit4;
            gridColumn9.FieldName = "ResultValue";
            gridColumn9.Name = "gridColumn9";
            gridColumn9.Visible = true;
            gridColumn9.VisibleIndex = 1;
            gridColumn9.Width = 120;
            // 
            // repositoryItemMemoEdit4
            // 
            repositoryItemMemoEdit4.Name = "repositoryItemMemoEdit4";
            // 
            // gridColumn12
            // 
            gridColumn12.AppearanceCell.Options.UseTextOptions = true;
            gridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn12.Caption = "UOM";
            gridColumn12.FieldName = "UnitOfMeasure";
            gridColumn12.Name = "gridColumn12";
            gridColumn12.Visible = true;
            gridColumn12.VisibleIndex = 2;
            gridColumn12.Width = 120;
            // 
            // gridColumn13
            // 
            gridColumn13.AppearanceCell.Options.UseTextOptions = true;
            gridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn13.Caption = "Reference";
            gridColumn13.FieldName = "ReferenceRange";
            gridColumn13.Name = "gridColumn13";
            gridColumn13.Visible = true;
            gridColumn13.VisibleIndex = 3;
            gridColumn13.Width = 100;
            // 
            // gridColumn18
            // 
            gridColumn18.ColumnEdit = repositoryItemCheckEdit7;
            gridColumn18.FieldName = "IsAbnormal";
            gridColumn18.Name = "gridColumn18";
            gridColumn18.OptionsColumn.ShowCaption = false;
            gridColumn18.Visible = true;
            gridColumn18.VisibleIndex = 4;
            gridColumn18.Width = 20;
            // 
            // repositoryItemCheckEdit7
            // 
            repositoryItemCheckEdit7.AutoHeight = false;
            repositoryItemCheckEdit7.AutoWidth = true;
            repositoryItemCheckEdit7.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            repositoryItemCheckEdit7.ImageOptions.ImageChecked = (Image)resources.GetObject("repositoryItemCheckEdit7.ImageOptions.ImageChecked");
            repositoryItemCheckEdit7.ImageOptions.ImageGrayed = (Image)resources.GetObject("repositoryItemCheckEdit7.ImageOptions.ImageGrayed");
            repositoryItemCheckEdit7.ImageOptions.ImageUnchecked = (Image)resources.GetObject("repositoryItemCheckEdit7.ImageOptions.ImageUnchecked");
            repositoryItemCheckEdit7.Name = "repositoryItemCheckEdit7";
            repositoryItemCheckEdit7.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            repositoryItemCheckEdit7.ValueChecked = "H";
            repositoryItemCheckEdit7.ValueGrayed = "N";
            repositoryItemCheckEdit7.ValueUnchecked = "L";
            // 
            // gridColumn19
            // 
            gridColumn19.ColumnEdit = repositoryItemCheckEdit8;
            gridColumn19.FieldName = "IsAbnormal";
            gridColumn19.Name = "gridColumn19";
            gridColumn19.OptionsColumn.ShowCaption = false;
            gridColumn19.Visible = true;
            gridColumn19.VisibleIndex = 5;
            gridColumn19.Width = 20;
            // 
            // repositoryItemCheckEdit8
            // 
            repositoryItemCheckEdit8.AutoHeight = false;
            repositoryItemCheckEdit8.AutoWidth = true;
            repositoryItemCheckEdit8.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            repositoryItemCheckEdit8.ImageOptions.ImageChecked = (Image)resources.GetObject("repositoryItemCheckEdit8.ImageOptions.ImageChecked");
            repositoryItemCheckEdit8.ImageOptions.ImageGrayed = (Image)resources.GetObject("repositoryItemCheckEdit8.ImageOptions.ImageGrayed");
            repositoryItemCheckEdit8.ImageOptions.ImageUnchecked = (Image)resources.GetObject("repositoryItemCheckEdit8.ImageOptions.ImageUnchecked");
            repositoryItemCheckEdit8.Name = "repositoryItemCheckEdit8";
            repositoryItemCheckEdit8.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            repositoryItemCheckEdit8.ValueChecked = "HH";
            repositoryItemCheckEdit8.ValueGrayed = "N";
            repositoryItemCheckEdit8.ValueUnchecked = "LL";
            // 
            // gridColumn20
            // 
            gridColumn20.Caption = "PrintOrder";
            gridColumn20.FieldName = "PrintOrder";
            gridColumn20.Name = "gridColumn20";
            gridColumn20.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            // 
            // gridColumn21
            // 
            gridColumn21.Name = "gridColumn21";
            gridColumn21.Visible = true;
            gridColumn21.VisibleIndex = 6;
            gridColumn21.Width = 80;
            // 
            // gridColumn14
            // 
            gridColumn14.AppearanceCell.Options.UseTextOptions = true;
            gridColumn14.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gridColumn14.Caption = "Test";
            gridColumn14.FieldName = "ResultItemName";
            gridColumn14.Name = "gridColumn14";
            gridColumn14.Visible = true;
            gridColumn14.VisibleIndex = 0;
            gridColumn14.Width = 245;
            // 
            // gridColumn15
            // 
            gridColumn15.AppearanceCell.Options.UseTextOptions = true;
            gridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn15.Caption = "Result Value";
            gridColumn15.FieldName = "ResultValue";
            gridColumn15.Name = "gridColumn15";
            gridColumn15.Visible = true;
            gridColumn15.VisibleIndex = 1;
            gridColumn15.Width = 79;
            // 
            // gridColumn16
            // 
            gridColumn16.AppearanceCell.Font = new Font("Segoe UI", 9F);
            gridColumn16.AppearanceCell.Options.UseFont = true;
            gridColumn16.AppearanceCell.Options.UseTextOptions = true;
            gridColumn16.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn16.Caption = "Reference Range";
            gridColumn16.FieldName = "ReferenceRange";
            gridColumn16.Name = "gridColumn16";
            gridColumn16.Visible = true;
            gridColumn16.VisibleIndex = 2;
            gridColumn16.Width = 123;
            // 
            // gridColumn17
            // 
            gridColumn17.Caption = "Abnormal";
            gridColumn17.FieldName = "NormalTXT";
            gridColumn17.Name = "gridColumn17";
            gridColumn17.Visible = true;
            gridColumn17.VisibleIndex = 3;
            // 
            // colLabHead
            // 
            colLabHead.AppearanceCell.Font = new Font("Segoe UI", 9F);
            colLabHead.AppearanceCell.Options.UseFont = true;
            colLabHead.Caption = " ";
            colLabHead.CustomizationCaption = " ";
            colLabHead.FieldName = "RequestItemName";
            colLabHead.Name = "colLabHead";
            colLabHead.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            colLabHead.OptionsColumn.ShowCaption = false;
            colLabHead.Visible = true;
            colLabHead.VisibleIndex = 0;
            // 
            // colBlank
            // 
            colBlank.MinWidth = 10;
            colBlank.Name = "colBlank";
            colBlank.OptionsColumn.AllowFocus = false;
            // 
            // colLabItem
            // 
            colLabItem.Caption = "LabItem";
            colLabItem.FieldName = "ResultItemName";
            colLabItem.Name = "colLabItem";
            colLabItem.Visible = true;
            colLabItem.VisibleIndex = 0;
            colLabItem.Width = 100;
            // 
            // colResult
            // 
            colResult.Caption = "Result";
            colResult.ColumnEdit = repositoryItemMemoEdit1;
            colResult.FieldName = "ResultValue";
            colResult.Name = "colResult";
            colResult.Visible = true;
            colResult.VisibleIndex = 1;
            colResult.Width = 100;
            // 
            // repositoryItemMemoEdit1
            // 
            repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colUnitofMeasure
            // 
            colUnitofMeasure.Caption = "UnitOfMeasure";
            colUnitofMeasure.FieldName = "UnitOfMeasure";
            colUnitofMeasure.Name = "colUnitofMeasure";
            colUnitofMeasure.Visible = true;
            colUnitofMeasure.VisibleIndex = 2;
            colUnitofMeasure.Width = 50;
            // 
            // colReference
            // 
            colReference.Caption = "Reference";
            colReference.FieldName = "ReferenceRange";
            colReference.Name = "colReference";
            colReference.Visible = true;
            colReference.VisibleIndex = 3;
            colReference.Width = 100;
            // 
            // colSymbo
            // 
            colSymbo.Caption = "Symbo";
            colSymbo.ColumnEdit = repositoryItemCheckEdit1;
            colSymbo.FieldName = "IsAbnormal";
            colSymbo.Name = "colSymbo";
            colSymbo.Visible = true;
            colSymbo.VisibleIndex = 4;
            colSymbo.Width = 50;
            // 
            // repositoryItemCheckEdit1
            // 
            repositoryItemCheckEdit1.AutoHeight = false;
            repositoryItemCheckEdit1.AutoWidth = true;
            repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            repositoryItemCheckEdit1.ImageOptions.ImageChecked = (Image)resources.GetObject("repositoryItemCheckEdit1.ImageOptions.ImageChecked");
            repositoryItemCheckEdit1.ImageOptions.ImageGrayed = (Image)resources.GetObject("repositoryItemCheckEdit1.ImageOptions.ImageGrayed");
            repositoryItemCheckEdit1.ImageOptions.ImageUnchecked = (Image)resources.GetObject("repositoryItemCheckEdit1.ImageOptions.ImageUnchecked");
            repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            repositoryItemCheckEdit1.ValueChecked = "H";
            repositoryItemCheckEdit1.ValueGrayed = "N";
            repositoryItemCheckEdit1.ValueUnchecked = "L";
            // 
            // colCritical
            // 
            colCritical.Caption = "CriticalFlage";
            colCritical.ColumnEdit = repositoryItemCheckEdit2;
            colCritical.FieldName = "IsAbnormal";
            colCritical.Name = "colCritical";
            colCritical.Visible = true;
            colCritical.VisibleIndex = 5;
            colCritical.Width = 30;
            // 
            // repositoryItemCheckEdit2
            // 
            repositoryItemCheckEdit2.AutoHeight = false;
            repositoryItemCheckEdit2.AutoWidth = true;
            repositoryItemCheckEdit2.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            repositoryItemCheckEdit2.ImageOptions.ImageChecked = (Image)resources.GetObject("repositoryItemCheckEdit2.ImageOptions.ImageChecked");
            repositoryItemCheckEdit2.ImageOptions.ImageGrayed = (Image)resources.GetObject("repositoryItemCheckEdit2.ImageOptions.ImageGrayed");
            repositoryItemCheckEdit2.ImageOptions.ImageUnchecked = (Image)resources.GetObject("repositoryItemCheckEdit2.ImageOptions.ImageUnchecked");
            repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            repositoryItemCheckEdit2.ValueChecked = "HH";
            repositoryItemCheckEdit2.ValueGrayed = "N";
            repositoryItemCheckEdit2.ValueUnchecked = "LL";
            // 
            // colGroupOrder
            // 
            colGroupOrder.AppearanceCell.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Pixel);
            colGroupOrder.AppearanceCell.ForeColor = Color.FromArgb(242, 248, 255);
            colGroupOrder.Caption = "GroupOrder";
            colGroupOrder.FieldName = "RequestItemUID";
            colGroupOrder.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            colGroupOrder.Name = "colGroupOrder";
            colGroupOrder.OptionsColumn.ShowCaption = false;
            colGroupOrder.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            // 
            // colPrintOrder
            // 
            colPrintOrder.Caption = "PrintOrder";
            colPrintOrder.FieldName = "PrintOrder";
            colPrintOrder.Name = "colPrintOrder";
            colPrintOrder.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            // 
            // colComments
            // 
            colComments.Caption = "Comments";
            colComments.FieldName = "Comments";
            colComments.Name = "colComments";
            colComments.Visible = true;
            colComments.VisibleIndex = 6;
            // 
            // colTime
            // 
            colTime.Caption = "TimeRequest";
            colTime.FieldName = "TimeRequest";
            colTime.Name = "colTime";
            colTime.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            colTime.Visible = true;
            colTime.VisibleIndex = 7;
            colTime.Width = 30;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "IsConfidential";
            gridColumn1.FieldName = "IsConfidential";
            gridColumn1.Name = "gridColumn1";
            // 
            // groupControl8
            // 
            groupControl8.Appearance.Font = new Font("Segoe UI", 9F);
            groupControl8.Appearance.Options.UseFont = true;
            groupControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            groupControl8.Controls.Add(txtZipCode);
            groupControl8.Controls.Add(ddlProvince);
            groupControl8.Controls.Add(label65);
            groupControl8.Controls.Add(label64);
            groupControl8.Controls.Add(txtAddress);
            groupControl8.Controls.Add(label63);
            groupControl8.Dock = DockStyle.Fill;
            groupControl8.Location = new Point(0, 0);
            groupControl8.LookAndFeel.SkinName = "Office 2010 Blue";
            groupControl8.LookAndFeel.UseDefaultLookAndFeel = false;
            groupControl8.Name = "groupControl8";
            groupControl8.ShowCaption = false;
            groupControl8.Size = new Size(1486, 553);
            groupControl8.TabIndex = 0;
            groupControl8.Text = "ที่อยู่สำหรับส่งผลตรวจ";
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(82, 150);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            txtZipCode.Properties.Appearance.Options.UseFont = true;
            txtZipCode.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtZipCode.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtZipCode.Properties.NullValuePrompt = "HN, Name , LastName";
            txtZipCode.Size = new Size(150, 24);
            txtZipCode.TabIndex = 50;
            // 
            // ddlProvince
            // 
            ddlProvince.EditValue = "";
            ddlProvince.Location = new Point(82, 120);
            ddlProvince.Name = "ddlProvince";
            ddlProvince.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            ddlProvince.Properties.Appearance.Options.UseFont = true;
            ddlProvince.Properties.AppearanceDropDown.Font = new Font("Segoe UI", 10F);
            ddlProvince.Properties.AppearanceDropDown.Options.UseFont = true;
            ddlProvince.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlProvince.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlProvince.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlProvince.Properties.NullText = "";
            ddlProvince.Size = new Size(150, 24);
            ddlProvince.TabIndex = 49;
            // 
            // label65
            // 
            label65.AutoSize = true;
            label65.Font = new Font("Segoe UI", 9.75F);
            label65.Location = new Point(4, 154);
            label65.Name = "label65";
            label65.Size = new Size(72, 17);
            label65.TabIndex = 39;
            label65.Text = "รหัสไปรษณีย์";
            label65.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label64
            // 
            label64.AutoSize = true;
            label64.Font = new Font("Segoe UI", 9.75F);
            label64.Location = new Point(4, 123);
            label64.Name = "label64";
            label64.Size = new Size(41, 17);
            label64.TabIndex = 38;
            label64.Text = "จังหวัด";
            label64.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            txtAddress.EditValue = "";
            txtAddress.Location = new Point(10, 25);
            txtAddress.Name = "txtAddress";
            txtAddress.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            txtAddress.Properties.Appearance.Options.UseFont = true;
            txtAddress.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtAddress.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtAddress.Size = new Size(222, 89);
            txtAddress.TabIndex = 37;
            // 
            // label63
            // 
            label63.AutoSize = true;
            label63.Font = new Font("Segoe UI", 9.75F);
            label63.Location = new Point(7, 5);
            label63.Name = "label63";
            label63.Size = new Size(123, 17);
            label63.TabIndex = 31;
            label63.Text = "ที่อยู่ (ไม่ต้องระบุจังหวัด)";
            label63.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupControlPE
            // 
            groupControlPE.Appearance.BackColor = Color.Transparent;
            groupControlPE.Appearance.Font = new Font("Segoe UI", 10F);
            groupControlPE.Appearance.Options.UseBackColor = true;
            groupControlPE.Appearance.Options.UseFont = true;
            groupControlPE.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            groupControlPE.Controls.Add(lblMedicalHistory);
            groupControlPE.Controls.Add(lblRh);
            groupControlPE.Controls.Add(lblABO);
            groupControlPE.Controls.Add(lblBP);
            groupControlPE.Controls.Add(lblRR);
            groupControlPE.Controls.Add(label32);
            groupControlPE.Controls.Add(label33);
            groupControlPE.Controls.Add(label34);
            groupControlPE.Controls.Add(label35);
            groupControlPE.Controls.Add(label36);
            groupControlPE.Controls.Add(lblPluse);
            groupControlPE.Controls.Add(lblTemperature);
            groupControlPE.Controls.Add(lblBMI);
            groupControlPE.Controls.Add(lblShape);
            groupControlPE.Controls.Add(lblWaist);
            groupControlPE.Controls.Add(lblHeight);
            groupControlPE.Controls.Add(lblWeight);
            groupControlPE.Controls.Add(label20);
            groupControlPE.Controls.Add(label21);
            groupControlPE.Controls.Add(label22);
            groupControlPE.Controls.Add(label23);
            groupControlPE.Controls.Add(label24);
            groupControlPE.Controls.Add(label25);
            groupControlPE.Controls.Add(label26);
            groupControlPE.Dock = DockStyle.Fill;
            groupControlPE.Location = new Point(0, 0);
            groupControlPE.LookAndFeel.SkinName = "Office 2010 Blue";
            groupControlPE.LookAndFeel.UseDefaultLookAndFeel = false;
            groupControlPE.Name = "groupControlPE";
            groupControlPE.ShowCaption = false;
            groupControlPE.Size = new Size(1486, 553);
            groupControlPE.TabIndex = 16;
            groupControlPE.Text = "Physical Examination";
            // 
            // lblMedicalHistory
            // 
            lblMedicalHistory.AutoSize = true;
            lblMedicalHistory.Font = new Font("Segoe UI", 10F);
            lblMedicalHistory.Location = new Point(8, 361);
            lblMedicalHistory.Name = "lblMedicalHistory";
            lblMedicalHistory.Size = new Size(15, 19);
            lblMedicalHistory.TabIndex = 37;
            lblMedicalHistory.Text = "-";
            // 
            // lblRh
            // 
            lblRh.AutoSize = true;
            lblRh.Font = new Font("Segoe UI", 10F);
            lblRh.Location = new Point(135, 310);
            lblRh.Name = "lblRh";
            lblRh.Size = new Size(15, 19);
            lblRh.TabIndex = 36;
            lblRh.Text = "-";
            // 
            // lblABO
            // 
            lblABO.AutoSize = true;
            lblABO.Font = new Font("Segoe UI", 10F);
            lblABO.Location = new Point(135, 280);
            lblABO.Name = "lblABO";
            lblABO.Size = new Size(15, 19);
            lblABO.TabIndex = 35;
            lblABO.Text = "-";
            // 
            // lblBP
            // 
            lblBP.AutoSize = true;
            lblBP.Font = new Font("Segoe UI", 10F);
            lblBP.Location = new Point(135, 250);
            lblBP.Name = "lblBP";
            lblBP.Size = new Size(15, 19);
            lblBP.TabIndex = 34;
            lblBP.Text = "-";
            // 
            // lblRR
            // 
            lblRR.AutoSize = true;
            lblRR.Font = new Font("Segoe UI", 10F);
            lblRR.Location = new Point(135, 220);
            lblRR.Name = "lblRR";
            lblRR.Size = new Size(15, 19);
            lblRR.TabIndex = 33;
            lblRR.Text = "-";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 10F);
            label32.Location = new Point(5, 340);
            label32.Name = "label32";
            label32.Size = new Size(104, 19);
            label32.TabIndex = 32;
            label32.Text = "Medical History";
            label32.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 10F);
            label33.Location = new Point(5, 310);
            label33.Name = "label33";
            label33.Size = new Size(87, 19);
            label33.TabIndex = 31;
            label33.Text = "Rh Grouping";
            label33.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 10F);
            label34.Location = new Point(5, 280);
            label34.Name = "label34";
            label34.Size = new Size(99, 19);
            label34.TabIndex = 30;
            label34.Text = "ABO Grouping";
            label34.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 10F);
            label35.Location = new Point(5, 250);
            label35.Name = "label35";
            label35.Size = new Size(25, 19);
            label35.TabIndex = 29;
            label35.Text = "BP";
            label35.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 10F);
            label36.Location = new Point(5, 220);
            label36.Name = "label36";
            label36.Size = new Size(25, 19);
            label36.TabIndex = 28;
            label36.Text = "RR";
            label36.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPluse
            // 
            lblPluse.AutoSize = true;
            lblPluse.Font = new Font("Segoe UI", 10F);
            lblPluse.Location = new Point(135, 184);
            lblPluse.Name = "lblPluse";
            lblPluse.Size = new Size(15, 19);
            lblPluse.TabIndex = 27;
            lblPluse.Text = "-";
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Font = new Font("Segoe UI", 10F);
            lblTemperature.Location = new Point(135, 160);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Size = new Size(15, 19);
            lblTemperature.TabIndex = 26;
            lblTemperature.Text = "-";
            // 
            // lblBMI
            // 
            lblBMI.AutoSize = true;
            lblBMI.Font = new Font("Segoe UI", 10F);
            lblBMI.Location = new Point(136, 70);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(15, 19);
            lblBMI.TabIndex = 25;
            lblBMI.Text = "-";
            // 
            // lblShape
            // 
            lblShape.AutoSize = true;
            lblShape.Font = new Font("Segoe UI", 10F);
            lblShape.Location = new Point(135, 130);
            lblShape.Name = "lblShape";
            lblShape.Size = new Size(15, 19);
            lblShape.TabIndex = 24;
            lblShape.Text = "-";
            // 
            // lblWaist
            // 
            lblWaist.AutoSize = true;
            lblWaist.Font = new Font("Segoe UI", 10F);
            lblWaist.Location = new Point(135, 100);
            lblWaist.Name = "lblWaist";
            lblWaist.Size = new Size(15, 19);
            lblWaist.TabIndex = 23;
            lblWaist.Text = "-";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Segoe UI", 10F);
            lblHeight.Location = new Point(135, 40);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(15, 19);
            lblHeight.TabIndex = 22;
            lblHeight.Text = "-";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 10F);
            lblWeight.Location = new Point(135, 12);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(15, 19);
            lblWeight.TabIndex = 21;
            lblWeight.Text = "-";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F);
            label20.Location = new Point(5, 190);
            label20.Name = "label20";
            label20.Size = new Size(41, 19);
            label20.TabIndex = 20;
            label20.Text = "Pluse";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10F);
            label21.Location = new Point(5, 160);
            label21.Name = "label21";
            label21.Size = new Size(86, 19);
            label21.TabIndex = 19;
            label21.Text = "Temperature";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10F);
            label22.Location = new Point(5, 70);
            label22.Name = "label22";
            label22.Size = new Size(34, 19);
            label22.TabIndex = 18;
            label22.Text = "BMI";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10F);
            label23.Location = new Point(5, 130);
            label23.Name = "label23";
            label23.Size = new Size(46, 19);
            label23.TabIndex = 17;
            label23.Text = "Shape";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10F);
            label24.Location = new Point(5, 100);
            label24.Name = "label24";
            label24.Size = new Size(42, 19);
            label24.TabIndex = 16;
            label24.Text = "Waist";
            label24.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 10F);
            label25.Location = new Point(5, 40);
            label25.Name = "label25";
            label25.Size = new Size(50, 19);
            label25.TabIndex = 15;
            label25.Text = "Height";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 10F);
            label26.Location = new Point(5, 10);
            label26.Name = "label26";
            label26.Size = new Size(52, 19);
            label26.TabIndex = 14;
            label26.Text = "Weight";
            // 
            // dockManager1
            // 
            dockManager1.Controller = barAndDockingController1;
            dockManager1.DockingOptions.ShowCaptionImage = true;
            dockManager1.DockingOptions.ShowCloseButton = false;
            dockManager1.DockingOptions.ShowMaximizeButton = false;
            dockManager1.Form = this;
            dockManager1.Images = imageCollection1;
            dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] { dockPanelPatient, dockPanel2 });
            dockManager1.TopZIndexControls.AddRange(new string[] { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane" });
            // 
            // barAndDockingController1
            // 
            barAndDockingController1.AppearancesBar.Dock.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            barAndDockingController1.AppearancesBar.Dock.Options.UseFont = true;
            barAndDockingController1.AppearancesDocking.ActiveTab.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            barAndDockingController1.AppearancesDocking.ActiveTab.ForeColor = Color.FromArgb(0, 102, 102);
            barAndDockingController1.AppearancesDocking.ActiveTab.Options.UseFont = true;
            barAndDockingController1.AppearancesDocking.ActiveTab.Options.UseForeColor = true;
            barAndDockingController1.AppearancesDocking.FloatFormCaption.Font = new Font("Segoe UI", 9.5F);
            barAndDockingController1.AppearancesDocking.FloatFormCaption.Options.UseFont = true;
            barAndDockingController1.AppearancesDocking.FloatFormCaptionActive.Font = new Font("Segoe UI", 9.5F);
            barAndDockingController1.AppearancesDocking.FloatFormCaptionActive.Options.UseFont = true;
            barAndDockingController1.AppearancesDocking.PanelCaption.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            barAndDockingController1.AppearancesDocking.PanelCaption.ForeColor = Color.FromArgb(0, 102, 102);
            barAndDockingController1.AppearancesDocking.PanelCaption.Options.UseFont = true;
            barAndDockingController1.AppearancesDocking.PanelCaption.Options.UseForeColor = true;
            barAndDockingController1.AppearancesDocking.PanelCaptionActive.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            barAndDockingController1.AppearancesDocking.PanelCaptionActive.ForeColor = Color.FromArgb(0, 102, 102);
            barAndDockingController1.AppearancesDocking.PanelCaptionActive.Options.UseFont = true;
            barAndDockingController1.AppearancesDocking.PanelCaptionActive.Options.UseForeColor = true;
            barAndDockingController1.AppearancesDocking.Tabs.Font = new Font("Segoe UI", 9.5F);
            barAndDockingController1.AppearancesDocking.Tabs.Options.UseFont = true;
            barAndDockingController1.LookAndFeel.SkinName = "Office 2007 Blue";
            barAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = false;
            barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            // 
            // imageCollection1
            // 
            imageCollection1.ImageSize = new Size(24, 24);
            imageCollection1.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("imageCollection1.ImageStream");
            imageCollection1.InsertImage(Resources.scale24px, "scale24px", typeof(Resources), 0);
            imageCollection1.Images.SetKeyName(0, "scale24px");
            imageCollection1.InsertImage(Resources.mailbox32px, "mailbox32px", typeof(Resources), 1);
            imageCollection1.Images.SetKeyName(1, "mailbox32px");
            imageCollection1.InsertImage(Resources.emailsign32px, "emailsign32px", typeof(Resources), 2);
            imageCollection1.Images.SetKeyName(2, "emailsign32px");
            imageCollection1.InsertImage(Resources.icon_Patient, "icon_Patient", typeof(Resources), 3);
            imageCollection1.Images.SetKeyName(3, "icon_Patient");
            imageCollection1.InsertImage(Resources.visible24px, "visible24px", typeof(Resources), 4);
            imageCollection1.Images.SetKeyName(4, "visible24px");
            imageCollection1.InsertImage(Resources.assistivelistening24px, "assistivelistening24px", typeof(Resources), 5);
            imageCollection1.Images.SetKeyName(5, "assistivelistening24px");
            imageCollection1.InsertImage(Resources.tube50px, "tube50px", typeof(Resources), 6);
            imageCollection1.Images.SetKeyName(6, "tube50px");
            imageCollection1.InsertImage(Resources.blood24px, "blood24px", typeof(Resources), 7);
            imageCollection1.Images.SetKeyName(7, "blood24px");
            imageCollection1.InsertImage(Resources.urinaanalysis24px, "urinaanalysis24px", typeof(Resources), 8);
            imageCollection1.Images.SetKeyName(8, "urinaanalysis24px");
            imageCollection1.InsertImage(Resources.stool24px, "stool24px", typeof(Resources), 9);
            imageCollection1.Images.SetKeyName(9, "stool24px");
            imageCollection1.InsertImage(Resources.urine24, "urine24", typeof(Resources), 10);
            imageCollection1.Images.SetKeyName(10, "urine24");
            imageCollection1.InsertImage(Resources.trust50px, "trust50px", typeof(Resources), 11);
            imageCollection1.Images.SetKeyName(11, "trust50px");
            imageCollection1.InsertImage(Resources.xray50px, "xray50px", typeof(Resources), 12);
            imageCollection1.Images.SetKeyName(12, "xray50px");
            imageCollection1.InsertImage(Resources.heart24, "heart24", typeof(Resources), 13);
            imageCollection1.Images.SetKeyName(13, "heart24");
            imageCollection1.InsertImage(Resources.private24, "private24", typeof(Resources), 14);
            imageCollection1.Images.SetKeyName(14, "private24");
            imageCollection1.InsertImage(Resources.doctor50, "doctor50", typeof(Resources), 15);
            imageCollection1.Images.SetKeyName(15, "doctor50");
            imageCollection1.InsertImage(Resources.gears50, "gears50", typeof(Resources), 16);
            imageCollection1.Images.SetKeyName(16, "gears50");
            imageCollection1.InsertImage(Resources.ekg24px, "ekg24px", typeof(Resources), 17);
            imageCollection1.Images.SetKeyName(17, "ekg24px");
            imageCollection1.InsertImage(Resources.healthcheckup32px, "healthcheckup32px", typeof(Resources), 18);
            imageCollection1.Images.SetKeyName(18, "healthcheckup32px");
            imageCollection1.InsertImage(Resources.mentalhealth24px, "mentalhealth24px", typeof(Resources), 19);
            imageCollection1.Images.SetKeyName(19, "mentalhealth24px");
            imageCollection1.InsertImage(Resources.heartpulse32px, "heartpulse32px", typeof(Resources), 20);
            imageCollection1.Images.SetKeyName(20, "heartpulse32px");
            imageCollection1.InsertImage(Resources.tube24px, "tube24px", typeof(Resources), 21);
            imageCollection1.Images.SetKeyName(21, "tube24px");
            imageCollection1.InsertImage(Resources.print24px, "print24px", typeof(Resources), 22);
            imageCollection1.Images.SetKeyName(22, "print24px");
            imageCollection1.InsertImage(Resources.printer_32x32, "printer_32x32", typeof(Resources), 23);
            imageCollection1.Images.SetKeyName(23, "printer_32x32");
            imageCollection1.InsertImage(Resources.usergroup50, "usergroup50", typeof(Resources), 24);
            imageCollection1.Images.SetKeyName(24, "usergroup50");
            // 
            // dockPanelPatient
            // 
            dockPanelPatient.Appearance.BackColor = Color.Transparent;
            dockPanelPatient.Appearance.Options.UseBackColor = true;
            dockPanelPatient.Controls.Add(dockPanel1_Container);
            dockPanelPatient.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            dockPanelPatient.FloatSize = new Size(500, 500);
            dockPanelPatient.FloatVertical = true;
            dockPanelPatient.ID = new Guid("7c1624a7-2909-4f95-a130-7697a7ba4a9b");
            dockPanelPatient.Location = new Point(0, 0);
            dockPanelPatient.Name = "dockPanelPatient";
            dockPanelPatient.Options.ShowAutoHideButton = false;
            dockPanelPatient.Options.ShowCloseButton = false;
            dockPanelPatient.Options.ShowMaximizeButton = false;
            dockPanelPatient.OriginalSize = new Size(200, 140);
            dockPanelPatient.Size = new Size(1492, 140);
            dockPanelPatient.Text = "Patient Information ";
            // 
            // dockPanel1_Container
            // 
            dockPanel1_Container.Controls.Add(label5);
            dockPanel1_Container.Controls.Add(lblReligion);
            dockPanel1_Container.Controls.Add(ribbonClientPanel1);
            dockPanel1_Container.Location = new Point(3, 26);
            dockPanel1_Container.Name = "dockPanel1_Container";
            dockPanel1_Container.Size = new Size(1486, 110);
            dockPanel1_Container.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(309, 62);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 122;
            label5.Text = "Religion :";
            // 
            // lblReligion
            // 
            lblReligion.AutoSize = true;
            lblReligion.BackColor = Color.Transparent;
            lblReligion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblReligion.ForeColor = Color.FromArgb(64, 64, 64);
            lblReligion.Location = new Point(370, 62);
            lblReligion.Name = "lblReligion";
            lblReligion.Size = new Size(13, 17);
            lblReligion.TabIndex = 123;
            lblReligion.Text = "-";
            // 
            // ribbonClientPanel1
            // 
            ribbonClientPanel1.CanvasColor = SystemColors.Control;
            ribbonClientPanel1.Controls.Add(lblPayor);
            ribbonClientPanel1.Controls.Add(label9);
            ribbonClientPanel1.Controls.Add(lblStaffID);
            ribbonClientPanel1.Controls.Add(label3);
            ribbonClientPanel1.Controls.Add(lblVisitDate);
            ribbonClientPanel1.Controls.Add(label8);
            ribbonClientPanel1.Controls.Add(lblVisitNo);
            ribbonClientPanel1.Controls.Add(label7);
            ribbonClientPanel1.Controls.Add(lblDateVN);
            ribbonClientPanel1.Controls.Add(lblVN);
            ribbonClientPanel1.Controls.Add(lblTel);
            ribbonClientPanel1.Controls.Add(label1);
            ribbonClientPanel1.Controls.Add(lblPatientName);
            ribbonClientPanel1.Controls.Add(label4);
            ribbonClientPanel1.Controls.Add(label2);
            ribbonClientPanel1.Controls.Add(label61);
            ribbonClientPanel1.Controls.Add(label62);
            ribbonClientPanel1.Controls.Add(label66);
            ribbonClientPanel1.Controls.Add(label67);
            ribbonClientPanel1.Controls.Add(lblHN);
            ribbonClientPanel1.Controls.Add(lblDOB);
            ribbonClientPanel1.Controls.Add(lblAge);
            ribbonClientPanel1.Controls.Add(lblGender);
            ribbonClientPanel1.Controls.Add(lblIdcard);
            ribbonClientPanel1.Controls.Add(lblNationality);
            ribbonClientPanel1.Controls.Add(pictureEdit1);
            ribbonClientPanel1.Controls.Add(reflectionLabel1);
            ribbonClientPanel1.Dock = DockStyle.Fill;
            ribbonClientPanel1.Location = new Point(0, 0);
            ribbonClientPanel1.Name = "ribbonClientPanel1";
            ribbonClientPanel1.Size = new Size(1486, 110);
            // 
            // 
            // 
            ribbonClientPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.DockSiteBackColor2;
            ribbonClientPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemSeparatorShade;
            ribbonClientPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            ribbonClientPanel1.Style.BorderBottomWidth = 1;
            ribbonClientPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemDisabledText;
            ribbonClientPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            ribbonClientPanel1.Style.BorderLeftWidth = 1;
            ribbonClientPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            ribbonClientPanel1.Style.BorderRightWidth = 1;
            ribbonClientPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            ribbonClientPanel1.Style.BorderTopWidth = 1;
            ribbonClientPanel1.Style.Class = "RibbonClientPanel";
            ribbonClientPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            ribbonClientPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            ribbonClientPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            ribbonClientPanel1.TabIndex = 1;
            // 
            // lblPayor
            // 
            lblPayor.AutoSize = true;
            lblPayor.BackColor = Color.Transparent;
            lblPayor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblPayor.ForeColor = Color.FromArgb(64, 64, 64);
            lblPayor.Location = new Point(730, 85);
            lblPayor.Name = "lblPayor";
            lblPayor.Size = new Size(13, 17);
            lblPayor.TabIndex = 99;
            lblPayor.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.ForeColor = Color.FromArgb(64, 64, 64);
            label9.Location = new Point(663, 85);
            label9.Name = "label9";
            label9.Size = new Size(48, 17);
            label9.TabIndex = 98;
            label9.Text = "Payor :";
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.BackColor = Color.Transparent;
            lblStaffID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblStaffID.ForeColor = Color.FromArgb(64, 64, 64);
            lblStaffID.Location = new Point(730, 40);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(13, 17);
            lblStaffID.TabIndex = 97;
            lblStaffID.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(664, 40);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 96;
            label3.Text = "Emp ID :";
            // 
            // lblVisitDate
            // 
            lblVisitDate.AutoSize = true;
            lblVisitDate.BackColor = Color.Transparent;
            lblVisitDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVisitDate.ForeColor = Color.FromArgb(30, 57, 91);
            lblVisitDate.Location = new Point(477, 85);
            lblVisitDate.Name = "lblVisitDate";
            lblVisitDate.Size = new Size(103, 19);
            lblVisitDate.TabIndex = 95;
            lblVisitDate.Text = "DD/MM/YYYY";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(30, 57, 91);
            label8.Location = new Point(389, 85);
            label8.Name = "label8";
            label8.Size = new Size(80, 19);
            label8.TabIndex = 94;
            label8.Text = "Visit Date :";
            // 
            // lblVisitNo
            // 
            lblVisitNo.AutoSize = true;
            lblVisitNo.BackColor = Color.Transparent;
            lblVisitNo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVisitNo.ForeColor = Color.FromArgb(30, 57, 91);
            lblVisitNo.Location = new Point(210, 85);
            lblVisitNo.Name = "lblVisitNo";
            lblVisitNo.Size = new Size(84, 19);
            lblVisitNo.TabIndex = 93;
            lblVisitNo.Text = "O99999999";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(30, 57, 91);
            label7.Location = new Point(135, 85);
            label7.Name = "label7";
            label7.Size = new Size(65, 19);
            label7.TabIndex = 92;
            label7.Text = "Visit No.";
            // 
            // lblDateVN
            // 
            lblDateVN.AutoSize = true;
            lblDateVN.BackColor = Color.Transparent;
            lblDateVN.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            lblDateVN.ForeColor = Color.SaddleBrown;
            lblDateVN.Location = new Point(1379, 98);
            lblDateVN.Name = "lblDateVN";
            lblDateVN.Size = new Size(0, 19);
            lblDateVN.TabIndex = 87;
            // 
            // lblVN
            // 
            lblVN.AutoSize = true;
            lblVN.BackColor = Color.Transparent;
            lblVN.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            lblVN.ForeColor = Color.SaddleBrown;
            lblVN.Location = new Point(1249, 98);
            lblVN.Name = "lblVN";
            lblVN.Size = new Size(0, 19);
            lblVN.TabIndex = 86;
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.BackColor = Color.Transparent;
            lblTel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblTel.ForeColor = Color.FromArgb(64, 64, 64);
            lblTel.Location = new Point(730, 61);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(13, 17);
            lblTel.TabIndex = 44;
            lblTel.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(664, 61);
            label1.Name = "label1";
            label1.Size = new Size(31, 17);
            label1.TabIndex = 43;
            label1.Text = "Tel :";
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.BackColor = Color.Transparent;
            lblPatientName.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold);
            lblPatientName.ForeColor = Color.FromArgb(30, 57, 91);
            lblPatientName.Location = new Point(135, 9);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(128, 25);
            lblPatientName.TabIndex = 28;
            lblPatientName.Text = "Patient Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(135, 40);
            label4.Name = "label4";
            label4.Size = new Size(41, 17);
            label4.TabIndex = 33;
            label4.Text = "DOB :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(309, 40);
            label2.Name = "label2";
            label2.Size = new Size(38, 17);
            label2.TabIndex = 34;
            label2.Text = "Age :";
            // 
            // label61
            // 
            label61.AutoSize = true;
            label61.BackColor = Color.Transparent;
            label61.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold);
            label61.ForeColor = Color.FromArgb(30, 57, 91);
            label61.Location = new Point(389, 9);
            label61.Name = "label61";
            label61.Size = new Size(50, 25);
            label61.TabIndex = 29;
            label61.Text = "HN :";
            // 
            // label62
            // 
            label62.AutoSize = true;
            label62.BackColor = Color.Transparent;
            label62.Font = new Font("Segoe UI", 9.75F);
            label62.ForeColor = Color.FromArgb(64, 64, 64);
            label62.Location = new Point(479, 62);
            label62.Name = "label62";
            label62.Size = new Size(59, 17);
            label62.TabIndex = 31;
            label62.Text = "ID Card :";
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.BackColor = Color.Transparent;
            label66.Font = new Font("Segoe UI", 9.75F);
            label66.ForeColor = Color.FromArgb(64, 64, 64);
            label66.Location = new Point(135, 61);
            label66.Name = "label66";
            label66.Size = new Size(77, 17);
            label66.TabIndex = 35;
            label66.Text = "Nationality :";
            // 
            // label67
            // 
            label67.AutoSize = true;
            label67.BackColor = Color.Transparent;
            label67.Font = new Font("Segoe UI", 9.75F);
            label67.ForeColor = Color.FromArgb(64, 64, 64);
            label67.Location = new Point(479, 40);
            label67.Name = "label67";
            label67.Size = new Size(35, 17);
            label67.TabIndex = 30;
            label67.Text = "Sex :";
            // 
            // lblHN
            // 
            lblHN.AutoSize = true;
            lblHN.BackColor = Color.Transparent;
            lblHN.Font = new Font("Segoe UI", 13.25F, FontStyle.Bold);
            lblHN.ForeColor = Color.FromArgb(30, 57, 91);
            lblHN.Location = new Point(435, 9);
            lblHN.Name = "lblHN";
            lblHN.Size = new Size(40, 25);
            lblHN.TabIndex = 36;
            lblHN.Text = "HN";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.BackColor = Color.Transparent;
            lblDOB.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblDOB.ForeColor = Color.FromArgb(64, 64, 64);
            lblDOB.Location = new Point(210, 40);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(13, 17);
            lblDOB.TabIndex = 37;
            lblDOB.Text = "-";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.BackColor = Color.Transparent;
            lblAge.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblAge.ForeColor = Color.FromArgb(64, 64, 64);
            lblAge.Location = new Point(370, 40);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(13, 17);
            lblAge.TabIndex = 38;
            lblAge.Text = "-";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Transparent;
            lblGender.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblGender.ForeColor = Color.FromArgb(64, 64, 64);
            lblGender.Location = new Point(523, 40);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(13, 17);
            lblGender.TabIndex = 39;
            lblGender.Text = "-";
            // 
            // lblIdcard
            // 
            lblIdcard.AutoSize = true;
            lblIdcard.BackColor = Color.Transparent;
            lblIdcard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblIdcard.ForeColor = Color.FromArgb(64, 64, 64);
            lblIdcard.Location = new Point(540, 62);
            lblIdcard.Name = "lblIdcard";
            lblIdcard.Size = new Size(13, 17);
            lblIdcard.TabIndex = 41;
            lblIdcard.Text = "-";
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.BackColor = Color.Transparent;
            lblNationality.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblNationality.ForeColor = Color.FromArgb(64, 64, 64);
            lblNationality.Location = new Point(210, 61);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(13, 17);
            lblNationality.TabIndex = 40;
            lblNationality.Text = "-";
            // 
            // pictureEdit1
            // 
            pictureEdit1.Location = new Point(4, 4);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            pictureEdit1.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.Image;
            pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            pictureEdit1.Size = new Size(100, 100);
            pictureEdit1.TabIndex = 1;
            // 
            // reflectionLabel1
            // 
            reflectionLabel1.BackColor = Color.Transparent;
            // 
            // 
            // 
            reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            reflectionLabel1.Dock = DockStyle.Right;
            reflectionLabel1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
            reflectionLabel1.Location = new Point(1036, 0);
            reflectionLabel1.Name = "reflectionLabel1";
            reflectionLabel1.Size = new Size(450, 110);
            reflectionLabel1.TabIndex = 79;
            reflectionLabel1.TabStop = false;
            reflectionLabel1.Text = "<font color=\"#006666\">ศูนย์ตรวจ</font><font color=\"#ef5b23\">สุขภาพ</font>";
            // 
            // dockPanel2
            // 
            dockPanel2.ActiveChild = dockPanelGA;
            dockPanel2.Controls.Add(dockPanelPE);
            dockPanel2.Controls.Add(dockPanelGA);
            dockPanel2.Controls.Add(dockPanelVision);
            dockPanel2.Controls.Add(dockPanelAudiogram);
            dockPanel2.Controls.Add(dockPanelSpecial);
            dockPanel2.Controls.Add(dockPanelCBC);
            dockPanel2.Controls.Add(dockPanelBloodChemistry);
            dockPanel2.Controls.Add(dockPanelUA);
            dockPanel2.Controls.Add(dockPanelStool);
            dockPanel2.Controls.Add(dockPanelStoolCulture);
            dockPanel2.Controls.Add(dockPanelXray);
            dockPanel2.Controls.Add(dockPanelEKG);
            dockPanel2.Controls.Add(dockPanelConfidential);
            dockPanel2.Controls.Add(dockPanelDoctor);
            dockPanel2.Controls.Add(dockPanelAddress);
            dockPanel2.Controls.Add(dockPanelReference);
            dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanel2.FloatVertical = true;
            dockPanel2.ID = new Guid("bd3af0d1-ec3b-4ae9-b77d-5901f1901f46");
            dockPanel2.ImageOptions.ImageIndex = 0;
            dockPanel2.Location = new Point(0, 140);
            dockPanel2.Name = "dockPanel2";
            dockPanel2.OriginalSize = new Size(800, 400);
            dockPanel2.Size = new Size(1492, 623);
            dockPanel2.Tabbed = true;
            dockPanel2.Text = "panelContainer1";
            // 
            // dockPanelGA
            // 
            dockPanelGA.AutoScroll = true;
            dockPanelGA.Controls.Add(controlContainer1);
            dockPanelGA.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanelGA.FloatVertical = true;
            dockPanelGA.ID = new Guid("0db32032-ade3-4b11-b187-8f7bf8ee1972");
            dockPanelGA.ImageOptions.ImageIndex = 0;
            dockPanelGA.Location = new Point(3, 32);
            dockPanelGA.Name = "dockPanelGA";
            dockPanelGA.OriginalSize = new Size(200, 200);
            dockPanelGA.Size = new Size(1486, 553);
            dockPanelGA.TabText = "GA : General Appearance";
            dockPanelGA.Text = "General Appearance";
            // 
            // controlContainer1
            // 
            controlContainer1.Controls.Add(pnPE);
            controlContainer1.Controls.Add(pnButton);
            controlContainer1.Location = new Point(0, 0);
            controlContainer1.Name = "controlContainer1";
            controlContainer1.Size = new Size(1486, 553);
            controlContainer1.TabIndex = 0;
            // 
            // pnButton
            // 
            pnButton.Appearance.BackColor = SystemColors.ActiveCaption;
            pnButton.Appearance.Options.UseBackColor = true;
            pnButton.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pnButton.Controls.Add(cmdPrintResultStudent);
            pnButton.Controls.Add(panel9);
            pnButton.Controls.Add(cmdPrintResultNew);
            pnButton.Controls.Add(cmdPrintResultOld);
            pnButton.Controls.Add(cmdPrintResultBookCover);
            pnButton.Controls.Add(cmdTempSave);
            pnButton.Controls.Add(cmdFinalize);
            pnButton.Controls.Add(cmdPrintResultBook);
            pnButton.Dock = DockStyle.Bottom;
            pnButton.Location = new Point(0, 494);
            pnButton.LookAndFeel.SkinName = "Office 2010 Blue";
            pnButton.LookAndFeel.UseDefaultLookAndFeel = false;
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(1486, 59);
            pnButton.TabIndex = 110;
            // 
            // cmdPrintResultStudent
            // 
            cmdPrintResultStudent.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cmdPrintResultStudent.Appearance.ForeColor = Color.White;
            cmdPrintResultStudent.Appearance.Options.UseFont = true;
            cmdPrintResultStudent.Appearance.Options.UseForeColor = true;
            cmdPrintResultStudent.ImageOptions.Image = (Image)resources.GetObject("cmdPrintResultStudent.ImageOptions.Image");
            cmdPrintResultStudent.Location = new Point(939, 4);
            cmdPrintResultStudent.LookAndFeel.SkinMaskColor = Color.HotPink;
            cmdPrintResultStudent.LookAndFeel.SkinName = "DevExpress Dark Style";
            cmdPrintResultStudent.LookAndFeel.UseDefaultLookAndFeel = false;
            cmdPrintResultStudent.Name = "cmdPrintResultStudent";
            cmdPrintResultStudent.Size = new Size(270, 27);
            cmdPrintResultStudent.TabIndex = 21;
            cmdPrintResultStudent.Text = "ใบรายงานผลตรวจก่อนเข้างาน/เข้าเรียน";
            cmdPrintResultStudent.Click += cmdPrintResultStudent_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(cmdAdminSave);
            panel9.Controls.Add(cmdClose);
            panel9.Dock = DockStyle.Right;
            panel9.Location = new Point(1243, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(243, 59);
            panel9.TabIndex = 20;
            // 
            // cmdAdminSave
            // 
            cmdAdminSave.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cmdAdminSave.Appearance.ForeColor = Color.White;
            cmdAdminSave.Appearance.Options.UseFont = true;
            cmdAdminSave.Appearance.Options.UseForeColor = true;
            cmdAdminSave.ImageOptions.Image = (Image)resources.GetObject("cmdAdminSave.ImageOptions.Image");
            cmdAdminSave.Location = new Point(17, 4);
            cmdAdminSave.LookAndFeel.SkinMaskColor = SystemColors.HotTrack;
            cmdAdminSave.LookAndFeel.SkinName = "DevExpress Dark Style";
            cmdAdminSave.LookAndFeel.UseDefaultLookAndFeel = false;
            cmdAdminSave.Name = "cmdAdminSave";
            cmdAdminSave.Size = new Size(113, 27);
            cmdAdminSave.TabIndex = 18;
            cmdAdminSave.Text = "Admin Save";
            cmdAdminSave.Visible = false;
            cmdAdminSave.Click += cmdAdminSave_Click;
            // 
            // cmdClose
            // 
            cmdClose.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cmdClose.Appearance.ForeColor = Color.White;
            cmdClose.Appearance.Options.UseFont = true;
            cmdClose.Appearance.Options.UseForeColor = true;
            cmdClose.ImageOptions.Image = (Image)resources.GetObject("cmdClose.ImageOptions.Image");
            cmdClose.Location = new Point(136, 4);
            cmdClose.LookAndFeel.SkinMaskColor = SystemColors.ActiveCaption;
            cmdClose.LookAndFeel.SkinName = "DevExpress Dark Style";
            cmdClose.LookAndFeel.UseDefaultLookAndFeel = false;
            cmdClose.Name = "cmdClose";
            cmdClose.Size = new Size(100, 27);
            cmdClose.TabIndex = 14;
            cmdClose.Text = "Close";
            cmdClose.Click += cmdClose_Click;
            // 
            // cmdPrintResultNew
            // 
            cmdPrintResultNew.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cmdPrintResultNew.Appearance.ForeColor = Color.White;
            cmdPrintResultNew.Appearance.Options.UseFont = true;
            cmdPrintResultNew.Appearance.Options.UseForeColor = true;
            cmdPrintResultNew.ImageOptions.Image = (Image)resources.GetObject("cmdPrintResultNew.ImageOptions.Image");
            cmdPrintResultNew.Location = new Point(394, 4);
            cmdPrintResultNew.LookAndFeel.SkinMaskColor = Color.SteelBlue;
            cmdPrintResultNew.LookAndFeel.SkinName = "DevExpress Dark Style";
            cmdPrintResultNew.LookAndFeel.UseDefaultLookAndFeel = false;
            cmdPrintResultNew.Name = "cmdPrintResultNew";
            cmdPrintResultNew.Size = new Size(200, 27);
            cmdPrintResultNew.TabIndex = 17;
            cmdPrintResultNew.Text = "ใบรายงานผล A4 (แบบใหม่)";
            cmdPrintResultNew.Click += cmdPrintResultNew_Click;
            // 
            // cmdPrintResultOld
            // 
            cmdPrintResultOld.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cmdPrintResultOld.Appearance.ForeColor = Color.White;
            cmdPrintResultOld.Appearance.Options.UseFont = true;
            cmdPrintResultOld.Appearance.Options.UseForeColor = true;
            cmdPrintResultOld.ImageOptions.Image = (Image)resources.GetObject("cmdPrintResultOld.ImageOptions.Image");
            cmdPrintResultOld.Location = new Point(218, 4);
            cmdPrintResultOld.LookAndFeel.SkinMaskColor = Color.SteelBlue;
            cmdPrintResultOld.LookAndFeel.SkinName = "DevExpress Dark Style";
            cmdPrintResultOld.LookAndFeel.UseDefaultLookAndFeel = false;
            cmdPrintResultOld.Name = "cmdPrintResultOld";
            cmdPrintResultOld.Size = new Size(170, 27);
            cmdPrintResultOld.TabIndex = 15;
            cmdPrintResultOld.Text = "ใบรายงานผล (แบบเก่า)";
            cmdPrintResultOld.Click += cmdPrintReportOld_Click;
            // 
            // cmdPrintResultBookCover
            // 
            cmdPrintResultBookCover.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cmdPrintResultBookCover.Appearance.ForeColor = Color.White;
            cmdPrintResultBookCover.Appearance.Options.UseFont = true;
            cmdPrintResultBookCover.Appearance.Options.UseForeColor = true;
            cmdPrintResultBookCover.ImageOptions.Image = (Image)resources.GetObject("cmdPrintResultBookCover.ImageOptions.Image");
            cmdPrintResultBookCover.Location = new Point(783, 4);
            cmdPrintResultBookCover.LookAndFeel.SkinMaskColor = Color.FromArgb(0, 102, 102);
            cmdPrintResultBookCover.LookAndFeel.SkinName = "DevExpress Dark Style";
            cmdPrintResultBookCover.LookAndFeel.UseDefaultLookAndFeel = false;
            cmdPrintResultBookCover.Name = "cmdPrintResultBookCover";
            cmdPrintResultBookCover.Size = new Size(150, 27);
            cmdPrintResultBookCover.TabIndex = 16;
            cmdPrintResultBookCover.Text = "ปกสมุดรายงานผล";
            cmdPrintResultBookCover.Click += cmdPrintResultBookCover_Click;
            // 
            // dockPanelPE
            // 
            dockPanelPE.AutoScroll = true;
            dockPanelPE.Controls.Add(dockPanel2_Container);
            dockPanelPE.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanelPE.ForeColor = Color.FromArgb(30, 57, 91);
            dockPanelPE.ID = new Guid("f2b40895-697e-4354-9d5b-f1bb9927b367");
            dockPanelPE.ImageOptions.ImageIndex = 0;
            dockPanelPE.Location = new Point(3, 32);
            dockPanelPE.Name = "dockPanelPE";
            dockPanelPE.OriginalSize = new Size(200, 200);
            dockPanelPE.Size = new Size(1486, 553);
            dockPanelPE.TabsScroll = true;
            dockPanelPE.TabText = " ";
            dockPanelPE.Text = "Physical Examination";
            // 
            // dockPanel2_Container
            // 
            dockPanel2_Container.Controls.Add(groupControlPE);
            dockPanel2_Container.Location = new Point(0, 0);
            dockPanel2_Container.Name = "dockPanel2_Container";
            dockPanel2_Container.Size = new Size(1486, 553);
            dockPanel2_Container.TabIndex = 0;
            // 
            // dockPanelVision
            // 
            dockPanelVision.Controls.Add(controlContainer2);
            dockPanelVision.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanelVision.FloatVertical = true;
            dockPanelVision.ID = new Guid("929c8e5a-134f-4b65-b8e3-a4ddb525a630");
            dockPanelVision.ImageOptions.ImageIndex = 4;
            dockPanelVision.Location = new Point(3, 32);
            dockPanelVision.Name = "dockPanelVision";
            dockPanelVision.OriginalSize = new Size(200, 200);
            dockPanelVision.Size = new Size(1486, 553);
            dockPanelVision.Text = "Vision Screening";
            // 
            // controlContainer2
            // 
            controlContainer2.Controls.Add(pnVision);
            controlContainer2.Location = new Point(0, 0);
            controlContainer2.Name = "controlContainer2";
            controlContainer2.Size = new Size(1486, 553);
            controlContainer2.TabIndex = 0;
            // 
            // dockPanelAudiogram
            // 
            dockPanelAudiogram.Controls.Add(controlContainer3);
            dockPanelAudiogram.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanelAudiogram.FloatVertical = true;
            dockPanelAudiogram.ID = new Guid("c5a92755-e6ff-44f6-a655-d7721abf37d7");
            dockPanelAudiogram.Location = new Point(3, 32);
            dockPanelAudiogram.Name = "dockPanelAudiogram";
            dockPanelAudiogram.OriginalSize = new Size(200, 200);
            dockPanelAudiogram.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanelAudiogram.SavedIndex = 1;
            dockPanelAudiogram.SavedTabbed = true;
            dockPanelAudiogram.Size = new Size(1486, 553);
            dockPanelAudiogram.Text = "Audiogram";
            // 
            // controlContainer3
            // 
            controlContainer3.Controls.Add(pnAudio);
            controlContainer3.Location = new Point(0, 0);
            controlContainer3.Name = "controlContainer3";
            controlContainer3.Size = new Size(1486, 553);
            controlContainer3.TabIndex = 0;
            // 
            // dockPanelSpecial
            // 
            dockPanelSpecial.Controls.Add(dockPanel8_Container);
            dockPanelSpecial.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanelSpecial.FloatVertical = true;
            dockPanelSpecial.ID = new Guid("6d664e83-6600-4d53-9fbd-29542cb6757c");
            dockPanelSpecial.Location = new Point(3, 32);
            dockPanelSpecial.Name = "dockPanelSpecial";
            dockPanelSpecial.OriginalSize = new Size(200, 200);
            dockPanelSpecial.Size = new Size(1486, 553);
            dockPanelSpecial.TabText = "Special Test";
            dockPanelSpecial.Text = "Special and Other Test";
            // 
            // dockPanel8_Container
            // 
            dockPanel8_Container.Controls.Add(pnSpecial);
            dockPanel8_Container.Location = new Point(0, 0);
            dockPanel8_Container.Name = "dockPanel8_Container";
            dockPanel8_Container.Size = new Size(1486, 553);
            dockPanel8_Container.TabIndex = 0;
            // 
            // dockPanelCBC
            // 
            dockPanelCBC.Controls.Add(dockPanel12_Container);
            dockPanelCBC.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanelCBC.ID = new Guid("baedc693-b7e1-481b-ac95-53c6a2efec8c");
            dockPanelCBC.Location = new Point(3, 32);
            dockPanelCBC.Name = "dockPanelCBC";
            dockPanelCBC.OriginalSize = new Size(200, 200);
            dockPanelCBC.Size = new Size(1486, 553);
            dockPanelCBC.TabText = "CBC";
            dockPanelCBC.Text = "Complete Blood Count";
            // 
            // dockPanel12_Container
            // 
            dockPanel12_Container.Controls.Add(pnCBC2);
            dockPanel12_Container.Controls.Add(pnCBC);
            dockPanel12_Container.Location = new Point(0, 0);
            dockPanel12_Container.Name = "dockPanel12_Container";
            dockPanel12_Container.Size = new Size(1486, 553);
            dockPanel12_Container.TabIndex = 0;
            // 
            // dockPanelBloodChemistry
            // 
            dockPanelBloodChemistry.Controls.Add(dockPanel3_Container);
            dockPanelBloodChemistry.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanelBloodChemistry.ID = new Guid("22442e85-616e-477e-a19b-9cc105e01364");
            dockPanelBloodChemistry.Location = new Point(3, 32);
            dockPanelBloodChemistry.Name = "dockPanelBloodChemistry";
            dockPanelBloodChemistry.OriginalSize = new Size(200, 200);
            dockPanelBloodChemistry.Size = new Size(1486, 553);
            dockPanelBloodChemistry.Text = "Blood Chemistry";
            // 
            // dockPanel3_Container
            // 
            dockPanel3_Container.Controls.Add(pnBloodChem);
            dockPanel3_Container.Location = new Point(0, 0);
            dockPanel3_Container.Name = "dockPanel3_Container";
            dockPanel3_Container.Size = new Size(1486, 553);
            dockPanel3_Container.TabIndex = 0;
            // 
            // dockPanelUA
            // 
            dockPanelUA.Controls.Add(dockPanel11_Container);
            dockPanelUA.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanelUA.ID = new Guid("0b147ea2-9177-4aa6-a5ca-2e40e05316d6");
            dockPanelUA.Location = new Point(3, 32);
            dockPanelUA.Name = "dockPanelUA";
            dockPanelUA.OriginalSize = new Size(200, 200);
            dockPanelUA.Size = new Size(1486, 553);
            dockPanelUA.TabText = "UA";
            dockPanelUA.Text = "Urine Analysis";
            // 
            // dockPanel11_Container
            // 
            dockPanel11_Container.Controls.Add(panel10);
            dockPanel11_Container.Controls.Add(pnUA);
            dockPanel11_Container.Location = new Point(0, 0);
            dockPanel11_Container.Name = "dockPanel11_Container";
            dockPanel11_Container.Size = new Size(1486, 553);
            dockPanel11_Container.TabIndex = 0;
            // 
            // dockPanelStool
            // 
            dockPanelStool.Controls.Add(dockPanel10_Container);
            dockPanelStool.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanelStool.ID = new Guid("832f2e6b-9f35-4fd2-b5ba-388be0c00b72");
            dockPanelStool.Location = new Point(3, 32);
            dockPanelStool.Name = "dockPanelStool";
            dockPanelStool.OriginalSize = new Size(200, 200);
            dockPanelStool.Size = new Size(1486, 553);
            dockPanelStool.Text = "Stool Examination";
            // 
            // dockPanel10_Container
            // 
            dockPanel10_Container.Controls.Add(pnStool2);
            dockPanel10_Container.Controls.Add(pnStool);
            dockPanel10_Container.Location = new Point(0, 0);
            dockPanel10_Container.Name = "dockPanel10_Container";
            dockPanel10_Container.Size = new Size(1486, 553);
            dockPanel10_Container.TabIndex = 0;
            // 
            // dockPanelStoolCulture
            // 
            dockPanelStoolCulture.Controls.Add(dockPanel9_Container);
            dockPanelStoolCulture.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanelStoolCulture.ID = new Guid("6c6b3e31-34b4-4cd3-837a-667af4d03601");
            dockPanelStoolCulture.Location = new Point(3, 32);
            dockPanelStoolCulture.Name = "dockPanelStoolCulture";
            dockPanelStoolCulture.OriginalSize = new Size(200, 200);
            dockPanelStoolCulture.Size = new Size(1486, 553);
            dockPanelStoolCulture.Text = "Stool Culture and Sensitivity";
            // 
            // dockPanel9_Container
            // 
            dockPanel9_Container.Controls.Add(pnStoolCulture);
            dockPanel9_Container.Location = new Point(0, 0);
            dockPanel9_Container.Name = "dockPanel9_Container";
            dockPanel9_Container.Size = new Size(1486, 553);
            dockPanel9_Container.TabIndex = 0;
            // 
            // dockPanelXray
            // 
            dockPanelXray.Controls.Add(dockPanel7_Container);
            dockPanelXray.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanelXray.FloatVertical = true;
            dockPanelXray.ID = new Guid("9c71f687-39c8-4669-b47d-f5fa9e493eb0");
            dockPanelXray.Location = new Point(3, 32);
            dockPanelXray.Name = "dockPanelXray";
            dockPanelXray.OriginalSize = new Size(200, 200);
            dockPanelXray.Size = new Size(1486, 553);
            dockPanelXray.TabText = "X-ray";
            dockPanelXray.Text = "ผลการตรวจทางรังสี (X-ray , Ultrasound)";
            // 
            // dockPanel7_Container
            // 
            dockPanel7_Container.Controls.Add(pnXray);
            dockPanel7_Container.Location = new Point(0, 0);
            dockPanel7_Container.Name = "dockPanel7_Container";
            dockPanel7_Container.Size = new Size(1486, 553);
            dockPanel7_Container.TabIndex = 0;
            // 
            // dockPanelEKG
            // 
            dockPanelEKG.Controls.Add(dockPanel6_Container);
            dockPanelEKG.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanelEKG.ID = new Guid("062dd343-1c82-4ac1-865d-9959112f3e10");
            dockPanelEKG.Location = new Point(3, 32);
            dockPanelEKG.Name = "dockPanelEKG";
            dockPanelEKG.OriginalSize = new Size(200, 200);
            dockPanelEKG.Size = new Size(1486, 553);
            dockPanelEKG.TabText = "เฉพาะด้านอื่นๆ";
            dockPanelEKG.Text = "ผลการตรวจเฉพาะด้านอื่นๆ (EKG , BMD , EST , ABI , สูตินารีฯ)";
            // 
            // dockPanel6_Container
            // 
            dockPanel6_Container.Controls.Add(pnTechnicOther);
            dockPanel6_Container.Location = new Point(0, 0);
            dockPanel6_Container.Name = "dockPanel6_Container";
            dockPanel6_Container.Size = new Size(1486, 553);
            dockPanel6_Container.TabIndex = 0;
            // 
            // dockPanelConfidential
            // 
            dockPanelConfidential.Controls.Add(controlContainer5);
            dockPanelConfidential.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanelConfidential.FloatVertical = true;
            dockPanelConfidential.ID = new Guid("4d8e431f-9397-463f-9a8e-287cf4cde1fc");
            dockPanelConfidential.Location = new Point(3, 32);
            dockPanelConfidential.Name = "dockPanelConfidential";
            dockPanelConfidential.OriginalSize = new Size(200, 200);
            dockPanelConfidential.Size = new Size(1486, 553);
            dockPanelConfidential.TabText = "Confidential";
            dockPanelConfidential.Text = "Confidential";
            // 
            // controlContainer5
            // 
            controlContainer5.Controls.Add(pnConfidential);
            controlContainer5.Location = new Point(0, 0);
            controlContainer5.Name = "controlContainer5";
            controlContainer5.Size = new Size(1486, 553);
            controlContainer5.TabIndex = 0;
            // 
            // pnConfidential
            // 
            pnConfidential.BackColor = Color.White;
            pnConfidential.Controls.Add(grdConfidential);
            pnConfidential.Dock = DockStyle.Fill;
            pnConfidential.Location = new Point(0, 0);
            pnConfidential.Name = "pnConfidential";
            pnConfidential.Size = new Size(1486, 553);
            pnConfidential.TabIndex = 122;
            // 
            // grdConfidential
            // 
            grdConfidential.Location = new Point(0, 0);
            grdConfidential.LookAndFeel.SkinName = "Office 2010 Blue";
            grdConfidential.LookAndFeel.UseDefaultLookAndFeel = false;
            grdConfidential.MainView = grdViewConfidential;
            grdConfidential.Name = "grdConfidential";
            grdConfidential.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemMemoEdit8, repositoryItemCheckEdit15, repositoryItemCheckEdit16 });
            grdConfidential.Size = new Size(1219, 559);
            grdConfidential.TabIndex = 7;
            grdConfidential.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { grdViewConfidential });
            // 
            // grdViewConfidential
            // 
            grdViewConfidential.Appearance.GroupRow.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grdViewConfidential.Appearance.GroupRow.Options.UseFont = true;
            grdViewConfidential.Appearance.HeaderPanel.Options.UseTextOptions = true;
            grdViewConfidential.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            grdViewConfidential.Appearance.Row.Font = new Font("Segoe UI", 10F);
            grdViewConfidential.Appearance.Row.Options.UseFont = true;
            grdViewConfidential.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            grdViewConfidential.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn55, gridColumn56, gridColumn57, gridColumn58, gridColumn59, gridColumn60, gridColumn61, gridColumn62, gridColumn63 });
            grdViewConfidential.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            grdViewConfidential.GridControl = grdConfidential;
            grdViewConfidential.GroupCount = 1;
            grdViewConfidential.GroupFormat = "[#image]{1} {2}";
            grdViewConfidential.Name = "grdViewConfidential";
            grdViewConfidential.OptionsBehavior.AutoExpandAllGroups = true;
            grdViewConfidential.OptionsBehavior.Editable = false;
            grdViewConfidential.OptionsDetail.EnableMasterViewMode = false;
            grdViewConfidential.OptionsView.ColumnAutoWidth = false;
            grdViewConfidential.OptionsView.RowAutoHeight = true;
            grdViewConfidential.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            grdViewConfidential.OptionsView.ShowGroupPanel = false;
            grdViewConfidential.OptionsView.ShowIndicator = false;
            grdViewConfidential.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            grdViewConfidential.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(gridColumn63, DevExpress.Data.ColumnSortOrder.Ascending) });
            // 
            // gridColumn55
            // 
            gridColumn55.Caption = "Test";
            gridColumn55.FieldName = "ResultItemName";
            gridColumn55.Name = "gridColumn55";
            gridColumn55.Visible = true;
            gridColumn55.VisibleIndex = 0;
            gridColumn55.Width = 240;
            // 
            // gridColumn56
            // 
            gridColumn56.AppearanceCell.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gridColumn56.AppearanceCell.Options.UseFont = true;
            gridColumn56.AppearanceCell.Options.UseTextOptions = true;
            gridColumn56.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn56.Caption = "Result";
            gridColumn56.ColumnEdit = repositoryItemMemoEdit8;
            gridColumn56.FieldName = "ResultValue";
            gridColumn56.Name = "gridColumn56";
            gridColumn56.Visible = true;
            gridColumn56.VisibleIndex = 1;
            gridColumn56.Width = 120;
            // 
            // repositoryItemMemoEdit8
            // 
            repositoryItemMemoEdit8.Name = "repositoryItemMemoEdit8";
            // 
            // gridColumn57
            // 
            gridColumn57.AppearanceCell.Options.UseTextOptions = true;
            gridColumn57.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn57.Caption = "UOM";
            gridColumn57.FieldName = "UnitOfMeasure";
            gridColumn57.Name = "gridColumn57";
            gridColumn57.Visible = true;
            gridColumn57.VisibleIndex = 2;
            gridColumn57.Width = 120;
            // 
            // gridColumn58
            // 
            gridColumn58.AppearanceCell.Options.UseTextOptions = true;
            gridColumn58.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridColumn58.Caption = "Reference";
            gridColumn58.FieldName = "ReferenceRange";
            gridColumn58.Name = "gridColumn58";
            gridColumn58.Visible = true;
            gridColumn58.VisibleIndex = 3;
            gridColumn58.Width = 100;
            // 
            // gridColumn59
            // 
            gridColumn59.ColumnEdit = repositoryItemCheckEdit15;
            gridColumn59.FieldName = "IsAbnormal";
            gridColumn59.Name = "gridColumn59";
            gridColumn59.OptionsColumn.ShowCaption = false;
            gridColumn59.Visible = true;
            gridColumn59.VisibleIndex = 4;
            gridColumn59.Width = 20;
            // 
            // repositoryItemCheckEdit15
            // 
            repositoryItemCheckEdit15.AutoHeight = false;
            repositoryItemCheckEdit15.AutoWidth = true;
            repositoryItemCheckEdit15.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            repositoryItemCheckEdit15.ImageOptions.ImageChecked = (Image)resources.GetObject("repositoryItemCheckEdit15.ImageOptions.ImageChecked");
            repositoryItemCheckEdit15.ImageOptions.ImageGrayed = (Image)resources.GetObject("repositoryItemCheckEdit15.ImageOptions.ImageGrayed");
            repositoryItemCheckEdit15.ImageOptions.ImageUnchecked = (Image)resources.GetObject("repositoryItemCheckEdit15.ImageOptions.ImageUnchecked");
            repositoryItemCheckEdit15.Name = "repositoryItemCheckEdit15";
            repositoryItemCheckEdit15.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            repositoryItemCheckEdit15.ValueChecked = "H";
            repositoryItemCheckEdit15.ValueGrayed = "N";
            repositoryItemCheckEdit15.ValueUnchecked = "L";
            // 
            // gridColumn60
            // 
            gridColumn60.ColumnEdit = repositoryItemCheckEdit16;
            gridColumn60.FieldName = "IsAbnormal";
            gridColumn60.Name = "gridColumn60";
            gridColumn60.OptionsColumn.ShowCaption = false;
            gridColumn60.Visible = true;
            gridColumn60.VisibleIndex = 5;
            gridColumn60.Width = 20;
            // 
            // repositoryItemCheckEdit16
            // 
            repositoryItemCheckEdit16.AutoHeight = false;
            repositoryItemCheckEdit16.AutoWidth = true;
            repositoryItemCheckEdit16.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            repositoryItemCheckEdit16.ImageOptions.ImageChecked = (Image)resources.GetObject("repositoryItemCheckEdit16.ImageOptions.ImageChecked");
            repositoryItemCheckEdit16.ImageOptions.ImageGrayed = (Image)resources.GetObject("repositoryItemCheckEdit16.ImageOptions.ImageGrayed");
            repositoryItemCheckEdit16.ImageOptions.ImageUnchecked = (Image)resources.GetObject("repositoryItemCheckEdit16.ImageOptions.ImageUnchecked");
            repositoryItemCheckEdit16.Name = "repositoryItemCheckEdit16";
            repositoryItemCheckEdit16.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            repositoryItemCheckEdit16.ValueChecked = "HH";
            repositoryItemCheckEdit16.ValueGrayed = "N";
            repositoryItemCheckEdit16.ValueUnchecked = "LL";
            // 
            // gridColumn61
            // 
            gridColumn61.Caption = "PrintOrder";
            gridColumn61.FieldName = "PrintOrder";
            gridColumn61.Name = "gridColumn61";
            gridColumn61.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            // 
            // gridColumn62
            // 
            gridColumn62.Caption = "Comment";
            gridColumn62.FieldName = "Comment";
            gridColumn62.Name = "gridColumn62";
            gridColumn62.Visible = true;
            gridColumn62.VisibleIndex = 6;
            gridColumn62.Width = 170;
            // 
            // gridColumn63
            // 
            gridColumn63.Caption = "CheckupGroupName";
            gridColumn63.FieldName = "CheckupGroupName";
            gridColumn63.Name = "gridColumn63";
            gridColumn63.Visible = true;
            gridColumn63.VisibleIndex = 7;
            // 
            // dockPanelDoctor
            // 
            dockPanelDoctor.AutoScroll = true;
            dockPanelDoctor.Controls.Add(controlContainer4);
            dockPanelDoctor.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanelDoctor.FloatSize = new Size(500, 500);
            dockPanelDoctor.ID = new Guid("ea5ad446-345b-45ec-8897-70de7cce686a");
            dockPanelDoctor.Location = new Point(3, 32);
            dockPanelDoctor.Name = "dockPanelDoctor";
            dockPanelDoctor.OriginalSize = new Size(200, 200);
            dockPanelDoctor.Size = new Size(1486, 553);
            dockPanelDoctor.Text = "สรุปผลการตรวจสุขภาพและข้อเสนอแนะของแพทย์";
            // 
            // controlContainer4
            // 
            controlContainer4.Controls.Add(panel1);
            controlContainer4.Controls.Add(pnDoctorSummary);
            controlContainer4.Location = new Point(0, 0);
            controlContainer4.Name = "controlContainer4";
            controlContainer4.Size = new Size(1486, 553);
            controlContainer4.TabIndex = 0;
            // 
            // dockPanelAddress
            // 
            dockPanelAddress.Controls.Add(dockPanel4_Container);
            dockPanelAddress.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanelAddress.FloatVertical = true;
            dockPanelAddress.ForeColor = Color.FromArgb(30, 57, 91);
            dockPanelAddress.ID = new Guid("d51b4a65-2edf-4beb-bad7-4675c842ead5");
            dockPanelAddress.Location = new Point(3, 32);
            dockPanelAddress.Name = "dockPanelAddress";
            dockPanelAddress.OriginalSize = new Size(200, 200);
            dockPanelAddress.Size = new Size(1486, 553);
            dockPanelAddress.TabText = " ";
            dockPanelAddress.Text = "ที่อยู่สำหรับส่งผลตรวจ";
            // 
            // dockPanel4_Container
            // 
            dockPanel4_Container.Controls.Add(groupControl8);
            dockPanel4_Container.Location = new Point(0, 0);
            dockPanel4_Container.Name = "dockPanel4_Container";
            dockPanel4_Container.Size = new Size(1486, 553);
            dockPanel4_Container.TabIndex = 0;
            // 
            // dockPanelReference
            // 
            dockPanelReference.Controls.Add(dockPanel5_Container);
            dockPanelReference.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            dockPanelReference.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Italic);
            dockPanelReference.ID = new Guid("773a4c49-6045-4f7b-b620-9845b530cb23");
            dockPanelReference.Location = new Point(3, 32);
            dockPanelReference.Name = "dockPanelReference";
            dockPanelReference.OriginalSize = new Size(200, 200);
            dockPanelReference.Size = new Size(1486, 553);
            dockPanelReference.TabText = " ";
            dockPanelReference.Text = "Reference Info.";
            // 
            // dockPanel5_Container
            // 
            dockPanel5_Container.Controls.Add(groupControl2);
            dockPanel5_Container.Location = new Point(0, 0);
            dockPanel5_Container.Name = "dockPanel5_Container";
            dockPanel5_Container.Size = new Size(1486, 553);
            dockPanel5_Container.TabIndex = 0;
            // 
            // groupControl2
            // 
            groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            groupControl2.Controls.Add(lblVisitNumber);
            groupControl2.Controls.Add(lblUpdBy);
            groupControl2.Controls.Add(lblLastUpd);
            groupControl2.Controls.Add(label68);
            groupControl2.Controls.Add(label27);
            groupControl2.Controls.Add(lblDocumentStatus);
            groupControl2.Controls.Add(label12);
            groupControl2.Controls.Add(label19);
            groupControl2.Controls.Add(lblPatientVisitUID);
            groupControl2.Controls.Add(label11);
            groupControl2.Controls.Add(lblPatientUID);
            groupControl2.Dock = DockStyle.Fill;
            groupControl2.Location = new Point(0, 0);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(1486, 553);
            groupControl2.TabIndex = 115;
            groupControl2.Text = "groupControl2";
            // 
            // lblVisitNumber
            // 
            lblVisitNumber.AutoSize = true;
            lblVisitNumber.Font = new Font("Segoe UI", 9.75F);
            lblVisitNumber.Location = new Point(126, 13);
            lblVisitNumber.Name = "lblVisitNumber";
            lblVisitNumber.Size = new Size(13, 17);
            lblVisitNumber.TabIndex = 124;
            lblVisitNumber.Text = "-";
            // 
            // lblUpdBy
            // 
            lblUpdBy.AutoSize = true;
            lblUpdBy.Font = new Font("Segoe UI", 9.75F);
            lblUpdBy.Location = new Point(126, 111);
            lblUpdBy.Name = "lblUpdBy";
            lblUpdBy.Size = new Size(13, 17);
            lblUpdBy.TabIndex = 123;
            lblUpdBy.Text = "-";
            // 
            // lblLastUpd
            // 
            lblLastUpd.AutoSize = true;
            lblLastUpd.Font = new Font("Segoe UI", 9.75F);
            lblLastUpd.Location = new Point(126, 84);
            lblLastUpd.Name = "lblLastUpd";
            lblLastUpd.Size = new Size(13, 17);
            lblLastUpd.TabIndex = 122;
            lblLastUpd.Text = "-";
            // 
            // label68
            // 
            label68.AutoSize = true;
            label68.Font = new Font("Segoe UI", 9.75F);
            label68.Location = new Point(7, 111);
            label68.Name = "label68";
            label68.Size = new Size(75, 17);
            label68.TabIndex = 121;
            label68.Text = "Update By :";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 9.75F);
            label27.Location = new Point(7, 84);
            label27.Name = "label27";
            label27.Size = new Size(85, 17);
            label27.TabIndex = 120;
            label27.Text = "Last Update :";
            // 
            // lblDocumentStatus
            // 
            lblDocumentStatus.AutoSize = true;
            lblDocumentStatus.Font = new Font("Segoe UI", 9.75F);
            lblDocumentStatus.Location = new Point(126, 60);
            lblDocumentStatus.Name = "lblDocumentStatus";
            lblDocumentStatus.Size = new Size(13, 17);
            lblDocumentStatus.TabIndex = 119;
            lblDocumentStatus.Text = "-";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F);
            label12.Location = new Point(7, 60);
            label12.Name = "label12";
            label12.Size = new Size(113, 17);
            label12.TabIndex = 118;
            label12.Text = "Document Status :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9.75F);
            label19.Location = new Point(7, 13);
            label19.Name = "label19";
            label19.Size = new Size(33, 17);
            label19.TabIndex = 117;
            label19.Text = "VN :";
            // 
            // lblPatientVisitUID
            // 
            lblPatientVisitUID.AutoSize = true;
            lblPatientVisitUID.Font = new Font("Segoe UI", 9.75F);
            lblPatientVisitUID.Location = new Point(126, 37);
            lblPatientVisitUID.Name = "lblPatientVisitUID";
            lblPatientVisitUID.Size = new Size(13, 17);
            lblPatientVisitUID.TabIndex = 116;
            lblPatientVisitUID.Text = "-";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F);
            label11.Location = new Point(7, 37);
            label11.Name = "label11";
            label11.Size = new Size(64, 17);
            label11.TabIndex = 115;
            label11.Text = "Visit UID :";
            // 
            // lblPatientUID
            // 
            lblPatientUID.AutoSize = true;
            lblPatientUID.Font = new Font("Segoe UI", 9.75F);
            lblPatientUID.Location = new Point(126, 169);
            lblPatientUID.Name = "lblPatientUID";
            lblPatientUID.Size = new Size(13, 17);
            lblPatientUID.TabIndex = 114;
            lblPatientUID.Text = "-";
            lblPatientUID.Visible = false;
            // 
            // panelContainerLeft
            // 
            panelContainerLeft.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            panelContainerLeft.ID = new Guid("22ff496d-9f21-4a60-a0d0-caaaf114fb20");
            panelContainerLeft.Location = new Point(0, 0);
            panelContainerLeft.Name = "panelContainerLeft";
            panelContainerLeft.OriginalSize = new Size(237, 162);
            panelContainerLeft.Size = new Size(237, 763);
            panelContainerLeft.Tabbed = true;
            panelContainerLeft.TabsScroll = true;
            panelContainerLeft.Text = "panelContainer1";
            // 
            // panelContainerResult
            // 
            panelContainerResult.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            panelContainerResult.FloatVertical = true;
            panelContainerResult.ID = new Guid("7cac1005-116f-4bb7-bf17-5ef8f034100c");
            panelContainerResult.Location = new Point(0, 0);
            panelContainerResult.Name = "panelContainerResult";
            panelContainerResult.OriginalSize = new Size(319, 400);
            panelContainerResult.Size = new Size(500, 400);
            panelContainerResult.Tabbed = true;
            panelContainerResult.Text = "panelContainer2";
            // 
            // progressLoad
            // 
            progressLoad.BackColor = Color.White;
            progressLoad.Controls.Add(picLoading);
            progressLoad.Controls.Add(lblWait);
            progressLoad.Location = new Point(0, 0);
            progressLoad.Name = "progressLoad";
            progressLoad.Padding = new Padding(20);
            progressLoad.Size = new Size(87, 69);
            progressLoad.TabIndex = 118;
            // 
            // picLoading
            // 
            picLoading.Dock = DockStyle.Top;
            picLoading.Image = Resources.loading;
            picLoading.Location = new Point(20, 59);
            picLoading.Name = "picLoading";
            picLoading.Size = new Size(47, 256);
            picLoading.SizeMode = PictureBoxSizeMode.CenterImage;
            picLoading.TabIndex = 0;
            picLoading.TabStop = false;
            // 
            // lblWait
            // 
            lblWait.Dock = DockStyle.Top;
            lblWait.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold);
            lblWait.ForeColor = Color.FromArgb(0, 102, 102);
            lblWait.Location = new Point(20, 20);
            lblWait.Name = "lblWait";
            lblWait.Size = new Size(47, 39);
            lblWait.TabIndex = 1;
            lblWait.Text = "Please Wait";
            lblWait.TextAlign = ContentAlignment.BottomCenter;
            // 
            // dockPanel1
            // 
            dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            dockPanel1.FloatVertical = true;
            dockPanel1.ID = new Guid("8af55303-2132-4072-84c9-16689d5e337f");
            dockPanel1.Location = new Point(237, 0);
            dockPanel1.Name = "dockPanel1";
            dockPanel1.OriginalSize = new Size(800, 400);
            dockPanel1.Size = new Size(1255, 400);
            dockPanel1.Text = "panelContainer1";
            // 
            // frmCheckUpMainXX
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 763);
            Controls.Add(progressLoad);
            Controls.Add(dockPanel2);
            Controls.Add(dockPanelPatient);
            Font = new Font("Microsoft Sans Serif", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "frmCheckUpMainXX";
            Text = "Check Up Result : ผลการตรวจสุขภาพ";
            WindowState = FormWindowState.Maximized;
            Load += frmPatientList_Load;
            SizeChanged += frmCheckUpMain_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)leIsAbnormal).EndInit();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)lstRecommendList).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtSearchRecommendation.Properties).EndInit();
            pnDoctorSummary.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtResult_DoctorRecommend.Properties).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ddlDoctor_Conclusion.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlDoctor_PE.Properties).EndInit();
            pnPE.ResumeLayout(false);
            pnPE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ddlGA_LevelOfConsciousne.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_Others.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_Skin.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_Extremties.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_Abdomen.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_Heart.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_LungChestBreast.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_Thyroid.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_Lymphoma.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_MouthAndThroat.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_EareAndNose.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_Eye.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_HeadAndFace.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGA_LevelOfConsciousne.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_Others.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_Skin.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_Extremties.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_Abdomen.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_Heart.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_LungChestBreast.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_Thyroid.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_Lymphoma.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_MouthAndThroat.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_EareAndNose.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_Eye.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlGA_HeadAndFace.Properties).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtVS_SummaryRemark.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlVS_Summary.Properties).EndInit();
            pnVision.ResumeLayout(false);
            pnVision.PerformLayout();
            panel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ddlVS_Blind.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtVS_BlindRemark.Properties).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ddlVS_RetinaRight.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtVS_VisibilityRight.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlVS_VisibilityRight.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtVS_RetinaRight.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlVS_EyeballRight.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtVS_EyeballRight.Properties).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtVS_VisibilityLeft.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlVS_VisibilityLeft.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtVS_RetinaLeft.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlVS_EyeballLeft.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlVS_RetinaLeft.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtVS_EyeballLeft.Properties).EndInit();
            pnAudio.ResumeLayout(false);
            pnAudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ddlEarsLeftRemark.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlEarsLeft.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlEarsRightRemark.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlEarsRight.Properties).EndInit();
            pnBloodChem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridBloodChemistry).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewBloodChemistry).EndInit();
            pnStool2.ResumeLayout(false);
            pnStool2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ddlST_Summary.Properties).EndInit();
            pnStool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridStool).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewStool).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemMemoEdit5).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit9).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit10).EndInit();
            pnStoolCulture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridStoolCulture).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewStoolCulture).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemMemoEdit6).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit11).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit12).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ddlUA_Summary.Properties).EndInit();
            pnUA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridUrine).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewUrine).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemMemoEdit7).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit13).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit14).EndInit();
            pnCBC2.ResumeLayout(false);
            pnCBC2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ddlCBC_Summary.Properties).EndInit();
            pnCBC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdCBC).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewCBC).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemMemoEdit3).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit5).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit6).EndInit();
            pnXray.ResumeLayout(false);
            pnXray.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtX_USBreast.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_USBreast.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtX_LowerAbdomenRemark.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_LowerAbdomen.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtX_Mammogram.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_Mammogram.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtX_EchoRemark.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_Echo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtX_UpperAbdomenRemark.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtX_ChestPA.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_UpperAbdomen.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_ChestPA.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtX_AbdomenRemark.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_Abdomen.Properties).EndInit();
            pnSpecial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdSpecialTest).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdViewSpecialTest).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemMemoEdit2).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit3).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit4).EndInit();
            pnTechnicOther.ResumeLayout(false);
            pnTechnicOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPapSmear.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkPapSmear.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtVegina.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkVegina.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtX_EKGResult.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_EKG.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtX_BMDRemark.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_BMD.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_EST.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtX_ABIRemark.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlX_ABI.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtX_ESTRemark.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemMemoEdit4).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit7).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit8).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemMemoEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit2).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl8).EndInit();
            groupControl8.ResumeLayout(false);
            groupControl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtZipCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlProvince.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAddress.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControlPE).EndInit();
            groupControlPE.ResumeLayout(false);
            groupControlPE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dockManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)barAndDockingController1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageCollection1).EndInit();
            dockPanelPatient.ResumeLayout(false);
            dockPanel1_Container.ResumeLayout(false);
            dockPanel1_Container.PerformLayout();
            ribbonClientPanel1.ResumeLayout(false);
            ribbonClientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            dockPanel2.ResumeLayout(false);
            dockPanelGA.ResumeLayout(false);
            controlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnButton).EndInit();
            pnButton.ResumeLayout(false);
            panel9.ResumeLayout(false);
            dockPanelPE.ResumeLayout(false);
            dockPanel2_Container.ResumeLayout(false);
            dockPanelVision.ResumeLayout(false);
            controlContainer2.ResumeLayout(false);
            dockPanelAudiogram.ResumeLayout(false);
            controlContainer3.ResumeLayout(false);
            dockPanelSpecial.ResumeLayout(false);
            dockPanel8_Container.ResumeLayout(false);
            dockPanelCBC.ResumeLayout(false);
            dockPanel12_Container.ResumeLayout(false);
            dockPanelBloodChemistry.ResumeLayout(false);
            dockPanel3_Container.ResumeLayout(false);
            dockPanelUA.ResumeLayout(false);
            dockPanel11_Container.ResumeLayout(false);
            dockPanelStool.ResumeLayout(false);
            dockPanel10_Container.ResumeLayout(false);
            dockPanelStoolCulture.ResumeLayout(false);
            dockPanel9_Container.ResumeLayout(false);
            dockPanelXray.ResumeLayout(false);
            dockPanel7_Container.ResumeLayout(false);
            dockPanelEKG.ResumeLayout(false);
            dockPanel6_Container.ResumeLayout(false);
            dockPanelConfidential.ResumeLayout(false);
            controlContainer5.ResumeLayout(false);
            pnConfidential.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdConfidential).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdViewConfidential).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemMemoEdit8).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit15).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit16).EndInit();
            dockPanelDoctor.ResumeLayout(false);
            controlContainer4.ResumeLayout(false);
            dockPanelAddress.ResumeLayout(false);
            dockPanel4_Container.ResumeLayout(false);
            dockPanelReference.ResumeLayout(false);
            dockPanel5_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            groupControl2.PerformLayout();
            progressLoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLoading).EndInit();
            ResumeLayout(false);
        }

        private DevExpress.XtraEditors.GroupControl groupControlPE;
    private System.Windows.Forms.Label lblMedicalHistory;
    private System.Windows.Forms.Label lblRh;
    private System.Windows.Forms.Label lblABO;
    private System.Windows.Forms.Label lblBP;
    private System.Windows.Forms.Label lblRR;
    private System.Windows.Forms.Label label32;
    private System.Windows.Forms.Label label33;
    private System.Windows.Forms.Label label34;
    private System.Windows.Forms.Label label35;
    private System.Windows.Forms.Label label36;
    private System.Windows.Forms.Label lblPluse;
    private System.Windows.Forms.Label lblTemperature;
    private System.Windows.Forms.Label lblBMI;
    private System.Windows.Forms.Label lblShape;
    private System.Windows.Forms.Label lblWaist;
    private System.Windows.Forms.Label lblHeight;
    private System.Windows.Forms.Label lblWeight;
    private System.Windows.Forms.Label label20;
    private System.Windows.Forms.Label label21;
    private System.Windows.Forms.Label label22;
    private System.Windows.Forms.Label label23;
    private System.Windows.Forms.Label label24;
    private System.Windows.Forms.Label label25;
    private System.Windows.Forms.Label label26;
    private System.Windows.Forms.Panel pnPE;
    private System.Windows.Forms.Label label39;
    private System.Windows.Forms.Label label38;
    private System.Windows.Forms.CheckBox chkNoCheck;
    internal DevExpress.XtraEditors.TextEdit txtGA_Others;
    internal DevExpress.XtraEditors.TextEdit txtGA_Skin;
    internal DevExpress.XtraEditors.TextEdit txtGA_Extremties;
    internal DevExpress.XtraEditors.TextEdit txtGA_Abdomen;
    internal DevExpress.XtraEditors.TextEdit txtGA_Heart;
    internal DevExpress.XtraEditors.TextEdit txtGA_LungChestBreast;
    internal DevExpress.XtraEditors.TextEdit txtGA_Thyroid;
    internal DevExpress.XtraEditors.TextEdit txtGA_Lymphoma;
    internal DevExpress.XtraEditors.TextEdit txtGA_MouthAndThroat;
    internal DevExpress.XtraEditors.TextEdit txtGA_EareAndNose;
    internal DevExpress.XtraEditors.TextEdit txtGA_Eye;
    internal DevExpress.XtraEditors.TextEdit txtGA_HeadAndFace;
    internal DevExpress.XtraEditors.TextEdit txtGA_LevelOfConsciousne;
    private DevExpress.XtraEditors.LookUpEdit ddlGA_Others;
    private System.Windows.Forms.Label label52;
    private DevExpress.XtraEditors.LookUpEdit ddlGA_Skin;
    private DevExpress.XtraEditors.LookUpEdit ddlGA_Extremties;
    private DevExpress.XtraEditors.LookUpEdit ddlGA_Abdomen;
    private DevExpress.XtraEditors.LookUpEdit ddlGA_Heart;
    private DevExpress.XtraEditors.LookUpEdit ddlGA_LungChestBreast;
    private DevExpress.XtraEditors.LookUpEdit ddlGA_Thyroid;
    private DevExpress.XtraEditors.LookUpEdit ddlGA_Lymphoma;
    private DevExpress.XtraEditors.LookUpEdit ddlGA_MouthAndThroat;
    private DevExpress.XtraEditors.LookUpEdit ddlGA_EareAndNose;
    private DevExpress.XtraEditors.LookUpEdit ddlGA_Eye;
    private System.Windows.Forms.Label label46;
    private System.Windows.Forms.Label label47;
    private System.Windows.Forms.Label label48;
    private System.Windows.Forms.Label label49;
    private System.Windows.Forms.Label label50;
    private System.Windows.Forms.Label label51;
    private System.Windows.Forms.Label label44;
    private System.Windows.Forms.Label label45;
    private System.Windows.Forms.Label label42;
    private System.Windows.Forms.Label label43;
    private DevExpress.XtraEditors.LookUpEdit ddlGA_HeadAndFace;
    private System.Windows.Forms.Label label41;
    private System.Windows.Forms.Label label40;
    private DevExpress.XtraEditors.LookUpEdit ddlGA_LevelOfConsciousne;
    private System.Windows.Forms.Panel pnVision;
    private System.Windows.Forms.Label label37;
    private System.Windows.Forms.Label label53;
    private System.Windows.Forms.Label label54;
    private System.Windows.Forms.Label label55;
    private System.Windows.Forms.Label label56;
    private System.Windows.Forms.Label label58;
    private System.Windows.Forms.Label label57;
    private DevExpress.XtraEditors.LookUpEdit ddlVS_Summary;
    internal DevExpress.XtraEditors.TextEdit txtVS_RetinaLeft;
    private DevExpress.XtraEditors.LookUpEdit ddlVS_RetinaLeft;
    internal DevExpress.XtraEditors.TextEdit txtVS_RetinaRight;
    private DevExpress.XtraEditors.LookUpEdit ddlVS_RetinaRight;
    internal DevExpress.XtraEditors.TextEdit txtVS_BlindRemark;
    private DevExpress.XtraEditors.LookUpEdit ddlVS_Blind;
    internal DevExpress.XtraEditors.TextEdit txtVS_EyeballLeft;
    private DevExpress.XtraEditors.LookUpEdit ddlVS_EyeballLeft;
    internal DevExpress.XtraEditors.TextEdit txtVS_EyeballRight;
    private DevExpress.XtraEditors.LookUpEdit ddlVS_EyeballRight;
    internal DevExpress.XtraEditors.TextEdit txtVS_VisibilityLeft;
    private DevExpress.XtraEditors.LookUpEdit ddlVS_VisibilityLeft;
    internal DevExpress.XtraEditors.TextEdit txtVS_VisibilityRight;
    private DevExpress.XtraEditors.LookUpEdit ddlVS_VisibilityRight;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Panel pnAudio;
    internal DevExpress.XtraEditors.TextEdit ddlEarsLeftRemark;
    private DevExpress.XtraEditors.LookUpEdit ddlEarsLeft;
    internal DevExpress.XtraEditors.TextEdit ddlEarsRightRemark;
    private DevExpress.XtraEditors.LookUpEdit ddlEarsRight;
    private System.Windows.Forms.Label label59;
    private System.Windows.Forms.Label label60;
    private System.Windows.Forms.Panel pnBloodChem;
   
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewBloodChemistry;
    internal DevExpress.XtraGrid.Columns.GridColumn colBC_ItemName;
    internal DevExpress.XtraGrid.Columns.GridColumn colBC_ResultValue;
    internal DevExpress.XtraGrid.Columns.GridColumn colBC_Reference;
  
    internal DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
    internal DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
    internal DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
    private DevExpress.XtraGrid.Columns.GridColumn colBC_Summary;
    private System.Windows.Forms.Panel panel10;
    private DevExpress.XtraEditors.LookUpEdit ddlUA_Summary;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Panel pnUA;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
    private System.Windows.Forms.Panel pnCBC2;
    private DevExpress.XtraEditors.LookUpEdit ddlCBC_Summary;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Panel pnCBC;
    private System.Windows.Forms.Panel pnStool2;
    private DevExpress.XtraEditors.LookUpEdit ddlST_Summary;
    private System.Windows.Forms.Label label17;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Panel pnStool;
    private DevExpress.XtraEditors.MemoEdit txtVegina;
    private System.Windows.Forms.Panel pnStoolCulture;
    private System.Windows.Forms.Panel pnSpecial;
    private System.Windows.Forms.Panel pnXray;
    private DevExpress.XtraEditors.MemoEdit txtX_UpperAbdomenRemark;
    private DevExpress.XtraEditors.MemoEdit txtX_ChestPA;
    private DevExpress.XtraEditors.LookUpEdit ddlX_UpperAbdomen;
    private DevExpress.XtraEditors.LookUpEdit ddlX_ChestPA;
    private DevExpress.XtraEditors.MemoEdit txtX_AbdomenRemark;
    private DevExpress.XtraEditors.LookUpEdit ddlX_Abdomen;
    private DevExpress.XtraEditors.LookUpEdit ddlX_EKG;
    private DevExpress.XtraEditors.MemoEdit txtX_EKGResult;
    private System.Windows.Forms.Label lblAbdomen;
    private System.Windows.Forms.Label lblChestPA;
    private System.Windows.Forms.Label lblUpperAbdomen;
    private System.Windows.Forms.Label lblHeart;
    private System.Windows.Forms.Label lblEST;
    private System.Windows.Forms.Label lblABI;
    private System.Windows.Forms.Label lblMammogram;
    private System.Windows.Forms.Label lblEKG;
    private DevExpress.XtraEditors.MemoEdit txtX_ABIRemark;
    private DevExpress.XtraEditors.MemoEdit txtX_Mammogram;
    private DevExpress.XtraEditors.MemoEdit txtX_ESTRemark;
    private DevExpress.XtraEditors.LookUpEdit ddlX_ABI;
    private DevExpress.XtraEditors.LookUpEdit ddlX_Mammogram;
    private DevExpress.XtraEditors.MemoEdit txtX_EchoRemark;
    private DevExpress.XtraEditors.LookUpEdit ddlX_EST;
    private DevExpress.XtraEditors.LookUpEdit ddlX_Echo;
    private System.Windows.Forms.Panel pnDoctorSummary;
    private DevExpress.XtraEditors.LookUpEdit ddlDoctor_Conclusion;
    private DevExpress.XtraEditors.LookUpEdit ddlDoctor_PE;
    private System.Windows.Forms.Label label31;
    private System.Windows.Forms.Label label30;
    private DevExpress.XtraEditors.MemoEdit txtResult_DoctorRecommend;
    internal DevExpress.XtraEditors.SimpleButton cmdPrintResultBook;
    internal DevExpress.XtraEditors.SimpleButton cmdFinalize;
    internal DevExpress.XtraEditors.SimpleButton cmdTempSave;
    private DevExpress.XtraEditors.GroupControl groupControl8;
    internal DevExpress.XtraEditors.TextEdit txtZipCode;
    private DevExpress.XtraEditors.LookUpEdit ddlProvince;
    private System.Windows.Forms.Label label65;
    private System.Windows.Forms.Label label64;
    private DevExpress.XtraEditors.MemoEdit txtAddress;
    private System.Windows.Forms.Label label63;
    private DevExpress.XtraBars.Docking.DockManager dockManager1;
    private DevExpress.XtraBars.Docking.DockPanel dockPanelPatient;
    private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
    private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
    private System.Windows.Forms.Label lblPayor;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label lblStaffID;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblVisitDate;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label lblVisitNo;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label lblDateVN;
    private System.Windows.Forms.Label lblVN;
    private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
    private System.Windows.Forms.Label lblTel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblPatientName;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label61;
    private System.Windows.Forms.Label label62;
    private System.Windows.Forms.Label label66;
    private System.Windows.Forms.Label label67;
    private System.Windows.Forms.Label lblHN;
    private System.Windows.Forms.Label lblDOB;
    private System.Windows.Forms.Label lblAge;
    private System.Windows.Forms.Label lblGender;
    private System.Windows.Forms.Label lblIdcard;
    private System.Windows.Forms.Label lblNationality;
    private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    private DevExpress.XtraBars.Docking.DockPanel dockPanelPE;
    private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
    private DevExpress.XtraBars.Docking.DockPanel dockPanelAddress;
    private DevExpress.XtraBars.Docking.ControlContainer dockPanel4_Container;
    private DevExpress.XtraBars.Docking.DockPanel dockPanelReference;
    private DevExpress.XtraBars.Docking.ControlContainer dockPanel5_Container;
    private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
    private DevExpress.XtraEditors.PanelControl pnButton;
    internal DevExpress.XtraEditors.SimpleButton cmdClose;
    private DevExpress.XtraEditors.MemoEdit txtX_LowerAbdomenRemark;
    private DevExpress.XtraEditors.LookUpEdit ddlX_LowerAbdomen;
    private System.Windows.Forms.Label lblLowerAbdomen;
    private DevExpress.XtraEditors.MemoEdit txtX_BMDRemark;
    private DevExpress.XtraEditors.LookUpEdit ddlX_BMD;
    private System.Windows.Forms.Label lblBMD;
    private DevExpress.XtraEditors.GroupControl groupControl2;
    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.Label lblPatientVisitUID;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label lblPatientUID;
    private DevExpress.XtraGrid.Columns.GridColumn colBC_ItemCode;

        private System.Windows.Forms.Panel pnTechnicOther;
        private System.Windows.Forms.Label lblDocumentStatus;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.MemoEdit txtPapSmear;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel8;
        private DevExpress.XtraEditors.SimpleButton btnX_PA;
        private DevExpress.XtraEditors.SimpleButton btnX_Lower;
        private DevExpress.XtraEditors.SimpleButton btnX_Mammo;
        private DevExpress.XtraEditors.SimpleButton btnX_Upper;
        private DevExpress.XtraEditors.SimpleButton btnX_Abdomen;
        private DevExpress.XtraEditors.SimpleButton btnX_Echo;
        private DevExpress.XtraEditors.CheckEdit chkPapSmear;
        private DevExpress.XtraEditors.CheckEdit chkVegina;
        private DevExpress.XtraGrid.Columns.GridColumn colLabHead;
        private DevExpress.XtraGrid.Columns.GridColumn colBlank;
        private DevExpress.XtraGrid.Columns.GridColumn colLabItem;
        private DevExpress.XtraGrid.Columns.GridColumn colResult;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitofMeasure;
        private DevExpress.XtraGrid.Columns.GridColumn colReference;
        private DevExpress.XtraGrid.Columns.GridColumn colSymbo;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colCritical;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colPrintOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colComments;
        private DevExpress.XtraGrid.Columns.GridColumn colTime;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Label lblUpdBy;
        private System.Windows.Forms.Label lblLastUpd;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label27;
        private DevExpress.XtraGrid.GridControl gridBloodChemistry;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit leIsAbnormal;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SearchControl txtSearchRecommendation;
        private DevExpress.XtraEditors.ListBoxControl lstRecommendList;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl grdCBC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCBC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.GridControl gridStool;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStool;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn29;
        private DevExpress.XtraGrid.GridControl gridStoolCulture;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStoolCulture;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn30;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn33;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn35;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn36;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn37;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.GridControl grdSpecialTest;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewSpecialTest;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn38;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn39;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn40;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn41;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn42;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn43;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn44;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn45;
        private DevExpress.XtraGrid.Columns.GridColumn colBC_UOM;
        private DevExpress.XtraGrid.GridControl gridUrine;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUrine;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn47;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn48;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn49;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn50;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn51;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn52;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn53;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn54;
        private DevExpress.XtraGrid.Columns.GridColumn colBC_IsAbnormal;
        private DevExpress.XtraGrid.Columns.GridColumn colBC_GroupName;
        private DevExpress.XtraGrid.Columns.GridColumn colBC_UID;
        private DevExpress.XtraBars.Docking.DockPanel panelContainerLeft;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelAudiogram;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer3;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelBloodChemistry;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelGA;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelVision;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer2;
        private DevExpress.XtraBars.Docking.DockPanel panelContainerResult;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelCBC;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel12_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelUA;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel11_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelStool;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel10_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelStoolCulture;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel9_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelSpecial;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel8_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelXray;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel7_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelEKG;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel6_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelDoctor;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer4;
        private System.Windows.Forms.TextBox txtST_DoctorRecommend;
        private System.Windows.Forms.TextBox txtUA_DoctorRecommend;
        private System.Windows.Forms.TextBox txtCBC_DoctorRecommend;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        internal DevExpress.XtraEditors.SimpleButton cmdPrintResultOld;
        internal DevExpress.XtraEditors.TextEdit txtVS_SummaryRemark;
        private System.Windows.Forms.Panel progressLoad;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.Label lblWait;
        internal DevExpress.XtraEditors.SimpleButton cmdPrintResultBookCover;
        internal DevExpress.XtraEditors.SimpleButton cmdPrintResultNew;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn46;
        internal DevExpress.XtraEditors.SimpleButton cmdAdminSave;
        private DevExpress.XtraBars.Docking.DockPanel dockPanelConfidential;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer5;
        private System.Windows.Forms.Panel pnConfidential;
        private DevExpress.XtraGrid.GridControl grdConfidential;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewConfidential;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn55;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn56;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn57;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn58;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn59;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn60;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn61;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn62;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn63;
        internal DevExpress.XtraEditors.SimpleButton cmdPrintResultStudent;
        private System.Windows.Forms.Panel panel9;
        private DevExpress.XtraEditors.SimpleButton btnPAC_PA;
        private DevExpress.XtraEditors.SimpleButton btnPAC_Lower;
        private DevExpress.XtraEditors.SimpleButton btnPAC_Mammo;
        private DevExpress.XtraEditors.SimpleButton btnPAC_Upper;
        private DevExpress.XtraEditors.SimpleButton btnPAC_Echo;
        private DevExpress.XtraEditors.SimpleButton btnPAC_Abdomen;
        private DevExpress.XtraEditors.SimpleButton btnPAC_BMD;
        private DevExpress.XtraEditors.SimpleButton btnPAC_USBreast;
        private DevExpress.XtraEditors.SimpleButton btnX_USBreast;
        private DevExpress.XtraEditors.MemoEdit txtX_USBreast;
        private DevExpress.XtraEditors.LookUpEdit ddlX_USBreast;
        private System.Windows.Forms.Label lblUsBreast;
        private System.Windows.Forms.Label lblVisitNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblReligion;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
    }
}
