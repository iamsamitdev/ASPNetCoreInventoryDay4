#pragma checksum "G:\TrainingWorkshop\ASPDotnetCoreSony\ASPNetCoreInventory\Views\Backend\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3be55efe4080448e25ea24c6e68a9e98fd7b2a2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Backend_Product), @"mvc.1.0.view", @"/Views/Backend/Product.cshtml")]
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
#line 1 "G:\TrainingWorkshop\ASPDotnetCoreSony\ASPNetCoreInventory\Views\_ViewImports.cshtml"
using ASPNetCoreInventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\TrainingWorkshop\ASPDotnetCoreSony\ASPNetCoreInventory\Views\_ViewImports.cshtml"
using ASPNetCoreInventory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3be55efe4080448e25ea24c6e68a9e98fd7b2a2c", @"/Views/Backend/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"581af0b1db14ac4b6ed983111f43a9c2c7e33217", @"/Views/_ViewImports.cshtml")]
    public class Views_Backend_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\TrainingWorkshop\ASPDotnetCoreSony\ASPNetCoreInventory\Views\Backend\Product.cshtml"
  
    ViewBag.Title = "Product";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid\">\r\n    <div class=\"row mb-3\">\r\n        <div class=\"col-md-6\">\r\n            <h2>Product List</h2>\r\n        </div>\r\n        <div class=\"col-md-6 text-right\">\r\n            ");
#nullable restore
#line 12 "G:\TrainingWorkshop\ASPDotnetCoreSony\ASPNetCoreInventory\Views\Backend\Product.cshtml"
       Write(Html.ActionLink("Create New", "Create", null, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>

    <table class=""table table-bordered table-striped"">
        <tr>
            <th>ProductPicture</th>
            <th>ProductID</th>
            <th>ProductName</th>
            <th>CategoryID</th>
            <th>UnitPrice</th>
            <th>UnitInStock</th>
            <th>CreatedDate</th>
            <th>ModifiedDate</th>
        </tr>
        <tr>
            <td>NoImg</td>
            <td>1</td>
            <td>iPhone 12 Pro</td>
            <td>Mobile</td>
            <td>20000</td>
            <td>10</td>
            <td>10/10/2021</td>
            <td>10/10/2021</td>
        </tr>
    </table>
</div>");
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
