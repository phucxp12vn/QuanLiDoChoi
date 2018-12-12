using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace khachhang.api.Models
{
    public class TaikhoanDK : Taikhoan
    {
        [Required(ErrorMessage = "Vui lòng xác nhận mật khẩu")]
        [Compare("MatKhau", ErrorMessage = "Xác nhận mật khẩu không trùng khớp")]
        public string MatKhauXacNhan { get; set; }
    }
}
