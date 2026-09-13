using System.Security.Claims;
using SUTH.HealthCheckup.WinFormsUI.Interfaces;
using SUTH.HealthCheckup.WinFormsUI.Models;

namespace SUTH.HealthCheckup.WinFormsUI.Services;

/// <summary>
/// Development bypass authentication service — ใช้แทน AuthenticationService ตอน dev บน internet
/// ที่ไม่สามารถเชื่อมต่อ Identity Server (identity.suth.go.th) ได้
///
/// เปิดใช้งานโดยตั้งค่า "UseDevelopmentBypass": true ใน appsettings.Development.json
/// ข้อมูลผู้ใช้จะอ่านจาก "Authentication:DevelopmentUser" — ต้องใส่ค่าจริงจากฐานข้อมูล
/// เช่น DoctorCode ต้องตรงกับ Careprovider.Code เพื่อให้ lookup ทำงานได้
/// </summary>
public class DevAuthenticationService : IAuthenticationService
{
    private readonly DevelopmentUserSettings _devUser;
    private CurrentUser _currentUser;

    public DevAuthenticationService(IConfigurationService configService)
    {
        _devUser = configService.Settings.Authentication.DevelopmentUser;
    }

    public bool IsAuthenticated => _currentUser != null;
    public CurrentUser CurrentUser => _currentUser;

    public Task<bool> LoginAsync(CancellationToken cancellationToken)
    {
        var roles = new List<Claim>();
        if (_devUser.HasAdminRole)
            roles.Add(new Claim(ClaimTypes.Role, "Admin"));
        if (_devUser.HasDoctorRole)
            roles.Add(new Claim(ClaimTypes.Role, "User : แพทย์ (Doctor)"));
        if (_devUser.HasNurseRole)
            roles.Add(new Claim(ClaimTypes.Role, "User : พยาบาล (Nurse)"));
        if (_devUser.IsBeCheckupGroup)
            roles.Add(new Claim(ClaimTypes.Role, "User : ตรวจสุขภาพ(CheckUp)"));

        var claims = new List<Claim>
        {
            new(ClaimTypes.NameIdentifier, _devUser.NameIdentifier),
            new(ClaimTypes.Name, _devUser.Name),
            new("EmployeeId", _devUser.EmployeeId),
            new("LoginName", _devUser.LoginName),
            new("DoctorCode", _devUser.DoctorCode),
            new("Position", _devUser.Position),
            new("scope", "suth-checkup-api"),
            new("scope", "openid"),
            new("scope", "profile"),
            new("scope", "offline_access"),
        };
        claims.AddRange(roles);

        _currentUser = new CurrentUser
        {
            NameIdentifier = _devUser.NameIdentifier,
            Name = _devUser.Name,
            EmployeeId = _devUser.EmployeeId,
            DoctorCode = _devUser.DoctorCode,
            Position = _devUser.Position,
            LoginName = _devUser.LoginName,
            HasAdminRole = _devUser.HasAdminRole,
            HasDoctorRole = _devUser.HasDoctorRole,
            HasNurseRole = _devUser.HasNurseRole,
            IsBeCheckupGroup = _devUser.IsBeCheckupGroup,
            IsMachineLogin = false,
            AccessToken = "dev-bypass-token",
            RefreshToken = "dev-bypass-refresh",
            IdentityToken = "dev-bypass-identity",
            AccessTokenExpiration = DateTimeOffset.UtcNow.AddHours(24),
            Claims = claims
        };

        return Task.FromResult(true);
    }

    public Task<string> GetAccessTokenAsync(CancellationToken cancellationToken)
    {
        return Task.FromResult(_currentUser?.AccessToken ?? "dev-bypass-token");
    }

    public Task LogoutAsync()
    {
        _currentUser = null;
        return Task.CompletedTask;
    }
}
