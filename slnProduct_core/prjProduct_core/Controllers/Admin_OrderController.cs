using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using prjAdmin.Models;
using prjAdmin.ViewModels;
using prjCSCoffee.Models;
using prjProduct_core.Models;
using prjProduct_core.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace prjProduct_core.Controllers
{
    public class Admin_OrderController : Controller
    {
        private readonly CoffeeContext db;
        private static Admin signIn_User;
        private readonly IConfiguration _configuration;

        public Admin_OrderController(CoffeeContext context, IConfiguration configuration)
        {
            db = context;
            _configuration = configuration;
        }
        public IActionResult Index(CAdmin_KeywordViewModel vModel)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                string JsonUser = HttpContext.Session.GetString(CDictionary.SK_LOGINED_ADMIN);
                signIn_User = System.Text.Json.JsonSerializer.Deserialize<Admin>(JsonUser);
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
                d單價 = o.Price,
                d數量 = o.Quantity,
                d小計 = o.Price * o.Quantity,
                d運費 = fee,
                d優惠卷金額 = couponprice
            });

            return Json(data);
        }

        public IActionResult Editstate(int? orderid, int? oldstateid, int? newstateid)
        {
            var data = db.Orders.Include(o=>o.Member).FirstOrDefault(t => t.OrderId == orderid);
            if (data != null)
            {
                if (oldstateid == 5 && newstateid == 4)
                {
                    EditProStock(orderid);
                }
                data.OrderStateId = (int)newstateid;
                #region 加入通知
                Notification noti = new Notification()
                {
                    TradeNo = data.TradeNo,
                    NotifyTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                    MemberId = data.MemberId,
                    OrderStateId = Convert.ToInt32(newstateid)
                };
                db.Notifications.Add(noti);
                #endregion
                db.SaveChanges();
            }

            if (newstateid == 3) // 假如訂單狀態修改為"已送達收穫地址"
            {
                string name = data.Member.MemberName, // 收件者姓名
                       tradeNo = data.TradeNo; // 訂單編號

                string strResponse = string.Empty;
                var strURL = "https://mail.surenotifyapi.com/v1/sms/messages"; // 電子豹API
                //string body = @"{
                //    'content': '親愛的 {{NAME}} 您好，你的包裹已送達，請攜帶雙證件前往取貨。您的取貨編號為： {{NUMBER}}',
                //    'recipients': [
                //        {
                //            'address': '0905815005',
                //            'country_code': '886',
                //            'variables': {
                //                'TradeNo': '123456'
                //            }
                //        }
                //    ]
                //}";
                JObject obj = new JObject { { "content", $"親愛的 {name} 您好，CSharp咖啡提醒您的包裹已送達，請攜帶雙證件前往取貨。您的取貨編號為： {tradeNo}" } }; // 簡訊內容
                JArray recipients = new JArray
                {
                    new JObject{ { "address", "0905815005" }, { "country_code", "886" }} // 傳送到我的手機，國別台灣
                };
                obj.Add("recipients", recipients);

                string JsonContent = JsonConvert.SerializeObject(obj, formatting: Formatting.Indented);
                HttpWebRequest request = HttpWebRequest.Create(strURL) as HttpWebRequest;
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Headers.Add("Content-Type", "application/json");
                request.Headers.Add("Accept", "application/json");

                string apiKey = _configuration.GetValue<string>("AppConfiguration:x-api-key"); // 從組態檔中匯入API金鑰
                request.Headers.Add("x-api-key", apiKey);

                UTF8Encoding encoding = new UTF8Encoding();
                Byte[] byteArray = encoding.GetBytes(JsonContent);
                request.ContentLength = byteArray.Length;

                using (Stream dataStream = request.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                }

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse) // 查詢結果用
                {
                    using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                    {
                        strResponse = reader.ReadToEnd();
                    }
                }

                //return Content(strResponse);
            }
            return RedirectToAction("index");
        }

        public IActionResult EditProStock(int? orderid)
        {
            var data = db.OrderDetails.Where(o => o.OrderId == orderid).Select(o => new
            {
                Fproid = o.ProductId,
                Fquantity = o.Quantity
            }).ToList();

            foreach (var item in data)
            {
                var prod = db.Products.FirstOrDefault(p => p.ProductId == item.Fproid);
                prod.Stock += item.Fquantity;
            }
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}


