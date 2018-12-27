using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace QuanLiDoChoi.Controllers
{
    public class BaseAdminController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var session = HttpContext.Session.GetString("power");
            if (session == null || session == "" || session == "2")
            {
                context.Result = new RedirectToRouteResult(new
                    RouteValueDictionary(new { action = "dangnhap", controller = "home" }));

            }
            base.OnActionExecuting(context);

        }
    }
}