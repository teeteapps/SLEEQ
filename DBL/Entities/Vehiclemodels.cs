using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
    [Table("Viewcompanycustomers")]
    public  class Vehiclemodels
    {
        [NotMapped]
        public static string TableName { get { return "Viewcompanycustomers"; } }
        public long Modelcode { get; set; }
        public string Modelname { get; set; }
    }
}
