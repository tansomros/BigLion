namespace BigLion.Domain.Entities;
/// <summary>
/// ผลการตรวจรังษี
/// </summary>
public class Xray : BaseEntity
{
    /// <summary>
    /// Checkup Id
    /// </summary>
    public int CheckupId { get; set; }
    public virtual Checkup? Checkup { get; set; }

    public string VisitNumber { get; set; }

    /// <summary>
    /// Checkup Item ID
    /// </summary>
    public int CheckupItemId { get; set; }
    public CheckupItem CheckupItem { get; set; } = null!;

    public string? ResultValue { get; set; }

    /// <summary>
    /// เก็บ Flag ว่าผลแลบ ปกติหรือไม่ Y/N/H/L
    /// </summary>
    public string? IsAbnormal { get; set; }

    /// <summary>
    /// การรายงานสรุปผลจากแพทย์
    /// </summary>
    public string? ResultReport { get; set; }

    /// <summary>
    /// คำอ่านผลจากระบบ PACs เป็น RTF string
    /// </summary>
    public string? ReportText { get; set; }

    /// <summary>
    /// XN NUMBER ในตาราง Xray_report hosxp
    /// </summary>
    public string? AccessionNumber { get; set; }



    /// <summary>
    /// กำหนดค่าตั้งต้นที่จำเป็นของข้อมูล ผลการตรวจทางรังษี
    /// </summary>
    /// <param name="checkupId">Checkup Id</param>
    /// <param name="visitNumber">เลขที่การมารับบริการ (VN)</param>
    /// <param name="checkupItemId">Checkup Item Id</param>
    /// <param name="resultValue">ผล</param>
    /// <param name="reportText">คำอ่านผลจากระบบ PACs เป็น RTF string</param>
    public Xray(
        int checkupId, 
        string visitNumber, 
        int checkupItemId, 
        string? resultValue,
        string? reportText,
        string accessionNumber)
    {
        CheckupId = checkupId;
        VisitNumber = visitNumber;
        CheckupItemId = checkupItemId;
        ResultValue = resultValue;
        ReportText = reportText;
        AccessionNumber = accessionNumber;
    }
}

