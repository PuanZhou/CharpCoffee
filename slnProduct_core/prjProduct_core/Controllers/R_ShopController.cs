using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using prjProduct_core.Models;
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

        //================分類搜尋===================
        [HttpGet("{c_id}")]
        public string Get(string c_id)
        {
            string c = c_id.Substring(0, 2);
            int id = int.Parse(c_id.Substring(3));
            IQueryable<Product> result;

            if (c == "co")
                result = db.Products.Where(x => x.Country.ContinentId==id);
            else if (c == "cy")
                result = db.Products.Where(x => x.CountryId == id);
            else if (c == "ro")
                result = db.Products.Where(x => x.Coffee.RoastingId == id);
            else if (c == "pr")
                result = db.Products.Where(x => x.Coffee.ProcessId == id);
            else //c=="pa"
                result = db.Products.Where(x => x.Coffee.PackageId == id);

            return JsonSerializer.Serialize(result);
        }

        [HttpGet]
        public IActionResult Get()
        {
            Byte[] b = System.IO.File.ReadAllBytes(_host.WebRootPath + "/temp/積木啦.png");
            return File(b, "image/png");
        }
    }
}
