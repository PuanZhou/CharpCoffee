using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList;
using prjCSCoffee.Models;
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

        public readonly CoffeeContext db;
        public ShopController(CoffeeContext context)
        {
            db = context;
        }


        public async Task<IActionResult> view(string search, int? countryid)
        {
            if (string.IsNullOrEmpty(search))
            {
                var q = db.Products.Select(p => new CProductViewModel()
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    CategoryId = p.CategoryId,
                    Category = p.Category,
                    Country = p.Country,
                    Coffee = p.Coffee,
                    Price = p.Price,
                    Description = p.Description,
                    Stock = p.Stock,
                    TakeDown = p.TakeDown,
                    ClickCount = p.ClickCount,
                    Star = p.Star,
                    MainPhotoPath=p.MainPhotoPath
                });
                ViewBag.countryid = countryid;
                //左側推薦商品欄位
                Random rng = new Random();
                var bestSales = db.Products.Select(p => p).OrderBy(p => p.Stock).Take(20).ToList();

                var recommend = bestSales.OrderBy(p => rng.Next()).Take(3).ToList();

                ViewBag.Recommend = recommend;
                return View(q);
            }
            else
            {
                if (countryid != null)
                {
                    ViewBag.countryid = countryid;
                    var q = db.Products.Where(p => p.CountryId == countryid).Select(p => new CProductViewModel()
                    {
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        CategoryId = p.CategoryId,
                        Category = p.Category,
                        Country = p.Country,
                        Coffee = p.Coffee,
                        Price = p.Price,
                        Description = p.Description,
                        Stock = p.Stock,
                        TakeDown = p.TakeDown,
                        ClickCount = p.ClickCount,
                        Star = p.Star,
                        MainPhotoPath = p.MainPhotoPath
                    });
                    //左側推薦商品欄位
                    Random rng = new Random();
                    var lowSales = db.Products.Select(p => p).OrderByDescending(p => p.Stock).Take(20).ToList();

                    var recommend = lowSales.OrderBy(p => rng.Next()).Take(3).ToList();

                    ViewBag.Recommend = recommend;
                    return View(await q.AsNoTracking().ToListAsync());

                }
                else
                {
                    ViewBag.countryid = countryid;
                    var q = db.Products.Where(p => p.ProductName.Contains(search)).Select(p => new CProductViewModel()
                    {
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        CategoryId = p.CategoryId,
                        Category = p.Category,
                        Country = p.Country,
                        Coffee = p.Coffee,
                        Price = p.Price,
                        Description = p.Description,
                        Stock = p.Stock,
                        TakeDown = p.TakeDown,
                        ClickCount = p.ClickCount,
                        Star = p.Star,
                        MainPhotoPath = p.MainPhotoPath
                    });
                    //左側推薦商品欄位
                    Random rng = new Random();
                    var lowSales = db.Products.Select(p => p).OrderByDescending(p => p.Stock).Take(20).ToList();

                    var recommend = lowSales.OrderBy(p => rng.Next()).Take(3).ToList();

                    ViewBag.Recommend = recommend;
                    return View(await q.AsNoTracking().ToListAsync());
                }
                
            }
        }

        public IActionResult detail(int? id)
        {
            var q1 = db.Products.Find(id);
            q1.ClickCount = q1.ClickCount + 1;
            db.SaveChanges();
            var q = db.Products.Include(p => p.Coffee).ThenInclude(p => p.Roasting)
                .Include(p => p.Coffee).ThenInclude(p => p.Process)
                .Include(p => p.Coffee).ThenInclude(p => p.Package)
                .Include(p => p.Photos)
                .Include(p=>p.Comments)
                .Where(p => p.ProductId == id).Select(p => new CProductViewModel()
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    CategoryId = p.CategoryId,
                    Category = p.Category,
                    Coffee = p.Coffee,
                    Country = p.Country,
                    ClickCount=p.ClickCount+1,
                    Price = p.Price,
                    Description = p.Description,
                    Stock = p.Stock,
                    TakeDown = p.TakeDown,                
                    Star = p.Comments.ToList().Count==0?0:p.Comments.Sum(c=>c.Star) / p.Comments.Count,
                    MainPhotoPath = p.MainPhotoPath,
                    Photos=p.Photos.Select(p=>p.ImagePath).ToList()
                }).ToList();
            return View(q[0]);

            

        }
        public IActionResult forhomedetail(int? id)
        {
            var q1 = db.Products.Find(id);
            q1.ClickCount = q1.ClickCount + 1;
            db.SaveChanges();
            var q = db.Products.Include(p => p.Coffee).ThenInclude(p => p.Roasting)
                .Include(p => p.Coffee).ThenInclude(p => p.Process)
                .Include(p => p.Coffee).ThenInclude(p => p.Package)
                .Include(p => p.Photos)
                .Where(p => p.ProductId == id).Select(p => new CProductViewModel()
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    CategoryId = p.CategoryId,
                    Category = p.Category,
                    Coffee = p.Coffee,
                    Country = p.Country,
                    Price = p.Price,
                    Description = p.Description,
                    Stock = p.Stock,
                    TakeDown = p.TakeDown,
                    Star = p.Star,
                    MainPhotoPath = p.MainPhotoPath,
                    Photos = p.Photos.Select(p => p.ImagePath).ToList()
                }).ToList();
            return View(q[0]);
        }
        public IActionResult addToCart(int? id)
        {

            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_USER))
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
                pd.Coffee = q.Coffee;
                pd.Description = q.Description;
                pd.Stock = q.Stock;
                pd.TakeDown = q.TakeDown;
                pd.Star = q.Star;
                pd.MainPhotoPath = q.MainPhotoPath;
                return View(pd);
            }
            else
            {

                return RedirectToAction("Login", "Home");
            }

        }

        public IActionResult partialView()
        {


            var q = db.Products.Select(p => new CProductViewModel()
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
                Coffee = p.Coffee,
                Description = p.Description,
                Stock = p.Stock,
                TakeDown = p.TakeDown,
                ClickCount=p.ClickCount,
                Star = p.Star,
                MainPhotoPath = p.MainPhotoPath
            });
            return PartialView(q);
        }
        public IActionResult partialViewContry(int id)
        {

            var q = db.Coffees.Where(p => p.CountryId == id).Select(p => new CCoffeeViewModel()
            {
                ProductId = p.ProductId,
                CoffeeId = p.CoffeeId,
                CoffeeName = p.CoffeeName,
                CountryId = p.CountryId,
                RoastingId = p.RoastingId,
                ProcessId = p.ProcessId,
                PackageId = p.PackageId,
                RainForest = p.RainForest,
                Country = p.Country,
                Package = p.Package,
                Process = p.Process,
                Product = p.Product,
                Roasting = p.Roasting
            });
            return PartialView(q);
        }
        public IActionResult partialViewRoast(int id)
        {

            var q = db.Coffees.Where(p => p.RoastingId == id).Select(p => new CCoffeeViewModel()
            {
                ProductId = p.ProductId,
                CoffeeId = p.CoffeeId,
                CoffeeName = p.CoffeeName,
                CountryId = p.CountryId,
                RoastingId = p.RoastingId,
                ProcessId = p.ProcessId,
                PackageId = p.PackageId,
                RainForest = p.RainForest,
                Country = p.Country,
                Package = p.Package,
                Process = p.Process,
                Product = p.Product,
                Roasting = p.Roasting
            });
            return PartialView(q);
        }
        public IActionResult partialViewProcess(int id)
        {

            var q = db.Coffees.Where(p => p.ProcessId == id).Select(p => new CCoffeeViewModel()
            {
                ProductId = p.ProductId,
                CoffeeId = p.CoffeeId,
                CoffeeName = p.CoffeeName,
                CountryId = p.CountryId,
                RoastingId = p.RoastingId,
                ProcessId = p.ProcessId,
                PackageId = p.PackageId,
                RainForest = p.RainForest,
                Country = p.Country,
                Package = p.Package,
                Process = p.Process,
                Product = p.Product,
                Roasting = p.Roasting
            });
            return PartialView(q);
        }
        public IActionResult partialViewPacking(int id)
        {

            var q = db.Coffees.Where(p => p.PackageId == id).Select(p => new CCoffeeViewModel()
            {
                ProductId = p.ProductId,
                CoffeeId = p.CoffeeId,
                CoffeeName = p.CoffeeName,
                CountryId = p.CountryId,
                RoastingId = p.RoastingId,
                ProcessId = p.ProcessId,
                PackageId = p.PackageId,
                RainForest = p.RainForest,
                Country = p.Country,
                Package = p.Package,
                Process = p.Process,
                Product = p.Product,
                Roasting = p.Roasting
            });
            return PartialView(q);
        }
        public IActionResult partialViewBtnForCatgory(int id)
        {
            var q = db.Products.Where(p => p.CategoryId == id).Select(p => new CProductViewModel()
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                CategoryId = p.CategoryId,
                Category = p.Category,
                Country = p.Country,
                Price = p.Price,
                Coffee = p.Coffee,
                Description = p.Description,
                Stock = p.Stock,
                TakeDown = p.TakeDown,
                Star = p.Star,
                MainPhotoPath = p.MainPhotoPath

            }).FirstOrDefault();
            return PartialView(q);
        }

        public IActionResult partialViewRelated(int? Id)
        {
            int CategoryID = db.Products.Where(p => p.ProductId == Id).Select(p => p.CategoryId).FirstOrDefault();

            if (CategoryID != 1)
            {
                return Content("null", "text/plain", System.Text.Encoding.UTF8);
            }

            Random rng = new Random();
            List<CRelatedViewModel> list = new List<CRelatedViewModel>();

            var productName = db.Coffees.Where(p => p.ProductId == Id).Select(n => n.CoffeeName).FirstOrDefault();

            var RoastingId = db.Products.Where(p => p.ProductId == Id).Select(r => r.Coffee.RoastingId).FirstOrDefault();

            var relatedbyRoasting = db.Coffees.Include(p => p.Product).AsEnumerable().Where(p => p.RoastingId == RoastingId && p.CoffeeName != productName)
                .OrderByDescending(x => rng.Next()).Select(p => new CRelatedViewModel()
                {
                    ProductId = p.ProductId,
                    CoffeeName = p.CoffeeName,
                    Price = Convert.ToInt32(p.Product.Price)
                }).FirstOrDefault();

            list.Add(relatedbyRoasting);

            var ProcessId = db.Products.Where(p => p.ProductId == Id).Select(r => r.Coffee.ProcessId).FirstOrDefault();

            var relatedbyProcess = db.Coffees.Include(p => p.Product).AsEnumerable().Where(p => p.ProcessId == ProcessId && p.CoffeeName != productName && p.CoffeeName != relatedbyRoasting.CoffeeName)
                .OrderByDescending(x => rng.Next()).Select(p => new CRelatedViewModel()
                {
                    ProductId = p.ProductId,
                    CoffeeName = p.CoffeeName,
                    Price = Convert.ToInt32(p.Product.Price)
                }).FirstOrDefault();

            list.Add(relatedbyProcess);

            var ContinentId = db.Products.Where(p => p.ProductId == Id).Select(r => r.Country.ContinentId).FirstOrDefault();

            var relatedbyContinent = db.Coffees.Include(p => p.Product).ThenInclude(p => p.Country).AsEnumerable()
                .Where(p => p.Country.ContinentId == ContinentId && p.CoffeeName != productName && p.CoffeeName != relatedbyRoasting.CoffeeName && p.CoffeeName != relatedbyProcess.CoffeeName).OrderByDescending(x => rng.Next())
                .Select(p => new CRelatedViewModel()
                {
                    ProductId = p.ProductId,
                    CoffeeName = p.CoffeeName,
                    Price = Convert.ToInt32(p.Product.Price)
                }).FirstOrDefault();

            list.Add(relatedbyContinent);

            return PartialView(list);
        }

    }
}
