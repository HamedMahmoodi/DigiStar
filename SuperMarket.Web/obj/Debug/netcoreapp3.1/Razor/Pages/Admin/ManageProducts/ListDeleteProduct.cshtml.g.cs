#pragma checksum "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Pages\Admin\ManageProducts\ListDeleteProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51ace6b62ff172fd16d7c63f120ea825caf3b990"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_ManageProducts_ListDeleteProduct), @"mvc.1.0.razor-page", @"/Pages/Admin/ManageProducts/ListDeleteProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51ace6b62ff172fd16d7c63f120ea825caf3b990", @"/Pages/Admin/ManageProducts/ListDeleteProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_ManageProducts_ListDeleteProduct : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Pages\Admin\ManageProducts\ListDeleteProduct.cshtml"
  
    ViewData["Title"] = "ListDeleteProduct";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <h1 class=""page-header"">???????? ?????????????? ?????? ??????</h1>
    </div>
    <!-- /.col-lg-12 -->
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                ???????? ?????????????? ?????? ?????? ????????
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <div class=""row"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51ace6b62ff172fd16d7c63f120ea825caf3b9904522", async() => {
                WriteLiteral(@"
                        <div class=""col-sm-5 col-md-5"">
                            <input type=""text"" name=""filterProduct"" class=""form-control"" placeholder=""?????? ??????????"" />
                        </div>
                        <div class=""col-sm-2 col-md-2"">
                            <button type=""submit"" class=""btn btn-info"">?????? ?? ????</button>
                            <a class=""btn btn-default btn-sm"" href=""/Admin/ManageProducts""> ???????? ????</a>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-12\" style=\"margin: 10px 0;\">\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51ace6b62ff172fd16d7c63f120ea825caf3b9906403", async() => {
                WriteLiteral("???????????? ?????????? ????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                </div>
                <table class=""table table-striped table-bordered table-hover dataTable no-footer"" id=""dataTables-example"" aria-describedby=""dataTables-example_info"">
                    <thead>
                        <tr>
                            <th>??????????</th>
                            <th>?????????? ??????????</th>
                            <th>????????</th>
                            <th>??????????????</th>
                            <th>????????</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 49 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Pages\Admin\ManageProducts\ListDeleteProduct.cshtml"
                         foreach (var product in Model.ProductForAdminViewModel.Products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 2140, "\"", 2187, 2);
            WriteAttributeValue("", 2146, "/products/thumb/", 2146, 16, true);
#nullable restore
#line 53 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Pages\Admin\ManageProducts\ListDeleteProduct.cshtml"
WriteAttributeValue("", 2162, product.ProductImageName, 2162, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"thumbnail\" />\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 56 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Pages\Admin\ManageProducts\ListDeleteProduct.cshtml"
                               Write(product.ProductTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </td>
                                <td>
                                </td>
                                <td>
                                </td>
                                <td>
                                    ");
#nullable restore
#line 63 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Pages\Admin\ManageProducts\ListDeleteProduct.cshtml"
                               Write(product.ProductPrice.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ??????????\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 66 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Pages\Admin\ManageProducts\ListDeleteProduct.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
                <div class=""row"">
                    <div class=""col-sm-6"">
                        <div class=""dataTables_paginate paging_simple_numbers"" id=""dataTables-example_paginate"">
                            <ul class=""pagination"">

");
#nullable restore
#line 74 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Pages\Admin\ManageProducts\ListDeleteProduct.cshtml"
                                 for (int i = 1; i <= Model.ProductForAdminViewModel.PageCount; i++)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li");
            BeginWriteAttribute("class", " class=\"", 3240, "\"", 3326, 2);
            WriteAttributeValue("", 3248, "paginate_button", 3248, 15, true);
#nullable restore
#line 76 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Pages\Admin\ManageProducts\ListDeleteProduct.cshtml"
WriteAttributeValue(" ", 3263, (i==Model.ProductForAdminViewModel.CurrentPage)?"active":"", 3264, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTables-example\" tabindex=\"0\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3420, "\"", 3458, 2);
            WriteAttributeValue("", 3427, "/Admin/ManageProducts?PageId=", 3427, 29, true);
#nullable restore
#line 77 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Pages\Admin\ManageProducts\ListDeleteProduct.cshtml"
WriteAttributeValue("", 3456, i, 3456, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 77 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Pages\Admin\ManageProducts\ListDeleteProduct.cshtml"
                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </li>\r\n");
#nullable restore
#line 79 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Pages\Admin\ManageProducts\ListDeleteProduct.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>
    <!-- /.col-lg-12 -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SuperMarket.Web.Pages.Admin.ManageProducts.ListDeleteProductModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SuperMarket.Web.Pages.Admin.ManageProducts.ListDeleteProductModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SuperMarket.Web.Pages.Admin.ManageProducts.ListDeleteProductModel>)PageContext?.ViewData;
        public SuperMarket.Web.Pages.Admin.ManageProducts.ListDeleteProductModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
