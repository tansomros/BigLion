
using DevExpress.XtraGrid.Columns;
using SUTH.HealthCheckup.WinFormsUI.Properties;

namespace SUTH.HealthCheckup.WinFormsUI;

partial class PatientList
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientList));
        panel1 = new Panel();
        lblClose = new Label();
        label5 = new Label();
        panel2 = new Panel();
        splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
        navBarControlSearh = new DevExpress.XtraNavBar.NavBarControl();
        navBarGroupSearch = new DevExpress.XtraNavBar.NavBarGroup();
        navBarContainerSearch = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
        xTabSearch = new DevExpress.XtraTab.XtraTabControl();
        xTabSearch_Patient = new DevExpress.XtraTab.XtraTabPage();
        dtpEndDate = new DevExpress.XtraEditors.DateEdit();
        label6 = new Label();
        btnClear = new DevExpress.XtraEditors.SimpleButton();
        cmdSearch = new DevExpress.XtraEditors.SimpleButton();
        cboCareproviderResult = new DevExpress.XtraEditors.CheckedComboBoxEdit();
        cboCareproviderPE = new DevExpress.XtraEditors.CheckedComboBoxEdit();
        label62 = new Label();
        label61 = new Label();
        dtpStartDate = new DevExpress.XtraEditors.DateEdit();
        txtSearchHN = new DevExpress.XtraEditors.TextEdit();
        Label3 = new Label();
        cboPayor = new DevExpress.XtraEditors.CheckedComboBoxEdit();
        Label2 = new Label();
        label4 = new Label();
        chkStatus = new DevExpress.XtraEditors.CheckedComboBoxEdit();
        Label1 = new Label();
        groupControl2 = new DevExpress.XtraEditors.GroupControl();
        grdData = new DevExpress.XtraGrid.GridControl();
        gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
        colStar = new GridColumn();
        chkStar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
        colPrint = new GridColumn();
        chkPrint = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
        colDate = new GridColumn();
        colHN = new GridColumn();
        colName = new GridColumn();
        colAge = new GridColumn();
        colSex = new GridColumn();
        colPackage = new GridColumn();
        colPayor = new GridColumn();
        colType = new GridColumn();
        colDoctor = new GridColumn();
        colStatus = new GridColumn();
        colLab = new GridColumn();
        colXray = new GridColumn();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
        splitContainerControl1.Panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
        splitContainerControl1.Panel2.SuspendLayout();
        splitContainerControl1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)navBarControlSearh).BeginInit();
        navBarControlSearh.SuspendLayout();
        navBarContainerSearch.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)xTabSearch).BeginInit();
        xTabSearch.SuspendLayout();
        xTabSearch_Patient.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dtpEndDate.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dtpEndDate.Properties.CalendarTimeProperties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)cboCareproviderResult.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)cboCareproviderPE.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dtpStartDate.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dtpStartDate.Properties.CalendarTimeProperties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)txtSearchHN.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)cboPayor.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)chkStatus.Properties).BeginInit();
        ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
        groupControl2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)grdData).BeginInit();
        ((System.ComponentModel.ISupportInitialize)gridViewData).BeginInit();
        ((System.ComponentModel.ISupportInitialize)chkStar).BeginInit();
        ((System.ComponentModel.ISupportInitialize)chkPrint).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(3, 56, 148);
        panel1.Controls.Add(lblClose);
        panel1.Controls.Add(label5);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(1174, 40);
        panel1.TabIndex = 7;
        // 
        // lblClose
        // 
        lblClose.BackColor = Color.Transparent;
        lblClose.Dock = DockStyle.Right;
        lblClose.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblClose.ForeColor = Color.White;
        lblClose.Location = new Point(1142, 0);
        lblClose.Name = "lblClose";
        lblClose.Size = new Size(32, 40);
        lblClose.TabIndex = 2;
        lblClose.Text = "X";
        lblClose.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.BackColor = Color.Transparent;
        label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        label5.ForeColor = Color.White;
        label5.Location = new Point(5, 5);
        label5.Name = "label5";
        label5.Size = new Size(153, 25);
        label5.TabIndex = 1;
        label5.Text = "Patient Visit List";
        // 
        // panel2
        // 
        panel2.Controls.Add(splitContainerControl1);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(0, 40);
        panel2.Name = "panel2";
        panel2.Size = new Size(1174, 669);
        panel2.TabIndex = 8;
        // 
        // splitContainerControl1
        // 
        splitContainerControl1.Dock = DockStyle.Fill;
        splitContainerControl1.Location = new Point(0, 0);
        splitContainerControl1.Name = "splitContainerControl1";
        // 
        // splitContainerControl1.Panel1
        // 
        splitContainerControl1.Panel1.Controls.Add(navBarControlSearh);
        splitContainerControl1.Panel1.Text = "Panel1";
        // 
        // splitContainerControl1.Panel2
        // 
        splitContainerControl1.Panel2.Controls.Add(groupControl2);
        splitContainerControl1.Panel2.Text = "Panel2";
        splitContainerControl1.Size = new Size(1174, 669);
        splitContainerControl1.SplitterPosition = 307;
        splitContainerControl1.TabIndex = 0;
        // 
        // navBarControlSearh
        // 
        navBarControlSearh.ActiveGroup = navBarGroupSearch;
        navBarControlSearh.Appearance.NavigationPaneHeader.Font = new Font("Segoe UI", 10F);
        navBarControlSearh.Appearance.NavigationPaneHeader.Options.UseFont = true;
        navBarControlSearh.Controls.Add(navBarContainerSearch);
        navBarControlSearh.Dock = DockStyle.Fill;
        navBarControlSearh.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] { navBarGroupSearch });
        navBarControlSearh.Location = new Point(0, 0);
        navBarControlSearh.LookAndFeel.SkinName = "McSkin";
        navBarControlSearh.LookAndFeel.UseDefaultLookAndFeel = false;
        navBarControlSearh.Name = "navBarControlSearh";
        navBarControlSearh.OptionsNavPane.ExpandedWidth = 307;
        navBarControlSearh.OptionsNavPane.ShowOverflowButton = false;
        navBarControlSearh.OptionsNavPane.ShowOverflowPanel = false;
        navBarControlSearh.OptionsNavPane.ShowSplitter = false;
        navBarControlSearh.Size = new Size(307, 669);
        navBarControlSearh.TabIndex = 11;
        navBarControlSearh.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinNavigationPaneViewInfoRegistrator("VS2010");
        // 
        // navBarGroupSearch
        // 
        navBarGroupSearch.Caption = "Search";
        navBarGroupSearch.ControlContainer = navBarContainerSearch;
        navBarGroupSearch.Expanded = true;
        navBarGroupSearch.GroupClientHeight = 664;
        navBarGroupSearch.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
        navBarGroupSearch.Name = "navBarGroupSearch";
        navBarGroupSearch.NavigationPaneVisible = false;
        // 
        // navBarContainerSearch
        // 
        navBarContainerSearch.Controls.Add(xTabSearch);
        navBarContainerSearch.Name = "navBarContainerSearch";
        navBarContainerSearch.Size = new Size(307, 646);
        navBarContainerSearch.TabIndex = 0;
        // 
        // xTabSearch
        // 
        xTabSearch.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
        xTabSearch.Dock = DockStyle.Fill;
        xTabSearch.Location = new Point(0, 0);
        xTabSearch.LookAndFeel.SkinName = "VS2010";
        xTabSearch.LookAndFeel.UseDefaultLookAndFeel = false;
        xTabSearch.MultiLine = DevExpress.Utils.DefaultBoolean.True;
        xTabSearch.Name = "xTabSearch";
        xTabSearch.SelectedTabPage = xTabSearch_Patient;
        xTabSearch.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
        xTabSearch.Size = new Size(307, 646);
        xTabSearch.TabIndex = 12;
        xTabSearch.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xTabSearch_Patient });
        // 
        // xTabSearch_Patient
        // 
        xTabSearch_Patient.Controls.Add(dtpEndDate);
        xTabSearch_Patient.Controls.Add(label6);
        xTabSearch_Patient.Controls.Add(btnClear);
        xTabSearch_Patient.Controls.Add(cmdSearch);
        xTabSearch_Patient.Controls.Add(cboCareproviderResult);
        xTabSearch_Patient.Controls.Add(cboCareproviderPE);
        xTabSearch_Patient.Controls.Add(label62);
        xTabSearch_Patient.Controls.Add(label61);
        xTabSearch_Patient.Controls.Add(dtpStartDate);
        xTabSearch_Patient.Controls.Add(txtSearchHN);
        xTabSearch_Patient.Controls.Add(Label3);
        xTabSearch_Patient.Controls.Add(cboPayor);
        xTabSearch_Patient.Controls.Add(Label2);
        xTabSearch_Patient.Controls.Add(label4);
        xTabSearch_Patient.Controls.Add(chkStatus);
        xTabSearch_Patient.Controls.Add(Label1);
        xTabSearch_Patient.Name = "xTabSearch_Patient";
        xTabSearch_Patient.Size = new Size(301, 632);
        xTabSearch_Patient.Text = "Patient";
        // 
        // dtpEndDate
        // 
        dtpEndDate.EditValue = null;
        dtpEndDate.Location = new Point(71, 40);
        dtpEndDate.Name = "dtpEndDate";
        dtpEndDate.Properties.Appearance.Font = new Font("Segoe UI", 10.5F);
        dtpEndDate.Properties.Appearance.Options.UseFont = true;
        dtpEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        dtpEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        dtpEndDate.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
        dtpEndDate.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
        dtpEndDate.Size = new Size(217, 26);
        dtpEndDate.TabIndex = 2;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 9.5F);
        label6.Location = new Point(4, 43);
        label6.Margin = new Padding(4, 0, 4, 0);
        label6.Name = "label6";
        label6.Size = new Size(61, 17);
        label6.TabIndex = 18;
        label6.Text = "End Date";
        // 
        // btnClear
        // 
        btnClear.Appearance.Font = new Font("Segoe UI", 10.5F);
        btnClear.Appearance.ForeColor = Color.White;
        btnClear.Appearance.Options.UseFont = true;
        btnClear.Appearance.Options.UseForeColor = true;
        btnClear.ImageOptions.Image = (Image)resources.GetObject("btnClear.ImageOptions.Image");
        btnClear.Location = new Point(188, 230);
        btnClear.LookAndFeel.SkinMaskColor = SystemColors.ActiveCaption;
        btnClear.LookAndFeel.SkinName = "DevExpress Dark Style";
        btnClear.LookAndFeel.UseDefaultLookAndFeel = false;
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(100, 32);
        btnClear.TabIndex = 9;
        btnClear.Text = "Clear";
        // 
        // cmdSearch
        // 
        cmdSearch.Appearance.Font = new Font("Segoe UI", 10.5F);
        cmdSearch.Appearance.ForeColor = Color.White;
        cmdSearch.Appearance.Options.UseFont = true;
        cmdSearch.Appearance.Options.UseForeColor = true;
        cmdSearch.ImageOptions.Image = Resources.Search_24px;
        cmdSearch.Location = new Point(71, 230);
        cmdSearch.LookAndFeel.SkinMaskColor = Color.FromArgb(3, 56, 148);
        cmdSearch.LookAndFeel.SkinName = "DevExpress Dark Style";
        cmdSearch.LookAndFeel.UseDefaultLookAndFeel = false;
        cmdSearch.Name = "cmdSearch";
        cmdSearch.Size = new Size(100, 32);
        cmdSearch.TabIndex = 8;
        cmdSearch.Text = "Search";
        // 
        // cboCareproviderResult
        // 
        cboCareproviderResult.EditValue = "";
        cboCareproviderResult.Location = new Point(71, 166);
        cboCareproviderResult.Margin = new Padding(4);
        cboCareproviderResult.Name = "cboCareproviderResult";
        cboCareproviderResult.Properties.Appearance.Font = new Font("Segoe UI", 10.5F);
        cboCareproviderResult.Properties.Appearance.Options.UseFont = true;
        cboCareproviderResult.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        cboCareproviderResult.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
        cboCareproviderResult.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
        cboCareproviderResult.Properties.SelectAllItemCaption = "---เลือกทั้งหมด---";
        cboCareproviderResult.Size = new Size(217, 26);
        cboCareproviderResult.TabIndex = 6;
        // 
        // cboCareproviderPE
        // 
        cboCareproviderPE.EditValue = "";
        cboCareproviderPE.Location = new Point(71, 134);
        cboCareproviderPE.Margin = new Padding(4);
        cboCareproviderPE.Name = "cboCareproviderPE";
        cboCareproviderPE.Properties.Appearance.Font = new Font("Segoe UI", 10.5F);
        cboCareproviderPE.Properties.Appearance.Options.UseFont = true;
        cboCareproviderPE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        cboCareproviderPE.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
        cboCareproviderPE.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
        cboCareproviderPE.Properties.SelectAllItemCaption = "---เลือกทั้งหมด---";
        cboCareproviderPE.Size = new Size(217, 26);
        cboCareproviderPE.TabIndex = 5;
        // 
        // label62
        // 
        label62.AutoSize = true;
        label62.Font = new Font("Segoe UI", 9.5F);
        label62.Location = new Point(4, 169);
        label62.Margin = new Padding(4, 0, 4, 0);
        label62.Name = "label62";
        label62.Size = new Size(60, 17);
        label62.TabIndex = 13;
        label62.Text = "Result By";
        // 
        // label61
        // 
        label61.AutoSize = true;
        label61.Font = new Font("Segoe UI", 9.5F);
        label61.Location = new Point(4, 137);
        label61.Margin = new Padding(4, 0, 4, 0);
        label61.Name = "label61";
        label61.Size = new Size(39, 17);
        label61.TabIndex = 12;
        label61.Text = "PE By";
        // 
        // dtpStartDate
        // 
        dtpStartDate.EditValue = null;
        dtpStartDate.Location = new Point(71, 8);
        dtpStartDate.Name = "dtpStartDate";
        dtpStartDate.Properties.Appearance.Font = new Font("Segoe UI", 10.5F);
        dtpStartDate.Properties.Appearance.Options.UseFont = true;
        dtpStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        dtpStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        dtpStartDate.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
        dtpStartDate.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
        dtpStartDate.Size = new Size(217, 26);
        dtpStartDate.TabIndex = 1;
        // 
        // txtSearchHN
        // 
        txtSearchHN.Location = new Point(71, 198);
        txtSearchHN.Name = "txtSearchHN";
        txtSearchHN.Properties.Appearance.Font = new Font("Segoe UI", 10.5F);
        txtSearchHN.Properties.Appearance.Options.UseFont = true;
        txtSearchHN.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
        txtSearchHN.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
        txtSearchHN.Properties.NullValuePrompt = "HN, Name , LastName";
        txtSearchHN.Size = new Size(217, 26);
        txtSearchHN.TabIndex = 7;
        // 
        // Label3
        // 
        Label3.AutoSize = true;
        Label3.Font = new Font("Segoe UI", 9.5F);
        Label3.Location = new Point(4, 201);
        Label3.Margin = new Padding(4, 0, 4, 0);
        Label3.Name = "Label3";
        Label3.Size = new Size(47, 17);
        Label3.TabIndex = 5;
        Label3.Text = "Search";
        // 
        // cboPayor
        // 
        cboPayor.EditValue = "";
        cboPayor.Location = new Point(71, 103);
        cboPayor.Margin = new Padding(4);
        cboPayor.Name = "cboPayor";
        cboPayor.Properties.Appearance.Font = new Font("Segoe UI", 10.5F);
        cboPayor.Properties.Appearance.Options.UseFont = true;
        cboPayor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        cboPayor.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
        cboPayor.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
        cboPayor.Properties.SelectAllItemCaption = "---เลือกทั้งหมด---";
        cboPayor.Size = new Size(217, 26);
        cboPayor.TabIndex = 4;
        // 
        // Label2
        // 
        Label2.AutoSize = true;
        Label2.Font = new Font("Segoe UI", 9.5F);
        Label2.Location = new Point(4, 76);
        Label2.Margin = new Padding(4, 0, 4, 0);
        Label2.Name = "Label2";
        Label2.Size = new Size(43, 17);
        Label2.TabIndex = 4;
        Label2.Text = "Status";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 9.5F);
        label4.Location = new Point(4, 106);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(41, 17);
        label4.TabIndex = 10;
        label4.Text = "Payor";
        // 
        // chkStatus
        // 
        chkStatus.EditValue = "";
        chkStatus.Location = new Point(71, 73);
        chkStatus.Margin = new Padding(4);
        chkStatus.Name = "chkStatus";
        chkStatus.Properties.Appearance.Font = new Font("Segoe UI", 10.5F);
        chkStatus.Properties.Appearance.Options.UseFont = true;
        chkStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
        chkStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] { new DevExpress.XtraEditors.Controls.CheckedListBoxItem("S", "Temporary Save"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem("F", "Finalized"), new DevExpress.XtraEditors.Controls.CheckedListBoxItem("N", "None Save") });
        chkStatus.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
        chkStatus.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
        chkStatus.Size = new Size(217, 26);
        chkStatus.TabIndex = 3;
        // 
        // Label1
        // 
        Label1.AutoSize = true;
        Label1.Font = new Font("Segoe UI", 9.5F);
        Label1.Location = new Point(4, 11);
        Label1.Margin = new Padding(4, 0, 4, 0);
        Label1.Name = "Label1";
        Label1.Size = new Size(66, 17);
        Label1.TabIndex = 1;
        Label1.Text = "Start Date";
        // 
        // groupControl2
        // 
        groupControl2.AllowTouchScroll = true;
        groupControl2.AppearanceCaption.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
        groupControl2.AppearanceCaption.ForeColor = Color.FromArgb(3, 56, 148);
        groupControl2.AppearanceCaption.Image = (Image)resources.GetObject("groupControl2.AppearanceCaption.Image");
        groupControl2.AppearanceCaption.Options.UseFont = true;
        groupControl2.AppearanceCaption.Options.UseForeColor = true;
        groupControl2.AppearanceCaption.Options.UseImage = true;
        groupControl2.Controls.Add(grdData);
        groupControl2.Dock = DockStyle.Fill;
        groupControl2.Location = new Point(0, 0);
        groupControl2.LookAndFeel.SkinName = "Office 2010 Blue";
        groupControl2.LookAndFeel.UseDefaultLookAndFeel = false;
        groupControl2.Name = "groupControl2";
        groupControl2.Size = new Size(861, 669);
        groupControl2.TabIndex = 1;
        groupControl2.Text = "Patient List : รายการผลตรวจสุขภาพ";
        // 
        // grdData
        // 
        grdData.Dock = DockStyle.Fill;
        grdData.Location = new Point(2, 24);
        grdData.MainView = gridViewData;
        grdData.Name = "grdData";
        grdData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { chkStar, chkPrint });
        grdData.Size = new Size(857, 643);
        grdData.TabIndex = 0;
        grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewData });
        // 
        // gridViewData
        // 
        gridViewData.Appearance.HeaderPanel.Font = new Font("Tahoma", 9F, FontStyle.Bold);
        gridViewData.Appearance.HeaderPanel.Options.UseFont = true;
        gridViewData.Appearance.HeaderPanel.Options.UseTextOptions = true;
        gridViewData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
        gridViewData.Appearance.Row.Font = new Font("Tahoma", 10F);
        gridViewData.Appearance.Row.Options.UseFont = true;
        gridViewData.Columns.AddRange(new GridColumn[] { colStar, colPrint, colDate, colHN, colName, colAge, colSex, colPackage, colPayor, colType, colDoctor, colStatus, colLab, colXray });
        gridViewData.GridControl = grdData;
        gridViewData.Name = "gridViewData";
        gridViewData.OptionsFind.AlwaysVisible = true;
        // 
        // colStar
        // 
        colStar.ColumnEdit = chkStar;
        colStar.FieldName = "CurrentStatus";
        colStar.Name = "colStar";
        colStar.OptionsColumn.ShowCaption = false;
        colStar.Visible = true;
        colStar.VisibleIndex = 0;
        colStar.Width = 30;
        // 
        // chkStar
        // 
        chkStar.AutoHeight = false;
        chkStar.AutoWidth = true;
        chkStar.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
        chkStar.ImageOptions.ImageChecked = Resources.star_orange;
        chkStar.ImageOptions.ImageGrayed = Resources.star_blue;
        chkStar.Name = "chkStar";
        chkStar.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
        chkStar.ValueChecked = "Finalize";
        chkStar.ValueGrayed = "Submited";
        chkStar.ValueUnchecked = "";
        // 
        // colPrint
        // 
        colPrint.ColumnEdit = chkPrint;
        colPrint.FieldName = "isReview";
        colPrint.Name = "colPrint";
        colPrint.OptionsColumn.ShowCaption = false;
        colPrint.Visible = true;
        colPrint.VisibleIndex = 1;
        colPrint.Width = 30;
        // 
        // chkPrint
        // 
        chkPrint.AutoHeight = false;
        chkPrint.AutoWidth = true;
        chkPrint.Caption = "";
        chkPrint.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Custom;
        chkPrint.ImageOptions.ImageChecked = (Image)resources.GetObject("chkPrint.ImageOptions.ImageChecked");
        chkPrint.Name = "chkPrint";
        chkPrint.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
        chkPrint.ValueChecked = "Y";
        chkPrint.ValueUnchecked = "N";
        // 
        // colDate
        // 
        colDate.Caption = "Visit Date";
        colDate.Name = "colDate";
        colDate.Visible = true;
        colDate.VisibleIndex = 2;
        colDate.Width = 66;
        // 
        // colHN
        // 
        colHN.Caption = "HN";
        colHN.FieldName = "HN";
        colHN.Name = "colHN";
        colHN.Visible = true;
        colHN.VisibleIndex = 3;
        colHN.Width = 66;
        // 
        // colName
        // 
        colName.Caption = "Name";
        colName.FieldName = "PatientName";
        colName.Name = "colName";
        colName.Visible = true;
        colName.VisibleIndex = 4;
        colName.Width = 66;
        // 
        // colAge
        // 
        colAge.Caption = "Age";
        colAge.FieldName = "Ages";
        colAge.Name = "colAge";
        colAge.Visible = true;
        colAge.VisibleIndex = 5;
        colAge.Width = 66;
        // 
        // colSex
        // 
        colSex.Caption = "Sex";
        colSex.FieldName = "Sex";
        colSex.Name = "colSex";
        colSex.Visible = true;
        colSex.VisibleIndex = 6;
        colSex.Width = 66;
        // 
        // colPackage
        // 
        colPackage.Caption = "Package";
        colPackage.FieldName = "PackageName";
        colPackage.Name = "colPackage";
        colPackage.Visible = true;
        colPackage.VisibleIndex = 7;
        colPackage.Width = 66;
        // 
        // colPayor
        // 
        colPayor.Caption = "Payor";
        colPayor.FieldName = "PayorName";
        colPayor.Name = "colPayor";
        colPayor.Visible = true;
        colPayor.VisibleIndex = 8;
        colPayor.Width = 66;
        // 
        // colType
        // 
        colType.Caption = "Service Type";
        colType.FieldName = "CheckupType";
        colType.Name = "colType";
        colType.Visible = true;
        colType.VisibleIndex = 9;
        colType.Width = 66;
        // 
        // colDoctor
        // 
        colDoctor.Caption = "Doctor";
        colDoctor.FieldName = "DoctorName";
        colDoctor.Name = "colDoctor";
        colDoctor.Visible = true;
        colDoctor.VisibleIndex = 10;
        colDoctor.Width = 66;
        // 
        // colStatus
        // 
        colStatus.Caption = "Status";
        colStatus.Name = "colStatus";
        colStatus.Visible = true;
        colStatus.VisibleIndex = 11;
        colStatus.Width = 66;
        // 
        // colLab
        // 
        colLab.Name = "colLab";
        colLab.Visible = true;
        colLab.VisibleIndex = 12;
        colLab.Width = 66;
        // 
        // colXray
        // 
        colXray.Name = "colXray";
        colXray.Visible = true;
        colXray.VisibleIndex = 13;
        colXray.Width = 83;
        // 
        // frmPatientList
        // 
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1174, 709);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Font = new Font("Segoe UI", 8.25F);
        Name = "frmPatientList";
        Text = "frmPatientList";
        Load += frmPatientList_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
        splitContainerControl1.Panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
        splitContainerControl1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
        splitContainerControl1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)navBarControlSearh).EndInit();
        navBarControlSearh.ResumeLayout(false);
        navBarContainerSearch.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)xTabSearch).EndInit();
        xTabSearch.ResumeLayout(false);
        xTabSearch_Patient.ResumeLayout(false);
        xTabSearch_Patient.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dtpEndDate.Properties.CalendarTimeProperties).EndInit();
        ((System.ComponentModel.ISupportInitialize)dtpEndDate.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)cboCareproviderResult.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)cboCareproviderPE.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)dtpStartDate.Properties.CalendarTimeProperties).EndInit();
        ((System.ComponentModel.ISupportInitialize)dtpStartDate.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)txtSearchHN.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)cboPayor.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)chkStatus.Properties).EndInit();
        ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
        groupControl2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)grdData).EndInit();
        ((System.ComponentModel.ISupportInitialize)gridViewData).EndInit();
        ((System.ComponentModel.ISupportInitialize)chkStar).EndInit();
        ((System.ComponentModel.ISupportInitialize)chkPrint).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label lblClose;
    private Label label5;
    private Panel panel2;
    private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    private DevExpress.XtraNavBar.NavBarControl navBarControlSearh;
    private DevExpress.XtraNavBar.NavBarGroup navBarGroupSearch;
    private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarContainerSearch;
    private DevExpress.XtraTab.XtraTabControl xTabSearch;
    private DevExpress.XtraTab.XtraTabPage xTabSearch_Patient;
    internal DevExpress.XtraEditors.DateEdit dtpEndDate;
    internal Label label6;
    private DevExpress.XtraEditors.SimpleButton btnClear;
    private DevExpress.XtraEditors.SimpleButton cmdSearch;
    internal DevExpress.XtraEditors.CheckedComboBoxEdit cboCareproviderResult;
    internal DevExpress.XtraEditors.CheckedComboBoxEdit cboCareproviderPE;
    internal Label label62;
    internal Label label61;
    internal DevExpress.XtraEditors.DateEdit dtpStartDate;
    internal DevExpress.XtraEditors.TextEdit txtSearchHN;
    internal Label Label3;
    internal DevExpress.XtraEditors.CheckedComboBoxEdit cboPayor;
    internal Label Label2;
    internal Label label4;
    internal DevExpress.XtraEditors.CheckedComboBoxEdit chkStatus;
    internal Label Label1;
    private DevExpress.XtraEditors.GroupControl groupControl2;
    private DevExpress.XtraGrid.GridControl grdData;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
    private GridColumn colStar;
    private GridColumn colPrint;
    private GridColumn colDate;
    private GridColumn colHN;
    private GridColumn colName;
    private GridColumn colAge;
    private GridColumn colSex;
    private GridColumn colPackage;
    private GridColumn colPayor;
    private GridColumn colType;
    private GridColumn colDoctor;
    private GridColumn colStatus;
    private GridColumn colLab;
    private GridColumn colXray;
    private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkStar;
    private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkPrint;
}
