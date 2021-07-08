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

        #region Vehicle Owner
        IEnumerable<Viewcompanycustomers> GetVehicleownerslist();
        Viewcompanycustomers GetVehicleownerdetailbycode(long ownercode);
        GenericModel Addvehicleowner(Companycustomers entity);
        GenericModel Editvehicleowner(Companycustomers entity);
        GenericModel Addvehicle(Companyvehicles entity);
        Companyvehicles GetCompanyvehiclesdetailbycode(long Vehiclecode);
        GenericModel Addnextofkin(Supportcustomers entity);
        IEnumerable<Viewcompanyvehicles> GetViewcompanyvehiclesdetailbycode(long ownercode);
        IEnumerable<Viewnextofkins> GetViewnextofkinsdetailbycode(long ownercode);
        GenericModel Deletecompanycustomer(long Custcode);
        #endregion

        #region Company Customers
        IEnumerable<Viewcompanycustomers> Getcompanycustomerslist();
        GenericModel FinishAssigndetails(Assigncustomercar entity);
        Viewassignedreciept GetAssignvehicledetailreport(long Assigncode);
        IEnumerable<Viewassignedreciept> GetAssignvehicledetailData();
        #endregion

        #region Vehicle Types
        IEnumerable<Viewcompanyvehicles> GetVehicletypelist();
        GenericModel Addvehicletype(Compvehicletypes entity);
        Compvehicletypes GetVehicletypebycode(long Typecode);
        GenericModel Editvehicletype(Compvehicletypes entity);
        GenericModel Addvehicletypehireterms(Vehicletypehireterms entity);
        GenericModel Editvehicletypehireterms(Vehicletypehireterms entity);
        Vehicletypehireterms Getvehicletypehiretermsbycode(long Typecode);
        GenericModel Checkinvehicle(long Assigncode, long Vehiclecode);
        #endregion

    }
}
