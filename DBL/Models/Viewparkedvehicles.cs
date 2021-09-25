using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Models
{
    [Table("Viewparkedvehicles")]
    public class Viewparkedvehicles
    {
        [NotMapped]
        public static string TableName { get { return "Viewparkedvehicles"; } }
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
