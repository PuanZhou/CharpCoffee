using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prjAdmin.Models;
using prjAdmin.ViewModels;
using prjCSCoffee.Models;
using prjProduct_core.Models;
using prjProduct_core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace prjProduct_core.Controllers
{
    public class Admin_OrderController : Controller
    {
        private readonly CoffeeContext db;
        private static Admin signIn_User;

        public Admin_OrderController(CoffeeContext context)
        {
            db = context;
        }
        public IActionResult Index(CAdmin_KeywordViewModel vModel)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                string JsonUser = HttpContext.Session.GetString(CDictionary.SK_LOGINED_ADMIN);
                signIn_User = JsonSerializer.Deserialize<Admin>(JsonUser);
                if (signIn_User.OrderOk)
                {
                    IEnumerable<CAdmin_OrderViewModel> datas = null;
                    List<CAdmin_OrderViewModel> list = new List<CAdmin_OrderViewModel>();
                    var dborder = db.Orders.Select(t => new CAdmin_OrderViewModel
                    {
                        OrderId = t.OrderId,
                        Payment = t.Payment,
                        OrderState = t.OrderState,
                        TradeNo = t.TradeNo,
                        MemberId = t.MemberId,
                        OrderDate = t.OrderDate,
                        OrderStateId = t.OrderStateId,
                        PaymentId = t.PaymentId,
                        OrderAddress = t.OrderAddress,
                        OrderPhone = t.OrderPhone,
                        OrderReceiver = t.OrderReceiver
                    });

                    foreach (CAdmin_OrderViewModel item in dborder)
                    {
                        CAdmin_OrderViewModel o = new CAdmin_OrderViewModel();
                        o.OrderId = item.OrderId;
                        o.Payment = item.Payment;
                        o.OrderState = item.OrderState;
                        o.TradeNo = item.TradeNo;
                        o.MemberId = item.MemberId;
                        o.OrderDate = item.OrderDate;
                        o.OrderStateId = item.OrderStateId;
                        o.PaymentId = item.PaymentId;
                        o.OrderAddress = item.OrderAddress;
                        o.OrderPhone = item.OrderPhone;
                        o.OrderReceiver = item.OrderReceiver;
                        list.Add(o);
                    }

                    if (string.IsNullOrEmpty(vModel.txtKeyword))
                    {
                        datas = list;
                    }
                    else
                    {
                        datas = list.Where(p => p.TradeNo.Contains(vModel.txtKeyword) ||
                                    p.OrderReceiver.Contains(vModel.txtKeyword) ||
                                    p.OrderPhone.Contains(vModel.txtKeyword));
                    }

                    return View(datas);
                }

                return RedirectToAction("Index", "Admin_Dashboard");
            }

            Admin_DashboardController.btnSignInText = "登入";
            return RedirectToAction("Index", "Admin_Dashboard");
        }


        public IActionResult Filter1(int? id)
        {
            IEnumerable<CAdmin_OrderViewModel> datas = null;
            List<CAdmin_OrderViewModel> list = new List<CAdmin_OrderViewModel>();
            var dborder = db.Orders.Select(t => new CAdmin_OrderViewModel
            {
                OrderId = t.OrderId,
                Payment = t.Payment,
                OrderState = t.OrderState,
                TradeNo = t.TradeNo,
                MemberId = t.MemberId,
                OrderDate = t.OrderDate,
                OrderStateId = t.OrderStateId,
                PaymentId = t.PaymentId,
                OrderAddress = t.OrderAddress,
                OrderPhone = t.OrderPhone,
                OrderReceiver = t.OrderReceiver
            });

            foreach (CAdmin_OrderViewModel item in dborder)
            {
                CAdmin_OrderViewModel o = new CAdmin_OrderViewModel();
                o.OrderId = item.OrderId;
                o.Payment = item.Payment;
                o.OrderState = item.OrderState;
                o.TradeNo = item.TradeNo;
                o.MemberId = item.MemberId;
                o.OrderDate = item.OrderDate;
                o.OrderStateId = item.OrderStateId;
                o.PaymentId = item.PaymentId;
                o.OrderAddress = item.OrderAddress;
                o.OrderPhone = item.OrderPhone;
                o.OrderReceiver = item.OrderReceiver;
                list.Add(o);
            }
            if (id == 0)
            {
                datas = list;
            }
            else
                datas = list.Where(p => p.OrderStateId == id);

            return PartialView(datas);
        }

        public IActionResult Detail(int? id)
        {
            var couponid = db.Orders.FirstOrDefault(t => t.OrderId == id)?.CouponId;
            var fee = db.Orders.FirstOrDefault(t => t.OrderId == id)?.Fee;

            decimal couponprice = 0;

            if (fee == null) fee = 0;
            if (couponid != null)
            {
                couponprice = db.Coupons.FirstOrDefault(c => c.CouponId == couponid).Money;
            }

            var data = db.OrderDetails.Where(t => t.OrderId == id).Select(o => new
            {
                d產品名 = o.Product.ProductName,
                d單價 = o.Product.Price,
                d數量 = o.Quantity,
                d小計 = o.Product.Price * o.Quantity,
                d運費 = fee,
                d優惠卷金額 = couponprice
            });

            return Json(data);
        }

        public IActionResult Editstate(int? orderid, int? stateid)
        {
            var data = db.Orders.FirstOrDefault(t => t.OrderId == orderid);
            if (data != null)
            {
                data.OrderStateId = (int)stateid;
                #region 加入通知
                Notification noti = new Notification()
                {
                    TradeNo = data.TradeNo,
                    NotifyTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                    MemberId = data.MemberId,
                    OrderStateId = Convert.ToInt32(stateid)
                };
                db.Notifications.Add(noti);
                #endregion
                db.SaveChanges();
            }
            return RedirectToAction("index");
        }
          

    }
}


