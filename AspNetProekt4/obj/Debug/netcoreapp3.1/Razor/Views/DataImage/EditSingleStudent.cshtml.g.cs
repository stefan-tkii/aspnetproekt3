#pragma checksum "C:\Users\stefa\source\repos\AspNetProekt3\Views\DataImage\EditSingleStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2f1709ccd0793dff6ba6b7509a0173e4ea13b9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DataImage_EditSingleStudent), @"mvc.1.0.view", @"/Views/DataImage/EditSingleStudent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2f1709ccd0793dff6ba6b7509a0173e4ea13b9d", @"/Views/DataImage/EditSingleStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbf3323ed67d4e44270af49f67036d506631fecb", @"/Views/_ViewImports.cshtml")]
    public class Views_DataImage_EditSingleStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNetProekt3.ViewModels.StudentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DataImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "uploadStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\stefa\source\repos\AspNetProekt3\Views\DataImage\EditSingleStudent.cshtml"
  
    ViewData["Title"] = "EditSingleStudent";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Selected student\'s profile</h3>\r\n\r\n<label>Profile image:</label>\r\n<br />\r\n<img width=\"200\" height=\"200\"");
            BeginWriteAttribute("src", " src=\"", 212, "\"", 233, 1);
#nullable restore
#line 10 "C:\Users\stefa\source\repos\AspNetProekt3\Views\DataImage\EditSingleStudent.cshtml"
WriteAttributeValue("", 218, Model.filePath, 218, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Empty image\" />\r\n\r\n<br />\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\stefa\source\repos\AspNetProekt3\Views\DataImage\EditSingleStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.Indeks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\stefa\source\repos\AspNetProekt3\Views\DataImage\EditSingleStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\stefa\source\repos\AspNetProekt3\Views\DataImage\EditSingleStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\stefa\source\repos\AspNetProekt3\Views\DataImage\EditSingleStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.EnrollmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\stefa\source\repos\AspNetProekt3\Views\DataImage\EditSingleStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.AcquiredCredits));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\stefa\source\repos\AspNetProekt3\Views\DataImage\EditSingleStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.CurrentSemester));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\stefa\source\repos\AspNetProekt3\Views\DataImage\EditSingleStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.EducationLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\stefa\source\repos\AspNetProekt3\Views\DataImage\EditSingleStudent.cshtml"
           Write(Html.DisplayFor(modelItem => Model.Indeks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\stefa\source\repos\AspNetProekt3\Views\DataImage\EditSingleStudent.cshtml"
           Write(Html.DisplayFor(modelItem => Model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\stefa\source\repos\AspNetProekt3\Views\DataImage\EditSingleStudent.cshtml"
           Write(Html.DisplayFor(modelItem => Model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\stefa\source\repos\AspNetProekt3\Views\DataImage\EditSingleStudent.cshtml"
           Write(Html.DisplayFor(modelItem => Model.EnrollmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\stefa\source\repos\AspNetProekt3\Views\DataImage\EditSingleStudent.cshtml"
           Write(Html.DisplayFor(modelItem => Model.AcquiredCredits));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\stefa\source\repos\AspNetProekt3\Views\DataImage\EditSingleStudent.cshtml"
           Write(Html.DisplayFor(modelItem => Model.CurrentSemester));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "C:\Users\stefa\source\repos\AspNetProekt3\Views\DataImage\EditSingleStudent.cshtml"
           Write(Html.DisplayFor(modelItem => Model.EducationLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n\r\n    </tbody>\r\n</table>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f1709ccd0793dff6ba6b7509a0173e4ea13b9d10044", async() => {
                WriteLiteral(@"
    <div class=""form-group row"">
        <label class=""col-sm-2 col-form-label"">Upload image: </label>
        <div class=""col-sm-10"">
            <div class=""custom-file"">
                <input type=""file"" name=""uploadedStudent"" class=""form-control custom-file-input"" />
                <label class=""custom-file-label""></label>
            </div>
        </div>
        <br />
        <input type=""submit"" value=""Save changes"" class=""btn btn-default"" />
    </div>
");
                DefineSection("Scripts", async() => {
                    WriteLiteral(@"
        <script>
        $(document).ready(function () {
            $('.custom-file-input').on(""change"", function () {
                var filename = $(this).val().split(""\\"").pop();
                $(this).next('.custom-file-label').html(filename);
            });
        });
        </script>
    ");
                }
                );
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\stefa\source\repos\AspNetProekt3\Views\DataImage\EditSingleStudent.cshtml"
                                                                                            WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetProekt3.ViewModels.StudentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
