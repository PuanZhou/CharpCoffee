#pragma checksum "D:\iii\期末專題\new\product\slnProduct_core\prjProduct_core\Views\Shop\partialViewForCatgory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8050c42372e807afd12c204949b11bd533d1d10e"
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
#line 1 "D:\iii\期末專題\new\product\slnProduct_core\prjProduct_core\Views\_ViewImports.cshtml"
using prjProduct_core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\iii\期末專題\new\product\slnProduct_core\prjProduct_core\Views\_ViewImports.cshtml"
using prjProduct_core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8050c42372e807afd12c204949b11bd533d1d10e", @"/Views/Shop/partialViewForCatgory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e68a38f904a3c0064916e4a245f427c24105a01", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_partialViewForCatgory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prjProduct_core.ViewModel.CProductViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\iii\期末專題\new\product\slnProduct_core\prjProduct_core\Views\Shop\partialViewForCatgory.cshtml"
  
    foreach (var pd in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <!-- Single Product Area -->
        <div class=""col-12 col-sm-6 col-lg-4"">
            <div class=""single-product-area mb-50"">
                <!-- Product Image -->
                <div class=""product-img"">
                    <a href=""shop-details.html""><img src=""../img/Home-img/02.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 412, "\"", 418, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a>
                    <!-- Product Tag -->
                    <div class=""product-tag"">
                        <a href=""#"">Hot</a>
                    </div>
                    <div class=""product-meta d-flex"">
                        <a href=""#"" class=""wishlist-btn""><i class=""icon_heart_alt""></i></a>
                        <a href=""cart.html"" class=""add-to-cart-btn"">Add to cart</a>
                        <a href=""#"" class=""compare-btn""><i class=""arrow_left-right_alt""></i></a>
                    </div>
                </div>
                <!-- Product Info -->
                <div class=""product-info mt-15 text-center"">
                    <a>
                        ");
#nullable restore
#line 25 "D:\iii\期末專題\new\product\slnProduct_core\prjProduct_core\Views\Shop\partialViewForCatgory.cshtml"
                   Write(Html.ActionLink(@pd.ProductName, "detail", new { id = pd.ProductId }, new { }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                    <h6>$");
#nullable restore
#line 27 "D:\iii\期末專題\new\product\slnProduct_core\prjProduct_core\Views\Shop\partialViewForCatgory.cshtml"
                     Write(Convert.ToInt32( pd.Price).ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 31 "D:\iii\期末專題\new\product\slnProduct_core\prjProduct_core\Views\Shop\partialViewForCatgory.cshtml"
    }

#line default
#line hidden
#nullable disable
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
