using System;
using System.Collections.Generic;

#nullable disable

namespace prjProduct_core.Models
{
    public partial class OrderState
    {
        public OrderState()
        {
            Notifications = new HashSet<Notification>();
            Orders = new HashSet<Order>();
        }

        public int OrderStateId { get; set; }
        public string OrderState1 { get; set; }

        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
