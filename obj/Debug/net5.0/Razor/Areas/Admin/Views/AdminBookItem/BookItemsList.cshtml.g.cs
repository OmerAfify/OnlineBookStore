#pragma checksum "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Areas\Admin\Views\AdminBookItem\BookItemsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07fed7694ddc6ef0a473779c106bf860ee6e2aab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminBookItem_BookItemsList), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminBookItem/BookItemsList.cshtml")]
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
#line 1 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineBookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineBookStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineBookStore.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07fed7694ddc6ef0a473779c106bf860ee6e2aab", @"/Areas/Admin/Views/AdminBookItem/BookItemsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7d89248ab5a2aa85b5137a91a264db578a1fe7f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminBookItem_BookItemsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BookItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminBookItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBookItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditBookItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteBookItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
            WriteLiteral(@" <!-- BEGIN: Content-->
<div class=""app-content content"">
    <div class=""content-overlay""></div>
    <div class=""header-navbar-shadow""></div>
    <div class=""content-wrapper"">
        <div class=""content-header row"">
            <div class=""content-header-left col-md-9 col-12 mb-2"">
                <div class=""row breadcrumbs-top"">
                    <div class=""col-12"">
                        <h2 class=""content-header-title float-left mb-0"">Bootstrap Tables</h2>
                        <div class=""breadcrumb-wrapper col-12"">
                            <ol class=""breadcrumb"">
                                <li class=""breadcrumb-item"">
                                    <a href=""index.html"">Home</a>
                                </li>
                                <li class=""breadcrumb-item active"">
                                    Table
                                </li>
                            </ol>
                        </div>
                    </div>
           ");
            WriteLiteral(@"     </div>
            </div>
            <div class=""content-header-right text-md-right col-md-3 col-12 d-md-block d-none"">
                <div class=""form-group breadcrum-right"">
                    <div class=""dropdown"">
                        <button class=""btn-icon btn btn-primary btn-round btn-sm dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""><i class=""feather icon-settings""></i></button>
                        <div class=""dropdown-menu dropdown-menu-right""><a class=""dropdown-item"" href=""#"">Chat</a><a class=""dropdown-item"" href=""#"">Email</a><a class=""dropdown-item"" href=""#"">Calendar</a></div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""content-body"">
            <!-- Basic Tables start -->
            <div class=""row"" id=""basic-table"">
                <div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-header"">
               ");
            WriteLiteral(@"             <h4 class=""card-title"">Books List</h4>
                        </div>
                        <div class=""card-content"">
                            <div class=""card-body"">
                                <p class=""card-text"">Here you can find the list of available books, Add a new book, delete an existing book or editing an existing book's data.</p>
                          
                          
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07fed7694ddc6ef0a473779c106bf860ee6e2aab7452", async() => {
                WriteLiteral("\r\n                                    <button class=\"btn btn-success col-12\">Add a new Book</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                      
    
    <!-- Table with outer spacing -->
                                <div class=""table-responsive"">
                                    <table class=""table"">
                                        <thead>
                                            <tr>
                                                <th>Book ID</th>
                                                <th>Books Image</th>
                                                <th>Book Name</th>
                                                <th>Sales Price</th>
                                                <th>Purchasing Price</th>
                                                <th>Category</th>
                                                <th></th>
                                                <th></th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 70 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Areas\Admin\Views\AdminBookItem\BookItemsList.cshtml"
                                             foreach (var item in Model)
                                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr>\r\n                                                    <th scope=\"row\">");
#nullable restore
#line 74 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Areas\Admin\Views\AdminBookItem\BookItemsList.cshtml"
                                                               Write(item.bookItemId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                                    <td><img");
            BeginWriteAttribute("src", " src=\"", 4038, "\"", 4126, 1);
#nullable restore
#line 75 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Areas\Admin\Views\AdminBookItem\BookItemsList.cshtml"
WriteAttributeValue("", 4044, string.Format("/UploadedFiles/Images/BookItemsImages/{0}",item.bookItemImageName), 4044, 82, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px; height:150px\"/></td>\r\n                                                    <td>");
#nullable restore
#line 76 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Areas\Admin\Views\AdminBookItem\BookItemsList.cshtml"
                                                   Write(item.bookItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 77 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Areas\Admin\Views\AdminBookItem\BookItemsList.cshtml"
                                                   Write(item.salesPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 78 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Areas\Admin\Views\AdminBookItem\BookItemsList.cshtml"
                                                   Write(item.purchasePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
#nullable restore
#line 79 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Areas\Admin\Views\AdminBookItem\BookItemsList.cshtml"
                                                   Write(item.bookCategory.bookCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07fed7694ddc6ef0a473779c106bf860ee6e2aab12915", async() => {
                WriteLiteral(" <button class=\"btn btn-primary\">Edit</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Areas\Admin\Views\AdminBookItem\BookItemsList.cshtml"
                                                                                                                      WriteLiteral(item.bookItemId);

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
            WriteLiteral("</td>\r\n                                                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07fed7694ddc6ef0a473779c106bf860ee6e2aab15505", async() => {
                WriteLiteral(" <button class=\"btn btn-danger\">Delete</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Areas\Admin\Views\AdminBookItem\BookItemsList.cshtml"
                                                                                                                        WriteLiteral(item.bookItemId);

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
            WriteLiteral("</td>\r\n                                                  \r\n                                                </tr>\r\n");
#nullable restore
#line 84 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Areas\Admin\Views\AdminBookItem\BookItemsList.cshtml"

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
                </div>
            </div>
            <!-- Basic Tables end -->

        </div>
    </div>
</div>
<!-- END: Content-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BookItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
