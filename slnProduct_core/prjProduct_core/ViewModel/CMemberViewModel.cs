using Microsoft.AspNetCore.Http;
using prjCSCoffee.Models;
using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prjCSCoffee.ViewModel
{
    public class CMemberViewModel
    {

        Member _mem;

        public CMemberViewModel()
        {
            _mem = new Member();
        }

        public Member member
        {
            get { return _mem; }
            set { _mem = value; }
        }


        [DisplayName("手機號碼")]
        [Required(ErrorMessage = "不可為空")]
        [RegularExpression(@"^[0]{1}[9]{1}[0-9]{8}$", ErrorMessage = "手機格式有誤")]
        public string MemberPhone
        {
            get { return _mem.MemberPhone; }
            set { _mem.MemberPhone = value; }
        }

        public int MemberId
        {
            get { return _mem.MemberId; }
            set { _mem.MemberId = value; }
        }

        public int ShoppingCarId
        {
            get { return _mem.ShoppingCarId; }
            set { _mem.ShoppingCarId = value; }
        }

        [DisplayName("電子郵件")]
        [Required(ErrorMessage = "不可為空")]
        [StringLength(50, ErrorMessage = "不得超過50字元")]
        [EmailAddress(ErrorMessage = "Email格式有誤")]
        public string MemberEmail
        {
            get { return _mem.MemberEmail; }
            set { _mem.MemberEmail = value; }
        }

        [DisplayName("密碼")]
        [Required(ErrorMessage = "不可為空")]
        [RegularExpression(@"^[a-zA-Z0-9]{8,50}$", ErrorMessage = "密碼格式有誤")]
        public string MemberPassword
        {
            get { return _mem.MemberPassword; }
            set { _mem.MemberPassword = value; }
        }

        [Required(ErrorMessage = "不可為空")]
        [Compare("MemberPassword", ErrorMessage = "密碼不相符")]
        public string checkPW { get; set; }

        [DisplayName("地址")]
        [Required(ErrorMessage = "不可為空")]
        public string MemberAddress
        {
            get { return _mem.MemberAddress; }
            set { _mem.MemberAddress = value; }
        }

        [DisplayName("姓名")]
        [Required(ErrorMessage = "不可為空")]
        public string MemberName
        {
            get { return _mem.MemberName; }
            set { _mem.MemberName = value; }
        }

        [DisplayName("生日")]
        [Required(ErrorMessage = "不可為空")]
        public DateTime MemberBirthDay
        {
            get { return _mem.MemberBirthDay; }
            set { _mem.MemberBirthDay = value; }
        }

        public string MemberPhotoPath
        {
            get { return _mem.MemberPhotoPath; }
            set { _mem.MemberPhotoPath = value; }
        }

        public bool BlackList
        {
            get { return _mem.BlackList; }
            set { _mem.BlackList = value; }
        }

        public IFormFile photo { get; set; }
    }
}
