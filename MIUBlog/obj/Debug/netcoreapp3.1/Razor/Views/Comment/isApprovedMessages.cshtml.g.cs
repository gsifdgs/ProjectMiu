#pragma checksum "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f19963f3c795268483b39e278bc81e71894c63f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_isApprovedMessages), @"mvc.1.0.view", @"/Views/Comment/isApprovedMessages.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f19963f3c795268483b39e278bc81e71894c63f", @"/Views/Comment/isApprovedMessages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10a5855d348d101dddb590f9ae946a0066ed454c", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_isApprovedMessages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Comment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Düzenle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
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
        $(document).ready(function () {
            $('#myTable').DataTable();
        });
    </script>

");
            }
            );
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"bg-primary text-white m-1 p-1  text-center\">\r\n        <h2>Onaylanan Yorumlar</h2>\r\n    </div>\r\n");
#nullable restore
#line 24 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
     if (Model.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container text-center p-1 m-1 mt-1\">\r\n            <h4>Onaylanan yorum yok</h4>\r\n        </div>\r\n");
#nullable restore
#line 29 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"


    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table data-page-length='3' id=""myTable"" class=""table table-bordered mt-3"">
            <thead>
                <tr>
                    <th>
                        Id
                    </th>
                    <th>
                        Kullanıcı Adı
                    </th>
                    <th>
                        Blog Adı
                    </th>
                    <th>
                        Yorum Tarihi
                    </th>
                    <th>
                        Onay Durumu
                    </th>
                    <th>

                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 58 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
                 foreach (var item in Model)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
                     if (item != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 64 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
                   Write(item.CommentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n\r\n                        ");
#nullable restore
#line 69 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
                   Write(item.ApplicationUser.NormalizedUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                    </td>\r\n\r\n");
#nullable restore
#line 74 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
                     if (item.BlogId != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 77 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
                       Write(item.Blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 79 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
                    }
                    else if (item.DiscussionId != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 83 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
                       Write(item.Discussion.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 85 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
                    }
                    else if (item.ProjectId != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 89 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
                       Write(item.Project.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 91 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 93 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
                   Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 96 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
                         if (item.isApproved)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fa fa-check\" aria-hidden=\"true\"></i>\r\n");
#nullable restore
#line 99 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fa fa-times\" aria-hidden=\"true\"></i>\r\n");
#nullable restore
#line 103 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n\r\n\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f19963f3c795268483b39e278bc81e71894c63f13591", async() => {
                WriteLiteral("\r\n\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f19963f3c795268483b39e278bc81e71894c63f13882", async() => {
                    WriteLiteral(" <i class=\"fas fa-pen-square\"></i>");
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
#nullable restore
#line 110 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
                                                      WriteLiteral(item.CommentId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
                                                                             WriteLiteral(item.CommentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 116 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"




                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3> Kayıt Yok</h3>\r\n");
#nullable restore
#line 124 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n\r\n          \r\n        </table>\r\n");
#nullable restore
#line 130 "C:\Users\MONSTER\Projects\CSharp\MIUBlog\MIUBlog\MIUBlog\Views\Comment\isApprovedMessages.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
