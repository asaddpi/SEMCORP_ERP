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
#nullable restore
#line 13 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderTracking.razor"
using AspNetCore.Reporting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderTracking.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderTracking.razor"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderTracking.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderTracking.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderTracking.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CustomLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/PurchaseOrderTracking")]
    public partial class PurchaseOrderTracking : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 440 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\PurchaseOrderTracking.razor"
       

    List<PurchaseOrderViewModel> purchaseOrderList = new List<PurchaseOrderViewModel>();
    List<PurchaseOrderViewModel> pOrderList = new List<PurchaseOrderViewModel>();
    List<PurchaseOrderViewModel> pOrderList1 = new List<PurchaseOrderViewModel>();
    PurchaseOrderModel pOrderModel = new PurchaseOrderModel();
    List<PurchaseOrderDetailsEntity> porderDetails = new List<PurchaseOrderDetailsEntity>();
    List<string> numbers;

    //numbers= nos.Split(',').ToList<string>();
    string receivedDate;
    string Vendor;
    string PODate;
    string concernPerson;
    protected bool ETD_1st_Date_IsDisabled { get; set; }
    protected bool ETD_2nd_Date_IsDisabled { get; set; }
    protected bool ETD_3rd_Date_IsDisabled { get; set; }
    protected bool ETD_4th_Date_IsDisabled { get; set; }

    protected bool ETD_1st_Date_CheckStatus { get; set; }
    protected bool ETD_2nd_Date_CheckStatus { get; set; }
    protected bool ETD_3rd_Date_CheckStatus { get; set; }
    protected bool ETD_4th_Date_CheckStatus { get; set; }

    //----------------------

    protected bool ETA_1st_Date_IsDisabled { get; set; }
    protected bool ETA_2nd_Date_IsDisabled { get; set; }
    protected bool ETA_3rd_Date_IsDisabled { get; set; }
    protected bool ETA_4th_Date_IsDisabled { get; set; }

    protected bool ETA_1st_Date_CheckStatus { get; set; }
    protected bool ETA_2nd_Date_CheckStatus { get; set; }
    protected bool ETA_3rd_Date_CheckStatus { get; set; }
    protected bool ETA_4th_Date_CheckStatus { get; set; }

    //----------------

    protected bool EA_1st_Date_IsDisabled { get; set; }
    protected bool EA_2nd_Date_IsDisabled { get; set; }
    protected bool EA_3rd_Date_IsDisabled { get; set; }
    protected bool EA_4th_Date_IsDisabled { get; set; }

    protected bool EA_1st_Date_CheckStatus { get; set; }
    protected bool EA_2nd_Date_CheckStatus { get; set; }
    protected bool EA_3rd_Date_CheckStatus { get; set; }
    protected bool EA_4th_Date_CheckStatus { get; set; }

    protected bool Received_Date_IsDisabled { get; set; }
    protected bool Received_Date_CheckStatus { get; set; }
    DateTime ETD_1st_Date = System.DateTime.Now;
    DateTime ETD_2nd_Date = System.DateTime.Now;
    DateTime ETD_3rd_Date = System.DateTime.Now;
    DateTime ETD_4th_Date = System.DateTime.Now;

    DateTime ETA_1st_Date = System.DateTime.Now;
    DateTime ETA_2nd_Date = System.DateTime.Now;
    DateTime ETA_3rd_Date = System.DateTime.Now;
    DateTime ETA_4th_Date = System.DateTime.Now;

    DateTime EA_1st_Date = System.DateTime.Now;
    DateTime EA_2nd_Date = System.DateTime.Now;
    DateTime EA_3rd_Date = System.DateTime.Now;
    DateTime EA_4th_Date = System.DateTime.Now;
    DateTime Received_Date = System.DateTime.Now;

    public int pageSize { get; set; }
    public int TotalPage { get; set; }
    public int Currentpage { get; set; }
    public int StartNumber { get; set; }
    public int EndNumber { get; set; }
    string message;

    protected override async Task OnInitializedAsync()
    {
        await GetAllData();
        pOrderList = await Http.GetJsonAsync<List<PurchaseOrderViewModel>>(Utility.BaseUrl + "api/Purchase/GetPOTrackingList");
        pOrderList1 = await Http.GetJsonAsync<List<PurchaseOrderViewModel>>(Utility.BaseUrl + "api/Purchase/GetPOTrackingList");
        AppState.purchaseOrderList = pOrderList;
        Pagination();
        StateHasChanged();
        await JsRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");
    }

    private async Task GetAllData()
    {
        purchaseOrderList = await Http.GetJsonAsync<List<PurchaseOrderViewModel>>(Utility.BaseUrl + "api/Purchase/GetPOTrackingList");
        porderDetails = await Http.GetJsonAsync<List<PurchaseOrderDetailsEntity>>(Utility.BaseUrl + "api/Purchase/GetAllPurchaseOrderDetails");
        List<PurchaseOrderDetailsEntity> podetails = new List<PurchaseOrderDetailsEntity>();
        PurchaseOrderDetailsEntity podetails1 = new PurchaseOrderDetailsEntity();
        foreach (var item in purchaseOrderList)
        {
            try
            {
                podetails = porderDetails.FindAll(el => el.PO_ID == item.PO_ID);
                foreach (var l in podetails)
                {
                    podetails1 = new PurchaseOrderDetailsEntity();
                    if (item.pOrderDetailsList == null)
                    { item.pOrderDetailsList = new List<PurchaseOrderDetailsEntity>(); }
                    podetails1.ITEM_NAME = l.ITEM_NAME;
                    podetails1.ITEM_ID = l.ITEM_ID;
                    podetails1.PO_ID = l.PO_ID;
                    podetails1.UOM = l.UOM;
                    podetails1.QUANTITY = l.QUANTITY;
                    item.pOrderDetailsList.Add(podetails1);
                }
            }
            catch (Exception ex)
            {

            }
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
        purchaseOrderList = pOrderList.Skip(pageNumber * pageSize).Take(pageSize).ToList();
        Currentpage = pageNumber;
        if (purchaseOrderList.Count > 0)
        {
            StartNumber = purchaseOrderList.FirstOrDefault().SL;
            EndNumber = purchaseOrderList[purchaseOrderList.Count - 1].SL;
        }

    }
    private void Pagination()
    {
        pageSize = 20;
        if (pOrderList.Count > 0)
        {
            pOrderList1 = pOrderList.Take(pageSize).ToList();
            TotalPage = (int)Math.Ceiling(pOrderList.Count() / (decimal)pageSize);
            StartNumber = pOrderList1.FirstOrDefault().SL;
            EndNumber = pOrderList1[pOrderList1.Count - 1].SL;
        }

    }
    async void ETD_1st_Date_CheckboxClicked(object checkedValue)
    {
        if ((bool)checkedValue)
        { ETD_1st_Date_IsDisabled = false; }
        else
        { ETD_1st_Date_IsDisabled = true; }
    }
    async void ETD_2nd_Date_CheckboxClicked(object checkedValue)
    {
        if ((bool)checkedValue)
        { ETD_2nd_Date_IsDisabled = false; }
        else
        { ETD_2nd_Date_IsDisabled = true; }
    }
    async void ETD_3rd_Date_CheckboxClicked(object checkedValue)
    {
        if ((bool)checkedValue)
        { ETD_3rd_Date_IsDisabled = false; }
        else
        { ETD_3rd_Date_IsDisabled = true; }
    }
    async void ETD_4th_Date_CheckboxClicked(object checkedValue)
    {
        if ((bool)checkedValue)
        { ETD_4th_Date_IsDisabled = false; }
        else
        { ETD_4th_Date_IsDisabled = true; }
    }
    async void ETA_1st_Date_CheckboxClicked(object checkedValue)
    {
        if ((bool)checkedValue)
        { ETA_1st_Date_IsDisabled = false; }
        else
        { ETA_1st_Date_IsDisabled = true; }
    }
    async void ETA_2nd_Date_CheckboxClicked(object checkedValue)
    {
        if ((bool)checkedValue)
        { ETA_2nd_Date_IsDisabled = false; }
        else
        { ETA_2nd_Date_IsDisabled = true; }
    }
    async void ETA_3rd_Date_CheckboxClicked(object checkedValue)
    {
        if ((bool)checkedValue)
        { ETA_3rd_Date_IsDisabled = false; }
        else
        { ETA_3rd_Date_IsDisabled = true; }
    }
    async void ETA_4th_Date_CheckboxClicked(object checkedValue)
    {
        if ((bool)checkedValue)
        { ETA_4th_Date_IsDisabled = false; }
        else
        { ETA_4th_Date_IsDisabled = true; }
    }
    async void EA_1st_Date_CheckboxClicked(object checkedValue)
    {
        if ((bool)checkedValue)
        { EA_1st_Date_IsDisabled = false; }
        else
        { EA_1st_Date_IsDisabled = true; }
    }
    async void EA_2nd_Date_CheckboxClicked(object checkedValue)
    {
        if ((bool)checkedValue)
        { EA_2nd_Date_IsDisabled = false; }
        else
        { EA_2nd_Date_IsDisabled = true; }
    }
    async void EA_3rd_Date_CheckboxClicked(object checkedValue)
    {
        if ((bool)checkedValue)
        { EA_3rd_Date_IsDisabled = false; }
        else
        { EA_3rd_Date_IsDisabled = true; }
    }
    async void EA_4th_Date_CheckboxClicked(object checkedValue)
    {
        if ((bool)checkedValue)
        { EA_4th_Date_IsDisabled = false; }
        else
        { EA_4th_Date_IsDisabled = true; }
    }
    async void Received_Date_CheckboxClicked(object checkedValue)
    {
        if ((bool)checkedValue)
        { Received_Date_IsDisabled = false; }
        else
        { Received_Date_IsDisabled = true; }
    }
    private async Task GetPOData(int Id)
    {
        try
        {
            pOrderModel.PO_NUMBER_LONG_CODE = purchaseOrderList.Find(x => x.PO_ID == Id).PO_NUMBER_LONG_CODE;
            PODate = purchaseOrderList.Find(x => x.PO_ID == Id).PO_DATE;
            Vendor = purchaseOrderList.Find(x => x.PO_ID == Id).VENDOR_NAME;
            concernPerson = purchaseOrderList.Find(x => x.PO_ID == Id).CONTACT_PERSON_NAME;
            pOrderModel.ETD_1st_Date = purchaseOrderList.Find(x => x.PO_ID == Id).ETD_1st_Date;
            pOrderModel.ETD_2nd_Date = purchaseOrderList.Find(x => x.PO_ID == Id).ETD_2nd_Date;
            pOrderModel.ETD_3rd_Date = purchaseOrderList.Find(x => x.PO_ID == Id).ETD_3rd_Date;
            pOrderModel.ETA_1st_Date = purchaseOrderList.Find(x => x.PO_ID == Id).ETA_1st_Date;
            pOrderModel.ETA_2nd_Date = purchaseOrderList.Find(x => x.PO_ID == Id).ETA_2nd_Date;
            pOrderModel.ETA_3rd_Date = purchaseOrderList.Find(x => x.PO_ID == Id).ETA_3rd_Date;
            pOrderModel.EA_WH_1st_Date = purchaseOrderList.Find(x => x.PO_ID == Id).EA_WH_1st_Date;
            pOrderModel.EA_WH_2nd_Date = purchaseOrderList.Find(x => x.PO_ID == Id).EA_WH_2nd_Date;
            pOrderModel.EA_WH_3rd_Date = purchaseOrderList.Find(x => x.PO_ID == Id).EA_WH_3rd_Date;
            receivedDate = Convert.ToString(purchaseOrderList.Find(x => x.PO_ID == Id).RECEIVED_DATE);
            pOrderModel.SHIPMENT_STATUS = purchaseOrderList.Find(x => x.PO_ID == Id).SHIPMENT_STATUS;
            pOrderModel.LC_NO = purchaseOrderList.Find(x => x.PO_ID == Id).LC_NO;
            pOrderModel.LC_DATE = purchaseOrderList.Find(x => x.PO_ID == Id).LC_DATE;
            pOrderModel.LC_STATUS = purchaseOrderList.Find(x => x.PO_ID == Id).LC_STATUS;
        }
        catch (Exception ex)
        {
            message = ex.Message;
        }



        StateHasChanged();
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JsRuntime.InvokeVoidAsync("JsInteropDatepicker");
    }
    public async Task UpdateShipment()
    {
        try
        {
            if (receivedDate == "" || receivedDate == null)
            { pOrderModel.RECEIVED_DATE = null; }
            else { pOrderModel.RECEIVED_DATE = Convert.ToDateTime(receivedDate); }

            var data = await Http.PutJsonAsync<PurchaseOrderModel>(Utility.BaseUrl + "api/Purchase/UpdateShipmentInfo", pOrderModel);
            toastService.ShowSuccess("Update Success!!!");
            await GetAllData();
        }
        catch (Exception ex)
        {
            toastService.ShowError("Data not update!" + ex.Message);

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SessionData sessionData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage ProtectedLocalStore { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.JSInterop.IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SessionState state { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591