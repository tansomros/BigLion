using Duende.IdentityModel.OidcClient.Browser;
using Microsoft.Web.WebView2.WinForms;
namespace SUTH.HealthCheckup.WinFormsUI
{
    public class WinFormsWebView : IBrowser
    {
        private readonly Func<Form> _formFactory;
        private BrowserOptions  _browserOptions { get; set; }
        private string _username { get; set; }
        private string _password { get; set; }

        public WinFormsWebView(Func<Form> formFactory)
        {
            _formFactory = formFactory;
        }

        public WinFormsWebView(string title = "ลงชื่อเข้าใช้...", int width = 412, int height = 768) :
            this(() => new Form
            {
                Name = "WebAuthentication",
                Text = title,
                Width = width,
                Height = height
            })
        {
            
        }

        public WinFormsWebView(string username, string password, string title = "ลงชื่อเข้าใช้...", int width = 412, int height = 768)
        {
            _formFactory = () => new Form
            {
                Name = "WebAuthentication",
                Text = title,
                Width = width,
                Height = height
            };

            _username = username;
            _password = password;
        }

        public async Task<BrowserResult> InvokeAsync(BrowserOptions options, CancellationToken cancellationToken = default)
        {
            _browserOptions = options;
            using(var form = _formFactory.Invoke())
            {
                using (var webView = new WebView2()
                {
                    Dock = DockStyle.Fill
                })
                {
                    var signal = new SemaphoreSlim(0, 1);
                    var browserResult = new BrowserResult
                    {
                        ResultType = BrowserResultType.UserCancel
                    };

                    form.FormClosed += (o, e) =>
                    {
                        signal.Release();
                    };

                    webView.NavigationStarting += (s, e) =>
                    {
                        if (IsBrowserNavigatingToRedirectUri(new Uri(e.Uri)))
                        {
                            e.Cancel = true;
                            browserResult = new BrowserResult()
                            {
                                ResultType = BrowserResultType.Success,
                                Response = new Uri(e.Uri).AbsoluteUri
                            };

                            signal.Release();
                            form.Close();
                        }
                    };

                    //webView.NavigationCompleted += (s, e) =>
                    //{
                    //    if (!string.IsNullOrWhiteSpace(_username) && !string.IsNullOrWhiteSpace(_password))
                    //    {
                    //        string escapedUsername = System.Web.HttpUtility.JavaScriptStringEncode(_username);
                    //        string escapedPassword = System.Web.HttpUtility.JavaScriptStringEncode(_password);
                    //        webView.CoreWebView2.ExecuteScriptAsync($"document.getElementById('Username').value = '{escapedUsername}';");
                    //        webView.CoreWebView2.ExecuteScriptAsync($"document.getElementById('Password').value = '{escapedPassword}';");
                    //        //webView.ExecuteScriptAsync("var event = new KeyboardEvent('keydown', {code: 'Enter', key: 'Enter', charCode: 13, keyCode: 13, view: window, 'bubbles': true}); document.getElementById('Password').dispatchEvent(event);");
                    //        //webView.CoreWebView2.ExecuteScriptAsync($"document.getElementsByTagName('form')[0].submit();");
                    //        webView.CoreWebView2.ExecuteScriptAsync($"document.getElementsByTagName('form')[0].submit();");
                    //    }
                    //};

                    // For Basic Authentication 
                    //webView.CoreWebView2.BasicAuthenticationRequested += (o, args) =>
                    //{
                    //    args.Response.UserName = _username;
                    //    args.Response.Password = _password;
                    //};

                    try
                    {
                        form.Controls.Add(webView);
                        webView.Show();
                        form.Show();

                        await webView.EnsureCoreWebView2Async(null);
                        webView.CoreWebView2.CookieManager.DeleteAllCookies();
                        webView.CoreWebView2.Navigate(_browserOptions.StartUrl);
                        await signal.WaitAsync();
                    }
                    finally
                    {
                        form.Hide();
                        webView.Hide();
                    }

                    return browserResult;
                }
            }
        }

        private bool IsBrowserNavigatingToRedirectUri(Uri uri)
        {
            return uri.AbsoluteUri.StartsWith(_browserOptions?.EndUrl);
        }
    }
}
