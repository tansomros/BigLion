using System.Globalization;

namespace SUTH.HealthCheckup.WinFormsUI.Functions;

/// <summary>
/// สำหรับแปลงวันที่จากปฏิทิน Gregorian ไปเป็น Thai Buddhist เพื่อการแสดงผลเท่านั้น
/// หมายเหตุ: 
/// ตัว DateTime หรือ DateTimeOffset ที่ได้มาจากการ Serialize ของ API มันจะบังคับ Curlture ไม่สามารถแปลงได้
/// ให้ลบตัว Annotation [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))] 
/// ของ property ที่ต้องการแปลงหลังจาก Generate API ด้วย Connected Service แล้วออก
/// </summary>
public static class ThaiDateHelper
{
    private static readonly CultureInfo ThaiCulture;
    
    static ThaiDateHelper()
    {
        ThaiCulture = new CultureInfo("th-TH");
        ThaiCulture.DateTimeFormat.Calendar = new ThaiBuddhistCalendar();
        CultureInfo.DefaultThreadCurrentCulture = ThaiCulture;
        CultureInfo.DefaultThreadCurrentUICulture = ThaiCulture;
        Thread.CurrentThread.CurrentCulture = ThaiCulture;
        Thread.CurrentThread.CurrentUICulture = ThaiCulture;
    }

    /// <summary>
    /// แปลง DateTime ในปฏิทิน Gregorian เป็น วัน เดือนไทย ปี พ.ศ. ตามรูปแบบที่ระบุ
    /// </summary>
    /// <param name="date"></param>
    /// <param name="format"></param>
    /// <returns></returns>
    public static string ToThaiDateString(this DateTime date, string format = "dd MMMM yyyy")
    {
        return date.ToString(format, ThaiCulture);
    }

    /// <summary>
    /// แปลง DateTimeOffset ในปฏิทิน Gregorian เป็น วัน เดือนไทย ปี พ.ศ. ตามรูปแบบที่ระบุ
    /// </summary>
    /// <param name="dateOffset"></param>
    /// <param name="format"></param>
    /// <returns></returns>
    public static string ToThaiDateString(this DateTimeOffset dateOffset, string format = "dd MMMM yyyy")
    {
        return dateOffset.LocalDateTime.ToThaiDateString(format);
    }
}
