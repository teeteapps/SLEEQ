#pragma checksum "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Maintenance\Vehicletypelist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b62782210b9ad4cc3590fe606845fed612daed63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Maintenance_Vehicletypelist), @"mvc.1.0.view", @"/Views/Maintenance/Vehicletypelist.cshtml")]
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
#line 1 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\_ViewImports.cshtml"
using Sleeqcarhire;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\_ViewImports.cshtml"
using Sleeqcarhire.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b62782210b9ad4cc3590fe606845fed612daed63", @"/Views/Maintenance/Vehicletypelist.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f41e61a928141ef8f45a927794be210a814f665c", @"/Views/_ViewImports.cshtml")]
    public class Views_Maintenance_Vehicletypelist : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DBL.Models.ViewcompanyVehicletypes>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/formvalidation.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/plugins/datatables/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/plugins/datatables-bs4/js/dataTables.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/plugins/datatables-responsive/js/dataTables.responsive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/plugins/datatables-responsive/js/responsive.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/plugins/datatables-buttons/js/dataTables.buttons.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Maintenance\Vehicletypelist.cshtml"
  
    ViewData["Title"] = "Vehicletypelist";
    Layout = "~/Views/Shared/_Layoutadmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-sm-12\">\r\n        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 292, "\"", 342, 1);
#nullable restore
#line 10 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Maintenance\Vehicletypelist.cshtml"
WriteAttributeValue("", 299, Url.Action("Addvehicletype","Maintenance"), 299, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-info btn-xs float-right"" data-bs-target=""#AddvehicletypeModal"" data-bs-toggle=""modal"">Add Type</a>
            </div>
            <div class=""card-body table-responsive-sm"">
                <table class=""table table-bordered table-striped compact nowrap text-nowrap flex-nowrap table-sm font-weight-light"" id=""vehicletypesdata"">
                    <thead>
                        <tr>
                            <th class=""font-weight-light"">Image</th>
                            <th class=""font-weight-light"">Type Name</th>
                            <th class=""font-weight-light"">Action</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 22 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Maintenance\Vehicletypelist.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td><img");
            BeginWriteAttribute("src", " src=\"", 1211, "\"", 1245, 1);
#nullable restore
#line 25 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Maintenance\Vehicletypelist.cshtml"
WriteAttributeValue("", 1217, Url.Content(item.Imagepath), 1217, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"30\" width=\"30\" /> </td>\r\n                                <td>");
#nullable restore
#line 26 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Maintenance\Vehicletypelist.cshtml"
                               Write(item.Typename);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1375, "\"", 1457, 1);
#nullable restore
#line 27 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Maintenance\Vehicletypelist.cshtml"
WriteAttributeValue("", 1382, Url.Action("VehicletypeDetails","Maintenance",new{Typecode=item.Typecode}), 1382, 75, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-xs ml-1\">Details</a><a class=\"btn btn-info btn-xs ml-1\"");
            BeginWriteAttribute("href", " href=\"", 1538, "\"", 1617, 1);
#nullable restore
#line 27 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Maintenance\Vehicletypelist.cshtml"
WriteAttributeValue("", 1545, Url.Action("Editvehicletype","Maintenance",new{Typecode=item.Typecode}), 1545, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-target=\"#AddvehicletypeModal\" data-bs-toggle=\"modal\">Edit</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 29 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Maintenance\Vehicletypelist.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade mt-5"" id=""AddvehicletypeModal"" tabindex=""-1"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">

        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b62782210b9ad4cc3590fe606845fed612daed639918", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b62782210b9ad4cc3590fe606845fed612daed6311017", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b62782210b9ad4cc3590fe606845fed612daed6312117", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b62782210b9ad4cc3590fe606845fed612daed6313217", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b62782210b9ad4cc3590fe606845fed612daed6314317", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b62782210b9ad4cc3590fe606845fed612daed6315417", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script type=""text/javascript"">
        $('#AddvehicletypeModal').on('show.bs.modal', function (event) {
            var button = $(event.relatedTarget);
            var url = button.attr(""href"");
            var modal = $(this);
            modal.find('.modal-content').load(url);
        });
        $('#AddvehicletypeModal').on('hidden.bs.modal', function () {
            $(this).removeData('bs.modal');
            $('#AddvehicletypeModal .modal-content').empty();
        });
        $(document).ready(function () {
            $('#vehicletypesdata').DataTable({
                ""paging"": true,
                ""lengthChange"": true,
                ""searching"": true,
                ""ordering"": true,
                ""info"": true,
                ""autoWidth"": false,
                ""responsive"": true,
            });
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DBL.Models.ViewcompanyVehicletypes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
