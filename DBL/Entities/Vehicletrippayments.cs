using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
    [Table("Vehiclepayments")]
    public class Vehicletrippayments
    {
        [NotMapped]
        public static string TableName { get { return "Vehiclepayments"; } }
        public long Assigncode { get; set; }
        public int Paymentmode { get; set; }
        public double Tripamount { get; set; }
        public double Tripbalance { get; set; }
        public double Paidamount { get; set; }
        public string Paidby { get; set; }
        public long Createdby { get; set; }
    }
}
