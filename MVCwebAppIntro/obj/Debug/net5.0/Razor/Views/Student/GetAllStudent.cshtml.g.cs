#pragma checksum "D:\.NetTrainings\MVCwebAppIntro\Views\Student\GetAllStudent.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6cffa5a3e4bc9d781d925c6dd510990d09cae0eed6eb2fba4781f5810cedd36d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_GetAllStudent), @"mvc.1.0.view", @"/Views/Student/GetAllStudent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6cffa5a3e4bc9d781d925c6dd510990d09cae0eed6eb2fba4781f5810cedd36d", @"/Views/Student/GetAllStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"46eaef4024d6799209616d341f90e454e298bce08e068ff2d13dc5cb3090bd79", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_GetAllStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVCwebAppIntro.Models.Student>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <h2>\r\n        All Students List\r\n    </h2>\r\n\r\n    <h5>\r\n        <ol>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 18 "D:\.NetTrainings\MVCwebAppIntro\Views\Student\GetAllStudent.cshtml"
              
                var x = Model.Count();
            

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
#nullable restore
#line 23 "D:\.NetTrainings\MVCwebAppIntro\Views\Student\GetAllStudent.cshtml"
             foreach (var stu in Model)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <li>ID : ");
            Write(
#nullable restore
#line 25 "D:\.NetTrainings\MVCwebAppIntro\Views\Student\GetAllStudent.cshtml"
                          stu.ID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(", Name : ");
            Write(
#nullable restore
#line 25 "D:\.NetTrainings\MVCwebAppIntro\Views\Student\GetAllStudent.cshtml"
                                          stu.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(", Marks : ");
            Write(
#nullable restore
#line 25 "D:\.NetTrainings\MVCwebAppIntro\Views\Student\GetAllStudent.cshtml"
                                                             stu.Marks

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</li>\r\n");
#nullable restore
#line 26 "D:\.NetTrainings\MVCwebAppIntro\Views\Student\GetAllStudent.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("            <div>Total Students : ");
            Write(
#nullable restore
#line 27 "D:\.NetTrainings\MVCwebAppIntro\Views\Student\GetAllStudent.cshtml"
                                   x

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n\r\n        </ol>\r\n\r\n        <h4>1 - 10 </h4>\r\n        <ul>\r\n");
#nullable restore
#line 33 "D:\.NetTrainings\MVCwebAppIntro\Views\Student\GetAllStudent.cshtml"
             for (var i = 1; i < 10; i++)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <li>");
            Write(
#nullable restore
#line 35 "D:\.NetTrainings\MVCwebAppIntro\Views\Student\GetAllStudent.cshtml"
                     i

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</li>\r\n");
#nullable restore
#line 36 "D:\.NetTrainings\MVCwebAppIntro\Views\Student\GetAllStudent.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("        </ul>\r\n        </h45>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVCwebAppIntro.Models.Student>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
