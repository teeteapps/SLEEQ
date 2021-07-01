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
    public class Compvehicletypes
    {
        public long Typecode { get; set; }
        public string Typename { get; set; }
        public long Cartype { get; set; }
        public long Capacity { get; set; }
        public string Imagepath { get; set; }
        [Display(Name = "Vehicle Image")]
        [Required(ErrorMessage = "Please select a file!")]
        [DataType(DataType.Upload)]
        [MaxFileSize(5 * 1024 * 1024)]
        [AllowedExtensions(new string[] { ".jpg", ".png", ".jpeg" })]
        public IFormFile Vehicleimage { get; set; }
        public long Createdby { get; set; }
    }
}
