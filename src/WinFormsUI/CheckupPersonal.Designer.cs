using SUTH.HealthCheckup.WinFormsUI.Properties;

namespace SUTH.HealthCheckup.WinFormsUI.Controllers
{
    partial class CheckupPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckupPersonal));
            panel1 = new Panel();
            lblClose = new Label();
            lblTitleName = new Label();
            panel2 = new Panel();
            grdData = new DevExpress.XtraGrid.GridControl();
            gridViewData = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumnStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            colPrint = new DevExpress.XtraGrid.Columns.GridColumn();
            chkPrint = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            GridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            GridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            GridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            GridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            colDoctorPE = new DevExpress.XtraGrid.Columns.GridColumn();
            colDoctorResult = new DevExpress.XtraGrid.Columns.GridColumn();
            GridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            pnButton = new DevExpress.XtraEditors.PanelControl();
            panel3 = new Panel();
            cmdClose = new DevExpress.XtraEditors.SimpleButton();
            progressLoad = new DevExpress.XtraWaitForm.ProgressPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkPrint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnButton).BeginInit();
            pnButton.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 56, 148);
            panel1.Controls.Add(lblClose);
            panel1.Controls.Add(lblTitleName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 40);
            panel1.TabIndex = 7;
            // 
            // lblClose
            // 
            lblClose.BackColor = Color.Transparent;
            lblClose.Dock = DockStyle.Right;
            lblClose.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 222);
            lblClose.ForeColor = Color.White;
            lblClose.Location = new Point(978, 0);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(32, 40);
            lblClose.TabIndex = 2;
            lblClose.Text = "X";
            lblClose.TextAlign = ContentAlignment.MiddleCenter;
            lblClose.Click += lblClose_Click;
            lblClose.MouseHover += lblClose_MouseHover;
            // 
            // lblTitleName
            // 
            lblTitleName.AutoSize = true;
            lblTitleName.BackColor = Color.Transparent;
            lblTitleName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitleName.ForeColor = Color.White;
            lblTitleName.Location = new Point(5, 5);
            lblTitleName.Name = "lblTitleName";
            lblTitleName.Size = new Size(196, 25);
            lblTitleName.TabIndex = 1;
            lblTitleName.Text = "รายการตรวจสุขภาพ : ";
            // 
            // panel2
            // 
            panel2.Controls.Add(grdData);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(1010, 556);
            panel2.TabIndex = 8;
            // 
            // grdData
            // 
            grdData.Dock = DockStyle.Fill;
            grdData.EmbeddedNavigator.Margin = new Padding(4);
            grdData.Location = new Point(0, 0);
            grdData.LookAndFeel.SkinName = "Blue";
            grdData.LookAndFeel.UseDefaultLookAndFeel = false;
            grdData.MainView = gridViewData;
            grdData.Margin = new Padding(0);
            grdData.Name = "grdData";
            grdData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemCheckEdit1, chkPrint });
            grdData.Size = new Size(1010, 556);
            grdData.TabIndex = 4;
            grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewData });
            grdData.DoubleClick += grdData_DoubleClick;
            // 
            // gridViewData
            // 
            gridViewData.Appearance.FocusedRow.BackColor = SystemColors.HotTrack;
            gridViewData.Appearance.FocusedRow.Font = new Font("Segoe UI", 9.5F);
            gridViewData.Appearance.FocusedRow.ForeColor = Color.White;
            gridViewData.Appearance.FocusedRow.Options.UseBackColor = true;
            gridViewData.Appearance.FocusedRow.Options.UseFont = true;
            gridViewData.Appearance.FocusedRow.Options.UseForeColor = true;
            gridViewData.Appearance.HeaderPanel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gridViewData.Appearance.HeaderPanel.ForeColor = Color.FromArgb(27, 41, 62);
            gridViewData.Appearance.HeaderPanel.Options.UseFont = true;
            gridViewData.Appearance.HeaderPanel.Options.UseForeColor = true;
            gridViewData.Appearance.HeaderPanel.Options.UseTextOptions = true;
            gridViewData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewData.Appearance.Row.Font = new Font("Segoe UI", 9.5F);
            gridViewData.Appearance.Row.Options.UseFont = true;
            gridViewData.Appearance.Row.Options.UseTextOptions = true;
            gridViewData.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridViewData.Appearance.SelectedRow.BackColor = SystemColors.HotTrack;
            gridViewData.Appearance.SelectedRow.Font = new Font("Segoe UI", 9.5F);
            gridViewData.Appearance.SelectedRow.ForeColor = Color.White;
            gridViewData.Appearance.SelectedRow.Options.UseBackColor = true;
            gridViewData.Appearance.SelectedRow.Options.UseFont = true;
            gridViewData.Appearance.SelectedRow.Options.UseForeColor = true;
            gridViewData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            gridViewData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumnStatus, colPrint, GridColumn7, GridColumn1, GridColumn3, GridColumn4, GridColumn5, GridColumn6, gridColumn11, GridColumn8, GridColumn9, colDoctorPE, colDoctorResult, GridColumn10, gridColumn2, gridColumn12 });
            gridViewData.GridControl = grdData;
            gridViewData.Name = "gridViewData";
            gridViewData.OptionsBehavior.Editable = false;
            gridViewData.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridViewData.OptionsSelection.EnableAppearanceHideSelection = false;
            gridViewData.OptionsView.ShowGroupPanel = false;
            gridViewData.OptionsView.ShowIndicator = false;
            gridViewData.RowStyle += gridViewData_RowStyle;
            gridViewData.MouseDown += gridViewData_MouseDown;
            gridViewData.MouseMove += gridViewData_MouseMove;
            // 
            // gridColumnStatus
            // 
            gridColumnStatus.Caption = " ";
            gridColumnStatus.ColumnEdit = repositoryItemCheckEdit1;
            gridColumnStatus.FieldName = "CurrentStatus";
            gridColumnStatus.Name = "gridColumnStatus";
            gridColumnStatus.Visible = true;
            gridColumnStatus.VisibleIndex = 0;
            gridColumnStatus.Width = 20;
            // 
            // repositoryItemCheckEdit1
            // 
            repositoryItemCheckEdit1.AutoHeight = false;
            repositoryItemCheckEdit1.AutoWidth = true;
            repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            repositoryItemCheckEdit1.ImageOptions.ImageChecked = Resources.star_orange;
            repositoryItemCheckEdit1.ImageOptions.ImageGrayed = Resources.star_blue;
            repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            repositoryItemCheckEdit1.ValueChecked = "Finalized";
            repositoryItemCheckEdit1.ValueGrayed = "Submited";
            repositoryItemCheckEdit1.ValueUnchecked = "";
            // 
            // colPrint
            // 
            colPrint.ColumnEdit = chkPrint;
            colPrint.FieldName = "isReview";
            colPrint.Name = "colPrint";
            colPrint.OptionsColumn.ShowCaption = false;
            colPrint.Visible = true;
            colPrint.VisibleIndex = 1;
            colPrint.Width = 20;
            // 
            // chkPrint
            // 
            chkPrint.AutoHeight = false;
            chkPrint.AutoWidth = true;
            chkPrint.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            chkPrint.ImageOptions.ImageChecked = Resources.printer_16x16;
            chkPrint.Name = "chkPrint";
            chkPrint.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            chkPrint.ValueChecked = "Y";
            chkPrint.ValueUnchecked = "N";
            // 
            // GridColumn7
            // 
            GridColumn7.Caption = "Visit Date";
            GridColumn7.FieldName = "VisitDate";
            GridColumn7.Name = "GridColumn7";
            GridColumn7.Visible = true;
            GridColumn7.VisibleIndex = 2;
            GridColumn7.Width = 47;
            // 
            // GridColumn1
            // 
            GridColumn1.Caption = "H.N.";
            GridColumn1.FieldName = "PatientID";
            GridColumn1.Name = "GridColumn1";
            GridColumn1.Width = 67;
            // 
            // GridColumn3
            // 
            GridColumn3.AppearanceCell.Options.UseTextOptions = true;
            GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            GridColumn3.Caption = "Name";
            GridColumn3.FieldName = "PatientName";
            GridColumn3.Name = "GridColumn3";
            GridColumn3.Visible = true;
            GridColumn3.VisibleIndex = 3;
            GridColumn3.Width = 115;
            // 
            // GridColumn4
            // 
            GridColumn4.Caption = "Age";
            GridColumn4.FieldName = "Age";
            GridColumn4.Name = "GridColumn4";
            GridColumn4.Visible = true;
            GridColumn4.VisibleIndex = 4;
            GridColumn4.Width = 25;
            // 
            // GridColumn5
            // 
            GridColumn5.Caption = "Sex";
            GridColumn5.FieldName = "Sex";
            GridColumn5.Name = "GridColumn5";
            GridColumn5.Visible = true;
            GridColumn5.VisibleIndex = 5;
            GridColumn5.Width = 35;
            // 
            // GridColumn6
            // 
            GridColumn6.AppearanceCell.Options.UseTextOptions = true;
            GridColumn6.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            GridColumn6.Caption = "Payor";
            GridColumn6.FieldName = "PayorName";
            GridColumn6.Name = "GridColumn6";
            GridColumn6.Visible = true;
            GridColumn6.VisibleIndex = 6;
            GridColumn6.Width = 112;
            // 
            // gridColumn11
            // 
            gridColumn11.Caption = "Current Status";
            gridColumn11.FieldName = "CurrentStatus";
            gridColumn11.Name = "gridColumn11";
            gridColumn11.Visible = true;
            gridColumn11.VisibleIndex = 7;
            gridColumn11.Width = 65;
            // 
            // GridColumn8
            // 
            GridColumn8.Caption = "Save Date";
            GridColumn8.FieldName = "SaveDTTM";
            GridColumn8.Name = "GridColumn8";
            GridColumn8.Visible = true;
            GridColumn8.VisibleIndex = 8;
            GridColumn8.Width = 51;
            // 
            // GridColumn9
            // 
            GridColumn9.Caption = "Finalized Date";
            GridColumn9.FieldName = "FinalDTTM";
            GridColumn9.Name = "GridColumn9";
            GridColumn9.Visible = true;
            GridColumn9.VisibleIndex = 9;
            GridColumn9.Width = 42;
            // 
            // colDoctorPE
            // 
            colDoctorPE.Caption = "Doctor P.E.";
            colDoctorPE.FieldName = "CareproviderName";
            colDoctorPE.Name = "colDoctorPE";
            colDoctorPE.Visible = true;
            colDoctorPE.VisibleIndex = 10;
            colDoctorPE.Width = 112;
            // 
            // colDoctorResult
            // 
            colDoctorResult.Caption = "Doctor Conclusion";
            colDoctorResult.FieldName = "DoctorResult";
            colDoctorResult.Name = "colDoctorResult";
            colDoctorResult.Visible = true;
            colDoctorResult.VisibleIndex = 11;
            colDoctorResult.Width = 112;
            // 
            // GridColumn10
            // 
            GridColumn10.Caption = "V.N.";
            GridColumn10.FieldName = "VisitNumber";
            GridColumn10.Name = "GridColumn10";
            GridColumn10.Width = 38;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Lab Status";
            gridColumn2.FieldName = "LabResultStatus";
            gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn12
            // 
            gridColumn12.Caption = "Radiology Status";
            gridColumn12.FieldName = "RadiologyResultStatus";
            gridColumn12.Name = "gridColumn12";
            // 
            // pnButton
            // 
            pnButton.Appearance.BackColor = SystemColors.ActiveCaption;
            pnButton.Appearance.Options.UseBackColor = true;
            pnButton.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pnButton.Controls.Add(panel3);
            pnButton.Dock = DockStyle.Bottom;
            pnButton.Location = new Point(0, 596);
            pnButton.LookAndFeel.SkinName = "Office 2010 Blue";
            pnButton.LookAndFeel.UseDefaultLookAndFeel = false;
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(1010, 40);
            pnButton.TabIndex = 111;
            // 
            // panel3
            // 
            panel3.Controls.Add(cmdClose);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(855, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 40);
            panel3.TabIndex = 15;
            // 
            // cmdClose
            // 
            cmdClose.Appearance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cmdClose.Appearance.ForeColor = Color.White;
            cmdClose.Appearance.Options.UseFont = true;
            cmdClose.Appearance.Options.UseForeColor = true;
            cmdClose.ImageOptions.Image = (Image)resources.GetObject("cmdClose.ImageOptions.Image");
            cmdClose.Location = new Point(50, 5);
            cmdClose.LookAndFeel.SkinMaskColor = SystemColors.ActiveCaption;
            cmdClose.LookAndFeel.SkinName = "DevExpress Dark Style";
            cmdClose.LookAndFeel.UseDefaultLookAndFeel = false;
            cmdClose.Name = "cmdClose";
            cmdClose.Size = new Size(93, 27);
            cmdClose.TabIndex = 14;
            cmdClose.Text = "Close";
            cmdClose.Click += cmdClose_Click;
            // 
            // progressLoad
            // 
            progressLoad.Appearance.BackColor = Color.Transparent;
            progressLoad.Appearance.Options.UseBackColor = true;
            progressLoad.AppearanceCaption.ForeColor = Color.Black;
            progressLoad.AppearanceCaption.Options.UseForeColor = true;
            progressLoad.AppearanceDescription.ForeColor = Color.Black;
            progressLoad.AppearanceDescription.Options.UseForeColor = true;
            progressLoad.Location = new Point(413, 287);
            progressLoad.LookAndFeel.SkinName = "McSkin";
            progressLoad.LookAndFeel.UseDefaultLookAndFeel = false;
            progressLoad.Name = "progressLoad";
            progressLoad.Padding = new Padding(10);
            progressLoad.Size = new Size(185, 62);
            progressLoad.TabIndex = 112;
            // 
            // frmCheckupPersonal
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 636);
            Controls.Add(progressLoad);
            Controls.Add(panel2);
            Controls.Add(pnButton);
            Controls.Add(panel1);
            Name = "frmCheckupPersonal";
            Text = "รายการตรวจสุขภาพส่วนบุคคล";
            Load += frmCheckupPersonal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdData).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewData).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemCheckEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkPrint).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnButton).EndInit();
            pnButton.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblTitleName;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.PanelControl pnButton;
        private System.Windows.Forms.Panel panel3;
        internal DevExpress.XtraEditors.SimpleButton cmdClose;
        private DevExpress.XtraGrid.GridControl grdData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrint;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkPrint;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn4;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn5;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn6;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn8;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn colDoctorPE;
        private DevExpress.XtraGrid.Columns.GridColumn colDoctorResult;
        internal DevExpress.XtraGrid.Columns.GridColumn GridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraWaitForm.ProgressPanel progressLoad;
    }
}
