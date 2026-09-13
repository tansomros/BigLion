using System.Net.Http;
using System.Net.Http.Headers;

namespace SUTH.HealthCheckup.WinFormsUI.OpenAPIs;
public class CheckupHttpClientService
{
    //private readonly string _url = "https://queue.suth.go.th/v2/api/";
    private readonly string _url = "https://localhost:8114/";
    private readonly HttpClient _httpClient;

    public CheckupHttpClientService(string token)
    {
        if (_httpClient == null)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_url);
            _httpClient.Timeout = TimeSpan.FromSeconds(15);

            if (!string.IsNullOrEmpty(token))
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }
    }

    public HttpClient GetHttpClient()
    {
        return _httpClient;
    }

    public string GetUrl()
    {
        return _url;
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}
