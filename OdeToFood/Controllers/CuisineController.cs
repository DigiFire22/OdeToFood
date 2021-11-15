using Microsoft.AspNetCore.Mvc;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        [HttpPost]
        public IActionResult Search(string name = "french")
        {
            return Content("Esimene" + name);
        }

        //[ActionName("otsi")]
        [HttpGet]
        public IActionResult Search(string name, Boolean notused)
        {
            return Content("Search!");
        }
    }
}
