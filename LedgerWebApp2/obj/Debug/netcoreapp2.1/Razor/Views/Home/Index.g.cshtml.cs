#pragma checksum "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85330acec38dfe067332b85b4c8786941aaca29f"
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
#line 1 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\_ViewImports.cshtml"
using LedgerWebApp2;

#line default
#line hidden
#line 2 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\_ViewImports.cshtml"
using LedgerWebApp2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85330acec38dfe067332b85b4c8786941aaca29f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbda22e111eac23e377728e3c1c673b46e4469c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 668, true);
            WriteLiteral(@"
<div><h1>Bank Ledger Web Application</h1></div>

<div><h2>Ledger Options</h2></div>
<div>
    <p><button onclick=""window.location.href = 'Home/CheckBalance';"" type=""button"">Check Balance</button></p>
    <p><button onclick=""window.location.href = 'Home/RecordDeposit';"" type=""button"">Record Deposit</button></p>
    <p><button onclick=""window.location.href = 'Home/RecordWithdrawal';"" type=""button"">Record Withdrawal</button></p>
    <p><button onclick=""window.location.href = 'Home/ViewHistory';"" type=""button"">View Transaction History</button></p>
    <p><button onclick=""window.location.href = 'Home/Logout';"" type=""button"">Logout</button></p>

</div>
");
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