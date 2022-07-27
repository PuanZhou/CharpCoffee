using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prjProduct_core.ViewModel
{
    public class CCompareCoffeeViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Coffee Coffee { get; set; }
        public Continent Continent { get; set; }
        public Country Country { get; set; }
        public  Package Package { get; set; }
        public Process Process { get; set; }
        public Roasting Roasting { get; set; }
        public string Description { get; set; }
        public string MainPhotoPath { get; set; }
        public decimal? Price { get; set; }
    }
}
