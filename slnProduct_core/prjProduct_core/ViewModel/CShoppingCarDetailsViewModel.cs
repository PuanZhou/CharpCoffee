using prjCSCoffee.Models;
using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjCSCoffee.ViewModel
{
    public class CShoppingCarDetailsViewModel
    {
        public CShoppingCarDetailsViewModel()
        {
            _detail = new ShoppingCarDetail();
            _prod = new Product();
        }
        private ShoppingCarDetail _detail;
        public ShoppingCarDetail carDetail
        {
            get { return _detail; }
            set { _detail = value; }
        }
        public int ShoppingCarDetialsId
        {
            get { return _detail.ShoppingCarDetialsId; }
            set { _detail.ShoppingCarDetialsId = value; }
        }
        public int MemberId
        {
            get { return _detail.MemberId; }
            set { _detail.MemberId = value; }
        }
        public int? ProductsId
        {
            get { return _detail.ProductsId; }
            set { _detail.ProductsId = value; }
        }
        public int? Quantity
        {
            get { return _detail.Quantity; }
            set { _detail.Quantity = value; }
        }
        public decimal? Price
        {
            get { return _detail.Price; }
            set { _detail.Price = value; }
        }
      


        private Product _prod;
        public Product product
        {
            get { return _prod; }
            set { _prod = value; }
        }
        //public decimal? ProPrice
        //{
        //    get { return _prod.Price; }
        //    set { _prod.Price = value; }
        //}
        public string ProName
        {
            get { return _prod.ProductName; }
            set { _prod.ProductName = value; }
        }

        public int? ProStock
        {
            get { return _prod.Stock; }
            set { _prod.Stock = value; }
        }

    }
}
