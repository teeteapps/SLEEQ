using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
    [Table("Extendvehicle")]
    public class Extendvehicle
    {
        [NotMapped]
        public static string TableName { get { return "Extendvehicle"; } }

        public long Assigncode { get; set; }
        public long Vehiclecode { get; set; }
        public string Expecteddate { get; set; }
        public DateTime Returndate { get; set; }
        public int Noofdays { get; set; }
        public decimal Hireamount { get; set; }
        public string Hiringdays { get; set; }
        public string Hireprice { get; set; }
        public long Createdby { get; set; }
    }
}
