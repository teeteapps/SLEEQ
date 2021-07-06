using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
	[Table("Vehicletypehireterms")]
	public class Vehicletypehireterms
	{
		[NotMapped]
		public static string TableName { get { return "Vehicletypehireterms"; } }
		public long Termcode { get; set; }
		public long Typecode { get; set; }
		public decimal Mondayprice { get; set; }
		public decimal Tuesdayprice { get; set; }
		public decimal Wednesdayprice { get; set; }
		public decimal Thursdayprice { get; set; }
		public decimal Fridayprice { get; set; }
		public decimal Saturdayprice { get; set; }
		public decimal Sundayprice { get; set; }
	}
}
