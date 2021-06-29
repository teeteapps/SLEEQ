using DBL;
using DBL.Entities;
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
        public async Task<IActionResult> Addvehicleowner(Vehicleowners model)
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
        public async Task<IActionResult> Vehicleownerdetails(long ownercode)
        {
            Vehicleownerdetails model = new Vehicleownerdetails();
            model.owner = new Viewvehicleowners();
            model.owner = await bl.GetVehicleownerdetailbycode(ownercode);
            return View(model);
        }
    }
}
