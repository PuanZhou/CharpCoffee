﻿using System;
using System.Collections.Generic;

#nullable disable

namespace prjProduct_core.Models
{
    public partial class HeldCoupon
    {
        public int HeldCouponId { get; set; }
        public int MemberId { get; set; }
        public int CouponId { get; set; }

        public virtual Coupon Coupon { get; set; }
        public virtual Member Member { get; set; }
    }
}
