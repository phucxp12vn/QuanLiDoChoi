#pragma checksum "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62a3d673b1c3203b140bd5c44533d1f933591449"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Product), @"mvc.1.0.view", @"/Views/Home/Product.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Product.cshtml", typeof(AspNetCore.Views_Home_Product))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62a3d673b1c3203b140bd5c44533d1f933591449", @"/Views/Home/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf3729f3a28b8e9849ca4d4bed21b47c69242569", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sanpham.api.Models.Sanpham>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Product.cshtml"
  
    ViewData["Title"] = "Product";
    var arrListStr = (string[])Model.MotaSp.Split('*');


#line default
#line hidden
            BeginContext(137, 298, true);
            WriteLiteral(@"
<div class=""services-breadcrumb"">
    <div class=""agile_inner_breadcrumb"">
        <div class=""container"">
            <ul class=""w3_short"">
                <li>
                    <a href=""index.html"">Trang chủ</a>
                    <i>|</i>
                </li>
                <li>");
            EndContext();
            BeginContext(436, 11, false);
#line 16 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Product.cshtml"
               Write(Model.TenSp);

#line default
#line hidden
            EndContext();
            BeginContext(447, 634, true);
            WriteLiteral(@"</li>
            </ul>
        </div>
    </div>
</div>
<!-- //page -->
<!-- Single Page -->
<div class=""banner-bootom-w3-agileits"">
    <div class=""container"">
        <!-- tittle heading -->
        <h3 class=""tittle-w3l"">
            Thông tin sản phẩm
            <span class=""heading-style"">
                <i></i>
                <i></i>
                <i></i>
            </span>
        </h3>
        <!-- //tittle heading -->
        <div class=""col-md-5 single-right-left "">
            <div class=""grid images_3_of_2"">
                <div class=""flexslider"">

                    <li data-thumb=""");
            EndContext();
            BeginContext(1082, 13, false);
#line 39 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Product.cshtml"
                               Write(Model.Hinhanh);

#line default
#line hidden
            EndContext();
            BeginContext(1095, 87, true);
            WriteLiteral("\">\r\n                        <div class=\"thumb-image\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1182, "\"", 1202, 1);
#line 41 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Product.cshtml"
WriteAttributeValue("", 1188, Model.Hinhanh, 1188, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1203, 315, true);
            WriteLiteral(@" data-imagezoom=""true"" class=""img-responsive"" alt="""">
                        </div>
                    </li>


                    <div class=""clearfix""></div>
                </div>
            </div>
        </div>
        <div class=""col-md-7 single-right-left simpleCart_shelfItem"">
            <h3>");
            EndContext();
            BeginContext(1519, 11, false);
#line 51 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Product.cshtml"
           Write(Model.TenSp);

#line default
#line hidden
            EndContext();
            BeginContext(1530, 67, true);
            WriteLiteral("</h3>\r\n\r\n            <p>\r\n                <span class=\"item_price\">");
            EndContext();
            BeginContext(1598, 25, false);
#line 54 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Product.cshtml"
                                    Write(Model.GiaBanLe.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1623, 463, true);
            WriteLiteral(@" VNĐ</span>

            </p>
            <div class=""single-infoagile"">
                <ul>
                    <li>
                        Giao hàng miễn phí.
                    </li>
                    <li>
                        Thanh toán khi nhận hàng.
                    </li>
                    <li>
                        Shipping tốc độ cao.
                    </li>
                    <li>
                        Xuất xử ở ");
            EndContext();
            BeginContext(2087, 12, false);
#line 69 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Product.cshtml"
                             Write(Model.XuatSu);

#line default
#line hidden
            EndContext();
            BeginContext(2099, 148, true);
            WriteLiteral(".\r\n                    </li>\r\n                    <li>\r\n                        Số lượng còn lại:\r\n                        <span class=\"item_price\">");
            EndContext();
            BeginContext(2248, 16, false);
#line 73 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Product.cshtml"
                                            Write(Model.SoLuongTon);

#line default
#line hidden
            EndContext();
            BeginContext(2264, 281, true);
            WriteLiteral(@"</span>
                    </li>
                </ul>
            </div>
            <div class=""product-single-w3l"">
                <p>
                    <i class=""fa fa-hand-o-right"" aria-hidden=""true"">Mô tả sản phẩm</i>

                </p>
                <ul>
");
            EndContext();
#line 83 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Product.cshtml"
                     foreach (string a in arrListStr)
                    {
                        var mota = a;

#line default
#line hidden
            BeginContext(2662, 58, true);
            WriteLiteral("                        <li>\r\n                            ");
            EndContext();
            BeginContext(2721, 4, false);
#line 87 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Product.cshtml"
                       Write(mota);

#line default
#line hidden
            EndContext();
            BeginContext(2725, 33, true);
            WriteLiteral("\r\n                        </li>\r\n");
            EndContext();
#line 89 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Product.cshtml"
                    }

#line default
#line hidden
            BeginContext(2781, 391, true);
            WriteLiteral(@"                </ul>

                <p>
                    <i class=""fa fa-refresh"" aria-hidden=""true""></i>
                    <label>Cho phép hoàn trả sản phẩm.</label>
                </p>
            </div>
            <div class=""occasion-cart"">
                <div class=""snipcart-details top_brand_home_details item_add single-item hvr-outline-out"">
                    ");
            EndContext();
            BeginContext(3172, 229, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06a355928a9745d59e2ea92b4a6ca8d3", async() => {
                BeginContext(3178, 88, true);
                WriteLiteral("\r\n                        <fieldset>\r\n\r\n                            <input type=\"button\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 3266, "\"", 3295, 3);
                WriteAttributeValue("", 3276, "them(\'", 3276, 6, true);
#line 102 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Home\Product.cshtml"
WriteAttributeValue("", 3282, Model.MaSp, 3282, 11, false);

#line default
#line hidden
                WriteAttributeValue("", 3293, "\')", 3293, 2, true);
                EndWriteAttribute();
                BeginContext(3296, 98, true);
                WriteLiteral(" value=\"Thêm vào giỏ\" class=\"button\" />\r\n                        </fieldset>\r\n                    ");
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
            BeginContext(3401, 133, true);
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"clearfix\"> </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sanpham.api.Models.Sanpham> Html { get; private set; }
    }
}
#pragma warning restore 1591
