namespace BigLion.Domain.Entities;
public class CheckupItem : BaseEntity
{
    /// <summary>
    /// รหัส Item ที่ตั้งเอง
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// คือรหัส LabItemCode จาก HosXP ตาราง LabItem และ icode จาก nonedrugitem
    /// </summary>
    public string? LabItemCode { get; set; }

    /// <summary>
    /// ชื่อรายการตรวจที่ใช้แสดงในรายงานผล
    /// </summary>
    public string DisplayName { get; set; }

    /// <summary>
    /// คำอธิบาย/ชื่อรายการแบบยาว
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// ชื่อที่ใช้แสดงในการเปรียบเทียบย้อนหลัง 
    /// </summary>
    public string? CumulativeName { get; set; }

    /// <summary>
    /// การจำแนกกลุ่มสำหรับการแสดงผลแบบ Cumulative 
    /// </summary>
    public string? CumulativeGroup { get; set; }

    /// <summary>
    /// การเรียงลำดับการแสดงผล Cumulative 
    /// </summary>
    public int CumulativeSort { get; set; }

    /// <summary>
    /// จัดกลุ่มการแสดงผลการตรวจสุขภาพ
    /// </summary>
    public int CheckupGroupId { get; set; }
    public virtual CheckupGroup CheckupGroup { get; set; } = null!;

    /// <summary>
    /// การเรียงลำดับในการแสดงผล
    /// </summary>
    public int Sort { get; set; }     
    public bool IsDisplayPrint { get; set; }

    public CheckupItem(int id,
        string code,
        string? labItemCode,
        string displayName, 
        string? description,
        int checkupGroupId, 
        int sort,
        string? cumulativeName,
        string? cumulativeGroup,
        int cumulativeSort,
        bool isDisplayPrint

    )
    {
        Id = id;
        Code = code;
        DisplayName = displayName; 
        CheckupGroupId =checkupGroupId; 
        Sort = sort;
        LabItemCode = labItemCode;
        Description = description;
        CumulativeName = cumulativeName;
        CumulativeGroup = cumulativeGroup; 
        CumulativeSort = cumulativeSort;
        IsDisplayPrint = isDisplayPrint;
    }
 
}
