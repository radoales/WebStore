#pragma checksum "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a717e92d93cc595c2f6453176ffaa4b7e2cd3908"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a717e92d93cc595c2f6453176ffaa4b7e2cd3908", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07232dfe33f5f03cc4b26e92a4537aaf25bc2ac9", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebStore.MVC.Helpers.PaginatedList<ListProductRequestModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/no-image.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-pageNumber", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<style>
.highligth-on-hoover:hover{
    background-color:lightgrey;
}
</style>

<style>
    /*--------------------------------------------------------*/
    /* The Modal (background) */
    .modal {
        display: none; /* Hidden by default */
        position: fixed; /* Stay in place */
        z-index: 1; /* Sit on top */
        padding-top: 50px; /* Location of the box */
        left: 0;
        top: 0;
        width: 100%; /* Full width */
        height: 100%; /* Full height */
        overflow: auto; /* Enable scroll if needed */
        background-color: rgb(0,0,0); /* Fallback color */
        background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
    }

    /* Modal Content */
    .modal-content {
        background-color: #fefefe;
        margin: auto;
        padding: 1px;
        border: 1px solid #888;
        width: 30%;
        opacity: 0.9;
        color: black;
    }

    /* The Close Button */
    .close {
        color: #aaaaaa;
        float: r");
            WriteLiteral("ight;\r\n        font-size: 28px;\r\n        font-weight: bold;\r\n    }\r\n\r\n        .close:hover,\r\n        .close:focus {\r\n            color: #000;\r\n            text-decoration: none;\r\n            cursor: pointer;\r\n        }\r\n</style>\r\n\r\n<h1>Products</h1>\r\n\r\n\r\n");
#nullable restore
#line 62 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
 if (this.User.IsInRole(Roles.AdminRole))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a717e92d93cc595c2f6453176ffaa4b7e2cd39088833", async() => {
                WriteLiteral("Add Product");
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
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 67 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-2\">\r\n            <div style=\"line-height:0.9;\" class=\"container\">\r\n");
#nullable restore
#line 72 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                 foreach (var item in await productService.GetAllCategories())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p><h5>");
#nullable restore
#line 74 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></p>\r\n");
#nullable restore
#line 75 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                     foreach (var productType in item.ProductTypes)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"highligth-on-hoover\" style=\"cursor:pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2057, "\"", 2103, 3);
            WriteAttributeValue("", 2067, "selectProductType(\'", 2067, 19, true);
#nullable restore
#line 77 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 2086, productType.Id, 2086, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2101, "\')", 2101, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 77 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                                                                                                                           Write(productType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><br />\r\n");
#nullable restore
#line 78 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <hr />\r\n");
#nullable restore
#line 80 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"col-sm-10\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 86 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                     foreach (var item in Model)
                    {
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card bg-light mb-3 list-galery-zoom\" style=\"width: 12.0rem; margin-left:20px; margin-bottom:30px\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a717e92d93cc595c2f6453176ffaa4b7e2cd390813200", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 91 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                                     if (item.Image == null)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a717e92d93cc595c2f6453176ffaa4b7e2cd390813787", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 94 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <img class=\"card-img-top\"");
                BeginWriteAttribute("src", " src=\"", 3071, "\"", 3135, 2);
                WriteAttributeValue("", 3077, "data:image/jpeg;base64,", 3077, 23, true);
#nullable restore
#line 97 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 3100, Convert.ToBase64String(item.Image), 3100, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", "\r\n                                             alt=\"", 3136, "\"", 3228, 1);
#nullable restore
#line 98 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 3188, Html.DisplayFor(modelItem => item.Name), 3188, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 99 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
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
            WriteLiteral("\r\n                                <div style=\"margin:5px; padding:3px;\" class=\"card-body text-center\">\r\n                                    <h5 class=\"card-title\">");
#nullable restore
#line 102 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <p class=\"card-text\">Some quick example text to build on the card title.</p>\r\n                                    <span class=\"price-text\"> ");
#nullable restore
#line 104 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" kr.</span>\r\n");
            WriteLiteral("                                    <input id=\"addToCardButton\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3931, "\"", 4050, 11);
            WriteAttributeValue("", 3941, "addToCart(", 3941, 10, true);
#nullable restore
#line 106 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 3951, item.Id, 3951, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3959, ",", 3959, 1, true);
            WriteAttributeValue(" ", 3960, "\'", 3961, 2, true);
#nullable restore
#line 106 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 3962, item.Name, 3962, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3972, "\',", 3972, 2, true);
#nullable restore
#line 106 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
WriteAttributeValue("  ", 3974, item.Price, 3976, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3987, ",", 3987, 1, true);
            WriteAttributeValue(" ", 3988, "\'data:image/jpeg;base64,", 3989, 25, true);
#nullable restore
#line 106 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 4013, Convert.ToBase64String(item.Image), 4013, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4048, "\')", 4048, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\" type=\"button\" value=\"Add\">\r\n");
            WriteLiteral("                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 110 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                        
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"myModal\" class=\"modal\"></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div> \r\n\r\n");
#nullable restore
#line 119 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
      
        var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
        var nextDisabled = !Model.HasNextPage ? "disabled" : "";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("      \r\n    <div class=\"center-div\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a717e92d93cc595c2f6453176ffaa4b7e2cd390822159", async() => {
                WriteLiteral("\r\n            Previous\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 126 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                      WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4722, "btn", 4722, 3, true);
            AddHtmlAttributeValue(" ", 4725, "btn-default", 4726, 12, true);
#nullable restore
#line 127 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
AddHtmlAttributeValue(" ", 4737, prevDisabled, 4738, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 130 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
         if (Model.PageIndex > 2)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a717e92d93cc595c2f6453176ffaa4b7e2cd390825210", async() => {
                WriteLiteral("\r\n                1\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <span>...</span>\r\n");
#nullable restore
#line 137 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
         if (Model.HasPreviousPage)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a717e92d93cc595c2f6453176ffaa4b7e2cd390827369", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 141 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
            Write(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 140 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                                             WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 143 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>");
#nullable restore
#line 144 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
         Write(Model.PageIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 145 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
         if (Model.HasNextPage)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a717e92d93cc595c2f6453176ffaa4b7e2cd390830513", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 148 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
            Write(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 147 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                                             WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 150 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 151 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
         if (Model.TotalPages > Model.PageIndex + 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>...</span>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a717e92d93cc595c2f6453176ffaa4b7e2cd390833433", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 156 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
           Write(Model.TotalPages);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 155 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                         WriteLiteral(Model.TotalPages);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 158 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a717e92d93cc595c2f6453176ffaa4b7e2cd390836069", async() => {
                WriteLiteral("\r\n            Next\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 160 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
                      WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5784, "btn", 5784, 3, true);
            AddHtmlAttributeValue(" ", 5787, "btn-default", 5788, 12, true);
#nullable restore
#line 161 "C:\Programming\Projects\WebStore\WebStore.MVC\Views\Products\Index.cshtml"
AddHtmlAttributeValue(" ", 5799, nextDisabled, 5800, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div> \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebStore.MVC.Helpers.PaginatedList<ListProductRequestModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
