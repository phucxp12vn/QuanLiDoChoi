#pragma checksum "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\ChiTietDonHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62c410f2a683e1e9347a5f7e2659774f8a80eba1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ChiTietDonHang), @"mvc.1.0.view", @"/Views/Home/ChiTietDonHang.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ChiTietDonHang.cshtml", typeof(AspNetCore.Views_Home_ChiTietDonHang))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\_ViewImports.cshtml"
using QuanLiDoChoi;

#line default
#line hidden
#line 2 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\_ViewImports.cshtml"
using QuanLiDoChoi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62c410f2a683e1e9347a5f7e2659774f8a80eba1", @"/Views/Home/ChiTietDonHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf3729f3a28b8e9849ca4d4bed21b47c69242569", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ChiTietDonHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<QuanLiDoChoi.Models.CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/js/controller/cartController.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\ChiTietDonHang.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var dem = 0;
    float tongtien = 0;

#line default
#line hidden
            BeginContext(176, 407, true);
            WriteLiteral(@"

<!-- //banner-2 -->
<!-- page -->
<div class=""services-breadcrumb"">
    <div class=""agile_inner_breadcrumb"">
        <div class=""container"">
            <ul class=""w3_short"">
                <li>
                    <a href=""/Home/Index"">Trang chủ</a>
                    <i>|</i>
                </li>
                <li>Kiểm tra</li>
            </ul>
        </div>
    </div>
</div>
");
            EndContext();
            BeginContext(584, 36, false);
#line 26 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\ChiTietDonHang.cshtml"
Write(Html.ValidationMessage("LoiSoLuong"));

#line default
#line hidden
            EndContext();
            BeginContext(620, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 28 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\ChiTietDonHang.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(648, 243, true);
            WriteLiteral("    <!-- //page -->\r\n    <!-- checkout page -->\r\n    <div class=\"privacy\">\r\n        <div class=\"container\">\r\n            <div class=\"checkout-right\">\r\n                <h4>\r\n                    Đơn hàng của bạn gồm :\r\n                    <span>");
            EndContext();
            BeginContext(892, 13, false);
#line 37 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\ChiTietDonHang.cshtml"
                     Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(905, 613, true);
            WriteLiteral(@" sản phẩm</span>
                </h4>
                <div class=""table-responsive"">
                    <table class=""timetable_sub"">
                        <thead>
                            <tr>
                                <th>STT</th>
                                <th>Sản phẩm</th>
                                <th>Số lượng</th>
                                <th>Tên sản phẩm</th>

                                <th>Giá</th>
                                <th>Thành tiền</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 53 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\ChiTietDonHang.cshtml"
                             foreach (var sp in Model)
                            {
                                dem++;
                                var rem = "rem" + @dem;
                                var close = "close" + @dem;
                                float tien = (float)sp.SP.GiaBanLe * sp.SoLuong;
                                tongtien = tongtien + tien;
                                

#line default
#line hidden
            BeginContext(1938, 3, true);
            WriteLiteral("<tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1941, "\"", 1953, 1);
#line 60 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\ChiTietDonHang.cshtml"
WriteAttributeValue("", 1949, rem, 1949, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1954, 58, true);
            WriteLiteral(">\r\n                                    <td class=\"invert\">");
            EndContext();
            BeginContext(2013, 3, false);
#line 61 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\ChiTietDonHang.cshtml"
                                                  Write(dem);

#line default
#line hidden
            EndContext();
            BeginContext(2016, 183, true);
            WriteLiteral("</td>\r\n                                    <td class=\"invert-image\">\r\n                                        <a href=\"single2.html\">\r\n                                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2199, "\"", 2224, 1);
#line 64 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\ChiTietDonHang.cshtml"
WriteAttributeValue("", 2205, sp.SP.Hinhanhindex, 2205, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2225, 220, true);
            WriteLiteral(" alt=\" \" class=\"img-responsive\">\r\n                                        </a>\r\n                                    </td>\r\n                                    <td class=\"invert\">\r\n                                        ");
            EndContext();
            BeginContext(2446, 10, false);
#line 68 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\ChiTietDonHang.cshtml"
                                   Write(sp.SoLuong);

#line default
#line hidden
            EndContext();
            BeginContext(2456, 100, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"invert\">");
            EndContext();
            BeginContext(2557, 11, false);
#line 70 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\ChiTietDonHang.cshtml"
                                                  Write(sp.SP.TenSp);

#line default
#line hidden
            EndContext();
            BeginContext(2568, 61, true);
            WriteLiteral("/td>\r\n                                    <td class=\"invert\">");
            EndContext();
            BeginContext(2630, 25, false);
#line 71 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\ChiTietDonHang.cshtml"
                                                  Write(sp.SP.GiaBanLe.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2655, 66, true);
            WriteLiteral(" VNĐ</td>\r\n                                    <td class=\"invert\">");
            EndContext();
            BeginContext(2722, 19, false);
#line 72 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\ChiTietDonHang.cshtml"
                                                  Write(tien.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(2741, 85, true);
            WriteLiteral(" VNĐ</td>                                   \r\n                                </tr>\r\n");
            EndContext();
#line 74 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\ChiTietDonHang.cshtml"
                            }

#line default
#line hidden
            BeginContext(2857, 335, true);
            WriteLiteral(@"

                        </tbody>
                    </table>
                </div>
            </div>

            <div style=""margin-top:10px;"">
                <button class=""btn btn-default"" onclick=""notify();return false;"">Quay Lại</button>
            </div>


            <h1 style=""text-align:right""> Tổng tiền: ");
            EndContext();
            BeginContext(3193, 23, false);
#line 87 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\ChiTietDonHang.cshtml"
                                                Write(tongtien.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(3216, 41, true);
            WriteLiteral(" VNĐ</h1>\r\n\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 91 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\ChiTietDonHang.cshtml"
}

#line default
#line hidden
            BeginContext(3260, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46179ef23fad487bae50881d39091964", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3324, 102, true);
            WriteLiteral("\r\n\r\n<script>\r\n    function notify() {\r\n        location.href = \'/Home/DonHang/\';\r\n    }\r\n</script>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<QuanLiDoChoi.Models.CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
