#pragma checksum "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "532be6955400f53282f239f0eb0017ba57112417"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_demo_Index), @"mvc.1.0.view", @"/Views/demo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/demo/Index.cshtml", typeof(AspNetCore.Views_demo_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"532be6955400f53282f239f0eb0017ba57112417", @"/Views/demo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf3729f3a28b8e9849ca4d4bed21b47c69242569", @"/Views/_ViewImports.cshtml")]
    public class Views_demo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<khachhang.api.Models.Taikhoan>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(80, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(109, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28d3fbd980eb47a0bb5136605f903003", async() => {
                BeginContext(115, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(209, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(211, 2525, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbf8e6e1f4ed4568b5c4c976e6ba2254", async() => {
                BeginContext(217, 11, true);
                WriteLiteral("\r\n<p>\r\n    ");
                EndContext();
                BeginContext(228, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feabef1604e54775bb40fd03e752f994", async() => {
                    BeginContext(251, 10, true);
                    WriteLiteral("Create New");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(265, 92, true);
                WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(358, 45, false);
#line 22 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TaiKhoan1));

#line default
#line hidden
                EndContext();
                BeginContext(403, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(459, 43, false);
#line 25 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MatKhau));

#line default
#line hidden
                EndContext();
                BeginContext(502, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(558, 41, false);
#line 28 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
                EndContext();
                BeginContext(599, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(655, 41, false);
#line 31 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quyen));

#line default
#line hidden
                EndContext();
                BeginContext(696, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(752, 41, false);
#line 34 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
                EndContext();
                BeginContext(793, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(849, 44, false);
#line 37 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GioiTinh));

#line default
#line hidden
                EndContext();
                BeginContext(893, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(949, 44, false);
#line 40 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NgaySinh));

#line default
#line hidden
                EndContext();
                BeginContext(993, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1049, 39, false);
#line 43 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Sdt));

#line default
#line hidden
                EndContext();
                BeginContext(1088, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1144, 42, false);
#line 46 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
                EndContext();
                BeginContext(1186, 55, true);
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                EndContext();
                BeginContext(1242, 40, false);
#line 49 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Flag));

#line default
#line hidden
                EndContext();
                BeginContext(1282, 86, true);
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
                EndContext();
#line 55 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
                BeginContext(1400, 48, true);
                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1449, 44, false);
#line 58 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TaiKhoan1));

#line default
#line hidden
                EndContext();
                BeginContext(1493, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1549, 42, false);
#line 61 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MatKhau));

#line default
#line hidden
                EndContext();
                BeginContext(1591, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1647, 40, false);
#line 64 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
                EndContext();
                BeginContext(1687, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1743, 40, false);
#line 67 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quyen));

#line default
#line hidden
                EndContext();
                BeginContext(1783, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1839, 40, false);
#line 70 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HoTen));

#line default
#line hidden
                EndContext();
                BeginContext(1879, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(1935, 43, false);
#line 73 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GioiTinh));

#line default
#line hidden
                EndContext();
                BeginContext(1978, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(2034, 43, false);
#line 76 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NgaySinh));

#line default
#line hidden
                EndContext();
                BeginContext(2077, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(2133, 38, false);
#line 79 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Sdt));

#line default
#line hidden
                EndContext();
                BeginContext(2171, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(2227, 41, false);
#line 82 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DiaChi));

#line default
#line hidden
                EndContext();
                BeginContext(2268, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(2324, 39, false);
#line 85 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Flag));

#line default
#line hidden
                EndContext();
                BeginContext(2363, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(2419, 65, false);
#line 88 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(2484, 20, true);
                WriteLiteral(" |\r\n                ");
                EndContext();
                BeginContext(2505, 71, false);
#line 89 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(2576, 20, true);
                WriteLiteral(" |\r\n                ");
                EndContext();
                BeginContext(2597, 69, false);
#line 90 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(2666, 36, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 93 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\demo\Index.cshtml"
}

#line default
#line hidden
                BeginContext(2705, 24, true);
                WriteLiteral("    </tbody>\r\n</table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2736, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<khachhang.api.Models.Taikhoan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
