using SUTH.HealthCheckup.WinFormsUI.Properties;

namespace SUTH.HealthCheckup.WinFormsUI
{
    partial class RecommendationForm : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecommendationForm));
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            grdData = new DevExpress.XtraGrid.GridControl();
            gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            colRcmRefID = new DevExpress.XtraGrid.Columns.GridColumn();
            colRcmItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colRcmCheckupName = new DevExpress.XtraGrid.Columns.GridColumn();
            colRcmTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            colRcmSex = new DevExpress.XtraGrid.Columns.GridColumn();
            colRcmCompareValue = new DevExpress.XtraGrid.Columns.GridColumn();
            colRcmLow = new DevExpress.XtraGrid.Columns.GridColumn();
            colRcmHigh = new DevExpress.XtraGrid.Columns.GridColumn();
            colRcmConclusionTH = new DevExpress.XtraGrid.Columns.GridColumn();
            colRcmRecomendTH = new DevExpress.XtraGrid.Columns.GridColumn();
            colRcmConclusionEN = new DevExpress.XtraGrid.Columns.GridColumn();
            colRcmRecomendEN = new DevExpress.XtraGrid.Columns.GridColumn();
            colRcmStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            pictureBox1 = new PictureBox();
            dtpStartDate = new DevExpress.XtraEditors.DateEdit();
            dtpEndDate = new DevExpress.XtraEditors.DateEdit();
            cmdFindCode = new DevExpress.XtraEditors.SimpleButton();
            ddlCondition = new DevExpress.XtraEditors.LookUpEdit();
            txtCompareValue = new DevExpress.XtraEditors.TextEdit();
            label16 = new Label();
            label15 = new Label();
            lblItemName = new Label();
            cmdClose = new DevExpress.XtraEditors.SimpleButton();
            cmdClear = new DevExpress.XtraEditors.SimpleButton();
            lblID = new Label();
            cmdSave = new DevExpress.XtraEditors.SimpleButton();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            lblHighValue = new Label();
            lblLowValue = new Label();
            label6 = new Label();
            chkStatus = new DevExpress.XtraEditors.CheckEdit();
            txtRcmEN = new DevExpress.XtraEditors.MemoEdit();
            txtConclusionEN = new DevExpress.XtraEditors.MemoEdit();
            txtRcmTH = new DevExpress.XtraEditors.MemoEdit();
            txtConclusionTH = new DevExpress.XtraEditors.MemoEdit();
            txtHighValue = new DevExpress.XtraEditors.TextEdit();
            txtLowValue = new DevExpress.XtraEditors.TextEdit();
            ddlSex = new DevExpress.XtraEditors.LookUpEdit();
            txtDescription = new DevExpress.XtraEditors.TextEdit();
            txtCode = new DevExpress.XtraEditors.TextEdit();
            label5 = new Label();
            label1 = new Label();
            lblPayor = new Label();
            label2 = new Label();
            lblDept = new Label();
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            panel2 = new Panel();
            progressLoad = new DevExpress.XtraWaitForm.ProgressPanel();
            label3 = new Label();
            panelControl4 = new DevExpress.XtraEditors.PanelControl();
            panel1 = new Panel();
            lblClose = new Label();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtpStartDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtpStartDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtpEndDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtpEndDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlCondition.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCompareValue.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkStatus.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtRcmEN.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtConclusionEN.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtRcmTH.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtConclusionTH.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHighValue.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtLowValue.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ddlSex.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl4).BeginInit();
            panelControl4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupControl2
            // 
            groupControl2.AppearanceCaption.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            groupControl2.AppearanceCaption.Options.UseFont = true;
            groupControl2.Controls.Add(grdData);
            groupControl2.Dock = DockStyle.Fill;
            groupControl2.Location = new Point(0, 0);
            groupControl2.LookAndFeel.SkinName = "Office 2010 Blue";
            groupControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            groupControl2.Margin = new Padding(4, 3, 4, 3);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new Size(1419, 245);
            groupControl2.TabIndex = 2;
            groupControl2.Text = "Recommend Configuration List";
            // 
            // grdData
            // 
            grdData.Dock = DockStyle.Fill;
            grdData.EmbeddedNavigator.Margin = new Padding(5);
            grdData.Font = new Font("Tahoma", 10F);
            grdData.Location = new Point(2, 22);
            grdData.LookAndFeel.SkinName = "Office 2010 Blue";
            grdData.LookAndFeel.UseDefaultLookAndFeel = false;
            grdData.MainView = gridViewData;
            grdData.Margin = new Padding(0);
            grdData.Name = "grdData";
            grdData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemCheckEdit1 });
            grdData.Size = new Size(1415, 221);
            grdData.TabIndex = 4;
            grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewData });
            // 
            // gridViewData
            // 
            gridViewData.Appearance.GroupRow.Font = new Font("Segoe UI", 9.5F);
            gridViewData.Appearance.GroupRow.Options.UseFont = true;
            gridViewData.Appearance.HeaderPanel.Font = new Font("Tahoma", 8.5F, FontStyle.Bold);
            gridViewData.Appearance.HeaderPanel.Options.UseFont = true;
            gridViewData.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridViewData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewData.Appearance.Row.Font = new Font("Segoe UI", 9.5F);
            gridViewData.Appearance.Row.Options.UseFont = true;
            gridViewData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colRcmRefID, colRcmItemCode, colRcmCheckupName, colRcmTypeName, colRcmSex, colRcmCompareValue, colRcmLow, colRcmHigh, colRcmConclusionTH, colRcmRecomendTH, colRcmConclusionEN, colRcmRecomendEN, colRcmStatus });
            gridViewData.DetailHeight = 404;
            gridViewData.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            gridViewData.GridControl = grdData;
            gridViewData.GroupFormat = "[#image]{1} {2}";
            gridViewData.Name = "gridViewData";
            gridViewData.OptionsBehavior.Editable = false;
            gridViewData.OptionsEditForm.PopupEditFormWidth = 933;
            gridViewData.OptionsFind.AlwaysVisible = true;
            gridViewData.OptionsFind.FindNullPrompt = "ค้นหา";
            gridViewData.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridViewData.OptionsSelection.EnableAppearanceFocusedRow = false;
            gridViewData.OptionsSelection.EnableAppearanceHideSelection = false;
            gridViewData.OptionsView.ShowIndicator = false;
            gridViewData.DoubleClick += gridViewData_DoubleClick;
            // 
            // colRcmRefID
            // 
            colRcmRefID.Caption = "RefID";
            colRcmRefID.FieldName = "Id";
            colRcmRefID.MinWidth = 23;
            colRcmRefID.Name = "colRcmRefID";
            colRcmRefID.Width = 44;
            // 
            // colRcmItemCode
            // 
            colRcmItemCode.AppearanceCell.Options.UseTextOptions = true;
            colRcmItemCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colRcmItemCode.Caption = "Code";
            colRcmItemCode.FieldName = "Code";
            colRcmItemCode.MinWidth = 23;
            colRcmItemCode.Name = "colRcmItemCode";
            colRcmItemCode.Visible = true;
            colRcmItemCode.VisibleIndex = 0;
            colRcmItemCode.Width = 69;
            // 
            // colRcmCheckupName
            // 
            colRcmCheckupName.AppearanceCell.Font = new Font("Tahoma", 9F);
            colRcmCheckupName.AppearanceCell.Options.UseFont = true;
            colRcmCheckupName.AppearanceCell.Options.UseTextOptions = true;
            colRcmCheckupName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            colRcmCheckupName.Caption = "Name";
            colRcmCheckupName.FieldName = "Name";
            colRcmCheckupName.MinWidth = 23;
            colRcmCheckupName.Name = "colRcmCheckupName";
            colRcmCheckupName.Visible = true;
            colRcmCheckupName.VisibleIndex = 1;
            colRcmCheckupName.Width = 138;
            // 
            // colRcmTypeName
            // 
            colRcmTypeName.Caption = "ConditionType";
            colRcmTypeName.FieldName = "CheckType";
            colRcmTypeName.MinWidth = 23;
            colRcmTypeName.Name = "colRcmTypeName";
            colRcmTypeName.Visible = true;
            colRcmTypeName.VisibleIndex = 2;
            colRcmTypeName.Width = 34;
            // 
            // colRcmSex
            // 
            colRcmSex.AppearanceCell.Options.UseTextOptions = true;
            colRcmSex.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colRcmSex.Caption = "เพศ";
            colRcmSex.FieldName = "SexCode";
            colRcmSex.MinWidth = 23;
            colRcmSex.Name = "colRcmSex";
            colRcmSex.Visible = true;
            colRcmSex.VisibleIndex = 3;
            colRcmSex.Width = 51;
            // 
            // colRcmCompareValue
            // 
            colRcmCompareValue.AppearanceCell.Font = new Font("Tahoma", 9F);
            colRcmCompareValue.AppearanceCell.Options.UseFont = true;
            colRcmCompareValue.Caption = "CompareValue";
            colRcmCompareValue.FieldName = "CompareValue";
            colRcmCompareValue.MinWidth = 23;
            colRcmCompareValue.Name = "colRcmCompareValue";
            colRcmCompareValue.Visible = true;
            colRcmCompareValue.VisibleIndex = 4;
            colRcmCompareValue.Width = 92;
            // 
            // colRcmLow
            // 
            colRcmLow.AppearanceCell.Font = new Font("Tahoma", 9F);
            colRcmLow.AppearanceCell.Options.UseFont = true;
            colRcmLow.AppearanceCell.Options.UseTextOptions = true;
            colRcmLow.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            colRcmLow.Caption = "Low";
            colRcmLow.FieldName = "LowValue";
            colRcmLow.MinWidth = 23;
            colRcmLow.Name = "colRcmLow";
            colRcmLow.Visible = true;
            colRcmLow.VisibleIndex = 5;
            colRcmLow.Width = 69;
            // 
            // colRcmHigh
            // 
            colRcmHigh.Caption = "High";
            colRcmHigh.FieldName = "HighValue";
            colRcmHigh.MinWidth = 23;
            colRcmHigh.Name = "colRcmHigh";
            colRcmHigh.Visible = true;
            colRcmHigh.VisibleIndex = 6;
            colRcmHigh.Width = 69;
            // 
            // colRcmConclusionTH
            // 
            colRcmConclusionTH.Caption = "คำแปลผล(ไทย)";
            colRcmConclusionTH.FieldName = "ConclusionTh";
            colRcmConclusionTH.MinWidth = 23;
            colRcmConclusionTH.Name = "colRcmConclusionTH";
            colRcmConclusionTH.Visible = true;
            colRcmConclusionTH.VisibleIndex = 7;
            colRcmConclusionTH.Width = 170;
            // 
            // colRcmRecomendTH
            // 
            colRcmRecomendTH.Caption = "คำแนะนำ(ไทย)";
            colRcmRecomendTH.FieldName = "RecommendTh";
            colRcmRecomendTH.MinWidth = 23;
            colRcmRecomendTH.Name = "colRcmRecomendTH";
            colRcmRecomendTH.Visible = true;
            colRcmRecomendTH.VisibleIndex = 8;
            colRcmRecomendTH.Width = 223;
            // 
            // colRcmConclusionEN
            // 
            colRcmConclusionEN.Caption = "คำแปล(EN)";
            colRcmConclusionEN.FieldName = "ConclusionEn";
            colRcmConclusionEN.MinWidth = 23;
            colRcmConclusionEN.Name = "colRcmConclusionEN";
            colRcmConclusionEN.Visible = true;
            colRcmConclusionEN.VisibleIndex = 9;
            colRcmConclusionEN.Width = 223;
            // 
            // colRcmRecomendEN
            // 
            colRcmRecomendEN.Caption = "คำแนะนำ(EN)";
            colRcmRecomendEN.FieldName = "RecommendEn";
            colRcmRecomendEN.MinWidth = 23;
            colRcmRecomendEN.Name = "colRcmRecomendEN";
            colRcmRecomendEN.Visible = true;
            colRcmRecomendEN.VisibleIndex = 10;
            colRcmRecomendEN.Width = 223;
            // 
            // colRcmStatus
            // 
            colRcmStatus.AppearanceCell.Options.UseTextOptions = true;
            colRcmStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            colRcmStatus.Caption = "Active";
            colRcmStatus.ColumnEdit = repositoryItemCheckEdit1;
            colRcmStatus.FieldName = "IsActive";
            colRcmStatus.MinWidth = 23;
            colRcmStatus.Name = "colRcmStatus";
            colRcmStatus.Visible = true;
            colRcmStatus.VisibleIndex = 11;
            colRcmStatus.Width = 54;
            // 
            // repositoryItemCheckEdit1
            // 
            repositoryItemCheckEdit1.AutoHeight = false;
            repositoryItemCheckEdit1.AutoWidth = true;
            repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            repositoryItemCheckEdit1.ImageOptions.ImageChecked = Resources.Apply_16x16;
            repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // groupControl1
            // 
            groupControl1.AppearanceCaption.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            groupControl1.AppearanceCaption.Options.UseFont = true;
            groupControl1.Controls.Add(panelControl1);
            groupControl1.Dock = DockStyle.Top;
            groupControl1.Location = new Point(0, 0);
            groupControl1.LookAndFeel.SkinName = "Office 2010 Blue";
            groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            groupControl1.Margin = new Padding(4, 3, 4, 3);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(1419, 415);
            groupControl1.TabIndex = 1;
            groupControl1.Text = "กำหนดคำแปลผลและคำแนะนำ";
            // 
            // panelControl1
            // 
            panelControl1.Appearance.Font = new Font("Segoe UI", 9.5F);
            panelControl1.Appearance.Options.UseFont = true;
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl1.Controls.Add(pictureBox1);
            panelControl1.Controls.Add(dtpStartDate);
            panelControl1.Controls.Add(dtpEndDate);
            panelControl1.Controls.Add(cmdFindCode);
            panelControl1.Controls.Add(ddlCondition);
            panelControl1.Controls.Add(txtCompareValue);
            panelControl1.Controls.Add(label16);
            panelControl1.Controls.Add(label15);
            panelControl1.Controls.Add(lblItemName);
            panelControl1.Controls.Add(cmdClose);
            panelControl1.Controls.Add(cmdClear);
            panelControl1.Controls.Add(lblID);
            panelControl1.Controls.Add(cmdSave);
            panelControl1.Controls.Add(label12);
            panelControl1.Controls.Add(label11);
            panelControl1.Controls.Add(label10);
            panelControl1.Controls.Add(label9);
            panelControl1.Controls.Add(lblHighValue);
            panelControl1.Controls.Add(lblLowValue);
            panelControl1.Controls.Add(label6);
            panelControl1.Controls.Add(chkStatus);
            panelControl1.Controls.Add(txtRcmEN);
            panelControl1.Controls.Add(txtConclusionEN);
            panelControl1.Controls.Add(txtRcmTH);
            panelControl1.Controls.Add(txtConclusionTH);
            panelControl1.Controls.Add(txtHighValue);
            panelControl1.Controls.Add(txtLowValue);
            panelControl1.Controls.Add(ddlSex);
            panelControl1.Controls.Add(txtDescription);
            panelControl1.Controls.Add(txtCode);
            panelControl1.Controls.Add(label5);
            panelControl1.Controls.Add(label1);
            panelControl1.Controls.Add(lblPayor);
            panelControl1.Controls.Add(label2);
            panelControl1.Controls.Add(lblDept);
            panelControl1.Dock = DockStyle.Fill;
            panelControl1.Location = new Point(2, 22);
            panelControl1.Margin = new Padding(4, 3, 4, 3);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(1415, 391);
            panelControl1.TabIndex = 52;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.exRecomendationConfig;
            pictureBox1.Location = new Point(848, 8);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dtpStartDate
            // 
            dtpStartDate.EditValue = null;
            dtpStartDate.Location = new Point(148, 353);
            dtpStartDate.Margin = new Padding(4, 3, 4, 3);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Properties.Appearance.Font = new Font("Segoe UI", 9.5F);
            dtpStartDate.Properties.Appearance.Options.UseFont = true;
            dtpStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtpStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtpStartDate.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            dtpStartDate.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            dtpStartDate.Size = new Size(175, 24);
            dtpStartDate.TabIndex = 85;
            // 
            // dtpEndDate
            // 
            dtpEndDate.EditValue = null;
            dtpEndDate.Location = new Point(360, 353);
            dtpEndDate.Margin = new Padding(4, 3, 4, 3);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Properties.Appearance.Font = new Font("Segoe UI", 9.5F);
            dtpEndDate.Properties.Appearance.Options.UseFont = true;
            dtpEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtpEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dtpEndDate.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            dtpEndDate.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            dtpEndDate.Size = new Size(175, 24);
            dtpEndDate.TabIndex = 86;
            // 
            // cmdFindCode
            // 
            cmdFindCode.Appearance.Font = new Font("Tahoma", 9F);
            cmdFindCode.Appearance.ForeColor = Color.White;
            cmdFindCode.Appearance.Options.UseFont = true;
            cmdFindCode.Appearance.Options.UseForeColor = true;
            cmdFindCode.ImageOptions.Image = Resources.Convert_16x16;
            cmdFindCode.Location = new Point(241, 38);
            cmdFindCode.LookAndFeel.SkinMaskColor = SystemColors.HotTrack;
            cmdFindCode.LookAndFeel.SkinName = "Office 2010 Blue";
            cmdFindCode.LookAndFeel.UseDefaultLookAndFeel = false;
            cmdFindCode.Margin = new Padding(4, 3, 4, 3);
            cmdFindCode.Name = "cmdFindCode";
            cmdFindCode.Size = new Size(27, 24);
            cmdFindCode.TabIndex = 1;
            cmdFindCode.Click += cmdFindCode_Click;
            // 
            // ddlCondition
            // 
            ddlCondition.Location = new Point(358, 107);
            ddlCondition.Margin = new Padding(4, 3, 4, 3);
            ddlCondition.Name = "ddlCondition";
            ddlCondition.Properties.Appearance.Font = new Font("Segoe UI", 9.5F);
            ddlCondition.Properties.Appearance.Options.UseFont = true;
            ddlCondition.Properties.AppearanceDropDown.Font = new Font("Segoe UI", 9.5F);
            ddlCondition.Properties.AppearanceDropDown.Options.UseFont = true;
            ddlCondition.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlCondition.Properties.NullText = "";
            ddlCondition.Properties.ShowFooter = false;
            ddlCondition.Properties.ShowHeader = false;
            ddlCondition.Size = new Size(177, 24);
            ddlCondition.TabIndex = 4;
            // 
            // txtCompareValue
            // 
            txtCompareValue.Location = new Point(848, 107);
            txtCompareValue.Margin = new Padding(4, 3, 4, 3);
            txtCompareValue.Name = "txtCompareValue";
            txtCompareValue.Properties.Appearance.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCompareValue.Properties.Appearance.Options.UseFont = true;
            txtCompareValue.Properties.Appearance.Options.UseTextOptions = true;
            txtCompareValue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            txtCompareValue.Size = new Size(176, 24);
            txtCompareValue.TabIndex = 7;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(330, 358);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(20, 17);
            label16.TabIndex = 80;
            label16.Text = "to";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 358);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(87, 17);
            label15.TabIndex = 78;
            label15.Text = "Effective Date";
            // 
            // lblItemName
            // 
            lblItemName.BackColor = Color.White;
            lblItemName.BorderStyle = BorderStyle.FixedSingle;
            lblItemName.Location = new Point(358, 38);
            lblItemName.Margin = new Padding(4, 0, 4, 0);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(483, 26);
            lblItemName.TabIndex = 77;
            lblItemName.Text = "-";
            lblItemName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmdClose
            // 
            cmdClose.Appearance.Font = new Font("Tahoma", 9F);
            cmdClose.Appearance.ForeColor = Color.White;
            cmdClose.Appearance.Options.UseFont = true;
            cmdClose.Appearance.Options.UseForeColor = true;
            cmdClose.ImageOptions.Image = (Image)resources.GetObject("cmdClose.ImageOptions.Image");
            cmdClose.Location = new Point(1234, 350);
            cmdClose.LookAndFeel.SkinMaskColor = SystemColors.ActiveCaption;
            cmdClose.LookAndFeel.SkinName = "DevExpress Dark Style";
            cmdClose.LookAndFeel.UseDefaultLookAndFeel = false;
            cmdClose.Margin = new Padding(4, 3, 4, 3);
            cmdClose.Name = "cmdClose";
            cmdClose.Size = new Size(117, 31);
            cmdClose.TabIndex = 18;
            cmdClose.Text = "Close";
            cmdClose.Click += cmdClose_Click;
            // 
            // cmdClear
            // 
            cmdClear.Appearance.Font = new Font("Tahoma", 9F);
            cmdClear.Appearance.ForeColor = Color.White;
            cmdClear.Appearance.Options.UseFont = true;
            cmdClear.Appearance.Options.UseForeColor = true;
            cmdClear.ImageOptions.Image = Resources.deletedatasource_16x16;
            cmdClear.Location = new Point(1111, 350);
            cmdClear.LookAndFeel.SkinMaskColor = Color.Maroon;
            cmdClear.LookAndFeel.SkinName = "DevExpress Dark Style";
            cmdClear.LookAndFeel.UseDefaultLookAndFeel = false;
            cmdClear.Margin = new Padding(4, 3, 4, 3);
            cmdClear.Name = "cmdClear";
            cmdClear.Size = new Size(117, 31);
            cmdClear.TabIndex = 17;
            cmdClear.Text = "Delete";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(145, 12);
            lblID.Margin = new Padding(4, 0, 4, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(15, 17);
            lblID.TabIndex = 75;
            lblID.Text = "0";
            // 
            // cmdSave
            // 
            cmdSave.Appearance.Font = new Font("Tahoma", 9F);
            cmdSave.Appearance.ForeColor = Color.White;
            cmdSave.Appearance.Options.UseFont = true;
            cmdSave.Appearance.Options.UseForeColor = true;
            cmdSave.ImageOptions.Image = Resources.save_22;
            cmdSave.Location = new Point(987, 350);
            cmdSave.LookAndFeel.SkinMaskColor = SystemColors.HotTrack;
            cmdSave.LookAndFeel.SkinName = "DevExpress Dark Style";
            cmdSave.LookAndFeel.UseDefaultLookAndFeel = false;
            cmdSave.Margin = new Padding(4, 3, 4, 3);
            cmdSave.Name = "cmdSave";
            cmdSave.Size = new Size(117, 31);
            cmdSave.TabIndex = 16;
            cmdSave.Text = "Save";
            cmdSave.Click += cmdSave_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(852, 267);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(110, 17);
            label12.TabIndex = 71;
            label12.Text = "Recommend (EN)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(853, 140);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(109, 17);
            label11.TabIndex = 70;
            label11.Text = "Recommend (TH)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 267);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(100, 17);
            label10.TabIndex = 69;
            label10.Text = "Conclusion (EN)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 140);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(99, 17);
            label9.TabIndex = 68;
            label9.Text = "Conclusion (TH)";
            // 
            // lblHighValue
            // 
            lblHighValue.AutoSize = true;
            lblHighValue.Location = new Point(693, 111);
            lblHighValue.Margin = new Padding(4, 0, 4, 0);
            lblHighValue.Name = "lblHighValue";
            lblHighValue.Size = new Size(70, 17);
            lblHighValue.TabIndex = 67;
            lblHighValue.Text = "High Value";
            // 
            // lblLowValue
            // 
            lblLowValue.AutoSize = true;
            lblLowValue.Location = new Point(542, 111);
            lblLowValue.Margin = new Padding(4, 0, 4, 0);
            lblLowValue.Name = "lblLowValue";
            lblLowValue.Size = new Size(66, 17);
            lblLowValue.TabIndex = 66;
            lblLowValue.Text = "Low Value";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(276, 111);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 17);
            label6.TabIndex = 65;
            label6.Text = "Condition";
            // 
            // chkStatus
            // 
            chkStatus.EditValue = true;
            chkStatus.Location = new Point(628, 355);
            chkStatus.Margin = new Padding(4, 3, 4, 3);
            chkStatus.Name = "chkStatus";
            chkStatus.Properties.Appearance.Font = new Font("Segoe UI", 10F);
            chkStatus.Properties.Appearance.Options.UseFont = true;
            chkStatus.Properties.Caption = "Active / เปิดใช้งาน";
            chkStatus.Properties.LookAndFeel.SkinName = "Whiteprint";
            chkStatus.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            chkStatus.Size = new Size(153, 23);
            chkStatus.TabIndex = 15;
            // 
            // txtRcmEN
            // 
            txtRcmEN.EditValue = "";
            txtRcmEN.Location = new Point(987, 263);
            txtRcmEN.Margin = new Padding(4, 3, 4, 3);
            txtRcmEN.Name = "txtRcmEN";
            txtRcmEN.Properties.Appearance.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRcmEN.Properties.Appearance.Options.UseFont = true;
            txtRcmEN.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtRcmEN.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtRcmEN.Size = new Size(691, 82);
            txtRcmEN.TabIndex = 12;
            // 
            // txtConclusionEN
            // 
            txtConclusionEN.EditValue = "";
            txtConclusionEN.Location = new Point(148, 263);
            txtConclusionEN.Margin = new Padding(4, 3, 4, 3);
            txtConclusionEN.Name = "txtConclusionEN";
            txtConclusionEN.Properties.Appearance.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConclusionEN.Properties.Appearance.Options.UseFont = true;
            txtConclusionEN.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtConclusionEN.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtConclusionEN.Size = new Size(693, 83);
            txtConclusionEN.TabIndex = 11;
            // 
            // txtRcmTH
            // 
            txtRcmTH.EditValue = "";
            txtRcmTH.Location = new Point(987, 138);
            txtRcmTH.Margin = new Padding(4, 3, 4, 3);
            txtRcmTH.Name = "txtRcmTH";
            txtRcmTH.Properties.Appearance.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRcmTH.Properties.Appearance.Options.UseFont = true;
            txtRcmTH.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtRcmTH.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtRcmTH.Size = new Size(691, 119);
            txtRcmTH.TabIndex = 10;
            // 
            // txtConclusionTH
            // 
            txtConclusionTH.EditValue = "";
            txtConclusionTH.Location = new Point(148, 137);
            txtConclusionTH.Margin = new Padding(4, 3, 4, 3);
            txtConclusionTH.Name = "txtConclusionTH";
            txtConclusionTH.Properties.Appearance.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConclusionTH.Properties.Appearance.Options.UseFont = true;
            txtConclusionTH.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            txtConclusionTH.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            txtConclusionTH.Size = new Size(693, 120);
            txtConclusionTH.TabIndex = 9;
            // 
            // txtHighValue
            // 
            txtHighValue.Location = new Point(783, 107);
            txtHighValue.Margin = new Padding(4, 3, 4, 3);
            txtHighValue.Name = "txtHighValue";
            txtHighValue.Properties.Appearance.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHighValue.Properties.Appearance.Options.UseFont = true;
            txtHighValue.Properties.Appearance.Options.UseTextOptions = true;
            txtHighValue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            txtHighValue.Size = new Size(58, 24);
            txtHighValue.TabIndex = 6;
            // 
            // txtLowValue
            // 
            txtLowValue.Location = new Point(628, 107);
            txtLowValue.Margin = new Padding(4, 3, 4, 3);
            txtLowValue.Name = "txtLowValue";
            txtLowValue.Properties.Appearance.Font = new Font("Segoe UI", 9.5F);
            txtLowValue.Properties.Appearance.Options.UseFont = true;
            txtLowValue.Properties.Appearance.Options.UseTextOptions = true;
            txtLowValue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            txtLowValue.Size = new Size(58, 24);
            txtLowValue.TabIndex = 5;
            // 
            // ddlSex
            // 
            ddlSex.EditValue = "";
            ddlSex.Location = new Point(148, 107);
            ddlSex.Margin = new Padding(4, 3, 4, 3);
            ddlSex.Name = "ddlSex";
            ddlSex.Properties.Appearance.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ddlSex.Properties.Appearance.Options.UseFont = true;
            ddlSex.Properties.AppearanceDropDown.Font = new Font("Segoe UI", 9.5F);
            ddlSex.Properties.AppearanceDropDown.Options.UseFont = true;
            ddlSex.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            ddlSex.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            ddlSex.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            ddlSex.Properties.NullText = "";
            ddlSex.Properties.ShowFooter = false;
            ddlSex.Properties.ShowHeader = false;
            ddlSex.Size = new Size(121, 24);
            ddlSex.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(148, 73);
            txtDescription.Margin = new Padding(4, 3, 4, 3);
            txtDescription.Name = "txtDescription";
            txtDescription.Properties.Appearance.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Properties.Appearance.Options.UseFont = true;
            txtDescription.Size = new Size(693, 24);
            txtDescription.TabIndex = 2;
            // 
            // txtCode
            // 
            txtCode.EditValue = "";
            txtCode.Location = new Point(148, 38);
            txtCode.Margin = new Padding(4, 3, 4, 3);
            txtCode.Name = "txtCode";
            txtCode.Properties.Appearance.BackColor = Color.FromArgb(255, 255, 192);
            txtCode.Properties.Appearance.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            txtCode.Properties.Appearance.ForeColor = Color.FromArgb(30, 57, 91);
            txtCode.Properties.Appearance.Options.UseBackColor = true;
            txtCode.Properties.Appearance.Options.UseFont = true;
            txtCode.Properties.Appearance.Options.UseForeColor = true;
            txtCode.Properties.Appearance.Options.UseTextOptions = true;
            txtCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            txtCode.Size = new Size(86, 24);
            txtCode.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 42);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 17);
            label5.TabIndex = 52;
            label5.Text = "Item Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 17);
            label1.TabIndex = 1;
            label1.Text = "Ref. ID";
            // 
            // lblPayor
            // 
            lblPayor.AutoSize = true;
            lblPayor.Location = new Point(6, 76);
            lblPayor.Margin = new Padding(4, 0, 4, 0);
            lblPayor.Name = "lblPayor";
            lblPayor.Size = new Size(74, 17);
            lblPayor.TabIndex = 50;
            lblPayor.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 111);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 17);
            label2.TabIndex = 9;
            label2.Text = "Sex (option)";
            // 
            // lblDept
            // 
            lblDept.AutoSize = true;
            lblDept.Location = new Point(6, 42);
            lblDept.Margin = new Padding(4, 0, 4, 0);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(68, 17);
            lblDept.TabIndex = 11;
            lblDept.Text = "Item Code";
            // 
            // splitContainerControl1
            // 
            splitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            splitContainerControl1.Dock = DockStyle.Fill;
            splitContainerControl1.Horizontal = false;
            splitContainerControl1.Location = new Point(2, 2);
            splitContainerControl1.LookAndFeel.SkinName = "Office 2013 Light Gray";
            splitContainerControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            splitContainerControl1.Margin = new Padding(4, 3, 4, 3);
            splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            splitContainerControl1.Panel1.AutoScroll = true;
            splitContainerControl1.Panel1.Controls.Add(groupControl1);
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(panel2);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new Size(1419, 672);
            splitContainerControl1.SplitterPosition = 415;
            splitContainerControl1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupControl2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1419, 245);
            panel2.TabIndex = 5;
            // 
            // progressLoad
            // 
            progressLoad.Appearance.BackColor = Color.Transparent;
            progressLoad.Appearance.Font = new Font("Tahoma", 10F);
            progressLoad.Appearance.ForeColor = Color.Black;
            progressLoad.Appearance.Options.UseBackColor = true;
            progressLoad.Appearance.Options.UseFont = true;
            progressLoad.Appearance.Options.UseForeColor = true;
            progressLoad.AppearanceCaption.Font = new Font("Microsoft Sans Serif", 12F);
            progressLoad.AppearanceCaption.Options.UseFont = true;
            progressLoad.AppearanceDescription.Font = new Font("Microsoft Sans Serif", 8.25F);
            progressLoad.AppearanceDescription.Options.UseFont = true;
            progressLoad.Location = new Point(372, 323);
            progressLoad.LookAndFeel.SkinName = "McSkin";
            progressLoad.LookAndFeel.UseDefaultLookAndFeel = false;
            progressLoad.Margin = new Padding(4, 3, 4, 3);
            progressLoad.Name = "progressLoad";
            progressLoad.Padding = new Padding(58, 23, 23, 23);
            progressLoad.Size = new Size(292, 85);
            progressLoad.TabIndex = 2;
            progressLoad.Text = "progressPanel1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(6, 6);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(436, 25);
            label3.TabIndex = 0;
            label3.Text = "กำหนดคำแปลผลและคำแนะนำ (Recommendation)";
            // 
            // panelControl4
            // 
            panelControl4.Appearance.BackColor = Color.Transparent;
            panelControl4.Appearance.BorderColor = Color.Transparent;
            panelControl4.Appearance.Font = new Font("Tahoma", 9F);
            panelControl4.Appearance.Options.UseBackColor = true;
            panelControl4.Appearance.Options.UseBorderColor = true;
            panelControl4.Appearance.Options.UseFont = true;
            panelControl4.Controls.Add(splitContainerControl1);
            panelControl4.Dock = DockStyle.Fill;
            panelControl4.Location = new Point(0, 46);
            panelControl4.Margin = new Padding(4, 3, 4, 3);
            panelControl4.Name = "panelControl4";
            panelControl4.Size = new Size(1423, 676);
            panelControl4.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 56, 148);
            panel1.Controls.Add(lblClose);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1423, 46);
            panel1.TabIndex = 6;
            // 
            // lblClose
            // 
            lblClose.BackColor = Color.Transparent;
            lblClose.Dock = DockStyle.Right;
            lblClose.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblClose.ForeColor = Color.White;
            lblClose.Location = new Point(1395, 0);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(28, 46);
            lblClose.TabIndex = 3;
            lblClose.Text = "X";
            lblClose.TextAlign = ContentAlignment.MiddleCenter;
            lblClose.Click += lblClose_Click;
            // 
            // RecommendationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1423, 722);
            Controls.Add(panelControl4);
            Controls.Add(progressLoad);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "RecommendationForm";
            Text = "Recommend Management";
            Load += frmReportMenu_Load;
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdData).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewData).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtpStartDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtpStartDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtpEndDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtpEndDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlCondition.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCompareValue.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkStatus.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtRcmEN.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtConclusionEN.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtRcmTH.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtConclusionTH.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHighValue.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtLowValue.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)ddlSex.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelControl4).EndInit();
            panelControl4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdSave;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPayor;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdClear;
        private DevExpress.XtraWaitForm.ProgressPanel progressLoad;
        internal DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraGrid.GridControl grdData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn colRcmStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        internal DevExpress.XtraGrid.Columns.GridColumn colRcmItemCode;
        internal DevExpress.XtraGrid.Columns.GridColumn colRcmCheckupName;
        internal DevExpress.XtraGrid.Columns.GridColumn colRcmTypeName;
        internal DevExpress.XtraGrid.Columns.GridColumn colRcmCompareValue;
        internal DevExpress.XtraGrid.Columns.GridColumn colRcmLow;
        internal DevExpress.XtraGrid.Columns.GridColumn colRcmHigh;
        private DevExpress.XtraGrid.Columns.GridColumn colRcmConclusionTH;
        internal DevExpress.XtraGrid.Columns.GridColumn colRcmRefID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.LookUpEdit ddlSex;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtHighValue;
        private DevExpress.XtraEditors.TextEdit txtLowValue;
        private DevExpress.XtraEditors.CheckEdit chkStatus;
        private DevExpress.XtraEditors.MemoEdit txtRcmEN;
        private DevExpress.XtraEditors.MemoEdit txtConclusionEN;
        private DevExpress.XtraEditors.MemoEdit txtRcmTH;
        private DevExpress.XtraEditors.MemoEdit txtConclusionTH;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblHighValue;
        private System.Windows.Forms.Label lblLowValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.TextEdit txtCompareValue;
        private DevExpress.XtraEditors.LookUpEdit ddlCondition;
        private DevExpress.XtraGrid.Columns.GridColumn colRcmRecomendTH;
        private DevExpress.XtraGrid.Columns.GridColumn colRcmSex;
        private DevExpress.XtraGrid.Columns.GridColumn colRcmConclusionEN;
        private DevExpress.XtraGrid.Columns.GridColumn colRcmRecomendEN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton cmdFindCode;
        internal DevExpress.XtraEditors.DateEdit dtpStartDate;
        internal DevExpress.XtraEditors.DateEdit dtpEndDate;
        private Label lblClose;
    }
}
