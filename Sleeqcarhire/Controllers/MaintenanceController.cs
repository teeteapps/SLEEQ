using DBL;
using DBL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        public IActionResult Companyvehicles()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Addsleeqcar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Addsleeqcar(Sleeqcars model)
        {
            return View();
        }
    }
}
