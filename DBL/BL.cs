using DBL.Entities;
using DBL.Enum;
using DBL.Helpers;
using DBL.Models;
using DBL.UOW;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace DBL
{
    public class BL
    {
        private UnitOfWork db;
        private string _connString;
        Passwordgenerator pass = new Passwordgenerator();
        EncryptDecrypt sec = new EncryptDecrypt();
        public BL(string connString)
        {
            this._connString = connString;
            db = new UnitOfWork(connString);
        }

        #region staffs
        public Task<IEnumerable<Viewstaffs>> Getstaffs()
        {
            return Task.Run(() =>
            {
                var Resp = db.SecurityRepository.Getstaffs();
                return Resp;
            });
        }
        public Task<GenericModel> Addstaff(Staffs obj)
        {
            return Task.Run(() =>
            {
                string password = pass.RandomPassword();
                obj.Passwordhash = sec.Encrypt(password);
                var Resp = db.SecurityRepository.Addstaff(obj);
                return Resp;
            });
        }
        public Task<Staffs> Getstaffbycode(long Usercode)
        {
            return Task.Run(() =>
            {
                var Resp = db.SecurityRepository.Getstaffbycode(Usercode);
                return Resp;
            });
        }
        public Task<GenericModel> Editstaff(Staffs obj)
        {
            return Task.Run(() =>
            {
                var Resp = db.SecurityRepository.Editstaff(obj);
                return Resp;
            });
        }
        public Task<GenericModel> Deletestaff(long Usercode, long Modifiedby)
        {
            return Task.Run(() =>
            {
                var Resp = db.SecurityRepository.Deletestaff(Usercode, Modifiedby);
                return Resp;
            });
        }
        #endregion

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

        #region Vehicle Owners
        public Task<IEnumerable<Viewcompanycustomers>> GetVehicleownerslist()
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.GetVehicleownerslist();
                return Resp;
            });
        }
        public Task<Viewcompanycustomers> GetVehicleownerdetailbycode(long ownercode)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.GetVehicleownerdetailbycode(ownercode);
                return Resp;
            });
        }
        public Task<IEnumerable<Viewcompanyvehicles>> GetViewcompanyvehiclesdetailbycode(long ownercode)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.GetViewcompanyvehiclesdetailbycode(ownercode);
                return Resp;
            });
        }
        public Task<IEnumerable<Viewnextofkins>> GetViewnextofkinsdetailbycode(long ownercode)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.GetViewnextofkinsdetailbycode(ownercode);
                return Resp;
            });
        }
        public Task<GenericModel> Addvehicleowner(Companycustomers obj)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.Addvehicleowner(obj);
                return Resp;
            });
        }
        public Task<GenericModel> Editvehicleowner(Companycustomers obj)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.Editvehicleowner(obj);
                return Resp;
            });
        }
        public Task<GenericModel> Addvehicle(Companyvehicles obj)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.Addvehicle(obj);
                return Resp;
            });
        }
        public Task<Companyvehicles> GetCompanyvehiclesdetailbycode(long Vehiclecode)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.GetCompanyvehiclesdetailbycode(Vehiclecode);
                return Resp;
            });
        }
        public Task<GenericModel> Addnextofkin(Supportcustomers obj)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.Addnextofkin(obj);
                return Resp;
            });
        }
        public Task<GenericModel> Deletecompanycustomer(long Custcode)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.Deletecompanycustomer(Custcode);
                return Resp;
            });
        }
        #endregion

        #region Company Customers
        public Task<IEnumerable<Viewcompanycustomers>> Getcompanycustomerslist()
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.Getcompanycustomerslist();
                return Resp;
            });
        }
        public Task<GenericModel> FinishAssigndetails(Assigncustomercar obj)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.FinishAssigndetails(obj);
                return Resp;
            });
        }
        public Task<Viewassignedreciept> GetAssignvehicledetailreport(long Assigncode)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.GetAssignvehicledetailreport(Assigncode);
                return Resp;
            });
        }
        public Task<IEnumerable<Viewassignedreciept>> GetAssignvehicledetailData()
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.GetAssignvehicledetailData();
                return Resp;
            });
        }
        #endregion

        #region Vehicle Types
        public Task<IEnumerable<Viewcompanyvehicles>> GetVehicletypelist()
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.GetVehicletypelist();
                return Resp;
            });
        }
        public Task<GenericModel> Addvehicletype(Compvehicletypes obj)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.Addvehicletype(obj);
                return Resp;
            });
        }
        public Task<GenericModel> Editvehicletype(Compvehicletypes obj)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.Editvehicletype(obj);
                return Resp;
            });
        }
        public Task<Compvehicletypes> GetVehicletypebycode(long Typecode)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.GetVehicletypebycode(Typecode);
                return Resp;
            });
        }
        public Task<GenericModel> Addvehicletypehireterms(Vehicletypehireterms obj)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.Addvehicletypehireterms(obj);
                return Resp;
            });
        }
        public Task<Vehicletypehireterms> Getvehicletypehiretermsbycode(long Typecode)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.Getvehicletypehiretermsbycode(Typecode);
                return Resp;
            });
        }

        public Task<GenericModel> Editvehicletypehireterms(Vehicletypehireterms obj)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.Editvehicletypehireterms(obj);
                return Resp;
            });
        }
        public Task<GenericModel> Checkinvehicle(long Assigncode,long Vehiclecode)
        {
            return Task.Run(() =>
            {
                var Resp = db.MaintenanceRepository.Checkinvehicle(Assigncode,Vehiclecode);
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

        #region Email
        public void Sendregistrationemail(string emailto, string subject, string emailbody)
        {
            string smtphost = "mail.mohoro.co.ke";
            string smtppass = "K@ribun1";
            string smtpuser = "support@mohoro.co.ke";
            using (MailMessage mm = new MailMessage(smtpuser, emailto))
            {
                mm.Subject = subject;
                mm.Body = emailbody;
                mm.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.EnableSsl = false;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(smtpuser, smtppass);
                    smtp.Host = smtphost;
                    smtp.Port = 25;
                    //smtp.Port = 8889;
                    smtp.Send(mm);

                }
            }
        }
        #endregion

        #region List Models
        public Task<IEnumerable<ListModel>> GetListModel(ListModelType listType)
        {
            return Task.Run(() =>
            {
                return db.SecurityRepository.GetListModel(listType);
            });
        }
        #endregion
    }
}
