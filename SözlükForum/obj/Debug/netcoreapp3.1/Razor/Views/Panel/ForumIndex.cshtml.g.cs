#pragma checksum "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Panel\ForumIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc53e422ab82e46ff074756d306264c3a97aae12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Panel_ForumIndex), @"mvc.1.0.view", @"/Views/Panel/ForumIndex.cshtml")]
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
#nullable restore
#line 3 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc53e422ab82e46ff074756d306264c3a97aae12", @"/Views/Panel/ForumIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4bb6bc2e9ae94685adfdbeda196cefeb22039f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Panel_ForumIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Panel\ForumIndex.cshtml"
  
    ViewData["Title"] = "Forumlar";
    Layout = "~/Views/Panel/panelLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Soru</th>\r\n        <th>İcerik</th>\r\n        <th>Kategori</th>\r\n        <th>Kullanici</th>\r\n        <th>Güncelle</th>\r\n        <th>Sil</th>\r\n    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Panel\ForumIndex.cshtml"
     foreach (var item in Model.forumSoruss)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Panel\ForumIndex.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><p class=\"text\">");
#nullable restore
#line 23 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Panel\ForumIndex.cshtml"
                           Write(item.soru);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n            <td><p class=\"text\">");
#nullable restore
#line 24 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Panel\ForumIndex.cshtml"
                           Write(item.icerik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Panel\ForumIndex.cshtml"
           Write(item.katego);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Panel\ForumIndex.cshtml"
           Write(item.kullanici.kullanıcıAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 643, "\"", 676, 2);
            WriteAttributeValue("", 650, "/Panel/SoruUpdate/", 650, 18, true);
#nullable restore
#line 27 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Panel\ForumIndex.cshtml"
WriteAttributeValue("", 668, item.Id, 668, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">");
#nullable restore
#line 27 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Panel\ForumIndex.cshtml"
                                                                        Write(localizer["guncelle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 753, "\"", 783, 2);
            WriteAttributeValue("", 760, "/Panel/SoruSil/", 760, 15, true);
#nullable restore
#line 28 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Panel\ForumIndex.cshtml"
WriteAttributeValue("", 775, item.Id, 775, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">");
#nullable restore
#line 28 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Panel\ForumIndex.cshtml"
                                                                    Write(localizer["sil"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Panel\ForumIndex.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewData> Html { get; private set; }
    }
}
#pragma warning restore 1591
