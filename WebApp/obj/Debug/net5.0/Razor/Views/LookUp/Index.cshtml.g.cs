<<<<<<< HEAD
#pragma checksum "C:\Users\lbalakrishnan\Desktop\Group 4\E-Commerce_Mobizone\WebApp\Views\LookUp\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87900c33c15580d4c9383ccd08e847a500642b3d"
=======
#pragma checksum "C:\Users\kparambath\source\GitHub\ECommmerce 06\E-Commerce_Mobizone\WebApp\Views\LookUp\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87900c33c15580d4c9383ccd08e847a500642b3d"
>>>>>>> 8017bc3558f40a7044716b348b1d09cfc2af8c89
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LookUp_Index), @"mvc.1.0.view", @"/Views/LookUp/Index.cshtml")]
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
<<<<<<< HEAD
#line 1 "C:\Users\lbalakrishnan\Desktop\Group 4\E-Commerce_Mobizone\WebApp\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\kparambath\source\GitHub\ECommmerce 06\E-Commerce_Mobizone\WebApp\Views\_ViewImports.cshtml"
>>>>>>> 8017bc3558f40a7044716b348b1d09cfc2af8c89
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\lbalakrishnan\Desktop\Group 4\E-Commerce_Mobizone\WebApp\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\kparambath\source\GitHub\ECommmerce 06\E-Commerce_Mobizone\WebApp\Views\_ViewImports.cshtml"
>>>>>>> 8017bc3558f40a7044716b348b1d09cfc2af8c89
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87900c33c15580d4c9383ccd08e847a500642b3d", @"/Views/LookUp/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_LookUp_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductCatalog.Domain.Products.LookUp>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 4 "C:\Users\lbalakrishnan\Desktop\Group 4\E-Commerce_Mobizone\WebApp\Views\LookUp\Index.cshtml"
=======
#line 4 "C:\Users\kparambath\source\GitHub\ECommmerce 06\E-Commerce_Mobizone\WebApp\Views\LookUp\Index.cshtml"
>>>>>>> 8017bc3558f40a7044716b348b1d09cfc2af8c89
  
    ViewData["Title"] = "MasterList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n\r\n            <th>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 14 "C:\Users\lbalakrishnan\Desktop\Group 4\E-Commerce_Mobizone\WebApp\Views\LookUp\Index.cshtml"
=======
#line 14 "C:\Users\kparambath\source\GitHub\ECommmerce 06\E-Commerce_Mobizone\WebApp\Views\LookUp\Index.cshtml"
>>>>>>> 8017bc3558f40a7044716b348b1d09cfc2af8c89
           Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
<<<<<<< HEAD
#line 22 "C:\Users\lbalakrishnan\Desktop\Group 4\E-Commerce_Mobizone\WebApp\Views\LookUp\Index.cshtml"
=======
#line 22 "C:\Users\kparambath\source\GitHub\ECommmerce 06\E-Commerce_Mobizone\WebApp\Views\LookUp\Index.cshtml"
>>>>>>> 8017bc3558f40a7044716b348b1d09cfc2af8c89
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 27 "C:\Users\lbalakrishnan\Desktop\Group 4\E-Commerce_Mobizone\WebApp\Views\LookUp\Index.cshtml"
=======
#line 27 "C:\Users\kparambath\source\GitHub\ECommmerce 06\E-Commerce_Mobizone\WebApp\Views\LookUp\Index.cshtml"
>>>>>>> 8017bc3558f40a7044716b348b1d09cfc2af8c89
           Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n\r\n            <td>\r\n                <button class=\"btn btn-primary mr-2\">");
            WriteLiteral("Edit</button>\r\n                <button class=\"btn btn-danger\">");
            WriteLiteral("Delete</button>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 36 "C:\Users\lbalakrishnan\Desktop\Group 4\E-Commerce_Mobizone\WebApp\Views\LookUp\Index.cshtml"
=======
#line 36 "C:\Users\kparambath\source\GitHub\ECommmerce 06\E-Commerce_Mobizone\WebApp\Views\LookUp\Index.cshtml"
>>>>>>> 8017bc3558f40a7044716b348b1d09cfc2af8c89
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductCatalog.Domain.Products.LookUp>> Html { get; private set; }
    }
}
#pragma warning restore 1591
