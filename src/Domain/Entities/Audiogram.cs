namespace BigLion.Domain.Entities;

/// <summary>
/// ผลการตรวจการได้ยิน ถ้าไม่ตรวจจะไม่มี Record
/// </summary>
public class Audiogram : BaseEntity
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
    public virtual CheckupItem CheckupItem { get; set; } = null!;

    /// <summary>
    /// ผลหูซ้าย
    /// </summary>
    public string? LeftNote { get; set; }

    /// <summary>
    /// ผลหูขวา
    /// </summary>
    public string? RightNote { get; set; }

    /// <summary>
    /// ความผิดปกติหูซ้าย
    /// </summary>
    public string LeftResult { get; set; }

    /// <summary>
    /// ความผิดปกติหูขวา
    /// </summary>
    public string RightResult { get; set; }

    /// <summary>
    /// สรุปผลการได้ยิน
    /// </summary>
    public string? ResultNote { get; set; }



    public ICollection<Hearing>? Hearings { get; set; }

    /// <summary>
    /// กำหนดค่าตั้งต้นที่จำเป็นของข้อมูล การตรวจการได้ยิน
    /// </summary>
    /// <param name="checkupId">Checkup Id</param>
    /// <param name="visitNumber">เลขที่การมารับบริการ (VN)</param>
    /// <param name="checkupItemId">Checkup Item Id</param>
    /// <param name="leftResult">ผลการตรวจหูซ้าย</param>
    /// <param name="rightResult">ผลการตรวจหูขวา</param>
    /// <param name="resultNote">สรุปผลการได้ยิน</param>
    public Audiogram(
        int checkupId,
        string visitNumber,
        int checkupItemId,
        string leftResult,
        string rightResult,
        string resultNote,
        string leftNote,
        string rightNote)
    {
        CheckupId = checkupId;
        VisitNumber = visitNumber;
        CheckupItemId = checkupItemId;
        ResultNote = resultNote;
        LeftResult = leftResult;
        RightResult = rightResult;
        RightNote = rightNote;
        LeftNote = leftNote;
        Hearings = []; //default value prevent null object reference
    }
}
