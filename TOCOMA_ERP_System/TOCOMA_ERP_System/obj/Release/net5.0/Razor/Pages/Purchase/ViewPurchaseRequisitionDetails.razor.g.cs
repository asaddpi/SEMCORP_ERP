#pragma checksum "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c608e2467753b2c780e22206bc67ee61911a28b"
// <auto-generated/>
#pragma warning disable 1591
namespace TOCOMA_ERP_System.Pages.Purchase
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_System.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_ClassLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_ClassLibrary.Models.WebsiteModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_System.Controller;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using TOCOMA_ERP_System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CustomLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewPurchaseRequisitionDetails/{requisition_no}")]
    public partial class ViewPurchaseRequisitionDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
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
        text-align: center;
    }

    tr th {
        text-align: center;
    }
</style>



");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "dashboard-details");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.OpenElement(5, "fieldset");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "style", "padding-top:10px;padding-left:10px");
            __builder.OpenElement(8, "p");
            __builder.AddAttribute(9, "style", "font-size:15px;font-weight:bold");
            __builder.AddContent(10, "Requisition NO : ");
            __builder.AddContent(11, 
#nullable restore
#line 149 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                                             requisitionDetails.REQUISITION_NO

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(12, " ");
            __builder.OpenElement(13, "label");
            __builder.AddAttribute(14, "style", "float:right;margin-right:230px");
            __builder.AddContent(15, 
#nullable restore
#line 149 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                                                                                                                                  requisitionDetails.ENTRYDATE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "p");
            __builder.AddMarkupContent(18, "<b>Requester:  </b> ");
            __builder.AddContent(19, 
#nullable restore
#line 150 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                        requisitionDetails.REQUESTED_BY

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "p");
            __builder.AddMarkupContent(22, "<b>Request Department :   </b> ");
            __builder.AddContent(23, 
#nullable restore
#line 151 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                   requisitionDetails.REQUEST_DEPARTMENT

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "p");
            __builder.AddMarkupContent(26, "<b>Request Receive Department :   </b> ");
            __builder.AddContent(27, 
#nullable restore
#line 152 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                           requisitionDetails.REQUEST_RECEIVE_DEPARTMENT

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "p");
            __builder.AddMarkupContent(30, "<b>Request Date:   </b> ");
            __builder.AddContent(31, 
#nullable restore
#line 153 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                            requisitionDetails.REQUEST_DATE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "p");
            __builder.AddMarkupContent(34, "<b>Require Date:   </b> ");
            __builder.AddContent(35, 
#nullable restore
#line 154 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                            requisitionDetails.REQUIRED_DATE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "p");
            __builder.AddMarkupContent(38, "<b>Priority:   </b> ");
            __builder.AddContent(39, 
#nullable restore
#line 155 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                        requisitionDetails.PRIORITY

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "p");
            __builder.AddMarkupContent(42, "<b>Purpose of Requisition:   </b> ");
            __builder.AddContent(43, 
#nullable restore
#line 156 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                      requisitionDetails.REQUISITION_PURPOSE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n                <br>\r\n                ");
            __builder.AddMarkupContent(45, "<label>Item Details</label>\r\n                ");
            __builder.OpenElement(46, "table");
            __builder.AddAttribute(47, "style", "width:50%");
            __builder.AddMarkupContent(48, "<tr><th>Item</th>\r\n                        <th>Quantity</th>\r\n                        <th>UOM</th>\r\n                        <th>Rate</th>\r\n                        <th>Amount</th></tr>\r\n                    ");
            __builder.OpenElement(49, "tbody");
#nullable restore
#line 169 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                         foreach (var tableitem in requestItemList)
                        {
                            double itemTotal = Convert.ToDouble(tableitem.Rate) * Convert.ToDouble(tableitem.Quantity);

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "tr");
            __builder.OpenElement(51, "td");
            __builder.AddAttribute(52, "scope", "col");
            __builder.AddContent(53, 
#nullable restore
#line 173 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                 tableitem.ITEM_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                ");
            __builder.OpenElement(55, "td");
            __builder.AddAttribute(56, "scope", "col");
            __builder.AddContent(57, 
#nullable restore
#line 174 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                 tableitem.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                                ");
            __builder.OpenElement(59, "td");
            __builder.AddAttribute(60, "scope", "col");
            __builder.AddContent(61, 
#nullable restore
#line 175 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                 tableitem.UOM

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                                ");
            __builder.OpenElement(63, "td");
            __builder.AddAttribute(64, "scope", "col");
            __builder.AddContent(65, 
#nullable restore
#line 176 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                 tableitem.Rate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                                ");
            __builder.OpenElement(67, "td");
            __builder.AddAttribute(68, "scope", "col");
            __builder.AddContent(69, 
#nullable restore
#line 177 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                 itemTotal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 179 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(70, "tr");
            __builder.AddMarkupContent(71, "<td colspan=\"4\" style=\"text-align:right\"><b>Total</b></td>\r\n                            ");
            __builder.OpenElement(72, "td");
            __builder.OpenElement(73, "b");
            __builder.AddContent(74, 
#nullable restore
#line 182 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                    requisition_Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                <br>\r\n\r\n                ");
            __builder.AddMarkupContent(76, "<label>Others</label>\r\n                ");
            __builder.OpenElement(77, "table");
            __builder.AddAttribute(78, "style", "width:50%");
            __builder.AddMarkupContent(79, "<tr><th>Item</th>\r\n                        <th>Quantity</th>\r\n                        <th>UOM</th>\r\n                        <th>Rate</th>\r\n                        <th>Total</th></tr>\r\n                    ");
            __builder.OpenElement(80, "tbody");
#nullable restore
#line 198 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                         foreach (var others in othersDetails)
                        {
                            decimal total = 0;
                            if (others.RATE != null || others.RATE != 0)
                            { total = Convert.ToDecimal(others.QUANTITY) * Convert.ToDecimal(others.RATE); }


#line default
#line hidden
#nullable disable
            __builder.OpenElement(81, "tr");
            __builder.OpenElement(82, "td");
            __builder.AddAttribute(83, "scope", "col");
            __builder.AddContent(84, 
#nullable restore
#line 205 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                 others.OTHERS_ITEM

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                                ");
            __builder.OpenElement(86, "td");
            __builder.AddAttribute(87, "scope", "col");
            __builder.AddContent(88, 
#nullable restore
#line 206 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                 others.QUANTITY

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                                ");
            __builder.OpenElement(90, "td");
            __builder.AddAttribute(91, "scope", "col");
            __builder.AddContent(92, 
#nullable restore
#line 207 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                 others.UNIT

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                                ");
            __builder.OpenElement(94, "td");
            __builder.AddAttribute(95, "scope", "col");
            __builder.AddContent(96, 
#nullable restore
#line 208 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                 others.RATE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                                ");
            __builder.OpenElement(98, "td");
            __builder.AddAttribute(99, "scope", "col");
            __builder.AddContent(100, 
#nullable restore
#line 209 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                 total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 211 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(101, "tr");
            __builder.AddMarkupContent(102, "<td colspan=\"4\" style=\"text-align:right\"><b>Total</b></td>\r\n                            ");
            __builder.OpenElement(103, "td");
            __builder.OpenElement(104, "b");
            __builder.AddContent(105, 
#nullable restore
#line 214 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                    others_Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                <br>\r\n                <br>\r\n\r\n                ");
            __builder.OpenElement(107, "table");
            __builder.AddAttribute(108, "width", "55%");
            __builder.AddAttribute(109, "style", "margin-bottom:100px");
            __builder.OpenElement(110, "tr");
            __builder.AddMarkupContent(111, "<td style=\"width:27%\">Total</td>\r\n                        ");
            __builder.OpenElement(112, "td");
            __builder.AddAttribute(113, "style", "width:7%;font-weight:bold");
            __builder.AddContent(114, 
#nullable restore
#line 224 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                               GrandTotal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                    ");
            __builder.OpenElement(116, "tr");
            __builder.OpenElement(117, "td");
            __builder.AddAttribute(118, "colspan", "2");
            __builder.AddAttribute(119, "style", "width:27%;text-align:left;font-weight:bold");
            __builder.AddContent(120, "In Words(BDT)  : ");
            __builder.AddContent(121, 
#nullable restore
#line 227 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                                                                                             Inwords

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 233 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
         if (department == "Admin & HR")
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "class", "col-6");
            __builder.AddAttribute(124, "style", "margin-bottom:150px");
            __builder.AddMarkupContent(125, "<label>Actions:</label>&nbsp;\r\n                ");
            __builder.OpenElement(126, "select");
            __builder.AddAttribute(127, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 237 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                requisitionDetails.STATUS

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(128, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => requisitionDetails.STATUS = __value, requisitionDetails.STATUS));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(129, "option");
            __builder.AddAttribute(130, "value");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                    ");
            __builder.OpenElement(132, "option");
            __builder.AddContent(133, "Open");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n                    ");
            __builder.OpenElement(135, "option");
            __builder.AddContent(136, "Approved");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                    ");
            __builder.OpenElement(138, "option");
            __builder.AddContent(139, "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n\r\n                ");
            __builder.OpenElement(141, "button");
            __builder.AddAttribute(142, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 245 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                                   () => ChangeStatus(requisitionDetails.REQUISITION_NO,requisitionDetails.STATUS)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(143, "class", "btn btn-info");
            __builder.AddContent(144, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                ");
            __builder.OpenElement(146, "label");
            __builder.AddContent(147, 
#nullable restore
#line 246 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
                        message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 248 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 254 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ViewPurchaseRequisitionDetails.razor"
       
    [Parameter]
    public string requisition_no { get; set; }
    PurchaseRequisitionViewEntity requisitionDetails = new PurchaseRequisitionViewEntity();
    List<PurchaseRequisitionOthersModel> othersDetails = new List<PurchaseRequisitionOthersModel>();
    List<OrderItemEntity> requestItemList = new List<OrderItemEntity>();
    string message;
    string department = "";
    double otherstotal;
    decimal others_Total;
    decimal requisition_Total;
    decimal GrandTotal;
    string Inwords;

    protected override async Task OnInitializedAsync()
    {
        await GetRequisitionDetails();
        department = await sessionStorage.GetItemAsync<string>("session_employeeDepartment");
    }
    public async Task GetRequisitionDetails()
    {
        requisitionDetails = await Http.GetJsonAsync<PurchaseRequisitionViewEntity>(Utility.BaseUrl + "api/Purchase/GetPurchaseRequisitionInfoByNo/" + requisition_no);
        requestItemList = await Http.GetJsonAsync<List<OrderItemEntity>>(Utility.BaseUrl + "api/Purchase/GetRequisitionItemDetailsByReqNo/" + requisition_no);
        othersDetails = await Http.GetJsonAsync<List<PurchaseRequisitionOthersModel>>(Utility.BaseUrl + "api/Purchase/GetRequisitionOthersItemDetailsByReqNo/" + requisition_no);
        requisition_Total= Convert.ToDecimal(String.Format("{0:0.00}", requisitionDetails.REQUISITION_TOTAL));

        foreach (var item in othersDetails)
        {
            otherstotal += item.QUANTITY * item.RATE;
        }
        others_Total = Convert.ToDecimal(String.Format("{0:0.00}", otherstotal));

        GrandTotal = requisition_Total + others_Total;
        double inwordValue = Convert.ToDouble(GrandTotal);
        Inwords = NumberToWords.ConvertAmount(inwordValue);
    }
    private async void ChangeStatus(string ReqNo, string Status)
    {
        PurchaseRequisitionEntity p = new PurchaseRequisitionEntity();
        p.REQUISITION_NO = ReqNo;
        p.STATUS = Status;

        await Http.PutJsonAsync<PurchaseRequisitionEntity>(Utility.BaseUrl + "api/Purchase/UpdateRequisitionStatus", p);
        if (Status == "Approved")
        { toastService.ShowSuccess("Requisition Approved"); }
        else if (Status == "Cancel")
        {
            toastService.ShowError("Requisition Cancel");
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
