#pragma checksum "/Users/alicina/Projects/Online-Shop2/Online-Shop/Views/Home/ViewProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05fef42f971712b9af40c00fcfcced7da51a67cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Online_Shop.Views.Home.Views_Home_ViewProfile), @"mvc.1.0.view", @"/Views/Home/ViewProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewProfile.cshtml", typeof(Online_Shop.Views.Home.Views_Home_ViewProfile))]
namespace Online_Shop.Views.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05fef42f971712b9af40c00fcfcced7da51a67cc", @"/Views/Home/ViewProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a5489a05befeeae653e7dba7cfd252ff343c974", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Online_Shop.ViewModels.ViewModelFood>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 84, true);
            WriteLiteral("\n<h1>View profile</h1>\n\n<table>\r\n    <tr>\r\n        <td>Username: </td>\r\n        <td>");
            EndContext();
            BeginContext(129, 30, false);
#line 8 "/Users/alicina/Projects/Online-Shop2/Online-Shop/Views/Home/ViewProfile.cshtml"
       Write(Model.CurrentCustomer.Username);

#line default
#line hidden
            EndContext();
            BeginContext(159, 66, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Email: </td>\r\n        <td>");
            EndContext();
            BeginContext(226, 27, false);
#line 12 "/Users/alicina/Projects/Online-Shop2/Online-Shop/Views/Home/ViewProfile.cshtml"
       Write(Model.CurrentCustomer.Email);

#line default
#line hidden
            EndContext();
            BeginContext(253, 66, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Phone: </td>\r\n        <td>");
            EndContext();
            BeginContext(320, 27, false);
#line 16 "/Users/alicina/Projects/Online-Shop2/Online-Shop/Views/Home/ViewProfile.cshtml"
       Write(Model.CurrentCustomer.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(347, 68, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Address: </td>\r\n        <td>");
            EndContext();
            BeginContext(416, 29, false);
#line 20 "/Users/alicina/Projects/Online-Shop2/Online-Shop/Views/Home/ViewProfile.cshtml"
       Write(Model.CurrentCustomer.Address);

#line default
#line hidden
            EndContext();
            BeginContext(445, 65, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>City: </td>\r\n        <td>");
            EndContext();
            BeginContext(511, 26, false);
#line 24 "/Users/alicina/Projects/Online-Shop2/Online-Shop/Views/Home/ViewProfile.cshtml"
       Write(Model.CurrentCustomer.City);

#line default
#line hidden
            EndContext();
            BeginContext(537, 72, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>Postal code: </td>\r\n        <td>");
            EndContext();
            BeginContext(610, 32, false);
#line 28 "/Users/alicina/Projects/Online-Shop2/Online-Shop/Views/Home/ViewProfile.cshtml"
       Write(Model.CurrentCustomer.PostalCode);

#line default
#line hidden
            EndContext();
            BeginContext(642, 28, true);
            WriteLiteral("</td>\r\n    </tr>\r\n</table>\n\n");
            EndContext();
            BeginContext(670, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05fef42f971712b9af40c00fcfcced7da51a67cc6007", async() => {
                BeginContext(720, 12, true);
                WriteLiteral("Edit profile");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Online_Shop.ViewModels.ViewModelFood> Html { get; private set; }
    }
}
#pragma warning restore 1591
