#pragma checksum "D:\Prerna-Chachare\.NET Core Training\Test\ProjectManagement\ProjectManagement\Views\Project\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36d761f78d10c591cad0adef0c6405964c246214"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Details), @"mvc.1.0.view", @"/Views/Project/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/Details.cshtml", typeof(AspNetCore.Views_Project_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36d761f78d10c591cad0adef0c6405964c246214", @"/Views/Project/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e17d690afeab3210a95cd19880aa1a9b7f76dfad", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectManagement.Models.Project>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Project", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Prerna-Chachare\.NET Core Training\Test\ProjectManagement\ProjectManagement\Views\Project\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(86, 116, true);
            WriteLiteral("\r\n<h1>Project Details</h1>\r\n<hr />\r\n<dl class=\"row\">\r\n    <dt class=\"col-sm-2\">Name</dt>\r\n    <dd class=\"col-sm-10\">");
            EndContext();
            BeginContext(203, 10, false);
#line 11 "D:\Prerna-Chachare\.NET Core Training\Test\ProjectManagement\ProjectManagement\Views\Project\Details.cshtml"
                     Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(213, 76, true);
            WriteLiteral("</dd>\r\n    <dt class=\"col-sm-2\">Description</dt>\r\n    <dd class=\"col-sm-10\">");
            EndContext();
            BeginContext(290, 17, false);
#line 13 "D:\Prerna-Chachare\.NET Core Training\Test\ProjectManagement\ProjectManagement\Views\Project\Details.cshtml"
                     Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(307, 75, true);
            WriteLiteral("</dd>\r\n    <dt class=\"col-sm-2\">Start Date</dt>\r\n    <dd class=\"col-sm-10\">");
            EndContext();
            BeginContext(383, 35, false);
#line 15 "D:\Prerna-Chachare\.NET Core Training\Test\ProjectManagement\ProjectManagement\Views\Project\Details.cshtml"
                     Write(Model.StartDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(418, 69, true);
            WriteLiteral("</dd>\r\n    <dt class=\"col-sm-2\">Type</dt>\r\n    <dd class=\"col-sm-10\">");
            EndContext();
            BeginContext(488, 10, false);
#line 17 "D:\Prerna-Chachare\.NET Core Training\Test\ProjectManagement\ProjectManagement\Views\Project\Details.cshtml"
                     Write(Model.Type);

#line default
#line hidden
            EndContext();
            BeginContext(498, 74, true);
            WriteLiteral("</dd>\r\n    <dt class=\"col-sm-2\">Is Active</dt>\r\n    <dd class=\"col-sm-10\">");
            EndContext();
            BeginContext(573, 14, false);
#line 19 "D:\Prerna-Chachare\.NET Core Training\Test\ProjectManagement\ProjectManagement\Views\Project\Details.cshtml"
                     Write(Model.IsActive);

#line default
#line hidden
            EndContext();
            BeginContext(587, 80, true);
            WriteLiteral("</dd>\r\n    <dt class=\"col-sm-2\">Project Manager</dt>\r\n    <dd class=\"col-sm-10\">");
            EndContext();
            BeginContext(668, 30, false);
#line 21 "D:\Prerna-Chachare\.NET Core Training\Test\ProjectManagement\ProjectManagement\Views\Project\Details.cshtml"
                     Write(Model.ProjectManager.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(698, 25, true);
            WriteLiteral("</dd>\r\n</dl>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(723, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36d761f78d10c591cad0adef0c6405964c2462147671", async() => {
                BeginContext(818, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "D:\Prerna-Chachare\.NET Core Training\Test\ProjectManagement\ProjectManagement\Views\Project\Details.cshtml"
                                                    WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(826, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(832, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36d761f78d10c591cad0adef0c6405964c24621410329", async() => {
                BeginContext(900, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(916, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectManagement.Models.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
