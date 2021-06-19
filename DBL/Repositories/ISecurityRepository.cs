using DBL.Entities;
using DBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL.Repositories
{
    public interface ISecurityRepository
    {
        #region Login client
        GenericModel Login(string userName);
        #endregion

        #region  System Menus
        IEnumerable<Vw_menus> MenusGetByProfile(int profilecode);
        #endregion
    }
}
