#pragma checksum "/home/danill/Documents/projects/vidly/Views/Movies/Random.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "574038081d20f941ca70f987a1db02f786fcbfe3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Random), @"mvc.1.0.view", @"/Views/Movies/Random.cshtml")]
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
#line 1 "/home/danill/Documents/projects/vidly/Views/_ViewImports.cshtml"
using vidly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/danill/Documents/projects/vidly/Views/_ViewImports.cshtml"
using vidly.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"574038081d20f941ca70f987a1db02f786fcbfe3", @"/Views/Movies/Random.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce7ef3862f22689644e3a6f7105d0f7ef573b943", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Random : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<vidly.ViewModels.MovieRandomVIew>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/home/danill/Documents/projects/vidly/Views/Movies/Random.cshtml"
                                       
    Layout = "_Header";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>customer name ");
#nullable restore
#line 8 "/home/danill/Documents/projects/vidly/Views/Movies/Random.cshtml"
             Write(Model.customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n<h3>movie name ");
#nullable restore
#line 10 "/home/danill/Documents/projects/vidly/Views/Movies/Random.cshtml"
          Write(Model.movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n");
#nullable restore
#line 12 "/home/danill/Documents/projects/vidly/Views/Movies/Random.cshtml"
  
    if(Model.customers.Count > 0) {
        foreach (Customer customer in Model.customers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>");
#nullable restore
#line 16 "/home/danill/Documents/projects/vidly/Views/Movies/Random.cshtml"
           Write(customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n");
#nullable restore
#line 17 "/home/danill/Documents/projects/vidly/Views/Movies/Random.cshtml"
        }
    } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>Customer Kosong Cuk</h3>\n");
#nullable restore
#line 20 "/home/danill/Documents/projects/vidly/Views/Movies/Random.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<vidly.ViewModels.MovieRandomVIew> Html { get; private set; }
    }
}
#pragma warning restore 1591
