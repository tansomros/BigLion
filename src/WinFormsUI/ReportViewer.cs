using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;
using SUTH.HealthCheckup.WinFormsUI.Functions;
using SUTH.HealthCheckup.WinFormsUI.Controllers;

namespace SUTH.HealthCheckup.WinFormsUI.Controllers
{
    public partial class ReportViewer : Form
    {      

        public ReportViewer()
        {
            InitializeComponent();
        }
         
        string sReportName; 
        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            progressLoad.Visible = true;
            LoadReport();
            this.TopMost = true;

        }
              
        private void LoadReport()
        {

            try
            {

            this.reportViewer1.RefreshReport();

            GlobalVariables.FagRPT = "CHKLIST";

            switch (GlobalVariables.Reportskey)
            {
                    case "COVER":
                        sReportName = "CheckUpReportBook_Cover";
                        this.Text = "ปกสมุดรายงานผลการตรวจสุขภาพ";
                        groupControlMain.Text = "ปกสมุดรายงานผลการตรวจสุขภาพ";                      
                        break;
                    case "CHKUPCOVER":
                        sReportName = "CheckUpReportBook_CoverPatient";
                        this.Text = "ปกสมุดรายงานผลการตรวจสุขภาพ";
                        groupControlMain.Text = "ปกสมุดรายงานผลการตรวจสุขภาพ";
                        break;
                    case "CHKUPBOOK":
                        sReportName = "CheckUpReportBook";
                        this.Text = "รายงานผลการตรวจสุขภาพ";
                        groupControlMain.Text = "รายงานผลการตรวจสุขภาพ";
                        break;
                    case "CHKUPOLD":
                        sReportName = "CheckUpReportTH";
                        this.Text = "รายงานผลการตรวจสุขภาพ";
                        groupControlMain.Text = "รายงานผลการตรวจสุขภาพ";
                        break;
                    case "CHKUP2019":
                        sReportName = "CheckUpReportTH2019";
                        this.Text = "รายงานผลการตรวจสุขภาพ";
                        groupControlMain.Text = "รายงานผลการตรวจสุขภาพ";
                        break;
                }



            reportViewer1.Reset();
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            
            //reportViewer1.ZoomMode = ZoomMode.PageWidth;

            //ReportServerCredentials credential = new ReportServerCredentials();

            //reportViewer1.ServerReport.ReportServerUrl = credential.ReportServerUrl();
            //reportViewer1.ServerReport.ReportPath = credential.ReportCheckUpPath(this.sReportName);

            reportViewer1.ShowPrintButton = true;
            reportViewer1.ShowParameterPrompts = false;

            //'System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("th-TH")

            ArrayList reportParam = new ArrayList();
            reportParam = ReportDefaultPatam();

            ReportParameter[] param = new ReportParameter[reportParam.Count];
            for (int k = 0; k < reportParam.Count; k++)
            {
                param[k] = (ReportParameter)reportParam[k];
            }

            //reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = credential.NetworkCredentials;
            reportViewer1.ServerReport.SetParameters(param);

            if (GlobalVariables.RPTMODE == "XLS")
            {
                string mimeType;
                string encoding;
                string extension;
                string[] streams;
                Warning[] warnings;
                byte[] pdfBytes = reportViewer1.ServerReport.Render("EXCEL", string.Empty, out mimeType,
                    out encoding, out extension, out streams, out warnings);

                // save the file
                //Convert.ToString("attachment; filename=" + GlobalVariables.ReportName + "_" + GlobalFunctions.ConvertDateToString(DateTime.Now.Date) + "." + extension)
                string outputPath = "C:/Temp/" + this.sReportName +  ".xls";

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel WorkBook|*.xls";
                saveFileDialog1.Title = "Save an Excel File";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    outputPath = saveFileDialog1.FileName;

                    using (FileStream fs = new FileStream(outputPath, FileMode.Create))
                    {
                        fs.Write(pdfBytes, 0, pdfBytes.Length);
                        fs.Close();
                    }

                }
                this.Close();

            }
            else
            {
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                if (GlobalVariables.Reportskey== "CHKUPCOVER")
                    {
                        reportViewer1.ZoomMode = ZoomMode.FullPage;
                    }
                else
                    {
                        reportViewer1.ZoomMode = ZoomMode.PageWidth;
                    } 
                reportViewer1.RefreshReport();
            }

                 }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {              
                    progressLoad.Visible = false;               
            }

            progressLoad.Visible = false;
        }

        private ArrayList ReportDefaultPatam()
        {
            ArrayList arrLstDefaultParam = new ArrayList();     

            switch (GlobalVariables.Reportskey)
            {
                case "CHKUPCOVER":                  
                    arrLstDefaultParam.Add(new ReportParameter("P_PatientUID", GlobalVariables.gPatientUID.ToString()));
                    break;
                case "CHKUPBOOK":    
                    arrLstDefaultParam.Add(new ReportParameter("P_OrganisationUID", "2"));
                    arrLstDefaultParam.Add(new ReportParameter("P_PatientUID", GlobalVariables.gPatientUID.ToString()));
                    arrLstDefaultParam.Add(new ReportParameter("P_PatientVisitUID", GlobalVariables.gPatientVisitUID.ToString()));
                    break;
                case "CHKUPOLD":
                    arrLstDefaultParam.Add(new ReportParameter("P_OrganisationUID", "2"));
                    arrLstDefaultParam.Add(new ReportParameter("P_PatientUID", GlobalVariables.gPatientUID.ToString()));
                    arrLstDefaultParam.Add(new ReportParameter("P_PatientVisitUID", GlobalVariables.gPatientVisitUID.ToString()));
                    break;
                case "CHKUP2019":
                    arrLstDefaultParam.Add(new ReportParameter("P_OrganisationUID", "2"));
                    arrLstDefaultParam.Add(new ReportParameter("P_PatientUID", GlobalVariables.gPatientUID.ToString()));
                    arrLstDefaultParam.Add(new ReportParameter("P_PatientVisitUID", GlobalVariables.gPatientVisitUID.ToString()));
                    break;
                default:
                    break;

            }

            return arrLstDefaultParam;
        }
        private ReportParameter CreateReportParameter(string paramName, string pramValue)
        {
            ReportParameter aParam = new ReportParameter(paramName, pramValue);
            return aParam;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
