using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUTH.HealthCheckup.WinFormsUI.Constants
{
   [Obsolete("ใช้ SUTH.HealthCheckup.Domain.Enums.CheckupStatus แทน เช่น CheckupStatus.Pending.Value, CheckupStatus.InProgress.Value")]
   public class CheckupStatus
    {
        public const int Pending = 1;
        public const int InProgress = 2;
        public const int Completed = 3; 
    }
}
