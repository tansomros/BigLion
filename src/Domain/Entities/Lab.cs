namespace BigLion.Domain.Entities;
/// <summary>
/// ผลการตรวจปฏิบัติการ
/// </summary>
public class Lab : BaseEntity
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
    public int? CheckupItemId { get; set; }
    public CheckupItem? CheckupItem { get; set; } = null!;

    /// <summary>
    /// เก็บค่า lab_item_code จาก HosXP
    /// </summary>
    public int Lab_Item_Code { get; set; }

    /// <summary>
    /// เก็บค่า lab_items_name_ref จาก HosXP
    /// </summary>
    public string? Lab_Item_Name { get; set; }

    /// <summary>
    /// ผลแลบ
    /// </summary>
    public string? ResultValue { get; set; }

    /// <summary>
    /// ค่าปกติ
    /// </summary>
    public string? ReferenceRange { get; set; }

    /// <summary>
    /// เก็บ Flag ว่าผลแลบ ปกติหรือไม่ Y/N/H/L
    /// </summary>
    public string? IsAbnormal { get; set; }

    /// <summary>
    /// สรุปผลแลบราย item
    /// </summary>
    public string? Comments { get; set; }

    /// <summary>
    /// วันที่รายงานผล เป็นวันที่จาก HIS
    /// </summary>
    public DateOnly? ResultDate { get; set; }

    /// <summary>
    /// เวลาที่รายงานผล จาก HIS
    /// </summary>
    public TimeOnly ResultTime { get; set; }

    /// <summary>
    /// กำหนดค่าตั้งต้นที่จำเป็นของข้อมูล ผลการตรวจปฏิบัติการ
    /// </summary>
    /// <param name="checkupId">Checkup Id</param>
    /// <param name="visitNumber">เลขที่การมารับบริการ (VN)</param>
    /// <param name="checkupItemId">Checkup Item Id</param>
    public Lab(int checkupId, string visitNumber, int? checkupItemId)
    {
        CheckupId = checkupId;
        VisitNumber = visitNumber;
        CheckupItemId = checkupItemId;
    }
}
