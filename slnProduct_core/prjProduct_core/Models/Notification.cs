using System;
using System.Collections.Generic;

#nullable disable

namespace prjProduct_core.Models
{
    public partial class Notification
    {
        public int NotificationId { get; set; }
        public int MemberId { get; set; }
        public DateTime NotifyTime { get; set; }
        public int OrderStateId { get; set; }
        public string TradeNo { get; set; }

        public virtual Member Member { get; set; }
        public virtual OrderState OrderState { get; set; }
        public virtual Order TradeNoNavigation { get; set; }
    }
}
