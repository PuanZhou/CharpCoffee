using System;
using System.Collections.Generic;

#nullable disable

namespace prjProduct_core.Models
{
    public partial class ArticleComment
    {
        public int ArticleCommentId { get; set; }
        public int? ArticleId { get; set; }
        public int? MemberId { get; set; }
        public int? ArticleCommentParentId { get; set; }
        public string ArticleCommentDescription { get; set; }
        public double? ArticleCommentStar { get; set; }

        public virtual Article Article { get; set; }
        public virtual Member Member { get; set; }
    }
}
