namespace SUTH.HealthCheckup.WinFormsUI.Models;
public class AuthenticationSettings
{
    public string Authority { get; set; }
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
    public string Scope { get; set; }
    public string RedirectUri { get; set; }
    public string RedirectPort { get; set; }
    public bool UseDevelopmentBypass { get; set; } = false;

    /// <summary>
    /// ข้อมูลผู้ใช้สำหรับ Development Bypass — ต้องใส่ค่าจริงจากฐานข้อมูลเพื่อให้ lookup ต่างๆ ทำงานได้
    /// เช่น DoctorCode ต้องตรงกับ Careprovider.Code ในระบบ
    /// </summary>
    public DevelopmentUserSettings DevelopmentUser { get; set; } = new();
}

/// <summary>
/// ตั้งค่าผู้ใช้สำหรับ dev bypass — ใช้ข้อมูลจริงจาก Identity Server / ฐานข้อมูล
/// เพื่อให้ฟีเจอร์ต่างๆ เช่น BindCareproviderToDDL() ทำงานได้ถูกต้อง
/// </summary>
public class DevelopmentUserSettings
{
    public string NameIdentifier { get; set; } = "dev-user-001";
    public string Name { get; set; } = "Developer (Dev Bypass)";
    public string EmployeeId { get; set; } = "DEV001";
    public string DoctorCode { get; set; } = "DEV-DOC";
    public string Position { get; set; } = "Developer";
    public string LoginName { get; set; } = "devuser";
    public bool HasAdminRole { get; set; } = true;
    public bool HasDoctorRole { get; set; } = true;
    public bool HasNurseRole { get; set; } = false;
    public bool IsBeCheckupGroup { get; set; } = true;
}
