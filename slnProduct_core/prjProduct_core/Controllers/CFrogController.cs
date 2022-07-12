using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjCSCoffee.Controllers
{
    public class CFrogController : Controller
    {
        public IActionResult faceToFrog()
        {
            return View();
        }
    }
}
