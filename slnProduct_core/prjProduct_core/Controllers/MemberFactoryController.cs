//using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
//using MimeKit;
using prjCSCoffee.Models;
using prjCSCoffee.ViewModel;
using prjProduct_core.Controllers;
using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace prjCSCoffee.Controllers
{
    public class MemberFactoryController : Controller
    {

        CoffeeContext db;

        public MemberFactoryController(CoffeeContext _db)
        {
            db = _db;
        }

        public IActionResult QueryMemEmail(string MemberEmail)
        {
            var emailExist = db.Members.Any(m => m.MemberEmail == MemberEmail);
            return Content(emailExist.ToString(), "text/plain", Encoding.UTF8);
        }

        public IActionResult QueryMemPhone(string MemberPhone)
        {
            var phoneExist = db.Members.Any(m => m.MemberPhone == MemberPhone);
            return Content(phoneExist.ToString(), "text/plain", Encoding.UTF8);
        }

        public IActionResult QueryOrder(int oYear, int oMonth, int oMonth2)
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                return Content("Login", "text/plain", Encoding.UTF8);
            }
            else
            {
                string jsonstring = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER); //拿出session登入字串
                int memID = JsonSerializer.Deserialize<Member>(jsonstring).MemberId; //字串轉物件
                var ord = db.Orders.Where(o => o.MemberId == memID &&
                o.OrderDate.Year == oYear && o.OrderDate.Month >= oMonth && o.OrderDate.Month <= oMonth2).Select(o => new
                {
                    訂單編號 = o.TradeNo,
                    訂單日期 = o.OrderDate.ToShortDateString(),
                    收件地址 = o.OrderAddress,
                    收件人 = o.OrderReceiver,
                    收件電話 = o.OrderPhone,
                    訂單狀態 = o.OrderState.OrderState1,
                    付款方式 = o.Payment.Payment1,
                });

                if (ord != null)
                {
                    return Json(ord);
                }
                else
                {
                    return Json(null);
                }
            }
        }

        public IActionResult QueryOrdDetail(string id) //此id為TradeNo
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                return Content("Login", "text/plain", Encoding.UTF8);
            }
            else
            {
                //1搜尋order的coupid 2.從coupid去cdb.oupon找名字
                string coupname = "";
                decimal couprice = 0;
                string jsonstring = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER);
                int memID = JsonSerializer.Deserialize<Member>(jsonstring).MemberId;
                var thiscouid = db.Orders.FirstOrDefault(o => o.TradeNo == id && o.MemberId == memID);
                if (thiscouid.CouponId == null)
                {
                    coupname = "無";
                    couprice = 0;
                }
                else
                {
                    var coupon = db.Coupons.FirstOrDefault(c => c.CouponId == thiscouid.CouponId);
                    coupname = coupon.CouponName;
                    couprice = coupon.Money;
                }
                var mycou = db.OrderDetails.Include(od => od.Order).ThenInclude(c => c.Coupon).Where(o => o.Order.TradeNo == id).Select(f => new
                {
                    商品名 = f.Product.ProductName,
                    商品單價 = f.Price,
                    商品數量 = f.Quantity,
                    小計 = f.Product.Price * f.Quantity,
                    使用的優惠券 = coupname,
                    優惠券金額 = couprice,
                    運費 = f.Order.Fee
                });
                return Json(mycou);
            }

        }

        public IActionResult OrdCancel(string id)
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                return Content("Login", "text/plain", Encoding.UTF8);
            }
            else
            {
                string jsonstring = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER);
                int memID = JsonSerializer.Deserialize<Member>(jsonstring).MemberId;
                var state = db.Orders.FirstOrDefault(o => o.TradeNo == id && o.MemberId == memID);
                if (state != null)
                {
                    state.OrderStateId = 5; //變成審核中
                    db.SaveChanges();
                    return Content("check", "text/plain", Encoding.UTF8);
                }
                return Content("Non", "text/plain", Encoding.UTF8);
            }
        }


        public IActionResult AddtoMyLike(int id)
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                string jsonstring = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER); //拿出session登入字串
                int memID = JsonSerializer.Deserialize<Member>(jsonstring).MemberId; //字串轉物件
                var haslike = db.MyLikes.Any(m => m.MemberId == memID && m.ProductId == id); //判斷是否已存在
                if (haslike)
                {
                    return Content("had", "text/plain", Encoding.UTF8);
                }
                else
                {
                    MyLike mk = new MyLike()
                    {
                        MemberId = memID,
                        ProductId = id
                    };
                    db.MyLikes.Add(mk);
                    db.SaveChanges();
                    return Content("join", "text/plain", Encoding.UTF8);
                }

            }

        }

        public IActionResult DeleteMylike(int id)
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                string jsonstring = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER); //拿出session登入字串
                int memID = JsonSerializer.Deserialize<Member>(jsonstring).MemberId; //字串轉物件
                var mk = db.MyLikes.FirstOrDefault(m => m.MemberId == memID && m.ProductId == id);
                db.MyLikes.Remove(mk);
                db.SaveChanges();
                return Content("已取消收藏", "text/plain", Encoding.UTF8);
            }
        }

        public IActionResult CheckNowPW(string txtPW)
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                string jsonstring = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER); //拿出session登入字串
                int memID = JsonSerializer.Deserialize<Member>(jsonstring).MemberId; //字串轉物件
                string afterhash = new CMemberViewModel().PWHasH(txtPW);
                string dbPW = db.Members.FirstOrDefault(m => m.MemberId == memID).MemberPassword;
                if (afterhash == dbPW)
                {
                    return Content("True", "text/plain", Encoding.UTF8);
                }
                return Content("False", "text/plain", Encoding.UTF8);
            }

        }

        public IActionResult ChangeNewPW(string txtNewPW)
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                if (txtNewPW != null)
                {
                    string jsonstring = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER);
                    int memID = JsonSerializer.Deserialize<Member>(jsonstring).MemberId;
                    var mem = db.Members.FirstOrDefault(m => m.MemberId == memID);
                    string newPW = new CMemberViewModel().PWHasH(txtNewPW);
                    mem.MemberPassword = newPW;
                    db.SaveChanges();
                    return Content("OK", "text/plain", Encoding.UTF8);
                }
                return Content("NO", "text/plain", Encoding.UTF8);
            }

        }



        public IActionResult SendMail(string MemberEmail) //忘記密碼
        {
            var mem = db.Members.FirstOrDefault(m => m.MemberEmail == MemberEmail);
            if (mem != null)
            {
                string newPW = Guid.NewGuid().ToString().Substring(0, 8);
                mem.MemberPassword = new CMemberViewModel().PWHasH(newPW);
                db.Members.Update(mem);
                db.SaveChanges();

                //emailsend
                try
                {
                    MailMessage mmsg = new MailMessage();
                    string emailfrom = "msit141csharpcoffee@gmail.com";
                    string emailPW = "xryubogltaftuanp";
                    mmsg.From = new MailAddress(emailfrom);
                    mmsg.To.Add(new MailAddress("forgotpwd87@gmail.com"));
                    mmsg.To.Add(new MailAddress("chiakiultra@gmail.com"));
                    mmsg.Subject = "[C#Coffee]忘記密碼通知信";
                    mmsg.Body = $"尊敬的會員您好：\n\n您新的密碼為{newPW}。請以新密碼登入並修改您的舊密碼。\n如果未有忘記密碼的需求，請忽略此信件。\n" +
                        $"請注意，由於部分信箱可能有收不到站方通知信件的情況，所以也請您不吝多留意「垃圾郵件夾」。\n" +
                        $"※此封郵件為系統自動發送，請勿直接回覆此郵件。 \nRegards,\nCSPCoffee Customer Service";
                    mmsg.IsBodyHtml = false;
                    mmsg.BodyEncoding = Encoding.UTF8;
                    mmsg.SubjectEncoding = Encoding.UTF8;
                    using (SmtpClient clinet = new SmtpClient("smtp.gmail.com", 587))
                    {
                        clinet.EnableSsl = true;
                        clinet.Credentials = new NetworkCredential(emailfrom, emailPW);
                        clinet.Send(mmsg);
                    }
                    return Content("sended", "text/plain", Encoding.UTF8);
                }
                catch (Exception ex)
                {
                    return Content("err", "text/plain", Encoding.UTF8);
                }

            }
            else //找不到會員
            {
                return Content("none", "text/plain", Encoding.UTF8);

            }

        }


        public IActionResult AddNotice(string TradNo, int OrderStateId)
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                return Content("Login", "text/plain", Encoding.UTF8);
            }
            try
            {
                string jsonstring = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER);
                int memID = JsonSerializer.Deserialize<Member>(jsonstring).MemberId;
                Notification noti = new Notification()
                {
                    NotifyTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                    TradeNo = TradNo,
                    MemberId = memID,
                    OrderStateId = OrderStateId
                };
                db.Notifications.Add(noti);
                db.SaveChanges();
                return Content("OK", "text/plain", Encoding.UTF8);
            }
            catch
            {
                return Content("fall", "text/plain", Encoding.UTF8);
            }

        }

        public IActionResult DeletNotice(int id)
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                string jsonstring = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER);
                int memID = JsonSerializer.Deserialize<Member>(jsonstring).MemberId;
                var noti = db.Notifications.FirstOrDefault(n => n.MemberId == memID && n.NotificationId == id);
                db.Notifications.Remove(noti);
                db.SaveChanges();
                return Content("OK", "text/plain", Encoding.UTF8);
            }

        }

        public IActionResult ReadOneNoti(int? id)
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                string jsonstring = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER);
                int memID = JsonSerializer.Deserialize<Member>(jsonstring).MemberId;
                if (id == null)//全部標已讀
                {
                    var noti = db.Notifications.Where(n => n.MemberId == memID).ToList();
                    foreach (var item in noti)
                    {
                        item.HasRead = true;
                    }
                }
                else //單個已讀
                {
                    var noti = db.Notifications.FirstOrDefault(n => n.MemberId == memID && n.NotificationId == id);
                    noti.HasRead = true;
                    db.SaveChanges();
                    //有無全部已讀
                    var noti2 = db.Notifications.Where(n => n.MemberId == memID && n.HasRead == false).ToList();//算未讀的數量
                    if (noti2.Count == 0)
                    {
                        return Content("AllRead", "text/plain", Encoding.UTF8);
                    }
                }
                db.SaveChanges();
                return Content("OK", "text/plain", Encoding.UTF8);
            }
        }

        public IActionResult GetCoupon(int id)
        {
            if (!HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
            {
                return Content("Login", "text/plain", Encoding.UTF8);
            }
            else
            {
                string jsonstring = HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER);
                int memID = JsonSerializer.Deserialize<Member>(jsonstring).MemberId;
                //檢查該會員有過該Coupon
                var cou = db.HeldCoupons.Any(c => c.MemberId == memID && c.CouponId == id);
                if (!cou)//如果沒有過
                {
                    CouponDetail cd = new CouponDetail()
                    {
                        MemberId = memID,
                        CouponId = id
                    };
                    db.CouponDetails.Add(cd);
                    HeldCoupon hc = new HeldCoupon()
                    {
                        MemberId = memID,
                        CouponId = id
                    };
                    db.HeldCoupons.Add(hc);
                    db.SaveChanges();
                    return Content("OK", "text/plain", Encoding.UTF8);
                }
                return Content("Had", "text/plain", Encoding.UTF8);
            }

        }

    }
}
