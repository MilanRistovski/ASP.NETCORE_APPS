#pragma checksum "C:\Users\Milan CRMT\Desktop\BackEnd Projects\Milan.PizzaApp.Demo\Milan.PizzaApp.Demo\Views\Home\PizzaDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "531b7079a7daf937d504fc452a44da68e1682e3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PizzaDetails), @"mvc.1.0.view", @"/Views/Home/PizzaDetails.cshtml")]
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
#line 1 "C:\Users\Milan CRMT\Desktop\BackEnd Projects\Milan.PizzaApp.Demo\Milan.PizzaApp.Demo\Views\_ViewImports.cshtml"
using Milan.PizzaApp.Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Milan CRMT\Desktop\BackEnd Projects\Milan.PizzaApp.Demo\Milan.PizzaApp.Demo\Views\_ViewImports.cshtml"
using Milan.PizzaApp.Demo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"531b7079a7daf937d504fc452a44da68e1682e3c", @"/Views/Home/PizzaDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea19b822078153bafdc48de99657adeadc62fd81", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PizzaDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Milan.PizzaApp.DataAccess.ViewModels.PizzaVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Milan CRMT\Desktop\BackEnd Projects\Milan.PizzaApp.Demo\Milan.PizzaApp.Demo\Views\Home\PizzaDetails.cshtml"
  
    ViewData["Title"] = "PizzaDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>PizzaDetails</h2>\r\n\r\n<div>\r\n    <h4>PizzaVM</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 14 "C:\Users\Milan CRMT\Desktop\BackEnd Projects\Milan.PizzaApp.Demo\Milan.PizzaApp.Demo\Views\Home\PizzaDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 17 "C:\Users\Milan CRMT\Desktop\BackEnd Projects\Milan.PizzaApp.Demo\Milan.PizzaApp.Demo\Views\Home\PizzaDetails.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 20 "C:\Users\Milan CRMT\Desktop\BackEnd Projects\Milan.PizzaApp.Demo\Milan.PizzaApp.Demo\Views\Home\PizzaDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 23 "C:\Users\Milan CRMT\Desktop\BackEnd Projects\Milan.PizzaApp.Demo\Milan.PizzaApp.Demo\Views\Home\PizzaDetails.cshtml"
       Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 26 "C:\Users\Milan CRMT\Desktop\BackEnd Projects\Milan.PizzaApp.Demo\Milan.PizzaApp.Demo\Views\Home\PizzaDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 29 "C:\Users\Milan CRMT\Desktop\BackEnd Projects\Milan.PizzaApp.Demo\Milan.PizzaApp.Demo\Views\Home\PizzaDetails.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 34 "C:\Users\Milan CRMT\Desktop\BackEnd Projects\Milan.PizzaApp.Demo\Milan.PizzaApp.Demo\Views\Home\PizzaDetails.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "531b7079a7daf937d504fc452a44da68e1682e3c6278", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Milan.PizzaApp.DataAccess.ViewModels.PizzaVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
