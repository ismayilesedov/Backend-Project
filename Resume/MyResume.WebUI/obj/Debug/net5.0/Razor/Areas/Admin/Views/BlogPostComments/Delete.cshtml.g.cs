#pragma checksum "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\BlogPostComments\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5db033f81006c4c129c86d1c2981c0ba79809d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BlogPostComments_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/BlogPostComments/Delete.cshtml")]
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
#line 3 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.BlogPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.ResumeModel.Bio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.ResumeModel.Experience;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.ContactPostModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.ProjectsModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.Business.ProjectCategoryModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using MyResume.Domain.AppCode.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5db033f81006c4c129c86d1c2981c0ba79809d8", @"/Areas/Admin/Views/BlogPostComments/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d82a6fbf82dc2af823dfe4727a81dd9cd0e6af81", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_BlogPostComments_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyResume.Domain.Models.Entities.BlogPostComment>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\BlogPostComments\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Delete</h2>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>BlogPostComment</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
#nullable restore
#line 15 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\BlogPostComments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedByUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 18 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\BlogPostComments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedByUser.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 21 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\BlogPostComments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 24 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\BlogPostComments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 27 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\BlogPostComments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BlogPost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 30 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\BlogPostComments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BlogPost.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 33 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\BlogPostComments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Parent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 36 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\BlogPostComments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Parent.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 39 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\BlogPostComments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Approved));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 42 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\BlogPostComments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Approved));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 45 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\BlogPostComments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 48 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\BlogPostComments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
#nullable restore
#line 51 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\BlogPostComments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeletedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
#nullable restore
#line 54 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\BlogPostComments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeletedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5db033f81006c4c129c86d1c2981c0ba79809d810772", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e5db033f81006c4c129c86d1c2981c0ba79809d811037", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 59 "C:\Users\DELL\Desktop\cvv\MyResume.WebUI\Areas\Admin\Views\BlogPostComments\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5db033f81006c4c129c86d1c2981c0ba79809d812831", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyResume.Domain.Models.Entities.BlogPostComment> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
