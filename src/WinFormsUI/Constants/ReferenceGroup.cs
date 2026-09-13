namespace SUTH.HealthCheckup.WinFormsUI.Constants
{
    [Obsolete("Use Smart Enums from SUTH.HealthCheckup.Domain.Enums instead (e.g. ExamResult, CheckupStatus). See SmartEnumBindingHelper for dropdown binding.")]
    public class ReferenceGroup
    {
        public static readonly int General = 1;
        public static readonly int LAB = 2;
        public static readonly int Xray = 3;
        public static readonly int BMD = 4;
        public static readonly int ABI = 5;
        public static readonly int CheckupStatus = 6;
        public static readonly int VA = 7;
        public static readonly int EYE = 8;
        public static readonly int Audiogram = 9;
    }
}
