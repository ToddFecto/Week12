#pragma checksum "C:\Dev\Week12\Assessment9_After\Assessment9_IceAndFire_After\Assessment9_IceAndFire_After\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ec457f1a7c89d1e54599a9d9000c36563140c63"
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
#line 1 "C:\Dev\Week12\Assessment9_After\Assessment9_IceAndFire_After\Assessment9_IceAndFire_After\Views\_ViewImports.cshtml"
using Assessment9_IceAndFire_After;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\Week12\Assessment9_After\Assessment9_IceAndFire_After\Assessment9_IceAndFire_After\Views\_ViewImports.cshtml"
using Assessment9_IceAndFire_After.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ec457f1a7c89d1e54599a9d9000c36563140c63", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d11e37873dc4eaa29ca9a04d94af9dbb5627bde7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Character>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Dev\Week12\Assessment9_After\Assessment9_IceAndFire_After\Assessment9_IceAndFire_After\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">#</th>\r\n            <th scope=\"col\">Name</th>\r\n            <th scope=\"col\">Gender</th>\r\n            <th scope=\"col\">Played By</th>\r\n        </tr>\r\n    </thead>\r\n\r\n");
#nullable restore
#line 16 "C:\Dev\Week12\Assessment9_After\Assessment9_IceAndFire_After\Assessment9_IceAndFire_After\Views\Home\Index.cshtml"
     foreach (var character in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\r\n            <tr>\r\n                <th scope=\"row\">1</th>\r\n                <td>");
#nullable restore
#line 22 "C:\Dev\Week12\Assessment9_After\Assessment9_IceAndFire_After\Assessment9_IceAndFire_After\Views\Home\Index.cshtml"
               Write(character.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Dev\Week12\Assessment9_After\Assessment9_IceAndFire_After\Assessment9_IceAndFire_After\Views\Home\Index.cshtml"
               Write(character.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 25 "C:\Dev\Week12\Assessment9_After\Assessment9_IceAndFire_After\Assessment9_IceAndFire_After\Views\Home\Index.cshtml"
                 foreach (var actor in character.PlayedBy)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 28 "C:\Dev\Week12\Assessment9_After\Assessment9_IceAndFire_After\Assessment9_IceAndFire_After\Views\Home\Index.cshtml"
                   Write(actor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 29 "C:\Dev\Week12\Assessment9_After\Assessment9_IceAndFire_After\Assessment9_IceAndFire_After\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tr>\r\n        </tbody>\r\n");
#nullable restore
#line 33 "C:\Dev\Week12\Assessment9_After\Assessment9_IceAndFire_After\Assessment9_IceAndFire_After\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Character>> Html { get; private set; }
    }
}
#pragma warning restore 1591
