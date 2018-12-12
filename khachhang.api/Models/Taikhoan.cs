using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace khachhang.api.Models
{
    public partial class Taikhoan
    {
        public string TaiKhoan1 { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập mật khẩu"), StringLength(10, MinimumLength = 6,ErrorMessage ="Mật khẩu phải có ít nhất 6 kí tự")]
        public string MatKhau { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Email không xác thực")]
        public string Email { get; set; }
        public string Quyen { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên")]
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }

        [RegularExpression("^[0-9]{1,12}$", ErrorMessage = "Vui lòng nhập số"), StringLength(11, MinimumLength = 10,ErrorMessage ="Số điện thoại có ít nhất 10 số.")]
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public int? Flag { get; set; }
    }
}
