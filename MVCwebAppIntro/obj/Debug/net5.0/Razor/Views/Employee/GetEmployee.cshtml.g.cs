#pragma checksum "D:\.NetTrainings\MVCwebAppIntro\Views\Employee\GetEmployee.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0995c33663fcbfa1f1d7ad33da2ec3093137d78e8f0c229040c9857273521a92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_GetEmployee), @"mvc.1.0.view", @"/Views/Employee/GetEmployee.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\.NetTrainings\MVCwebAppIntro\Views\_ViewImports.cshtml"
using MVCwebAppIntro

#nullable disable
    ;
#nullable restore
#line 2 "D:\.NetTrainings\MVCwebAppIntro\Views\_ViewImports.cshtml"
using MVCwebAppIntro.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0995c33663fcbfa1f1d7ad33da2ec3093137d78e8f0c229040c9857273521a92", @"/Views/Employee/GetEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"46eaef4024d6799209616d341f90e454e298bce08e068ff2d13dc5cb3090bd79", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_GetEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\.NetTrainings\MVCwebAppIntro\Views\Employee\GetEmployee.cshtml"
  
    Employee emp = ViewBag.employee as Employee;

#line default
#line hidden
#nullable disable

            WriteLiteral("<div class=\"container\">\r\n    <h1>Employee Details</h1>\r\n    <h4>");
            Write(
#nullable restore
#line 6 "D:\.NetTrainings\MVCwebAppIntro\Views\Employee\GetEmployee.cshtml"
         emp.EmpId

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h4>\r\n    <h4>");
            Write(
#nullable restore
#line 7 "D:\.NetTrainings\MVCwebAppIntro\Views\Employee\GetEmployee.cshtml"
         emp.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h4>\r\n    <h4>");
            Write(
#nullable restore
#line 8 "D:\.NetTrainings\MVCwebAppIntro\Views\Employee\GetEmployee.cshtml"
         emp.Salary

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h4>\r\n\r\n\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
