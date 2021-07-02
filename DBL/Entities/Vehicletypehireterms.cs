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
		public long Hiretermcode { get; set; }
		public long Typecode { get; set; }
		public string Hirefrom { get; set; }
		public string Hireto { get; set; }
		public double Hireprice { get; set; }
	}
}
