#pragma checksum "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b6ba645b6ee8e50eb12a767f4dd885d9a90c623"
// <auto-generated/>
#pragma warning disable 1591
namespace TOCOMA_ERP_System.Pages.Sales
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_System.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_ClassLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_ClassLibrary.Models.WebsiteModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_System.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CustomLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/QuotationDetails/{Id}")]
    public partial class QuotationDetails : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    fieldset {
        border: 1px solid gray;
        padding: 10px;
        margin: 10px;
    }

    table {
        border-collapse: collapse;
        /*width: 150% !important;*/
    }

    th,
    td {
        border: 1px solid #888;
        /*padding: 0.25em 0.5em;*/
    }

        td i {
            display: inline-block;
        }

    tr td {
        text-align: left;
    }

    tr th {
        text-align: left;
        background-color: LightGray;
        font-size: 15px;
        width:10%
    }
</style>
");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "dashboard-details");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.AddAttribute(5, "style", "margin-bottom:200px");
            __builder.AddMarkupContent(6, "<a href=\"QuotationList\"><i class=\'bi bi-arrow-left-circle\' style=\"font-size:30px\"></i></a>\r\n        ");
            __builder.AddMarkupContent(7, "<label for=\"submitbutton\" class=\"btn btn-success\">Download Quotation</label>\r\n        ");
            __builder.AddMarkupContent(8, "<form action=\"Excel/SalesQuotation\" method=\"post\" style=\"display:none\"><button type=\"submit\" id=\"submitbutton\"></button></form>\r\n\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-lg-12");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card");
            __builder.AddMarkupContent(15, "<div class=\"card-header\">\r\n                        Quotation Info\r\n\r\n                    </div>\r\n                    ");
            __builder.OpenElement(16, "table");
            __builder.AddAttribute(17, "width", "100%");
            __builder.OpenElement(18, "thead");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "<th>Quotation Type</th>\r\n                                ");
            __builder.OpenElement(21, "td");
#nullable restore
#line 57 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(22, salesQuotationInfo.QUOTATION_TYPE);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                                ");
            __builder.AddMarkupContent(24, "<th>Quotation No</th>\r\n                                ");
            __builder.OpenElement(25, "td");
#nullable restore
#line 59 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(26, salesQuotationInfo.QUOTATION_NO);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                                ");
            __builder.AddMarkupContent(28, "<th>Quotation Date</th>\r\n                                ");
            __builder.OpenElement(29, "td");
#nullable restore
#line 61 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(30, salesQuotationInfo.QUOTATION_DATE);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.OpenElement(32, "tr");
            __builder.AddMarkupContent(33, "<th>Valid Up To</th>\r\n                                ");
            __builder.OpenElement(34, "td");
#nullable restore
#line 66 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(35, salesQuotationInfo.VALID_UP_TO_DATE);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                                ");
            __builder.AddMarkupContent(37, "<th>Incoterm</th>\r\n                                ");
            __builder.OpenElement(38, "td");
#nullable restore
#line 68 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(39, salesQuotationInfo.INCOTERM);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                                ");
            __builder.AddMarkupContent(41, "<th>Ship Via</th>\r\n                                ");
            __builder.OpenElement(42, "td");
#nullable restore
#line 70 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(43, salesQuotationInfo.SHIP_VIA);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                            ");
            __builder.OpenElement(45, "tr");
            __builder.AddMarkupContent(46, "<th>Sales Person</th>\r\n                                ");
            __builder.OpenElement(47, "td");
#nullable restore
#line 74 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(48, salesQuotationInfo.SALES_PERSON);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                                ");
            __builder.AddMarkupContent(50, "<th>Phone No.</th>\r\n                                ");
            __builder.OpenElement(51, "td");
#nullable restore
#line 76 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(52, salesQuotationInfo.PHONE_NO);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                                ");
            __builder.AddMarkupContent(54, "<th>Payment Terms</th>\r\n                                ");
            __builder.OpenElement(55, "td");
#nullable restore
#line 78 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(56, salesQuotationInfo.PAYMENT_TERMS);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                            ");
            __builder.OpenElement(58, "tr");
            __builder.AddMarkupContent(59, "<th>Attn.</th>\r\n                                ");
            __builder.OpenElement(60, "td");
