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
using MarkupConverter;
using SUTH.HealthCheckup.WinFormsUI.Functions;
using SUTH.HealthCheckup.WinFormsUI.Controllers;

namespace SUTH.HealthCheckup.WinFormsUI.Controllers
{
    public partial class CompareLayout : Form
    {
        public CompareLayout()
        {
            InitializeComponent();
        }

        //readonly ResultController  ctlR = new ResultController();
        //DataTable dtR = new DataTable();
        private void frmCompareLayout_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            //dtR = ctlR.Result_GetDetail(GlobalVariables.gResultComponentUID);
            //if (dtR.Rows.Count > 0)
            //{
            //    SaveResultTextual(dtR);

            //    this.Text = dtR.Rows[0].Field<string>("RequestItemName");
            //    //lblItemName.Text = dtR.Rows[0].Field<string>("RequestItemName");
            //    //lblReporter.Text = dtR.Rows[0].Field<string>("ReporterName");
            //    //lblResult.Text= ConvertRtfToText(ctlR.Result_GetTexttual(GlobalVariables.ResultConponentUID));

            //    this.reportViewer1.RefreshReport();
            //    //this.Text = GlobalVariables.ReportName;
            //    LoadReport(dtR);

            //}

            this.reportViewer1.RefreshReport();
        }

        private void LoadReport(DataTable dt)
        {
            //System.Threading.Thread.Sleep(1000)
            //UpdateProgress1.Visible = True

            string strHostName = System.Environment.MachineName;

            reportViewer1.Reset();
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;

            //ReportServerCredentials credential = new ReportServerCredentials();

            //reportViewer1.ServerReport.ReportServerUrl = credential.ReportServerUrl();

            //string reportName;
            //reportName = "RadiologyResultReport"; 
            //this.Text = "Result Report";
            //this.Text = "รายงานผลการวินิจฉัย";
     

            //switch (GlobalVariables.Reportskey)
            //{
            //    case "Doctor":
            //        reportName = "DoctorSchedule2";
            //        break;
            //    case "Consult":
            //        reportName = "ConsultSchedule";
            //        break;
            //    default:
            //        reportName = "";
            //        break;

            //}


            //reportViewer1.ServerReport.ReportPath = credential.ReportPath(reportName);

            reportViewer1.ShowPrintButton = true;
            reportViewer1.ShowParameterPrompts = false;

            //'System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("th-TH")

            ArrayList reportParam = new ArrayList();
            reportParam = ReportDefaultPatam(dt);

            ReportParameter[] param = new ReportParameter[reportParam.Count];
            for (int k = 0; k < reportParam.Count; k++)
            {
                param[k] = (ReportParameter)reportParam[k];
            }

            //reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = credential.NetworkCredentials;
            reportViewer1.ServerReport.SetParameters(param);

            if (GlobalVariables.FagRPT == "XLS")
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
                string outputPath = "C:/Temp/XrayReport.xls";

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
                reportViewer1.RefreshReport();
            }



        }

        private ArrayList ReportDefaultPatam(DataTable dt)
        {
            ArrayList arrLstDefaultParam = new ArrayList();
            arrLstDefaultParam.Add(CreateReportParameter("P_ResultComponentUID", dt.Rows[0].Field<Int64>("ResultComponentUID").ToString()));
            arrLstDefaultParam.Add(CreateReportParameter("P_OrganisationUID","2"));
            arrLstDefaultParam.Add(CreateReportParameter("P_RequestUID", dt.Rows[0].Field<Int64>("RequestUID").ToString()));
            //arrLstDefaultParam.Add(CreateReportParameter("P_LoginUID", DataHelper.usercode));
            //arrLstDefaultParam.Add(CreateReportParameter("ReportSubTitle", "Sub Title of Report"));
            return arrLstDefaultParam;
        }
        private ReportParameter CreateReportParameter(string paramName, string pramValue)
        {
            ReportParameter aParam = new ReportParameter(paramName, pramValue);
            return aParam;
        }

        private void SaveResultTextual(DataTable dttr)
        {
            //string sHTML;
            //sHTML = MarkupConverter.RtfToHtmlConverter.ConvertRtfToHtml(ctlR.Result_GetTexttual(GlobalVariables.gResultComponentUID));

            //ctlR.Result_SaveResultTextual(Convert.ToInt64(dttr.Rows[0].Field<long>("ResultComponentUID")), dttr.Rows[0].Field<string>("ResultItemCode"), dttr.Rows[0].Field<string>("RequestItemName"), ConvertRtfToText(ctlR.Result_GetTexttual(GlobalVariables.gResultComponentUID)), sHTML);
            
        }

        public static string ConvertRtfToText(string input)
        {

            if (!string.IsNullOrEmpty(input))
            {
                string returnValue = string.Empty;

                //Create the RichTextBox. (Requires a reference to System.Windows.Forms.dll.)
                System.Windows.Forms.RichTextBox rtBox = new System.Windows.Forms.RichTextBox();

                // Convert the RTF to plain text.
                try
                {
                    rtBox.Rtf = input;

                }
                catch 
                {
                }

                string plainText = rtBox.Text;

                // Output plain text to file, encoded as UTF-8.
                return plainText;

            }
            else
            {
                return "";
            }

        }

    }
}
