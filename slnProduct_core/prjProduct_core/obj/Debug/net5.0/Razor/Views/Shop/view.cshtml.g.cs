#pragma checksum "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\view.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fa51d5e1fa6c6d28677dd3ef92735faf03229b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_view), @"mvc.1.0.view", @"/Views/Shop/view.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fa51d5e1fa6c6d28677dd3ef92735faf03229b6", @"/Views/Shop/view.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e68a38f904a3c0064916e4a245f427c24105a01", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_view : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prjProduct_core.ViewModel.CProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/coffee-img/been2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""breadcrumb-area"">
    <!-- Top Breadcrumb Area -->
    <div class=""top-breadcrumb-area bg-img bg-overlay d-flex align-items-center justify-content-center"" style=""background-image: url(../img/Home-img/02.jpg);"">
        <h2>Shop</h2>
    </div>

    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fa51d5e1fa6c6d28677dd3ef92735faf03229b65715", async() => {
                WriteLiteral("<i class=\"fa fa-home\"></i> Home");
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
            WriteLiteral("</li>\r\n                        <li class=\"breadcrumb-item active\" aria-current=\"page\">Shop</li>\r\n                    </ol>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            WriteLiteral(@"<section class=""shop-page section-padding-0-100"">
    <div class=""container"">

        <div class=""row"">
            <!-- Sidebar Area -->
            <div class=""col-12 col-md-4 col-lg-3"">
                <div class=""shop-sidebar-area"">

                    <!-- Shop Widget -->
                    <div class=""shop-widget catagory mb-50"">
                        <h4 class=""widget-title"">產品類別</h4>
                        <div class=""widget-desc"">
                            <!-- Categories -->
                            <ul>
                                <li>
                                    <ul class=""dropdown"">
                                        <li id=""selectall"" style=""color: #808080 ; cursor:pointer"">所有產品</li>

                                        <li id=""s_1"" style=""color: #808080  ; cursor:pointer"" class=""coff"">咖啡豆</li>
                                        <li id=""s_2"" style=""color: #808080;cursor:pointer"" class=""coff"">咖啡器具</li>
                                      ");
            WriteLiteral(@"  <li id=""s_3"" style=""color: #808080;cursor:pointer"" class=""coff"">消耗品</li>
                                    </ul>
                                </li>
                            </ul>
                        </div>
                    </div>

                    <!-- Shop Widget -->
                    <div class=""shop-widget sort-by mb-50 coffcate"">
                        <h4 class=""widget-title"">咖啡豆分類</h4>
                        <div class=""widget-desc"">
                            <ul>
                                <li>
                                    <ul class=""dropdown test1 "">
                                        <li style=""color: #808080"" class=""list"">
                                            產地國家
                                            <ul class=""coffeelist animate__animated animate__fadeIn"" id=""coffcontry"">
                                                <li id=""c_1"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcn"">衣索比亞	</li>
                     ");
            WriteLiteral(@"                           <li id=""c_2"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcn"">肯亞	</li>
                                                <li id=""c_3"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcn"">盧安達</li>
                                                <li id=""c_4"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcn"">巴西</li>
                                                <li id=""c_5"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcn"">祕魯</li>
                                                <li id=""c_6"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcn"">巴拿馬	</li>
                                                <li id=""c_7"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcn"">瓜地馬拉	</li>
                                                <li id=""c_8"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcn"">薩爾瓦多</li>
                                                <li id=""c_9"" style=""color: #808080  ; cursor:pointer"" class=""cof");
            WriteLiteral(@"fc coffcn"">宏都拉斯	</li>
                                                <li id=""c_10"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcn"">哥倫比亞	</li>
                                                <li id=""c_11"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcn"">哥斯大黎加</li>
                                                <li id=""c_12"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcn"">印尼</li>
                                                <li id=""c_13"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcn"">巴布亞新幾內亞</li>
                                                <li id=""c_14"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcn"">台灣</li>
                                                <li id=""c_15"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcn"">尼加拉瓜</li>
                                            </ul>
                                        </li>
                                        <li style=""color: #808080"" class=""list"">
          ");
            WriteLiteral(@"                                  烘培程度
                                            <ul class=""coffeelist animate__animated animate__fadeIn"" id=""coffroast"">
                                                <li id=""r_1"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcr"">淺焙</li>
                                                <li id=""r_2"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcr"">中淺焙</li>
                                                <li id=""r_3"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcr"">中焙</li>
                                                <li id=""r_4"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcr"">中深焙</li>
                                                <li id=""r_5"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcr"">深焙</li>
                                            </ul>
                                        </li>
                                        <li style=""color: #808080"" class=""list"">
                        ");
            WriteLiteral(@"                    處理方式
                                            <ul class=""coffeelist animate__animated animate__fadeIn dropdown"">
                                                <li id=""w_1"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcw""> 日曬</li>
                                                <li id=""w_2"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcw"">水洗</li>
                                                <li id=""w_3"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcw"">蜜處理</li>
                                                <li id=""w_4"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcw"">特殊處理</li>
                                            </ul>
                                        </li>
                                        <li style=""color: #808080"" class=""list"">
                                            包裝方法
                                            <ul class=""coffeelist animate__animated animate__fadeIn"">
                     ");
            WriteLiteral(@"                           <li id=""p_1"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcp"">豆(半磅)</li>
                                                <li id=""p_2"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcp"">豆(一磅)</li>
                                                <li id=""p_3"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcp"">濾掛</li>
                                                <li id=""p_4"" style=""color: #808080  ; cursor:pointer"" class=""coffc coffcp"">濾袋</li>
                                            </ul>
                                        </li>
                                    </ul>
                                </li>
                            </ul>
                        </div>
                    </div>

                    <!-- Shop Widget -->
                    <div class=""shop-widget best-seller mb-50"">
                        <h4 class=""widget-title"">推薦產品</h4>
                        <div class=""widget-desc"">
");
#nullable restore
#line 116 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\view.cshtml"
                              
                                foreach (Product item in ViewBag.Recommend)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <!-- Single Best Seller Products -->
                                    <div class=""single-best-seller-product d-flex align-items-center"">
                                        <div class=""product-thumbnail"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fa51d5e1fa6c6d28677dd3ef92735faf03229b615594", async() => {
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4fa51d5e1fa6c6d28677dd3ef92735faf03229b615811", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\view.cshtml"
                                                                                           WriteLiteral(item.ProductId);

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
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"product-info\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fa51d5e1fa6c6d28677dd3ef92735faf03229b619275", async() => {
#nullable restore
#line 125 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\view.cshtml"
                                                                                                                   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 125 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\view.cshtml"
                                                                                           WriteLiteral(item.ProductId);

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
            WriteLiteral("\r\n                                            <p>NT$");
#nullable restore
#line 126 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\view.cshtml"
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
#line 136 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\view.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>

            <!-- All Products Area -->
            <div class=""col-12 col-md-8 col-lg-9"">
                <div class=""shop-products-area"">
                    <div class=""row"" id=""showcard"">
                    </div>
                    <!-- Pagination -->
                    <nav aria-label=""Page navigation"">

                    </nav>
                </div>
            </div>
        </div>
    </div>
</section>
");
            DefineSection("Style", async() => {
                WriteLiteral(@"
    <style>
        .coffc {
            margin-left: 5px;
            font-size: 5px;
        }


        .list {
            cursor: default;
            user-select: none;
            color: #1e1e1e
        }

        .coffcate {
            height: 800px;
        }
    </style>
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(\"#showcard\").load(\'");
#nullable restore
#line 180 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\view.cshtml"
                        Write(Url.Content("~/Shop/partialView"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' + \"?id=1\");\r\n\r\n         $(\'#selectall\').click(function () {\r\n            $(\'#showcard\').load(\'");
#nullable restore
#line 183 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\view.cshtml"
                            Write(Url.Content("~/Shop/partialView"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' +\"?id=1\");\r\n        });\r\n\r\n        /*下拉式選單*/\r\n        $(\".coff\").click(function () {\r\n            let id = $(event.target).attr(\"id\").substr(2);\r\n\r\n            $(\'#showcard\').load(\'");
#nullable restore
#line 190 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\view.cshtml"
                            Write(Url.Content("~/Shop/partialViewForCatgory"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' + \"?id=\" + id+\"&page=1\");\r\n\r\n        });\r\n\r\n        $(\".coffcn\").click(function(){\r\n            let id = $(event.target).attr(\"id\").substr(2);\r\n            $(\'#showcard\').load(\'");
#nullable restore
#line 196 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\view.cshtml"
                            Write(Url.Content("~/Shop/partialViewContry"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' + \"?id=\" + id + \"&page=1\");\r\n        })\r\n         $(\".coffcr\").click(function(){\r\n            let id = $(event.target).attr(\"id\").substr(2);\r\n             $(\'#showcard\').load(\'");
#nullable restore
#line 200 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\view.cshtml"
                             Write(Url.Content("~/Shop/partialViewRoast"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' + \"?id=\" + id + \"&page=1\");\r\n         })\r\n         $(\".coffcw\").click(function(){\r\n            let id = $(event.target).attr(\"id\").substr(2);\r\n             $(\'#showcard\').load(\'");
#nullable restore
#line 204 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\view.cshtml"
                             Write(Url.Content("~/Shop/partialViewProcess"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' + \"?id=\" + id + \"&page=1\");\r\n         })\r\n        $(\".coffcp\").click(function(){\r\n            let id = $(event.target).attr(\"id\").substr(2);\r\n            $(\'#showcard\').load(\'");
#nullable restore
#line 208 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\view.cshtml"
                            Write(Url.Content("~/Shop/partialViewPacking"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' + \"?id=\" + id + \"&page=1\");\r\n        })\r\n        /*下拉式選單*/\r\n\r\n\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prjProduct_core.ViewModel.CProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
