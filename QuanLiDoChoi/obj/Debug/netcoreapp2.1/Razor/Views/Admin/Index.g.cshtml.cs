#pragma checksum "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6a9886301992f3a4416360f861a2bc8a0e359ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6a9886301992f3a4416360f861a2bc8a0e359ae", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33de17273e06be94d75b9deb74bf4aa5771b4dad", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "P:\QuanLiDoChoi\QuanLiDoChoi\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(95, 10419, true);
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-lg-12"">
        <h1 class=""page-header"">Tổng quan</h1>
    </div>
    <!-- /.col-lg-12 -->
</div>
<!-- /.row -->
<div class=""row"">
    <div class=""col-lg-3 col-md-6"">
        <div class=""panel panel-primary"">
            <div class=""panel-heading"">
                <div class=""row"">
                    <div class=""col-xs-3"">
                        <i class=""fa fa-comments fa-5x""></i>
                    </div>
                    <div class=""col-xs-9 text-right"">
                        <div class=""huge"">26</div>
                        <div>New Comments!</div>
                    </div>
                </div>
            </div>
            <a href=""#"">
                <div class=""panel-footer"">
                    <span class=""pull-left"">View Details</span>
                    <span class=""pull-right""><i class=""fa fa-arrow-circle-right""></i></span>
                    <div class=""clearfix""></div>
                </div>
            </a>
   ");
            WriteLiteral(@"     </div>
    </div>
    <div class=""col-lg-3 col-md-6"">
        <div class=""panel panel-green"">
            <div class=""panel-heading"">
                <div class=""row"">
                    <div class=""col-xs-3"">
                        <i class=""fa fa-tasks fa-5x""></i>
                    </div>
                    <div class=""col-xs-9 text-right"">
                        <div class=""huge"">12</div>
                        <div>New Tasks!</div>
                    </div>
                </div>
            </div>
            <a href=""#"">
                <div class=""panel-footer"">
                    <span class=""pull-left"">View Details</span>
                    <span class=""pull-right""><i class=""fa fa-arrow-circle-right""></i></span>
                    <div class=""clearfix""></div>
                </div>
            </a>
        </div>
    </div>
    <div class=""col-lg-3 col-md-6"">
        <div class=""panel panel-yellow"">
            <div class=""panel-heading"">
                <di");
            WriteLiteral(@"v class=""row"">
                    <div class=""col-xs-3"">
                        <i class=""fa fa-shopping-cart fa-5x""></i>
                    </div>
                    <div class=""col-xs-9 text-right"">
                        <div class=""huge"">124</div>
                        <div>New Orders!</div>
                    </div>
                </div>
            </div>
            <a href=""#"">
                <div class=""panel-footer"">
                    <span class=""pull-left"">View Details</span>
                    <span class=""pull-right""><i class=""fa fa-arrow-circle-right""></i></span>
                    <div class=""clearfix""></div>
                </div>
            </a>
        </div>
    </div>
    <div class=""col-lg-3 col-md-6"">
        <div class=""panel panel-red"">
            <div class=""panel-heading"">
                <div class=""row"">
                    <div class=""col-xs-3"">
                        <i class=""fa fa-support fa-5x""></i>
                    </div>
       ");
            WriteLiteral(@"             <div class=""col-xs-9 text-right"">
                        <div class=""huge"">13</div>
                        <div>Support Tickets!</div>
                    </div>
                </div>
            </div>
            <a href=""#"">
                <div class=""panel-footer"">
                    <span class=""pull-left"">View Details</span>
                    <span class=""pull-right""><i class=""fa fa-arrow-circle-right""></i></span>
                    <div class=""clearfix""></div>
                </div>
            </a>
        </div>
    </div>
</div>
<!-- /.row -->
<div class=""row"">
    <div class=""col-lg-8"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <i class=""fa fa-bar-chart-o fa-fw""></i> Area Chart Example
                <div class=""pull-right"">
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-default btn-xs dropdown-toggle"" data-toggle=""dropdown"">
              ");
            WriteLiteral(@"              Actions
                            <span class=""caret""></span>
                        </button>
                        <ul class=""dropdown-menu pull-right"" role=""menu"">
                            <li>
                                <a href=""#"">Action</a>
                            </li>
                            <li>
                                <a href=""#"">Another action</a>
                            </li>
                            <li>
                                <a href=""#"">Something else here</a>
                            </li>
                            <li class=""divider""></li>
                            <li>
                                <a href=""#"">Separated link</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <div id=""morris-area-chart""></div>
            </div>
            WriteLiteral(@"
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <i class=""fa fa-bar-chart-o fa-fw""></i> Bar Chart Example
                <div class=""pull-right"">
                    <div class=""btn-group"">
                        <button type=""button"" class=""btn btn-default btn-xs dropdown-toggle"" data-toggle=""dropdown"">
                            Actions
                            <span class=""caret""></span>
                        </button>
                        <ul class=""dropdown-menu pull-right"" role=""menu"">
                            <li>
                                <a href=""#"">Action</a>
                            </li>
                            <li>
                                <a href=""#"">Another action</a>
                            </li>
                            <li>
                                <a href=""#"">Something else here</a>
                 ");
            WriteLiteral(@"           </li>
                            <li class=""divider""></li>
                            <li>
                                <a href=""#"">Separated link</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <!-- /.panel-heading -->
     
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <i class=""fa fa-clock-o fa-fw""></i> Responsive Timeline
            </div>
            <!-- /.panel-heading -->
         
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>
    <!-- /.col-lg-8 -->
    <div class=""col-lg-4"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <i class=""fa fa-bell fa-fw""></i> Notifications Panel
            </div>
            <!-- /.panel-heading -->
            <");
            WriteLiteral(@"div class=""panel-body"">
                <div class=""list-group"">
                    <a href=""#"" class=""list-group-item"">
                        <i class=""fa fa-comment fa-fw""></i> New Comment
                        <span class=""pull-right text-muted small"">
                            <em>4 minutes ago</em>
                        </span>
                    </a>
                    <a href=""#"" class=""list-group-item"">
                        <i class=""fa fa-twitter fa-fw""></i> 3 New Followers
                        <span class=""pull-right text-muted small"">
                            <em>12 minutes ago</em>
                        </span>
                    </a>
                    <a href=""#"" class=""list-group-item"">
                        <i class=""fa fa-envelope fa-fw""></i> Message Sent
                        <span class=""pull-right text-muted small"">
                            <em>27 minutes ago</em>
                        </span>
                    </a>
                   ");
            WriteLiteral(@" <a href=""#"" class=""list-group-item"">
                        <i class=""fa fa-tasks fa-fw""></i> New Task
                        <span class=""pull-right text-muted small"">
                            <em>43 minutes ago</em>
                        </span>
                    </a>
                    <a href=""#"" class=""list-group-item"">
                        <i class=""fa fa-upload fa-fw""></i> Server Rebooted
                        <span class=""pull-right text-muted small"">
                            <em>11:32 AM</em>
                        </span>
                    </a>
                    <a href=""#"" class=""list-group-item"">
                        <i class=""fa fa-bolt fa-fw""></i> Server Crashed!
                        <span class=""pull-right text-muted small"">
                            <em>11:13 AM</em>
                        </span>
                    </a>
                    <a href=""#"" class=""list-group-item"">
                        <i class=""fa fa-warning fa-fw""></i> Serve");
            WriteLiteral(@"r Not Responding
                        <span class=""pull-right text-muted small"">
                            <em>10:57 AM</em>
                        </span>
                    </a>
                    <a href=""#"" class=""list-group-item"">
                        <i class=""fa fa-shopping-cart fa-fw""></i> New Order Placed
                        <span class=""pull-right text-muted small"">
                            <em>9:49 AM</em>
                        </span>
                    </a>
                    <a href=""#"" class=""list-group-item"">
                        <i class=""fa fa-money fa-fw""></i> Payment Received
                        <span class=""pull-right text-muted small"">
                            <em>Yesterday</em>
                        </span>
                    </a>
                </div>
                <!-- /.list-group -->
                <a href=""#"" class=""btn btn-default btn-block"">View All Alerts</a>
            </div>
            <!-- /.panel-body -->
       ");
            WriteLiteral(" </div>\r\n        <!-- /.panel -->\r\n        \r\n        <!-- /.panel -->\r\n       \r\n        <!-- /.panel .chat-panel -->\r\n    </div>\r\n    <!-- /.col-lg-4 -->\r\n</div>\r\n<!-- /.row -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591