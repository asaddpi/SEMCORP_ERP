#pragma checksum "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Admin\RequisitionApproval.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ad3a3a3983765bc334e2c2e6b7d5557f0978729"
// <auto-generated/>
#pragma warning disable 1591
namespace TOCOMA_ERP_System.Admin
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/RequisitionApproval")]
    public partial class RequisitionApproval : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "dashboard-details");
            __builder.AddMarkupContent(2, "<h4 class=\"p-2\"><img src=\"images/fountain-pen.png\" alt width=\"50\" height=\"50\" class=\"mr-3\"><span class=\"text-uppercase\">Pending Request For Approval</span></h4>\r\n    ");
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
                                <td scope=""col"">Request For</td>
                                <td scope=""col"">Request Date</td>
                                <td scope=""col"">Require Date</td>
                                <td scope=""col"">Requisition Total</td>
                                <td scope=""col"">Status</td>
                                <td></td></tr></thead>
                        ");
            __builder.OpenElement(14, "tbody");
#nullable restore
#line 28 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Admin\RequisitionApproval.razor"
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
            __builder.AddAttribute(19, "href", "ViewPurchaseRequisitionDetails/" + (
#nullable restore
#line 33 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Admin\RequisitionApproval.razor"
                                                                                                 item.REQUISITION_NO

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "VIEW DETAILS");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                                        ");
            __builder.OpenElement(22, "td");
            __builder.AddAttribute(23, "scope", "col");
            __builder.AddContent(24, 
#nullable restore
#line 34 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Admin\RequisitionApproval.razor"
                                                         item.REQUISITION_NO

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                                        ");
            __builder.OpenElement(26, "td");
            __builder.AddAttribute(27, "scope", "col");
            __builder.AddContent(28, 
#nullable restore
#line 35 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Admin\RequisitionApproval.razor"
                                                         item.REQUESTED_BY

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                                        ");
            __builder.OpenElement(30, "td");
            __builder.AddAttribute(31, "scope", "col");
            __builder.AddContent(32, 
#nullable restore
#line 36 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Admin\RequisitionApproval.razor"
                                                         item.DEPARTMENT_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                                        ");
            __builder.OpenElement(34, "td");
            __builder.AddAttribute(35, "scope", "col");
            __builder.AddContent(36, 
#nullable restore
#line 37 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Admin\RequisitionApproval.razor"
                                                         item.REQUEST_FOR

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                                        ");
            __builder.OpenElement(38, "td");
            __builder.AddAttribute(39, "scope", "col");
            __builder.AddContent(40, 
#nullable restore
#line 38 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Admin\RequisitionApproval.razor"
                                                         item.REQUEST_DATE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                                        ");
            __builder.OpenElement(42, "td");
            __builder.AddAttribute(43, "scope", "col");
            __builder.AddContent(44, 
#nullable restore
#line 39 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Admin\RequisitionApproval.razor"
                                                         item.REQUIRED_DATE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                                        ");
            __builder.OpenElement(46, "td");
            __builder.AddAttribute(47, "scope", "col");
            __builder.AddContent(48, 
#nullable restore
#line 40 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Admin\RequisitionApproval.razor"
                                                         item.REQUISITION_TOTAL

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                                        ");
            __builder.OpenElement(50, "td");
            __builder.OpenElement(51, "select");
            __builder.AddAttribute(52, "name", "");
            __builder.AddAttribute(53, "id", "");
            __builder.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Admin\RequisitionApproval.razor"
                                                                          item.STATUS

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.STATUS = __value, item.STATUS));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(56, "option");
            __builder.AddAttribute(57, "value");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                                                ");
            __builder.OpenElement(59, "option");
            __builder.AddAttribute(60, "value", "Open");
            __builder.AddContent(61, "Open");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                                                ");
            __builder.OpenElement(63, "option");
            __builder.AddAttribute(64, "value", "Approved");
            __builder.AddContent(65, "Approved");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                                                ");
            __builder.OpenElement(67, "option");
            __builder.AddAttribute(68, "value", "Not Approved");
            __builder.AddContent(69, "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                                        ");
            __builder.OpenElement(71, "td");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Admin\RequisitionApproval.razor"
                                                               () => ChangeStatus(item.REQUISITION_NO,item.STATUS)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "class", "btn btn-info");
            __builder.AddContent(75, "Done");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Admin\RequisitionApproval.razor"
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
#line 65 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Admin\RequisitionApproval.razor"
       
    List<PurchaseRequisitionViewEntity> requisitionList = new List<PurchaseRequisitionViewEntity>();

    protected override async Task OnInitializedAsync()
    {
        await GetPurchaseRequisition();
    }
    private async Task GetPurchaseRequisition()
    {
        requisitionList = await Http.GetJsonAsync<List<PurchaseRequisitionViewEntity>>(Utility.BaseUrl + "api/Purchase/GetPurchaseRequisitionList_ForApproval");
    }
    private async void ChangeStatus(string ReqNo, string Status)
    {
        PurchaseRequisitionEntity p = new PurchaseRequisitionEntity();
        p.REQUISITION_NO = ReqNo;
        p.STATUS = Status;

        await Http.PutJsonAsync<PurchaseRequisitionEntity>(Utility.BaseUrl + "api/Purchase/UpdateRequisitionStatus", p);
        await GetPurchaseRequisition();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
