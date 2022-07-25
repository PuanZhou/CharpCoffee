using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using prjProduct_core.Models;
using prjProduct_core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace prjProduct_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class R_ShopController : ControllerBase
    {
        private readonly CoffeeContext db;
        private readonly IWebHostEnvironment _host;

        public R_ShopController(CoffeeContext context, IWebHostEnvironment hostEnvironment)
        {
            db = context;
            _host = hostEnvironment;
        }

        //==========Main and Sub AD===================
        [HttpGet]
        public string Get()
        {
            IQueryable<Product> tempM, tempS;
            tempM = db.Products.Where(x=>x.CategoryId==1).OrderByDescending(x => x.Stock).Take(5);
            var tempSId = db.OrderDetails.Where(x => x.Product.CategoryId == 1).OrderBy(x => x.Order.OrderDate).Select(x => x.ProductId).Take(10);
            tempS = db.Products.Where(x => tempSId.Contains(x.ProductId));
            var result = tempM.Concat(tempS).Select(x => new CAppProductVM()
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                Price = (int)x.Price,
                Description = x.Description,
                MainPhotoPath="49562fbf-8247-436c-9fa2-32d626786eee.jpg",
                //MainPhotoPath = x.MainPhotoPath,
                Stock = (int)x.Stock,
            });
            
            return JsonSerializer.Serialize(result);
        }

        //===========photo====================
        [HttpGet("{pName}")]
        public IActionResult Get(string pName)
        {
            Byte[] b = System.IO.File.ReadAllBytes(_host.WebRootPath + "/images/" + pName);
            return File(b, "image/png");
        }


        //================search===================
        [HttpGet("{c}/{id}")]
        public string Get(string c,int id)
        {
            IQueryable<Product> temp;
            string kw = c;
            if (c == "co")
                temp = db.Products.Where(x => x.Country.ContinentId==id);
            else if (c == "cy")
                temp = db.Products.Where(x => x.CountryId == id);
            else if (c == "ro")
                temp = db.Products.Where(x => x.Coffee.RoastingId == id);
            else if (c == "pr")
                temp = db.Products.Where(x => x.Coffee.ProcessId == id);
            else if(c == "pa")
                temp = db.Products.Where(x => x.Coffee.PackageId == id);
            else
            {   
                kw = c;
                var pId = db.Coffees.Select(n => new {
                    cnN = n.Country.Continent.ContinentName,
                    coN = n.Country.CountryName,
                    roN = n.Roasting.RoastingName,
                    prN = n.Process.ProcessName,
                    paN = n.Package.PackageName,
                    cfN = n.CoffeeName,
                    pID = n.ProductId,
                }).AsEnumerable().Where(c => fuzzy(c.cnN) || fuzzy(c.coN) || fuzzy(c.roN) || fuzzy(c.prN) || fuzzy(c.paN) || fuzzy(c.cfN))
                            .Select(c => c.pID).Distinct().ToList();

                temp = db.Products.Where(x => pId.Contains(x.ProductId));

            }

            var result = temp.Select(x => new CAppProductVM()
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                Price=(int)x.Price,
                Description=x.Description,
                MainPhotoPath ="49562fbf-8247-436c-9fa2-32d626786eee.jpg",
                //MainPhotoPath=x.MainPhotoPath,
                Stock =(int)x.Stock,
            });
            return JsonSerializer.Serialize(result);

            bool fuzzy(string item)
            {
                if (item.Contains(kw)) return true;
                return false;
            }
        }



    }
}
