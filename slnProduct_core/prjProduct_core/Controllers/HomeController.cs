using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using prjCSCoffee.Models;
using prjCSCoffee.ViewModel;
using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(CLoginViewModel login) //登入資料送出
        {
            var mem = db.Members.FirstOrDefault(m => m.MemberPhone == login.txtAccount);
            if (mem != null)
            {
                if (mem.MemberPassword.Equals(login.txtPW))
                {

                    //授權部分 暫時用session代替 之後再用[Authorize]
                    string jsonUser = JsonSerializer.Serialize(mem);  //將物件轉字串
                    HttpContext.Session.SetString(CDictionary.SK_LOGINED_USER, jsonUser); //放入到session紀錄登入資訊
                    loginmem = JsonSerializer.Deserialize<Member>(jsonUser);
                    MemName = $"{loginmem.MemberName}您好";
                    return RedirectToAction("Index");
                }

            }

            return View();

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove(CDictionary.SK_LOGINED_USER);
            loginmem = null;
            MemName = "Login";
            return RedirectToAction("Index");  //ajax登出
        }

        public IActionResult Create()
        {
            var cartID = db.Members.Select(m => m.MemberId).Max() + 1;
            ViewBag.CARTID = cartID;
            byte[] defaultimg = db.Members.First().MemberPhoto;
            ViewBag.DEFAULTIMG = defaultimg;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Member newmem)
        {
            db.Members.Add(newmem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
