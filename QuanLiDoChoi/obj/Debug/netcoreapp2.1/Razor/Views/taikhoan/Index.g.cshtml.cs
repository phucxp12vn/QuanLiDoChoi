#pragma checksum "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc4a830fde80e7be3fe24585da46dafef5eb710c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_taikhoan_Index), @"mvc.1.0.view", @"/Views/taikhoan/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/taikhoan/Index.cshtml", typeof(AspNetCore.Views_taikhoan_Index))]
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
#line 2 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc4a830fde80e7be3fe24585da46dafef5eb710c", @"/Views/taikhoan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf3729f3a28b8e9849ca4d4bed21b47c69242569", @"/Views/_ViewImports.cshtml")]
    public class Views_taikhoan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<khachhang.api.Models.Taikhoan>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "taikhoan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml"
  
    ViewData["Title"] = "TaiKhoan";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(189, 95, true);
            WriteLiteral("\r\n<br />\r\n<h2>Quản lí tài khoản</h2>\r\n\r\n<p>\r\n    <br />\r\n</p>\r\n\r\n<p>\r\n    Nhập tên khách hàng: ");
            EndContext();
            BeginContext(285, 61, false);
#line 16 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml"
                    Write(Html.TextBox("searchString", ViewBag.CurrentFilter as string));

#line default
#line hidden
            EndContext();
            BeginContext(346, 375, true);
            WriteLiteral(@"
    <button type=""submit""><i class=""fa fa-search""></i></button>
</p>
<br />
<table sytle=""width: 100%;"" class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
    <thead>
        <tr>
            <th>
                Tài khoản
            </th>
            <th>
                Email
            </th>
            <th>
                ");
            EndContext();
            BeginContext(722, 76, false);
#line 30 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml"
           Write(Html.ActionLink("Họ tên", "Index", new { sortOrder = ViewBag.NameSortParm }));

#line default
#line hidden
            EndContext();
            BeginContext(798, 119, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Giới tính\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(918, 79, false);
#line 36 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml"
           Write(Html.ActionLink("Ngày sinh", "Index", new { sortOrder = ViewBag.DateSortParm }));

#line default
#line hidden
            EndContext();
            BeginContext(997, 292, true);
            WriteLiteral(@"
            </th>
            <th>
                Số điện thoại
            </th>
            <th>
                Địa chỉ
            </th>
            <th>
                <p style=""text-align:center"">Chức năng</p>
            </th>
        </tr>
    </thead>

    <tbody>
");
            EndContext();
#line 51 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1338, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1399, 44, false);
#line 55 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TaiKhoan1));

#line default
#line hidden
            EndContext();
            BeginContext(1443, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1511, 40, false);
#line 58 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1551, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1619, 40, false);
#line 61 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(1659, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1727, 43, false);
#line 64 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.GioiTinh));

#line default
#line hidden
            EndContext();
            BeginContext(1770, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1838, 43, false);
#line 67 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(1881, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1949, 38, false);
#line 70 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Sdt));

#line default
#line hidden
            EndContext();
            BeginContext(1987, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2055, 41, false);
#line 73 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(2096, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 75 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml"
                 if (item.Quyen != "1")
                {

#line default
#line hidden
            BeginContext(2181, 97, true);
            WriteLiteral("                    <td align=\"center\">\r\n\r\n                        <button class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2278, "\"", 2327, 4);
            WriteAttributeValue("", 2288, "notify(\'", 2288, 8, true);
#line 79 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml"
WriteAttributeValue("", 2296, item.TaiKhoan1, 2296, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2311, "\');return", 2311, 9, true);
            WriteAttributeValue(" ", 2320, "false;", 2321, 7, true);
            EndWriteAttribute();
            BeginContext(2328, 62, true);
            WriteLiteral(">Xóa</button>&nbsp&nbsp&nbsp&nbsp\r\n                    </td>\r\n");
            EndContext();
#line 81 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2450, 46, true);
            WriteLiteral("                    <td align=\"center\"></td>\r\n");
            EndContext();
#line 85 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2515, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 87 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2545, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
            BeginContext(2569, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8c3321e4918a4994b0363d4ecd9655ed", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 90 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 90 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\taikhoan\Index.cshtml"
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
            BeginContext(2717, 260, true);
            WriteLiteral(@"

<script type=""text/javascript"">
    function notify(id) {
        var con = confirm(""Bạn có chắc chắn muốn xóa tài khoàn này?"");
        if (con == true) {
            location.href = '/Admin/TaiKhoanDelete/' + id;
        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<khachhang.api.Models.Taikhoan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
