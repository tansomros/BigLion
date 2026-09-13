namespace SUTH.HealthCheckup.WinFormsUI.Models
{
    public class Master
    {
        public class StatusPost
        {
            public int UID { get; set; } 
            public string Code { get; set; }
            public string Name { get; set; }            
        }
        public class LocationFloor
        {
            public int UID { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
        }

        public class Equipment
        {
            public int UID { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
        }

        public class Hearing
        {
            public int? Id { get; set; }
            public string Hertz { get; set; }
            public string RightHz { get; set; }
            public string LeftHz { get; set; }
        }
    }
   

}
