using DBL.Helpers;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
    public class Sleeqcars
    {
		[Display(Name = "Vehicle Type")]
		[Required(ErrorMessage = "Vehicle Type required!")]
		public string Vehiclemodel { get; set; }
		[Display(Name = "Vehicle Seater")]
		[Required(ErrorMessage = "Vehicle Seater required!")]
		public string Vehiclecapacity { get; set; }
		[Display(Name = "Hire From Day")]
		[Required(ErrorMessage = "Hire From Day required!")]
		public string Fromday { get; set; }
		[Display(Name = "Hire To Day")]
		[Required(ErrorMessage = "Hire To Day required!")]
		public string Today { get; set; }
		[Display(Name = "Hire Amount")]
		[Required(ErrorMessage = "Hire Amount required!")]
		public double Hireprice { get; set; }
		public string Imagesource { get; set; }
		[Display(Name = "Vehicle Image")]
		[Required(ErrorMessage = "Please select a file!")]
		[DataType(DataType.Upload)]
		[MaxFileSize(5 * 1024 * 1024)]
		[AllowedExtensions(new string[] { ".jpg", ".png", ".jpeg" })]
		public IFormFile Vehicleimage { get; set; }
	}
}
