#pragma checksum "C:\Users\Kenan\source\repos\oxu.az\oxu.az\Views\Home\_HomePassPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6eb10edbe8f869c871bd30e4c456b31e62ec95a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__HomePassPartial), @"mvc.1.0.view", @"/Views/Home/_HomePassPartial.cshtml")]
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
#line 1 "C:\Users\Kenan\source\repos\oxu.az\oxu.az\Views\_ViewImports.cshtml"
using oxu.az;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kenan\source\repos\oxu.az\oxu.az\Views\_ViewImports.cshtml"
using oxu.az.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eb10edbe8f869c871bd30e4c456b31e62ec95a0", @"/Views/Home/_HomePassPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e62fc99f9a6a7239d02db072078bdd01319bfc78", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__HomePassPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<oxu.az.Models.News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 4 "C:\Users\Kenan\source\repos\oxu.az\oxu.az\Views\Home\_HomePassPartial.cshtml"
     foreach (var News in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-12 col-md-6 col-lg-4 pt-4\">\r\n            <div class=\"news-item\"");
            BeginWriteAttribute("id", " id=\"", 182, "\"", 195, 1);
#nullable restore
#line 7 "C:\Users\Kenan\source\repos\oxu.az\oxu.az\Views\Home\_HomePassPartial.cshtml"
WriteAttributeValue("", 187, News.Id, 187, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 217, "\"", 270, 1);
#nullable restore
#line 8 "C:\Users\Kenan\source\repos\oxu.az\oxu.az\Views\Home\_HomePassPartial.cshtml"
WriteAttributeValue("", 224, Url.Action("News","Home",new {Id = News.Id }), 224, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"item-photo position-relative\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6eb10edbe8f869c871bd30e4c456b31e62ec95a04660", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 372, "~/images/", 372, 9, true);
#nullable restore
#line 10 "C:\Users\Kenan\source\repos\oxu.az\oxu.az\Views\Home\_HomePassPartial.cshtml"
AddHtmlAttributeValue("", 381, News.FileName, 381, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 10 "C:\Users\Kenan\source\repos\oxu.az\oxu.az\Views\Home\_HomePassPartial.cshtml"
AddHtmlAttributeValue("", 402, News.FileName, 402, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"when position-absolute\">\r\n                            <div class=\"date\">\r\n                                <p>");
#nullable restore
#line 13 "C:\Users\Kenan\source\repos\oxu.az\oxu.az\Views\Home\_HomePassPartial.cshtml"
                              Write(News.CreationTime.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 14 "C:\Users\Kenan\source\repos\oxu.az\oxu.az\Views\Home\_HomePassPartial.cshtml"
                                  
                                    String monthName = Microsoft.VisualBasic.DateAndTime.MonthName(News.CreationTime.Month).Substring(0, 3);
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>");
#nullable restore
#line 17 "C:\Users\Kenan\source\repos\oxu.az\oxu.az\Views\Home\_HomePassPartial.cshtml"
                              Write(monthName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"time\">\r\n                                <p>");
#nullable restore
#line 20 "C:\Users\Kenan\source\repos\oxu.az\oxu.az\Views\Home\_HomePassPartial.cshtml"
                              Write(News.CreationTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"item-title\">\r\n                        ");
#nullable restore
#line 26 "C:\Users\Kenan\source\repos\oxu.az\oxu.az\Views\Home\_HomePassPartial.cshtml"
                   Write(News.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </a>
                <div class=""item-stats"">
                    <div class=""row"">
                        <div class=""col-4 pr-0  text-center"">
                            <div class=""like pt-2 pb-2"">
                                <i class=""fas fa-thumbs-up""></i>
                                <span>");
#nullable restore
#line 34 "C:\Users\Kenan\source\repos\oxu.az\oxu.az\Views\Home\_HomePassPartial.cshtml"
                                 Write(News.Like);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                        </div>
                        <div class=""col-4 pl-0 pr-0 text-center"">
                            <div class=""unlike  pt-2 pb-2"">
                                <i class=""fas fa-thumbs-down""></i>
                                <span>");
#nullable restore
#line 40 "C:\Users\Kenan\source\repos\oxu.az\oxu.az\Views\Home\_HomePassPartial.cshtml"
                                 Write(News.Unlike);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </div>
                        </div>
                        <div class=""col-4 pl-0 text-center"">
                            <div class=""view  pt-2 pb-2"">
                                <i class=""fas fa-eye""></i>
                                <span>");
#nullable restore
#line 46 "C:\Users\Kenan\source\repos\oxu.az\oxu.az\Views\Home\_HomePassPartial.cshtml"
                                 Write(News.View);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 53 "C:\Users\Kenan\source\repos\oxu.az\oxu.az\Views\Home\_HomePassPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<oxu.az.Models.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
