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
        public Product product { get; set; }



        public string Receiver { get; set; }
        public string phone { get; set; }
        public int payment { get; set; }
        public string paymentname { get; set; }
        public string Address { get; set; }
        public int discount { get; set; }


        public List<Coupon> couponall { get; set; }

        
    }
}
