#pragma checksum "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\CArticle\faceToArticleDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f0503e334b5a3bd4aeaa159a00b68de483a7922"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CArticle_faceToArticleDetail), @"mvc.1.0.view", @"/Views/CArticle/faceToArticleDetail.cshtml")]
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
#nullable restore
#line 1 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\CArticle\faceToArticleDetail.cshtml"
using static prjProduct_core.Models.CoffeeContext;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f0503e334b5a3bd4aeaa159a00b68de483a7922", @"/Views/CArticle/faceToArticleDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e68a38f904a3c0064916e4a245f427c24105a01", @"/Views/_ViewImports.cshtml")]
    public class Views_CArticle_faceToArticleDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prjProduct_core.ViewModel.CArticleViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Frog001.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Home-img/02.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <!-- ##### Breadcrumb Area Start ##### -->
<div class=""breadcrumb-area"">
    <!-- Top Breadcrumb Area -->
    <div class=""top-breadcrumb-area bg-img bg-overlay d-flex align-items-center justify-content-center"" style=""background-image: url(../../img/Home-img/02.jpg);"">
        <h2>好文慢讀</h2>
    </div>

    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""#""><i class=""fa fa-home""></i> Home</a></li>
                        <li class=""breadcrumb-item""><a href=""#"">相關文章</a></li>
                        <li class=""breadcrumb-item""><a href=""#"">咖啡好文</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">好文慢讀</li>
                    </ol>
                </nav>
            </div>
        </div>
    </div>
</div>
<!-- ##### Breadcrumb Area End ##### -->
<!-- ##### Blog Content A");
            WriteLiteral(@"rea Start ##### -->
<section class=""blog-content-area section-padding-0-100"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <!-- Blog Posts Area -->
            <div class=""col-12 col-md-8"">
                <div class=""blog-posts-area"">

                    <!-- Post Details Area -->
                    <div class=""single-post-details-area"">
                        <div class=""post-content"">
                            <h4 class=""post-title"">");
#nullable restore
#line 37 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\CArticle\faceToArticleDetail.cshtml"
                                              Write(Model.FirstOrDefault().ArticleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <div >\r\n                                <a href=\"#\">");
#nullable restore
#line 39 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\CArticle\faceToArticleDetail.cshtml"
                                       Write(Model.FirstOrDefault().ArticleDate.ToString().Substring(0, 9));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </div>\r\n                            <div class=\"post-thumbnail mb-30\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2f0503e334b5a3bd4aeaa159a00b68de483a79227019", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <p id=\"P1\">\r\n                                ");
#nullable restore
#line 45 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\CArticle\faceToArticleDetail.cshtml"
                           Write(Html.Raw(@Model.FirstOrDefault().ArticleDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                            <div class=""row mb-30""></div>
                        </div>
                    </div>

                    <!-- Post Tags & Share -->
                    <!--<div class=""post-tags-share d-flex justify-content-between align-items-center "">-->
                        <!-- Tags -->
                        <!--<ol class=""popular-tags d-flex align-items-center flex-wrap"">
                            <li><span>Tag:</span></li>
                            <li><a href=""#"">PLANTS</a></li>
                            <li><a href=""#"">CACTUS</a></li>
                        </ol>-->
                        <!-- Share -->
                        <!--<div class=""post-share"">
                            <a href=""#""><i class=""fa fa-facebook"" aria-hidden=""true""></i></a>
                            <a href=""#""><i class=""fa fa-twitter"" aria-hidden=""true""></i></a>
                            <a href=""#""><i class=""fa fa-google-plus"" aria-hidden=""tru");
            WriteLiteral(@"e""></i></a>
                            <a href=""#""><i class=""fa fa-instagram"" aria-hidden=""true""></i></a>
                        </div>
                    </div>-->

                </div>
            </div>

            <!-- Blog Sidebar Area -->
            <div class=""col-12 col-sm-9 col-md-4"">
                <div class=""post-sidebar-area"">


                    <!-- ##### Single Widget Area ##### -->
                    <div class=""single-widget-area"">
                        <!-- Title -->
                        <div class=""widget-title"">
                            <h4>十大熱銷商品</h4>
                        </div>
");
#nullable restore
#line 82 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\CArticle\faceToArticleDetail.cshtml"
                          
                            CoffeeContext _context = new CoffeeContext();


                            foreach (var item in _context.Products.OrderByDescending(t =>t.Stock).Take(10))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <!-- 熱銷商品 -->\r\n                    <div class=\"single-best-seller-product d-flex align-items-center\">\r\n                        <div class=\"product-thumbnail\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4309, "\"", 4375, 1);
#nullable restore
#line 91 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\CArticle\faceToArticleDetail.cshtml"
WriteAttributeValue("", 4316, Url.Action($"detail", "Shop", new { id = item.ProductId }), 4316, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2f0503e334b5a3bd4aeaa159a00b68de483a792211430", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>");
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"product-info\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4549, "\"", 4615, 1);
#nullable restore
#line 94 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\CArticle\faceToArticleDetail.cshtml"
WriteAttributeValue("", 4556, Url.Action($"detail", "Shop", new { id = item.ProductId }), 4556, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 94 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\CArticle\faceToArticleDetail.cshtml"
                                                                                             Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <p>");
#nullable restore
#line 95 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\CArticle\faceToArticleDetail.cshtml"
                          Write(Convert.ToInt32(item.Price).ToString("0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            <div class=""ratings"">
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""fa fa-star""></i>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 105 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\CArticle\faceToArticleDetail.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



                    </div>
                </div>
        </div>
    </div>
  </div>
</section>
<!-- ##### Blog Content Area End ##### -->
<!-- ##### All Javascript Files ##### -->
<!-- jQuery-2.2.4 js -->
<script src=""js/jquery/jquery-2.2.4.min.js""></script>
<!-- Popper js -->
<script src=""js/bootstrap/popper.min.js""></script>
<!-- Bootstrap js -->
<script src=""js/bootstrap/bootstrap.min.js""></script>
<!-- All Plugins js -->
<script src=""js/plugins/plugins.js""></script>
<!-- Active js -->
<script src=""js/active.js""></script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prjProduct_core.ViewModel.CArticleViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
