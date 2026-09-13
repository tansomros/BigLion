namespace SUTH.HealthCheckup.WinFormsUI.Reports;

partial class ReportCenter
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportCenter));
        DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
        DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
        DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
        DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
        DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
        DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
        DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
        gridControlReportResult = new DevExpress.XtraGrid.GridControl();
        viewReportResult = new DevExpress.XtraGrid.Views.Grid.GridView();
        panel1 = new Panel();
        panel5 = new Panel();
        btnBestFitColumn = new Button();
        btRunReport = new Button();
        btExcelExport = new Button();
        label3 = new Label();
        SplitContentControlMain = new DevExpress.XtraEditors.SplitContainerControl();
        groupControl1 = new DevExpress.XtraEditors.GroupControl();
        panelReportName = new Panel();
        gridControlReportName = new DevExpress.XtraGrid.GridControl();
        viewReportName = new DevExpress.XtraGrid.Views.Grid.GridView();
        colReportGroup = new DevExpress.XtraGrid.Columns.GridColumn();
        colReportName = new DevExpress.XtraGrid.Columns.GridColumn();
        repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
        colScriptSql = new DevExpress.XtraGrid.Columns.GridColumn();
        colParameter = new DevExpress.XtraGrid.Columns.GridColumn();
        colQueryType = new DevExpress.XtraGrid.Columns.GridColumn();
        colReportUID = new DevExpress.XtraGrid.Columns.GridColumn();
        colPublic = new DevExpress.XtraGrid.Columns.GridColumn();
        gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
        repositoryItemButtonRun = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
        gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
        panel3 = new Panel();
        panel4 = new Panel();
        cmdPageBack = new DevExpress.XtraEditors.SimpleButton();
        ((System.ComponentModel.ISupportInitialize)gridControlReportResult).BeginInit();
        ((System.ComponentModel.ISupportInitialize)viewReportResult).BeginInit();
        panel1.SuspendLayout();
        panel5.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)SplitContentControlMain).BeginInit();
        ((System.ComponentModel.ISupportInitialize)SplitContentControlMain.Panel1).BeginInit();
        SplitContentControlMain.Panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)SplitContentControlMain.Panel2).BeginInit();
        SplitContentControlMain.Panel2.SuspendLayout();
        SplitContentControlMain.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
        groupControl1.SuspendLayout();
        panelReportName.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridControlReportName).BeginInit();
        ((System.ComponentModel.ISupportInitialize)viewReportName).BeginInit();
        ((System.ComponentModel.ISupportInitialize)repositoryItemMemoEdit1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)repositoryItemButtonRun).BeginInit();
        panel3.SuspendLayout();
        panel4.SuspendLayout();
        SuspendLayout();
        // 
        // gridControlReportResult
        // 
        gridControlReportResult.Dock = DockStyle.Fill;
        gridControlReportResult.EmbeddedNavigator.Buttons.Append.Visible = false;
        gridControlReportResult.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
        gridControlReportResult.EmbeddedNavigator.Buttons.Edit.Visible = false;
        gridControlReportResult.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
        gridControlReportResult.EmbeddedNavigator.Buttons.Remove.Visible = false;
        gridControlReportResult.Location = new Point(0, 0);
        gridControlReportResult.LookAndFeel.SkinName = "WXI";
        gridControlReportResult.LookAndFeel.UseDefaultLookAndFeel = false;
        gridControlReportResult.MainView = viewReportResult;
        gridControlReportResult.Name = "gridControlReportResult";
        gridControlReportResult.Size = new Size(441, 411);
        gridControlReportResult.TabIndex = 2;
        gridControlReportResult.UseEmbeddedNavigator = true;
        gridControlReportResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { viewReportResult });
        // 
        // viewReportResult
        // 
        viewReportResult.Appearance.EvenRow.BackColor = Color.FromArgb(244, 249, 255);
        viewReportResult.Appearance.EvenRow.Options.UseBackColor = true;
        viewReportResult.Appearance.HeaderPanel.Font = new Font("Sarabun", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        viewReportResult.Appearance.HeaderPanel.ForeColor = Color.Black;
        viewReportResult.Appearance.HeaderPanel.Options.UseFont = true;
        viewReportResult.Appearance.HeaderPanel.Options.UseForeColor = true;
        viewReportResult.Appearance.Row.Font = new Font("Sarabun", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        viewReportResult.Appearance.Row.Options.UseFont = true;
        viewReportResult.AppearancePrint.EvenRow.BackColor = Color.FromArgb(237, 233, 240);
        viewReportResult.AppearancePrint.EvenRow.Options.UseBackColor = true;
        viewReportResult.AppearancePrint.Row.BackColor = Color.FromArgb(237, 233, 240);
        viewReportResult.AppearancePrint.Row.Options.UseBackColor = true;
        viewReportResult.GridControl = gridControlReportResult;
        viewReportResult.Name = "viewReportResult";
        viewReportResult.OptionsBehavior.Editable = false;
        viewReportResult.OptionsPrint.EnableAppearanceEvenRow = true;
        viewReportResult.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
        viewReportResult.OptionsView.ColumnAutoWidth = false;
        viewReportResult.OptionsView.EnableAppearanceEvenRow = true;
        viewReportResult.RowHeight = 0;
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(62, 91, 135);
        panel1.Controls.Add(panel5);
        panel1.Controls.Add(btExcelExport);
        panel1.Controls.Add(label3);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Padding = new Padding(1);
        panel1.Size = new Size(441, 41);
        panel1.TabIndex = 3;
        // 
        // panel5
        // 
        panel5.Controls.Add(btnBestFitColumn);
        panel5.Controls.Add(btRunReport);
        panel5.Dock = DockStyle.Left;
        panel5.Location = new Point(1, 1);
        panel5.Name = "panel5";
        panel5.Size = new Size(300, 39);
        panel5.TabIndex = 2;
        // 
        // btnBestFitColumn
        // 
        btnBestFitColumn.Cursor = Cursors.Hand;
        btnBestFitColumn.FlatAppearance.BorderColor = Color.FromArgb(40, 118, 75);
        btnBestFitColumn.FlatAppearance.BorderSize = 0;
        btnBestFitColumn.FlatStyle = FlatStyle.Flat;
        btnBestFitColumn.Font = new Font("Sarabun", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnBestFitColumn.ForeColor = Color.White;
        btnBestFitColumn.Image = (Image)resources.GetObject("btnBestFitColumn.Image");
        btnBestFitColumn.ImageAlign = ContentAlignment.MiddleLeft;
        btnBestFitColumn.Location = new Point(5, 4);
        btnBestFitColumn.Name = "btnBestFitColumn";
        btnBestFitColumn.Size = new Size(138, 31);
        btnBestFitColumn.TabIndex = 2;
        btnBestFitColumn.Text = "Best fit columns";
        btnBestFitColumn.TextAlign = ContentAlignment.MiddleRight;
        btnBestFitColumn.UseVisualStyleBackColor = false;
        btnBestFitColumn.Click += btnBestFitColumn_Click;
        // 
        // btRunReport
        // 
        btRunReport.Cursor = Cursors.Hand;
        btRunReport.FlatAppearance.BorderColor = Color.FromArgb(40, 118, 75);
        btRunReport.FlatAppearance.BorderSize = 0;
        btRunReport.FlatStyle = FlatStyle.Flat;
        btRunReport.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btRunReport.ForeColor = Color.White;
        btRunReport.Image = (Image)resources.GetObject("btRunReport.Image");
        btRunReport.ImageAlign = ContentAlignment.MiddleLeft;
        btRunReport.Location = new Point(202, 1);
        btRunReport.Name = "btRunReport";
        btRunReport.Size = new Size(84, 34);
        btRunReport.TabIndex = 1;
        btRunReport.Text = "     RUN";
        btRunReport.UseVisualStyleBackColor = false;
        btRunReport.Visible = false;
        btRunReport.Click += btRunReport_Click;
        // 
        // btExcelExport
        // 
        btExcelExport.Cursor = Cursors.Hand;
        btExcelExport.Dock = DockStyle.Right;
        btExcelExport.FlatAppearance.BorderColor = Color.FromArgb(40, 118, 75);
        btExcelExport.FlatAppearance.BorderSize = 0;
        btExcelExport.FlatStyle = FlatStyle.Flat;
        btExcelExport.Font = new Font("Sarabun", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btExcelExport.ForeColor = Color.White;
        btExcelExport.Image = (Image)resources.GetObject("btExcelExport.Image");
        btExcelExport.ImageAlign = ContentAlignment.MiddleLeft;
        btExcelExport.Location = new Point(352, 1);
        btExcelExport.Name = "btExcelExport";
        btExcelExport.Padding = new Padding(2, 0, 0, 0);
        btExcelExport.Size = new Size(88, 39);
        btExcelExport.TabIndex = 2;
        btExcelExport.Text = "Export";
        btExcelExport.TextAlign = ContentAlignment.MiddleRight;
        btExcelExport.UseVisualStyleBackColor = false;
        btExcelExport.Click += btExcelExport_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Sarabun", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label3.ForeColor = Color.White;
        label3.Location = new Point(500, 3);
        label3.Name = "label3";
        label3.Size = new Size(151, 39);
        label3.TabIndex = 0;
        label3.Text = "Report Center";
        // 
        // SplitContentControlMain
        // 
        SplitContentControlMain.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1;
        SplitContentControlMain.Dock = DockStyle.Fill;
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
        SplitContentControlMain.Size = new Size(734, 448);
        SplitContentControlMain.SplitterPosition = 287;
        SplitContentControlMain.TabIndex = 4;
        // 
        // groupControl1
        // 
        groupControl1.AppearanceCaption.Font = new Font("Sarabun", 9F, FontStyle.Bold);
        groupControl1.AppearanceCaption.Options.UseFont = true;
        groupControl1.Controls.Add(panelReportName);
        groupControl1.Dock = DockStyle.Fill;
        groupControl1.Location = new Point(0, 0);
        groupControl1.Name = "groupControl1";
        groupControl1.Size = new Size(287, 448);
        groupControl1.TabIndex = 11;
        groupControl1.Text = "รายงาน";
        // 
        // panelReportName
        // 
        panelReportName.BackColor = Color.WhiteSmoke;
        panelReportName.Controls.Add(gridControlReportName);
        panelReportName.Dock = DockStyle.Fill;
        panelReportName.Location = new Point(2, 27);
        panelReportName.Name = "panelReportName";
        panelReportName.Size = new Size(283, 419);
        panelReportName.TabIndex = 5;
        // 
        // gridControlReportName
        // 
        gridControlReportName.Dock = DockStyle.Fill;
        gridControlReportName.Location = new Point(0, 0);
        gridControlReportName.LookAndFeel.SkinName = "WXI";
        gridControlReportName.LookAndFeel.UseDefaultLookAndFeel = false;
        gridControlReportName.MainView = viewReportName;
        gridControlReportName.Name = "gridControlReportName";
        gridControlReportName.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemButtonRun, repositoryItemMemoEdit1 });
        gridControlReportName.Size = new Size(283, 419);
        gridControlReportName.TabIndex = 2;
        gridControlReportName.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { viewReportName });
        // 
        // viewReportName
        // 
        viewReportName.Appearance.EvenRow.BackColor = Color.FromArgb(242, 246, 251);
        viewReportName.Appearance.EvenRow.Options.UseBackColor = true;
        viewReportName.Appearance.FilterPanel.Font = new Font("Segoe UI", 10F);
        viewReportName.Appearance.FilterPanel.Options.UseFont = true;
        viewReportName.Appearance.FooterPanel.Font = new Font("Segoe UI", 10F);
        viewReportName.Appearance.FooterPanel.Options.UseFont = true;
        viewReportName.Appearance.GroupRow.BackColor = Color.FromArgb(203, 228, 240);
        viewReportName.Appearance.GroupRow.Font = new Font("Sarabun", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        viewReportName.Appearance.GroupRow.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.WindowText;
        viewReportName.Appearance.GroupRow.Options.UseBackColor = true;
        viewReportName.Appearance.GroupRow.Options.UseFont = true;
        viewReportName.Appearance.GroupRow.Options.UseForeColor = true;
        viewReportName.Appearance.HeaderPanel.Font = new Font("Sarabun", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
        viewReportName.Appearance.HeaderPanel.ForeColor = Color.FromArgb(64, 64, 64);
        viewReportName.Appearance.HeaderPanel.Options.UseFont = true;
        viewReportName.Appearance.HeaderPanel.Options.UseForeColor = true;
        viewReportName.Appearance.Row.BackColor = Color.White;
        viewReportName.Appearance.Row.Font = new Font("Sarabun", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        viewReportName.Appearance.Row.Options.UseBackColor = true;
        viewReportName.Appearance.Row.Options.UseFont = true;
        viewReportName.Appearance.TopNewRow.Font = new Font("Segoe UI", 10F);
        viewReportName.Appearance.TopNewRow.Options.UseFont = true;
        viewReportName.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colReportGroup, colReportName, colScriptSql, colParameter, colQueryType, colReportUID, colPublic, gridColumn1, gridColumn2 });
        gridFormatRule1.ApplyToRow = true;
        gridFormatRule1.Name = "Format0";
        formatConditionRuleExpression1.Expression = "[Active] = False";
        formatConditionRuleExpression1.PredefinedName = "Red Text";
        gridFormatRule1.Rule = formatConditionRuleExpression1;
        viewReportName.FormatRules.Add(gridFormatRule1);
        viewReportName.GridControl = gridControlReportName;
        viewReportName.Name = "viewReportName";
        viewReportName.OptionsFilter.AllowFilterEditor = false;
        viewReportName.OptionsFind.AlwaysVisible = true;
        viewReportName.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
        viewReportName.OptionsFind.HighlightFindResults = false;
        viewReportName.OptionsFind.ShowFindButton = false;
        viewReportName.OptionsSelection.EnableAppearanceHotTrackedRow = DevExpress.Utils.DefaultBoolean.True;
        viewReportName.OptionsSelection.InvertSelection = true;
        viewReportName.OptionsView.RowAutoHeight = true;
        viewReportName.OptionsView.ShowColumnHeaders = false;
        viewReportName.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
        viewReportName.OptionsView.ShowGroupPanel = false;
        viewReportName.OptionsView.ShowIndicator = false;
        viewReportName.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] { new DevExpress.XtraGrid.Columns.GridColumnSortInfo(gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending), new DevExpress.XtraGrid.Columns.GridColumnSortInfo(colReportName, DevExpress.Data.ColumnSortOrder.Ascending) });
        viewReportName.CustomDrawGroupRow += viewReportName_CustomDrawGroupRow;
        viewReportName.DoubleClick += viewReportName_DoubleClick;
        // 
        // colReportGroup
        // 
        colReportGroup.Caption = "Group";
        colReportGroup.FieldName = "ReportGroupName";
        colReportGroup.FieldNameSortGroup = "Sort";
        colReportGroup.Name = "colReportGroup";
        // 
        // colReportName
        // 
        colReportName.Caption = "ReportName";
        colReportName.ColumnEdit = repositoryItemMemoEdit1;
        colReportName.FieldName = "ReportName";
        colReportName.Name = "colReportName";
        colReportName.OptionsColumn.AllowEdit = false;
        colReportName.Visible = true;
        colReportName.VisibleIndex = 0;
        colReportName.Width = 253;
        // 
        // repositoryItemMemoEdit1
        // 
        repositoryItemMemoEdit1.AllowFocused = false;
        repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
        repositoryItemMemoEdit1.ReadOnly = true;
        // 
        // colScriptSql
        // 
        colScriptSql.Caption = "Sql";
        colScriptSql.FieldName = "Sql";
        colScriptSql.Name = "colScriptSql";
        // 
        // colParameter
        // 
        colParameter.Caption = "Parameter";
        colParameter.Name = "colParameter";
        // 
        // colQueryType
        // 
        colQueryType.Caption = "ReportType";
        colQueryType.Name = "colQueryType";
        // 
        // colReportUID
        // 
        colReportUID.Caption = "Id";
        colReportUID.FieldName = "Id";
        colReportUID.Name = "colReportUID";
        // 
        // colPublic
        // 
        colPublic.Caption = "IsPublic";
        colPublic.FieldName = "Active";
        colPublic.Name = "colPublic";
        colPublic.Width = 55;
        // 
        // gridColumn1
        // 
        gridColumn1.Caption = "gridColumn1";
        gridColumn1.ColumnEdit = repositoryItemButtonRun;
        gridColumn1.Name = "gridColumn1";
        gridColumn1.Visible = true;
        gridColumn1.VisibleIndex = 1;
        gridColumn1.Width = 30;
        // 
        // repositoryItemButtonRun
        // 
        repositoryItemButtonRun.AutoHeight = false;
        repositoryItemButtonRun.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        editorButtonImageOptions1.SvgImage = Properties.Resources.next1;
        editorButtonImageOptions1.SvgImageSize = new Size(24, 24);
        serializableAppearanceObject1.Font = new Font("Prompt", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        serializableAppearanceObject1.Options.UseFont = true;
        repositoryItemButtonRun.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
        repositoryItemButtonRun.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        repositoryItemButtonRun.LookAndFeel.UseDefaultLookAndFeel = false;
        repositoryItemButtonRun.Name = "repositoryItemButtonRun";
        repositoryItemButtonRun.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
        repositoryItemButtonRun.ButtonClick += repositoryItemButtonRun_ButtonClick;
        // 
        // gridColumn2
        // 
        gridColumn2.Caption = "Sort";
        gridColumn2.FieldName = "Sort";
        gridColumn2.Name = "gridColumn2";
        // 
        // panel3
        // 
        panel3.Controls.Add(panel1);
        panel3.Controls.Add(gridControlReportResult);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(0, 0);
        panel3.Name = "panel3";
        panel3.Size = new Size(441, 411);
        panel3.TabIndex = 2;
        // 
        // panel4
        // 
        panel4.BackColor = Color.White;
        panel4.Controls.Add(cmdPageBack);
        panel4.Dock = DockStyle.Bottom;
        panel4.Location = new Point(0, 411);
        panel4.Name = "panel4";
        panel4.Size = new Size(441, 37);
        panel4.TabIndex = 2;
        panel4.TabStop = true;
        // 
        // cmdPageBack
        // 
        cmdPageBack.Appearance.BackColor = Color.White;
        cmdPageBack.Appearance.BorderColor = Color.Transparent;
        cmdPageBack.Appearance.Options.UseBackColor = true;
        cmdPageBack.Appearance.Options.UseBorderColor = true;
        cmdPageBack.Cursor = Cursors.Hand;
        cmdPageBack.Dock = DockStyle.Right;
        cmdPageBack.ImageOptions.Image = Properties.Resources.prev2;
        cmdPageBack.Location = new Point(410, 0);
        cmdPageBack.Margin = new Padding(0);
        cmdPageBack.Name = "cmdPageBack";
        cmdPageBack.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
        cmdPageBack.Size = new Size(31, 37);
        cmdPageBack.TabIndex = 0;
        // 
        // ReportCenter
        // 
        Appearance.Options.UseFont = true;
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(734, 448);
        Controls.Add(SplitContentControlMain);
        Name = "ReportCenter";
        Text = "Report Center";
        Load += ReportCenter_Load;
        ((System.ComponentModel.ISupportInitialize)gridControlReportResult).EndInit();
        ((System.ComponentModel.ISupportInitialize)viewReportResult).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel5.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)SplitContentControlMain.Panel1).EndInit();
        SplitContentControlMain.Panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)SplitContentControlMain.Panel2).EndInit();
        SplitContentControlMain.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)SplitContentControlMain).EndInit();
        SplitContentControlMain.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
        groupControl1.ResumeLayout(false);
        panelReportName.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridControlReportName).EndInit();
        ((System.ComponentModel.ISupportInitialize)viewReportName).EndInit();
        ((System.ComponentModel.ISupportInitialize)repositoryItemMemoEdit1).EndInit();
        ((System.ComponentModel.ISupportInitialize)repositoryItemButtonRun).EndInit();
        panel3.ResumeLayout(false);
        panel4.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private DevExpress.XtraGrid.GridControl gridControlReportResult;
    private DevExpress.XtraGrid.Views.Grid.GridView viewReportResult;
    private Panel panel1;
    private Panel panel5;
    private Button btnBestFitColumn;
    private Button btRunReport;
    private Button btExcelExport;
    private Label label3;
    internal DevExpress.XtraEditors.SplitContainerControl SplitContentControlMain;
    private DevExpress.XtraEditors.GroupControl groupControl1;
    private Panel panel3;
    private Panel panel4;
    private DevExpress.XtraEditors.SimpleButton cmdPageBack;
    private Panel panelReportName;
    private DevExpress.XtraGrid.GridControl gridControlReportName;
    private DevExpress.XtraGrid.Views.Grid.GridView viewReportName;
    private DevExpress.XtraGrid.Columns.GridColumn colReportGroup;
    private DevExpress.XtraGrid.Columns.GridColumn colReportName;
    private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    private DevExpress.XtraGrid.Columns.GridColumn colScriptSql;
    private DevExpress.XtraGrid.Columns.GridColumn colParameter;
    private DevExpress.XtraGrid.Columns.GridColumn colQueryType;
    private DevExpress.XtraGrid.Columns.GridColumn colReportUID;
    private DevExpress.XtraGrid.Columns.GridColumn colPublic;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonRun;
    private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
}
