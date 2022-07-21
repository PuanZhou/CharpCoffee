using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjProduct_core.ViewModel
{
    public class CAdmin_MemberDetailsViewModel
    {
        public CAdmin_MemberViewModel member { get; set; }
        public List<CAdmin_OrderViewModel> order { get; set; }
    }
}
