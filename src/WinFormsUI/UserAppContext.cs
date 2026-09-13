using System.Security.Claims;

namespace SUTH.HealthCheckup.WinFormsUI
{
    public static class UserAppContext
    {
        public static string NameIdentifier { get; set; }
        public static string Name { get; set; }
        public static string EmployeeId { get; set; }
        public static string DoctorCode { get; set; }
        public static string Position { get; set; }
        public static string LoginName { get; set; }
        public static string IdentityToken { get; set; }
        public static string AccessToken { get; set; }
        public static List<Claim> Claims { get; set; }
        public static bool HasAdminRole { get; set; }
        public static bool HasDoctorRole { get; set; }
        public static bool HasNurseRole { get; set; }
        public static bool IsBeCheckupGroup { get; set; }
        public static bool IsMachineLogin { get; set; }
    }
}
