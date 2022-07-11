using Microsoft.AspNetCore.Mvc;
using prjCSCoffee.Models;
using prjProduct_core.Models;
using prjProduct_core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace prjProduct_core.Controllers
{
    public class CompareController : Controller
    {
        private readonly CoffeeContext db;

        public CompareController(CoffeeContext context)
        {
            db = context;
        }
        public IActionResult CompareView()
        {
            List<CCompareCoffeeViewModel> list = new List<CCompareCoffeeViewModel>();
            if (HttpContext.Request.Cookies.Keys.Contains(CDictionary.AddCompare))
            {
                string jsonCompare = HttpContext.Request.Cookies[CDictionary.AddCompare];
                List<int> compareIdList = JsonSerializer.Deserialize<List<int>>(jsonCompare);
               foreach(int Id in compareIdList)
                {
                    var prod = db.Products.Where(p => p.ProductId == Id).Select(p => new CCompareCoffeeViewModel()
                    {
                        ProductId = p.ProductId,//咖啡ID
                        ProductName = p.ProductName,
                        Continent = p.Country.Continent,//咖啡產地
                        Country = p.Country,//國家
                        Process = p.Coffee.Process, //處理法
                        Roasting = p.Coffee.Roasting,//烘培
                        Package = p.Coffee.Package,//包裝
                        Description = p.Description,//風味
                        Price = p.Price//單價
                    }).FirstOrDefault();
                    list.Add(prod);
                }
            }
            return View(list);
        }
        public IActionResult AddCompare(int? Id)
        {
            string jsonCompare;
            List<int> compareIdList;
            if (!HttpContext.Request.Cookies.Keys.Contains(CDictionary.AddCompare))
            {
                compareIdList = new List<int>();
            }
            else
            {
                jsonCompare = HttpContext.Request.Cookies[CDictionary.AddCompare];
                compareIdList = JsonSerializer.Deserialize<List<int>>(jsonCompare);
            }
            if (compareIdList.Contains(Convert.ToInt32(Id)))
            {
                return Content("已經加入過比較列表", "text/plain", System.Text.Encoding.UTF8);
            }
            else if (compareIdList.Count >= 3)
            {
                return Content("已加入三樣商品請先前往比較", "text/plain", System.Text.Encoding.UTF8);
            }

            compareIdList.Add(Convert.ToInt32(Id));
            jsonCompare = JsonSerializer.Serialize(compareIdList);
            HttpContext.Response.Cookies.Append(CDictionary.AddCompare, jsonCompare);
            return Content("商品加入比較列表", "text/plain", System.Text.Encoding.UTF8);
        }
    }
}
