using DBL;
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

        public IActionResult Index()
        {
            return View();
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
