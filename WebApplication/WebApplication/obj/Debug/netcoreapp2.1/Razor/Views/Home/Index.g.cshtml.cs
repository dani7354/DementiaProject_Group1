#pragma checksum "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0945deba2cc61e761165e16ffa7673c6059b35b5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0945deba2cc61e761165e16ffa7673c6059b35b5", @"/Views/Home/Index.cshtml")]
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
            BeginContext(58, 198, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2f92895012e409a9adb8e921c12877d", async() => {
                BeginContext(64, 185, true);
                WriteLiteral("\r\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n        <link rel=\"stylesheet\" type=\"text/css\" href=\"/css/style.css\">\r\n        <title>Beemo</title>\r\n    ");
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
            BeginContext(256, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(264, 5181, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c1e18542caa40f28b6c24c80f268093", async() => {
                BeginContext(270, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(277, 40, false);
#line 14 "C:\Users\d\Source\Repos\DementiaProject_Group1\WebApplication\WebApplication\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_HeaderNavbar"));

#line default
#line hidden
                EndContext();
                BeginContext(317, 5121, true);
                WriteLiteral(@"
        <div class=""Chat js-chat green"">
            <div class=""Chat-options js-options options"">
                <ul class=""Chat-colors"">
                    <li class=""Chat-color Chat-color--light js-light""></li>
                    <li class=""Chat-color Chat-color--dark js-dark""></li>
                    <li class=""Chat-color Chat-color--green js-green""></li>
                </ul>
                <svg class=""Chat-optionsIcon js-optionsBtn"" viewBox=""0 0 30 30"">
                    <path d=""M5.532 0h18.936c1.517 0 2.908.632 3.92 1.612C29.368 2.624 30 4.015 30 5.532v18.936c0 1.517-.632 2.908-1.612 3.92-1.012.98-2.403 1.612-3.92 1.612H5.532c-1.517 0-2.908-.632-3.92-1.612C.632 27.376 0 25.985 0 24.468V5.532c0-1.517.632-2.908 1.612-3.92C2.624.632 4.015 0 5.532 0zm18.936 1.58H5.532A3.867 3.867 0 0 0 2.75 2.75a3.867 3.867 0 0 0-1.17 2.782v18.936c0 1.106.443 2.086 1.17 2.782a3.867 3.867 0 0 0 2.782 1.17h18.936a3.813 3.813 0 0 0 2.782-1.17 3.813 3.813 0 0 0 1.17-2.782V5.532a3.867 3.867 0 0 0-1.17-2.782 3.");
                WriteLiteral(@"813 3.813 0 0 0-2.782-1.17zM20.61 13.34c.253.222.443.538.57.886h2.497c.442 0 .79.347.79.79 0 .41-.348.79-.79.79H21.18c-.126.316-.316.632-.569.854v.031c-.41.411-1.011.664-1.675.664a2.48 2.48 0 0 1-1.676-.664 3.16 3.16 0 0 1-.537-.885h-10.4a.803.803 0 0 1-.79-.79c0-.443.347-.79.79-.79h10.4a2.46 2.46 0 0 1 .537-.886h.032a2.243 2.243 0 0 1 1.644-.695c.664 0 1.264.253 1.675.695zM14.7 21.212c.253.253.442.569.569.885h8.409c.442 0 .79.38.79.79 0 .443-.348.79-.79.79h-8.41a2.37 2.37 0 0 1-.568.886c-.411.442-1.012.695-1.676.695a2.314 2.314 0 0 1-1.675-.695 2.37 2.37 0 0 1-.57-.885H6.323a.783.783 0 0 1-.79-.79c0-.412.348-.791.79-.791h4.458c.126-.316.316-.632.569-.885.442-.411 1.043-.696 1.675-.696.664 0 1.233.285 1.676.696zm8.978-14.89c.442 0 .79.348.79.79 0 .443-.348.791-.79.791h-10.4c-.096.316-.317.632-.538.885-.443.411-1.043.696-1.676.696a2.39 2.39 0 0 1-1.675-.696 2.652 2.652 0 0 1-.57-.885H6.323a.783.783 0 0 1-.79-.79c0-.443.348-.79.79-.79H8.82a2.37 2.37 0 0 1 .569-.886c.41-.442 1.011-.695 1.675-.695.633 0 1.233.253");
                WriteLiteral(@" 1.676.695.221.253.442.538.537.885h10.4z""
                    /></svg>
                <div class=""Chat-font"">
                    <span class=""Chat-fontMinus js-minus"">–</span> aA <span class=""Chat-fontPlus js-plus"">+</span>
                </div>
            </div>
            <div class=""Chat-beemo js-beemo"">
                <h2 class=""Chat-beemo1"">Hi I'm Beemo</h2>
                <h2 class=""Chat-beemo2"">Beemo listening</h2>
            </div>
            <button class=""Chat-speakBtn js-speakBtn"">
                <svg class=""Chat-micIcon js-microphone"" viewBox=""0 0 11 18"">
                    <path d=""M10.325 6.571v4.344c0 2.29-1.75 3.657-4.678 3.657-1.495 0-4.971-.346-4.971-3.548V6.572H0v4.452c0 3.485 3.448 4.08 5.163 4.159v2.194H3.609V18h3.782v-.623H5.838v-2.184c2.53-.055 5.162-1.2 5.162-4.278V6.57h-.675z""
                    />
                    <path d=""M5.5 13.714c2.022 0 3.667-1.466 3.667-3.267v-7.18C9.167 1.466 7.522 0 5.5 0S1.833 1.466 1.833 3.267v7.18c0 1.802 1.645 3.267 3.667 3.2");
                WriteLiteral(@"67zM2.75 3.528c0-1.473 1.234-2.67 2.75-2.67s2.75 1.197 2.75 2.67v3.33h-5.5v-3.33zm0 4.186h5.5v2.724c0 1.334-1.234 2.42-2.75 2.42s-2.75-1.086-2.75-2.42V7.714z""
                    /></svg>
            </button>
            <div class=""Chat-messages js-messageContainer"">
               
                <div class=""Chat-message Chat-message--dots js-dots"">
                    <span class=""Chat-bubble"">
                        <svg class=""Chat-dots"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24"">
                            <g class=""Chat-dots"">
                                <circle class=""Chat-dot1"" cx=""1"" cy=""20"" r=""3"" />
                                <circle class=""Chat-dot2"" cx=""12"" cy=""20"" r=""3"" />
                                <circle class=""Chat-dot3"" cx=""24"" cy=""20"" r=""3"" />
                            </g>
                        </svg>
                    </span>
                </div>
            </div>

            <div class=""Chat-inputWrapper"">
                <form ");
                WriteLiteral(@"class=""Chat-inputForm js-inputForm"" autocomplete=""off"">
                    <input type=""text"" class=""Chat-inputField js-inputField"" placeholder=""Write a reply..."">
                    <svg class=""Chat-smileyIcon"" viewBox=""0 0 18 18""><path d=""M9 0a9 9 0 1 1 0 18A9 9 0 0 1 9 0zm0 1C4.589 1 1 4.589 1 9s3.589 8 8 8 8-3.589 8-8-3.589-8-8-8zM5 6.999a1 1 0 1 1 2.002.004A1 1 0 0 1 5 6.999zm5.999 0a1.002 1.002 0 0 1 2.001 0 1 1 0 1 1-2.001 0zM8.959 13.5c-.086 0-.173-.002-.26-.007-2.44-.132-4.024-2.099-4.09-2.182l-.31-.392.781-.62.312.39c.014.017 1.382 1.703 3.37 1.806 1.306.072 2.61-.554 3.882-1.846l.351-.356.712.702-.35.356c-1.407 1.427-2.886 2.15-4.398 2.15z""
                            fill-rule=""evenodd""></path></svg>
                    <input class=""Chat-submitBtn"" type=""submit"" value=""Send"" />
                </form>
            </div>
        </div>

        <script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js""></script>
        <script src=""/js/chat.js"" async></script>
   ");
                WriteLiteral(" ");
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
            BeginContext(5445, 11, true);
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
