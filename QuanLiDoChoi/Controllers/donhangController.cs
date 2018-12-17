using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using donhang.api.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PagedList.Core;

namespace QuanLiDoChoi.Controllers
{
    public class donhangController : Controller
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

        public async Task<IActionResult> Index(int page = 1)
        {


            List<Donhang> donhang = new List<Donhang>();

            HttpResponseMessage respond = await GetAPI("DonHangUrl").GetAsync(pathDH);

            if (respond.IsSuccessStatusCode)
            {
                // Gán dữ liệu API đọc được
                var taikhoanJsonString = await respond.Content.ReadAsStringAsync();

                var deserialized = JsonConvert.DeserializeObject<IEnumerable<Donhang>>(taikhoanJsonString).Where(x => x.Status == 1);

                donhang = deserialized.ToList();

            }

            return View(donhang.AsQueryable().ToPagedList(page, 5));
        }


        public async Task<IActionResult> Detail(string id)
        {

            if (id == null)
            {
                ModelState.AddModelError("", "Chưa nhập mã đơn hàng");
                return RedirectToAction(nameof(Index));
            }
            else
            {

                List<Chitietdonhang> chitietdonhang = new List<Chitietdonhang>();

                HttpResponseMessage respond = await GetAPI("DonHangUrl").GetAsync(pathCTDH);

                if (respond.IsSuccessStatusCode)
                {
                    // Gán dữ liệu API đọc được
                    var taikhoanJsonString = await respond.Content.ReadAsStringAsync();

                    var deserialized = JsonConvert.DeserializeObject<IEnumerable<Chitietdonhang>>(taikhoanJsonString).Where(x=>x.MaDh == id);
                    chitietdonhang = deserialized.ToList();
                    return View(chitietdonhang);
                }
                else
                {
                    ModelState.AddModelError("", "Không tìm được mã sản phẩm!");
                    return RedirectToAction(nameof(Index));
                }
            }
        }

        public async Task<IActionResult> ThanhToan(string id)
        {
            HttpClient client = GetAPI("DonHangUrl");
            HttpResponseMessage respond = await client.GetAsync($"{pathDH}/{id}");

            if (!respond.IsSuccessStatusCode)
            {
                ModelState.AddModelError("", "Mã đơn hàng không tồn tại!");
            }
            else
            {
                Donhang donhang = await respond.Content.ReadAsAsync<Donhang>();
                donhang.DaThanhToan = 1;
                HttpResponseMessage result = await client.PutAsJsonAsync($"{pathDH}/{id}", donhang);
                if (!result.IsSuccessStatusCode)
                {
                    ModelState.AddModelError("", "Quá trình thanh toán đã thất bại!");
                }
            }

            return RedirectToAction("Index");
        }


    }
}