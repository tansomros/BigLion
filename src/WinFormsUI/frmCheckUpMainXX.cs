using System.Data;
using System.Diagnostics;
using System.IO;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraNavBar;
using Microsoft.VisualBasic;
//using System.Threading;
//using System.Threading.Tasks;
using SUTH.HealthCheckup.WinFormsUI.Controllers;
using SUTH.HealthCheckup.WinFormsUI.Functions;


namespace SUTH.HealthCheckup.WinFormsUI
{
    public partial  class frmCheckUpMainXX
    {
        readonly PatientController ctlP = new PatientController();
        DataTable dt= new DataTable();
        readonly ReferenceDataController ctlRef = new ReferenceDataController();
        private readonly RepositoryItemLookUpEdit myLookup = new RepositoryItemLookUpEdit();
        readonly ResultController ctlR = new ResultController();
        readonly UserController ctlUser = new UserController();
        private readonly HOSxPServiceController npg = new HOSxPServiceController();
        int i;
        string strValidate = "";
        string RequestDetailUID;
        public Int64 VisitUID { get; set; }
        public Int64 PatientUID { get; set; }
        //public bool UserAuthorized { get; set; }
        public string hn { get; set; }
        public string vn { get; set; }

        public Int64 xChestPAUID { get; set; }
        public Int64 xAbdomenUID { get; set; }
        public Int64 xUpperUID { get; set; }
        public Int64 xLowerUID { get; set; }
        public Int64 xMamoUID { get; set; }
        public Int64 xUSBreastUID { get; set; }
        public Int64 xEchoUID { get; set; }

        public frmCheckUpMainXX()
        {
            InitializeComponent();
            //Broker.Instance.Register(this);

            //using (frmWaitForm frm = new frmWaitForm(() => LoadData()))
            //{
            //    frm.ShowDialog(this);
            //}

            progressLoad.Size = new Size(this.Width, this.Height);
            progressLoad.Location = new Point(0, 0);
            progressLoad.Visible = true;
        }

        //[EventSubscription("topic://inproc/VisitEvent", typeof(OnPublisher))]

        private void frmPatientList_Load(object sender, EventArgs e)
        {
            progressLoad.Size = new Size(this.Width, this.Height);
            progressLoad.Location = new Point(0, 0);
            progressLoad.Visible = true;

            cmdPrintResultBookCover.Visible = false;
            cmdPrintResultBook.Visible = false;
            cmdPrintResultNew.Visible = false;
            cmdPrintResultOld.Visible = false;
            cmdPrintResultStudent.Visible = false;


            LoadData();
            progressLoad.Visible = false;

           
        }

        private void LoadData()
        { 
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                      
            //lblWait.Height =Convert.ToInt32(this.Height*0.3);
            //picLoading.Dock = DockStyle.Top;
            //picLoading.Height = 256;
            //picLoading.Width = this.Width;

            //backgroundWorker1.WorkerReportsProgress = true;
            //backgroundWorker1.WorkerSupportsCancellation = true;
            //Control.CheckForIllegalCrossThreadCalls = false;
            //backgroundWorker1.RunWorkerAsync();

            //Thread.Sleep(2000);
            CollabHeader();
                       
            cmdTempSave.Visible = false;
            cmdFinalize.Visible = false;
      

            UserControlVisibility();
            //LoadPatient();
            BindNormalAbnormalDataToDDL();
            BindNormalAbnormalRadiologicDataToDDL();
            BindNormalAbnormalLabResultDataToDDL();
            BindNormalAbnormalBMDDataToDDL();
            BindNormalAbnormalABIDataToDDL();
            BindNormalAbnormalSummaryDataToDDL();

            BindRecommendToCheckBox();
            LoadDoctors();
            LoadProvince();

            ShowPatientResult(VisitUID,vn);
            
            //gridColumnConclusion.ColumnEdit = leIsAbnormal;
            leIsAbnormal.NullText = "Normal";
      
            //gridViewBloodChemistry.BestFitColumns(true);
            progressLoad.Visible = false;
            //pnLoad.Visible = false;

            //panelContainerMain.Height=600;
            //panelContainerResult.Width = 800;
            //dockPanelGA.Size = new Size(800,600); 
             
        }


        //private void StartThread(Action method)
        //{
        //    ThreadStart thStart = new ThreadStart(method);
        //    Thread th = new Thread(thStart);
        //    th.Start();
        //}

       private void CollabHeader()
        {

            dockPanelGA.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dockPanelVision.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dockPanelAudiogram.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dockPanelBloodChemistry.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dockPanelCBC.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dockPanelUA.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dockPanelStool.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dockPanelStoolCulture.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            
            dockPanelXray.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dockPanelEKG.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dockPanelSpecial.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;  
            //dockPanelConfidential.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dockPanelDoctor.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
        }

        private void GetLabHeader(string vn)
        {
            DataTable dtR = new DataTable();
           
            dockPanelGA.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;

            dockPanelVision.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dockPanelAudiogram.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dockPanelBloodChemistry.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dockPanelCBC.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dockPanelUA.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dockPanelStool.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dockPanelStoolCulture.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;            

            dockPanelDoctor.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            dockPanelSpecial.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            
            dockPanelEKG.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            dockPanelXray.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            //dockPanelConfidential.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;

            //--------------test postgresql ------------
         
            dtR = npg.CheckOrderItemGroup(vn);



            //dtR = ctlR.Result_CheckOrderItemGroup(VNUID);
            if (dtR !=null && dtR.Rows.Count > 0)
            {                

                DataTable dtOrder = new DataTable();
                //dtOrder = dtR.Copy();                           

                dtR.DefaultView.RowFilter = "Code='LM'";
                dtOrder = dtR.DefaultView.ToTable();
                if (dtOrder.Rows.Count > 0) dockPanelStoolCulture.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;

                dtR.DefaultView.RowFilter = "Code='LU015'";
                dtOrder = dtR.DefaultView.ToTable();
                if (dtOrder.Rows.Count > 0) dockPanelStool.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;

                dtR.DefaultView.RowFilter = "Code='LU017'";
                dtOrder = dtR.DefaultView.ToTable();
                if (dtOrder.Rows.Count > 0) dockPanelUA.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;

                dtR.DefaultView.RowFilter = "Code='LH'";
                dtOrder = dtR.DefaultView.ToTable();
                if (dtOrder.Rows.Count > 0) dockPanelCBC.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;

                dtR.DefaultView.RowFilter = "Code='LC'";
                dtOrder = dtR.DefaultView.ToTable();
                if (dtOrder.Rows.Count > 0) dockPanelBloodChemistry.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;

                dtR.DefaultView.RowFilter = "Code IN ('DX0005')";
                dtOrder = dtR.DefaultView.ToTable();
                if (dtOrder.Rows.Count > 0) dockPanelAudiogram.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;

                dtR.DefaultView.RowFilter = "Code IN ('DX0006','DX0027','DX0028','DX0030')";
                dtOrder = dtR.DefaultView.ToTable();
                if (dtOrder.Rows.Count>0) dockPanelVision.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;

                dockPanelGA.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;

                #region "CheckOrder"           

                //for (i = 0; i <= dtR.Rows.Count - 1; i++)
                //{

                //    //DataRow dr = new DataRow();
                //    //dr = dtR.Rows[i];

                //    switch (GlobalFunctions.Left(GlobalFunctions.DBNull2Str(dtR.Rows[i].Field<string>("Code")), 2))
                //    {
                //        case "LU":
                //            //463 LU017  Urine Analysis
                //            if (GlobalFunctions.DBNull2Str(dtR.Rows[i].Field<string>("Code")) == "LU017")
                //            {                             
                //                dockPanelUA.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                //                //461 LU015 Stool Examination
                //            }
                //            else if (GlobalFunctions.DBNull2Str(dtR.Rows[i].Field<string>("Code")) == "LU015")
                //            {
                //                dockPanelStool.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                //            }
                //            break;
                //        case "LH":
                //            //180 LH015 Complete Blood Count (CBC)                          
                //            dockPanelCBC.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                //            break;
                //        case "LC":
                //            //Blood Chemistry
                //            dockPanelBloodChemistry.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                //            break;
                //        case "LI":
                //        case "LS":
                //        case "LP":
                //            //Other
                //            dockPanelSpecial.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                //            break;
                //        case "LM":
                //            //Stool Culture
                //            dockPanelStoolCulture.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                //            break;
                //        case "XR":
                //        case "EK":
                //            dockPanelXray.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                //            switch (GlobalFunctions.DBNull2Str(dtR.Rows[i].Field<string>("Code")))
                //            {
                //                case "XRSP011":
                //                    txtX_Mammogram.Enabled = true;
                //                    ddlX_Mammogram.BackColor = ColorTranslator.FromHtml("#FFFFC8");
                //                    ddlX_Mammogram.Enabled = true;
                //                    txtX_Mammogram.BackColor = ColorTranslator.FromHtml("#FFFFC8");                                   
                //                    break;
                //                case "XRGEN001":
                //                    ddlX_ChestPA.Enabled = true;
                //                    //ddlX_Chest_Send.Enabled = True
                //                    txtX_ChestPA.Enabled = true;
                //                    ddlX_ChestPA.BackColor = ColorTranslator.FromHtml("#FFFFC8");
                //                    txtX_ChestPA.BackColor = ColorTranslator.FromHtml("#FFFFC8");
                //                    //ddlX_Chest_Send.BackColor = Color.White                                  
                //                    break;
                //                case "XRUS031":
                //                    ddlX_Abdomen.Enabled = true;
                //                    txtX_AbdomenRemark.Enabled = true;
                //                    txtX_AbdomenRemark.BackColor = ColorTranslator.FromHtml("#FFFFC8");
                //                    ddlX_Abdomen.BackColor = ColorTranslator.FromHtml("#FFFFC8");
                //                    break;
                //                case "XRUS029":
                //                    ddlX_UpperAbdomen.Enabled = true;
                //                    txtX_UpperAbdomenRemark.Enabled = true;
                //                    txtX_UpperAbdomenRemark.BackColor = ColorTranslator.FromHtml("#FFFFC8");
                //                    ddlX_UpperAbdomen.BackColor = ColorTranslator.FromHtml("#FFFFC8");
                //                    break;
                //            }
                //            break;
                //        case "DX":
                //            switch (GlobalFunctions.DBNull2Str(dtR.Rows[i].Field<string>("Code")))
                //            {
                //                case "DX0002":                                    
                //                    dockPanelXray.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                //                    txtX_EKGResult.Enabled = true;
                //                    //ddlX_EKG_Send.Enabled = True
                //                    ddlX_EKG.Enabled = true;
                //                    ddlX_EKG.BackColor = ColorTranslator.FromHtml("#FFFFC8");
                //                    txtX_EKGResult.BackColor = ColorTranslator.FromHtml("#FFFFC8");
                //                    break;
                //                case "DX0005":                                
                //                    dockPanelAudiogram.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                //                    GlobalFunctions.gAudiogram = true;
                //                    dockPanelGA.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                //                    break;
                //                case "DX0006":
                //                case "DX0027":
                //                case "DX0028":
                //                case "DX0030":                                    
                //                    dockPanelVision.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                //                    break;
                //                case "DX0003":
                //                    if (GlobalFunctions.Left(dtR.Rows[i].Field<string>("itemName"), 3) != "EKG")
                //                    {                                        
                //                        dockPanelVision.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                //                    }
                //                    else
                //                    {                                        
                //                        dockPanelXray.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                //                    }
                //                    break;
                //                case "DX0011":
                //                    ddlX_EST.Enabled = true;
                //                    txtX_ESTRemark.Enabled = true;
                //                    ddlX_EST.BackColor = ColorTranslator.FromHtml("#FFFFC8");
                //                    txtX_ESTRemark.BackColor = ColorTranslator.FromHtml("#FFFFC8");                                  
                //                    break;
                //                case "DX0012":
                //                    ddlX_Echo.Enabled = true;
                //                    txtX_EchoRemark.Enabled = true;
                //                    ddlX_Echo.BackColor = ColorTranslator.FromHtml("#FFFFC8");
                //                    txtX_EchoRemark.BackColor = ColorTranslator.FromHtml("#FFFFC8");
                //                    break;
                //                case "DX0020":
                //                    ddlX_ABI.Enabled = true;
                //                    txtX_ABIRemark.Enabled = true;
                //                    ddlX_ABI.BackColor = ColorTranslator.FromHtml("#FFFFC8");
                //                    txtX_ABIRemark.BackColor = ColorTranslator.FromHtml("#FFFFC8");
                //                    break;
                //                default:                                 
                //                    dockPanelXray.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                //                    break;
                //            }
                //            break;
                //        case "df":
                //            break;
                //        default:                         
                //            dockPanelSpecial.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                //            break;
                //    }
                //}
                #endregion
            }
            dtR = null;
 
        }


