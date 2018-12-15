using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using khachhang.api.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using sanpham.api.Models;

namespace QuanLiDoChoi.Controllers
{
    public class sanphamController : Controller
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


        public async Task<IActionResult> Detail(string id)
        {

            if(id == null)
            {
                ModelState.AddModelError("", "Chưa nhập mã sản phẩm");
                return RedirectToAction(nameof(Index));
            }
            else
            {
                Sanpham sanpham = null;

                HttpResponseMessage respond = await GetAPI("SanPhamUrl").GetAsync($"{pathSP}/{id}");

                if (respond.IsSuccessStatusCode)
                {
                    sanpham = await respond.Content.ReadAsAsync<Sanpham>();
                    return View(sanpham);
                }
                else
                {
                    ModelState.AddModelError("", "Không tìm được mã sản phẩm!");
                    return RedirectToAction(nameof(Index));
                }
            }

        }

        // GET: KhachHangs/Edit/5
        [HttpGet(Name = "Get an content to edit")]
        public async Task<IActionResult> Edit(string id)
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

        [ValidateAntiForgeryToken]
        [HttpPost(Name = "Update a content")]
        public async Task<IActionResult> Edit(Sanpham sanpham)
        {
           
            if (ModelState.IsValid)
            {
                HttpResponseMessage respond = await GetAPI("SanPhamUrl").PutAsJsonAsync($"{pathSP}/{sanpham.MaSp}", sanpham);
                respond.EnsureSuccessStatusCode();

                return RedirectToAction(nameof(Index));
            }

            return View(sanpham);
        }


    }
}