#pragma checksum "c:\Users\ccowart\OneDrive - wtamu.edu\Documents\GitHub\PRPC\MVC\Areas\Identity\Pages\Account\Manage\ResetAuthenticator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3385c30931222eb651f9917c8cb3d8b2ca5d39d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MVC.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_ResetAuthenticator), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/ResetAuthenticator.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Manage/ResetAuthenticator.cshtml", typeof(MVC.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_ResetAuthenticator), null)]
namespace MVC.Areas.Identity.Pages.Account.Manage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "c:\Users\ccowart\OneDrive - wtamu.edu\Documents\GitHub\PRPC\MVC\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "c:\Users\ccowart\OneDrive - wtamu.edu\Documents\GitHub\PRPC\MVC\Areas\Identity\Pages\_ViewImports.cshtml"
using MVC.Areas.Identity;

#line default
#line hidden
#line 3 "c:\Users\ccowart\OneDrive - wtamu.edu\Documents\GitHub\PRPC\MVC\Areas\Identity\Pages\_ViewImports.cshtml"
using MVC.Areas.Identity.Data;

#line default
#line hidden
#line 1 "c:\Users\ccowart\OneDrive - wtamu.edu\Documents\GitHub\PRPC\MVC\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using MVC.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "c:\Users\ccowart\OneDrive - wtamu.edu\Documents\GitHub\PRPC\MVC\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using MVC.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3385c30931222eb651f9917c8cb3d8b2ca5d39d1", @"/Areas/Identity/Pages/Account/Manage/ResetAuthenticator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95e3908a74fa66a21981c4013bf3a31036e13046", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a13d68b5638bdc8454db8089f3660850a21505a", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1731c7f3dcd136766ca769e69f9e0ea5a459d57a", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_ResetAuthenticator : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("reset-authenticator-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "c:\Users\ccowart\OneDrive - wtamu.edu\Documents\GitHub\PRPC\MVC\Areas\Identity\Pages\Account\Manage\ResetAuthenticator.cshtml"
  
    ViewData["Title"] = "Reset authenticator key";
    ViewData["ActivePage"] = ManageNavPages.TwoFactorAuthentication;

#line default
#line hidden
            BeginContext(162, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(164, 51, false);
#line 8 "c:\Users\ccowart\OneDrive - wtamu.edu\Documents\GitHub\PRPC\MVC\Areas\Identity\Pages\Account\Manage\ResetAuthenticator.cshtml"
Write(Html.Partial("_StatusMessage", Model.StatusMessage));

#line default
#line hidden
            EndContext();
            BeginContext(215, 5, true);
            WriteLiteral("\n<h4>");
            EndContext();
            BeginContext(221, 17, false);
#line 9 "c:\Users\ccowart\OneDrive - wtamu.edu\Documents\GitHub\PRPC\MVC\Areas\Identity\Pages\Account\Manage\ResetAuthenticator.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(238, 471, true);
            WriteLiteral(@"</h4>
<div class=""alert alert-warning"" role=""alert"">
    <p>
        <span class=""glyphicon glyphicon-warning-sign""></span>
        <strong>If you reset your authenticator key your authenticator app will not work until you reconfigure it.</strong>
    </p>
    <p>
        This process disables 2FA until you verify your authenticator app.
        If you do not complete your authenticator app configuration you may lose access to your account.
    </p>
</div>
<div>
    ");
            EndContext();
            BeginContext(709, 199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8ebf4a76cc04ce7815813720f7839d5", async() => {
                BeginContext(778, 123, true);
                WriteLiteral("\n        <button id=\"reset-authenticator-button\" class=\"btn btn-danger\" type=\"submit\">Reset authenticator key</button>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(908, 7, true);
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResetAuthenticatorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ResetAuthenticatorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ResetAuthenticatorModel>)PageContext?.ViewData;
        public ResetAuthenticatorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
