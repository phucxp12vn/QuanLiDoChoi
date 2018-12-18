using sanpham.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLiDoChoi.Models
{
    [Serializable]
    public class CartItem
    {
        public Sanpham SP { set; get; }
        public int SoLuong { set; get; }
    }
}