         private void UserControlVisibility()
         { 

        //cmdTempSave.Visible = True;
        //cmdFinalize.Visible = True;
        //lnkPapSmear.Visible = False;
        //lnkLiquid.Visible = False;
        
        //for (int i = 0; i < chkRecomend.Items.Count; i++)
        //    {
        //         chkRecomend.SetItemChecked(i, false);
              
        //    }              

        lblHN.Text = "";
        lblStaffID.Text = "";
        GlobalVariables.gPatientVisitUID  = 0;
        GlobalVariables.gPatientUID  = 0;
        lblVisitNo.Text = "";
        lblVisitDate.Text = "";
        lblPatientName.Text = "";
        lblAge.Text = "";
        lblGender.Text = "";
        lblShape.Text = "";
        lblWaist.Text = "";
        lblBMI.Text = "";
        lblWeight.Text = "";
        lblHeight.Text = "";
        lblTemperature.Text = "";
        lblPluse.Text = "";
        lblBP.Text = "";
        lblRR.Text = "";
        lblMedicalHistory.Text = "";
       

        ddlGA_LevelOfConsciousne.EditValue = "N";
        txtGA_LevelOfConsciousne.Text = "";
        ddlGA_HeadAndFace.EditValue = "N";
        txtGA_HeadAndFace.Text = "";
        ddlGA_Eye.EditValue = "N";
        txtGA_Eye.Text = "";
        ddlGA_EareAndNose.EditValue = "N";
        txtGA_EareAndNose.Text = "";
        ddlGA_MouthAndThroat.EditValue = "N";
        txtGA_MouthAndThroat.Text = "";
        ddlGA_Lymphoma.EditValue = "N";
        txtGA_Lymphoma.Text = "";
        ddlGA_Thyroid.EditValue = "N";
        txtGA_Thyroid.Text = "";
        ddlGA_LungChestBreast.EditValue = "N";
        txtGA_LungChestBreast.Text = "";
        ddlGA_Heart.EditValue = "N";
        txtGA_Heart.Text = "";
        ddlGA_Abdomen.EditValue = "N";
        txtGA_Abdomen.Text = "";
        ddlGA_Extremties.EditValue = "N";
        txtGA_Extremties.Text = "";
        ddlGA_Skin.EditValue = "N";
        txtGA_Skin.Text = "";
        ddlGA_Others.EditValue = "N";
        txtGA_Others.Text = "";
       
        txtVS_VisibilityRight.Text = "";
        ddlVS_VisibilityRight.Text = "";
        txtVS_VisibilityLeft.Text = "";
        ddlVS_VisibilityLeft.Text = "";
        txtVS_EyeballRight.Text = "";
        ddlVS_EyeballRight.Text = "";
        txtVS_EyeballLeft.Text = "";
        ddlVS_EyeballLeft.Text = "";
        txtVS_BlindRemark.Text = "";
        ddlVS_Blind.Text = "";
        txtVS_SummaryRemark.Text = "";
        ddlVS_Summary.Text = "";
        txtVS_RetinaRight.Text = "";
        ddlVS_RetinaRight.EditValue = "";
        txtVS_RetinaLeft.Text = "";
        ddlVS_RetinaLeft.EditValue = "";

        ddlEarsRight.Text = "";
        ddlEarsRightRemark.Text = "";
        ddlEarsLeft.Text = "";
        ddlEarsLeftRemark.Text = "";

       
        ddlUA_Summary.EditValue = "N";
        txtUA_DoctorRecommend.Text = "ผลการตรวจปัสสาวะอยู่ในเกณฑ์ปกติ";

        ddlST_Summary.EditValue = "N";
        txtST_DoctorRecommend.Text = "ผลการตรวจอุจจาระอยู่ในเกณฑ์ปกติ";

        ddlCBC_Summary.EditValue = "N";
        txtCBC_DoctorRecommend.Text = "ความสมบูรณ์ของเม็ดเลือดอยู่ในเกณฑ์ปกติ";

      
       

        // txtResult_Conclusion.Text = ""
        //txtResult_LabTest.Text = ""
        txtResult_DoctorRecommend.Text = "";
        ddlDoctor_PE.EditValue = "";
        ddlDoctor_Conclusion.EditValue = "";

            //txtSTD_Regis.Text = "";

            //ddlSTD_Body.EditValue = "";
            //txtSTD_Body.Text = "";
            //ddlSTD_Head.EditValue = "";
            //txtSTD_Head.Text = ""
            //ddlSTD_Eye.EditValue = "";
            //txtSTD_Eye.Text = ""
            //ddlSTD_Ears.EditValue = "";
            //txtSTD_Ears.Text = ""
            //ddlSTD_Nose.EditValue = "";
            //txtSTD_Nose.Text = ""
            //ddlSTD_Thoat.EditValue = "";
            //txtSTD_Thoat.Text = ""
            //ddlSTD_Lung.EditValue = "";
            //txtSTD_Lung.Text = ""
            //ddlSTD_Heart.EditValue = "";
            //txtSTD_Heart.Text = ""
            //ddlSTD_Extremties.EditValue = "";
            //txtSTD_Extremties.Text = ""
            //ddlSTD_Skin.EditValue = "";
            //txtSTD_Skin.Text = ""
            //ddlSTD_Lymphose.EditValue = "";
            //txtSTD_Lymphose.Text = ""
            //ddlSTD_Nerve.EditValue = "";
            //txtSTD_Nerve.Text = ""
            //txtSTD_Other.Text = ""
            //ddlSTD_EyeRight.EditValue = "";
            //txtSTD_EyeFixRight.Text = ""
            //ddlSTD_EyeLeft.EditValue = "";
            //txtSTD_EyeFixLeft.Text = ""
            //ddlSTD_ChestXRay.EditValue = "";
            //txtSTD_ChestXray.Text = ""
            //ddlSTD_Type.EditValue = "";
            //txtSTD_Type.Text = ""



            ddlX_EKG.BackColor = Color.White;
            ddlX_Abdomen.BackColor = Color.White;
            ddlX_ChestPA.BackColor = Color.White;
            ddlX_UpperAbdomen.BackColor = Color.White;
            ddlX_Echo.BackColor = Color.White;
            ddlX_EST.BackColor = Color.White;
            ddlX_Mammogram.BackColor = Color.White;
            ddlX_USBreast.BackColor = Color.White;
            ddlX_ABI.BackColor = Color.White;
            

            txtX_EKGResult.BackColor = Color.White;
            txtX_AbdomenRemark.BackColor = Color.White;
            txtX_ChestPA.BackColor = Color.White;
            txtX_UpperAbdomenRemark.BackColor = Color.White;
            txtX_EchoRemark.BackColor = Color.White;
            txtX_ESTRemark.BackColor = Color.White;
            txtX_Mammogram.BackColor = Color.White;
            txtX_USBreast.BackColor = Color.White;
            txtX_ABIRemark.BackColor = Color.White;

            txtPapSmear.BackColor = Color.White;
            txtVegina.BackColor = Color.White;

            lblChestPA.BackColor = Color.Transparent;
            lblEKG.BackColor = Color.Transparent;
            lblAbdomen.BackColor = Color.Transparent;
            lblUpperAbdomen.BackColor = Color.Transparent;
            lblHeart.BackColor = Color.Transparent;
            lblEST.BackColor = Color.Transparent;
            lblABI.BackColor = Color.Transparent;
            lblMammogram.BackColor = Color.Transparent;
            lblUsBreast.BackColor = Color.Transparent;



            ddlX_Abdomen.EditValue = "";
        ddlX_ABI.EditValue = "";
        ddlX_EKG.EditValue = "";
        ddlX_EST.EditValue = "";
        ddlX_Echo.EditValue = "";
        ddlX_Mammogram.EditValue = "";
            ddlX_USBreast.EditValue = "";
            ddlX_UpperAbdomen.EditValue = "";
        ddlX_ChestPA.EditValue = "";
        ddlX_LowerAbdomen.EditValue = "";
        ddlX_BMD.EditValue = "";


        txtX_ChestPA.Text = "";
        txtX_Mammogram.Text = "";
            txtX_USBreast.Text = "";
            txtX_EKGResult.Text = "";
        txtX_AbdomenRemark.Text = "";
        txtX_EchoRemark.Text = "";
        txtX_ESTRemark.Text = "";
        txtX_ABIRemark.Text = "";
        txtX_UpperAbdomenRemark.Text = "";
        txtX_BMDRemark.Text = "";
        txtX_LowerAbdomenRemark.Text = "";

        ddlX_Abdomen.Enabled = true;
        ddlX_ABI.Enabled = true;
        ddlX_EKG.Enabled = true;
        ddlX_EST.Enabled = true;
        ddlX_Echo.Enabled = true;
        ddlX_Mammogram.Enabled = true;
            ddlX_USBreast.Enabled = true;
            ddlX_UpperAbdomen.Enabled = true;
        ddlX_ChestPA.Enabled = true;
        ddlX_LowerAbdomen.Enabled = true;
        ddlX_BMD.Enabled = true;


        txtX_ChestPA.Enabled = true;
        txtX_Mammogram.Enabled = true;
            txtX_USBreast.Enabled = true;
            txtX_EKGResult.Enabled = true;
        txtX_AbdomenRemark.Enabled = true;
        txtX_EchoRemark.Enabled = true;
        txtX_ESTRemark.Enabled = true;
        txtX_ABIRemark.Enabled = true;
        txtX_UpperAbdomenRemark.Enabled = true;
        txtX_BMDRemark.Enabled = true;
        txtX_LowerAbdomenRemark.Enabled = true;

            btnX_PA.Visible = false;
            btnX_Mammo.Visible = false;
            btnX_USBreast.Visible = false;
            //btnX_EKG.Visible = false;
            btnX_Abdomen.Visible = false;
            btnX_Echo.Visible = false;
            //btnX_EST.Visible = false;
            //btnX_ABI.Visible = false;
            btnX_Upper.Visible = false;
            //btnX_BMD.Visible = false;
            btnX_Lower.Visible = false;

            btnPAC_Abdomen.Visible = false;
            btnPAC_BMD.Visible = false;
            btnPAC_Echo.Visible = false;
            btnPAC_Lower.Visible = false;
            btnPAC_Mammo.Visible = false;
            btnPAC_USBreast.Visible = false;
            btnPAC_PA.Visible = false;
            btnPAC_Upper.Visible = false;      



        }
        private void BindRecommendToCheckBox()
        {
            
                dt = ctlRef.RecommendData_Get();
                if (dt.Rows.Count > 0)
                {
                    //chkRecomend.DataSource = dt;
                    //chkRecomend.DisplayMember = "DisplayName";
                    //chkRecomend.ValueMember = "DisplayName";

                    //for (int i=0;i<dt.Rows.Count;i++)
                    //{
                    //    chkRecomend.Items.Add(dt.Rows[i].Field<string>("DisplayName"));
                    //}


                lstRecommendList.DataSource = dt;
                if (lstRecommendList.DataSource != null)
                {
                    lstRecommendList.DisplayMember = "DisplayName";
                    lstRecommendList.ValueMember = "DisplayName"; 
                }
            }
        dt = null;
        }
        private void BindNormalAbnormalDataToDDL()
        { 
              
                dt = ctlRef.ReferenceData_GetByDomain("GA");
            if (dt.Rows.Count>0 )
            {                   

                ddlGA_LevelOfConsciousne.Properties.DataSource = dt;
                ddlGA_LevelOfConsciousne.Properties.DisplayMember = "DisplayName";
                ddlGA_LevelOfConsciousne.Properties.ValueMember = "ValueCode";
                DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlGA_LevelOfConsciousne.Properties.Columns.Add(col);


                ddlGA_Others.Properties.DataSource = dt;
                ddlGA_Others.Properties.DisplayMember = "DisplayName";
                ddlGA_Others.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlGA_Others.Properties.Columns.Add(col);

                ddlGA_Skin.Properties.DataSource = dt;
                ddlGA_Skin.Properties.DisplayMember = "DisplayName";
                ddlGA_Skin.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlGA_Skin.Properties.Columns.Add(col);

                ddlGA_Extremties.Properties.DataSource = dt;
                ddlGA_Extremties.Properties.DisplayMember = "DisplayName";
                ddlGA_Extremties.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlGA_Extremties.Properties.Columns.Add(col);

                ddlGA_Abdomen.Properties.DataSource = dt;
                ddlGA_Abdomen.Properties.DisplayMember = "DisplayName";
                ddlGA_Abdomen.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlGA_Abdomen.Properties.Columns.Add(col);

                ddlGA_Heart.Properties.DataSource = dt;
                ddlGA_Heart.Properties.DisplayMember = "DisplayName";
                ddlGA_Heart.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlGA_Heart.Properties.Columns.Add(col);

                ddlGA_LungChestBreast.Properties.DataSource = dt;
                ddlGA_LungChestBreast.Properties.DisplayMember = "DisplayName";
                ddlGA_LungChestBreast.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlGA_LungChestBreast.Properties.Columns.Add(col);

                ddlGA_Thyroid.Properties.DataSource = dt;
                ddlGA_Thyroid.Properties.DisplayMember = "DisplayName";
                ddlGA_Thyroid.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlGA_Thyroid.Properties.Columns.Add(col);

               
                ddlGA_Lymphoma.Properties.DataSource = dt;
                ddlGA_Lymphoma.Properties.DisplayMember = "DisplayName";
                ddlGA_Lymphoma.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlGA_Lymphoma.Properties.Columns.Add(col);

                ddlGA_MouthAndThroat.Properties.DataSource = dt;
                ddlGA_MouthAndThroat.Properties.DisplayMember = "DisplayName";
                ddlGA_MouthAndThroat.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlGA_MouthAndThroat.Properties.Columns.Add(col);                                 

                ddlGA_EareAndNose.Properties.DataSource = dt;
                ddlGA_EareAndNose.Properties.DisplayMember = "DisplayName";
                ddlGA_EareAndNose.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlGA_EareAndNose.Properties.Columns.Add(col);

                ddlGA_Eye.Properties.DataSource = dt;
                ddlGA_Eye.Properties.DisplayMember = "DisplayName";
                ddlGA_Eye.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlGA_Eye.Properties.Columns.Add(col);


                ddlGA_HeadAndFace.Properties.DataSource = dt;
                ddlGA_HeadAndFace.Properties.DisplayMember = "DisplayName";
                ddlGA_HeadAndFace.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlGA_HeadAndFace.Properties.Columns.Add(col);


                //myLookup.Properties.DataSource = dt;
                //myLookup.Properties.DisplayMember = "DisplayName";
                //myLookup.Properties.ValueMember = "ValueCode";
                ////DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                //col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                //myLookup.Properties.Columns.Add(col);


                ddlVS_VisibilityRight.Properties.DataSource = dt;
                ddlVS_VisibilityRight.Properties.DisplayMember = "DisplayName";
                ddlVS_VisibilityRight.Properties.ValueMember = "ValueCode";
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlVS_VisibilityRight.Properties.Columns.Add(col);

                ddlVS_VisibilityLeft.Properties.DataSource = dt;
                ddlVS_VisibilityLeft.Properties.DisplayMember = "DisplayName";
                ddlVS_VisibilityLeft.Properties.ValueMember = "ValueCode";
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlVS_VisibilityLeft.Properties.Columns.Add(col);

                ddlVS_EyeballRight.Properties.DataSource = dt;
                ddlVS_EyeballRight.Properties.DisplayMember = "DisplayName";
                ddlVS_EyeballRight.Properties.ValueMember = "ValueCode";
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlVS_EyeballRight.Properties.Columns.Add(col);
                
                ddlVS_EyeballLeft.Properties.DataSource = dt;
                ddlVS_EyeballLeft.Properties.DisplayMember = "DisplayName";
                ddlVS_EyeballLeft.Properties.ValueMember = "ValueCode";
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlVS_EyeballLeft.Properties.Columns.Add(col);

                ddlVS_RetinaRight.Properties.DataSource = dt;
                ddlVS_RetinaRight.Properties.DisplayMember = "DisplayName";
                ddlVS_RetinaRight.Properties.ValueMember = "ValueCode";
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlVS_RetinaRight.Properties.Columns.Add(col);

                ddlVS_RetinaLeft.Properties.DataSource = dt;
                ddlVS_RetinaLeft.Properties.DisplayMember = "DisplayName";
                ddlVS_RetinaLeft.Properties.ValueMember = "ValueCode";
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlVS_RetinaLeft.Properties.Columns.Add(col);

                ddlVS_Blind.Properties.DataSource = dt;
                ddlVS_Blind.Properties.DisplayMember = "DisplayName";
                ddlVS_Blind.Properties.ValueMember = "ValueCode";
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlVS_Blind.Properties.Columns.Add(col);

                ddlVS_Summary.Properties.DataSource = dt;
                ddlVS_Summary.Properties.DisplayMember = "DisplayName";
                ddlVS_Summary.Properties.ValueMember = "ValueCode"; 
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlVS_Summary.Properties.Columns.Add(col);

                ddlEarsRight.Properties.DataSource = dt;
                ddlEarsRight.Properties.DisplayMember = "DisplayName";
                ddlEarsRight.Properties.ValueMember = "ValueCode"; 
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlEarsRight.Properties.Columns.Add(col);

                ddlEarsLeft.Properties.DataSource = dt;
                ddlEarsLeft.Properties.DisplayMember = "DisplayName";
                ddlEarsLeft.Properties.ValueMember = "ValueCode";
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlEarsLeft.Properties.Columns.Add(col);
                               
               ddlGA_HeadAndFace.EditValue = "N";
               ddlGA_Others.EditValue = "N";
               ddlGA_Skin.EditValue = "N";
               ddlGA_Extremties.EditValue = "N";
               ddlGA_Abdomen.EditValue = "N";
               ddlGA_Heart.EditValue = "N";
               ddlGA_LungChestBreast.EditValue = "N";
               ddlGA_Thyroid.EditValue = "N";
               ddlGA_Lymphoma.EditValue = "N";
               ddlGA_MouthAndThroat.EditValue = "N";
               ddlGA_EareAndNose.EditValue = "N";
               ddlGA_Eye.EditValue = "N";
               ddlGA_HeadAndFace.EditValue = "N";
               ddlGA_LevelOfConsciousne.EditValue = "N";

               ddlUA_Summary.EditValue = "N";
               //myLookup.EditValue = "";          

            }       
        }

        private void BindNormalAbnormalRadiologicDataToDDL()
        {

            dt = ctlRef.ReferenceData_GetByDomain("X");
            if (dt.Rows.Count > 0)
            {
                ddlX_ChestPA.Properties.DataSource = dt;
                ddlX_ChestPA.Properties.DisplayMember = "DisplayName";
                ddlX_ChestPA.Properties.ValueMember = "ValueCode";
                DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlX_ChestPA.Properties.Columns.Add(col);

                ddlX_ChestPA.EditValue = "N";



                ddlX_Echo.Properties.DataSource = dt;
                ddlX_Echo.Properties.DisplayMember = "DisplayName";
                ddlX_Echo.Properties.ValueMember = "ValueCode"; 
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlX_Echo.Properties.Columns.Add(col);

                ddlX_EKG.Properties.DataSource = dt;
                ddlX_EKG.Properties.DisplayMember = "DisplayName";
                ddlX_EKG.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlX_EKG.Properties.Columns.Add(col);

                ddlX_Abdomen.Properties.DataSource = dt;
                ddlX_Abdomen.Properties.DisplayMember = "DisplayName";
                ddlX_Abdomen.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlX_Abdomen.Properties.Columns.Add(col);

                ddlX_UpperAbdomen.Properties.DataSource = dt;
                ddlX_UpperAbdomen.Properties.DisplayMember = "DisplayName";
                ddlX_UpperAbdomen.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlX_UpperAbdomen.Properties.Columns.Add(col);

                  ddlX_LowerAbdomen.Properties.DataSource = dt;
                ddlX_LowerAbdomen.Properties.DisplayMember = "DisplayName";
                ddlX_LowerAbdomen.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlX_LowerAbdomen.Properties.Columns.Add(col);

                ddlX_EST.Properties.DataSource = dt;
                ddlX_EST.Properties.DisplayMember = "DisplayName";
                ddlX_EST.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlX_EST.Properties.Columns.Add(col);

              


                ddlX_Mammogram.Properties.DataSource = dt;
                ddlX_Mammogram.Properties.DisplayMember = "DisplayName";
                ddlX_Mammogram.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlX_Mammogram.Properties.Columns.Add(col);

                ddlX_USBreast.Properties.DataSource = dt;
                ddlX_USBreast.Properties.DisplayMember = "DisplayName";
                ddlX_USBreast.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlX_USBreast.Properties.Columns.Add(col);




                ddlX_EKG.EditValue = "N";
                ddlX_Echo.EditValue = "N";               
                ddlX_Abdomen.EditValue = "N";
                ddlX_UpperAbdomen.EditValue = "N";
                //ddlX_BMD.EditValue = "N";
                ddlX_EST.EditValue = "N";
                ddlX_LowerAbdomen.EditValue = "N";
                ddlX_Mammogram.EditValue = "N";
                ddlX_USBreast.EditValue = "N";
                //ddlX_ABI.EditValue = "N";

            }


        }

        private void BindNormalAbnormalLabResultDataToDDL()
        {
            dt = ctlRef.GET_NormalAbnormalLabResult();
            if (dt.Rows.Count > 0)
            {
                leIsAbnormal.DataSource = dt;
                leIsAbnormal.DisplayMember = "DisplayName";
                leIsAbnormal.ValueMember = "NormalTXT";
                DevExpress.XtraEditors.Controls.LookUpColumnInfo col2;
                col2 = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "", 120);
                //col2.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                leIsAbnormal.Columns.Add(col2);
            }
        }

        private void BindNormalAbnormalSummaryDataToDDL()
        {

            dt = ctlRef.ReferenceData_GetByDomain("LAB");
            if (dt.Rows.Count > 0)
            {

                ddlCBC_Summary.Properties.DataSource = dt;
                ddlCBC_Summary.Properties.DisplayMember = "DisplayName";
                ddlCBC_Summary.Properties.ValueMember = "ValueCode";
                DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlCBC_Summary.Properties.Columns.Add(col);

                ddlUA_Summary.Properties.DataSource = dt;
                ddlUA_Summary.Properties.DisplayMember = "DisplayName";
                ddlUA_Summary.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlUA_Summary.Properties.Columns.Add(col);

                ddlST_Summary.Properties.DataSource = dt;
                ddlST_Summary.Properties.DisplayMember = "DisplayName";
                ddlST_Summary.Properties.ValueMember = "ValueCode";
                //DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlST_Summary.Properties.Columns.Add(col);


                ddlCBC_Summary.EditValue = "N";
                ddlUA_Summary.EditValue = "N";
                ddlST_Summary.EditValue = "N";

            }
        }

