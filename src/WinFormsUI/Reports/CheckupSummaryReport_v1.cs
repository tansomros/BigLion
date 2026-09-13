using System.ComponentModel;
using DevExpress.XtraReports.UI;
using SUTH.HealthCheckup.WinFormsUI.Checkup.Api.Client;

namespace SUTH.HealthCheckup.WinFormsUI.Reports
{
	public partial class CheckupSummaryReport_v1 : DevExpress.XtraReports.UI.XtraReport
	{	
		public CheckupSummaryReport_v1()
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

            if (currentReports != null && currentReports.Urine != null)
            {
                // 3. ส่งข้อมูลเฉพาะกลุ่ม ให้กับรายงานย่อย
                // .ToList() สำคัญมากเพื่อให้ DevExpress ทำงานต่อได้
                urineReport.DataSource = currentReports.Urine.Labs;
                    //.Where(x => x.CheckupItem.CheckupGroup.Code == CheckupGroup.Urine && x.CheckupItem.IsDisplayPrint == true).ToList();
            }            


            //// 2. กำหนด DataSource (สมมติว่าคุณมี List ของ Object หรือ DataTable อยู่แล้ว)
            //// ในที่นี้คือข้อมูล Lipid ที่คุณดึงมา หรือผล Lab ต่างๆ
            //var myLabData = GetLabDataList(); // ฟังก์ชันดึงข้อมูลของคุณ
            //stoolReport.DataSource = currentReports.Urine.Labs;

            //// 3. ผูกข้อมูล (Data Binding) ให้กับ Cell ในตาราง
            //// "Text" คือ Property ที่เราต้องการแสดง
            //// "FieldName" คือชื่อ Column หรือ Property ใน DataSource ของคุณ
            //xrTableCell1.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "[ItemName]"));
            //xrTableCell2.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "[ResultValue]"));
            //xrTableCell3.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "[Interpretation]"));
        }

        private void StoolReport_BeforePrint(object sender, CancelEventArgs e)
        {
            DetailReportBand stoolReport = (DetailReportBand)sender;

            var currentReports = (CheckupReportViewModel)this.GetCurrentRow();

            if (currentReports != null && currentReports.Stool != null)
            {                
                stoolReport.DataSource = currentReports.Stool.Labs;
                //.Where(x => x.CheckupItem.CheckupGroup.Code == CheckupGroup.Stool && x.CheckupItem.IsDisplayPrint == true).ToList();
            }
        }

        private void SpecialReport_BeforePrint(object sender, CancelEventArgs e)
        {
            DetailReportBand otherReport = (DetailReportBand)sender;

            var currentReports = (CheckupReportViewModel)this.GetCurrentRow();

            if (currentReports != null && currentReports.OtherLab != null)
            {
                otherReport.DataSource = currentReports.OtherLab.Labs;
                //.Where(x => x.CheckupItem.CheckupGroup.Code == CheckupGroup.other && x.CheckupItem.IsDisplayPrint == true).ToList();
            }
        }

        private void UrineReportFooter_BeforePrint(object sender, CancelEventArgs e)
        {
            ReportFooterBand urineReportFoot = (ReportFooterBand)sender;            
            var urineReport = (CheckupReportViewModel)this.GetCurrentRow();
            if (urineReport != null  )
            {
                lblUrineReport.Text = urineReport.UrineReport;
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
    }
}
