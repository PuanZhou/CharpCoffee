using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjProduct_core.ViewModel
{
    public class CProductViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? CountryId { get; set; }
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public int? Stock { get; set; }
        public int? ClickCount { get; set; }
        public bool TakeDown { get; set; }
        public double? Star { get; set; }
        public Category Category { get; set; }
        public  Country Country { get; set; }
        public  Coffee Coffee { get; set; }
    }
}
