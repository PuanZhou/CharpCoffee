using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjProduct_core.ViewModel
{
    public class CNotificationViewModel
    {
        OrderState _ordst;
       public CNotificationViewModel()
        {
            _ordst = new OrderState();
        }

        public OrderState orderstate
        {
            get { return _ordst; }
            set { _ordst = value; }
        }

        public int NotificationId { get; set; }
        public int MemberId { get; set; }
        public DateTime NotifyTime { get; set; }
        public int OrderStateId { get; set; }
        public string TradeNo { get; set; }
        public string statement { get; set; }

    }
}
