#pragma checksum "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\CArticle\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e9e617632bfc6fc1b724a2bccfb2086715bfc1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CArticle_List), @"mvc.1.0.view", @"/Views/CArticle/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e9e617632bfc6fc1b724a2bccfb2086715bfc1a", @"/Views/CArticle/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e68a38f904a3c0064916e4a245f427c24105a01", @"/Views/_ViewImports.cshtml")]
    public class Views_CArticle_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prjProduct_core.Models.Article>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\CArticle\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br /><br /><br /><br /><br />\r\n\r\n\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e9e617632bfc6fc1b724a2bccfb2086715bfc1a3736", async() => {
                WriteLiteral("<h2>新增</h2>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<table class=""table"">
    <thead>
        <tr>
            <th  class=""col-12 col-md-2"">
                文章名稱
            </th>
            <th  class=""col-12 col-md-9"">
                文章內容
            </th>
            <th class=""col-12 col-md-1""></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 25 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\CArticle\List.cshtml"
           
            int count = 0;
            foreach (var item in Model)
            {
                count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <p>\r\n                        ");
#nullable restore
#line 33 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\CArticle\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ArticleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <p>\r\n                        ");
#nullable restore
#line 36 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\CArticle\List.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ArticleImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 925, "\"", 931, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"80\" height=\"40\" />\r\n                        </p>\r\n                    </td>\r\n                    <td>\r\n                         ");
#nullable restore
#line 41 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\CArticle\List.cshtml"
                    Write(Html.DisplayFor(modelItem => item.ArticleDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\CArticle\List.cshtml"
                   Write(Html.ActionLink("修改", "Edit", new { id =item.ArticleId }, new { Class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                        <br/>\r\n                        <br/>\r\n                        ");
#nullable restore
#line 47 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\CArticle\List.cshtml"
                   Write(Html.ActionLink("刪除", "Delete", new { id = item.ArticleId }, new { Class= "btn btn-danger", onclick = "return confirm('無法恢復，請確認是否刪除?')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 50 "D:\iii\期末專題\product(改版後)7.13\slnProduct_core\prjProduct_core\Views\CArticle\List.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prjProduct_core.Models.Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591
