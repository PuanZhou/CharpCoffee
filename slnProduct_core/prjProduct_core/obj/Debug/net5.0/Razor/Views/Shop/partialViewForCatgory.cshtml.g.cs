#pragma checksum "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\partialViewForCatgory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6423de8780452877d9f3c9bbfa2a2fad78c7adec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_partialViewForCatgory), @"mvc.1.0.view", @"/Views/Shop/partialViewForCatgory.cshtml")]
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
#line 1 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\_ViewImports.cshtml"
using prjProduct_core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\_ViewImports.cshtml"
using prjProduct_core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6423de8780452877d9f3c9bbfa2a2fad78c7adec", @"/Views/Shop/partialViewForCatgory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e68a38f904a3c0064916e4a245f427c24105a01", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_partialViewForCatgory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prjProduct_core.ViewModel.CProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("add-to-cart-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\partialViewForCatgory.cshtml"
  
    foreach (var pd in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <!-- Single Product Area -->
        <div class=""col-12 col-sm-6 col-lg-4"" >
            <div class=""single-product-area mb-50 single_portfolio_item home-design wow fadeIn"" data-wow-delay=""300ms"">
                <!-- Product Image -->
                <div class=""product-img"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6423de8780452877d9f3c9bbfa2a2fad78c7adec4755", async() => {
                WriteLiteral("<img src=\"../img/Home-img/02.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 505, "\"", 511, 0);
                EndWriteAttribute();
                WriteLiteral(">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\partialViewForCatgory.cshtml"
                                             WriteLiteral(pd.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <!-- Product Tag -->
                    <div class=""product-tag"">
                        <a href=""#"">Hot</a>
                    </div>
                    <div class=""product-meta d-flex"">
                        <a href=""#"" class=""wishlist-btn""><i class=""icon_heart_alt""></i></a>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6423de8780452877d9f3c9bbfa2a2fad78c7adec7459", async() => {
                WriteLiteral("Add to cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\partialViewForCatgory.cshtml"
                                                    WriteLiteral(pd.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <a href=""#"" class=""compare-btn""><i class=""arrow_left-right_alt""></i></a>
                    </div>
                </div>
                <!-- Product Info -->
                <div class=""product-info mt-15 text-center"">
                    <a>
                        ");
#nullable restore
#line 25 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\partialViewForCatgory.cshtml"
                   Write(Html.ActionLink(@pd.ProductName, "detail", new { id = pd.ProductId }, new { }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                    <h6>NT$");
#nullable restore
#line 27 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\partialViewForCatgory.cshtml"
                       Write(Convert.ToInt32( pd.Price).ToString("0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 31 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\partialViewForCatgory.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div  class=\"col-12\">\r\n    <ul class=\"pagination left pull-left\" id=\"btnul\">\r\n    </ul>\r\n</div>\r\n\r\n\r\n<script>\r\n    \r\n    $(\"#btnul\").append(function () {\r\n        $.get(\'");
#nullable restore
#line 42 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\partialViewForCatgory.cshtml"
          Write(Url.Content("~/API/loadCatory"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \"?id=\" +");
#nullable restore
#line 42 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\partialViewForCatgory.cshtml"
                                                      Write(Model.Select(p=>p.CategoryId).FirstOrDefault());

#line default
#line hidden
#nullable disable
            WriteLiteral(@", function (data) {
            let cont = parseInt(data) + 1;

                for (let i = 1; i < cont+1; i++) {
                    $(""#btnul"").append(`<li class="" page-item""><a href=""#"" class="" page-link "" id=""Page${i}"" onclick=""loadpage()"">${i}</a></li>`)
                }
        })
    });

        function loadpage() {
            let id = $(event.target).attr(""id"").substr(4);
            /*console.log(id)*/
             $(""#showcard"").load('");
#nullable restore
#line 54 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\partialViewForCatgory.cshtml"
                             Write(Url.Content("~/Shop/partialViewForCatgory"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \"?id=\" +");
#nullable restore
#line 54 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\partialViewForCatgory.cshtml"
                                                                                     Write(Model.Select(p=>p.CategoryId).FirstOrDefault());

#line default
#line hidden
#nullable disable
            WriteLiteral("+\"&page=\"+id);\r\n        }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prjProduct_core.ViewModel.CProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
