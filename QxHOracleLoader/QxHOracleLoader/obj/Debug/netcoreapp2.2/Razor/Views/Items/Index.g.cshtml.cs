#pragma checksum "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e1822dd6d2717ac1f486746fc4359dfb653acfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Index), @"mvc.1.0.view", @"/Views/Items/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Index.cshtml", typeof(AspNetCore.Views_Items_Index))]
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
#line 1 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\_ViewImports.cshtml"
using QxHOracleLoader;

#line default
#line hidden
#line 2 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\_ViewImports.cshtml"
using QxHOracleLoader.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e1822dd6d2717ac1f486746fc4359dfb653acfa", @"/Views/Items/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57f889062d23032eb1da1f45e9dc2f7769e6c6b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QxHOracleLoader.Models.Item>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "items", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(92, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(121, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e1822dd6d2717ac1f486746fc4359dfb653acfa6351", async() => {
                BeginContext(144, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(158, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
            BeginContext(166, 3791, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e1822dd6d2717ac1f486746fc4359dfb653acfa7735", async() => {
                BeginContext(240, 139, true);
                WriteLiteral("\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>Select</th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(380, 42, false);
#line 18 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ItemId));

#line default
#line hidden
                EndContext();
                BeginContext(422, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(490, 45, false);
#line 21 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PlanSeqId));

#line default
#line hidden
                EndContext();
                BeginContext(535, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(603, 51, false);
#line 24 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ItemDescription));

#line default
#line hidden
                EndContext();
                BeginContext(654, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(722, 49, false);
#line 27 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.OrderQuantity));

#line default
#line hidden
                EndContext();
                BeginContext(771, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(839, 47, false);
#line 30 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.OrderSldTdy));

#line default
#line hidden
                EndContext();
                BeginContext(886, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(954, 53, false);
#line 33 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PlannedMinutesQty));

#line default
#line hidden
                EndContext();
                BeginContext(1007, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1075, 52, false);
#line 36 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ActualMinutesQty));

#line default
#line hidden
                EndContext();
                BeginContext(1127, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1195, 45, false);
#line 39 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.NetworkId));

#line default
#line hidden
                EndContext();
                BeginContext(1240, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1308, 45, false);
#line 42 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CompanyId));

#line default
#line hidden
                EndContext();
                BeginContext(1353, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1421, 50, false);
#line 45 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.AvaiForSaleQty));

#line default
#line hidden
                EndContext();
                BeginContext(1471, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1539, 44, false);
#line 48 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ShowDate));

#line default
#line hidden
                EndContext();
                BeginContext(1583, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1651, 42, false);
#line 51 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ShowCd));

#line default
#line hidden
                EndContext();
                BeginContext(1693, 106, true);
                WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 57 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(1856, 60, true);
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(1917, 50, false);
#line 61 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.CheckBoxFor(modelItem => item.CheckboxAnswer));

#line default
#line hidden
                EndContext();
                BeginContext(1967, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(2035, 41, false);
#line 64 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ItemId));

#line default
#line hidden
                EndContext();
                BeginContext(2076, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(2144, 50, false);
#line 67 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ItemDescription));

#line default
#line hidden
                EndContext();
                BeginContext(2194, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(2262, 44, false);
#line 70 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PlanSeqId));

#line default
#line hidden
                EndContext();
                BeginContext(2306, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(2374, 44, false);
#line 73 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NetworkId));

#line default
#line hidden
                EndContext();
                BeginContext(2418, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(2486, 44, false);
#line 76 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CompanyId));

#line default
#line hidden
                EndContext();
                BeginContext(2530, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(2598, 48, false);
#line 79 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderQuantity));

#line default
#line hidden
                EndContext();
                BeginContext(2646, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(2714, 46, false);
#line 82 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderSldTdy));

#line default
#line hidden
                EndContext();
                BeginContext(2760, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(2828, 49, false);
#line 85 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.AvaiForSaleQty));

#line default
#line hidden
                EndContext();
                BeginContext(2877, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(2945, 41, false);
#line 88 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ShowCd));

#line default
#line hidden
                EndContext();
                BeginContext(2986, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(3054, 43, false);
#line 91 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ShowDate));

#line default
#line hidden
                EndContext();
                BeginContext(3097, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(3165, 52, false);
#line 94 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PlannedMinutesQty));

#line default
#line hidden
                EndContext();
                BeginContext(3217, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(3285, 51, false);
#line 97 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ActualMinutesQty));

#line default
#line hidden
                EndContext();
                BeginContext(3336, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(3403, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e1822dd6d2717ac1f486746fc4359dfb653acfa20855", async() => {
                    BeginContext(3452, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 100 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
                                           WriteLiteral(item.ItemId);

#line default
#line hidden
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
                EndContext();
                BeginContext(3460, 24, true);
                WriteLiteral(" |\r\n                    ");
                EndContext();
                BeginContext(3484, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e1822dd6d2717ac1f486746fc4359dfb653acfa23361", async() => {
                    BeginContext(3536, 7, true);
                    WriteLiteral("Details");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 101 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
                                              WriteLiteral(item.ItemId);

#line default
#line hidden
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
                EndContext();
                BeginContext(3547, 24, true);
                WriteLiteral(" |\r\n                    ");
                EndContext();
                BeginContext(3571, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e1822dd6d2717ac1f486746fc4359dfb653acfa25873", async() => {
                    BeginContext(3622, 6, true);
                    WriteLiteral("Delete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 102 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
                                             WriteLiteral(item.ItemId);

#line default
#line hidden
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
                EndContext();
                BeginContext(3632, 44, true);
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
                EndContext();
#line 105 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(3691, 259, true);
                WriteLiteral(@"        </tbody>
    </table>
    <div class=""form-group"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-6 col-lg-4"">
                <input id=""Submit"" type=""submit"" value=""submit""/>
            </div>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QxHOracleLoader.Models.Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591