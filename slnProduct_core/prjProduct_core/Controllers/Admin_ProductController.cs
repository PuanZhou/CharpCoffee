using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using prjAdmin.Models;
using prjAdmin.ViewModels;
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
    public class Admin_ProductController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly CoffeeContext _context;
        private static Admin signIn_User;

        public Admin_ProductController(CoffeeContext context, IWebHostEnvironment host)
        {
            _environment = host;
            _context = context;
        }

        public IActionResult Index(CAdmin_KeywordViewModel vModel)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                string JsonUser = HttpContext.Session.GetString(CDictionary.SK_LOGINED_ADMIN);
                signIn_User = JsonSerializer.Deserialize<Admin>(JsonUser);
                if (signIn_User.ProductOk)
                {
                    IEnumerable<CAdmin_ProductViewModel> datas = null;
                    var list = _context.Products.Include(p => p.Comments).Select(p => new CAdmin_ProductViewModel()
                    {
                        ProductId = p.ProductId,
                        ProductName = p.ProductName,
                        Category = p.Category,
                        Country = p.Country,
                        Coffee = p.Coffee,
                        Price = p.Price,
                        Description = p.Description,
                        Stock = p.Stock,
                        ClickCount = p.ClickCount,
                        TakeDown = p.TakeDown,
                        Star = p.Comments.Count == 0 ? 0 : Math.Round((double)(p.Comments.Sum(c => c.Star) / p.Comments.Count),1),
                        MainPhotoPath = p.MainPhotoPath
                    });

                    if (string.IsNullOrEmpty(vModel.txtKeyword)) // 若沒輸入關鍵字則回傳所有產品
                    {
                        datas = list;
                    }
                    else
                    {
                        if (vModel.txtKeyword == "上架") // 關鍵字輸入上架回傳上架商品
                            datas = list.Where(p => p.TakeDown == false); 
                        else if (vModel.txtKeyword == "下架") // 關鍵字輸入下架回傳下架商品
                            datas = list.Where(p => p.TakeDown == true); 
                        else if (vModel.txtKeyword.StartsWith("#類別 ")) // 關鍵字輸入#類別 (半形空格)後打類別名稱，回傳搜尋結果
                            datas = list.Where(p => p.Category.CategoriesName.Contains(vModel.txtKeyword.Substring(4)));
                        else if (vModel.txtKeyword.StartsWith("#國家 ")) // 關鍵字輸入#國家 (半形空格)後打類別名稱，回傳搜尋結果
                            datas = list.Where(p => p.Country.CountryName.Contains(vModel.txtKeyword.Substring(4)));
                        else if (vModel.txtKeyword.StartsWith("#庫存不足")) // 關鍵字輸入#庫存不足，回傳庫存數 < 10的產品
                            datas = list.Where(p => p.Stock < 10);
                        else if (vModel.txtKeyword.StartsWith("#庫存"))
                        {
                            string[] key = vModel.txtKeyword.Split("存");
                            if (key[1].StartsWith(">=")) // 庫存>=
                            {
                                int num;
                                bool success = int.TryParse(key[1].Split(">=")[1], out num);
                                if (success)
                                    datas = list.Where(p => p.Stock >= num);
                                else
                                    datas = list;
                            }
                            else if (key[1].StartsWith("<=")) // 庫存<=
                            {
                                int num;
                                bool success = int.TryParse(key[1].Split("<=")[1], out num);
                                if (success)
                                    datas = list.Where(p => p.Stock <= num);
                                else
                                    datas = list;
                            }
                            else if (key[1].StartsWith("=")) // 庫存=
                            {
                                int num;
                                bool success = int.TryParse(key[1].Split("=")[1], out num);
                                if (success)
                                    datas = list.Where(p => p.Stock == num);
                                else
                                    datas = list;
                            }
                            else if (key[1].StartsWith(">")) // 庫存>
                            {
                                int num;
                                bool success = int.TryParse(key[1].Split(">")[1], out num);
                                if (success)
                                    datas = list.Where(p => p.Stock > num);
                                else
                                    datas = list;
                            }
                            else if (key[1].StartsWith("<")) // 庫存<
                            {
                                int num;
                                bool success = int.TryParse(key[1].Split("<")[1], out num);
                                if (success)
                                    datas = list.Where(p => p.Stock < num);
                                else
                                    datas = list;
                            }
                        }
                        else
                        {
                            datas = list.Where(p => p.ProductName.Contains(vModel.txtKeyword));  // 依輸入關鍵字查詢產品名                                               

                        }
                    }
                    return View(datas);
                }

                return RedirectToAction("Error403", "Admin_Dashboard");
            }

            Admin_DashboardController.btnSignInText = "登入";
            return RedirectToAction("Error403", "Admin_Dashboard");
        }

        [HttpGet]
        public IActionResult Create()
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                string JsonUser = HttpContext.Session.GetString(CDictionary.SK_LOGINED_ADMIN);
                signIn_User = JsonSerializer.Deserialize<Admin>(JsonUser);
                if (signIn_User.ProductOk)
                {
                    return View();
                }

                return RedirectToAction("Error403", "Admin_Dashboard");
            }

            Admin_DashboardController.btnSignInText = "登入";
            return RedirectToAction("Error403", "Admin_Dashboard");
        }

        [HttpPost]
        public IActionResult Create(CAdmin_ProductViewModel p)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                string JsonUser = HttpContext.Session.GetString(CDictionary.SK_LOGINED_ADMIN);
                signIn_User = JsonSerializer.Deserialize<Admin>(JsonUser);
                if (signIn_User.ProductOk)
                {
                    // 新增產品
                    Product prod = new Product();
                    prod.ProductName = p.ProductName;
                    prod.CategoryId = p.CategoryId;
                    prod.CountryId = p.CountryId;
                    prod.Price = p.Price;
                    prod.Description = p.Description;
                    prod.Stock = p.Stock;
                    prod.TakeDown = p.TakeDown;

                    // 若有新增主產品圖片
                    if (p.photo != null)
                    {
                        string pName = Guid.NewGuid().ToString() + ".jpg";
                        using (FileStream fs = new FileStream(_environment.WebRootPath + "/Images/" + pName, FileMode.Create))
                            p.photo.CopyTo(fs);
                        prod.MainPhotoPath = pName;
                    }

                    _context.Products.Add(prod);
                    _context.SaveChanges();

                    // 若有新增副產品圖片
                    if (p.SubPhotos != null)
                    {
                        foreach (IFormFile subphoto in p.SubPhotos)
                        {
                            // 新建圖片檔案在wwwroot/Images
                            string spName = Guid.NewGuid().ToString() + ".jpg";
                            using (FileStream fs = new FileStream(_environment.WebRootPath + "/Images/" + spName, FileMode.Create))
                                subphoto.CopyTo(fs);                            
                            // 更新副圖片資料表
                            Photo newphoto = new Photo();
                            newphoto.ProductId = _context.Products.OrderBy(p=>p.ProductId).Last().ProductId;
                            newphoto.ImagePath = spName;
                            _context.Photos.Add(newphoto);
                            _context.SaveChanges();
                        }
                    }

                    // 若新增的產品為咖啡類別，在咖啡資料表內新增該產品
                    int productId = _context.Products.AsEnumerable().Last().ProductId;
                    int coffeeCateId = _context.Categories.FirstOrDefault(c => c.CategoriesName == "咖啡").CategoryId;

                    if (p.CategoryId == coffeeCateId)
                    {
                        Coffee coffee = new Coffee()
                        {
                            ProductId = productId,
                            CoffeeName = p.ProductName,
                            CountryId = (int)p.CountryId,
                            RoastingId = p.RoastingId,
                            PackageId = p.PackageId,
                            ProcessId = p.ProcessId,
                            RainForest = p.RainForest
                        };

                        _context.Coffees.Add(coffee);
                        _context.SaveChanges();
                    }

                    return RedirectToAction("Index");
                }

                return RedirectToAction("Error403", "Admin_Dashboard");
            }

            Admin_DashboardController.btnSignInText = "登入";
            return RedirectToAction("Error403", "Admin_Dashboard");
        }

        public IActionResult TakeDown(int id)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                string JsonUser = HttpContext.Session.GetString(CDictionary.SK_LOGINED_ADMIN);
                signIn_User = JsonSerializer.Deserialize<Admin>(JsonUser);
                if (signIn_User.ProductOk)
                {
                    Product p = _context.Products.Find(id);
                    p.TakeDown = true;
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }

                return RedirectToAction("Error403", "Admin_Dashboard");
            }

            Admin_DashboardController.btnSignInText = "登入";
            return RedirectToAction("Error403", "Admin_Dashboard");
        }

        public IActionResult Launch(int id)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                string JsonUser = HttpContext.Session.GetString(CDictionary.SK_LOGINED_ADMIN);
                signIn_User = JsonSerializer.Deserialize<Admin>(JsonUser);
                if (signIn_User.ProductOk)
                {
                    Product p = _context.Products.Find(id);
                    p.TakeDown = false;
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }

                return RedirectToAction("Error403", "Admin_Dashboard");
            }

            Admin_DashboardController.btnSignInText = "登入";
            return RedirectToAction("Error403", "Admin_Dashboard");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                string JsonUser = HttpContext.Session.GetString(CDictionary.SK_LOGINED_ADMIN);
                signIn_User = JsonSerializer.Deserialize<Admin>(JsonUser);
                if (signIn_User.ProductOk)
                {
                    List<CAdmin_ProductViewModel> prod = null;
                    if (_context.Coffees.Any(c => c.ProductId == id))
                    {
                        prod = _context.Products.Include(p => p.Photos).Where(p => p.ProductId == id).Select(p => new CAdmin_ProductViewModel()
                        {
                            ProductId = p.ProductId,
                            ProductName = p.ProductName,
                            CategoryId = p.CategoryId,
                            CountryId = p.CountryId,
                            Coffee = p.Coffee,
                            PackageId = p.Coffee.PackageId,
                            ProcessId = p.Coffee.ProcessId,
                            RoastingId = p.Coffee.RoastingId,
                            RainForest = p.Coffee.RainForest,
                            Price = p.Price,
                            Description = p.Description,
                            Stock = p.Stock,
                            ClickCount = p.ClickCount,
                            TakeDown = p.TakeDown,
                            Star = p.Comments.Count == 0 ? 0 : Math.Round((double)(p.Comments.Sum(c => c.Star) / p.Comments.Count), 1), 
                            MainPhotoPath = p.MainPhotoPath,
                            SubPhotosPath = p.Photos.Select(p => p.ImagePath).ToList()
                        })
                            .ToList();
                    }
                    else
                    {
                        prod = _context.Products.Include(p => p.Photos).Where(p => p.ProductId == id).Select(p => new CAdmin_ProductViewModel()
                        {
                            ProductId = p.ProductId,
                            ProductName = p.ProductName,
                            CategoryId = p.CategoryId,
                            CountryId = p.CountryId,
                            Coffee = p.Coffee,
                            Price = p.Price,
                            Description = p.Description,
                            Stock = p.Stock,
                            ClickCount = p.ClickCount,
                            TakeDown = p.TakeDown,
                            Star = p.Star,
                            MainPhotoPath = p.MainPhotoPath,
                            SubPhotosPath = p.Photos.Select(p => p.ImagePath).ToList()
                        })
                            .ToList();
                    }

                    var lstCatrgory = _context.Categories.ToList();
                    var lstCountry = _context.Countries.ToList();
                    var lstPackage = _context.Packages.ToList();
                    var lstProcess = _context.Processes.ToList();
                    var lstRoasting = _context.Roastings.ToList();

                    ViewBag.CateListItem = CSelectList.ToSelectList(lstCatrgory);
                    ViewBag.CtryListItem = CSelectList.ToSelectList(lstCountry);
                    ViewBag.PkgListItem = CSelectList.ToSelectList(lstPackage);
                    ViewBag.PrcsListItem = CSelectList.ToSelectList(lstProcess);
                    ViewBag.RoastListItem = CSelectList.ToSelectList(lstRoasting);

                    if (prod.Count == 0)
                        return RedirectToAction("Index");
                    return View(prod[0]);
                }

                return RedirectToAction("Error403", "Admin_Dashboard");
            }

            Admin_DashboardController.btnSignInText = "登入";
            return RedirectToAction("Error403", "Admin_Dashboard");
        }

        [HttpPost]
        public IActionResult Edit(CAdmin_ProductViewModel p)
        {
            if (HttpContext.Session.Keys.Contains(CDictionary.SK_LOGINED_ADMIN))
            {
                string JsonUser = HttpContext.Session.GetString(CDictionary.SK_LOGINED_ADMIN);
                signIn_User = JsonSerializer.Deserialize<Admin>(JsonUser);
                if (signIn_User.ProductOk)
                {
                    // 修改產品
                    Product prod = _context.Products.Find(p.ProductId);
                    if (prod != null)
                    {
                        // 若有上傳主圖片
                        if (p.photo != null)
                        {
                            // 新建圖片檔案在wwwroot/Images
                            string pName = Guid.NewGuid().ToString() + ".jpg";
                            using (FileStream fs = new FileStream(_environment.WebRootPath + "/Images/" + pName, FileMode.Create))
                                p.photo.CopyTo(fs);
                            // 更新資料庫圖片檔名
                            prod.MainPhotoPath = pName;
                        }
                        // 若有上傳副圖片
                        if (p.SubPhotos != null)
                        {
                            foreach (IFormFile subphoto in p.SubPhotos)
                            {
                                var origPhotos = _context.Photos.Where(photo => photo.ProductId == p.ProductId).ToList();
                                // 若此產品的副圖片原本就有2張，且繼續上傳副圖片的話，刪除原本第1張舊圖片
                                if (origPhotos.Count > 1)
                                {
                                    System.IO.File.Delete(_environment.WebRootPath + "/Images/" + origPhotos[0].ImagePath);
                                    _context.Photos.Remove(origPhotos[0]);
                                }

                                // 新建圖片檔案在wwwroot/Images
                                string spName = Guid.NewGuid().ToString() + ".jpg";
                                using (FileStream fs = new FileStream(_environment.WebRootPath + "/Images/" + spName, FileMode.Create))
                                    subphoto.CopyTo(fs);
                                // 更新副圖片資料表
                                Photo newphoto = new Photo();
                                newphoto.ProductId = p.ProductId;
                                newphoto.ImagePath = spName;
                                _context.Photos.Add(newphoto);
                                _context.SaveChanges();
                            }
                        }
                        prod.ProductName = p.ProductName;
                        prod.CategoryId = p.CategoryId;
                        prod.CountryId = p.CountryId;
                        prod.Price = p.Price;
                        prod.Description = p.Description;
                        prod.Stock = p.Stock;
                        prod.TakeDown = p.TakeDown;
                    };

                    _context.SaveChanges();

                    // 假如產品修改類別為咖啡
                    int coffeeCateId = _context.Categories.FirstOrDefault(c => c.CategoriesName == "咖啡").CategoryId;

                    if (p.CategoryId == coffeeCateId)
                    {
                        // 若產品原本不是咖啡類別，在咖啡資料表內新增該產品
                        Coffee product = _context.Coffees.FirstOrDefault(c => c.ProductId == p.ProductId);
                        if (product == null)
                        {
                            _context.Coffees.Add(new Coffee()
                            {
                                ProductId = p.ProductId,
                                CoffeeName = p.ProductName,
                                PackageId = p.PackageId,
                                ProcessId = p.ProcessId,
                                RoastingId = p.RoastingId,
                                RainForest = p.RainForest,
                                CountryId = (int)p.CountryId
                            });
                        }
                        else
                        {
                            // 若產品原本就是咖啡類別，更新產品資料
                            product.CoffeeName = p.ProductName;
                            product.PackageId = p.PackageId;
                            product.ProcessId = p.ProcessId;
                            product.RoastingId = p.RoastingId;
                            product.RainForest = p.RainForest;
                            product.CountryId = (int)p.CountryId;
                        }

                        _context.SaveChanges();
                    }
                    else
                    {
                        // 若產品類別不是咖啡，且在咖啡資料表內找到該產品
                        Coffee coffee = _context.Coffees.FirstOrDefault(c => c.ProductId == p.ProductId);
                        if (coffee != null)
                        {
                            // 在咖啡資料表中刪除該產品
                            _context.Coffees.Remove(coffee);
                            _context.SaveChanges();
                        }
                    }

                    return RedirectToAction("Index");
                }

                return RedirectToAction("Error403", "Admin_Dashboard");
            }

            Admin_DashboardController.btnSignInText = "登入";
            return RedirectToAction("Error403", "Admin_Dashboard");
        }
    }
}
