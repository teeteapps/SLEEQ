using DBL;
using DBL.Entities;
using DBL.Enum;
using DBL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.FileProviders;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Sleeqcarhire.Controllers
{
    [Authorize]
    public class MaintenanceController : BaseController
    {
        private readonly BL bl;
        string encusercode = "";
        public MaintenanceController()
        {
            bl = new BL(Util.GetDbConnString());
        }
        [HttpGet]
        public async Task<IActionResult> Companyvehicles()
        {
            var data = await bl.GetCompanyvehicles();
            return View(data);
        }
        [HttpGet]
        public IActionResult Addsleeqcar()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Addsleeqcar(Sleeqcars model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var fileName = "";
                    var filepath = "";
                    var newFileName = "";
                    string uploadPath = "~/VehicleImages/";
                    model.Createdby = SessionUserData.UserCode;
                    if (model.Vehicleimage.Length > 0)
                    {
                        var image = Image.Load(model.Vehicleimage.OpenReadStream());
                        image.Mutate(x => x.Resize(600, 400));
                        //Assigning Unique Filename (Guid)
                        var myUniqueFileName = Convert.ToString(Guid.NewGuid());
                        // concatenating  FileName + FileExtension
                        newFileName = String.Concat(myUniqueFileName, ".png");
                        // Combines two strings into a path.
                        filepath = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "VehicleImages")).Root + $@"\{newFileName}";
                        image.Save(filepath);
                    }
                    var uploadfilePath = Path.Combine(uploadPath, newFileName);
                    model.Sleeqcarimage = uploadfilePath;
                    var resp = await bl.Addsleeqcar(model);
                    if (resp.RespStatus==0)
                    {
                        Success(resp.RespMessage,true);
                        return RedirectToAction("CompanyvehicleDetails",new {Vehiclecode=Convert.ToInt64(resp.Data1) });
                    }else if (resp.RespStatus==1)
                    {
                        Danger(resp.RespMessage,true);
                    }
                    else
                    {
                        Danger("Database Error Occured. Kindly Contact Admin",true);
                    }
                }
            }
            catch (Exception ex)
            {
                Util.LogError("Addsleeqcar",ex,true);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CompanyvehicleDetails(long Vehiclecode)
        {
            Companyvehicledetails data = new Companyvehicledetails();
            data.sleeq = new Sleeqcars();
            data.hiredays = new List<Vehiclehiredays>();
            data.sleeq = await bl.GetCompanyvehiclesbycode(Vehiclecode);
            data.hiredays = await bl.GetVehiclehiredaysbycode(Vehiclecode);
            return View(data);
        }
        [HttpGet]
        public IActionResult Addvehiclehiredays(string Sleeqcarcode)
        {
            Vehiclehiredays model = new Vehiclehiredays();
            model.Sleeqcarcode = Convert.ToInt64(Sleeqcarcode);
            return PartialView("_Addvehiclehiredays", model);
        }

        [HttpPost]
        public async Task<IActionResult> Addvehiclehiredays(Vehiclehiredays model)
        {
            var resp = await bl.Addvehiclehiredays(model);
            if (resp.RespStatus==0)
            {
                Success(resp.RespMessage, true);
                return RedirectToAction("CompanyvehicleDetails", new { Vehiclecode = Convert.ToInt64(model.Sleeqcarcode) });
            }
            else if (resp.RespStatus == 1)
            {
                Danger(resp.RespMessage, true);
            }
            else
            {
                Danger("Database Error Occured. Kindly Contact Admin", true);
            }
            return View();
        }

        #region Vehicle models and makes
        [HttpGet]
        public async Task<IActionResult> Vehiclemakelist()
        {
            var data = await bl.Getvehiclemakelist();
            return View(data);
        }
        [HttpGet]
        public IActionResult Addvehiclemake()
        {
            return PartialView("_Addvehiclemake");
        }
        [HttpPost]
        public async Task<IActionResult> Addvehiclemake(VehicleMakes model)
        {
            model.Createdby = SessionUserData.UserCode;
            var resp = await bl.Addvehiclemake(model);
            if (resp.RespStatus == 0)
            {
                Success(resp.RespMessage, true);
                return RedirectToAction("Vehiclemakelist");
            }
            else if (resp.RespStatus == 1)
            {
                Danger(resp.RespMessage, true);
            }
            else
            {
                Danger("Database Error Occured. Kindly Contact Admin", true);
            }
            return RedirectToAction("Vehiclemakelist");
        }
        [HttpGet]
        public async Task<IActionResult> Editvehiclemake(long Makecode)
        {
            var data = await bl.Getvehiclemakebycode(Makecode);
            return PartialView("_Editvehiclemake",data);
        }
        [HttpPost]
        public async Task<IActionResult> Editvehiclemake(VehicleMakes model)
        {
            var resp = await bl.Editvehiclemake(model);
            if (resp.RespStatus == 0)
            {
                Success(resp.RespMessage, true);
                return RedirectToAction("Vehiclemakelist");
            }
            else if (resp.RespStatus == 1)
            {
                Danger(resp.RespMessage, true);
            }
            else
            {
                Danger("Database Error Occured. Kindly Contact Admin", true);
            }
            return RedirectToAction("Vehiclemakelist");
        }
        #endregion

        
    }
}
