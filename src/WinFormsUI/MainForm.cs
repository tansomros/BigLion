using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using Microsoft.Extensions.DependencyInjection;
using SUTH.HealthCheckup.WinFormsUI.Checkup.Api.Client;
using SUTH.HealthCheckup.WinFormsUI.Controllers;
using SUTH.HealthCheckup.WinFormsUI.Functions;
using SUTH.HealthCheckup.WinFormsUI.Hosxp.Api.Client;
using SUTH.HealthCheckup.WinFormsUI.Interfaces;
using SUTH.HealthCheckup.WinFormsUI.Reports;

namespace SUTH.HealthCheckup.WinFormsUI
{
    public partial class MainForm : RibbonForm
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserContext _userContext;
        private readonly CheckupApiClient _checkupApiClient;
        private readonly HosxpApiClient _hosxpApiClient;
        //uctrlReportCenter _report;
        Version appVersion { get; set; }

        public MainForm(
            IServiceProvider serviceProvider,
            IAuthenticationService authenticationService,
            IUserContext userContext,
            CheckupApiClient checkupApiClient,
            HosxpApiClient hosxpApiClient)
        {
            _serviceProvider = serviceProvider;
            _authenticationService = authenticationService;
            _userContext = userContext;
            _hosxpApiClient = hosxpApiClient;
            _checkupApiClient = checkupApiClient;

            InitializeComponent();
            InitSkinGallery();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            ShowVersion();
            SetupUserInterface();
            ///this.BringToFront();
        }

        private void ShowVersion()
        {

#if DEBUG
            //Version_Lbl.Text = "DebuggMode";
            this.Text = "SUTH-Checkup : [DebuggMode]";
#else
            var ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            string version = string.Format("{0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision);
            this.Text = "SUTH-Checkup : [v." + version + "]";
#endif
        }

        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DevExpress.Skins.SkinManager.EnableFormSkins();
            //DevExpress.UserSkins.BonusSkins.Register();
            //UserLookAndFeel.Default.SetSkinStyle(SkinStyle.VisualStudio2010);
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            GlobalVariables._MAINFORM = this;
            //if (ApplicationDeployment.IsNetworkDeployed)
            //    appVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion;
            //this.Text = "SUTH-Checkup : [v." + appVersion + "]";

            //frmCheckUpList frmCkup = new frmCheckUpList();
            //frmCkup.MdiParent = this;
            //frmCkup.Show();

            //frmNote frmN = new frmNote();
            //frmN.MdiParent = this;
            //frmN.Show();

            //barHearderUser.Caption = DataHelper.username;
            //siInfoDB.Caption = DataHelper.dbconnection;

            ////string test = "[PatientInfo][Registration][Report506][Clinic][CustomReport]";
            //DataHelper.admin = DataHelper.accessright.Contains("Administrator");
            //if (DataHelper.admin == true) { return; }
            ////string[] arr = test.Split(new[] { ']' });
            //string[] arr = DataHelper.accessright.Split(new[] { ']' });

            //foreach (RibbonPage p in this.ribbonControl.Pages)
            //{
            //    p.Visible = false;
            //    foreach (RibbonPageGroup g in p.Groups)
            //    {
            //        //p.Visible = false;
            //        g.Visible = false;
            //        foreach (BarItemLink i in g.ItemLinks)
            //        {
            //            int has = Array.IndexOf(arr, "[" + i.Item.AccessibleName);
            //            if (has >= 0)
            //            {
            //                p.Visible = true;
            //                g.Visible = true;
            //                i.Item.Visibility = BarItemVisibility.Always;
            //            }
            //            else
            //            {
            //                i.Item.Visibility = BarItemVisibility.Never;
            //            }
            //        }
            //    }
            //}


            // SetThaiLanguage();

            ////ใช้ทดสอบเฉพาะพี่ธีร์ เด๋วเสร็จแล้วจะลบออก 
            //if (DataHelper.username == "557099")
            //{
            //    menuCheckupMergeVisit.Visibility = BarItemVisibility.Always;
            //}
            //else
            //{
            //    menuCheckupMergeVisit.Visibility = BarItemVisibility.Never;
            //}

            //-------------------
            GroupChkUpSetting.Visible = false;
            GroupChkUpReport.Visible = false;

            var user = _userContext.CurrentUser;

            if (user != null && user.HasAdminRole)
            {
                PageSetting.Visible = true;
                GroupChkUpReport.Visible = true;
                GroupChkUpSetting.Visible = true;
                GroupChkUpAdmin.Visible = true;
            }



            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.VisualStudio2010);
            GlobalFunctions.CheckOpenedForm(this);
            //frmCheckUpList frmChkUp = new(_checkupApiClient, _hosxpApiClient);

