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
        public Sleeqcars compan { get; set; }
        public IEnumerable<Compvehicletypes> sleeqcars { get; set; }
    }
}
