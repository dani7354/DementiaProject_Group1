#pragma checksum "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34fca3ba7e5f82fb10b2da5e5d08441cc4c55a5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Login.cshtml", typeof(AspNetCore.Views_Account_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34fca3ba7e5f82fb10b2da5e5d08441cc4c55a5e", @"/Views/Account/Login.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication.Models.LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(77, 81, true);
            WriteLiteral("    <img src=\"/img/smiley-beemo.png\" alt=\"Smiley face\">\r\n        <h1>Login</h1>\r\n");
            EndContext();
#line 7 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
         using (Html.BeginForm("Login", "Account"))
        {
            

#line default
#line hidden
            BeginContext(235, 24, false);
#line 9 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
       Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(274, 23, false);
#line 10 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(330, 27, false);
#line 12 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
           Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(376, 29, false);
#line 13 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
           Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(446, 30, false);
#line 15 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
           Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(495, 33, false);
#line 16 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
           Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(569, 32, false);
#line 18 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
           Write(Html.LabelFor(m => m.RememberMe));

#line default
#line hidden
            EndContext();
            BeginContext(620, 35, false);
#line 19 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
           Write(Html.CheckBoxFor(m => m.RememberMe));

#line default
#line hidden
            EndContext();
            BeginContext(672, 51, true);
            WriteLiteral("                <button type=\"submit\">Go</button>\r\n");
            EndContext();
            BeginContext(737, 31, true);
            WriteLiteral("             <div class=\"Link\">");
            EndContext();
            BeginContext(769, 73, false);
#line 23 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
                          Write(Html.ActionLink("Don't have an account? Sign up!", "Register", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(842, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 24 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.Models.LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
