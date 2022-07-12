using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjProduct_core.ViewModel
{
    public class CCoffeeViewModel
    {
        public int CoffeeId { get; set; }
        public int ProductId { get; set; }
        public string CoffeeName { get; set; }
        public int CountryId { get; set; }
        public int RoastingId { get; set; }
        public int ProcessId { get; set; }
        public int PackageId { get; set; }
        public int? ConstellationId { get; set; }
        public bool RainForest { get; set; }

        public  Country Country { get; set; }
        public  Package Package { get; set; }
        public  Process Process { get; set; }
        public  Product Product { get; set; }
        public  Roasting Roasting { get; set; }
    }
}
