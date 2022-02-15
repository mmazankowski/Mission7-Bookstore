#pragma checksum "/Users/matthewmazankowski/Desktop/413-Mission/Mission7-Bookstore/Mission7-Bookstore/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0a00a8bd728194541b1925569b0c81dc76511eb"
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
#line 1 "/Users/matthewmazankowski/Desktop/413-Mission/Mission7-Bookstore/Mission7-Bookstore/Views/_ViewImports.cshtml"
using Mission7_Bookstore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/matthewmazankowski/Desktop/413-Mission/Mission7-Bookstore/Mission7-Bookstore/Views/_ViewImports.cshtml"
using Mission7_Bookstore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/matthewmazankowski/Desktop/413-Mission/Mission7-Bookstore/Mission7-Bookstore/Views/_ViewImports.cshtml"
using Mission7_Bookstore.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0a00a8bd728194541b1925569b0c81dc76511eb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71766d343999767a8395ba881111c47c372e2f0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BooksViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Mission7_Bookstore.Infrastructure.PaginationTagHelper __Mission7_Bookstore_Infrastructure_PaginationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/matthewmazankowski/Desktop/413-Mission/Mission7-Bookstore/Mission7-Bookstore/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Books";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Bookstore</h1>\n</div>\n\n<div class=\"text-left\">\n");
#nullable restore
#line 13 "/Users/matthewmazankowski/Desktop/413-Mission/Mission7-Bookstore/Mission7-Bookstore/Views/Home/Index.cshtml"
     foreach (Book b in Model.Books)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>");
#nullable restore
#line 15 "/Users/matthewmazankowski/Desktop/413-Mission/Mission7-Bookstore/Mission7-Bookstore/Views/Home/Index.cshtml"
       Write(b.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n");
            WriteLiteral("        <ul>\n            <li>Author: ");
#nullable restore
#line 18 "/Users/matthewmazankowski/Desktop/413-Mission/Mission7-Bookstore/Mission7-Bookstore/Views/Home/Index.cshtml"
                   Write(b.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li>Publisher: ");
#nullable restore
#line 19 "/Users/matthewmazankowski/Desktop/413-Mission/Mission7-Bookstore/Mission7-Bookstore/Views/Home/Index.cshtml"
                      Write(b.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li>ISBN: ");
#nullable restore
#line 20 "/Users/matthewmazankowski/Desktop/413-Mission/Mission7-Bookstore/Mission7-Bookstore/Views/Home/Index.cshtml"
                 Write(b.Isbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li>Classification: ");
#nullable restore
#line 21 "/Users/matthewmazankowski/Desktop/413-Mission/Mission7-Bookstore/Mission7-Bookstore/Views/Home/Index.cshtml"
                           Write(b.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li>Category: ");
#nullable restore
#line 22 "/Users/matthewmazankowski/Desktop/413-Mission/Mission7-Bookstore/Mission7-Bookstore/Views/Home/Index.cshtml"
                     Write(b.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li>Number of Pages: ");
#nullable restore
#line 23 "/Users/matthewmazankowski/Desktop/413-Mission/Mission7-Bookstore/Mission7-Bookstore/Views/Home/Index.cshtml"
                            Write(b.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n            <li>Price: ");
#nullable restore
#line 24 "/Users/matthewmazankowski/Desktop/413-Mission/Mission7-Bookstore/Mission7-Bookstore/Views/Home/Index.cshtml"
                  Write(b.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        </ul>\n");
            WriteLiteral("        <br />\n");
#nullable restore
#line 28 "/Users/matthewmazankowski/Desktop/413-Mission/Mission7-Bookstore/Mission7-Bookstore/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0a00a8bd728194541b1925569b0c81dc76511eb6864", async() => {
            }
            );
            __Mission7_Bookstore_Infrastructure_PaginationTagHelper = CreateTagHelper<global::Mission7_Bookstore.Infrastructure.PaginationTagHelper>();
            __tagHelperExecutionContext.Add(__Mission7_Bookstore_Infrastructure_PaginationTagHelper);
#nullable restore
#line 31 "/Users/matthewmazankowski/Desktop/413-Mission/Mission7-Bookstore/Mission7-Bookstore/Views/Home/Index.cshtml"
__Mission7_Bookstore_Infrastructure_PaginationTagHelper.PageBlah = Model.PageInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-blah", __Mission7_Bookstore_Infrastructure_PaginationTagHelper.PageBlah, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Mission7_Bookstore_Infrastructure_PaginationTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BooksViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
