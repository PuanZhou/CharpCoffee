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
        public MemCenterController(CoffeeContext _db, IWebHostEnvironment iweb)
        {
            db = _db;
            _environment = iweb;
        }

        public IActionResult Index() //會員中心
        {

            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                return RedirectToAction("Login", "Home");   //如果沒有登入則要求登入
            }
            else
            {
                string jsonstring = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER); //拿出session登入字串
                int memID = JsonSerializer.Deserialize<Member>(jsonstring).MemberId; //字串轉物件
                var mem = db.Members.FirstOrDefault(m => m.MemberId.Equals(memID));
                return View(mem);
            }
        }

        [HttpPost]
        public IActionResult Index(CEditMemberViewModel cmem)
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
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
                    mem.Newspaper = cmem.Newspaper;
                }
                db.SaveChanges();
                mem = db.Members.FirstOrDefault(m => m.MemberId.Equals(cmem.MemberId));
                //刷新
                string json = JsonSerializer.Serialize(mem);  //物件轉字串
                HttpContext.Session.SetString(CDictionary.SK_LOGINED_USER, json); //塞新資料到session
                return View(mem);
            }
        }

        public IActionResult ChangePW()
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
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
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                string jsonstring = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER);
                int memID = JsonSerializer.Deserialize<Member>(jsonstring).MemberId;
                var mylike = db.MyLikes.Where(m => m.MemberId == memID).Select(k => new CMyLikeViewModel()
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
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                string jsonstring = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER); //拿出session登入字串
                int memID = JsonSerializer.Deserialize<Member>(jsonstring).MemberId; //字串轉物件
                var cou = db.CouponDetails.Where(c => c.MemberId == memID && c.Coupon.CouponDeadline >= DateTime.Now).Select(c => new CCouponDetailViewModel()
                {
                    couponName = c.Coupon.CouponName,
                    money = c.Coupon.Money,
                    condition = c.Coupon.Condition,
                    startDate = c.Coupon.CouponStartDate,
                    deadline = c.Coupon.CouponDeadline
                });

                return PartialView(cou);
            }
        }

        public IActionResult QueryOrderPartialView() //訂單查詢
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                string jsonstring = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER); //拿出session登入字串
                int memID = JsonSerializer.Deserialize<Member>(jsonstring).MemberId; //字串轉物件
                var ord = db.Orders.Where(o => o.MemberId.Equals(memID))
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

        public IActionResult Notice()
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                string jsonstring = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER); //拿出session登入字串
                int memID = JsonSerializer.Deserialize<Member>(jsonstring).MemberId; //字串轉物件
                var noti = db.Notifications.Where(n => n.MemberId == memID).OrderByDescending(n => n.NotifyTime)
                .Select(n => new CNotificationViewModel()
                {
                    NotificationId = n.NotificationId,
                    NotifyTime = n.NotifyTime,
                    statement = n.OrderState.OrderState1,
                    TradeNo = n.TradeNo,
                    HasRead = n.HasRead
                }).ToList();
                return View(noti);
            }

        }

        public IActionResult GetCoupon()
        {
            DateTime now = DateTime.Now;
            var coupon = db.Coupons.Where(c => c.CouponStartDate <= now && c.CouponDeadline >= now && c.CouponId != 3).ToList();
            return View(coupon);
        }

    }
}
