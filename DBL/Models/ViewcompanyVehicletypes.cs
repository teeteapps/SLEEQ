using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Models
{
    [Table("ViewcompanyVehicletypes")]
    public class ViewcompanyVehicletypes
    {
        [NotMapped]
        public static string TableName { get { return "ViewcompanyVehicletypes"; } }
        public long Typecode { get; set; }
        public string Typename { get; set; }
        public string Capacity { get; set; }
        public string Imagepath { get; set; }
        public double Mondayprice { get; set; }
        public double Tuesdayprice { get; set; }
        public double Wednesdayprice { get; set; }
        public double Thursdayprice { get; set; }
        public double Fridayprice { get; set; }
        public double Saturdayprice { get; set; }
        public double Sundayprice { get; set; }

    }
}
