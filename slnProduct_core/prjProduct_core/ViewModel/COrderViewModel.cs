using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjProduct_core.ViewModel
{
    public class COrderViewModel
    {
        //OrderState _ordstat;
        //Payment _payment;
        //Coupon _coupon;

        //public COrderViewModel()
        //{
        //    _ordstat = new OrderState();
        //    _payment = new Payment();
        //    _coupon = new Coupon();
        //}

        //public OrderState orderState
        //{
        //    get { return _ordstat ; }
        //    set { _ordstat = value; }
        //}

        //public Payment payment
        //{
        //    get { return _payment; }
        //    set { _payment = value; }
        //}


        public int OrderId { get; set; }
        public int MemberId { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderStateId { get; set; }
        public int PaymentId { get; set; }
        public string OrderAddress { get; set; }
        public string OrderReceiver { get; set; }
        public string OrderPhone { get; set; }
        public int? CouponId { get; set; }

        public string orderstatement { get; set; } //狀態
        public string payway { get; set; } //付款方式
        public string couponame { get; set; }  //折價券


        public virtual Member Member { get; set; }
        public virtual OrderState OrderState { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
