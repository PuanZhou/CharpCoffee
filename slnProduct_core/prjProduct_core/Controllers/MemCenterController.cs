using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using prjCSCoffee.Models;
using prjCSCoffee.ViewModel;
using prjProduct_core.Models;
using prjProduct_core.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                return RedirectToRoute(new { controller = "Home", action = "Login" });   //如果沒有登入則要求登入
            }
            else
            {
                return View();
            }
        }

        public IActionResult EditPartialView(int id) //修改資料 
        {
            if (HomeController.loginmem == null)
            {
                return RedirectToRoute(new { controller = "Home", action = "Login" });   //如果沒有登入則要求登入
            }
            else
            {
                CMemberViewModel cvmem = new CMemberViewModel();
                //cvmem.MemberId = HomeController.loginmem.MemberId;
                cvmem.MemberPhone = HomeController.loginmem.MemberPhone;
                cvmem.MemberName = HomeController.loginmem.MemberName;
                cvmem.MemberEmail = HomeController.loginmem.MemberEmail;
                cvmem.MemberAddress = HomeController.loginmem.MemberAddress;
                cvmem.MemberPassword = HomeController.loginmem.MemberPassword;
                cvmem.MemberBirthDay = HomeController.loginmem.MemberBirthDay;
                //還有圖片
                return PartialView(cvmem);
            }
        }

        [HttpPost]
        public IActionResult EditPartialView(CMemberViewModel cmem)
        {
            if (HomeController.loginmem == null)
            {
                return RedirectToRoute(new { controller = "Home", action = "Login" });   //如果沒有登入則要求登入
            }
            else
            {
                Member mem = db.Members.FirstOrDefault(m => m.MemberId.Equals(cmem.MemberId));
                if (mem != null && ModelState.IsValid) //符合驗證
                {
                    if(cmem.photo !=null )  //如果有上傳照片
                    {
                        string photoname = Guid.NewGuid().ToString()+".jpg";
                        cmem.photo.CopyTo(new FileStream(_environment.WebRootPath + "/img/Mem-img/" + photoname, FileMode.Create));
                        mem.MemberPhotoPath = photoname;
                    }

                    mem.MemberName = cmem.MemberName;
                    mem.MemberEmail = cmem.MemberEmail;
                    mem.MemberAddress = cmem.MemberAddress;
                    mem.MemberPassword = cmem.MemberPassword;
                }
                db.SaveChanges();
                mem = db.Members.FirstOrDefault(m => m.MemberId.Equals(cmem.MemberId));
                HomeController.loginmem = mem; //刷新
                return RedirectToAction("Index");
            }

        }

        public IActionResult MyLikePartial()
        {
            if (HomeController.loginmem == null)
            {
                return RedirectToRoute(new { controller = "Home", action = "Login" }); 
            }
            else
            {
                var mylike = db.MyLikes.Where(m => m.MemberId == HomeController.loginmem.MemberId).Select(k => new CMyLikeViewModel()
                {
                    ProductId = k.ProductId,
                    productname = k.Product.ProductName,
                    price = k.Product.Price,
                    MainPhotoPath = k.Product.MainPhotoPath
                });
                return PartialView(mylike);
            }
            
        }

        public IActionResult CouponPartialView() //優惠券
        {
            if (HomeController.loginmem == null)
            {
                return RedirectToRoute(new { controller = "Home", action = "Login" });   //如果沒有登入則要求登入
            }
            else
            {
                var cou = db.CouponDetails.Where(c => c.MemberId == HomeController.loginmem.MemberId).Select(c => new CCouponDetailViewModel()
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
                return RedirectToRoute(new { controller = "Home", action = "Login" });   //如果沒有登入則要求登入
            }
            else
            {

                var ord = db.Orders.Where(o => o.MemberId.Equals(HomeController.loginmem.MemberId))
                    .Select(o=>new COrderViewModel(){ 
                        OrderId = o.OrderId,
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

        public IActionResult GiveBackPartialView() //退貨
        {
            if (HomeController.loginmem == null)
            {
                return RedirectToRoute(new { controller = "Home", action = "Login" });   //如果沒有登入則要求登入
            }
            else
            {
                return PartialView();
            }
        }



    }
}
