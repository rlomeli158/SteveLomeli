#pragma checksum "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72495190e3579277b95ae9462a2f99510158832e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectWorkspace.Views.MovieReview.Views_MovieReview_Index), @"mvc.1.0.view", @"/Views/MovieReview/Index.cshtml")]
namespace FinalProjectWorkspace.Views.MovieReview
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
#line 2 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/_ViewImports.cshtml"
using FinalProjectWorkspace.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72495190e3579277b95ae9462a2f99510158832e", @"/Views/MovieReview/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3077373090091c5850da6e8c6a3970a3b8885491", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieReview_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FinalProjectWorkspace.Models.MovieReview>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
  
    ViewData["Title"] = "All Movie Reviews";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <br />
<h1 class=""text-center text-danger"">Movie Reviews</h1>
<hr style=""height:2px;border-width:0;color:#d0faff;background-color:#d0faff"">
<br />

<!--<p>
    <a asp-action=""Create"">Create New</a>
</p>-->
<table class=""table table-hover text-center"">
    <thead>
        <tr class=""text-light text-center"">
            <th>
                ");
#nullable restore
#line 19 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ReviewDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 25 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 28 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ReviewDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n");
#nullable restore
#line 30 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
             if (User.IsInRole("Employee") || User.IsInRole("Manager"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>\n                    ");
#nullable restore
#line 33 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ApprovalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n");
#nullable restore
#line 35 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>\n                Edit\n            </th>\n            <th>\n                Details\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 45 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"table-secondary text-center text-dark\">\n            <td>\n                ");
#nullable restore
#line 49 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReviewDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 52 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Movie.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 55 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 58 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReviewDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n");
#nullable restore
#line 60 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
             if (User.IsInRole("Employee") || User.IsInRole("Manager"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\n                    ");
#nullable restore
#line 63 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ApprovalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n");
#nullable restore
#line 65 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\n");
#nullable restore
#line 67 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
             if (User.IsInRole("Manager") || User.IsInRole("Employee") || item.User.UserName == User.Identity.Name)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72495190e3579277b95ae9462a2f99510158832e11562", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
                                                                           WriteLiteral(item.MovieReviewID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 70 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("Unable to Edit\n");
#nullable restore
#line 74 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72495190e3579277b95ae9462a2f99510158832e14644", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
                                                                         WriteLiteral(item.MovieReviewID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 80 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/MovieReview/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FinalProjectWorkspace.Models.MovieReview>> Html { get; private set; }
    }
}
#pragma warning restore 1591