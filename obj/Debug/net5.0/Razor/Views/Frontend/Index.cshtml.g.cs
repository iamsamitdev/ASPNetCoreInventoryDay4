#pragma checksum "G:\TrainingWorkshop\ASPDotnetCoreSony\ASPNetCoreInventory\Views\Frontend\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17d3068a7fc2f7e74131db63595061f5733fd5b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Frontend_Index), @"mvc.1.0.view", @"/Views/Frontend/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17d3068a7fc2f7e74131db63595061f5733fd5b6", @"/Views/Frontend/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"581af0b1db14ac4b6ed983111f43a9c2c7e33217", @"/Views/_ViewImports.cshtml")]
    public class Views_Frontend_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\TrainingWorkshop\ASPDotnetCoreSony\ASPNetCoreInventory\Views\Frontend\Index.cshtml"
  
    ViewBag.Title = "หน้าหลัก";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!DOCTYPE html>

<div id=""carouselId"" class=""carousel slide"" data-ride=""carousel"">
    <ol class=""carousel-indicators"">
        <li data-target=""#carouselId"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#carouselId"" data-slide-to=""1""></li>
        <li data-target=""#carouselId"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"" role=""listbox"">
        <div class=""carousel-item active"">
            <img");
            BeginWriteAttribute("src", " src=", 492, "", 537, 1);
#nullable restore
#line 16 "G:\TrainingWorkshop\ASPDotnetCoreSony\ASPNetCoreInventory\Views\Frontend\Index.cshtml"
WriteAttributeValue("", 497, Url.Content("~/images/slide/food1.jpg"), 497, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"First slide\">\r\n        </div>\r\n        <div class=\"carousel-item\">\r\n            <img");
            BeginWriteAttribute("src", " src=", 627, "", 672, 1);
#nullable restore
#line 19 "G:\TrainingWorkshop\ASPDotnetCoreSony\ASPNetCoreInventory\Views\Frontend\Index.cshtml"
WriteAttributeValue("", 632, Url.Content("~/images/slide/food2.jpg"), 632, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Second slide\">\r\n        </div>\r\n        <div class=\"carousel-item\">\r\n            <img");
            BeginWriteAttribute("src", " src=", 763, "", 808, 1);
#nullable restore
#line 22 "G:\TrainingWorkshop\ASPDotnetCoreSony\ASPNetCoreInventory\Views\Frontend\Index.cshtml"
WriteAttributeValue("", 768, Url.Content("~/images/slide/food3.jpg"), 768, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Third slide"">
        </div>
    </div>
    <a class=""carousel-control-prev"" href=""#carouselId"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselId"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
    </a>
</div>

<div class=""container"">
    <h1 class=""my-4"">หน้าหลัก</h1>
    <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Eligendi, aut omnis suscipit animi laborum fuga nostrum earum molestiae sequi iusto cupiditate? Cupiditate magni debitis fugiat dolore odio ut, pariatur nesciunt minima inventore molestias minus perferendis rem esse amet illo officiis repudiandae voluptas quidem cumque aperiam iusto corrupti nisi consectetur nemo. Molestias omnis adipisci maiores accusamus eligendi numquam eaque aspernatur ex, nisi natus vero laboriosam ut repellat a impedit, amet et consequuntur reiciendis. Illum ");
            WriteLiteral("recusandae incidunt reiciendis veniam earum similique commodi, voluptatem nulla illo ut quam, voluptate, quaerat rem ratione enim? Quidem dignissimos sequi ipsa, consectetur nostrum sit obcaecati voluptatum fugiat.</p>\r\n</div>\r\n");
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