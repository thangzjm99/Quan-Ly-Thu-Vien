using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QLThuVienMTA.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Mời bạn điền tên đăng nhập!")]
        public string UserName { set; get; }
        [Required(ErrorMessage = "Mời bạn điền password!")]
        public string password { set; get; }
        public bool RememberMe { set; get; }
         
    }
}