using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
    public class Companyvehicles
    {
        public long Vehiclecode { get; set; }
        public long Custcode { get; set; }
        public long Modelcode { get; set; }
        public long Makecode { get; set; }
        public string Regno { get; set; }
        public string Capacity { get; set; }
        public string Fueltype { get; set; }
        public string Chasno { get; set; }
        public string Enginesize { get; set; }
        public long Createdby { get; set; }
    }
}
