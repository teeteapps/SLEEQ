#pragma checksum "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8e4ceeede1ce46679923f99b9a38869c9f931ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Viewassignvehicledata), @"mvc.1.0.view", @"/Views/Customers/Viewassignvehicledata.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8e4ceeede1ce46679923f99b9a38869c9f931ae", @"/Views/Customers/Viewassignvehicledata.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f41e61a928141ef8f45a927794be210a814f665c", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Viewassignvehicledata : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DBL.Models.Viewassignedreciept>>
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
#line 2 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
  
    ViewData["Title"] = "Viewassignvehicledata";
    Layout = "~/Views/Shared/_Layoutadmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-sm-12"">
        <div class=""card"">
            <div class=""card-body table-responsive"">
                <table class=""table table-bordered table-striped compact nowrap text-nowrap flex-nowrap table-sm font-weight-light table-sm"" id=""Viewassignedreciept"">
                    <thead>
                        <tr>
                            <th class=""font-weight-lighter"">Customer Details</th>
                            <th class=""font-weight-lighter"">Trip Details</th>
                            <th class=""font-weight-lighter"">Hirer Details</th>
                            <th class=""font-weight-lighter"">Payment Details</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 20 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td><b>Vehicle: </b>");
#nullable restore
#line 23 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                               Write(item.Vehiclereg);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><b>Name: </b>");
#nullable restore
#line 23 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                                                                  Write(item.Customername);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /> <b>Phone: </b>");
#nullable restore
#line 23 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                                                                                                         Write(item.Phoneno);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><b>Email: </b>");
#nullable restore
#line 23 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                                                                                                                                          Write(item.Emailadd);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /></td>\r\n                                <td>\r\n                                    <b>Where to: </b>");
#nullable restore
#line 25 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                                Write(item.Whereto);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><b>Description: </b>");
#nullable restore
#line 25 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                                                                       Write(item.Wheretodescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /> <b>Days: </b>");
#nullable restore
#line 25 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                                                                                                                    Write(item.Hiredays);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /> <b>Date Hired: </b>");
#nullable restore
#line 25 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                                                                                                                                                            Write(item.Dateissued);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /><b>Date Expected: </b> ");
#nullable restore
#line 25 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                                                                                                                                                                                                          Write(item.Dateexpected);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /><b>Status: </b>");
#nullable restore
#line 25 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                                                                                                                                                                                                                                                  Write(item.Carstatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 26 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                     if (item.Carstatus != "Parked" && item.Ispaid)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"btn btn-info btn-xs ml-1\"");
            BeginWriteAttribute("href", " href=\"", 1757, "\"", 1836, 1);
#nullable restore
#line 28 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
WriteAttributeValue("", 1764, Url.Action("Extendvehicle","Customers",new{Assigncode=item.Assigncode}), 1764, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-target=\"#ExtendvehicleModal\" data-bs-toggle=\"modal\">Extend</a><br />\r\n");
#nullable restore
#line 29 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>\r\n                                    <b>Date Hired: </b>");
#nullable restore
#line 32 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                                  Write(item.Dateissued);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><b>Leased By: </b>");
#nullable restore
#line 32 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                                                                          Write(item.Hirername);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><b>Date Recieved: </b>");
#nullable restore
#line 32 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                                                                                                                     Write(item.Daterecieved);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><b>Recieved by: </b>");
#nullable restore
#line 32 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                                                                                                                                                                 Write(item.Recievername);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 33 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                     if (item.Carstatus != "Parked" && item.Ispaid)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"btn btn-info btn-xs ml-1\"");
            BeginWriteAttribute("href", " href=\"", 2439, "\"", 2548, 1);
#nullable restore
#line 35 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
WriteAttributeValue("", 2446, Url.Action("Checkinvehicle","Customers",new{Assigncode=item.Assigncode,Vehiclecode=item.Vehiclecode}), 2446, 102, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Checkin</a>\r\n");
#nullable restore
#line 36 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>\r\n                                    <b>Amount Due: </b>Ksh. ");
#nullable restore
#line 39 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                                       Write(item.Amountdue.ToString("#,#00.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 40 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                     if (item.Ispaid)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"btn btn-xs btn-success\"><b>Paid</b></span><br />\r\n                                        <b>Amount Paid:  </b><span>Ksh.</span> ");
#nullable restore
#line 43 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                                                          Write(item.Paidamount.ToString("#,#00.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                                        <b>Paid By: </b>");
#nullable restore
#line 44 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                                   Write(item.Paidby);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 45 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"btn btn-xs btn-danger\">Not Paid</span><br />\r\n");
#nullable restore
#line 48 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                     if (!item.Ispaid)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"btn btn-info btn-xs ml-1 mt-1\"");
            BeginWriteAttribute("href", " href=\"", 3572, "\"", 3648, 1);
#nullable restore
#line 51 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
WriteAttributeValue("", 3579, Url.Action("Payvehicle","Customers",new{Assigncode=item.Assigncode}), 3579, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-target=\"#ExtendvehicleModal\" data-bs-toggle=\"modal\">Pay</a><br />\r\n");
#nullable restore
#line 52 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a class=\"btn btn-info btn-xs ml-1 mb-0\"");
            BeginWriteAttribute("href", " href=\"", 3925, "\"", 4016, 1);
#nullable restore
#line 55 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
WriteAttributeValue("", 3932, Url.Action("Assignvehicledetailreport","Customers",new{Assigncode=item.Assigncode}), 3932, 84, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Reciept</a><br />\r\n");
#nullable restore
#line 56 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 59 "C:\Users\user\source\repos\SLEEQ\Sleeqcarhire\Views\Customers\Viewassignvehicledata.cshtml"
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

<div class=""modal fade mt-5"" id=""ExtendvehicleModal"" tabindex=""-1"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">

        </div>
    </div>
</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8e4ceeede1ce46679923f99b9a38869c9f931ae19750", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8e4ceeede1ce46679923f99b9a38869c9f931ae20850", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8e4ceeede1ce46679923f99b9a38869c9f931ae21950", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8e4ceeede1ce46679923f99b9a38869c9f931ae23050", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8e4ceeede1ce46679923f99b9a38869c9f931ae24150", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8e4ceeede1ce46679923f99b9a38869c9f931ae25250", async() => {
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
        $('#ExtendvehicleModal').on('show.bs.modal', function (event) {
            var button = $(event.relatedTarget);
            var url = button.attr(""href"");
            var modal = $(this);
            modal.find('.modal-content').load(url);
        });
        $('#ExtendvehicleModal').on('hidden.bs.modal', function () {
            $(this).removeData('bs.modal');
            $('#ExtendvehicleModal .modal-content').empty();
        });
        $(document).ready(function () {
            function timedRefresh(time) {
                setTimeout(() => {
                    location.reload(true);
                }, time)
            }
            (() => {
                timedRefresh(1200000);
            })();
            $('#Viewassignedreciept').DataTable({
                ""paging"": true,
                ""lengthChange"": true,
                ""searching"": true,
                ""ordering"": true,
                ""info"": true,
                """);
                WriteLiteral("autoWidth\": false,\r\n                \"responsive\": true,\r\n            });\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DBL.Models.Viewassignedreciept>> Html { get; private set; }
    }
}
#pragma warning restore 1591
