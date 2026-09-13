namespace BigLion.Domain.Entities;
/// <summary>
/// ประเภทการตรวจสุขภาพ เช่น
/// ตรวจประจำปี
/// ตรวจเพื่อสอบใบขับขี่
/// ตรวจเพื่อสมัครงาน
/// </summary>
public class CheckupType : BaseEntity
{
    /// <summary>
    /// ชื่อประเภท
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// คำอธิบายหรือรายละเอียดประเภท
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// กำหนดค่าตั้งต้นที่จำเป็นของข้อมูล ประเภทการตรวจสุขภาพ
    /// </summary>
    /// <param name="name">ชื่อประเภท</param>
    /// <param name="description">คำอธิบายหรือรายละเอียดประเภท</param>
    public CheckupType(int id,string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
}
