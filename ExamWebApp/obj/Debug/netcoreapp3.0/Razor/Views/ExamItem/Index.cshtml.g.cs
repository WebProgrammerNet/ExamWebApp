#pragma checksum "C:\Users\Code\source\repos\ExamWebApp\ExamWebApp\Views\ExamItem\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa9d0a9a4c324306c1c4d774b03bc5dcdb6ad51d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ExamItem_Index), @"mvc.1.0.view", @"/Views/ExamItem/Index.cshtml")]
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
#line 1 "C:\Users\Code\source\repos\ExamWebApp\ExamWebApp\Views\_ViewImports.cshtml"
using ExamWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Code\source\repos\ExamWebApp\ExamWebApp\Views\_ViewImports.cshtml"
using ExamWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Code\source\repos\ExamWebApp\ExamWebApp\Views\_ViewImports.cshtml"
using ExamWebApp.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa9d0a9a4c324306c1c4d774b03bc5dcdb6ad51d", @"/Views/ExamItem/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"155048ed2dc817b263312c7cbf1bb9e90d8b58f1", @"/Views/_ViewImports.cshtml")]
    public class Views_ExamItem_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExofSt>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Code\source\repos\ExamWebApp\ExamWebApp\Views\ExamItem\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""container-fluid"">

        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th scope=""col"">No</th>
                                <th scope=""col"">Teacher_Name</th>
                                <th scope=""col"">Teacher_Surname</th>
                                <th scope=""col"">Student_Name</th>
                                <th scope=""col"">Student_Surname</th>
                                <th scope=""col"">St_Mark</th>
                                <th scope=""col"">St_Code</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 25 "C:\Users\Code\source\repos\ExamWebApp\ExamWebApp\Views\ExamItem\Index.cshtml"
                              
                                int count = 1;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Code\source\repos\ExamWebApp\ExamWebApp\Views\ExamItem\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n\r\n                                <th scope=\"row\">");
#nullable restore
#line 32 "C:\Users\Code\source\repos\ExamWebApp\ExamWebApp\Views\ExamItem\Index.cshtml"
                                           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                                <td>");
#nullable restore
#line 34 "C:\Users\Code\source\repos\ExamWebApp\ExamWebApp\Views\ExamItem\Index.cshtml"
                               Write(item.Teacher.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 35 "C:\Users\Code\source\repos\ExamWebApp\ExamWebApp\Views\ExamItem\Index.cshtml"
                               Write(item.Teacher.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 36 "C:\Users\Code\source\repos\ExamWebApp\ExamWebApp\Views\ExamItem\Index.cshtml"
                               Write(item.Student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 37 "C:\Users\Code\source\repos\ExamWebApp\ExamWebApp\Views\ExamItem\Index.cshtml"
                               Write(item.Student.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 38 "C:\Users\Code\source\repos\ExamWebApp\ExamWebApp\Views\ExamItem\Index.cshtml"
                               Write(item.Student.Mark);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 39 "C:\Users\Code\source\repos\ExamWebApp\ExamWebApp\Views\ExamItem\Index.cshtml"
                               Write(item.Student.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Code\source\repos\ExamWebApp\ExamWebApp\Views\ExamItem\Index.cshtml"
                                count++;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExofSt>> Html { get; private set; }
    }
}
#pragma warning restore 1591
