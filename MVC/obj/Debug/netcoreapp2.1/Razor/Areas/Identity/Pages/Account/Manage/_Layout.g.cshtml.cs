#pragma checksum "C:\New folder\PRPC\PRPC\MVC\Areas\Identity\Pages\Account\Manage\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3101fbdd7c7cb80bf9be8f26794a73da47b6495f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MVC.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage__Layout), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml", typeof(MVC.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage__Layout))]
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
#line 1 "C:\New folder\PRPC\PRPC\MVC\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\New folder\PRPC\PRPC\MVC\Areas\Identity\Pages\_ViewImports.cshtml"
using MVC.Areas.Identity;

#line default
#line hidden
#line 3 "C:\New folder\PRPC\PRPC\MVC\Areas\Identity\Pages\_ViewImports.cshtml"
using MVC.Areas.Identity.Data;

#line default
#line hidden
#line 1 "C:\New folder\PRPC\PRPC\MVC\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using MVC.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "C:\New folder\PRPC\PRPC\MVC\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using MVC.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3101fbdd7c7cb80bf9be8f26794a73da47b6495f", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95e3908a74fa66a21981c4013bf3a31036e13046", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a13d68b5638bdc8454db8089f3660850a21505a", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1731c7f3dcd136766ca769e69f9e0ea5a459d57a", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ManageNav", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\New folder\PRPC\PRPC\MVC\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
   
    Layout = "/Areas/Identity/Pages/_Layout.cshtml";

#line default
#line hidden
            BeginContext(59, 155, true);
            WriteLiteral("\n<h2>Manage your account</h2>\n\n<div>\n    <h4>Change your account settings</h4>\n    <hr />\n    <div class=\"row\">\n        <div class=\"col-md-3\">\n            ");
            EndContext();
            BeginContext(214, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "981dd2dd3008433a97863b4673d56a32", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(243, 59, true);
            WriteLiteral("\n        </div>\n        <div class=\"col-md-9\">\n            ");
            EndContext();
            BeginContext(303, 12, false);
#line 15 "C:\New folder\PRPC\PRPC\MVC\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(315, 35, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(368, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(374, 41, false);
#line 21 "C:\New folder\PRPC\PRPC\MVC\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(415, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
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
