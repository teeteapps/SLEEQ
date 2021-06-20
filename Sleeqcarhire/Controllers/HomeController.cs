using DBL;
using DBL.Entities;
using DBL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sleeqcarhire.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sleeqcarhire.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        private readonly BL bl;
        string encusercode = "";
        public HomeController()
        {
            bl = new BL(Util.GetDbConnString());
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            Companyvehicledetails data = new Companyvehicledetails();
            data.sleeq = new Sleeqcars();
            data.hiredays = new List<Vehiclehiredays>();
            data.sleeqcars = await bl.GetCompanyvehicles();
            foreach (var item in data.sleeqcars)
            {
                data.hiredays = await bl.GetVehiclehiredaysbycode(item.Sleeqcarcode);
            }
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
