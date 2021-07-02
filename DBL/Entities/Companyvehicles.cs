using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
    [Table("Companyvehicles")]
    public class Companyvehicles
    {
        [NotMapped]
        public static string TableName { get { return "Companyvehicles"; } }
        public long Vehiclecode { get; set; }
        public long Custcode { get; set; }
        public long Typecode { get; set; }
        public string Regno { get; set; }
        public string Color { get; set; }
        public string Fueltype { get; set; }
        public string Chasno { get; set; }
        public string Enginesize { get; set; }
        public long Createdby { get; set; }
    }
}
