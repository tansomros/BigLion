using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUTH.HealthCheckup.WinFormsUI.Forms
{
    public partial class InputBox : Form
    {

        public string result { get; set; } 
        string caption { get; set; }
        public InputBox(string _caption)
        {
            InitializeComponent();
            caption = _caption;
        }

        private void InputBox_Load(object sender, EventArgs e)
        {
            lblCaption.Text = caption;
            txtData.Text = result;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            result = txtData.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtData_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }

        private void InputBox_Shown(object sender, EventArgs e)
        {
            txtData.Focus();
        }
    }
}
