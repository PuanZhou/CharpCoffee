using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjCSCoffee.Controllers
{
    public class CAboutMeController : Controller
    {
        public IActionResult faceToMe()
        {
            return View();
        }
    }
}
