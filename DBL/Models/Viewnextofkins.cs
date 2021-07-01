using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Models
{
    [Table("Viewnextofkins")]
    public class Viewnextofkins
    {
        [NotMapped]
        public static string TableName { get { return "Viewnextofkins"; } }
        public long Supcustcode { get; set; }
        public long Custcode { get; set; }
        public long Relation { get; set; }
        public string Relname { get; set; }
        public string Fullname { get; set; }
        public string Phonenumber { get; set; }
        public string Idnumber { get; set; }
    }
}