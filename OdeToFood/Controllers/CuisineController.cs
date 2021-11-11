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
        public IActionResult Search(string name)
        {
            return Content(name);
        }
    }
}
