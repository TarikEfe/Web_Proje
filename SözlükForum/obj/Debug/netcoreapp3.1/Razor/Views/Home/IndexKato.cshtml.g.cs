#pragma checksum "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\IndexKato.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5393283e7767fd74dfc31ea3b84c2d0f812fd2c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexKato), @"mvc.1.0.view", @"/Views/Home/IndexKato.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5393283e7767fd74dfc31ea3b84c2d0f812fd2c9", @"/Views/Home/IndexKato.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4bb6bc2e9ae94685adfdbeda196cefeb22039f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_IndexKato : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SözlükForum.Models.ForumSoru>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Kayit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ForumSoru", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\IndexKato.cshtml"
  
    
    ViewData["Title"] = "kategori";
    Layout = "_Layout";
    var gundem = ViewData["gundem"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\IndexKato.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5393283e7767fd74dfc31ea3b84c2d0f812fd2c94870", async() => {
                WriteLiteral("Soru Yaz");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <br />\r\n");
#nullable restore
#line 19 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\IndexKato.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n");
            WriteLiteral("    <div class=\"col-4\">\r\n        ");
#nullable restore
#line 34 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\IndexKato.cshtml"
   Write(Html.Partial("_Gundemm", gundem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-8\">\r\n");
#nullable restore
#line 37 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\IndexKato.cshtml"
         if (Model is null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger\">\r\n                <strong>Üzgünüz!</strong> sonuç bulunamadı...\r\n            </div>\r\n");
#nullable restore
#line 42 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\IndexKato.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\IndexKato.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div style=\"background-color:#faf7d3; border-radius:5%\" class=\"container\">\r\n                    <div>\r\n                        <a style=\"color:black\"");
            BeginWriteAttribute("href", " href=\"", 1674, "\"", 1707, 2);
            WriteAttributeValue("", 1681, "/ForumSoru/Detail/", 1681, 18, true);
#nullable restore
#line 49 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\IndexKato.cshtml"
WriteAttributeValue("", 1699, item.Id, 1699, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h2 class=\"text-center text\">");
#nullable restore
#line 49 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\IndexKato.cshtml"
                                                                                                         Write(Html.DisplayFor(modelItem => item.soru));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2></a>\r\n                        <p class=\"text-right\">");
#nullable restore
#line 50 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\IndexKato.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.kullanici.kullanıcıAd));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <hr />\r\n                    <div>\r\n                        <p class=\"text\">");
#nullable restore
#line 54 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\IndexKato.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.icerik));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"text-right\"><i>");
#nullable restore
#line 55 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\IndexKato.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.eklemeTarih));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n                    </div>\r\n                </div>\r\n                <hr />\r\n");
#nullable restore
#line 59 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\IndexKato.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Home\IndexKato.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SözlükForum.Models.ForumSoru>> Html { get; private set; }
    }
}
#pragma warning restore 1591
