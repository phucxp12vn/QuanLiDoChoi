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


namespace QuanLiDoChoi.Controllers
{
    public class HomeController : Controller
    {
        //private readonly QL_TaiKhoanContext _context;
        //static readonly string address = Environment.GetEnvironmentVariable("KhachHangUrl").ToString();
        //static Uri apiAddress = new Uri(address);
        //static readonly string address1 = Environment.GetEnvironmentVariable("SanPhamUrl").ToString();
        //static Uri apiAddress1 = new Uri(address1);

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

        const string path = "api/taikhoans";
        const string path1 = "api/sanphams";



        public async Task<IActionResult> Index()
        {


            List<Sanpham> sanpham = new List<Sanpham>();

            HttpResponseMessage respond = await GetAPI("SanPhamUrl").GetAsync(path1);

            if (respond.IsSuccessStatusCode)
            {
                // Gán dữ liệu API đọc được
                var taikhoanJsonString = await respond.Content.ReadAsStringAsync();

                var deserialized = JsonConvert.DeserializeObject<IEnumerable<Sanpham>>(taikhoanJsonString);

                sanpham = deserialized.ToList();
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
                HttpResponseMessage respond = await client.GetAsync($"{path}/{taikhoan.TaiKhoan1}");

                if (respond.IsSuccessStatusCode)
                {
                    ModelState.AddModelError("", "Mã tài khoản đã được sử dụng!");
                }
                else
                {
                    taikhoan.Flag = 1;
                    taikhoan.Quyen = "2";
                    HttpResponseMessage result = await client.PostAsJsonAsync(path, taikhoan);
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

            HttpResponseMessage respond = await GetAPI("KhachHangUrl").GetAsync($"{path}/{taikhoan.TaiKhoan1}");
            ViewBag.Name = HttpContext.Session.GetString("abc");


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

    }
}