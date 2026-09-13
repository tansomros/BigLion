namespace BigLion.Domain.Entities;
/// <summary>
/// การตรวจการได้ยิน 
/// </summary>
public class Hearing : BaseEntity
{
    /// <summary>
    /// Id ของ Audiogram
    /// </summary>
    public int AudiogramId { get; set; }

    /// <summary>
    /// ค่าความถี่
    /// </summary>
    public int Hertz { get; set; }

    /// <summary>
    /// การได้ยินหูซ้าย
    /// </summary>
    public double LeftHz { get; set; }

    /// <summary>
    /// การได้ยินหูขวา
    /// </summary>
    public double RightHz { get; set; }

    /// <summary>
    /// กำหนดค่าตั้งต้นที่จำเป็นของข้อมูล การตรวจการได้ยิน
    /// </summary>
    /// <param name="audiogramId">Audiogram Id</param>
    /// <param name="hertz">ค่าความถี่</param>
    /// <param name="leftHz">การได้ยินหูซ้าย</param>
    /// <param name="rightHz">การได้ยินหูขวา</param>
    public Hearing(int audiogramId, int hertz, double leftHz, double rightHz)
    {
        AudiogramId = audiogramId;
        Hertz = hertz;
        LeftHz = leftHz;
        RightHz = rightHz;
    }
}
