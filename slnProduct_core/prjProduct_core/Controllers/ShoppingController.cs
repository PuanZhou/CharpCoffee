using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prjCSCoffee.Models;
using prjCSCoffee.ViewModel;
using prjProduct_core.Controllers;
using prjProduct_core.Models;
using prjProduct_core.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace prjCSCoffee.Controllers
{
    public class ShoppingController : Controller
    {
        private readonly CoffeeContext db;
        public ShoppingController(CoffeeContext conetxt)
        {
            db = conetxt;
        }
        int UserId = 1;
        public IActionResult ShoppingCar()
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                UserId = JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;

                var datas = db.ShoppingCarDetails.Where(t => t.MemberId == UserId)
                  .Select(t => new CShoppingCarDetailsViewModel
                  {
                      ProductsId = t.ProductsId,
                      Quantity = t.Quantity,
                      Price = t.Price,
                      product = t.Products,
                      ProStock = t.Products.Stock,
                      ProPhotoPath = t.Products.MainPhotoPath,
                      ShoppingCarDetialsId = t.ShoppingCarDetialsId
                  });
                if (datas.ToList().Count == 0)
                {
                    return RedirectToAction("ShoppingCarEmpty");
                }
                var data2 = db.CouponDetails.Where(t => t.MemberId == UserId)
                   .Select(c => new
                   {
                       Fcouponid = c.CouponId,
                       Fcouponname = c.Coupon.CouponName,
                       Fcouponmoney = c.Coupon.Money,
                       Fcouponstart = c.Coupon.CouponStartDate,
                       Fcouponend = c.Coupon.CouponDeadline,
                       Fcondition = c.Coupon.Condition,
                       fcoupon = c.Coupon
                   }).ToList();

                List<CShoppingCartItem> list = new List<CShoppingCartItem>();
                foreach (var item in datas)
                {
                    CShoppingCartItem t = new CShoppingCartItem();
                    t.productId = (int)item.ProductsId;
                    t.count = (int)item.Quantity;
                    t.price = (decimal)item.Price;
                    t.product = item.product;
                    t.stock = (int)item.ProStock;
                    t.mainPhotoPath = item.ProPhotoPath;
                    t.ShoppingCarDetialsId = item.ShoppingCarDetialsId;

                    List<Coupon> cc = new List<Coupon>();
                    foreach (var item1 in data2)
                    {
                        Coupon t2 = new Coupon();
                        t2.CouponId = (int)item1.Fcouponid;
                        t2.CouponName = item1.Fcouponname;
                        t2.Money = item1.Fcouponmoney;
                        t2.CouponStartDate = item1.Fcouponstart;
                        t2.CouponDeadline = item1.Fcouponend;
                        t2.Condition = item1.Fcondition;
                        cc.Add(t2);
                    };
                    t.couponall = cc;
                    list.Add(t);
                }
                return View(list);
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }

        public IActionResult PartialViewCart()
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                UserId = JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;

                var datas = db.ShoppingCarDetails.Where(t => t.MemberId == UserId)
                  .Select(t => new CShoppingCarDetailsViewModel
                  {
                      ProductsId = t.ProductsId,
                      Quantity = t.Quantity,
                      Price = t.Price,
                      product = t.Products,
                      ProStock = t.Products.Stock,
                      ProPhotoPath = t.Products.MainPhotoPath,
                      ShoppingCarDetialsId = t.ShoppingCarDetialsId
                  });
                if (datas.ToList().Count == 0)
                {
                    return RedirectToAction("ShoppingCarEmpty");
                }
                var data2 = db.CouponDetails.Where(t => t.MemberId == UserId)
                   .Select(c => new
                   {
                       Fcouponid = c.CouponId,
                       Fcouponname = c.Coupon.CouponName,
                       Fcouponmoney = c.Coupon.Money,
                       Fcouponstart = c.Coupon.CouponStartDate,
                       Fcouponend = c.Coupon.CouponDeadline,
                       Fcondition = c.Coupon.Condition,
                       fcoupon = c.Coupon
                   }).ToList();

                List<CShoppingCartItem> list = new List<CShoppingCartItem>();
                foreach (var item in datas)
                {
                    CShoppingCartItem t = new CShoppingCartItem();
                    t.productId = (int)item.ProductsId;
                    t.count = (int)item.Quantity;
                    t.price = (decimal)item.Price;
                    t.product = item.product;
                    t.stock = (int)item.ProStock;
                    t.mainPhotoPath = item.ProPhotoPath;
                    t.ShoppingCarDetialsId = item.ShoppingCarDetialsId;

                    List<Coupon> cc = new List<Coupon>();
                    foreach (var item1 in data2)
                    {
                        Coupon t2 = new Coupon();
                        t2.CouponId = (int)item1.Fcouponid;
                        t2.CouponName = item1.Fcouponname;
                        t2.Money = item1.Fcouponmoney;
                        t2.CouponStartDate = item1.Fcouponstart;
                        t2.CouponDeadline = item1.Fcouponend;
                        t2.Condition = item1.Fcondition;
                        cc.Add(t2);
                    };
                    t.couponall = cc;
                    list.Add(t);
                }
                return PartialView(list);
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }

        public IActionResult ShoppingCarEmpty()
        {   //如果購物車為空的話，跳這邊
            return View();
        }

        public IActionResult FloatPartialViewCart()
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                UserId = JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;

                var datas = db.ShoppingCarDetails.Where(t => t.MemberId == UserId)
                  .Select(t => new CShoppingCarDetailsViewModel
                  {
                      ProductsId = t.ProductsId,
                      Quantity = t.Quantity,
                      Price = t.Price,
                      product = t.Products,
                      ProStock = t.Products.Stock,
                      ProPhotoPath = t.Products.MainPhotoPath,
                      ShoppingCarDetialsId = t.ShoppingCarDetialsId
                  });


                List<CShoppingCartItem> list = new List<CShoppingCartItem>();
                foreach (var item in datas)
                {
                    CShoppingCartItem t = new CShoppingCartItem();
                    t.productId = (int)item.ProductsId;
                    t.count = (int)item.Quantity;
                    t.price = (decimal)item.Price;
                    t.product = item.product;
                    t.stock = (int)item.ProStock;
                    t.mainPhotoPath = item.ProPhotoPath;
                    t.ShoppingCarDetialsId = item.ShoppingCarDetialsId;
                    list.Add(t);
                }
                return PartialView(list);
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }

        public IActionResult UseCoupon(int? id)
        {
            var money = db.Coupons.Where(t => t.CouponId == id).Select(t => t.Money);
            string jsonCart = "";
            List<CDeliveryViewModel> list = new List<CDeliveryViewModel>();
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_使用的折價卷))
                list = new List<CDeliveryViewModel>();
            else
            {
                jsonCart = HttpContext.Session.GetString(CDictionary.SK_使用的折價卷);
                list = JsonSerializer.Deserialize<List<CDeliveryViewModel>>(jsonCart);
            }
            foreach (var item in money)
            {
                CDeliveryViewModel t = new CDeliveryViewModel();
                t.discountid = (int)id;
                t.discountmoney = (int)item;
                list.Add(t);
            }
            jsonCart = JsonSerializer.Serialize(list);
            HttpContext.Session.SetString(CDictionary.SK_使用的折價卷, jsonCart);
            return View();
        }

        public IActionResult AddtoCart(int? id, int quantity, int price)
        {

            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                UserId = JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;

                //表示該產品是購物車狀態
                var currentCar = db.ShoppingCarDetails
                    .Where(m => m.ProductsId == id && m.MemberId == UserId && m.Price == price)
                    .FirstOrDefault();
                //若currentCar等於null，表示會員選購的產品不是購物車狀態
                if (currentCar == null)
                {
                    //找出目前選購的產品並指定給product
                    var product = db.Products.Where(m => m.ProductId == id).FirstOrDefault();
                    //將產品放入訂單明細，因為產品的fIsApproved為"否"，表示為購物車狀態
                    ShoppingCarDetail carDetail = new ShoppingCarDetail();
                    carDetail.MemberId = UserId;
                    carDetail.ProductsId = product.ProductId;
                    carDetail.Price = product.Price;
                    carDetail.Quantity = quantity;
                    db.ShoppingCarDetails.Add(carDetail);
                }
                else
                {
                    currentCar.Quantity += quantity;
                }
                db.SaveChanges();
                return Content("add", "text/plain", System.Text.Encoding.UTF8);
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }

        public IActionResult SaleAddtoCart(int? id, int quantity, int price)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                UserId = JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;
                var currentCar = db.ShoppingCarDetails
                    .Where(m => m.ProductsId == id && m.MemberId == UserId && m.Price == price)
                    .FirstOrDefault();
                if (currentCar == null)
                {
                    var product = db.Products.Where(m => m.ProductId == id).FirstOrDefault();
                    ShoppingCarDetail carDetail = new ShoppingCarDetail();
                    carDetail.MemberId = UserId;
                    carDetail.ProductsId = product.ProductId;
                    carDetail.Price = product.Price * 0.8m;
                    carDetail.Quantity = quantity;
                    db.ShoppingCarDetails.Add(carDetail);
                }
                else
                {
                    currentCar.Quantity += quantity;
                }
                db.SaveChanges();
                return Content("add", "text/plain", System.Text.Encoding.UTF8);
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }

        }

        public IActionResult Delete(int? id, int price) //購物車按鈕用ㄉ
        {
            UserId = JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;
            var prod = db.ShoppingCarDetails.FirstOrDefault(t => t.MemberId == UserId && t.ProductsId == id && t.Price == price);

            db.ShoppingCarDetails.Remove(prod);
            db.SaveChanges();
            return RedirectToAction("ShoppingCar");
        }

        public IActionResult Deletedrop(int? id) //拖拉刪的(抓shoppingdetail id)
        {
            UserId = JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;
            var prod = db.ShoppingCarDetails.FirstOrDefault(t => t.ShoppingCarDetialsId == id);

            db.ShoppingCarDetails.Remove(prod);
            db.SaveChanges();
            return RedirectToAction("ShoppingCar");
        }

        public IActionResult DeleteAll() //刪全部ㄉ購物車
        {
            UserId = JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;
            var data = db.ShoppingCarDetails.Where(t => t.MemberId == UserId);

            foreach (var item in data)
            {
                db.ShoppingCarDetails.Remove(item);
            }
            db.SaveChanges();
            return RedirectToAction("ShoppingCar");
        }
        public IActionResult Plus(int? id, int price)
        {
            UserId = JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;
            ShoppingCarDetail prod = db.ShoppingCarDetails.FirstOrDefault(t => t.MemberId == UserId && t.ProductsId == id && t.Price == price);

            if (prod != null)
            {
                prod.Quantity += 1;
            }
            db.SaveChanges();
            return RedirectToAction("ShoppingCar");
        }

        public IActionResult Reduce(int? id, int price)
        {
            UserId = JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;

            ShoppingCarDetail prod = db.ShoppingCarDetails.FirstOrDefault(t => t.MemberId == UserId && t.ProductsId == id && t.Price == price);

            if (prod != null)
            {
                prod.Quantity -= 1;
            }
            db.SaveChanges();
            return RedirectToAction("ShoppingCar");
        }

        public IActionResult Car2()
        {
            UserId = HomeController.loginmem.MemberId;
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_使用的折價卷))
            {
                int pay = 0;
                string jsonCart = HttpContext.Session.GetString(CDictionary.SK_使用的折價卷);
                var list1 = JsonSerializer.Deserialize<List<CDeliveryViewModel>>(jsonCart);
                foreach (var item1 in list1)
                {
                    pay = item1.discountid;
                }
                ViewData["discount"] = pay;
            }

            var add = db.Members.FirstOrDefault(m => m.MemberId == UserId).MemberAddress;
            ViewBag.memAddress = add;
            return View();
        }

        [HttpPost]
        public IActionResult Car2(CDeliveryViewModel vModel)
        {
            string jsonCart = "";
            List<CShoppingCartItem> list = null;
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_付款資訊))
                list = new List<CShoppingCartItem>();
            else
            {
                jsonCart = HttpContext.Session.GetString(CDictionary.SK_付款資訊);
                list = JsonSerializer.Deserialize<List<CShoppingCartItem>>(jsonCart);
            }

            int discountmoney = 0;
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_使用的折價卷))
            {
                string jsonCart3 = HttpContext.Session.GetString(CDictionary.SK_使用的折價卷);
                var list3 = JsonSerializer.Deserialize<List<CDeliveryViewModel>>(jsonCart3);
                foreach (var item1 in list3)
                {
                    discountmoney = item1.discountmoney;
                }
            }
            var datas = db.ShoppingCarDetails.Where(t => t.MemberId == UserId).Select(t => new { fPrice = t.Price * t.Quantity });
            int total = 0;
            int fee = 0;
            foreach (var item1 in datas)
            {
                total += (int)item1.fPrice;
            }
            total = total - discountmoney;
            if (total < 1200)
            {
                fee = 100;
                total = total + fee;
            }

            CShoppingCartItem item = new CShoppingCartItem()
            {
                Receiver = vModel.fReceiver,
                Phone = vModel.fPhone,
                Address = vModel.fAddress,
                Payment = vModel.payment,
                Discount = vModel.discountid,
                Fee = fee
            };

            list.Add(item);
            jsonCart = JsonSerializer.Serialize(list);
            HttpContext.Session.SetString(
                CDictionary.SK_付款資訊, jsonCart);
            return RedirectToAction("Car3");
        }

        public IActionResult Car3()
        {
            UserId = JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;
            ViewBag.discountmoney = 0;
            int discountmoney = 0;
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_使用的折價卷))
            {
                string jsonCart3 = HttpContext.Session.GetString(CDictionary.SK_使用的折價卷);
                var list3 = JsonSerializer.Deserialize<List<CDeliveryViewModel>>(jsonCart3);
                foreach (var item in list3)
                {
                    discountmoney = item.discountmoney;
                    ViewBag.discountmoney = item.discountmoney;
                }
            }

            var datas = db.ShoppingCarDetails.Where(t => t.MemberId == UserId)
                  .Select(t => new {
                      Fid = t.ProductsId,
                      FName = t.Products.ProductName,
                      Fcount = t.Quantity,
                      Fprice = t.Price,
                      Fproduct = t.Products,
                      FPhoto = t.Products.MainPhotoPath
                  });

            #region 金流支付
            string tradeNo = Guid.NewGuid().ToString();
            tradeNo = tradeNo.Substring(tradeNo.Length - 12, 12);
            ViewBag.tradeNo = tradeNo;
            string timenow = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            ViewBag.timenow = timenow;

            int total = 0;
            string ItemName = "";
            foreach (var item in datas)
            {
                int price = (int)item.Fprice;
                total += ((int)(item.Fcount) * price);
                ItemName += $"{item.FName} NT${Convert.ToInt32(item.Fprice).ToString("0")}X{item.Fcount}#";
            }
            total = total - discountmoney;
            if (total < 1200) { total = total + 100; }

            ItemName = ItemName.Substring(0, ItemName.Length - 1);

            ViewBag.Total = total;
            ViewBag.ItemName = ItemName;

            NameValueCollection parameters = HttpUtility.ParseQueryString(string.Empty);

            parameters["HashKey"] = "5294y06JbISpM5x9";
            parameters["ChoosePayment"] = "Credit";
            parameters["ClientBackURL"] = $"{Request.Scheme}://{Request.Host}/Shopping/SendOrder/?id={tradeNo}";    //完成後跳回去的頁面
            parameters["CreditInstallment"] = "";
            parameters["EncryptType"] = "1";
            parameters["InstallmentAmount"] = "";
            parameters["ItemName"] = ItemName;
            parameters["MerchantID"] = "2000132";
            parameters["MerchantTradeDate"] = timenow;
            parameters["MerchantTradeNo"] = tradeNo;
            parameters["PaymentType"] = "aio";
            parameters["Redeem"] = "";
            parameters["ReturnURL"] = "https://developers.opay.tw/AioMock/MerchantReturnUrl";
            parameters["StoreID"] = "";
            parameters["TotalAmount"] = total.ToString();
            parameters["TradeDesc"] = "建立信用卡測試訂單";
            parameters["HashIV"] = "v77hoKGq4kWxNNIS";

            ViewBag.ClientBackURL = $"{Request.Scheme}://{Request.Host}/Shopping/SendOrder/?id={tradeNo}";

            string checkMacValue = parameters.ToString();

            checkMacValue = checkMacValue.Replace("=", "%3d").Replace("&", "%26");

            using var hash = SHA256.Create();
            var byteArray = hash.ComputeHash(Encoding.UTF8.GetBytes(checkMacValue.ToLower()));
            checkMacValue = Convert.ToHexString(byteArray).ToUpper();
            ViewBag.checkMacValue = checkMacValue;
            #endregion

            List<CShoppingCartItem> list = new List<CShoppingCartItem>();
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_付款資訊))
            {
                string jsonCart = HttpContext.Session.GetString(CDictionary.SK_付款資訊);
                var list1 = JsonSerializer.Deserialize<List<CShoppingCartItem>>(jsonCart);
                var paymentname = db.Payments.FirstOrDefault(t => t.PaymentId == list1[0].Payment).Payment1;

                foreach (var item in datas)
                {
                    CShoppingCartItem t = new CShoppingCartItem();
                    t.productId = (int)item.Fid;
                    t.count = (int)item.Fcount;
                    t.price = (decimal)item.Fprice;
                    t.product = item.Fproduct;
                    t.MerchantTradeNo = tradeNo;
                    t.mainPhotoPath = item.FPhoto;
                    foreach (var item1 in list1)
                    {
                        t.Receiver = item1.Receiver;
                        t.Phone = item1.Phone;
                        t.Payment = item1.Payment;
                        t.Address = item1.Address;
                        t.Paymentname = paymentname;
                    }
                    list.Add(t);
                }
                return View(list);
            }
            else
                return RedirectToAction("view", "shop");
        }

        public IActionResult SendOrder(CShoppingCartItem vModel, string id)
        {
            UserId = JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;

            if (HttpContext.Session.Keys.Contains(CDictionary.SK_付款資訊))
            {
                string jsonCart = HttpContext.Session.GetString(CDictionary.SK_付款資訊);
                List<CShoppingCartItem> cart = JsonSerializer.Deserialize<List<CShoppingCartItem>>(jsonCart);
                foreach (var item in cart)
                {
                    vModel.Receiver = item.Receiver;
                    vModel.Phone = item.Phone;
                    vModel.Address = item.Address;
                    vModel.Payment = item.Payment;
                    vModel.Discount = item.Discount;
                    vModel.Fee = item.Fee;
                    vModel.MerchantTradeNo = id;
                }
            }
            ViewBag.tradeNo = id;
            #region 產生Order明細
            Order order = new Order();
            order.MemberId = UserId;
            order.OrderDate = DateTime.Now;
            order.OrderStateId = 1;
            order.PaymentId = vModel.Payment;
            order.OrderAddress = vModel.Address;
            order.OrderReceiver = vModel.Receiver;
            order.OrderPhone = vModel.Phone;
            if (vModel.Discount != 0) order.CouponId = vModel.Discount;
            order.Fee = vModel.Fee;
            order.TradeNo = vModel.MerchantTradeNo;
            db.Orders.Add(order);
            db.SaveChanges();
            #endregion

            #region 加入通知
            Notification noti = new Notification()
            {
                TradeNo = vModel.MerchantTradeNo,
                NotifyTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                MemberId = UserId,
                OrderStateId = 1
            };
            db.Notifications.Add(noti);
            db.SaveChanges();
            #endregion

            System.Threading.Thread.Sleep(1000);
            #region 產生OrderDetail 明細
            var neworder = db.Orders.OrderByDescending(p => p.OrderId).Take(1).FirstOrDefault();
            var datas = db.ShoppingCarDetails.Where(t => t.MemberId == UserId).Select(p => new CShoppingCarDetailsViewModel()
            {
                ProductsId = p.ProductsId,
                Quantity = p.Quantity,
                ProName = p.Products.ProductName,
                Price = p.Price
            });
            foreach (var item in datas)
            {
                OrderDetail detail = new OrderDetail();
                detail.OrderId = neworder.OrderId;
                detail.ProductId = (int)item.ProductsId;
                detail.Quantity = (int)item.Quantity;
                detail.Price = (int)item.Price;
                db.OrderDetails.Add(detail);
            }
            #endregion

            #region 發信給會員

            // 收件人信箱
            string userEmail = "forgotpwd87@gmail.com";
            #region 信件內容
            string mailtable = "";
            string mailreceiver = "";
            var memname = db.Members.FirstOrDefault(m => m.MemberId == UserId).MemberName;
            mailreceiver = mailreceiver += $"<ul class=\"list - group\" style=\"text - align:left; \">" +
                $"<li>會員名稱:{memname}</li>" +
                $"<li>訂單編號: {vModel.MerchantTradeNo}</li>" +
                $"<li>訂單成立日期: {DateTime.Now.ToString()}</li></ul><br />";

            mailtable += $"<table style=\"border: 2px solid black; width: 100 %; border - collapse:collapse; \" cellpadding=\"10\" border='1'>" +
                $"<thead><tr>" +
                $"<th scope=\"col\">序號</th>" +
                $"<th scope=\"col\">產品名稱</th>" +
                $"<th scope=\"col\">單價</th>" +
                $"<th scope=\"col\">數量</th>" +
                $"<th scope=\"col\">總價</th>" +
                $"</tr></thead><tbody>";


            int count = 0;
            int total = 0;
            int discountmoney = 0;
            if (vModel.Discount != 0)
            {
                discountmoney = (int)db.Coupons.FirstOrDefault(p => p.CouponId == vModel.Discount).Money;
            }

            foreach (var item in datas)
            {
                count++;
                int subtotal = (int)item.Price * (int)item.Quantity;
                total += subtotal;
                mailtable += $"<tr><th>{count}</th>" +
                                    $"<td>{item.ProName}</td>" +
                                    $"<td>NT$ {(int)item.Price}</td>" +
                                    $"<td>{item.Quantity}</td>" +
                                    $"<td>NT$ {subtotal}</td></tr>";
            }
            total = total + vModel.Fee - discountmoney;
            mailtable += $"<tr><td colspan=\"5\" align=\"left\">折扣金額 : -NT$ {discountmoney} 元</td></tr>" +
                        $"<tr><td colspan=\"5\" align=\"left\">運費 : NT$ {vModel.Fee} 元</td></tr>" +
                        $"<tr><td colspan=\"5\" align=\"left\">總金額 : NT$ {total} 元</td></tr>" +
                        $"</tbody></table>";

            string mailContent = $"<div style=\"border: 2px solid black; width: 600px; padding: 0 30px 30px 30px; \">" +
                $"<div style=\"text - align:center; color: brown; \"><br />" +
                $"<h3>***本通知信為系統自動發送，請勿直接回覆***</h3>" +
                $"</div><hr /><div style=\"text - align:center; \">" +
                $"<h4>您好，感謝您訂購 CSharpCoffee 商品，下表為您本次交易之明細。</h4>" +
                $"{mailreceiver}{mailtable}</div>" +
                $"<div style=\"text - align:center; color: gray; padding:50px; \"><br />" +
                $"<h7>※如有訂單相關問題，請洽客服處理，謝謝。</h7></div></div>";

            #endregion

            // 寄件人信箱+驗證碼
            string GoogleMailUserID = "msit141csharpcoffee@gmail.com";
            string GoogleMailUserPwd = "xryubogltaftuanp";

            // 使用Google Mail Server 發信
            string SmtpServer = "smtp.gmail.com";
            int SmtpPort = 587;
            MailMessage mms = new MailMessage();
            mms.From = new MailAddress(GoogleMailUserID);
            mms.Subject = "[CSharpCoffee]訂單已成立通知";
            mms.Body = mailContent;
            mms.IsBodyHtml = true;  //讀不讀得懂html語法
            mms.SubjectEncoding = Encoding.UTF8;    //標題編碼()
            mms.BodyEncoding = Encoding.UTF8;
            mms.To.Add(new MailAddress(userEmail)); //收件人
            using (SmtpClient client = new SmtpClient(SmtpServer, SmtpPort))
            {
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(GoogleMailUserID, GoogleMailUserPwd); // 寄信帳號
                client.Send(mms); // 寄出郵件
            }

            #endregion

            #region 所有要刪除的地方
            //刪除product庫存
            var data3 = db.ShoppingCarDetails.Where(t => t.MemberId == UserId).Select(t => new
            {
                tProductid = t.ProductsId,
                tQuantity = t.Quantity
            }).ToList();
            foreach (var item in data3)
            {
                Product prod = db.Products.FirstOrDefault(p => p.ProductId == item.tProductid);
                prod.Stock -= item.tQuantity;
            }

            //刪除coupon
            if (vModel.Discount != 0)
            {
                var delcoupon = db.CouponDetails.FirstOrDefault(m => m.MemberId == UserId && m.CouponId == vModel.Discount);
                db.CouponDetails.Remove(delcoupon);
            }


            //刪除ShoppingCarDetail明細 
            var data2 = db.ShoppingCarDetails.Where(t => t.MemberId == UserId).Select(t => t.ProductsId).ToList();
            foreach (var item in data2)
            {
                Deletedetail(item);
            }
            db.SaveChanges();

            #endregion

            HttpContext.Session.Remove(CDictionary.SK_付款資訊);
            HttpContext.Session.Remove(CDictionary.SK_使用的折價卷);

            return View();

        }

        public IActionResult Deletedetail(int? id)    //only給刪除shoppingcardetails用
        {
            UserId = JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;
            var prod = db.ShoppingCarDetails.FirstOrDefault(t => t.MemberId == UserId && t.ProductsId == id);

            db.ShoppingCarDetails.Remove(prod);
            db.SaveChanges();
            return RedirectToAction("ShoppingCar");
        }

        public IActionResult RelatedpartialView(int? id)
        {
            UserId = HomeController.loginmem.MemberId;
            Random rng = new Random(Guid.NewGuid().GetHashCode());
            List<CShoppingCarDetailsViewModel> list = new List<CShoppingCarDetailsViewModel>();
            var detailid = db.ShoppingCarDetails.OrderByDescending(p => p.ShoppingCarDetialsId).FirstOrDefault().ShoppingCarDetialsId;
            ViewBag.detailid = detailid;
            var data = db.Products.AsEnumerable().OrderByDescending(p => p.Stock).Select(p => new CShoppingCarDetailsViewModel()
            {
                ProductsId = p.ProductId,
                ProName = p.ProductName,
                Price = (int)p.Price,
                ProStock = p.Stock,
                ProPhotoPath = p.MainPhotoPath
            }).Take(20).OrderByDescending(x => rng.Next());

            var data1 = db.ShoppingCarDetails.Where(m => m.MemberId == UserId).Select(p => p.ProductsId).ToList();
            foreach (var item in data)
            {
                bool flag = true;
                foreach (var item1 in data1)
                {
                    if (item.ProductsId == item1)
                    {
                        flag = false;
                        break;
                    }

                }
                if (flag == true) list.Add(item);
                if (list.Count == 3) break;
            }

            return PartialView(list);

        }

    }
}


