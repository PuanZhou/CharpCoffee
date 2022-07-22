using System;
using System.Collections.Generic;

#nullable disable

namespace prjProduct_core.Models
{
    public partial class Article
    {
        public Article()
        {
            ArticleComments = new HashSet<ArticleComment>();
        }

        public int ArticleId { get; set; }
        public string ArticleName { get; set; }
        public string ArticleDescription { get; set; }
        public string ArticleImage { get; set; }
        public DateTime? ArticleDate { get; set; }

        public virtual ICollection<ArticleComment> ArticleComments { get; set; }
    }
}
