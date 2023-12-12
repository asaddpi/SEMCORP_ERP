// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TOCOMA_ERP_System.Pages.Purchase
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/PurchaseOrderList")]
    public partial class PurchaseOrderList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderList.razor"
       
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
        purchaseviewList_forPagination = await Http.GetJsonAsync<List<PurchaseOrderViewModel>>(Utility.BaseUrl + "api/Purchase/GetPurchaseList");
        display_row_no = 10;
        Pagination();
        StateHasChanged();
        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");
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
        AppState.porder= purchaseOrder;
        AppState.porderDetailsList = purchaseOrder.pOrderDetailsList;

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