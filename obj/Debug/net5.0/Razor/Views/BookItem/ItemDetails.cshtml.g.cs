#pragma checksum "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\BookItem\ItemDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a464be7ae4c4122f2c9f9570c204ef0273a718ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookItem_ItemDetails), @"mvc.1.0.view", @"/Views/BookItem/ItemDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a464be7ae4c4122f2c9f9570c204ef0273a718ed", @"/Views/BookItem/ItemDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7d89248ab5a2aa85b5137a91a264db578a1fe7f", @"/Views/_ViewImports.cshtml")]
    public class Views_BookItem_ItemDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DetailsPageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/WebsiteAssets/images/icon/visa.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/WebsiteAssets/images/icon/mastercard.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/WebsiteAssets/images/icon/paypal.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/WebsiteAssets/images/icon/american-express.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/WebsiteAssets/images/icon/discover.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-solid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_xsmallBookItemBox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <!-- breadcrumb start -->
    <div class=""breadcrumb-section"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <div class=""page-title"">
                        <h2>product</h2>
                    </div>
                </div>
                <div class=""col-sm-6"">
                    <nav aria-label=""breadcrumb"" class=""theme-breadcrumb"">
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                            <li class=""breadcrumb-item active"" aria-current=""page"">product</li>
                        </ol>
                    </nav>
                </div>
            </div>
        </div>
    </div>
    <!-- breadcrumb End -->

    <!-- section start -->
    <section>
        <div class=""collection-wrapper"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-");
            WriteLiteral("lg-4\">\r\n                        <div class=\"product-slick\">\r\n");
            WriteLiteral("                            <div>\r\n                                 <img");
            BeginWriteAttribute("src", " src=\"", 1247, "\"", 1345, 1);
