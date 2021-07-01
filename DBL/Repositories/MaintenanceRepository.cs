using Dapper;
using DBL.Entities;
using DBL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        #region Add Company Vehicles
        public GenericModel Addsleeqcar(Sleeqcars entity)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Sleeqcar", entity.Sleeqcar);
                parameters.Add("@Seaters", entity.Seaters);
                parameters.Add("@Sleeqcarimage", entity.Sleeqcarimage);
                parameters.Add("@Fueltype", entity.Fueltype);
                parameters.Add("@Enginesize", entity.Enginesize);
                parameters.Add("@VehicleColor", entity.VehicleColor);
                parameters.Add("@Createdby", entity.Createdby);
                return connection.Query<GenericModel>("Usp_Addsleeqcar", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        #endregion

        #region Get all Company Vehicles
        public IEnumerable<Sleeqcars> GetCompanyvehicles()
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Sleeqcars>(GetAllStatement(Sleeqcars.TableName)).ToList();
            }
        }
        #endregion

        #region Get Vehicles Details
        public Sleeqcars GetCompanyvehiclesbycode(long Sleeqcarcode)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Sleeqcars>(FindStatement(Sleeqcars.TableName, "Sleeqcarcode"),new { Id= Sleeqcarcode}).FirstOrDefault();
            }
        }
        #endregion

        #region Add Vehicle Hire Days
        public GenericModel Addvehiclehiredays(Vehiclehiredays entity)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Sleeqcarcode", entity.Sleeqcarcode);
                parameters.Add("@Hirefrom", entity.Hirefrom);
                parameters.Add("@Hireto", entity.Hireto);
                parameters.Add("@Hireprice", entity.Hireprice);
                return connection.Query<GenericModel>("Usp_Addvehiclehiredays", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        #endregion

        #region Get Vehicles Hire Days
        public IEnumerable<Vehiclehiredays> GetVehiclehiredaysbycode(long Sleeqcarcode)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Vehiclehiredays>(FindStatement(Vehiclehiredays.TableName, "Sleeqcarcode"), new { Id = Sleeqcarcode }).ToList();
            }
        }
        #endregion

        #region Get Vehicles Owner lists
        public IEnumerable<Viewcompanycustomers> GetVehicleownerslist()
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Viewcompanycustomers>(GetAllStatement(Viewcompanycustomers.TableName)).ToList();
            }
        }
        public Viewcompanycustomers GetVehicleownerdetailbycode(long ownercode)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Viewcompanycustomers>(FindStatement(Viewcompanycustomers.TableName, "Custcode"), new { Id = ownercode }).FirstOrDefault();
            }
        }
        #endregion

        #region Add Vehicle Owner
        public GenericModel Addvehicleowner(Companycustomers entity)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Firstname", entity.Firstname);
                parameters.Add("@Lastname", entity.Lastname);
                parameters.Add("@Emailadd", entity.Emailadd);
                parameters.Add("@Phoneno", entity.Phoneno);
                parameters.Add("@Custtype", entity.Custtype);
                parameters.Add("@Idnumber", entity.Idnumber);
                parameters.Add("@Createdby", entity.Createdby);
                return connection.Query<GenericModel>("Usp_AddCompanycustomer", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        #endregion

        #region Vehicle Models and Makes
        public IEnumerable<Vehiclemodels> Getvehiclemodelslist()
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Vehiclemodels>(GetAllStatement(Vehiclemodels.TableName)).ToList();
            }
        }
        #endregion
    }
}
