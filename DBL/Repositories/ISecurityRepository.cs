using DBL.Entities;
using DBL.Enum;
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
        #region Dashboard Data
        Viewdashboarddata Getdashboarddata();
        #endregion

        #region Staffs
        IEnumerable<Viewstaffs> Getstaffs();
        GenericModel Addstaff(Staffs entity);
        Staffs Getstaffbycode(long Usercode);
        GenericModel Editstaff(Staffs entity);
        GenericModel Deletestaff(long Usercode, long Modifiedby);
        GenericModel Changepassword(Changepassword entity);
        #endregion

        #region Login client
        GenericModel Login(string userName);
        #endregion

        #region  System Menus
        IEnumerable<Vw_menus> MenusGetByProfile(int profilecode);
        #endregion

        #region Other Methods
         IEnumerable<ListModel> GetListModel(ListModelType listType);
        #endregion
    }
}
