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

        public Companycustomers Getcompanycustomerbycode(long ownercode)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Companycustomers>(FindStatement(Companycustomers.TableName, "Custcode"), new { Id = ownercode }).FirstOrDefault();
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
                parameters.Add("@Altphoneno", entity.Altphoneno);
                parameters.Add("@Custtype", entity.Custtype);
                parameters.Add("@Idnumber", entity.Idnumber);
                parameters.Add("@Createdby", entity.Createdby);
                parameters.Add("@Residence", entity.Residence);
                parameters.Add("@Occupation", entity.Occupation);
                parameters.Add("@Descriptions", entity.Descriptions);
                parameters.Add("@Obligations", entity.Obligations);
                return connection.Query<GenericModel>("Usp_AddCompanycustomer", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public GenericModel Editvehicleowner(Companycustomers entity)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Custcode", entity.Custcode);
                parameters.Add("@Firstname", entity.Firstname);
                parameters.Add("@Lastname", entity.Lastname);
                parameters.Add("@Emailadd", entity.Emailadd);
                parameters.Add("@Phoneno", entity.Phoneno);
                parameters.Add("@Altphoneno", entity.Altphoneno);
                parameters.Add("@Custtype", entity.Custtype);
                parameters.Add("@Idnumber", entity.Idnumber);
                parameters.Add("@Residence", entity.Residence);
                parameters.Add("@Occupation", entity.Occupation);
                parameters.Add("@Descriptions", entity.Descriptions);
                parameters.Add("@Obligations", entity.Obligations);
                return connection.Query<GenericModel>("Usp_EditCompanycustomer", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        public GenericModel Editvehicle(Companyvehicles entity)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Vehiclecode", entity.Vehiclecode);
                parameters.Add("@Custcode", entity.Custcode);
                parameters.Add("@Regno", entity.Regno);
                parameters.Add("@Color", entity.Color);
                parameters.Add("@Fueltype", entity.Fueltype);
                parameters.Add("@Enginesize", entity.Enginesize);
                parameters.Add("@Chasno", entity.Chasno);
                parameters.Add("@Typecode", entity.Typecode);
                return connection.Query<GenericModel>("Usp_Editvehicle", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        public Supportcustomers Getnokdetailbycode(long Supcustcode)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Supportcustomers>(FindStatement(Supportcustomers.TableName, "Supcustcode"), new { Id = Supcustcode }).FirstOrDefault();
            }
        }
        public GenericModel Editnextofkin(Supportcustomers entity)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Supcustcode", entity.Supcustcode);
                parameters.Add("@Custcode", entity.Custcode);
                parameters.Add("@Fullname", entity.Fullname);
                parameters.Add("@Phonenumber", entity.Phonenumber);
                parameters.Add("@Idnumber", entity.Idnumber);
                parameters.Add("@Relation", entity.Relation);
                return connection.Query<GenericModel>("Usp_Editnextofkin", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        public GenericModel Deletecompanycustomer(long Custcode)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Custcode", Custcode);
                return connection.Query<GenericModel>("Usp_Deletecompanycustomer", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        public GenericModel Actdeactivatecustomer(long Custcode,long Status)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Custcode", Custcode);
                parameters.Add("@Status", Status);
                return connection.Query<GenericModel>("Usp_Actdeactivatecustomer", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        public GenericModel FinishAssigndetails(Assigncustomercar entity)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Vehiclecode", entity.Vehiclecode);
                parameters.Add("@Custcode", entity.Custcode);
                parameters.Add("@Vehiclereg", entity.Vehiclereg);
                parameters.Add("@Whereto", entity.Whereto);
                parameters.Add("@Wheretodescription", entity.Wheretodescription);
                parameters.Add("@Hiredays", entity.Hiredays);
                parameters.Add("@Hiringdays", entity.Hiringdays);
                parameters.Add("@Hireamount", entity.Hireamount);
                parameters.Add("@Hireprice", entity.Hireprice);
                parameters.Add("@Carwash", entity.Carwash);
                parameters.Add("@Startdate",Convert.ToDateTime(entity.Newstartdate));
                parameters.Add("@Enddate", Convert.ToDateTime(entity.Newenddate));
                parameters.Add("@Hiredby", entity.Hiredby);
                parameters.Add("@Recievedby", entity.Recievedby);
                return connection.Query<GenericModel>("Usp_Assigncustomervehicle", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        public Viewassignedreciept GetAssignvehicledetailreport(long Assigncode)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Viewassignedreciept>(FindStatement(Viewassignedreciept.TableName, "Assigncode"), new { Id = Assigncode }).FirstOrDefault();
            }
        }
        public IEnumerable<Viewassignedreciept> GetAssignvehicledetailData()
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Viewassignedreciept>(GetAllStatement(Viewassignedreciept.TableName, "Datecreated")).ToList();
            }
        }
        #endregion

        #region Vehicle Types
        public IEnumerable<ViewcompanyVehicletypes> GetVehicletypelist()
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<ViewcompanyVehicletypes>(GetAllStatement(ViewcompanyVehicletypes.TableName)).ToList();
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
                parameters.Add("@Mondayprice", entity.Mondayprice);
                parameters.Add("@Tuesdayprice", entity.Tuesdayprice);
                parameters.Add("@Wednesdayprice", entity.Wednesdayprice);
                parameters.Add("@Thursdayprice", entity.Thursdayprice);
                parameters.Add("@Fridayprice", entity.Fridayprice);
                parameters.Add("@Saturdayprice", entity.Saturdayprice);
                parameters.Add("@Sundayprice", entity.Sundayprice);
                return connection.Query<GenericModel>("Usp_Addvehicletypehireterms", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        public GenericModel Editvehicletypehireterms(Vehicletypehireterms entity)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Termcode", entity.Termcode);
                parameters.Add("@Mondayprice", entity.Mondayprice);
                parameters.Add("@Tuesdayprice", entity.Tuesdayprice);
                parameters.Add("@Wednesdayprice", entity.Wednesdayprice);
                parameters.Add("@Thursdayprice", entity.Thursdayprice);
                parameters.Add("@Fridayprice", entity.Fridayprice);
                parameters.Add("@Saturdayprice", entity.Saturdayprice);
                parameters.Add("@Sundayprice", entity.Sundayprice);
                return connection.Query<GenericModel>("Usp_Editvehicletypehireterms", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        public Vehicletypehireterms Getvehicletypehiretermsbycode(long Typecode)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Vehicletypehireterms>(FindStatement(Vehicletypehireterms.TableName, "Typecode"), new { Id = Typecode }).FirstOrDefault();
            }
        }
        public GenericModel Checkinvehicle(long Assigncode,long Vehiclecode)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Assigncode", Assigncode);
                parameters.Add("@Vehiclecode",Vehiclecode);
                return connection.Query<GenericModel>("Usp_Checkinvehicle", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        public GenericModel Payvehicle(Vehicletrippayments entity)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Assigncode", entity.Assigncode);
                parameters.Add("@Tripbalance", entity.Tripbalance);
                parameters.Add("@Tripamount", entity.Tripamount);
                parameters.Add("@Paymentmode", entity.Paymentmode);
                parameters.Add("@Paidamount", entity.Paidamount);
                parameters.Add("@Paidby", entity.Paidby);
                parameters.Add("@Createdby", entity.Createdby);
                return connection.Query<GenericModel>("Usp_Payvehicle", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        public IEnumerable<Vehicletrippayments> Getvehiclepaymentreport(long Assigncode)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Vehicletrippayments>(FindStatement(Vehicletrippayments.TableName, "Assigncode"), new { Id = Assigncode }).ToList();
            }
        }
        public GenericModel Extendvehicle(Extendvehicle entity)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Assigncode", entity.Assigncode);
                parameters.Add("@Vehiclecode", entity.Vehiclecode);
                parameters.Add("@Noofdays", entity.Noofdays);
                parameters.Add("@Returndate", entity.Returndate);
                parameters.Add("@Expecteddate", Convert.ToDateTime(entity.Expecteddate));
                parameters.Add("@Hireamount", entity.Hireamount);
                parameters.Add("@Hireprice", entity.Hireprice);
                parameters.Add("@Hiringdays", entity.Hiringdays);
                parameters.Add("@Createdby", entity.Createdby);
                return connection.Query<GenericModel>("Usp_Extendvehicle", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        #endregion
    }
}
