#pragma checksum "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76c838f2025f879963adda04482e9f7546d66efa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_ViewMyCourses), @"mvc.1.0.view", @"/Views/Student/ViewMyCourses.cshtml")]
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
#nullable restore
#line 1 "C:\Users\stefa\source\repos\AspNetProekt3\Views\_ViewImports.cshtml"
using AspNetProekt3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\stefa\source\repos\AspNetProekt3\Views\_ViewImports.cshtml"
using AspNetProekt3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76c838f2025f879963adda04482e9f7546d66efa", @"/Views/Student/ViewMyCourses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbf3323ed67d4e44270af49f67036d506631fecb", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_ViewMyCourses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AspNetProekt3.Models.Enrollment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "editStudentEnrollment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
  
    ViewData["Title"] = "ViewMyCourses";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Enrolled courses</h3>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
           Write(Html.DisplayNameFor(model => model.Student.Indeks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
           Write(Html.DisplayNameFor(model => model.Grade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
           Write(Html.DisplayNameFor(model => model.Semester));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
           Write(Html.DisplayNameFor(model => model.ExamPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
           Write(Html.DisplayNameFor(model => model.SeminalPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
           Write(Html.DisplayNameFor(model => model.AdditionalPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
           Write(Html.DisplayNameFor(model => model.FinishDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
           Write(Html.DisplayNameFor(model=>model.ProjectUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
           Write(Html.DisplayNameFor(model=>model.SeminalUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 45 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
               Write(Html.DisplayFor(modelItem => item.Student.Indeks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
               Write(Html.DisplayFor(modelItem => item.Grade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
               Write(Html.DisplayFor(modelItem => item.Semester));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
               Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
               Write(Html.DisplayFor(modelItem => item.ExamPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
               Write(Html.DisplayFor(modelItem => item.SeminalPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
               Write(Html.DisplayFor(modelItem => item.AdditionalPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
               Write(Html.DisplayFor(modelItem => item.FinishDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                   <a");
            BeginWriteAttribute("href", " href=\"", 2278, "\"", 2301, 1);
#nullable restore
#line 73 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
WriteAttributeValue("", 2285, item.ProjectUrl, 2285, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 73 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.ProjectUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
               Write(Html.DisplayFor(modelItem => item.SeminalUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76c838f2025f879963adda04482e9f7546d66efa11299", async() => {
                WriteLiteral("Edit enrollment");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 82 "C:\Users\stefa\source\repos\AspNetProekt3\Views\Student\ViewMyCourses.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<br />\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AspNetProekt3.Models.Enrollment>> Html { get; private set; }
    }
}
#pragma warning restore 1591