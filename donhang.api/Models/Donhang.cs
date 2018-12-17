using System;
using System.Collections.Generic;

namespace donhang.api.Models
{
    public partial class Donhang
    {
        public string MaDh { get; set; }
        public DateTime? NgayTao { get; set; }
        public string TaiKhoan { get; set; }
        public string ShipMobile { get; set; }
        public string ShipAddress { get; set; }
        public decimal? TongTien { get; set; }
        public int? DaThanhToan { get; set; }
        public int? Status { get; set; }
    }
}
