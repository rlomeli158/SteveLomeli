#pragma checksum "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2258dd0179ce5137777ec302164e10d5d65e8bab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectWorkspace.Views.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace FinalProjectWorkspace.Views.Home
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
#line 2 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/_ViewImports.cshtml"
using FinalProjectWorkspace.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2258dd0179ce5137777ec302164e10d5d65e8bab", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9daefa0269a9261bb659ce4728f692443d8481bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FinalProjectWorkspace.Models.Showing>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Browse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Home/Index.cshtml"
  
    ViewBag.Title = "Welcome to Main St. Movies!";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<!DOCTYPE html>\n\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2258dd0179ce5137777ec302164e10d5d65e8bab7115", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2258dd0179ce5137777ec302164e10d5d65e8bab8126", async() => {
                WriteLiteral(@"
    <div class=""text-center"">
        <br />
        <h1>Welcome to Main St. Movies!</h1>
    </div>

    <div class=""text-center"">
        <hr style=""height:2px;border-width:0;color:#d0faff;background-color:#d0faff"">
        <br />



        <h2 class=""text-danger"">Main St. Original: The Last Search</h2>


        <br />
        <video controls autoplay loop class=""video"">
            <source src=""/images/MSM.mp4"" type=""video/mp4"">
        </video>

    </div>

    <hr style=""height:2px;border-width:0;color:#d0faff;background-color:#d0faff"">
    <br />


    <h2 class=""text-danger text-center"">Current Showings</h2>

    <div>
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2258dd0179ce5137777ec302164e10d5d65e8bab9042", async() => {
                    WriteLiteral(@"
            <p class=""form-group text-center"">
                Search Today's Showings: <input name=""SearchString"" class=""form-control"" placeholder=""Search Movie Title"" /><br />
                <button type=""submit"" class=""btn btn-outline-primary"">Search</button>
                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2258dd0179ce5137777ec302164e10d5d65e8bab9596", async() => {
                        WriteLiteral("Search All Movies");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                <!--<a asp-action=\"Index\" type=\"button\" class=\"btn btn-outline-primary\">See All Showings</a>-->\n\n            </p>\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    </div>\n    <div>\n        <p>\n            Displaying ");
#nullable restore
#line 55 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Home/Index.cshtml"
                  Write(ViewBag.SelectedShowings);

#line default
#line hidden
#nullable disable
                WriteLiteral(" out of ");
#nullable restore
#line 55 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Home/Index.cshtml"
                                                   Write(ViewBag.AllShowings);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Remaining Showings Today\n        </p>\n    </div>\n    <div class=\"text-center\">\n        <table class=\"table table-hover text-center\">\n            <thead>\n                <tr class=\"text-light text-center\">\n                    <th>\n                        ");
#nullable restore
#line 63 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Home/Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Movie.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 66 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Home/Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ShowingDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 69 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Home/Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.StartTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 72 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Home/Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.EndTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </th>\n                    <th>\n                        ");
#nullable restore
#line 75 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Home/Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Theatre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </th>\n                    <th>\n                        Buy Ticket\n                    </th>\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 83 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Home/Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr class=\"table-secondary text-center text-dark\">\n                        <td>\n                            ");
#nullable restore
#line 87 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Home/Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Movie.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 90 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Home/Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ShowingDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 93 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Home/Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.StartTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 96 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Home/Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.EndTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </td>\n                        <td>\n                            ");
#nullable restore
#line 99 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Home/Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Theatre));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </td>\n                        <td>\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2258dd0179ce5137777ec302164e10d5d65e8bab18990", async() => {
                    WriteLiteral("\n                                <input type=\"submit\" value=\"Buy a ticket!\" class=\"btn btn-outline-info\" />\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-showingid", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Home/Index.cshtml"
                                                                                      WriteLiteral(item.ShowingID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["showingid"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-showingid", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["showingid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        </td>\n\n                    </tr>\n");
#nullable restore
#line 108 "/Users/slomeli/Desktop/Sophomore Year/First Semester/MIS 333K/Projects/Final Project/FinalProjectWorkspace/FinalProject/FinalProjectWorkspace/Views/Home/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </tbody>
        </table>
        <h3 class=""text-center text-danger"">That's all for today, folks!</h3>
    </div>

    <!-- This is the slide show  comment out for now
        <h2>
            Slideshow Example
        </h2>
        <br />
        <div class=""text-center"">
            *****change the image on the CSS File and add new if necessry
            <div class=""simple-ss-1"" alt="""" title=""""></div>
            <div class=""content-ss-1""></div>
        </div>
        <br />
        <br /> -->

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FinalProjectWorkspace.Models.Showing>> Html { get; private set; }
    }
}
#pragma warning restore 1591
