using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLiDoChoi.Models;
using sanpham.api.Models;

namespace QuanLiDoChoi.Controllers
{
    public class CartController : Controller
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
        private const string CartSession = "cartSession";

        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetComplexData<List<CartItem>>(CartSession);
            if (cart != null)
            {              
                return View(cart);
            }
            return View();
        }

        public async Task<Sanpham> GetSanPhamAsync(string MaSp)
        {
            Sanpham sanpham = null;

            HttpResponseMessage respond = await GetAPI("SanPhamUrl").GetAsync($"{pathSP}/{MaSp}");

            if (respond.IsSuccessStatusCode)
            {
                sanpham = await respond.Content.ReadAsAsync<Sanpham>();
                return sanpham;
            }
            else
            {
                return null;
            }
        }


        public ActionResult AddItem(string MaSp)
        {
            int SoLuong = 1;
            var cart = HttpContext.Session.GetComplexData<List<CartItem>>(CartSession);
            if (cart != null)
            {
                if (cart.Exists(x => x.SP.MaSp == MaSp))
                {
                    foreach (var item in cart)
                    {
                        if (item.SP.MaSp == MaSp) item.SoLuong += SoLuong;
                    }
                }
                else
                {
                    var item = new CartItem();
                    item.SP =(Sanpham)GetSanPhamAsync(MaSp).GetAwaiter().GetResult();
                    item.SoLuong = SoLuong;
                    cart.Add(item);
                }
                HttpContext.Session.SetComplexData(CartSession, cart);

            }
            else
            {
                var item = new CartItem();
                item.SP = (Sanpham)GetSanPhamAsync(MaSp).GetAwaiter().GetResult();               
                item.SoLuong = SoLuong;
                var list = new List<CartItem>();
                list.Add(item);
                HttpContext.Session.SetComplexData(CartSession, list);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}