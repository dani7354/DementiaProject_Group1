#pragma checksum "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbbee8a486f9bc9adc7bf36f2684215961e31de3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbbee8a486f9bc9adc7bf36f2684215961e31de3", @"/Views/Account/Login.cshtml")]
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
#line 2 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(72, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(101, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7046f4542b34f0c94954dde728de43f", async() => {
                BeginContext(107, 144, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/css/login_style.css\">\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Login</title>\r\n");
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
            BeginContext(258, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(260, 801, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9342c0bb9e34fdd9aedf92547eea9da", async() => {
                BeginContext(266, 85, true);
                WriteLiteral("\r\n    <img src=\"/img/smiley-beemo.png\" alt=\"Smiley face\">\r\n\r\n        <h1>Login</h1>\r\n");
                EndContext();
#line 18 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
         using (Html.BeginForm("Login", "Account"))
        {
            

#line default
#line hidden
                BeginContext(428, 24, false);
#line 20 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
       Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(467, 23, false);
#line 21 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(523, 27, false);
#line 23 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
           Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
                EndContext();
                BeginContext(569, 29, false);
#line 24 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
           Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
                EndContext();
                BeginContext(639, 30, false);
#line 26 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
           Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
                EndContext();
                BeginContext(688, 33, false);
#line 27 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
           Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
                EndContext();
                BeginContext(762, 32, false);
#line 29 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
           Write(Html.LabelFor(m => m.RememberMe));

#line default
#line hidden
                EndContext();
                BeginContext(813, 35, false);
#line 30 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
           Write(Html.CheckBoxFor(m => m.RememberMe));

#line default
#line hidden
                EndContext();
                BeginContext(865, 51, true);
                WriteLiteral("                <button type=\"submit\">Go</button>\r\n");
                EndContext();
                BeginContext(930, 31, true);
                WriteLiteral("             <div class=\"Link\">");
                EndContext();
                BeginContext(962, 73, false);
#line 34 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
                          Write(Html.ActionLink("Don't have an account? Sign up!", "Register", "Account"));

#line default
#line hidden
                EndContext();
                BeginContext(1035, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
#line 35 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Login.cshtml"
        }

#line default
#line hidden
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
            BeginContext(1061, 11, true);
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
