#pragma checksum "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Shared\MenuPanel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc3f31261ea6171192f3989e557ba05bb80914da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MenuPanel), @"mvc.1.0.view", @"/Views/Shared/MenuPanel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc3f31261ea6171192f3989e557ba05bb80914da", @"/Views/Shared/MenuPanel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MenuPanel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<nav id=\"top\" class=\"htop\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div id=\"top-links\" class=\"nav pull-left flip\">\r\n");
#nullable restore
#line 5 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Shared\MenuPanel.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"currency\" class=\"btn-group\">\r\n                        <button class=\"btn-link dropdown-toggle\" data-toggle=\"dropdown\"><span>");
#nullable restore
#line 8 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Shared\MenuPanel.cshtml"
                                                                                         Write(User.Claims.SingleOrDefault(u=>u.Type=="UserName").Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<i class=""fa fa-caret-down""></i></span></button>
                        <ul class=""dropdown-menu"">
                            <li>
                                <a class=""currency-select btn btn-link btn-block"" href=""/UserPanel"">مشاهده حساب کاربری</a>
                            </li>
                            <li>
                                <a class=""currency-select btn btn-link btn-block"" href=""/UserPanel/EditProfile"">ویرایش حساب کاربری</a>
                            </li>
                            <li>
                                <a class=""currency-select btn btn-link btn-block"" href=""/UserPanel/ChangePassword"">تغییر رمز عبور</a>
                            </li>
                            <li>
                                <a class=""currency-select btn btn-link btn-block"" href=""/UserPanel/Wallet"">کیف پول من</a>
                            </li>
                            <li>
                                <a class=""currency-select btn btn-link btn-block"" href=""/UserP");
            WriteLiteral(@"anel/MyOrders"">سفارش های من</a>
                            </li>
                            <li>
                                <a class=""currency-select btn btn-link btn-block"" href=""/LogOut"">خروج از حساب کاربری</a>
                            </li>
                        </ul>
                    </div>
");
#nullable restore
#line 30 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Shared\MenuPanel.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <ul>\r\n                        <li><a href=\"/Register\">عضویت</a></li>\r\n                        <li><a href=\"/Login\">ورود</a></li>\r\n                    </ul>\r\n");
#nullable restore
#line 37 "D:\Projehaye Asp.net Core\SuperMarket\SuperMarket.Web\Views\Shared\MenuPanel.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</nav>");
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
