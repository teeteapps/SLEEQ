using Dapper;
using DBL.Entities;
using DBL.Enum;
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
    public class SecurityRepository : BaseRepository, ISecurityRepository
    {
        public SecurityRepository(string connectionString) : base(connectionString)
        {
        }

        #region Staff
        public IEnumerable<Viewstaffs> Getstaffs()
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Viewstaffs>(GetAllStatement(Viewstaffs.TableName)).ToList();
            }
        }
        public GenericModel Addstaff(Staffs entity)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Firstname", entity.Firstname);
                parameters.Add("@Lastname", entity.Lastname);
                parameters.Add("@Emailadd", entity.Emailadd);
                parameters.Add("@Phonenumber", entity.Phonenumber);
                parameters.Add("@Passwordhash", entity.Passwordhash);
                parameters.Add("@Createdby", entity.Createdby);
                parameters.Add("@Modifiedby", entity.Modifiedby);
                return connection.Query<GenericModel>("Usp_Addstaff", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        public Staffs Getstaffbycode(long Usercode)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                return connection.Query<Staffs>(FindStatement(Staffs.TableName, "Usercode"), new { Id = Usercode }).FirstOrDefault();
            }
        }
        public GenericModel Editstaff(Staffs entity)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Usercode", entity.Usercode);
                parameters.Add("@Firstname", entity.Firstname);
                parameters.Add("@Lastname", entity.Lastname);
                parameters.Add("@Emailadd", entity.Emailadd);
                parameters.Add("@Phonenumber", entity.Phonenumber);
                parameters.Add("@Modifiedby", entity.Modifiedby);
                return connection.Query<GenericModel>("Usp_Editstaff", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        public GenericModel Deletestaff(long Usercode,long Modifiedby)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Usercode", Usercode);
                parameters.Add("@Modifiedby", Modifiedby);
                return connection.Query<GenericModel>("Usp_Deletestaff", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        public GenericModel Changepassword(Changepassword entity)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@UserCode", entity.UserCode);
                parameters.Add("@Newpassword", entity.Newpassword);
                return connection.Query<GenericModel>("Usp_Changepassword", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        #endregion

        #region Login User
        public GenericModel Login(string userName)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Emailaddress", userName);

                return connection.Query<GenericModel>("Usp_VerifyUser", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        #endregion

        #region Get Menus
        public IEnumerable<Vw_menus> MenusGetByProfile(int profilecode)
        {
            using (IDbConnection Connection = new SqlConnection(_connString))
            {
                var d = Connection.Query<Vw_menus>(FindStatement(Vw_menus.TableName, "ProfileCode"), param: new { Id = profilecode }).ToList();
                return d;
            }
        }
        #endregion

        #region Other Methods
        public IEnumerable<ListModel> GetListModel(ListModelType listType)
        {
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();

                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Type", (int)listType);

                return connection.Query<ListModel>("Usp_GetListModel", parameters, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        #endregion
    }
}
