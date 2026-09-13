namespace BigLion.Domain.Entities;
public class Recommendation : BaseEntity
{
    /// <summary>
    /// Code การตรวจ อาจจะเป็น Lab Code หรือ Code ที่ตั้งขึ้นมาเอง เพราะบางอย่างก็ไม่ใช่ Lab เช่น การแปลผล BMI , ความดัน
    /// </summary>
    public string Code { get; set; }
    /// <summary>
    /// ชื่อการแปลผล
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// ประเภทการเทียบค่า เช่น L,B,G,E
    /// </summary>
    public string CheckType { get; set; }
    /// <summary>
    /// เพศ กรณีบาง Lab ค่า Normal แยก ช/ญ
    /// </summary>
    public string? SexCode { get; set; }
    /// <summary>
    /// ค่าเปรียบเทียบกรณี เปรียบเทียบแบบเท่ากับค่า
    /// </summary>
    public string? CompareValue { get; set; }
    /// <summary>
    /// ค่าตำสุด
    /// </summary>
    public double LowValue { get; set; }
    /// <summary>
    /// ค่าสูงสุด
    /// </summary>
    public double HighValue { get; set; }
    /// <summary>
    /// คำแปลผลภาษาไทย
    /// </summary>
    public string ConclusionTh { get; set; }
    /// <summary>
    /// คำแปลผลภาษาอังกฤษ
    /// </summary>
    public string? ConclusionEn { get; set; }
    /// <summary>
    /// คำแนะนำภาษาไทย
    /// </summary>
    public string? RecommendTh { get; set; }
    /// <summary>
    /// คำแนะนำภาษาอังกฤษ
    /// </summary>
    public string? RecommendEn { get; set; }

    public DateTime? ActiveFrom { get; set; }
    public DateTime? ActiveTo { get; set; }


    public Recommendation(string code, string name, string checkType,string sexCode,string compareValue, double lowValue, double highValue, string conclusionTh, string conclusionEn, string recommendTh, string recommendEn,DateTime? activeFrom,DateTime? activeTo)
    {
        Code = code;
        Name = name;
        CheckType = checkType;
        SexCode = sexCode;
        CompareValue = compareValue;
        LowValue = lowValue;
        HighValue = highValue;
        ConclusionTh = conclusionTh;
        ConclusionEn = conclusionEn;
        RecommendTh = recommendTh;
        RecommendEn = recommendEn;
        ActiveFrom = activeFrom;
        ActiveTo =activeTo;
    }
}
