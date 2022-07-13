using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjCSCoffee.ViewModel
{
    public class CDeliveryViewModel
    {
        public string fReceiver { get; set; }
        public int payment { get; set; }
        public string fAddress { get; set; }
        public int fdiscount { get; set; }
        public string fPhone { get; set; }

        public int discountid { get; set; }

        public int discountmoney { get; set; }
    }
}

