#pragma checksum "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\RequisitionList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f5c4f91f378434f3c07aaf7e6d57d7b25d8330f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/RequisitionList")]
    public partial class RequisitionList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "dashboard-details");
            __builder.AddMarkupContent(2, "<h4 class=\"p-2\"><img src=\"images/fountain-pen.png\" alt width=\"50\" height=\"50\" class=\"mr-3\"><span class=\"text-uppercase\">REQUISITION LIST</span></h4>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "newRequsitionForm-content");
            __builder.OpenElement(5, "form");
            __builder.AddAttribute(6, "action");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container-fluid");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "analytic_details_contain_two");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table table-striped");
            __builder.AddMarkupContent(13, @"<thead style=""background-color:steelblue;color:white""><tr><td scope=""col""></td>
                                <td scope=""col"">Requisition No.</td>
                                <td scope=""col"">Requester</td>
                                <td scope=""col"">Request Department</td>
                                <td scope=""col"">Requisition Title</td>
                                <td scope=""col"">Request Date</td>
                                <td scope=""col"">Requisition Total</td>
                                <td scope=""col"">Status</td></tr></thead>
                        ");
            __builder.OpenElement(14, "tbody");
#nullable restore
#line 27 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\RequisitionList.razor"
                             if (requisitionList != null)
                            {
                                foreach (var item in requisitionList)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "tr");
            __builder.OpenElement(16, "td");
            __builder.AddAttribute(17, "scope", "col");
            __builder.OpenElement(18, "a");
            __builder.AddAttribute(19, "href", "PurchaseOrder/" + (
#nullable restore
#line 32 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\RequisitionList.razor"
                                                                                item.REQUISITION_NO

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "NEW PO");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                                        ");
            __builder.OpenElement(22, "td");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "href", "ViewPurchaseRequisitionDetails/" + (
#nullable restore
#line 33 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\RequisitionList.razor"
                                                                                     item.REQUISITION_NO

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, 
#nullable restore
#line 33 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\RequisitionList.razor"
                                                                                                           item.REQUISITION_NO

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                                        ");
            __builder.OpenElement(27, "td");
            __builder.AddAttribute(28, "scope", "col");
            __builder.AddContent(29, 
#nullable restore
#line 34 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\RequisitionList.razor"
                                                         item.REQUESTED_BY

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                                        ");
            __builder.OpenElement(31, "td");
            __builder.AddAttribute(32, "scope", "col");
            __builder.AddContent(33, 
#nullable restore
#line 35 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\RequisitionList.razor"
                                                         item.DEPARTMENT_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                                        ");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "scope", "col");
            __builder.AddContent(37, 
#nullable restore
#line 36 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\RequisitionList.razor"
                                                         item.REQUEST_FOR

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                        ");
            __builder.OpenElement(39, "td");
            __builder.AddAttribute(40, "scope", "col");
            __builder.AddContent(41, 
#nullable restore
#line 37 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\RequisitionList.razor"
                                                         item.REQUEST_DATE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                                        ");
            __builder.OpenElement(43, "td");
            __builder.AddAttribute(44, "scope", "col");
            __builder.AddContent(45, 
#nullable restore
#line 38 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\RequisitionList.razor"
                                                         item.REQUISITION_TOTAL

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                                        ");
            __builder.OpenElement(47, "td");
            __builder.AddAttribute(48, "scope", "col");
            __builder.AddContent(49, 
#nullable restore
#line 39 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\RequisitionList.razor"
                                                         item.STATUS

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\RequisitionList.razor"
                                }
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\RequisitionList.razor"
       
    List<PurchaseRequisitionViewEntity> requisitionList = new List<PurchaseRequisitionViewEntity>();

    protected override async Task OnInitializedAsync()
    {
        await GetPurchaseRequisition();
    }
    private async Task GetPurchaseRequisition()
    {
        requisitionList = await Http.GetJsonAsync<List<PurchaseRequisitionViewEntity>>(Utility.BaseUrl + "api/Purchase/GetPurchaseRequisitionList");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
