#pragma checksum "D:\repos\Library\Library\Views\Patron\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5206cb986774449bf802ad97d147e611c6f76465"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patron_Detail), @"mvc.1.0.view", @"/Views/Patron/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patron/Detail.cshtml", typeof(AspNetCore.Views_Patron_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5206cb986774449bf802ad97d147e611c6f76465", @"/Views/Patron/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Patron_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.ViewModels.Patron.PatronDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
  
    ViewBag.Title = @Model.LastName + ", " + @Model.FirstName;

#line default
#line hidden
            BeginContext(125, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(144, 607, true);
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.1.1.slim.min.js"" integrity=""sha384-A7FZj7v+d/sdmMqp/nOQwliLvUsJfDHW+k9Omg/a/EheAdgtzNs3hpfag6Ed950n"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js"" integrity=""sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js"" integrity=""sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn"" crossorigin=""anonymous""></script>
");
                EndContext();
            }
            );
            BeginContext(754, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(772, 224, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css\" integrity=\"sha384-rwoIResjU2yc3z8GV/NPeZWAv56rSmLldC3R/AZzGRnGxQQKnKkoFVhFQhNUwEyJ\" crossorigin=\"anonymous\">\r\n");
                EndContext();
            }
            );
            BeginContext(999, 283, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""header clearfix detailHeading"">
        <h2 class=""text-muted"">Patron Information</h2>
    </div>
    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div>
                    <h2>");
            EndContext();
            BeginContext(1283, 15, false);
#line 25 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                   Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1298, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1300, 14, false);
#line 25 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                                    Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1314, 117, true);
            WriteLiteral("</h2>\r\n                    <div class=\"patronContact\">\r\n                        <div id=\"patronTel\">Library Card ID: ");
            EndContext();
            BeginContext(1432, 19, false);
#line 27 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                                                        Write(Model.LibraryCardId);

#line default
#line hidden
            EndContext();
            BeginContext(1451, 65, true);
            WriteLiteral("</div>\r\n                        <div id=\"patronAddress\">Address: ");
            EndContext();
            BeginContext(1517, 13, false);
#line 28 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                                                    Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1530, 63, true);
            WriteLiteral("</div>\r\n                        <div id=\"patronTel\">Telephone: ");
            EndContext();
            BeginContext(1594, 15, false);
#line 29 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                                                  Write(Model.Telephone);

#line default
#line hidden
            EndContext();
            BeginContext(1609, 67, true);
            WriteLiteral("</div>\r\n                        <div id=\"patronDate\">Member Since: ");
            EndContext();
            BeginContext(1677, 17, false);
#line 30 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                                                      Write(Model.MemberSince);

#line default
#line hidden
            EndContext();
            BeginContext(1694, 70, true);
            WriteLiteral("</div>\r\n                        <div id=\"patronLibrary\">Home Library: ");
            EndContext();
            BeginContext(1765, 23, false);
#line 31 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                                                         Write(Model.HomeLibraryBranch);

#line default
#line hidden
            EndContext();
            BeginContext(1788, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 32 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                         if (@Model.OverdueFees > 0)
                        {

#line default
#line hidden
            BeginContext(1877, 71, true);
            WriteLiteral("                            <div id=\"patronHasFees\">Current Fees Due: $");
            EndContext();
            BeginContext(1949, 17, false);
#line 34 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                                                                  Write(Model.OverdueFees);

#line default
#line hidden
            EndContext();
            BeginContext(1966, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 35 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2058, 81, true);
            WriteLiteral("                            <div id=\"patronNoFees\">No Fees Currently Due.</div>\r\n");
            EndContext();
#line 39 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"

                        }

#line default
#line hidden
            BeginContext(2168, 163, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <h4>Assets Currently Checked Out</h4>\r\n");
            EndContext();
#line 46 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                 if (@Model.AssetsCheckedOut.Any())
                {

#line default
#line hidden
            BeginContext(2403, 75, true);
            WriteLiteral("                    <div id=\"patronAssets\">\r\n                        <ul>\r\n");
            EndContext();
#line 50 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                             foreach (var checkout in @Model.AssetsCheckedOut)
                            {

#line default
#line hidden
            BeginContext(2589, 74, true);
            WriteLiteral("                                <li>\r\n                                    ");
            EndContext();
            BeginContext(2664, 27, false);
#line 53 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                               Write(checkout.LibraryAsset.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2691, 22, true);
            WriteLiteral(" - (Library Asset ID: ");
            EndContext();
            BeginContext(2714, 24, false);
#line 53 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                                                                                 Write(checkout.LibraryAsset.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2738, 142, true);
            WriteLiteral(")\r\n                                    <ul>\r\n                                        <li>\r\n                                            Since: ");
            EndContext();
            BeginContext(2881, 14, false);
#line 56 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                                              Write(checkout.Since);

#line default
#line hidden
            EndContext();
            BeginContext(2895, 144, true);
            WriteLiteral("\r\n                                        </li>\r\n                                        <li>\r\n                                            Due: ");
            EndContext();
            BeginContext(3040, 15, false);
#line 59 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                                            Write(checkout.Untill);

#line default
#line hidden
            EndContext();
            BeginContext(3055, 131, true);
            WriteLiteral("\r\n                                        </li>\r\n                                    </ul>\r\n                                </li>\r\n");
            EndContext();
#line 63 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                            }

#line default
#line hidden
            BeginContext(3217, 59, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
            EndContext();
#line 66 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3336, 64, true);
            WriteLiteral("                    <div>No items currently checked out.</div>\r\n");
            EndContext();
#line 70 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"

                }

#line default
#line hidden
            BeginContext(3421, 109, true);
            WriteLiteral("            </div>\r\n\r\n            <div class=\"col-md-4\">\r\n                <h4>Assets Currently On Hold</h4>\r\n");
            EndContext();
#line 76 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                 if (@Model.Holds.Any())
                {

#line default
#line hidden
            BeginContext(3591, 74, true);
            WriteLiteral("                    <div id=\"patronHolds\">\r\n                        <ul>\r\n");
            EndContext();
#line 80 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                             foreach (var hold in @Model.Holds)
                            {

#line default
#line hidden
            BeginContext(3761, 36, true);
            WriteLiteral("                                <li>");
            EndContext();
            BeginContext(3798, 23, false);
#line 82 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                               Write(hold.LibraryAsset.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3821, 10, true);
            WriteLiteral(" - Placed ");
            EndContext();
            BeginContext(3832, 44, false);
#line 82 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                                                                 Write(hold.HoldPlaced.ToString("yy-dd-MM - HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(3876, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 83 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                            }

#line default
#line hidden
            BeginContext(3914, 59, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
            EndContext();
#line 86 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(4033, 50, true);
            WriteLiteral("                    <div>No items on hold.</div>\r\n");
            EndContext();
#line 90 "D:\repos\Library\Library\Views\Patron\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(4102, 56, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.ViewModels.Patron.PatronDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
