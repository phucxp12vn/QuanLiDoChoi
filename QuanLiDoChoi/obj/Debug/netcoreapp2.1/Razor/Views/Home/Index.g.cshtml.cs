#pragma checksum "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3a690bc610c00a1875fec88a5ccf355760f4947"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3a690bc610c00a1875fec88a5ccf355760f4947", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf3729f3a28b8e9849ca4d4bed21b47c69242569", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<sanpham.api.Models.Sanpham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/js/jquery-2.1.4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/js/jquery-ui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/js/controller/miniSearch.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(138, 450, true);
            WriteLiteral(@"
<div class=""ads-grid"">
    <!-- tittle heading -->
    <h3 class=""tittle-w3l"">
        Sản phẩm của shop
        <span class=""heading-style"">
            <i></i>
            <i></i>
            <i></i>
        </span>
    </h3>
    <!-- //tittle heading -->
    <!-- product left -->
    <div class=""side-bar col-md-3"">
        <div class=""search-hotel"">
            <h3 class=""agileits-sear-head"">Tìm kiếm sản phẩm</h3>
            ");
            EndContext();
            BeginContext(588, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f28cccdc1e7440c9dd757db9247040f", async() => {
                BeginContext(617, 176, true);
                WriteLiteral("\r\n                <input type=\"search\" id=\"miniKeyword\" name=\"keyword\" placeholder=\"Tên sản phẩm...\" required=\"\">\r\n                <input type=\"submit\" value=\" \">\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(800, 34, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(834, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "702d2834a68a40aea5535bafb45178f3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(889, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(895, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6275b617e98048d6b93499fbb91148c5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(943, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(949, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64c1abd603c345f0b3cc2f997981efe3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1009, 223, true);
            WriteLiteral("\r\n    <!-- //product left -->\r\n    <!-- product right -->\r\n    <div class=\"agileinfo-ads-display col-md-9\">\r\n        <div class=\"wrapper\">\r\n            <!-- first section (nuts) -->\r\n            <div class=\"product-sec1\">\r\n");
            EndContext();
#line 38 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Index.cshtml"
                 foreach (var sp in Model)
                {
                    var quantity = (int)1;
                    var url = "Product/" + sp.MaSp;
                    var urlcart = "/Cart/AddItem?masp=" + sp.MaSp + "&soluong=" + quantity;

#line default
#line hidden
            BeginContext(1485, 251, true);
            WriteLiteral("                        <div class=\"col-md-4 product-men\">\r\n                                <div class=\"men-pro-item simpleCart_shelfItem\">\r\n                                    <div class=\"men-thumb-item\">\r\n                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1736, "\"", 1758, 1);
#line 46 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Index.cshtml"
WriteAttributeValue("", 1742, sp.Hinhanhindex, 1742, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1759, 206, true);
            WriteLiteral(" alt=\"\">\r\n                                        <div class=\"men-cart-pro\">\r\n                                            <div class=\"inner-men-cart-pro\">\r\n                                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1965, "\"", 2022, 1);
#line 49 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Index.cshtml"
WriteAttributeValue("", 1972, Url.Action("Product","Home",new { id = sp.MaSp }), 1972, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2023, 436, true);
            WriteLiteral(@" class=""link-product-add-cart"">Xem nhanh</a>
                                            </div>
                                        </div>
                                        <span class=""product-new-top"">New</span>

                                    </div>
                                    <div class=""item-info-product "">
                                        <h4>
                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2459, "\"", 2518, 1);
#line 57 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Index.cshtml"
WriteAttributeValue("", 2466, Url.Action("Detail","Product",new { id = sp.MaSp }), 2466, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2519, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2521, 8, false);
#line 57 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Index.cshtml"
                                                                                                      Write(sp.TenSp);

#line default
#line hidden
            EndContext();
            BeginContext(2529, 196, true);
            WriteLiteral("</a>\r\n                                        </h4>\r\n                                        <div class=\"info-product-price\">\r\n                                            <span class=\"item_price\">");
            EndContext();
            BeginContext(2726, 22, false);
#line 60 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Index.cshtml"
                                                                Write(sp.GiaBanLe.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2748, 239, true);
            WriteLiteral(" VNĐ</span>\r\n\r\n                                        </div>\r\n                                        <div class=\"snipcart-details top_brand_home_details item_add single-item hvr-outline-out\">\r\n                                            ");
            EndContext();
            BeginContext(2987, 324, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "135c3275b46d4926a92808fb68a688eb", async() => {
                BeginContext(2993, 136, true);
                WriteLiteral("\r\n                                                <fieldset>\r\n\r\n                                                    <input type=\"button\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 3129, "\"", 3157, 3);
                WriteAttributeValue("", 3139, "notify(\'", 3139, 8, true);
#line 67 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Index.cshtml"
WriteAttributeValue("", 3147, sp.MaSp, 3147, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 3155, "\')", 3155, 2, true);
                EndWriteAttribute();
                BeginContext(3158, 146, true);
                WriteLiteral(" value=\"Thêm vào giỏ\" class=\"button\" />\r\n                                                </fieldset>\r\n                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3311, 174, true);
            WriteLiteral("\r\n\r\n                                        </div>\r\n\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 76 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Index.cshtml"

                }

#line default
#line hidden
            BeginContext(3506, 324, true);
            WriteLiteral(@"                <div class=""clearfix""></div>
            </div>
        </div>
    </div>
    <!-- //product right -->
</div>

<script type=""text/javascript"">
    function notify(id) {        
        location.href = '/Cart/AddItem?masp=' + id;
        alert(""Thêm vào giỏ hàng thành công."");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<sanpham.api.Models.Sanpham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
