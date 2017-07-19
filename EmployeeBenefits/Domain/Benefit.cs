using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Benefit
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Employee Employee { get; set; }
    }
}
