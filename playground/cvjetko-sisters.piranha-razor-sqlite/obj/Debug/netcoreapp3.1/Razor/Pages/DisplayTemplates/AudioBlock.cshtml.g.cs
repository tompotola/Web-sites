#pragma checksum "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/DisplayTemplates/AudioBlock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30aaa49ac69c54f919410a5dcc10f219ecf8a738"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(cvjetko_sisters.piranha_razor_sqlite.Pages.DisplayTemplates.Pages_DisplayTemplates_AudioBlock), @"mvc.1.0.view", @"/Pages/DisplayTemplates/AudioBlock.cshtml")]
namespace cvjetko_sisters.piranha_razor_sqlite.Pages.DisplayTemplates
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
#line 1 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/_ViewImports.cshtml"
using Piranha.AspNetCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/_ViewImports.cshtml"
using cvjetko_sisters.piranha_razor_sqlite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30aaa49ac69c54f919410a5dcc10f219ecf8a738", @"/Pages/DisplayTemplates/AudioBlock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01d6a23f1d55e9caa8ca496fad7da5369092a83e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DisplayTemplates_AudioBlock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Piranha.Extend.Blocks.AudioBlock>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<audio width=\"100%\" controls>\n    <source");
            BeginWriteAttribute("src", " src=\"", 82, "\"", 112, 1);
#nullable restore
#line 4 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/DisplayTemplates/AudioBlock.cshtml"
WriteAttributeValue("", 88, Url.Content(Model.Body), 88, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("type", " type=\"", 113, "\"", 120, 0);
            EndWriteAttribute();
            WriteLiteral(">\n    Your browser does not support the audio tag.\n</audio>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Piranha.Extend.Blocks.AudioBlock> Html { get; private set; }
    }
}
#pragma warning restore 1591
