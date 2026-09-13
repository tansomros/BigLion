using System.Net.Http;
using System.Net.Http.Headers;
using SUTH.HealthCheckup.WinFormsUI.Interfaces;

namespace SUTH.HealthCheckup.WinFormsUI.Services;
public class AuthenticationHandler : DelegatingHandler
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationHandler(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var token = await _authenticationService.GetAccessTokenAsync(cancellationToken);
        if (!string.IsNullOrEmpty(token))
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        var response = await base.SendAsync(request, cancellationToken);
        if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
        {
            token = await _authenticationService.GetAccessTokenAsync(cancellationToken);
            if (!string.IsNullOrEmpty(token))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                response = await base.SendAsync(request, cancellationToken);
            }
        }

        return response;
    }
}
