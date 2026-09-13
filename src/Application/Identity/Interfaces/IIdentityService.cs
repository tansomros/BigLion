using BigLion.Application.Identity.Commands;

namespace BigLion.Application.Identity.Interfaces;
public interface IIdentityService
{
    Task<LoginResponse> LoginAsync(
        string username,
        string password,
        CancellationToken cancellationToken);
}
