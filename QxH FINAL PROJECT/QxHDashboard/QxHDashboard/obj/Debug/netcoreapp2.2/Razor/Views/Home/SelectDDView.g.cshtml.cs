#pragma checksum "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\Home\SelectDDView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d34445e9c01cb51265de1e34ccdede0e0a22ae33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SelectDDView), @"mvc.1.0.view", @"/Views/Home/SelectDDView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SelectDDView.cshtml", typeof(AspNetCore.Views_Home_SelectDDView))]
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
#line 1 "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\_ViewImports.cshtml"
using QxHDashboard;

#line default
#line hidden
#line 2 "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\_ViewImports.cshtml"
using QxHDashboard.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d34445e9c01cb51265de1e34ccdede0e0a22ae33", @"/Views/Home/SelectDDView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e073f5c11902bab484901f0be5f929bb70ae21e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SelectDDView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QxHDashboard.Models.MerchandiseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/3bars_menu_header.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("merchSelect"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SelectDDView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formSelect"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("variant"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("load"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/merchandise.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\Home\SelectDDView.cshtml"
  
    ViewData["Title"] = "Variant Summary";

#line default
#line hidden
            BeginContext(100, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(102, 3627, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d34445e9c01cb51265de1e34ccdede0e0a22ae336853", async() => {
                BeginContext(134, 354, true);
                WriteLiteral(@"
    <div class=""pageMain"">
        <div class=""variant-page"">
            <div class=""container-variant"">
                <header>
                    <nav class=""navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-dark "">
                        <div class=""container"">
                            <h3>
                                ");
                EndContext();
                BeginContext(488, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d34445e9c01cb51265de1e34ccdede0e0a22ae337597", async() => {
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
                EndContext();
                BeginContext(532, 81, true);
                WriteLiteral(" Variant Summary\r\n                            </h3>\r\n                            ");
                EndContext();
                BeginContext(613, 1140, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d34445e9c01cb51265de1e34ccdede0e0a22ae338921", async() => {
                    BeginContext(675, 232, true);
                    WriteLiteral("\r\n                                <asp:UpdatePanel runat=\"server\" id=\"UpdatePanel\" updatemode=\"Conditional\">\r\n                                    <label style=\"margin-left: 1em;\">Company</label>\r\n                                    ");
                    EndContext();
                    BeginContext(907, 91, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d34445e9c01cb51265de1e34ccdede0e0a22ae339566", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 19 "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\Home\SelectDDView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedCountryId);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 19 "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\Home\SelectDDView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.countries;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(998, 124, true);
                    WriteLiteral("\r\n                                    <label style=\"margin-left: 1em;\">Network</label>\r\n                                    ");
                    EndContext();
                    BeginContext(1122, 90, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d34445e9c01cb51265de1e34ccdede0e0a22ae3311991", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 21 "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\Home\SelectDDView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedNetworkId);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 21 "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\Home\SelectDDView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.networks;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1212, 126, true);
                    WriteLiteral("\r\n                                    <label style=\"margin-left: 1em;\">Show Card</label>\r\n                                    ");
                    EndContext();
                    BeginContext(1338, 83, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d34445e9c01cb51265de1e34ccdede0e0a22ae3314419", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 23 "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\Home\SelectDDView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedCardId);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 23 "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\Home\SelectDDView.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.cards;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1421, 325, true);
                    WriteLiteral(@"
                                    <Triggers>
                                        <input type=""submit"" value=""Update"" id=""autoSubmit"" class=""btn btn-light"" style=""margin-left: 1em;"" />

                                    </Triggers>
                                </asp:UpdatePanel>
                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1753, 685, true);
                WriteLiteral(@"
                        </div>
                    </nav>
                </header>
            </div>
            <table class=""merchTable"" id=""block"">
                <tr>
                    <th width=""75px"">SEQ</th>
                    <th width=""125px"">Item ID</th>
                    <th width=""700px"">Description</th>
                    <th width=""90px"">Sold</th>
                    <th width=""90px"">Sold Today</th>
                    <th width=""90px"">AFS</th>
                    <th width=""65px"">P Mins</th>
                    <th width=""65px"">A Mins</th>
                </tr>
                <tr>
                    <td></td>
                </tr>
");
                EndContext();
#line 48 "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\Home\SelectDDView.cshtml"
                 foreach (var item in Model.merchandise)
                {

#line default
#line hidden
                BeginContext(2515, 54, true);
                WriteLiteral("                    <tr id=\"merchRow\" data-item-type=\"");
                EndContext();
                BeginContext(2570, 7, false);
#line 50 "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\Home\SelectDDView.cshtml"
                                                 Write(item.Id);

#line default
#line hidden
                EndContext();
                BeginContext(2577, 55, true);
                WriteLiteral("\">\r\n                        <td class=\"1\" width=\"75px\">");
                EndContext();
                BeginContext(2633, 14, false);
#line 51 "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\Home\SelectDDView.cshtml"
                                              Write(item.PlanSeqId);

#line default
#line hidden
                EndContext();
                BeginContext(2647, 60, true);
                WriteLiteral("</td>\r\n                        <td class=\"2\"  width=\"125px\">");
                EndContext();
                BeginContext(2708, 11, false);
#line 52 "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\Home\SelectDDView.cshtml"
                                                Write(item.ItemId);

#line default
#line hidden
                EndContext();
                BeginContext(2719, 59, true);
                WriteLiteral("</td>\r\n                        <td class=\"3\" width=\"700px\">");
                EndContext();
                BeginContext(2779, 20, false);
#line 53 "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\Home\SelectDDView.cshtml"
                                               Write(item.ItemDescription);

#line default
#line hidden
                EndContext();
                BeginContext(2799, 70, true);
                WriteLiteral("</td>\r\n                        <td class=\"4\" width=90px align=\"right\">");
                EndContext();
                BeginContext(2870, 18, false);
#line 54 "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\Home\SelectDDView.cshtml"
                                                          Write(item.OrderQuantity);

#line default
#line hidden
                EndContext();
                BeginContext(2888, 70, true);
                WriteLiteral("</td>\r\n                        <td class=\"5\" width=90px align=\"right\">");
                EndContext();
                BeginContext(2959, 16, false);
#line 55 "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\Home\SelectDDView.cshtml"
                                                          Write(item.OrderSldTdy);

#line default
#line hidden
                EndContext();
                BeginContext(2975, 70, true);
                WriteLiteral("</td>\r\n                        <td class=\"6\" width=90px align=\"right\">");
                EndContext();
                BeginContext(3046, 19, false);
#line 56 "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\Home\SelectDDView.cshtml"
                                                          Write(item.AvaiForSaleQty);

#line default
#line hidden
                EndContext();
                BeginContext(3065, 70, true);
                WriteLiteral("</td>\r\n                        <td class=\"7\" width=65px align=\"right\">");
                EndContext();
                BeginContext(3136, 22, false);
#line 57 "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\Home\SelectDDView.cshtml"
                                                          Write(item.PlannedMinutesQty);

#line default
#line hidden
                EndContext();
                BeginContext(3158, 70, true);
                WriteLiteral("</td>\r\n                        <td class=\"8\" width=65px align=\"right\">");
                EndContext();
                BeginContext(3229, 21, false);
#line 58 "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\Home\SelectDDView.cshtml"
                                                          Write(item.ActualMinutesQty);

#line default
#line hidden
                EndContext();
                BeginContext(3250, 34, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n");
                EndContext();
#line 60 "C:\Users\bryan\OneDrive\Desktop\HSNProj2.0\QxH FINAL PROJECT\QxHDashboard\QxHDashboard\Views\Home\SelectDDView.cshtml"
                }

#line default
#line hidden
                BeginContext(3303, 419, true);
                WriteLiteral(@"            </table>            
        </div>        
    </div>
    <div class=""pageSide"" style=""height:810px; overflow-y: auto; display:block;"">
        <div id=""rightPanel"" style=""height:100%; overflow:hidden; background-color:white;"">
            <iframe id=""hsnComFrame"" src=""https://www.hsn.com/product-by-style/083408?Device=mobile"" style=""width: 98%; height:100%;""></iframe>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3729, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3756, 12, true);
                WriteLiteral("\r\n    \r\n    ");
                EndContext();
                BeginContext(3768, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d34445e9c01cb51265de1e34ccdede0e0a22ae3326184", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3811, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QxHDashboard.Models.MerchandiseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
