﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
    [Table("VehicleModels")]
    public  class Vehiclemodels
    {
        [NotMapped]
        public static string TableName { get { return "VehicleModels"; } }
        public long Modelcode { get; set; }
        public long Makecode { get; set; }
        public string Modelname { get; set; }
    }
}
