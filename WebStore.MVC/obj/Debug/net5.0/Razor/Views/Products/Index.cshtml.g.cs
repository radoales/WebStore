#pragma checksum "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96f15ae25d91b062665b6caf821cdb9517817e6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\_ViewImports.cshtml"
using WebStore.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\_ViewImports.cshtml"
using WebStore.MVC.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\_ViewImports.cshtml"
using WebStore.MVC.ViewModels.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\_ViewImports.cshtml"
using WebStore.MVC.ViewModels.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\_ViewImports.cshtml"
using WebStore.MVC.ViewModels.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\_ViewImports.cshtml"
using WebStore.MVC.ViewModels.Cart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\_ViewImports.cshtml"
using WebStore.MVC.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\_ViewImports.cshtml"
using WebStore.MVC.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\_ViewImports.cshtml"
using static WebStore.MVC.WebConstants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96f15ae25d91b062665b6caf821cdb9517817e6c", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07232dfe33f5f03cc4b26e92a4537aaf25bc2ac9", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light dropdown-toggle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("sortId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/no-image.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Products";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"productTypeId\" data-value=\"");
#nullable restore
#line 9 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                               Write(Model.ProductTypeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></div>\r\n");
#nullable restore
#line 10 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
 if (this.User.IsInRole(Roles.AdminRole))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"center-div\">\r\n        <div style=\"border: solid; max-width:200px; margin:auto;\">\r\n            <p>Admin Section</p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96f15ae25d91b062665b6caf821cdb9517817e6c8956", async() => {
                WriteLiteral("AddNew Product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"container border\">\r\n        <div class=\"row\">\r\n            <div class=\"container\"");
            BeginWriteAttribute("style", " style=\"", 632, "\"", 640, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"float-right\"");
            BeginWriteAttribute("style", " style=\"", 684, "\"", 692, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96f15ae25d91b062665b6caf821cdb9517817e6c10969", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 24 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.SortBy);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96f15ae25d91b062665b6caf821cdb9517817e6c12417", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 25 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.SortBy);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.SortList;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\" style=\"margin:auto\">\r\n");
#nullable restore
#line 30 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
             foreach (var item in Model.Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card bg-light mb-3 list-galery-zoom  mb-5 rounded\" style=\"width: 14.1rem; margin-top:5px;margin-right:10px; margin-right:10px; margin-bottom:30px\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96f15ae25d91b062665b6caf821cdb9517817e6c15047", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                         if (item.Thumbnail == null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "96f15ae25d91b062665b6caf821cdb9517817e6c15602", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <img class=\"card-img-top\"");
                BeginWriteAttribute("src", " src=\"", 1641, "\"", 1685, 2);
                WriteAttributeValue("", 1647, "data:image/jpeg;base64,", 1647, 23, true);
#nullable restore
#line 40 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 1670, item.Thumbnail, 1670, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", "\r\n                                 alt=\"", 1686, "\"", 1766, 1);
#nullable restore
#line 41 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 1726, Html.DisplayFor(modelItem => item.Name), 1726, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 42 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                    <div style=\"margin:5px; padding:3px;\" class=\"card-body text-center\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 45 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 46 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <hr />\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 2165, "\"", 2173, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <span class=\"price-text float-left\"> ");
#nullable restore
#line 49 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                                                            Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" kr.</span>\r\n                            <div class=\"btn btn-success float-right\" id=\"addToCardButton\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2385, "\"", 2484, 11);
            WriteAttributeValue("", 2395, "addToCart(", 2395, 10, true);
#nullable restore
#line 50 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 2405, item.Id, 2405, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2413, ",", 2413, 1, true);
            WriteAttributeValue(" ", 2414, "\'", 2415, 2, true);
#nullable restore
#line 50 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 2416, item.Name, 2416, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2426, "\',", 2426, 2, true);
#nullable restore
#line 50 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
WriteAttributeValue("  ", 2428, item.Price, 2430, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2441, ",", 2441, 1, true);
            WriteAttributeValue(" ", 2442, "\'data:image/jpeg;base64,", 2443, 25, true);
#nullable restore
#line 50 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 2467, item.Thumbnail, 2467, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2482, "\')", 2482, 2, true);
            EndWriteAttribute();
            WriteLiteral("\r\n                                 data-toggle=\"modal\" data-target=\"#myModal\" type=\"button\">  <i class=\"fas fa-shopping-cart\"></i></div>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 56 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div id=\"myModal\" class=\"modal\"></div>\r\n    </div>\r\n\r\n\r\n");
#nullable restore
#line 63 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
  
    var prevDisabled = !Model.Products.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !Model.Products.HasNextPage ? "disabled" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"center-div\" style=\"padding-bottom:40px;\">\r\n        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3063, "\"", 3112, 3);
            WriteAttributeValue("", 3073, "paging(", 3073, 7, true);
#nullable restore
#line 69 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 3080, Model.Products.PageIndex - 1, 3080, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3111, ")", 3111, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("class", "\r\n           class=\"", 3113, "\"", 3162, 3);
            WriteAttributeValue("", 3133, "btn", 3133, 3, true);
            WriteAttributeValue(" ", 3136, "btn-default", 3137, 12, true);
#nullable restore
#line 70 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
WriteAttributeValue(" ", 3148, prevDisabled, 3149, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            Previous\r\n        </a>\r\n");
#nullable restore
#line 73 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
         if (Model.Products.PageIndex > 2)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"btn btn-default\" onclick=\"paging(1)\">\r\n                1\r\n            </a>\r\n            <span>...</span>\r\n");
#nullable restore
#line 79 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
         if (Model.Products.HasPreviousPage)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"btn btn-default\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3491, "\"", 3540, 3);
            WriteAttributeValue("", 3501, "paging(", 3501, 7, true);
#nullable restore
#line 82 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 3508, Model.Products.PageIndex - 1, 3508, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3539, ")", 3539, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
#nullable restore
#line 83 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
            Write(Model.Products.PageIndex - 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n");
#nullable restore
#line 85 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>");
#nullable restore
#line 86 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
         Write(Model.Products.PageIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 87 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
         if (Model.Products.HasNextPage)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"btn btn-default\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3761, "\"", 3810, 3);
            WriteAttributeValue("", 3771, "paging(", 3771, 7, true);
#nullable restore
#line 89 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 3778, Model.Products.PageIndex + 1, 3778, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3809, ")", 3809, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
#nullable restore
#line 90 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
            Write(Model.Products.PageIndex + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n");
#nullable restore
#line 92 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
         if (Model.Products.TotalPages > Model.Products.PageIndex + 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>...</span>\r\n            <a class=\"btn btn-default\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4043, "\"", 4089, 3);
            WriteAttributeValue("", 4053, "paging(", 4053, 7, true);
#nullable restore
#line 96 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 4060, Model.Products.TotalPages, 4060, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4088, ")", 4088, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
#nullable restore
#line 97 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
           Write(Model.Products.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n");
#nullable restore
#line 99 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 4176, "\"", 4225, 3);
            WriteAttributeValue("", 4186, "paging(", 4186, 7, true);
#nullable restore
#line 100 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 4193, Model.Products.PageIndex + 1, 4193, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4224, ")", 4224, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("class", "\r\n           class=\"", 4226, "\"", 4275, 3);
            WriteAttributeValue("", 4246, "btn", 4246, 3, true);
            WriteAttributeValue(" ", 4249, "btn-default", 4250, 12, true);
#nullable restore
#line 101 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
WriteAttributeValue(" ", 4261, nextDisabled, 4262, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            Next\r\n        </a>\r\n    </div>\r\n</div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IProductService productService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
