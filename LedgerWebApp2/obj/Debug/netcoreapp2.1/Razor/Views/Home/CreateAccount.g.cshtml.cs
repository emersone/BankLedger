#pragma checksum "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\CreateAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a283474276c222acf69274ec7ee494addabe6890"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreateAccount), @"mvc.1.0.view", @"/Views/Home/CreateAccount.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CreateAccount.cshtml", typeof(AspNetCore.Views_Home_CreateAccount))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a283474276c222acf69274ec7ee494addabe6890", @"/Views/Home/CreateAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbda22e111eac23e377728e3c1c673b46e4469c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CreateAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LedgerWebApp2.Models.CreateAccountModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\CreateAccount.cshtml"
  
    ViewData["Title"] = "CreateAccount";

#line default
#line hidden
            BeginContext(99, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\CreateAccount.cshtml"
 using (Html.BeginForm("CreateAccount", "Home", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(171, 87, true);
            WriteLiteral("    <div>Please enter the below information to create an account with us.</div><br />\r\n");
            EndContext();
            BeginContext(260, 29, true);
            WriteLiteral("    <label>Username: </label>");
            EndContext();
            BeginContext(290, 40, false);
#line 11 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\CreateAccount.cshtml"
                        Write(Html.TextBoxFor(model => model.username));

#line default
#line hidden
            EndContext();
            BeginContext(332, 29, true);
            WriteLiteral("    <label>Password: </label>");
            EndContext();
            BeginContext(362, 40, false);
#line 12 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\CreateAccount.cshtml"
                        Write(Html.TextBoxFor(model => model.password));

#line default
#line hidden
            EndContext();
            BeginContext(402, 39, true);
            WriteLiteral("<br />\r\n    <label>First Name: </label>");
            EndContext();
            BeginContext(442, 41, false);
#line 13 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\CreateAccount.cshtml"
                          Write(Html.TextBoxFor(model => model.firstName));

#line default
#line hidden
            EndContext();
            BeginContext(485, 30, true);
            WriteLiteral("    <label>Last Name: </label>");
            EndContext();
            BeginContext(516, 40, false);
#line 14 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\CreateAccount.cshtml"
                         Write(Html.TextBoxFor(model => model.lastName));

#line default
#line hidden
            EndContext();
            BeginContext(556, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(571, 50, false);
#line 16 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\CreateAccount.cshtml"
Write(Html.ValidationMessageFor(model => model.username));

#line default
#line hidden
            EndContext();
            BeginContext(628, 50, false);
#line 17 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\CreateAccount.cshtml"
Write(Html.ValidationMessageFor(model => model.password));

#line default
#line hidden
            EndContext();
            BeginContext(685, 51, false);
#line 18 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\CreateAccount.cshtml"
Write(Html.ValidationMessageFor(model => model.firstName));

#line default
#line hidden
            EndContext();
            BeginContext(743, 50, false);
#line 19 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\CreateAccount.cshtml"
Write(Html.ValidationMessageFor(model => model.lastName));

#line default
#line hidden
            EndContext();
            BeginContext(797, 51, true);
            WriteLiteral("    <button type=\"submit\">Create Account</button>\r\n");
            EndContext();
            BeginContext(850, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(858, 28, false);
#line 23 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\CreateAccount.cshtml"
  Write(ViewBag.AccountCreationError);

#line default
#line hidden
            EndContext();
            BeginContext(886, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 24 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\CreateAccount.cshtml"
}

#line default
#line hidden
            BeginContext(895, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LedgerWebApp2.Models.CreateAccountModel> Html { get; private set; }
    }
}
#pragma warning restore 1591