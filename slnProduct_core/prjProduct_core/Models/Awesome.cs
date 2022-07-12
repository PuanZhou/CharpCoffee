using System;
using System.Collections.Generic;

#nullable disable

namespace prjProduct_core.Models
{
    public partial class Awesome
    {
        public int AwesomeId { get; set; }
        public int CommentId { get; set; }
        public int MemberId { get; set; }

        public virtual Comment Comment { get; set; }
    }
}
