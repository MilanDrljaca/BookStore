#pragma checksum "C:\Users\milan drljaca\source\repos\BookStore\WebGentle.BookStore\WebGentle.BookStore\Views\Book\GetAllBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a32fc93adf530de196f6fc7947a5ebab194681b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_GetAllBooks), @"mvc.1.0.view", @"/Views/Book/GetAllBooks.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a32fc93adf530de196f6fc7947a5ebab194681b", @"/Views/Book/GetAllBooks.cshtml")]
    public class Views_Book_GetAllBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebGentle.BookStore.Models.BookModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\milan drljaca\source\repos\BookStore\WebGentle.BookStore\WebGentle.BookStore\Views\Book\GetAllBooks.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n \r\n\r\n<div class=\"container\">\r\n    <h1 class=\"display-4\">All books</h1>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 11 "C:\Users\milan drljaca\source\repos\BookStore\WebGentle.BookStore\WebGentle.BookStore\Views\Book\GetAllBooks.cshtml"
         foreach (var book in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-4"">
            <div class=""card mb-4 shadow-sm"">
                <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/200/svg"">
                    <div class=""card-body"">
                        <h3 class=""card-title"">");
#nullable restore
#line 17 "C:\Users\milan drljaca\source\repos\BookStore\WebGentle.BookStore\WebGentle.BookStore\Views\Book\GetAllBooks.cshtml"
                                          Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <p class=""card-text"">This section will be used to display the short description of book</p>
                        <div class=""d-flex justify-content-between align-items-center"">
                            <div class=""btn-group"">
                                <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View details</a>
                            </div>
                            <small class=""text-muted"">");
#nullable restore
#line 23 "C:\Users\milan drljaca\source\repos\BookStore\WebGentle.BookStore\WebGentle.BookStore\Views\Book\GetAllBooks.cshtml"
                                                 Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </div>\r\n                    </div>\r\n                </svg>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 29 "C:\Users\milan drljaca\source\repos\BookStore\WebGentle.BookStore\WebGentle.BookStore\Views\Book\GetAllBooks.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebGentle.BookStore.Models.BookModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
