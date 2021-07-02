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

        #region Vehicles Owner lists
        public IEnumerable<Viewcompanycustomers> GetVehicleownerslist()
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Viewcompanycustomers>(FindStatementnot(Viewcompanycustomers.TableName, "Custtype"), new { Id = 300 }).ToList();
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
        public IEnumerable<Viewcompanyvehicles> GetViewcompanyvehiclesdetailbycode(long ownercode)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Viewcompanyvehicles>(FindStatement(Viewcompanyvehicles.TableName, "Custcode"), new { Id = ownercode }).ToList();
            }
        }
        public IEnumerable<Viewnextofkins> GetViewnextofkinsdetailbycode(long ownercode)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Viewnextofkins>(FindStatement(Viewnextofkins.TableName, "Custcode"), new { Id = ownercode }).ToList();
            }
        }
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
       
        public GenericModel Addvehicle(Companyvehicles entity)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Custcode", entity.Custcode);
                parameters.Add("@Regno", entity.Regno);
                parameters.Add("@Color", entity.Color);
                parameters.Add("@Fueltype", entity.Fueltype);
                parameters.Add("@Enginesize", entity.Enginesize);
                parameters.Add("@Chasno", entity.Chasno);
                parameters.Add("@Typecode", entity.Typecode);
                parameters.Add("@Createdby", entity.Createdby);
                return connection.Query<GenericModel>("Usp_Addvehicle", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        public Companyvehicles GetCompanyvehiclesdetailbycode(long Vehiclecode)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Companyvehicles>(FindStatement(Companyvehicles.TableName, "Vehiclecode"), new { Id = Vehiclecode }).FirstOrDefault();
            }
        }
        public GenericModel Addnextofkin(Supportcustomers entity)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Custcode", entity.Custcode);
                parameters.Add("@Fullname", entity.Fullname);
                parameters.Add("@Phonenumber", entity.Phonenumber);
                parameters.Add("@Idnumber", entity.Idnumber);
                parameters.Add("@Relation", entity.Relation);
                parameters.Add("@Createdby", entity.Createdby);
                return connection.Query<GenericModel>("Usp_Addnextofkin", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        #endregion

        #region Company Customers 
        public IEnumerable<Viewcompanycustomers> Getcompanycustomerslist()
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Viewcompanycustomers>(FindStatement(Viewcompanycustomers.TableName, "Custtype"), new { Id = 300 }).ToList();
            }
        }
        #endregion


        #region Vehicle Types
        public IEnumerable<Compvehicletypes> GetVehicletypelist()
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Compvehicletypes>(GetAllStatement(Compvehicletypes.TableName)).ToList();
            }
        }
        public GenericModel Addvehicletype(Compvehicletypes entity)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Typename", entity.Typename);
                parameters.Add("@Capacity", entity.Capacity);
                parameters.Add("@Cartype", entity.Cartype);
                parameters.Add("@Imagepath", entity.Imagepath);
                parameters.Add("@Createdby", entity.Createdby);
                return connection.Query<GenericModel>("Usp_Addvehicletype", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        public Compvehicletypes GetVehicletypebycode(long Typecode)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Compvehicletypes>(FindStatement(Compvehicletypes.TableName, "Typecode"), new { Id = Typecode }).FirstOrDefault();
            }
        }
        public GenericModel Editvehicletype(Compvehicletypes entity)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Typecode", entity.Typecode);
                parameters.Add("@Typename", entity.Typename);
                parameters.Add("@Capacity", entity.Capacity);
                parameters.Add("@Cartype", entity.Cartype);
                parameters.Add("@Imagepath", entity.Imagepath);
                parameters.Add("@Createdby", entity.Createdby);
                return connection.Query<GenericModel>("Usp_Editvehicletype", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public GenericModel Addvehicletypehireterms(Vehicletypehireterms entity)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Typecode", entity.Typecode);
                parameters.Add("@Hireday", entity.Hireday);
                parameters.Add("@Hireprice", entity.Hireprice);
                return connection.Query<GenericModel>("Usp_Addvehicletypehireterms", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        public IEnumerable<Vehicletypehireterms> Getvehicletypehiretermsbycode(long Typecode)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Vehicletypehireterms>(FindStatement(Vehicletypehireterms.TableName, "Typecode"), new { Id = Typecode }).ToList();
            }
        }

        #endregion
    }
}
