using DBL.Helpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
	[Table("Sleeqcars")]
	public class Sleeqcars
	{
		[NotMapped]
		public static string TableName { get { return "Sleeqcars"; } }
		[Display(Name = "Vehicle Name")]
		[Required(ErrorMessage = "Vehicle Name required!")]
		public string Sleeqcar { get; set; }
		[Display(Name = "Vehicle Seater")]
		[Required(ErrorMessage = "Vehicle Seater required!")]
		public string Seaters { get; set; }
		[Display(Name = "Fuel Type")]
		[Required(ErrorMessage = "Fuel Type required!")]
		public string Fueltype { get; set; }
		[Display(Name = "Engine Size")]
		[Required(ErrorMessage = "Engine Size required!")]
		public string Enginesize { get; set; }
		[Display(Name = "Vehicle Color")]
		[Required(ErrorMessage = "Vehicle Color required!")]
		public string VehicleColor { get; set; }
		public string Sleeqcarimage { get; set; }
		[Display(Name = "Vehicle Image")]
		[Required(ErrorMessage = "Please select a file!")]
		[DataType(DataType.Upload)]
		[MaxFileSize(5 * 1024 * 1024)]
		[AllowedExtensions(new string[] { ".jpg", ".png", ".jpeg" })]
		public IFormFile Vehicleimage { get; set; }
		public long Createdby{get;set;}
		public long Sleeqcarcode { get;set;}
	}
}
