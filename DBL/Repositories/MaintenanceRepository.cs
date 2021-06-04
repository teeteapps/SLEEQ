using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Repositories
{
    public class MaintenanceRepository:BaseRepository,IMaintenanceRepository
    {
        public MaintenanceRepository(string connectionString) : base(connectionString)
        {
        }
    }
}
