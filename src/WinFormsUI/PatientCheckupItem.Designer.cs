namespace SUTH.HealthCheckup.WinFormsUI.Controllers
{
    partial class PatientCheckupItem : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientCheckupItem));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grdData = new DevExpress.XtraGrid.GridControl();
            this.grdViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCheckupGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnResultValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn46 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnReference = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboGroup = new DevExpress.XtraEditors.LookUpEdit();
            this.cmdView = new DevExpress.XtraEditors.SimpleButton();
            this.dtpStartDate = new DevExpress.XtraEditors.DateEdit();
            this.lblPayor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEndDate = new DevExpress.XtraEditors.DateEdit();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.progressLoad = new DevExpress.XtraWaitForm.ProgressPanel();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.grdData);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.LookAndFeel.SkinName = "Office 2010 Blue";
            this.groupControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(878, 451);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "รายการตรวจ";
            // 
            // grdData
            // 
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.grdData.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.grdData.Location = new System.Drawing.Point(2, 22);
            this.grdData.LookAndFeel.SkinName = "Office 2010 Blue";
            this.grdData.LookAndFeel.UseDefaultLookAndFeel = false;
            this.grdData.MainView = this.grdViewData;
            this.grdData.Margin = new System.Windows.Forms.Padding(0);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(874, 427);
            this.grdData.TabIndex = 5;
            this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewData});
            // 
            // grdViewData
            // 
            this.grdViewData.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grdViewData.Appearance.GroupRow.Options.UseFont = true;
            this.grdViewData.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.grdViewData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdViewData.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.grdViewData.Appearance.OddRow.Options.UseBackColor = true;
            this.grdViewData.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grdViewData.Appearance.Row.Options.UseFont = true;
            this.grdViewData.Appearance.Row.Options.UseTextOptions = true;
            this.grdViewData.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grdViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCheckupGroupName,
            this.gridColumnResultValue,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn46,
            this.gridColumnReference});
            this.grdViewData.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.grdViewData.GridControl = this.grdData;
            this.grdViewData.GroupCount = 2;
            this.grdViewData.GroupFormat = "[#image]{1} {2}";
            this.grdViewData.Name = "grdViewData";
            this.grdViewData.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.grdViewData.OptionsFind.AlwaysVisible = true;
            this.grdViewData.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grdViewData.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.grdViewData.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.grdViewData.OptionsView.EnableAppearanceOddRow = true;
            this.grdViewData.OptionsView.ShowGroupPanel = false;
            this.grdViewData.OptionsView.ShowIndicator = false;
            this.grdViewData.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCheckupGroupName, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumnResultValue, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCheckupGroupName
            // 
            this.colCheckupGroupName.AppearanceCell.Options.UseTextOptions = true;
            this.colCheckupGroupName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colCheckupGroupName.Caption = "CheckupGroupName";
            this.colCheckupGroupName.FieldName = "CheckupGroupName";
            this.colCheckupGroupName.FieldNameSortGroup = "DisplayOrderGroup";
            this.colCheckupGroupName.Name = "colCheckupGroupName";
            this.colCheckupGroupName.OptionsColumn.AllowEdit = false;
            this.colCheckupGroupName.Visible = true;
            this.colCheckupGroupName.VisibleIndex = 0;
            // 
            // gridColumnResultValue
            // 
            this.gridColumnResultValue.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumnResultValue.AppearanceCell.Options.UseFont = true;
            this.gridColumnResultValue.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnResultValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumnResultValue.Caption = "DisplayName";
            this.gridColumnResultValue.FieldName = "DisplayName";
            this.gridColumnResultValue.Name = "gridColumnResultValue";
            this.gridColumnResultValue.OptionsColumn.AllowEdit = false;
            this.gridColumnResultValue.Visible = true;
            this.gridColumnResultValue.VisibleIndex = 0;
            this.gridColumnResultValue.Width = 120;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "HN";
            this.gridColumn1.FieldName = "PatientID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "PatientUID";
            this.gridColumn2.FieldName = "PatientUID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "PatientVisitUID";
            this.gridColumn3.FieldName = "PatientVisitUID";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn46
            // 
            this.gridColumn46.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn46.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumn46.Caption = "Name";
            this.gridColumn46.FieldName = "PatientName";
            this.gridColumn46.Name = "gridColumn46";
            this.gridColumn46.OptionsColumn.AllowEdit = false;
            this.gridColumn46.Visible = true;
            this.gridColumn46.VisibleIndex = 3;
            this.gridColumn46.Width = 120;
            // 
            // gridColumnReference
            // 
            this.gridColumnReference.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnReference.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnReference.Caption = "Visit Date";
            this.gridColumnReference.FieldName = "VisitDTTM";
            this.gridColumnReference.Name = "gridColumnReference";
            this.gridColumnReference.OptionsColumn.AllowEdit = false;
            this.gridColumnReference.Visible = true;
            this.gridColumnReference.VisibleIndex = 4;
            this.gridColumnReference.Width = 150;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.LookAndFeel.SkinName = "Office 2010 Blue";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(878, 121);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "ค้นหา";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.panelControl1.Appearance.Options.UseFont = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.txtSearch);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cboGroup);
            this.panelControl1.Controls.Add(this.cmdView);
            this.panelControl1.Controls.Add(this.dtpStartDate);
            this.panelControl1.Controls.Add(this.lblPayor);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.dtpEndDate);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(2, 22);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(832, 97);
            this.panelControl1.TabIndex = 52;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(81, 64);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Properties.NullValuePrompt = "Lab name";
            this.txtSearch.Size = new System.Drawing.Size(209, 24);
            this.txtSearch.TabIndex = 53;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 52;
            this.label3.Text = "Keyword";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visit Date ";
            // 
            // cboGroup
            // 
            this.cboGroup.EditValue = "";
            this.cboGroup.Location = new System.Drawing.Point(81, 34);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGroup.Properties.Appearance.Options.UseFont = true;
            this.cboGroup.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGroup.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGroup.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.cboGroup.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cboGroup.Properties.NullText = "";
            this.cboGroup.Size = new System.Drawing.Size(540, 24);
            this.cboGroup.TabIndex = 51;
            // 
            // cmdView
            // 
            this.cmdView.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cmdView.Appearance.ForeColor = System.Drawing.Color.White;
            this.cmdView.Appearance.Options.UseFont = true;
            this.cmdView.Appearance.Options.UseForeColor = true;
            this.cmdView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdView.ImageOptions.Image")));
            this.cmdView.Location = new System.Drawing.Point(296, 64);
            this.cmdView.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.HotTrack;
            this.cmdView.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.cmdView.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdView.Name = "cmdView";
            this.cmdView.Size = new System.Drawing.Size(85, 25);
            this.cmdView.TabIndex = 0;
            this.cmdView.Text = "View";
            this.cmdView.Click += new System.EventHandler(this.cmdResultByItem_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.EditValue = null;
            this.dtpStartDate.Location = new System.Drawing.Point(81, 4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpStartDate.Properties.Appearance.Options.UseFont = true;
            this.dtpStartDate.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpStartDate.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dtpStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpStartDate.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.dtpStartDate.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dtpStartDate.Size = new System.Drawing.Size(131, 24);
            this.dtpStartDate.TabIndex = 8;
            // 
            // lblPayor
            // 
            this.lblPayor.AutoSize = true;
            this.lblPayor.Location = new System.Drawing.Point(3, 40);
            this.lblPayor.Name = "lblPayor";
            this.lblPayor.Size = new System.Drawing.Size(48, 19);
            this.lblPayor.TabIndex = 50;
            this.lblPayor.Text = "Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "to";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.EditValue = null;
            this.dtpEndDate.Location = new System.Drawing.Point(250, 4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpEndDate.Properties.Appearance.Options.UseFont = true;
            this.dtpEndDate.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpEndDate.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dtpEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpEndDate.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            this.dtpEndDate.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dtpEndDate.Size = new System.Drawing.Size(131, 24);
            this.dtpEndDate.TabIndex = 10;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.splitContainerControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(878, 584);
            this.splitContainerControl1.SplitterPosition = 121;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // progressLoad
            // 
            this.progressLoad.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressLoad.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.progressLoad.Appearance.ForeColor = System.Drawing.Color.Black;
            this.progressLoad.Appearance.Options.UseBackColor = true;
            this.progressLoad.Appearance.Options.UseFont = true;
            this.progressLoad.Appearance.Options.UseForeColor = true;
            this.progressLoad.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressLoad.AppearanceCaption.Options.UseFont = true;
            this.progressLoad.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.progressLoad.AppearanceDescription.Options.UseFont = true;
            this.progressLoad.BarAnimationElementThickness = 2;
            this.progressLoad.Location = new System.Drawing.Point(319, 280);
            this.progressLoad.LookAndFeel.SkinName = "McSkin";
            this.progressLoad.LookAndFeel.UseDefaultLookAndFeel = false;
            this.progressLoad.Name = "progressLoad";
            this.progressLoad.Padding = new System.Windows.Forms.Padding(50, 20, 20, 20);
            this.progressLoad.Size = new System.Drawing.Size(250, 74);
            this.progressLoad.TabIndex = 2;
            this.progressLoad.Text = "progressPanel1";
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.panel2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(0, 584);
            this.panelControl3.LookAndFeel.SkinName = "Office 2010 Blue";
            this.panelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(878, 40);
            this.panelControl3.TabIndex = 111;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(738, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 40);
            this.panel2.TabIndex = 16;
            // 
            // cmdClose
            // 
            this.cmdClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmdClose.Appearance.ForeColor = System.Drawing.Color.White;
            this.cmdClose.Appearance.Options.UseFont = true;
            this.cmdClose.Appearance.Options.UseForeColor = true;
            this.cmdClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdClose.ImageOptions.Image")));
            this.cmdClose.Location = new System.Drawing.Point(34, 6);
            this.cmdClose.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdClose.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.cmdClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(94, 27);
            this.cmdClose.TabIndex = 14;
            this.cmdClose.Text = "Close";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainerControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 584);
            this.panel1.TabIndex = 112;
            // 
            // frmPatientCheckupItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(878, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.progressLoad);
            this.Name = "frmPatientCheckupItem";
            this.Load += new System.EventHandler(this.frmReportMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdView;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        internal DevExpress.XtraEditors.DateEdit dtpEndDate;
        private System.Windows.Forms.Label label2;
        internal DevExpress.XtraEditors.DateEdit dtpStartDate;
        private DevExpress.XtraEditors.LookUpEdit cboGroup;
        private System.Windows.Forms.Label lblPayor;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraWaitForm.ProgressPanel progressLoad;
        private DevExpress.XtraGrid.GridControl grdData;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewData;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumnResultValue;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn46;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumnReference;
        private DevExpress.XtraGrid.Columns.GridColumn colCheckupGroupName;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        internal DevExpress.XtraEditors.SimpleButton cmdClose;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private System.Windows.Forms.Label label3;
    }
}