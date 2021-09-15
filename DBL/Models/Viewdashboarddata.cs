using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Models
{
    [Table("Viewdashboarddata")]
    public class Viewdashboarddata
    {
        [NotMapped]
        public static string TableName { get { return "Viewdashboarddata"; } }
        public int Customers { get; set; }
        public int Vehicles { get; set; }
        public int Parkedvehicles { get; set; }
        public int Hiredvehicles { get; set; }
    }
}
