#pragma checksum "C:\Users\Robert Leatherman\Desktop\HSN Internship\CouchbaseDI\CouchbaseDI\Views\Home\Airline.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3643ff039265dbaf14b19eee60e3545a1ec5e671"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Airline), @"mvc.1.0.view", @"/Views/Home/Airline.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Airline.cshtml", typeof(AspNetCore.Views_Home_Airline))]
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
#line 1 "C:\Users\Robert Leatherman\Desktop\HSN Internship\CouchbaseDI\CouchbaseDI\Views\_ViewImports.cshtml"
using CouchbaseDI;

#line default
#line hidden
#line 2 "C:\Users\Robert Leatherman\Desktop\HSN Internship\CouchbaseDI\CouchbaseDI\Views\_ViewImports.cshtml"
using CouchbaseDI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3643ff039265dbaf14b19eee60e3545a1ec5e671", @"/Views/Home/Airline.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5119073b05bcf9d044c36837cf11c6d62dc995ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Airline : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Airline>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Robert Leatherman\Desktop\HSN Internship\CouchbaseDI\CouchbaseDI\Views\Home\Airline.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(68, 162, true);
            WriteLiteral("<h2>Airlines</h2>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Callsign</th>\r\n        <th>Country</th>\r\n        <th>Name</th>\r\n    </tr>\r\n");
            EndContext();
#line 14 "C:\Users\Robert Leatherman\Desktop\HSN Internship\CouchbaseDI\CouchbaseDI\Views\Home\Airline.cshtml"
     foreach (var airline in Model)
    {

#line default
#line hidden
            BeginContext(274, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(305, 10, false);
#line 17 "C:\Users\Robert Leatherman\Desktop\HSN Internship\CouchbaseDI\CouchbaseDI\Views\Home\Airline.cshtml"
           Write(airline.Id);

#line default
#line hidden
            EndContext();
            BeginContext(315, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(339, 16, false);
#line 18 "C:\Users\Robert Leatherman\Desktop\HSN Internship\CouchbaseDI\CouchbaseDI\Views\Home\Airline.cshtml"
           Write(airline.Callsign);

#line default
#line hidden
            EndContext();
            BeginContext(355, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(379, 15, false);
#line 19 "C:\Users\Robert Leatherman\Desktop\HSN Internship\CouchbaseDI\CouchbaseDI\Views\Home\Airline.cshtml"
           Write(airline.Country);

#line default
#line hidden
            EndContext();
            BeginContext(394, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(418, 12, false);
#line 20 "C:\Users\Robert Leatherman\Desktop\HSN Internship\CouchbaseDI\CouchbaseDI\Views\Home\Airline.cshtml"
           Write(airline.Name);

#line default
#line hidden
            EndContext();
            BeginContext(430, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 22 "C:\Users\Robert Leatherman\Desktop\HSN Internship\CouchbaseDI\CouchbaseDI\Views\Home\Airline.cshtml"
    }

#line default
#line hidden
            BeginContext(459, 10, true);
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Airline>> Html { get; private set; }
    }
}
#pragma warning restore 1591