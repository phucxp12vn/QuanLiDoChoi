#pragma checksum "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\DonHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24110e143dba79006e64f06427bb22dcdd610968"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DonHang), @"mvc.1.0.view", @"/Views/Home/DonHang.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DonHang.cshtml", typeof(AspNetCore.Views_Home_DonHang))]
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
#line 2 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\DonHang.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24110e143dba79006e64f06427bb22dcdd610968", @"/Views/Home/DonHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf3729f3a28b8e9849ca4d4bed21b47c69242569", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DonHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<donhang.api.Models.Donhang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "donhang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::PagedList.Core.Mvc.PagerTagHelper __PagedList_Core_Mvc_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\DonHang.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(178, 670, true);
            WriteLiteral(@"
</br>


<table class=""table table-striped table-bordered table-hover"" id=""dataTables-example"" style=""width:90%;margin-left:30px;"">
    <thead>
        <tr style=""text-align:center"">
            <th>
                Mã ĐH
            </th>
            <th>
                Ngày Tạo
            </th>
            <th>
                Sdt Người Nhận
            </th>
            <th>
                Địa Chỉ Nhận
            </th>
            <th>
                Tổng Tiền
            </th>
            <th>
                Tình Trạng
            </th>
            <th>
            </th>
        </tr>
    </thead>

    <tbody>
");
            EndContext();
#line 38 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\DonHang.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(897, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(958, 39, false);
#line 42 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\DonHang.cshtml"
               Write(Html.DisplayFor(modelItem => item.MaDh));

#line default
#line hidden
            EndContext();
            BeginContext(997, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1065, 42, false);
#line 45 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\DonHang.cshtml"
               Write(Html.DisplayFor(modelItem => item.NgayTao));

#line default
#line hidden
            EndContext();
            BeginContext(1107, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1175, 45, false);
#line 48 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\DonHang.cshtml"
               Write(Html.DisplayFor(modelItem => item.ShipMobile));

#line default
#line hidden
            EndContext();
            BeginContext(1220, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1288, 46, false);
#line 51 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\DonHang.cshtml"
               Write(Html.DisplayFor(modelItem => item.ShipAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1334, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1402, 43, false);
#line 54 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\DonHang.cshtml"
               Write(Html.DisplayFor(modelItem => item.TongTien));

#line default
#line hidden
            EndContext();
            BeginContext(1445, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 56 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\DonHang.cshtml"
                 if (item.DaThanhToan == 1)
                {

#line default
#line hidden
            BeginContext(1534, 94, true);
            WriteLiteral("                    <td>\r\n                        Đã thanh toán\r\n                    </td>\r\n");
            EndContext();
#line 61 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\DonHang.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1688, 95, true);
            WriteLiteral("                    <td>\r\n                        Chưa thanh toán\r\n                    </td>\r\n");
            EndContext();
#line 67 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\DonHang.cshtml"
                }

#line default
#line hidden
            BeginContext(1802, 84, true);
            WriteLiteral("\r\n                <td align=\"\">\r\n                    <button class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1886, "\"", 1980, 4);
            WriteAttributeValue("", 1896, "location.href=\'", 1896, 15, true);
#line 70 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\DonHang.cshtml"
WriteAttributeValue("", 1911, Url.Action("ChiTietDonHang",  new { id = item.MaDh }), 1911, 54, false);

#line default
#line hidden
            WriteAttributeValue("", 1965, "\';return", 1965, 8, true);
            WriteAttributeValue(" ", 1973, "false;", 1974, 7, true);
            EndWriteAttribute();
            BeginContext(1981, 35, true);
            WriteLiteral(">Xem</button>&nbsp&nbsp&nbsp&nbsp\r\n");
            EndContext();
#line 71 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\DonHang.cshtml"
                     if (item.DaThanhToan != 1)
                    {

#line default
#line hidden
            BeginContext(2088, 50, true);
            WriteLiteral("                    <button class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2138, "\"", 2182, 4);
            WriteAttributeValue("", 2148, "notify(\'", 2148, 8, true);
#line 73 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\DonHang.cshtml"
WriteAttributeValue("", 2156, item.MaDh, 2156, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 2166, "\');return", 2166, 9, true);
            WriteAttributeValue(" ", 2175, "false;", 2176, 7, true);
            EndWriteAttribute();
            BeginContext(2183, 15, true);
            WriteLiteral(">Hủy</button>\r\n");
            EndContext();
#line 74 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\DonHang.cshtml"
                    }

#line default
#line hidden
            BeginContext(2221, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 77 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\DonHang.cshtml"
        }

#line default
#line hidden
            BeginContext(2274, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(2300, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7ff7595be72a44c48899b58e66863ef4", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 81 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\DonHang.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 81 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\DonHang.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.Options = PagedListRenderOptions.TwitterBootstrapPager;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("options", __PagedList_Core_Mvc_PagerTagHelper.Options, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __PagedList_Core_Mvc_PagerTagHelper.AspAction = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __PagedList_Core_Mvc_PagerTagHelper.AspController = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2447, 250, true);
            WriteLiteral("\r\n\r\n<script type=\"text/javascript\">\r\n    function notify(id) {\r\n        var con = confirm(\"Bạn có chắc chắn muốn hủy đơn hàng này?\");\r\n        if (con == true) {\r\n            location.href = \'/Home/Cancel/\' + id;\r\n        }\r\n    }\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<donhang.api.Models.Donhang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
