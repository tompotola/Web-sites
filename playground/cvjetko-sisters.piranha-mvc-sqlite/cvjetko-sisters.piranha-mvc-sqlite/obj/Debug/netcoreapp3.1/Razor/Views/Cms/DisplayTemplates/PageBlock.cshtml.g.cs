#pragma checksum "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-mvc-sqlite/cvjetko-sisters.piranha-mvc-sqlite/Views/Cms/DisplayTemplates/PageBlock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b65e4b4c09764ea8c402b4d4f8dfd2a500fe084"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_DisplayTemplates_PageBlock), @"mvc.1.0.view", @"/Views/Cms/DisplayTemplates/PageBlock.cshtml")]
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
#line 1 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-mvc-sqlite/cvjetko-sisters.piranha-mvc-sqlite/Views/_ViewImports.cshtml"
using Piranha.AspNetCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-mvc-sqlite/cvjetko-sisters.piranha-mvc-sqlite/Views/_ViewImports.cshtml"
using cvjetko_sisters.piranha_mvc_sqlite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b65e4b4c09764ea8c402b4d4f8dfd2a500fe084", @"/Views/Cms/DisplayTemplates/PageBlock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fac4e918349584ba6cca4478535bb3a4c835f6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_DisplayTemplates_PageBlock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Piranha.Extend.Blocks.PageBlock>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-mvc-sqlite/cvjetko-sisters.piranha-mvc-sqlite/Views/Cms/DisplayTemplates/PageBlock.cshtml"
 if (Model.Body.Page != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\n");
#nullable restore
#line 6 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-mvc-sqlite/cvjetko-sisters.piranha-mvc-sqlite/Views/Cms/DisplayTemplates/PageBlock.cshtml"
         if (Model.Body.Page.PrimaryImage.HasValue)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 171, "\"", 204, 1);
#nullable restore
#line 8 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-mvc-sqlite/cvjetko-sisters.piranha-mvc-sqlite/Views/Cms/DisplayTemplates/PageBlock.cshtml"
WriteAttributeValue("", 178, Model.Body.Page.Permalink, 178, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 248, "\"", 332, 1);
#nullable restore
#line 9 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-mvc-sqlite/cvjetko-sisters.piranha-mvc-sqlite/Views/Cms/DisplayTemplates/PageBlock.cshtml"
WriteAttributeValue("", 254, Url.Content(WebApp.Media.ResizeImage(Model.Body.Page.PrimaryImage, 540, 200)), 254, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            </a>\n");
#nullable restore
#line 11 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-mvc-sqlite/cvjetko-sisters.piranha-mvc-sqlite/Views/Cms/DisplayTemplates/PageBlock.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card-body\">\n            <h5>");
#nullable restore
#line 13 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-mvc-sqlite/cvjetko-sisters.piranha-mvc-sqlite/Views/Cms/DisplayTemplates/PageBlock.cshtml"
           Write(Model.Body.Page.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n            <p>");
#nullable restore
#line 14 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-mvc-sqlite/cvjetko-sisters.piranha-mvc-sqlite/Views/Cms/DisplayTemplates/PageBlock.cshtml"
          Write(Html.Raw(Model.Body.Page.Excerpt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <a");
            BeginWriteAttribute("href", " href=\"", 506, "\"", 539, 1);
#nullable restore
#line 15 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-mvc-sqlite/cvjetko-sisters.piranha-mvc-sqlite/Views/Cms/DisplayTemplates/PageBlock.cshtml"
WriteAttributeValue("", 513, Model.Body.Page.Permalink, 513, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-primary\">Read more</a>\n        </div>\n    </div>\n");
#nullable restore
#line 18 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-mvc-sqlite/cvjetko-sisters.piranha-mvc-sqlite/Views/Cms/DisplayTemplates/PageBlock.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Piranha.AspNetCore.Services.IApplicationService WebApp { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Piranha.Extend.Blocks.PageBlock> Html { get; private set; }
    }
}
#pragma warning restore 1591