using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjProduct_core.ViewModel
{
    public class CMyLikeViewModel
    {

        public Product _product;
        public CMyLikeViewModel()
        {
            _product = new Product();
        }
        public Product Products
        {
            get { return _product; }
            set { _product = value; }
        }


        public int LikeId { get; set; }
        public int MemberId { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string productname { get; set; }
        public decimal? price { get; set; }
        public string MainPhotoPath { get; set; }


    }
}