#nullable restore
#line 34 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\BookItem\ItemDetails.cshtml"
WriteAttributeValue("", 1253, string.Format("/UploadedFiles/Images/BookItemsImages/{0}",Model.bookItem.bookItemImageName), 1253, 92, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1346, "\"", 1352, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                                     class=""img-fluid blur-up lazyload image_zoom_cls-0"">
                            </div>
 


                        </div>
                        <div class=""row"">
                            <div class=""col-12 p-0"">

");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-4\">\r\n                        <div class=\"product-right product-description-box\">\r\n                            <h2>");
#nullable restore
#line 71 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\BookItem\ItemDetails.cshtml"
                           Write(Model.bookItem.bookItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                            <div class=""border-product"">
                                <h6 class=""product-title"">Book''s details</h6>
                                <p>
                                    Sed ut perspiciatis, unde omnis iste natus error sit voluptatem accusantium
                                    doloremque laudantium, totam rem aperiam eaque ipsa, quae ab illo inventore
                                    veritatis et quasi architecto beatae vitae dicta sunt, explicabo. Nemo enim ipsam
                                    voluptatem,
                                </p>
                            </div>
                            <div class=""single-product-tables border-product detail-section"">
                                <table>
                                    <tbody>
                                        <tr>
                                            <td>Category:</td>
                                            <td>");
#nullable restore
#line 86 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\BookItem\ItemDetails.cshtml"
                                           Write(Model.bookItem.bookCategory.bookCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                        </tr>
                                        <tr>
                                            <td>Author:</td>
                                            <td>authnamevalue</td>
                                        </tr>
                                        <tr>
                                            <td>Collection:</td>
                                            <td>collectionname</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                            <div class=""border-product"">
                                <h6 class=""product-title"">share it</h6>
                                <div class=""product-icon"">
                                    <ul class=""product-social"">
                                        <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                                        <l");
            WriteLiteral(@"i><a href=""#""><i class=""fa fa-google-plus""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-instagram""></i></a></li>
                                        <li><a href=""#""><i class=""fa fa-rss""></i></a></li>
                                    </ul>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a464be7ae4c4122f2c9f9570c204ef0273a718ed13374", async() => {
                WriteLiteral(@"
                                        <button class=""wishlist-btn"">
                                            <i class=""fa fa-heart""></i><span class=""title-font"">Add To WishList</span>
                                        </button>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""border-product"">
                                <h6 class=""product-title"">100% SECURE PAYMENT</h6>
                                <div class=""payment-card-bottom"">
                                    <ul>
                                        <li>
                                            <a href=""#"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a464be7ae4c4122f2c9f9570c204ef0273a718ed15408", async() => {
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
            WriteLiteral("</a>\r\n                                        </li>\r\n                                        <li>\r\n                                            <a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a464be7ae4c4122f2c9f9570c204ef0273a718ed16682", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                        </li>\r\n                                        <li>\r\n                                            <a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a464be7ae4c4122f2c9f9570c204ef0273a718ed17956", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                        </li>\r\n                                        <li>\r\n                                            <a href=\"#\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a464be7ae4c4122f2c9f9570c204ef0273a718ed19282", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </a>\r\n                                        </li>\r\n                                        <li>\r\n                                            <a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a464be7ae4c4122f2c9f9570c204ef0273a718ed20604", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-4"">
                        <div class=""product-right product-form-box"">
                   
                            <h3>");
#nullable restore
#line 146 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\BookItem\ItemDetails.cshtml"
                           Write(Model.bookItem.purchasePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" EGP</h3>
                            <ul class=""color-variant"">
                                <li class=""bg-light0""></li>
                                <li class=""bg-light1""></li>
                                <li class=""bg-light2""></li>
                            </ul>
                            <div class=""product-description border-product"">
                              
                                <h6 class=""product-title"">quantity</h6>
                                <div class=""qty-box"">
                                    <div class=""input-group"">
                                        <span class=""input-group-prepend"">
                                            <button type=""button""
                                                    class=""btn quantity-left-minus"" data-type=""minus"" data-field="""">
                                                <i class=""ti-angle-left""></i>
                                            </button>
                                        </s");
            WriteLiteral(@"pan>
                                        <input type=""text"" name=""quantity"" class=""form-control input-number"" value=""1"">
                                        <span class=""input-group-prepend"">
                                            <button type=""button""
                                                    class=""btn quantity-right-plus"" data-type=""plus"" data-field="""">
                                                <i class=""ti-angle-right""></i>
                                            </button>
                                        </span>
                                    </div>
                                </div>
                            </div>
                            <div class=""product-buttons"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a464be7ae4c4122f2c9f9570c204ef0273a718ed24291", async() => {
                WriteLiteral("add to cart");
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
#line 174 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\BookItem\ItemDetails.cshtml"
                                                                                          WriteLiteral(Model.bookItem.bookItemId);

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
            WriteLiteral(@"
                                <a href=""#"" class=""btn btn-solid"">buy now</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Section ends -->

    <!-- product-tab starts -->
    <section class=""tab-product m-0"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-sm-12 col-lg-12"">
                    <ul class=""nav nav-tabs nav-material"" id=""top-tab"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" id=""top-home-tab"" data-toggle=""tab""
                               href=""#top-home"" role=""tab"" aria-selected=""true"">Long Description</a>
                            <div class=""material-border""></div>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" id=""profile-top-tab"" data-toggle=""t");
            WriteLiteral(@"ab""
                               href=""#top-profile"" role=""tab"" aria-selected=""false"">Details</a>
                            <div class=""material-border""></div>
                        </li>
          
                    </ul>
                    <div class=""tab-content nav-material"" id=""top-tabContent"">
                        <div class=""tab-pane fade show active"" id=""top-home"" role=""tabpanel""
                             aria-labelledby=""top-home-tab"">
                            <p>
                                Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum
                                has been the industry's standard dummy text ever since the 1500s, when an unknown
                                printer took a galley of type and scrambled it to make a type specimen book. It has
                                survived not only five centuries, but also the leap into electronic typesetting,
                                remaining essentiall");
            WriteLiteral(@"y unchanged. It was popularised in the 1960s with the release of
                                Letraset sheets containing Lorem Ipsum passages, and more recently with desktop
                                publishing software like Aldus PageMaker including versions of Lorem Ipsum. Lorem Ipsum
                                is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the
                                industry's standard dummy text ever since the 1500s, when an unknown printer took a
                                galley of type and scrambled it to make a type specimen book. It has survived not only
                                five centuries, but also the leap into electronic typesetting, remaining essentially
                                unchanged. It was popularised in the 1960s with the release of Letraset sheets
                                containing Lorem Ipsum passages, and more recently with desktop publishing software like
              ");
            WriteLiteral(@"                  Aldus PageMaker including versions of Lorem Ipsum.
                            </p>
                        </div>
                        <div class=""tab-pane fade"" id=""top-profile"" role=""tabpanel"" aria-labelledby=""profile-top-tab"">
                            <p>
                                Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum
                                has been the industry's standard dummy text ever since the 1500s, when an unknown
                                printer took a galley of type and scrambled it to make a type specimen book. It has
                                survived not only five centuries, but also the leap into electronic typesetting,
                                remaining essentially unchanged. It was popularised in the 1960s with the release of
                                Letraset sheets containing Lorem Ipsum passages, and more recently with desktop
                                publis");
            WriteLiteral(@"hing software like Aldus PageMaker including versions of Lorem Ipsum.
                            </p>
                            <div class=""single-product-tables"">
                                <table>
                                    <tbody>
                                        <tr>
                                            <td>Febric</td>
                                            <td>Chiffon</td>
                                        </tr>
                                        <tr>
                                            <td>Color</td>
                                            <td>Red</td>
                                        </tr>
                                        <tr>
                                            <td>Material</td>
                                            <td>Crepe printed</td>
                                        </tr>
                                    </tbody>
                                </table>
                             ");
            WriteLiteral(@"   <table>
                                    <tbody>
                                        <tr>
                                            <td>Length</td>
                                            <td>50 Inches</td>
                                        </tr>
                                        <tr>
                                            <td>Size</td>
                                            <td>S, M, L .XXL</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                         </div>
                </div>
            </div>
        </div>
    </section>
    <!-- product-tab ends -->
    <!-- product section start -->
    <section class=""section-b-space ratio_asos"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12 product-related"">
                    <h2>relate");
            WriteLiteral("d products</h2>\r\n                </div>\r\n            </div>\r\n\r\n                <div class=\"row search-product\">\r\n");
#nullable restore
#line 281 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\BookItem\ItemDetails.cshtml"
                     foreach (var relatedItem in Model.relatedBookItems)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a464be7ae4c4122f2c9f9570c204ef0273a718ed33706", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
#nullable restore
#line 283 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\BookItem\ItemDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = relatedItem;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 284 "D:\6-Programming and courses\New Projects\Asp.net Core\OnlineBookStore\Views\BookItem\ItemDetails.cshtml"
                        
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            \r\n            </div>\r\n</section>\r\n    <!-- product section end -->\r\n  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailsPageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
