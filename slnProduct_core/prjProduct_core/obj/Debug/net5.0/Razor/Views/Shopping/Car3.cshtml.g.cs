#pragma checksum "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ede416bed6d41c8f668ca4222f273f995ad7c3e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shopping_Car3), @"mvc.1.0.view", @"/Views/Shopping/Car3.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ede416bed6d41c8f668ca4222f273f995ad7c3e2", @"/Views/Shopping/Car3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e68a38f904a3c0064916e4a245f427c24105a01", @"/Views/_ViewImports.cshtml")]
    public class Views_Shopping_Car3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prjCSCoffee.Models.CShoppingCartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formCreditCard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept-charset", new global::Microsoft.AspNetCore.Html.HtmlString("UTF-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://payment-stage.opay.tw/Cashier/AioCheckOut/V5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
  
    ViewData["Title"] = "Car3";
    int count = 0;
    int Total = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- ##### Breadcrumb Area Start ##### -->
<div class=""breadcrumb-area"">
    <!-- Top Breadcrumb Area -->
    <div class=""top-breadcrumb-area bg-img bg-overlay d-flex align-items-center justify-content-center"" style=""background-image: url(img/bg-img/24.jpg);"">
        <h2>購物明細確認</h2>
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
            WriteLiteral(@"         <div class=""cart-table clearfix"">

                    <div class=""progress"" style=""height: 40px; background-color: #F0F0F0; margin-bottom: 50px;"">
                        <div class=""progress-bar"" role=""progressbar"" style=""width: 33%; font-size: 15px; background-color: #BEBEBE"" aria-valuenow=""33"" aria-valuemin=""0"" aria-valuemax=""100"">確認購物車</div>
                        <div class=""progress-bar"" role=""progressbar"" style=""width: 33%; font-size: 15px; background-color: #BEBEBE"" aria-valuenow=""33"" aria-valuemin=""0"" aria-valuemax=""100"">付款與運送方式</div>
                        <div class=""progress-bar"" role=""progressbar"" style=""width: 34%; font-size: 15px;"" aria-valuenow=""33"" aria-valuemin=""0"" aria-valuemax=""100"">最後確認</div>
                    </div>

                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>
                                    產品名稱
                                </th>
                        ");
            WriteLiteral("        <th>\r\n                                    ");
#nullable restore
#line 50 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
                               Write(Html.DisplayNameFor(model => model.count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 53 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
                               Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 56 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
                               Write(Html.DisplayNameFor(model => model.小計));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 62 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
                             foreach (var item in Model)
                            {
                                count++;
                                Total += (int)item.小計;
                                int price = (int)item.price;
                                int 小計 = (int)item.小計;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 70 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.productId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 71 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
                                   Write(item.product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 74 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n");
            WriteLiteral("                                        <p id=\"txtprice\">NT$");
#nullable restore
#line 78 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
                                                       Write(price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </td>\r\n                                    <td>\r\n");
            WriteLiteral("                                        <p id=\"txtcount\">NT$");
#nullable restore
#line 82 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
                                                       Write(小計);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 85 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n\r\n                    <div style=\" margin-bottom:20px\">\r\n                        <div style=\"float:right\">\r\n                            <p>共 ");
#nullable restore
#line 91 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
                            Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 項商品</p>\r\n                            <p id=\"labTotal\">總金額 : NT$ ");
#nullable restore
#line 92 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
                                                  Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 元</p>\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n                    <div class=\"form-horizontal\">\r\n                        <h3>確認收件人資料</h3>\r\n");
#nullable restore
#line 99 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"form-group\">\r\n                                <span class=\"control-label col-md-2\">收件人姓名</span>\r\n                                ");
#nullable restore
#line 103 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Receiver));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <span class=\"control-label col-md-2\">收件人電話</span>\r\n                                ");
#nullable restore
#line 107 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
                           Write(Html.DisplayFor(modelItem => item.phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <span class=\"control-label col-md-2\">收件人地址</span>\r\n                                ");
#nullable restore
#line 111 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <span class=\"control-label col-md-2\">付款方式</span>\r\n                                ");
#nullable restore
#line 115 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
                           Write(item.paymentname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 117 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
                            break;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ede416bed6d41c8f668ca4222f273f995ad7c3e214899", async() => {
                WriteLiteral("\r\n\r\n                        <div class=\"form-group\">\r\n                            <div class=\"form-check\">\r\n                                <input class=\"form-check-input\" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 5990, "\"", 5998, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""invalidCheck"" required>
                                <label class=""form-check-label"" for=""invalidCheck"">
                                    我已確認訂購內容及寄送資訊無誤
                                </label>
                                <div class=""invalid-feedback"">
                                    您必須在提交前同意
                                </div>
                            </div>
                        </div>


                        <input type=""hidden"" name=""MerchantID"" value=""2000132"" />

                        <input type=""hidden"" name=""MerchantTradeNo""");
                BeginWriteAttribute("value", " value=\"", 6584, "\"", 6608, 1);
#nullable restore
#line 141 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
WriteAttributeValue("", 6592, ViewBag.tradeNo, 6592, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                        <input type=\"hidden\" name=\"MerchantTradeDate\"");
                BeginWriteAttribute("value", " value=\"", 6685, "\"", 6709, 1);
#nullable restore
#line 143 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
WriteAttributeValue("", 6693, ViewBag.timenow, 6693, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                        <input type=\"hidden\" name=\"PaymentType\" value=\"aio\" />\r\n\r\n                        <input type=\"hidden\" name=\"TotalAmount\"");
                BeginWriteAttribute("value", " value=\"", 6862, "\"", 6884, 1);
#nullable restore
#line 147 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
WriteAttributeValue("", 6870, ViewBag.Total, 6870, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                        <input type=\"hidden\" name=\"TradeDesc\" value=\"建立信用卡測試訂單\" />\r\n\r\n                        <input type=\"hidden\" name=\"ItemName\"");
                BeginWriteAttribute("value", " value=\"", 7038, "\"", 7063, 1);
#nullable restore
#line 151 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
WriteAttributeValue("", 7046, ViewBag.ItemName, 7046, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />

                        <input type=""hidden"" name=""ReturnURL"" value=""https://developers.opay.tw/AioMock/MerchantReturnUrl"" />
   
                        <input type=""hidden"" name=""ChoosePayment"" value=""Credit"" />
         
                        <input type=""hidden"" name=""StoreID""");
                BeginWriteAttribute("value", " value=\"", 7358, "\"", 7366, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                     \r\n                        <input type=\"hidden\" name=\"ClientBackURL\" value=\"https://developers.opay.tw/AioMock/MerchantClientBackUrl\" />\r\n         \r\n                        <input type=\"hidden\" name=\"CreditInstallment\"");
                BeginWriteAttribute("value", " value=\"", 7610, "\"", 7618, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n  \r\n                        <input type=\"hidden\" name=\"InstallmentAmount\"");
                BeginWriteAttribute("value", " value=\"", 7697, "\"", 7705, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                        <input type=\"hidden\" name=\"Redeem\"");
                BeginWriteAttribute("value", " value=\"", 7771, "\"", 7779, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                \r\n                        <input type=\"hidden\" name=\"EncryptType\" value=\"1\" />\r\n  \r\n                        <input type=\"hidden\" name=\"CheckMacValue\"");
                BeginWriteAttribute("value", " value=\"", 7950, "\"", 7980, 1);
#nullable restore
#line 169 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
WriteAttributeValue("", 7958, ViewBag.checkMacValue, 7958, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                        <div class=\"form-group\">\r\n                            <div class=\"col-md-offset-2 col-md-10\">\r\n                                ");
#nullable restore
#line 173 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\Shopping\Car3.cshtml"
                           Write(Html.ActionLink("返回上一步", "Car2", "Shopping", null, new { @class = "btn btn-light" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                <input type=\"submit\" value=\"確認訂購\" class=\"btn btn-info\" />\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n    </div>\r\n</div>\r\n<!-- ##### Cart Area End ##### -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prjCSCoffee.Models.CShoppingCartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591