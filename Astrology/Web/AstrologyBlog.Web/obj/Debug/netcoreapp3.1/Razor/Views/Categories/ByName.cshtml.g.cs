#pragma checksum "C:\Dev\CSharpAspNetCoreOct2020\Astrology\Web\AstrologyBlog.Web\Views\Categories\ByName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "963045a65db6e647e90c660d403d121cb1bcb255"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_ByName), @"mvc.1.0.view", @"/Views/Categories/ByName.cshtml")]
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
#nullable restore
#line 1 "C:\Dev\CSharpAspNetCoreOct2020\Astrology\Web\AstrologyBlog.Web\Views\_ViewImports.cshtml"
using AstrologyBlog.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\CSharpAspNetCoreOct2020\Astrology\Web\AstrologyBlog.Web\Views\_ViewImports.cshtml"
using AstrologyBlog.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"963045a65db6e647e90c660d403d121cb1bcb255", @"/Views/Categories/ByName.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e5a2aa7287c88671975ec106b317132532ffe31", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_ByName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AstrologyBlog.Web.ViewModels.Categories.CategoryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Dev\CSharpAspNetCoreOct2020\Astrology\Web\AstrologyBlog.Web\Views\Categories\ByName.cshtml"
  
    this.ViewData["Title"] = @Model.Title;
    this.ViewData["Name"] = @Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"content\" class=\"blog_page blog_details\">\r\n    <div id=\"blogs\" class=\"blog_section\">\r\n        <div class=\"container-fluid\">\r\n            <div class=\"blog_inner_matter\">\r\n                <h2 class=\"wow fadeInLeftBig animated\"><a");
            BeginWriteAttribute("href", " href=\"", 394, "\"", 401, 0);
            EndWriteAttribute();
            WriteLiteral(">Какво е ");
#nullable restore
#line 10 "C:\Dev\CSharpAspNetCoreOct2020\Astrology\Web\AstrologyBlog.Web\Views\Categories\ByName.cshtml"
                                                                     Write(this.ViewData["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("?</a></h2>\r\n                    <!-- left side -->\r\n                    <div class=\"col-md-12\">\r\n                        <div class=\"blog_inner_matter\">\r\n                            <p class=\"wow fadeInUpBig animated\">");
#nullable restore
#line 14 "C:\Dev\CSharpAspNetCoreOct2020\Astrology\Web\AstrologyBlog.Web\Views\Categories\ByName.cshtml"
                                                           Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <!-- right side -->\r\n                    <!-- middle -->\r\n                    <div class=\"col-12\">\r\n                        <p class=\"wow fadeInDownBig animated\">");
#nullable restore
#line 20 "C:\Dev\CSharpAspNetCoreOct2020\Astrology\Web\AstrologyBlog.Web\Views\Categories\ByName.cshtml"
                                                         Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AstrologyBlog.Web.ViewModels.Categories.CategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
