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
