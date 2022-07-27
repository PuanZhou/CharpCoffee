using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prjCSCoffee.Models
{
    public class CShoppingCartItem
    {
        public int productId { get; set; }

        [DisplayName("數量")]
        public int count { get; set; }

        [DisplayName("產品單價")]
        //[DisplayFormat(DataFormatString = "{0:C}")]
        public decimal price { get; set; }

        [DisplayName("小計")]
        //[DisplayFormat(DataFormatString = "{0:C}")]
        public decimal 小計 { get { return this.price * this.count; } }

        public int stock { get; set; }

        public string mainPhotoPath { get; set; }
        public int ShoppingCarDetialsId { get; set; }
        public Product product { get; set; }



        public string Receiver { get; set; }
        public string Phone { get; set; }
        public int Payment { get; set; }
        public string Paymentname { get; set; }
        public string Address { get; set; }
        public int Discount { get; set; }
        public int Fee { get; set; }
        public string MerchantTradeNo { get; set; }

        public List<Coupon> couponall { get; set; }

        
    }
}
