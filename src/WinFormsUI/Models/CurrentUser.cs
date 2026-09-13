using System.Security.Claims;

namespace SUTH.HealthCheckup.WinFormsUI.Models;
public class CurrentUser
{
    public string NameIdentifier { get; set; }
    public string Name { get; set; }
    public string EmployeeId { get; set; }
    public string DoctorCode { get; set; }
    public string Position { get; set; }
    public string LoginName { get; set; }
    public List<Claim> Claims { get; set; }
    public bool HasAdminRole { get; set; }
    public bool HasDoctorRole { get; set; }
    public bool HasDentistRole { get; set; }
    public bool HasNurseRole { get; set; }
    public bool IsBeCheckupGroup { get; set; }
    public bool IsMachineLogin { get; set; }
    public string IdentityToken { get; set; }
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
    public DateTimeOffset AccessTokenExpiration { get; set; }
    public bool IsTokenExpired => DateTimeOffset.UtcNow >= AccessTokenExpiration.AddMinutes(-5);

    public CurrentUser()
    {
        Claims = [];
    }
}
