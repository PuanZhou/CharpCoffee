using Microsoft.AspNetCore.Mvc;
using prjCSCoffee.Models;
using prjProduct_core.Models;
using prjProduct_core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjProduct_core.Controllers
{
    public class Admin_CouponController : Controller
    {
        private readonly CoffeeContext db;
        public Admin_CouponController(CoffeeContext context)
        {
            db = context;
        }
        public IActionResult CouponList()
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                var coulist = db.Coupons.Select(c => new CCouponViewModel()
                {
                    CouponId = c.CouponId,
                    CouponName = c.CouponName,
                    Condition = c.Condition,
                    CouponStartDate = c.CouponStartDate,
                    CouponDeadline = c.CouponDeadline,
                    Money = c.Money
                }).ToList();
                return View(coulist);
            }
            else
            {
                Admin_DashboardController.btnSignInText = "登入";
                return RedirectToAction("Error403", "Admin_Dashboard");
            }
        }

        public IActionResult DeleteCoupon(int id)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                if (id != null)
                {
                    //刪除前消除擁有該優惠券的所有會員1.先消除CouponDetail & HeldCoupon
                    var heldmem = db.HeldCoupons.Where(hm => hm.CouponId == id).ToList();
                    var havingmem = db.CouponDetails.Where(hcm => hcm.CouponId == id).ToList();//目前持有該券的會員
                    foreach (var item in heldmem)
                    {
                        db.HeldCoupons.Remove(item);
                    }
                    foreach (var item in havingmem)
                    {
                        db.CouponDetails.Remove(item);
                    }
                    db.SaveChanges();
                    //2.再刪除該優惠券
                    var cou = db.Coupons.FirstOrDefault(c => c.CouponId == id);
                    db.Coupons.Remove(cou);
                    db.SaveChanges();
                    return Content("OK", "text/plain", Encoding.UTF8);
                }
                else
                {
                    return Content("Err", "text/plain", Encoding.UTF8);
                }
            }
            return Content("Login", "text/plain", Encoding.UTF8);
            
        }

        public IActionResult Create()
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                return View();
            }
            return RedirectToAction("Error403", "Admin_Dashboard");
        }
        [HttpPost]
        public IActionResult Create(CCouponViewModel ccvm)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                if (ModelState.IsValid)
                {
                    Coupon cou = new Coupon()
                    {
                        CouponName = ccvm.CouponName,
                        Condition = ccvm.Condition,
                        Money = ccvm.Money,
                        CouponStartDate = Convert.ToDateTime(ccvm.CouponStartDate),
                        CouponDeadline = Convert.ToDateTime(ccvm.CouponDeadline)
                    };
                    db.Coupons.Add(cou);
                    db.SaveChanges();
                    return RedirectToAction("CouponList");
                }
                return View();
            }
            return RedirectToAction("Error403", "Admin_Dashboard");
        }

    }
}
