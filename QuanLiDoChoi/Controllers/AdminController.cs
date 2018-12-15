using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using khachhang.api.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace QuanLiDoChoi.Controllers
{
    public class AdminController : Controller
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

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> TaiKhoan()
        {


            List<Taikhoan> taikhoan = new List<Taikhoan>();

            HttpResponseMessage respond = await GetAPI("KhachHangUrl").GetAsync(pathKH);

            if (respond.IsSuccessStatusCode)
            {
                // Gán dữ liệu API đọc được
                var taikhoanJsonString = await respond.Content.ReadAsStringAsync();

                var deserialized = JsonConvert.DeserializeObject<IEnumerable<Taikhoan>>(taikhoanJsonString).Where(x => x.Flag == 1);

                //taikhoan = (List<Taikhoan>)deserialized.ToList().Where(x=> x.Flag == 1);
                taikhoan = deserialized.ToList();

            }

            return View(taikhoan);
        }



        public async Task<IActionResult> TaiKhoanDelete(string id)
        {
            HttpClient client = GetAPI("KhachHangUrl");
            HttpResponseMessage respond = await client.GetAsync($"{pathKH}/{id}");

            if (!respond.IsSuccessStatusCode)
            {
                ModelState.AddModelError("", "Mã tài khoản không tồn tại!");
            }
            else
            {
                Taikhoan taikhoan = await respond.Content.ReadAsAsync<Taikhoan>();
                taikhoan.Flag = 0;
                HttpResponseMessage result = await client.PutAsJsonAsync($"{pathKH}/{id}",taikhoan);
                if (!result.IsSuccessStatusCode)
                {
                    ModelState.AddModelError("", "Quá trình xóa đã thất bại!");
                }
            }

            return RedirectToAction("TaiKhoan");
        }

    }
}