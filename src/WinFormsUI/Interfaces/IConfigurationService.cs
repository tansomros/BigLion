using SUTH.HealthCheckup.WinFormsUI.Models;

namespace SUTH.HealthCheckup.WinFormsUI.Interfaces;
public interface IConfigurationService
{
    AppSettings Settings { get; }
    string Environment { get; }
    bool IsDevelopment { get; }
    bool IsProduction { get; }
}
