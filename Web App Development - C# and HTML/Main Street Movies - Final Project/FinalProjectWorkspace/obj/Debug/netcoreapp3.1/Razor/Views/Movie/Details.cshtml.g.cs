#pragma checksum "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb873c95d79f9f6b39f9542b3db651835cae3183"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectWorkspace.Views.Movie.Views_Movie_Details), @"mvc.1.0.view", @"/Views/Movie/Details.cshtml")]
namespace FinalProjectWorkspace.Views.Movie
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb873c95d79f9f6b39f9542b3db651835cae3183", @"/Views/Movie/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3077373090091c5850da6e8c6a3970a3b8885491", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalProjectWorkspace.Models.Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DisplaySearchResults", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
   ViewData["Title"] = "Movie Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br/>\n<h3 class=\"text-danger\">\n    ");
#nullable restore
#line 7 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
Write(Html.DisplayFor(model => model.Tagline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</h3>\n\n<div class=\"list-group\">\n    <a class=\"list-group-item list-group-item-action flex-column align-items-start\">\n        <div class=\"d-flex w-100 justify-content-between\">\n            <h5 class=\"mb-1\">\n                ");
#nullable restore
#line 14 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h5>\n            <small class=\"text-muted\">\n                Released in ");
#nullable restore
#line 17 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
                       Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral(". Run Time: ");
#nullable restore
#line 17 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
                                                                        Write(Html.DisplayFor(model => model.RunTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </small>\n        </div>\n        <p class=\"mb-1\">\n            ");
#nullable restore
#line 21 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </a>\n    <a class=\"list-group-item list-group-item-action flex-column align-items-start\">\n        <div class=\"d-flex w-100 justify-content-between\">\n            <h5 class=\"mb-1\">\n                ");
#nullable restore
#line 27 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Overview));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h5>\n        </div>\n        <p class=\"mb-1\">\n            ");
#nullable restore
#line 31 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
       Write(Html.DisplayFor(model => model.Overview));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </a>\n    <a class=\"list-group-item list-group-item-action flex-column align-items-start\">\n        <div class=\"d-flex w-100 justify-content-between\">\n            <h5 class=\"mb-1\">\n                ");
#nullable restore
#line 37 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Actors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h5>\n        </div>\n        <p class=\"mb-1\">\n            ");
#nullable restore
#line 41 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
       Write(Html.DisplayFor(model => model.Actors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </a>\n    <a class=\"list-group-item list-group-item-action flex-column align-items-start\">\n        <div class=\"d-flex w-100 justify-content-between\">\n            <h5 class=\"mb-1\">\n                ");
#nullable restore
#line 47 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.MPAARating));

#line default
#line hidden
#nullable disable
            WriteLiteral(" & ");
#nullable restore
#line 47 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
                                                             Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h5>\n        </div>\n        <p class=\"mb-1\">\n            ");
#nullable restore
#line 51 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
       Write(Html.DisplayFor(model => model.MPAARating));

#line default
#line hidden
#nullable disable
            WriteLiteral(" and\n            ");
#nullable restore
#line 52 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
       Write(Html.DisplayFor(model => model.Genre.GenreName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </p>
    </a>
    <a class=""list-group-item list-group-item-action flex-column align-items-start"">
        <div class=""d-flex w-100 justify-content-between"">
            <h5 class=""mb-1"">
                Average Review Rating
            </h5>
        </div>
        <p class=""mb-1"">
");
#nullable restore
#line 62 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
              Double? avgReview = Model.MovieReviews.Where(r => r.ApprovalStatus == true).Average(m => m.Rating);

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
             if (avgReview != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
           Write(avgReview);

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
                          
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("No Rating yet\n");
#nullable restore
#line 70 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </p>\n    </a>\n");
#nullable restore
#line 73 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
     if (User.IsInRole("Manager"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"list-group-item list-group-item-action flex-column align-items-start\">\n            <div class=\"d-flex w-100 justify-content-between\">\n                <h5 class=\"mb-1\">\n                    ");
#nullable restore
#line 78 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Revenue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </h5>\n            </div>\n            <p class=\"mb-1\">\n                ");
#nullable restore
#line 82 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
           Write(Html.DisplayFor(model => model.Revenue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </p>\n        </a>\n");
#nullable restore
#line 85 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

</div>

<table class=""table table-hover text-center"">
    <tr class=""text-light text-center"">
        <th>Showing Date</th>
        <th>Start Time</th>
        <th>End Time</th>
        <th>Theatre</th>
        <th>Special Event?</th>
        <th>Purchase</th>
    </tr>
");
#nullable restore
#line 99 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
     foreach (Showing p in Model.Showings)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr class=\"table-secondary text-center text-dark\">\n");
#nullable restore
#line 102 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
     if (DateTime.Now < p.StartTime && p.Status == "Published")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>");
#nullable restore
#line 104 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
       Write(Html.DisplayFor(modelItem => p.ShowingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 105 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
       Write(Html.DisplayFor(modelItem => p.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 106 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
       Write(Html.DisplayFor(modelItem => p.EndTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 107 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
       Write(Html.DisplayFor(modelItem => p.Theatre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>\n");
#nullable restore
#line 109 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
             if (p.SpecialEvent == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("Yes\n");
#nullable restore
#line 112 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("No\n");
#nullable restore
#line 116 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </td>\n        <td>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb873c95d79f9f6b39f9542b3db651835cae318319006", async() => {
                WriteLiteral("\n                <input type=\"submit\" value=\"Buy a ticket!\" class=\"btn btn-outline-info\" />\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-showingid", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
                                                                      WriteLiteral(p.ShowingID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["showingid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-showingid", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["showingid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </td>\n");
#nullable restore
#line 123 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</tr>");
#nullable restore
#line 124 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n<h3 class=\"text-danger text-center\">Movie Reviews</h3>\n<table class=\"table table-hover text-center\">\n    <tr class=\"text-light text-center\">\n        <th>Review Date</th>\n        <th>Rating</th>\n        <th>Description</th>\n    </tr>\n");
#nullable restore
#line 134 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
     foreach (MovieReview mr in Model.MovieReviews)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"table-secondary text-center text-dark\">\n");
#nullable restore
#line 137 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
             if (mr.ApprovalStatus == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 139 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
               Write(Html.DisplayFor(modelItem => mr.ReviewDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 140 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
               Write(Html.DisplayFor(modelItem => mr.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 141 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
               Write(Html.DisplayFor(modelItem => mr.ReviewDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 142 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\n");
#nullable restore
#line 144 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n<div class=\"text-center\">\n\n");
#nullable restore
#line 149 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
     if (User.Identity.IsAuthenticated)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 151 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
         if (User.IsInRole("Manager"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb873c95d79f9f6b39f9542b3db651835cae318326049", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 153 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
                                                                  WriteLiteral(Model.MovieID);

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
#line 154 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 154 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Movie/Details.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb873c95d79f9f6b39f9542b3db651835cae318328940", async() => {
                WriteLiteral("Back to Movie Showings");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProjectWorkspace.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
