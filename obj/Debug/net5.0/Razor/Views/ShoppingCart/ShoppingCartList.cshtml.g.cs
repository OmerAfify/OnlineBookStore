#pragma checksum "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\ShoppingCart\ShoppingCartList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51a86da4211fb96c6c12c2bd3456c01159dea597"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_ShoppingCartList), @"mvc.1.0.view", @"/Views/ShoppingCart/ShoppingCartList.cshtml")]
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
#line 1 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\_ViewImports.cshtml"
using OnlineBookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\_ViewImports.cshtml"
using OnlineBookStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\_ViewImports.cshtml"
using OnlineBookStore.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51a86da4211fb96c6c12c2bd3456c01159dea597", @"/Views/ShoppingCart/ShoppingCartList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7d89248ab5a2aa85b5137a91a264db578a1fe7f", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_ShoppingCartList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCart>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-solid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral(@"

    <!-- breadcrumb start -->
    <div class=""breadcrumb-section"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <div class=""page-title"">
                        <h2>cart</h2>
                    </div>
                </div>
                <div class=""col-sm-6"">
                    <nav aria-label=""breadcrumb"" class=""theme-breadcrumb"">
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                            <li class=""breadcrumb-item active"">cart</li>
                        </ol>
                    </nav>
                </div>
            </div>
        </div>
    </div>
    <!-- breadcrumb End -->
    <!--section start-->
    <section class=""cart-section section-b-space"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-sm-12"">
                    <table class=""ta");
            WriteLiteral(@"ble cart-table table-responsive-xs"">
                        <thead>
                            <tr class=""table-head"">
                                <th scope=""col"">image</th>
                                <th scope=""col"">book name</th>
                                <th scope=""col"">price</th>
                                <th scope=""col"">quantity</th>
                                <th scope=""col"">action</th>
                                <th scope=""col"">total</th>
                            </tr>
                        </thead>
                        <tbody>
                            <!--<tr> is a single product-->
");
#nullable restore
#line 44 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\ShoppingCart\ShoppingCartList.cshtml"
                         foreach(var cartitem in Model.cartItemList) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                         <tr>\r\n                            <td>\r\n                               <a href=\"#\"><img");
            BeginWriteAttribute("src", " src=\"", 1886, "\"", 1987, 1);
#nullable restore
#line 47 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\ShoppingCart\ShoppingCartList.cshtml"
WriteAttributeValue("", 1892, string.Format("/UploadedFiles/Images/BookItemsImages/{0}",cartitem.bookItem.bookItemImageName), 1892, 95, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1988, "\"", 1994, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                            </td>\r\n                            <td>\r\n                               <a href=\"#\">");
#nullable restore
#line 50 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\ShoppingCart\ShoppingCartList.cshtml"
                                      Write(cartitem.bookItem.bookItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        \r\n                            </td>\r\n                            <td>\r\n                                <h2>");
#nullable restore
#line 54 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\ShoppingCart\ShoppingCartList.cshtml"
                               Write(cartitem.bookItem.purchasePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" EGP</h2>
                            </td>
                            <td>
                                <div class=""qty-box"">
                                    <div class=""input-group"">
                                        <input type=""number"" data-ItemsPrice=""");
#nullable restore
#line 59 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\ShoppingCart\ShoppingCartList.cshtml"
                                                                         Write(cartitem.bookItem.purchasePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" name=\"quantity\" class=\"form-control input-number\"");
            BeginWriteAttribute("value", " value=\"", 2673, "\"", 2703, 1);
#nullable restore
#line 59 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\ShoppingCart\ShoppingCartList.cshtml"
WriteAttributeValue("", 2681, cartitem.itemQuantity, 2681, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                </div>\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51a86da4211fb96c6c12c2bd3456c01159dea59710307", async() => {
                WriteLiteral("\r\n                                    <i class=\"ti-close\"></i>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\ShoppingCart\ShoppingCartList.cshtml"
                                                                                               WriteLiteral(cartitem.bookItemId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <h2 class=\"td-color\">");
#nullable restore
#line 69 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\ShoppingCart\ShoppingCartList.cshtml"
                                                Write(cartitem.totalItemPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 72 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\ShoppingCart\ShoppingCartList.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </tbody>
                        </table>
                    <table class=""table cart-table table-responsive-md"">
                        <tfoot>
                            <tr>
                                <td>total Quantity :</td>
                                <td>
                                    <h2 >");
#nullable restore
#line 81 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\ShoppingCart\ShoppingCartList.cshtml"
                                    Write(Model.totalCartQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td>total price :</td>\r\n                                <td>\r\n                                    <h2>");
#nullable restore
#line 87 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\ShoppingCart\ShoppingCartList.cshtml"
                                   Write(Model.totalCartPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" EGP</h2>
                                </td>
                            </tr>
                        </tfoot>
                    </table>
                </div>
            </div>
            <div class=""row cart-buttons"">
                <div class=""col-6"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51a86da4211fb96c6c12c2bd3456c01159dea59715187", async() => {
                WriteLiteral("continue shopping");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                <div class=\"col-6\"><a href=\"#\" class=\"btn btn-solid\">check out</a></div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!--section end-->\r\n \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCart> Html { get; private set; }
    }
}
#pragma warning restore 1591
