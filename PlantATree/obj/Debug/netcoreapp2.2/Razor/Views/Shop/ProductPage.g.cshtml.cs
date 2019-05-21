#pragma checksum "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62bc78b54c0bae13af43fac0b83ec8b8e3faec18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_ProductPage), @"mvc.1.0.view", @"/Views/Shop/ProductPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/ProductPage.cshtml", typeof(AspNetCore.Views_Shop_ProductPage))]
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
#line 1 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\_ViewImports.cshtml"
using PlantATree.Models;

#line default
#line hidden
#line 2 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\_ViewImports.cshtml"
using PlantATree.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62bc78b54c0bae13af43fac0b83ec8b8e3faec18", @"/Views/Shop/ProductPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50ee8b87b29c9e352b818b0dce87db3045125344", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_ProductPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlantInfo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
  
    ViewBag.Title = "Product Page";
    string PlantImage = "~/img/trees/" + Model.Name + ".jpg";

#line default
#line hidden
            BeginContext(125, 111, true);
            WriteLiteral("\r\n    <div class=\"card col-sm-auto col-md-6 mt-3 mb-3 p-3 shadow-lg\">\r\n        <div class=\"\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 236, "\"", 253, 1);
#line 9 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
WriteAttributeValue("", 242, PlantImage, 242, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(254, 81, true);
            WriteLiteral(" class=\"img-fluid\" alt=\"Responsive image\">\r\n\r\n            <h1 class=\"card-title\">");
            EndContext();
            BeginContext(336, 10, false);
#line 11 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(346, 240, true);
            WriteLiteral("</h1>\r\n\r\n            <!--tabel for price max height and growth rate-->\r\n            <table class=\"table\">\r\n                <tbody>\r\n                    <tr>\r\n                        <th scope=\"row\">Price</th>\r\n                        <td> $");
            EndContext();
            BeginContext(587, 11, false);
#line 18 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                         Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(598, 146, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">Max Height</th>\r\n                        <td> ");
            EndContext();
            BeginContext(745, 15, false);
#line 22 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                        Write(Model.MaxHeight);

#line default
#line hidden
            EndContext();
            BeginContext(760, 149, true);
            WriteLiteral(" m</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">Growth Rate</th>\r\n                        <td> ");
            EndContext();
            BeginContext(910, 16, false);
#line 26 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                        Write(Model.GrowthRate);

#line default
#line hidden
            EndContext();
            BeginContext(926, 150, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th scope=\"row\">Plant Category</th>\r\n                        <td> ");
            EndContext();
            BeginContext(1077, 14, false);
#line 30 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                        Write(Model.Category);

#line default
#line hidden
            EndContext();
            BeginContext(1091, 155, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n\r\n\r\n            <b>Discription</b><br>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(1247, 17, false);
#line 38 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
           Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1264, 284, true);
            WriteLiteral(@"
            </p>

            <!--Using unorder list for printing condition of place to be planted-->
            <b>Conditions of Place to be planted:</b><br>
            <ul class=""list-group list-group-flush"">
                <li class=""list-group-item""><b>Sun:         </b>");
            EndContext();
            BeginContext(1549, 9, false);
#line 44 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                                                           Write(Model.Sun);

#line default
#line hidden
            EndContext();
            BeginContext(1558, 74, true);
            WriteLiteral("   </li>\r\n                <li class=\"list-group-item\"><b>Drainage:    </b>");
            EndContext();
            BeginContext(1633, 15, false);
#line 45 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                                                           Write(Model.SoilDrain);

#line default
#line hidden
            EndContext();
            BeginContext(1648, 156, true);
            WriteLiteral("  </li>\r\n            </ul>\r\n\r\n            <div class=\"card-body\">\r\n                <b>Maintenace Requirements</b>\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(1805, 14, false);
#line 51 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
               Write(Model.MaintReq);

#line default
#line hidden
            EndContext();
            BeginContext(1819, 158, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n            <!--buy or return buittons-->\r\n\r\n            <button type=\"button\" class=\"btn btn-success btn-block\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1977, "\"", 2026, 3);
            WriteAttributeValue("", 1987, "alert(\'~/img/Trees/", 1987, 19, true);
            WriteAttributeValue("", 2006, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
                                                                                                                  
                BeginContext(2009, 10, false);
#line 57 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
                                                                                             Write(Model.Name);

#line default
#line hidden
                EndContext();
                                                                                                                             
                PopWriter();
            }
            ), 2006, 14, false);
            WriteAttributeValue("", 2020, ".jpg\')", 2020, 6, true);
            EndWriteAttribute();
            BeginContext(2027, 91, true);
            WriteLiteral(">Buy</button>\r\n\r\n            <button type=\"button\" class=\"btn btn-outline-danger btn-block\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2118, "\"", 2174, 3);
            WriteAttributeValue("", 2128, "location.href=\'", 2128, 15, true);
#line 59 "C:\Users\Hamish\source\repos\PlantATree\PlantATree\Views\Shop\ProductPage.cshtml"
WriteAttributeValue("", 2143, Url.Action("Catalog", "Shop"), 2143, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 2173, "\'", 2173, 1, true);
            EndWriteAttribute();
            BeginContext(2175, 77, true);
            WriteLiteral(" style=\"text-decoration : none\">Return</button>\r\n\r\n        </div>\r\n    </div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlantInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591