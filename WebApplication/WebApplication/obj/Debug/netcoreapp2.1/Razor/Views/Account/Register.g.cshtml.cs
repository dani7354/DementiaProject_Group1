#pragma checksum "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffb3ae9c53a2c9486d958622ebcc536b0f49b8f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffb3ae9c53a2c9486d958622ebcc536b0f49b8f3", @"/Views/Account/Register.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication.Models.RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(80, 72, true);
            WriteLiteral("<img src=\"/img/smiley-beemo.png\" alt=\"Smiley face\">\r\n<h1>Register</h1>\r\n");
            EndContext();
#line 7 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
 using (Html.BeginForm("Register", "Account"))
{
    

#line default
#line hidden
            BeginContext(208, 24, false);
#line 9 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(239, 23, false);
#line 10 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(271, 31, false);
#line 12 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
Write(Html.LabelFor(m => m.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(309, 33, false);
#line 13 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
Write(Html.TextBoxFor(m => m.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(351, 30, false);
#line 15 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(388, 32, false);
#line 16 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
Write(Html.TextBoxFor(m => m.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(429, 25, false);
#line 18 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
Write(Html.LabelFor(m => m.Age));

#line default
#line hidden
            EndContext();
            BeginContext(461, 27, false);
#line 19 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
Write(Html.TextBoxFor(m => m.Age));

#line default
#line hidden
            EndContext();
            BeginContext(497, 33, false);
#line 21 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
Write(Html.LabelFor(m => m.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(537, 35, false);
#line 22 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
Write(Html.TextBoxFor(m => m.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(581, 35, false);
#line 24 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
Write(Html.LabelFor(m => m.ContactPerson));

#line default
#line hidden
            EndContext();
            BeginContext(623, 37, false);
#line 25 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
Write(Html.TextBoxFor(m => m.ContactPerson));

#line default
#line hidden
            EndContext();
            BeginContext(669, 27, false);
#line 27 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(703, 29, false);
#line 28 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(741, 30, false);
#line 30 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(778, 33, false);
#line 31 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
            EndContext();
            BeginContext(820, 37, false);
#line 33 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
Write(Html.LabelFor(m => m.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(864, 40, false);
#line 34 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
Write(Html.PasswordFor(m => m.ConfirmPassword));

#line default
#line hidden
            EndContext();
            BeginContext(906, 67, true);
            WriteLiteral("    <button type=\"submit\">Register</button>\r\n    <div class=\"Link\">");
            EndContext();
            BeginContext(974, 84, false);
#line 36 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
                 Write(Html.ActionLink("Already have an account? Go to the login page", "Login", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 37 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.Models.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
