#pragma checksum "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3f2c81c44c0c5baa5d2b03ec9cfeaa4bbf6e135"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3f2c81c44c0c5baa5d2b03ec9cfeaa4bbf6e135", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 29, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n    ");
            EndContext();
            BeginContext(58, 199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7311924366d34713aa48c8d90f984dc6", async() => {
                BeginContext(64, 186, true);
                WriteLiteral("\r\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n        <link rel=\"stylesheet\" type=\"text/css\" href=\"/css/styles.css\">\r\n        <title>Beemo</title>\r\n    ");
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
            BeginContext(257, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(265, 2441, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b94ad714da234a21993208341e458712", async() => {
                BeginContext(271, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(278, 40, false);
#line 14 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_HeaderNavbar"));

#line default
#line hidden
                EndContext();
                BeginContext(318, 2381, true);
                WriteLiteral(@"
        <div class=""Chat js-chat"">
            <div class=""Chat-messages js-messageContainer"">

                <div class=""Chat-message Chat-message--dots js-dots"">
                    <span class=""Chat-bubble"">
                        <svg class=""Chat-dots"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24"">
                            <g class=""Chat-dots"">
                                <circle class=""Chat-dot1"" cx=""1"" cy=""20"" r=""3""/>
                                <circle class=""Chat-dot2"" cx=""12"" cy=""20"" r=""3""/>
                                <circle class=""Chat-dot3"" cx=""24"" cy=""20"" r=""3""/>
                            </g>
                        </svg>
                    </span>
                </div>
            </div>

            <form class=""Chat-input js-inputForm""  autocomplete=""off"">
                <input type=""text"" class=""Chat-inputField js-inputField"" placeholder=""Write a reply..."">
                <svg class=""Chat-icon Chat-icon--smiley"" viewBox=""0 0 18 18""><path");
                WriteLiteral(@" d=""M9 0a9 9 0 1 1 0 18A9 9 0 0 1 9 0zm0 1C4.589 1 1 4.589 1 9s3.589 8 8 8 8-3.589 8-8-3.589-8-8-8zM5 6.999a1 1 0 1 1 2.002.004A1 1 0 0 1 5 6.999zm5.999 0a1.002 1.002 0 0 1 2.001 0 1 1 0 1 1-2.001 0zM8.959 13.5c-.086 0-.173-.002-.26-.007-2.44-.132-4.024-2.099-4.09-2.182l-.31-.392.781-.62.312.39c.014.017 1.382 1.703 3.37 1.806 1.306.072 2.61-.554 3.882-1.846l.351-.356.712.702-.35.356c-1.407 1.427-2.886 2.15-4.398 2.15z""
                    fill-rule=""evenodd""></path></svg>
                <svg class=""Chat-icon"" viewBox=""0 0 18 18""><path d=""M10.325 6.571v4.344c0 2.29-1.75 3.657-4.678 3.657-1.495 0-4.971-.346-4.971-3.548V6.572H0v4.452c0 3.485 3.448 4.08 5.163 4.159v2.194H3.609V18h3.782v-.623H5.838v-2.184c2.53-.055 5.162-1.2 5.162-4.278V6.57h-.675z""
                /><path d=""M5.5 13.714c2.022 0 3.667-1.466 3.667-3.267v-7.18C9.167 1.466 7.522 0 5.5 0S1.833 1.466 1.833 3.267v7.18c0 1.802 1.645 3.267 3.667 3.267zM2.75 3.528c0-1.473 1.234-2.67 2.75-2.67s2.75 1.197 2.75 2.67v3.33h-5.5v-3.33zm0 4.186h5.5v2.724c0 1.");
                WriteLiteral(@"334-1.234 2.42-2.75 2.42s-2.75-1.086-2.75-2.42V7.714z""/></svg>
                <input type=""submit"" class=""Chat-submitBtn"" value=""Send"" />
            </form>
        </div>

        <script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js""></script>
        <script src=""/js/chat.js"" async></script>
    ");
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
            BeginContext(2706, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
