#pragma checksum "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\WorkOrderList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38aaafeea56591c6661eb7309d56481f65242c08"
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/WorkOrderList")]
    public partial class WorkOrderList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    table, tr, td {\r\n        /*border: none;*/\r\n        text-align: left;\r\n    }\r\n\r\n    table, tbody, tr, td {\r\n        /*padding:5px;*/\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-md-12");
            __builder.AddAttribute(3, "style", "display: flex;align-items:center;justify-content:space-between");
            __builder.AddMarkupContent(4, "<div class=\"col-md-4\"><h5>Work Order List</h5></div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class");
            __builder.AddAttribute(7, "style", "display:flex;gap:10px;align-items:center");
            __builder.AddMarkupContent(8, "<a href=\"SalesQuotation\"><button class=\"btn btn-primary\" style=\"display:flex;justify-content:center;height:40px;align-items:center;width:max-content;padding:0 10px\"><i class=\'bi bi-plus\' style=\"font-size:30px\"></i> New</button></a>\r\n\r\n\r\n        ");
            __builder.OpenElement(9, "label");
            __builder.AddAttribute(10, "style", "margin-bottom:0!important");
#nullable restore
#line 26 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\WorkOrderList.razor"
__builder.AddContent(11, StartNumber);

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "-");
#nullable restore
#line 26 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\WorkOrderList.razor"
__builder.AddContent(13, EndNumber);

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, " of ");
#nullable restore
#line 26 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\WorkOrderList.razor"
__builder.AddContent(15, quotationList.Count());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "style", "color:Highlight;");
            __builder.OpenElement(19, "i");
            __builder.AddAttribute(20, "class", "bi bi-arrow-left-circle");
            __builder.AddAttribute(21, "style", "font-size:30px");
            __builder.AddAttribute(22, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\WorkOrderList.razor"
                                                                                  e => NavigatTo("prev")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "style", "color:Highlight");
            __builder.OpenElement(26, "i");
            __builder.AddAttribute(27, "class", "bi bi-arrow-right-circle");
            __builder.AddAttribute(28, "style", "font-size:30px;");
            __builder.AddAttribute(29, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\WorkOrderList.razor"
                                                                                    e => NavigatTo("next")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(31, "table");
            __builder.AddAttribute(32, "id", "#example");
            __builder.AddAttribute(33, "width", "100%");
            __builder.AddMarkupContent(34, @"<thead><tr><td></td>            
            <td>Quotation No</td>
            <td>Work Order No</td>
            <td>Quotation Date</td>
            <td style=""text-align:left"">Customer</td>
            <td>Sales Person</td>
            <td>Status</td></tr></thead>
    ");
            __builder.OpenElement(35, "tbody");
#nullable restore
#line 56 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\WorkOrderList.razor"
         if (AllquotationList != null)
        {
            foreach (var item in AllquotationList)
            {                

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "tr");
            __builder.OpenElement(37, "td");
            __builder.AddAttribute(38, "style", "width:150px");
            __builder.OpenElement(39, "a");
            __builder.AddAttribute(40, "href", "WorkOrder/" + (
#nullable restore
#line 62 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\WorkOrderList.razor"
                                                                item.QUOTATION_NO

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "New Work Order");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "td");
            __builder.AddAttribute(44, "style", "width:150px");
            __builder.OpenElement(45, "a");
            __builder.AddAttribute(46, "style", "color:Highlight;cursor:pointer");
            __builder.AddAttribute(47, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\WorkOrderList.razor"
                                                                                                 () => GetSalesQuotationById(item.SALES_QUOTATION_ID)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 63 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\WorkOrderList.razor"
__builder.AddContent(48, item.QUOTATION_NO);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "td");
            __builder.AddAttribute(51, "style", "width:150px");
            __builder.OpenElement(52, "a");
#nullable restore
#line 64 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\WorkOrderList.razor"
__builder.AddContent(53, item.PO_WO_NUMBER);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n                    ");
            __builder.OpenElement(55, "td");
#nullable restore
#line 66 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\WorkOrderList.razor"
__builder.AddContent(56, item.QUOTATION_DATE);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.OpenElement(58, "td");
            __builder.AddAttribute(59, "style", "text-align:left");
#nullable restore
#line 67 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\WorkOrderList.razor"
__builder.AddContent(60, item.CUSTOMER_NAME);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.OpenElement(62, "td");
#nullable restore
#line 68 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\WorkOrderList.razor"
__builder.AddContent(63, item.SALES_PERSON);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                    ");
            __builder.OpenElement(65, "td");
#nullable restore
#line 69 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\WorkOrderList.razor"
__builder.AddContent(66, item.STATUS);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 72 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\WorkOrderList.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\WorkOrderList.razor"
       

    CustomerModel customer = new CustomerModel();
    List<CustomerViewModel> allcustomerList = new List<CustomerViewModel>();
    List<CustomerViewModel> customerList = new List<CustomerViewModel>();
    List<SalesQuotationView> AllquotationList = new List<SalesQuotationView>();
    List<SalesQuotationView> quotationList = new List<SalesQuotationView>();
    SalesQuotationView salesQuotationInfo = new SalesQuotationView();
    List<SalesQuotationItemView> salesQuotationItemList = new List<SalesQuotationItemView>();
    List<PurchaseTermsConditionsModel> termsConditionList = new List<PurchaseTermsConditionsModel>();
    List<ItemEntity> itemList = new List<ItemEntity>();
    public int pageSize { get; set; }
    public int TotalPage { get; set; }
    public int Currentpage { get; set; }
    public int StartNumber { get; set; }
    public int EndNumber { get; set; }
    bool checkStatus = false;
    int iOption = 0;

    protected override async Task OnInitializedAsync()
    {
        AllquotationList = await Http.GetJsonAsync<List<SalesQuotationView>>(Utility.BaseUrl + "api/Sales/GetAllQuotation");
        quotationList = await Http.GetJsonAsync<List<SalesQuotationView>>(Utility.BaseUrl + "api/Sales/GetAllQuotation");
        //AppState.salesQuotation = quotationList;
        //Pagination();
        StateHasChanged();
        await js.InvokeAsync<object>("TestDataTablesAdd", "#example");

        Pagination();
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
        AllquotationList = quotationList.Skip(pageNumber * pageSize).Take(pageSize).ToList();
        Currentpage = pageNumber;
        if (AllquotationList.Count > 0)
        {
            StartNumber = AllquotationList.FirstOrDefault().SL;
            EndNumber = AllquotationList[AllquotationList.Count - 1].SL;
        }

    }
    private void Pagination()
    {
        pageSize = 20;
        if (quotationList.Count > 0)
        {
            AllquotationList = quotationList.Take(pageSize).ToList();
            TotalPage = (int)Math.Ceiling(quotationList.Count() / (decimal)pageSize);
            StartNumber = AllquotationList.FirstOrDefault().SL;
            EndNumber = AllquotationList[AllquotationList.Count - 1].SL;
        }

    }
    async void CheckboxClicked(int poId, object checkedValue)
    {
        if ((bool)checkedValue)
        {

            await GetSalesQuotationById(poId);
            checkStatus = true;
            StateHasChanged();
        }
    }
    private async Task GetSalesQuotationById(int poId)
    {

        salesQuotationInfo = await Http.GetJsonAsync<SalesQuotationView>(Utility.BaseUrl + "api/Sales/GetsalesQuotationInfoById/" + poId);
        if (salesQuotationInfo.TERMS_AND_CONDITION != null && salesQuotationInfo.TERMS_AND_CONDITION != "")
        {
            termsConditionList = await Http.GetJsonAsync<List<PurchaseTermsConditionsModel>>(Utility.BaseUrl + "api/Sales/GetSalesTermsAndConditionsByIds/" + salesQuotationInfo.TERMS_AND_CONDITION);
            AppState.SalestermsConditionList = termsConditionList;
        }
        if (salesQuotationInfo.USED_PRODUCT != null)
        {
            itemList = await Http.GetJsonAsync<List<ItemEntity>>(Utility.BaseUrl + "api/Sales/GetItemListByUsedProduct/" + salesQuotationInfo.USED_PRODUCT);
            AppState.usedProductList = itemList;
        }

        //porder.REPORT_TYPE = "1";
        salesQuotationItemList = await Http.GetJsonAsync<List<SalesQuotationItemView>>(Utility.BaseUrl + "api/Sales/GetSalesQuotationItemListById/" + poId);
        //porder.pOrderDetailsList = purchaseOrderDetailsList;
        AppState.salesQuotation = salesQuotationInfo;
        AppState.salesQuotationitemList = salesQuotationItemList;

        await js.InvokeAsync<object>("open", "api/RDLCReport/GetSalesQuotation", "_blank");
    }
    private void Download()
    {
        if (checkStatus == true)
        {
            iOption = 1;
            StateHasChanged();


        }
        else { toastService.ShowWarning("Please Select Item For Download"); }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
