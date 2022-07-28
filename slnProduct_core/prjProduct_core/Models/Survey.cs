using System;
using System.Collections.Generic;

#nullable disable

namespace prjProduct_core.Models
{
    public partial class Survey
    {
        public int SurveyId { get; set; }
        public string TradeNo { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }
    }
}
