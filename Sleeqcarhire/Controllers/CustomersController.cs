using DBL;
using DBL.Entities;
using DBL.Enum;
using DBL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rotativa.AspNetCore;
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
            bl = new BL(Util.ShareConnectionString.Value);
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
                        return RedirectToAction("Vehicleownerdetails",new { Custcode = Convert.ToInt64(resp.Data1) });
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
            return View("Vehicleownerslist");
        }

        [HttpGet]
        public async Task<IActionResult> Editvehicleowner(long Custcode)
        {
            var data = await bl.Getcompanycustomerbycode(Custcode);
            return PartialView("_Editvehicleowner", data);
        }
        [HttpPost]
        public async Task<IActionResult> Editvehicleowner(Companycustomers model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var resp = await bl.Editvehicleowner(model);
                    if (resp.RespStatus == 0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("Vehicleownerslist");
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
            return View("Vehicleownerslist");
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
        public async Task<IActionResult> Editvehicle(long Vehiclecode)
        {
            LoadParams();
            var data = await bl.GetCompanyvehiclesdetailbycode(Vehiclecode);
            return PartialView("_Editvehicle", data);
        }
        [HttpPost]
        public async Task<IActionResult> Editvehicle(Companyvehicles model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Createdby = SessionUserData.UserCode;
                    var resp = await bl.Editvehicle(model);
                    if (resp.RespStatus == 0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("Vehicleownerdetails", new { Custcode = Convert.ToInt64(resp.Data1) });
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
        public async Task<IActionResult> Editnextofkin(long Supcustcode)
        {
            LoadParams();
            var data = await bl.Getnokdetailbycode(Supcustcode);
            return PartialView("_Editnextofkin", data);
        }
        [HttpPost]
        public async Task<IActionResult> Editnextofkin(Supportcustomers model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Createdby = SessionUserData.UserCode;
                    var resp = await bl.Editnextofkin(model);
                    if (resp.RespStatus == 0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("Vehicleownerdetails", new { Custcode = Convert.ToInt64(resp.Data1) });
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
        [HttpGet]
        public async Task<IActionResult> Editnextofkincustomer(long Supcustcode)
        {
            LoadParams();
            var data = await bl.Getnokdetailbycode(Supcustcode);
            return PartialView("_Editnextofkincustomer", data);
        }
        [HttpPost]
        public async Task<IActionResult> Editnextofkincustomer(Supportcustomers model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Createdby = SessionUserData.UserCode;
                    var resp = await bl.Editnextofkin(model);
                    if (resp.RespStatus == 0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("Companycustomerdetails", new { Custcode = Convert.ToInt64(resp.Data1) });
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
        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> Deletevehicleowner(long Custcode)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var resp = await bl.Deletecompanycustomer(Custcode);
                    if (resp.RespStatus == 0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("Vehicleownerslist");
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
                Util.LogError("Delete Customer", ex, true);
            }
            return RedirectToAction("Vehicleownerslist");
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
        public async Task<IActionResult> Admincompanycustomerlist()
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
                        return RedirectToAction("Companycustomerdetails", new { Custcode = Convert.ToInt64(resp.Data1) });
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
            return View("Companycustomerlist");
        }
        [HttpGet]
        public async Task<IActionResult> Editcompanycustomer(long Custcode)
        {
            var data = await bl.Getcompanycustomerbycode(Custcode);
            return PartialView("_Editcompanycustomer", data);
        }
        [HttpPost]
        public async Task<IActionResult> Editcompanycustomer(Companycustomers model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.Createdby = SessionUserData.UserCode;
                    var resp = await bl.Editvehicleowner(model);
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
                Util.LogError("Edit vehicleowner", ex, true);
            }
            return View("Companycustomerlist");
        }
        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> Deletecompanycustomer(long Custcode)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var resp = await bl.Deletecompanycustomer(Custcode);
                    if (resp.RespStatus == 0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("Admincompanycustomerlist");
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
                Util.LogError("Delete Customer", ex, true);
            }
            return RedirectToAction("Admincompanycustomerlist");
        }
        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> Actdeactivatecustomer(long Custcode,long Status)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var resp = await bl.Actdeactivatecustomer(Custcode,Status);
                    if (resp.RespStatus == 0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("Admincompanycustomerlist");
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
                Util.LogError("Activate Deactivate Customer", ex, true);
            }
            return RedirectToAction("Admincompanycustomerlist");
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
            decimal price=0;
            decimal totalprice = 0;
            List<string> hireDayofweek = new List<string>();
            List<decimal> hireDayprice = new List<decimal>();
            var data = await bl.GetCompanyvehiclesdetailbycode(obj.Vehiclecode);
            Assigncustomercar model = new Assigncustomercar();
            model.Startdate = newDate;
            model.Enddate = newDate.AddDays(obj.Hiredays).AddMinutes(10);
            model.Newstartdate = newDate.ToString();
            model.Newenddate = (newDate.AddDays(obj.Hiredays).AddMinutes(10)).ToString();
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
                for (var day = model.Startdate; day < model.Enddate.AddDays(-1); day = day.AddDays(1))
                {
                    string Dayofweek = day.DayOfWeek.ToString();
                    if (Dayofweek=="Monday")
                    {
                        price = prices.Mondayprice;
                    }else if (Dayofweek == "Tuesday")
                    {
                        price = prices.Tuesdayprice;
                    }
                    else if (Dayofweek == "Wednesday")
                    {
                        price = prices.Wednesdayprice;
                    }
                    else if (Dayofweek == "Thursday")
                    {
                        price = prices.Thursdayprice;
                    }
                    else if(Dayofweek == "Friday")
                    {
                        price = prices.Fridayprice;
                    }
                    else if (Dayofweek == "Saturday")
                    {
                        price = prices.Saturdayprice;
                    }
                    else
                    {
                        price = prices.Sundayprice;
                    }
                    totalprice = totalprice + price;
                    hireDayofweek.Add(Dayofweek);
                    hireDayprice.Add(price);
                }
            }
            model.Hiringdays = string.Join(',', hireDayofweek);
            model.Hireamount = totalprice;
            model.Hireprice = string.Join(',', hireDayprice);
            model.Hiredby = SessionUserData.UserCode;
            model.Recievedby = SessionUserData.UserCode;
            model.Vehiclecode = obj.Vehiclecode;
            return PartialView("_Assignvehicledetails", model);
        }
        [HttpPost]
        public async Task<IActionResult> FinishAssigndetails(Assigncustomercar model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var resp = await bl.FinishAssigndetails(model);
                    if (resp.RespStatus == 0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("Viewassignvehicledata");
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
                Util.LogError("Assign Vehicle", ex, true);
            }
            return RedirectToAction("Companycustomerlist");
        }
        [HttpGet]
        public async Task<IActionResult> Assignvehicledetailreport(long Assigncode)
        {
            Viewassignedreciept model = new Viewassignedreciept();
             model = await bl.GetAssignvehicledetailreport(Assigncode);
            var paymentdata = await bl.Getvehiclepaymentreport(Assigncode);
            var Staffdata = await bl.Getstaffs();
            model.Paidamount = paymentdata.Sum(x => x.Paidamount);
            model.Paidby = string.Join(',', paymentdata.Select(x => x.Paidby));
            model.Recievedby = string.Join(',', Staffdata.Select(x => x.Fullname));
            model.Amountdue = model.Totalhireamount - paymentdata.Sum(x => x.Paidamount);
            return new ViewAsPdf("Assignvehicledetailreport", model);
        }
       
        
        [HttpGet]
        public async Task<IActionResult> Viewassignvehicledata()
        {
            var data = await bl.GetAssignvehicledetailData();
            foreach (var item in data)
            {
                var paymentdata = await bl.Getvehiclepaymentreport(item.Assigncode);
                var Staffdata = await bl.Getstaffs();
                item.Paidamount = paymentdata.Sum(x=>x.Paidamount);
                item.Paidby = paymentdata.Select(x => x.Paidby).FirstOrDefault();
                item.Recievedby = Staffdata.Select(x => x.Fullname).FirstOrDefault();
                item.Amountdue = item.Totalhireamount - paymentdata.Sum(x => x.Paidamount);
            }
            return View(data);
        }
        [HttpGet]
        [HttpPost]
        public async Task<IActionResult> Checkinvehicle(long Assigncode,long Vehiclecode)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var resp = await bl.Checkinvehicle(Assigncode,Vehiclecode);
                    if (resp.RespStatus == 0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("Viewassignvehicledata");
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
                Util.LogError("Assign Vehicle", ex, true);
            }
            return RedirectToAction("Viewassignvehicledata");
        }
        [HttpGet]
        public async Task<IActionResult> Extendvehicle(long Assigncode)
        {
            Extendvehicle model = new Extendvehicle();
            var data = await bl.GetAssignvehicledetailreport(Assigncode);
            model.Vehiclecode = data.Vehiclecode;
            model.Expecteddate = data.Dateexpected.ToString("dd/MM/yyyy h:d:s");
            return PartialView("_Extendvehicle",model);
        }
        [HttpPost]
        public async Task<IActionResult> Extendvehicle(Extendvehicle model)
        {
            try
            {
                decimal price = 0;
                decimal totalprice = 0;
                List<string> hireDayofweek = new List<string>();
                List<decimal> hireDayprice = new List<decimal>();
                if (ModelState.IsValid)
                {
                    model.Returndate = Convert.ToDateTime(model.Expecteddate).AddDays(model.Noofdays);
                    model.Createdby = SessionUserData.UserCode;
                    var data = await bl.GetCompanyvehiclesdetailbycode(model.Vehiclecode);
                    if (data != null)
                    {
                        var prices = await bl.Getvehicletypehiretermsbycode(data.Typecode);
                        for (var day = Convert.ToDateTime(model.Expecteddate); day < model.Returndate; day = day.AddDays(1))
                        {
                            string Dayofweek = day.DayOfWeek.ToString();
                            if (Dayofweek == "Monday")
                            {
                                price = prices.Mondayprice;
                            }
                            else if (Dayofweek == "Tuesday")
                            {
                                price = prices.Tuesdayprice;
                            }
                            else if (Dayofweek == "Wednesday")
                            {
                                price = prices.Wednesdayprice;
                            }
                            else if (Dayofweek == "Thursday")
                            {
                                price = prices.Thursdayprice;
                            }
                            else if (Dayofweek == "Friday")
                            {
                                price = prices.Fridayprice;
                            }
                            else if (Dayofweek == "Saturday")
                            {
                                price = prices.Saturdayprice;
                            }
                            else
                            {
                                price = prices.Sundayprice;
                            }
                            totalprice = totalprice + price;
                            hireDayofweek.Add(Dayofweek);
                            hireDayprice.Add(price);
                        }
                    }
                    model.Hiringdays = string.Join(',', hireDayofweek);
                    model.Hireamount = totalprice;
                    model.Hireprice = string.Join(',', hireDayprice);
                    var resp = await bl.Extendvehicle(model);
                    if (resp.RespStatus == 0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("Viewassignvehicledata");
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
                Util.LogError("Assign Vehicle", ex, true);
            }
            return RedirectToAction("Viewassignvehicledata");
        }
        [HttpGet]
        public async Task<IActionResult> Payvehicle(long Assigncode)
        {
            Vehicletrippayments model = new Vehicletrippayments();
            var data = await bl.GetAssignvehicledetailreport(Assigncode);
            var paymentdata = await bl.Getvehiclepaymentreport(Assigncode);
            if (paymentdata.Count()>0)
            {
                model.Tripbalance = data.Totalhireamount-paymentdata.Sum(x => x.Paidamount);
            }
            else
            {
                model.Tripbalance = data.Totalhireamount;
            }
            model.Tripamount = data.Totalhireamount;
            model.Assigncode = Assigncode;
            return PartialView("_Payvehicle",model);
        }
        [HttpPost]
        public async Task<IActionResult> Payvehicle(Vehicletrippayments model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (model.Tripbalance == model.Paidamount)
                    {
                        model.Tripbalance = 0;
                    }
                    else
                    {
                        model.Tripbalance = model.Tripbalance - model.Paidamount;
                    }
                    model.Createdby = SessionUserData.UserCode;
                    var resp = await bl.Payvehicle(model);
                    if (resp.RespStatus == 0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("Viewassignvehicledata");
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
                Util.LogError("Assign Vehicle", ex, true);
            }
            return RedirectToAction("Viewassignvehicledata");
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
