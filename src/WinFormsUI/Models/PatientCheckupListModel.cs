using SUTH.HealthCheckup.WinFormsUI.Functions;

namespace SUTH.HealthCheckup.WinFormsUI.Models
{
    public class PatientCheckupListModel
    {
        public int Id { get; set; }
        public string QueueNumber { get; set; }
        public string Room { get; set; }
        public int QueueHis { get; set; }
        public string Name { get; set; }
        public string Doctor { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }
        public LabStatus Lab { get; set; }
        public XRayStatus Xray { get; set; }
    }
}
