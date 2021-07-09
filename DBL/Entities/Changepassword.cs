using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
    public class Changepassword
    {
        public long UserCode { get; set; }
       [Display(Name ="New Password")]
        public string Newpassword { get; set; }
    }
}
