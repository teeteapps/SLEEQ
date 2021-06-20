using DBL;
using DBL.Entities;
using DBL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
            data.sleeq = await bl.GetCompanyvehiclesbycode(Vehiclecode);
            return View(data);
        }
        [HttpGet]
        public IActionResult Addvehiclehiredays(long Sleeqcarcode)
        {
            Vehiclehiredays model = new Vehiclehiredays();
            model.Sleeqcarcode = Sleeqcarcode;
            return View(model);
        }
        [HttpPost]
        public IActionResult Addvehiclehiredays(Vehiclehiredays model)
        {
            return View();
        }
    }
}
