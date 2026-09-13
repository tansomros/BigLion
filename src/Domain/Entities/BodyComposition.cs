namespace BigLion.Domain.Entities;

/// <summary>
/// ผลการตรวจองค์ประกอบร่างกาย (Body Composition)
/// </summary>
public class BodyComposition : BaseEntity
{
    public int CheckupId { get; set; }
    public virtual Checkup? Checkup { get; set; }
    public string VisitNumber { get; set; } 
    public int CheckupItemId { get; set; }
    public CheckupItem CheckupItem { get; set; } = null!;
    public string? Bmr { get; set; }
    public string? BmrNote { get; set; } 
    public string? BodyWater { get; set; }   
    public string? BodyWaterNote { get; set; }
    public string? VisceralFat { get; set; }
    public string? VisceralFatNote { get; set; }
    public string? BodyFat {  get; set; }
    public string? BodyFatNote { get; set; }
    public string? FatRate { get; set; }
    public string? FatRateNote { get; set; }
    public string? MuscleMass { get; set; } 
    public string? MuscleMassNote { get; set; }


    /// <summary>
    /// กำหนดค่าตั้งต้นที่จำเป็นของข้อมูล องค์ประกอบร่างกาย
    /// </summary>
    /// <param name="checkupId">Checkup Id</param>
    /// <param name="visitNumber">เลขที่การมารับบริการ (VN)</param>
    /// <param name="checkupItemId">Checkup Item Id</param>
    public BodyComposition(
        int checkupId,
        string visitNumber,
        int checkupItemId)
    {
        CheckupId = checkupId;
        VisitNumber = visitNumber;
        CheckupItemId = checkupItemId;
    }
}
