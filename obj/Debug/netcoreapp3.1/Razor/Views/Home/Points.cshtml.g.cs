#pragma checksum "C:\Users\gokans01\source\repos\comp680\Views\Home\Points.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd7c9cd9a9628922bd134b2af922b277cc462f3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Points), @"mvc.1.0.view", @"/Views/Home/Points.cshtml")]
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
#line 1 "C:\Users\gokans01\source\repos\comp680\Views\_ViewImports.cshtml"
using comp680;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gokans01\source\repos\comp680\Views\_ViewImports.cshtml"
using comp680.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd7c9cd9a9628922bd134b2af922b277cc462f3e", @"/Views/Home/Points.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4288078b56a748279335d8b08ced9232109deec1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Points : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\gokans01\source\repos\comp680\Views\Home\Points.cshtml"
  
    ViewData["Title"] = "2019-2020 NBA Season Points Leaders";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gokans01\source\repos\comp680\Views\Home\Points.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>");
#nullable restore
#line 6 "C:\Users\gokans01\source\repos\comp680\Views\Home\Points.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral(@"    <p>1. James Harden - 34.9 Points Per Game</p>
    <p>2. Bradley Beal - 30.4 Points Per Game</p>
    <p>3. Giannis Antetokounmpo - 29.9 Points Per Game</p>
    <p>4. Trae Young - 29.8 Points Per Game </p>
    <p>5. Damian Lillard - 29.5 Points Per Game</p>
");
#nullable restore
#line 13 "C:\Users\gokans01\source\repos\comp680\Views\Home\Points.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Please log in to see these statistics.</h1>\r\n");
#nullable restore
#line 17 "C:\Users\gokans01\source\repos\comp680\Views\Home\Points.cshtml"
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
