namespace BigLion.Domain.Entities;
/// <summary>
/// ประเภทการแสดงผลการตรวจสุขภาพ
/// 1 checkup item มีได้ 1 checkup group
/// </summary>
public class CheckupClass : BaseEntity
{
    public string Code { get; set; }
    public string Name { get; set; }
    public int Sort { get; set; }
    public ICollection<CheckupGroup> CheckupGroups { get; set; }
    public CheckupClass(int id,string code, string name,int sort)
    {
        Id = id;
        Code = code;
        Name = name;
        Sort = sort;
        CheckupGroups = [];
    }
}
