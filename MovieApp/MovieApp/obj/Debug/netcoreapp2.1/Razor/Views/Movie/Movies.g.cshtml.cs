#pragma checksum "C:\Users\pepi\Desktop\MVCMovieApp-master\MovieApp\MovieApp\Views\Movie\Movies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d22d73a369f2a73f6edb285454b6b659be993839"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Movies), @"mvc.1.0.view", @"/Views/Movie/Movies.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Movies.cshtml", typeof(AspNetCore.Views_Movie_Movies))]
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
#line 1 "C:\Users\pepi\Desktop\MVCMovieApp-master\MovieApp\MovieApp\Views\_ViewImports.cshtml"
using MovieApp;

#line default
#line hidden
#line 2 "C:\Users\pepi\Desktop\MVCMovieApp-master\MovieApp\MovieApp\Views\_ViewImports.cshtml"
using MovieApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d22d73a369f2a73f6edb285454b6b659be993839", @"/Views/Movie/Movies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0301d5cca4a9345895d039cc67d16e7b77f0437f", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Movies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MovieModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\pepi\Desktop\MVCMovieApp-master\MovieApp\MovieApp\Views\Movie\Movies.cshtml"
  
    ViewData["Title"] = "Movies";

#line default
#line hidden
            BeginContext(67, 30, true);
            WriteLiteral("\r\n<h2>Movies</h2>\r\n\r\n<div>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\pepi\Desktop\MVCMovieApp-master\MovieApp\MovieApp\Views\Movie\Movies.cshtml"
     foreach (MovieModel movie in Model)
    {

#line default
#line hidden
            BeginContext(146, 48, true);
            WriteLiteral("        <ul>\r\n            <li>\r\n                ");
            EndContext();
            BeginContext(195, 10, false);
#line 14 "C:\Users\pepi\Desktop\MVCMovieApp-master\MovieApp\MovieApp\Views\Movie\Movies.cshtml"
           Write(movie.Name);

#line default
#line hidden
            EndContext();
            BeginContext(205, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(224, 49, false);
#line 15 "C:\Users\pepi\Desktop\MVCMovieApp-master\MovieApp\MovieApp\Views\Movie\Movies.cshtml"
           Write(Html.ActionLink("Details", "MovieDetails", movie));

#line default
#line hidden
            EndContext();
            BeginContext(273, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(292, 38, false);
#line 16 "C:\Users\pepi\Desktop\MVCMovieApp-master\MovieApp\MovieApp\Views\Movie\Movies.cshtml"
           Write(Html.ActionLink("Edit", "Edit", movie));

#line default
#line hidden
            EndContext();
            BeginContext(330, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(349, 47, false);
#line 17 "C:\Users\pepi\Desktop\MVCMovieApp-master\MovieApp\MovieApp\Views\Movie\Movies.cshtml"
           Write(Html.ActionLink("Delete", "DeleteMovie", movie));

#line default
#line hidden
            EndContext();
            BeginContext(396, 38, true);
            WriteLiteral("\r\n            </li>\r\n\r\n        </ul>\r\n");
            EndContext();
#line 21 "C:\Users\pepi\Desktop\MVCMovieApp-master\MovieApp\MovieApp\Views\Movie\Movies.cshtml"
    }

#line default
#line hidden
            BeginContext(441, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(446, 35, false);
#line 22 "C:\Users\pepi\Desktop\MVCMovieApp-master\MovieApp\MovieApp\Views\Movie\Movies.cshtml"
Write(Html.ActionLink("Add Movie", "Add"));

#line default
#line hidden
            EndContext();
            BeginContext(481, 18, true);
            WriteLiteral("\r\n    <br />\r\n    ");
            EndContext();
            BeginContext(500, 53, false);
#line 24 "C:\Users\pepi\Desktop\MVCMovieApp-master\MovieApp\MovieApp\Views\Movie\Movies.cshtml"
Write(Html.ActionLink("Back to home page", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(553, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MovieModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
