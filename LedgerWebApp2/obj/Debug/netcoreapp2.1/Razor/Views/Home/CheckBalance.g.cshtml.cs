#pragma checksum "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\CheckBalance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91422e4531fe8254ebdb2229371dbd82293b8272"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CheckBalance), @"mvc.1.0.view", @"/Views/Home/CheckBalance.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CheckBalance.cshtml", typeof(AspNetCore.Views_Home_CheckBalance))]
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
#line 1 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\_ViewImports.cshtml"
using LedgerWebApp2;

#line default
#line hidden
#line 2 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\_ViewImports.cshtml"
using LedgerWebApp2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91422e4531fe8254ebdb2229371dbd82293b8272", @"/Views/Home/CheckBalance.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbda22e111eac23e377728e3c1c673b46e4469c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CheckBalance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\CheckBalance.cshtml"
  
    ViewData["Title"] = "CheckBalance";

#line default
#line hidden
            BeginContext(48, 28, true);
            WriteLiteral("\r\n<h2>CheckBalance</h2>\r\n<p>");
            EndContext();
            BeginContext(77, 15, false);
#line 6 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\CheckBalance.cshtml"
Write(ViewBag.Balance);

#line default
#line hidden
            EndContext();
            BeginContext(92, 4, true);
            WriteLiteral("</p>");
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
