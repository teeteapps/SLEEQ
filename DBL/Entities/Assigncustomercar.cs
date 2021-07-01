using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Entities
{
	public class Assigncustomercar
	{
		public long Assigncode { get; set; }
		public long Vehiclecode { get; set; }
		public long Custcode { get; set; }
		public bool Isassigned { get; set; }
		public bool Custstatus { get; set; }
		public DateTime Startdate { get; set; }
		public DateTime Enddate { get; set; }
		public long Hiredays { get; set; }
		public double Hireamount { get; set; }
		public long Hiredby { get; set; }
		public long Recievedby { get; set; }
		public DateTime Recievedtime { get; set; }
		public DateTime DateHired { get; set; }
	}
}
