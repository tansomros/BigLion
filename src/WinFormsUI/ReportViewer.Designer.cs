namespace SUTH.HealthCheckup.WinFormsUI.Controllers
{
    partial class ReportViewer : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportViewer));
            this.groupControlMain = new DevExpress.XtraEditors.GroupControl();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.progressLoad = new DevExpress.XtraWaitForm.ProgressPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdClose = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMain)).BeginInit();
            this.groupControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControlMain
            // 
            this.groupControlMain.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupControlMain.AppearanceCaption.Options.UseFont = true;
            this.groupControlMain.Controls.Add(this.reportViewer1);
            this.groupControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlMain.Location = new System.Drawing.Point(0, 0);
            this.groupControlMain.LookAndFeel.SkinName = "Office 2010 Blue";
            this.groupControlMain.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControlMain.Name = "groupControlMain";
            this.groupControlMain.Size = new System.Drawing.Size(535, 278);
            this.groupControlMain.TabIndex = 2;
            this.groupControlMain.Text = "ใบรายงานผลการตรวจสุขภาพ";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(2, 25);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(531, 251);
            this.reportViewer1.TabIndex = 2;
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
            this.progressLoad.Location = new System.Drawing.Point(375, 95);
            this.progressLoad.LookAndFeel.SkinName = "McSkin";
            this.progressLoad.LookAndFeel.UseDefaultLookAndFeel = false;
            this.progressLoad.Name = "progressLoad";
            this.progressLoad.Padding = new System.Windows.Forms.Padding(50, 20, 20, 20);
            this.progressLoad.Size = new System.Drawing.Size(250, 74);
            this.progressLoad.TabIndex = 2;
            this.progressLoad.Text = "progressPanel1";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 278);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(535, 40);
            this.panelControl1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(407, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 40);
            this.panel1.TabIndex = 16;
            // 
            // cmdClose
            // 
            this.cmdClose.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cmdClose.Appearance.Options.UseFont = true;
            this.cmdClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("cmdClose.ImageOptions.Image")));
            this.cmdClose.Location = new System.Drawing.Point(32, 6);
            this.cmdClose.LookAndFeel.SkinMaskColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdClose.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.cmdClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(91, 27);
            this.cmdClose.TabIndex = 15;
            this.cmdClose.Text = "Close";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.groupControlMain);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(535, 278);
            this.panelControl2.TabIndex = 4;
            // 
            // frmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(535, 318);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.progressLoad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportViewer";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMain)).EndInit();
            this.groupControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlMain;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DevExpress.XtraWaitForm.ProgressPanel progressLoad;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Panel panel1;
        internal DevExpress.XtraEditors.SimpleButton cmdClose;

    }
}