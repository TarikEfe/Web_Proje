#pragma checksum "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3c33639c4096eee7fd472bfc944cff3907f822d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\_ViewImports.cshtml"
using SözlükForum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\_ViewImports.cshtml"
using SözlükForum.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c33639c4096eee7fd472bfc944cff3907f822d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8fc63bcb8d349f81a068b5fcbad8e8b987adfa2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SözlükForum.Models.ForumSoru>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_Layout";
    var gundem = ViewData["gundem"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n");
            WriteLiteral("    <div class=\"col-3\">\r\n        ");
#nullable restore
#line 21 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\Index.cshtml"
   Write(Html.Partial("_Gundemm", gundem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-9\">\r\n");
#nullable restore
#line 24 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\Index.cshtml"
         if (Model is null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger\">\r\n                <strong>Üzgünüz!</strong> sonuç bulunamadı...\r\n            </div>\r\n");
#nullable restore
#line 29 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\Index.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"background-color:#faf7d3; border-radius:5%\" class=\"container\">\r\n                    <div>\r\n                        <a style=\"color:black\"");
            BeginWriteAttribute("href", " href=\"", 1320, "\"", 1353, 2);
            WriteAttributeValue("", 1327, "/ForumSoru/Detail/", 1327, 18, true);
#nullable restore
#line 36 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\Index.cshtml"
WriteAttributeValue("", 1345, item.Id, 1345, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h2 class=\"text-center text\">");
#nullable restore
#line 36 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\Index.cshtml"
                                                                                                         Write(Html.DisplayFor(modelItem => item.soru));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></a>\r\n                        <p class=\"text-right\">");
#nullable restore
#line 37 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\Index.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.kullanici.kullanıcıAd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <hr />\r\n                    <div>\r\n                        <p class=\"text\">");
#nullable restore
#line 41 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.icerik));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"text-right\"><i>");
#nullable restore
#line 42 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.eklemeTarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n                    </div>\r\n                </div>\r\n                <hr />\r\n");
#nullable restore
#line 46 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SözlükForum.Models.ForumSoru>> Html { get; private set; }
    }
}
#pragma warning restore 1591
