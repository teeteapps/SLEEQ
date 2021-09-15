using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Models
{
    [Table("Viewcompanycustomers")]
    public class Viewcompanycustomers
    {
        [NotMapped]
        public static string TableName { get { return "Viewcompanycustomers"; } }
        public long Custcode { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Emailadd { get; set; }
        public string Phoneno { get; set; }
        public string Idnumber { get; set; }
        public int Kinscount { get; set; }
        public long Custtype { get; set; }
        public string Custtypename { get; set; }
        public bool Isactive { get; set; }
        public DateTime Datecreated { get; set; }
    }
}
