#pragma checksum "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dc338ab8537235f27101640270092fae2b27653"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_detail), @"mvc.1.0.view", @"/Views/Shop/detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dc338ab8537235f27101640270092fae2b27653", @"/Views/Shop/detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e68a38f904a3c0064916e4a245f427c24105a01", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<prjProduct_core.ViewModel.CProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "view", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart clearfix d-flex align-items-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- ##### Breadcrumb Area Start ##### -->
<div class=""breadcrumb-area"">
    <!-- Top Breadcrumb Area -->
    <div class=""top-breadcrumb-area bg-img bg-overlay d-flex align-items-center justify-content-center"" style=""background-image: url(../../img/Home-img/02.jpg);"">
        <h2>DETAILS</h2>
    </div>

    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dc338ab8537235f27101640270092fae2b276536236", async() => {
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
            WriteLiteral("</li>\r\n                        <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dc338ab8537235f27101640270092fae2b276537683", async() => {
                WriteLiteral("Shop");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Shop Details</li>
                    </ol>
                </nav>
            </div>
        </div>
    </div>
</div>
<!-- ##### Breadcrumb Area End ##### -->
<!-- ##### Single Product Details Area Start ##### -->
<section class=""single_product_details_area mb-50"">
    <div class=""produts-details--content mb-50"">
        <div class=""container"">
            <div class=""row justify-content-between"">
");
            WriteLiteral(@"                <div class=""col-12 col-md-6 col-lg-5"">
                    <div class=""single_product_thumb"">
                        <div id=""product_details_slider"" class=""carousel slide"" data-ride=""carousel"">
                            <div class=""carousel-inner"">
                                <div class=""carousel-item active"">
                                    <a class=""product-img"" href=""../../img/Home-img/02.jpg"" title=""Product Image"">
                                        <img class=""d-block w-100"" src=""../../img/Home-img/02.jpg"" alt=""1"">
                                    </a>
                                </div>
                                <div class=""carousel-item"">
                                    <a class=""product-img"" href=""../../img/Home-img/02.jpg"" title=""Product Image"">
                                        <img class=""d-block w-100"" src=""../../img/Home-img/02.jpg"" alt=""1"">
                                    </a>
                                </div>
        ");
            WriteLiteral(@"                        <div class=""carousel-item"">
                                    <a class=""product-img"" href=""../../img/Home-img/02.jpg"" title=""Product Image"">
                                        <img class=""d-block w-100"" src=""../../img/Home-img/02.jpg"" alt=""1"">
                                    </a>
                                </div>
                            </div>
                            <ol class=""carousel-indicators"">
                                <li class=""active"" data-target=""#product_details_slider"" data-slide-to=""0"" style=""background-image: url(../../img/Home-img/02.jpg); "">
                                </li>
                                <li data-target=""#product_details_slider"" data-slide-to=""1"" style=""background-image: url(../../img/Home-img/02.jpg); "">
                                </li>
                                <li data-target=""#product_details_slider"" data-slide-to=""2"" style=""background-image: url(../../img/Home-img/02.jpg);"">
               ");
            WriteLiteral("                 </li>\r\n                            </ol>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"col-12 col-md-6\">\r\n                    <div class=\"single_product_desc\">\r\n                        <h4 class=\"title\">");
#nullable restore
#line 64 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
                                     Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <h4 class=\"price\">NT$");
#nullable restore
#line 65 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
                                         Write(Convert.ToInt32( Model.Price).ToString("0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <div class=\"short_overview\">\r\n                            <p>");
#nullable restore
#line 67 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
                          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"cart--area d-flex flex-wrap align-items-center\">\r\n                            <!-- Add to Cart Form -->\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dc338ab8537235f27101640270092fae2b2765313324", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("                                <a");
                BeginWriteAttribute("href", " href=\"", 4940, "\"", 5011, 1);
#nullable restore
#line 77 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
WriteAttributeValue("", 4947, Url.Action("AddtoCart","Shopping", new { id = Model.ProductId}), 4947, 64, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"cursor:pointer\" class=\"btn alazea-btn ml-15\"><span hidden id=\"addtocart\">");
#nullable restore
#line 77 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
                                                                                                                                                                                      Write(Model.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>Add to cart</a>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <!-- Wishlist & Compare -->
                            <div class=""wishlist-compare d-flex flex-wrap align-items-center"">
                                <a href=""javascript:void(0);"" class=""wishlist-btn ml-15""><i class=""icon_heart_alt""><span hidden id=""comid"">");
#nullable restore
#line 81 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
                                                                                                                                      Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></i></a>\r\n                                <a style=\"cursor:pointer\" class=\"compare-btn ml-15\"><i class=\"arrow_left-right_alt\"></i><span hidden id=\"comid\">");
#nullable restore
#line 82 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
                                                                                                                                           Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n                            </div>\r\n                        </div>\r\n\r\n");
#nullable restore
#line 86 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
                          
                            if (Model.CategoryId == 1)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""products--meta"">
                                    <p><span>產地:</span> <span>台灣</span></p>
                                    <p><span>烘培程度:</span>非常重</p>
                                    <p><span>處理方法:</span> <span>日曬法</span></p>
                                    <p>
                                        <span>Share on:</span>
                                        <span>
                                            <a href=""#""><i class=""fa-brand fa-facebook""></i></a>
                                            <a href=""#""><i class=""fa-brand fa-twitter""></i></a>
                                            <a href=""#""><i class=""fa-brand fa-pinterest""></i></a>
                                            <a href=""#""><i class=""fa-brand fa-google-plus""></i></a>
                                        </span>
                                    </p>
                                </div>
");
#nullable restore
#line 104 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"products--meta\">\r\n                                    <p><span>產地:</span> <span>台灣</span></p>\r\n                                    <p><span>產品種類:</span> <span>");
#nullable restore
#line 109 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
                                                           Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                                    <p>
                                        <span>Share on:</span>
                                        <span>
                                            <a href=""#""><i class=""fa-brand fa-facebook""></i></a>
                                            <a href=""#""><i class=""fa-brand fa-twitter""></i></a>
                                            <a href=""#""><i class=""fa-brand fa-pinterest""></i></a>
                                            <a href=""#""><i class=""fa-brand fa-google-plus""></i></a>
                                        </span>
                                    </p>
                                </div>
");
#nullable restore
#line 120 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--===================Comments and Ranking Area Start=====================-->
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""product_details_tab clearfix"">
                    <!-- Tabs -->
                    <ul class=""nav nav-tabs"" role=""tablist"" id=""product-details-tab"">
                        <li class=""nav-item"">
                            <a href=""#description"" class=""nav-link active"" data-toggle=""tab"" role=""tab"">Description</a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""#addi-info"" class=""nav-link"" data-toggle=""tab"" role=""tab"">Additional Information</a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""#reviews"" class=""nav-link"" data-toggle=""tab"" role=""tab"">評價&回覆 <span class=""text-mute");
            WriteLiteral(@"d""></span></a>
                        </li>
                    </ul>
                    <!-- Tab Content -->
                    <div class=""tab-content"">
                        <div role=""tabpanel"" class=""tab-pane fade show active"" id=""description"">
                            <div class=""description_area"">
                                <p></p>
                                <p>Interdum et malesuada fames ac ante ipsum primis in faucibus. In scelerisque augue at the moment mattis. Proin vitae arcu sit amet justo sollicitudin tincidunt sit amet ut velit.Proin placerat vel augue eget euismod. Phasellus cursus orci eu tellus vestibulum, vestibulum urna accumsan. Vestibulum ut ullamcorper sapien. Pellentesque molestie, est ac vestibulum eleifend, lorem ipsum mollis ipsum.</p>
                            </div>
                        </div>
                        <div role=""tabpanel"" class=""tab-pane fade"" id=""addi-info"">
                            <div class=""additional_info_area"">
        ");
            WriteLiteral(@"                        <p>
                                    What should I do if I receive a damaged parcel?
                                    <br> <span>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reprehenderit impedit similique qui, itaque delectus labore.</span>
                                </p>
                                <p>
                                    I have received my order but the wrong item was delivered to me.
                                    <br> <span>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Facilis quam voluptatum beatae harum tempore, ab?</span>
                                </p>
                                <p>
                                    Product Receipt and Acceptance Confirmation Process
                                    <br> <span>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolorum ducimus, temporibus soluta impedit minus rerum?</span>
                                </p>
                         ");
            WriteLiteral(@"       <p>
                                    How do I cancel my order?
                                    <br> <span>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Nostrum eius eum, minima!</span>
                                </p>
                            </div>
                        </div>
                        <div role=""tabpanel"" class=""tab-pane fade"" id=""reviews"">
                            <div class=""reviews_area"">
                                <ul>
                                    <li>
                                    </li>
                                </ul>
                            </div>

                            <div class=""submit_a_review_area mt-50"">
                                <h4>給予評價</h4>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dc338ab8537235f27101640270092fae2b2765324380", async() => {
                WriteLiteral(@"
                                    <div class=""row"">
                                        <div class=""col-12"">
                                            <div class=""form-group d-flex align-items-center"">
                                                <span class=""mr-15"">評價星數:</span>
                                                <div class=""stars"">
                                                    <input type=""radio"" name=""star"" value=""1"" class=""star-1 rc"" id=""star-1"">
                                                    <label class=""star-1"" for=""star-1"">1</label>
                                                    <input type=""radio"" name=""star"" value=""2"" class=""star-2 rc"" id=""star-2"">
                                                    <label class=""star-2"" for=""star-2"">2</label>
                                                    <input type=""radio"" name=""star"" value=""3"" class=""star-3 rc"" id=""star-3"">
                                                    <label class=""star-3"" for=""star-");
                WriteLiteral(@"3"">3</label>
                                                    <input type=""radio"" name=""star"" value=""4"" class=""star-4 rc"" id=""star-4"">
                                                    <label class=""star-4"" for=""star-4"">4</label>
                                                    <input type=""radio"" name=""star"" value=""5"" class=""star-5 rc"" id=""star-5"">
                                                    <label class=""star-5"" for=""star-5"">5</label>
                                                    <span></span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""col-12"">
                                            <div class=""form-group"">
                                                <label for=""comments"">評價內容</label>
                                                <textarea class=""form-control"" id=""comments"" rows=""5"" data-max-length=""150""");
                WriteLiteral(@"></textarea>
                                            </div>
                                        </div>
                                        <div class=""col-12"">
                                            <button id=""btnSummit"" class=""btn alazea-btn"">提出評價</button>
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <p id=""btnComment"" style=""cursor:pointer"" class=""text-primary mt-3"">查看評論與回覆</p>
                            <div id=""divComment""></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--===================Comments and Ranking Area End=====================-->
<!-- ##### Single Product Details Area End ##### -->
<!-- ##### Related Product Area Start ##### -->
<div class=""related-products-area"">
</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        //=====================設定評論星數=====================\r\n        const pId =");
#nullable restore
#line 233 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
              Write(Model.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
        let starNum=0;
        $("".rc"").click(function () {
            starNum = event.target.value;
        });
        //=====================送出評論鈕=====================
        $(""#btnSummit"").click(function (e) {
            e.preventDefault();
            let comStr = $(""#comments"").val();
            if (starNum == 0 || comStr == """") { return };
            $.post('");
#nullable restore
#line 243 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
               Write(Url.Content("~/api/AddComment"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"', {
                ""OrderId"": 1,""ProductId"":pId, ""MemberId"":1, ""CommentParentId"":0,
                ""CommentDescription"": comStr, ""Star"": starNum
            }, function (data) {
                $("".submit_a_review_area"").hide();
                $(""#btnComment"").hide();
                alert(data);
                $(""#divComment"").load('");
#nullable restore
#line 250 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
                                  Write(Url.Content("~/home/_CommentBoard"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',{ \"productId\": pId });\r\n            })\r\n        })\r\n        //=====================計算評論與回覆的數量並顯示=====================\r\n        $.getJSON(\'");
#nullable restore
#line 254 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
              Write(Url.Content("~/api/CountComments"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"', { ""productId"": pId }, function (counts) {
            if (counts[0] == 0) {
                $(""#btnComment"").attr(""hidden"", """");
            }
            else if (counts[1] == 0) {
                $(""#btnComment"").text(`查看評論(${counts[0]})`)
            }
            else {
                $(""#btnComment"").text(`查看評論(${counts[0]})與回覆(${counts[1]})`)
            }
        })

        //=====================查看評論與回覆鈕=====================
        $(""#btnComment"").click(function () {
            $(""#divComment"").load('");
#nullable restore
#line 268 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
                              Write(Url.Content("~/home/_CommentBoard"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',{ \"productId\": pId });\r\n            $(\"#btnComment\").hide();\r\n        })\r\n\r\n        //=====================推薦商品區域=====================\r\n         $.get(\'");
#nullable restore
#line 273 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
           Write(Url.Content("~/Shop/partialViewRelated"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\', { \"ID\":");
#nullable restore
#line 273 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
                                                              Write(Model.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral("},\r\n                function (data) {\r\n                    if (data != \"null\") {\r\n                         $(\".related-products-area\").load(\'");
#nullable restore
#line 276 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
                                                      Write(Url.Content("~/Shop/partialViewRelated"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' + \"?Id=");
#nullable restore
#line 276 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
                                                                                                        Write(Model.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""")
                    }
             })

        //====================加入收藏================================
        $("".wishlist-btn"").click(async function (event) {
            let likeid = event.currentTarget.textContent;
            console.log(likeid);
            $.get('");
#nullable restore
#line 284 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
              Write(Url.Content("~/MemberFactory/AddtoMyLike"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\', { \"id\": likeid },\r\n                function (data) {\r\n                    if (data == \"此商品已收藏過\" || data == \"已加入收藏\") {\r\n                        alert(data);\r\n                    } else {\r\n                        window.location.href = \'");
#nullable restore
#line 289 "C:\Users\Student\Desktop\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shop\detail.cshtml"
                                           Write(Url.Content("~/MemberFactory/AddtoMyLike"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n                    }\r\n                });\r\n        }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<prjProduct_core.ViewModel.CProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
