#pragma checksum "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByDate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a7cc5f12b79d0ee5b92be198a62b0508a1587d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_PaymentByDate), @"mvc.1.0.view", @"/Views/Report/PaymentByDate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Report/PaymentByDate.cshtml", typeof(AspNetCore.Views_Report_PaymentByDate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a7cc5f12b79d0ee5b92be198a62b0508a1587d4", @"/Views/Report/PaymentByDate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18770d24c01ce5aa069ffdc99ad2b3d05525268d", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_PaymentByDate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaymentByDateReportViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByDate.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(78, 301, true);
            WriteLiteral(@"
<div class=""content-wrapper"">
    <div class=""col-md-12 grid-margin stretch-card pt-2"">
        <div class=""card"">
            <div class=""card-body"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item"">");
            EndContext();
            BeginContext(379, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a7cc5f12b79d0ee5b92be198a62b0508a1587d45614", async() => {
                BeginContext(423, 4, true);
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
            BeginContext(431, 203, true);
            WriteLiteral("</li>\r\n                        <li class=\"breadcrumb-item active\" aria-current=\"page\">Payment record report by date</li>\r\n                    </ol>\r\n                </nav><br /><br />\r\n\r\n                ");
            EndContext();
            BeginContext(634, 1047, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a7cc5f12b79d0ee5b92be198a62b0508a1587d47404", async() => {
                BeginContext(654, 155, true);
                WriteLiteral("\r\n                    <div class=\"form-row\">\r\n                        <div class=\"form-group col-md-1 font-weight-bold pt-1\">\r\n                            ");
                EndContext();
                BeginContext(809, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a7cc5f12b79d0ee5b92be198a62b0508a1587d47948", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 20 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByDate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DateFrom);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(843, 152, true);
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group col-md-3 font-italic font-weight-bolder\">\r\n                            ");
                EndContext();
                BeginContext(995, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4a7cc5f12b79d0ee5b92be198a62b0508a1587d49737", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 23 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByDate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DateFrom);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("date", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1049, 126, true);
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group col-md-1 pt-1\">\r\n                            ");
                EndContext();
                BeginContext(1175, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a7cc5f12b79d0ee5b92be198a62b0508a1587d411902", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 26 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByDate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DateTo);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1207, 121, true);
                WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group col-md-3\">\r\n                            ");
                EndContext();
                BeginContext(1328, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4a7cc5f12b79d0ee5b92be198a62b0508a1587d413661", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 29 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByDate.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DateTo);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1375, 299, true);
                WriteLiteral(@"
                        </div>
                        <div class=""form-group"">
                            <button type=""submit"" class=""btn btn-rounded btn-primary float-left ml-2"" style=""width:100px"">Accept</button>
                        </div>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1681, 32, true);
            WriteLiteral("\r\n\r\n                <hr />\r\n\r\n\r\n");
            EndContext();
#line 40 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByDate.cshtml"
                 if (Model.Payments != null && Model.Payments.Count()>0)
                {

#line default
#line hidden
            BeginContext(1806, 2375, true);
            WriteLiteral(@"                    <div id=""example2_wrapper"" class=""dataTables_wrapper dt-bootstrap4"">
                        <div class=""row""><div class=""col-sm-12 col-md-6""></div><div class=""col-sm-12 col-md-6""></div></div><div class=""row"">
                            <div class=""col-sm-12"">
                                <table id=""example2"" class=""table table-bordered table-hover dataTable"" role=""grid"" aria-describedby=""example2_info"">
                                    <thead>
                                        <tr role=""row"">
                                            <th class=""sorting_asc"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"">
                                                Employee
                                            </th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"">
                                                Pay Date
                                     ");
            WriteLiteral(@"       </th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"">
                                                Month
                                            </th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"">
                                                Tax Year
                                            </th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"">
                                                Total Earnings
                                            </th>
                                            <th class=""sorting"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"">
                                                Total Deductions
                                            </th>
                                            <th cla");
            WriteLiteral(@"ss=""sorting"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"">
                                                Net Payment
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
            EndContext();
#line 72 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByDate.cshtml"
                                         foreach (var item in Model.Payments)
                                        {

#line default
#line hidden
            BeginContext(4303, 125, true);
            WriteLiteral("                                            <tr role=\"row\" class=\"odd\">\r\n                                                <td>");
            EndContext();
            BeginContext(4429, 13, false);
#line 75 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByDate.cshtml"
                                               Write(item.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(4442, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4502, 35, false);
#line 76 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByDate.cshtml"
                                               Write(item.PayDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(4537, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4597, 13, false);
#line 77 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByDate.cshtml"
                                               Write(item.PayMonth);

#line default
#line hidden
            EndContext();
            BeginContext(4610, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4670, 9, false);
#line 78 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByDate.cshtml"
                                               Write(item.Year);

#line default
#line hidden
            EndContext();
            BeginContext(4679, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4739, 32, false);
#line 79 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByDate.cshtml"
                                               Write(item.TotalEarnings.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(4771, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4831, 33, false);
#line 80 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByDate.cshtml"
                                               Write(item.TotalDeduction.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(4864, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(4924, 29, false);
#line 81 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByDate.cshtml"
                                               Write(item.NetPayment.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(4953, 58, true);
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
            EndContext();
#line 83 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByDate.cshtml"
                                        }

#line default
#line hidden
            BeginContext(5054, 1658, true);
            WriteLiteral(@"

                                    </tbody>
                                </table>
                            </div>
                        </div><div class=""row""><div class=""col-sm-12 col-md-5""><div class=""dataTables_info"" id=""example2_info"" role=""status"" aria-live=""polite"">Showing 1 to 10 of 57 entries</div></div><div class=""col-sm-12 col-md-7""><div class=""dataTables_paginate paging_simple_numbers"" id=""example2_paginate""><ul class=""pagination""><li class=""paginate_button page-item previous disabled"" id=""example2_previous""><a href=""#"" aria-controls=""example2"" data-dt-idx=""0"" tabindex=""0"" class=""page-link"">Previous</a></li><li class=""paginate_button page-item active""><a href=""#"" aria-controls=""example2"" data-dt-idx=""1"" tabindex=""0"" class=""page-link"">1</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""example2"" data-dt-idx=""2"" tabindex=""0"" class=""page-link"">2</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""example2"" data-dt-idx=""3"" tabindex=""0"" class");
            WriteLiteral(@"=""page-link"">3</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""example2"" data-dt-idx=""4"" tabindex=""0"" class=""page-link"">4</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""example2"" data-dt-idx=""5"" tabindex=""0"" class=""page-link"">5</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""example2"" data-dt-idx=""6"" tabindex=""0"" class=""page-link"">6</a></li><li class=""paginate_button page-item next"" id=""example2_next""><a href=""#"" aria-controls=""example2"" data-dt-idx=""7"" tabindex=""0"" class=""page-link"">Next</a></li></ul></div></div></div>
                    </div>
");
            EndContext();
#line 91 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Report\PaymentByDate.cshtml"
                }

#line default
#line hidden
            BeginContext(6731, 64, true);
            WriteLiteral("                </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaymentByDateReportViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591