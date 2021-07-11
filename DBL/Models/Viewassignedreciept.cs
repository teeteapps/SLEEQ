using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Models
{
    [Table("Viewassignedreciept")]
    public class Viewassignedreciept
    {
        [NotMapped]
        public static string TableName { get { return "Viewassignedreciept"; } }
        public long Assigncode { get; set; }
        public long Vehiclecode { get; set; }
        public long Custcode { get; set; }
        public string Customername { get; set; }
        public string Emailadd { get; set; }
        public string Phoneno { get; set; }
        public string Vehiclereg { get; set; }
        public string Whereto { get; set; }
        public string Wheretodescription { get; set; }
        public string Hiredays { get; set; }
        public string Hiringdays { get; set; }
        public string Hiringprice { get; set; }
        public double Hireamount { get; set; }
        public double Totalhireamount { get; set; }
        public double Carwash { get; set; }
        public string Carstatus { get; set; }
        public bool Ispaid { get; set; }
        public DateTime Dateissued { get; set; }
        public DateTime Daterecieved { get; set; }
        public DateTime Dateexpected { get; set; }
        public string Hirername { get; set; }
        public string Recievername { get; set; }

    }
}
