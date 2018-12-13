using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using khachhang.api.Models;
using Microsoft.AspNetCore.Http;
using QuanLiDoChoi.Common;

namespace QuanLiDoChoi.Controllers
{
    public class HomeController : Controller
    {
        //private readonly QL_TaiKhoanContext _context;
        static HttpClient client = new HttpClient();
        static readonly string address = Environment.GetEnvironmentVariable("KhachHangUrl").ToString();
        static Uri apiAddress = new Uri(address);

        static void GetAPI()
        {
            client.BaseAddress = apiAddress;
            //client.BaseAddress = new Uri("http://172.18.32.122/"); 

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }

        const string path = "api/taikhoans";



        public IActionResult Index()
        {
           
            return View();
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
            if (!apiAddress.Equals(client.BaseAddress))
            {
                GetAPI();
            }
            if (ModelState.IsValid)
            {
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

                    return RedirectToAction(nameof(Index));
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
            if (!apiAddress.Equals(client.BaseAddress))
            {
                GetAPI();
            }

            Taikhoan taiKhoanGetFromAPI = null;

            HttpResponseMessage respond = await client.GetAsync($"{path}/{taikhoan.TaiKhoan1}");
            ViewBag.Name = HttpContext.Session.GetString("abc");


            if (respond.IsSuccessStatusCode)
            {
                // Gán dữ liệu API đọc được
                taiKhoanGetFromAPI = await respond.Content.ReadAsAsync<Taikhoan>();
                if (taikhoan.MatKhau == taiKhoanGetFromAPI.MatKhau)
                {
                    //var userSession = new userLogin();
                    //userSession.TaiKhoan1 = taikhoan.TaiKhoan1;
                    //userSession.Quyen = taikhoan.Quyen;
                    //HttpContext.Session.SetString(CommonConstants.USER_SESSION, userSession);
                    HttpContext.Session.SetString("userName", taikhoan.TaiKhoan1);
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



    }
}