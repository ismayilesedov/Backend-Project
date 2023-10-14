#pragma checksum "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14c674f44d6a293e7273c9fef938a3df15703fc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14c674f44d6a293e7273c9fef938a3df15703fc2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1707a7370f603cc1805447dc8807fd84c1850f01", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<About>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "About me";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- ABOUT ME -->\n<div class=\"inside-sec\">\n    <!-- BIO AND SKILLS -->\n    <h5 class=\"tittle\">About Me</h5>\n\n    <!-- Blog -->\n    <section class=\"about-me padding-top-10\">\n        <!-- Personal Info -->\n        ");
#nullable restore
#line 13 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("About"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n\n        <!-- I’m Web Designer -->\n");
#nullable restore
#line 16 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h5 class=\"tittle\">");
#nullable restore
#line 18 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Home\Index.cshtml"
                          Write(item.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n            <div class=\"padding-20\">\n                <p>\n                    ");
#nullable restore
#line 21 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Home\Index.cshtml"
               Write(Html.Raw(@item.LongDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </p>\n            </div>\n");
#nullable restore
#line 24 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        <!-- Services -->\n        <h5 class=\"tittle\">Services</h5>\n        <div class=\"row padding-20 margin-top-50\">\n            <!-- Icon -->\n");
#nullable restore
#line 31 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Home\Index.cshtml"
                 foreach (var md in item.Services)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-4 text-center\">\n                        <div class=\"icon-box i-large ib-black\">\n                            <div class=\"ib-icon\">\n                                <i");
            BeginWriteAttribute("class", " class=\"", 1092, "\"", 1111, 1);
#nullable restore
#line 38 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Home\Index.cshtml"
WriteAttributeValue("", 1100, md.IconKey, 1100, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\n                            </div>\n                            <div class=\"ib-info\">\n                                <h4 class=\"h6\">");
#nullable restore
#line 41 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Home\Index.cshtml"
                                          Write(md.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                                <p>\n                                    ");
#nullable restore
#line 43 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Home\Index.cshtml"
                               Write(md.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                </p>\n                            </div>\n                        </div>\n                    </div>\n");
#nullable restore
#line 48 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Home\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n\n        <!-- Skills -->\n        <h5 class=\"tittle\">Skills</h5>\n\n        <!-- Sound Engineering -->\n        <div class=\"panel-group accordion padding-20\"\n             id=\"accordion\">\n            ");
#nullable restore
#line 59 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("SkillsForHome"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </section>\n</div>\n\n\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<About>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
