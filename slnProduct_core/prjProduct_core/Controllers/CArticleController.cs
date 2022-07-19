using Microsoft.AspNetCore.Mvc;
using prjCSCoffee.Models;
using prjProduct_core.ViewModel;
using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace prjCSCoffee.Controllers
{
    public class CArticleController : Controller
    {

        private readonly CoffeeContext db;

        public CArticleController(CoffeeContext _db)
        {

            db = _db;
        }


        int pageSize = 4;
        //外域(用戶可見)
        public IActionResult faceToArticle(CKeywordViewModel vModel,int page =1)
        {
            int currentPage = page < 1 ? 1 : page;

            IEnumerable<Article> datas = null;
            if (string.IsNullOrEmpty(vModel.txtKeyword))
            {
                datas = from c in db.Articles
                        select c;
            }
            else
            {
                datas = db.Articles.Where(t => t.ArticleName.Contains(vModel.txtKeyword));
            }
            return View(datas.ToPagedList(currentPage,pageSize));
        }
        //public IActionResult faceToArticleDetail(int? id)
        //{
        //    CoffeeContext db = new CoffeeContext();
        //    Article art = db.Articles.FirstOrDefault(t => t.ArticleId == id);
        //    if (art == null)
        //        return RedirectToAction("faceToArticle");
        //    return View(art);
        //}


        public IActionResult faceToArticleDetail(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("faceToArticle");
            }
            IEnumerable<CArticleViewModel> datas = null;
            var list = db.Articles.Where(t => t.ArticleId == id).Select(a => new CArticleViewModel()
            {
                ArticleId = a.ArticleId,
                ArticleName = a.ArticleName,
                ArticleDescription = a.ArticleDescription,
                ArticleDate = a.ArticleDate,
                ArticleImage = a.ArticleImage,
                product = db.Products.FirstOrDefault()
            });
            if (list != null)
            {
                datas = list;
            }
            return View(datas);
        }

        public IActionResult Hot()
        {
            Random rng = new Random();
            var q1 = db.Products.OrderByDescending(p => p.Stock).Take(10).ToList();
            var q2 = q1.Select(p => p).OrderBy(p => rng.Next()).Take(5).ToList();
            List<Product> q3 = new List<Product>();
            foreach (Product item in q2)
            {
                q3.Add(item);
            }

            return PartialView(q3);
        }
        public IActionResult Recommend()
        {
            Random rng = new Random();
            var q1 = db.Products.AsEnumerable().Where(p => p.CategoryId == 2).Take(10).ToList();
            var q2 = q1.OrderBy(p => rng.Next()).Take(5).ToList();
            List<Product> q3 = new List<Product>();
            foreach (Product item in q2)
            {
                q3.Add(item);
            }

            return PartialView(q3);
        }

        //內域(用戶不可見-管理用)
        //public IActionResult List (CKeywordViewModel vModel)
        //{
        //    CoffeeContext db = new CoffeeContext();
        //    IEnumerable<Article> datas = null;
        //    if (string.IsNullOrEmpty(vModel.txtKeyword))
        //    {
        //        datas = from c in db.Articles
        //                select c;
        //    }
        //    else
        //    {
        //        datas = db.Articles.Where(t => t.ArticleName.Contains(vModel.txtKeyword));
        //    }
        //    return View(datas);
        //}

        //public IActionResult CreatArticle()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult CreatArticle(Article art)
        //{
        //    CoffeeContext db = new CoffeeContext();
        //    db.Articles.Add(art);
        //    db.SaveChanges();
        //    return RedirectToAction("List");
        //}
    }
}
