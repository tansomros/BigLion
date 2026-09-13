using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SUTH.Checkup.WinFormsUI.Controllers;
using SUTH.Checkup.Models;


namespace SUTH.Checkup.WinFormsUI.Controllers
{
    public partial class frmUserAuthorize : DevExpress.XtraEditors.XtraForm
    {
            UserController ctlUser = new UserController();

        public frmUserAuthorize()
        {
            InitializeComponent();
        }

        private void frmUserAuthorize_Load(object sender, EventArgs e)
        {
            txtComment.Focus();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                GetConfirmed();
            }
        }

        private void GetConfirmed()
        {
            BEL.UserDetails objLogin = new BEL.UserDetails();
       
            objLogin._usercode = txtUsername.Text;
            objLogin._Password = CryptographyEngine.EncryptString(txtPassword.Text, true);
            try
            {
               
                BaseGlobalClass.UserAuthorized = false;

                DataTable dtLogin = ctlUser.User_CheckLogin(objLogin._usercode,objLogin._Password);
                if (dtLogin.Rows.Count == 0)
                {
                    MessageBox.Show("Username or Password doesn't match", "Error Authorization");
                }
                else
                {
                    ctlUser.User_ReasonFinalSave( BaseGlobalClass.gPatientUID , BaseGlobalClass.gPatientVisitUID, DataHelper.usercode, txtComment.Text);

                    BaseGlobalClass.UserAuthorized = true;
                    this.Close(); 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            GetConfirmed();
        }
    }
}
