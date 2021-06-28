using DBL.Entities;
using DBL.Helpers;
using DBL.Models;
using DBL.UOW;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DBL
{
    public class BL
    {
        private UnitOfWork db;
        private string _connString;
        //EncryptDecrypt sec = new EncryptDecrypt();
        public BL(string connString)
        {
            this._connString = connString;
            db = new UnitOfWork(connString);
        }

        #region Login 
        public Task<UserModel> Login(string userName, string password)
        {
            return Task.Run(() =>
            {
                UserModel userModel = new UserModel { };
                var resp = db.SecurityRepository.Login(userName);
                if (resp.RespStatus == 0)
                {
                    EncryptDecrypt sec = new EncryptDecrypt();
                    string enccpass = sec.Encrypt(password);
                    string descpass = sec.Decrypt(resp.Data4);

                    if (password == descpass)
                    {
                        userModel = new UserModel
                        {
                            Subcode = Convert.ToInt64(resp.Data1),
                            Fullname = resp.Data2,
                            PhoneNo = resp.Data3,
                            Email = resp.Data5,
                            profilecode = Convert.ToInt32(resp.Data6),
                            Loginstatus = Convert.ToInt32(resp.Data7),
                            Parentcode = Convert.ToInt64(resp.Data8)

                        };
                        return userModel;
                    }
                    else
                    {
                        userModel.RespStatus = 1;
                        userModel.RespMessage = "Incorrect Password!";
                    }
                }
                else
                {
                    userModel.RespStatus = 1;
                    userModel.RespMessage = "Incorrect Password!";
                }

                return userModel;
            });
        }
        #endregion

        #region Add Sleeq Cars Data
        public Task<GenericModel> Addsleeqcar(Sleeqcars obj)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.Addsleeqcar(obj);
                return Resp;
            });
        }
        #endregion

        #region Get Vehicles List
        public Task<IEnumerable<Sleeqcars>> GetCompanyvehicles()
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.GetCompanyvehicles();
                return Resp;
            });
        }
        #endregion

        #region Get Vehicles Details
        public Task<Sleeqcars> GetCompanyvehiclesbycode(long Sleeqcarcode)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.GetCompanyvehiclesbycode(Sleeqcarcode);
                return Resp;
            });
        }
        #endregion

        #region add Vehicle Hire Days
        public Task<GenericModel> Addvehiclehiredays(Vehiclehiredays obj)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.Addvehiclehiredays(obj);
                return Resp;
            });
        }
        #endregion

        #region Get Vehicles Hire Days
        public Task<IEnumerable<Vehiclehiredays>> GetVehiclehiredaysbycode(long Sleeqcarcode)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.GetVehiclehiredaysbycode(Sleeqcarcode);
                return Resp;
            });
        }
        #endregion

        #region Add Vehicle Owners
        public Task<GenericModel> Addvehicleowner(Vehicleowners obj)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.Addvehicleowner(obj);
                return Resp;
            });
        }
        #endregion

        #region GetMenus
        public Task<IEnumerable<Vw_menus>> getMenus(int profilecode)
        {
            return Task.Run(() => db.SecurityRepository.MenusGetByProfile(profilecode));
        }
        #endregion
    }
}
