using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjProduct_core.ViewModel
{
    public class CArticleCommentViewModel
    {
        public int ArticleCommentId { get; set; }
        public int? ArticleId { get; set; }
        public int? MemberId { get; set; }
        public int? ArticleCommentParentId { get; set; }
        public string ArticleCommentDescription { get; set; }
        public double? ArticleCommentStar { get; set; }
        public string MemberName { get; set; }
    }
}
