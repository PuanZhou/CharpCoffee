using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using prjProduct_core.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Drawing;
using System;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace prjProduct_core.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class R_MemberController : ControllerBase
    {
        private readonly CoffeeContext db;
        private readonly IWebHostEnvironment _host;

        public R_MemberController(CoffeeContext context, IWebHostEnvironment hostEnvironment)
        {
            db = context;
            _host = hostEnvironment;
        }

        [HttpGet]
        public string Get()
        {
            Byte[] b = System.IO.File.ReadAllBytes(_host.WebRootPath + "/temp/1017616.jpg");
            return JsonSerializer.Serialize(b);
        }

        //===============會員中心(訂單記錄)
        [HttpGet("{id}")]
        public IQueryable<Order> Get(int id)
        {
            return db.Orders.Where(m => m.MemberId == id);
        }

        //================會員登入===================
        [HttpGet("{id}/{pw}")] 
        public string Get(string id, string pw)
        {
            var result = db.Members.Where(x => x.MemberPhone == id && x.MemberPassword == pw).FirstOrDefault();
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
