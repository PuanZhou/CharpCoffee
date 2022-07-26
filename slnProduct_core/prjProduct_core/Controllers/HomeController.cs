using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prjCSCoffee.Models;
using prjCSCoffee.ViewModel;
using prjProduct_core.Models;
using prjProduct_core.ViewModel;
using prjProduct_core.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Security.Cryptography;//


namespace prjProduct_core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        CoffeeContext db = null;

        public static Member loginmem = null;  //登入中的會員
        public static string MemName = "Login";

        public HomeController(ILogger<HomeController> logger , CoffeeContext _db)
        {
            _logger = logger;
            db = _db;
        }

        public IActionResult Index()
        {
            var q = db.Products.OrderByDescending(p => p.Stock).Take(4).Select(p => new CProductViewModel()
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                CategoryId = p.CategoryId,
                Category = p.Category,
                Coffee = p.Coffee,
                ClickCount = p.ClickCount,
                Country = p.Country,
                Price = p.Price,
                Description = p.Description,
                Stock = p.Stock,
                TakeDown = p.TakeDown,
                Star = p.Star,
                MainPhotoPath = p.MainPhotoPath
            });
            return View(q);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {

            return View();
        }

        public IActionResult CanLogin(string txtAccount, string txtPW) //登入資料送出
        {
            var mem = db.Members.FirstOrDefault(m => m.MemberPhone == txtAccount);
            if (mem != null)
            {
                if (mem.MemberPassword == new CMemberViewModel().PWHasH(txtPW))
                {
                    string jsonUser = JsonSerializer.Serialize(mem);  //將物件轉字串
                    HttpContext.Session.SetString(CDictionary.SK_LOGINED_USER, jsonUser); //放入到session紀錄登入資訊
                    loginmem = JsonSerializer.Deserialize<Member>(jsonUser);
                    MemName = $"{loginmem.MemberName}您好";
                    return Content("OK", "text/plain", Encoding.UTF8);
                }
            }
            return Content("NO", "text/plain", Encoding.UTF8); ;


        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove(CDictionary.SK_LOGINED_USER);
            loginmem = null;
            MemName = "Login";
            return RedirectToAction("Index"); 
        }

        public IActionResult Create()
        {
            var cartID = db.Members.Select(m => m.MemberId).Max() + 1;
            ViewBag.CARTID = cartID;
            return View();
        }
        [HttpPost]
        public IActionResult Create(CMemberViewModel newmem)
        {
            if (ModelState.IsValid)
            {
                Member mem = new Member()
                {
                    MemberName = newmem.MemberName,
                    MemberEmail = newmem.MemberEmail,
                    MemberAddress = newmem.MemberAddress,
                    MemberPhone = newmem.MemberPhone,
                    MemberPassword = newmem.PWHasH(newmem.MemberPassword),
                    MemberBirthDay = newmem.MemberBirthDay,
                    ShoppingCarId = newmem.ShoppingCarId,
                    Newspaper = newmem.Newspaper
                };

                db.Members.Add(mem);
                db.SaveChanges();

                return RedirectToAction("Login");
            }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //===============留言板PV===============
        public IActionResult _CommentBoard(int productId)
        {
            var data = db.Comments.Where(x => x.ProductId == productId)
                .OrderByDescending(x => x.CommentId)
                .Select(x => new CCommentsViewModel()
                {
                    CommentId = x.CommentId,
                    CommentParentId = x.CommentParentId,
                    CommentDescription = x.CommentDescription,
                    ProductId = x.ProductId,
                    MemberId = x.MemberId,
                    Star = x.Star,
                    OrderId = x.OrderId,
                    MemberName = x.Member.MemberName
                }).ToList();
            return PartialView(data);
        }

        //===============即時客服===============
        public IActionResult OnlineServices()
        {
            if (HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER) == null)
                return RedirectToAction("Login");
            
            return View(JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)));
        }
    }
}
