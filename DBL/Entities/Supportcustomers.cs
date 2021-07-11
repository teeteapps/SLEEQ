using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
    [Table("Supportcustomers")]
    public class Supportcustomers
    {
        [NotMapped]
        public static string TableName { get { return "Supportcustomers"; } }
        public long Supcustcode { get; set; }
        public long Custcode { get; set; }
        public long Relation { get; set; }
        public string Fullname { get; set; }
        public string Phonenumber { get; set; }
        public string Idnumber { get; set; }
        public long Createdby { get; set; }
    }
}
