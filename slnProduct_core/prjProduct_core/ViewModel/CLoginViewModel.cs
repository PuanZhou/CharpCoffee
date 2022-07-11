using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prjCSCoffee.ViewModel
{
    public class CLoginViewModel
    {
        [Required]
        public string txtAccount { get; set; }
        [Required(ErrorMessage ="請填入正確的帳號或密碼")]
        public string txtPW { get; set; }
    }
}
