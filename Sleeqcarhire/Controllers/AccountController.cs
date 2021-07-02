using DBL;
using DBL.Enum;
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
        public AccountController()
        {
            bl = new BL(Util.GetDbConnString());
        }


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

        //#region Unonumous Register

        //[AllowAnonymous]
        //[HttpGet]
        //public async Task<IActionResult> Subscribe()
        //{
        //    Systemsubscribemodel postsdata = new Systemsubscribemodel();
        //    postsdata.Clientdata = new Bloghubclients();
        //    postsdata.Postslistdata = new List<VwBloghubposts>();
        //    var tenant = RouteData.Values.SingleOrDefault(r => r.Key == "tenant");
        //    postsdata.Postslistdata = await bl.Getallpostslists(Convert.ToInt64(tenant.Value));
        //    if (Convert.ToInt64(tenant.Value) == 0)
        //    {
        //        postsdata.Postslistdata = await bl.Getallsyspostslists();
        //        return View(postsdata);
        //    }
        //    return View(postsdata);
        //}
        //[AllowAnonymous]
        //[HttpPost]
        //public async Task<IActionResult> Subscribe(Systemsubscribemodel model)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            var resp = await bl.Subscribe(model.Clientdata);
        //            if (resp.RespStatus == 0)
        //            {
        //                Success(resp.RespMessage, true);
        //                return RedirectToAction("Login");
        //            }
        //            else if (resp.RespStatus == 1)
        //            {
        //                Danger(resp.RespMessage, true);
        //            }
        //            else
        //            {
        //                Danger("Database error occured. Kindly contact Admin", true);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Util.LogError("Subscribe User", ex, true);
        //    }
        //    return RedirectToAction("Subscribe");
        //}
        //#endregion

        //[HttpGet]
        //public async Task<IActionResult> Clientslists()
        //{
        //    long clientrole = SessionUserData.ProfileCode;
        //    var tenantdata = await bl.GetClientsclientlists(SessionUserData.UserCode);
        //    if (clientrole == 100)
        //    {
        //        var data = await bl.GetClientslists();
        //        return View(data);
        //    }
        //    return View(tenantdata);
        //}
        //[HttpGet]
        //public IActionResult Registerclient()
        //{
        //    Bloghubclients model = new Bloghubclients();
        //    model.Clientrole = 300;
        //    model.Loginstatus = 0;

        //    return View(model);
        //}
        //[HttpPost]
        //public async Task<IActionResult> Registerclient(Bloghubclients model)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            model.Createdby = SessionUserData.UserCode;
        //            model.Modifiedby = SessionUserData.UserCode;
        //            model.Parentcode = SessionUserData.UserCode;
        //            var resp = await bl.Registerclient(model);
        //            if (resp.RespStatus == 0)
        //            {
        //                Success(resp.RespMessage, true);
        //                return RedirectToAction("Login");
        //            }
        //            else if (resp.RespStatus == 1)
        //            {
        //                Danger(resp.RespMessage, true);
        //            }
        //            else
        //            {
        //                Danger("Database error occured. Kindly contact Admin", true);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Util.LogError("Register Client", ex, true);
        //    }
        //    return View();
        //}

        //[HttpGet]
        //public async Task<IActionResult> Editclient(long Clientcode)
        //{
        //    var data = await bl.Getsystemclientbycode(Clientcode);
        //    return View(data);
        //}
        //[HttpPost]
        //public async Task<IActionResult> Editclient(Bloghubclientsedit model)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            model.Modifiedby = SessionUserData.UserCode;
        //            var resp = await bl.Updateclient(model);
        //            if (resp.RespStatus == 0)
        //            {
        //                Success(resp.RespMessage, true);
        //                return RedirectToAction("Clientslists");
        //            }
        //            else if (resp.RespStatus == 1)
        //            {
        //                Danger(resp.RespMessage, true);
        //            }
        //            else
        //            {
        //                Danger("Database error occured. Kindly contact Admin", true);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Util.LogError("Update Client", ex, true);
        //    }
        //    return View();
        //}

        //#region Delete Client
        //[HttpGet]
        //[HttpPost]
        //public async Task<IActionResult> Deleteclient(long Clientcode, int Status)
        //{
        //    await bl.Updateclientsstatus(Clientcode, Status);
        //    return RedirectToAction("Clientslists");
        //}
        //#endregion
    }
}
