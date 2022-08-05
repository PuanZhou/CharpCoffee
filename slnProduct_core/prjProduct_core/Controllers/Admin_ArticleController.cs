using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prjCSCoffee.Models;
using prjProduct_core.Models;
using prjProduct_core.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace prjProduct_core.Controllers
{
    public class Admin_ArticleController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly CoffeeContext _context;
        private static Admin signIn_User;

        public Admin_ArticleController(CoffeeContext context, IWebHostEnvironment host)
        {
            _environment = host;
            _context = context;
        }
        //List
        public IActionResult List(CAdmin_KeywordViewModel vModel)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                string JsonUser = HttpContext.Session.GetString(CDictionary.SK_LOGINED_ADMIN);
                signIn_User = JsonSerializer.Deserialize<Admin>(JsonUser);
                if (signIn_User.ArticleOk)
                {
                    IEnumerable<CAdmin_ArticleViewModel> datas = null;
                    var list = _context.Articles.Select(a => new CAdmin_ArticleViewModel()
                    {
                        ArticleId = a.ArticleId,
                        ArticleName = a.ArticleName,
                        ArticleDescription = a.ArticleDescription,
                        ArticleDate = a.ArticleDate,
                        ArticleImage = a.ArticleImage
                    }).OrderByDescending(b => b.ArticleDate);

                    if (string.IsNullOrEmpty(vModel.txtKeyword))
                    {
                        datas = list;
                    }
                    else
                    {
                        datas = list.Where(a => a.ArticleName.Contains(vModel.txtKeyword));
                        if (datas.Count() == 0)
                        {
                            datas = list;
                        }
                    }
                    return View(datas);
                }

                return RedirectToAction("Error403", "Admin_Dashboard");
            }

            Admin_DashboardController.btnSignInText = "登入";
            return RedirectToAction("Error403", "Admin_Dashboard");
        }
        //Creat
        public IActionResult CreatArticle()
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                string JsonUser = HttpContext.Session.GetString(CDictionary.SK_LOGINED_ADMIN);
                signIn_User = JsonSerializer.Deserialize<Admin>(JsonUser);
                if (signIn_User.ArticleOk)
                {
                    return View();
                }

                return RedirectToAction("Error403", "Admin_Dashboard");
            }

            Admin_DashboardController.btnSignInText = "登入";
            return RedirectToAction("Error403", "Admin_Dashboard");
        }
        [HttpPost]
        public IActionResult CreatArticle(CAdmin_ArticleViewModel a)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                string JsonUser = HttpContext.Session.GetString(CDictionary.SK_LOGINED_ADMIN);
                signIn_User = JsonSerializer.Deserialize<Admin>(JsonUser);
                if (signIn_User.ArticleOk)
                {
                    Article art = new Article();
                    art.ArticleName = a.ArticleName;
                    art.ArticleDescription = a.ArticleDescription;
                    art.ArticleDate = a.ArticleDate;
                    if (a.photo != null)
                    {
                        string aName = Guid.NewGuid().ToString() + ".jpg";
                        a.photo.CopyTo(new FileStream(_environment.WebRootPath + "/articleImages/" + aName, FileMode.Create));
                        art.ArticleImage = aName;
                    }

                    _context.Articles.Add(art);
                    _context.SaveChanges();
                    return RedirectToAction("List");
                }

                return RedirectToAction("Error403", "Admin_Dashboard");
            }

            Admin_DashboardController.btnSignInText = "登入";
            return RedirectToAction("Error403", "Admin_Dashboard");
        }
        //Delete
        public IActionResult DeleteArticle(int? id)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                string JsonUser = HttpContext.Session.GetString(CDictionary.SK_LOGINED_ADMIN);
                signIn_User = JsonSerializer.Deserialize<Admin>(JsonUser);
                if (signIn_User.ArticleOk)
                {
                    Article art = _context.Articles.FirstOrDefault(a => a.ArticleId == id);
                    IEnumerable<ArticleComment> ac = _context.ArticleComments.Where(ac => ac.ArticleId == id).ToList();
                    foreach (var item in ac)
                    {
                        _context.ArticleComments.Remove(item);
                    }

                    if (art != null)
                    {
                        _context.Articles.Remove(art);
                        _context.SaveChanges();
                    }
                    return RedirectToAction("List");
                }

                return RedirectToAction("Error403", "Admin_Dashboard");
            }

            Admin_DashboardController.btnSignInText = "登入";
            return RedirectToAction("Error403", "Admin_Dashboard");
        }
        //Edit
        public IActionResult EditArticle(int? id)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                string JsonUser = HttpContext.Session.GetString(CDictionary.SK_LOGINED_ADMIN);
                signIn_User = JsonSerializer.Deserialize<Admin>(JsonUser);
                if (signIn_User.ArticleOk)
                {
                    CoffeeContext db = new CoffeeContext();
                    Article art = _context.Articles.FirstOrDefault(a => a.ArticleId == id);
                    if (art == null)
                    {
                        return RedirectToAction("List");
                    }
                    return View(art);
                }

                return RedirectToAction("Error403", "Admin_Dashboard");
            }

            Admin_DashboardController.btnSignInText = "登入";
            return RedirectToAction("Error403", "Admin_Dashboard");
        }
        [HttpPost]
        public IActionResult EditArticle(CAdmin_ArticleViewModel a)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                string JsonUser = HttpContext.Session.GetString(CDictionary.SK_LOGINED_ADMIN);
                signIn_User = JsonSerializer.Deserialize<Admin>(JsonUser);
                if (signIn_User.ArticleOk)
                {
                    Article art = _context.Articles.FirstOrDefault(article => article.ArticleId == a.ArticleId);
                    if (art != null)
                    {
                        if (a.photo != null)
                        {
                            string aName = Guid.NewGuid().ToString() + ".jpg";
                            a.photo.CopyTo(new FileStream(_environment.WebRootPath + "/articleImages/" + aName, FileMode.Create));
                            art.ArticleImage = aName;
                        }
                        art.ArticleName = a.ArticleName;
                        art.ArticleDescription = a.ArticleDescription;
                        art.ArticleDate = a.ArticleDate;
                    }
                    _context.SaveChanges();
                    return RedirectToAction("List");
                }

                return RedirectToAction("Error403", "Admin_Dashboard");
            }

            Admin_DashboardController.btnSignInText = "登入";
            return RedirectToAction("Error403", "Admin_Dashboard");
        }
    }
}
