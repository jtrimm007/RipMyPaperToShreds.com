#pragma checksum "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\_Comment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8667417aeaa7757185a9bfc254e3733ce1b19cb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Comment), @"mvc.1.0.view", @"/Views/Home/_Comment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8667417aeaa7757185a9bfc254e3733ce1b19cb6", @"/Views/Home/_Comment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3cbbfa5339059b24fdcd144eadf927cd19cb27", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b81e3996575f667c9f5553e7a8522f8b06c48d01", @"/Views/Home/_ViewImports.cshtml")]
    public class Views_Home__Comment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""col"">
    <input class=""rounded small"" size=""30"" type=""text"" maxlength=""150"" min=""1"" placeholder=""comment here"" />
    <button id=""submitComment"" class=""btn btn-sm btn-success small"">Submit</button><button id=""cancelComment"" class=""btn btn-sm btn-danger small"">x</button>
</div>");
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
