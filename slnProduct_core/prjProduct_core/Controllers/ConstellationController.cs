using Microsoft.AspNetCore.Mvc;
using prjCSCoffee.Models;
using prjProduct_core.ViewModel;
using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjCSCoffee.Controllers
{
    public class ConstellationController : Controller
    {

        //public IActionResult faceToConstellation()
        //{
        //    CoffeeContext db = new CoffeeContext();
        //    var datas = from c in db.Constellations
        //                select c;
        //    List<Constellation> list = new List<Constellation>();
        //    foreach (Constellation q in datas)
        //    {
        //        list.Add(q);
        //    }
        //    return View(datas);
        //}

        private readonly CoffeeContext db;

        public ConstellationController(CoffeeContext _db)
        {

            db = _db;
        }

        public IActionResult faceToConstellation()
        {
            IEnumerable<CConstellationViewModel> datas = null;
            var list = db.Constellations.Select(c => new CConstellationViewModel()
            {

                ConstellationId = c.ConstellationId,
                ConstellationName = c.ConstellationName,
                ConstellationDescription = c.ConstellationDescription,
                ConstellationDate = c.ConstellationDate,
                ConstellationProductId = c.ConstellationProductId,
                productName = db.Products.FirstOrDefault(n => n.ProductId == c.ConstellationProductId).ProductName,
            });;
            if (list != null)
            {
                datas = list;
            }

            return View(datas);
        }
    }
}
