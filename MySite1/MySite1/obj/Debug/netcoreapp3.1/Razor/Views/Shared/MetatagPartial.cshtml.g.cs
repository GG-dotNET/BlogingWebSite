#pragma checksum "C:\Users\ol140\source\repos\MySite1\MySite1\Views\Shared\MetatagPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e2663cdf95dc51b220801d32967413ee56ac44e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MetatagPartial), @"mvc.1.0.view", @"/Views/Shared/MetatagPartial.cshtml")]
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
#line 2 "C:\Users\ol140\source\repos\MySite1\MySite1\Views\_ViewImports.cshtml"
using MySite1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ol140\source\repos\MySite1\MySite1\Views\_ViewImports.cshtml"
using MySite1.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ol140\source\repos\MySite1\MySite1\Views\_ViewImports.cshtml"
using MySite1.Models.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ol140\source\repos\MySite1\MySite1\Views\Shared\MetatagPartial.cshtml"
using MySite1.Service;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e2663cdf95dc51b220801d32967413ee56ac44e", @"/Views/Shared/MetatagPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32687cc39ca45d891eef10527cc9467d6f7418e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MetatagPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<meta charset=\"utf-8\" />\r\n<meta name=\"viewport\" content=\"width=device-width, initial-scale=1, user-scalable=no\" />\r\n");
#nullable restore
#line 4 "C:\Users\ol140\source\repos\MySite1\MySite1\Views\Shared\MetatagPartial.cshtml"
 if (ViewBag.Title != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 6 "C:\Users\ol140\source\repos\MySite1\MySite1\Views\Shared\MetatagPartial.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 7 "C:\Users\ol140\source\repos\MySite1\MySite1\Views\Shared\MetatagPartial.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <title>");
#nullable restore
#line 10 "C:\Users\ol140\source\repos\MySite1\MySite1\Views\Shared\MetatagPartial.cshtml"
      Write(Config.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
#nullable restore
#line 11 "C:\Users\ol140\source\repos\MySite1\MySite1\Views\Shared\MetatagPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ol140\source\repos\MySite1\MySite1\Views\Shared\MetatagPartial.cshtml"
 if (ViewBag.Description != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"description\"");
            BeginWriteAttribute("content", " content=\"", 328, "\"", 358, 1);
#nullable restore
#line 14 "C:\Users\ol140\source\repos\MySite1\MySite1\Views\Shared\MetatagPartial.cshtml"
WriteAttributeValue("", 338, ViewBag.Description, 338, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n");
#nullable restore
#line 15 "C:\Users\ol140\source\repos\MySite1\MySite1\Views\Shared\MetatagPartial.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ol140\source\repos\MySite1\MySite1\Views\Shared\MetatagPartial.cshtml"
 if (ViewBag.Keywords != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <meta name=\"keywords\"");
            BeginWriteAttribute("content", " content=\"", 426, "\"", 453, 1);
#nullable restore
#line 18 "C:\Users\ol140\source\repos\MySite1\MySite1\Views\Shared\MetatagPartial.cshtml"
WriteAttributeValue("", 436, ViewBag.Keywords, 436, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n");
#nullable restore
#line 19 "C:\Users\ol140\source\repos\MySite1\MySite1\Views\Shared\MetatagPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
