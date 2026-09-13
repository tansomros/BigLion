using System.ComponentModel;
using DevExpress.XtraReports.UI;
using SUTH.HealthCheckup.WinFormsUI.Checkup.Api.Client;
using SUTH.HealthCheckup.WinFormsUI.Constants;

namespace SUTH.HealthCheckup.WinFormsUI.Reports
{
	public partial class CheckupSummaryReport : DevExpress.XtraReports.UI.XtraReport
	{	
		public CheckupSummaryReport()
		{
			InitializeComponent();
		}

        //private void xrWBC_BeforePrint(object sender, CancelEventArgs e)
        //{
        //    var currentReports = (CheckupReportViewModel)this.GetCurrentRow();

        //    if (currentReports != null && currentReports.Wbc != null)
        //    {
        //        // 2. เข้าถึงตัว XRSubreport ที่ส่ง Event นี้มา
        //        XRSubreport subreport = (XRSubreport)sender;

        //        // 3. ส่งข้อมูลเฉพาะกลุ่ม ให้กับรายงานย่อย
        //        // .ToList() สำคัญมากเพื่อให้ DevExpress ทำงานต่อได้
        //        subreport.ReportSource.DataSource = currentReports.Wbc.Labs
        //                                            .Where(x => x.CheckupGroupCode == CheckupGroup.WhiteBloodCell)
        //                                            .ToList();
        //    }
        //}

        //private void xrRFT_BeforePrint(object sender, CancelEventArgs e)
        //{
        //    var currentReports = (CheckupReportViewModel)this.GetCurrentRow();

        //    if (currentReports != null && currentReports.Renal != null)
        //    {
        //        // 2. เข้าถึงตัว XRSubreport ที่ส่ง Event นี้มา
        //        XRSubreport subreport = (XRSubreport)sender;

        //        // 3. ส่งข้อมูลเฉพาะกลุ่ม ให้กับรายงานย่อย
        //        // .ToList() สำคัญมากเพื่อให้ DevExpress ทำงานต่อได้
        //        subreport.ReportSource.DataSource = currentReports.Renal.Labs
        //                                            .Where(x => x.CheckupGroupCode == CheckupGroup.Renal)
        //                                            .ToList();
        //    }
        //}

        //private void xrLiver_BeforePrint(object sender, CancelEventArgs e)
        //{
        //    var currentReports = (CheckupReportViewModel)this.GetCurrentRow();

        //    if (currentReports != null && currentReports.Liver != null)
        //    {
        //        // 2. เข้าถึงตัว XRSubreport ที่ส่ง Event นี้มา
        //        XRSubreport subreport = (XRSubreport)sender;

        //        // 3. ส่งข้อมูลเฉพาะกลุ่ม ให้กับรายงานย่อย
        //        // .ToList() สำคัญมากเพื่อให้ DevExpress ทำงานต่อได้
        //        subreport.ReportSource.DataSource = currentReports.Liver.Labs
        //            .Where(x => x.CheckupItemCode == "ALP" || x.CheckupItemCode == "SGPT" || x.CheckupItemCode == "SGOT").ToList();
        //    }
        //}

        private void UrineReport_BeforePrint(object sender, CancelEventArgs e)
        {
            // 1. ดึงตัวแปร DetailReportBand ออกมา
            DetailReportBand urineReport = (DetailReportBand)sender;

            var currentReports = (CheckupReportViewModel)this.GetCurrentRow();
             
            if (currentReports != null && currentReports.Urine.Labs.Count != 0)
            {
                // 3. ส่งข้อมูลเฉพาะกลุ่ม ให้กับรายงานย่อย
                // .ToList() สำคัญมากเพื่อให้ DevExpress ทำงานต่อได้
                urineReport.DataSource = currentReports.Urine.Labs;
                    //.Where(x => x.CheckupItem.CheckupGroup.Code == CheckupGroup.Urine && x.CheckupItem.IsDisplayPrint == true).ToList();
            }
            else
            {
                UrineReportDetail.Visible=false;  
            }
        }
        private void UrineReportFooter_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportFooterBand urineReportFoot = (ReportFooterBand)sender;
            var urineReport = (CheckupReportViewModel)this.GetCurrentRow();
            if (urineReport != null)
            {
                lblUrineReport.Text = urineReport.UrineReport;
            }
        }
        private void StoolReport_BeforePrint(object sender, CancelEventArgs e)
        {
            DetailReportBand stoolReport = (DetailReportBand)sender;

            var currentReports = (CheckupReportViewModel)this.GetCurrentRow();

            if (currentReports != null && currentReports.Stool.Labs.Count != 0)
            {                
                stoolReport.DataSource = currentReports.Stool.Labs;
                //.Where(x => x.CheckupItem.CheckupGroup.Code == CheckupGroup.Stool && x.CheckupItem.IsDisplayPrint == true).ToList();
            }
            else
            {
                StoolReportDetail.Visible=false;
            }
        }
        private void StoolReportFooter_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportFooterBand stoolReportFoot = (ReportFooterBand)sender;
            var stoolReport = (CheckupReportViewModel)this.GetCurrentRow();
            if (stoolReport != null)
            {
                lblStoolReport.Text = stoolReport.StoolReport;
            }
        }
        private void SpecialReport_BeforePrint(object sender, CancelEventArgs e)
        {
            DetailReportBand otherReport = (DetailReportBand)sender;

            var currentReports = (CheckupReportViewModel)this.GetCurrentRow();


            if (currentReports != null && currentReports.OtherLab.Labs.Count != 0)
            {
                var oth = currentReports.OtherLab.Labs
                .Where(x => x.CheckupItemCode != CheckupItemCode.FreeT3
                && x.CheckupItemCode != CheckupItemCode.FreeT4
                && x.CheckupItemCode != CheckupItemCode.TSH
                && x.CheckupItemCode != CheckupItemCode.AFP
                && x.CheckupItemCode != CheckupItemCode.CEA
                && x.CheckupItemCode != CheckupItemCode.PSA
                && x.CheckupItemCode != CheckupItemCode.CA199
                && x.CheckupItemCode != CheckupItemCode.CA125
                ).ToList();

                if (oth != null && oth.Count != 0)
                {
                    otherReport.DataSource = currentReports.OtherLab.Labs
                .Where(x => x.CheckupItemCode != CheckupItemCode.FreeT3 
                && x.CheckupItemCode != CheckupItemCode.FreeT4 
                && x.CheckupItemCode != CheckupItemCode.TSH 
                && x.CheckupItemCode != CheckupItemCode.AFP 
                && x.CheckupItemCode != CheckupItemCode.CEA
                && x.CheckupItemCode != CheckupItemCode.PSA
                && x.CheckupItemCode != CheckupItemCode.CA199
                && x.CheckupItemCode != CheckupItemCode.CA125
                ).ToList();
      }
                else
                {
                    otherReport.Visible = false;

                }

            }
            else
            {
                otherReport.Visible = false;
            }
        }

       

       
    }
}
