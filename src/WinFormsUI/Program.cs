using System.Globalization;
using System.Net.Http;
using Duende.IdentityModel.OidcClient;
using Microsoft.Extensions.DependencyInjection;
using SUTH.HealthCheckup.WinFormsUI.Checkup.Api.Client;
using SUTH.HealthCheckup.WinFormsUI.Factories;
using SUTH.HealthCheckup.WinFormsUI.Hosxp.Api.Client;
using SUTH.HealthCheckup.WinFormsUI.Interfaces;
using SUTH.HealthCheckup.WinFormsUI.Reports;
using SUTH.HealthCheckup.WinFormsUI.Services;

namespace SUTH.HealthCheckup.WinFormsUI
{
    static class Program
    {
        /// <summary>
        /// จุดเริ่มต้นของโปรแกรมจ้า
        /// </summary>
        [STAThread]
        static void Main()
        {
            // ตั้งค่าเลือก LaunchSetting 
            #if DEBUG
                SetLaunchProfile("CheckupDev");
            #else
                SetLaunchProfile("CheckupProd");
            #endif

            // ตั้งค่าปฏิทินพุทธศักราช
            // ConfigureThaiCulture();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ตั้งค่า services ต่างๆ ที่ต้องการใช้, แล้วฉีดเข้าไปใน ServiceCollection DI
            var services = new ServiceCollection();
            ConfigureServices(services);

            using var serviceProvider = services.BuildServiceProvider();

            // ฟอร์ม Login จะเปิดขึ้นมาก่อนเพื่อเรียกใช้ระบบการยืนยันตัวตนผ่าน WebView ถ้าสำเร็จจะเปิด Form Main
            var loginForm = serviceProvider.GetRequiredService<LoginForm>();
            if (loginForm.ShowDialog() == DialogResult.OK && loginForm.IsLoginSuccessful)
            {
                var mainForm = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(mainForm);
            } 
            else
            {
                MessageBox.Show("โปรดเข้าสู่ระบบ", "ต้องยืนยันตัวตนก่อนเข้าใช้งาน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // ไฟล์ตั้งค่าตัวแปรต่างๆ appsettings.Enviroment.json 
            services.AddSingleton<IConfigurationService, ConfigurationService>();
            var configureService = new ConfigurationService();

            // ตั้งค่า Identity Server สำหรับการยืนยันตัวตน
            var authSettings = configureService.Settings.Authentication;

            if (authSettings.UseDevelopmentBypass)
            {
                // Dev bypass: ไม่ต้องเชื่อมต่อ Identity Server
                services.AddSingleton<IAuthenticationService, DevAuthenticationService>();
            }
            else
            {
                // Production: ใช้ OidcClient + AuthenticationService จริง
                services.AddSingleton<OidcClient>(sp =>
                {
                    var options = new OidcClientOptions
                    {
                        Authority = authSettings.Authority,
                        ClientId = authSettings.ClientId,
                        ClientSecret = authSettings.ClientSecret,
                        Scope = authSettings.Scope,
                        RedirectUri = authSettings.RedirectUri,
                        Browser = new WinFormsWebView()
                    };
                    return new OidcClient(options);
                });

                services.AddSingleton<IAuthenticationService, AuthenticationService>();
            }
            services.AddSingleton<IUserContext, UserContext>();
            services.AddTransient<AuthenticationHandler>();

            // กำหนด Api Client ด้วย IHttpClientFactory ของ donet
            services.AddHttpClient("HosxpApiClient");
            services.AddHttpClient("CheckupApiClient")
                .AddHttpMessageHandler<AuthenticationHandler>();

            // ตั้งค่า HOSxP Api Client
            services.AddTransient<HosxpApiClient>(sp =>
            {
                var config = sp.GetRequiredService<IConfigurationService>();
                var hosxpApiSettings = config.Settings.Api.Hosxp;
                var httpClient = sp.GetRequiredService<IHttpClientFactory>().CreateClient("HosxpApiClient");
                httpClient.Timeout = TimeSpan.FromSeconds(hosxpApiSettings.Timeout);
                return new HosxpApiClient(hosxpApiSettings.BaseUrl, httpClient);
            });

            // ตั้งค่า Checkup Api Client
            services.AddTransient<CheckupApiClient>(sp =>
            {
                var config = sp.GetRequiredService<IConfigurationService>();
                var checkupApiSettings = config.Settings.Api.Checkup;
                var httpClient = sp.GetRequiredService<IHttpClientFactory>().CreateClient("CheckupApiClient");
                if (!string.IsNullOrEmpty(checkupApiSettings.BaseUrl))
                {
                    httpClient.BaseAddress = new Uri(checkupApiSettings.BaseUrl);
                }
                httpClient.Timeout = TimeSpan.FromSeconds(checkupApiSettings.Timeout);
                return new CheckupApiClient(httpClient);
            });

            // ฉีดฟอร์มเข้า DI สำหรับฟอร์มไหนที่ต้องใช้ Services ใน ServiceCollection, ฟอร์มที่ไม่ต้องใช้ ไม่ต้องฉีด
            // เวลา initialize class ผ่าน constructor ถ้าอยากใช้ service ไหน ก็ initialize ใน constructor ได้เลย
            // สรุปง่ายๆ Form ไหนที่ต้องการใช้ Services จาก ServiceCollection ต้องฉีดเข้าไปใน ServiceCollection ด้วย เช่น frmMain
            // และ Form แม่ ที่ต้องการเปิด Form ลูก ให้ฉีด IServiceProvider เข้าไปที่ Constructor เพื่อเปิด Form อื่นต่อไป
            
            //services.AddTransient<CheckupForm>();
            services.AddTransient<IFormFactory, FormFactory>();
            services.AddTransient<LoginForm>();
            services.AddTransient<MainForm>();
            services.AddTransient<CheckUpListForm>();
            services.AddTransient<RecommendationForm>();
            services.AddTransient<SyncDataForm>();
            services.AddTransient<ReportCenter>();
        }

        private static void ConfigureThaiCulture()
        {
            var thaiCulture = new CultureInfo("th-TH");
            thaiCulture.DateTimeFormat.Calendar = new ThaiBuddhistCalendar();
            CultureInfo.DefaultThreadCurrentCulture = thaiCulture;
            CultureInfo.DefaultThreadCurrentUICulture = thaiCulture;
            Thread.CurrentThread.CurrentCulture = thaiCulture;
            Thread.CurrentThread.CurrentUICulture = thaiCulture;
        }

        static void SetLaunchProfile(string profileName)
        {
            // ตั้งค่าตาม launchSettings.json ด้วยตนเอง
            switch (profileName)
            {
                case "CheckupDev":
                    Environment.SetEnvironmentVariable("DOTNET_ENVIRONMENT", "Development");
                    Environment.SetEnvironmentVariable("DOTNET_SYSTEM_GLOBALIZATION_INVARIANT", "0");
                    break;

                case "CheckupProd":
                    Environment.SetEnvironmentVariable("DOTNET_ENVIRONMENT", "Production");
                    Environment.SetEnvironmentVariable("DOTNET_SYSTEM_GLOBALIZATION_INVARIANT", "0");
                    break;
            }
        }
    }
}
