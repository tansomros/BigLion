namespace BigLion.Domain.Entities;
/// <summary>
/// การตรวจการมองเห็น
/// </summary>
public class Vision : BaseEntity
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
    /// ผลการวัดการมองเห็น ตาขวา VA (เก็บ Reference Value Code)
    /// </summary>
    //public int? VA_Right_TypeId { get; set; }

    /// <summary>
    /// Note การวัดการมองเห็น ตาขวา VA 
    /// </summary>
    /// public string? VA_Right_Note { get; set; }
    public string? VA_Right_Value { get; set; }
    /// <summary>
    /// ผลการวัดการมองเห็น ตาซ้าย VA (เก็บ Reference Value Code)
    /// </summary>
    /// public int? VA_Left_TypeId { get; set; }

    /// <summary>
    /// Note การวัดการมองเห็น ตาซ้าย VA (เก็บ Reference Value Code)
    /// </summary>
    /// public string? VA_Left_Note { get; set; }
    public string? VA_Left_Value { get; set; }
    /// <summary>
    /// ผลการวัดการมองเห็น ตาขวา PH
    /// </summary>
    /// public int? PH_Right_TypeId { get; set; }

    /// <summary>
    /// Note การวัดการมองเห็น ตาขวา PH (เก็บ Reference Value Code)
    /// </summary>
    /// public string? PH_Right_Note { get; set; }
    public string? PH_Right_Value { get; set; }
    /// <summary>
    /// ผลการวัดการมองเห็น ตาซ้าย PH
    /// </summary>
    /// public int? PH_Left_TypeId { get; set; }

    /// <summary>
    /// Note การวัดการมองเห็น ตาซ้าย PH
    /// </summary>
    /// public string? PH_Left_Note { get; set; }
    public string? PH_Left_Value { get; set; }


    ///// <summary>
    ///// ผลการวัดการมองเห็น มองใกล้ ตาขวา VA
    ///// </summary>
    //public int? VA_Right_Near_TypeId { get; set; }
    ///// <summary>
    ///// Note การวัดการมองเห็น มองใกล้ ตาขวา VA
    ///// </summary>
    //public string? VA_Right_Near_Note { get; set; }
    ///// <summary>
    ///// ผลการวัดการมองเห็น มองใกล้ ตาซ้าย VA
    ///// </summary>
    //public int? VA_Left_Near_TypeId { get; set; }
    ///// <summary>
    ///// Note การวัดการมองเห็น มองใกล้ ตาซ้าย VA
    ///// </summary>
    //public string? VA_Left_Near_Note { get; set; }

    ///// <summary>
    ///// ผลการวัดการมองเห็น มองระยะกลาง ตาขวา VA
    ///// </summary>
    //public int? VA_Right_Mid_TypeId { get; set; }
    ///// <summary>
    ///// Note การวัดการมองเห็น มองระยะกลาง ตาขวา VA
    ///// </summary>
    //public string? VA_Right_Mid_Note { get; set; }
    ///// <summary>
    ///// ผลการวัดการมองเห็น มองระยะกลาง ตาซ้าย VA
    ///// </summary>
    //public int? VA_Left_Mid_TypeId { get; set; }
    ///// <summary>
    ///// Note การวัดการมองเห็น มองระยะกลาง ตาซ้าย VA
    ///// </summary>
    //public string? VA_Left_Mid_Note { get; set; }


    ///// <summary>
    ///// ผลการวัดการมองเห็น มองไกล ตาขวา
    ///// </summary>
    //public int? VA_Right_Far_TypeId { get; set; }
    ///// <summary>
    ///// Note การวัดการมองเห็น มองไกล ตาขวา VA
    ///// </summary>
    //public string? VA_Right_Far_Note { get; set; }
    ///// <summary>
    ///// ผลการวัดการมองเห็น มองไกล ตาซ้าย VA
    ///// </summary>
    //public int? VA_Left_Far_TypeId { get; set; }
    ///// <summary>
    ///// Note การวัดการมองเห็น มองไกล ตาซ้าย VA
    ///// </summary>
    //public string? VA_Left_Far_Note { get; set; }


    ///// <summary>
    ///// ผลการวัดการมองเห็น มองใกล้ ตาขวา PH
    ///// </summary>
    //public int? PH_Right_Near_TypeId { get; set; }
    ///// <summary>
    ///// Note การวัดการมองเห็น มองใกล้ ตาขวา PH
    ///// </summary>
    //public string? PH_Right_Near_Note { get; set; }
    ///// <summary>
    ///// ผลการวัดการมองเห็น มองใกล้ ตาซ้าย PH
    ///// </summary>
    //public int? PH_Left_Near_TypeId { get; set; }
    ///// <summary>
    ///// Note การวัดการมองเห็น มองใกล้ ตาซ้าย PH
    ///// </summary>
    //public string? PH_Left_Near_Note { get; set; }

    ///// <summary>
    ///// ผลการวัดการมองเห็น มองระยะกลาง ตาขวา PH
    ///// </summary>
    //public int? PH_Right_Mid_TypeId { get; set; }
    ///// <summary>
    ///// Note การวัดการมองเห็น มองระยะกลาง ตาขวา PH
    ///// </summary>
    //public string? PH_Right_Mid_Note { get; set; }
    ///// <summary>
    ///// ผลการวัดการมองเห็น มองระยะกลาง ตาซ้าย PH
    ///// </summary>
    //public int? PH_Left_Mid_TypeId { get; set; }
    ///// <summary>
    ///// Note การวัดการมองเห็น มองระยะกลาง ตาซ้าย PH
    ///// </summary>
    //public string? PH_Left_Mid_Note { get; set; }


    ///// <summary>
    ///// ผลการวัดการมองเห็น มองไกล ตาขวา PH
    ///// </summary>
    //public int? PH_Right_Far_TypeId { get; set; }
    ///// <summary>
    ///// Note การวัดการมองเห็น มองไกล ตาขวา PH
    ///// </summary>
    //public string? PH_Right_Far_Note { get; set; }
    ///// <summary>
    ///// ผลการวัดการมองเห็น มองไกล ตาซ้าย PH
    ///// </summary>
    //public int? PH_Left_Far_TypeId { get; set; }
    ///// <summary>
    ///// Note การวัดการมองเห็น มองไกล ตาซ้าย PH
    ///// </summary>
    //public string? PH_Left_Far_Note { get; set; }



    /// <summary>
    /// ผลระดับการมองเห็น ตาขวา
    /// </summary>
    public string? VisionRightResult { get; set; }
    /// <summary>
    /// ผลระดับการมองเห็น ตาซ้าย
    /// </summary>
    public string? VisionLeftResult { get; set; }

    /// <summary>
    /// ตาบอดสี
    /// </summary>
    public string? ColorBlind { get; set; }
    /// <summary>
    /// ความดันตาขวา
    /// </summary>
    public string? PressureRight { get; set; }
    /// <summary>
    /// ความดันตาซ้าย
    /// </summary>
    public string? PressureLeft { get; set; }
    /// <summary>
    /// การมองภาพ 3 มิติ
    /// </summary>
    public string? Vision3D { get; set; }
    /// <summary>
    /// ภาวะเข
    /// </summary>
    public string? Squint { get; set; }
    /// <summary>
    /// การวัดลานสายตา
    /// </summary>
    public string? VisualField { get; set; }
    /// <summary>
    /// จอประสาทตาขวา
    /// </summary>
    public string? RetinaRight { get; set; }
    /// <summary>
    /// จอประสาทตาซ้าย
    /// </summary>
    public string? RetinaLeft { get; set; }
    /// <summary>
    /// สรุปผลการตรวจสายตา
    /// </summary>
    public string? ResultNote { get; set; }


    /// <summary>
    /// กำหนดค่าตั้งต้นที่จำเป็นของข้อมูล ผลการตรวจการมองเห็น
    /// </summary>
    /// <param name="checkupId">Checkup Id</param>
    /// <param name="visitNumber">เลขที่การมารับบริการ (VN)</param>
    /// <param name="checkupItemId">Checkup Item Id</param>
    /// <param name="visionRightResult">ผลระดับการมองเห็น ตาขวา</param>
    /// <param name="visionLeftResult">ผลระดับการมองเห็น ตาซ้าย</param>
    /// <param name="resultNote">สรุปผลการตรวจสายตา</param>
    public Vision(
        int checkupId, 
        string visitNumber, 
        int checkupItemId,
        string visionRightResult, 
        string visionLeftResult, 
        string resultNote)
    {
        CheckupId = checkupId;
        VisitNumber = visitNumber;
        CheckupItemId = checkupItemId;
        VisionRightResult = visionRightResult;
        VisionLeftResult = visionLeftResult;
        ResultNote = resultNote;
    }
}
