using DBL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Models
{
    public class Companyvehicledetails
    {
        public Sleeqcars sleeq { get; set; }
        public IEnumerable<Vehiclehiredays> hiredays { get; set; }
    }
}
