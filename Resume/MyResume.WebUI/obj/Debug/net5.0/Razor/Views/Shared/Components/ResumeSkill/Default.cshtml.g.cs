#pragma checksum "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d22af16234a5a13417dccc80ec836ddce9b10df9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ResumeSkill_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ResumeSkill/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d22af16234a5a13417dccc80ec836ddce9b10df9", @"/Views/Shared/Components/ResumeSkill/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1707a7370f603cc1805447dc8807fd84c1850f01", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ResumeSkill_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ResumeCategory>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h6>");
#nullable restore
#line 6 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n");
#nullable restore
#line 8 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
     foreach (var skill in item.ResumeSkills)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
         if (skill.View == null)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""panel-group accordion"" id=""accordion5"">
                <div class=""panel panel-default"">
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <!-- PANEL HEADING -->
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a data-toggle=""collapse""
                           data-parent=""#accordion-");
#nullable restore
#line 21 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
                                              Write(skill.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("href", "\n                           href=\"", 675, "\"", 730, 3);
            WriteAttributeValue("", 709, "#collapse-", 709, 10, true);
#nullable restore
#line 22 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
WriteAttributeValue("", 719, skill.Id, 719, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 728, "-5", 728, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"collapsed\" aria-expanded=\"false\">\n                                        ");
#nullable restore
#line 23 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
                                   Write(skill.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </a>
                                </h4>
                            </div>
                        </div>

                        <div class=""col-sm-8"">
                            <div class=""progress"">
                                <div class=""progress-bar""
                         role=""progressbar""
                         aria-valuenow=""80""
                         aria-valuemin=""0""
                         aria-valuemax=""100""");
            BeginWriteAttribute("style", "\n                         style=\"", 1302, "\"", 1355, 3);
            WriteAttributeValue("", 1335, "width:", 1335, 6, true);
#nullable restore
#line 36 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
WriteAttributeValue(" ", 1341, skill.Level, 1342, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1354, "%", 1354, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                                    <span class=\"sr-only\">");
#nullable restore
#line 37 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
                                                     Write(skill.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral("% Complete</span>\n                                </div>\n                            </div>\n\n                            <!-- Skillls Bars -->\n                            <!-- Skillls Text -->\n                            <div");
            BeginWriteAttribute("id", " id=\"", 1653, "\"", 1678, 3);
            WriteAttributeValue("", 1658, "collapse-", 1658, 9, true);
#nullable restore
#line 43 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
WriteAttributeValue("", 1667, skill.Id, 1667, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1676, "-5", 1676, 2, true);
            EndWriteAttribute();
            WriteLiteral("\n                     class=\"panel-collapse collapse\" aria-expanded=\"false\" style=\"height: 0px;\">\n                                <div class=\"panel-body\">\n                                    <p>\n                                        ");
#nullable restore
#line 47 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
                                   Write(skill.Description.ToPlainText());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </p>\n                                </div>\n                            </div>\n                        </div>\n\n                    </div>\n                </div>\n            </div>\n");
#nullable restore
#line 56 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
        }
        else if (skill.View != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"ethical\">\n                <h6>");
#nullable restore
#line 60 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
               Write(skill.ResumeCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n                <a href=\"#.\">");
#nullable restore
#line 61 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
                        Write(skill.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n            </div>\n");
#nullable restore
#line 63 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Shared\Components\ResumeSkill\Default.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ResumeCategory>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
