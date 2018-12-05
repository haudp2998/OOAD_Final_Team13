using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore_Final.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Vui lòng nhập email")]
        public string Email { set; get; }
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string matKhau { set; get; }
        public bool rememberMe { set; get; }
    }
}
