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
            bl = new BL(Util.ShareConnectionString.Value);
        }

        [HttpGet]
        public async Task<IActionResult> Companyvehicleslist()
        {
            var data = await bl.GetCompanyvehicles();
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> Companyparkedvehicles()
        {
            var data = await bl.Getompanyparkedvehicles();
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> Companyhiredvehicles()
        {
            var data = await bl .GetCompanyhiredvehicles();
            return View(data);
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
                    if (resp.RespStatus == 0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("CompanyvehicleDetails", new { Vehiclecode = Convert.ToInt64(resp.Data1) });
                    }
                    else if (resp.RespStatus == 1)
                    {
                        Danger(resp.RespMessage, true);
                    }
                    else
                    {
                        Danger("Database Error Occured. Kindly Contact Admin", true);
                    }
                }
            }
            catch (Exception ex)
            {
                Util.LogError("Addsleeqcar", ex, true);
            }
            return View();
        }


        #region Vehicle Types
        [HttpGet]
        public async Task<IActionResult> Vehicletypelist()
        {
            var data = await bl.GetVehicletypelist();
            return View(data);
        }
        [HttpGet]
        public IActionResult Addvehicletype()
        {
            LoadParams();
            return PartialView("_Addvehicletype");
        }
        [HttpPost]
        public async Task<IActionResult> Addvehicletype(Compvehicletypes model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
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
                    model.Imagepath = uploadfilePath;
                    var resp = await bl.Addvehicletype(model);
                    if (resp.RespStatus == 0)
                    {
                        Success(resp.RespMessage, true);
                        return RedirectToAction("VehicletypeDetails", new { Typecode = Convert.ToInt64(resp.Data1) });
                    }
                    else if (resp.RespStatus == 1)
                    {
                        Danger(resp.RespMessage, true);
                    }
                    else
                    {
                        Danger("Database Error Occured. Kindly Contact Admin", true);
                    }
                }
            }
            catch (Exception ex)
            {
                Util.LogError("Addvehicletype", ex, true);
            }
            return RedirectToAction("Vehicletypelist");
        }
        [HttpGet]
        public async Task<IActionResult> Editvehicletype(long Typecode)
        {
            LoadParams();
            var data = await bl.GetVehicletypebycode(Typecode);
            return PartialView("_Editvehicletype", data);
        }
        [HttpPost]
        public async Task<IActionResult> Editvehicletype(Compvehicletypes model)
        {
            try
            {
                //if (ModelState.IsValid)
                //{
                var filepath = "";
                var newFileName = "";
                string uploadPath = "~/VehicleImages/";

                if (model.Vehicleimage != null)
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
                    var uploadfilePath = Path.Combine(uploadPath, newFileName);
                    model.Imagepath = uploadfilePath;
                }

                var resp = await bl.Editvehicletype(model);
                if (resp.RespStatus == 0)
                {
                    Success(resp.RespMessage, true);
                    return RedirectToAction("Vehicletypelist");
                }
                else if (resp.RespStatus == 1)
                {
                    Danger(resp.RespMessage, true);
                }
                else
                {
                    Danger("Database Error Occured. Kindly Contact Admin", true);
                }
                //}
            }
            catch (Exception ex)
            {
                Util.LogError("Editvehicletype", ex, true);
            }
            return RedirectToAction("Vehicletypelist");
        }

        [HttpGet]
        public async Task<IActionResult> VehicletypeDetails(long Typecode)
        {
            CompanyVehicletypedetails data = new CompanyVehicletypedetails();
            data.Vehtypes = new Compvehicletypes();
            data.Hireterms = new Vehicletypehireterms();
            data.Vehtypes = await bl.GetVehicletypebycode(Typecode);
            data.Hireterms = await bl.Getvehicletypehiretermsbycode(Typecode);
            return View(data);
        }
        [HttpGet]
        public IActionResult Addvehicletypehireterms(long Typecode)
        {
            Vehicletypehireterms model = new Vehicletypehireterms();
            model.Typecode = Typecode;
            return PartialView("_Addvehicletypehireterms", model);
        }
        [HttpPost]
        public async Task<IActionResult> Addvehicletypehireterms(Vehicletypehireterms model)
        {
            var resp = await bl.Addvehicletypehireterms(model);
            if (resp.RespStatus == 0)
            {
                Success(resp.RespMessage, true);
                return RedirectToAction("VehicletypeDetails", new { Typecode = Convert.ToInt64(model.Typecode) });
            }
            else if (resp.RespStatus == 1)
            {
                Danger(resp.RespMessage, true);
            }
            else
            {
                Danger("Database Error Occured. Kindly Contact Admin", true);
            }
            return RedirectToAction("VehicletypeDetails", new { Typecode = Convert.ToInt64(model.Typecode) });
        }
        [HttpGet]
        public async Task<IActionResult> Editvehicletypehireterms(long Typecode)
        {
            var data = await bl.Getvehicletypehiretermsbycode(Typecode);
            return PartialView("_Editvehicletypehireterms", data);
        }
        [HttpPost]
        public async Task<IActionResult> Editvehicletypehireterms(Vehicletypehireterms model)
        {
            var resp = await bl.Editvehicletypehireterms(model);
            if (resp.RespStatus == 0)
            {
                Success(resp.RespMessage, true);
                return RedirectToAction("VehicletypeDetails", new { Typecode = Convert.ToInt64(model.Typecode) });
            }
            else if (resp.RespStatus == 1)
            {
                Danger(resp.RespMessage, true);
            }
            else
            {
                Danger("Database Error Occured. Kindly Contact Admin", true);
            }
            return RedirectToAction("VehicletypeDetails", new { Typecode = Convert.ToInt64(model.Typecode) });
        }
        #endregion

        #region Other methods
        private void LoadParams()
        {
            var list = bl.GetListModel(ListModelType.Vehiclecapacity).Result.Select(x => new SelectListItem
            {
                Text = x.Text,
                Value = x.Value
            }).ToList();
            ViewData["Vehiclecapacitylists"] = list;
        }
        #endregion
    }
}
