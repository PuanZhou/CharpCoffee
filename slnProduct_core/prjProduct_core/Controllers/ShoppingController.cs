using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prjCSCoffee.Models;
using prjCSCoffee.ViewModel;
using prjProduct_core.Controllers;
using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace prjCSCoffee.Controllers
{
    public class ShoppingController : Controller
    {
        private readonly CoffeeContext db;
        public ShoppingController(CoffeeContext conetxt)
        {
            db = conetxt;
        }
        int UserId = 0;   

        //public IActionResult List()
        //{           
        //    //HomeController.loginmem
        //    var datas = db.Products.OrderBy(f => f.ProductId).ToList();
        //    List<CProductViewModel_09> list = new List<CProductViewModel_09>();
        //    foreach(Product item in datas)
        //    {
        //        CProductViewModel_09 p = new CProductViewModel_09();
        //        p.product = item;
        //        list.Add(p);
        //    }
        //    return View(list);
        //}

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
                      ProPrice = t.Price,
                      product = t.Products,
                      ProStock = t.Products.Stock
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
                       fcoupon = c.Coupon
                   }).ToList();

                List<CShoppingCartItem> list = new List<CShoppingCartItem>();
                foreach (var item in datas)
                {
                    CShoppingCartItem t = new CShoppingCartItem();
                    t.productId = (int)item.ProductsId;
                    t.count = (int)item.Quantity;
                    t.price = (decimal)item.ProPrice;
                    t.product = item.product;
                    t.stock = (int)item.ProStock;

                    List<Coupon> cc = new List<Coupon>();
                    foreach (var item1 in data2)
                    {
                        Coupon t2 = new Coupon();
                        t2.CouponId = (int)item1.Fcouponid;
                        t2.CouponName = item1.Fcouponname;
                        t2.Money = item1.Fcouponmoney;
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
              
        public IActionResult ShoppingCarEmpty()
        {   //如果購物車為空的話，跳這邊
            return View();
        }

        public IActionResult UseCoupon(int? id)
        {
            HttpContext.Session.Clear();
            string jsonCart = "";
            List<int> list = null;
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_使用的折價卷))
                list = new List<int>();
            else
            {
                jsonCart = HttpContext.Session.GetString(CDictionary.SK_使用的折價卷);
                list = JsonSerializer.Deserialize<List<int>>(jsonCart);
            }            
            list.Add((int)id);

            jsonCart = JsonSerializer.Serialize(list);
            HttpContext.Session.SetString(
                CDictionary.SK_使用的折價卷, jsonCart);
            return View();
        }

        public IActionResult AddtoCart(int? id)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                UserId = JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;
                //表示該產品是購物車狀態
                var currentCar = db.ShoppingCarDetails
                    .Where(m => m.ProductsId == id && m.MemberId == UserId)
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
                    carDetail.Quantity = 1;
                    db.ShoppingCarDetails.Add(carDetail);
                }
                else
                {
                    //若產品為購物車狀態，即將該產品數量加1
                    currentCar.Quantity += 1;
                }
                db.SaveChanges();
                return RedirectToAction("view", "shop");
            }
            else
            {

                return RedirectToAction("Login", "Home");
            }
           
        }
        public IActionResult Delete(int? id)
        {
            UserId = JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;
            var prod = db.ShoppingCarDetails.FirstOrDefault(t => t.MemberId == UserId && t.ProductsId == id);
            
                db.ShoppingCarDetails.Remove(prod);
                db.SaveChanges();        
           
            return RedirectToAction("ShoppingCar");
        }
        public IActionResult Plus(int? id)
        {
            UserId = JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;
            ShoppingCarDetail prod = db.ShoppingCarDetails.FirstOrDefault(t => t.MemberId==UserId && t.ProductsId == id);

            if (prod != null)
            {
                prod.Quantity += 1;
            }
            db.SaveChanges();
            return RedirectToAction("ShoppingCar");
        }
        public IActionResult Reduce(int? id)
        {
            UserId = JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;
            ShoppingCarDetail prod = db.ShoppingCarDetails.FirstOrDefault(t => t.MemberId == UserId && t.ProductsId == id);

            if (prod != null)
            {
                prod.Quantity -= 1;
            }
            db.SaveChanges();
            return RedirectToAction("ShoppingCar");
        }

        public IActionResult Car2()
        {            
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_使用的折價卷))
            {
                int pay = 0 ;
                string jsonCart = HttpContext.Session.GetString(CDictionary.SK_使用的折價卷);
                var list1 = JsonSerializer.Deserialize<List<int>>(jsonCart);                          
                foreach (var item1 in list1)
                {
                    pay = item1;
                }
                ViewData["discount"] = pay;               
            }           
            return View();
        }      

        [HttpPost]
        public IActionResult Car2(CDeliveryViewModel vModel)
        {
            //HttpContext.Session.Clear();
            string jsonCart = "";
            List<CShoppingCartItem> list = null;
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_付款資訊))
                list = new List<CShoppingCartItem>();
            else
            {
                jsonCart = HttpContext.Session.GetString(CDictionary.SK_付款資訊);
                list = JsonSerializer.Deserialize<List<CShoppingCartItem>>(jsonCart);
            }
            CShoppingCartItem item = new CShoppingCartItem()
            {
                Receiver = vModel.fReceiver,
                phone=vModel.fPhone,
                Address = vModel.fAddress,
                payment = vModel.payment,
                discount=vModel.fdiscount              
            };
            list.Add(item);
            jsonCart = JsonSerializer.Serialize(list);
            HttpContext.Session.SetString(
                CDictionary.SK_付款資訊, jsonCart);
            return RedirectToAction("Car3");
        }


        public IActionResult Car3()
        {
            //金流的
            string tradeNo = Guid.NewGuid().ToString();
            tradeNo = tradeNo.Substring(tradeNo.Length - 12, 12);
            ViewBag.tradeNo = tradeNo;
            string timenow = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            ViewBag.timenow = timenow;

            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                UserId = JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;
            }
            var datas = db.ShoppingCarDetails.Where(t => t.MemberId == UserId)
                   .Select(t => new {
                       Fid = t.ProductsId,
                       FName=t.Products.ProductName,
                       Fcount = t.Quantity,
                       Fprice = t.Price,
                       Fproduct = t.Products
                   });
            int total = 0;
            string ItemName = "";
            foreach (var item in datas)
            {
                int price = (int)item.Fprice;
                total += ((int)(item.Fcount) * price);
                ItemName += $"{item.FName} {Convert.ToInt32(item.Fprice).ToString("0")}元X{item.Fcount}#";
            }
 
            ItemName = ItemName.Substring(0,ItemName.Length-1);
            ViewBag.Total = total;
            ViewBag.ItemName = ItemName;

            string checkMacValue = $"HashKey=5294y06JbISpM5x9&ChoosePayment=Credit&ClientBackURL=https://developers.opay.tw/AioMock/MerchantClientBackUrl&CreditInstallment=&EncryptType=1&InstallmentAmount=&ItemName={ItemName}&MerchantID=2000132&MerchantTradeDate={timenow}&MerchantTradeNo={tradeNo}&PaymentType=aio&Redeem=&ReturnURL=https://developers.opay.tw/AioMock/MerchantReturnUrl&StoreID=&TotalAmount={total}&TradeDesc=建立信用卡測試訂單&HashIV=v77hoKGq4kWxNNIS";
            checkMacValue = System.Web.HttpUtility.UrlEncode(checkMacValue, System.Text.Encoding.UTF8).ToLower();
            using var hash = SHA256.Create();
            var byteArray = hash.ComputeHash(Encoding.UTF8.GetBytes(checkMacValue));
            checkMacValue = Convert.ToHexString(byteArray).ToUpper();
            ViewBag.checkMacValue = checkMacValue;

            List<CShoppingCartItem> list = new List<CShoppingCartItem>();
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_付款資訊))
            {
                string jsonCart = HttpContext.Session.GetString(CDictionary.SK_付款資訊);
                var list1 = JsonSerializer.Deserialize<List<CShoppingCartItem>>(jsonCart);
                var list2 = db.Payments.Where(t => t.PaymentId == list1[0].payment).Select(p => p.Payment1).ToArray();               
               
                foreach (var item in datas)
                {
                    CShoppingCartItem t = new CShoppingCartItem();
                    t.productId = (int)item.Fid;
                    t.count = (int)item.Fcount;
                    t.price = (decimal)item.Fprice;
                    t.product = item.Fproduct;
                    foreach (var item1 in list1)
                    {
                        t.Receiver = item1.Receiver;
                        t.phone = item1.phone;
                        t.payment = item1.payment;                        
                        t.Address = item1.Address;
                        t.discount = item1.discount;
                        foreach (var item2 in list2)
                        {
                            t.paymentname = item2;                            
                        }                        
                    }
                    list.Add(t);
                }        
                return View(list);
            }
            else
                return RedirectToAction("view", "shop");
        } 
        [HttpPost]
        public IActionResult Car3(CShoppingCartItem vModel)
        {
            //加訂單流水號
            //訂單時間、交易金額、產品名稱

            

            UserId = JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_付款資訊))
            {
                string jsonCart = HttpContext.Session.GetString(CDictionary.SK_付款資訊);
                List<CShoppingCartItem> cart = JsonSerializer.Deserialize<List<CShoppingCartItem>>(jsonCart);
                foreach (var item in cart)
                {
                    vModel.Receiver = item.Receiver;
                    vModel.phone = item.phone;
                    vModel.Address = item.Address;
                    vModel.payment = item.payment;
                    vModel.discount = item.discount;
                }
            }
            //產生Order明細
            Order order = new Order();
            order.MemberId = UserId;
            order.OrderDate = DateTime.Now;
            order.OrderStateId = 1;
            order.PaymentId = vModel.payment;
            order.OrderAddress = vModel.Address;
            order.OrderReceiver = vModel.Receiver;
            order.OrderPhone = vModel.phone;
            order.CouponId = vModel.discount;      //TODO 5 折價卷還沒確定，記得用完要刪掉折價眷
            db.Orders.Add(order);
            db.SaveChanges();

            System.Threading.Thread.Sleep(1000);
            //產生OrderDetail 明細
            var neworder = db.Orders.OrderByDescending(p => p.OrderId).Take(1).FirstOrDefault();
            var datas = db.ShoppingCarDetails.Where(t => t.MemberId == UserId);
            foreach (var item in datas)
            {
                OrderDetail detail = new OrderDetail();
                detail.OrderId = neworder.OrderId;
                detail.ProductId = (int)item.ProductsId;
                detail.Quantity = (int)item.Quantity;
                db.OrderDetails.Add(detail);
            }
            db.SaveChanges();

            //刪除ShoppingCarDetail明細
            var data2 = db.ShoppingCarDetails.Where(t => t.MemberId == UserId).Select(t=>t.ProductsId).ToList();
            foreach (var item in data2)
            {
                Delete(item);               
            }
            return RedirectToAction("view", "shop");
        }


        //public IActionResult Maps()
        //{
        //    var datas = db.ShoppingCarDetails.Where(t => t.MemberId == UserId)
        //           .Select(t => new {
        //               Fid = t.ProductsId,
        //               Fcount = t.Quantity,
        //               Fprice = t.Price,
        //               Fproduct = t.Products
        //           });          

        //    List<CShoppingCartItem> list = new List<CShoppingCartItem>();
        //    foreach (var item in datas)
        //    {
        //        CShoppingCartItem t = new CShoppingCartItem();
        //        t.productId = (int)item.Fid;
        //        t.count = (int)item.Fcount;
        //        t.price = (decimal)item.Fprice;
        //        t.product = item.Fproduct;
        //        list.Add(t);
        //    }
        //    return View(list);
        //}
    }
}


//TODO 2 最上方小圖顯示購物車總數量
//TODO 3 運費還沒算

//TODO 5 買家取貨地圖
//TODO 6 刪除已購入的庫存、折價眷


