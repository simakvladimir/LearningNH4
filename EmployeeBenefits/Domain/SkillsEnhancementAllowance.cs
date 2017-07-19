using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SkillsEnhancementAllowance : Benefit
    {
        public int RemainingEntitlement { get; set; }
        public int Entitlement { get; set; }
    }
}
