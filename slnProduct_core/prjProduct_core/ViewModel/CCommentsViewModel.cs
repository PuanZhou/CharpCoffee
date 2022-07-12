using prjProduct_core.Models;

namespace prjProduct_core.ViewModels
{
    public class CCommentsViewModel
    {
        public int CommentId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int MemberId { get; set; }
        public int? CommentParentId { get; set; }
        public string CommentDescription { get; set; }
        public double? Star { get; set; }

        public string MemberName { get; set; }

    }
}