            // เปิดฟอร์มลูก ไปเอา Form ลูกที่ฉีกเข้าไปใน ServiceCollection แล้วเช่น
            var checkupListForm = _serviceProvider.GetRequiredService<CheckUpListForm>();
            checkupListForm.MdiParent = this;
            checkupListForm.Show();
        }

        private void menuPatientInfo_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("ท่านต้องการปิดโปรแกรมใช่หรือไม่", "ปิดโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Environment.Exit(0);
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }

            // GC.Collect();
            // this.Dispose();
            // this.Close();
            // ////Environment.Exit(1);
            //var th = new Thread(openLoginFrom);
            // th.SetApartmentState(ApartmentState.STA);
            // th.Start();
        }

        private void openLoginFrom()
        {
            //Login();
            //Application.Run(new frmLogin());
        }


        private void menuR506_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void menuUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            GlobalFunctions.CheckOpenedForm(this);
            //Setting.frmUser frmUser = new Setting.frmUser();
            //frmUser.MdiParent = this;
            //frmUser.Show();
        }


        private void MenuExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Setting.frmChangePassword frmChangePwd = new Setting.frmChangePassword();
            //frmChangePwd.MdiParent = this;
            //frmChangePwd.Show();
        }



        private void menuSSNExport_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void menuCheckUpPatientList_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.VisualStudio2010);
            GlobalFunctions.CheckOpenedForm(this);
            var checkupListForm = _serviceProvider.GetRequiredService<CheckUpListForm>();
            checkupListForm.MdiParent = this;
            checkupListForm.Show();
        }

        private void menuCheckupRecomend_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.VisualStudio2010);
            GlobalFunctions.CheckOpenedForm(this);
            var recmForm = _serviceProvider.GetRequiredService<RecommendationForm>();
            //RecommendationForm recmForm = new RecommendationForm();
            recmForm.MdiParent = this;
            recmForm.Show();
        }
        private void mnuCheckupReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            //if (_report == null || _report.IsDisposed)
            //    _report = new uctrlReportCenter() { Text = "Report Center" };
            //AddTabView(_report);
            //tabbedView.ActivateDocument(_report);

            GlobalFunctions.CheckOpenedForm(this);
            var recmForm = _serviceProvider.GetRequiredService<ReportCenter>();
            //RecommendationForm recmForm = new RecommendationForm();
            recmForm.MdiParent = this;
            recmForm.Show();
        }
        //void AddTabView(XtraUserControl userControl)
        //{
        //    bool controlDuplicate = false;
        //    foreach (var ctrl in tabbedView.Documents)
        //        if (ctrl.Control == userControl)
        //            controlDuplicate = true;

        //    if (!controlDuplicate)
        //    {
        //        tabbedView.AddDocument(userControl);
        //        tabbedView.ActivateDocument(userControl);
        //    }
        //}

        private void menuCheckupMergeVisit_ItemClick(object sender, ItemClickEventArgs e)
        {
            //GlobalFunctions.CheckOpenedForm(this);
            //CheckUp.frmCheckUpMergeVisit frmChkUp = new CheckUp.frmCheckUpMergeVisit();
            //frmChkUp.MdiParent = this;
            //frmChkUp.Show();
        }

        private void mnuBookCover_ItemClick(object sender, ItemClickEventArgs e)
        {
            //GlobalVariables.FagRPT = "COVER";
            //GlobalVariables.Reportskey = "COVER";

            //CheckUp.frmReportViewer floan = new CheckUp.frmReportViewer();
            //floan.MdiParent = this;
            //floan.Show();
        }


        private void mnuCheckupPatientItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            //CheckUp.frmPatientCheckupItem frmB = new CheckUp.frmPatientCheckupItem();
            //frmB.MdiParent = this;
            //frmB.Show();            
        }

        private void menuCheckUp_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.VisualStudio2010);
            GlobalFunctions.CheckOpenedForm(this);
            //CheckUp.frmCheckupPersonal frmChkUp = new CheckUp.frmCheckupPersonal();
            //frmChkUp.MdiParent = this;
            //frmChkUp.Show();
        }

        private void mnuSyncDataCheckup_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.VisualStudio2010);
            GlobalFunctions.CheckOpenedForm(this);
            var frmForm = _serviceProvider.GetRequiredService<SyncDataForm>();
            frmForm.MdiParent = this;
            frmForm.Show();
        }

        private void mnuNews_ItemClick(object sender, ItemClickEventArgs e)
        {
            //frmNote frmChkUp = new frmNote();
            //frmChkUp.MdiParent = this;
            //frmChkUp.Show();
        }

        private void SignOut_BtnClick(object sender, ItemClickEventArgs e)
        {
            var result = MessageBox.Show("ยืนยันการ logout หรือไม่", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _authenticationService.LogoutAsync();
                Application.Restart();
            }
        }

        private void SetupUserInterface()
        {
            // Sort User information
            var user = _userContext.CurrentUser;
            stbUser.Caption = $"สวัสดีวันสดใส, {user.Name}";

        }

        private void mnuReportManager_ItemClick(object sender, ItemClickEventArgs e)
        {
            //GlobalFunctions.CheckOpenedForm(this);
            var recmForm = _serviceProvider.GetRequiredService<ReportCenter>();       
            recmForm.MdiParent = this;
            recmForm.Show();
        }
    }
}
