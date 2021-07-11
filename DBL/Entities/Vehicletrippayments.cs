using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
    public class Vehicletrippayments
    {
        public long Assigncode { get; set; }
        public int Paymentmode { get; set; }
        public double Tripamount { get; set; }
        public double Tripbalance { get; set; }
        public double Paidamount { get; set; }
        public string Paidby { get; set; }
        public long Createdby { get; set; }
    }
}
