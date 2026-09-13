namespace SUTH.HealthCheckup.WinFormsUI.Forms
{
    partial class MessageBox
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBox));
            btOK = new DevExpress.XtraEditors.SimpleButton();
            imageList1 = new ImageList(components);
            picSuccess = new PictureBox();
            picError = new PictureBox();
            lblMessageTitle = new Label();
            lblMessageDetail = new Label();
            btYes = new DevExpress.XtraEditors.SimpleButton();
            btNo = new DevExpress.XtraEditors.SimpleButton();
            btCancel = new DevExpress.XtraEditors.SimpleButton();
            panel1 = new Panel();
            txtMessageDetail = new WeraControls.Controls.WeraTextBox();
            bunifuElipse1 = new WeraControls.Controls.WeraElipse();
            ((System.ComponentModel.ISupportInitialize)picSuccess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picError).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btOK
            // 
            btOK.Anchor = AnchorStyles.Top;
            btOK.Appearance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btOK.Appearance.Options.UseFont = true;
            btOK.Cursor = Cursors.Hand;
            btOK.DialogResult = DialogResult.OK;
            btOK.Location = new Point(211, 253);
            btOK.LookAndFeel.SkinName = "WXI";
            btOK.LookAndFeel.UseDefaultLookAndFeel = false;
            btOK.Margin = new Padding(1);
            btOK.Name = "btOK";
            btOK.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            btOK.Size = new Size(89, 35);
            btOK.TabIndex = 0;
            btOK.Text = "OK";
            btOK.Click += btOK_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Error.png");
            imageList1.Images.SetKeyName(1, "Warning.png");
            imageList1.Images.SetKeyName(2, "Info.png");
            imageList1.Images.SetKeyName(3, "ConfirmDialog.png");
            // 
            // picSuccess
            // 
            picSuccess.Anchor = AnchorStyles.Top;
            picSuccess.BackColor = Color.Transparent;
            picSuccess.Image = (Image)resources.GetObject("picSuccess.Image");
            picSuccess.Location = new Point(171, 13);
            picSuccess.Name = "picSuccess";
            picSuccess.Size = new Size(169, 169);
            picSuccess.SizeMode = PictureBoxSizeMode.StretchImage;
            picSuccess.TabIndex = 2;
            picSuccess.TabStop = false;
            picSuccess.Visible = false;
            // 
            // picError
            // 
            picError.Anchor = AnchorStyles.Top;
            picError.Image = (Image)resources.GetObject("picError.Image");
            picError.Location = new Point(215, 23);
            picError.Name = "picError";
            picError.Size = new Size(80, 80);
            picError.SizeMode = PictureBoxSizeMode.AutoSize;
            picError.TabIndex = 3;
            picError.TabStop = false;
            // 
            // lblMessageTitle
            // 
            lblMessageTitle.Anchor = AnchorStyles.Top;
            lblMessageTitle.Font = new Font("Sarabun", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessageTitle.ForeColor = Color.FromArgb(255, 193, 7);
            lblMessageTitle.Location = new Point(171, 106);
            lblMessageTitle.Name = "lblMessageTitle";
            lblMessageTitle.Size = new Size(169, 47);
            lblMessageTitle.TabIndex = 4;
            lblMessageTitle.Text = "Warning";
            lblMessageTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMessageDetail
            // 
            lblMessageDetail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMessageDetail.BackColor = Color.Transparent;
            lblMessageDetail.Font = new Font("Sarabun", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessageDetail.ForeColor = Color.FromArgb(64, 64, 64);
            lblMessageDetail.Location = new Point(12, 160);
            lblMessageDetail.Name = "lblMessageDetail";
            lblMessageDetail.Size = new Size(486, 85);
            lblMessageDetail.TabIndex = 5;
            lblMessageDetail.Text = "Detail";
            lblMessageDetail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btYes
            // 
            btYes.Appearance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btYes.Appearance.ForeColor = Color.Black;
            btYes.Appearance.Options.UseFont = true;
            btYes.Appearance.Options.UseForeColor = true;
            btYes.Cursor = Cursors.Hand;
            btYes.DialogResult = DialogResult.Yes;
            btYes.Location = new Point(1, 1);
            btYes.LookAndFeel.SkinName = "WXI";
            btYes.LookAndFeel.UseDefaultLookAndFeel = false;
            btYes.Margin = new Padding(1);
            btYes.Name = "btYes";
            btYes.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            btYes.Size = new Size(89, 35);
            btYes.TabIndex = 6;
            btYes.Text = "Yes";
            btYes.Visible = false;
            // 
            // btNo
            // 
            btNo.Appearance.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btNo.Appearance.ForeColor = Color.White;
            btNo.Appearance.Options.UseFont = true;
            btNo.Appearance.Options.UseForeColor = true;
            btNo.Cursor = Cursors.Hand;
            btNo.DialogResult = DialogResult.No;
            btNo.Location = new Point(93, 1);
            btNo.Margin = new Padding(1);
            btNo.Name = "btNo";
            btNo.Size = new Size(89, 35);
            btNo.TabIndex = 7;
            btNo.Visible = false;
            // 
            // btCancel
            // 
            btCancel.Appearance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btCancel.Appearance.ForeColor = Color.Black;
            btCancel.Appearance.Options.UseFont = true;
            btCancel.Appearance.Options.UseForeColor = true;
            btCancel.Cursor = Cursors.Hand;
            btCancel.DialogResult = DialogResult.Cancel;
            btCancel.Location = new Point(185, 1);
            btCancel.LookAndFeel.SkinName = "WXI";
            btCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            btCancel.Margin = new Padding(1);
            btCancel.Name = "btCancel";
            btCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            btCancel.Size = new Size(89, 35);
            btCancel.TabIndex = 8;
            btCancel.Text = "Cancel";
            btCancel.Visible = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.AutoSize = true;
            panel1.Controls.Add(btCancel);
            panel1.Controls.Add(btYes);
            panel1.Controls.Add(btNo);
            panel1.Location = new Point(118, 252);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 37);
            panel1.TabIndex = 10;
            // 
            // txtMessageDetail
            // 
            txtMessageDetail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMessageDetail.BackColor = SystemColors.Window;
            txtMessageDetail.BorderColor = Color.Silver;
            txtMessageDetail.BorderFocusColor = Color.DodgerBlue;
            txtMessageDetail.BorderRadius = 0;
            txtMessageDetail.BorderSize = 1;
            txtMessageDetail.Cursor = Cursors.IBeam;
            txtMessageDetail.FocusBackColor = Color.Empty;
            txtMessageDetail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMessageDetail.ForeColor = Color.FromArgb(64, 64, 64);
            txtMessageDetail.Location = new Point(12, 160);
            txtMessageDetail.Multiline = false;
            txtMessageDetail.Name = "txtMessageDetail";
            txtMessageDetail.Padding = new Padding(10, 7, 10, 7);
            txtMessageDetail.PlaceholderColor = Color.DarkGray;
            txtMessageDetail.PlaceholderText = "";
            txtMessageDetail.Size = new Size(486, 32);
            txtMessageDetail.TabIndex = 12;
            txtMessageDetail.TextAlign = HorizontalAlignment.Left;
            txtMessageDetail.Texts = "";
            txtMessageDetail.UnderlinedStyle = false;
            txtMessageDetail.UseSystemPasswordChar = false;
            txtMessageDetail.Visible = false;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.CornerRadius = 10;
            bunifuElipse1.TargetControl = this;
            // 
            // MessageBox
            // 
            Appearance.BackColor = Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 300);
            Controls.Add(txtMessageDetail);
            Controls.Add(lblMessageTitle);
            Controls.Add(btOK);
            Controls.Add(panel1);
            Controls.Add(lblMessageDetail);
            Controls.Add(picError);
            Controls.Add(picSuccess);
            Font = new Font("Segoe UI", 8.25F);
            FormBorderStyle = FormBorderStyle.None;
            IconOptions.ShowIcon = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MessageBox";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
            Load += MessageBox_Load;
            Shown += MessageBox_Shown;
            ((System.ComponentModel.ISupportInitialize)picSuccess).EndInit();
            ((System.ComponentModel.ISupportInitialize)picError).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btOK;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picSuccess;
        private System.Windows.Forms.PictureBox picError;
        private System.Windows.Forms.Label lblMessageTitle;
        private System.Windows.Forms.Label lblMessageDetail;
        private DevExpress.XtraEditors.SimpleButton btYes;
        private DevExpress.XtraEditors.SimpleButton btNo;
        //private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        private System.Windows.Forms.Panel panel1;
        private WeraControls.Controls.WeraTextBox txtMessageDetail;
        private WeraControls.Controls.WeraElipse bunifuElipse1;
    }
}
