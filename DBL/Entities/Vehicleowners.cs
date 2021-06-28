using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
    public class Vehicleowners
    {
        public long Ownercode { get; set; }
        public string Ownerfirstname { get; set; }
        public string Ownerlastname { get; set; }
        public string Owneremail { get; set; }
        public string Ownerphone { get; set; }
        public string Owneridno { get; set; }
        public int Ownertype { get; set;}
        public long Createdby { get; set;}
    }
}
