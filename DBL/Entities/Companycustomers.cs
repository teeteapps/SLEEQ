using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
    
    public class Companycustomers
    {
        
        public long Custcode { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Emailadd { get; set; }
        public string Phoneno { get; set; }
        public string Idnumber { get; set; }
        public int Custtype { get; set;}
        public long Createdby { get; set;}
    }
}
