#pragma checksum "C:\Users\zovbe\source\repos\OrderReceiverSystem\Views\OrderListData\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56241549f582dc7ef03df2050caed99d2d4a725f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderListData_Index), @"mvc.1.0.view", @"/Views/OrderListData/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56241549f582dc7ef03df2050caed99d2d4a725f", @"/Views/OrderListData/Index.cshtml")]
    public class Views_OrderListData_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderReceiverSystem.Modelos.ViewModel.OrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\zovbe\source\repos\OrderReceiverSystem\Views\OrderListData\Index.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ORDER LIST DATA</h1>\r\n<u>Order: </u>\r\n<br />\r\n<i>");
#nullable restore
#line 9 "C:\Users\zovbe\source\repos\OrderReceiverSystem\Views\OrderListData\Index.cshtml"
Write(Html.Raw(Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\zovbe\source\repos\OrderReceiverSystem\Views\OrderListData\Index.cshtml"
Write(Url.Action("Call", "OrderListData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderReceiverSystem.Modelos.ViewModel.OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
