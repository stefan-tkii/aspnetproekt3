#pragma checksum "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7c4c95c8f4fdeedb91908c433506a8488d86520"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_editStudentEnrollment), @"mvc.1.0.view", @"/Views/Student/editStudentEnrollment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7c4c95c8f4fdeedb91908c433506a8488d86520", @"/Views/Student/editStudentEnrollment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94889b7ad63ca4f34071938785fb79d16e8f1df7", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_editStudentEnrollment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNetProekt3.ViewModels.EnrollmentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "changeUrl", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "uploadProject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
  
    ViewData["Title"] = "editStudentEnrollment";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h3>editStudentEnrollment</h3>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 12 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
           Write(Html.DisplayNameFor(model => model.Student.Indeks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 15 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
           Write(Html.DisplayNameFor(model => model.Grade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 18 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
           Write(Html.DisplayNameFor(model => model.Semester));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 21 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 24 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
           Write(Html.DisplayNameFor(model => model.ExamPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 27 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
           Write(Html.DisplayNameFor(model => model.SeminalPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 30 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
           Write(Html.DisplayNameFor(model => model.AdditionalPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 33 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
           Write(Html.DisplayNameFor(model => model.FinishDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 36 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
           Write(Html.DisplayNameFor(model => model.ProjectUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n        \n            <tr>\n                <td>\n                    ");
#nullable restore
#line 44 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Student.Indeks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 47 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Grade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 50 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Semester));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 53 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
               Write(Html.DisplayFor(modelItem => Model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 56 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
               Write(Html.DisplayFor(modelItem => Model.ExamPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 59 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
               Write(Html.DisplayFor(modelItem => Model.SeminalPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 62 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
               Write(Html.DisplayFor(modelItem => Model.AdditionalPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 65 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
               Write(Html.DisplayFor(modelItem => Model.FinishDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                   <a");
            BeginWriteAttribute("href", " href=\"", 2072, "\"", 2096, 1);
#nullable restore
#line 68 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
WriteAttributeValue("", 2079, Model.ProjectUrl, 2079, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 68 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
                                           Write(Html.DisplayFor(modelItem => Model.ProjectUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\n                </td>\n            </tr>\n    </tbody>\n</table>\n<br />\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7c4c95c8f4fdeedb91908c433506a8488d8652011606", async() => {
                WriteLiteral(@"
    <div class=""form-actions no-color"">
        <p>
            Enter the link to the project url: <input type=""text"" name=""url"" placeholder=""Project URL"" />
            <input type=""submit"" value=""Save changes"" class=""btn btn-default"" />
        </p>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
                                                        WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<br />\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7c4c95c8f4fdeedb91908c433506a8488d8652014736", async() => {
                WriteLiteral(@"
    <div class=""form-group row"">
        <label class=""col-sm-2 col-form-label"">Upload file: </label>
        <div class=""col-sm-10"">
            <div class=""custom-file"">
                <input type=""file"" name=""uploadedFile"" class=""form-control custom-file-input"" />
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\stefa\source\repos\AspNetProekt4\Views\Student\editStudentEnrollment.cshtml"
                                                                                          WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetProekt3.ViewModels.EnrollmentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
