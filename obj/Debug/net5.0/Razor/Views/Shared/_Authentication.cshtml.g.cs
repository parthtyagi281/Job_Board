#pragma checksum "C:\Job-Board-master\Views\Shared\_Authentication.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4d83e0929b16ead63bcd1f653550e9beb6b50987066a975291b8b4bfc4fb5756"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Authentication), @"mvc.1.0.view", @"/Views/Shared/_Authentication.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4d83e0929b16ead63bcd1f653550e9beb6b50987066a975291b8b4bfc4fb5756", @"/Views/Shared/_Authentication.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c2b12eaf9d4e7a0bc3208ffa8dc78f8a03ae26803a70693ea1426c5bc297e1e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Authentication : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Job-Board-master\Views\Shared\_Authentication.cshtml"
 if (User.Identity.IsAuthenticated)
{




#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"main-menu  d-none d-lg-block\">\n            <ul id=\"navigation\">\n                <li>\n");
#nullable restore
#line 9 "C:\Job-Board-master\Views\Shared\_Authentication.cshtml"
                     if (!User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a href=\"/Profile\"> Profile <i class=\"ti-angle-down\"></i></a>\n                        <ul class=\"submenu\">\n");
#nullable restore
#line 13 "C:\Job-Board-master\Views\Shared\_Authentication.cshtml"
                             if (User.IsInRole("Developer"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a href=\"/Job/AppliedJobs\">Applied Jobs</a></li>\n");
#nullable restore
#line 16 "C:\Job-Board-master\Views\Shared\_Authentication.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a href=\"/Job/MyJobs\">Posted Jobs</a></li>\n");
#nullable restore
#line 20 "C:\Job-Board-master\Views\Shared\_Authentication.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <hr style=""margin: 0px"">
                            <li><a href=""/Profile/Settings"">Settings </a></li>
                            <hr style=""margin: 0px"">
                            <li><a href=""/Account/Logout"">Log out</a></li>
                        </ul>
");
#nullable restore
#line 26 "C:\Job-Board-master\Views\Shared\_Authentication.cshtml"
                }
                else { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"/Admin\"> Profile <i class=\"ti-angle-down\"></i></a>\n");
#nullable restore
#line 29 "C:\Job-Board-master\Views\Shared\_Authentication.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </li>\n            </ul>\n    </div>\n");
#nullable restore
#line 34 "C:\Job-Board-master\Views\Shared\_Authentication.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"phone_num d-none d-xl-block\">\n        <a href=\"/Account/Login\">Log in</a>\n    </div>\n");
#nullable restore
#line 40 "C:\Job-Board-master\Views\Shared\_Authentication.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
