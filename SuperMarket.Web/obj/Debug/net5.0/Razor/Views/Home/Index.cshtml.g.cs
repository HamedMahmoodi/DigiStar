#pragma checksum "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aafdf73fca2d65ed0151b30209c202066cc538fd"
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
using SuperMarket.DataLayer.Entites.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
using SuperMarket.Core.DTOs.Product;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aafdf73fca2d65ed0151b30209c202066cc538fd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CartItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_viewMobileGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BoxProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "خانه";

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
                    <div id=""logo""><a href=""/""><img class=""img-responsive"" src=""/images/logo.png"" title=""DigiStar"" alt=""DigiStar"" /></a></div>
                </div>
                <!-- Logo End -->
                <!-- جستجو Start-->
                <div class=""col-table-cell col-md-5 col-md-push-0 col-sm-6 col-sm-push-6 col-xs-12"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aafdf73fca2d65ed0151b30209c202066cc538fd6203", async() => {
                    WriteLiteral(@"
                        <div id=""search"" class=""input-group"">
                            <input type=""text"" name=""filter"" id=""autFilter"" placeholder=""جستجو در دیجی استار..."" class=""form-control input-lg"" />
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
                WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 28 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"col-table-cell col-lg-3 col-md-3 col-sm-6 col-xs-12\">\r\n");
#nullable restore
#line 31 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
                          
                            List<Order> ShowOrderUser = ViewBag.OrderUserInIndex as List<Order>;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
                         foreach (var item in ShowOrderUser)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aafdf73fca2d65ed0151b30209c202066cc538fd9174", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 36 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
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
#line 37 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n");
#nullable restore
#line 39 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""col-table-cell col-lg-3 col-md-3 col-sm-6 col-xs-12"">
                        <div id=""cart"">
                            <button type=""button"" data-toggle=""dropdown"" data-loading-text=""Loading..."" class=""heading dropdown-toggle"">
                                <span class=""cart-icon pull-left flip""></span>
                                <span id=""cart-total"">سبد خرید</span>
                            </button>
                            <ul class=""dropdown-menu"">
                                <li>
                                    <p class=""alert alert-danger"">جهت مشاهده سبد خرید وارد سایت شوید</p>
                                    <p class=""checkout""><a href=""/Login"" class=""btn btn-primary""> ورود به سایت</a></p>
                                </li>
                            </ul>
                        </div>
                    </div>
");
#nullable restore
#line 56 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <!-- جستجو End-->\r\n            </div>\r\n        </div>\r\n    </header>\r\n");
            }
            );
            WriteLiteral(@"<!-- Feature Box Start-->
<div class=""container"">
    <div class=""custom-feature-box row"">
        <div class=""col-md-4 col-sm-8 col-xs-12"">
            <div class=""feature-box fbox_1"">
                <div class=""title"">ارسال رایگان</div>
                <p>برای خرید های بیش از 100 هزار تومان</p>
            </div>
        </div>
        <div class=""col-md-4 col-sm-8 col-xs-12"">
            <div class=""feature-box fbox_3"">
                <div class=""title"">کارت هدیه</div>
                <p>بهترین هدیه برای عزیزان شما</p>
            </div>
        </div>
        <div class=""col-md-4 col-sm-8 col-xs-12"">
            <div class=""feature-box fbox_4"">
                <div class=""title"">امتیازات خرید</div>
                <p>از هر خرید امتیاز کسب کرده و از آن بهره بگیرید</p>
            </div>
        </div>
    </div>
</div>
<!-- Feature Box End-->
<div class=""container"">
    <div class=""row"">
        <!-- Left Part Start-->
        <aside id=""column-left"" class=""col-sm-3 hidden-xs"">");
            WriteLiteral(@"

            <div class=""banner owl-carousel"">
                <div class=""item""> <a href=""#""><img src=""/images/banner/small-banner1-265x350.jpg"" alt=""small banner"" class=""img-responsive"" /></a> </div>
                <div class=""item""> <a href=""#""><img src=""/images/banner/small-banner-265x350.jpg"" alt=""small banner1"" class=""img-responsive"" /></a> </div>
            </div>
            <h3 class=""subtitle"">موبایل</h3>
            <div class=""side-item"">
");
#nullable restore
#line 97 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
                  
                    List<Product> MobileProduct = ViewBag.GroupMobile as List<Product>;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
                 foreach (var item in MobileProduct)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aafdf73fca2d65ed0151b30209c202066cc538fd14758", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 102 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
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
#line 103 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </aside>
        <!-- Left Part End-->
        <div id=""content"" class=""col-sm-9"">
            <!-- Slideshow Start-->
            <div class=""slideshow single-slider owl-carousel"">
                <div class=""item""> <a href=""/""><img class=""img-responsive"" src=""/images/slider/banner-1.jpg"" alt=""banner 1"" /></a> </div>
                <div class=""item""> <a href=""/""><img class=""img-responsive"" src=""/images/slider/banner-2.jpg"" alt=""banner 2"" /></a> </div>
                <div class=""item""> <a href=""/""><img class=""img-responsive"" src=""/images/slider/banner-3.jpg"" alt=""banner 3"" /></a> </div>
            </div>
            <!-- Slideshow End-->
            <h3 class=""subtitle"">جدیدترین  -<a class=""viewall"" href=""/Product"">نمایش همه</a></h3>
            <div class=""owl-carousel product_carousel"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("cache", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aafdf73fca2d65ed0151b30209c202066cc538fd17438", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 118 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
               Write(await Component.InvokeAsync("LatesProduct"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper);
#nullable restore
#line 117 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
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
            <!-- Featured محصولات End-->
            <!-- Banner Start-->
            <div class=""marketshop-banner"">
                <div class=""row"">
                    <div class=""col-lg-4 col-md-4 col-sm-6 col-xs-12""><a href=""#""><img src=""images/banner/sample-banner-1-400x200.jpg"" alt=""بنر نمونه 3"" title=""بنر نمونه 3"" /></a></div>
                    <div class=""col-lg-4 col-md-4 col-sm-6 col-xs-12""><a href=""#""><img src=""images/banner/sample-banner-4-400x200.jpg"" alt=""بنر نمونه"" title=""بنر نمونه"" /></a></div>
                    <div class=""col-lg-4 col-md-4 col-sm-6 col-xs-12""><a href=""#""><img src=""images/banner/sample-banner-3-400x200.jpg"" alt=""بنر نمونه 2"" title=""بنر نمونه 2"" /></a></div>
                </div>
            </div>
            <!-- Banner End-->
            <h3 class=""subtitle"">پرفروش - <a class=""viewall""");
            BeginWriteAttribute("href", " href=\"", 6481, "\"", 6517, 2);
            WriteAttributeValue("", 6488, "/Product/", 6488, 9, true);
#nullable restore
#line 131 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 6497, ViewBag.orderByType, 6497, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">نمایش همه</a></h3>\r\n            <div class=\"owl-carousel product_carousel\">\r\n");
#nullable restore
#line 133 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
                  
                    List<ShowProductListItemViewModel> bestSeller = ViewBag.BestsellerProduct as List<ShowProductListItemViewModel>;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
                 if (bestSeller != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
                     foreach (var item in bestSeller)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aafdf73fca2d65ed0151b30209c202066cc538fd21480", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 140 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
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
#line 141 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Home\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\"#autFilter\").autocomplete({\r\n                source: \'api/productapi/search\'\r\n            });\r\n        });\r\n    </script>\r\n\r\n");
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
