#pragma checksum "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce9a6db6cc79612881f34a8a8aba49701d79d552"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Login.cshtml", typeof(AspNetCore.Views_Home_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce9a6db6cc79612881f34a8a8aba49701d79d552", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbda22e111eac23e377728e3c1c673b46e4469c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LedgerWebApp2.Models.LoginModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\Login.cshtml"
  
    ViewBag.Title = "User Login";

#line default
#line hidden
            BeginContext(84, 27, true);
            WriteLiteral("\r\n<h2>User Login</h2>\r\n\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\Login.cshtml"
 using (Html.BeginForm("Login", "Home", FormMethod.Post))
{


#line default
#line hidden
            BeginContext(175, 29, true);
            WriteLiteral("    <label>Username: </label>");
            EndContext();
            BeginContext(205, 40, false);
#line 13 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\Login.cshtml"
                        Write(Html.TextBoxFor(model => model.username));

#line default
#line hidden
            EndContext();
            BeginContext(247, 29, true);
            WriteLiteral("    <label>Password: </label>");
            EndContext();
            BeginContext(277, 40, false);
#line 14 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\Login.cshtml"
                        Write(Html.TextBoxFor(model => model.password));

#line default
#line hidden
            EndContext();
            BeginContext(317, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(332, 50, false);
#line 16 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\Login.cshtml"
Write(Html.ValidationMessageFor(model => model.username));

#line default
#line hidden
            EndContext();
            BeginContext(389, 50, false);
#line 17 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\Login.cshtml"
Write(Html.ValidationMessageFor(model => model.password));

#line default
#line hidden
            EndContext();
            BeginContext(443, 42, true);
            WriteLiteral("    <button type=\"submit\">Login</button>\r\n");
            EndContext();
#line 20 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\Login.cshtml"
}

#line default
#line hidden
            BeginContext(488, 176, true);
            WriteLiteral("\r\n<div>\r\n    <br />\r\n    Don\'t have an account with us?   <button onclick=\"window.location.href = \'/Home/CreateAccount\';\" type=\"button\">Create Account</button>\r\n\r\n</div>\r\n\r\n<p>");
            EndContext();
            BeginContext(665, 18, false);
#line 28 "C:\Users\Ellie\Desktop\LedgerWebApp\LedgerWebApp2\Views\Home\Login.cshtml"
Write(ViewBag.LoginError);

#line default
#line hidden
            EndContext();
            BeginContext(683, 16, true);
            WriteLiteral("</p>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LedgerWebApp2.Models.LoginModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
