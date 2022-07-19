using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjProduct_core.ViewModel
{
    public class COrderViewModel
    {
        public int OrderId { get; set; }
        public int MemberId { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderStateId { get; set; }
        public int PaymentId { get; set; }
        public string OrderAddress { get; set; }
        public string OrderReceiver { get; set; }
        public string OrderPhone { get; set; }
        public int? CouponId { get; set; }
        public decimal? Fee { get; set; }
        public string TradeNo { get; set; }

        public string orderstatement { get; set; } //狀態
        public string payway { get; set; } //付款方式
        public string couponame { get; set; }  //折價券

    }
}
