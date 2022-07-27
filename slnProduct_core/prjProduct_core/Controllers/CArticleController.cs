using Microsoft.AspNetCore.Mvc;
using prjCSCoffee.Models;
using prjProduct_core.ViewModel;
using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using prjProduct_core.Controllers;

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
        public IActionResult New()
        {
            var q1 = db.Articles.OrderByDescending(p => p.ArticleDate).Take(5).ToList();
            List<Article> q2 = new List<Article>();
            foreach (Article item in q1)
            {
                q2.Add(item);
            }

            return PartialView(q2);
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

        public IActionResult faceToArticleComment(int articleId)
        {
            var data = db.ArticleComments.Where(a => a.ArticleId == articleId).OrderByDescending(ac => ac.ArticleCommentId).Select(nac => new CArticleCommentViewModel()
            {
                ArticleCommentId = nac.ArticleCommentId,
                MemberId = nac.MemberId,
                ArticleId = nac.ArticleId,
                ArticleCommentParentId = nac.ArticleCommentParentId,
                ArticleCommentDescription = nac.ArticleCommentDescription,
                ArticleCommentStar = nac.ArticleCommentStar,
                MemberName = nac.Member.MemberName
            }).ToList();

            return PartialView(data);
        }

        //新增回覆
        public IActionResult AddArticleComment(ArticleComment ac)
        {
            if (HomeController.loginmem == null)
            {
                return Content("login", "text/plain", System.Text.Encoding.UTF8);
            }
            db.ArticleComments.Add(ac);
            db.SaveChanges();
            return Content("謝謝您的評論。", "text/plain", System.Text.Encoding.UTF8);
        }

        public IActionResult CheckArticleCommentMemberId()
        {
            if (HomeController.loginmem != null)
            {
                return Content($"{HomeController.loginmem.MemberId}", "text/plain", System.Text.Encoding.UTF8);
            }
            return Content("NoMember", "text/plain", System.Text.Encoding.UTF8);
        }

        //計算回覆量
        public IActionResult ArticleCommentsCount(int articleId)
        {
            var acs = db.ArticleComments.Where(x => x.ArticleId == articleId);
            int acCount = acs.Where(a => a.ArticleCommentParentId == 0).Count();
            int acChridrenCount = acs.Where(c => c.ArticleCommentParentId != 0).Count();
            int[] result = { acCount, acChridrenCount };
            return Json(result);
        }

        //連結指定商品
        public IActionResult prodNamelike(string PdtName)
        {
            var result = db.Products.Any(m => m.ProductName.Replace(" ", "").Trim().Contains(PdtName) || m.ProductName.Trim().Contains(PdtName));
            if (result == false)
            {
                return Content("false", "text/plain", System.Text.Encoding.UTF8);
            }
            else
            {
                string prod = db.Products.FirstOrDefault(m => m.ProductName.Replace(" ", "").Trim().Contains(PdtName) || m.ProductName.Trim().Contains(PdtName)).ProductId.ToString();
                return Content(prod, "text/plain", System.Text.Encoding.UTF8);
            }

        }


    }
}
