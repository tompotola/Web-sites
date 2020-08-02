#pragma checksum "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e6ad13788a6b9806af89192d6fe56e11efa4c37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(cvjetko_sisters.piranha_razor_sqlite.Pages.Pages_Archive), @"mvc.1.0.razor-page", @"/Pages/Archive.cshtml")]
namespace cvjetko_sisters.piranha_razor_sqlite.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e6ad13788a6b9806af89192d6fe56e11efa4c37", @"/Pages/Archive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01d6a23f1d55e9caa8ca496fad7da5369092a83e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Archive : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
  
    ViewData["Title"] = Model.Data.Title;
    var hasImage = Model.Data.PrimaryImage.HasValue;

    var posts = Model.Archive.Posts.Count;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<header ");
#nullable restore
#line 10 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
    Write(hasImage ? "class=has-image" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
                                         Write(hasImage ? $"style=background-image:url({ @Url.Content(WebApp.Media.ResizeImage(Model.Data.PrimaryImage, 1920, 400)) })" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\n    <div class=\"dimmer\"></div>\n    <div class=\"container text-center\">\n        <h1>");
#nullable restore
#line 13 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
       Write(Model.Data.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
#nullable restore
#line 14 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
         if (!string.IsNullOrWhiteSpace(Model.Data.Excerpt))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row justify-content-center\">\n                <div class=\"col-lg-8 lead\">\n                    ");
#nullable restore
#line 18 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
               Write(Html.Raw(Model.Data.Excerpt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n");
#nullable restore
#line 21 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</header>\n\n<main class=\"archive\">\n");
#nullable restore
#line 26 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
     foreach (var block in Model.Data.Blocks)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 872, "\"", 902, 2);
            WriteAttributeValue("", 880, "block", 880, 5, true);
#nullable restore
#line 28 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
WriteAttributeValue(" ", 885, block.CssName(), 886, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <div class=\"container\">\n                ");
#nullable restore
#line 30 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
           Write(Html.DisplayFor(m => block, block.GetType().Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n");
#nullable restore
#line 33 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\n");
#nullable restore
#line 35 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
         for (var n = 0; n < posts; n += 2)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\n");
#nullable restore
#line 38 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
                 for (var i = n; i < Math.Min(posts, n + 2); i++)
                {
                    var post = Model.Archive.Posts[i];


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 1324, "\"", 1368, 1);
#nullable restore
#line 42 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
WriteAttributeValue("", 1332, i == 0 ? "col-md-12" : "col-md-6", 1332, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        <article>\n                            <header>\n");
#nullable restore
#line 45 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
                                 if (post.PrimaryImage.HasValue)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a");
            BeginWriteAttribute("href", " href=\"", 1579, "\"", 1601, 1);
#nullable restore
#line 47 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
WriteAttributeValue("", 1586, post.Permalink, 1586, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                        <img class=\"rounded mb-3\"");
            BeginWriteAttribute("src", " src=\"", 1669, "\"", 1743, 1);
#nullable restore
#line 48 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
WriteAttributeValue("", 1675, Url.Content(WebApp.Media.ResizeImage(post.PrimaryImage, 1140, 450)), 1675, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1744, "\"", 1782, 1);
#nullable restore
#line 48 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
WriteAttributeValue("", 1750, post.PrimaryImage.Media.AltText, 1750, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                    </a>\n");
#nullable restore
#line 50 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <h3>");
#nullable restore
#line 51 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
                               Write(post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                                <p class=\"post-meta\">\n                                    <span>\n                                        In <a");
            BeginWriteAttribute("href", " href=\"", 2055, "\"", 2112, 3);
#nullable restore
#line 54 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
WriteAttributeValue("", 2062, Model.Data.Permalink, 2062, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2083, "/category/", 2083, 10, true);
#nullable restore
#line 54 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
WriteAttributeValue("", 2093, post.Category.Slug, 2093, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 54 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
                                                                                                   Write(post.Category.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                    </span>\n                                    <span>\n                                        Tags\n");
#nullable restore
#line 58 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
                                         foreach (var tag in post.Tags)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a");
            BeginWriteAttribute("href", " href=\"", 2431, "\"", 2473, 3);
#nullable restore
#line 60 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
WriteAttributeValue("", 2438, Model.Data.Permalink, 2438, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2459, "/tag/", 2459, 5, true);
#nullable restore
#line 60 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
WriteAttributeValue("", 2464, tag.Slug, 2464, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">#");
#nullable restore
#line 60 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
                                                                                      Write(tag.Slug);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n");
#nullable restore
#line 61 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </span>\n");
#nullable restore
#line 63 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
                                     if (post.IsPublished)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>\n                                            Published ");
#nullable restore
#line 66 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
                                                 Write(post.Published.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </span>\n");
#nullable restore
#line 68 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
                                     if (post.EnableComments && post.CommentCount > 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 3120, "\"", 3151, 2);
#nullable restore
#line 72 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
WriteAttributeValue("", 3127, post.Permalink, 3127, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3142, "#comments", 3142, 9, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 72 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
                                                                          Write(post.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 72 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
                                                                                              Write(post.CommentCount == 1 ? "comment" : "comments");

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                        </span>\n");
#nullable restore
#line 74 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </p>\n                                <p>");
#nullable restore
#line 76 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
                              Write(Html.Raw(post.Excerpt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3447, "\"", 3469, 1);
#nullable restore
#line 77 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
WriteAttributeValue("", 3454, post.Permalink, 3454, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Read more</a>\n                            </header>\n                        </article>\n                    </div>\n");
#nullable restore
#line 81 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
                     if (i == 0)
                    {
                        n--;
                        break;
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n");
#nullable restore
#line 88 "/Users/Shared/Projects/e/personal/Web-sites/playground/cvjetko-sisters.piranha-razor-sqlite/Pages/Archive.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</main>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArchivePage<StandardArchive, Piranha.Models.PostInfo>> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ArchivePage<StandardArchive, Piranha.Models.PostInfo>> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ArchivePage<StandardArchive, Piranha.Models.PostInfo>>)PageContext?.ViewData;
        public ArchivePage<StandardArchive, Piranha.Models.PostInfo> Model => ViewData.Model;
    }
}
#pragma warning restore 1591