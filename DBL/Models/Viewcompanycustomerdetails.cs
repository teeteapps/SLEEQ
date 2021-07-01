using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Models
{
    public class Viewcompanycustomerdetails
    {
        public Viewcompanycustomers Customer { get; set; }
        public IEnumerable<Viewcompanyvehicles> Vehicles { get; set; }
        public IEnumerable<Viewnextofkins> Nextofkin { get; set; }
    }
}
