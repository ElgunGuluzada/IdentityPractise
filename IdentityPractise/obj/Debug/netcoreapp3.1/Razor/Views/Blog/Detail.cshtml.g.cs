#pragma checksum "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca69c73748b3e398b42aa7122502a0be07f35202"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
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
#line 1 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\_ViewImports.cshtml"
using IdentityPractise.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\_ViewImports.cshtml"
using IdentityPractise.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca69c73748b3e398b42aa7122502a0be07f35202", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded18a8416d2fe85ffdc096125f16fc9b51e8f13", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogDetailVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/blog/11.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("author thumb"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("widget-search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("post thumb"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog thumb"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/blog/comment-icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "deletecomment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addcomment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <!-- main wrapper start -->
    <main>
        <!-- breadcrumb area start -->
        <div class=""breadcrumb-area bg-img"" data-bg=""assets/img/banner/breadcrumb-banner.jpg"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""breadcrumb-wrap text-center"">
                            <nav aria-label=""breadcrumb"">
                                <h1 class=""breadcrumb-title"">Blog</h1>
                                <ul class=""breadcrumb"">
                                    <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                                    <li class=""breadcrumb-item""><a href=""blog-right-sidebar.html"">Blog</a></li>
                                    <li class=""breadcrumb-item active"" aria-current=""page"">Blog Details</li>
                                </ul>
                            </nav>
                        </div>
                    </div>
                <");
            WriteLiteral(@"/div>
            </div>
        </div>
        <!-- breadcrumb area end -->

        <!-- blog main wrapper start -->
        <div class=""blog-main-wrapper section-padding"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-3 order-2"">
                        <div class=""blog-widget-wrapper"">
                            <!-- widget item start -->
                            <div class=""blog-widget"">
                                <div class=""blog-widget-img"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ca69c73748b3e398b42aa7122502a0be07f352028895", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                                <div class=""blog-author-title text-center"">
                                    <h5>Erik Jhonson</h5>
                                    <span>UI UX Designer</span>
                                    <div class=""blog-widget-icon"">
                                        <a href=""#""><i class=""fa fa-facebook""></i></a>
                                        <a href=""#""><i class=""fa fa-twitter""></i></a>
                                        <a href=""#""><i class=""fa fa-vimeo""></i></a>
                                        <a href=""#""><i class=""fa fa-pinterest-p""></i></a>
                                    </div>
                                </div>
                            </div>
                            <!-- widget item end -->

                            <!-- widget item start -->
                            <div class=""blog-widget"">
                                <h4 class=""blog-widget-title"">Search</h4>
");
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca69c73748b3e398b42aa7122502a0be07f3520211116", async() => {
                WriteLiteral(@"
                                    <input placeholder=""Search keyword"" type=""text"" class=""search-field"">
                                    <button type=""submit"" class=""search-btn""><i class=""fa fa-search""></i></button>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <!-- widget item end -->

                            <!-- widget item start -->
                            <div class=""blog-widget"">
                                <h4 class=""blog-widget-title"">Recent Posts</h4>
                                <ul class=""recent-posts-inner"">
");
#nullable restore
#line 68 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
                                   foreach (var item in Model.Blogs)
                                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                       <li class=\"recent-posts\">\r\n                                        <div class=\"recent-posts-image\">\r\n                                            <a href=\"blog-details.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ca69c73748b3e398b42aa7122502a0be07f3520213570", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3796, "~/assets/img/blog/", 3796, 18, true);
#nullable restore
#line 72 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 3814, item.ImageUrl, 3814, 14, false);

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
            WriteLiteral("</a>\r\n                                        </div>\r\n                                        <div class=\"recent-posts-body\">\r\n                                            <span class=\"recent-posts-meta\">");
#nullable restore
#line 75 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
                                                                       Write(item.CrearetAt.ToString(" dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            <h6 class=\"recent-posts-title\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca69c73748b3e398b42aa7122502a0be07f3520215759", async() => {
#nullable restore
#line 76 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
                                                                                                                     Write(item.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
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
            WriteLiteral("</h6>\r\n                                            <h6 class=\"recent-posts-title\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca69c73748b3e398b42aa7122502a0be07f3520218311", async() => {
#nullable restore
#line 77 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
                                                                                                                      Write(item.Desc.Substring(0,12));

#line default
#line hidden
#nullable disable
                WriteLiteral("...");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
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
            WriteLiteral("</h6>\r\n                                        </div>\r\n                                    </li>\n");
#nullable restore
#line 80 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </ul>
                            </div>
                            <!-- widget item end -->

                            <!-- widget item start -->
                            <div class=""blog-widget"">
                                <h4 class=""blog-widget-title"">Categories</h4>
                                <ul class=""blog-categories"">
                                    <li><a href=""blog-details.html"">Shoes</a><span>(20)</span></li>
                                    <li><a href=""blog-details.html"">Fashion</a><span>(18)</span></li>
                                    <li><a href=""blog-details.html"">Wallet</a><span>(40)</span></li>
                                    <li><a href=""blog-details.html"">Life Style</a><span>(66)</span></li>
                                    <li><a href=""blog-details.html"">Electronics</a><span>(66)</span></li>
                                    <li><a href=""blog-details.html"">Jewellery & Cosmetics</a><span>(30)</span></li>
     ");
            WriteLiteral(@"                           </ul>
                            </div>
                            <!-- widget item end -->

                            <!-- widget item start -->
                            <div class=""blog-widget"">
                                <h4 class=""blog-widget-title"">Tags</h4>
                                <div class=""blog-tag"">
                                    <a href=""blog-details.html"">Fashion</a>
                                    <a href=""blog-details.html"">Shoes</a>
                                    <a href=""blog-details.html"">Wallet</a>
                                    <a href=""blog-details.html"">Bags</a>
                                    <a href=""blog-details.html"">Jewelery</a>
                                </div>
                            </div>
                            <!-- widget item end -->
                        </div>
                    </div>
                    <div class=""col-lg-9 order-1"">
                        <div class=""");
            WriteLiteral(@"row"">
                            <div class=""col-12"">
                                <!-- blog single item start -->
                                <div class=""blog-post-item"">
                                    <div class=""blog-thumb"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ca69c73748b3e398b42aa7122502a0be07f3520223606", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6877, "~/assets/img/blog/", 6877, 18, true);
#nullable restore
#line 119 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 6895, Model.Blog.ImageUrl, 6895, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"blog-content blog-details\">\r\n                                        <h5 class=\"blog-title\">\r\n                                            ");
#nullable restore
#line 123 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
                                       Write(Model.Blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </h5>
                                        <ul class=""blog-meta"">
                                            <li><span>By: </span>Admin,</li>
                                            <li><span>On: </span>");
#nullable restore
#line 127 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
                                                            Write(Model.Blog.CrearetAt.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        </ul>\r\n                                       \r\n                                        <p>\r\n                                            ");
#nullable restore
#line 131 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
                                       Write(Model.Blog.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </p>
                                    </div>
                                </div>
                                <!-- blog single item start -->

                                <!-- comment area start -->
                            <div class=""comment-section section-padding"">
                                <h5>");
#nullable restore
#line 139 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
                               Write(Model.Blog.Comments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Comment</h5>\r\n                                <ul>\r\n");
#nullable restore
#line 141 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
                                 foreach (var item in Model.Blog.Comments)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li>\r\n                                        <div class=\"author-avatar\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ca69c73748b3e398b42aa7122502a0be07f3520227865", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"comment-body\">\r\n");
#nullable restore
#line 148 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
                                                   if(item.AppUserId== ViewBag.AppUserId){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                       <span class=\"reply-btn\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca69c73748b3e398b42aa7122502a0be07f3520229469", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 149 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
                                                                                                               WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 149 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
                                                                                                                                           WriteLiteral(Model.Blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["BlogId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-BlogId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["BlogId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</span>\r\n");
#nullable restore
#line 150 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                         \r\n                                            <h5 class=\"comment-author\">Admin</h5>\r\n                                            <div class=\"comment-post-date\">\r\n                                               ");
#nullable restore
#line 154 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
                                          Write(item.CreatetAt.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                            <p>");
#nullable restore
#line 156 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
                                          Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </li>\n");
#nullable restore
#line 159 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </ul>
                            </div>
                            <!-- comment area end -->
    
                            <!-- start blog comment box -->
                            <div class=""blog-comment-wrapper"">
                                <h5>Leave A Reply</h5>
                                <p>Email address will not be published. Required fields are marked *</p>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca69c73748b3e398b42aa7122502a0be07f3520234456", async() => {
                WriteLiteral(@"
                                    <div class=""comment-post-box"">
                                        <div class=""row"">
                                            <div class=""col-12"">
                                                <label>Comment</label>
                                                <textarea name=""Message"" placeholder=""Write a comment""></textarea>
                                                <input  type=""hidden"" name=""BlogId""");
                BeginWriteAttribute("value", " value=\"", 10387, "\"", 10409, 1);
#nullable restore
#line 174 "C:\Users\User\Desktop\IdentityPractise\IdentityPractise\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 10395, Model.Blog.Id, 10395, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/>
                                            </div>
                                          
                                            <div class=""col-12"">
                                                <div class=""coment-btn"">
                                                    <input class=""btn"" type=""submit"" name=""submit"" value=""POST COMMENT"">
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <!-- start blog comment box -->
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- blog main wrapper end -->
    </main>
    <!-- main wrapper end -->

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogDetailVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
