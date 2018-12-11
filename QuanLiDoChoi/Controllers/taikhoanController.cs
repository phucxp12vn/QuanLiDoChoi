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
    public class taikhoanController : Controller
    {
        //private readonly QL_TaiKhoanContext _context;
        static HttpClient client = new HttpClient();
        static readonly string address = Environment.GetEnvironmentVariable("KhachHangUrl").ToString();
        static Uri apiAddress = new Uri(address);

        static void GetAPI()
        {
            client.BaseAddress = apiAddress;
           // client.BaseAddress = new Uri("http://172.18.32.122/"); 

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }

        const string path = "api/taikhoans";

        //public taikhoanController(QL_TaiKhoanContext context)
        //{
        //    _context = context;
        //}

        public async Task<IActionResult> Index()
        {
            if (!apiAddress.Equals(client.BaseAddress))
            {
                GetAPI();
            }

            List<Taikhoan> taikhoan = new List<Taikhoan>();

            HttpResponseMessage respond = await client.GetAsync(path);

            if (respond.IsSuccessStatusCode)
            {
                // Gán dữ liệu API đọc được
                var taikhoanJsonString = await respond.Content.ReadAsStringAsync();

                var deserialized = JsonConvert.DeserializeObject<IEnumerable<Taikhoan>>(taikhoanJsonString);

                taikhoan = deserialized.ToList();
            }

            return View(taikhoan);
        }

    }
}