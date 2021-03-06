﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using donhang.api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
        const string pathDH = "api/donhangs";
        const string pathCTDH = "api/chitietdonhangs";
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
                    item.SP = GetSanPhamAsync(MaSp).GetAwaiter().GetResult();
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

        public JsonResult Update(string id)
        {
            //JsonConvert.DeserializeObject<IEnumerable<Sanpham>>(taikhoanJsonString);
            var listSession = JsonConvert.DeserializeObject<List<CartItem>>(id);
            var Sessioncart = HttpContext.Session.GetComplexData<List<CartItem>>(CartSession);
            foreach (var item in Sessioncart)
            {
                var jsonItem = listSession.SingleOrDefault(x => x.SP.MaSp == item.SP.MaSp);
                if(jsonItem != null)
                {
                    Sanpham sanpham = GetSanphamAsync(item.SP.MaSp).GetAwaiter().GetResult();
                    if(sanpham.SoLuongTon >= jsonItem.SoLuong)
                    {
                        item.SoLuong = jsonItem.SoLuong;
                    }
                    else
                    {
                        return Json(new
                        {
                            status = false
                        });
                    }

                }
            }
            HttpContext.Session.SetComplexData(CartSession, Sessioncart);
            return Json(new
            {
                status = true
            });
        }

        public JsonResult DeleteAll()
        {
            HttpContext.Session.Remove(CartSession);

            return Json(new {
                status = true
            });
        }

        public JsonResult Delete(string id)
        {
            var cart = HttpContext.Session.GetComplexData<List<CartItem>>(CartSession);
            cart.RemoveAll(x => x.SP.MaSp == id);
            HttpContext.Session.SetComplexData(CartSession, cart);
            return Json(new
            {
                status = true
            });
        }
         
        [HttpGet]
        public IActionResult Payment()
        {
            var cart = HttpContext.Session.GetComplexData<List<CartItem>>(CartSession);
            var userName = HttpContext.Session.GetString("userName");
            if(userName != null && userName != "")
            {
                if (cart != null)
                {
                    return View(cart);
                }
                else return View();
            }
            else
            {
                return RedirectToAction("dangnhap", "home", "");
            }
            
            
        }

        [HttpPost]
        public IActionResult Payment(string mobile, string address, string email)
        {
            var userName = HttpContext.Session.GetString("userName");
            if (userName != null && userName != "")
            {
                Donhang donhang = new Donhang();
                donhang.NgayTao = DateTime.Now;
                donhang.ShipAddress = address;
                donhang.ShipMobile = mobile;
                var maDh = GetMaDHAsync().GetAwaiter().GetResult();
                donhang.MaDh = maDh;
                donhang.Status = 1;
                donhang.TaiKhoan = userName;
                donhang.DaThanhToan = 0;
                //Xong tao chi tiet don hang
                int TongTien = 0;
                var cart = HttpContext.Session.GetComplexData<List<CartItem>>(CartSession);
                foreach(var item in cart)
                {
                    //Kiem tra so luong trc khi them don hang
                    Sanpham sanpham = GetSanphamAsync(item.SP.MaSp).GetAwaiter().GetResult();
                    if (sanpham.SoLuongTon >= item.SoLuong)
                    {
                        Chitietdonhang chitetdh = new Chitietdonhang();
                        chitetdh.MaDh = maDh;
                        chitetdh.MaSp = item.SP.MaSp;
                        chitetdh.SoLuong = item.SoLuong;
                        chitetdh.ThanhTien = item.SP.GiaBanLe * item.SoLuong;
                        chitetdh.Status = 1;
                        TongTien += (int)chitetdh.ThanhTien;
                        taoChiTietDHAsync(chitetdh);
                        CapNhatSLSanPhamAsync(sanpham, item.SoLuong);

                    }
                    else
                    {
                        ModelState.AddModelError("", "Sản phần không đủ số lượng!");
                    }

                }

                donhang.TongTien = TongTien;
                taoDonHangAsync(donhang);
                HttpContext.Session.Remove(CartSession);
            }
            else
            {
                return RedirectToAction("dangnhap","home","");
            }

            return RedirectToAction("ThanhCong");
        }

        private async Task<string> GetMaDHAsync()
        {

            HttpResponseMessage respond = await GetAPI("DonHangUrl").GetAsync(pathDH);

            if (respond.IsSuccessStatusCode)
            {
                // Gán dữ liệu API đọc được
                var taikhoanJsonString = await respond.Content.ReadAsStringAsync();

                var count = JsonConvert.DeserializeObject<IEnumerable<Donhang>>(taikhoanJsonString).Count();

                if (count < 9) return "DH00" + ++count;
                else if (count < 99) return "DH0" + ++count;
                else return "DH" + ++count;
            }
            else return null;
            
        }


        public async void taoDonHangAsync(Donhang donhang)
        {

                HttpResponseMessage respond = await GetAPI("DonHangUrl").PostAsJsonAsync(pathDH, donhang);
                respond.EnsureSuccessStatusCode();   
        }

        public async void capNhatDonHangAsync(Donhang donhang)
        {
            HttpResponseMessage respond = await GetAPI("DonHangUrl").PutAsJsonAsync($"{pathDH}/{donhang.MaDh}", donhang);
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

        public async void CapNhatSLSanPhamAsync(Sanpham sanpham, int SoLuong)
        {
            sanpham.SoLuongTon -= SoLuong;
            HttpResponseMessage respond = await GetAPI("SanPhamUrl").PutAsJsonAsync($"{pathSP}/{sanpham.MaSp}", sanpham);
            respond.EnsureSuccessStatusCode();
        }

        public async void taoChiTietDHAsync(Chitietdonhang chitietdh)
        {
            HttpResponseMessage respond = await GetAPI("DonHangUrl").PostAsJsonAsync(pathCTDH, chitietdh);
            respond.EnsureSuccessStatusCode();
        }

        [HttpGet]
        public IActionResult ThanhCong()
        {
            return View();
        }

    }
}