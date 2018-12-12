using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using khachhang.api.Models;

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
        

        public IActionResult dangnhap()
        {
            return View();
        }

        [HttpPost(Name = "Create a new one")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> dangnhap([Bind("TaiKhoan1,MatKhau")] Taikhoan taikhoan)
        {
            if (!apiAddress.Equals(client.BaseAddress))
            {
                GetAPI();
            }

            Taikhoan taiKhoanGetFromAPI = null;

            HttpResponseMessage respond = await client.GetAsync($"{path}/{taikhoan.TaiKhoan1}");

            if (respond.IsSuccessStatusCode)
            {
                // Gán dữ liệu API đọc được
                taiKhoanGetFromAPI = await respond.Content.ReadAsAsync<Taikhoan>();
                if (taikhoan.MatKhau == taiKhoanGetFromAPI.MatKhau)
                {
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