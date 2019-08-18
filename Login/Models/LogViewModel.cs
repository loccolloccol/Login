using Login.Infrastructure.Attribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class LogViewModel
    {
        [Required(ErrorMessage ="請輸入帳號")]
        [Display(Name = "帳號")]
        [StringLength(maximumLength:20,MinimumLength =6)]
        public string Account { get; set; }


        [Required(ErrorMessage = "請輸入密碼")]
        [Display(Name = "密碼")]
        [StringLength(maximumLength: 20, MinimumLength = 6)]
        public string Password { get; set; }

        [Display(Name ="驗證碼")]
        [ValidCaptialCode(ErrorMessage = "驗證錯誤")]
        public string CapitalCode { get; set; }
    }
}