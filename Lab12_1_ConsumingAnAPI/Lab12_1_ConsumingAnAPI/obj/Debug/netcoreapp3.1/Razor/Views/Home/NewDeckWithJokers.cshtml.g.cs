#pragma checksum "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\NewDeckWithJokers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07c486f50ba44af1d450c4c82a7458823763750c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NewDeckWithJokers), @"mvc.1.0.view", @"/Views/Home/NewDeckWithJokers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07c486f50ba44af1d450c4c82a7458823763750c", @"/Views/Home/NewDeckWithJokers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f4b68544662562d40bd6c68fc6b7800a6169143", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NewDeckWithJokers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CardDeck>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\NewDeckWithJokers.cshtml"
  
    ViewData["Title"] = "NewDeck";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">New Deck With Jokers</h1>\r\n</div>\r\n\r\n");
#nullable restore
#line 11 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\NewDeckWithJokers.cshtml"
  
    ViewData["Title"] = "Home Page";
    string hand = Poker.GetHand(Model.cards);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    Deck ID: ");
#nullable restore
#line 17 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\NewDeckWithJokers.cshtml"
        Write(Model.deck_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    Cards Remaining: ");
#nullable restore
#line 18 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\NewDeckWithJokers.cshtml"
                Write(Model.remaining);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 341, "\"", 382, 2);
            WriteAttributeValue("", 348, "/home/index?deck_id=", 348, 20, true);
#nullable restore
#line 21 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\NewDeckWithJokers.cshtml"
WriteAttributeValue("", 368, Model.deck_id, 368, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Draw 7</a>\r\n<br />\r\n\r\n");
#nullable restore
#line 24 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\NewDeckWithJokers.cshtml"
 if (Model.remaining >= 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 467, "\"", 519, 2);
            WriteAttributeValue("", 474, "/home/index/Reshuffle/?deck_id=", 474, 31, true);
#nullable restore
#line 26 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\NewDeckWithJokers.cshtml"
WriteAttributeValue("", 505, Model.deck_id, 505, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Reshuffle Deck</a>\r\n");
#nullable restore
#line 27 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\NewDeckWithJokers.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n");
#nullable restore
#line 30 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\NewDeckWithJokers.cshtml"
 if (Model.remaining == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"/\" class=\"btn btn-primary\">Start Over</a>\r\n");
#nullable restore
#line 33 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\NewDeckWithJokers.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n\r\n");
#nullable restore
#line 37 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\NewDeckWithJokers.cshtml"
 if (hand != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>Congratulations! You grabbed a Brand New Deck with Jokers included and drew a ");
#nullable restore
#line 39 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\NewDeckWithJokers.cshtml"
                                                                                  Write(hand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 40 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\NewDeckWithJokers.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\NewDeckWithJokers.cshtml"
 foreach (Draw card in Model.cards)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <img");
            BeginWriteAttribute("src", " src=\"", 856, "\"", 873, 1);
#nullable restore
#line 44 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\NewDeckWithJokers.cshtml"
WriteAttributeValue("", 862, card.image, 862, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 45 "C:\Dev\Week12\Lab12_1_ConsumingAnAPI\Lab12_1_ConsumingAnAPI\Views\Home\NewDeckWithJokers.cshtml"
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
