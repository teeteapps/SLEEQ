 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
		[Display(Name ="Firstname")]
		[Required(ErrorMessage ="Firstname is required!")]
		public string Firstname { get; set; }
		[Display(Name = "Lastname")]
		[Required(ErrorMessage = "Lastname is required!")]
		public string Lastname { get; set; }
		[Display(Name = "Email")]
		[Required(ErrorMessage = "Email is required!")]
		[DataType(DataType.EmailAddress)]
		public string Emailadd { get; set; }
		[Display(Name = "Phone")]
		[Required(ErrorMessage = "Phone is required!")]
		[DataType(DataType.PhoneNumber)]
		public string Phonenumber { get; set; }
		[Display(Name ="Profile")]
		public long Rolecode { get; set; }
		public string Passwordhash { get; set; }
		public long Createdby { get; set; }
		public long Modifiedby { get; set; }
	}
}
