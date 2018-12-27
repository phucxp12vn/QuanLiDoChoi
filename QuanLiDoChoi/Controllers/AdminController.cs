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
    public class AdminController : BaseAdminController
    {

        public IActionResult Index()
        {
            return View();
        }
       
    }
}