#pragma checksum "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\RecordWithdrawal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "774cdda1a9dc332ae535a97a50818031ba29cf86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RecordWithdrawal), @"mvc.1.0.view", @"/Views/Home/RecordWithdrawal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/RecordWithdrawal.cshtml", typeof(AspNetCore.Views_Home_RecordWithdrawal))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"774cdda1a9dc332ae535a97a50818031ba29cf86", @"/Views/Home/RecordWithdrawal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbda22e111eac23e377728e3c1c673b46e4469c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RecordWithdrawal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LedgerWebApp2.Models.RecordTransactionModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\RecordWithdrawal.cshtml"
  
    ViewData["Title"] = "RecordWithdrawal";

#line default
#line hidden
            BeginContext(106, 31, true);
            WriteLiteral("\r\n<h2>RecordWithdrawal</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\RecordWithdrawal.cshtml"
 using (Html.BeginForm("RecordWithdrawal", "Home", FormMethod.Post))
{


#line default
#line hidden
            BeginContext(212, 23, true);
            WriteLiteral("<label>Amount: </label>");
            EndContext();
            BeginContext(236, 38, false);
#line 12 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\RecordWithdrawal.cshtml"
                  Write(Html.TextBoxFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(274, 6, true);
            WriteLiteral("<br>\r\n");
            EndContext();
            BeginContext(287, 48, false);
#line 14 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\RecordWithdrawal.cshtml"
Write(Html.ValidationMessageFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(337, 54, true);
            WriteLiteral("    <button type=\"submit\">Record Withdrawal</button>\r\n");
            EndContext();
#line 16 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\RecordWithdrawal.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LedgerWebApp2.Models.RecordTransactionModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
