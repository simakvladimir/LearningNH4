using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Benefit : EntityBase
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
