#pragma checksum "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a6440f98bde11ebe595f7b3cf324b5cb16bb936"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\_ViewImports.cshtml"
using Blog;

#line default
#line hidden
#line 2 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a6440f98bde11ebe595f7b3cf324b5cb16bb936", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60de8826b8954e9153bb5ddebbd8520bddd0a921", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var empty = true;

#line default
#line hidden
            BeginContext(94, 29, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(123, 379, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66756e5186f94d8bba1c27e034f6b43f", async() => {
                BeginContext(129, 121, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
                EndContext();
                BeginContext(251, 17, false);
#line 13 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Index.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(268, 30, true);
                WriteLiteral(" - Herman\'s Blog</title>\r\n    ");
                EndContext();
                BeginContext(298, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f163efbbe92643378f0fe1f9ce0f2d69", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(345, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(351, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a2a9d7f27674edd8970ddc0a0489c76", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(422, 73, true);
                WriteLiteral("\r\n    <script src=\"https://use.fontawesome.com/d1341f9b7a.js\"></script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(502, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(504, 2776, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b54a779ed6564ba5b7f45163e5ba7cd6", async() => {
                BeginContext(510, 522, true);
                WriteLiteral(@"
    <div id=""fb-root""></div>
    <script async defer crossorigin=""anonymous"" src=""https://connect.facebook.net/en_US/sdk.js#xfbml=1&version=v4.0""></script>
    <br />
    <div class=""card border-primary mb-12"">
        <h3 class=""card-header"">Welcome to my blog!</h3>
        <div class=""card-body"">
            <p class=""card-text"">My name is Herman, and this is my personal website where I share the projects I like to work on.</p>
        </div>
    </div>

    <br />
    <br />

    <div class=""row"">
");
                EndContext();
#line 33 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Index.cshtml"
         foreach (var post in Model)
        {

#line default
#line hidden
                BeginContext(1081, 97, true);
                WriteLiteral("            <div class=\"col-sm-4\">\r\n                <div class=\"card mb-3\">\r\n                    ");
                EndContext();
                BeginContext(1178, 159, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dfc3f86dde546acab8b0b72a98b4a89", async() => {
                    BeginContext(1245, 50, true);
                    WriteLiteral("\r\n                        <h3 class=\"card-header\">");
                    EndContext();
                    BeginContext(1296, 10, false);
#line 38 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Index.cshtml"
                                           Write(post.Title);

#line default
#line hidden
                    EndContext();
                    BeginContext(1306, 27, true);
                    WriteLiteral("</h3>\r\n                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 37 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Index.cshtml"
                                                                 WriteLiteral(post.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1337, 108, true);
                WriteLiteral("\r\n                    <div class=\"card-body\">\r\n                        <h6 class=\"card-subtitle text-muted\">");
                EndContext();
                BeginContext(1446, 32, false);
#line 41 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Index.cshtml"
                                                        Write(post.Created.ToShortDateString());

#line default
#line hidden
                EndContext();
                BeginContext(1478, 35, true);
                WriteLiteral("</h6>\r\n                    </div>\r\n");
                EndContext();
#line 43 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Index.cshtml"
                      var image_path = $"/Image/{post.Image}";

#line default
#line hidden
                BeginContext(1578, 63, true);
                WriteLiteral("                    <img style=\"height: 300px; display: block;\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1641, "\"", 1658, 1);
#line 44 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Index.cshtml"
WriteAttributeValue("", 1647, image_path, 1647, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1659, 301, true);
                WriteLiteral(@" alt=""Card image"">
                    <!--
                    <div class=""card-body"">
                        <p class=""card-text"">""summury goes here""</p>
                    </div>
                    -->
                    <div class=""list-group list-group-flush"">
                        ");
                EndContext();
                BeginContext(1960, 107, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c215c244adb4d4799bd700afada2d38", async() => {
                    BeginContext(2051, 12, true);
                    WriteLiteral("More Details");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 51 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Index.cshtml"
                                                                                             WriteLiteral(post.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2067, 153, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"card-footer text-muted\">\r\n                        <a>Share to Facebook! &nbsp; &nbsp;</a>\r\n");
                EndContext();
#line 55 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Index.cshtml"
                          var fbLink = $"https://www.facebook.com/sharer/sharer.php?u=https%3A%2F%2Fhttps://localhost:44363/Home/Post/{post.Id}%2F&amp;src=sdkpreparse";

#line default
#line hidden
                BeginContext(2391, 26, true);
                WriteLiteral("                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=", 2417, "", 2430, 1);
#line 56 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Index.cshtml"
WriteAttributeValue("", 2423, fbLink, 2423, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2430, 160, true);
                WriteLiteral(" class=\"card-link\"><i class=\"fa fa-facebook-square fa-lg\" aria-hidden=\"true\"></i></a>\r\n                    </div>\r\n                </div>\r\n                <a>\r\n");
                EndContext();
#line 60 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Index.cshtml"
                      empty = false;

#line default
#line hidden
                BeginContext(2629, 42, true);
                WriteLiteral("                </a>\r\n            </div>\r\n");
                EndContext();
#line 63 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(2682, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
#line 66 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Index.cshtml"
     if (empty)
    {

#line default
#line hidden
                BeginContext(2720, 381, true);
                WriteLiteral(@"        <div class=""card border-primary mb-12"">
            <h3 class=""card-header"">There are currently no blog posts to display</h3>
            <div class=""card-body"">
                <p class=""card-text"">This site is under 1 week old, so check back soon for great content posted bi-weekly.</p>
                <p class=""card-text"">Until there are posts added, check out the ");
                EndContext();
                BeginContext(3101, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59af9f05c88147a09a1fb410b08228ec", async() => {
                    BeginContext(3157, 5, true);
                    WriteLiteral("about");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3166, 100, true);
                WriteLiteral(" page to learn about me and about how this site was built!</p>\r\n            </div>\r\n        </div>\r\n");
                EndContext();
#line 75 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3280, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
