#pragma checksum "C:\Job-Board-master\Views\Admin\Categories.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5f7af3ffd079883297cbd62c72ed553411610cb04ad2016c580f9eeb4f85b21d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Categories), @"mvc.1.0.view", @"/Views/Admin/Categories.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Job-Board-master\Views\_ViewImports.cshtml"
using Job_Board;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Job-Board-master\Views\_ViewImports.cshtml"
using Job_Board.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Job-Board-master\Views\_ViewImports.cshtml"
using Job_Board.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Job-Board-master\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5f7af3ffd079883297cbd62c72ed553411610cb04ad2016c580f9eeb4f85b21d", @"/Views/Admin/Categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c2b12eaf9d4e7a0bc3208ffa8dc78f8a03ae26803a70693ea1426c5bc297e1e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PopolarCategoriesViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/Categories"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Job-Board-master\Views\Admin\Categories.cshtml"
  
    ViewData["Title"] = "Categories";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"" style=""margin: 60px 0px;"">
    <div class=""popular_catagory_area col-lg-12"" style=""padding: 0px;"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""section_title mb-40"">
                        <h3>Categories</h3>
                    </div>
                </div>
            </div>

            <div class=""row"" style=""margin-bottom: 4%;"">
                <div class=""col-lg-12"">
                    <div class=""job_filter white-bg"" style=""padding: 30px 20px 30px 20px;"">
                        <div class=""form_inner white-bg"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f7af3ffd079883297cbd62c72ed553411610cb04ad2016c580f9eeb4f85b21d5181", async() => {
                WriteLiteral(@"
                                <div class=""row"">
                                    <div class=""col-lg-12"">
                                        <div class=""single_field"">
                                            <input type=""text"" placeholder=""Add New Category"" class=""form-control"" style=""width: 100%;height: 60px;margin-bottom: 20px;"">
                                        </div>
                                    </div>
                                </div>
                                ");
#nullable restore
#line 28 "C:\Job-Board-master\Views\Admin\Categories.cshtml"
                           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                <button class=\"boxed-btn3 w-100\" type=\"submit\">ADD</button>\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n            </div>\n\n            <div class=\"row\">\n");
#nullable restore
#line 37 "C:\Job-Board-master\Views\Admin\Categories.cshtml"
                 foreach (var item in Model) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-xl-3 col-md-6\">\n                    <div class=\"single_catagory\">\n                        <a href=\"href=\"/");
            BeginWriteAttribute("Job/Search?_category", "Job/Search?_category=", 1792, "", 1823, 1);
#nullable restore
#line 40 "C:\Job-Board-master\Views\Admin\Categories.cshtml"
WriteAttributeValue("", 1813, item.Name, 1813, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\"\"><h4>");
#nullable restore
#line 40 "C:\Job-Board-master\Views\Admin\Categories.cshtml"
                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></a>\n                        <p> <span>");
#nullable restore
#line 41 "C:\Job-Board-master\Views\Admin\Categories.cshtml"
                             Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> Available position</p>\n                    </div>\n                </div>\n");
#nullable restore
#line 44 "C:\Job-Board-master\Views\Admin\Categories.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".single_catagory"").fadeIn(600);  
            $(""form"").on(""submit"", function (e) {
                e.preventDefault();
                $(""form .form-control"").select();
                var name = $(""form .form-control"").val();
                var token = $(""form input[name='__RequestVerificationToken']"").val();
                var container = $("".categories-container"");
                var Category = '<div class=""col-lg-4 col-xl-3 col-md-6""><div class=""single_catagory""><h4>' + name + '</h4><p> <span>0</span> Available position</p></div></div>';

                console.log(name);
                console.log(token);

                $.ajax({
                    url: ""/Api/Category"",
                    method: ""POST"",
                    headers: { ""X-CSRF-TOKEN"": token },
                    data: { ""Name"": name },
                    success: function (data, status) {
                        console.log(status)
                        cons");
                WriteLiteral(@"ole.log(Category)
                        console.log(container)
                        container.append(Category);
                    },
                    error: function (data, status, fx) {
                        alert(""Failed"");
                        console.log(status);
                    }
                });


            })
        })
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PopolarCategoriesViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
