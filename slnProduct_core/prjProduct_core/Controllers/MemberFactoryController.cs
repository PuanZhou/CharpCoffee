//using MailKit.Net.Smtp;
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

            var ord = db.Orders.Where(o => o.MemberId == HomeController.loginmem.MemberId &&
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

        public IActionResult QueryOrdDetail(string id) //此id為TradeNo
        {
            //1搜尋order的coupid 2.從coupid去cdb.oupon找名字
            string coupname = "";
            decimal couprice = 0;
            var thiscouid = db.Orders.FirstOrDefault(o => o.TradeNo == id && o.MemberId == HomeController.loginmem.MemberId);
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
            int fee = thiscouid.CouponId == null ? 0 : 100;
            var mycou = db.OrderDetails.Include(od => od.Order).ThenInclude(c => c.Coupon).Where(o => o.Order.TradeNo == id).Select(f => new
            {
                商品名 = f.Product.ProductName,
                商品單價 = f.Price,
                商品數量 = f.Quantity,
                小計 = f.Product.Price * f.Quantity,
                使用的優惠券 = coupname,
                優惠券金額 = couprice,
                運費 = fee
            });
            return Json(mycou);
        }


        public IActionResult OrdCancel(string id)
        {
            var state = db.Orders.FirstOrDefault(o => o.TradeNo == id && o.MemberId == HomeController.loginmem.MemberId);
            if (state != null)
            {
                state.OrderStateId = 5; //變成審核中
                db.SaveChanges();
            }
            return Content("check", "text/plain", Encoding.UTF8);
        }


        public IActionResult AddtoMyLike(int id)
        {
            if (HomeController.loginmem == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                var haslike = db.MyLikes.Any(m => m.MemberId == HomeController.loginmem.MemberId && m.ProductId == id); //判斷是否已存在
                if (haslike)
                {
                    return Content("had", "text/plain", Encoding.UTF8);
                }
                else
                {
                    MyLike mk = new MyLike()
                    {
                        MemberId = HomeController.loginmem.MemberId,
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
            if (HomeController.loginmem == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                var mk = db.MyLikes.FirstOrDefault(m => m.MemberId == HomeController.loginmem.MemberId && m.ProductId == id);
                db.MyLikes.Remove(mk);
                db.SaveChanges();
                return Content("已取消收藏", "text/plain", Encoding.UTF8);
            }
        }

        public IActionResult CheckNowPW(string txtPW)
        {
            if (HomeController.loginmem == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                string afterhash = new CMemberViewModel().PWHasH(txtPW);
                string dbPW = db.Members.FirstOrDefault(m => m.MemberId == HomeController.loginmem.MemberId).MemberPassword;
                if (afterhash == dbPW)
                {
                    return Content("True", "text/plain", Encoding.UTF8);
                }
                return Content("False", "text/plain", Encoding.UTF8);
            }

        }

        public IActionResult ChangeNewPW(string txtNewPW)
        {
            if (HomeController.loginmem == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                var mem = db.Members.FirstOrDefault(m => m.MemberId == HomeController.loginmem.MemberId);
                string newPW = new CMemberViewModel().PWHasH(txtNewPW);
                mem.MemberPassword = newPW;
                db.SaveChanges();
                return Content("OK", "text/plain", Encoding.UTF8);
            }

        }



        public IActionResult SendMail(string MemberEmail)
        {//找不到會員
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
            else
            {
                return Content("none", "text/plain", Encoding.UTF8);

            }

        }


        public IActionResult AddNotice(string TradNo, int OrderStateId)
        {
            try
            {
                Notification noti = new Notification()
                {
                    NotifyTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                    TradeNo = TradNo,
                    MemberId = HomeController.loginmem.MemberId,
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
            if (HomeController.loginmem == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                var noti = db.Notifications.FirstOrDefault(n => n.MemberId == HomeController.loginmem.MemberId && n.NotificationId == id);
                db.Notifications.Remove(noti);
                db.SaveChanges();
                return Content("OK", "text/plain", Encoding.UTF8);
            }

        }

        public IActionResult ReadOneNoti(int? id)
        {
            if (HomeController.loginmem == null)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                if (id == null)//全部標已讀
                {
                    var noti = db.Notifications.Where(n => n.MemberId == HomeController.loginmem.MemberId).ToList();
                    foreach (var item in noti)
                    {
                        item.HasRead = true;
                    }
                }
                else //單個已讀
                {
                    var noti = db.Notifications.FirstOrDefault(n => n.MemberId == HomeController.loginmem.MemberId && n.NotificationId == id);
                    noti.HasRead = true;
                    db.SaveChanges();
                    //有無全部已讀
                    var noti2 = db.Notifications.Where(n => n.MemberId == HomeController.loginmem.MemberId && n.HasRead == false).ToList();//算未讀的數量
                    if (noti2.Count == 0)
                    {
                        return Content("AllRead", "text/plain", Encoding.UTF8);
                    }
                }
                db.SaveChanges();
                return Content("OK", "text/plain", Encoding.UTF8);
            }
        }

    }
}
