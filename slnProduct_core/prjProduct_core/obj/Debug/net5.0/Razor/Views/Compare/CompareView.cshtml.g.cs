#pragma checksum "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Compare\CompareView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5fe3a83b44f3437dab6cacac312ee166f2e7111"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Compare_CompareView), @"mvc.1.0.view", @"/Views/Compare/CompareView.cshtml")]
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
#line 1 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\_ViewImports.cshtml"
using prjProduct_core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\_ViewImports.cshtml"
using prjProduct_core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5fe3a83b44f3437dab6cacac312ee166f2e7111", @"/Views/Compare/CompareView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e68a38f904a3c0064916e4a245f427c24105a01", @"/Views/_ViewImports.cshtml")]
    public class Views_Compare_CompareView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prjProduct_core.ViewModel.CCompareCoffeeViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Home-img/03.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-link linkzoom btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Style", async() => {
                WriteLiteral("\r\n    <style>\r\n        .linkzoom {\r\n            transition: 0.5s;\r\n        }\r\n\r\n            .linkzoom:hover {\r\n                transform: scale(1.2);\r\n            }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Compare\CompareView.cshtml"
  
    ViewData["Title"] = "CompareView";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""breadcrumb-area"">
    <!-- Top Breadcrumb Area -->
    <div class=""top-breadcrumb-area bg-img bg-overlay d-flex align-items-center justify-content-center"" style=""background-image: url(../img/Home-img/02.jpg);"">
        <h2>比較列表</h2>
    </div>

    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5fe3a83b44f3437dab6cacac312ee166f2e71117113", async() => {
                WriteLiteral("<i class=\"fa fa-home\"></i>Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">比較列表</li>
                    </ol>
                </nav>
            </div>
        </div>
    </div>
</div>

<div class=""container wow fadeIn"" data-wow-delay=""200ms"" id=""compare"">
    <div class=""card-deck"">
");
#nullable restore
#line 39 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Compare\CompareView.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card col-12 col-md-6 col-lg-4\" style=\"width: 18rem;\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e5fe3a83b44f3437dab6cacac312ee166f2e71119185", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div class=\"card-body\">\r\n                    產品名稱:<h5 class=\"card-title\">");
#nullable restore
#line 44 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Compare\CompareView.cshtml"
                                           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">風味描述:");
#nullable restore
#line 45 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Compare\CompareView.cshtml"
                                         Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <ul class=\"list-group list-group-flush\">\r\n                    <li class=\"list-group-item\">產區:");
#nullable restore
#line 48 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Compare\CompareView.cshtml"
                                              Write(item.Country.Continent.ContinentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\">國家:");
#nullable restore
#line 49 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Compare\CompareView.cshtml"
                                              Write(item.Country.CountryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\">烘培程度:");
#nullable restore
#line 50 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Compare\CompareView.cshtml"
                                                Write(item.Roasting.RoastingName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\">處理法:");
#nullable restore
#line 51 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Compare\CompareView.cshtml"
                                               Write(item.Process.ProcessName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\">包裝方式:");
#nullable restore
#line 52 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Compare\CompareView.cshtml"
                                                Write(item.Package.PackageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    <li class=\"list-group-item\">NT$");
#nullable restore
#line 53 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Compare\CompareView.cshtml"
                                              Write(Convert.ToInt32(item.Price).ToString("0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n                <div class=\"card-body\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5fe3a83b44f3437dab6cacac312ee166f2e711113501", async() => {
                WriteLiteral("前往商品頁面");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Compare\CompareView.cshtml"
                                                                   WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <a href=\"javascript:void(0)\" class=\"card-link linkzoom remove btn btn-danger\" id=\"remove\"><input hidden");
            BeginWriteAttribute("value", " value=\"", 2543, "\"", 2566, 1);
#nullable restore
#line 57 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Compare\CompareView.cshtml"
WriteAttributeValue("", 2551, item.ProductId, 2551, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />移除比較</a>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 60 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Compare\CompareView.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<!-- Modal -->
<div class=""modal fade"" id=""staticBackdrop"" data-bs-backdrop=""static"" data-bs-keyboard=""false"" tabindex=""-1"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <p>比較列表中已無任何商品，請先回到商品頁面重新將商品加入比較</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" id=""returnView"" class=""btn btn-info"">回到商品頁面</button>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(\".remove\").click(function () {\r\n            let Id = $(this.children).val();\r\n            $(this).closest(\'.card\').remove();\r\n            $.get(\'");
#nullable restore
#line 82 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Compare\CompareView.cshtml"
              Write(Url.Content("~/compare/DeleteCompare"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"', { ""Id"": Id },
                function (data) {
                    if (data === ""null"") {
                        $(""#staticBackdrop"").modal('show');
                        $('#returnView').click(function () {
                            window.location.href = '");
#nullable restore
#line 87 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Compare\CompareView.cshtml"
                                               Write(Url.Content("~/Shop/View"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
                        })
                    }
                    else {
                        $('.bootstrap-growl').remove();
                        $.bootstrapGrowl(""已從比較列表刪除"", {
                            ele: ""body"",
                            type: ""danger"",
                            offset: { from: ""bottom"", amount: 50 },
                            align: ""right"",
                            width: ""auto"",
                            delay: 3000,
                            allow_dismiss: true,
                            stackup_spacing: 10
                        });
                    }
                }
            )
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prjProduct_core.ViewModel.CCompareCoffeeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
