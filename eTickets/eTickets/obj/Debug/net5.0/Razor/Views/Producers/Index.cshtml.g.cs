#pragma checksum "C:\Users\User\Documents\GitHub\ASP.NET-Cinema-Booking\eTickets\eTickets\Views\Producers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69746a7a919efa107325a174df4e3fbe4a89ad85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producers_Index), @"mvc.1.0.view", @"/Views/Producers/Index.cshtml")]
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
#line 1 "C:\Users\User\Documents\GitHub\ASP.NET-Cinema-Booking\eTickets\eTickets\Views\_ViewImports.cshtml"
using eTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Documents\GitHub\ASP.NET-Cinema-Booking\eTickets\eTickets\Views\_ViewImports.cshtml"
using eTickets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69746a7a919efa107325a174df4e3fbe4a89ad85", @"/Views/Producers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae36ea9afdbf4434090466b2ad951861827cd6f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Producers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Producer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\User\Documents\GitHub\ASP.NET-Cinema-Booking\eTickets\eTickets\Views\Producers\Index.cshtml"
  
    ViewData["Title"] = "List of Producers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-8 offset-md-2\">\r\n\r\n        <table class=\"table\">\r\n            <thead>\r\n                <tr class=\"text-center\">\r\n                    <th>");
#nullable restore
#line 16 "C:\Users\User\Documents\GitHub\ASP.NET-Cinema-Booking\eTickets\eTickets\Views\Producers\Index.cshtml"
                   Write(Html.DisplayNameFor(Model => Model.ProfilePictureUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 17 "C:\Users\User\Documents\GitHub\ASP.NET-Cinema-Booking\eTickets\eTickets\Views\Producers\Index.cshtml"
                   Write(Html.DisplayNameFor(Model => Model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 18 "C:\Users\User\Documents\GitHub\ASP.NET-Cinema-Booking\eTickets\eTickets\Views\Producers\Index.cshtml"
                   Write(Html.DisplayNameFor(Model => Model.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n            </thead>\r\n\r\n            <tbody>\r\n");
#nullable restore
#line 24 "C:\Users\User\Documents\GitHub\ASP.NET-Cinema-Booking\eTickets\eTickets\Views\Producers\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"align-middle\">\r\n                            <img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 832, "\"", 861, 1);
#nullable restore
#line 28 "C:\Users\User\Documents\GitHub\ASP.NET-Cinema-Booking\eTickets\eTickets\Views\Producers\Index.cshtml"
WriteAttributeValue("", 838, item.ProfilePictureUrl, 838, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 862, "\"", 882, 1);
#nullable restore
#line 28 "C:\Users\User\Documents\GitHub\ASP.NET-Cinema-Booking\eTickets\eTickets\Views\Producers\Index.cshtml"
WriteAttributeValue("", 868, item.FullName, 868, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style-\"max-width: 150px\" />\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 31 "C:\Users\User\Documents\GitHub\ASP.NET-Cinema-Booking\eTickets\eTickets\Views\Producers\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
#nullable restore
#line 34 "C:\Users\User\Documents\GitHub\ASP.NET-Cinema-Booking\eTickets\eTickets\Views\Producers\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>
                        <td class=""align-middle"">
                            <a class=""btn btn-outline-primary""><i class=""bi bi-pencil-square""></i>Edit </a> |
                            <a class=""btn btn-outline-info""><i class=""bi bi-eye""></i>Details </a> |
                            <a class=""btn btn-danger text-white""><i class=""bi bi-trash""></i>Delete </a>

                        </td>

                    </tr>
");
#nullable restore
#line 44 "C:\Users\User\Documents\GitHub\ASP.NET-Cinema-Booking\eTickets\eTickets\Views\Producers\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n\r\n\r\n        </table>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Producer>> Html { get; private set; }
    }
}
#pragma warning restore 1591