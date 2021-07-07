 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
	[Table("Staffs")]
	public class Staffs
	{
		[NotMapped]
		public static string TableName { get { return "Staffs"; } }
		public long Usercode { get; set; }
		public string Firstname { get; set; }
		public string Lastname { get; set; }
		public string Emailadd { get; set; }
		public string Phonenumber { get; set; }
		public string Passwordhash { get; set; }
		public long Createdby { get; set; }
		public long Modifiedby { get; set; }
	}
}
