#pragma checksum "C:\Users\Xoe\Desktop\New folder\Luiz_Enterprise\Luiz_Enterprise\sol_Job_Bank_Part4ABC\Views\UserRoles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc178f370abb4dea3053701d0aa7414b04ac2bf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserRoles_Index), @"mvc.1.0.view", @"/Views/UserRoles/Index.cshtml")]
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
#line 1 "C:\Users\Xoe\Desktop\New folder\Luiz_Enterprise\Luiz_Enterprise\sol_Job_Bank_Part4ABC\Views\_ViewImports.cshtml"
using sol_Job_Bank;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Xoe\Desktop\New folder\Luiz_Enterprise\Luiz_Enterprise\sol_Job_Bank_Part4ABC\Views\_ViewImports.cshtml"
using sol_Job_Bank.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc178f370abb4dea3053701d0aa7414b04ac2bf5", @"/Views/UserRoles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7916f4305a193bf66d68408f5d75792728496372", @"/Views/_ViewImports.cshtml")]
    public class Views_UserRoles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<sol_Job_Bank.ViewModels.UserVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Xoe\Desktop\New folder\Luiz_Enterprise\Luiz_Enterprise\sol_Job_Bank_Part4ABC\Views\UserRoles\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>User Role Assignments</h2>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 12 "C:\Users\Xoe\Desktop\New folder\Luiz_Enterprise\Luiz_Enterprise\sol_Job_Bank_Part4ABC\Views\UserRoles\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 15 "C:\Users\Xoe\Desktop\New folder\Luiz_Enterprise\Luiz_Enterprise\sol_Job_Bank_Part4ABC\Views\UserRoles\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.userRoles));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\Xoe\Desktop\New folder\Luiz_Enterprise\Luiz_Enterprise\sol_Job_Bank_Part4ABC\Views\UserRoles\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 24 "C:\Users\Xoe\Desktop\New folder\Luiz_Enterprise\Luiz_Enterprise\sol_Job_Bank_Part4ABC\Views\UserRoles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 27 "C:\Users\Xoe\Desktop\New folder\Luiz_Enterprise\Luiz_Enterprise\sol_Job_Bank_Part4ABC\Views\UserRoles\Index.cshtml"
                  
                    foreach (var r in item.userRoles)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            WriteLiteral("  ");
#nullable restore
#line 30 "C:\Users\Xoe\Desktop\New folder\Luiz_Enterprise\Luiz_Enterprise\sol_Job_Bank_Part4ABC\Views\UserRoles\Index.cshtml"
                       Write(r);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 31 "C:\Users\Xoe\Desktop\New folder\Luiz_Enterprise\Luiz_Enterprise\sol_Job_Bank_Part4ABC\Views\UserRoles\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\Xoe\Desktop\New folder\Luiz_Enterprise\Luiz_Enterprise\sol_Job_Bank_Part4ABC\Views\UserRoles\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Xoe\Desktop\New folder\Luiz_Enterprise\Luiz_Enterprise\sol_Job_Bank_Part4ABC\Views\UserRoles\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<sol_Job_Bank.ViewModels.UserVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591