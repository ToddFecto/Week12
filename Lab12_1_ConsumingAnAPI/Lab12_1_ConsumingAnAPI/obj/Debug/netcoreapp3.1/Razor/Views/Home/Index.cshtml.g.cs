#pragma checksum "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57540bd93493a3b534d24759d064a0a7a48426ae"
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
#line 1 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\_ViewImports.cshtml"
using Lab12_1_ConsumingAnAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\_ViewImports.cshtml"
using Lab12_1_ConsumingAnAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57540bd93493a3b534d24759d064a0a7a48426ae", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f4b68544662562d40bd6c68fc6b7800a6169143", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CardDeck>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    string hand = Poker.GetHand(Model.cards);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h2 class=\"display-4\">Deck Of Cards Game</h2>\r\n</div>\r\n\r\n<div>\r\n    Deck ID: ");
#nullable restore
#line 12 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
        Write(Model.deck_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    Cards Remaining: ");
#nullable restore
#line 13 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
                Write(Model.remaining);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<a href=\"/home/AddingToPiles\" class=\"btn btn-primary\">Adding To Piles</a>\r\n<br />\r\n\r\n<a href=\"/home/APartialDeck\" class=\"btn btn-primary\">Draw 1 - 12 Card Deck</a>\r\n<br />\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 467, "\"", 508, 2);
            WriteAttributeValue("", 474, "/home/index?deck_id=", 474, 20, true);
#nullable restore
#line 22 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
WriteAttributeValue("", 494, Model.deck_id, 494, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Draw 7</a>\r\n<br />\r\n\r\n");
#nullable restore
#line 25 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
 if (Model.remaining >= 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 593, "\"", 639, 2);
            WriteAttributeValue("", 600, "/home/Reshuffle/?deck_id=", 600, 25, true);
#nullable restore
#line 27 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
WriteAttributeValue("", 625, Model.deck_id, 625, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Reshuffle Deck</a>\r\n");
#nullable restore
#line 28 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n");
#nullable restore
#line 31 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
 if (Model.remaining >= 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 735, "\"", 779, 2);
            WriteAttributeValue("", 742, "/home/NewDeck/?deck_id=", 742, 23, true);
#nullable restore
#line 33 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
WriteAttributeValue("", 765, Model.deck_id, 765, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Brand New Deck</a>\r\n");
#nullable restore
#line 34 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n");
#nullable restore
#line 37 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
 if (Model.remaining >= 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 875, "\"", 929, 2);
            WriteAttributeValue("", 882, "/home/NewDeckWithJokers/?deck_id=", 882, 33, true);
#nullable restore
#line 39 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
WriteAttributeValue("", 915, Model.deck_id, 915, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">New Deck With Jokers</a>\r\n");
#nullable restore
#line 40 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n");
#nullable restore
#line 43 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
 if (Model.remaining == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"/\" class=\"btn btn-primary\">Start Over</a>\r\n");
#nullable restore
#line 46 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n\r\n");
#nullable restore
#line 50 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
 if (hand != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>Congratulations! You drew a ");
#nullable restore
#line 52 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
                                Write(hand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 53 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
 foreach (Draw card in Model.cards)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <img");
            BeginWriteAttribute("src", " src=\"", 1222, "\"", 1239, 1);
#nullable restore
#line 57 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
WriteAttributeValue("", 1228, card.image, 1228, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 58 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CardDeck> Html { get; private set; }
    }
}
#pragma warning restore 1591
