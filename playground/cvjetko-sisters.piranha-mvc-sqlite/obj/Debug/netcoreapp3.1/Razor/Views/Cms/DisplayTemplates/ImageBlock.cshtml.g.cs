#pragma checksum "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-mvc-sqlite/Views/Cms/DisplayTemplates/ImageBlock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "759ff33c29f5e54757c8041b61d8586abb282007"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cms_DisplayTemplates_ImageBlock), @"mvc.1.0.view", @"/Views/Cms/DisplayTemplates/ImageBlock.cshtml")]
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
#line 1 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-mvc-sqlite/Views/_ViewImports.cshtml"
using Piranha.AspNetCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-mvc-sqlite/Views/_ViewImports.cshtml"
using cvjetko_sisters.piranha_mvc_sqlite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"759ff33c29f5e54757c8041b61d8586abb282007", @"/Views/Cms/DisplayTemplates/ImageBlock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fac4e918349584ba6cca4478535bb3a4c835f6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Cms_DisplayTemplates_ImageBlock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Piranha.Extend.Blocks.ImageBlock>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<img");
            BeginWriteAttribute("src", " src=\"", 45, "\"", 102, 1);
#nullable restore
#line 3 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-mvc-sqlite/Views/Cms/DisplayTemplates/ImageBlock.cshtml"
WriteAttributeValue("", 51, Url.Content(WebApp.Media.ResizeImage(Model, 1110)), 51, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Piranha.Extend.Blocks.ImageBlock> Html { get; private set; }
    }
}
#pragma warning restore 1591
