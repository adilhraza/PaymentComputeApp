#pragma checksum "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Shared\_NotificationPanel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c91fe3f6f279d9d827cae4694a75194498aea865"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__NotificationPanel), @"mvc.1.0.view", @"/Views/Shared/_NotificationPanel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_NotificationPanel.cshtml", typeof(AspNetCore.Views_Shared__NotificationPanel))]
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
using PaymentComputeApp.WebUI.Models.Employee;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c91fe3f6f279d9d827cae4694a75194498aea865", @"/Views/Shared/_NotificationPanel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a97b3dca6ee84536ae654fc9b9033ca9139215ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__NotificationPanel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Shared\_NotificationPanel.cshtml"
 if (TempData["notification"] != null)
{
    

#line default
#line hidden
            BeginContext(48, 34, false);
#line 3 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Shared\_NotificationPanel.cshtml"
Write(Html.Raw(TempData["notification"]));

#line default
#line hidden
            EndContext();
#line 3 "D:\Projects\ASP .NET Core\PaymentComputeApp\PaymentComputeApp.WebUI\Views\Shared\_NotificationPanel.cshtml"
                                       
}

#line default
#line hidden
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
