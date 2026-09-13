using System.IO;
using Microsoft.Extensions.Configuration;
using SUTH.HealthCheckup.WinFormsUI.Interfaces;
using SUTH.HealthCheckup.WinFormsUI.Models;

namespace SUTH.HealthCheckup.WinFormsUI.Services;
public class ConfigurationService : IConfigurationService
{
    private readonly IConfiguration _configuration;

    public AppSettings Settings { get; }

    public string Environment { get; }

    public bool IsDevelopment => Environment == "Development";

    public bool IsProduction => Environment == "Production";

    public ConfigurationService()
    {
        var basePath = AppContext.BaseDirectory;
        Environment = System.Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ?? "Development";

        var fileName = $"appsettings.{Environment}.json";
        var fullPath = Path.Combine(basePath, fileName);

        if (!File.Exists(fullPath))
        {
            throw new FileNotFoundException($"Config file not found: {fullPath}");
        }
        
        var builder = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile($"appsettings.{Environment}.json", optional: false, reloadOnChange: false)
            .AddEnvironmentVariables();

        _configuration = builder.Build();
        Settings = new AppSettings();
        _configuration.Bind(Settings);
    }
}
