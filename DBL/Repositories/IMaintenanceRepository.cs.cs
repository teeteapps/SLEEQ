using DBL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Repositories
{
    public interface IMaintenanceRepository
    {
        #region Add Company Vehicles
         GenericModel Addsleeqcar(Sleeqcars entity);
        #endregion

        #region  Get All Company vehicles
        IEnumerable<Sleeqcars> GetCompanyvehicles();
        #endregion

        #region Get Company Vehicle Details
        Sleeqcars GetCompanyvehiclesbycode(long Sleeqcarcode);
        #endregion

        #region Vehicle Hire Days
        GenericModel Addvehiclehiredays(Vehiclehiredays entity);
        IEnumerable<Vehiclehiredays> GetVehiclehiredaysbycode(long Sleeqcarcode);
        #endregion

        #region Add Vehicle Owners
        GenericModel Addvehicleowner(Vehicleowners entity);
        #endregion

    }
}
