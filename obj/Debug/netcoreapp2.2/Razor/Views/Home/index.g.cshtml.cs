#pragma checksum "/Users/ryan/Desktop/coding_dojo/C_Sharp/asp.net_core/randomPasscode/Views/Home/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5e418ede18d5b049bcfb4c0ab81ec09ebfefc50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_index), @"mvc.1.0.view", @"/Views/Home/index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/index.cshtml", typeof(AspNetCore.Views_Home_index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5e418ede18d5b049bcfb4c0ab81ec09ebfefc50", @"/Views/Home/index.cshtml")]
    public class Views_Home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/ryan/Desktop/coding_dojo/C_Sharp/asp.net_core/randomPasscode/Views/Home/index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 124, true);
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome</h1>\n    <p>------------</p>\n    <p>Random passcode (passcode #");
            EndContext();
            BeginContext(167, 21, false);
#line 8 "/Users/ryan/Desktop/coding_dojo/C_Sharp/asp.net_core/randomPasscode/Views/Home/index.cshtml"
                             Write(ViewBag.passcodeCount);

#line default
#line hidden
            EndContext();
            BeginContext(188, 15, true);
            WriteLiteral(" )</p>\n    <h3>");
            EndContext();
            BeginContext(204, 19, false);
#line 9 "/Users/ryan/Desktop/coding_dojo/C_Sharp/asp.net_core/randomPasscode/Views/Home/index.cshtml"
   Write(ViewBag.passcodeNew);

#line default
#line hidden
            EndContext();
            BeginContext(223, 116, true);
            WriteLiteral("</h3>\n    <form action=\"/\" method = \"post\">\n        <input type=\"submit\" value = \"Generate\">\n    </form>\n    \n</div>");
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