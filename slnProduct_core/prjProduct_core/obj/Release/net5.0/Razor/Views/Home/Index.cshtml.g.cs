#pragma checksum "C:\Users\Student\Source\Repos\tsaiwenkai\product\slnProduct_core\prjProduct_core\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ade652b9272800870ab906a839cac4c751d3c15c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Student\Source\Repos\tsaiwenkai\product\slnProduct_core\prjProduct_core\Views\_ViewImports.cshtml"
using prjProduct_core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Source\Repos\tsaiwenkai\product\slnProduct_core\prjProduct_core\Views\_ViewImports.cshtml"
using prjProduct_core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ade652b9272800870ab906a839cac4c751d3c15c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e68a38f904a3c0064916e4a245f427c24105a01", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "view", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn alazea-btn mr-30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Student\Source\Repos\tsaiwenkai\product\slnProduct_core\prjProduct_core\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- ##### Hero Area Start ##### -->
<section class=""hero-area"">
    <div class=""hero-post-slides owl-carousel"">

        <!-- Single Hero Post -->
        <div class=""single-hero-post bg-overlay"">
            <!-- Post Image -->
            <div class=""slide-img bg-img"" style=""background-image: url(img/Home-img/01.jpg); ""></div>
            <div class=""container h-100"">
                <div class=""row h-100 align-items-center"">
                    <div class=""col-12"">
                        <!-- Post Content -->
                        <div class=""hero-slides-content text-center"">
                            <h2>守護地球 從選用「雨林聯盟」認證的好咖啡開始！</h2>
                            <p>一起響應地球環境永續、雨林生態維護等理念，幫助咖啡農場工人擁有健全的工作環境及工資，為改善咖啡生產地的醫療、居住環境盡一份心力。</p>
                            <div class=""welcome-btn-group"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ade652b9272800870ab906a839cac4c751d3c15c5217", async() => {
                WriteLiteral("Go Shop");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                <a href=""#"" class=""btn alazea-btn active"">CONTACT US</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Single Hero Post -->
        <div class=""single-hero-post bg-overlay"">
            <!-- Post Image -->
            <div class=""slide-img bg-img"" style=""background-image: url(img/Home-img/02.jpg); ""></div>
            <div class=""container h-100"">
                <div class=""row h-100 align-items-center"">
                    <div class=""col-12"">
                        <!-- Post Content -->
                        <div class=""hero-slides-content text-center"">
                            <h2>守護地球 從選用「雨林聯盟」認證的好咖啡開始！</h2>
                            <p>以義式高壓萃取的雨林聯盟認證咖啡，享受清香芳醇的口感與香氣，還能在生活中的微小時刻，積蓄保護生態的能量，在蛙鳴中落實森林永續的理念。</p>
                            <div class=""welcome-btn-group"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ade652b9272800870ab906a839cac4c751d3c15c7672", async() => {
                WriteLiteral("Go Shop");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                <a href=""#"" class=""btn alazea-btn active"">CONTACT US</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
</section>
<!-- ##### Hero Area End ##### -->
<!-- ##### video Area Start ##### -->
<section class=""our-services-area bg-gray section-padding-100-0"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <!-- Section Heading -->
                <div class=""section-heading text-center"">
                    <h2>咖啡豆兩大品種</h2>
                    <p>阿拉比卡 Arabica & 羅布斯塔 Robusta</p>
                </div>
            </div>
        </div>

        <div class=""row justify-content-between"">
            <div class=""col-12 col-lg-5"">
                <div class=""alazea-service-area mb-100"">

                    <!-- Single Service Area -->
                    <div class=""single-service-area d-fle");
            WriteLiteral("x align-items-center wow fadeInUp\" data-wow-delay=\"100ms\">\r\n                        <!-- Icon -->\r\n                        <div class=\"service-icon mr-30\">\r\n                            <img src=\"img/coffee-img/Arabica.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3309, "\"", 3315, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <!-- Content -->
                        <div class=""service-content"">
                            <h5>阿拉比卡 Arabica</h5>
                            <p>阿拉比卡在咖啡市場市佔率近七成，如此受歡迎與此品種帶有細緻柔和的果酸與花香的風味特色有關。一般來說咖啡在愈高的海拔生長，風味層次愈值得期待。阿拉比卡平均種植在海拔1000-2000公尺以上的位置，豆種咖啡因含量較低，含糖量是羅布斯特豆種的兩倍，脂肪含量比羅布斯特多了60%，綜合整體風味更為香甜。</p>
                        </div>
                    </div>

                    <!-- Single Service Area -->
                    <div class=""single-service-area d-flex align-items-center wow fadeInUp"" data-wow-delay=""300ms"">
                        <!-- Icon -->
                        <div class=""service-icon mr-30"">
                            <img src=""img/coffee-img/Robusta.png""");
            BeginWriteAttribute("alt", " alt=\"", 4075, "\"", 4081, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <!-- Content -->
                        <div class=""service-content"">
                            <h5>羅布斯塔 Robusta</h5>
                            <p>與阿拉比卡相比之下，羅布斯特在風味表現雖然稍嫌遜色，香氣平平、口感也略為粗糙，但良好的抗病力使其果實繁殖能力強。綠原酸的成分含量高，好處是農作物栽種方面不易受害蟲與氣候環境所影響。羅布斯特在海拔較低800公尺以下的地方也能生長的很好。</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-12 col-lg-6"">
                <div class=""alazea-video-area bg-overlay mb-100"">
                    <iframe width=""540"" height=""350"" src=""https://www.youtube.com/embed/vFcS080VYQ0"" title=""The basics about: Coffee"" frameborder=""0"" allow=""accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- ##### video Area End ##### -->
<!-- ##### Portfolio Area Start ##### -->
<section class=""alazea-portfolio-ar");
            WriteLiteral(@"ea section-padding-100-0"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <!-- Section Heading -->
                <div class=""section-heading text-center"">
                    <h2>照片集</h2>
                    <p>We devote all of our experience and efforts for creation</p>
                </div>
            </div>
        </div>
    </div>

    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""alazea-portfolio-filter"">
                    <div class=""portfolio-filter"">
                        <button class=""btn active"" data-filter=""*"">All</button>
                        <button class=""btn"" data-filter="".design"">Coffee Art</button>
                        <button class=""btn"" data-filter="".garden"">Process</button>
                        <button class=""btn"" data-filter="".home-design"">Roasting</button>
                        <button class=""btn"" data-filter="".office-de");
            WriteLiteral("sign\">About the Bean</button>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row alazea-portfolio\">\r\n");
            WriteLiteral(@"            <!-- Single Portfolio Area -->
            <div class=""col-12 col-sm-6 col-lg-3 single_portfolio_item design  wow fadeInUp"" data-wow-delay=""100ms"">
                <!-- Portfolio Thumbnail -->
                <div class=""portfolio-thumbnail bg-img"" style=""background-image: url(/img/coffee-img/latta1.jpg);""></div>
                <!-- Portfolio Hover Text -->
                <div class=""portfolio-hover-overlay"">
                    <a href=""/img/coffee-img/latta1.jpg"" class=""portfolio-img d-flex align-items-center justify-content-center"">
                        <div class=""port-hover-text"">
                            <h3>濃萃拿鐵</h3>
                            <h5>Latte Art</h5>
                        </div>
                    </a>
                </div>
            </div>
            <!-- Single Portfolio Area -->
            <div class=""col-12 col-sm-6 col-lg-3 single_portfolio_item design  wow fadeInUp"" data-wow-delay=""100ms"">
                <!-- Portfolio Thumbnail -->
     ");
            WriteLiteral(@"           <div class=""portfolio-thumbnail bg-img"" style=""background-image: url(/img/coffee-img/latta2.jpg);""></div>
                <!-- Portfolio Hover Text -->
                <div class=""portfolio-hover-overlay"">
                    <a href=""/img/coffee-img/latta2.jpg"" class=""portfolio-img d-flex align-items-center justify-content-center"">
                        <div class=""port-hover-text"">
                            <h3>卡布奇諾</h3>
                            <h5>Latte Art</h5>
                        </div>
                    </a>
                </div>
            </div>
");
            WriteLiteral(@"            <!-- Single Portfolio Area -->
            <div class=""col-12 col-sm-6 col-lg-3 single_portfolio_item garden wow fadeInUp"" data-wow-delay=""200ms"">
                <!-- Portfolio Thumbnail -->
                <div class=""portfolio-thumbnail bg-img"" style=""background-image: url(/img/coffee-img/pross1.jpg);""></div>
                <!-- Portfolio Hover Text -->
                <div class=""portfolio-hover-overlay"">
                    <a href=""/img/coffee-img/pross1.jpg"" class=""portfolio-img d-flex align-items-center justify-content-center"" title=""Portfolio 2"">
                        <div class=""port-hover-text"">
                            <h3>處理方式</h3>
                            <h5>日曬法</h5>
                        </div>
                    </a>
                </div>
            </div>

            <!-- Single Portfolio Area -->
            <div class=""col-12 col-sm-6 col-lg-3 single_portfolio_item garden wow fadeInUp"" data-wow-delay=""200ms"">
                <!-- Portfolio Thumbn");
            WriteLiteral(@"ail -->
                <div class=""portfolio-thumbnail bg-img"" style=""background-image: url(/img/coffee-img/pross2.jpg);""></div>
                <!-- Portfolio Hover Text -->
                <div class=""portfolio-hover-overlay"">
                    <a href=""/img/coffee-img/pross2.jpg"" class=""portfolio-img d-flex align-items-center justify-content-center"" title=""Portfolio 2"">
                        <div class=""port-hover-text"">
                            <h3>處理方式</h3>
                            <h5>水洗法</h5>
                        </div>
                    </a>
                </div>
            </div>

            <!-- Single Portfolio Area -->
            <div class=""col-12 col-sm-6 col-lg-3 single_portfolio_item office-design wow fadeInUp"" data-wow-delay=""400ms"">
                <!-- Portfolio Thumbnail -->
                <div class=""portfolio-thumbnail bg-img"" style=""background-image: url(/img/coffee-img/farm4.jpg);""></div>
                <!-- Portfolio Hover Text -->
             ");
            WriteLiteral(@"   <div class=""portfolio-hover-overlay"">
                    <a href=""/img/coffee-img/farm4.jpg"" class=""portfolio-img d-flex align-items-center justify-content-center"" title=""Portfolio 4"">
                        <div class=""port-hover-text"">
                            <h3>Friend Of Coffee</h3>
                            <h5>Service Person</h5>
                        </div>
                    </a>
                </div>
            </div>
            <!-- Single Portfolio Area -->
            <div class=""col-12 col-sm-6 col-lg-3 single_portfolio_item garden wow fadeInUp"" data-wow-delay=""200ms"">
                <!-- Portfolio Thumbnail -->
                <div class=""portfolio-thumbnail bg-img"" style=""background-image: url(/img/coffee-img/pross3.jpg);""></div>
                <!-- Portfolio Hover Text -->
                <div class=""portfolio-hover-overlay"">
                    <a href=""/img/coffee-img/pross3.jpg"" class=""portfolio-img d-flex align-items-center justify-content-center"" title=""P");
            WriteLiteral(@"ortfolio 2"">
                        <div class=""port-hover-text"">
                            <h3>處理方式</h3>
                            <h5>蜜處理法</h5>
                        </div>
                    </a>
                </div>
            </div>
");
            WriteLiteral(@"            <!-- Single Portfolio Area -->
            <div class=""col-12 col-sm-6  single_portfolio_item home-design  wow fadeInUp"" data-wow-delay=""300ms"">
                <!-- Portfolio Thumbnail -->
                <div class=""portfolio-thumbnail bg-img"" style=""background-image: url(/img/coffee-img/been1.jpg);""></div>
                <!-- Portfolio Hover Text -->
                <div class=""portfolio-hover-overlay"">
                    <a href=""/img/coffee-img/been1.jpg"" class=""portfolio-img d-flex align-items-center justify-content-center"">
                        <div class=""port-hover-text"">
                            <h3>烘焙程度</h3>
                            <h5>去殼至烘焙</h5>
                        </div>
                    </a>
                </div>
            </div>

            <!-- Single Portfolio Area -->
            <div class=""col-12 col-sm-6 col-lg-3 single_portfolio_item home-design wow fadeInUp"" data-wow-delay=""300ms"">
                <!-- Portfolio Thumbnail -->
        ");
            WriteLiteral(@"        <div class=""portfolio-thumbnail bg-img"" style=""background-image: url(/img/coffee-img/been2.jpg);""></div>
                <!-- Portfolio Hover Text -->
                <div class=""portfolio-hover-overlay"">
                    <a href=""/img/coffee-img/been2.jpg"" class=""portfolio-img d-flex align-items-center justify-content-center"">
                        <div class=""port-hover-text"">
                            <h3>烘焙程度</h3>
                            <h5>採摘</h5>
                        </div>
                    </a>
                </div>
            </div>

            <!-- Single Portfolio Area -->
            <div class=""col-12 col-sm-6 single_portfolio_item home-design wow fadeInUp"" data-wow-delay=""300ms"">
                <!-- Portfolio Thumbnail -->
                <div class=""portfolio-thumbnail bg-img"" style=""background-image: url(/img/coffee-img/been3.jpg);""></div>
                <!-- Portfolio Hover Text -->
                <div class=""portfolio-hover-overlay"">
         ");
            WriteLiteral(@"           <a href=""/img/coffee-img/been3.jpg"" class=""portfolio-img d-flex align-items-center justify-content-center"">
                        <div class=""port-hover-text"">
                            <h3>烘焙程度</h3>
                            <h5>咖啡豆的一生</h5>
                        </div>
                    </a>
                </div>
            </div>
            <!-- Single Portfolio Area -->
            <div class=""col-12 col-sm-6 col-lg-3 single_portfolio_item design  wow fadeInUp"" data-wow-delay=""100ms"">
                <!-- Portfolio Thumbnail -->
                <div class=""portfolio-thumbnail bg-img"" style=""background-image: url(/img/coffee-img/latta3.jpg);""></div>
                <!-- Portfolio Hover Text -->
                <div class=""portfolio-hover-overlay"">
                    <a href=""/img/coffee-img/latta3.jpg"" class=""portfolio-img d-flex align-items-center justify-content-center"">
                        <div class=""port-hover-text"">
                            <h3>卡布奇諾</h3>");
            WriteLiteral("\r\n                            <h5>Latte Art</h5>\r\n                        </div>\r\n                    </a>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <!-- Single Portfolio Area -->
            <div class=""col-12 col-sm-6 col-lg-3 single_portfolio_item  office-design wow fadeInUp"" data-wow-delay=""400ms"">
                <!-- Portfolio Thumbnail -->
                <div class=""portfolio-thumbnail bg-img"" style=""background-image: url(/img/coffee-img/farm1.jpg);""></div>
                <!-- Portfolio Hover Text -->
                <div class=""portfolio-hover-overlay"">
                    <a href=""/img/coffee-img/farm1.jpg"" class=""portfolio-img d-flex align-items-center justify-content-center"" title=""Portfolio 4"">
                        <div class=""port-hover-text"">
                            <h3>Home Of Coffee</h3>
                            <h5>Farm</h5>
                        </div>
                    </a>
                </div>
            </div>
            <!-- Single Portfolio Area -->
            <div class=""col-12 col-sm-6 col-lg-3 single_portfolio_item office-design wow fadeInUp"" data-wow-delay=""400ms"">
               ");
            WriteLiteral(@" <!-- Portfolio Thumbnail -->
                <div class=""portfolio-thumbnail bg-img"" style=""background-image: url(/img/coffee-img/farm2.jpg);""></div>
                <!-- Portfolio Hover Text -->
                <div class=""portfolio-hover-overlay"">
                    <a href=""/img/coffee-img/farm2.jpg"" class=""portfolio-img d-flex align-items-center justify-content-center"" title=""Portfolio 4"">
                        <div class=""port-hover-text"">
                            <h3>Coffee bean</h3>
                            <h5>Coffee itself</h5>
                        </div>
                    </a>
                </div>
            </div>
            <!-- Single Portfolio Area -->
            <div class=""col-12 col-sm-6 col-lg-3 single_portfolio_item design  wow fadeInUp"" data-wow-delay=""100ms"">
                <!-- Portfolio Thumbnail -->
                <div class=""portfolio-thumbnail bg-img"" style=""background-image: url(/img/coffee-img/latta4.jpg);""></div>
                <!-- Portfolio");
            WriteLiteral(@" Hover Text -->
                <div class=""portfolio-hover-overlay"">
                    <a href=""/img/coffee-img/latta4.jpg"" class=""portfolio-img d-flex align-items-center justify-content-center"">
                        <div class=""port-hover-text"">
                            <h3>卡布奇諾</h3>
                            <h5>Latte Art</h5>
                        </div>
                    </a>
                </div>
            </div>
            <!-- Single Portfolio Area -->
            <div class=""col-12 col-sm-6 col-lg-3 single_portfolio_item office-design wow fadeInUp"" data-wow-delay=""400ms"">
                <!-- Portfolio Thumbnail -->
                <div class=""portfolio-thumbnail bg-img"" style=""background-image: url(/img/coffee-img/farm3.jpg);""></div>
                <!-- Portfolio Hover Text -->
                <div class=""portfolio-hover-overlay"">
                    <a href=""/img/coffee-img/farm3.jpg"" class=""portfolio-img d-flex align-items-center justify-content-center"" title=""Po");
            WriteLiteral(@"rtfolio 4"">
                        <div class=""port-hover-text"">
                            <h3>Friend Of Coffee</h3>
                            <h5>Service Person</h5>
                        </div>
                    </a>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- ##### Portfolio Area End ##### -->

<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591