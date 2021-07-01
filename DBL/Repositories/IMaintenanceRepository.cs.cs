using DBL.Entities;
using DBL.Models;
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

        #region Vehicle Owner list
        IEnumerable<Viewcompanycustomers> GetVehicleownerslist();
        Viewcompanycustomers GetVehicleownerdetailbycode(long ownercode);
        GenericModel Addvehicleowner(Companycustomers entity);
        GenericModel Addvehicle(Companyvehicles entity);
        GenericModel Addnextofkin(Supportcustomers entity);
        #endregion

        #region Company Customers
        IEnumerable<Viewcompanycustomers> Getcompanycustomerslist();
        #endregion

        #region Vehicle Models and makes
        IEnumerable<Vehiclemodels> Getvehiclemodelslist();
        GenericModel Addvehiclemodel(Vehiclemodels entity);
        #endregion

    }
}
