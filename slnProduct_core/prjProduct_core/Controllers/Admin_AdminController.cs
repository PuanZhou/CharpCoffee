using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prjCSCoffee.Models;
using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace prjProduct_core.Controllers
{
    public class Admin_AdminController : Controller
    {
        private static Admin signIn_User;
        private readonly CoffeeContext db;

        public Admin_AdminController(CoffeeContext context)
        {
            db = context;
        }
        public IActionResult List()
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                string JsonUser = HttpContext.Session.GetString(CDictionary.SK_LOGINED_ADMIN);
                signIn_User = JsonSerializer.Deserialize<Admin>(JsonUser);
                if (signIn_User.AdminOk)
                {
                    var q = db.Admins;
                    return View(q);
                }

                return RedirectToAction("Index", "Admin_Dashboard");
            }

            Admin_DashboardController.btnSignInText = "登入";
            return RedirectToAction("Index", "Admin_Dashboard");
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Admin a)
        {
            db.Admins.Add(a);
            db.SaveChanges();

            return RedirectToAction("List");
        }
        public IActionResult Edit(int id)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                string JsonUser = HttpContext.Session.GetString(CDictionary.SK_LOGINED_ADMIN);
                signIn_User = JsonSerializer.Deserialize<Admin>(JsonUser);
                if (signIn_User.AdminOk)
                {
                    var q = db.Admins.FirstOrDefault(a => a.AdminId == id);
                    return View(q);
                }

                return RedirectToAction("Index", "Admin_Dashboard");
            }

            Admin_DashboardController.btnSignInText = "登入";
            return RedirectToAction("Index", "Admin_Dashboard");
        }

        [HttpPost]
        public IActionResult Edit(Admin a)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                string JsonUser = HttpContext.Session.GetString(CDictionary.SK_LOGINED_ADMIN);
                signIn_User = JsonSerializer.Deserialize<Admin>(JsonUser);
                if (signIn_User.AdminOk)
                {
                    var q = db.Admins.FirstOrDefault(p => p.AdminId == a.AdminId);
                    if (q == null)
                    {
                        return RedirectToAction("List");
                    }
                    else
                    {
                        q.Email = a.Email;
                        q.Password = a.Password;
                        q.ProductOk = a.ProductOk;
                        q.MemberOk = a.MemberOk;
                        q.ArticleOk = a.ArticleOk;
                        q.AdminOk = a.AdminOk;
                    }
                    db.SaveChanges();
                    return RedirectToAction("List");
                }

                return RedirectToAction("Index", "Admin_Dashboard");
            }

            Admin_DashboardController.btnSignInText = "登入";
            return RedirectToAction("Index", "Admin_Dashboard");
        }

    }
}
