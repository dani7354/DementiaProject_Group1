#pragma checksum "C:\Users\Nicolai\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a791e8ceffa33cee9bf7d77d694450ce853b6985"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a791e8ceffa33cee9bf7d77d694450ce853b6985", @"/Views/Account/Login.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication.Models.LoginViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Nicolai\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(72, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(101, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd66abd9cb86428cb966e1794eee1d56", async() => {
                BeginContext(107, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Login</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(201, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(203, 836, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1cca728dc0942f48bfcfecb0ecf5e68", async() => {
                BeginContext(209, 42, true);
                WriteLiteral("\r\n    <fieldset>\r\n        <h1>Login</h1>\r\n");
                EndContext();
#line 16 "C:\Users\Nicolai\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
         using (Html.BeginForm("Login", "Account"))
        {
            

#line default
#line hidden
                BeginContext(328, 24, false);
#line 18 "C:\Users\Nicolai\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
       Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(367, 23, false);
#line 19 "C:\Users\Nicolai\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(396, 33, true);
                WriteLiteral("            <p>\r\n                ");
                EndContext();
                BeginContext(430, 27, false);
#line 23 "C:\Users\Nicolai\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
           Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
                EndContext();
                BeginContext(457, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(476, 29, false);
#line 24 "C:\Users\Nicolai\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
           Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
                EndContext();
                BeginContext(505, 53, true);
                WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
                EndContext();
                BeginContext(559, 30, false);
#line 27 "C:\Users\Nicolai\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
           Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
                EndContext();
                BeginContext(589, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(608, 33, false);
#line 28 "C:\Users\Nicolai\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
           Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
                EndContext();
                BeginContext(641, 53, true);
                WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
                EndContext();
                BeginContext(695, 32, false);
#line 31 "C:\Users\Nicolai\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
           Write(Html.LabelFor(m => m.RememberMe));

#line default
#line hidden
                EndContext();
                BeginContext(727, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(746, 35, false);
#line 32 "C:\Users\Nicolai\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
           Write(Html.CheckBoxFor(m => m.RememberMe));

#line default
#line hidden
                EndContext();
                BeginContext(781, 20, true);
                WriteLiteral("\r\n            </p>\r\n");
                EndContext();
                BeginContext(813, 102, true);
                WriteLiteral("            <p>\r\n                <button type=\"submit\">Go</button>\r\n            </p>\r\n            <p> ");
                EndContext();
                BeginContext(916, 73, false);
#line 38 "C:\Users\Nicolai\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
           Write(Html.ActionLink("Don't have an account? Sign up!", "Register", "Account"));

#line default
#line hidden
                EndContext();
                BeginContext(989, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
#line 39 "C:\Users\Nicolai\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"

        }

#line default
#line hidden
                BeginContext(1008, 24, true);
                WriteLiteral("    </fieldset>\r\n   \r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1039, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.Models.LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
