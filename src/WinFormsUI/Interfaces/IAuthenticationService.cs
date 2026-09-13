using SUTH.HealthCheckup.WinFormsUI.Models;

namespace SUTH.HealthCheckup.WinFormsUI.Interfaces;
public interface IAuthenticationService
{
    Task<bool> LoginAsync(CancellationToken cancellationToken);
    Task LogoutAsync();
    Task<string> GetAccessTokenAsync(CancellationToken cancellationToken);
    bool IsAuthenticated { get; }
    CurrentUser CurrentUser { get; }
}
