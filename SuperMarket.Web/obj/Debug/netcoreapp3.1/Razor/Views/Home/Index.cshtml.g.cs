#pragma checksum "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a47ae6cc44dff95e053ada32704903d67f9ce37c"
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
#line 1 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
using SuperMarket.DataLayer.Entites.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
using SuperMarket.Core.DTOs.Product;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a47ae6cc44dff95e053ada32704903d67f9ce37c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BoxProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "????????";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("SearchBox", async() => {
                WriteLiteral(@"
    <header class=""header-row"">
        <div class=""container"">
            <div class=""table-container"">
                <!-- Logo Start -->
                <div class=""col-table-cell col-lg-6 col-md-6 col-sm-12 col-xs-12 inner"">
                    <div id=""logo""><a href=""index.html""><img class=""img-responsive"" src=""/images/logo.png"" title=""MarketShop"" alt=""MarketShop"" /></a></div>
");
                WriteLiteral("                </div>\r\n                <!-- Logo End -->\r\n                <!-- ?????????? Start-->\r\n                <div class=\"col-table-cell col-lg-5 col-md-5 col-md-push-0 col-sm-6 col-sm-push-6 col-xs-12\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a47ae6cc44dff95e053ada32704903d67f9ce37c5463", async() => {
                    WriteLiteral(@"
                        <div id=""search"" class=""input-group"">
                            <input type=""text"" name=""filter"" id=""autFilter"" placeholder=""?????????? ???? ???????? ??????????..."" class=""form-control input-lg"" />
                            <button class=""button-search""><i class=""fa fa-search""></i></button>
                        </div>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <!-- ?????????? End-->\r\n                <!-- Mini Cart Start-->\r\n");
                WriteLiteral("                <!-- Mini Cart End-->\r\n            </div>\r\n        </div>\r\n    </header>\r\n");
            }
            );
            WriteLiteral(@"
    <!-- Feature Box Start-->
    <div class=""container"">
        <div class=""custom-feature-box row"">
            <div class=""col-md-4 col-sm-8 col-xs-12"">
                <div class=""feature-box fbox_1"">
                    <div class=""title"">?????????? ????????????</div>
                    <p>???????? ???????? ?????? ?????? ???? 100 ???????? ??????????</p>
                </div>
            </div>
            <div class=""col-md-4 col-sm-8 col-xs-12"">
                <div class=""feature-box fbox_3"">
                    <div class=""title"">???????? ????????</div>
                    <p>???????????? ???????? ???????? ???????????? ??????</p>
                </div>
            </div>
            <div class=""col-md-4 col-sm-8 col-xs-12"">
                <div class=""feature-box fbox_4"">
                    <div class=""title"">???????????????? ????????</div>
                    <p>???? ???? ???????? ???????????? ?????? ???????? ?? ???? ???? ???????? ????????????</p>
                </div>
            </div>
        </div>
    </div>
    <!-- Feature Box End-->
    <div class=""container"">
        <div ");
            WriteLiteral(@"class=""row"">
            <!-- Left Part Start-->
            <aside id=""column-left"" class=""col-sm-3 hidden-xs"">
                <div class=""banner owl-carousel"">
                    <div class=""item""> <a href=""#""><img src=""/images/banner/small-banner1-265x350.jpg"" alt=""small banner"" class=""img-responsive"" /></a> </div>
                    <div class=""item""> <a href=""#""><img src=""/images/banner/small-banner-265x350.jpg"" alt=""small banner1"" class=""img-responsive"" /></a> </div>
                </div>

            </aside>
            <!-- Left Part End-->
            <div id=""content"" class=""col-sm-9"">
                <!-- Slideshow Start-->
                <div class=""slideshow single-slider owl-carousel"">
                    <div class=""item""> <a href=""#""><img class=""img-responsive"" src=""/images/slider/banner-1.jpg"" alt=""banner 1"" /></a> </div>
                    <div class=""item""> <a href=""#""><img class=""img-responsive"" src=""/images/slider/banner-2.jpg"" alt=""banner 2"" /></a> </div>
          ");
            WriteLiteral(@"          <div class=""item""> <a href=""#""><img class=""img-responsive"" src=""/images/slider/banner-3.jpg"" alt=""banner 3"" /></a> </div>
                </div>
                <!-- Slideshow End-->
                <h3 class=""subtitle"">????????????????  -<a class=""viewall"" href=""category.tpl"">?????????? ??????</a></h3>
                <div class=""owl-carousel product_carousel"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("cache", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a47ae6cc44dff95e053ada32704903d67f9ce37c10323", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 86 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
                       Write(await Component.InvokeAsync("LatesProduct"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper);
#nullable restore
#line 85 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper.ExpiresAfter = TimeSpan.FromMinutes(1);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("expires-after", __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper.ExpiresAfter, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <!-- Featured ?????????????? End-->
                <!-- Banner Start-->
                <div class=""marketshop-banner"">
                    <div class=""row"">
                        <div class=""col-lg-4 col-md-4 col-sm-6 col-xs-12""><a href=""#""><img src=""image/banner/sample-banner-3-400x200.jpg"" alt=""?????? ?????????? 3"" title=""?????? ?????????? 3"" /></a></div>
                        <div class=""col-lg-4 col-md-4 col-sm-6 col-xs-12""><a href=""#""><img src=""image/banner/sample-banner-1-400x200.jpg"" alt=""?????? ??????????"" title=""?????? ??????????"" /></a></div>
                        <div class=""col-lg-4 col-md-4 col-sm-6 col-xs-12""><a href=""#""><img src=""image/banner/sample-banner-2-400x200.jpg"" alt=""?????? ?????????? 2"" title=""?????? ?????????? 2"" /></a></div>
                    </div>
                </div>
                <!-- Banner End-->
                <h3 class=""subtitle"">???????????? - <a class=""viewall"" href=""category.tpl"">?????????? ??????</a></h3>
                <div class=""owl-carousel product_carousel"">
");
#nullable restore
#line 101 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
                      
                        List<ShowProductListItemViewModel> bestSeller = ViewBag.BestsellerProduct as List<ShowProductListItemViewModel>;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
                     if (bestSeller != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
                         foreach (var item in bestSeller)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a47ae6cc44dff95e053ada32704903d67f9ce37c14048", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 108 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 109 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\"#autFilter\").autocomplete({\r\n                source: \'api/productapi/search\'\r\n            });\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
