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
using prjProduct_core.ViewModel;
using System.Threading.Tasks;


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

        //===============訂單記錄/訂單明細==========
        [HttpGet("{t_id}")]
        public string Get(string t_id)
        {
            string type = t_id.Substring(0, 1);
            int id =int.Parse(t_id.Substring(2));

            if (type == "o")
            {
                var result = db.Orders.Where(m => m.MemberId == id).Select(x=> new CAppOrderVM() { 
                    OrderId=x.OrderId,
                    MemberId = x.MemberId,
                    OrderDate =x.OrderDate,
                    OrderState=x.OrderState.OrderState1,
                    //PaymentId=x.PaymentId,
                    //PaymentName =x.Payment.Payment1,
                    //OrderAddress =x.OrderAddress,
                    //OrderReceiver =x.OrderReceiver,
                    //OrderPhone =x.OrderPhone,
                    //CouponId=(int)x.CouponId,
                    //CouponName=x.Coupon.CouponName,
                    //Fee=(int)x.Fee,
                    //TradeNo=x.TradeNo,
                });
                return JsonSerializer.Serialize(result);
            }
            else
            {
                var result = db.OrderDetails.Where(m => m.OrderId == id).Select(x=>new CAppOrderDetailVM()
                {
                    OrderDetailsId=x.OrderDetailsId,
                    OrderId=x.OrderId,
                    ProductId=x.ProductId,
                    ProductName=x.Product.ProductName,
                    Quantity=x.Quantity,
                    Price=(int)x.Product.Price,
            });
                return JsonSerializer.Serialize(result);
            }            
        }
        //================會員登入===================
        [HttpGet("{id}/{pw}")] 
        public string Get(string id, string pw)
        {
            var result = db.Members.Where(x => x.MemberPhone == id && x.MemberPassword == pw).FirstOrDefault();
            return JsonSerializer.Serialize(result);
        }

        //==============購物(新增order)======================
        //https://prjcoffee.azurewebsites.net/api/R_Member
        [HttpPost]
        public async Task<ActionResult<string>> Post(CAppOrderVM o)
        {
            Order order = new Order();
            string tradeNo = Guid.NewGuid().ToString();
            order.MemberId = o.MemberId;
            order.OrderDate = DateTime.Now;
            order.OrderStateId = 1;
            order.PaymentId = 2;
            order.OrderAddress = db.Members.Where(x=>x.MemberId==o.MemberId).Select(x=>x.MemberAddress).FirstOrDefault();
            order.OrderReceiver = db.Members.Where(x => x.MemberId == o.MemberId).Select(x => x.MemberName).FirstOrDefault();
            order.OrderPhone = db.Members.Where(x => x.MemberId == o.MemberId).Select(x => x.MemberPhone).FirstOrDefault(); 
            order.TradeNo = tradeNo.Substring(tradeNo.Length - 12, 12);

            db.Orders.Add(order);
            await db.SaveChangesAsync();

            return "成功";
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
