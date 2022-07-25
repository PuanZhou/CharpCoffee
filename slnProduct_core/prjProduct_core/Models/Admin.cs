using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace prjProduct_core.Models
{
    public partial class Admin
    {
        public int AdminId { get; set; }
        [DisplayName("信箱帳號")]
        public string Email { get; set; }
        [DisplayName("密碼")]
        public string Password { get; set; }
        [DisplayName("是否可以修改產品")]
        public bool ProductOk { get; set; }
        [DisplayName("是否可以修改訂單")]
        public bool OrderOk { get; set; }
        [DisplayName("是否可以修改會員")]
        public bool MemberOk { get; set; }
        [DisplayName("是否可以修改文章")]
        public bool ArticleOk { get; set; }
        
        public bool AdminOk { get; set; }
    }
}
