namespace BigLion.Domain.Entities;

/// <summary>
/// ผลการตรวจทันตกรรม
/// </summary>
public class Dental : BaseEntity
{
    public int CheckupId { get; set; }
    public virtual Checkup? Checkup { get; set; }
    public string VisitNumber { get; set; } 
    public int CheckupItemId { get; set; }
    public CheckupItem CheckupItem { get; set; } = null!;
    public string ResultValue { get; set; }
    public string? ResultNote { get; set; } 
    /// <summary>
    /// เหงือกอักเสบ
    /// </summary>
    public bool Gingivitis { get; set; } 
    /// <summary>
    /// ฟันผุ
    /// </summary>
    public bool Decay { get; set; } 
    /// <summary>
    /// ขูดหินปูน
    /// </summary>
    public bool Scaling { get; set; }    
 
    /// <summary>
    /// เคลือบฟลูออไรด์
    /// </summary>
    public bool Fluoride {  get; set; }
    /// <summary>
    /// เคลือบหลุมร่องฟัน
    /// </summary>
    public bool Sealant { get; set; }
    public string? SealantNote { get; set; }
    /// <summary>
    /// อุดฟัน
    /// </summary>
    public bool Filling { get; set; } 
    public string? FillingNote { get; set; }
    /// <summary>
    /// ถอนฟัน  เดี๋ยวมาลบออก สะกดชื่อผิด
    /// </summary>
    public bool Extration { get; set; }
    public string? ExtrationNote { get; set; }

    public bool Extraction { get; set; }
    public string? ExtractionNote { get; set; }


    /// <summary>
    /// กำหนดค่าตั้งต้นที่จำเป็นของข้อมูล ทันตกรรม
    /// </summary>
    /// <param name="checkupId">Checkup Id</param>
    /// <param name="visitNumber">เลขที่การมารับบริการ (VN)</param>
    /// <param name="checkupItemId">Checkup Item Id</param>
    public Dental(
        int checkupId,
        string visitNumber,
        int checkupItemId,
        string resultValue
        )
    {
        CheckupId = checkupId;
        VisitNumber = visitNumber;
        CheckupItemId = checkupItemId;
        ResultValue = resultValue;
    }
}
