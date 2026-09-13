namespace SUTH.HealthCheckup.WinFormsUI.Interfaces;
public interface IFormFactory
{
    T Create<T>(params object[] parameters) where T : DevExpress.XtraEditors.XtraForm;
}
