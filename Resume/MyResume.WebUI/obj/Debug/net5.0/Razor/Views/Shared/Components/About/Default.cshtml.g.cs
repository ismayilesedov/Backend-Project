#pragma checksum "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "817ccbe1ad8db8a8006320700abaf6e1f4b0f695"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_About_Default), @"mvc.1.0.view", @"/Views/Shared/Components/About/Default.cshtml")]
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
#line 4 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.BlogPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.ContactPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.Domain.AppCode.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.Domain.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\_ViewImports.cshtml"
using MyResume.WebUI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"817ccbe1ad8db8a8006320700abaf6e1f4b0f695", @"/Views/Shared/Components/About/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1707a7370f603cc1805447dc8807fd84c1850f01", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_About_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<About>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<ul class=\"personal-info\">\n    <li>\n        <p> <span> Name</span>");
#nullable restore
#line 6 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                         Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </li>\n    <li>\n        <p> <span> Age</span>");
#nullable restore
#line 9 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                        Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </li>\n    <li>\n        <p>\n");
#nullable restore
#line 13 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
             if (@Model.Location == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span></span>\n");
#nullable restore
#line 16 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span> Location</span>\n");
#nullable restore
#line 20 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 22 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
       Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n\n    </li>\n    <li>\n        <p> <span> Experience</span>");
#nullable restore
#line 27 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                               Write(Model.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n    </li>\n    <li>\n        <p> <span> Degree</span> ");
#nullable restore
#line 30 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                            Write(Model.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </li>\n    <li>\n        <p> <span> Career Level</span>");
#nullable restore
#line 33 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                                 Write(Model.CareerLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </li>\n    <li>\n        <p> <span> Phone</span>");
#nullable restore
#line 36 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                          Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </li>\n    <li>\n        <p> <span> FAX</span>");
#nullable restore
#line 39 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                        Write(Model.Fax);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n    </li>\n    <li>\n        <p> <span> E-mail</span> <a href=\"#.\"></a> ");
#nullable restore
#line 42 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                                              Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </li>\n    <li>\n        <p>\n");
#nullable restore
#line 46 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
             if (@Model.Website == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span></span>\n");
#nullable restore
#line 49 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span> Website</span>\n");
#nullable restore
#line 53 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <a href=\"#.\"></a>");
#nullable restore
#line 55 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\About\Default.cshtml"
                        Write(Model.Website);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </li>\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<About> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591