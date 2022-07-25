using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using prjProduct_core.Models;
using prjProduct_core.ViewModel;
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
              var result = db.ShoppingCarDetails.Where(m => m.MemberId == id).Select(x => new CAppCartVM()
              {
                  ShoppingCarDetialsId = x.ShoppingCarDetialsId,
                  MemberId = x.MemberId,
                  ProductsId=(int)x.ProductsId,
                  ProductName=x.Products.ProductName,
                  Price=(int)x.Price,
                  Quantity=(int)x.Quantity,
                  Description=x.Products.Description,
                  Stock=(int)x.Products.Stock,
                  //MainPhotoPath=x.Products.MainPhotoPath,
                  MainPhotoPath= "4f127afc-4031-4b15-89e4-e39a8f66b57c.jpg",
              });
            return JsonSerializer.Serialize(result);
        }

        //// POST api/<WApiController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<WApiController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<WApiController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
