namespace BigLion.Domain.Entities;
/// <summary>
/// ผลการตรวจปอด
/// </summary>
public class Lung : BaseEntity
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

    /// <summary>
    /// ค่า Fvc
    /// </summary>
    public double Fvc { get; set; }

    /// <summary>
    /// Fvc %
    /// </summary>
    public double? Fvc_Rate { get; set; }

    /// <summary>
    /// ผลการตรวจ Fev1
    /// </summary>
    public double? Fev1 { get; set; }

    /// <summary>
    /// ผลการตรวจ Fev1 %
    /// </summary>
    public double? Fev1_Rate { get; set; }

    /// <summary>
    /// ตรวจพบความผิดปกติ = Y
    /// </summary>
    public string? ResultAbnormal { get; set; }

    /// <summary>
    /// ตรวจพบความผิดปกติแบบ Restriction
    /// </summary>
    public string? RestrictionAbnormal { get; set; }

    /// <summary>
    /// ระดับความผิดปกติแบบ Restriction
    /// </summary>
    public string? RestrictionLevel { get; set; }

    /// <summary>
    /// ตรวจพบความผิดปกติแบบ Obstruction
    /// </summary>
    public string? ObstructionAbnormal { get; set; }

    /// <summary>
    /// ระดับความผิดปกติแบบ Obstruction
    /// </summary>
    public string? ObstructionLevel { get; set; }

    /// <summary>
    /// ตรวจพบความผิดปกติทั้ง 2 อย่างร่วมกัน
    /// </summary>
    public string? CombineAbnormal { get; set; }

    /// <summary>
    /// แนะนำควรปรึกษาแพทย์
    /// </summary>
    public string? IsConsult { get; set; }

    /// <summary>
    /// สรุปผลการได้ยิน
    /// </summary>
    public string? ResultNote { get; set; }


    /// <summary>
    /// กำหนดค่าตั้งต้นที่จำเป็นของข้อมูล การตรวจการได้ยิน
    /// </summary>
    /// <param name="checkupId">Checkup Id</param>
    /// <param name="visitNumber">เลขที่การมารับบริการ (VN)</param>
    /// <param name="checkupItemId">Checkup Item Id</param>
    /// <param name="resultAbnormal">ผลการตรวจผิดปกติ</param>
    public Lung(
        int checkupId,
        string visitNumber,
        int checkupItemId,
        string resultAbnormal)
    {
        CheckupId = checkupId;
        VisitNumber = visitNumber;
        CheckupItemId = checkupItemId;
        ResultAbnormal = resultAbnormal;
    }
}
