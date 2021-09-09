using DBL;
using DBL.Entities;
using DBL.Enum;
using DBL.Helpers;
using DBL.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Sleeqcarhire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Sleeqcarhire.Controllers
{
    [Authorize]
    public class AccountController : BaseController
    {
        private readonly BL bl; 
        EncryptDecrypt sec = new EncryptDecrypt();
        public AccountController()
        {
            bl = new BL(Util.ShareConnectionString.Value);
        }

        #region System Staff
        [HttpGet]
        public async Task<IActionResult> Stafflists()
        {
            var data = await bl.Getstaffs();
            return View(data);
        }
        [HttpGet]
        public IActionResult Addstaff()
        {
            return PartialView("_Addstaff");
        }
        [HttpPost]
        public async Task<IActionResult> Addstaff(Staffs model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Createdby = SessionUserData.UserCode;
                    model.Modifiedby = SessionUserData.UserCode;
                    var resp = await bl.Addstaff(model);
                    if (resp.RespStatus==0)
                    {
                        Success(resp.RespMessage,true);
                        string Subject = "Registration Credentials";
                        string Emailbody = "Dear, "+resp.Data1+" ,<br/> Your Username is: "+resp.Data2+"<br/> and Password is: "+ sec.Decrypt(resp.Data3)+".<br/> Thankyou";
                        bl.Sendregistrationemail(resp.Data2, Subject, Emailbody);
                        return RedirectToAction("Stafflists");
                    }
                    else if (resp.RespStatus == 1)
                    {
                        Danger(resp.RespMessage,true);
                    }
                    else
                    {
                        Danger("A Database Error has occured. Contact Admin!",true);
                    }
                }
            }
            catch (Exception ex)
            {
                Util.LogError("Add staff", ex,true);
            }
            return RedirectToAction("Stafflists");
        }

        [HttpGet]
        public async Task<IActionResult> Editstaff(long Usercode)
        {
            var data = await bl.Getstaffbycode(Usercode);
            return PartialView("_Editstaff", data);
        }
        [HttpPost]
        public async Task<IActionResult> Editstaff(Staffs model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Modifiedby = SessionUserData.UserCode;
                    var resp = await bl.Editstaff(model);
                    if (resp.RespStatus == 0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("Stafflists");
                    }
                    else if (resp.RespStatus == 1)
                    {
                        Danger(resp.RespMessage, true);
                    }
                    else
                    {
                        Danger("A Database Error has occured. Contact Admin!", true);
                    }
                }
            }
            catch (Exception ex)
            {
                Util.LogError("Edit staff", ex, true);
            }
            return RedirectToAction("Stafflists");
        }
        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> Deletestaff(long Usercode)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var resp = await bl.Deletestaff(Usercode,SessionUserData.UserCode);
                    if (resp.RespStatus == 0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("Stafflists");
                    }
                    else if (resp.RespStatus == 1)
                    {
                        Danger(resp.RespMessage, true);
                    }
                    else
                    {
                        Danger("Database error occured. Please contact Admin!", true);
                    }
                }
            }
            catch (Exception ex)
            {
                Util.LogError("Delete User", ex, true);
            }
            return RedirectToAction("Stafflists");
        }
        #endregion

        #region Change and Reset Password
        [HttpGet]
        public IActionResult Changepassword(long UserCode)
        {
            Changepassword model = new Changepassword();
            model.UserCode = UserCode;
            return PartialView("_Changepassword", model);
        }
        [HttpPost]
        public async Task<IActionResult> Changepassword(Changepassword model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var resp = await bl.Changepassword(model);
                    if (resp.RespStatus == 0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("Dashboard","Home");
                    }
                    else if (resp.RespStatus == 1)
                    {
                        Danger(resp.RespMessage, true);
                    }
                    else
                    {
                        Danger("Database error occured. Please contact Admin!", true);
                    }
                }
            }
            catch (Exception ex)
            {
                Util.LogError("Change Password", ex, true);
            }
            return RedirectToAction("Dashboard","Home");
        }
        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> Resetpassword(long UserCode)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Changepassword model = new Changepassword();
                    model.UserCode = UserCode;
                    var resp = await bl.Resetpassword(model);
                    if (resp.RespStatus == 0)
                    {
                        var data = await bl.Getstaffbycode(Convert.ToInt64(resp.Data1));
                        string Subject = "Password Reset Credentials";
                        string Emailbody = "Dear, " + data.Firstname + " ,<br/> Your Username is: " + data.Emailadd + "<br/> and Password is: " + sec.Decrypt(data.Passwordhash) + ".<br/> Thankyou";
                        bl.Sendregistrationemail(data.Emailadd, Subject, Emailbody);

                        Success(resp.RespMessage, true);
                        return RedirectToAction("Stafflists");
                    }
                    else if (resp.RespStatus == 1)
                    {
                        Danger(resp.RespMessage, true);
                    }
                    else
                    {
                        Danger("Database error occured. Please contact Admin!", true);
                    }
                }
            }
            catch (Exception ex)
            {
                Util.LogError("Reset Password", ex, true);
            }
            return RedirectToAction("Stafflists");
        }
        #endregion


        #region Client Login
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Loginviewmodel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var resp = await bl.Login(model.Emailaddress, model.Password);
                if (resp.RespStatus == 0)
                {
                    UserModel User = new UserModel
                    {
                        Subcode = resp.Subcode,
                        PhoneNo = resp.PhoneNo,
                        Email = resp.Email,
                        Fullname = resp.Fullname,
                        profilecode = resp.profilecode,
                        Parentcode = resp.Parentcode
                    };
                    SetUserLoggedIn(User, false);
                    if (User.Loginstatus == Convert.ToInt32(UserLoginStatus.Subscribe))
                    {
                        return RedirectToAction("Subscribe", "Home");
                    }
                    else
                    {
                        return RedirectToAction("Dashboard", "Home");
                    }
                }
                else if (resp.RespStatus == 1)
                {
                    Danger(resp.RespMessage, true);
                }
                else
                {
                    Danger("Database Error Occured. Contact Admin!", true);
                }
            }
            return View(new Loginviewmodel());
        }

        private async void SetUserLoggedIn(UserModel user, bool rememberMe)
        {
            UserDataModel serializeModel = new UserDataModel
            {
                UserCode = user.Subcode,
                Fullname = user.Fullname,
                UserName = user.Email,
                Phonenumber = user.PhoneNo,
                Parentcode = user.Parentcode,
                ProfileCode = user.profilecode,
            };

            string userData = JsonConvert.SerializeObject(serializeModel);

            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Subcode.ToString()),
                new Claim(ClaimTypes.Name, user.Fullname),
                 new Claim("FullNames", serializeModel.Fullname),
                new Claim("userData", userData),
            };

            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "ApplicationCookie");

            ClaimsPrincipal principal = new ClaimsPrincipal(new ClaimsIdentity[] { claimsIdentity });
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal,
            new AuthenticationProperties
            {
                IsPersistent = rememberMe,
                ExpiresUtc = new DateTimeOffset?(DateTime.UtcNow.AddMinutes(30))
            });
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Dashboard), "Home");
            }
        }

        #endregion

    }
}
