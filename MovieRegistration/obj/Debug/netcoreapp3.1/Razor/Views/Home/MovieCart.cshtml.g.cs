#pragma checksum "C:\Users\desha\source\repos\MovieRegistrationUpdated\MovieRegistration\Views\Home\MovieCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a81d92d444b2bef0c905c913cc91196bf6214ec7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MovieCart), @"mvc.1.0.view", @"/Views/Home/MovieCart.cshtml")]
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
#line 1 "C:\Users\desha\source\repos\MovieRegistrationUpdated\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\desha\source\repos\MovieRegistrationUpdated\MovieRegistration\Views\_ViewImports.cshtml"
using MovieRegistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a81d92d444b2bef0c905c913cc91196bf6214ec7", @"/Views/Home/MovieCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6edb0700316839935d5586746ff80ad9306f8388", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MovieCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>Movie Cart</h1>\r\n\r\n<table class=\"table-primary\">\r\n    <tr>\r\n        <th>Movie Title</th>\r\n        <th>Genre</th>\r\n        <th>Year</th>\r\n        <th>Director(s)</th>\r\n        <th>Actor(s)</th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "C:\Users\desha\source\repos\MovieRegistrationUpdated\MovieRegistration\Views\Home\MovieCart.cshtml"
     foreach (var selectedMovie in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 17 "C:\Users\desha\source\repos\MovieRegistrationUpdated\MovieRegistration\Views\Home\MovieCart.cshtml"
   Write(selectedMovie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 18 "C:\Users\desha\source\repos\MovieRegistrationUpdated\MovieRegistration\Views\Home\MovieCart.cshtml"
   Write(selectedMovie.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 19 "C:\Users\desha\source\repos\MovieRegistrationUpdated\MovieRegistration\Views\Home\MovieCart.cshtml"
   Write(selectedMovie.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 20 "C:\Users\desha\source\repos\MovieRegistrationUpdated\MovieRegistration\Views\Home\MovieCart.cshtml"
   Write(selectedMovie.Directors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 21 "C:\Users\desha\source\repos\MovieRegistrationUpdated\MovieRegistration\Views\Home\MovieCart.cshtml"
   Write(selectedMovie.Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
            WriteLiteral("\r\n</tr>\r\n");
#nullable restore
#line 29 "C:\Users\desha\source\repos\MovieRegistrationUpdated\MovieRegistration\Views\Home\MovieCart.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591