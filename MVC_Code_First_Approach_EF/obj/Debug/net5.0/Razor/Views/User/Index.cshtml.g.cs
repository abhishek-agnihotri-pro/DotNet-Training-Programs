#pragma checksum "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "893f52e794e6b7623d05a73173a62af661099fb9e70a21a9904e9479ef2c6c30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\_ViewImports.cshtml"
using MVC_Code_First_Approach_EF

#nullable disable
    ;
#nullable restore
#line 2 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\_ViewImports.cshtml"
using MVC_Code_First_Approach_EF.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"893f52e794e6b7623d05a73173a62af661099fb9e70a21a9904e9479ef2c6c30", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1a80b2a5217ca64d2ae68afd6ae0c081de370c106a9df9a7b20c3cc46a7f31e0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVC_Code_First_Approach_EF.Models.User>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>List</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "893f52e794e6b7623d05a73173a62af661099fb9e70a21a9904e9479ef2c6c303824", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 16 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                 Html.DisplayNameFor(model => model.UserID)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 19 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                 Html.DisplayNameFor(model => model.FirstName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 22 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                 Html.DisplayNameFor(model => model.LastName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 25 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                 Html.DisplayNameFor(model => model.Email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 28 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                 Html.DisplayNameFor(model => model.Age)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 31 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                 Html.DisplayNameFor(model => model.Password)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 34 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                 Html.DisplayNameFor(model => model.ConfirmPassword)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 37 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                 Html.DisplayNameFor(model => model.PhoneNumber)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            Write(
#nullable restore
#line 40 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                 Html.DisplayNameFor(model => model.URL)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 46 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            Write(
#nullable restore
#line 50 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                     Html.DisplayFor(modelItem => item.UserID)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            Write(
#nullable restore
#line 53 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                     Html.DisplayFor(modelItem => item.FirstName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            Write(
#nullable restore
#line 56 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                     Html.DisplayFor(modelItem => item.LastName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            Write(
#nullable restore
#line 59 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                     Html.DisplayFor(modelItem => item.Email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            Write(
#nullable restore
#line 62 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                     Html.DisplayFor(modelItem => item.Age)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            Write(
#nullable restore
#line 65 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                     Html.DisplayFor(modelItem => item.Password)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            Write(
#nullable restore
#line 68 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                     Html.DisplayFor(modelItem => item.ConfirmPassword)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            Write(
#nullable restore
#line 71 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                     Html.DisplayFor(modelItem => item.PhoneNumber)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            Write(
#nullable restore
#line 74 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                     Html.DisplayFor(modelItem => item.URL)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            Write(
#nullable restore
#line 77 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                     Html.ActionLink("Edit", "Edit", new { id=item.UserID })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" |\r\n                    ");
            Write(
#nullable restore
#line 78 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                     Html.ActionLink("Details", "Details", new { id=item.UserID })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" |\r\n                    ");
            Write(
#nullable restore
#line 79 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
                     Html.ActionLink("Delete", "Delete", new {  id=item.UserID })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 82 "D:\.NetTrainings\MVC_Code_First_Approach_EF\Views\User\Index.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVC_Code_First_Approach_EF.Models.User>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
