using SUTH.HealthCheckup.WinFormsUI.Properties;

namespace SUTH.HealthCheckup.WinFormsUI
{
    partial class CheckUpListForm : System.Windows.Forms.Form
{
         
        private System.ComponentModel.IContainer components = new System.ComponentModel.Container(); // กำหนดค่าให้กับ components


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


        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckUpListForm));
            SplitContentControlMain = new DevExpress.XtraEditors.SplitContainerControl();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            btnNextDate = new DevExpress.XtraEditors.SimpleButton();
            btnPrvDate = new DevExpress.XtraEditors.SimpleButton();
            dtpEndDate = new DevExpress.XtraEditors.DateEdit();
            DtpStartDate = new DevExpress.XtraEditors.DateEdit();
            label6 = new Label();
            cboCompany = new DevExpress.XtraEditors.LookUpEdit();
            BtnClear = new DevExpress.XtraEditors.SimpleButton();
            cboCareprovider = new DevExpress.XtraEditors.LookUpEdit();
            BtnSearch = new DevExpress.XtraEditors.SimpleButton();
            cboCheckupType = new DevExpress.XtraEditors.LookUpEdit();
            label62 = new Label();
            cboStatus = new DevExpress.XtraEditors.LookUpEdit();
            label61 = new Label();
            Label1 = new Label();
            label4 = new Label();
            TxtSearch = new DevExpress.XtraEditors.TextEdit();
            Label2 = new Label();
            Label3 = new Label();
            panel3 = new Panel();
            grdData = new DevExpress.XtraGrid.GridControl();
            gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            colRow = new DevExpress.XtraGrid.Columns.GridColumn();
            colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            chkStar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            colPrint = new DevExpress.XtraGrid.Columns.GridColumn();
            chkPrint = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            colVisitDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colHN = new DevExpress.XtraGrid.Columns.GridColumn();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            colSex = new DevExpress.XtraGrid.Columns.GridColumn();
            colNationId = new DevExpress.XtraGrid.Columns.GridColumn();
            colPackage = new DevExpress.XtraGrid.Columns.GridColumn();
            colPayor = new DevExpress.XtraGrid.Columns.GridColumn();
            colType = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            colDoctorPE = new DevExpress.XtraGrid.Columns.GridColumn();
            colDoctorResult = new DevExpress.XtraGrid.Columns.GridColumn();
            colCurrentStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            colVN = new DevExpress.XtraGrid.Columns.GridColumn();
            colLab = new DevExpress.XtraGrid.Columns.GridColumn();
            chkStatus = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            colXray = new DevExpress.XtraGrid.Columns.GridColumn();
            colEye = new DevExpress.XtraGrid.Columns.GridColumn();
            chkVision = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            colDent = new DevExpress.XtraGrid.Columns.GridColumn();
            chkDent = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            panel4 = new Panel();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            txtPageCurrent = new DevExpress.XtraEditors.TextEdit();
            txtPageTotal = new DevExpress.XtraEditors.TextEdit();
            label7 = new Label();
            cmdPageNext = new DevExpress.XtraEditors.SimpleButton();
            cmdPageBack = new DevExpress.XtraEditors.SimpleButton();
            panel1 = new Panel();
            lblClose = new Label();
            label5 = new Label();
            panel2 = new Panel();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            ((System.ComponentModel.ISupportInitialize)SplitContentControlMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SplitContentControlMain.Panel1).BeginInit();
            SplitContentControlMain.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContentControlMain.Panel2).BeginInit();
            SplitContentControlMain.Panel2.SuspendLayout();
            SplitContentControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtpEndDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtpEndDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtpStartDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtpStartDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboCompany.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboCareprovider.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboCheckupType.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cboStatus.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtSearch.Properties).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkStar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkPrint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkVision).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkDent).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPageCurrent.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPageTotal.Properties).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // SplitContentControlMain
            // 
            SplitContentControlMain.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            SplitContentControlMain.Dock = DockStyle.Fill;
            SplitContentControlMain.Horizontal = false;
            SplitContentControlMain.Location = new Point(0, 0);
            SplitContentControlMain.Margin = new Padding(0);
            SplitContentControlMain.Name = "SplitContentControlMain";
            // 
            // SplitContentControlMain.Panel1
            // 
            SplitContentControlMain.Panel1.Controls.Add(groupControl1);
            // 
            // SplitContentControlMain.Panel2
            // 
            SplitContentControlMain.Panel2.AutoScroll = true;
            SplitContentControlMain.Panel2.Controls.Add(panel3);
            SplitContentControlMain.Panel2.Controls.Add(panel4);
            SplitContentControlMain.Size = new Size(1427, 734);
            SplitContentControlMain.TabIndex = 3;
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(btnNextDate);
            groupControl1.Controls.Add(btnPrvDate);
            groupControl1.Controls.Add(dtpEndDate);
            groupControl1.Controls.Add(DtpStartDate);
            groupControl1.Controls.Add(label6);
            groupControl1.Controls.Add(cboCompany);
            groupControl1.Controls.Add(BtnClear);
            groupControl1.Controls.Add(cboCareprovider);
            groupControl1.Controls.Add(BtnSearch);
            groupControl1.Controls.Add(cboCheckupType);
            groupControl1.Controls.Add(label62);
            groupControl1.Controls.Add(cboStatus);
            groupControl1.Controls.Add(label61);
            groupControl1.Controls.Add(Label1);
            groupControl1.Controls.Add(label4);
            groupControl1.Controls.Add(TxtSearch);
            groupControl1.Controls.Add(Label2);
            groupControl1.Controls.Add(Label3);
            groupControl1.Dock = DockStyle.Fill;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(1427, 100);
            groupControl1.TabIndex = 11;
            groupControl1.Text = "groupControl1";
            // 
            // btnNextDate
            // 
            btnNextDate.Cursor = Cursors.Hand;
            btnNextDate.ImageOptions.Image = Resources.next2;
            btnNextDate.Location = new Point(283, 62);
            btnNextDate.Margin = new Padding(0);
            btnNextDate.Name = "btnNextDate";
            btnNextDate.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnNextDate.Size = new Size(35, 26);
            btnNextDate.TabIndex = 20;
            btnNextDate.Click += btnNextDate_Click;
            // 
            // btnPrvDate
            // 
            btnPrvDate.Appearance.BackColor = Color.White;
            btnPrvDate.Appearance.BorderColor = Color.Transparent;
            btnPrvDate.Appearance.Options.UseBackColor = true;
            btnPrvDate.Appearance.Options.UseBorderColor = true;
            btnPrvDate.Cursor = Cursors.Hand;
            btnPrvDate.ImageOptions.Image = Resources.prev2;
            btnPrvDate.Location = new Point(283, 28);
            btnPrvDate.Margin = new Padding(0);
            btnPrvDate.Name = "btnPrvDate";
            btnPrvDate.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            btnPrvDate.Size = new Size(35, 26);
            btnPrvDate.TabIndex = 19;
            btnPrvDate.Click += btnPrvDate_Click;
            // 
            // dtpEndDate
            // 
            dtpEndDate.EditValue = null;
            dtpEndDate.Location = new Point(91, 61);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Properties.Appearance.Font = new Font("Sarabun", 9F);
            dtpEndDate.Properties.Appearance.Options.UseFont = true;
            dtpEndDate.Properties.AppearanceCalendar.Button.Font = new Font("Sarabun", 9F);
            dtpEndDate.Properties.AppearanceCalendar.Button.Options.UseFont = true;
            dtpEndDate.Properties.AppearanceCalendar.Header.Font = new Font("Sarabun", 9F);
            dtpEndDate.Properties.AppearanceCalendar.Header.Options.UseFont = true;
            dtpEndDate.Properties.AppearanceCalendar.WeekDay.Font = new Font("Sarabun", 9F);
            dtpEndDate.Properties.AppearanceCalendar.WeekDay.Options.UseFont = true;
            dtpEndDate.Properties.AppearanceCalendar.WeekNumber.Font = new Font("Sarabun", 9F);
            dtpEndDate.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = true;
            dtpEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtpEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtpEndDate.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            dtpEndDate.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            dtpEndDate.Size = new Size(190, 28);
            dtpEndDate.TabIndex = 2;
            // 
            // DtpStartDate
            // 
            DtpStartDate.EditValue = null;
            DtpStartDate.Location = new Point(91, 26);
            DtpStartDate.Name = "DtpStartDate";
            DtpStartDate.Properties.Appearance.Font = new Font("Sarabun", 9F);
            DtpStartDate.Properties.Appearance.Options.UseFont = true;
            DtpStartDate.Properties.AppearanceCalendar.Button.Font = new Font("Prompt", 10F);
            DtpStartDate.Properties.AppearanceCalendar.Button.Options.UseFont = true;
            DtpStartDate.Properties.AppearanceCalendar.DayCell.Font = new Font("Sarabun", 9F);
            DtpStartDate.Properties.AppearanceCalendar.DayCell.Options.UseFont = true;
            DtpStartDate.Properties.AppearanceCalendar.Header.Font = new Font("Prompt", 9.749999F);
            DtpStartDate.Properties.AppearanceCalendar.Header.Options.UseFont = true;
            DtpStartDate.Properties.AppearanceCalendar.WeekDay.Font = new Font("Sarabun", 9F);
            DtpStartDate.Properties.AppearanceCalendar.WeekDay.Options.UseFont = true;
            DtpStartDate.Properties.AppearanceCalendar.WeekNumber.Font = new Font("Sarabun", 9F);
            DtpStartDate.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = true;
            DtpStartDate.Properties.AppearanceDropDown.Font = new Font("Sarabun", 9F);
            DtpStartDate.Properties.AppearanceDropDown.Options.UseFont = true;
            DtpStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DtpStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DtpStartDate.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            DtpStartDate.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            DtpStartDate.Size = new Size(190, 28);
            DtpStartDate.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(13, 64);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(65, 19);
            label6.TabIndex = 18;
            label6.Text = "End Date";
            // 
            // cboCompany
            // 
            cboCompany.EditValue = "";
            cboCompany.Location = new Point(943, 24);
            cboCompany.Margin = new Padding(4, 3, 4, 3);
            cboCompany.Name = "cboCompany";
            cboCompany.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            cboCompany.Properties.Appearance.Font = new Font("Sarabun", 9F);
            cboCompany.Properties.Appearance.Options.UseFont = true;
            cboCompany.Properties.AppearanceDropDown.Font = new Font("Sarabun", 9F);
            cboCompany.Properties.AppearanceDropDown.Options.UseFont = true;
            cboCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Company", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.True) });
            cboCompany.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            cboCompany.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            cboCompany.Properties.NullText = "";
            cboCompany.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            cboCompany.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            cboCompany.Size = new Size(288, 28);
            cboCompany.TabIndex = 4;
            cboCompany.KeyDown += cboCompany_KeyDown;
            // 
            // BtnClear
            // 
            BtnClear.Appearance.Font = new Font("Segoe UI", 10.5F);
            BtnClear.Appearance.ForeColor = Color.White;
            BtnClear.Appearance.Options.UseFont = true;
            BtnClear.Appearance.Options.UseForeColor = true;
            BtnClear.ImageOptions.Image = (Image)resources.GetObject("BtnClear.ImageOptions.Image");
            BtnClear.Location = new Point(1046, 58);
            BtnClear.LookAndFeel.SkinMaskColor = SystemColors.ActiveCaption;
            BtnClear.LookAndFeel.SkinName = "DevExpress Dark Style";
            BtnClear.LookAndFeel.UseDefaultLookAndFeel = false;
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(88, 29);
            BtnClear.TabIndex = 9;
            BtnClear.Text = "Clear";
            BtnClear.Click += BtnClear_Click;
            // 
            // cboCareprovider
            // 
            cboCareprovider.EditValue = "";
            cboCareprovider.Location = new Point(403, 59);
            cboCareprovider.Margin = new Padding(4, 3, 4, 3);
            cboCareprovider.Name = "cboCareprovider";
            cboCareprovider.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            cboCareprovider.Properties.Appearance.Font = new Font("Sarabun", 9F);
            cboCareprovider.Properties.Appearance.Options.UseFont = true;
            cboCareprovider.Properties.AppearanceDropDown.Font = new Font("Sarabun", 9F);
            cboCareprovider.Properties.AppearanceDropDown.Options.UseFont = true;
            cboCareprovider.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboCareprovider.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullNameThai", "Doctor", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            cboCareprovider.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            cboCareprovider.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            cboCareprovider.Properties.NullText = "";
            cboCareprovider.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            cboCareprovider.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            cboCareprovider.Size = new Size(190, 28);
            cboCareprovider.TabIndex = 6;
            cboCareprovider.KeyDown += cboCareprovider_KeyDown;
            // 
            // BtnSearch
            // 
            BtnSearch.Appearance.Font = new Font("Segoe UI", 10.5F);
            BtnSearch.Appearance.ForeColor = Color.White;
            BtnSearch.Appearance.Options.UseFont = true;
            BtnSearch.Appearance.Options.UseForeColor = true;
            BtnSearch.ImageOptions.Image = (Image)resources.GetObject("BtnSearch.ImageOptions.Image");
            BtnSearch.Location = new Point(943, 58);
            BtnSearch.LookAndFeel.SkinMaskColor = Color.FromArgb(3, 56, 148);
            BtnSearch.LookAndFeel.SkinName = "DevExpress Dark Style";
            BtnSearch.LookAndFeel.UseDefaultLookAndFeel = false;
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(88, 29);
            BtnSearch.TabIndex = 8;
            BtnSearch.Text = "Search";
            BtnSearch.Click += BtnSearch_Click;
            // 
            // cboCheckupType
            // 
            cboCheckupType.EditValue = "";
            cboCheckupType.Location = new Point(669, 24);
            cboCheckupType.Margin = new Padding(4, 3, 4, 3);
            cboCheckupType.Name = "cboCheckupType";
            cboCheckupType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            cboCheckupType.Properties.Appearance.Font = new Font("Sarabun", 9F);
            cboCheckupType.Properties.Appearance.Options.UseFont = true;
            cboCheckupType.Properties.AppearanceDropDown.Font = new Font("Sarabun", 9F);
            cboCheckupType.Properties.AppearanceDropDown.Options.UseFont = true;
            cboCheckupType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboCheckupType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Type", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            cboCheckupType.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            cboCheckupType.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            cboCheckupType.Properties.NullText = "";
            cboCheckupType.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            cboCheckupType.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            cboCheckupType.Size = new Size(190, 28);
            cboCheckupType.TabIndex = 5;
            cboCheckupType.KeyDown += cboCheckupType_KeyDown;
            // 
            // label62
            // 
            label62.AutoSize = true;
            label62.Font = new Font("Segoe UI", 10F);
            label62.Location = new Point(330, 64);
            label62.Margin = new Padding(4, 0, 4, 0);
            label62.Name = "label62";
            label62.Size = new Size(69, 19);
            label62.TabIndex = 13;
            label62.Text = "Report By";
            // 
            // cboStatus
            // 
            cboStatus.EditValue = "";
            cboStatus.Location = new Point(403, 25);
            cboStatus.Margin = new Padding(4, 3, 4, 3);
            cboStatus.Name = "cboStatus";
            cboStatus.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            cboStatus.Properties.Appearance.Font = new Font("Sarabun", 9F);
            cboStatus.Properties.Appearance.Options.UseFont = true;
            cboStatus.Properties.AppearanceDropDown.Font = new Font("Sarabun", 9F);
            cboStatus.Properties.AppearanceDropDown.Options.UseFont = true;
            cboStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cboStatus.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descriptions", "Status", 17, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default) });
            cboStatus.Properties.DropDownRows = 4;
            cboStatus.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            cboStatus.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            cboStatus.Properties.NullText = "";
            cboStatus.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            cboStatus.Properties.PopupSizeable = false;
            cboStatus.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            cboStatus.Size = new Size(190, 28);
            cboStatus.TabIndex = 3;
            cboStatus.KeyDown += cboStatus_KeyDown;
            // 
            // label61
            // 
            label61.AutoSize = true;
            label61.Font = new Font("Segoe UI", 10F);
            label61.Location = new Point(612, 30);
            label61.Margin = new Padding(4, 0, 4, 0);
            label61.Name = "label61";
            label61.Size = new Size(37, 19);
            label61.TabIndex = 12;
            label61.Text = "Type";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI", 10F);
            Label1.Location = new Point(13, 30);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(71, 19);
            Label1.TabIndex = 1;
            Label1.Text = "Start Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(867, 30);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 10;
            label4.Text = "Company";
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(669, 59);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Properties.Appearance.Font = new Font("Sarabun", 9F);
            TxtSearch.Properties.Appearance.Options.UseFont = true;
            TxtSearch.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            TxtSearch.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            TxtSearch.Properties.NullValuePrompt = "HN, Name , LastName";
            TxtSearch.Size = new Size(190, 28);
            TxtSearch.TabIndex = 7;
            TxtSearch.KeyDown += TxtSearch_KeyDown;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI", 10F);
            Label2.Location = new Point(330, 31);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(47, 19);
            Label2.TabIndex = 4;
            Label2.Text = "Status";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 10F);
            Label3.Location = new Point(612, 64);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(49, 19);
            Label3.TabIndex = 5;
            Label3.Text = "Search";
            // 
            // panel3
            // 
            panel3.Controls.Add(grdData);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1427, 591);
            panel3.TabIndex = 2;
            // 
            // grdData
            // 
            grdData.Dock = DockStyle.Fill;
            grdData.EmbeddedNavigator.Margin = new Padding(4, 3, 4, 3);
            grdData.Font = new Font("TH SarabunPSK", 14F);
            grdData.Location = new Point(0, 0);
            grdData.LookAndFeel.SkinName = "Office 2010 Blue";
            grdData.LookAndFeel.UseDefaultLookAndFeel = false;
            grdData.MainView = gridViewData;
            grdData.Margin = new Padding(0);
            grdData.Name = "grdData";
            grdData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { chkStar, chkPrint, chkStatus, chkVision, chkDent });
            grdData.Size = new Size(1427, 591);
            grdData.TabIndex = 3;
            grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewData });
            // 
            // gridViewData
            // 
            gridViewData.Appearance.FocusedCell.Font = new Font("Segoe UI", 10F);
            gridViewData.Appearance.FocusedCell.Options.UseFont = true;
            gridViewData.Appearance.FocusedRow.BackColor = SystemColors.HotTrack;
            gridViewData.Appearance.FocusedRow.Font = new Font("Sarabun", 9.5F);
            gridViewData.Appearance.FocusedRow.ForeColor = Color.White;
            gridViewData.Appearance.FocusedRow.Options.UseBackColor = true;
            gridViewData.Appearance.FocusedRow.Options.UseFont = true;
            gridViewData.Appearance.FocusedRow.Options.UseForeColor = true;
            gridViewData.Appearance.HeaderPanel.Font = new Font("Sarabun", 9F, FontStyle.Bold);
            gridViewData.Appearance.HeaderPanel.ForeColor = Color.FromArgb(3, 56, 148);
            gridViewData.Appearance.HeaderPanel.Options.UseFont = true;
            gridViewData.Appearance.HeaderPanel.Options.UseForeColor = true;
            gridViewData.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridViewData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewData.Appearance.Row.Font = new Font("Sarabun", 9.5F);
            gridViewData.Appearance.Row.Options.UseFont = true;
            gridViewData.Appearance.Row.Options.UseTextOptions = true;
            gridViewData.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewData.Appearance.SelectedRow.BackColor = SystemColors.HotTrack;
            gridViewData.Appearance.SelectedRow.Font = new Font("Segoe UI", 10F);
            gridViewData.Appearance.SelectedRow.ForeColor = Color.White;
            gridViewData.Appearance.SelectedRow.Options.UseBackColor = true;
            gridViewData.Appearance.SelectedRow.Options.UseFont = true;
            gridViewData.Appearance.SelectedRow.Options.UseForeColor = true;
            gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colRow, colStatus, colPrint, colVisitDate, colHN, colName, colAge, colSex, colNationId, colPackage, colPayor, colType, gridColumn3, colDoctorPE, colDoctorResult, colCurrentStatus, colVN, colLab, colXray, colEye, colDent });
            gridViewData.DetailHeight = 372;
            gridViewData.GridControl = grdData;
            gridViewData.Name = "gridViewData";
            gridViewData.OptionsBehavior.Editable = false;
            gridViewData.OptionsEditForm.PopupEditFormWidth = 700;
            gridViewData.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridViewData.OptionsSelection.EnableAppearanceHideSelection = false;
            gridViewData.OptionsView.ShowIndicator = false;
            gridViewData.CustomDrawCell += gridViewData_CustomDrawCell;
            gridViewData.RowStyle += gridViewData_RowStyle;
            gridViewData.CustomUnboundColumnData += gridViewData_CustomUnboundColumnData;
            gridViewData.MouseDown += gridViewData_MouseDown;
            gridViewData.DoubleClick += gridViewData_DoubleClick;
            // 
            // colRow
            // 
            colRow.Caption = "No.";
            colRow.FieldName = "Row";
            colRow.MinWidth = 17;
            colRow.Name = "colRow";
            colRow.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            colRow.Visible = true;
            colRow.VisibleIndex = 0;
            colRow.Width = 35;
            // 
            // colStatus
            // 
            colStatus.Caption = "Status";
            colStatus.ColumnEdit = chkStar;
            colStatus.FieldName = "FinalStatus";
            colStatus.MinWidth = 17;
            colStatus.Name = "colStatus";
            colStatus.OptionsColumn.ShowCaption = false;
            colStatus.Visible = true;
            colStatus.VisibleIndex = 1;
            colStatus.Width = 21;
            // 
            // chkStar
            // 
            chkStar.AutoHeight = false;
            chkStar.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            chkStar.ImageOptions.ImageChecked = Resources.star_orange;
            chkStar.ImageOptions.ImageGrayed = Resources.star_blue;
            chkStar.Name = "chkStar";
            chkStar.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            chkStar.NullText = "Pending";
            chkStar.ValueChecked = "Finalized";
            chkStar.ValueGrayed = "Reviewed";
            chkStar.ValueUnchecked = "Pending";
            // 
            // colPrint
            // 
            colPrint.Caption = "พิมพ์";
            colPrint.ColumnEdit = chkPrint;
            colPrint.FieldName = "StatusName";
            colPrint.MinWidth = 17;
            colPrint.Name = "colPrint";
            colPrint.OptionsColumn.ShowCaption = false;
            colPrint.Width = 21;
            // 
            // chkPrint
            // 
            chkPrint.AutoHeight = false;
            chkPrint.AutoWidth = true;
            chkPrint.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            chkPrint.ImageOptions.ImageChecked = Resources.printer_16x16;
            chkPrint.ImageOptions.ImageGrayed = Resources.printer_16x16;
            chkPrint.Name = "chkPrint";
            chkPrint.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            chkPrint.NullText = "Pending";
            chkPrint.ValueChecked = "Completed";
            chkPrint.ValueGrayed = "InProgress";
            chkPrint.ValueUnchecked = "Pending";
            // 
            // colVisitDate
            // 
            colVisitDate.Caption = "วันที่รับบริการ";
            colVisitDate.DisplayFormat.FormatString = "yyyy-MM-dd";
            colVisitDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            colVisitDate.FieldName = "VisitDate";
            colVisitDate.MinWidth = 17;
            colVisitDate.Name = "colVisitDate";
            colVisitDate.Visible = true;
            colVisitDate.VisibleIndex = 2;
            colVisitDate.Width = 89;
            // 
            // colHN
            // 
            colHN.Caption = "HN";
            colHN.FieldName = "HospitalNumber";
            colHN.MinWidth = 17;
            colHN.Name = "colHN";
            colHN.Visible = true;
            colHN.VisibleIndex = 3;
            colHN.Width = 80;
            // 
            // colName
            // 
            colName.AppearanceCell.Options.UseTextOptions = true;
            colName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            colName.Caption = "ชื่อผู้รับบริการ";
            colName.FieldName = "Patient.FullName";
            colName.MinWidth = 17;
            colName.Name = "colName";
            colName.Visible = true;
            colName.VisibleIndex = 4;
            colName.Width = 139;
            // 
            // colAge
            // 
            colAge.Caption = "อายุ";
            colAge.FieldName = "AgeCheckup";
            colAge.MinWidth = 17;
            colAge.Name = "colAge";
            colAge.Visible = true;
            colAge.VisibleIndex = 5;
            colAge.Width = 29;
            // 
            // colSex
            // 
            colSex.Caption = "เพศ";
            colSex.FieldName = "Patient.Gender";
            colSex.MinWidth = 17;
            colSex.Name = "colSex";
            colSex.Visible = true;
            colSex.VisibleIndex = 6;
            colSex.Width = 41;
            // 
            // colNationId
            // 
            colNationId.Caption = "เลขที่บัตรประชาชน";
            colNationId.FieldName = "Patient.NationId";
            colNationId.MinWidth = 17;
            colNationId.Name = "colNationId";
            colNationId.Visible = true;
            colNationId.VisibleIndex = 7;
            colNationId.Width = 89;
            // 
            // colPackage
            // 
            colPackage.AppearanceCell.Options.UseTextOptions = true;
            colPackage.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            colPackage.Caption = "โปรแกรมตรวจ";
            colPackage.FieldName = "PackageName";
            colPackage.MinWidth = 17;
            colPackage.Name = "colPackage";
            colPackage.Visible = true;
            colPackage.VisibleIndex = 8;
            colPackage.Width = 89;
            // 
            // colPayor
            // 
            colPayor.AppearanceCell.Options.UseTextOptions = true;
            colPayor.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            colPayor.Caption = "สิทธิ์การรักษา";
            colPayor.FieldName = "PayorName";
            colPayor.MinWidth = 17;
            colPayor.Name = "colPayor";
            colPayor.Visible = true;
            colPayor.VisibleIndex = 9;
            colPayor.Width = 135;
            // 
            // colType
            // 
            colType.Caption = "ประเภทบริการ";
            colType.FieldName = "CheckupType.Name";
            colType.MinWidth = 17;
            colType.Name = "colType";
            colType.Visible = true;
            colType.VisibleIndex = 10;
            colType.Width = 89;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "หน่วยงาน";
            gridColumn3.FieldName = "Company.Name";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 11;
            gridColumn3.Width = 77;
            // 
            // colDoctorPE
            // 
            colDoctorPE.AppearanceCell.Options.UseTextOptions = true;
            colDoctorPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            colDoctorPE.Caption = "แพทย์ตรวจร่างกาย";
            colDoctorPE.FieldName = "PhysicalExaminationBy.FullNameThai";
            colDoctorPE.MinWidth = 17;
            colDoctorPE.Name = "colDoctorPE";
            colDoctorPE.Visible = true;
            colDoctorPE.VisibleIndex = 12;
            colDoctorPE.Width = 135;
            // 
            // colDoctorResult
            // 
            colDoctorResult.AppearanceCell.Options.UseTextOptions = true;
            colDoctorResult.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            colDoctorResult.Caption = "แพทย์สรุปผล";
            colDoctorResult.FieldName = "ConclusionBy.FullNameThai";
            colDoctorResult.MinWidth = 17;
            colDoctorResult.Name = "colDoctorResult";
            colDoctorResult.Visible = true;
            colDoctorResult.VisibleIndex = 13;
            colDoctorResult.Width = 135;
            // 
            // colCurrentStatus
            // 
            colCurrentStatus.Caption = "สถานะ";
            colCurrentStatus.FieldName = "StatusName";
            colCurrentStatus.MinWidth = 17;
            colCurrentStatus.Name = "colCurrentStatus";
            colCurrentStatus.Visible = true;
            colCurrentStatus.VisibleIndex = 14;
            colCurrentStatus.Width = 77;
            // 
            // colVN
            // 
            colVN.Caption = "VN";
            colVN.FieldName = "VisitNumber";
            colVN.MinWidth = 17;
            colVN.Name = "colVN";
            colVN.Width = 33;
            // 
            // colLab
            // 
            colLab.Caption = "Lab";
            colLab.ColumnEdit = chkStatus;
            colLab.FieldName = "LabStatusName";
            colLab.MinWidth = 17;
            colLab.Name = "colLab";
            colLab.Visible = true;
            colLab.VisibleIndex = 15;
            colLab.Width = 20;
            // 
            // chkStatus
            // 
            chkStatus.AutoHeight = false;
            chkStatus.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            chkStatus.ImageOptions.ImageChecked = Resources.ok16;
            chkStatus.ImageOptions.ImageGrayed = Resources.hourglass16;
            chkStatus.ImageOptions.ImageUnchecked = Resources.hourglass16;
            chkStatus.Name = "chkStatus";
            chkStatus.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            chkStatus.NullText = "Awaiting Results";
            chkStatus.ValueChecked = "Completed";
            chkStatus.ValueGrayed = "";
            chkStatus.ValueUnchecked = "Awaiting Results";
            // 
            // colXray
            // 
            colXray.Caption = "Xray";
            colXray.ColumnEdit = chkStatus;
            colXray.FieldName = "XrayStatusName";
            colXray.MinWidth = 17;
            colXray.Name = "colXray";
            colXray.Visible = true;
            colXray.VisibleIndex = 16;
            colXray.Width = 20;
            // 
            // colEye
            // 
            colEye.Caption = "Eye";
            colEye.ColumnEdit = chkVision;
            colEye.FieldName = "VisionStatusName";
            colEye.Name = "colEye";
            colEye.Visible = true;
            colEye.VisibleIndex = 17;
            colEye.Width = 20;
            // 
            // chkVision
            // 
            chkVision.AutoHeight = false;
            chkVision.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            chkVision.ImageOptions.ImageChecked = Resources.visible16px;
            chkVision.ImageOptions.ImageGrayed = Resources.visible16gray;
            chkVision.Name = "chkVision";
            chkVision.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            chkVision.NullText = "X";
            chkVision.ValueChecked = "Completed";
            chkVision.ValueGrayed = "Pending";
            chkVision.ValueUnchecked = "X";
            // 
            // colDent
            // 
            colDent.Caption = "Dent";
            colDent.ColumnEdit = chkDent;
            colDent.FieldName = "DentalStatusName";
            colDent.Name = "colDent";
            colDent.Visible = true;
            colDent.VisibleIndex = 18;
            colDent.Width = 20;
            // 
            // chkDent
            // 
            chkDent.AutoHeight = false;
            chkDent.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
            chkDent.ImageOptions.ImageChecked = Resources.tooth16;
            chkDent.ImageOptions.ImageGrayed = Resources.toothgray16;
            chkDent.Name = "chkDent";
            chkDent.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            chkDent.NullText = "X";
            chkDent.ValueChecked = "Completed";
            chkDent.ValueGrayed = "Pending";
            chkDent.ValueUnchecked = "X";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panelControl1);
            panel4.Controls.Add(cmdPageNext);
            panel4.Controls.Add(cmdPageBack);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 591);
            panel4.Name = "panel4";
            panel4.Size = new Size(1427, 37);
            panel4.TabIndex = 2;
            panel4.TabStop = true;
            // 
            // panelControl1
            // 
            panelControl1.Appearance.BackColor = Color.White;
            panelControl1.Appearance.Options.UseBackColor = true;
            panelControl1.Controls.Add(txtPageCurrent);
            panelControl1.Controls.Add(txtPageTotal);
            panelControl1.Controls.Add(label7);
            panelControl1.Location = new Point(34, 7);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(60, 24);
            panelControl1.TabIndex = 5;
            // 
            // txtPageCurrent
            // 
            txtPageCurrent.EditValue = "1";
            txtPageCurrent.Location = new Point(1, 1);
            txtPageCurrent.Margin = new Padding(0);
            txtPageCurrent.Name = "txtPageCurrent";
            txtPageCurrent.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtPageCurrent.Properties.Appearance.ForeColor = SystemColors.HotTrack;
            txtPageCurrent.Properties.Appearance.Options.UseFont = true;
            txtPageCurrent.Properties.Appearance.Options.UseForeColor = true;
            txtPageCurrent.Properties.Appearance.Options.UseTextOptions = true;
            txtPageCurrent.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            txtPageCurrent.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            txtPageCurrent.Size = new Size(21, 22);
            txtPageCurrent.TabIndex = 2;
            // 
            // txtPageTotal
            // 
            txtPageTotal.EditValue = "2";
            txtPageTotal.Location = new Point(37, 1);
            txtPageTotal.Margin = new Padding(0);
            txtPageTotal.Name = "txtPageTotal";
            txtPageTotal.Properties.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtPageTotal.Properties.Appearance.ForeColor = SystemColors.HotTrack;
            txtPageTotal.Properties.Appearance.Options.UseFont = true;
            txtPageTotal.Properties.Appearance.Options.UseForeColor = true;
            txtPageTotal.Properties.Appearance.Options.UseTextOptions = true;
            txtPageTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            txtPageTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            txtPageTotal.Size = new Size(21, 22);
            txtPageTotal.TabIndex = 4;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.ForeColor = SystemColors.GrayText;
            label7.Location = new Point(21, 1);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(16, 22);
            label7.TabIndex = 3;
            label7.Text = "/";
            // 
            // cmdPageNext
            // 
            cmdPageNext.Cursor = Cursors.Hand;
            cmdPageNext.ImageOptions.Image = Resources.next2;
            cmdPageNext.Location = new Point(92, 7);
            cmdPageNext.Margin = new Padding(0);
            cmdPageNext.Name = "cmdPageNext";
            cmdPageNext.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            cmdPageNext.Size = new Size(28, 26);
            cmdPageNext.TabIndex = 1;
            cmdPageNext.Click += cmdPageNext_Click;
            // 
            // cmdPageBack
            // 
            cmdPageBack.Appearance.BackColor = Color.White;
            cmdPageBack.Appearance.BorderColor = Color.Transparent;
            cmdPageBack.Appearance.Options.UseBackColor = true;
            cmdPageBack.Appearance.Options.UseBorderColor = true;
            cmdPageBack.Cursor = Cursors.Hand;
            cmdPageBack.ImageOptions.Image = Resources.prev2;
            cmdPageBack.Location = new Point(4, 7);
            cmdPageBack.Margin = new Padding(0);
            cmdPageBack.Name = "cmdPageBack";
            cmdPageBack.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            cmdPageBack.Size = new Size(31, 26);
            cmdPageBack.TabIndex = 0;
            cmdPageBack.Click += cmdPageBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 56, 148);
            panel1.Controls.Add(lblClose);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1427, 42);
            panel1.TabIndex = 6;
            // 
            // lblClose
            // 
            lblClose.BackColor = Color.Transparent;
            lblClose.Dock = DockStyle.Right;
            lblClose.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblClose.ForeColor = Color.White;
            lblClose.Location = new Point(1399, 0);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(28, 42);
            lblClose.TabIndex = 2;
            lblClose.Text = "X";
            lblClose.TextAlign = ContentAlignment.MiddleCenter;
            lblClose.Click += lblClose_Click;
            lblClose.MouseHover += lblClose_MouseHover;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Prompt", 14F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(4, 6);
            label5.Name = "label5";
            label5.Size = new Size(373, 29);
            label5.TabIndex = 1;
            label5.Text = "Patient Visit List  : รายการผลตรวจสุขภาพ";
            // 
            // panel2
            // 
            panel2.Controls.Add(SplitContentControlMain);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(1427, 734);
            panel2.TabIndex = 7;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Doctor";
            gridColumn2.FieldName = "Name";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "C0mpany";
            gridColumn1.FieldName = "Name";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 1;
            // 
            // progressPanel1
            // 
            progressPanel1.Appearance.BackColor = Color.Transparent;
            progressPanel1.Appearance.Font = new Font("Prompt", 8.25F);
            progressPanel1.Appearance.Options.UseBackColor = true;
            progressPanel1.Appearance.Options.UseFont = true;
            progressPanel1.AppearanceCaption.Font = new Font("Segoe UI", 16F);
            progressPanel1.AppearanceCaption.Options.UseFont = true;
            progressPanel1.AppearanceCaption.Options.UseTextOptions = true;
            progressPanel1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            progressPanel1.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            progressPanel1.AppearanceDescription.Font = new Font("Segoe UI", 10F);
            progressPanel1.AppearanceDescription.Options.UseFont = true;
            progressPanel1.AppearanceDescription.Options.UseTextOptions = true;
            progressPanel1.AppearanceDescription.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            progressPanel1.AppearanceDescription.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            progressPanel1.Caption = "Loading...";
            progressPanel1.CaptionToDescriptionDistance = 4;
            progressPanel1.ContentAlignment = ContentAlignment.MiddleCenter;
            progressPanel1.Location = new Point(0, 0);
            progressPanel1.LookAndFeel.SkinName = "Office 2019 Colorful";
            progressPanel1.LookAndFeel.UseDefaultLookAndFeel = false;
            progressPanel1.Name = "progressPanel1";
            progressPanel1.ShowDescription = false;
            progressPanel1.Size = new Size(179, 60);
            progressPanel1.TabIndex = 8;
            // 
            // CheckUpListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 776);
            Controls.Add(progressPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CheckUpListForm";
            Text = "Check Up : Patient List";
            WindowState = FormWindowState.Maximized;
            Load += CheckupListForm_Load;
            ((System.ComponentModel.ISupportInitialize)SplitContentControlMain.Panel1).EndInit();
            SplitContentControlMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContentControlMain.Panel2).EndInit();
            SplitContentControlMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContentControlMain).EndInit();
            SplitContentControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtpEndDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtpEndDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtpStartDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtpStartDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboCompany.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboCareprovider.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboCheckupType.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cboStatus.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtSearch.Properties).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdData).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewData).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkStar).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkPrint).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkVision).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkDent).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtPageCurrent.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPageTotal.Properties).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        internal DevExpress.XtraEditors.SplitContainerControl SplitContentControlMain;
	internal System.Windows.Forms.Label Label1;
	internal System.Windows.Forms.Label Label3;
	internal System.Windows.Forms.Label Label2;
    internal DevExpress.XtraEditors.DateEdit DtpStartDate;
	internal DevExpress.XtraEditors.TextEdit TxtSearch;
    private DevExpress.XtraGrid.GridControl grdData;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
    internal DevExpress.XtraGrid.Columns.GridColumn colHN;
    internal DevExpress.XtraGrid.Columns.GridColumn colName;
    internal DevExpress.XtraGrid.Columns.GridColumn colAge;
    internal DevExpress.XtraGrid.Columns.GridColumn colSex;
    internal DevExpress.XtraGrid.Columns.GridColumn colPayor;
    internal DevExpress.XtraGrid.Columns.GridColumn colVisitDate;
    internal DevExpress.XtraGrid.Columns.GridColumn colVN;
    private DevExpress.XtraGrid.Columns.GridColumn colCurrentStatus;
    internal System.Windows.Forms.Label label4;
    private DevExpress.XtraGrid.Columns.GridColumn colStatus;
    private DevExpress.XtraEditors.SimpleButton BtnClear;
    private DevExpress.XtraEditors.SimpleButton BtnSearch;
    internal System.Windows.Forms.Label label62;
    internal System.Windows.Forms.Label label61;
    private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkStar;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colDoctorPE;
    private DevExpress.XtraGrid.Columns.GridColumn colDoctorResult;
    private DevExpress.XtraGrid.Columns.GridColumn colPrint;
    private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn colLab;
        private DevExpress.XtraGrid.Columns.GridColumn colXray;
        internal DevExpress.XtraEditors.DateEdit dtpEndDate;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblClose;
        private DevExpress.XtraGrid.Columns.GridColumn colPackage;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private Panel panel3;
        private Panel panel4;
        private DevExpress.XtraEditors.SimpleButton cmdPageNext;
        private DevExpress.XtraEditors.SimpleButton cmdPageBack;
        private DevExpress.XtraEditors.TextEdit txtPageCurrent;
        private DevExpress.XtraEditors.TextEdit txtPageTotal;
        private Label label7;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.LookUpEdit cboStatus;
        private DevExpress.XtraEditors.LookUpEdit cboCheckupType;
        private DevExpress.XtraEditors.LookUpEdit cboCareprovider;
        private DevExpress.XtraEditors.LookUpEdit cboCompany;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private DevExpress.XtraGrid.Columns.GridColumn colNationId;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnNextDate;
        private DevExpress.XtraEditors.SimpleButton btnPrvDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRow;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colEye;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkVision;
        private DevExpress.XtraGrid.Columns.GridColumn colDent;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkDent;
    }
}
