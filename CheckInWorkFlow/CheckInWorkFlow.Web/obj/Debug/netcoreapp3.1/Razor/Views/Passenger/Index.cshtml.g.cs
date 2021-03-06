#pragma checksum "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32790afa1c5f02acf0fe8ac88876805a5c1229f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Passenger_Index), @"mvc.1.0.view", @"/Views/Passenger/Index.cshtml")]
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
#line 1 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/_ViewImports.cshtml"
using CheckInWorkFlow.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/_ViewImports.cshtml"
using CheckInWorkFlow.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/_ViewImports.cshtml"
using CheckInWorkFlow.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/_ViewImports.cshtml"
using CheckInWorkFlow.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32790afa1c5f02acf0fe8ac88876805a5c1229f5", @"/Views/Passenger/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c452109c3e80367e84a25c752a2dc190e9ddb13f", @"/Views/_ViewImports.cshtml")]
    public class Views_Passenger_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PassengerModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Passenger", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookPassengerData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml"
  
    var AppointmentId=TempData["AppointmentId"];
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml"
 if(Model.Count()>0){

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\n");
#nullable restore
#line 8 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml"
      if(AppointmentId==null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h2>Passengers List</h2>\n");
#nullable restore
#line 11 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>Available Passengers</h2>\n");
#nullable restore
#line 15 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row \">\n");
#nullable restore
#line 17 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml"
         if(AppointmentId==null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32790afa1c5f02acf0fe8ac88876805a5c1229f56595", async() => {
                WriteLiteral("Add Passenger");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 20 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <br/>
</div>
    <div class=""panel-body"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Weight</th>
                    <th>Status</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 34 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml"
                 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td> ");
#nullable restore
#line 36 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml"
                        Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td> ");
#nullable restore
#line 37 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml"
                        Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td> ");
#nullable restore
#line 38 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml"
                        Write(item.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td> ");
#nullable restore
#line 39 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml"
                        Write(item.Status.DisplayName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 40 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml"
                          if(AppointmentId!=null)
                         {
                              

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml"
                                                                                                                                                                                     

                        var parms = new Dictionary<string, string>
                                    {
                                        { "AppointmentId", AppointmentId.ToString() },
                                        { "PassengerId", item.Id.ToString() }
                                    };

                             

#line default
#line hidden
#nullable disable
            WriteLiteral("                             <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32790afa1c5f02acf0fe8ac88876805a5c1229f510906", async() => {
                WriteLiteral("Book Passenger");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 51 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = parms;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n");
#nullable restore
#line 52 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml"
                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\n");
#nullable restore
#line 54 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n\n        </table>\n         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32790afa1c5f02acf0fe8ac88876805a5c1229f513305", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 58 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n");
#nullable restore
#line 61 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml"
}
else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\n        No Passengers available\n    </div>\n");
#nullable restore
#line 66 "/home/user/Code/CheckInWorkFlow/CheckInWorkFlow.Web/Views/Passenger/Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PassengerModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
