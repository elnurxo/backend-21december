#pragma checksum "C:\Users\LENOVO\Desktop\BackEnd Tasks\12-21-2021Task\FirstDayBackEnd\FirstDayBackEnd\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2af139b508e004fbeab02a3b6d3ced75fad3da28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2af139b508e004fbeab02a3b6d3ced75fad3da28", @"/Views/Home/Detail.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\LENOVO\Desktop\BackEnd Tasks\12-21-2021Task\FirstDayBackEnd\FirstDayBackEnd\Views\Home\Detail.cshtml"
   
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("<img src=\"https://www.p2pfinancenews.co.uk/wp-content/uploads/2021/03/Details-1024x585.jpg\" width=\"550px\" height=\"400px\" alt=\"Alternate Text\" />\r\n<h1 style=\"color:hotpink\">This is Details page</h1>\r\n<ul>\r\n    <li>Tempdate: ");
#nullable restore
#line 7 "C:\Users\LENOVO\Desktop\BackEnd Tasks\12-21-2021Task\FirstDayBackEnd\FirstDayBackEnd\Views\Home\Detail.cshtml"
             Write(TempData["Id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>ViewData: ");
#nullable restore
#line 8 "C:\Users\LENOVO\Desktop\BackEnd Tasks\12-21-2021Task\FirstDayBackEnd\FirstDayBackEnd\Views\Home\Detail.cshtml"
             Write(ViewData["Id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>ViewBag: ");
#nullable restore
#line 9 "C:\Users\LENOVO\Desktop\BackEnd Tasks\12-21-2021Task\FirstDayBackEnd\FirstDayBackEnd\Views\Home\Detail.cshtml"
            Write(ViewBag.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n");
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
