#pragma checksum "D:\repos\Library\Library\Views\Catalog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0cc63d1c458ad788cdb1d3557b4bfe990462a8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Detail), @"mvc.1.0.view", @"/Views/Catalog/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/Detail.cshtml", typeof(AspNetCore.Views_Catalog_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0cc63d1c458ad788cdb1d3557b4bfe990462a8e", @"/Views/Catalog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.ViewModels.Catalog.AssetDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarkFound", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CheckIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Hold", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Scripts", async() => {
                BeginContext(69, 607, true);
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.1.1.slim.min.js"" integrity=""sha384-A7FZj7v+d/sdmMqp/nOQwliLvUsJfDHW+k9Omg/a/EheAdgtzNs3hpfag6Ed950n"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js"" integrity=""sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb"" crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js"" integrity=""sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn"" crossorigin=""anonymous""></script>
");
                EndContext();
            }
            );
            BeginContext(679, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(697, 224, true);
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css\" integrity=\"sha384-rwoIResjU2yc3z8GV/NPeZWAv56rSmLldC3R/AZzGRnGxQQKnKkoFVhFQhNUwEyJ\" crossorigin=\"anonymous\">\r\n");
                EndContext();
            }
            );
            BeginContext(924, 297, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""header clearfix detailHeading"">
        <h2 class=""text-muted"">View Library Item</h2>
    </div>
</div>

<div class=""jumbotron p-lg-5"">
    <div class=""row"">
        <div class=""col-md-4"">
            <div>
                <img class=""detailImage""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1221, "\"", 1242, 1);
#line 21 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
WriteAttributeValue("", 1227, Model.ImageUrl, 1227, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1243, 103, true);
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <p id=\"itemTitle\">");
            EndContext();
            BeginContext(1347, 11, false);
#line 25 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                         Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1358, 37, true);
            WriteLiteral("</p>\r\n            <p id=\"itemAuthor\">");
            EndContext();
            BeginContext(1396, 22, false);
#line 26 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                          Write(Model.AuthorOrDirector);

#line default
#line hidden
            EndContext();
            BeginContext(1418, 37, true);
            WriteLiteral("</p>\r\n            <p id=\"itemStatus\">");
            EndContext();
            BeginContext(1456, 12, false);
#line 27 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                          Write(Model.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1468, 35, true);
            WriteLiteral("</p>\r\n            <p id=\"itemType\">");
            EndContext();
            BeginContext(1504, 10, false);
#line 28 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                        Write(Model.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1514, 54, true);
            WriteLiteral("</p>\r\n            <p id=\"itemLocation\">Last Location: ");
            EndContext();
            BeginContext(1569, 21, false);
#line 29 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                                           Write(Model.CurrentLocation);

#line default
#line hidden
            EndContext();
            BeginContext(1590, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
#line 31 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
             if (@Model.Status == "Lost")
            {

#line default
#line hidden
            BeginContext(1656, 88, true);
            WriteLiteral("                <p>This item is lost. It cannot be checked out.</p>\r\n                <p>");
            EndContext();
            BeginContext(1744, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0cc63d1c458ad788cdb1d3557b4bfe990462a8e10376", async() => {
                BeginContext(1867, 15, true);
                WriteLiteral("Mark Item Found");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                                                                                                                  WriteLiteral(Model.AssetId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1886, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 35 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
            }

#line default
#line hidden
            BeginContext(1907, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 37 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
             if (Model.Status == "Checked Out")
            {

#line default
#line hidden
            BeginContext(1973, 51, true);
            WriteLiteral("                <p id=\"itemPatron\">Checked Out By: ");
            EndContext();
            BeginContext(2025, 16, false);
#line 39 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                                              Write(Model.PatronName);

#line default
#line hidden
            EndContext();
            BeginContext(2041, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(2066, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0cc63d1c458ad788cdb1d3557b4bfe990462a8e14042", async() => {
                BeginContext(2190, 8, true);
                WriteLiteral("Check In");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                                                                                                                   WriteLiteral(Model.AssetId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2202, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(2227, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0cc63d1c458ad788cdb1d3557b4bfe990462a8e16825", async() => {
                BeginContext(2348, 10, true);
                WriteLiteral("Place Hold");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                                                                                                                WriteLiteral(Model.AssetId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2362, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 42 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
            }

#line default
#line hidden
            BeginContext(2383, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 43 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
             if (@Model.Status == "Available")
            {

#line default
#line hidden
            BeginContext(2446, 19, true);
            WriteLiteral("                <p>");
            EndContext();
            BeginContext(2465, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0cc63d1c458ad788cdb1d3557b4bfe990462a8e20091", async() => {
                BeginContext(2587, 9, true);
                WriteLiteral("Check Out");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                                                                                                                 WriteLiteral(Model.AssetId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2600, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 46 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
            }

#line default
#line hidden
            BeginContext(2621, 199, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-md-4 detailinfo\">\r\n            <table>\r\n                <tr>\r\n                    <td class=\"itemLabel\">ISBN: </td>\r\n                    <td class=\"itemValue\">");
            EndContext();
            BeginContext(2821, 10, false);
#line 52 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                                     Write(Model.ISBN);

#line default
#line hidden
            EndContext();
            BeginContext(2831, 156, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"itemLabel\">Call Number: </td>\r\n                    <td class=\"itemValue\">");
            EndContext();
            BeginContext(2988, 11, false);
#line 56 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                                     Write(Model.Dewey);

#line default
#line hidden
            EndContext();
            BeginContext(2999, 162, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td class=\"itemLabel\">Replacement Cost: </td>\r\n                    <td class=\"itemValue\">$");
            EndContext();
            BeginContext(3162, 10, false);
#line 60 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                                      Write(Model.Cost);

#line default
#line hidden
            EndContext();
            BeginContext(3172, 477, true);
            WriteLiteral(@"</td>
                </tr>
            </table>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-6"">
        <h4>Checkout History</h4>
        <table class=""table table-bordered table-hover table-condensed"">
            <thead>
                <tr>
                    <th>Date Loaned</th>
                    <th>Date Returned</th>
                    <th>Card Id</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 78 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                 foreach (var checkout in @Model.CheckoutHistory)
                {

#line default
#line hidden
            BeginContext(3735, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3820, 19, false);
#line 82 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                       Write(checkout.CheckedOut);

#line default
#line hidden
            EndContext();
            BeginContext(3839, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3931, 18, false);
#line 85 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                       Write(checkout.CheckedIn);

#line default
#line hidden
            EndContext();
            BeginContext(3949, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4041, 23, false);
#line 88 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                       Write(checkout.LibraryCard.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4064, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 91 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(4143, 374, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
    <div class=""col-lg-6"">
        <h4>Current Holds</h4>
        <table class=""table table-bordered table-hover table-condensed"">
            <thead>
                <tr>
                    <th>Hold Placed</th>
                    <th>Patron</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 105 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                 foreach (var hold in @Model.CurrentHolds)
                {

#line default
#line hidden
            BeginContext(4596, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4681, 15, false);
#line 109 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                       Write(hold.HoldPlaced);

#line default
#line hidden
            EndContext();
            BeginContext(4696, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4788, 15, false);
#line 112 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                       Write(hold.PatronName);

#line default
#line hidden
            EndContext();
            BeginContext(4803, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 115 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(4882, 64, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.ViewModels.Catalog.AssetDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
