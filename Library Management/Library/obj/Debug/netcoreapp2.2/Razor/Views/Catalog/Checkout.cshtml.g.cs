#pragma checksum "D:\repos\Library\Library\Views\Catalog\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51f750a26e07fb077df8ec3e100ca494d03f71ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Checkout), @"mvc.1.0.view", @"/Views/Catalog/Checkout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/Checkout.cshtml", typeof(AspNetCore.Views_Catalog_Checkout))]
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
#line 1 "D:\repos\Library\Library\Views\_ViewImports.cshtml"
using Library;

#line default
#line hidden
#line 2 "D:\repos\Library\Library\Views\_ViewImports.cshtml"
using Library.Models;

#line default
#line hidden
#line 1 "D:\repos\Library\Library\Views\Catalog\Checkout.cshtml"
using Library.ViewModels.CheckoutModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51f750a26e07fb077df8ec3e100ca494d03f71ff", @"/Views/Catalog/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.ViewModels.CheckoutModels.CheckoutModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\repos\Library\Library\Views\Catalog\Checkout.cshtml"
  
    ViewBag.Title = @Model.Title;

#line default
#line hidden
            BeginContext(140, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(177, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(196, 607, true);
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.1.1.slim.min.js"" integrity=""sha384-A7FZj7v+d/sdmMqp/nOQwliLvUsJfDHW+k9Omg/a/EheAdgtzNs3hpfag6Ed950n"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js"" integrity=""sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js"" integrity=""sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn"" crossorigin=""anonymous""></script>
");
                EndContext();
            }
            );
            BeginContext(806, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(824, 224, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css\" integrity=\"sha384-rwoIResjU2yc3z8GV/NPeZWAv56rSmLldC3R/AZzGRnGxQQKnKkoFVhFQhNUwEyJ\" crossorigin=\"anonymous\">\r\n");
                EndContext();
            }
            );
            BeginContext(1051, 302, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""header clearfix detailHeading"">
        <h2 class=""text-muted"">Checkout Library Item</h2>
    </div>

    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-md-3"">
                <div>
                    <p id=""itemTitle"">");
            EndContext();
            BeginContext(1354, 11, false);
#line 28 "D:\repos\Library\Library\Views\Catalog\Checkout.cshtml"
                                 Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1365, 50, true);
            WriteLiteral("</p>\r\n                    <img class=\"detailImage\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1415, "\"", 1436, 1);
#line 29 "D:\repos\Library\Library\Views\Catalog\Checkout.cshtml"
WriteAttributeValue("", 1421, Model.ImageUrl, 1421, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1437, 49, true);
            WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n");
            EndContext();
            BeginContext(1535, 36, true);
            WriteLiteral("            <div class=\"col-md-9\">\r\n");
            EndContext();
#line 35 "D:\repos\Library\Library\Views\Catalog\Checkout.cshtml"
                 using (Html.BeginForm("PlaceCheckout", "Catalog", FormMethod.Post))
                {
                    

#line default
#line hidden
            BeginContext(1792, 30, false);
#line 37 "D:\repos\Library\Library\Views\Catalog\Checkout.cshtml"
               Write(Html.HiddenFor(a => a.AssetId));

#line default
#line hidden
            EndContext();
            BeginContext(1824, 109, true);
            WriteLiteral("                    <div>\r\n                        Please insert a Library Card ID.\r\n                        ");
            EndContext();
            BeginContext(1934, 37, false);
#line 40 "D:\repos\Library\Library\Views\Catalog\Checkout.cshtml"
                   Write(Html.TextBoxFor(a => a.LibraryCardId));

#line default
#line hidden
            EndContext();
            BeginContext(1971, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2073, 180, true);
            WriteLiteral("                    </div>\r\n                    <div>\r\n                        <button type=\"submit\" class=\"btn btn-success btn-lg\">Check out</button>\r\n                    </div>\r\n");
            EndContext();
#line 46 "D:\repos\Library\Library\Views\Catalog\Checkout.cshtml"
                }

#line default
#line hidden
            BeginContext(2272, 56, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.ViewModels.CheckoutModels.CheckoutModel> Html { get; private set; }
    }
}
#pragma warning restore 1591