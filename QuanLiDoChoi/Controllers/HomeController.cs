using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using khachhang.api.Models;
using sanpham.api.Models;
using Microsoft.AspNetCore.Http;
using PagedList.Core;
using donhang.api.Models;
using QuanLiDoChoi.Models;

namespace QuanLiDoChoi.Controllers
{
    public class HomeController : Controller
    {


        static HttpClient GetAPI(string myChoice)
        {
             HttpClient client = new HttpClient();
             Uri apiAddress = new Uri(Environment.GetEnvironmentVariable(myChoice).ToString());
             client.BaseAddress = apiAddress;
             client.DefaultRequestHeaders.Accept.Clear();
             client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            return client;

        }

        const string pathKH = "api/taikhoans";
        const string pathSP = "api/sanphams";
        const string pathDH = "api/donhangs";
        const string pathCTDH = "api/chitietdonhangs";



        public async Task<IActionResult> Index()
        {


            List<Sanpham> sanpham = new List<Sanpham>();

            HttpResponseMessage respond = await GetAPI("SanPhamUrl").GetAsync(pathSP);

            if (respond.IsSuccessStatusCode)
            {
                // Gán dữ liệu API đọc được
                var taikhoanJsonString = await respond.Content.ReadAsStringAsync();

                var deserialized = JsonConvert.DeserializeObject<IEnumerable<Sanpham>>(taikhoanJsonString).Where(x => x.TrangThai == "1");

                sanpham = deserialized.ToList();
            }

            return View(sanpham);
        }

        [HttpGet(Name = "Get an detail of product")]
        public async Task<IActionResult> Product(string id)
        {
           
            Sanpham sanpham = null;

            HttpResponseMessage respond = await GetAPI("SanPhamUrl").GetAsync($"{pathSP}/{id}");

            if (respond.IsSuccessStatusCode)
            {
                // Gán dữ liệu API đọc được
                sanpham = await respond.Content.ReadAsAsync<Sanpham>();
            }

            return View(sanpham);
        }
        //Dang ky moi tai khoan
        public IActionResult dangky()
        {
            return View();
        }

        [HttpPost(Name = "Create a new one")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> dangky([Bind("TaiKhoan1,HoTen,MatKhau,MatKhauXacNhan,Email,GioiTinh,NgaySinh,Sdt,DiaChi")] TaikhoanDK taikhoan)
        {

            if (ModelState.IsValid)
            {
                HttpClient client = GetAPI("KhachHangUrl");
                HttpResponseMessage respond = await client.GetAsync($"{pathKH}/{taikhoan.TaiKhoan1}");

                if (respond.IsSuccessStatusCode)
                {
                    ModelState.AddModelError("", "Mã tài khoản đã được sử dụng!");
                }
                else
                {
                    taikhoan.Flag = 1;
                    taikhoan.Quyen = "2";
                    HttpResponseMessage result = await client.PostAsJsonAsync(pathKH, taikhoan);
                    result.EnsureSuccessStatusCode();

                    HttpContext.Session.SetString("userName", taikhoan.TaiKhoan1);
                    HttpContext.Session.SetString("power", taikhoan.Quyen);
                    return Redirect("/");
                }

            }
            else
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
                ModelState.AddModelError("", "Thông tin nhập vào không hợp lệ");
            }
            return View(taikhoan);
        }


        //Dang nhap tai khoan
        public IActionResult dangnhap()
        {
            return View();
        }

