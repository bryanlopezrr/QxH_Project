#pragma checksum "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c4d5f4e76331586ec7966c2e483418a4f803082"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Details), @"mvc.1.0.view", @"/Views/Items/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Details.cshtml", typeof(AspNetCore.Views_Items_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c4d5f4e76331586ec7966c2e483418a4f803082", @"/Views/Items/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57f889062d23032eb1da1f45e9dc2f7769e6c6b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QxHOracleLoader.Models.Item>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(81, 127, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Item</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(209, 45, false);
#line 14 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PlanSeqId));

#line default
#line hidden
            EndContext();
            BeginContext(254, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(318, 41, false);
#line 17 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayFor(model => model.PlanSeqId));

#line default
#line hidden
            EndContext();
            BeginContext(359, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(422, 51, false);
#line 20 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ItemDescription));

#line default
#line hidden
            EndContext();
            BeginContext(473, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(537, 47, false);
#line 23 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayFor(model => model.ItemDescription));

#line default
#line hidden
            EndContext();
            BeginContext(584, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(647, 49, false);
#line 26 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(696, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(760, 45, false);
#line 29 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(805, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(868, 47, false);
#line 32 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderSldTdy));

#line default
#line hidden
            EndContext();
            BeginContext(915, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(979, 43, false);
#line 35 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderSldTdy));

#line default
#line hidden
            EndContext();
            BeginContext(1022, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1085, 53, false);
#line 38 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PlannedMinutesQty));

#line default
#line hidden
            EndContext();
            BeginContext(1138, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1202, 49, false);
#line 41 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayFor(model => model.PlannedMinutesQty));

#line default
#line hidden
            EndContext();
            BeginContext(1251, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1314, 52, false);
#line 44 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ActualMinutesQty));

#line default
#line hidden
            EndContext();
            BeginContext(1366, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1430, 48, false);
#line 47 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayFor(model => model.ActualMinutesQty));

#line default
#line hidden
            EndContext();
            BeginContext(1478, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1541, 45, false);
#line 50 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NetworkId));

#line default
#line hidden
            EndContext();
            BeginContext(1586, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1650, 41, false);
#line 53 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayFor(model => model.NetworkId));

#line default
#line hidden
            EndContext();
            BeginContext(1691, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1754, 45, false);
#line 56 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyId));

#line default
#line hidden
            EndContext();
            BeginContext(1799, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1863, 41, false);
#line 59 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompanyId));

#line default
#line hidden
            EndContext();
            BeginContext(1904, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1967, 50, false);
#line 62 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AvaiForSaleQty));

#line default
#line hidden
            EndContext();
            BeginContext(2017, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2081, 46, false);
#line 65 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayFor(model => model.AvaiForSaleQty));

#line default
#line hidden
            EndContext();
            BeginContext(2127, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2190, 44, false);
#line 68 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ShowDate));

#line default
#line hidden
            EndContext();
            BeginContext(2234, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2298, 40, false);
#line 71 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShowDate));

#line default
#line hidden
            EndContext();
            BeginContext(2338, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2401, 42, false);
#line 74 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ShowCd));

#line default
#line hidden
            EndContext();
            BeginContext(2443, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2507, 38, false);
#line 77 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShowCd));

#line default
#line hidden
            EndContext();
            BeginContext(2545, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2592, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c4d5f4e76331586ec7966c2e483418a4f80308214367", async() => {
                BeginContext(2642, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "C:\Users\Robert Leatherman\Desktop\HSN Internship\QxHOracleLoader\QxHOracleLoader\Views\Items\Details.cshtml"
                           WriteLiteral(Model.ItemId);

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
            BeginContext(2650, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2658, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c4d5f4e76331586ec7966c2e483418a4f80308216722", async() => {
                BeginContext(2680, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2696, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QxHOracleLoader.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591