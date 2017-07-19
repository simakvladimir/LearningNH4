using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Leave : Benefit
    {
        public virtual LeaveType Type { get; set; }
        public virtual int AvailableEntitlement { get; set; }
        public virtual int RemainingEntitlement { get; set; }
    }
}
