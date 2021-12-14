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
            throw new Exception("Something terrible has happend!");
            return Content("Esimene" + name);
        }
    }
}
