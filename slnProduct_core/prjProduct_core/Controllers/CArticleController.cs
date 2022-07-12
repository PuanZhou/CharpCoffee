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

        int pageSize = 4;
        //外域(用戶可見)
        public IActionResult faceToArticle(CKeywordViewModel vModel,int page =1)
        {
            int currentPage = page < 1 ? 1 : page;
            CoffeeContext db = new CoffeeContext();
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
            CoffeeContext db = new CoffeeContext();
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
