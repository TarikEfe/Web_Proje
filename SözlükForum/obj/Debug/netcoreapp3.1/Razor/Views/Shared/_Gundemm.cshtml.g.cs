#pragma checksum "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Shared\_Gundemm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8f575082ed5f9aa4b32d950a6f818f2151e381a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Gundemm), @"mvc.1.0.view", @"/Views/Shared/_Gundemm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8f575082ed5f9aa4b32d950a6f818f2151e381a", @"/Views/Shared/_Gundemm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8fc63bcb8d349f81a068b5fcbad8e8b987adfa2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Gundemm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SözlükForum.Models.ForumSoru>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""overflow-auto container "" style=""max-height:640px; position:fixed; border-right-style: solid; max-width:265px;"">
    <h3 class=""text-center"" style=""background-color:#e5e969; border-radius:5px;"">Gündem</h3>
    <hr />
    <ul class=""list-group"">
");
#nullable restore
#line 9 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Shared\_Gundemm.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a style=\"color:black\"");
            BeginWriteAttribute("href", " href=\"", 517, "\"", 550, 2);
            WriteAttributeValue("", 524, "/ForumSoru/Detail/", 524, 18, true);
#nullable restore
#line 11 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Shared\_Gundemm.cshtml"
WriteAttributeValue("", 542, item.Id, 542, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><li class=\"list-group-item list-group-item-action list-group-item-light text\" style=\"border-color:#e5e969\" >");
#nullable restore
#line 11 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Shared\_Gundemm.cshtml"
                                                                                                                                                                            Write(Html.DisplayFor(modelItem => item.soru));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li></a>\r\n");
#nullable restore
#line 12 "C:\Users\Tarık\Desktop\SözlükForum\SözlükForum\Views\Shared\_Gundemm.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
