using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prjProduct_core.ViewModel
{
    public class CCouponViewModel
    {

        public int CouponId { get; set; }


        
        [Required(ErrorMessage ="不得為空")]
        [DisplayName("優惠券名稱")]
        public string CouponName { get; set; }


        [DisplayName("折抵金額")]
        [Required(ErrorMessage = "不得為空")]
        public decimal Money { get; set; }


        [DisplayName("折抵條件")]
        [Required(ErrorMessage = "不得為空")]
        public int Condition { get; set; }


        [DataType(DataType.Date)]
        [DisplayName("起始日期")]
        public DateTime? CouponStartDate { get; set; }


        [DataType(DataType.Date)]
        [DisplayName("結束日期")]
        public DateTime? CouponDeadline { get; set; }

        public virtual ICollection<CouponDetail> CouponDetails { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
