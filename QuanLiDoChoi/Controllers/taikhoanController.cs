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
          //client.BaseAddress = new Uri("http://172.18.32.122/"); 

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
        [HttpGet(Name = "Get an detail")]
        public async Task<IActionResult> Details(string id)
        {
            if (!apiAddress.Equals(client.BaseAddress))
            {
                GetAPI();
            }

            Taikhoan taikhoan = null;

            HttpResponseMessage respond = await client.GetAsync($"{path}/{id}");

            if (respond.IsSuccessStatusCode)
            {
                // Gán dữ liệu API đọc được
                taikhoan = await respond.Content.ReadAsAsync<Taikhoan>();
            }

            return View(taikhoan);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost(Name = "Create a new one")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TaiKhoan1,HoTen,GioiTinh,NgaySinh,Sdt,DiaChi")] Taikhoan taikhoan)
        {
            if (!apiAddress.Equals(client.BaseAddress))
            {
                GetAPI();
            }

            if (ModelState.IsValid)
            {
                taikhoan.MatKhau = "fsdafsafsa";

                HttpResponseMessage respond = await client.PostAsJsonAsync(path, taikhoan);
                respond.EnsureSuccessStatusCode();

                return RedirectToAction(nameof(Index));
            }

            return View(taikhoan);
        }

        // GET: KhachHangs/Edit/5
        [HttpGet(Name = "Get an content to edit")]
        public async Task<IActionResult> Edit(string id)
        {
            if (!apiAddress.Equals(client.BaseAddress))
            {
                GetAPI();
            }

            Taikhoan taikhoan = null;

            HttpResponseMessage respond = await client.GetAsync($"{path}/{id}");

            if (respond.IsSuccessStatusCode)
            {
                // Gán dữ liệu API đọc được
                taikhoan = await respond.Content.ReadAsAsync<Taikhoan>();
            }

            return View(taikhoan);
        }

        [ValidateAntiForgeryToken]
        [HttpPost(Name = "Update a content")]
        public async Task<IActionResult> Edit(string id, [Bind("TaiKhoan1,HoTen,GioiTinh,NgaySinh,Sdt,DiaChi")] Taikhoan taikhoan)
        {
            if (!apiAddress.Equals(client.BaseAddress))
            {
                GetAPI();
            }

            if (ModelState.IsValid)
            {
                taikhoan.MatKhau = "fsdafsafsa";
                HttpResponseMessage respond = await client.PutAsJsonAsync($"{path}/{id}", taikhoan);
                respond.EnsureSuccessStatusCode();

                return RedirectToAction(nameof(Index));
            }

            return View(taikhoan);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string TaiKhoan1)
        {
            if (!apiAddress.Equals(client.BaseAddress))
            {
                GetAPI();
            }

            HttpResponseMessage respond = await client.DeleteAsync($"{path}/{TaiKhoan1}");

            return RedirectToAction(nameof(Index));
        }
    }
}