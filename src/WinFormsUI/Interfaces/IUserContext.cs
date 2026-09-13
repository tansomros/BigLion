using SUTH.HealthCheckup.WinFormsUI.Models;

namespace SUTH.HealthCheckup.WinFormsUI.Interfaces;
public interface IUserContext
{
    CurrentUser CurrentUser { get; }
    bool IsAuthenticated { get; }
    bool IsInRole(string role);
    bool HasClaim(string claimType, string claimValue = null);
    string GetClaimValue(string claimType);
}
