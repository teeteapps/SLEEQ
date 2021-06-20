using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
	[Table("Sleeqcarshiredays")]
	public class Vehiclehiredays
	{
		[NotMapped]
		public static string TableName { get { return "Sleeqcarshiredays"; } }
		public long Sleeqcarhiredayscode { get; set; }
		public long Sleeqcarcode { get; set; }
		public string Hirefrom { get; set; }
		public string Hireto { get; set; }
		public double Hireprice { get; set; }
	}
}
