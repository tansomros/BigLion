using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SUTH.HealthCheckup.WinFormsUI.Functions;

namespace SUTH.HealthCheckup.WinFormsUI.Controllers
{
    public partial class ReportMenu : Form
    {
        public ReportMenu()
        {
            InitializeComponent();
        }

        private void frmReportMenu_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void LoadForm()
        {
            ReportCondition floan = new ReportCondition();
            floan.MdiParent = this.MdiParent;
            floan.Show();
        }
        private void cmdResultSummaryByDate_Click(object sender, EventArgs e)
        {
            GlobalVariables.Reportskey = "SUM1";
            LoadForm();
        }

        private void cmdResultByItem_Click(object sender, EventArgs e)
        {
            GlobalVariables.Reportskey = "RPT1";
            LoadForm();
       
        }

        private void cmdReport3_Click(object sender, EventArgs e)
        {
            GlobalVariables.Reportskey = "RPT2";
            LoadForm();
        }

        private void cmdReportPayor_Click(object sender, EventArgs e)
        {
            GlobalVariables.Reportskey = "RPT6";
            LoadForm();
        }

        private void cmdReportDoctor_Click(object sender, EventArgs e)
        {
            GlobalVariables.Reportskey = "RPT8";
            
        }

        private void cmdReportEmployee_Click(object sender, EventArgs e)
        {
            GlobalVariables.Reportskey = "RPT5";
            LoadForm();
        }

        private void cmdReportNewStudent_Click(object sender, EventArgs e)
        {
            GlobalVariables.Reportskey = "RPT7";
          
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            GlobalVariables.Reportskey = "FN1";
            LoadForm();
        }

        private void lblClose_MouseHover(object sender, EventArgs e)
        {
            lblClose.BackColor = Color.Maroon;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
