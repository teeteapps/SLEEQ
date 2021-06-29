using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Models
{
    [Table("Viewvehicleowners")]
    public class Viewvehicleowners
    {
        [NotMapped]
        public static string TableName { get { return "Viewvehicleowners"; } }
        public long Vehicleownercode { get; set; }
        public string Ownerfirstname { get; set; }
        public string Ownerlastname { get; set; }
        public string Owneremail { get; set; }
        public string Ownerphone { get; set; }
        public string Owneridno { get; set; }
        public long Ownertype { get; set; }
        public bool Isactive { get; set; }
        public DateTime Datecreated { get; set; }
    }
}
