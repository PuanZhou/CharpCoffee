using System;
using System.Collections.Generic;

#nullable disable

namespace prjProduct_core.Models
{
    public partial class QuestionTable
    {
        public int QuestionTableId { get; set; }
        public string QuestionTableName { get; set; }
        public int? QuestionTableDetailsId { get; set; }
    }
}
