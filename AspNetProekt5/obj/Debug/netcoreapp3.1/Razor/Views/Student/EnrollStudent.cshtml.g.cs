#pragma checksum "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\EnrollStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e706cc50f42c78d304184d99c4d5936796be5541"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_EnrollStudent), @"mvc.1.0.view", @"/Views/Student/EnrollStudent.cshtml")]
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
#line 1 "C:\Users\stefa\source\repos\AspNetProekt4\Views\_ViewImports.cshtml"
using AspNetProekt3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\stefa\source\repos\AspNetProekt4\Views\_ViewImports.cshtml"
using AspNetProekt3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e706cc50f42c78d304184d99c4d5936796be5541", @"/Views/Student/EnrollStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94889b7ad63ca4f34071938785fb79d16e8f1df7", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_EnrollStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AspNetProekt3.Models.Enrollment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\EnrollStudent.cshtml"
      
       ViewData["Title"] = "EnrollStudent";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h3>Current enrollment list</h3>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 12 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\EnrollStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.course.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 15 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\EnrollStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.course.Semester));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 18 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\EnrollStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.Student.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 21 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\EnrollStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.Student.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 24 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\EnrollStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.Student.Indeks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 27 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\EnrollStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 32 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\EnrollStudent.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 36 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\EnrollStudent.cshtml"
               Write(Html.DisplayFor(model => item.course.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 39 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\EnrollStudent.cshtml"
               Write(Html.DisplayFor(model => item.course.Semester));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 42 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\EnrollStudent.cshtml"
               Write(Html.DisplayFor(model => item.Student.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 45 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\EnrollStudent.cshtml"
               Write(Html.DisplayFor(model => item.Student.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 48 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\EnrollStudent.cshtml"
               Write(Html.DisplayFor(model => item.Student.Indeks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 51 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\EnrollStudent.cshtml"
               Write(Html.DisplayFor(model => item.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 54 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\EnrollStudent.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n\n");
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