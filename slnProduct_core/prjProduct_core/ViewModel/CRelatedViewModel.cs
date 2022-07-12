using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjProduct_core.ViewModel
{
    public class CRelatedViewModel
    {
        public int ProductId { get; set; }
        public string CoffeeName { get; set; }
        public int Price { get; set; }
        public Country Country { get; set; }
        public Continent Continent { get; set; }
    }
}
