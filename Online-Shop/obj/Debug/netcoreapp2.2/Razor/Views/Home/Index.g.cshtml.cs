#pragma checksum "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1e0046ddf598dc0a3bb9da6918a83ff097274da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Online_Shop.Views.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(Online_Shop.Views.Home.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1e0046ddf598dc0a3bb9da6918a83ff097274da", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a5489a05befeeae653e7dba7cfd252ff343c974", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Online_Shop.ViewModels.ViewModelFood>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("GET"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-mode", new global::Microsoft.AspNetCore.Html.HtmlString("replace"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("#shopping-cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(45, 614, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-lg-10 mx-auto col-12 text-center mb-3"">
            <h1 class=""mt-0 text-primary"">Our Menu</h1>
            <p class=""lead"">Begin with a selection from our award winning beverage menu or choose a wine from our extensive wine list. Our wine list features over 100 different vintages and has received the chamber of commerce award of excellence.</p>
        </div>
        <div class=""col-12 mt-4"">
            <h3 class=""text-center"">Pizza</h3>
            <hr class=""accent my-5"">
        </div>
        <div class=""card-columns"">
");
            EndContext();
#line 14 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
             foreach (var item in Model.AllFoods.Where(c => c.CategoryId == 1))
            {

#line default
#line hidden
            BeginContext(755, 109, true);
            WriteLiteral("                <div class=\"card card-body\">\r\n                    <span class=\"float-right font-weight-bold\">");
            EndContext();
            BeginContext(865, 10, false);
#line 17 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
                                                          Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(875, 55, true);
            WriteLiteral("</span>\r\n                    <h6 class=\"text-truncate\">");
            EndContext();
            BeginContext(931, 9, false);
#line 18 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
                                         Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(940, 115, true);
            WriteLiteral("</h6>\r\n                    <p class=\"small\">\r\n                        <ul class=\"ingredients\" style=\"padding: 0\">\r\n");
            EndContext();
#line 21 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
                             foreach (var ing in item.Ingredients)
                            {

#line default
#line hidden
            BeginContext(1154, 74, true);
            WriteLiteral("                                <li>\r\n                                    ");
            EndContext();
            BeginContext(1229, 18, false);
#line 24 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
                               Write(ing.IngredientName);

#line default
#line hidden
            EndContext();
            BeginContext(1247, 41, true);
            WriteLiteral("\r\n                                </li>\r\n");
            EndContext();
#line 26 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"

                            }

#line default
#line hidden
            BeginContext(1321, 55, true);
            WriteLiteral("                        </ul>\r\n                        ");
            EndContext();
            BeginContext(1376, 302, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1e0046ddf598dc0a3bb9da6918a83ff097274da7907", async() => {
                BeginContext(1663, 11, true);
                WriteLiteral("Add to cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
                                                                          WriteLiteral(item.FoodId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1678, 52, true);
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n");
            EndContext();
#line 36 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1745, 189, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-12 mt-4\">\r\n            <h3 class=\"text-center\">Pasta</h3>\r\n            <hr class=\"accent my-5\">\r\n        </div>\r\n        <div class=\"card-columns\">\r\n");
            EndContext();
#line 43 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
             foreach (var item in Model.AllFoods.Where(c => c.CategoryId == 2))
            {

#line default
#line hidden
            BeginContext(2030, 109, true);
            WriteLiteral("                <div class=\"card card-body\">\r\n                    <span class=\"float-right font-weight-bold\">");
            EndContext();
            BeginContext(2140, 10, false);
#line 46 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
                                                          Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2150, 55, true);
            WriteLiteral("</span>\r\n                    <h6 class=\"text-truncate\">");
            EndContext();
            BeginContext(2206, 9, false);
#line 47 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
                                         Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2215, 115, true);
            WriteLiteral("</h6>\r\n                    <p class=\"small\">\r\n                        <ul class=\"ingredients\" style=\"padding: 0\">\r\n");
            EndContext();
#line 50 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
                             foreach (var ing in item.Ingredients)
                            {

#line default
#line hidden
            BeginContext(2429, 74, true);
            WriteLiteral("                                <li>\r\n                                    ");
            EndContext();
            BeginContext(2504, 18, false);
#line 53 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
                               Write(ing.IngredientName);

#line default
#line hidden
            EndContext();
            BeginContext(2522, 41, true);
            WriteLiteral("\r\n                                </li>\r\n");
            EndContext();
#line 55 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"

                            }

#line default
#line hidden
            BeginContext(2596, 55, true);
            WriteLiteral("                        </ul>\r\n                        ");
            EndContext();
            BeginContext(2651, 302, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1e0046ddf598dc0a3bb9da6918a83ff097274da13622", async() => {
                BeginContext(2938, 11, true);
                WriteLiteral("Add to cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
                                                                          WriteLiteral(item.FoodId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2953, 52, true);
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n");
            EndContext();
#line 65 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3020, 189, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-12 mt-4\">\r\n            <h3 class=\"text-center\">Salad</h3>\r\n            <hr class=\"accent my-5\">\r\n        </div>\r\n        <div class=\"card-columns\">\r\n");
            EndContext();
#line 72 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
             foreach (var item in Model.AllFoods.Where(c => c.CategoryId == 3))
            {

#line default
#line hidden
            BeginContext(3305, 109, true);
            WriteLiteral("                <div class=\"card card-body\">\r\n                    <span class=\"float-right font-weight-bold\">");
            EndContext();
            BeginContext(3415, 10, false);
#line 75 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
                                                          Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3425, 55, true);
            WriteLiteral("</span>\r\n                    <h6 class=\"text-truncate\">");
            EndContext();
            BeginContext(3481, 9, false);
#line 76 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
                                         Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3490, 115, true);
            WriteLiteral("</h6>\r\n                    <p class=\"small\">\r\n                        <ul class=\"ingredients\" style=\"padding: 0\">\r\n");
            EndContext();
#line 79 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
                             foreach (var ing in item.Ingredients)
                            {

#line default
#line hidden
            BeginContext(3704, 74, true);
            WriteLiteral("                                <li>\r\n                                    ");
            EndContext();
            BeginContext(3779, 18, false);
#line 82 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
                               Write(ing.IngredientName);

#line default
#line hidden
            EndContext();
            BeginContext(3797, 41, true);
            WriteLiteral("\r\n                                </li>\r\n");
            EndContext();
#line 84 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"

                            }

#line default
#line hidden
            BeginContext(3871, 55, true);
            WriteLiteral("                        </ul>\r\n                        ");
            EndContext();
            BeginContext(3926, 302, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1e0046ddf598dc0a3bb9da6918a83ff097274da19338", async() => {
                BeginContext(4213, 11, true);
                WriteLiteral("Add to cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 87 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
                                                                          WriteLiteral(item.FoodId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4228, 52, true);
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n");
            EndContext();
#line 94 "/Users/alicina/Projects/Online-Shop/Online-Shop/Views/Home/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(4295, 38, true);
            WriteLiteral("        </div>\r\n\r\n\r\n    </div>\r\n</div>");
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
