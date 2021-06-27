using DBL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Vehicleownerslist()
        {
            return View();
        } 
        [HttpGet]
        public IActionResult Addvehicleowner()
        {
            return PartialView("_Addvehicleowner");
        }
    }
}
