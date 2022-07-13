using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjProduct_core.ViewModel
{
    public class CCouponDetailViewModel
    {
        public int CouponDetailsId { get; set; }
        public int MemberId { get; set; }
        public int CouponId { get; set; }
        public string couponName { get; set; }
        public decimal money { get; set; }
        public int condition { get; set; }
        public DateTime startDate { get; set; }
        public DateTime deadline { get; set; }
    }
}
