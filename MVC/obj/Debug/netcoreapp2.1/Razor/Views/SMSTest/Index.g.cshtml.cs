#pragma checksum "C:\New folder\PRPC\PRPC\MVC\Views\SMSTest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81b5d02609ef2346101a88cf6485ddc15543a2d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SMSTest_Index), @"mvc.1.0.view", @"/Views/SMSTest/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SMSTest/Index.cshtml", typeof(AspNetCore.Views_SMSTest_Index))]
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
#line 1 "C:\New folder\PRPC\PRPC\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#line 2 "C:\New folder\PRPC\PRPC\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#line 3 "C:\New folder\PRPC\PRPC\MVC\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81b5d02609ef2346101a88cf6485ddc15543a2d8", @"/Views/SMSTest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9daceda3ec4a61071afc06f5eb5ba3fb5dc0f4b9", @"/Views/_ViewImports.cshtml")]
    public class Views_SMSTest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\New folder\PRPC\PRPC\MVC\Views\SMSTest\Index.cshtml"
  
    ViewData["Title"] = "SMSTest";

#line default
#line hidden
            BeginContext(43, 20, true);
            WriteLiteral("<p>SMS Test</p>\r\n<p>");
            EndContext();
            BeginContext(64, 16, false);
#line 5 "C:\New folder\PRPC\PRPC\MVC\Views\SMSTest\Index.cshtml"
Write(ViewData["name"]);

#line default
#line hidden
            EndContext();
            BeginContext(80, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(90, 23, false);
#line 6 "C:\New folder\PRPC\PRPC\MVC\Views\SMSTest\Index.cshtml"
Write(ViewData["phoneNumber"]);

#line default
#line hidden
            EndContext();
            BeginContext(113, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(123, 25, false);
#line 7 "C:\New folder\PRPC\PRPC\MVC\Views\SMSTest\Index.cshtml"
Write(ViewData["messageResult"]);

#line default
#line hidden
            EndContext();
            BeginContext(148, 10, true);
            WriteLiteral("</p>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
