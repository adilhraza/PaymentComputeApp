#pragma checksum "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1b419fba0c7073b9ab02cebb8e2d8ebbfb2ec9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_PaymentByTotalDeduction), @"mvc.1.0.view", @"/Views/Report/PaymentByTotalDeduction.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Report/PaymentByTotalDeduction.cshtml", typeof(AspNetCore.Views_Report_PaymentByTotalDeduction))]
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
#line 1 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\_ViewImports.cshtml"
using PaymentComputeApp.WebUI;

#line default
#line hidden
#line 2 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\_ViewImports.cshtml"
using PaymentComputeApp.WebUI.Models;

#line default
#line hidden
#line 3 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\_ViewImports.cshtml"
using PaymentComputeApp.Core.Helpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1b419fba0c7073b9ab02cebb8e2d8ebbfb2ec9d", @"/Views/Report/PaymentByTotalDeduction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"693bc087f324f5845a8ff13143aa10a57e79e1c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_PaymentByTotalDeduction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList<PaymentIndexViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PaymentByTotalDeduction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-controls", new global::Microsoft.AspNetCore.Html.HtmlString("example2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-dt-idx", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tabindex", new global::Microsoft.AspNetCore.Html.HtmlString("0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
  
    ViewData["Title"] = "PaymentByTotalDeduction";

#line default
#line hidden
            BeginContext(102, 301, true);
            WriteLiteral(@"
<div class=""content-wrapper"">
    <div class=""col-md-12 grid-margin stretch-card pt-2"">
        <div class=""card"">
            <div class=""card-body"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item"">");
            EndContext();
            BeginContext(403, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1b419fba0c7073b9ab02cebb8e2d8ebbfb2ec9d6519", async() => {
                BeginContext(447, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(455, 174, true);
            WriteLiteral("</li>\r\n                        <li class=\"breadcrumb-item active\" aria-current=\"page\">Payment report</li>\r\n                    </ol>\r\n                </nav><br /><br />\r\n\r\n\r\n");
            EndContext();
#line 19 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                 using (Html.BeginForm())
                {

#line default
#line hidden
            BeginContext(691, 333, true);
            WriteLiteral(@"                    <div class=""form-row"">
                        <div class=""form-group col-md-1 font-weight-bold pt-1"">
                            <label>Amount From: </label>
                        </div>
                        <div class=""form-group col-md-3 font-italic font-weight-bolder"">
                            ");
            EndContext();
            BeginContext(1025, 68, false);
#line 26 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                       Write(Html.TextBox("fromDeduction", null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 321, true);
            WriteLiteral(@"
                        </div>
                        <div class=""form-group col-md-1 font-weight-bold pt-1"">
                            <label>Amount To: </label>
                        </div>
                        <div class=""form-group col-md-3 font-italic font-weight-bolder"">
                            ");
            EndContext();
            BeginContext(1415, 66, false);
#line 32 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                       Write(Html.TextBox("toDeduction", null, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1481, 273, true);
            WriteLiteral(@"
                        </div>
                        <div class=""form-group col-md-3 font-italic font-weight-bolder"">
                            <input type=""submit"" class=""btn btn-info"" value=""Search"" />
                        </div>
                    </div>
");
            EndContext();
#line 38 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                }

#line default
#line hidden
            BeginContext(1773, 30, true);
            WriteLiteral("\r\n                <hr />\r\n\r\n\r\n");
            EndContext();
#line 43 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                 if (Model != null && Model.Count() > 0)
                {

#line default
#line hidden
            BeginContext(1880, 1906, true);
            WriteLiteral(@"                    <div class=""dataTables_wrapper dt-bootstrap4"">
                        <div class=""row""><div class=""col-sm-12 col-md-6""></div><div class=""col-sm-12 col-md-6""></div></div><div class=""row"">
                            <div class=""col-sm-12"">
                                <table class=""table table-bordered table-hover dataTable"" role=""grid"">
                                    <thead>
                                        <tr role=""row"">
                                            <th rowspan=""1"" colspan=""1"">
                                                Employee
                                            </th>
                                            <th rowspan=""1"" colspan=""1"">
                                                Payment Date
                                            </th>
                                            <th rowspan=""1"" colspan=""1"">
                                                Month
                                            </th>
     ");
            WriteLiteral(@"                                       <th rowspan=""1"" colspan=""1"">
                                                Tax Year
                                            </th>
                                            <th rowspan=""1"" colspan=""1"">
                                                Total Earnings
                                            </th>
                                            <th rowspan=""1"" colspan=""1"">
                                                Total Deductions
                                            </th>
                                            <th rowspan=""1"" colspan=""1"">
                                                Net Payment
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 75 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
            BeginContext(3899, 125, true);
            WriteLiteral("                                            <tr role=\"row\" class=\"odd\">\r\n                                                <td>");
            EndContext();
            BeginContext(4025, 13, false);
#line 78 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                                               Write(item.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(4038, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4098, 35, false);
#line 79 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                                               Write(item.PayDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(4133, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4193, 13, false);
#line 80 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                                               Write(item.PayMonth);

#line default
#line hidden
            EndContext();
            BeginContext(4206, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4266, 9, false);
#line 81 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                                               Write(item.Year);

#line default
#line hidden
            EndContext();
            BeginContext(4275, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4335, 32, false);
#line 82 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                                               Write(item.TotalEarnings.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(4367, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4427, 33, false);
#line 83 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                                               Write(item.TotalDeduction.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(4460, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4520, 29, false);
#line 84 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                                               Write(item.NetPayment.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(4549, 58, true);
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
            EndContext();
#line 86 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4650, 190, true);
            WriteLiteral("\r\n\r\n                                    </tbody>\r\n                                </table>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </div>\r\n");
            EndContext();
#line 95 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"



                    var disabledPrevious = Model.CurrentPage > 1 ? "" : "disabled";
                    var disabledNext = Model.CurrentPage < Model.TotalPages ? "" : "disabled";




#line default
#line hidden
            BeginContext(5033, 72, true);
            WriteLiteral("                    <ul class=\"pagination\">\r\n                        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5105, "\"", 5165, 4);
            WriteAttributeValue("", 5113, "paginate_button", 5113, 15, true);
            WriteAttributeValue(" ", 5128, "page-item", 5129, 10, true);
            WriteAttributeValue(" ", 5138, "previous", 5139, 9, true);
#line 104 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
WriteAttributeValue(" ", 5147, disabledPrevious, 5148, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5166, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(5197, 346, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1b419fba0c7073b9ab02cebb8e2d8ebbfb2ec9d18542", async() => {
                BeginContext(5531, 8, true);
                WriteLiteral("Previous");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-fromDeduction", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 106 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                                            WriteLiteral(ViewData["fromDeduction"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["fromDeduction"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-fromDeduction", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["fromDeduction"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 107 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                                          WriteLiteral(ViewData["toDeduction"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["toDeduction"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-toDeduction", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["toDeduction"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 108 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                                          WriteLiteral(Model.CurrentPage-1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5543, 33, true);
            WriteLiteral("\r\n                        </li>\r\n");
            EndContext();
#line 111 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                         for (int i = 1; i <= Model.TotalPages; i++)
                        {
                            var disabledButton = (i != Model.CurrentPage) ? "" : "disabled";

#line default
#line hidden
            BeginContext(5767, 31, true);
            WriteLiteral("                            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5798, "\"", 5847, 3);
            WriteAttributeValue("", 5806, "paginate_button", 5806, 15, true);
            WriteAttributeValue(" ", 5821, "page-item", 5822, 10, true);
#line 114 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
WriteAttributeValue(" ", 5831, disabledButton, 5832, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5848, 35, true);
            WriteLiteral(">\r\n                                ");
            EndContext();
            BeginContext(5883, 354, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1b419fba0c7073b9ab02cebb8e2d8ebbfb2ec9d23663", async() => {
                BeginContext(6232, 1, false);
#line 118 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                                                                                                                                Write(i);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-fromDeduction", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 116 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                                                WriteLiteral(ViewData["fromDeduction"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["fromDeduction"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-fromDeduction", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["fromDeduction"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 117 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                                              WriteLiteral(ViewData["toDeduction"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["toDeduction"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-toDeduction", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["toDeduction"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 118 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                                             WriteLiteral(i);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6237, 37, true);
            WriteLiteral("\r\n                            </li>\r\n");
            EndContext();
#line 120 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                        }

#line default
#line hidden
            BeginContext(6301, 31, true);
            WriteLiteral("\r\n\r\n                        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 6332, "\"", 6384, 4);
            WriteAttributeValue("", 6340, "paginate_button", 6340, 15, true);
            WriteAttributeValue(" ", 6355, "page-item", 6356, 10, true);
            WriteAttributeValue(" ", 6365, "next", 6366, 5, true);
#line 123 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
WriteAttributeValue(" ", 6370, disabledNext, 6371, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6385, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(6416, 342, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1b419fba0c7073b9ab02cebb8e2d8ebbfb2ec9d29185", async() => {
                BeginContext(6750, 4, true);
                WriteLiteral("Next");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-fromDeduction", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 125 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                                            WriteLiteral(ViewData["fromDeduction"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["fromDeduction"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-fromDeduction", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["fromDeduction"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 126 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                                          WriteLiteral(ViewData["toDeduction"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["toDeduction"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-toDeduction", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["toDeduction"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 127 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                                          WriteLiteral(Model.CurrentPage+1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6758, 60, true);
            WriteLiteral("\r\n                        </li>\r\n                    </ul>\r\n");
            EndContext();
#line 131 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByTotalDeduction.cshtml"
                }

#line default
#line hidden
            BeginContext(6837, 58, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList<PaymentIndexViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591