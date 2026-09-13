namespace SUTH.HealthCheckup.WinFormsUI.Interfaces;
public interface ISuthIdentityTokenService
{
    Task<string> GetTokenAsync(CancellationToken cancellationToken);
}
