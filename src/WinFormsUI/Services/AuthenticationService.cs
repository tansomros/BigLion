using System.Security.Claims;
using Duende.IdentityModel.OidcClient;
using SUTH.HealthCheckup.WinFormsUI.Interfaces;
using SUTH.HealthCheckup.WinFormsUI.Models;

namespace SUTH.HealthCheckup.WinFormsUI.Services;

/// <summary>
/// service สำหรับการเข้าสู่ระบบ / ออกจากระบบ / การดึงข้อมูล user ที่ login ณ ขณะนั้น
/// </summary>
public class AuthenticationService(OidcClient oidcClient) : IAuthenticationService
{
    private readonly OidcClient _oidcClient = oidcClient;
    private LoginResult _loginResult;

    public bool IsAuthenticated => _loginResult != null && !_loginResult.IsError && CurrentUser != null;
    private CurrentUser _currentUser;
    public CurrentUser CurrentUser => _currentUser;

    public async Task<string> GetAccessTokenAsync(CancellationToken cancellationToken)
    {
        if (_loginResult != null && _loginResult.AccessTokenExpiration < DateTimeOffset.UtcNow.AddMinutes(5))
        {
            var refreshResult = await _oidcClient.RefreshTokenAsync(_loginResult.RefreshToken, cancellationToken: cancellationToken);
            if (!refreshResult.IsError)
            {
                _currentUser.AccessToken = refreshResult.AccessToken;
                _currentUser.RefreshToken = refreshResult.RefreshToken;
                _currentUser.AccessTokenExpiration = refreshResult.AccessTokenExpiration;
                return refreshResult.AccessToken;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine($"Token refresh failed: {refreshResult.Error}");
            }
        }

        return _loginResult?.AccessToken;
    }

    /// <summary>
    /// เมธอดสำหรับเข้าสู่ระบบ
    /// </summary>
    /// <returns></returns>
    public async Task<bool> LoginAsync(CancellationToken cancellationToken)
    {
        try
        {
            _loginResult = await _oidcClient.LoginAsync(new LoginRequest(), cancellationToken);
            if (_loginResult.IsError)
            {
                var message = "";
                if (_loginResult.Error == "access_denied")
                {
                    message = "เข้าสู่ระบบไม่สำเร็จ, ไม่สามารถเข้าใช้งานได้";
                }

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show($"{message} ต้องการเข้าสู่ระบบใหม่อีกครั้งหรือไม่?", "การเข้าสู่ระบบ", buttons);
                if (result == DialogResult.Yes)
                {
                    await LoginAsync(cancellationToken);
                }
                else
                {
                    Application.Exit();
                    System.Environment.Exit(0);
                }

                return false;
            }

            _currentUser = ExtracUserFromClaims(_loginResult);
            return true;
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message);
            MessageBox.Show("ขออภัยระบบเกิดข้อผิดพลาด, ไม่สามารถเชื่อมต่อกับระบบ SUTH-Identity ได้ในขณะนี้, โปรดติดต่อแผนกสารสนเทศ โทรศัพท์ 6702" +"\n"
                + ex.Message + "\n"
                + ex.Source + "\n"
                + ex.StackTrace + "\n"
                + ex.InnerException + "\n"
                + ex.Data.Values + "\n"
                + ex.TargetSite + "\n"
                
                , "ระบบเกิดข้อผิดพลาด");
            Application.Exit();
            Environment.Exit(0);
            return false;
        }
    }

    /// <summary>
    /// เมธอดสำหรับดึงข้อมูลข้อมูลใช้ที่ login ณ ขณะนั้น
    /// </summary>
    /// <param name="loginResult"></param>
    /// <returns></returns>
    private static CurrentUser ExtracUserFromClaims(LoginResult loginResult)
    {
        var checkupAdminRole = new String[]
            {
                "Admin : ตรวจสุขภาพ (CheckUp)",
            };

        var checkupDoctorRole = new String[]
            {
                "User : แพทย์ ตรวจสุขภาพ (CheckUp)",
                //"User : แพทย์ (Doctor)",
            };
        var checkupDentistRole = new String[]
            {
                "User : ทันตกรรม (Dental)",
            };

        var checkupGroupRole = new string[]
        {
                "User : ตรวจสุขภาพ(CheckUp)",
        };

        var checkupNurseRole = new string[]
        {
                "User : พยาบาลOPD",
                "User : ผู้ช่วยเหลือผู้ป่วยOPD",
        };

        var currentUser = new CurrentUser
        {
            AccessToken = loginResult.AccessToken,
            RefreshToken = loginResult.RefreshToken,
            IdentityToken = loginResult.IdentityToken,
            AccessTokenExpiration = loginResult.AccessTokenExpiration,
        };

        var claims = loginResult.User?.Claims;
        if (claims != null && claims.ToList().Count > 0)
        {
            currentUser.Claims = [.. loginResult.User.Claims];
            currentUser.NameIdentifier = loginResult.User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            currentUser.Name = loginResult.User.Claims.First(c => c.Type == ClaimTypes.Name)?.Value;
            currentUser.EmployeeId = loginResult.User.Claims.First(c => c.Type == "EmployeeId")?.Value;
            currentUser.LoginName = loginResult.User.Claims.First(c => c.Type == "LoginName")?.Value;
            currentUser.DoctorCode = loginResult.User.Claims.First(c => c.Type == "DoctorCode")?.Value;
            currentUser.Position = loginResult.User.Claims.First(c => c.Type == "Position")?.Value;
            currentUser.HasAdminRole = loginResult.User.Claims.Any(c => c.Type == ClaimTypes.Role && checkupAdminRole.Contains(c.Value));           
            currentUser.HasDoctorRole = loginResult.User.Claims.Any(c => c.Type == ClaimTypes.Role && checkupDoctorRole.Contains(c.Value));
            currentUser.HasDentistRole = loginResult.User.Claims.Any(c => c.Type == ClaimTypes.Role && checkupDentistRole.Contains(c.Value));
            currentUser.HasNurseRole = loginResult.User.Claims.Any(c => c.Type == ClaimTypes.Role && checkupNurseRole.Contains(c.Value));
            currentUser.IsBeCheckupGroup = loginResult.User.Claims.Any(c => c.Type == ClaimTypes.Role && checkupGroupRole.Contains(c.Value));
            currentUser.IsMachineLogin = false;
        }

        return currentUser;
    }

    /// <summary>
    /// เมธอดสำหรับออกจากระบบ
    /// </summary>
    /// <returns></returns>
    public async Task LogoutAsync()
    {
        if (_loginResult != null)
        {
            await _oidcClient?.LogoutAsync(new LogoutRequest { IdTokenHint = _loginResult.IdentityToken });
            _loginResult = null;
            _currentUser = null;
        }
    }
}
