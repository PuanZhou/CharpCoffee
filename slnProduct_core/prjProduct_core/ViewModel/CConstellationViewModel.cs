using prjCSCoffee.Models;
using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjProduct_core.ViewModel
{
    public class CConstellationViewModel
    {
        public CConstellationViewModel()//建構子
        {
            _con = new Constellation();
            _pro = new Product();
        }
        private Constellation _con;
        private Product _pro;
        public Product product
        {
            get { return _pro; }
            set { _pro = value; }
        }
        public int productID
        {
            get { return _pro.ProductId; }
            set { _pro.ProductId = value; }
        }
        public string productName
        {
            get { return _pro.ProductName; }
            set { _pro.ProductName = value; }
        }
        public Constellation constellation
        {
            get { return _con; }
            set { _con = value; }
        }
        public int ConstellationId
        {
            get { return _con.ConstellationId; }
            set { _con.ConstellationId = value; }
        }
        public string ConstellationName
        {
            get { return _con.ConstellationName; }
            set { _con.ConstellationName = value; }
        }
        public string ConstellationDescription
        {
            get { return _con.ConstellationDescription; }
            set { _con.ConstellationDescription = value; }
        }
        public string ConstellationDate
        {
            get { return _con.ConstellationDate; }
            set { _con.ConstellationDate = value; }
        }
        public int? ConstellationProductId
        {
            get { return _con.ConstellationProductId; }
            set { _con.ConstellationProductId = value; }
        }

    }
}
