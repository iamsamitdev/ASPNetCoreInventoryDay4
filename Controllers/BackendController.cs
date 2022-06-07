using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreInventory.Controllers
{
    public class BackendController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }
    }
}