#nullable restore
#line 84 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(61, salesQuotationInfo.CONTACT_PERSON_NAME);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                                ");
            __builder.AddMarkupContent(63, "<th>Contact</th>\r\n                                ");
            __builder.OpenElement(64, "td");
#nullable restore
#line 86 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(65, salesQuotationInfo.CONTACT_PERSON_PHONE);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                                ");
            __builder.AddMarkupContent(67, "<th>Email</th>\r\n                                ");
            __builder.OpenElement(68, "td");
#nullable restore
#line 88 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(69, salesQuotationInfo.CONTACT_PERSON_EMAIL);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                            ");
            __builder.OpenElement(71, "tr");
            __builder.AddMarkupContent(72, "<th>Expected Delivery Date</th>\r\n                                ");
            __builder.OpenElement(73, "td");
#nullable restore
#line 92 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(74, salesQuotationInfo.EXPECTED_DELIVERY_DATE);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                                ");
            __builder.AddMarkupContent(76, "<th>Submitted To</th>\r\n                                ");
            __builder.OpenElement(77, "td");
#nullable restore
#line 95 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(78, salesQuotationInfo.CUSTOMER_NAME);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(79, "<br>\r\n                                    ");
#nullable restore
#line 96 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(80, salesQuotationInfo.CORPORATE_ADDRESS);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                                ");
            __builder.AddMarkupContent(82, "<th>Ship To</th>\r\n                                ");
            __builder.OpenElement(83, "td");
#nullable restore
#line 99 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(84, salesQuotationInfo.SHIPPING_ADDRESS);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n            <hr>");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n        <br>\r\n        ");
            __builder.OpenElement(87, "table");
            __builder.AddAttribute(88, "style", "width:100%");
            __builder.AddMarkupContent(89, @"<thead><tr><th style=""width:27%;background-color:gainsboro"">Item <br>Description</th>
                    <th style=""width:7%;background-color:gainsboro"">Minimum<br>Order<br>Quantity</th>
                    <th style=""width:7%;background-color:gainsboro"">Unit<br>Of<br>Measure</th>
                    <th style=""width:7%;background-color:gainsboro"">Unit Price</th>

                    <th style=""width:7%;background-color:gainsboro"">AIT(%)</th>
                    <th style=""width:7%;background-color:gainsboro"">VAT(%)</th>
                    <th style=""width:7%;background-color:gainsboro"">Unit Price<br>Including VAT/TAX</th></tr></thead>


            ");
            __builder.OpenElement(90, "tbody");
#nullable restore
#line 129 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
                 if (salesQuotationItemList != null)
                {
                    foreach (var item in salesQuotationItemList)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(91, "tr");
            __builder.OpenElement(92, "td");
#nullable restore
#line 134 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(93, item.ITEM_NAME);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(94, "<br>");
#nullable restore
#line 134 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(95, (MarkupString)@item.ITEM_DESCRIPTION);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                            ");
            __builder.OpenElement(97, "td");
#nullable restore
#line 135 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(98, item.ORDER_QUANTITY);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                            ");
            __builder.OpenElement(100, "td");
#nullable restore
#line 136 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(101, item.UOM);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                            ");
            __builder.OpenElement(103, "td");
#nullable restore
#line 137 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(104, item.UNIT_PRICE);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                            ");
            __builder.OpenElement(106, "td");
#nullable restore
#line 138 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(107, item.AIT);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                            ");
            __builder.OpenElement(109, "td");
#nullable restore
#line 139 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(110, item.VAT);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                            ");
            __builder.OpenElement(112, "td");
#nullable restore
#line 140 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
__builder.AddContent(113, item.TOTAL_PRICE);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 142 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 151 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\QuotationDetails.razor"
       
    [Parameter]
    public string Id { get; set; }
    SalesQuotationView salesQuotationInfo = new SalesQuotationView();
    List<SalesQuotationItemView> salesQuotationItemList = new List<SalesQuotationItemView>();
    protected override async Task OnInitializedAsync()
    {
        salesQuotationInfo = await Http.GetJsonAsync<SalesQuotationView>(Utility.BaseUrl + "api/Sales/GetsalesQuotationInfoById/" + Id);
        salesQuotationItemList = await Http.GetJsonAsync<List<SalesQuotationItemView>>(Utility.BaseUrl + "api/Sales/GetSalesQuotationItemListById/" + Id);

        AppState.salesQuotation = salesQuotationInfo;
        AppState.salesQuotationitemList = salesQuotationItemList;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
