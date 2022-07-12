using prjCSCoffee.Models;
using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjCSCoffee.ViewModel
{
    public class CProductViewModel_09
    {
        public CProductViewModel_09()
        {
            _prod = new Product();
        }
        private Product _prod;
        public Product product
        {
            get { return _prod; }
            set { _prod = value; }
        }
        public int ProductId
        {
            get { return _prod.ProductId; }
            set { _prod.ProductId = value; }
        }
        public string ProductName
        {
            get { return _prod.ProductName; }
            set { _prod.ProductName = value; }
        }       
        public decimal? Price
        {
            get { return _prod.Price; }
            set { _prod.Price = value; }
        }
        public string Description
        {
            get { return _prod.Description; }
            set { _prod.Description = value; }
        }
        public int? Stock
        {
            get { return _prod.Stock; }
            set { _prod.Stock = value; }
        }
        public int CategoryId
        {
            get { return _prod.CategoryId; }
            set { _prod.CategoryId = value; }
        }
        public int? CountryId
        {
            get { return _prod.CountryId; }
            set { _prod.CountryId = value; }
        }
        public int? ClickCount
        {
            get { return _prod.ClickCount; }
            set { _prod.ClickCount = value; }
        }
        public bool TakeDown
        {
            get { return _prod.TakeDown; }
            set { _prod.TakeDown = value; }
        }
        public double? Star
        {
            get { return _prod.Star; }
            set { _prod.Star = value; }
        }
    }
}
