#pragma checksum "P:\QuanLiDoChoi\QuanLiDoChoi\Views\sanpham\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54815c32a54df1e452867871a950a05fa17893c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_sanpham_Index), @"mvc.1.0.view", @"/Views/sanpham/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/sanpham/Index.cshtml", typeof(AspNetCore.Views_sanpham_Index))]
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
#line 2 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\sanpham\Index.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54815c32a54df1e452867871a950a05fa17893c0", @"/Views/sanpham/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf3729f3a28b8e9849ca4d4bed21b47c69242569", @"/Views/_ViewImports.cshtml")]
    public class Views_sanpham_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.IPagedList<sanpham.api.Models.Sanpham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pager-container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "sanpham", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(90, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\sanpham\Index.cshtml"
  
    ViewData["Title"] = "SanPham";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(187, 44, true);
            WriteLiteral("</br>\r\n<p>\r\n    <button class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 231, "\"", 292, 4);
            WriteAttributeValue("", 241, "location.href=\'", 241, 15, true);
#line 10 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\sanpham\Index.cshtml"
WriteAttributeValue("", 256, Url.Action("Create"), 256, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 277, "\';return", 277, 8, true);
            WriteAttributeValue(" ", 285, "false;", 286, 7, true);
            EndWriteAttribute();
            BeginContext(293, 78, true);
            WriteLiteral(">Tạo mới</button>&nbsp;&nbsp;&nbsp;&nbsp;\r\n    <button class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 371, "\"", 431, 4);
            WriteAttributeValue("", 381, "location.href=\'", 381, 15, true);
#line 11 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\sanpham\Index.cshtml"
WriteAttributeValue("", 396, Url.Action("Index"), 396, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 416, "\';return", 416, 8, true);
            WriteAttributeValue(" ", 424, "false;", 425, 7, true);
            EndWriteAttribute();
            BeginContext(432, 581, true);
            WriteLiteral(@">Tải lại</button>
</p>

<table class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
    <thead>
        <tr style=""text-align:center"">
            <th>
                Mã SP
            </th>
            <th style=""width:35%"">
                Tên SP
            </th>
            <th>
                Số lượng
            </th>
            <th>
                Giá bán
            </th>
            <th>
                Xuất xứ
            </th>
            <th>

            </th>
        </tr>
    </thead>

    <tbody>
");
            EndContext();
#line 39 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\sanpham\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1062, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1123, 39, false);
#line 43 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\sanpham\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MaSp));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1230, 40, false);
#line 46 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\sanpham\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TenSp));

#line default
#line hidden
            EndContext();
            BeginContext(1270, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1338, 45, false);
#line 49 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\sanpham\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SoLuongTon));

#line default
#line hidden
            EndContext();
            BeginContext(1383, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1451, 43, false);
#line 52 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\sanpham\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.GiaBanLe));

#line default
#line hidden
            EndContext();
            BeginContext(1494, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1562, 41, false);
#line 55 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\sanpham\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.XuatSu));

#line default
#line hidden
            EndContext();
            BeginContext(1603, 113, true);
            WriteLiteral("\r\n                </td>\r\n                <td align=\"center\">\r\n                    <button class=\"btn btn-success\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1716, "\"", 1802, 4);
            WriteAttributeValue("", 1726, "location.href=\'", 1726, 15, true);
#line 58 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\sanpham\Index.cshtml"
WriteAttributeValue("", 1741, Url.Action("Detail",  new { id = item.MaSp }), 1741, 46, false);

#line default
#line hidden
            WriteAttributeValue("", 1787, "\';return", 1787, 8, true);
            WriteAttributeValue(" ", 1795, "false;", 1796, 7, true);
            EndWriteAttribute();
            BeginContext(1803, 86, true);
            WriteLiteral(">Xem</button>&nbsp&nbsp&nbsp&nbsp\r\n                    <button class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1889, "\"", 1973, 4);
            WriteAttributeValue("", 1899, "location.href=\'", 1899, 15, true);
#line 59 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\sanpham\Index.cshtml"
WriteAttributeValue("", 1914, Url.Action("Edit",  new { id = item.MaSp }), 1914, 44, false);

#line default
#line hidden
            WriteAttributeValue("", 1958, "\';return", 1958, 8, true);
            WriteAttributeValue(" ", 1966, "false;", 1967, 7, true);
            EndWriteAttribute();
            BeginContext(1974, 85, true);
            WriteLiteral(">Sửa</button>&nbsp&nbsp&nbsp&nbsp\r\n                    <button class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2059, "\"", 2103, 4);
            WriteAttributeValue("", 2069, "notify(\'", 2069, 8, true);
#line 60 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\sanpham\Index.cshtml"
WriteAttributeValue("", 2077, item.MaSp, 2077, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 2087, "\');return", 2087, 9, true);
            WriteAttributeValue(" ", 2096, "false;", 2097, 7, true);
            EndWriteAttribute();
            BeginContext(2104, 77, true);
            WriteLiteral(">Xóa</button>&nbsp&nbsp&nbsp&nbsp\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 63 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\sanpham\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2192, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(2218, 147, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6cbdab8f5e334668a74b167e62154db8", async() => {
            }
            );
            __PagedList_Core_Mvc_PagerTagHelper = CreateTagHelper<global::PagedList.Core.Mvc.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__PagedList_Core_Mvc_PagerTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 67 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\sanpham\Index.cshtml"
__PagedList_Core_Mvc_PagerTagHelper.List = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("list", __PagedList_Core_Mvc_PagerTagHelper.List, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 67 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\sanpham\Index.cshtml"
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
            BeginContext(2365, 266, true);
            WriteLiteral(@"

<script type=""text/javascript"">
    function notify(id) {
        var con = confirm(""Bạn có chắc chắn muốn tạm ngưng bán sản phẩm này?"");
        if (con == true) {
            location.href = '/SanPham/Delete/' + id;
        }
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.IPagedList<sanpham.api.Models.Sanpham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
