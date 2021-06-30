using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
    public class Supportcustomers
    {
        public long Supcustcode { get; set; }
        public long Custcode { get; set; }
        public long Relation { get; set; }
        public string Fullname { get; set; }
        public string Phonenumber { get; set; }
        public string Idnumber { get; set; }
        public long Createdby { get; set; }
    }
}
