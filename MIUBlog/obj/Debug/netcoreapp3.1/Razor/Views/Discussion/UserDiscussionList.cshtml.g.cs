#pragma checksum "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Discussion\UserDiscussionList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9658034893f696afe612ccd912b9c1dfde7f317"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Discussion_UserDiscussionList), @"mvc.1.0.view", @"/Views/Discussion/UserDiscussionList.cshtml")]
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
#line 1 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\_ViewImports.cshtml"
using MIUBlog.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\_ViewImports.cshtml"
using MIUBlog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\_ViewImports.cshtml"
using MIUBlog.Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\_ViewImports.cshtml"
using MIUBlog.WebUI.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9658034893f696afe612ccd912b9c1dfde7f317", @"/Views/Discussion/UserDiscussionList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10a5855d348d101dddb590f9ae946a0066ed454c", @"/Views/_ViewImports.cshtml")]
    public class Views_Discussion_UserDiscussionList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Discussion>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Discussion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mb-3 rounded-pill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Düzelt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Sil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Discussion\UserDiscussionList.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.10.20/css/dataTables.bootstrap4.min.css\">\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""//cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.20/js/dataTables.bootstrap4.min.js""></script>

    <script>
        $(document).ready( function () {
            $('#myTable').DataTable();
        });
    </script>

");
            }
            );
            WriteLiteral("\r\n\r\n<div class=\"container mt-3\">\r\n    <div class=\"bg-primary text-white p-1 m-1 text-center\">\r\n        <h2>Tartışmalarım</h2>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9658034893f696afe612ccd912b9c1dfde7f3178592", async() => {
                WriteLiteral("<i class=\"fas fa-plus-circle\"></i>&nbsp;Yeni Tartışma");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n");
#nullable restore
#line 33 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Discussion\UserDiscussionList.cshtml"
             if (Model.Count() > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table data-page-length='10' id=""myTable"" class=""table table-bordered table-striped mt-3"">

                    <thead>
                        <tr>
                            
                            <th>Id</th>
                            <th>Görsel</th>
                            <th>Başlık</th>
                            <th>Tarih</th>
                            <th>Onay</th>

                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 50 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Discussion\UserDiscussionList.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 53 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Discussion\UserDiscussionList.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a9658034893f696afe612ccd912b9c1dfde7f31711684", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1742, "~/img/", 1742, 6, true);
#nullable restore
#line 55 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Discussion\UserDiscussionList.cshtml"
AddHtmlAttributeValue("", 1748, item.Image, 1748, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 57 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Discussion\UserDiscussionList.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 58 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Discussion\UserDiscussionList.cshtml"
                               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 60 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Discussion\UserDiscussionList.cshtml"
                                     if (item.isApproved)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fa fa-check\" aria-hidden=\"true\"></i>\r\n");
#nullable restore
#line 63 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Discussion\UserDiscussionList.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fa fa-times\" aria-hidden=\"true\"></i>\r\n");
#nullable restore
#line 67 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Discussion\UserDiscussionList.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n\r\n\r\n                                <td>\r\n                                \r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9658034893f696afe612ccd912b9c1dfde7f31715202", async() => {
                WriteLiteral("\r\n                                        <i class=\"fas fa-pen-square\"></i>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Discussion\UserDiscussionList.cshtml"
                                                                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9658034893f696afe612ccd912b9c1dfde7f31717987", async() => {
                WriteLiteral("\r\n                                        <i class=\"fas fa-trash-alt\"></i>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Discussion\UserDiscussionList.cshtml"
                                                                                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 81 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Discussion\UserDiscussionList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 84 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Discussion\UserDiscussionList.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-danger\">\r\n                    Tartışma Eklenmemiş\r\n                </div>\r\n");
#nullable restore
#line 90 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Discussion\UserDiscussionList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Discussion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
