using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Address : EntityBase
    {
        public virtual string AddressLine1 { get; set; }
        public virtual string AddressLine2 { get; set; }
        public virtual string Postcode { get; set; }
        public virtual string City { get; set; }
        public virtual string Country { get; set; }
    }
}
