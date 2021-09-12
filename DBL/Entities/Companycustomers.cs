using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
    [Table("Companycustomers")]
    public class Companycustomers
    {
        [NotMapped]
        public static string TableName { get { return "Companycustomers"; } }

        public long Custcode { get; set; }
        [Display(Name="Firstname")]
        public string Firstname { get; set; }
        [Display(Name = "Laststname")]
        public string Lastname { get; set; }
        [Display(Name = "Email")]
        public string Emailadd { get; set; }
        [Display(Name = "Phone")]
        public string Phoneno { get; set; }
        [Display(Name = "Alternative No.")]
        public string Altphoneno { get; set; }
        [Display(Name = "Idnumber")]
        public string Idnumber { get; set; }
        [Display(Name = "Customer Type")]
        public int Custtype { get; set;}

        [Display(Name = "Occupation")]
        public string Occupation { get; set; }
        [Display(Name = "Residence")]
        public string Residence { get; set; }
        [Display(Name = "Describe")]
        public string Descriptions { get; set; }
        [Display(Name = "Personal Obligations")]
        public string Obligations { get; set; }
        public long Createdby { get; set;}
    }
}