        private void BindNormalAbnormalBMDDataToDDL()
        {

            dt = ctlRef.ReferenceData_GetByDomain("BMD");
            if (dt.Rows.Count > 0)
            {
                ddlX_BMD.Properties.DataSource = dt;
                ddlX_BMD.Properties.DisplayMember = "DisplayName";
                ddlX_BMD.Properties.ValueMember = "ValueCode";
                DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlX_BMD.Properties.Columns.Add(col);

            }
        }
        private void BindNormalAbnormalABIDataToDDL()
        {

            dt = ctlRef.ReferenceData_GetByDomain("ABI");
            if (dt.Rows.Count > 0)
            {
                ddlX_ABI.Properties.DataSource = dt;
                ddlX_ABI.Properties.DisplayMember = "DisplayName";
                ddlX_ABI.Properties.ValueMember = "ValueCode";
                DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 50);
                //col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlX_ABI.Properties.Columns.Add(col);

            }
        }
        
        private void LoadProvince()
        {
            dt = ctlP.Province_Get();

            if (dt.Rows.Count > 0)
            {
                //ddlProvince.Items.Add("");
                //ddlProvince.Items(0).Value = "";

                //for (i = 0; i <= dt.Rows.Count - 1; i++)
                //{
                //    ddlProvince.Items.Add(dt.Rows[i].Field<string>("ProvinceName"));
                //    ddlProvince.Items(i + 1).Value = dt.Rows[i].Field<string>("ProvinceName");
                //}
                

                ddlProvince.Properties.DataSource = dt;
                ddlProvince.Properties.DisplayMember = "ProvinceName";
                ddlProvince.Properties.ValueMember = "ProvinceName";
                DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProvinceName", "Province", 50);
                col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlProvince.Properties.Columns.Add(col);



                ddlProvince.EditValue = "";

            }
            else
            {
            }
            dt = null;
        }

        private void LoadDoctors()
        {
            dt = ctlP.CheckUp_GetAllDoctor();
            if (dt.Rows.Count > 0)
            {
                
                ddlDoctor_PE.Properties.DataSource = dt;
                ddlDoctor_PE.Properties.DisplayMember = "DisplayName";
                ddlDoctor_PE.Properties.ValueMember = "UID";
                DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 100);
                col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlDoctor_PE.Properties.Columns.Add(col);

                ddlDoctor_Conclusion.Properties.DataSource = dt;
                ddlDoctor_Conclusion.Properties.DisplayMember = "DisplayName";
                ddlDoctor_Conclusion.Properties.ValueMember = "UID"; 
                col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayName", "Value", 100);
                col.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
                ddlDoctor_Conclusion.Properties.Columns.Add(col);
              
                ddlDoctor_PE.EditValue = "";
                ddlDoctor_Conclusion.EditValue = "";

            }
            else
            {
            }
            dt = null;
        }

        private void navBarData_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                NavBarControl navBar = sender as NavBarControl;
                NavBarHitInfo hitInfo = navBar.CalcHitInfo(new Point(e.X, e.Y));

                if (hitInfo.InGroupCaption && (!hitInfo.InGroupButton))
                {
                    hitInfo.Group.Expanded = !hitInfo.Group.Expanded;
                   
                }
                
            }
        }

        private void ShowPatientResult(long VNUID,string vn)
        {

            DataTable dtU = new DataTable();
            dtU = ctlUser.User_GetConfidentialByLoginName(DataHelper.LoginUser);
            if (dtU.Rows.Count > 0) //ตรวจสอบว่าเป็นหมอ หรือ admin หรือไม่ ถ้าใช่ให้สามารถเห็น Lab Confidential ได้
            {
                ShowConfidentialTestResult(VNUID);
            }

            UserControlVisibility();

            GetLabHeader(vn);

            ShowPatientInfo(VNUID);
      
            SynVisibility(VNUID);
            ShowVisionScreeningResult(VNUID);
            ShowAudiogramResult(VNUID);
            //GetLabResult(VNUID);
            ShowDoctorResult(VNUID);

            GetLabResult(VNUID);

            //ShowBloodChemistryResult(VNUID);
            //ShowUrineResult(UID, VNUID);
            //ShowCBCResult(UID, VNUID);
            //ShowStoolResult(UID, VNUID);
            //ShowOtherResult(UID, VNUID);
            //ShowStoolCultureResult(UID, VNUID);
            //ShowSpecialTestResult(UID, VNUID);
                        
            //navBarContainerUA.Height = 400;
            //navBarContainerCBC.Height = 400;
            //navBarContainerXray.Height = 400;

            gridViewBloodChemistry.OptionsSelection.EnableAppearanceFocusedRow = false;
            gridViewUrine.OptionsSelection.EnableAppearanceFocusedRow = false;
            gridViewCBC.OptionsSelection.EnableAppearanceFocusedRow = false;
            gridViewStool.OptionsSelection.EnableAppearanceFocusedRow = false;
            //gridViewOther.OptionsSelection.EnableAppearanceFocusedRow = false;
            gridViewStoolCulture.OptionsSelection.EnableAppearanceFocusedRow = false;
            grdViewSpecialTest.OptionsSelection.EnableAppearanceFocusedRow = false;
      
             

        }

        private void GetLabResult(long VNUID)
        {
            
            DataTable dtR = new DataTable();
            dtR = ctlR.Result_GetLabResult(VNUID);
            if (dtR.Rows.Count > 0)
            {

                ShowBloodChemistryResult(VNUID);
                ShowUrineResult(VNUID);
                ShowCBCResult(VNUID);
                ShowStoolResult(VNUID);
                //ShowOtherResult(VNUID);
                ShowStoolCultureResult(VNUID);

                ShowSpecialTestResult(VNUID);               
                 
            }

            DataTable dtSP = new DataTable();

            dtSP = ctlR.Result_GetSpecialResult(VNUID);

            if (dtSP.Rows.Count > 0)
            {
                ShowXRAYSummaryResult(dtSP);              
            }

            ShowXrayOrder(VNUID);

            if (lblGender.Text == "หญิง")
            {
                ShowPAPsmearResult(VNUID);
            }

            ShowSuggestionAndDoctorRecommend(VNUID);
            // ShowRecommend(dtR)
            ShowSummaryResult(VNUID);

           


            dtR = null;
            dtSP = null;
        }


        public static Image GetPatientImage(string hn)
        {
            
                //PatientController ctlImg = new PatientController();
                DataTable dtImg = new DataTable();
            //dtImg = ctlImg.Patient_GetPatientImage(PatientUID);
            HOSxPServiceController npg2 = new HOSxPServiceController();
            dtImg = npg2.GetPatientImage(hn);
            try
            {
                if (dtImg!=null && dtImg.Rows.Count > 0)
                {
                    byte[] ap; ap = (byte[])(dtImg.Rows[0].Field<byte[]>(0));
                    MemoryStream ms = new MemoryStream(ap);
                    return Image.FromStream(ms);
                }
                else return null;

            }
            catch
            {
                return null;
            }

        }

        private void ShowPatientInfo(long VNUID)
        {
            //progressLoad.Visible = true;
            //pnLoad.Visible = true;
            //PatientController PT = new PatientController();
            DataTable dtP = new DataTable();



            //if (!ctlR.Result_IsResultInCheckUP(PatientUID, VNUID))
            //{
            //    SynLabResultFromHO(PatientUID, VNUID);
            //    //ดึงข้อมูลจาก HO แก้ไข 20/04/2558
            //}
             
            //DataTable dtPA = new DataTable();
            //dtPA = npg.GetPatientAddress(hn);
            ////dtPA = ctlP.Patient_GetAddress(PatientUID);

            //if (dtPA.Rows.Count > 0)
            //{           
            //txtAddress.Text = string.Concat(dtPA.Rows[0].Field<string>("PatientAddress"));
            //ddlProvince.EditValue = string.Concat(dtPA.Rows[0].Field<string>("PatientProvince"));
            //txtZipCode.Text = string.Concat(dtPA.Rows[0].Field<string>("ZipCode"));
            //}

            //dtPA = null;



            dtP =   ctlP.Patient_GetPatientOrderInCheckUp(VNUID);

            if (dtP.Rows.Count > 0)
            {
             
                lblHN.Text = string.Concat(dtP.Rows[0].Field<string>("hn"));
                lblStaffID.Text = string.Concat(dtP.Rows[0].Field<string>("EmployeeID"));
                GlobalVariables.gPatientVisitUID = dtP.Rows[0].Field<long>("PatientVisitID");
                GlobalVariables.gPatientUID = PatientUID;

                lblPatientVisitUID.Text = dtP.Rows[0].Field<long>("PatientVisitID").ToString();
                //lblPatientUID.Text = PatientUID.ToString();
                lblVisitNumber.Text = string.Concat(dtP.Rows[0].Field<string>("vn"));
                lblVisitNo.Text = string.Concat(dtP.Rows[0].Field<string>("vn"));
                lblVisitDate.Text = string.Concat(dtP.Rows[0].Field<DateTime>("VisitDTTM"));
                lblPatientName.Text = string.Concat(dtP.Rows[0].Field<string>("PatientName"));
                lblAge.Text = string.Concat(dtP.Rows[0].Field<string>("Age"));
                lblGender.Text = string.Concat(dtP.Rows[0].Field<string>("Sex"));

                lblIdcard.Text = string.Concat(dtP.Rows[0].Field<string>("CardID"));
                lblDOB.Text = string.Concat(dtP.Rows[0].Field<string>("DOB"));
                lblNationality.Text = string.Concat(dtP.Rows[0].Field<string>("Nationality"));
                lblReligion.Text = string.Concat(dtP.Rows[0].Field<string>("Religion"));
                lblTel.Text = string.Concat(dtP.Rows[0].Field<string>("PhoneNumber"));
                lblPayor.Text = string.Concat(dtP.Rows[0].Field<string>("PayorName"));

                txtAddress.Text = string.Concat(dtP.Rows[0].Field<string>("PatientAddress"));
                ddlProvince.EditValue = string.Concat(dtP.Rows[0].Field<string>("PatientProvince"));
                txtZipCode.Text = string.Concat(dtP.Rows[0].Field<string>("ZipCode"));

                //Header Document 

                lblDocumentStatus.Text = "Pending";

                if (string.Concat(dtP.Rows[0]["FinalStatus"])=="1")
                {
                    lblDocumentStatus.Text = "Finalize";
                }
                else
                {
                    if (string.Concat(dtP.Rows[0]["SaveTXTDTTM"]) != "")
                    {
                        lblDocumentStatus.Text = "Save Temporary";
                    }                       
                }

                lblUpdBy.Text = string.Concat(dtP.Rows[0].Field<string>("UpdBy"));
                lblLastUpd.Text = string.Concat(dtP.Rows[0].Field<string>("UpdTime"));

                // End Document 

                //pictureEdit1.Image = GetPatientImage(dtP.Rows[0].Field<long>("PatientUID"));
                pictureEdit1.Image = GetPatientImage(dtP.Rows[0].Field<string>("hn"));
         
                GetPatientPhysicalHOSxP(hn, vn);

                //GetPhysicalExamResult(dtP.Rows[0].Field<long>("PatientUID"), dtP.Rows[0].Field<long>("PatientVisitID"));

                //GetLabHeader(dtP.Rows[0].Field<long>("PatientUID"), dtP.Rows[0].Field<long>("PatientVisitID"));

                //GetPatientDesease(dtP.Rows[0].Field<long>("PatientUID"), dtP.Rows[0].Field<long>("PatientVisitID"));

                //Check is Student

                //dtVS = ctlR.Result_CheckAudiogramOrder(dtP.Rows[0].Field<long>("PatientVisitID"));
         
                    SynAudiogram(dtP.Rows[0].Field<long>("PatientVisitID"));
                    //GetStudentResult(dtP.Rows[0].Field<long>("PatientUID"), dtP.Rows[0].Field<long>("PatientVisitID"));
                      
                    //Load General Appearance and vision screening
                    //SynGA2CheckUp(VNUID);
                    GetGeneralAppearanceResult(dtP.Rows[0].Field<long>("PatientVisitID"));                  
                    dockPanelGA.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
       
                               
                cmdTempSave.Visible = true;
                cmdFinalize.Visible = true;

                cmdPrintResultBookCover.Visible = true;
                cmdPrintResultBook.Visible = true;
                cmdPrintResultNew.Visible = true;
                cmdPrintResultOld.Visible = true;
                cmdPrintResultStudent.Visible = false;


                UserController ctlUser = new UserController();



                if (ctlUser.User_IsSuperUser(DataHelper.LoginUser)) //ถ้าให้สิทธิ์ในการแก้ไข/บันทึก ต้องเป็น SuperUser
                {
                    cmdAdminSave.Visible = true;

                    if  (GlobalFunctions.StrNull2Zero(string.Concat(dtP.Rows[0]["FinalStatus"])) == 1) //ถ้า Finalized แล้ว
                    {                    
                        //SetControlPermission(True)
                        cmdTempSave.Visible = false;
                        cmdFinalize.Visible = true;
                        //pnFinalReason.Visible = true;
                        //SetPermissionFinalCase()     
                    }
                    else //ถ้ายังไม่ Final ให้บันทึก Temp / Final 
                    {
                        cmdTempSave.Visible = true;
                        cmdFinalize.Visible = true;

                        cmdPrintResultBookCover.Visible = true;
                        cmdPrintResultBook.Visible = true;
                        cmdPrintResultNew.Visible = true;
                        cmdPrintResultOld.Visible = true;
                        cmdPrintResultStudent.Visible = false;
                    }


                }
                else //ถ้าให้ดูผลอย่างเดียว
                {
                    cmdTempSave.Visible = false;
                    cmdFinalize.Visible = false;
                    cmdAdminSave.Visible = false;
                }

                if (string.IsNullOrEmpty(GlobalFunctions.DBNull2Str(dtP.Rows[0].Field<string>("SaveDTTM")))) //ถ้ายังไม่มีการ Save มาก่อนให้ซ่อนปุ่ม print รายงานผลทั้งหมด
                   {
                    cmdPrintResultBookCover.Visible = false;
                    cmdPrintResultBook.Visible = false;
                    cmdPrintResultOld.Visible = false;
                    cmdPrintResultNew.Visible = false;
                    cmdPrintResultStudent.Visible = false;
                }
                else
                    {
                    cmdPrintResultBookCover.Visible = true;
                    cmdPrintResultBook.Visible = true;
                    cmdPrintResultNew.Visible = true;
                    cmdPrintResultOld.Visible = true;
                    cmdPrintResultStudent.Visible = false;
                }

            }
            else
            {
                MessageBox.Show("ไม่สามารถดึงข้อมูลจากฐานข้อมูลได้ กรุณาลองใหม่อีกครั้งหรือแจ้งเจ้าหน้าที่ดูแลระบบ โทร.6702?", "ผิดพลาด", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                     
            }

            dtP = null;

        }

        private void SynAudiogram(long VNUID)
        {
            DataTable dtAu = new DataTable();

            //dtAu = ctlR.Result_CheckAudiogramOrder(VNUID);
            dtAu = npg.CheckAudiogramOrder(vn);
            if (dtAu != null && dtAu.Rows.Count > 0)
            {
                dockPanelAudiogram.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                GlobalVariables.gIsAudiogram= true;
                dockPanelAudiogram.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                //สมรรถภาพการได้ยิน()
                ctlR.Result_GeneralAppearance_Add(VNUID, "AU001R", "", "หูขวา", "", "", Convert.ToInt32(DataHelper.usercode), Convert.ToInt32(DataHelper.usercode), "AU");
                ctlR.Result_GeneralAppearance_Add(VNUID, "AU001L", "", "หูซ้าย", "", "", Convert.ToInt32(DataHelper.usercode), Convert.ToInt32(DataHelper.usercode), "AU");
                ddlEarsRight.Enabled = true;
                ddlEarsRightRemark.Enabled = true;
                ddlEarsRight.BackColor = Color.White;

                ddlEarsLeft.Enabled = true;
                ddlEarsLeftRemark.Enabled = true;
                ddlEarsLeft.BackColor = Color.White;
             
            }
            else
            {
                ddlEarsRight.Enabled = false;
                ddlEarsRightRemark.Enabled = false;
                ddlEarsRight.BackColor = ColorTranslator.FromHtml("#ebebe4");

                ddlEarsLeft.Enabled = false;
                ddlEarsLeftRemark.Enabled = false;
                ddlEarsLeft.BackColor = ColorTranslator.FromHtml("#ebebe4");
                dockPanelAudiogram.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                GlobalVariables.gIsAudiogram = false;
            }
            dtAu = null;

        }

        private void SynGA2CheckUp(long VNUID)
        {
            DataTable dtGA = new DataTable();
            string pNormal = null;
            string YesOrNo = null;
            //dtGA = ctlR.Result_GetGAfromHOResult(VNUID);
            dtGA = npg.GetPatientGeneralApperanceHOSxP(vn);
            if (dtGA !=null && dtGA.Rows.Count > 0)
            {
                var K = dtGA.Rows[0];
                pNormal = GlobalFunctions.DisplayAbnormalTXT(K.Field<string>("LevelCon"));
                YesOrNo = GlobalFunctions.DisplayYesOrNoTXT(K.Field<string>("LevelCon"));
                ctlR.Result_GeneralAppearance_Add(VNUID, "GA001", pNormal, "สติสัมปชัญญะ/Level Of Consciousne", YesOrNo, "", Convert.ToInt32(DataHelper.usercode), Convert.ToInt32(DataHelper.usercode), "GA");

                pNormal = GlobalFunctions.DisplayAbnormalTXT(K.Field<string>("Head"));
                YesOrNo = GlobalFunctions.DisplayYesOrNoTXT(K.Field<string>("Head"));
                ctlR.Result_GeneralAppearance_Add(VNUID, "GA002", pNormal, "ศีรษะ,หน้า/Head,Face", YesOrNo, "", Convert.ToInt32(DataHelper.usercode), Convert.ToInt32(DataHelper.usercode), "GA");

                pNormal = GlobalFunctions.DisplayAbnormalTXT(K.Field<string>("Eye"));
                YesOrNo = GlobalFunctions.DisplayYesOrNoTXT(K.Field<string>("Eye"));
                ctlR.Result_GeneralAppearance_Add(VNUID, "GA003", pNormal, "ตา/Eye ", YesOrNo, "", Convert.ToInt32(DataHelper.usercode), Convert.ToInt32(DataHelper.usercode), "GA");

                pNormal = GlobalFunctions.DisplayAbnormalTXT(K.Field<string>("Ear"));
                YesOrNo = GlobalFunctions.DisplayYesOrNoTXT(K.Field<string>("Ear"));
                ctlR.Result_GeneralAppearance_Add(VNUID, "GA004", pNormal, "หู,จมูก/Ears,Nose", YesOrNo, "", Convert.ToInt32(DataHelper.usercode), Convert.ToInt32(DataHelper.usercode), "GA");

                pNormal = GlobalFunctions.DisplayAbnormalTXT(K.Field<string>("Mouth"));
                YesOrNo = GlobalFunctions.DisplayYesOrNoTXT(K.Field<string>("Mouth"));
                ctlR.Result_GeneralAppearance_Add(VNUID, "GA005", pNormal, "ปาก,คอ/Mouth,Throat", YesOrNo, "", Convert.ToInt32(DataHelper.usercode), Convert.ToInt32(DataHelper.usercode), "GA");

                pNormal = GlobalFunctions.DisplayAbnormalTXT(K.Field<string>("LYM"));
                YesOrNo = GlobalFunctions.DisplayYesOrNoTXT(K.Field<string>("LYM"));
                ctlR.Result_GeneralAppearance_Add(VNUID, "GA006", pNormal, "ต่อมน้ำเหลือง/Lymph Node", YesOrNo, "", Convert.ToInt32(DataHelper.usercode), Convert.ToInt32(DataHelper.usercode), "GA");

                pNormal = GlobalFunctions.DisplayAbnormalTXT(K.Field<string>("Thyroid"));
                YesOrNo = GlobalFunctions.DisplayYesOrNoTXT(K.Field<string>("Thyroid"));
                ctlR.Result_GeneralAppearance_Add(VNUID, "GA007", pNormal, "ต่อมไทรอยด์/Thyroid", YesOrNo, "", Convert.ToInt32(DataHelper.usercode), Convert.ToInt32(DataHelper.usercode), "GA");

                pNormal = GlobalFunctions.DisplayAbnormalTXT(K.Field<string>("Lung"));
                YesOrNo = GlobalFunctions.DisplayYesOrNoTXT(K.Field<string>("Lung"));
                ctlR.Result_GeneralAppearance_Add(VNUID, "GA008", pNormal, "ปอด,หน้าอก,เต้านม/Lung,Chest,Breast", YesOrNo, "", Convert.ToInt32(DataHelper.usercode), Convert.ToInt32(DataHelper.usercode), "GA");

                pNormal = GlobalFunctions.DisplayAbnormalTXT(K.Field<string>("Heart"));
                YesOrNo = GlobalFunctions.DisplayYesOrNoTXT(K.Field<string>("Heart"));
                ctlR.Result_GeneralAppearance_Add(VNUID, "GA009", pNormal, "หัวใจ/Heart", YesOrNo, "", Convert.ToInt32(DataHelper.usercode), Convert.ToInt32(DataHelper.usercode), "GA");

                pNormal = GlobalFunctions.DisplayAbnormalTXT(K.Field<string>("Abdomen"));
                YesOrNo = GlobalFunctions.DisplayYesOrNoTXT(K.Field<string>("Abdomen"));
                ctlR.Result_GeneralAppearance_Add(VNUID, "GA010", pNormal, "ช่องท้อง/Abdomen", YesOrNo, "", Convert.ToInt32(DataHelper.usercode), Convert.ToInt32(DataHelper.usercode), "GA");

                pNormal = GlobalFunctions.DisplayAbnormalTXT(K.Field<string>("Extre"));
                YesOrNo = GlobalFunctions.DisplayYesOrNoTXT(K.Field<string>("Extre"));
                ctlR.Result_GeneralAppearance_Add(VNUID, "GA011", pNormal, "แขน,ขา/Extremities", YesOrNo, "", Convert.ToInt32(DataHelper.usercode), Convert.ToInt32(DataHelper.usercode), "GA");

                pNormal = GlobalFunctions.DisplayAbnormalTXT(K.Field<string>("Skin"));
                YesOrNo = GlobalFunctions.DisplayYesOrNoTXT(K.Field<string>("Skin"));
                ctlR.Result_GeneralAppearance_Add(VNUID, "GA012", pNormal, "ผิวหนัง/Skin", YesOrNo, "", Convert.ToInt32(DataHelper.usercode), Convert.ToInt32(DataHelper.usercode), "GA");

                pNormal = GlobalFunctions.DisplayAbnormalTXT(K.Field<string>("Other"));
                YesOrNo = GlobalFunctions.DisplayYesOrNoTXT(K.Field<string>("Other"));
                ctlR.Result_GeneralAppearance_Add(VNUID, "GA099", "", "อื่นๆ/Others", "", "", Convert.ToInt32(DataHelper.usercode), Convert.ToInt32(DataHelper.usercode), "GA");

            }
            dtGA = null;
        }

        private void GetGeneralAppearanceResult(long VNUID)
        {
            DataTable dtR = new DataTable();
            dtR = ctlR.Result_GetGAResult(VNUID);
            if (dtR.Rows.Count == 0)
            {
                SynGA2CheckUp(VNUID);

            }
            else
            {
                for (i = 0; i <= dtR.Rows.Count - 1; i++)
                {
                    var K = dtR.Rows[i];
                    switch (dtR.Rows[i].Field<string>("ItemCode"))
                    {
                        case "GA000":
                            chkNoCheck.Checked = true;
                            break;
                        case "GA001":
                            ddlGA_LevelOfConsciousne.EditValue =GlobalFunctions.DisplayYN2NormalTXTGA(K.Field<string>("isAbnormal"));
                            txtGA_LevelOfConsciousne.Text = K.Field<string>("TXTRemark");
                            switch (K.Field<string>("isAbnormal"))
                            {
                                case "Y":
                                case "L":
                                case "H":
                                    txtGA_LevelOfConsciousne.ForeColor = Color.DeepPink;
                                    ddlGA_LevelOfConsciousne.ForeColor = Color.DeepPink;

                                    break;
                            }
                            break;
                        case "GA002":
                            ddlGA_HeadAndFace.EditValue = GlobalFunctions.DisplayYN2NormalTXTGA(K.Field<string>("isAbnormal"));
                            txtGA_HeadAndFace.Text = K.Field<string>("TXTRemark");
                            switch (K.Field<string>("isAbnormal"))
                            {

                                case "Y":
                                case "L":
                                case "H":
                                    ddlGA_HeadAndFace.ForeColor = Color.DeepPink;
                                    txtGA_HeadAndFace.ForeColor = Color.DeepPink;
                                    break;
                            }
                            break;
                        case "GA003":
                            ddlGA_Eye.EditValue = GlobalFunctions.DisplayYN2NormalTXTGA(K.Field<string>("isAbnormal"));
                            txtGA_Eye.Text = K.Field<string>("TXTRemark");
                            switch (K.Field<string>("isAbnormal"))
                            {

                                case "Y":
                                case "L":
                                case "H":
                                    ddlGA_Eye.ForeColor = Color.DeepPink;
                                    txtGA_Eye.ForeColor = Color.DeepPink;
                                    break;
                            }
                            break;
                        case "GA004":
                            ddlGA_EareAndNose.EditValue = GlobalFunctions.DisplayYN2NormalTXTGA(K.Field<string>("isAbnormal"));
                            txtGA_EareAndNose.Text = K.Field<string>("TXTRemark");
                            switch (K.Field<string>("isAbnormal"))
                            {

                                case "Y":
                                case "L":
                                case "H":
                                    ddlGA_EareAndNose.ForeColor = Color.DeepPink;
                                    txtGA_EareAndNose.ForeColor = Color.DeepPink;
                                    break;
                            }
                            break;
                        case "GA005":
                            ddlGA_MouthAndThroat.EditValue = GlobalFunctions.DisplayYN2NormalTXTGA(K.Field<string>("isAbnormal"));
                            txtGA_MouthAndThroat.Text = K.Field<string>("TXTRemark");
                            switch (K.Field<string>("isAbnormal"))
                            {

                                case "Y":
                                case "L":
                                case "H":
                                    ddlGA_MouthAndThroat.ForeColor = Color.DeepPink;
                                    txtGA_MouthAndThroat.ForeColor = Color.DeepPink;
                                    break;
                            }
                            break;
                        case "GA006":
                            ddlGA_Lymphoma.EditValue = GlobalFunctions.DisplayYN2NormalTXTGA(K.Field<string>("isAbnormal"));
                            txtGA_Lymphoma.Text = K.Field<string>("TXTRemark");
                            switch (K.Field<string>("isAbnormal"))
                            {

                                case "Y":
                                case "L":
                                case "H":
                                    ddlGA_Lymphoma.ForeColor = Color.DeepPink;
                                    txtGA_Lymphoma.ForeColor = Color.DeepPink;
                                    break;
                            }
                            break;
                        case "GA007":
                            ddlGA_Thyroid.EditValue = GlobalFunctions.DisplayYN2NormalTXTGA(K.Field<string>("isAbnormal"));
                            txtGA_Thyroid.Text = K.Field<string>("TXTRemark");
                            switch (K.Field<string>("isAbnormal"))
                            {

                                case "Y":
                                case "L":
                                case "H":
                                    ddlGA_Thyroid.ForeColor = Color.DeepPink;
                                    txtGA_Thyroid.ForeColor = Color.DeepPink;
                                    break;
                            }
                            break;
                        case "GA008":
                            ddlGA_LungChestBreast.EditValue = GlobalFunctions.DisplayYN2NormalTXTGA(K.Field<string>("isAbnormal"));
                            txtGA_LungChestBreast.Text = K.Field<string>("TXTRemark");
                            switch (K.Field<string>("isAbnormal"))
                            {

                                case "Y":
                                case "L":
                                case "H":
                                    ddlGA_LungChestBreast.ForeColor = Color.DeepPink;
                                    txtGA_LungChestBreast.ForeColor = Color.DeepPink;
                                    break;
                            }
                            break;
                        case "GA009":
                            ddlGA_Heart.EditValue = GlobalFunctions.DisplayYN2NormalTXTGA(K.Field<string>("isAbnormal"));
                            txtGA_Heart.Text = K.Field<string>("TXTRemark");
                            switch (K.Field<string>("isAbnormal"))
                            {
                                case "Y":
                                case "L":
                                case "H":
                                    ddlGA_Heart.ForeColor = Color.DeepPink;
                                    txtGA_Heart.ForeColor = Color.DeepPink;
                                    break;
                            }
                            break;
                        case "GA010":
                            ddlGA_Abdomen.EditValue = GlobalFunctions.DisplayYN2NormalTXTGA(K.Field<string>("isAbnormal"));
                            txtGA_Abdomen.Text = K.Field<string>("TXTRemark");
                            switch (K.Field<string>("isAbnormal"))
                            {
                                case "Y":
                                case "L":
                                case "H":
                                    ddlGA_Abdomen.ForeColor = Color.DeepPink;
                                    txtGA_Abdomen.ForeColor = Color.DeepPink;
                                    break;
                            }
                            break;
                        case "GA011":
                            ddlGA_Extremties.EditValue = GlobalFunctions.DisplayYN2NormalTXTGA(K.Field<string>("isAbnormal"));
                            txtGA_Extremties.Text = K.Field<string>("TXTRemark");
                            switch (K.Field<string>("isAbnormal"))
                            {
                                case "Y":
                                case "L":
                                case "H":
                                    ddlGA_Extremties.ForeColor = Color.DeepPink;
                                    txtGA_Extremties.ForeColor = Color.DeepPink;
                                    break;
                            }
                            break;
                        case "GA012":
                            ddlGA_Skin.EditValue = GlobalFunctions.DisplayYN2NormalTXTGA(K.Field<string>("isAbnormal"));
                            txtGA_Skin.Text = K.Field<string>("TXTRemark");
                            switch (K.Field<string>("isAbnormal"))
                            {
                                case "Y":
                                case "L":
                                case "H":
                                    ddlGA_Skin.ForeColor = Color.DeepPink;
                                    txtGA_Skin.ForeColor = Color.DeepPink;
                                    break;
                            }
                            break;
                        case "GA099":
                            ddlGA_Others.EditValue = GlobalFunctions.DisplayYN2NormalTXTGA(string.Concat(K.Field<string>("isAbnormal")));
                            txtGA_Others.Text = string.Concat(K.Field<string>("TXTRemark"));
                            switch (K.Field<string>("isAbnormal"))
                            {
                                case "Y":
                                case "L":
                                case "H":
                                    ddlGA_Others.ForeColor = Color.DeepPink;
                                    txtGA_Others.ForeColor = Color.DeepPink;
                                    break;
                            }

                            break;
                        case "AU001R":
                            if (!string.IsNullOrEmpty(GlobalFunctions.DBNull2Str(K.Field<string>("isAbnormal"))))
                            {
                                ddlEarsRight.Enabled = true;
                                ddlEarsRightRemark.Enabled = true;
                                ddlEarsRight.EditValue = GlobalFunctions.DisplayYN2NormalTXTGA(K.Field<string>("isAbnormal"));
                                ddlEarsRightRemark.Text = K.Field<string>("TXTRemark");

                                switch (K.Field<string>("isAbnormal"))
                                {
                                    case "Y":
                                    case "L":
                                    case "H":
                                        ddlEarsRight.ForeColor = Color.DeepPink;
                                        ddlEarsRightRemark.ForeColor = Color.DeepPink;
                                        break;
                                }
                            }
                            break;
                        case "AU001L":
                            if (!string.IsNullOrEmpty(GlobalFunctions.DBNull2Str(K.Field<string>("isAbnormal"))))
                            {
                                ddlEarsLeft.Enabled = true;
                                ddlEarsLeftRemark.Enabled = true;
                                ddlEarsLeft.EditValue = GlobalFunctions.DisplayYN2NormalTXTGA(K.Field<string>("isAbnormal"));
                                ddlEarsLeftRemark.Text = K.Field<string>("TXTRemark");

                                switch (K.Field<string>("isAbnormal"))
                                {
                                    case "Y":
                                    case "L":
                                    case "H":
                                        ddlEarsLeft.ForeColor = Color.DeepPink;
                                        ddlEarsLeftRemark.ForeColor = Color.DeepPink;
                                        break;
                                }
                            }
                            break;
                    }
                }
            }
            dtR = null;
        }

        private void GetPatientDesease(string hn)
        {
            DataTable dtPhy = new DataTable();
            dtPhy = ctlP.Patient_MedicalHistory(hn);

            if (dtPhy.Rows.Count > 0)
            {
                for (i = 0; i <= dtPhy.Rows.Count - 1; i++)
                {
                    var DR1 = dtPhy.Rows[i];
                    lblMedicalHistory.Text += "- " + dtPhy.Rows[i].Field<string>("MedicalItemName") + Constants.vbCrLf;
                }
            }
            else
            {
                lblMedicalHistory.Text = "-";
            }
            dtPhy = null;

        }
        private void GetPatientPhysicalHOSxP(string hn,string vn)
        {
            DataTable dtPhy = new DataTable();
            dtPhy = npg.GetPatientPhysicalHOSxP(hn,vn);
            if (dtPhy != null && dtPhy.Rows.Count > 0)
            { 
                //lblShape.Text = GlobalFunctions.DBNull2Str(dtPhy.Rows[0].Field<string>("HL"));
                //lblWaist.Text = GlobalFunctions.DBNull2Str(dtPhy.Rows[0].Field<string>("WL"));
                lblBMI.Text = GlobalFunctions.DBNull2Str(dtPhy.Rows[0].Field<decimal>("bmi").ToString("#.##"));
                lblWeight.Text = GlobalFunctions.DBNull2Str(dtPhy.Rows[0].Field<decimal>("bw").ToString("#.##"));
                lblHeight.Text = GlobalFunctions.DBNull2Str(dtPhy.Rows[0].Field<decimal>("Height").ToString("#.##"));
                lblTemperature.Text = GlobalFunctions.DBNull2Str(dtPhy.Rows[0].Field<decimal>("Temperature").ToString("#.##"));
                lblPluse.Text = GlobalFunctions.DBNull2Str(dtPhy.Rows[0].Field<decimal>("Pulse").ToString("#"));
                lblBP.Text = GlobalFunctions.DBNull2Str(dtPhy.Rows[0].Field<decimal>("BPD").ToString("#")) + "/" + GlobalFunctions.DBNull2Str(dtPhy.Rows[0].Field<decimal>("BPS").ToString("#"));
                lblRR.Text = GlobalFunctions.DBNull2Str(dtPhy.Rows[0].Field<decimal>("RR").ToString("#"));
                lblMedicalHistory.Text += "- " + dtPhy.Rows[i].Field<string>("cc_persist_disease") + Constants.vbCrLf;
            }
            dtPhy = null;
        }

        private void GetPhysicalExamResult(long VNUID)
        {
            DataTable dtPhy = new DataTable();
            dtPhy = ctlR.Patient_GetPhysicalExamResult(VNUID);
            if (dtPhy.Rows.Count > 0)
            {
           
                lblShape.Text = GlobalFunctions.DBNull2Str(dtPhy.Rows[0].Field<string>("HL"));
                lblWaist.Text = GlobalFunctions.DBNull2Str(dtPhy.Rows[0].Field<string>("WL"));
                lblBMI.Text = GlobalFunctions.DBNull2Str(dtPhy.Rows[0].Field<string>("BMI"));
                lblWeight.Text = GlobalFunctions.DBNull2Str(dtPhy.Rows[0].Field<string>("Weight"));
                lblHeight.Text = GlobalFunctions.DBNull2Str(dtPhy.Rows[0].Field<string>("Height"));
                lblTemperature.Text = GlobalFunctions.DBNull2Str(dtPhy.Rows[0].Field<string>("Temperature"));
                lblPluse.Text = GlobalFunctions.DBNull2Str(dtPhy.Rows[0].Field<string>("Pulse"));
                lblBP.Text = GlobalFunctions.DBNull2Str(dtPhy.Rows[0].Field<string>("BP"));
                lblRR.Text = GlobalFunctions.DBNull2Str(dtPhy.Rows[0].Field<string>("RR"));


            }
            dtPhy = null;
        }

        private void SynLabResultFromHO(long VNUID)
        {
            DataTable dtHO = new DataTable();
            DataTable dtSP = new DataTable();
            //ctlP.SyncPatientCheckUPFromHO(PatientUID, VNUID, GlobalFunctions.UserID) 
            dtHO = ctlR.Result_GetLabResultFromHO(VNUID);
            if (dtHO.Rows.Count > 0)
            {
                for (i = 0; i <= dtHO.Rows.Count - 1;)
                {
                    //switch (dtHO.Rows[i].Field<string>("ResultItemCode"))
                    //{
                    //    case"LP125", "LP127", "DX0002", "DX0011", "DX0012", "DX0020", "DX0027", "DX0028", "DX0030", "XRCT013", "XRCT043", "XRCT046", "XRGEN001", "XRGEN025", "XRGEN053", "XRGEN057", "XRGEN198", "XRGEN199", "XRGEN351", "XRMR002", "XRMR022", "XRMR027", "XRMR040", "XRMR043", "XRSP011", "XRUS003", "XRUS018", "XRUS019", "XRUS029", "XRUS031":
                    ctlR.SyncLabResultFromHO(VNUID, dtHO.Rows[i].Field<string>("ResultItemCode"), dtHO.Rows[i].Field<string>("ResultValue"), GlobalVariables.UserID);
                    break;
                        
                    //}

                }
            }

            dtSP = ctlR.Result_GetSpecialResultFromHO(VNUID);
            if (dtSP.Rows.Count > 0)
            {
                for (i = 0; i <= dtSP.Rows.Count - 1; i++)
                {
                    ctlR.SyncSpecialResultFromHO(VNUID, dtSP.Rows[i].Field<string>("ResultItemCode"), dtSP.Rows[i].Field<string>("ResultValue"), GlobalVariables.UserID);
                }
            }

            dtHO = null;
            dtSP = null;
        }

        private void SynVisibility(long VNUID)
        {
            DataTable dtVS = new DataTable();
            bool n = false;
            string pNormal = null;
            string pNormalTXT = null;

            //dtVS = ctlR.Result_CheckVisibilityOrder(PUID, VNUID);
            dtVS = npg.CheckEyeOrder(vn);
            if (dtVS != null && dtVS.Rows.Count > 0)
            {
                dockPanelVision.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;

                DataTable dtEye = new DataTable();

                dtEye = npg.GetEyeResult(vn);

                for (i = 0; i <= dtEye.Rows.Count - 1; i++)
                {
                    var K = dtEye.Rows[i];



                    switch (K.Field<string>("code"))
                    {
                        case "DX0006":
                            //ตาบอดสี
                            ctlR.Result_GeneralAppearance_Add(VNUID, "VS003", K.Field<string>("ckup_eye_abnormal_color"), "ตาบอดสี", "", "",  Convert.ToInt32(DataHelper.usercode),  Convert.ToInt32(DataHelper.usercode), "VS");
                            n = true;
                            ddlVS_Blind.Enabled = true;
                            txtVS_BlindRemark.Enabled = true;
                            break;
                        case "DX0027":
                        case "3046050":
                            ctlR.Result_GeneralAppearance_Add(VNUID, "VS002R", K.Field<string>("ckup_eye_pressure_right"), "ความดันลูกตา(ตาขวา)", "", "",  Convert.ToInt32(DataHelper.usercode),  Convert.ToInt32(DataHelper.usercode), "VS");
                            ctlR.Result_GeneralAppearance_Add(VNUID, "VS002L", K.Field<string>("ckup_eye_pressure_left"), "ความดันลูกตา(ตาซ้าย)", "", "",  Convert.ToInt32(DataHelper.usercode),  Convert.ToInt32(DataHelper.usercode), "VS");
                            n = true;
                            txtVS_EyeballLeft.Enabled = true;
                            ddlVS_EyeballLeft.Enabled = true;
                            txtVS_EyeballRight.Enabled = true;
                            txtVS_EyeballRight.Enabled = true;
                            break;
                        case "DX0028":
                        case "3046051":
                            ctlR.Result_GeneralAppearance_Add(VNUID, "VS001R", K.Field<string>("ckup_eye_va_mid_left_note"), "การมองเห็น(ตาขวา)", "", "",  Convert.ToInt32(DataHelper.usercode),  Convert.ToInt32(DataHelper.usercode), "VS");
                            ctlR.Result_GeneralAppearance_Add(VNUID, "VS001L", K.Field<string>("ckup_eye_va_mid_right_note"), "การมองเห็น(ตาซ้าย)", "", "",  Convert.ToInt32(DataHelper.usercode),  Convert.ToInt32(DataHelper.usercode), "VS");
                            n = true;

                            ddlVS_VisibilityLeft.Enabled = true;
                            txtVS_VisibilityLeft.Enabled = true;
                            txtVS_VisibilityRight.Enabled = true;
                            txtVS_VisibilityRight.Enabled = true;

                            break;
                        case "DX0030":
                            if (ctlR.Result_VS_fromFillupForm(VNUID, 2920) == "Yes")
                            {
                                pNormal = "Y";
                                pNormalTXT = "Normal";
                            }
                            else if (ctlR.Result_VS_fromFillupForm(VNUID, 2920) == "No")
                            {
                                pNormal = "N";
                                pNormalTXT = "Abnormal";
                            }
                            else
                            {
                                pNormal = "";
                                pNormalTXT = "รอจักษุแพทย์สรุปผล";
                            }

                            ctlR.Result_GeneralAppearance_Add(VNUID, "VS004R", pNormalTXT, "จอประสาทตา(ตาขวา)", pNormal, "",  Convert.ToInt32(DataHelper.usercode),  Convert.ToInt32(DataHelper.usercode), "VS");
                            ctlR.Result_GeneralAppearance_Add(VNUID, "VS004L", pNormalTXT, "จอประสาทตา(ตาซ้าย)", pNormal, "",  Convert.ToInt32(DataHelper.usercode),  Convert.ToInt32(DataHelper.usercode), "VS");
                            n = true;
                            ddlVS_RetinaLeft.Enabled = true;
                            txtVS_RetinaLeft.Enabled = true;
                            txtVS_RetinaRight.Enabled = true;
                            txtVS_RetinaRight.Enabled = true;
                            break;
                        //case "DX0003":
                        //    if (Strings.Left(dtEye.Rows[i].Field<string>("itemName"), 3) != "EKG")
                        //    {
                        //        ctlR.Result_GeneralAppearance_Add(VNUID, "VS003", "", "ตาบอดสี", "", "",  Convert.ToInt32(DataHelper.usercode),  Convert.ToInt32(DataHelper.usercode), "VS");
                        //        n = true;
                        //        ddlVS_Blind.Enabled = true;
                        //        txtVS_BlindRemark.Enabled = true;
                        //    }
                        //    else
                        //    {
                        //        dockPanelVision.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                        //    }

                        //    break;
                    }
                }

                if (n == true)
                {
                    //ผลการตรวจทางสายตา
                    ctlR.Result_GeneralAppearance_Add(VNUID, "VS099", "", "ผลการตรวจสายตา", "", "",  Convert.ToInt32(DataHelper.usercode),  Convert.ToInt32(DataHelper.usercode), "VS");
                    ddlVS_Summary.Visible = true;
                }
                else
                {
                    ddlVS_Summary.Visible = false;
                }


            }
        }

        private void ShowVisionScreeningResult(long VNUID)
        {
            DataTable dtV = new DataTable();
            dtV = ctlR.Result_GetVisionScreening(VNUID);

            for (i = 0; i <= dtV.Rows.Count - 1; i++)
            {
                var K1 = dtV.Rows[i];
                switch (dtV.Rows[i].Field<string>("itemCode"))
                {
                    case "VS001L":
                        ddlVS_VisibilityLeft.Enabled = true;
                        ddlVS_VisibilityLeft.BackColor = Color.White;
                        txtVS_VisibilityLeft.Enabled = true;
                        ddlVS_VisibilityLeft.EditValue = K1.Field<string>("isAbnormal");
                        txtVS_VisibilityLeft.Text = K1.Field<string>("ResultValue");
                        switch (K1.Field<string>("isAbnormal"))
                        {
                            case "Y":
                            case "L":
                            case "H":
                                ddlVS_VisibilityLeft.ForeColor = Color.DeepPink;
                                txtVS_VisibilityLeft.ForeColor = Color.DeepPink;
                                break;
                        }
                        break;
                    case "VS001R":
                        ddlVS_VisibilityRight.Enabled = true;
                        ddlVS_VisibilityRight.BackColor = Color.White;
                        txtVS_VisibilityRight.Enabled = true;
                        ddlVS_VisibilityRight.EditValue = K1.Field<string>("isAbnormal");
                        txtVS_VisibilityRight.Text = K1.Field<string>("ResultValue");
                        switch (K1.Field<string>("isAbnormal"))
                        {
                            case "Y":
                            case "L":
                            case "H":
                                ddlVS_VisibilityRight.ForeColor = Color.DeepPink;
                                txtVS_VisibilityRight.ForeColor = Color.DeepPink;
                                break;
                        }
                        break;
                    case "VS002L":
                        ddlVS_EyeballLeft.Enabled = true;
                        ddlVS_EyeballLeft.BackColor = Color.White;
                        txtVS_EyeballLeft.Enabled = true;
                        ddlVS_EyeballLeft.EditValue = K1.Field<string>("isAbnormal");
                        txtVS_EyeballLeft.Text = K1.Field<string>("ResultValue");
                        switch (K1.Field<string>("isAbnormal"))
                        {
                            case "Y":
                            case "L":
                            case "H":
                                ddlVS_EyeballLeft.ForeColor = Color.DeepPink;
                                txtVS_EyeballLeft.ForeColor = Color.DeepPink;
                                break;
                        }
                        break;
                    case "VS002R":
                        ddlVS_EyeballRight.Enabled = true;
                        ddlVS_EyeballRight.BackColor = Color.White;
                        txtVS_EyeballRight.Enabled = true;
                        ddlVS_EyeballRight.EditValue = K1.Field<string>("isAbnormal");
                        txtVS_EyeballRight.Text = K1.Field<string>("ResultValue");
                        switch (K1.Field<string>("isAbnormal"))
                        {
                            case "Y":
                            case "L":
                            case "H":
                                ddlVS_EyeballRight.ForeColor = Color.DeepPink;
                                txtVS_EyeballRight.ForeColor = Color.DeepPink;
                                break;
                        }
                        break;
                    case "VS003":
                        ddlVS_Blind.Enabled = true;
                        ddlVS_Blind.BackColor = Color.White;
                        txtVS_BlindRemark.Enabled = true;
                        //ddlVS_Blind.EditValue = GlobalFunctions.DisplayYN2NormalTXT(K1.Field<string>("isAbnormal"));
                        ddlVS_Blind.EditValue = K1.Field<string>("isAbnormal");
                        txtVS_BlindRemark.Text = K1.Field<string>("TXTRemark");
                        switch (K1.Field<string>("isAbnormal"))
                        {
                            case "Y":
                            case "L":
                            case "H":
                                ddlVS_Blind.ForeColor = Color.DeepPink;
                                txtVS_BlindRemark.ForeColor = Color.DeepPink;
                                break;
                        }
                        break;
                    case "VS004L":
                        ddlVS_RetinaLeft.Enabled = true;
                        ddlVS_RetinaLeft.BackColor = Color.White;
                        txtVS_RetinaLeft.Enabled = true;
                        ddlVS_RetinaLeft.EditValue =K1.Field<string>("isAbnormal");
                        txtVS_RetinaLeft.Text = K1.Field<string>("ResultValue");
                        switch (K1.Field<string>("isAbnormal"))
                        {
                            case "Y":
                            case "L":
                            case "H":
                                ddlVS_RetinaLeft.ForeColor = Color.DeepPink;
                                txtVS_RetinaLeft.ForeColor = Color.DeepPink;
                                break;
                        }
                        break;
                    case "VS004R":
                        ddlVS_RetinaRight.Enabled = true;
                        ddlVS_RetinaRight.BackColor = Color.White;
                        txtVS_RetinaRight.Enabled = true;
                        ddlVS_RetinaRight.EditValue = K1.Field<string>("isAbnormal");
                        txtVS_RetinaRight.Text = K1.Field<string>("ResultValue");
                        switch (K1.Field<string>("isAbnormal"))
                        {
                            case "Y":
                            case "L":
                            case "H":
                                ddlVS_RetinaRight.ForeColor = Color.DeepPink;
                                txtVS_RetinaRight.ForeColor = Color.DeepPink;
                                break;
                        }
                        break;
                    case "VS099":
                        ddlVS_Summary.Enabled = true;
                        ddlVS_Summary.BackColor = Color.White;
                        txtVS_SummaryRemark.Enabled = true;
                        ddlVS_Summary.EditValue = K1.Field<string>("isAbnormal");
                        txtVS_SummaryRemark.Text = K1.Field<string>("TXTRemark");
                        switch (K1.Field<string>("isAbnormal"))
                        {
                            case "Y":
                            case "L":
                            case "H":
                                ddlVS_Summary.ForeColor = Color.DeepPink;
                                txtVS_SummaryRemark.ForeColor = Color.DeepPink;
                                break;
                        }

                        break;
                }
            }
            dtV = null;
        }
        private void ShowAudiogramResult(long VNUID)
        {
            DataTable dtV = new DataTable();
            dtV = ctlR.Result_GetAudiogramResult(VNUID);
            if (dtV.Rows.Count > 0)
            {
                for (i = 0; i <= dtV.Rows.Count - 1; i++)
                {
                    var K = dtV.Rows[i];
                    switch (K.Field<string>("itemCode"))
                    {

                        case "AU001R":
                            if (!string.IsNullOrEmpty(GlobalFunctions.DBNull2Str(K.Field<string>("isAbnormal"))))
                            {
                                ddlEarsRight.Enabled = true;
                                ddlEarsRightRemark.Enabled = true;
                                ddlEarsRight.EditValue = GlobalFunctions.DisplayYN2NormalTXTGA(K.Field<string>("isAbnormal"));
                                ddlEarsRightRemark.Text = K.Field<string>("TXTRemark");
                                switch (K.Field<string>("isAbnormal"))
                                {
                                    case "Y":
                                    case "L":
                                    case "H":
                                        ddlEarsRight.ForeColor = Color.DeepPink;
                                        ddlEarsRightRemark.ForeColor = Color.DeepPink;
                                        break;
                                }
                            }
                            break;
                        case "AU001L":

                            if (!string.IsNullOrEmpty(GlobalFunctions.DBNull2Str(K.Field<string>("isAbnormal"))))
                            {
                                ddlEarsLeft.Enabled = true;
                                ddlEarsLeftRemark.Enabled = true;
                                ddlEarsLeft.EditValue = GlobalFunctions.DisplayYN2NormalTXTGA(K.Field<string>("isAbnormal"));
                                ddlEarsLeftRemark.Text = K.Field<string>("TXTRemark");
                                switch (K.Field<string>("isAbnormal"))
                                {
                                    case "Y":
                                    case "L":
                                    case "H":
                                        ddlEarsLeft.ForeColor = Color.DeepPink;
                                        ddlEarsLeftRemark.ForeColor = Color.DeepPink;
                                        break;
                                }
                            }
                            break;
                    }


                }


            }
            dtV = null;
        }

        private void ShowDoctorResult(long VNUID)
        {
            int dcUID;

            try
            {
                dcUID=Convert.ToInt32(ctlP.Patient_GetCareProviderID(VNUID.ToString()).ToString());
                if (dcUID != 0)
                {
                    ddlDoctor_PE.EditValue = dcUID;
                }
                else
                {
                    ddlDoctor_PE.EditValue = "";
                }
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                
                dcUID = Convert.ToInt32(ctlP.Patient_GetDoctorRecommend(VNUID.ToString()));
                if (dcUID != 0)
                {
                    ddlDoctor_Conclusion.EditValue = dcUID;
                }
                else
                {
                    ddlDoctor_Conclusion.EditValue = Convert.ToInt32(DataHelper.usercode);
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void ShowBloodChemistryResult(long VNUID)
        {            
         DataTable dtR  =  new DataTable();
        dtR = ctlR.Result_GetLabResult(VNUID,"LC");

        if (dtR.Rows.Count > 0)
            {
                dockPanelBloodChemistry.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                gridBloodChemistry.Visible = true;
                gridBloodChemistry.DataSource = dtR;

                gridViewBloodChemistry.Columns[0].Width = 300;
                gridViewBloodChemistry.Columns[1].Width = 120;
                gridViewBloodChemistry.Columns[2].Width = 90;
                gridViewBloodChemistry.Columns[3].Width = 120;
                gridViewBloodChemistry.Columns[5].BestFit();

                //gridBloodChem2.Visible = true;
                //gridBloodChem2.DataSource = dtR;

                //int i;
                //for (i = 0; i <= dtR.Rows.Count - 1; i++)
                //{
                //if (dtR.Rows[i].Field<string>("IsAbnormal") == "Y" || dtR.Rows[i].Field<string>("IsAbnormal") == "L" || dtR.Rows[i].Field<string>("IsAbnormal") == "H")
                //{
                //    gridView2.ActiveEditor.EditValue = "Abnormal";


                //    //DataRow row = gridView2.GetDataRow(i);
                //    //lbl_editItem.Text = Convert.ToString(row[1]);
                //    //te_editUnit.Text = Convert.ToString(row[2]);


                //    //gridView2.GetFocusedRowCellValue("");

                //}
                //else
                //{
                //    gridView2.ActiveEditor.EditValue = "N";
                //}

                //}


            }
        else
        {
            gridBloodChemistry.Visible = false;
            }
        dtR = null;
        }

        private void ShowUrineResult(long VNUID)
        {
            DataTable dtR = new DataTable();
            dtR = ctlR.Result_GetLabResult(VNUID, "UA");

            if (dtR.Rows.Count > 0)
            {

                gridUrine.Visible = true;
                gridUrine.DataSource = dtR;

                //gridViewUrine.Columns[3].Visible = false;
            }
            else
            {
                gridUrine.Visible = false;
            }
            dtR = null;
        }

        private void ShowCBCResult(long VNUID)
        {
            DataTable dtR = new DataTable();
            dtR = ctlR.Result_GetLabResult(VNUID, "CBC");

            if (dtR.Rows.Count > 0)
            {

                //gridCBC.Visible = true;
                //gridCBC.DataSource = dtR;
                //gridViewCBC.Columns[3].Visible = false;
                                
                grdCBC.Visible = true;
                grdCBC.DataSource = dtR;

                //gridViewCBC.Columns[0].Width = 200;
                //gridViewCBC.Columns[1].Width = 150;
                //gridViewCBC.Columns[2].Width = 100;
                //gridViewCBC.Columns[3].BestFit();
                //gridViewCBC.Columns[4].Width = 25;
                //gridViewCBC.Columns[5].BestFit(); 

            }
            else
            {
                //gridCBC.Visible = false;
            }
            dtR = null;
        }

        private void ShowStoolResult(long VNUID)
        {
            DataTable dtR = new DataTable();
            dtR = ctlR.Result_GetLabResult(VNUID, "ST");

            if (dtR.Rows.Count > 0)
            {

                gridStool.Visible = true;
                gridStool.DataSource = dtR;

                //gridViewStool.Columns[3].Visible = false;
            }
            else
            {
                gridStool.Visible = false;
            }
            dtR = null;
        }
        //private void ShowOtherResult(long VNUID)
        //{
        //    DataTable dtR = new DataTable();
        //    dtR = ctlR.Result_GetLabResult(VNUID, "LO");

        //    if (dtR.Rows.Count > 0)
        //    {

        //        gridOtherLab.Visible = true;
        //        gridOtherLab.DataSource = dtR;

        //        gridViewOther.Columns[3].Visible = false;
        //    }
        //    else
        //    {
        //        gridOtherLab.Visible = false;
        //    }
        //    dtR = null;
        //}
        private void ShowStoolCultureResult(long VNUID)
        {
            DataTable dtR = new DataTable();
            dtR = ctlR.Result_GetLabResult(VNUID, "LM");

            if (dtR.Rows.Count > 0)
            {

                gridStoolCulture.Visible = true;
                gridStoolCulture.DataSource = dtR;

                gridViewStoolCulture.Columns[3].Visible = false;
            }
            else
            {
                gridStoolCulture.Visible = false;
            }
            dtR = null;
        }

        private void ShowSpecialTestResult(long VNUID)
        {
            DataTable dtR = new DataTable();
            dtR = ctlR.Result_GetSpecialTestLabResult(VNUID);

            if (dtR.Rows.Count > 0)
            {
                dockPanelSpecial.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                grdSpecialTest.Visible = true;
                grdSpecialTest.DataSource = dtR;
                //grdViewSpecialTest.BestFitColumns();

                //grdViewSpecialTest.Columns[2].Width = 350;
                //grdViewSpecialTest.Columns[3].Width = 200;
                //grdViewSpecialTest.Columns[4].Width = 100;
                //grdViewSpecialTest.Columns[5].BestFit();
                //grdViewSpecialTest.Columns[7].Width = 350;
                //grdViewSpecialTest.Columns[10].Width = 100;

            }
            else
            {
                grdSpecialTest.Visible = false;
                dockPanelSpecial.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            }
            dtR = null;
        }

        private void ShowConfidentialTestResult(long VNUID)
        {
            DataTable dtR = new DataTable();
            dtR = ctlR.Result_GetConfidentialTestResult(VNUID);

            if (dtR.Rows.Count > 0)
            {
                dockPanelConfidential.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                grdConfidential.Visible = true;
                grdConfidential.DataSource = dtR;
            }
            else
            {
                grdConfidential.Visible = false;
                dockPanelConfidential.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            }
            dtR = null;
        }


        private void ShowXrayOrder(long PVN)
        {
            DataTable pDT = new DataTable();

            pDT = ctlR.Result_GetXRAYOrderItem(PVN);

            for (i = 0; i <= pDT.Rows.Count - 1; i++)
            {
                var DR = pDT.Rows[i];
                if (Strings.Left(pDT.Rows[i].Field<string>("Code"), 2) == "XR" | Strings.Left(pDT.Rows[i].Field<string>("Code"), 2) == "DX")
                {
                    switch (pDT.Rows[i].Field<string>("Code"))
                    {
                        case "DX0002":     
                            lblEKG.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            break;
                        case "XRGEN001":
                        case "XRGEN398":
                            lblChestPA.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            break;
                        case "XRUS029":
                            lblUpperAbdomen.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            break;
                        case "XRUS019":
                            lblLowerAbdomen.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            break;
                        case "XRUS031":
                            lblAbdomen.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            break;
                        case "DX0012":
                            lblHeart.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            break;
                        case "DX0011":
                            lblEST.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            break;
                        case "DX0020":
                            lblABI.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            break;
                        case "XRSP011":
                            lblMammogram.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            break;
                        case "XRUS003":
                            lblUsBreast.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            break;

                        case "XRBMD004":
                            lblBMD.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            break;
                    }
                }

            }

            if (Strings.Trim(lblGender.Text) == "ชาย")
            {
                ddlX_Mammogram.Enabled = false;
                ddlX_Mammogram.SelectedText = "";
                txtX_Mammogram.Enabled = false;

                ddlX_USBreast.Enabled = false;
                ddlX_USBreast.SelectedText = "";
                txtX_USBreast.Enabled = false;

                chkPapSmear.Enabled = false;
                txtPapSmear.Text = "";
                txtPapSmear.Enabled = false;

                chkVegina.Enabled = false;
                txtVegina.Text = "";
                txtVegina.Enabled = false;
            }

            pDT = null;
        }

        private void ShowXRAYSummaryResult(DataTable pDT)
        {
            //Dim pDT As New DataTable
            //pDT = ctlR.Result_GetXRAYOrderItem(PVN)

            for (i = 0; i <= pDT.Rows.Count - 1; i++)
            {
                var DR = pDT.Rows[i];
                if (Strings.Left(pDT.Rows[i].Field<string>("ResultItemCode"), 2) == "XR" | Strings.Left(pDT.Rows[i].Field<string>("ResultItemCode"), 2) == "DX")
                {
                    switch (pDT.Rows[i].Field<string>("ResultItemCode"))
                    {
                        case "DX0002":
                            txtX_EKGResult.Enabled = true;
                            txtX_EKGResult.Text = Strings.Replace(string.Concat(DR.Field<string>("ResultValue")),"\n",Constants.vbCrLf);
                            if (txtX_EKGResult.Text == "FT")
                            {
                                txtX_EKGResult.Text = "";
                            }

                            //ddlX_EKG_Send.Enabled = True
                            //ddlX_EKG_Send.BackColor = Color.White
                            //ddlX_EKG_Send.EditValue = String.Concat(.Item("SendToDoctor"))
                            ddlX_EKG.Enabled = true;
                            //ddlX_EKG.EditValue = GlobalFunctions.DisplayXrayYNTXT(DR.Field<string>("isAbnormal"));
                            ddlX_EKG.EditValue =DR.Field<string>("isAbnormal");

                            lblEKG.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            break;
                        case "XRGEN001":
                        case "XRGEN398":
                            txtX_ChestPA.Enabled = true;
                            txtX_ChestPA.Text =Strings.Replace(string.Concat(DR.Field<string>("ResultValue")),"\n",Constants.vbCrLf);
                            //if(txtX_ChestPA.Text == "FT")
                            //{
                            //    txtX_ChestPA.Text = "";
                            //}

                            if (txtX_ChestPA.Text == "FT" | txtX_ChestPA.Text == "")
                            {
                                txtX_ChestPA.Text = SubStringXRAY(ConvertRtfToText(ctlR.Result_GetTexttual(DR.Field<Int64>("ResultComponentUID"))));
                                txtX_ChestPA.Text = Strings.Replace(txtX_ChestPA.Text, "\n", Constants.vbCrLf);
                            }
                            else
                            {
                                txtX_ChestPA.Text = SubStringXRAY(txtX_ChestPA.Text);
                            }
                            xChestPAUID = DR.Field<Int64>("ResultComponentUID");

                            //ddlX_Chest_Send.EditValue = String.Concat(.Item("SendToDoctor"));
                            ddlX_ChestPA.EditValue = DR.Field<string>("isAbnormal");

                            ddlX_ChestPA.Enabled = true;
                            btnX_PA.Visible = true;
                            btnPAC_PA.Visible = true;
                            //ddlX_Chest_Send.Enabled = True

                            lblChestPA.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            break;
                        //ddlX_Chest_Send.BackColor = Color.White
                        case "XRUS029":
                            txtX_UpperAbdomenRemark.Enabled = true;
                            txtX_UpperAbdomenRemark.Text = Strings.Replace(string.Concat(DR.Field<string>("ResultValue")), "\n", Constants.vbCrLf);
                            //if (txtX_UpperAbdomenRemark.Text == "FT")
                            //{
                            //    txtX_UpperAbdomenRemark.Text = "";
                            //}


                            ddlX_UpperAbdomen.Enabled = true;
                            btnX_Upper.Visible = true;
                            btnPAC_Upper.Visible = true;
                            //ddlX_UpperAbdomen.BackColor = Color.White;
                            lblUpperAbdomen.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            if (string.IsNullOrEmpty(txtX_UpperAbdomenRemark.Text) | txtX_UpperAbdomenRemark.Text == "FT")
                            {
                                txtX_UpperAbdomenRemark.Text = SubStringXRAY(ConvertRtfToText(ctlR.Result_GetTexttual(DR.Field<Int64>("ResultComponentUID"))));
                            }
                            xUpperUID = DR.Field<Int64>("ResultComponentUID");
                            ddlX_UpperAbdomen.EditValue = DR.Field<string>("isAbnormal");
                            break;
                        case "XRUS019":
                            txtX_LowerAbdomenRemark.Enabled = true;
                            txtX_LowerAbdomenRemark.Text = Strings.Replace(string.Concat(DR.Field<string>("ResultValue")), "\n", Constants.vbCrLf);
                            //if (txtX_LowerAbdomenRemark.Text == "FT")
                            //{
                            //    txtX_LowerAbdomenRemark.Text = "";
                            //}
                            ddlX_LowerAbdomen.Enabled = true;
                            btnX_Lower.Visible = true;
                            btnPAC_Lower.Visible = true;
                            //ddlX_LowerAbdomen.BackColor = Color.White;
                            lblLowerAbdomen.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            if (string.IsNullOrEmpty(txtX_LowerAbdomenRemark.Text) | txtX_LowerAbdomenRemark.Text == "FT")
                            {
                                txtX_LowerAbdomenRemark.Text = SubStringXRAY(ConvertRtfToText(ctlR.Result_GetTexttual(DR.Field<Int64>("ResultComponentUID"))));
                            }
                            xLowerUID = DR.Field<Int64>("ResultComponentUID");
                            ddlX_LowerAbdomen.EditValue = DR.Field<string>("isAbnormal");

                            break;

                        case "XRUS031":
                            txtX_AbdomenRemark.Enabled = true;
                            txtX_AbdomenRemark.Text = Strings.Replace(string.Concat(DR.Field<string>("ResultValue")), "\n", Constants.vbCrLf);
                            //if (txtX_AbdomenRemark.Text == "FT")
                            //{
                            //    txtX_AbdomenRemark.Text = "";
                            //}
                            ddlX_Abdomen.Enabled = true;
                            btnX_Abdomen.Visible = true;
                            btnPAC_Abdomen.Visible = true;
                            //ddlX_Abdomen.BackColor = Color.White;
                            lblAbdomen.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            if (string.IsNullOrEmpty(txtX_AbdomenRemark.Text) | txtX_AbdomenRemark.Text == "FT")
                            {
                                txtX_AbdomenRemark.Text = SubStringXRAY(ConvertRtfToText(ctlR.Result_GetTexttual(DR.Field<Int64>("ResultComponentUID"))));
                            }

                            xAbdomenUID = DR.Field<Int64>("ResultComponentUID");
                            ddlX_Abdomen.EditValue = DR.Field<string>("isAbnormal");
                            break;
                        case "DX0012":
                            txtX_EchoRemark.Enabled = true;
                            //ddlX_Echo.BackColor = Color.White;
                            lblHeart.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            ddlX_Echo.Enabled = true;
                            btnX_Echo.Visible = true;
                            btnPAC_Echo.Visible = true;

                            txtX_EchoRemark.Text = Strings.Replace(string.Concat(DR.Field<string>("ResultValue")), "\n", Constants.vbCrLf);
                            if (txtX_EchoRemark.Text == "FT")
                            {
                                txtX_EchoRemark.Text = "";
                            }

                            ddlX_Echo.EditValue = DR.Field<string>("isAbnormal");
                            xEchoUID = DR.Field<Int64>("ResultComponentUID");

                            break;
                        case "DX0011":
                            txtX_ESTRemark.Enabled = true;
                            //ddlX_EST.BackColor = Color.White;
                            lblEST.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            ddlX_EST.Enabled = true;
                            txtX_ESTRemark.Text = Strings.Replace(string.Concat(DR.Field<string>("ResultValue")),"\n",Constants.vbCrLf);
                            if (txtX_ESTRemark.Text == "FT")
                            {
                                txtX_ESTRemark.Text = "";
                            }
                            ddlX_EST.EditValue = DR.Field<string>("isAbnormal");                           
                            break;
                        case "DX0020":
                            txtX_ABIRemark.Enabled = true;
                            //ddlX_ABI.BackColor = Color.White;
                            lblABI.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            ddlX_ABI.Enabled = true;
                            txtX_ABIRemark.Text = Strings.Replace(string.Concat(DR.Field<string>("ResultValue")),"\n",Constants.vbCrLf);
                            if (txtX_ABIRemark.Text == "FT")
                            {
                                txtX_ABIRemark.Text = "";
                            }
                            ddlX_ABI.EditValue = DR.Field<string>("isAbnormal");

                            break;
                        case "XRSP011":
                            txtX_Mammogram.Enabled = true;
                            //ddlX_Mammogram.BackColor = Color.White;
                            //txtX_Mammogram.BackColor = Color.White;
                            lblMammogram.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            //txtX_Mammogram.ReadOnly = False
                            btnX_Mammo.Visible = true;
                            btnPAC_Mammo.Visible = true;
                            ddlX_Mammogram.Enabled = true;
                            txtX_Mammogram.Text = Strings.Replace(string.Concat(DR.Field<string>("ResultValue")), "\n", Constants.vbCrLf);
                            //if (txtX_Mammogram.Text == "FT")
                            //{
                            //    txtX_Mammogram.Text = "";
                            //}
                            if (string.IsNullOrEmpty(txtX_Mammogram.Text) | txtX_Mammogram.Text == "FT")
                            {
                                txtX_Mammogram.Text = SubStringXRAY(ConvertRtfToText(ctlR.Result_GetTexttual(DR.Field<Int64>("ResultComponentUID"))));
                            }

                            xMamoUID = DR.Field<Int64>("ResultComponentUID");

                            ddlX_Mammogram.EditValue = GlobalFunctions.DisplayXrayYNTXT2(DR.Field<string>("isAbnormal"));
                            break;
                        case "XRUS003":
                            txtX_USBreast.Enabled = true;
                            //ddlX_USBreast.BackColor = Color.White;
                            //txtX_USBreast.BackColor = Color.White;
                            lblUsBreast.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            //txtX_USBreast.ReadOnly = False
                            btnX_USBreast.Visible = true;
                            btnPAC_USBreast.Visible = true;
                            ddlX_USBreast.Enabled = true;
                            txtX_USBreast.Text = Strings.Replace(string.Concat(DR.Field<string>("ResultValue")), "\n", Constants.vbCrLf);
                            //if (txtX_USBreast.Text == "FT")
                            //{
                            //    txtX_USBreast.Text = "";
                            //}
                            if (string.IsNullOrEmpty(txtX_USBreast.Text) | txtX_USBreast.Text == "FT")
                            {
                                txtX_USBreast.Text = SubStringXRAY(ConvertRtfToText(ctlR.Result_GetTexttual(DR.Field<Int64>("ResultComponentUID"))));
                            }

                            xUSBreastUID = DR.Field<Int64>("ResultComponentUID");

                            ddlX_USBreast.EditValue = GlobalFunctions.DisplayXrayYNTXT2(DR.Field<string>("isAbnormal"));
                            break;
                        case "XRBMD004":
                            txtX_BMDRemark.Enabled = true;
                            //ddlX_BMD.BackColor = Color.White;
                            lblBMD.BackColor = ColorTranslator.FromHtml("#FFCC00");
                            ddlX_BMD.Enabled = true;
                            txtX_BMDRemark.Text = Strings.Replace(string.Concat(DR.Field<string>("ResultValue")),"\n",Constants.vbCrLf);
                            //if (txtX_BMDRemark.Text == "FT")
                            //{
                            //    txtX_BMDRemark.Text = "";
                            //}

                            if (string.IsNullOrEmpty(txtX_BMDRemark.Text) | txtX_BMDRemark.Text == "FT")
                            {
                                txtX_BMDRemark.Text = SubStringXRAY(ConvertRtfToText(ctlR.Result_GetTexttual(DR.Field<Int64>("ResultComponentUID"))));
                            }

                            ddlX_BMD.EditValue = DR.Field<string>("isAbnormal");
                            break;
                    }
                }

            }

            if (Strings.Trim(lblGender.Text) == "ชาย")
            {
                ddlX_Mammogram.Enabled = false;
                ddlX_Mammogram.SelectedText = "";
                txtX_Mammogram.Enabled = false;

                ddlX_USBreast.Enabled = false;
                ddlX_USBreast.SelectedText = "";
                txtX_USBreast.Enabled = false;


                chkPapSmear.Enabled = false;
                txtPapSmear.Text = "";
                txtPapSmear.Enabled = false;

                chkVegina.Enabled = false;
                txtVegina.Text = "";
                txtVegina.Enabled = false;
            }

            pDT = null;
        }

        private void ShowPAPsmearResult(long VNUID)
        {
            DataTable dtPap = new DataTable();
            txtPapSmear.Text = "";
            chkPapSmear.Checked = false;

            dtPap = ctlR.PapSmearResult_Get(VNUID,"LP125");
            if (dtPap.Rows.Count > 0)
            {
                var DR1 = dtPap.Rows[0];
                txtPapSmear.Text = string.Concat(DR1.Field<string>("ResultValue"));
                chkPapSmear.Checked = true;
                if (txtPapSmear.Text.Trim() == "")
                {
                    txtPapSmear.Text = "ผลการตรวจคัดกรองมะเร็งปากมดลูกจะส่งตามที่ผู้ป่วยแสดงความจำนง";
                }

                txtPapSmear.BackColor = ColorTranslator.FromHtml("#FFFFC8");       
                dockPanelEKG.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            }

            dtPap = ctlR.PapSmearResult_Get(VNUID, "LP127");
            if (dtPap.Rows.Count > 0)
            {
                var DR1 = dtPap.Rows[0];
                txtPapSmear.Text = string.Concat(DR1.Field<string>("ResultValue"));
                chkPapSmear.Checked = true;
                if (txtPapSmear.Text.Trim() == "")
                {
                    txtPapSmear.Text = "ผลการตรวจคัดกรองมะเร็งปากมดลูกจะส่งตามที่ผู้ป่วยแสดงความจำนง";
                }

                txtPapSmear.BackColor = ColorTranslator.FromHtml("#FFFFC8");
                dockPanelEKG.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            }
                       

            DataTable dtVegina = new DataTable();
            dtVegina = ctlR.VeginaResult_Get(VNUID);
            if (dtVegina.Rows.Count > 0)
            {
                var DR2 = dtVegina.Rows[0];
                txtVegina.Text = string.Concat(DR2.Field<string>("ResultValue"));
                chkVegina.Checked = true;

                if (txtVegina.Text.Trim()=="")
                {
                    txtVegina.Text = "ตามคำแนะนำของสูตินารีแพทย์";
                }

                txtVegina.BackColor = ColorTranslator.FromHtml("#FFFFC8");
                //navBarGroupSpecialTechnic.Visible = true;
                dockPanelEKG.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            }
            else
            {
                txtVegina.Text = "";
                chkVegina.Checked = false;
            }

            dtVegina = null;
            dtPap = null;
        }

        private void ShowSuggestionFromCheckup(long VNUID)
        {
            DataTable dtR = new DataTable();
            dtR = ctlR.Result_GetSuggestionFromCheckup(VNUID);
            string strSum;
             
            if (dtR.Rows.Count > 0)
            {
                strSum = dtR.Rows[0].Field<string>("SummarySuggestion");

                if (GlobalFunctions.Right(strSum,2)=="\r\n")
                {
                    strSum = GlobalFunctions.Left(strSum, strSum.Length - 2);
                }

                if (GlobalFunctions.Left(strSum,6) == "\r\n- \r\n")
                {
                    strSum = GlobalFunctions.Right(strSum, strSum.Length - 6);
                }
                if (GlobalFunctions.Left(strSum, 4) == "\r\n- ")
                {
                    strSum = GlobalFunctions.Right(strSum, strSum.Length - 4);
                }

                if (GlobalFunctions.Left(strSum, 2) == "\r\n")
                {
                    strSum = GlobalFunctions.Right(strSum, strSum.Length - 2);
                }

                //txtResult_DoctorRecommend.Text = Strings.Replace(strSum, "\r\n", Constants.vbCrLf);
                txtResult_DoctorRecommend.Text = strSum;
            }
           
            dtR = null;
        }

        private void ShowSuggestionAndDoctorRecommend(long VNUID)
        {

            DataTable dtCHK = new DataTable(); 
            dtCHK = ctlR.Result_GetDoctorSuggestionSummary(VNUID);

            if (dtCHK.Rows.Count > 0) //ถ้ามีแสดงว่า หมอได้สรุปผลแล้ว
            {
                //txtSpecial_Test.Text = dtCHK.Rows(0)("SpecialTest");
                //txtResult_DoctorRecommend.Text = dtCHK.Rows[0].Field<string>("Recommendation");
                txtResult_DoctorRecommend.Text = Strings.Replace(dtCHK.Rows[0].Field<string>("Recommendation"), "\n", Constants.vbCrLf);

                //chkRecomend.UnCheckAll();

                if (!string.IsNullOrEmpty(string.Concat(dtCHK.Rows[0].Field<string>("Conclustion"))))
                {
                    string[] strR = null;
               
                    strR = Strings.Split(dtCHK.Rows[0].Field<string>("Conclustion"), "|");

                    //for (int a = 0; a <= strR.Length - 1; a++)
                    //{

                    //    for (n = 0; n <= chkRecomend.Items.Count - 1; n++)
                    //    {

                    //        if (chkRecomend.GetItemValue(n).ToString() == strR[a].ToString())
                    //        {                               
                    //            chkRecomend.SetItemChecked(n, true);
                    //        }
                    //    }

                    //}
                }

              
            }
            else //ถ้าไม่มีแสดงว่า ยังไม่ได้สรุปผล
            {
                //ShowSpecialTestResult(VNUID);
                ShowSuggestionFromCheckup(VNUID);
            }

        }

        private void ShowSummaryResult(long VNUID)
        {
            DataTable dtV = new DataTable();
            dtV = ctlR.Result_GetSummaryResult(VNUID);
            if (dtV.Rows.Count > 0)
            {
                for (i = 0; i <= dtV.Rows.Count - 1; i++)
                {
                    var DR = dtV.Rows[i];
                    switch (dtV.Rows[i].Field<string>("ResultitemCode"))
                    {
                        case "LU017":
                            ddlUA_Summary.EditValue = DR.Field<string>("IsAbnormal");
                            txtUA_DoctorRecommend.Text = string.Concat(DR.Field<string>("Comments"));
                            break;
                        case "LH015":
                            ddlCBC_Summary.EditValue = DR.Field<string>("IsAbnormal");
                            txtCBC_DoctorRecommend.Text = string.Concat(DR.Field<string>("Comments"));
                            break;
                        case "LU015":
                            ddlST_Summary.EditValue = DR.Field<string>("IsAbnormal");
                            txtST_DoctorRecommend.Text = string.Concat(DR.Field<string>("Comments"));
                            break;
                    }

                }

            }
            dtV = null;

        }

        public static string SubStringXRAY(string strX)
        {          
            if (!string.IsNullOrEmpty(strX))
            {
                int nCount , nPos;
                nCount = 0;
                nPos = 0;
                try
                {
                    nCount = strX.Length;
                    nPos = strX.IndexOf("IMPRESSION:"); 
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (nPos>=0)
                {
                    strX= strX.Right(nCount - nPos - 11).ToString();
                    do
                    {
                        if (GlobalFunctions.Left(strX, 2) == "\r\n")
                        {
                            strX = GlobalFunctions.Right(strX, strX.Length - 2);
                        }
                    } while (GlobalFunctions.Left(strX, 2) == "\r\n");


                    return strX;
                }
                else
                {
                    return  strX;
                }

          
            }
            else
            {
                return "";
            }

        }

        public static string ConvertRtfToText(string input)
        {

            if (!string.IsNullOrEmpty(input))
            {
                string returnValue = string.Empty;

                //Create the RichTextBox. (Requires a reference to System.Windows.Forms.dll.)
                System.Windows.Forms.RichTextBox rtBox = new System.Windows.Forms.RichTextBox();

                // Convert the RTF to plain text.
                try
                {
                    rtBox.Rtf = input;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                string plainText = rtBox.Text;

                // Output plain text to file, encoded as UTF-8.
                return plainText;

            }
            else
            {
                return "";
            }

        }
        private void gridViewBloodChemistry_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle > 0)
            {
                if ((e.RowHandle % 2) == 0)
                {
                    e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                }
                else
                {
                    e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml("#f2f9ff");
                }
            }

            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {

                //gridViewBloodChemistry.SetRowCellValue(e.RowHandle, gridViewBloodChemistry.Columns[4],"Normal");

                //string refNormal = View.GetRowCellDisplayText(e.RowHandle, View.Columns[3]);
                if (gridViewBloodChemistry.GetRowCellValue(e.RowHandle, gridViewBloodChemistry.Columns[4]) != null)
                {

                    if (gridViewBloodChemistry.GetRowCellValue(e.RowHandle, gridViewBloodChemistry.Columns[4]).ToString() == "L")
                    {
                        e.Appearance.ForeColor = Color.Orange;
                        //e.Appearance.BackColor = Color.LightPink;         
                        //gridViewBloodChemistry.SetRowCellValue(e.RowHandle, "NormalTXT", "Abnormal");

                    }
                    else if (gridViewBloodChemistry.GetRowCellValue(e.RowHandle, gridViewBloodChemistry.Columns[4]).ToString() == "H")
                    {
                        e.Appearance.ForeColor = Color.Red;
                        //e.Appearance.BackColor = Color.LightPink;  
                        //gridViewBloodChemistry.SetRowCellValue(e.RowHandle, "NormalTXT", "Abnormal"); 
                    }
                    else if (gridViewBloodChemistry.GetRowCellValue(e.RowHandle, gridViewBloodChemistry.Columns[4]).ToString() == "LL")
                    {
                        e.Appearance.ForeColor = Color.Orange;
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        //gridViewBloodChemistry.SetRowCellValue(e.RowHandle, "NormalTXT", "Abnormal");
                    }
                    else if (gridViewBloodChemistry.GetRowCellValue(e.RowHandle, gridViewBloodChemistry.Columns[4]).ToString() == "HH")
                    {
                        e.Appearance.ForeColor = Color.Red;
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        //gridViewBloodChemistry.SetRowCellValue(e.RowHandle, "NormalTXT", "Abnormal");
                    }
                    else if (gridViewBloodChemistry.GetRowCellValue(e.RowHandle, gridViewBloodChemistry.Columns[4]).ToString() == "Y")
                    {
                        e.Appearance.ForeColor = Color.Red;                
                    }
                }

            }
        }

        private void gridViewUrine_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle > 0)
            {
                if ((e.RowHandle % 2) == 0)
                {
                    e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                }
                else
                {
                    e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml("#f2f9ff");
                }
            }

            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {

                //string refNormal = View.GetRowCellDisplayText(e.RowHandle, View.Columns[3]);
                if (gridViewUrine.GetRowCellValue(e.RowHandle, gridViewUrine.Columns[4]) != null)
                {

                    if (gridViewUrine.GetRowCellValue(e.RowHandle, gridViewUrine.Columns[4]).ToString() == "L")
                    {
                        e.Appearance.ForeColor = Color.Orange;
                        //e.Appearance.BackColor = Color.LightPink;                    

                    }
                    else if (gridViewUrine.GetRowCellValue(e.RowHandle, gridViewUrine.Columns[4]).ToString() == "H")
                    {
                        e.Appearance.ForeColor = Color.Red;
                        //e.Appearance.BackColor = Color.LightPink;                    

                    }
                    else if (gridViewUrine.GetRowCellValue(e.RowHandle, gridViewUrine.Columns[4]).ToString() == "LL")
                    {
                        e.Appearance.ForeColor = Color.Orange;
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);

                    }
                    else if (gridViewUrine.GetRowCellValue(e.RowHandle, gridViewUrine.Columns[4]).ToString() == "HH")
                    {
                        e.Appearance.ForeColor = Color.Red;
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);

                    }
                }

            }
        }
                
        private void gridViewStool_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle > 0)
            {
                if ((e.RowHandle % 2) == 0)
                {
                    e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                }
                else
                {
                    e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml("#f2f9ff");
                }
            }

            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {

                //string refNormal = View.GetRowCellDisplayText(e.RowHandle, View.Columns[3]);
                if (gridViewStool.GetRowCellValue(e.RowHandle, gridViewStool.Columns[4]) != null)
                {

                    if (gridViewStool.GetRowCellValue(e.RowHandle, gridViewStool.Columns[4]).ToString() == "L")
                    {
                        e.Appearance.ForeColor = Color.Orange;
                        //e.Appearance.BackColor = Color.LightPink;                    

                    }
                    else if (gridViewStool.GetRowCellValue(e.RowHandle, gridViewStool.Columns[4]).ToString() == "H")
                    {
                        e.Appearance.ForeColor = Color.Red;
                        //e.Appearance.BackColor = Color.LightPink;                    

                    }
                    else if (gridViewStool.GetRowCellValue(e.RowHandle, gridViewStool.Columns[4]).ToString() == "LL")
                    {
                        e.Appearance.ForeColor = Color.Orange;
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);

                    }
                    else if (gridViewStool.GetRowCellValue(e.RowHandle, gridViewStool.Columns[4]).ToString() == "HH")
                    {
                        e.Appearance.ForeColor = Color.Red;
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);

                    }
                }

            }
        }

        //private void gridViewOther_RowStyle(object sender, RowStyleEventArgs e)
        //{
        //    GridView View = sender as GridView;
        //    if (e.RowHandle >= 0)
        //    {
        //        //string refNormal = View.GetRowCellDisplayText(e.RowHandle, View.Columns[3]);
        //        if (gridViewOther.GetRowCellValue(e.RowHandle, gridViewOther.Columns[3]) != null)
        //        {

        //            if (gridViewOther.GetRowCellValue(e.RowHandle, gridViewOther.Columns[3]).ToString() == "Abnormal")
        //            {
        //                e.Appearance.ForeColor = Color.Red;
        //                //e.Appearance.BackColor = Color.LightPink;                    

        //            }


        //        }

        //    }
        //}

        private void gridViewStoolCulture_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle > 0)
            {
                if ((e.RowHandle % 2) == 0)
                {
                    e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                }
                else
                {
                    e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml("#f2f9ff");
                }
            }

            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {

                //string refNormal = View.GetRowCellDisplayText(e.RowHandle, View.Columns[3]);
                if (gridViewStoolCulture.GetRowCellValue(e.RowHandle, gridViewStoolCulture.Columns[4]) != null)
                {

                    if (gridViewStoolCulture.GetRowCellValue(e.RowHandle, gridViewStoolCulture.Columns[4]).ToString() == "L")
                    {
                        e.Appearance.ForeColor = Color.Orange;
                        //e.Appearance.BackColor = Color.LightPink;                    

                    }
                    else if (gridViewStoolCulture.GetRowCellValue(e.RowHandle, gridViewStoolCulture.Columns[4]).ToString() == "H")
                    {
                        e.Appearance.ForeColor = Color.Red;
                        //e.Appearance.BackColor = Color.LightPink;                    

                    }
                    else if (gridViewStoolCulture.GetRowCellValue(e.RowHandle, gridViewStoolCulture.Columns[4]).ToString() == "LL")
                    {
                        e.Appearance.ForeColor = Color.Orange;
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);

                    }
                    else if (gridViewStoolCulture.GetRowCellValue(e.RowHandle, gridViewStoolCulture.Columns[4]).ToString() == "HH")
                    {
                        e.Appearance.ForeColor = Color.Red;
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);

                    }
                }

            }
        }

        
        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdTempSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void cmdFinalize_Click(object sender, EventArgs e)
        {
            
            if (ctlP.Patient_Finalized(Convert.ToInt64(lblPatientVisitUID.Text)))
            {
                if (ctlUser.User_IsSuperUser(DataHelper.LoginUser))
                {
                    //frmUserAuthorize fAut = new frmUserAuthorize();
                    //fAut.ShowDialog();

                    if (GlobalVariables.UserAuthorized == false)
                    {
                        return;
                    }
                }
            }
            SaveData();

            ctlR.Result_UpdateFinalSaveDate(Convert.ToInt64(lblPatientVisitUID.Text));
                      

        }
        private void SavePatientAddress()
        {
            if (!string.IsNullOrEmpty(txtAddress.Text))
            {
                ctlP.SavePatientAddress(Convert.ToInt64(lblPatientVisitUID.Text), txtAddress.Text, ddlProvince.EditValue.ToString(), txtZipCode.Text);
            }
            //Update 17-04-2019 By Tee

        }
      
          private void SaveData()
        {                                 
            
            if (ValidateData() == false)
            {
                MessageBox.Show(strValidate, "Warning!!");
                return;
            }

            SavePatientAddress();
            SaveGeneralAppearanceResult(Convert.ToInt64(lblPatientVisitUID.Text));
            SaveCheckupResult();

            SaveDoctorSuggestionAndRecommend(Convert.ToInt64(lblPatientVisitUID.Text));
            
            //Update SaveDate
            ctlR.Result_UpdateSaveDate(Convert.ToInt64(lblPatientVisitUID.Text));

            cmdPrintResultBookCover.Visible = true;
            cmdPrintResultBook.Visible = true;
            cmdPrintResultNew.Visible = true;
            cmdPrintResultOld.Visible = true;
            cmdPrintResultStudent.Visible = false;

            ctlUser.User_GenLogfile(DataHelper.LoginUser, "SAVE", "CHECKUP", "บันทึกผลการตรวจสุขภาพ:SUTHOS", "hn=" + lblHN.Text + ",VisitUID=" + lblPatientVisitUID.Text);

            MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "Complete",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private bool ValidateData()
        {
            bool result = true;
            if (ctlR.Result_CheckOrderItemByCode(Convert.ToInt64(lblPatientVisitUID.Text), "DX0002"))
            {
                if (ddlX_EKG.EditValue.ToString() == "")
                {
                    result = false;
                    strValidate = "- ท่านยังไม่ได้ลงผลการตรวจคลื่นไฟฟ้าหัวใจ/EKG  <br/>";
                }
            }
            if (ctlR.Result_CheckOrderItemByCode(Convert.ToInt64(lblPatientVisitUID.Text), "XRGEN001"))
            {
                if (ddlX_ChestPA.EditValue.ToString() == "")
                {
                    result = false;
                    strValidate = "- ท่านยังไม่ได้ลงผล Chest PA <br/>";
                }
            }
            if (ctlR.Result_CheckOrderItemByCode(Convert.ToInt64(lblPatientVisitUID.Text), "XRGEN398"))
            {
                if (ddlX_ChestPA.EditValue.ToString() == "")
                {
                    result = false;
                    strValidate = "- ท่านยังไม่ได้ลงผล Chest PA <br/>";
                }
            }

            if (ctlR.Result_CheckOrderItemByCode(Convert.ToInt64(lblPatientVisitUID.Text), "DX0020"))
            {
                if (ddlX_ABI.EditValue.ToString() == "")
                {
                    result = false;
                    strValidate = "- ท่านยังไม่ได้ลงผลตรวจความแข็งตัวของหลอดเลือด (ABI) <br/>";
                }
            }

            if (ctlR.Result_CheckOrderItemByCode(Convert.ToInt64(lblPatientVisitUID.Text), "XRBMD004"))
            {
                if (ddlX_BMD.EditValue.ToString() == "")
                {
                    result = false;
                    strValidate = "- ท่านยังไม่ได้ลงผลการตรวจความหนาแน่นของกระดูก (BMD) <br/>";
                }
            }

            return result;
        }


        private void SaveCheckupResult()
        {
            //DataTable dtR = new DataTable();

            //dtR = ctlR.Result_GetLabResult(Convert.ToInt64(lblPatientVisitUID.Text));

            //if (dtR.Rows.Count > 0)
            //{
                SaveBloodChemistryResult( Convert.ToInt64(lblPatientVisitUID.Text));
                SaveLabResultSummary(Convert.ToInt64(lblPatientVisitUID.Text));
                savePAPsmearResult(Convert.ToInt64(lblPatientVisitUID.Text));

                //DataTable dtVS = new DataTable();
                //dtVS = ctlR.Result_CheckAudiogramOrder(Convert.ToInt64(lblPatientVisitUID.Text));
                //if (dtVS.Rows.Count > 0)
                //{
                //    SaveStudentPreDoctorResult(Convert.ToInt64(lblPatientVisitUID.Text));
                //}
                //dtVS = null;



            //}

            SaveXRAYSummaryResult(Convert.ToInt64(lblPatientVisitUID.Text));
           

            //dtR = null;
        }


        
        private void SaveGeneralAppearanceResult(long PVN)
        {
            if (chkNoCheck.Checked)
            {
                ctlR.Result_SaveNoCheckGA(PVN,Convert.ToInt32(DataHelper.usercode));
            }
            else
            {
                ctlR.Result_DeleteNoCheckGA(PVN);
                ctlR.Result_SaveGAResult(PVN, "GA001", ddlGA_LevelOfConsciousne.EditValue.ToString(), txtGA_LevelOfConsciousne.Text, Convert.ToInt32(DataHelper.usercode));
                ctlR.Result_SaveGAResult(PVN, "GA002", ddlGA_HeadAndFace.EditValue.ToString(), txtGA_HeadAndFace.Text, Convert.ToInt32(DataHelper.usercode));
                ctlR.Result_SaveGAResult(PVN, "GA003", ddlGA_Eye.EditValue.ToString(), txtGA_Eye.Text, Convert.ToInt32(DataHelper.usercode));
                ctlR.Result_SaveGAResult(PVN, "GA004", ddlGA_EareAndNose.EditValue.ToString(), txtGA_EareAndNose.Text, Convert.ToInt32(DataHelper.usercode));
                ctlR.Result_SaveGAResult(PVN, "GA005", ddlGA_MouthAndThroat.EditValue.ToString(), txtGA_MouthAndThroat.Text, Convert.ToInt32(DataHelper.usercode));
                ctlR.Result_SaveGAResult(PVN, "GA006", ddlGA_Lymphoma.EditValue.ToString(), txtGA_Lymphoma.Text, Convert.ToInt32(DataHelper.usercode));
                ctlR.Result_SaveGAResult(PVN, "GA007", ddlGA_Thyroid.EditValue.ToString(), txtGA_Thyroid.Text, Convert.ToInt32(DataHelper.usercode));
                ctlR.Result_SaveGAResult(PVN, "GA008", ddlGA_LungChestBreast.EditValue.ToString(), txtGA_LungChestBreast.Text, Convert.ToInt32(DataHelper.usercode));
                ctlR.Result_SaveGAResult(PVN, "GA009", ddlGA_Heart.EditValue.ToString(), txtGA_Heart.Text, Convert.ToInt32(DataHelper.usercode));
                ctlR.Result_SaveGAResult(PVN, "GA010", ddlGA_Abdomen.EditValue.ToString(), txtGA_Abdomen.Text, Convert.ToInt32(DataHelper.usercode));
                ctlR.Result_SaveGAResult(PVN, "GA011", ddlGA_Extremties.EditValue.ToString(), txtGA_Extremties.Text, Convert.ToInt32(DataHelper.usercode));
                ctlR.Result_SaveGAResult(PVN, "GA012", ddlGA_Skin.EditValue.ToString(), txtGA_Skin.Text, Convert.ToInt32(DataHelper.usercode));
                ctlR.Result_SaveGAResult(PVN, "GA099", ddlGA_Others.EditValue.ToString(), txtGA_Others.Text, Convert.ToInt32(DataHelper.usercode));
            }

            DataTable dtVS = new DataTable();
            bool n = false;
            dtVS = ctlR.Result_CheckVisibilityOrder(PVN);
            if (dtVS.Rows.Count > 0)
            {
                for (i = 0; i <= dtVS.Rows.Count - 1; i++)
                {
                    switch (dtVS.Rows[i].Field<string>("code"))
                    {
                        case "DX0006":
                            ctlR.Result_SaveVisionResult(PVN, "VS003", ddlVS_Blind.EditValue.ToString(), "", txtVS_BlindRemark.Text, Convert.ToInt32(DataHelper.usercode));
                            n = true;
                            break;
                        case "DX0027":
                            ctlR.Result_SaveVisionResult(PVN, "VS002L", ddlVS_EyeballLeft.EditValue.ToString(), txtVS_EyeballLeft.Text, "", Convert.ToInt32(DataHelper.usercode));
                            ctlR.Result_SaveVisionResult(PVN, "VS002R", ddlVS_EyeballRight.EditValue.ToString(), txtVS_EyeballRight.Text, "", Convert.ToInt32(DataHelper.usercode));
                            n = true;
                            break;
                        case "DX0028":
                            ctlR.Result_SaveVisionResult(PVN, "VS001L", ddlVS_VisibilityLeft.EditValue.ToString(), txtVS_VisibilityLeft.Text, "", Convert.ToInt32(DataHelper.usercode));
                            ctlR.Result_SaveVisionResult(PVN, "VS001R", ddlVS_VisibilityRight.EditValue.ToString(), txtVS_VisibilityRight.Text, "", Convert.ToInt32(DataHelper.usercode));
                            n = true;
                            break;
                        case "DX0030":
                            ctlR.Result_SaveVisionResult(PVN, "VS004L", ddlVS_RetinaLeft.EditValue.ToString(), txtVS_RetinaLeft.Text, "", Convert.ToInt32(DataHelper.usercode));
                            ctlR.Result_SaveVisionResult(PVN, "VS004R", ddlVS_RetinaRight.EditValue.ToString(), txtVS_RetinaRight.Text, "", Convert.ToInt32(DataHelper.usercode));
                            n = true;
                            break;
                        case "DX0003":
                            if (Strings.Left(dtVS.Rows[i].Field<string>("itemName"), 3) != "EKG")
                            {
                                ctlR.Result_SaveVisionResult(PVN, "VS003", ddlVS_Blind.EditValue.ToString(), "", txtVS_BlindRemark.Text, Convert.ToInt32(DataHelper.usercode));
                                n = true;
                            }

                            break;
                    }
                }

                if (n == true)
                {
                    ctlR.Result_SaveVisionResult(PVN, "VS099", ddlVS_Summary.EditValue.ToString(), "", txtVS_SummaryRemark.Text, Convert.ToInt32(DataHelper.usercode));
                }

            }
            dtVS.Rows.Clear();
            dtVS = ctlR.Result_CheckAudiogramOrder(PVN);
            if (dtVS.Rows.Count > 0)
            {
                ctlR.Result_SaveVisionResult(PVN, "AU001R", ddlEarsRight.EditValue.ToString(), "", ddlEarsRightRemark.Text, Convert.ToInt32(DataHelper.usercode));
                ctlR.Result_SaveVisionResult(PVN, "AU001L", ddlEarsLeft.EditValue.ToString(), "", ddlEarsLeftRemark.Text, Convert.ToInt32(DataHelper.usercode));

            }
            dtVS = null;
        }

        private void SaveBloodChemistryResult(long PVN)
        {
            string sItemcode,sItemName ,sResult,sAbNormal,sDoctorResult = null;
            long rUID;
            rUID = 0;
            sItemcode = "";
            sAbNormal = "";
            sResult="";
            sItemName = "";
            sDoctorResult = "";

            for (i=0;i<gridViewBloodChemistry.RowCount-1;i++)
                {

                if (gridViewBloodChemistry.GetRowCellValue(i, "ResultItemCode")!=null)
                { 
                    rUID = Convert.ToInt64(gridViewBloodChemistry.GetRowCellValue(i, "UID"));
                    sItemcode = gridViewBloodChemistry.GetRowCellValue(i, "ResultItemCode").ToString();
                    sResult = gridViewBloodChemistry.GetRowCellValue(i, "ResultValue").ToString();
                    sItemName = gridViewBloodChemistry.GetRowCellValue(i, "ResultItemName").ToString();
                    sAbNormal = gridViewBloodChemistry.GetRowCellValue(i, "IsAbnormal").ToString(); //มาจาก Database 
                    sDoctorResult = gridViewBloodChemistry.GetRowCellValue(i, "NormalTXT").ToString(); //มาจากแพทย์ลงผล

                    if(sDoctorResult=="Abnormal") //ถ้าหมอลงว่าผิดปกติ
                    {
                        if (sAbNormal == "N" || sAbNormal == "-" || sAbNormal == "") //แต่ผลจาก HO ปกติ
                            {
                                sDoctorResult = "Y";
                            }
                            else //ถ้าผลจาก HO ไม่ปกติ ให้คงค่าเดิมไว้
                            {
                                sDoctorResult = sAbNormal;
                            }
                    }
                    else //ถ้าหมอลงว่าปกติ ก็ลงผลว่าปกติเลย
                    {
                        sDoctorResult = "N";
                    }

                    ctlR.Result_SaveBloodChemistryResult(rUID, PVN, sItemcode, sResult, sDoctorResult, Convert.ToInt32(DataHelper.usercode), sItemName, 75);
                }                              
            }
        }

        private void SaveXRAYSummaryResult(long PVN)
        {
            string sResult = null;
            string sReport = null;
            string sAbNormal = null;
            string sSendToDoc = null;
            int DMID = 0;

            sSendToDoc = "";

            if (ddlX_EKG.Text !="")
            {
                sResult = txtX_EKGResult.Text;
                sAbNormal = ddlX_EKG.EditValue.ToString();
                if (ddlX_EKG.EditValue.ToString() == "W")
                {
                    sSendToDoc = "Y";
                }

                switch (sAbNormal)
                { 
                    case "N":
                        sReport = "ไม่พบความผิดปกติ";
                        break;
                    case "Y":
                        sReport = "ตรวจพบความผิดปกติ";
                        break;
                    case "W":
                        sReport = "ส่งแพทย์เฉพาะทางอ่านผล";
                        break;
                    default:
                        sReport = "";
                        break;
                }

                DMID = 253;
                ctlR.SUTH_Result_SaveXRAYResult(Convert.ToInt64(lblPatientVisitUID.Text), "DX0002", sResult,sReport, sAbNormal, Convert.ToInt32(DataHelper.usercode), "EKG (ELECTROCARDIOGRAPHY)", DMID, sSendToDoc);
            }
            else
            {
                ctlR.SUTH_Result_DeleteResult(Convert.ToInt64(lblPatientVisitUID.Text), "DX0002", "ไม่ตรวจ", "", Convert.ToInt32(DataHelper.usercode), "EKG (ELECTROCARDIOGRAPHY)", DMID, sSendToDoc);
            }

            if (ddlX_ChestPA.EditValue.ToString() != "")
            {
                sResult = txtX_ChestPA.Text;
                sAbNormal = ddlX_ChestPA.EditValue.ToString();
                if (ddlX_ChestPA.EditValue.ToString() == "W")
                {
                    sSendToDoc = "Y";
                }
                switch (sAbNormal)
                {
                    case "N":
                        sReport = "ไม่พบความผิดปกติ";
                        break;
                    case "Y":
                        sReport = "ตรวจพบความผิดปกติ";
                        break;
                    case "W":
                        sReport = "ส่งแพทย์เฉพาะทางอ่านผล";
                        break;
                    default:
                        sReport = "";
                        break;
                }

                DMID = 253;
                ctlR.SUTH_Result_SaveXRAYResult(Convert.ToInt64(lblPatientVisitUID.Text), "XRGEN001", sResult, sReport, sAbNormal, Convert.ToInt32(DataHelper.usercode), "Chest PA check up", DMID, sSendToDoc);
            }
            else
            {
                ctlR.SUTH_Result_DeleteResult(Convert.ToInt64(lblPatientVisitUID.Text), "XRGEN001", "ไม่ตรวจ", "", Convert.ToInt32(DataHelper.usercode), "Chest PA check up", DMID, sSendToDoc);
            }


            if (ddlX_Abdomen.EditValue.ToString() != "")
            {
                sResult = txtX_AbdomenRemark.Text;
                sAbNormal = ddlX_Abdomen.EditValue.ToString();
                if (ddlX_Abdomen.EditValue.ToString() == "W")
                {
                    sSendToDoc = "Y";
                }
                switch (sAbNormal)
                {
                    case "N":
                        sReport = "ไม่พบความผิดปกติ";
                        break;
                    case "Y":
                        sReport = "ตรวจพบความผิดปกติ";
                        break;
                    case "W":
                        sReport = "ส่งแพทย์เฉพาะทางอ่านผล";
                        break;
                    default:
                        sReport = "";
                        break;
                }
                DMID = 260;
                ctlR.SUTH_Result_SaveXRAYResult(Convert.ToInt64(lblPatientVisitUID.Text), "XRUS031", sResult, sReport, sAbNormal, Convert.ToInt32(DataHelper.usercode), "Ultrasound Whole Abdomen", DMID, sSendToDoc);
            }
            else
            {
                ctlR.SUTH_Result_DeleteResult(Convert.ToInt64(lblPatientVisitUID.Text), "XRUS031", "ไม่ตรวจ", "", Convert.ToInt32(DataHelper.usercode), "Ultrasound Whole Abdomen", DMID, sSendToDoc);
            }


            if (ddlX_UpperAbdomen.EditValue.ToString() != "")
            {
                sResult = txtX_UpperAbdomenRemark.Text;
                sAbNormal = ddlX_UpperAbdomen.EditValue.ToString();
                if ( ddlX_UpperAbdomen.EditValue.ToString() == "W")
                {
                    sSendToDoc = "Y";
                }
                switch (sAbNormal)
                {
                    case "N":
                        sReport = "ไม่พบความผิดปกติ";
                        break;
                    case "Y":
                        sReport = "ตรวจพบความผิดปกติ";
                        break;
                    case "W":
                        sReport = "ส่งแพทย์เฉพาะทางอ่านผล";
                        break;
                    default:
                        sReport = "";
                        break;
                }
                DMID = 260;
                ctlR.SUTH_Result_SaveXRAYResult(Convert.ToInt64(lblPatientVisitUID.Text), "XRUS029", sResult, sReport, sAbNormal, Convert.ToInt32(DataHelper.usercode), "Ultrasound Upper Abdomen", DMID, sSendToDoc);
            }
            else
            {
                ctlR.SUTH_Result_DeleteResult(Convert.ToInt64(lblPatientVisitUID.Text), "XRUS029", "ไม่ตรวจ", "", Convert.ToInt32(DataHelper.usercode), "Ultrasound Upper Abdomen", DMID, sSendToDoc);
            }


            if (ddlX_LowerAbdomen.EditValue.ToString() != "")
            {
                sResult = txtX_LowerAbdomenRemark.Text;
                sAbNormal = ddlX_LowerAbdomen.EditValue.ToString();
                if (ddlX_LowerAbdomen.EditValue.ToString() == "W")
                {
                    sSendToDoc = "Y";
                }
                switch (sAbNormal)
                {
                    case "N":
                        sReport = "ไม่พบความผิดปกติ";
                        break;
                    case "Y":
                        sReport = "ตรวจพบความผิดปกติ";
                        break;
                    case "W":
                        sReport = "ส่งแพทย์เฉพาะทางอ่านผล";
                        break;
                    default:
                        sReport = "";
                        break;
                }
                DMID = 260;
                ctlR.SUTH_Result_SaveXRAYResult(Convert.ToInt64(lblPatientVisitUID.Text), "XRUS019", sResult, sReport, sAbNormal, Convert.ToInt32(DataHelper.usercode), "Ultrasound Lower Abdomen", DMID, sSendToDoc);
            }
            else
            {
                ctlR.SUTH_Result_DeleteResult(Convert.ToInt64(lblPatientVisitUID.Text), "XRUS019", "ไม่ตรวจ", "", Convert.ToInt32(DataHelper.usercode), "Ultrasound Lower Abdomen", DMID, sSendToDoc);
            }


            if (ddlX_Echo.EditValue.ToString() != "")
            {
                sResult = txtX_EchoRemark.Text;
                sAbNormal = ddlX_Echo.EditValue.ToString();
                if (ddlX_Echo.EditValue.ToString() == "W")
                {
                    sSendToDoc = "Y";
                }

                switch (sAbNormal)
                {
                    case "N":
                        sReport = "ไม่พบความผิดปกติ";
                        break;
                    case "Y":
                        sReport = "ตรวจพบความผิดปกติ" ;
                        break;
                    case "W":
                        sReport = "ส่งแพทย์เฉพาะทางอ่านผล";
                        break;
                    default:
                        sReport = "";
                        break;
                }

                DMID = 260;
                ctlR.SUTH_Result_SaveXRAYResult(Convert.ToInt64(lblPatientVisitUID.Text), "DX0012", sResult, sReport, sAbNormal, Convert.ToInt32(DataHelper.usercode), "Acho", DMID, sSendToDoc);
            }
            else
            {
                ctlR.SUTH_Result_DeleteResult(Convert.ToInt64(lblPatientVisitUID.Text), "DX0012", "ไม่ตรวจ", "", Convert.ToInt32(DataHelper.usercode), "Acho", DMID, sSendToDoc);
            }

            if (ddlX_EST.EditValue.ToString() != "")
            {
                sResult = txtX_ESTRemark.Text;
                sAbNormal = ddlX_EST.EditValue.ToString();
                if (ddlX_EST.EditValue.ToString() == "W")
                {
                    sSendToDoc = "Y";
                }
                switch (sAbNormal)
                {
                    case "N":
                        sReport = "ไม่พบความผิดปกติ";
                        break;
                    case "Y":
                        sReport = "ตรวจพบความผิดปกติ" ;
                        break;
                    case "W":
                        sReport = "ส่งแพทย์เฉพาะทางอ่านผล";
                        break;
                    default:
                        sReport = "";
                        break;
                }

                ctlR.SUTH_Result_SaveXRAYResult(Convert.ToInt64(lblPatientVisitUID.Text), "DX0011", sResult, sReport, sAbNormal, Convert.ToInt32(DataHelper.usercode), "EST", DMID, sSendToDoc);
            }
            else
            {
                ctlR.SUTH_Result_DeleteResult(Convert.ToInt64(lblPatientVisitUID.Text), "DX0011", "ไม่ตรวจ", "", Convert.ToInt32(DataHelper.usercode), "EST", DMID, sSendToDoc);
            }

            if (ddlX_ABI.EditValue.ToString() != "")
            {
                sResult = txtX_ABIRemark.Text;
                sAbNormal = ddlX_ABI.EditValue.ToString();
                if (ddlX_ABI.EditValue.ToString() == "W")
                {
                    sSendToDoc = "Y";
                }
                switch (sAbNormal)
                {
                    case "N":
                        sReport = "ไม่พบความผิดปกติ";
                        break;
                    case "Y":
                        sReport = "ตรวจพบความผิดปกติ" ;
                        break;
                    case "W":
                        sReport = "ส่งแพทย์เฉพาะทางอ่านผล";
                        break;
                    case "Abnormal1":
                        sReport = "พบภาวะหลอดเลือดแข็ง";
                        break;
                    case "Abnormal2":
                        sReport = "พบภาวะหลอดเลือดอุดตัน";
                        break;
                    default:
                        sReport = "";
                        break;
                }
                ctlR.SUTH_Result_SaveXRAYResult(Convert.ToInt64(lblPatientVisitUID.Text), "DX0020", sResult, sReport, sAbNormal, Convert.ToInt32(DataHelper.usercode), "ABI", DMID, sSendToDoc);
            }
            else
            {
                ctlR.SUTH_Result_DeleteResult(Convert.ToInt64(lblPatientVisitUID.Text), "DX0020", "ไม่ตรวจ", "", Convert.ToInt32(DataHelper.usercode), "ABI", DMID, sSendToDoc);

            }

            if (ddlX_BMD.EditValue.ToString() != "")
            {
                sResult = txtX_BMDRemark.Text;
                sAbNormal = ddlX_BMD.EditValue.ToString();
                if (ddlX_BMD.EditValue.ToString() == "W")
                {
                    sSendToDoc = "Y";
                }

                switch (sAbNormal)
                {
                    case "N":
                        sReport = "ไม่พบความผิดปกติ";
                        break;
                    case "Y":
                        sReport = "ตรวจพบความผิดปกติ";
                        break;
                    case "W":
                        sReport = "ส่งแพทย์เฉพาะทางอ่านผล";
                        break;
                    case "Abnormal1":
                        sReport = "มวลกระดูกเริ่มบางเมื่อเทียบกับช่วงอายุเดียวกัน";
                        break;
                    case "Abnormal2":
                        sReport = "กระดูกพรุนเมื่อเทียบกับช่วงอายุเดียวกัน";
                        break;
                    default:
                        sReport = "";
                        break;
                }


                ctlR.SUTH_Result_SaveXRAYResult(Convert.ToInt64(lblPatientVisitUID.Text), "XRBMD004", sResult, sReport, sAbNormal, Convert.ToInt32(DataHelper.usercode), "BMD", DMID, sSendToDoc);
            }
            else
            {
                ctlR.SUTH_Result_DeleteResult(Convert.ToInt64(lblPatientVisitUID.Text), "XRBMD004", "ไม่ตรวจ", "", Convert.ToInt32(DataHelper.usercode), "BMD", DMID, sSendToDoc);

            }

            if (ddlX_Mammogram.EditValue.ToString() != "")
            {
                sResult = txtX_Mammogram.Text;
                sAbNormal = ddlX_Mammogram.EditValue.ToString();
                if (ddlX_Mammogram.EditValue.ToString() == "W")
                {
                    sSendToDoc = "Y";
                }
                switch (sAbNormal)
                {
                    case "N":
                        sReport = "ไม่พบความผิดปกติ";
                        break;
                    case "Y":
                        sReport = "ตรวจพบความผิดปกติ" ;
                        break;
                    case "W":
                        sReport = "ส่งแพทย์เฉพาะทางอ่านผล";
                        break;
                    default:
                        sReport = "";
                        break;
                }
                DMID = 255;

                if (ctlP.Patient_GetSEXXUID(GlobalFunctions.StrNull2Zero(lblPatientUID.Text)) == 2)
                {
                    ctlR.SUTH_Result_SaveXRAYResult(Convert.ToInt64(lblPatientVisitUID.Text), "XRSP011", sResult,sReport, ddlX_Mammogram.EditValue.ToString(), Convert.ToInt32(DataHelper.usercode), "Mammogram (with ultrasound breast)", DMID, sSendToDoc);
                }

            }
            else
            {
                ctlR.SUTH_Result_DeleteResult(Convert.ToInt64(lblPatientVisitUID.Text), "XRSP011", "ไม่ตรวจ", "", Convert.ToInt32(DataHelper.usercode), "Mammogram (with ultrasound breast)", DMID, sSendToDoc);
            }

            if (ddlX_USBreast.EditValue.ToString() != "")
            {
                sResult = txtX_USBreast.Text;
                sAbNormal = ddlX_USBreast.EditValue.ToString();
                if (ddlX_USBreast.EditValue.ToString() == "W")
                {
                    sSendToDoc = "Y";
                }
                switch (sAbNormal)
                {
                    case "N":
                        sReport = "ไม่พบความผิดปกติ";
                        break;
                    case "Y":
                        sReport = "ตรวจพบความผิดปกติ";
                        break;
                    case "W":
                        sReport = "ส่งแพทย์เฉพาะทางอ่านผล";
                        break;
                    default:
                        sReport = "";
                        break;
                }
                DMID = 255;

                if (ctlP.Patient_GetSEXXUID(GlobalFunctions.StrNull2Zero(lblPatientUID.Text)) == 2)
                {
                    ctlR.SUTH_Result_SaveXRAYResult(Convert.ToInt64(lblPatientVisitUID.Text), "XRUS003", sResult, sReport, ddlX_USBreast.EditValue.ToString(), Convert.ToInt32(DataHelper.usercode), "Ultrasound breast)", DMID, sSendToDoc);
                }

            }
            else
            {
                ctlR.SUTH_Result_DeleteResult(Convert.ToInt64(lblPatientVisitUID.Text), "XRUS003", "ไม่ตรวจ", "", Convert.ToInt32(DataHelper.usercode), "Ultrasound breast", DMID, sSendToDoc);
            }

            //pDT = Nothing
        }

        private void savePAPsmearResult(long VNUID)
        {
            DataTable dtPap = new DataTable();
            DataTable dtPap125 = new DataTable();
            DataTable dtPap127 = new DataTable();

            // string cyto;
            //cyto = "";
            if (chkVegina.Checked==true)
            {
                ctlR.Result_SaveLabPapSmearResult(Convert.ToInt64(lblPatientVisitUID.Text), "GA013", txtVegina.Text, "", Convert.ToInt32(DataHelper.usercode), "ตรวจภายใน", 80);
            }

            if (chkPapSmear.Checked== true)
            {
          
                dtPap125 = ctlR.RequestDetail_GetByItemCode(VNUID, "LP125");
                if (dtPap125.Rows.Count > 0)
                {
                    //cyto = "LP125";
           
                    ctlR.Result_SaveLabPapSmearResult(Convert.ToInt64(lblPatientVisitUID.Text), "LP125", txtPapSmear.Text, "", Convert.ToInt32(DataHelper.usercode), "Pap Smear (Conventional method)", 80);
                }

                dtPap127 = ctlR.RequestDetail_GetByItemCode(VNUID, "LP127");
                if (dtPap127.Rows.Count > 0)
                {
                    //cyto = "LP127";
           
                    ctlR.Result_SaveLabPapSmearResult(Convert.ToInt64(lblPatientVisitUID.Text), "LP127", txtPapSmear.Text, "", Convert.ToInt32(DataHelper.usercode), "Liquid based PAP Smear", 80);
                }


                //dtPap = ctlR.CytologyResult_Get(VNUID);
                //if (dtPap.Rows.Count > 0)
                //{
                //    var DR7 = dtPap.Rows[0];
                //    ctlR.Result_SavePAPSmearResult(lblHN.Text,  Convert.ToInt64(lblPatientVisitUID.Text), lblPatientName.Text,Convert.ToInt32(DR7[5]), cyto, txtPapSmear.Text, txtPapSmear.Text, "", "",
                //    "", Convert.ToInt32(DataHelper.usercode));

                //}

          }

            dtPap = null;

        }

        private void SaveDoctorSuggestionAndRecommend(long VNUID)
        {
            //for (i = 0; i <= chkRecomend.Items.Count - 1; i++)
            //{
            //    if (chkRecomend.GetItemCheckState(i) == System.Windows.Forms.CheckState.Checked)
            //    {
            //        strR += chkRecomend.GetItemValue(i).ToString();
            //        if (i != (chkRecomend.Items.Count - 1))
            //        {
            //            strR += "|";
            //        }
            //    }
            //}

            //int nCount;
            string strR;
            //nCount = 0;
            strR = txtResult_DoctorRecommend.Text;
            //do
            //{
            //    nCount = strR.IndexOf(Constants.vbCrLf);
            //    strR = Strings.Replace(strR, "\n", "");
            //    strR = Strings.Replace(strR, "\r", "");
            //    strR = Strings.Replace(strR, "--", "");
            //} while (nCount >=0);
      
            //strR = Strings.Replace(strR, "- -", "");
            //strR = Strings.Replace(strR," -", "");

            do
            {
                if (GlobalFunctions.Left(strR, 2) == "\r\n")
                {
                    strR = GlobalFunctions.Right(strR, strR.Length - 2);
                }                                   
            } while (GlobalFunctions.Left(strR, 2) == "\r\n");


            if (strR.Length<5)
            {
                strR = "";
                txtResult_DoctorRecommend.Text = strR;
            }

            ctlR.Result_SaveDoctorSuggestionAndRecommend(Convert.ToInt64(lblPatientVisitUID.Text),strR,GlobalFunctions.StrNull2Zero(ddlDoctor_PE.EditValue.ToString()),GlobalFunctions.StrNull2Zero(ddlDoctor_Conclusion.EditValue.ToString()), Convert.ToInt32(DataHelper.usercode));
        }


        private void SaveLabResultSummary(long VNUID)
        {
            if (dockPanelUA.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Visible)
            {
                ctlR.Result_SaveLabResultSammary(Convert.ToInt64(lblPatientVisitUID.Text), "LU017", "ผลการตรวจปัสสวะ (Urine Exam)", ddlUA_Summary.EditValue.ToString(), 1, Convert.ToInt32(DataHelper.usercode), txtUA_DoctorRecommend.Text);
            }
            if (dockPanelStool.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Visible)
            {
                ctlR.Result_SaveLabResultSammary(Convert.ToInt64(lblPatientVisitUID.Text), "LU015", "ผลการตรวจอุจจาระ (Stool Exam)", ddlST_Summary.EditValue.ToString(), 1, Convert.ToInt32(DataHelper.usercode), txtST_DoctorRecommend.Text);
            }
            if (dockPanelCBC.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Visible)
            {
                ctlR.Result_SaveLabResultSammary(Convert.ToInt64(lblPatientVisitUID.Text), "LH015", "ผลการตรวจความสมบูรณ์ของเม็ดเลือด (CBC)", ddlCBC_Summary.EditValue.ToString(), 2, Convert.ToInt32(DataHelper.usercode), txtCBC_DoctorRecommend.Text);
            }
        }

       
              

        private void btnX_PA_Click(object sender, EventArgs e)
        {
            frmCompareLayout frmX = new frmCompareLayout();
            GlobalVariables.gResultComponentUID = Convert.ToInt64(xChestPAUID);
            frmX.Show();
        }

        private void btnX_Abdomen_Click(object sender, EventArgs e)
        {
            frmCompareLayout frmX = new frmCompareLayout();
            GlobalVariables.gResultComponentUID = Convert.ToInt64(xAbdomenUID);
            frmX.Show();
        }

        private void btnX_Echo_Click(object sender, EventArgs e)
        {
            frmCompareLayout frmX = new frmCompareLayout();
            GlobalVariables.gResultComponentUID = Convert.ToInt64(xEchoUID);
            frmX.Show();
        }

        private void btnX_Upper_Click(object sender, EventArgs e)
        {
            frmCompareLayout frmX = new frmCompareLayout();
            GlobalVariables.gResultComponentUID = Convert.ToInt64(xUpperUID);
            frmX.Show();
        }

        private void btnX_Mammo_Click(object sender, EventArgs e)
        {
            frmCompareLayout frmX = new frmCompareLayout();
            GlobalVariables.gResultComponentUID = Convert.ToInt64(xMamoUID);
            frmX.Show();
        }

        private void btnX_USBreast_Click(object sender, EventArgs e)
        {
            frmCompareLayout frmX = new frmCompareLayout();
            GlobalVariables.gResultComponentUID = Convert.ToInt64(xUSBreastUID);
            frmX.Show();
        }


        private void btnX_Lower_Click(object sender, EventArgs e)
        {
            frmCompareLayout frmX = new frmCompareLayout();
            GlobalVariables.gResultComponentUID = Convert.ToInt64(xLowerUID);
            frmX.Show();
        }

        private void grdViewSpecialTest_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle > 0)
            {
                if ((e.RowHandle % 2) == 0)
                {
                    e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                }
                else
                {
                    e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml("#fffafa");
                }
            }

            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {

                //string refNormal = View.GetRowCellDisplayText(e.RowHandle, View.Columns[3]);
                if (grdViewSpecialTest.GetRowCellValue(e.RowHandle, grdViewSpecialTest.Columns[4]) != null)
                {

                    if (grdViewSpecialTest.GetRowCellValue(e.RowHandle, grdViewSpecialTest.Columns[4]).ToString() == "L")
                    {
                        e.Appearance.ForeColor = Color.Orange;
                        //e.Appearance.BackColor = Color.LightPink;                    

                    }
                    else if (grdViewSpecialTest.GetRowCellValue(e.RowHandle, grdViewSpecialTest.Columns[4]).ToString() == "H")
                    {
                        e.Appearance.ForeColor = Color.Red;
                        //e.Appearance.BackColor = Color.LightPink;                    

                    }
                    else if (grdViewSpecialTest.GetRowCellValue(e.RowHandle, grdViewSpecialTest.Columns[4]).ToString() == "LL")
                    {
                        e.Appearance.ForeColor = Color.Orange;
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);

                    }
                    else if (grdViewSpecialTest.GetRowCellValue(e.RowHandle, grdViewSpecialTest.Columns[4]).ToString() == "HH")
                    {
                        e.Appearance.ForeColor = Color.Red;
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);

                    }
                }

            }

        }

        private void lstRecommendList_DoubleClick(object sender, EventArgs e)
        {            
            txtResult_DoctorRecommend.Text += Constants.vbCrLf+lstRecommendList.SelectedValue.ToString(); 
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
            txtResult_DoctorRecommend.DeselectAll();
            startSelect = txtResult_DoctorRecommend.Text.IndexOf(sSearch);
            endSelect = sSearch.Length;
            if (startSelect >= 0) txtResult_DoctorRecommend.Select(startSelect, endSelect);
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

        private void grdViewCBC_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle > 0)
            {
                if ((e.RowHandle % 2) == 0)
                {
                    e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
                }
                else
                {
                    e.Appearance.BackColor = System.Drawing.ColorTranslator.FromHtml("#f2f9ff");
                }
            }

            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {

                //string refNormal = View.GetRowCellDisplayText(e.RowHandle, View.Columns[3]);
                if (gridViewCBC.GetRowCellValue(e.RowHandle, gridViewCBC.Columns[4]) != null)
                {

                    if (gridViewCBC.GetRowCellValue(e.RowHandle, gridViewCBC.Columns[4]).ToString() == "L")
                    {
                        e.Appearance.ForeColor = Color.Orange;
                        //e.Appearance.BackColor = Color.LightPink;                    

                    }
                    else if (gridViewCBC.GetRowCellValue(e.RowHandle, gridViewCBC.Columns[4]).ToString() == "H")
                    {
                        e.Appearance.ForeColor = Color.Red;
                        //e.Appearance.BackColor = Color.LightPink;                    

                    }
                    else if (gridViewCBC.GetRowCellValue(e.RowHandle, gridViewCBC.Columns[4]).ToString() == "LL")
                    {
                        e.Appearance.ForeColor = Color.Orange;
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);

                    }
                    else if (gridViewCBC.GetRowCellValue(e.RowHandle, gridViewCBC.Columns[4]).ToString() == "HH")
                    {
                        e.Appearance.ForeColor = Color.Red;
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);

                    }
                }

            }
        }

        private void frmCheckUpMain_SizeChanged(object sender, EventArgs e)
        {         
            //panelContainerMain.Size = new Size(this.Width, this.Height-220);
            panelContainerResult.Size = new Size(800 , panelContainerResult.Height);
        }

       
        private void cmdPrintReportOld_Click(object sender, EventArgs e)
        {
            GlobalVariables.FagRPT = "CHKUPOLD";
            GlobalVariables.Reportskey = "CHKUPOLD";
            GlobalVariables.gPatientUID = Convert.ToInt64(lblPatientUID.Text);
            GlobalVariables.gPatientVisitUID = Convert.ToInt64(lblPatientVisitUID.Text);

            frmReportViewer floan = new frmReportViewer();
            floan.MdiParent = this.MdiParent;
            floan.Show();
        }

        private void cmdPrintResultBook_Click(object sender, EventArgs e)
        {
            GlobalVariables.FagRPT = "CHKUPBOOK";
            GlobalVariables.Reportskey = "CHKUPBOOK";
            GlobalVariables.gPatientUID = Convert.ToInt64(lblPatientUID.Text);
            GlobalVariables.gPatientVisitUID = Convert.ToInt64(lblPatientVisitUID.Text);

            frmReportViewer floan = new frmReportViewer();
            floan.MdiParent = this.MdiParent;
            floan.Show();
        }
        private void cmdPrintResultBookCover_Click(object sender, EventArgs e)
        {
            GlobalVariables.FagRPT = "CHKUPCOVER";
            GlobalVariables.Reportskey = "CHKUPCOVER";
            GlobalVariables.gPatientUID = Convert.ToInt64(lblPatientUID.Text);
            GlobalVariables.gPatientVisitUID = Convert.ToInt64(lblPatientVisitUID.Text);

            frmReportViewer floan = new frmReportViewer();
            floan.MdiParent = this.MdiParent;
            floan.Show();
        }

        private void cmdPrintResultNew_Click(object sender, EventArgs e)
        {
            GlobalVariables.FagRPT = "CHKUP2019";
            GlobalVariables.Reportskey = "CHKUP2019";
            GlobalVariables.gPatientUID = Convert.ToInt64(lblPatientUID.Text);
            GlobalVariables.gPatientVisitUID = Convert.ToInt64(lblPatientVisitUID.Text);

            frmReportViewer floan = new frmReportViewer();
            floan.MdiParent = this.MdiParent;
            floan.Show();
        }

        private void cmdPrintResultStudent_Click(object sender, EventArgs e)
        {

        }

        private void cmdAdminSave_Click(object sender, EventArgs e)
        {
            if (ValidateData() == false)
            {
                MessageBox.Show(strValidate, "Warning!!");
                return;
            }

            SavePatientAddress();
            SaveGeneralAppearanceResult(Convert.ToInt64(lblPatientVisitUID.Text));
            SaveCheckupResult();

            //SaveDoctorSuggestionAndRecommendByAdmin(Convert.ToInt64(lblPatientVisitUID.Text));

            //Update SaveDate
            //ctlR.Result_UpdateSaveDate(Convert.ToInt64(lblPatientVisitUID.Text));

            cmdPrintResultBookCover.Visible = true;
            cmdPrintResultBook.Visible = true;
            cmdPrintResultNew.Visible = true;
            cmdPrintResultOld.Visible = true;
            cmdPrintResultStudent.Visible = false;

            ctlUser.User_GenLogfile(DataHelper.LoginUser, "ADMIN SAVE", "CHECKUP", "บันทึกผลการตรวจสุขภาพ:SUTHOS", "PatientUID=" + lblPatientUID.Text + ",VisitUID=" + lblPatientVisitUID.Text);

            MessageBox.Show("บันทึกข้อมูลเรียบร้อย", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        private void btnPAC_PA_Click(object sender, EventArgs e)
        {
            RequestDetailUID = ctlR.HO_Result_GetRequestDetailUID(Convert.ToInt64(lblPatientVisitUID.Text), "XRGEN001"); 
            if (RequestDetailUID == "")
            {
                RequestDetailUID = ctlR.HO_Result_GetRequestDetailUID(Convert.ToInt64(lblPatientVisitUID.Text), "XRGEN398");
            }

            if (RequestDetailUID == "")
            {
               Process.Start("http://pacssmc/explore.asp?path=/All%20Patients/InternalPatientUID=" + lblHN.Text);
            }
            else
            {
                Process.Start("http://pacssmc/explore.asp?path=/Session/Working%20Studies/AccessionNumber="+ RequestDetailUID);
            }            
        }

        private void btnPAC_Echo_Click(object sender, EventArgs e)
        {
            RequestDetailUID = ctlR.HO_Result_GetRequestDetailUID(Convert.ToInt64(lblPatientVisitUID.Text), "DX0012");
            if (RequestDetailUID == "")
            {
                Process.Start("http://pacssmc/explore.asp?path=/All%20Patients/InternalPatientUID=" + lblHN.Text);
            }
            else
            {
                Process.Start("http://pacssmc/explore.asp?path=/Session/Working%20Studies/AccessionNumber=" + RequestDetailUID);
            }
        }

        private void btnPAC_Mammo_Click(object sender, EventArgs e)
        {
            RequestDetailUID = ctlR.HO_Result_GetRequestDetailUID(Convert.ToInt64(lblPatientVisitUID.Text), "XRSP011");
            if (RequestDetailUID == "")
            {
                Process.Start("http://pacssmc/explore.asp?path=/All%20Patients/InternalPatientUID=" + lblHN.Text);
            }
            else
            {
                Process.Start("http://pacssmc/explore.asp?path=/Session/Working%20Studies/AccessionNumber=" + RequestDetailUID);
            }
        }

        private void btnPAC_Abdomen_Click(object sender, EventArgs e)
        {
            RequestDetailUID = ctlR.HO_Result_GetRequestDetailUID(Convert.ToInt64(lblPatientVisitUID.Text), "XRUS031");
            if (RequestDetailUID == "")
            {
                Process.Start("http://pacssmc/explore.asp?path=/All%20Patients/InternalPatientUID=" + lblHN.Text);
            }
            else
            {
                Process.Start("http://pacssmc/explore.asp?path=/Session/Working%20Studies/AccessionNumber=" + RequestDetailUID);
            }
        }

        private void btnPAC_Upper_Click(object sender, EventArgs e)
        {
            RequestDetailUID = ctlR.HO_Result_GetRequestDetailUID(Convert.ToInt64(lblPatientVisitUID.Text), "XRUS029");
            if (RequestDetailUID == "")
            {
                Process.Start("http://pacssmc/explore.asp?path=/All%20Patients/InternalPatientUID=" + lblHN.Text);
            }
            else
            {
                Process.Start("http://pacssmc/explore.asp?path=/Session/Working%20Studies/AccessionNumber=" + RequestDetailUID);
            }
        }

        private void btnPAC_Lower_Click(object sender, EventArgs e)
        {
            RequestDetailUID = ctlR.HO_Result_GetRequestDetailUID(Convert.ToInt64(lblPatientVisitUID.Text), "XRUS019");
            if (RequestDetailUID == "")
            {
                Process.Start("http://pacssmc/explore.asp?path=/All%20Patients/InternalPatientUID=" + lblHN.Text);
            }
            else
            {
                Process.Start("http://pacssmc/explore.asp?path=/Session/Working%20Studies/AccessionNumber=" + RequestDetailUID);
            }
        }

        private void btnPAC_BMD_Click(object sender, EventArgs e)
        {
            RequestDetailUID = ctlR.HO_Result_GetRequestDetailUID(Convert.ToInt64(lblPatientVisitUID.Text), "XRBMD004");
            if (RequestDetailUID == "")
            {
                Process.Start("http://pacssmc/explore.asp?path=/All%20Patients/InternalPatientUID=" + lblHN.Text);
            }
            else
            {
                Process.Start("http://pacssmc/explore.asp?path=/Session/Working%20Studies/AccessionNumber=" + RequestDetailUID);
            }
        }

        private void btnPAC_USBreast_Click(object sender, EventArgs e)
        {
            RequestDetailUID = ctlR.HO_Result_GetRequestDetailUID(Convert.ToInt64(lblPatientVisitUID.Text), "XRUS003");
            if (RequestDetailUID == "")
            {
                Process.Start("http://pacssmc/explore.asp?path=/All%20Patients/InternalPatientUID=" + lblHN.Text);
            }
            else
            {
                Process.Start("http://pacssmc/explore.asp?path=/Session/Working%20Studies/AccessionNumber=" + RequestDetailUID);
            }
        }


        //private void cboPrintReport_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    switch (cboPrintReport.SelectedIndex)
        //    {
        //        case 1:
        //            GlobalVariables.FagRPT = "CHKUPCOVER";
        //            GlobalVariables.Reportskey = "CHKUPCOVER";                                    
        //            break;
        //        case 2:
        //            GlobalVariables.FagRPT = "CHKUPBOOK";
        //            GlobalVariables.Reportskey = "CHKUPBOOK";
        //            break;
        //        case 3:
        //            GlobalVariables.FagRPT = "CHKUP2019";
        //            GlobalVariables.Reportskey = "CHKUP2019";
        //            break;
        //        case 4:
        //            GlobalVariables.FagRPT = "CHKUP01";
        //            GlobalVariables.Reportskey = "CHKUP01";
        //            break;
        //    }

        //    if (cboPrintReport.SelectedIndex!=0)
        //    {
        //        GlobalVariables.gPatientUID = Convert.ToInt64(lblPatientUID.Text);
        //        GlobalVariables.gPatientVisitUID = Convert.ToInt64(lblPatientVisitUID.Text);
        //        frmReportViewer floan = new frmReportViewer();
        //        floan.MdiParent = this.MdiParent;
        //        floan.Show();
        //    }

        //}





        //private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        //{          
        //    progressLoad.Size = new Size(this.Width, this.Height);
        //    progressLoad.Location = new Point(0, 0);
        //    progressLoad.Visible = true;

        //    for(i=1;i<=100;i++)
        //    {
        //        backgroundWorker1.ReportProgress(i);
        //        Thread.Sleep(10);
        //        lblProgress.Text = progressBar1.Value.ToString() + "%";
        //    }


        //}

        //private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        //{
        //    progressBar1.Value = e.ProgressPercentage;
        //}

        //private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        //{
        //    progressLoad.Visible = false;
        //}
    }
}
