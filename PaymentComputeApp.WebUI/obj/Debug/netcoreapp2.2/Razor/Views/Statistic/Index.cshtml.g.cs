#pragma checksum "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Statistic\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "895028605f1941e124dcb85cfd5214e6028e9b92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statistic_Index), @"mvc.1.0.view", @"/Views/Statistic/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Statistic/Index.cshtml", typeof(AspNetCore.Views_Statistic_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"895028605f1941e124dcb85cfd5214e6028e9b92", @"/Views/Statistic/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"693bc087f324f5845a8ff13143aa10a57e79e1c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Statistic_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Statistic\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(41, 301, true);
            WriteLiteral(@"
<div class=""content-wrapper"">
    <div class=""col-md-12 grid-margin stretch-card pt-2"">
        <div class=""card"">
            <div class=""card-body"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item"">");
            EndContext();
            BeginContext(342, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "895028605f1941e124dcb85cfd5214e6028e9b924539", async() => {
                BeginContext(386, 4, true);
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
            BeginContext(394, 4502, true);
            WriteLiteral(@"</li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">Statistics</li>
                    </ol>
                </nav><br /><br />

                <div class=""row"">
                    <div class=""col-md-6"">
                        <div class=""card"">
                            <div class=""card-header"">
                                <h3 class=""card-title"">Employees/City</h3>

                                <div class=""card-tools"">
                                    <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                                        <i class=""fas fa-minus""></i>
                                    </button>
                                    <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"" data-toggle=""tooltip"" title=""Remove"">
                                        <i class=""fas fa-times""></i>
                                    </button>
                ");
            WriteLiteral(@"                </div>
                            </div>
                            <div class=""card-body"">
                                <div id=""chartEmployeesCity"" style=""height: 370px; width: 100%;""></div>
                            </div>
                            <!-- /.card-body -->
                        </div>
                    </div>

                    <div class=""col-md-6"">
                        <div class=""card"">
                            <div class=""card-header"">
                                <h3 class=""card-title"">AVG (Total Earnings)/Year</h3>

                                <div class=""card-tools"">
                                    <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                                        <i class=""fas fa-minus""></i>
                                    </button>
                                    <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove");
            WriteLiteral(@""" data-toggle=""tooltip"" title=""Remove"">
                                        <i class=""fas fa-times""></i>
                                    </button>
                                </div>
                            </div>
                            <div class=""card-body"">
                                <div id=""chartAvgTotalEarningsYear"" style=""height: 370px; width: 100%;""></div>
                            </div>
                            <!-- /.card-body -->
                        </div>
                    </div>

                    <div class=""col-md-6"">
                        <div class=""card"">
                            <div class=""card-header"">
                                <h3 class=""card-title"">AVG (Total Deduction)/Year</h3>

                                <div class=""card-tools"">
                                    <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" data-toggle=""tooltip"" title=""Collapse"">
                                      ");
            WriteLiteral(@"  <i class=""fas fa-minus""></i>
                                    </button>
                                    <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"" data-toggle=""tooltip"" title=""Remove"">
                                        <i class=""fas fa-times""></i>
                                    </button>
                                </div>
                            </div>
                            <div class=""card-body"">
                                <div id=""chartAvgTotalDeductionYear"" style=""height: 370px; width: 100%;""></div>
                            </div>
                            <!-- /.card-body -->
                        </div>
                    </div>
                </div>

                <script src=""https://canvasjs.com/assets/script/canvasjs.min.js""></script>
                <script src=""https://canvasjs.com/assets/script/jquery-1.11.1.min.js""></script>
            </div>
        </div>
    </div>
</div>


<script>
    window.");
            WriteLiteral(@"onload = function () {

        var chart = new CanvasJS.Chart(""chartEmployeesCity"", {
			theme: ""light2"", // ""light1"", ""light2"", ""dark1"", ""dark2""
			exportEnabled: true,
			animationEnabled: true,
			title: {
				text: """",
				fontSize: 21
			},
			data: [{
				type: ""pie"",
				startAngle: 160,
				toolTipContent: ""<b>{label}</b>: {y}%"",
				indexLabel: ""{label} - {y}%"",
				dataPoints: ");
            EndContext();
            BeginContext(4897, 41, false);
#line 105 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Statistic\Index.cshtml"
                       Write(Html.Raw(ViewBag.DataPointsEmployeesCity));

#line default
#line hidden
            EndContext();
            BeginContext(4938, 309, true);
            WriteLiteral(@"
			}]
        });
        chart.render();

        var chart = new CanvasJS.Chart(""chartAvgTotalEarningsYear"", {
			animationEnabled: true,
			theme: ""light2"", // ""light1"", ""dark1"", ""dark2""
			exportEnabled: true,
			title: {
				text: """"
			},
			data: [{
				type: ""column"",
				dataPoints:  ");
            EndContext();
            BeginContext(5248, 48, false);
#line 119 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Statistic\Index.cshtml"
                        Write(Html.Raw(ViewBag.DataPointsAvgTotalEarningsYear));

#line default
#line hidden
            EndContext();
            BeginContext(5296, 306, true);
            WriteLiteral(@"
			}]
		});
        chart.render();


        var chart = new CanvasJS.Chart(""chartAvgTotalDeductionYear"", {
			animationEnabled: true,
			theme: ""light2"", // ""light1"", ""dark1"", ""dark2""
			exportEnabled: true,
			title: {
				text: """"
			},
			data: [{
				type: ""column"",
				dataPoints:  ");
            EndContext();
            BeginContext(5603, 48, false);
#line 134 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Statistic\Index.cshtml"
                        Write(Html.Raw(ViewBag.DataPointsAvgTotalDeuctionYear));

#line default
#line hidden
            EndContext();
            BeginContext(5651, 61, true);
            WriteLiteral("\r\n\t\t\t}]\r\n\t\t});\r\n        chart.render();\r\n    }\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
