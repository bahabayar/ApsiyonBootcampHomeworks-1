#pragma checksum "C:\Kodluyoruz\20haziran\ETicaret\ETicaret.Web\Views\Order\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1922c7b25a5ae763551d632c8c6da6be829d5a1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Payment), @"mvc.1.0.view", @"/Views/Order/Payment.cshtml")]
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
#nullable restore
#line 1 "C:\Kodluyoruz\20haziran\ETicaret\ETicaret.Web\Views\_ViewImports.cshtml"
using ETicaret.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Kodluyoruz\20haziran\ETicaret\ETicaret.Web\Views\_ViewImports.cshtml"
using ETicaret.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Kodluyoruz\20haziran\ETicaret\ETicaret.Web\Views\_ViewImports.cshtml"
using ETicaret.Application.Dto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1922c7b25a5ae763551d632c8c6da6be829d5a1f", @"/Views/Order/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbb223b2e3b0b20e56621b113592db0fb868cd1d", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BasketViewDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-12\">\r\n        ");
#nullable restore
#line 4 "C:\Kodluyoruz\20haziran\ETicaret\ETicaret.Web\Views\Order\Payment.cshtml"
   Write(Model.Items.Sum(x => x.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1922c7b25a5ae763551d632c8c6da6be829d5a1f4003", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-6"">
            <input name=""Owner"" type=""text"" placeholder=""Kart Sahibi"" />
        </div>
        <div class=""col-6"">
            <input name=""CardNumber"" type=""text"" placeholder=""Kart numarası"" />
        </div>
        <div class=""col-6"">
            <input name=""ValidMonth"" type=""text"" placeholder=""Kart Geçerlilik tarihi ay"" />
        </div>
        <div class=""col-6"">
            <input name=""ValidYear"" type=""text"" placeholder=""Kart Geçerlilik tarihi yıl"" />
        </div>
        <div class=""col-6"">
            <input name=""Cvv"" type=""text"" placeholder=""Cvv"" />
        </div>
    </div>
    <input name=""Money"" type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 851, "\"", 889, 1);
#nullable restore
#line 25 "C:\Kodluyoruz\20haziran\ETicaret\ETicaret.Web\Views\Order\Payment.cshtml"
WriteAttributeValue("", 859, Model.Items.Sum(x => x.Total), 859, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <button type=\"submit\">Ödeme Yap</button>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasketViewDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
