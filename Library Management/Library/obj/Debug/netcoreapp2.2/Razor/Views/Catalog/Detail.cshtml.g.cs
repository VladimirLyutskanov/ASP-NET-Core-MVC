#pragma checksum "D:\repos\Library\Library\Views\Catalog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ded62286fd85d53bab46bfab64d055cbea2ba65"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ded62286fd85d53bab46bfab64d055cbea2ba65", @"/Views/Catalog/Detail.cshtml")]
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
            BeginContext(52, 332, true);
            WriteLiteral(@"
    <div class=""container"">
        <div class=""header clearfix detailHeading"">
            <h2 class=""text-muted"">View Library Item</h2>
        </div>
    </div>

    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div>
                    <img class=""detailImage""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 384, "\"", 405, 1);
#line 13 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
WriteAttributeValue("", 390, Model.ImageUrl, 390, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(406, 119, true);
            WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <p id=\"itemTitle\">");
            EndContext();
            BeginContext(526, 11, false);
#line 17 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                             Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(537, 41, true);
            WriteLiteral("</p>\r\n                <p id=\"itemAuthor\">");
            EndContext();
            BeginContext(579, 22, false);
#line 18 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                              Write(Model.AuthorOrDirector);

#line default
#line hidden
            EndContext();
            BeginContext(601, 41, true);
            WriteLiteral("</p>\r\n                <p id=\"itemStatus\">");
            EndContext();
            BeginContext(643, 12, false);
#line 19 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                              Write(Model.Status);

#line default
#line hidden
            EndContext();
            BeginContext(655, 39, true);
            WriteLiteral("</p>\r\n                <p id=\"itemType\">");
            EndContext();
            BeginContext(695, 10, false);
#line 20 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                            Write(Model.Type);

#line default
#line hidden
            EndContext();
            BeginContext(705, 58, true);
            WriteLiteral("</p>\r\n                <p id=\"itemLocation\">Last Location: ");
            EndContext();
            BeginContext(764, 21, false);
#line 21 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                                               Write(Model.CurrentLocation);

#line default
#line hidden
            EndContext();
            BeginContext(785, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
#line 23 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                 if (@Model.Status == "Lost")
                {

#line default
#line hidden
            BeginContext(859, 96, true);
            WriteLiteral("                    <p>This item is lost. It cannot be checked out.</p>\r\n                    <p>");
            EndContext();
            BeginContext(955, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ded62286fd85d53bab46bfab64d055cbea2ba659108", async() => {
                BeginContext(1078, 15, true);
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
#line 26 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
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
            BeginContext(1097, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 27 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(1122, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 29 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                 if (Model.Status == "Checked Out")
                {

#line default
#line hidden
            BeginContext(1196, 55, true);
            WriteLiteral("                    <p id=\"itemPatron\">Checked Out By: ");
            EndContext();
            BeginContext(1252, 16, false);
#line 31 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                                                  Write(Model.PatronName);

#line default
#line hidden
            EndContext();
            BeginContext(1268, 29, true);
            WriteLiteral("</p>\r\n                    <p>");
            EndContext();
            BeginContext(1297, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ded62286fd85d53bab46bfab64d055cbea2ba6512801", async() => {
                BeginContext(1421, 8, true);
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
#line 32 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
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
            BeginContext(1433, 29, true);
            WriteLiteral("</p>\r\n                    <p>");
            EndContext();
            BeginContext(1462, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ded62286fd85d53bab46bfab64d055cbea2ba6515592", async() => {
                BeginContext(1583, 10, true);
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
#line 33 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
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
            BeginContext(1597, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 34 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(1622, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 35 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                 if (@Model.Status == "Available")
                {

#line default
#line hidden
            BeginContext(1693, 23, true);
            WriteLiteral("                    <p>");
            EndContext();
            BeginContext(1716, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ded62286fd85d53bab46bfab64d055cbea2ba6518882", async() => {
                BeginContext(1838, 9, true);
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
#line 37 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
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
            BeginContext(1851, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 38 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                }

#line default
#line hidden
            BeginContext(1876, 223, true);
            WriteLiteral("            </div>\r\n            <div class=\"col-md-4 detailinfo\">\r\n                <table>\r\n                    <tr>\r\n                        <td class=\"itemLabel\">ISBN: </td>\r\n                        <td class=\"itemValue\">");
            EndContext();
            BeginContext(2100, 10, false);
#line 44 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                                         Write(Model.ISBN);

#line default
#line hidden
            EndContext();
            BeginContext(2110, 172, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"itemLabel\">Call Number: </td>\r\n                        <td class=\"itemValue\">");
            EndContext();
            BeginContext(2283, 11, false);
#line 48 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                                         Write(Model.Dewey);

#line default
#line hidden
            EndContext();
            BeginContext(2294, 178, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td class=\"itemLabel\">Replacement Cost: </td>\r\n                        <td class=\"itemValue\">$");
            EndContext();
            BeginContext(2473, 10, false);
#line 52 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                                          Write(Model.Cost);

#line default
#line hidden
            EndContext();
            BeginContext(2483, 546, true);
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
#line 70 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                     foreach (var checkout in @Model.CheckoutHistory)
                    {

#line default
#line hidden
            BeginContext(3123, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3220, 19, false);
#line 74 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                           Write(checkout.CheckedOut);

#line default
#line hidden
            EndContext();
            BeginContext(3239, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3343, 18, false);
#line 77 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                           Write(checkout.CheckedIn);

#line default
#line hidden
            EndContext();
            BeginContext(3361, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3465, 23, false);
#line 80 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                           Write(checkout.LibraryCard.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3488, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 83 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                    }

#line default
#line hidden
            BeginContext(3579, 426, true);
            WriteLiteral(@"                </tbody>
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
#line 97 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                     foreach (var hold in @Model.CurrentHolds)
                    {

#line default
#line hidden
            BeginContext(4092, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4189, 15, false);
#line 101 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                           Write(hold.HoldPlaced);

#line default
#line hidden
            EndContext();
            BeginContext(4204, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(4308, 15, false);
#line 104 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                           Write(hold.PatronName);

#line default
#line hidden
            EndContext();
            BeginContext(4323, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 107 "D:\repos\Library\Library\Views\Catalog\Detail.cshtml"
                    }

#line default
#line hidden
            BeginContext(4414, 80, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
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