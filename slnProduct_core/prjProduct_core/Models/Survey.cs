using System;
using System.Collections.Generic;

#nullable disable

namespace prjProduct_core.Models
{
    public partial class Survey
    {
        public int SurveyId { get; set; }
        public string TradeNo { get; set; }

        public virtual Order TradeNoNavigation { get; set; }
    }
}
