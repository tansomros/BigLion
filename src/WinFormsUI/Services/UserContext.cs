using SUTH.HealthCheckup.WinFormsUI.Interfaces;
using SUTH.HealthCheckup.WinFormsUI.Models;

namespace SUTH.HealthCheckup.WinFormsUI.Services;
public class UserContext(IAuthenticationService authenticationService) : IUserContext
{
    private readonly IAuthenticationService _authenticationService = authenticationService;

    public CurrentUser CurrentUser => _authenticationService.CurrentUser;

    public bool IsAuthenticated => throw new NotImplementedException();

    public string GetClaimValue(string claimType)
    {
        throw new NotImplementedException();
    }

    public bool HasClaim(string claimType, string claimValue = null)
    {
        throw new NotImplementedException();
    }

    public bool IsInRole(string role)
    {
        throw new NotImplementedException();
    }
}
