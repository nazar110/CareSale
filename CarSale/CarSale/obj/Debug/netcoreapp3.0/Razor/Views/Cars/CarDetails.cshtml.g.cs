#pragma checksum "D:\Documents\Repositories\Web\CareSale\CarSale\CarSale\Views\Cars\CarDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "031cddf23eebbab040fca31583224adc5bbe2b16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_CarDetails), @"mvc.1.0.view", @"/Views/Cars/CarDetails.cshtml")]
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
#line 1 "D:\Documents\Repositories\Web\CareSale\CarSale\CarSale\Views\_ViewImports.cshtml"
using CarSale;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Documents\Repositories\Web\CareSale\CarSale\CarSale\Views\Cars\CarDetails.cshtml"
using CarSale.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"031cddf23eebbab040fca31583224adc5bbe2b16", @"/Views/Cars/CarDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f1e46456aaeb5315719e3eaa05266cb93ce5e4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_CarDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Documents\Repositories\Web\CareSale\CarSale\CarSale\Views\Cars\CarDetails.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "031cddf23eebbab040fca31583224adc5bbe2b163327", async() => {
                WriteLiteral("\r\n\r\n    <h1>Details for ");
#nullable restore
#line 10 "D:\Documents\Repositories\Web\CareSale\CarSale\CarSale\Views\Cars\CarDetails.cshtml"
                Write($"{Model.Brandname} {Model.Modelname}");

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n    <h3>");
#nullable restore
#line 11 "D:\Documents\Repositories\Web\CareSale\CarSale\CarSale\Views\Cars\CarDetails.cshtml"
    Write($"{Model.Brandname} {Model.Modelname}");

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n    <img");
                BeginWriteAttribute("src", " src=", 235, "", 255, 1);
#nullable restore
#line 12 "D:\Documents\Repositories\Web\CareSale\CarSale\CarSale\Views\Cars\CarDetails.cshtml"
WriteAttributeValue("", 240, Model.ImageUrl, 240, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcScqGXN9u_ymkHnqEptsXPte1luADbMzMvdq2Gg8hCV5rT9Ppffmw&s\" width=\"500\">\r\n    <p>Color: ");
#nullable restore
#line 13 "D:\Documents\Repositories\Web\CareSale\CarSale\CarSale\Views\Cars\CarDetails.cshtml"
         Write(Model.Color);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>Features: ");
#nullable restore
#line 14 "D:\Documents\Repositories\Web\CareSale\CarSale\CarSale\Views\Cars\CarDetails.cshtml"
            Write(Model.Features);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>Country Of Origin: ");
#nullable restore
#line 15 "D:\Documents\Repositories\Web\CareSale\CarSale\CarSale\Views\Cars\CarDetails.cshtml"
                     Write(Model.CountryOfOrigin);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>Price: ");
#nullable restore
#line 16 "D:\Documents\Repositories\Web\CareSale\CarSale\CarSale\Views\Cars\CarDetails.cshtml"
         Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" $</p>\r\n    <p>Description: ");
#nullable restore
#line 17 "D:\Documents\Repositories\Web\CareSale\CarSale\CarSale\Views\Cars\CarDetails.cshtml"
               Write(Model.LongDescription);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p><a class=\"btn btn-warning\" href=\"https://localhost:44381/Cars/PurchaseForm\">Buy</a></p>\r\n");
#nullable restore
#line 19 "D:\Documents\Repositories\Web\CareSale\CarSale\CarSale\Views\Cars\CarDetails.cshtml"
      
        /*
            <form method="LINK" action="http://codehelper.ru">
            <input type="submit" value="Go to CodeHelper!">
            </form>
         */
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    \r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
