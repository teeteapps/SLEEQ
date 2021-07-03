using DBL;
using DBL.Entities;
using DBL.Enum;
using DBL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sleeqcarhire.Controllers
{
    [Authorize]
    public class CustomersController : BaseController
    {
        private readonly BL bl;
        string encusercode = "";
        public CustomersController()
        {
            bl = new BL(Util.GetDbConnString());
        }
        #region Vehicle Owner Details
        [HttpGet]
        public async Task<IActionResult> Vehicleownerslist()
        {
            var data = await bl.GetVehicleownerslist();
            return View(data);
        } 
        [HttpGet]
        public IActionResult Addvehicleowner()
        {
            return PartialView("_Addvehicleowner");
        }
        [HttpPost]
        public async Task<IActionResult> Addvehicleowner(Companycustomers model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Createdby = SessionUserData.UserCode;
                    var resp = await bl.Addvehicleowner(model);
                    if (resp.RespStatus==0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("Vehicleownerdetails",new {ownercode=Convert.ToInt64(resp.Data1) });
                    }
                    else if (resp.RespStatus == 1)
                    {
                        Danger(resp.RespMessage, true);
                    }
                    else
                    {
                        Danger("Database error occured. Please contact Admin!",true);
                    }
                }
            }
            catch (Exception ex)
            {
                Util.LogError("Add vehicleowner", ex,true);
            }
            return PartialView("_Addvehicleowner");
        }
        [HttpGet]
        public async Task<IActionResult> Vehicleownerdetails(long Custcode)
        {
            Viewcompanycustomerdetails model = new Viewcompanycustomerdetails();
            model.Customer = new Viewcompanycustomers();
            model.Vehicles = new List<Viewcompanyvehicles>();
            model.Nextofkin = new List<Viewnextofkins>();
            model.Customer = await bl.GetVehicleownerdetailbycode(Custcode);
            model.Vehicles = await bl.GetViewcompanyvehiclesdetailbycode(Custcode);
            model.Nextofkin = await bl.GetViewnextofkinsdetailbycode(Custcode);
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Companycustomerdetails(long Custcode)
        {
            Viewcompanycustomerdetails model = new Viewcompanycustomerdetails();
            model.Customer = new Viewcompanycustomers();
            model.Nextofkin = new List<Viewnextofkins>();
            model.Customer = await bl.GetVehicleownerdetailbycode(Custcode);
            model.Nextofkin = await bl.GetViewnextofkinsdetailbycode(Custcode);
            return View(model);
        }

        [HttpGet]
        public IActionResult Addvehicle(long Customercode)
        {
            LoadParams();
            Companyvehicles model = new Companyvehicles();
            model.Custcode = Customercode;
            return PartialView("_Addcompvehicle",model);
        }
        [HttpPost]
        public async Task<IActionResult> Addvehicle(Companyvehicles model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Createdby = SessionUserData.UserCode;
                    var resp = await bl.Addvehicle(model);
                    if (resp.RespStatus == 0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("Vehicleownerdetails", new { Custcode = model.Custcode });
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
                Util.LogError("Add Vehicle", ex, true);
            }
            return RedirectToAction("Vehicleownerdetails", new { Custcode = model.Custcode });
        }
        [HttpGet]
        public IActionResult Addnextofkin(long Customercode)
        {
            LoadParams();
            Supportcustomers model = new Supportcustomers();
            model.Custcode = Customercode;
            return PartialView("_Addnextofkin",model);
        }
        [HttpPost]
        public async Task<IActionResult> Addnextofkin(Supportcustomers model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Createdby = SessionUserData.UserCode;
                    var resp = await bl.Addnextofkin(model);
                    if (resp.RespStatus == 0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("Vehicleownerdetails", new { Custcode = model.Custcode });
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
                Util.LogError("Add Next of kin", ex, true);
            }
            return RedirectToAction("Vehicleownerdetails", new { Custcode = model.Custcode });
        }
        [HttpGet]
        public IActionResult Addnextofkincustomer(long Customercode)
        {
            LoadParams();
            Supportcustomers model = new Supportcustomers();
            model.Custcode = Customercode;
            return PartialView("_Addnextofkincustomer", model);
        }
        [HttpPost]
        public async Task<IActionResult> Addnextofkincustomer(Supportcustomers model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Createdby = SessionUserData.UserCode;
                    var resp = await bl.Addnextofkin(model);
                    if (resp.RespStatus == 0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("Companycustomerdetails", new { Custcode = model.Custcode });
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
                Util.LogError("Add Next of kin", ex, true);
            }
            return RedirectToAction("Companycustomerdetails", new { Custcode = model.Custcode });
        }
        #endregion

        #region Company Customers 
        [HttpGet]
        public async Task<IActionResult> Companycustomerlist()
        {
            var data = await bl.Getcompanycustomerslist();
            return View(data);
        }
        [HttpGet]
        public IActionResult Addcompanycustomer()
        {
            return PartialView("_Addcompanycustomer");
        }
        [HttpPost]
        public async Task<IActionResult> Addcompanycustomer(Companycustomers model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Createdby = SessionUserData.UserCode;
                    var resp = await bl.Addvehicleowner(model);
                    if (resp.RespStatus == 0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("Companycustomerlist", new { ownercode = Convert.ToInt64(resp.Data1) });
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
                Util.LogError("Add vehicleowner", ex, true);
            }
            return PartialView("_Addcompanycustomer");
        }
        #endregion

        #region Assign Vehicle
        [HttpGet]
        public IActionResult AssignCustomervehicle(long Custcode)
        {
            LoadParams();
            Assigncardata model = new Assigncardata();
            model.Custcode = Custcode;
            return PartialView("_AssignCustomervehicle", model);
        }
        [HttpPost]
        public async Task<IActionResult> AssignCustomervehicle(Assigncardata obj)
        {
            var dt = DateTime.Now;
            TimeSpan ts = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
            DateTime newDate = obj.Startdate.Add(ts);
            double price=0;
            double totalprice = 0;
            List<string> hireDayofweek = new List<string>();
            var data = await bl.GetCompanyvehiclesdetailbycode(obj.Vehiclecode);
            Assigncustomercar model = new Assigncustomercar();
            model.Startdate = newDate;
            model.Enddate = newDate.AddDays(obj.Hiredays).AddMinutes(10);
            model.Whereto = obj.Whereto;
            model.Wheretodescription = obj.Wheretodescription;
            model.Vehiclereg = data.Regno;
            model.Hiredays = obj.Hiredays;
            if (obj.Hascarwash)
            {
                model.Carwash = 200;
            }
            else
            {
                model.Carwash = 0;
            }
            if (data!=null) {
                var prices = await bl.Getvehicletypehiretermsbycode(data.Typecode);
                for (var day = model.Startdate; day < model.Enddate; day = day.AddDays(1)) { 
                   string Dayofweek=day.DayOfWeek.ToString();
                    price = prices.Where(x => x.Hireday.Contains(Dayofweek)).FirstOrDefault().Hireprice;
                    totalprice = totalprice + price;
                    hireDayofweek.Add(Dayofweek);
                } 
            }
            model.Hiringdays = string.Join(',', hireDayofweek);
            model.Hireamount = totalprice;
            return PartialView("_Assignvehicledetails", model);
        }
        #endregion

        #region Other methods
        private void LoadParams()
        {
            var list = bl.GetListModel(ListModelType.Vehicletype).Result.Select(x => new SelectListItem
            {
                Text = x.Text,
                Value = x.Value
            }).ToList();
            ViewData["Vehicletypeslists"] = list;
            list = bl.GetListModel(ListModelType.Relation).Result.Select(x => new SelectListItem
            {
                Text = x.Text,
                Value = x.Value
            }).ToList();
            ViewData["Relationlists"] = list;
            list = bl.GetListModel(ListModelType.Availablevehicles).Result.Select(x => new SelectListItem
            {
                Text = x.Text,
                Value = x.Value
            }).ToList();
            ViewData["Availablevehicleslists"] = list;
        }
        #endregion
    }
}
