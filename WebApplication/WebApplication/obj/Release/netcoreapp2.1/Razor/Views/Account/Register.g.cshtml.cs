#pragma checksum "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bed7a6260218fb54f57edb1de6a9b51e324fe37"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bed7a6260218fb54f57edb1de6a9b51e324fe37", @"/Views/Account/Register.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication.Models.RegisterViewModel>
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
#line 2 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(75, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(104, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb271e59320d46c2b12e176f50e5d166", async() => {
                BeginContext(110, 90, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Register</title>\r\n");
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
            BeginContext(207, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(209, 753, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bfb87bf6ac34d0d80e8f6881cbc7285", async() => {
                BeginContext(215, 45, true);
                WriteLiteral("\r\n    <fieldset>\r\n        <h1>Register</h1>\r\n");
                EndContext();
#line 16 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
         using (Html.BeginForm("Register", "Account"))
        {
            

#line default
#line hidden
                BeginContext(340, 24, false);
#line 18 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
       Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(379, 23, false);
#line 19 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(419, 33, true);
                WriteLiteral("            <p>\r\n                ");
                EndContext();
                BeginContext(453, 27, false);
#line 23 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
           Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
                EndContext();
                BeginContext(480, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(499, 29, false);
#line 24 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
           Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
                EndContext();
                BeginContext(528, 53, true);
                WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
                EndContext();
                BeginContext(582, 30, false);
#line 27 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
           Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
                EndContext();
                BeginContext(612, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(631, 33, false);
#line 28 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
           Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
                EndContext();
                BeginContext(664, 53, true);
                WriteLiteral("\r\n            </p>\r\n            <p>\r\n                ");
                EndContext();
                BeginContext(718, 37, false);
#line 31 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
           Write(Html.LabelFor(m => m.ConfirmPassword));

#line default
#line hidden
                EndContext();
                BeginContext(755, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(774, 40, false);
#line 32 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"
           Write(Html.PasswordFor(m => m.ConfirmPassword));

#line default
#line hidden
                EndContext();
                BeginContext(814, 111, true);
                WriteLiteral("\r\n            </p>    \r\n            <p>\r\n                <button type=\"submit\" >Go</button>\r\n            </p>\r\n");
                EndContext();
#line 37 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Account\Register.cshtml"

        }

#line default
#line hidden
                BeginContext(938, 17, true);
                WriteLiteral("    </fieldset>\r\n");
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
            BeginContext(962, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.Models.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
