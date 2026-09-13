namespace BigLion.Domain.Entities;
/// <summary>
/// บุคลากรทางการแพทย์
/// </summary>
public class CareProvider : BaseEntity
{
    /// <summary>
    /// เลขพนักงานจากใน hosxp จากตาราง doctor ไม่ใช่รหัสพนักงาน
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// ชื่อภาษาไทย
    /// </summary>
    public string FullNameThai { get; set; }

    /// <summary>
    /// ชื่อภาษาอังกฤษ
    /// </summary>
    public string? FullNameEnglish { get; set; }

    /// <summary>
    /// เลขที่ใบประกอบวิชาชีพ
    /// </summary>
    public string? LicenseNo { get; set; }

    /// <summary>
    /// เลขที่บัตรประชาชน สำหรับเอาไว้เชื่อมโยงกับ User และ Patient
    /// </summary>
    public string? NationalId { get; set; }

    /// <summary>
    /// ตำแหน่ง
    /// </summary>
    public string? PositionName { get; set; }
    
    /// <summary>
    /// ประเภทบุคลากร
    /// </summary>
    public int CareProviderTypeId { get; set; }
    public string? CareProviderTypeName { get; set; }

    /// <summary>
    /// กำหนดค่าตั้งต้นที่จำเป็นของข้อมูล บุคลากรทางการแพทย์
    /// </summary>
    /// <param name="code">code พนักงานจากตาราง doctor ในระบบ HOSxP</param>
    /// <param name="fullNameThai">ชื่อภาษาไทย</param> 
    /// <param name="careProviderTypeId">ประเภทบุคลากร</param> 
    public CareProvider(string code, string fullNameThai, int careProviderTypeId)
    {
        Code = code;
        FullNameThai = fullNameThai;
        CareProviderTypeId = careProviderTypeId;
    }
}
