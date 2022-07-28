using Microsoft.AspNetCore.Mvc;
using prjAdmin.Models;
using prjAdmin.ViewModels;
using prjProduct_core.Models;
using prjProduct_core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjProduct_core.Controllers
{
    public class Admin_ConstellationController : Controller
    {
        private readonly CoffeeContext _context;

        public Admin_ConstellationController(CoffeeContext context)
        {
            _context = context;
        }
        public IActionResult ConstellationList()
        {
            IEnumerable<CAdmin_ConstellationViewModel> datas = null;
            var list = _context.Constellations.Select(a => new CAdmin_ConstellationViewModel()
            {
                ConstellationId = a.ConstellationId,
                ConstellationName = a.ConstellationName,
                ConstellationProductId = a.ConstellationProductId
            });
            if (list != null)
            {
                datas = list;
            }
            return View(datas);
        }

        public IActionResult EditConstellation(int? id)
        {
            CoffeeContext db = new CoffeeContext();
            Constellation con = _context.Constellations.FirstOrDefault(a => a.ConstellationId == id);
            if (con == null)
            {
                return RedirectToAction("ConstellationList");
            }
            return View(con);
        }
        [HttpPost]
        public IActionResult EditConstellation(CAdmin_ConstellationViewModel c)
        {
            Constellation con = _context.Constellations.FirstOrDefault(constellation => constellation.ConstellationId == c.ConstellationId);
            if (con != null)
            {
                con.ConstellationProductId = c.ConstellationProductId;
            }
            _context.SaveChanges();
            return RedirectToAction("ConstellationList");
        }
        public IActionResult EDConstellation()
        {
            IEnumerable<CAdmin_ConstellationViewModel> datas = null;
            var list = _context.Constellations.Select(a => new CAdmin_ConstellationViewModel()
            {
                ConstellationId = a.ConstellationId,
                ConstellationName = a.ConstellationName,
                ConstellationProductId = a.ConstellationProductId
            });
            if (list != null)
            {
                datas = list;
            }
            return View(datas);
        }

        public IActionResult ChangeProductID(int cid, int chpd)
        {
            Constellation con = _context.Constellations.FirstOrDefault(c => c.ConstellationId == cid);
            if (chpd == 0)
            {
                return Content("fal", "text/plain", System.Text.Encoding.UTF8);
            }
            else
            {
                if (con != null)
                {
                    con.ConstellationProductId = chpd;
                    _context.SaveChanges();
                    return Content("sus", "text/plain", System.Text.Encoding.UTF8);
                }
                else
                {
                    return Content("fal", "text/plain", System.Text.Encoding.UTF8);
                }
            }


        }
    }
}
