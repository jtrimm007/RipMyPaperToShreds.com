#pragma checksum "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Papers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "730545c6d866e69c6939482314c2fcc2d6a29e31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Papers), @"mvc.1.0.view", @"/Views/Home/Papers.cshtml")]
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
#line 1 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\_ViewImports.cshtml"
using RipMyPaperToShreds.com;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\_ViewImports.cshtml"
using RipMyPaperToShreds.com.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\_ViewImports.cshtml"
using RipMyPaperToShreds.com.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\_ViewImports.cshtml"
using RipMyPaperToShreds.com.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"730545c6d866e69c6939482314c2fcc2d6a29e31", @"/Views/Home/Papers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3cbbfa5339059b24fdcd144eadf927cd19cb27", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b81e3996575f667c9f5553e7a8522f8b06c48d01", @"/Views/Home/_ViewImports.cshtml")]
    public class Views_Home_Papers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RipMyPaperToShreds.com.Models.Papers>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Paper", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Papers.cshtml"
  
    ViewData["Title"] = "Papers";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main id=\"main\">\r\n    <section id=\"services\" class=\"services mt-5\">\r\n        <div class=\"container\">\r\n            <div class=\"section-title\" data-aos=\"fade-up\">\r\n                <h2>");
#nullable restore
#line 12 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Papers.cshtml"
               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p>Browser all of the current papers.</p>\r\n            </div>\r\n");
            WriteLiteral("\r\n\r\n        <div class=\"shadow pt-3 mb-5\">\r\n\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 913, "\"", 921, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div id=\"cardHolder\" class=\"container-fluid \">\r\n");
#nullable restore
#line 29 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Papers.cshtml"
                     foreach (var item in Model)
                    {



#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"card\" class=\"card\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "730545c6d866e69c6939482314c2fcc2d6a29e316550", async() => {
                WriteLiteral("\r\n                            <div class=\"row p-4\">\r\n                                <div class=\"text-dark col-8\">\r\n                                    <h3>");
#nullable restore
#line 37 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Papers.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                                </div>\r\n                                <div class=\"text-dark col-4 d-flex flex-row-reverse\">\r\n                                    <p class=\"small\">");
#nullable restore
#line 40 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Papers.cshtml"
                                                Write(item.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n\r\n                            <div class=\"card-body\">\r\n                                <div class=\"text-dark col-12\"><h5>");
#nullable restore
#line 45 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Papers.cshtml"
                                                             Write(item.Paper);

#line default
#line hidden
#nullable disable
                WriteLiteral(" .....</h5></div>\r\n                                <div class=\"text-decoration-none col-4\"><p class=\"small\">Read More</p></div>\r\n\r\n                            </div>\r\n\r\n                            \r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Papers.cshtml"
                                                                                            WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 53 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Papers.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""d-flex justify-content-center"">
                    <button class=""m-3 btn btn-dark"" onclick=""OnClick()"">Load More</button>
                </div>
            </div>
        </div>            

        </div>
    </section>
</main>

<script>
    let page = 0;

    function OnClick() {
        page++;

        $.ajax({
            url: ""/Home/NextPage/"" + page,
            success: function _success(response) {
                console.log(response);
                document.getElementById('cardHolder').innerHTML += response;
            }
        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RipMyPaperToShreds.com.Models.Papers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
