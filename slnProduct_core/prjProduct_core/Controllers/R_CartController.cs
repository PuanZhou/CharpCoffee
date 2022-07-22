using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using prjProduct_core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace prjProduct_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class R_CartController : ControllerBase
    {
        private readonly CoffeeContext db;
        private readonly IWebHostEnvironment _host;

        public R_CartController(CoffeeContext context, IWebHostEnvironment hostEnvironment)
        {
            db = context;
            _host = hostEnvironment;
        }

        //================查購物車===================
        [HttpGet("{id}")]
        public string Get(int id)
        {
              var result = db.ShoppingCarDetails.AsEnumerable().Where(m => m.MemberId == id)
                .Select(x => x);

            return JsonSerializer.Serialize(result);
        }

        //================查購物車內某商品數量===================
        [HttpGet("{mId}/{pId}")]
        public int Get(int mId,int pId)
        {
            return db.ShoppingCarDetails.Where(m => m.MemberId == mId && m.ProductsId == pId)
                .Sum(x => (int)x.Quantity);
        }
    }
}
