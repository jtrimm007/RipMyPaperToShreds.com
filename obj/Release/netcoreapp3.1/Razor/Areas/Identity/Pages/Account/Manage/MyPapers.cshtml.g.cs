#pragma checksum "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Areas\Identity\Pages\Account\Manage\MyPapers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3f2de7fffcbd439425556c86d831e7bc72e2791"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage_MyPapers), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/MyPapers.cshtml")]
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
#line 1 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Areas\Identity\Pages\_ViewImports.cshtml"
using RipMyPaperToShreds.com.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Areas\Identity\Pages\_ViewImports.cshtml"
using RipMyPaperToShreds.com.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using RipMyPaperToShreds.com.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using RipMyPaperToShreds.com.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using RipMyPaperToShreds.com.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3f2de7fffcbd439425556c86d831e7bc72e2791", @"/Areas/Identity/Pages/Account/Manage/MyPapers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f17aa9d41fdc13a5b89964b1e0a8ace0b09ca558", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9611ef808aede7af9592d35454c4e2f85799ff2", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39767cd76da749af64bf38586951ce831eb40c2a", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_MyPapers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Areas\Identity\Pages\Account\Manage\MyPapers.cshtml"
  
    ViewData["Title"] = "My Papers";
    ViewData["ActivePage"] = ManageNavPages.MyPapers;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h4>");
#nullable restore
#line 8 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Areas\Identity\Pages\Account\Manage\MyPapers.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RipMyPaperToShreds.com.Areas.Identity.Pages.Account.Manage.MyPapersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RipMyPaperToShreds.com.Areas.Identity.Pages.Account.Manage.MyPapersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RipMyPaperToShreds.com.Areas.Identity.Pages.Account.Manage.MyPapersModel>)PageContext?.ViewData;
        public RipMyPaperToShreds.com.Areas.Identity.Pages.Account.Manage.MyPapersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
