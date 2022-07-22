using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using prjCSCoffee.Models;
using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace prjProduct_core.Controllers
{
    public class APIController : Controller
    {
        private readonly CoffeeContext db;
        private readonly IWebHostEnvironment _host;

        public APIController(CoffeeContext context, IWebHostEnvironment hostEnvironment)
        {
            db = context;
            _host = hostEnvironment;
        }
        //===============計算產品數量===============
        public IActionResult CategoryidCount(int id)
        {
            if (id == 0)
            {
                var q = db.Products;
                return Content($"{q.Count()}","text/plain", System.Text.Encoding.UTF8);
            }
            else
            {
                var q = db.Products.Where(p => p.CategoryId == id);
                return Content($"{q.Count()}", "text/plain", System.Text.Encoding.UTF8);
            }                   
        }
        public IActionResult RoastCount(int id)
        {
            if (id == 0)
            {
                var q = db.Products;
                return Content($"{q.Count()}", "text/plain", System.Text.Encoding.UTF8);
            }
            else
            {
                var q = db.Products.Where(p => p.Coffee.RoastingId == id);
                return Content($"{q.Count()}", "text/plain", System.Text.Encoding.UTF8);
            }
        }
        public IActionResult PackCount(int id)
        {
            if (id == 0)
            {
                var q = db.Products;
                return Content($"{q.Count()}", "text/plain", System.Text.Encoding.UTF8);
            }
            else
            {
                var q = db.Products.Where(p => p.Coffee.PackageId == id);
                return Content($"{q.Count()}", "text/plain", System.Text.Encoding.UTF8);
            }
        }
        public IActionResult ProssCount(int id)
        {
            if (id == 0)
            {
                var q = db.Products;
                return Content($"{q.Count()}", "text/plain", System.Text.Encoding.UTF8);
            }
            else
            {
                var q = db.Products.Where(p => p.Coffee.ProcessId == id);
                return Content($"{q.Count()}", "text/plain", System.Text.Encoding.UTF8);
            }
        }
        public IActionResult ContryCount(int id)
        {
            if (id == 0)
            {
                var q = db.Products;
                return Content($"{q.Count()}", "text/plain", System.Text.Encoding.UTF8);
            }
            else
            {
                var q = db.Products.Where(p => p.Coffee.CountryId == id);
                return Content($"{q.Count()}", "text/plain", System.Text.Encoding.UTF8);
            }
        }
        //===============計算評論與回覆數量===============
        public IActionResult CountComments(int productId)
        {
            var comments = db.Comments.Where(x => x.ProductId == productId);
            int countP = comments.Where(x => x.CommentParentId == 0).Count();
            int countC = comments.Where(x => x.CommentParentId != 0).Count();
            int[] result = { countP, countC };
            return Json(result);
        }
        //===============新增留言===============
        public IActionResult AddComment(Comment c)
        {
            if (HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER) != null)
            {
                //int mId=JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;
                //c.MemberId = mId;
            }
            db.Comments.Add(c);
            db.SaveChanges();
            return Content("您的評論已成功送出！", "text/plain", System.Text.Encoding.UTF8);
        }
        //===============客服圖===============
        public IActionResult uploadImage(IFormFile file)
        {
            string path = Path.Combine(_host.WebRootPath, "temp", file.FileName);
            //string path = Path.Combine(_host.WebRootPath, "temp", "temp.jpg");
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            string info = @"/temp/" + file.FileName;
            //string info = @"temp/temp.jpg";
            return Content(info, "text/plain", System.Text.Encoding.UTF8);
        }

        //===============會員的購物車內物品數計算===============
        public IActionResult CountCart()
        {
            if (HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER) == null)
            {
                return Content("0", "text/plain");
            }
            int id = JsonSerializer.Deserialize<Member>(HttpContext.Session.GetString(CDictionary.SK_LOGINED_USER)).MemberId;
            string result = db.ShoppingCarDetails.Where(x => x.MemberId == id).Select(x => x.Quantity).Sum(x => x).ToString();
            return Content(result, "text/plain");
        }
    }
}
