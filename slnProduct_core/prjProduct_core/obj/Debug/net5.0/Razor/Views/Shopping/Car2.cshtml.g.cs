#pragma checksum "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shopping\Car2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cf007cdabc22db992cf7d47645a7a889c2f1b33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shopping_Car2), @"mvc.1.0.view", @"/Views/Shopping/Car2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cf007cdabc22db992cf7d47645a7a889c2f1b33", @"/Views/Shopping/Car2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e68a38f904a3c0064916e4a245f427c24105a01", @"/Views/_ViewImports.cshtml")]
    public class Views_Shopping_Car2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Car2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shopping\Car2.cshtml"
  
    ViewData["Title"] = "Car2";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- ##### Breadcrumb Area Start ##### -->
<div class=""breadcrumb-area"">
    <!-- Top Breadcrumb Area -->
    <div class=""top-breadcrumb-area bg-img bg-overlay d-flex align-items-center justify-content-center"" style=""background-image: url(img/bg-img/24.jpg);"">
        <h2>配送付款資訊填寫</h2>
    </div>

    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""#""><i class=""fa fa-home""></i> Home</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Cart</li>
                    </ol>
                </nav>
            </div>
        </div>
    </div>
</div>
<!-- ##### Breadcrumb Area End ##### -->
<!-- ##### Cart Area Start ##### -->
<div class=""cart-area section-padding-0-100 clearfix"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
     ");
            WriteLiteral(@"           <div class=""cart-table clearfix"">

                    <div class=""progress"" style=""height: 40px; background-color: #F0F0F0; margin-bottom: 50px;"">
                        <div class=""progress-bar"" role=""progressbar"" style=""width: 33%; font-size: 15px; background-color: #BEBEBE"" aria-valuenow=""33"" aria-valuemin=""0"" aria-valuemax=""100"">確認購物車</div>
                        <div class=""progress-bar"" role=""progressbar"" style=""width: 33%; font-size: 15px;"" aria-valuenow=""33"" aria-valuemin=""0"" aria-valuemax=""100"">付款與運送方式</div>
                        <div class=""progress-bar"" role=""progressbar"" style=""width: 34%; font-size: 15px; background-color: #BEBEBE"" aria-valuenow=""33"" aria-valuemin=""0"" aria-valuemax=""100"">最後確認</div>
                    </div>

                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7cf007cdabc22db992cf7d47645a7a889c2f1b336155", async() => {
                WriteLiteral(@"
                        <div class=""form-horizontal"">
                            <h4>填寫訂單收件人資料</h4>
                            <hr />
                            <div class=""form-group"">
                                <span class=""control-label col-md-2"">收件人姓名</span>
                                <div class=""col-3"">
                                    <input type=""text"" id=""fReceiver"" name=""fReceiver"" required=""required"" class=""form-control"" placeholder=""請輸入中文全名"" />
                                </div>
                            </div>
                            <div class=""form-group"">
                                <span class=""control-label col-md-2"">收件人電話</span>
                                <div class=""col-3"">
                                    <input type=""text"" id=""fPhone"" name=""fPhone"" required=""required"" class=""form-control"" placeholder=""請輸入格式為:09xxxxxxxx"" pattern=""09\d{8}""/>
                                </div>
                            </div>
                      ");
                WriteLiteral(@"      <div class=""form-group"">
                                <span class=""control-label col-md-2"">收件人地址</span>
                                <div class=""col-3"">
                                    <input type=""text"" id=""fAddress"" name=""fAddress"" required=""required"" class=""form-control"" placeholder=""請輸入收件地址""/>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <span class=""control-label col-md-2"">付款方式</span>
                                <div class=""col-md-10"">
                                    ");
#nullable restore
#line 65 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shopping\Car2.cshtml"
                               Write(Html.RadioButton("payment", "2", true));

#line default
#line hidden
#nullable disable
                WriteLiteral(" 信用卡<br />\r\n                                    ");
#nullable restore
#line 66 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shopping\Car2.cshtml"
                               Write(Html.RadioButton("payment", "1"));

#line default
#line hidden
#nullable disable
                WriteLiteral("貨到付款\r\n                                </div>\r\n                            </div>\r\n\r\n                            <input type=\"hidden\" id=\"fdiscount\" name=\"fdiscount\"");
                BeginWriteAttribute("value", " value=\"", 3845, "\"", 3874, 1);
#nullable restore
#line 70 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shopping\Car2.cshtml"
WriteAttributeValue("", 3853, ViewData["discount"], 3853, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\r\n\r\n                            <div class=\"form-group\">\r\n                                <div class=\"col-md-offset-2 col-md-10\">\r\n                                    ");
#nullable restore
#line 74 "C:\Users\user\source\repos\PuanZhou\CharpCoffee\slnProduct_core\prjProduct_core\Views\Shopping\Car2.cshtml"
                               Write(Html.ActionLink("返回上一步", "ShoppingCar", "Shopping", null, new { @class = "btn btn-light" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    <input type=\"submit\" value=\"前往最後確認\" class=\"btn btn-info\" id=\"nextpage\" />\r\n                                </div>\r\n                            </div>\r\n\r\n                        </div>\r\n\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n       \r\n\r\n    </div>\r\n</div>\r\n<!-- ##### Cart Area End ##### -->\r\n\r\n\r\n\r\n\r\n\r\n");
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
