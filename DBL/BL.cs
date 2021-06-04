﻿using DBL.Helpers;
using DBL.Models;
using DBL.UOW;
using System;
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

        #region Sleeq Cars Data
        //public Task<GenericModel> Poststorydata(Bloghubposts obj)
        //{
        //    return Task.Run(() =>
        //    {
        //        var Resp = db.MaintenanceRepository.Poststorydata(obj);
        //        return Resp;
        //    });
        //}
        #endregion
    }
}
