#pragma checksum "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75a4feeeca25920d41fd9c4869b74aac8f083bc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_donhang_Index), @"mvc.1.0.view", @"/Views/donhang/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/donhang/Index.cshtml", typeof(AspNetCore.Views_donhang_Index))]
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
#line 2 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75a4feeeca25920d41fd9c4869b74aac8f083bc8", @"/Views/donhang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf3729f3a28b8e9849ca4d4bed21b47c69242569", @"/Views/_ViewImports.cshtml")]
    public class Views_donhang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<donhang.api.Models.Donhang>>
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
#line 3 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(183, 46, true);
            WriteLiteral("\r\n</br>\r\n<p>\r\n    <button class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 229, "\"", 290, 4);
            WriteAttributeValue("", 239, "location.href=\'", 239, 15, true);
#line 10 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
WriteAttributeValue("", 254, Url.Action("Create"), 254, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 275, "\';return", 275, 8, true);
            WriteAttributeValue(" ", 283, "false;", 284, 7, true);
            EndWriteAttribute();
            BeginContext(291, 78, true);
            WriteLiteral(">Tạo mới</button>&nbsp;&nbsp;&nbsp;&nbsp;\r\n    <button class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 369, "\"", 429, 4);
            WriteAttributeValue("", 379, "location.href=\'", 379, 15, true);
#line 11 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
WriteAttributeValue("", 394, Url.Action("Index"), 394, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 414, "\';return", 414, 8, true);
            WriteAttributeValue(" ", 422, "false;", 423, 7, true);
            EndWriteAttribute();
            BeginContext(430, 714, true);
            WriteLiteral(@">Tải lại</button>
</p>

<table class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
    <thead>
        <tr style=""text-align:center"">
            <th>
                Mã ĐH
            </th>
            <th>
                Ngày Tạo
            </th>
            <th>
                Tài Khoản
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
#line 44 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1193, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1242, 39, false);
#line 48 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaDh));

#line default
#line hidden
            EndContext();
            BeginContext(1281, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1337, 42, false);
#line 51 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NgayTao));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1435, 43, false);
#line 54 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TaiKhoan));

#line default
#line hidden
            EndContext();
            BeginContext(1478, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1534, 45, false);
#line 57 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ShipMobile));

#line default
#line hidden
            EndContext();
            BeginContext(1579, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1635, 46, false);
#line 60 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ShipAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1681, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1737, 43, false);
#line 63 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TongTien));

#line default
#line hidden
            EndContext();
            BeginContext(1780, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 65 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
             if (item.DaThanhToan == 1)
            {

#line default
#line hidden
            BeginContext(1857, 82, true);
            WriteLiteral("                <td>\r\n                    Đã thanh toán\r\n                </td>\r\n");
            EndContext();
#line 70 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1987, 83, true);
            WriteLiteral("                <td>\r\n                    Chưa thanh toán\r\n                </td>\r\n");
            EndContext();
#line 76 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2085, 90, true);
            WriteLiteral("\r\n                <td align=\"center\">\r\n                    <button class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2175, "\"", 2261, 4);
            WriteAttributeValue("", 2185, "location.href=\'", 2185, 15, true);
#line 79 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
WriteAttributeValue("", 2200, Url.Action("Detail",  new { id = item.MaDh }), 2200, 46, false);

#line default
#line hidden
            WriteAttributeValue("", 2246, "\';return", 2246, 8, true);
            WriteAttributeValue(" ", 2254, "false;", 2255, 7, true);
            EndWriteAttribute();
            BeginContext(2262, 35, true);
            WriteLiteral(">Xem</button>&nbsp&nbsp&nbsp&nbsp\r\n");
            EndContext();
#line 80 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
                     if (item.DaThanhToan != 1)
                    {

#line default
#line hidden
            BeginContext(2369, 54, true);
            WriteLiteral("                        <button class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2423, "\"", 2467, 4);
            WriteAttributeValue("", 2433, "notify(\'", 2433, 8, true);
#line 82 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
WriteAttributeValue("", 2441, item.MaDh, 2441, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 2451, "\');return", 2451, 9, true);
            WriteAttributeValue(" ", 2460, "false;", 2461, 7, true);
            EndWriteAttribute();
            BeginContext(2468, 15, true);
            WriteLiteral(">Hủy</button>\r\n");
            EndContext();
#line 83 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2506, 40, true);
            WriteLiteral("\r\n                </td>\r\n        </tr>\r\n");
            EndContext();
#line 87 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2557, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(2583, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f136c583623549f5a23749a12584177d", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 91 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 91 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\donhang\Index.cshtml"
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
            BeginContext(2730, 253, true);
            WriteLiteral("\r\n\r\n<script type=\"text/javascript\">\r\n    function notify(id) {\r\n        var con = confirm(\"Bạn có chắc chắn muốn hủy đơn hàng này?\");\r\n        if (con == true) {\r\n            location.href = \'/DonHang/Cancel/\' + id;\r\n        }\r\n    }\r\n</script>\r\n\r\n");
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
