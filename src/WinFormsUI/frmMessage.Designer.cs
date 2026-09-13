namespace SUTH.Checkup.WinFormsUI
{
    partial class frmMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessage));
            lblMessage = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btOK = new Button();
            btYes = new Button();
            btCancel = new Button();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMessage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.FromArgb(64, 64, 64);
            lblMessage.Location = new Point(4, 134);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(440, 58);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Message";
            lblMessage.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(176, 14);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btOK);
            panel1.Controls.Add(btYes);
            panel1.Controls.Add(btCancel);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblMessage);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 257);
            panel1.TabIndex = 3;
            // 
            // btOK
            // 
            btOK.Anchor = AnchorStyles.Bottom;
            btOK.BackColor = Color.WhiteSmoke;
            btOK.DialogResult = DialogResult.OK;
            btOK.FlatAppearance.BorderColor = Color.Silver;
            btOK.FlatStyle = FlatStyle.Flat;
            btOK.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btOK.ForeColor = Color.FromArgb(64, 64, 64);
            btOK.Location = new Point(180, 211);
            btOK.Margin = new Padding(4, 3, 4, 3);
            btOK.Name = "btOK";
            btOK.Size = new Size(88, 32);
            btOK.TabIndex = 3;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = false;
            // 
            // btYes
            // 
            btYes.Anchor = AnchorStyles.Bottom;
            btYes.BackColor = Color.WhiteSmoke;
            btYes.DialogResult = DialogResult.Yes;
            btYes.FlatAppearance.BorderColor = Color.LightGray;
            btYes.FlatStyle = FlatStyle.Flat;
            btYes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btYes.ForeColor = Color.FromArgb(64, 64, 64);
            btYes.Location = new Point(131, 211);
            btYes.Margin = new Padding(4, 3, 4, 3);
            btYes.Name = "btYes";
            btYes.Size = new Size(88, 32);
            btYes.TabIndex = 5;
            btYes.Text = "Yes";
            btYes.UseVisualStyleBackColor = false;
            btYes.Visible = false;
            // 
            // btCancel
            // 
            btCancel.Anchor = AnchorStyles.Bottom;
            btCancel.BackColor = Color.WhiteSmoke;
            btCancel.DialogResult = DialogResult.Cancel;
            btCancel.FlatAppearance.BorderColor = Color.Silver;
            btCancel.FlatStyle = FlatStyle.Flat;
            btCancel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btCancel.ForeColor = Color.FromArgb(64, 64, 64);
            btCancel.Location = new Point(229, 211);
            btCancel.Margin = new Padding(4, 3, 4, 3);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(88, 32);
            btCancel.TabIndex = 4;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = false;
            btCancel.Visible = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Cancel_80px.png");
            imageList1.Images.SetKeyName(1, "Error_80px.png");
            imageList1.Images.SetKeyName(2, "Ok_80px.png");
            // 
            // frmMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(447, 257);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMessage";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Message Box";
            Load += frmMessage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btYes;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.ImageList imageList1;
    }
}
