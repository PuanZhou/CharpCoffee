#pragma checksum "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\MemCenter\MyLikePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfdf1d451650fa13166b579301e5689d2c7341d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MemCenter_MyLikePartial), @"mvc.1.0.view", @"/Views/MemCenter/MyLikePartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfdf1d451650fa13166b579301e5689d2c7341d4", @"/Views/MemCenter/MyLikePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e68a38f904a3c0064916e4a245f427c24105a01", @"/Views/_ViewImports.cshtml")]
    public class Views_MemCenter_MyLikePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prjProduct_core.ViewModel.CMyLikeViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <!-- Sidebar Area -->\r\n    <!-- All Products Area -->\r\n    <div class=\"col-12 col-md-12 col-lg-12\">\r\n        <div class=\"shop-products-area\">\r\n            <div class=\"row test\">\r\n\r\n");
#nullable restore
#line 10 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\MemCenter\MyLikePartial.cshtml"
                  
                    int prodcount = 0;

                    foreach (var pd in Model)
                    {
                        prodcount++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <!-- Single Product Area -->\r\n                        <div class=\"col-12 col-sm-6 col-lg-4 dele\"");
            BeginWriteAttribute("id", " id=\"", 560, "\"", 578, 1);
#nullable restore
#line 17 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\MemCenter\MyLikePartial.cshtml"
WriteAttributeValue("", 565, pd.ProductId, 565, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""single-product-area mb-50"">
                                <!-- Product Image -->
                                <div class=""product-img"">
                                    <a href=""shop-details.html""><img src=""../img/Home-img/02.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 863, "\"", 869, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                                    <!-- Product Tag -->
                                    <div class=""product-tag"">
                                        <a href=""#"">Hot</a>
                                    </div>
                                    <div class=""product-meta d-flex"">
                                        <a href=""javascript:viod(0);"" class=""wishlist-btn""><i class=""icon_heart_alt""><span hidden id=""likeid"">");
#nullable restore
#line 27 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\MemCenter\MyLikePartial.cshtml"
                                                                                                                                         Write(pd.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></i></a>
                                        <a style=""cursor:pointer"" class=""add-to-cart-btn"">Add to cart</a>
                                        <a class=""compare-btn"" style=""cursor:pointer""><i class=""arrow_left-right_alt""></i><span hidden id=""comid"">");
#nullable restore
#line 29 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\MemCenter\MyLikePartial.cshtml"
                                                                                                                                             Write(pd.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></a>
                                    </div>
                                </div>
                                <!-- Product Info -->
                                <div class=""product-info mt-15 text-center"">
                                    <a>
                                        ");
#nullable restore
#line 35 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\MemCenter\MyLikePartial.cshtml"
                                   Write(Html.ActionLink(pd.productname, "detail", new { id = pd.ProductId }, new { }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                    <h6>$");
#nullable restore
#line 37 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\MemCenter\MyLikePartial.cshtml"
                                     Write(Convert.ToInt32( pd.price).ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 41 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\MemCenter\MyLikePartial.cshtml"


                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n        $(\".compare-btn\").click(function () {\r\n        let comid = $(this.children).text();\r\n        $.get(\'");
#nullable restore
#line 53 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\MemCenter\MyLikePartial.cshtml"
          Write(Url.Content("~/compare/AddCompare"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', { ""id"": comid },
            function (data) {
                alert(data);
            }
        );
        })

        $("".wishlist-btn"").click(function (event) {
        let likeid = event.currentTarget.textContent;

            let aa = $(this).closest("".dele"");
            console.log(aa); //所有元素

        $.get('");
#nullable restore
#line 66 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\MemCenter\MyLikePartial.cshtml"
          Write(Url.Content("~/MemberFactory/DeleteMylike"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', { \"id\": likeid },\r\n            function (data) {\r\n                if (data == \"已取消收藏\") {\r\n                    aa.remove();\r\n                    alert(data);\r\n                } else {\r\n                    window.location.href = \'");
#nullable restore
#line 72 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\MemCenter\MyLikePartial.cshtml"
                                       Write(Url.Content("~/MemberFactory/DeleteMylike"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prjProduct_core.ViewModel.CMyLikeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591