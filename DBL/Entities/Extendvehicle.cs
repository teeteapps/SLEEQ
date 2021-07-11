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
        public string Expecteddate { get; set; }
        public DateTime Returndate { get; set; }
        public int Days { get; set; }
        public long Createdby { get; set; }
    }
}
