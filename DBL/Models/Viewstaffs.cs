using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Models
{
    [Table("Viewstaffs")]
    public class Viewstaffs
    {
        [NotMapped]
        public static string TableName { get { return "Viewstaffs"; } }
        public long Usercode { get; set; }
        public string Fullname { get; set; }
        public string Emailadd { get; set; }
        public string Staffrole { get; set; }
        public string Phonenumber { get; set; }
        public DateTime Datecreated { get; set; }
    }
}
