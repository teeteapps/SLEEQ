using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Models
{
    [Table("Viewhiredvehicles")]
    public class Viewhiredvehicles
    {
        [NotMapped]
        public static string TableName { get { return "Viewhiredvehicles"; } }
        public string Fullname { get; set; }
        public string Emailaddress { get; set; }
        public string Phoneno { get; set; }
        public string Whereto { get; set; }
        public string Wheretodescription { get; set; }
        public long Hiredays { get; set; }
        public long Assigncode { get; set; }
        public double Hireamount { get; set; }
        public double Carwash { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Dateissued { get; set; }
        public string Hiringdays { get; set; }
        public double Hiringprice { get; set; }
        public DateTime Enddate { get; set; }
        public long Vehiclecode { get; set; }
        public long Custcode { get; set; }
        public string Regno { get; set; }
        public string Typename { get; set; }
        public string Imagepath { get; set; }
        public string Capname { get; set; }
        public string Fueltype { get; set; }
        public string Chaseno { get; set; }
        public string Color { get; set; }
        public string Enginesize { get; set; }
        public int Carstatus { get; set; }
        public string Statuscar { get; set; }
    }
}
