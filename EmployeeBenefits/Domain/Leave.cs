using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Leave : Benefit
    {
        public LeaveType Type { get; set; }
        public int AvailableEntitlement { get; set; }
        public int RemainingEntitlement { get; set; }
    }
}