        [HttpPost(Name = "Sign in")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> dangnhap([Bind("TaiKhoan1,MatKhau")] Taikhoan taikhoan)
        {

            Taikhoan taiKhoanGetFromAPI = null;

            HttpResponseMessage respond = await GetAPI("KhachHangUrl").GetAsync($"{pathKH}/{taikhoan.TaiKhoan1}");
            if (respond.IsSuccessStatusCode)
            {
                // Gán dữ liệu API đọc đượcs
                taiKhoanGetFromAPI = await respond.Content.ReadAsAsync<Taikhoan>();
                if (taikhoan.MatKhau == taiKhoanGetFromAPI.MatKhau)
                {
                    HttpContext.Session.SetString("userName", taiKhoanGetFromAPI.TaiKhoan1);
                    HttpContext.Session.SetString("power", taiKhoanGetFromAPI.Quyen);
                    return Redirect("/");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không thành công");
                }
            }
            else
            {
                ModelState.AddModelError("", "Đăng nhập không thành công");
            }
            return View(taikhoan);
        }

        public IActionResult logout()
        {
            HttpContext.Session.SetString("userName", "");
            HttpContext.Session.SetString("power", "");
            return Redirect("/");
        }


        public async Task<IActionResult> DonHang(int page = 1)
        {
            var userName = HttpContext.Session.GetString("userName");
            if (userName != null && userName != "")
            {

                List<Donhang> donhang = new List<Donhang>();

                HttpResponseMessage respond = await GetAPI("DonHangUrl").GetAsync(pathDH);

                if (respond.IsSuccessStatusCode)
                {
                    // Gán dữ liệu API đọc được
                    var taikhoanJsonString = await respond.Content.ReadAsStringAsync();

                    var deserialized = JsonConvert.DeserializeObject<IEnumerable<Donhang>>(taikhoanJsonString).Where(x => x.Status == 1 & x.TaiKhoan == userName).OrderByDescending(x => x.MaDh);

                    donhang = deserialized.ToList();

                }

                return View(donhang.AsQueryable().ToPagedList(page, 5));
            }
            else
            {
                return RedirectToAction("dangnhap", "home", "");
            }
        }


        public async Task<IActionResult> ChiTietDonHang(string id)
        {

            if (id == null)
            {
                ModelState.AddModelError("", "Chưa nhập mã đơn hàng");
                return RedirectToAction("DonHang");
            }
            else
            {

                List<Chitietdonhang> chitietdonhang = new List<Chitietdonhang>();

                HttpResponseMessage respond = await GetAPI("DonHangUrl").GetAsync(pathCTDH);

                if (respond.IsSuccessStatusCode)
                {
                    // Gán dữ liệu API đọc được
                    var taikhoanJsonString = await respond.Content.ReadAsStringAsync();

                    var deserialized = JsonConvert.DeserializeObject<IEnumerable<Chitietdonhang>>(taikhoanJsonString).Where(x => x.MaDh == id);
                    chitietdonhang = deserialized.ToList();
                    List<CartItem> listSanPham = await chuyenThanhListSPAsync(chitietdonhang);
                    return View(listSanPham);
                }
                else
                {
                    ModelState.AddModelError("", "Không tìm được mã đơn hàng!");
                    return RedirectToAction("DonHang");
                }
            }
        }

        private async Task<List<CartItem>> chuyenThanhListSPAsync(List<Chitietdonhang> chitietdonhang)
        {
            List<CartItem> result = new List<CartItem>();
            foreach (var item in chitietdonhang)
            {
                Sanpham sanpham = null;
                HttpResponseMessage respond = await GetAPI("SanPhamUrl").GetAsync($"{pathSP}/{item.MaSp}");
                if (respond.IsSuccessStatusCode)
                {
                    sanpham = await respond.Content.ReadAsAsync<Sanpham>();
                    CartItem newItem = new CartItem();
                    newItem.SP = sanpham;
                    newItem.SoLuong = (int)item.SoLuong;
                    result.Add(newItem);
                }
                else
                {
                    return result;
                }
            }
            return result;
        }

        public async Task<IActionResult> Cancel(string id)
        {
            HttpClient client = GetAPI("DonHangUrl");
            HttpResponseMessage respond = await client.GetAsync($"{pathDH}/{id}");

            if (!respond.IsSuccessStatusCode)
            {
                ModelState.AddModelError("", "Hủy đơn hàng thất bại!");
            }
            else
            {
                Donhang donhang = await respond.Content.ReadAsAsync<Donhang>();
                List<Chitietdonhang> chitietdonhang = GetChiTietDonHangAsync(donhang.MaDh).GetAwaiter().GetResult();
                foreach (var item in chitietdonhang)
                {
                    Sanpham sanpham = GetSanphamAsync(item.MaSp).GetAwaiter().GetResult();
                    CapNhatSLSanPhamAsync(sanpham, (int)item.SoLuong);
                    item.Status = 0;
                    capNhatChiTietDonHangAsync(item);
                }
                donhang.Status = 0;
                capNhatDonHangAsync(donhang);
            }

            return RedirectToAction("DonHang", "Home");
        }


        public async Task<List<Chitietdonhang>> GetChiTietDonHangAsync(string MaDH)
        {
            List<Chitietdonhang> chitietdonhang = new List<Chitietdonhang>();

            HttpResponseMessage respond = await GetAPI("DonHangUrl").GetAsync(pathCTDH);

            if (respond.IsSuccessStatusCode)
            {
                // Gán dữ liệu API đọc được
                var taikhoanJsonString = await respond.Content.ReadAsStringAsync();

                var deserialized = JsonConvert.DeserializeObject<IEnumerable<Chitietdonhang>>(taikhoanJsonString).Where(x => x.MaDh == MaDH);
                chitietdonhang = deserialized.ToList();
                return chitietdonhang;
            }
            else
            {
                return null;
            }
        }

        public async void CapNhatSLSanPhamAsync(Sanpham sanpham, int SoLuong)
        {
            sanpham.SoLuongTon += SoLuong;
            HttpResponseMessage respond = await GetAPI("SanPhamUrl").PutAsJsonAsync($"{pathSP}/{sanpham.MaSp}", sanpham);
            respond.EnsureSuccessStatusCode();
        }

        public async void capNhatDonHangAsync(Donhang donhang)
        {
            HttpResponseMessage respond = await GetAPI("DonHangUrl").PutAsJsonAsync($"{pathDH}/{donhang.MaDh}", donhang);
            respond.EnsureSuccessStatusCode();
        }

        public async void capNhatChiTietDonHangAsync(Chitietdonhang ctdh)
        {
            HttpResponseMessage respond = await GetAPI("DonHangUrl").PutAsJsonAsync($"{pathCTDH}/{ctdh.MaDh}&&{ctdh.MaSp}", ctdh);
            respond.EnsureSuccessStatusCode();
        }


        public async Task<Sanpham> GetSanphamAsync(string MaSp)
        {
            Sanpham sanpham = null;

            HttpResponseMessage respond = await GetAPI("SanPhamUrl").GetAsync($"{pathSP}/{MaSp}");

            if (respond.IsSuccessStatusCode)
            {
                sanpham = await respond.Content.ReadAsAsync<Sanpham>();
            }

            return sanpham;
        }
    }
}