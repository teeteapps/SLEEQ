using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
    [Table("VehicleMakes")]
    public class VehicleMakes
    {
        [NotMapped]
        public static string TableName { get { return "VehicleMakes"; } }
        public long Makecode { get; set; }
        public string Makename { get; set; }
    }
}
