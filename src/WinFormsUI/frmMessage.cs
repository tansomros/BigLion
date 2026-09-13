using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUTH.Checkup.WinFormsUI
{
    public partial class frmMessage : Form
    {
        public frmMessage(string message, MessageBoxIcon _MessageBoxIcon)
        {
            InitializeComponent();

            lblMessage.Text = message;

            if (_MessageBoxIcon == MessageBoxIcon.Error)
                pictureBox1.Image = imageList1.Images[0];
            else if (_MessageBoxIcon == MessageBoxIcon.Warning)
                pictureBox1.Image = imageList1.Images[1];
            else
                pictureBox1.Image = imageList1.Images[2];
        }
        public frmMessage(string message, MessageBoxButtons buttons, MessageBoxIcon _MessageBoxIcon)
        {
            InitializeComponent();

            lblMessage.Text = message;

            if (buttons == MessageBoxButtons.OK)
                btOK.Visible = true;
            else
            {
                btOK.Visible = false;
                btYes.Visible = true;
                btCancel.Visible = true;
            }

            if (_MessageBoxIcon == MessageBoxIcon.Error)
                pictureBox1.Image = imageList1.Images[0];
            else if (_MessageBoxIcon == MessageBoxIcon.Warning)
                pictureBox1.Image = imageList1.Images[1];
            else
                pictureBox1.Image = imageList1.Images[2];
        }

        private void frmMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
