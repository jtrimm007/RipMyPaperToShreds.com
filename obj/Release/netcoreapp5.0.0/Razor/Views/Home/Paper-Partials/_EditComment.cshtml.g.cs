#pragma checksum "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3fba6f71ecc23dbf85f3e8659a0dc0939392443"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Paper_Partials__EditComment), @"mvc.1.0.view", @"/Views/Home/Paper-Partials/_EditComment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3fba6f71ecc23dbf85f3e8659a0dc0939392443", @"/Views/Home/Paper-Partials/_EditComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3cbbfa5339059b24fdcd144eadf927cd19cb27", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b81e3996575f667c9f5553e7a8522f8b06c48d01", @"/Views/Home/_ViewImports.cshtml")]
    public class Views_Home_Paper_Partials__EditComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RipMyPaperToShreds.com.Models.SubShreds>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("position: fixed;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml"
   
    string screenName = @UserManager.Users.FirstOrDefault(x => x.Id == Model.ShrederId).ScreenName;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("id", " id=\"", 213, "\"", 239, 2);
            WriteAttributeValue("", 218, "editComment-", 218, 12, true);
#nullable restore
#line 7 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml"
WriteAttributeValue("", 230, Model.ID, 230, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col\">\r\n    <input");
            BeginWriteAttribute("id", " id=\"", 265, "\"", 295, 2);
            WriteAttributeValue("", 270, "editCommentText-", 270, 16, true);
#nullable restore
#line 8 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml"
WriteAttributeValue("", 286, Model.ID, 286, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded small mb-1\" size=\"30\" type=\"text\" maxlength=\"150\" min=\"1\" placeholder=\"comment here\"");
            BeginWriteAttribute("value", " value=\"", 396, "\"", 419, 1);
#nullable restore
#line 8 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml"
WriteAttributeValue("", 404, Model.SubShred, 404, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <button id=\"submitComment\" class=\"btn btn-sm btn-success small\"");
            BeginWriteAttribute("onclick", " onclick=\"", 492, "\"", 542, 6);
            WriteAttributeValue("", 502, "updateComment(", 502, 14, true);
#nullable restore
#line 9 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml"
WriteAttributeValue("", 516, Model.ID, 516, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 525, ",", 525, 1, true);
            WriteAttributeValue(" ", 526, "\'", 527, 2, true);
#nullable restore
#line 9 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml"
WriteAttributeValue("", 528, screenName, 528, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 539, "\');", 539, 3, true);
            EndWriteAttribute();
            WriteLiteral(">Update</button> <button id=\"submitComment\" class=\"btn btn-sm btn-danger small\"");
            BeginWriteAttribute("onclick", " onclick=\"", 622, "\"", 656, 3);
            WriteAttributeValue("", 632, "deleteComment(", 632, 14, true);
#nullable restore
#line 9 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml"
WriteAttributeValue("", 646, Model.ID, 646, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 655, ")", 655, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button><button id=\"cancelComment\"");
            BeginWriteAttribute("onclick", " onclick=\"", 699, "\"", 737, 3);
            WriteAttributeValue("", 709, "cancelCommentEdit(", 709, 18, true);
#nullable restore
#line 9 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml"
WriteAttributeValue("", 727, Model.ID, 727, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 736, ")", 736, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-dark small\">x</button>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3fba6f71ecc23dbf85f3e8659a0dc09393924439693", async() => {
                WriteLiteral("\r\n    <input name=\"SubShred\"");
                BeginWriteAttribute("id", " id=\"", 996, "\"", 1019, 2);
                WriteAttributeValue("", 1001, "SubShred-", 1001, 9, true);
#nullable restore
#line 13 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml"
WriteAttributeValue("", 1010, Model.ID, 1010, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded small mb-1\" size=\"30\" type=\"text\" maxlength=\"150\" min=\"1\"");
                BeginWriteAttribute("value", " value=\"", 1093, "\"", 1116, 1);
#nullable restore
#line 13 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml"
WriteAttributeValue("", 1101, Model.SubShred, 1101, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input name=\"Date\"");
                BeginWriteAttribute("id", " id=\"", 1144, "\"", 1163, 2);
                WriteAttributeValue("", 1149, "Date-", 1149, 5, true);
#nullable restore
#line 14 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml"
WriteAttributeValue("", 1154, Model.ID, 1154, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden");
                BeginWriteAttribute("value", " value=\"", 1171, "\"", 1190, 1);
#nullable restore
#line 14 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml"
WriteAttributeValue("", 1179, Model.Date, 1179, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input name=\"ShredId\"");
                BeginWriteAttribute("id", " id=\"", 1221, "\"", 1243, 2);
                WriteAttributeValue("", 1226, "ShredId-", 1226, 8, true);
#nullable restore
#line 15 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml"
WriteAttributeValue("", 1234, Model.ID, 1234, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden");
                BeginWriteAttribute("value", " value=\"", 1251, "\"", 1273, 1);
#nullable restore
#line 15 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml"
WriteAttributeValue("", 1259, Model.ShredId, 1259, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input name=\"ShrederId\"");
                BeginWriteAttribute("id", " id=\"", 1306, "\"", 1330, 2);
                WriteAttributeValue("", 1311, "ShrederId-", 1311, 10, true);
#nullable restore
#line 16 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml"
WriteAttributeValue("", 1321, Model.ID, 1321, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden");
                BeginWriteAttribute("value", " value=\"", 1338, "\"", 1362, 1);
#nullable restore
#line 16 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml"
WriteAttributeValue("", 1346, Model.ShrederId, 1346, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input name=\"ID\"");
                BeginWriteAttribute("id", " id=\"", 1388, "\"", 1405, 2);
                WriteAttributeValue("", 1393, "ID-", 1393, 3, true);
#nullable restore
#line 17 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml"
WriteAttributeValue("", 1396, Model.ID, 1396, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden");
                BeginWriteAttribute("value", " value=\"", 1413, "\"", 1430, 1);
#nullable restore
#line 17 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml"
WriteAttributeValue("", 1421, Model.ID, 1421, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "name", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 839, "updateComment-", 839, 14, true);
#nullable restore
#line 12 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml"
AddHtmlAttributeValue("", 853, Model.ID, 853, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 882, "updateCommentForm-", 882, 18, true);
#nullable restore
#line 12 "C:\Users\Joshua\source\repos\RipMyPaperToShreds.com\RipMyPaperToShreds.com\Views\Home\Paper-Partials\_EditComment.cshtml"
AddHtmlAttributeValue("", 900, Model.ID, 900, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RipMyPaperToShreds.com.Models.SubShreds> Html { get; private set; }
    }
}
#pragma warning restore 1591
