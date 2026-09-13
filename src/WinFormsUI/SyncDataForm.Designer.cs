namespace SUTH.HealthCheckup.WinFormsUI
{
    partial class SyncDataForm
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
            panel1 = new Panel();
            LblSuccess = new Label();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            TxtHospitalNumber = new DevExpress.XtraEditors.TextEdit();
            Label3 = new Label();
            DtpEndDate = new DevExpress.XtraEditors.DateEdit();
            DtpStartDate = new DevExpress.XtraEditors.DateEdit();
            label6 = new Label();
            label2 = new Label();
            progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            label4 = new Label();
            btnSync = new DevExpress.XtraEditors.SimpleButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtHospitalNumber.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtpEndDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtpEndDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtpStartDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DtpStartDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(LblSuccess);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Tahoma", 9F);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 35);
            panel1.TabIndex = 0;
            // 
            // LblSuccess
            // 
            LblSuccess.AutoSize = true;
            LblSuccess.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            LblSuccess.Location = new Point(5, 5);
            LblSuccess.Name = "LblSuccess";
            LblSuccess.Size = new Size(137, 25);
            LblSuccess.TabIndex = 0;
            LblSuccess.Text = "Data Interface";
            // 
            // panelControl1
            // 
            panelControl1.Appearance.Font = new Font("Segoe UI", 10F);
            panelControl1.Appearance.Options.UseFont = true;
            panelControl1.Controls.Add(TxtHospitalNumber);
            panelControl1.Controls.Add(Label3);
            panelControl1.Controls.Add(DtpEndDate);
            panelControl1.Controls.Add(DtpStartDate);
            panelControl1.Controls.Add(label6);
            panelControl1.Controls.Add(label2);
            panelControl1.Controls.Add(progressBarControl1);
            panelControl1.Controls.Add(label4);
            panelControl1.Controls.Add(btnSync);
            panelControl1.Dock = DockStyle.Fill;
            panelControl1.Location = new Point(0, 35);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(337, 205);
            panelControl1.TabIndex = 1;
            // 
            // TxtHospitalNumber
            // 
            TxtHospitalNumber.Location = new Point(81, 97);
            TxtHospitalNumber.Name = "TxtHospitalNumber";
            TxtHospitalNumber.Properties.Appearance.Font = new Font("Prompt", 9.749999F);
            TxtHospitalNumber.Properties.Appearance.Options.UseFont = true;
            TxtHospitalNumber.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            TxtHospitalNumber.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            TxtHospitalNumber.Size = new Size(190, 26);
            TxtHospitalNumber.TabIndex = 9;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI", 10F);
            Label3.Location = new Point(24, 102);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(29, 19);
            Label3.TabIndex = 8;
            Label3.Text = "HN";
            // 
            // DtpEndDate
            // 
            DtpEndDate.EditValue = null;
            DtpEndDate.Location = new Point(81, 65);
            DtpEndDate.Name = "DtpEndDate";
            DtpEndDate.Properties.Appearance.Font = new Font("Segoe UI", 10.5F);
            DtpEndDate.Properties.Appearance.Options.UseFont = true;
            DtpEndDate.Properties.AppearanceCalendar.Button.Font = new Font("Prompt", 10F);
            DtpEndDate.Properties.AppearanceCalendar.Button.Options.UseFont = true;
            DtpEndDate.Properties.AppearanceCalendar.Header.Font = new Font("Prompt", 9.749999F);
            DtpEndDate.Properties.AppearanceCalendar.Header.Options.UseFont = true;
            DtpEndDate.Properties.AppearanceCalendar.WeekDay.Font = new Font("Prompt", 10F);
            DtpEndDate.Properties.AppearanceCalendar.WeekDay.Options.UseFont = true;
            DtpEndDate.Properties.AppearanceCalendar.WeekNumber.Font = new Font("Prompt", 10F);
            DtpEndDate.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = true;
            DtpEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DtpEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DtpEndDate.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            DtpEndDate.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            DtpEndDate.Size = new Size(190, 26);
            DtpEndDate.TabIndex = 21;
            // 
            // DtpStartDate
            // 
            DtpStartDate.EditValue = null;
            DtpStartDate.Location = new Point(81, 30);
            DtpStartDate.Name = "DtpStartDate";
            DtpStartDate.Properties.Appearance.Font = new Font("Segoe UI", 10.5F);
            DtpStartDate.Properties.Appearance.Options.UseFont = true;
            DtpStartDate.Properties.AppearanceCalendar.Button.Font = new Font("Prompt", 10F);
            DtpStartDate.Properties.AppearanceCalendar.Button.Options.UseFont = true;
            DtpStartDate.Properties.AppearanceCalendar.Header.Font = new Font("Prompt", 9.749999F);
            DtpStartDate.Properties.AppearanceCalendar.Header.Options.UseFont = true;
            DtpStartDate.Properties.AppearanceCalendar.WeekDay.Font = new Font("Prompt", 10F);
            DtpStartDate.Properties.AppearanceCalendar.WeekDay.Options.UseFont = true;
            DtpStartDate.Properties.AppearanceCalendar.WeekNumber.Font = new Font("Prompt", 10F);
            DtpStartDate.Properties.AppearanceCalendar.WeekNumber.Options.UseFont = true;
            DtpStartDate.Properties.AppearanceDropDown.Font = new Font("Prompt", 9F);
            DtpStartDate.Properties.AppearanceDropDown.Options.UseFont = true;
            DtpStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DtpStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            DtpStartDate.Properties.LookAndFeel.SkinName = "Office 2010 Blue";
            DtpStartDate.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            DtpStartDate.Size = new Size(190, 26);
            DtpStartDate.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(3, 68);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(65, 19);
            label6.TabIndex = 22;
            label6.Text = "End Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(3, 34);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 20;
            label2.Text = "Start Date";
            // 
            // progressBarControl1
            // 
            progressBarControl1.Location = new Point(3, 165);
            progressBarControl1.Name = "progressBarControl1";
            progressBarControl1.Properties.FlowAnimationEnabled = true;
            progressBarControl1.Properties.ShowTitle = true;
            progressBarControl1.Size = new Size(327, 32);
            progressBarControl1.TabIndex = 10;
            // 
            // label4
            // 
            label4.BackColor = Color.Gold;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(2, 2);
            label4.Name = "label4";
            label4.Size = new Size(333, 25);
            label4.TabIndex = 5;
            label4.Text = "ถ้าไม่ระบุ HN จะดึงข้อมูลทั้งหมดตามวันที่";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSync
            // 
            btnSync.Appearance.Font = new Font("Tahoma", 10F);
            btnSync.Appearance.ForeColor = Color.White;
            btnSync.Appearance.Options.UseFont = true;
            btnSync.Appearance.Options.UseForeColor = true;
            btnSync.Location = new Point(123, 129);
            btnSync.LookAndFeel.SkinMaskColor = SystemColors.HotTrack;
            btnSync.LookAndFeel.SkinName = "DevExpress Dark Style";
            btnSync.LookAndFeel.UseDefaultLookAndFeel = false;
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(89, 30);
            btnSync.TabIndex = 3;
            btnSync.Text = "Sync";
            btnSync.Click += btnSync_Click;
            // 
            // SyncDataForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 240);
            Controls.Add(panelControl1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            LookAndFeel.SkinName = "VS2010";
            LookAndFeel.UseDefaultLookAndFeel = false;
            Name = "SyncDataForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Data interface";
            Load += SyncDataForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TxtHospitalNumber.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtpEndDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtpEndDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtpStartDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)DtpStartDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)progressBarControl1.Properties).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label LblSuccess;
        private DevExpress.XtraEditors.SimpleButton btnSync;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        internal DevExpress.XtraEditors.DateEdit DtpEndDate;
        internal DevExpress.XtraEditors.DateEdit DtpStartDate;
        internal Label label6;
        internal Label label2;
        internal DevExpress.XtraEditors.TextEdit TxtHospitalNumber;
        internal Label Label3;
    }
}
