using System.Net.Http;
using Duende.IdentityModel.Client;
using Duende.IdentityModel.OidcClient;
using SUTH.HealthCheckup.WinFormsUI.Interfaces;

namespace SUTH.HealthCheckup.WinFormsUI.Services;
public class SuthIdentityTokenService : ISuthIdentityTokenService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly OidcClient _oidcClient;
    private readonly HttpClient _identityHttpClient;

    public SuthIdentityTokenService(IHttpClientFactory httpClientFactory, OidcClient oidcClient)
    {
        _httpClientFactory = httpClientFactory;
        _oidcClient = oidcClient;
        _identityHttpClient = _httpClientFactory.CreateClient("SUTH-Identity");
    }

    public async Task<string> GetTokenAsync(CancellationToken cancellationToken)
    {
        if (
            string.IsNullOrEmpty(_oidcClient.Options.Authority) || 
            string.IsNullOrEmpty(_oidcClient.Options.ClientId) || 
            string.IsNullOrEmpty(_oidcClient.Options.ClientSecret))
        {
            throw new Exception($"SuthIdentity Url or ClientId or ClientSecret is not set");
        }

        if (string.IsNullOrEmpty(_identityHttpClient.BaseAddress?.ToString()))
        {
            throw new Exception($"Identity Base address is empty");
        }

        var discovery = await _identityHttpClient.GetDiscoveryDocumentAsync(_identityHttpClient.BaseAddress.ToString() ?? _oidcClient.Options.Authority);
        if (discovery.IsError)
        {
            throw new Exception($"Discovery document error: {discovery.Error}");
        }

        var tokenResponse = await _identityHttpClient.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
        {
            Address = discovery.TokenEndpoint,
            ClientId = _oidcClient.Options.ClientId,
            ClientSecret = _oidcClient.Options.ClientSecret,
        }, cancellationToken: cancellationToken);

        if (tokenResponse.IsError || string.IsNullOrEmpty(tokenResponse.AccessToken))
        {
            throw new Exception($"Token Response error: {tokenResponse.Error}");
        }

        return tokenResponse.AccessToken;
    }
}
