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
            bl = new BL(Util.ShareConnectionString.Value);
        }

        public async Task<IActionResult> Dashboard()
        {
            var data = await bl.Getdashboarddata();
            return View(data);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index() {
            var data = await bl.GetVehicletypelist();
            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
