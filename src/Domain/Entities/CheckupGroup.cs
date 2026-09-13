namespace BigLion.Domain.Entities;
/// <summary>
/// กลุ่มการแสดงผลการตรวจสุขภาพ
/// 1 checkup item มีได้ 1 checkup group
/// </summary>
public class CheckupGroup : BaseEntity
{
    public string Code { get; set; }
    public string Name { get; set; }
    public int Sort { get; set; }
    public int CheckupClassId { get; set; }
    public virtual CheckupClass CheckupClass { get; set; } = null!;

    public ICollection<CheckupItem> CheckupItems { get; set; }
    public CheckupGroup(int id,string code, string name, int checkupClassId,int sort)
    {
        Id = id;
        Code = code;
        Name = name;
        CheckupClassId = checkupClassId;
        Sort = sort;
        CheckupItems = [];
    }
}
