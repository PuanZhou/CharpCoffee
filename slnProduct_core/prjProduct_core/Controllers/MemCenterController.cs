using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prjCSCoffee.Models;
using prjCSCoffee.ViewModel;
using prjProduct_core.Models;
using prjProduct_core.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace prjProduct_core.Controllers
{
    public class MemCenterController : Controller
    {
        private readonly CoffeeContext db;
        IWebHostEnvironment _environment;
        public MemCenterController(CoffeeContext _db , IWebHostEnvironment iweb)
        {
            db = _db;
            _environment = iweb;
        }

        public IActionResult Index() //會員中心
        {

            if (HomeController.loginmem==null)
            {
                return RedirectToAction("Login", "Home");   //如果沒有登入則要求登入
            }
            else
            {
                var mem = db.Members.FirstOrDefault(m => m.MemberId.Equals(HomeController.loginmem.MemberId));
                return View(mem);
            }
        }

        [HttpPost]
        public IActionResult Index(CMemberViewModel cmem)
        {
            if (HomeController.loginmem == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                Member mem = db.Members.FirstOrDefault(m => m.MemberId.Equals(cmem.MemberId));
                if (mem != null && ModelState.IsValid) //符合驗證
                {
                    if (cmem.photo != null)  //如果有上傳照片
                    {
                        string photoname = Guid.NewGuid().ToString() + ".jpg";
                        cmem.photo.CopyTo(new FileStream(_environment.WebRootPath + "/img/Mem-img/" + photoname, FileMode.Create));
                        mem.MemberPhotoPath = photoname;
                    }
                    mem.MemberName = cmem.MemberName;
                    mem.MemberEmail = cmem.MemberEmail;
                    mem.MemberAddress = cmem.MemberAddress;
                    mem.MemberPassword = cmem.MemberPassword;
                    mem.Newspaper = cmem.Newspaper;
                }
                db.SaveChanges();
                mem = db.Members.FirstOrDefault(m => m.MemberId.Equals(cmem.MemberId));
                HomeController.loginmem = mem; //刷新
                string json = JsonSerializer.Serialize(HomeController.loginmem);
                HttpContext.Session.SetString(CDictionary.SK_LOGINED_USER, json);
                return View(mem);
            }
        }

        public IActionResult ChangePW()
        {
            if (HomeController.loginmem == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                return PartialView();
            }
            
        }

        public IActionResult MyLikePartial()
        {
            if (HomeController.loginmem == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                var mylike = db.MyLikes.Where(m => m.MemberId == HomeController.loginmem.MemberId).Select(k => new CMyLikeViewModel()
                {
                    ProductId = k.ProductId,
                    productname = k.Product.ProductName,
                    price = k.Product.Price,
                    MainPhotoPath = k.Product.MainPhotoPath,
                    CategoryId = k.Product.CategoryId
                });
                return PartialView(mylike);
            }
            
        }

        public IActionResult CouponPartialView() //優惠券
        {
            if (HomeController.loginmem == null)
            {
                return RedirectToAction("Login", "Home");   //如果沒有登入則要求登入
            }
            else
            {
                
                var cou = db.CouponDetails.Where(c => c.MemberId == HomeController.loginmem.MemberId &&c.Coupon.CouponDeadline>=DateTime.Now).Select(c => new CCouponDetailViewModel()
                {
                    couponName = c.Coupon.CouponName,
                    money = c.Coupon.Money,
                    condition  =c.Coupon.Condition,
                    startDate = c.Coupon.CouponStartDate,
                    deadline = c.Coupon.CouponDeadline
                });

                return PartialView(cou);
            }
        }

        public IActionResult QueryOrderPartialView() //訂單查詢
        {
            if (HomeController.loginmem == null)
            {
                return RedirectToAction("Login", "Home");   //如果沒有登入則要求登入
            }
            else
            {

                var ord = db.Orders.Where(o => o.MemberId.Equals(HomeController.loginmem.MemberId))
                    .Select(o => new COrderViewModel()
                    {
                        TradeNo = o.TradeNo,
                        OrderDate = o.OrderDate,
                        OrderAddress = o.OrderAddress,
                        OrderReceiver = o.OrderReceiver,
                        OrderPhone = o.OrderPhone,
                        orderstatement = o.OrderState.OrderState1,
                        payway = o.Payment.Payment1
                    });

                return PartialView(ord);
            }
        }


    }
}
