using Microsoft.AspNetCore.Mvc;
using prjCSCoffee.Models;
using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCSCoffee.Controllers
{
    public class MemberFactoryController : Controller
    {

        CoffeeContext db ;

        public MemberFactoryController(CoffeeContext  _db)
        {
            db = _db;
        }

        public IActionResult QueryMemEmail(string MemberEmail)
        {
            var emailExist = db.Members.Any(m => m.MemberEmail == MemberEmail);
            return Content(emailExist.ToString(),"text/plain",Encoding.UTF8);
        }

        public IActionResult QueryMemPhone(string MemberPhone)
        {
            var phoneExist = db.Members.Any(m => m.MemberPhone == MemberPhone);
            return Content(phoneExist.ToString(), "text/plain", Encoding.UTF8);
        }


    }
}
