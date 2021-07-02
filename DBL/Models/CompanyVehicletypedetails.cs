using DBL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Models
{
    public class CompanyVehicletypedetails
    {
        public Compvehicletypes Vehtypes { get; set; }
        public IEnumerable<Vehicletypehireterms> Hireterms { get; set; }
    }
}
