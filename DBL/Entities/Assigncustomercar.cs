using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
	[Table("Assigncustomercar")]
	public class Assigncustomercar
	{
		[NotMapped]
		public static string TableName { get { return "Assigncustomercar"; } }
		public long Assigncode { get; set; }
		public long Vehiclecode { get; set; }
		public long Custcode { get; set; }
		public DateTime Startdate { get; set; }
		public DateTime Enddate { get; set; }
		public string Newstartdate { get; set; }
		public string  Newenddate { get; set; }
		public double Hiredays { get; set; }
		public string Hireprice { get; set; }
		public string Hiringdays { get; set; }
		public string Whereto { get; set; }
		public string Wheretodescription { get; set; }
		public decimal Hireamount { get; set; }
		public decimal Carwash { get; set; }
		public long Hiredby { get; set; }
		public long Recievedby { get; set; }
		public DateTime Recievedtime { get; set; }
		public DateTime DateHired { get; set; }
		public string Vehiclereg{ get; set; }
	}

    public class Assigncardata
    {
        public long Custcode { get; set; }
		[Display(Name ="Vehicle")]
		[Required(ErrorMessage = "Vehicle registration is required")]
        public long Vehiclecode { get; set; }
		[Display(Name = "Destination")]
		[Required(ErrorMessage = "Your Destination is required")]
		public string Whereto { get; set; }
		[Display(Name = "Destination Details")]
		[Required(ErrorMessage = "Your Destination Details is required")]
		public string Wheretodescription { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
		[Display(Name = "Start Date")]
		[Required(ErrorMessage = "Your Start Date of Hire is required")]
		public DateTime Startdate { get; set; }
		[Display(Name = "Day(s) of Hire")]
		[Required(ErrorMessage ="Your Day(s) of Hire is required")]
		public long Hiredays { get; set; }
		[Display(Name = "Include Carwash")]
		public bool Hascarwash { get; set; }
    }

}
