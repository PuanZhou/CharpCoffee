#pragma checksum "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shop\partialViewPacking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2560575d65b5d8219251bf05d39ba44b3d04600b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_partialViewPacking), @"mvc.1.0.view", @"/Views/Shop/partialViewPacking.cshtml")]
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
#line 1 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\_ViewImports.cshtml"
using prjProduct_core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\_ViewImports.cshtml"
using prjProduct_core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2560575d65b5d8219251bf05d39ba44b3d04600b", @"/Views/Shop/partialViewPacking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e68a38f904a3c0064916e4a245f427c24105a01", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_partialViewPacking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prjProduct_core.ViewModel.CCoffeeViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<style>
    .pagination {
        position: relative;
        z-index: 1;
        -webkit-box-pack: center;
        -ms-flex-pack: center;
        justify-content: center;
    }

        .pagination li a {
            color: #707070;
            width: 46px;
            height: 46px;
            border-radius: 50%;
            text-align: center;
            font-size: 18px;
            line-height: 44px;
            padding: 0;
            margin: 0 10px;
        }

        .pagination li span {
            color: #707070;
            width: 46px;
            height: 46px;
            border-radius: 50%;
            text-align: center;
            font-size: 18px;
            line-height: 44px;
            padding: 0;
            margin: 0 10px;
        }

        .pagination li a:hover, .pagination li a:focus, .pagination li .current, .pagination li .current:hover {
            border-color: #70c745;
            background-color: #70c745;
            color: #ffffff;
    ");
            WriteLiteral("    }\r\n</style>\r\n");
            WriteLiteral("    <div class=\"col-12\">\r\n        <ul class=\"pagination left pull-left \" id=\"btnul\">\r\n        </ul>\r\n    </div>\r\n");
#nullable restore
#line 46 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shop\partialViewPacking.cshtml"
    foreach (var pd in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <!-- Single Product Area -->
        <div class=""col-12 col-sm-6 col-lg-4 list-item"">
            <div class=""single-product-area mb-50 single_portfolio_item home-design wow fadeIn"" data-wow-delay=""300ms"">
                <!-- Product Image -->
                <div class=""product-img"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2560575d65b5d8219251bf05d39ba44b3d04600b5390", async() => {
                WriteLiteral("<img src=\"../img/Home-img/02.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 1665, "\"", 1671, 0);
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
#line 53 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shop\partialViewPacking.cshtml"
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
                        <a");
            BeginWriteAttribute("href", " href=\"", 2015, "\"", 2084, 1);
#nullable restore
#line 60 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shop\partialViewPacking.cshtml"
WriteAttributeValue("", 2022, Url.Action("AddtoCart","Shopping", new { id = @pd.ProductId}), 2022, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor:pointer\" class=\"add-to-cart-btn\"><span hidden id=\"addtocart\">");
#nullable restore
#line 60 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shop\partialViewPacking.cshtml"
                                                                                                                                                                       Write(pd.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>Add to cart</a>\r\n                        <a href=\"javascript:void(0);\" class=\"compare-btn\"><i class=\"arrow_left-right_alt\"></i><span hidden id=\"comid\">");
#nullable restore
#line 61 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shop\partialViewPacking.cshtml"
                                                                                                                                 Write(pd.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n                    </div>\r\n                </div>\r\n                <!-- Product Info -->\r\n                <div class=\"product-info mt-15 text-center\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2560575d65b5d8219251bf05d39ba44b3d04600b9810", async() => {
                WriteLiteral("\r\n                        ");
#nullable restore
#line 67 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shop\partialViewPacking.cshtml"
                   Write(pd.CoffeeName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
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
#line 66 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shop\partialViewPacking.cshtml"
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
            WriteLiteral("\r\n                    <h6>$");
#nullable restore
#line 69 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shop\partialViewPacking.cshtml"
                     Write(Convert.ToInt32( pd.Product.Price).ToString("0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 73 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shop\partialViewPacking.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12\">\r\n        <ul class=\"pagination left pull-left \" id=\"btnul\">\r\n        </ul>\r\n    </div>\r\n");
            WriteLiteral(@"<script>
    // 每個頁面要顯示幾個項目
    var perPage = 9;
    // 總共有多少個項目
    var numItems = $("".list-item"").length;

    $("".list-item"").slice(perPage).hide();

    $('.pagination').pagination({

        items: numItems,
        itemsOnPage: perPage,
        prevText: ""&laquo;"",
        nextText: ""&raquo;"",
        onPageClick: function (pageNumber) {
            // 計算出 起始 以及結束
            var from = perPage * (pageNumber - 1);
            var to = from + perPage;
            $("".list-item"").hide().slice(from, to).show();

        }
    })
    //=====================加入比較按鈕=====================
    $("".compare-btn"").click(function () {
        let comid = $(this.children).text();
        $('.bootstrap-growl').remove();
        $.get('");
#nullable restore
#line 105 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shop\partialViewPacking.cshtml"
          Write(Url.Content("~/compare/AddCompare"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', { ""Id"": comid },
            function (data) {
                if (data === ""add"") {
                    $.bootstrapGrowl(""加入比較清單"", {
                        ele: ""body"",
                        type: ""success"",
                        offset: { from: ""bottom"", amount: 50 },
                        align: ""right"",
                        width: ""auto"",
                        delay: 3000,
                        allow_dismiss: true,
                        stackup_spacing: 10
                    });
                }
                else if (data === ""beenAdd"") {
                    $.bootstrapGrowl(""該商品已加入過比較清單!"", {
                        ele: ""body"",
                        type: ""warning"",
                        offset: { from: ""bottom"", amount: 50 },
                        align: ""right"",
                        width: ""auto"",
                        delay: 3000,
                        allow_dismiss: true,
                        stackup_spacing: 10
                    });
");
            WriteLiteral("                }\r\n                else{\r\n                    $.bootstrapGrowl(\"比較清單已加入3樣商品 <a href=\'");
#nullable restore
#line 132 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shop\partialViewPacking.cshtml"
                                                      Write(Url.Content("~/Compare/CompareView"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' style='font-weight: bolder;font-size:18px; color: #4F9D9D'>前往比較頁面</a>"", {
                        ele: ""body"",
                        type: ""primary"",
                        offset: { from: ""bottom"", amount: 50 },
                        align: ""right"",
                        width: ""auto"",
                        delay: 3000,
                        allow_dismiss: true,
                        stackup_spacing: 10
                    });
                }
                ReportCompareCount();
             }
        );
    });
    //==================目前比較數量===============
    function ReportCompareCount() {
         $.get('");
#nullable restore
#line 149 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shop\partialViewPacking.cshtml"
           Write(Url.Content("~/Compare/ReportCompareCount"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                function (data) {
                    $(""#compare-count"").html(`&nbsp&nbsp${data}`);
                }
    )};
           //============================加入收藏==============================
    $("".wishlist-btn"").click(async function (event) {
        let likeid = event.currentTarget.textContent;
        $.get('");
#nullable restore
#line 157 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shop\partialViewPacking.cshtml"
          Write(Url.Content("~/MemberFactory/AddtoMyLike"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', { \"id\": likeid },\r\n            function (data) {\r\n                if (data == \"此商品已收藏過\" || data == \"已加入收藏\") {\r\n                    alert(data);\r\n                } else {\r\n                    window.location.href = \'");
#nullable restore
#line 162 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shop\partialViewPacking.cshtml"
                                       Write(Url.Content("~/MemberFactory/AddtoMyLike"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n                }\r\n            });\r\n\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prjProduct_core.ViewModel.CCoffeeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
