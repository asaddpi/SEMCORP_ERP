#pragma checksum "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Project\Purchase.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77c084d2b86b8d2610687a9cf159801b2162bc7d"
// <auto-generated/>
#pragma warning disable 1591
namespace TOCOMA_ERP_System.Pages.Project
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Purchase")]
    public partial class Purchase : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    table, tr, td {\r\n        border: none;\r\n        text-align: center;\r\n    }\r\n\r\n    table, tbody, tr, td {\r\n        padding: 5px;\r\n    }\r\n</style>\r\n\r\n");
            __builder.AddMarkupContent(1, @"<div class=""col-md-12"" style=""display: flex;align-items:center;justify-content:space-between""><div class=""col-md-4""><h5 style=""color:lightgreen"">Purchase List</h5></div>
    <div class style=""display:flex;gap:10px;align-items:center""><a href=""PurchaseforProject""><button class=""btn btn-primary"" style=""display:flex;justify-content:center;height:40px;align-items:center;width:max-content;padding:0 10px""><i class=""bi bi-plus"" style=""font-size:30px""></i> New</button></a></div></div>


<hr>

");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "id", "#example");
            __builder.AddAttribute(4, "width", "100%");
            __builder.AddMarkupContent(5, "<thead style=\"background-color:lightgreen\"><tr><td>Voucher No.</td>            \r\n            <td>Po Date</td>\r\n            <td>Memo No.</td>\r\n            <td>Supplier</td>\r\n            <td>Total</td>\r\n            <td></td></tr></thead>\r\n    ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 47 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Project\Purchase.razor"
         if (purchaseviewList != null)
        {
            foreach (var item in purchaseviewList)
            {                

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddAttribute(9, "style", "text-align:center;width:100px");
            __builder.OpenElement(10, "a");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Project\Purchase.razor"
                                                                            () => GetPurchaseOrder(item.VOUCHER_NO)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, 
#nullable restore
#line 53 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Project\Purchase.razor"
                                                                                                                      item.VOUCHER_NO

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddAttribute(15, "style", "width:100px;text-align:center");
            __builder.AddContent(16, 
#nullable restore
#line 54 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Project\Purchase.razor"
                                                               item.PO_DATE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddAttribute(19, "style", "width:100px");
            __builder.AddContent(20, 
#nullable restore
#line 55 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Project\Purchase.razor"
                                             item.SUPPLIER_MEMO_NO

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddAttribute(23, "style", "text-align:center");
            __builder.AddContent(24, 
#nullable restore
#line 56 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Project\Purchase.razor"
                                                   item.VENDOR_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 57 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Project\Purchase.razor"
                         item.GRAND_TOTAL

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "href", "DailyPurchaseForProject/" + (
#nullable restore
#line 58 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Project\Purchase.razor"
                                                          item.VOUCHER_NO

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "View Details");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Project\Purchase.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n<hr>\r\n");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class");
            __builder.AddAttribute(36, "style", "display:flex;gap:10px;align-items:center");
            __builder.OpenElement(37, "label");
            __builder.AddAttribute(38, "style", "margin-bottom:0!important");
            __builder.AddContent(39, 
#nullable restore
#line 69 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Project\Purchase.razor"
                                              StartNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(40, "-");
            __builder.AddContent(41, 
#nullable restore
#line 69 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Project\Purchase.razor"
                                                           EndNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(42, " of ");
            __builder.AddContent(43, 
#nullable restore
#line 69 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Project\Purchase.razor"
                                                                         purchaseviewList_forPagination.Count()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.OpenElement(45, "a");
            __builder.AddAttribute(46, "style", "color:Highlight;");
            __builder.OpenElement(47, "i");
            __builder.AddAttribute(48, "class", "bi bi-arrow-left-circle");
            __builder.AddAttribute(49, "style", "font-size:30px");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Project\Purchase.razor"
                                                                              e => NavigatTo("prev")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.OpenElement(52, "a");
            __builder.AddAttribute(53, "style", "color:Highlight");
            __builder.OpenElement(54, "i");
            __builder.AddAttribute(55, "class", "bi bi-arrow-right-circle");
            __builder.AddAttribute(56, "style", "font-size:30px;");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Project\Purchase.razor"
                                                                                e => NavigatTo("next")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Project\Purchase.razor"
       
    List<PurchaseOrderViewModel> purchaseviewList_forPagination = new List<PurchaseOrderViewModel>();
    List<PurchaseOrderViewModel> purchaseviewList = new List<PurchaseOrderViewModel>();
    PurchaseOrderViewModel purchaseOrder = new PurchaseOrderViewModel();
    public int pageSize { get; set; }
    public int TotalPage { get; set; }
    public int Currentpage { get; set; }
    public int StartNumber { get; set; }
    public int EndNumber { get; set; }
    public int display_row_no { get; set; }
    protected override async Task OnInitializedAsync()
    {
        purchaseviewList = await Http.GetJsonAsync<List<PurchaseOrderViewModel>>(Utility.BaseUrl + "api/Purchase/GetPurchaseList");
        purchaseviewList_forPagination = await Http.GetJsonAsync<List<PurchaseOrderViewModel>>(Utility.BaseUrl + "api/Purchase/GetPurchaseList" );
        display_row_no = 10;
        Pagination();
        //StateHasChanged();
        //await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");
    }
    private void Pagination()
    {
        pageSize = display_row_no;
        if (purchaseviewList_forPagination.Count > 0)
        {
            purchaseviewList = purchaseviewList_forPagination.Take(pageSize).ToList();
            TotalPage = (int)Math.Ceiling(purchaseviewList_forPagination.Count() / (decimal)pageSize);
            StartNumber = purchaseviewList.FirstOrDefault().SL;
            EndNumber = purchaseviewList[purchaseviewList.Count - 1].SL;
        }

    }
    private void NavigatTo(string direction)
    {
        if (direction == "prev" && Currentpage != 0)
            Currentpage -= 1;
        if (direction == "next" && Currentpage != TotalPage - 1)
            Currentpage += 1;

        UpdateList(Currentpage);
    }
    private void UpdateList(int pageNumber)
    {
        purchaseviewList = purchaseviewList_forPagination.Skip(pageNumber * pageSize).Take(pageSize).ToList();
        Currentpage = pageNumber;
        if (purchaseviewList.Count > 0)
        {
            StartNumber = purchaseviewList.FirstOrDefault().SL;
            EndNumber = purchaseviewList[purchaseviewList.Count - 1].SL;
        }

    }
    private async Task GetPurchaseOrder(string quotationNo)
    {

        purchaseOrder = await Http.GetJsonAsync<PurchaseOrderViewModel>(Utility.BaseUrl + "api/Purchase/GetPurchaseListByQuotationNo/" + quotationNo);
        //if (salesQuotationInfo.TERMS_AND_CONDITION != null && salesQuotationInfo.TERMS_AND_CONDITION != "")
        //{
        //    termsConditionList = await Http.GetJsonAsync<List<PurchaseTermsConditionsModel>>(Utility.BaseUrl + "api/Sales/GetSalesTermsAndConditionsByIds/" + salesQuotationInfo.TERMS_AND_CONDITION);
        //    AppState.SalestermsConditionList = termsConditionList;
        //}

        ////porder.REPORT_TYPE = "1";
        //salesQuotationItemList = await Http.GetJsonAsync<List<SalesQuotationItemView>>(Utility.BaseUrl + "api/Sales/GetSalesQuotationItemListByByQuotationNo/" + quotationNo);
        ////porder.pOrderDetailsList = purchaseOrderDetailsList;
        //AppState.salesQuotation = salesQuotationInfo;
        //AppState.salesQuotationitemList = salesQuotationItemList;

        await JSRuntime.InvokeAsync<object>("open", "api/RDLCReport/GetPurchaseOrder", "_blank");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
