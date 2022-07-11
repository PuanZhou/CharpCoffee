using Microsoft.AspNetCore.Mvc;
using prjProduct_core.Models;
using prjProduct_core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjProduct_core.Controllers
{
    public class ShopController : Controller
    {

        private readonly CoffeeContext db;
        public ShopController(CoffeeContext context)
        {
            db = context;
        }


        public IActionResult view()
        {

            var q = db.Products.Select(p => new CProductViewModel()
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                CategoryId = p.CategoryId,
                Category = p.Category,
                Country = p.Country,
                Price = p.Price,
                Description = p.Description,
                Stock = p.Stock,
                TakeDown = p.TakeDown,
                Star = p.Star
            });
            return View(q);
        }

        public IActionResult detail(int? id)
        {
            CProductViewModel pd = new CProductViewModel();
            var q = db.Products.FirstOrDefault(p => p.ProductId == id);
            pd.ProductId = q.ProductId;
            pd.ProductName = q.ProductName;
            pd.CategoryId = q.CategoryId;
            var q1 = db.Categories.FirstOrDefault(p => p.CategoryId == q.CategoryId);
            pd.CategoryName = q1.CategoriesName;
            pd.Country = q.Country;
            pd.Price = q.Price;
            pd.Description = q.Description;
            pd.Stock = q.Stock;
            pd.TakeDown = q.TakeDown;
            pd.Star = q.Star;
            return View(pd);
        }
        public IActionResult addToCart(int? id)
        {
            CProductViewModel pd = new CProductViewModel();
            var q = db.Products.FirstOrDefault(p => p.ProductId == id);
            pd.ProductId = q.ProductId;
            pd.ProductName = q.ProductName;
            pd.CategoryId = q.CategoryId;
            var q1 = db.Categories.FirstOrDefault(p => p.CategoryId == q.CategoryId);
            pd.CategoryName = q1.CategoriesName;
            pd.Country = q.Country;
            pd.Price = q.Price;
            pd.Description = q.Description;
            pd.Stock = q.Stock;
            pd.TakeDown = q.TakeDown;
            pd.Star = q.Star;
            return View(pd);
        }
        public IActionResult partialView()
        {
            var q = db.Products.Select(p => new CProductViewModel()
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                CategoryId = p.CategoryId,
                Category = p.Category,
                Country = p.Country,
                Price = p.Price,
                Description = p.Description,
                Stock = p.Stock,
                TakeDown = p.TakeDown,
                Star = p.Star
            });
            return PartialView(q);
        }
        public IActionResult partialViewForCatgory(int id)
        {
            var q = db.Products.Where(p => p.CategoryId == id).Select(p => new CProductViewModel()
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                CategoryId = p.CategoryId,
                Category = p.Category,
                Country = p.Country,
                Price = p.Price,
                Description = p.Description,
                Stock = p.Stock,
                TakeDown = p.TakeDown,
                Star = p.Star
            });
            return PartialView(q);
        }

        public IActionResult partialViewRelated(int? Id)
        {
            Random rng = new Random();
            List<CRelatedViewModel> list = new List<CRelatedViewModel>();

            var productName = db.Coffees.Where(p => p.ProductId == Id).Select(n => n.CoffeeName).FirstOrDefault();

            var RoastingId = db.Products.Where(p => p.ProductId == Id).Select(r => r.Coffee.RoastingId).FirstOrDefault();

            var relatedbyRoasting = db.Coffees.AsEnumerable().Where(p => p.RoastingId == RoastingId && p.CoffeeName != productName)
                .OrderByDescending(x => rng.Next()).Select(p => new CRelatedViewModel()
                {
                    ProductId = p.ProductId,
                    CoffeeName = p.CoffeeName,
                    Price=Convert.ToInt32(db.Products.Where(p=>p.ProductId==p.ProductId).Select(p=>p.Price).FirstOrDefault())
                }).FirstOrDefault();

            list.Add(relatedbyRoasting);

            var ProcessId = db.Products.Where(p => p.ProductId == Id).Select(r => r.Coffee.ProcessId).FirstOrDefault();

            var relatedbyProcess = db.Coffees.AsEnumerable().Where(p => p.ProcessId == ProcessId && p.CoffeeName != productName && p.CoffeeName != relatedbyRoasting.CoffeeName)
                .OrderByDescending(x => rng.Next()).Select(p => new CRelatedViewModel()
                {
                    ProductId = p.ProductId,
                    CoffeeName = p.CoffeeName,
                    Price = Convert.ToInt32(db.Products.Where(p => p.ProductId == p.ProductId).Select(p => p.Price).FirstOrDefault())
                }).FirstOrDefault();

            list.Add(relatedbyProcess);

            var CountryId = db.Products.Where(p => p.ProductId == Id).Select(r => r.CountryId).FirstOrDefault();

            var relatedbyCountry = db.Coffees.AsEnumerable().Where(p => p.CountryId == CountryId && p.CoffeeName != productName && p.CoffeeName != relatedbyRoasting.CoffeeName && p.CoffeeName != relatedbyProcess.CoffeeName)
                .OrderByDescending(x => rng.Next()).Select(p => new CRelatedViewModel()
                {
                    ProductId = p.ProductId,
                    CoffeeName = p.CoffeeName,
                    Price = Convert.ToInt32(db.Products.Where(p => p.ProductId == p.ProductId).Select(p => p.Price).FirstOrDefault())
                }).FirstOrDefault();
            if (relatedbyCountry != null)
            {
                list.Add(relatedbyCountry);
            }
            return PartialView(list);
        }
    }
}
