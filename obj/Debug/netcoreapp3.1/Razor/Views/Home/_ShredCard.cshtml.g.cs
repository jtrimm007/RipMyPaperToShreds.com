#pragma checksum "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\_ShredCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d9892cb05315d1782e0245e287e113a0d006e6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ShredCard), @"mvc.1.0.view", @"/Views/Home/_ShredCard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d9892cb05315d1782e0245e287e113a0d006e6e", @"/Views/Home/_ShredCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3cbbfa5339059b24fdcd144eadf927cd19cb27", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b81e3996575f667c9f5553e7a8522f8b06c48d01", @"/Views/Home/_ViewImports.cshtml")]
    public class Views_Home__ShredCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<!--Start Shred Card-->

    <div class=""shadow p-2 mt-5 container-fluid"">

        <div class=""row m-3 border-bottom"">
            <!--Up and Down Vote Buttons-->
            <div id=""rip-vote-container"" class=""col-2 pl-0 ml-0"">
                <p title=""Number of up votes"" class=""m-0 p-0"">123</p>
                <span id=""upVoteButton"" class=""btn m-0 p-0"" title=""Up Vote"" onclick=""turnRed()"">
                    <svg class=""bi bi-arrow-up-square mb-1"" width=""2em"" height=""2em"" viewBox=""0 0 16 16"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"" title=""Up Vote"">
                        <path id=""up1"" fill=""Gainsboro"" fill-rule=""evenodd"" d=""M14 1H2a1 1 0 0 0-1 1v12a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1V2a1 1 0 0 0-1-1zM2 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2H2z"" />
                        <path id=""up2"" fill=""Gainsboro"" fill-rule=""evenodd"" d=""M4.646 8.354a.5.5 0 0 0 .708 0L8 5.707l2.646 2.647a.5.5 0 0 0 .708-.708l-3-3a.5.5 0 0 0-.708 0l-3 3a.5.5 0 0 0 0 .708z"" />
       ");
            WriteLiteral(@"                 <path id=""up3"" fill=""Gainsboro"" fill-rule=""evenodd"" d=""M8 11.5a.5.5 0 0 0 .5-.5V6a.5.5 0 0 0-1 0v5a.5.5 0 0 0 .5.5z"" />
                    </svg>
                </span>
                <span id=""downVoteButton"" class=""btn m-0 p-0"" title=""Down Vote"" onclick=""turnDownVoteRed()"">
                    <svg class=""bi bi-arrow-down-square"" width=""2em"" height=""2em"" viewBox=""0 0 16 16"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                        <path id=""down1"" fill=""Gainsboro"" fill-rule=""evenodd"" d=""M14 1H2a1 1 0 0 0-1 1v12a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1V2a1 1 0 0 0-1-1zM2 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h12a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2H2z"" />
                        <path id=""down2"" fill=""Gainsboro"" fill-rule=""evenodd"" d=""M4.646 7.646a.5.5 0 0 1 .708 0L8 10.293l2.646-2.647a.5.5 0 0 1 .708.708l-3 3a.5.5 0 0 1-.708 0l-3-3a.5.5 0 0 1 0-.708z"" />
                        <path id=""down3"" fill=""Gainsboro"" fill-rule=""evenodd"" d=""M8 4.5a.5.5 0 0 1 .5.5v5a.5.5 0 0 1-1 0V5a.5.5 0");
            WriteLiteral(@" 0 1 .5-.5z"" />
                    </svg>
                </span>

                <span id=""fixedButton"" class=""btn m-0 p-0"" title=""Improved Paper"">
                    <svg class=""bi bi-check2-square mt-3 mb-1"" width=""2em"" height=""2em"" viewBox=""0 0 16 16"" fill=""LimeGreen"" xmlns=""http://www.w3.org/2000/svg"">
                        <path fill=""LimeGreen"" fill-rule=""evenodd"" d=""M15.354 2.646a.5.5 0 0 1 0 .708l-7 7a.5.5 0 0 1-.708 0l-3-3a.5.5 0 1 1 .708-.708L8 9.293l6.646-6.647a.5.5 0 0 1 .708 0z"" />
                        <path fill=""LimeGreen"" fill-rule=""evenodd"" d=""M1.5 13A1.5 1.5 0 0 0 3 14.5h10a1.5 1.5 0 0 0 1.5-1.5V8a.5.5 0 0 0-1 0v5a.5.5 0 0 1-.5.5H3a.5.5 0 0 1-.5-.5V3a.5.5 0 0 1 .5-.5h8a.5.5 0 0 0 0-1H3A1.5 1.5 0 0 0 1.5 3v10z"" />
                    </svg>
                </span>
            </div>
            <div class=""col-10"">
                <blockquote class=""blockquote text-right"">
                    <p class=""small""><em>""Good teachers love that because it lets them give good wr");
            WriteLiteral(@"iters extra scores.""</em></p>
                    <footer class=""blockquote-footer""><cite title=""Source Title"">jomammy</cite></footer>
                </blockquote>

            </div>
        </div>
        <div class=""row  m-3"">
            <div class=""col""><p class=""small"">jomammy</p></div>
            <div class=""col""><p class=""small"">12/12/12 12:12 pm</p></div>
        </div>
        <div class=""row mr-2 ml-2 border-bottom"">
            <div class=""col"">
                <p>I am thinking that he lets should be let's, with an apostrophe.</p>
            </div>
        </div>
        <div class=""row m-3"">
            <div>
                <p class=""small""><strong>Sub-Shreds</strong></p>
            </div>
        </div>
        <div class=""row  mt-3 mr-3 ml-3 mb-0"">
            <div class=""col"">
                <p class=""small""><em>Shreder</em></p>
            </div>
            <div class=""col"">
                <p class=""small"">12/13/12 12:12 pm</p>
            </div>
        </d");
            WriteLiteral(@"iv>
        <div class=""row mr-3 ml-3"">
            <div class=""col"">
                <p class=""small"">I don't agree with putting an apostrophe there.</p>
            </div>
        </div>
        <div class=""row mr-3 ml-3"">
            <div class=""col"">
                <p class=""small""><em><button class=""small btn btn-sm btn-link"">comment</button></em></p>
            </div>
        </div>
    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591