#pragma checksum "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baa7b7cf9d7685fac66279e1736701d2def4a09d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FinalProjectWorkspace.Views.Order.Views_Order_CompleteOrder), @"mvc.1.0.view", @"/Views/Order/CompleteOrder.cshtml")]
namespace FinalProjectWorkspace.Views.Order
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baa7b7cf9d7685fac66279e1736701d2def4a09d", @"/Views/Order/CompleteOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3077373090091c5850da6e8c6a3970a3b8885491", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_CompleteOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalProjectWorkspace.Models.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Submit Order"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CompleteOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
  
    ViewData["Title"] = "Confirm Your Order";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <br />

    <h1 class=""text-center text-danger"">Confirm Your Order</h1>
    <hr style=""height:2px;border-width:0;color:#d0faff;background-color:#d0faff"">
    <br />

</div>
<div class=""list-group"">
    <a class=""list-group-item list-group-item-action flex-column align-items-start"">
        <div class=""d-flex w-100 justify-content-between"">
            <h5 class=""mb-1"">
                ");
#nullable restore
#line 19 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
           Write(Html.DisplayNameFor(model => model.TransactionNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h5>\n        </div>\n        <p class=\"mb-1\">\n            ");
#nullable restore
#line 23 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
       Write(Html.DisplayFor(model => model.TransactionNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </a>\n    <a class=\"list-group-item list-group-item-action flex-column align-items-start\">\n        <div class=\"d-flex w-100 justify-content-between\">\n            <h5 class=\"mb-1\">\n                ");
#nullable restore
#line 29 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h5>\n        </div>\n        <p class=\"mb-1\">\n            ");
#nullable restore
#line 33 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
       Write(Html.DisplayFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </a>\n    <a class=\"list-group-item list-group-item-action flex-column align-items-start\">\n        <div class=\"d-flex w-100 justify-content-between\">\n            <h5 class=\"mb-1\">\n                ");
#nullable restore
#line 39 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h5>\n        </div>\n        <p class=\"mb-1\">\n            ");
#nullable restore
#line 43 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
       Write(Html.DisplayFor(model => model.OrderStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </a>\n");
#nullable restore
#line 46 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
     if (Model.Seller != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <a class=""list-group-item list-group-item-action flex-column align-items-start"">
            <div class=""d-flex w-100 justify-content-between"">
                <h5 class=""mb-1"">
                    Sold By Employee
                </h5>
            </div>
            <p class=""mb-1"">
                ");
#nullable restore
#line 55 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
           Write(Html.DisplayFor(model => model.Seller.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 55 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
                                                             Write(Html.DisplayFor(model => model.Seller.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </p>\n        </a>\n");
#nullable restore
#line 58 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <a class=""list-group-item list-group-item-action flex-column align-items-start"">
        <div class=""d-flex w-100 justify-content-between"">
            <h5 class=""mb-1"">
                Customer
            </h5>
        </div>
        <p class=""mb-1"">
            ");
#nullable restore
#line 66 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
       Write(Html.DisplayFor(model => model.Purchaser.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 66 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
                                                            Write(Html.DisplayFor(model => model.Purchaser.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </a>\n");
#nullable restore
#line 69 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
     if (Model.Recipient != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"list-group-item list-group-item-action flex-column align-items-start\">\n            <div class=\"d-flex w-100 justify-content-between\">\n                <h5 class=\"mb-1\">\n                    Gift ");
#nullable restore
#line 74 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
                    Write(Html.DisplayNameFor(model => model.Recipient));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </h5>\n            </div>\n            <p class=\"mb-1\">\n                ");
#nullable restore
#line 78 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
           Write(Html.DisplayFor(model => model.Recipient.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </p>\n        </a>\n");
#nullable restore
#line 81 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<hr style=""height:2px;border-width:0;color:#d0faff;background-color:#d0faff"">
<br />

<h5 class=""text-center text-danger"">Tickets on this Order</h5>
<table class=""table table-hover text-center"">
    <tr class=""table-primary text-center"">
        <!--class=""text-light text-center""-->
        <th>Movie Title</th>
        <th>Date</th>
        <th>Seat</th>
        <!--<th>Price</th>
        <th>Discount</th>-->
        <th>Ticket Type</th>
        <th>Total</th>
    </tr>
");
#nullable restore
#line 99 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
     foreach (Ticket t in Model.Tickets)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"table-secondary text-center text-dark\">\n            <td>");
#nullable restore
#line 102 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
           Write(Html.DisplayFor(ModelItem => t.Showing.Movie.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 103 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
           Write(Html.DisplayFor(ModelItem => t.Showing.ShowingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" at ");
#nullable restore
#line 103 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
                                                                   Write(Html.DisplayFor(ModelItem => t.Showing.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 104 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
           Write(Html.DisplayFor(ModelItem => t.SeatNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <!--<td>Html.DisplayFor(ModelItem => t.TicketPrice)</td>\n            <td>Html.DisplayFor(ModelItem => t.DiscountAmount)</td>-->\n");
#nullable restore
#line 107 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
             if (t.DiscountName == DiscountNames.Matinee)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Matinee Discount</td>\n");
#nullable restore
#line 110 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
            }
            else if (t.DiscountName == DiscountNames.Tuesday_Discount)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Discount Tuesday</td>\n");
#nullable restore
#line 114 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
            }
            else if (t.DiscountName == DiscountNames.Senior_Discounts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Senior Discount</td>\n");
#nullable restore
#line 118 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
            }
            else if (t.DiscountName == DiscountNames.Matinee_and_Senior)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Matinee &amp; Senior Discounts</td>\n");
#nullable restore
#line 122 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
            }
            else if (t.DiscountName == DiscountNames.Tuesday_and_Senior)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Discount Tuesday &amp; Senior Discounts</td>\n");
#nullable restore
#line 126 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
            }
            else if (t.TicketType == TicketTypes.Special_Event)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Special Event</td>\n");
#nullable restore
#line 130 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
            }
            else if (t.TicketType == TicketTypes.Weekday_Regular)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Weekday Discount</td>\n");
#nullable restore
#line 134 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
            }
            else if (t.TicketType == TicketTypes.Weekend_Regular)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Regular Weekend</td>\n");
#nullable restore
#line 138 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>");
#nullable restore
#line 139 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
           Write(Html.DisplayFor(ModelItem => t.TotalCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 141 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n\n<h5>Order Summary</h5>\n<table class=\"table-secondary text-dark\" style=\"width:40%; padding:10px\">\n    <tr>\n        <th colspan=\"2\" style=\"text-align:center\">Order Summary</th>\n    </tr>\n    <tr>\n        <td>Order Subtotal:</td>\n        <td>");
#nullable restore
#line 151 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
       Write(Html.DisplayFor(model => model.OrderSubtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>Taxes:</td>\n        <td>");
#nullable restore
#line 155 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
       Write(Html.DisplayFor(model => model.Taxes));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>Order Total:</td>\n        <td>");
#nullable restore
#line 159 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
       Write(Html.DisplayFor(model => model.OrderTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    </tr>\n");
#nullable restore
#line 161 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
     if (Model.PaidWithPopcornPoints == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>Popcorn Points Used:</td>\n            <td>");
#nullable restore
#line 165 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
           Write(Html.DisplayFor(model => model.PopcornPoints));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Amount Saved With Popcorn Points:</td>\n");
#nullable restore
#line 169 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
               Decimal popcornSaved = Model.Tickets.Sum(t => t.TicketPrice) - Model.Tickets.Sum(t => t.DiscountAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>$");
#nullable restore
#line 170 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
            Write(popcornSaved);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 172 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n<div style=\"display:inline-flex; grid-column-gap:15px; margin-top:30px;\" class=\"text-center\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa7b7cf9d7685fac66279e1736701d2def4a09d24636", async() => {
                WriteLiteral("\n        <input type=\"submit\" value=\"Return to Order\" class=\"btn btn-outline-warning\" />\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 175 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
                                 WriteLiteral(Model.OrderID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa7b7cf9d7685fac66279e1736701d2def4a09d27221", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "baa7b7cf9d7685fac66279e1736701d2def4a09d27484", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 179 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OrderID);

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
                WriteLiteral("\n        <input type=\"hidden\" name=\"paidPP\"");
                BeginWriteAttribute("value", " value=", 6405, "", 6442, 1);
#nullable restore
#line 180 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
WriteAttributeValue("", 6412, ViewBag.PaidWithPopcornPoints, 6412, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n        <input type=\"hidden\" name=\"pcpBalance\"");
                BeginWriteAttribute("value", " value=", 6490, "", 6516, 1);
#nullable restore
#line 181 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
WriteAttributeValue("", 6497, ViewBag.PCPBalance, 6497, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n        <input type=\"hidden\" name=\"popcornPoints\"");
                BeginWriteAttribute("value", " value=", 6567, "", 6596, 1);
#nullable restore
#line 182 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
WriteAttributeValue("", 6574, ViewBag.PopcornPoints, 6574, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n        <input type=\"hidden\" name=\"recipient\"");
                BeginWriteAttribute("value", " value=", 6643, "", 6668, 1);
#nullable restore
#line 183 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
WriteAttributeValue("", 6650, ViewBag.Recipient, 6650, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "baa7b7cf9d7685fac66279e1736701d2def4a09d31378", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 184 "/Users/slomeli/Desktop/Professional/Professional Projects for Git/Steve-Lomeli/SteveLomeli/Web App Development - C# and HTML/FinalProjectWorkspace/Views/Order/CompleteOrder.cshtml"
                                                    WriteLiteral(Model.OrderID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalProjectWorkspace.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
