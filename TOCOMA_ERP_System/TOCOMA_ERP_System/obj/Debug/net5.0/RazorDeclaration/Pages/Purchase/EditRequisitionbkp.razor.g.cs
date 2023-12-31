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
#line 6 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\EditRequisitionbkp.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/EditRequisition_bkp")]
    public partial class EditRequisitionbkp : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 161 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\EditRequisitionbkp.razor"
       

    private List<PurchaseRequisitionEntity> Customers { get; set; }
    PurchaseRequisitionEntity purchaseRequisition = new PurchaseRequisitionEntity();
    List<PurchaseRequisitionDetailsEntity> requisitionDetailsEntities = new List<PurchaseRequisitionDetailsEntity>();
    PurchaseRequisitionDetailsEntity details = new PurchaseRequisitionDetailsEntity();
    List<DepartmentEntity> departmentList = new List<DepartmentEntity>();
    List<ItemEntity> productList = new List<ItemEntity>();
    private ItemEntity SelectedArticle;
    List<OrderItemEntity> requestItemList = new List<OrderItemEntity>();
    string searchitem = "";
    OrderItemEntity orderitem;
    OrderItemEntity order_itm = null;
    string q = "";
    string r = "";
    string itemname = "";
    double requisitionTotal = 0;
    DateTime request_date = System.DateTime.Now;
    DateTime require_date = System.DateTime.Now;




    protected override async Task OnInitializedAsync()
    {
        await DepartmentList();
        await GetItemList();
    }
    private async Task GetItemList()
    {
        productList = await Http.GetJsonAsync<List<ItemEntity>>(Utility.BaseUrl + "api/Product");
    }

    private async Task<IEnumerable<ItemEntity>> SearchArticles(string searchText)
    {
        searchitem = searchText;
        return await Task.FromResult(productList.Where(x => x.ITEM_NAME.ToLower().Contains(searchText.ToLower())));
    }
    private async Task DepartmentList()
    {
        departmentList = await Http.GetJsonAsync<List<DepartmentEntity>>(Utility.BaseUrl + "api/Department");

    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {

        }
        //await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");
    }
    protected async Task AddItem()
    {
        bool alreadyExists = productList.Any(x => x.ITEM_NAME == itemname);
        order_itm = new OrderItemEntity();
        order_itm.ITEM_NAME = itemname;
        order_itm.Quantity = Convert.ToDouble(q);
        order_itm.Rate = Convert.ToDouble(r);
        if (alreadyExists == true) { order_itm.ITEM_ID = productList.FirstOrDefault(x => x.ITEM_NAME == itemname).ITEM_ID; }
        else
        {
            order_itm.ITEM_ID = await Http.GetJsonAsync<int>(Utility.BaseUrl + "api/Purchase/GetItemId/" + itemname);
        }

        order_itm.Total = Convert.ToDouble(order_itm.Quantity) * Convert.ToDouble(order_itm.Rate);
        requisitionTotal += order_itm.Total;
        requestItemList.Add(order_itm);

    }


    public async Task SavePurchaseRequision()
    {

        if (IsValidation() != true)
        {
            try
            {
                purchaseRequisition.REQUEST_DATE = request_date;
                //purchaseRequisition.REQUIRED_DATE = require_date;
                purchaseRequisition.REQUISITION_TOTAL = requisitionTotal;
                purchaseRequisition.STATUS = "Open";
                purchaseRequisition.REG_BY = "Asad";
                var data = await Http.PostJsonAsync<PurchaseRequisitionEntity>(Utility.BaseUrl + "api/Purchase", purchaseRequisition);
                var id = await Http.GetJsonAsync<int>(Utility.BaseUrl + "api/Purchase/GetPurchaseRequisitionId/" + purchaseRequisition.REQUISITION_NO);
                foreach (var item in requestItemList)
                {
                    details = new PurchaseRequisitionDetailsEntity();
                    details.PURCHASE_REQUISITION_ID = id;
                    details.REQUISITION_NO = purchaseRequisition.REQUISITION_NO;
                    details.ITEM_ID = item.ITEM_ID;
                    details.QUANTITY = item.Quantity;
                    details.RATE = item.Rate;
                    requisitionDetailsEntities.Add(details);
                }
                var requisition_details = await Http.PostJsonAsync<List<PurchaseRequisitionDetailsEntity>>(Utility.BaseUrl + "api/Purchase/AddPurchaseRequisitionDetails", requisitionDetailsEntities);
                toastService.ShowSuccess("Requisition Generate Successfully!!!");
            }
            catch (Exception ex)
            {

            }

        }
    }
    private bool IsValidation()
    {
        bool flag = false;
        if (purchaseRequisition.REQUISITION_NO == "" || purchaseRequisition.REQUISITION_NO == string.Empty || purchaseRequisition.REQUISITION_NO == null)
        {
            toastService.ShowWarning("Requisition No cannot be empty!");
            flag = true;
        }
        else if (purchaseRequisition.REQUESTED_BY == "" || purchaseRequisition.REQUESTED_BY == string.Empty || purchaseRequisition.REQUESTED_BY == null)
        {
            toastService.ShowWarning("Requested By cannot be empty!");
            flag = true;
        }
        else if (purchaseRequisition.REQUEST_DEPARTMENT_ID == 0)
        {
            toastService.ShowWarning("Please Select Department");
            flag = true;
        }
        else if (requestItemList.Count == 0)
        {
            toastService.ShowWarning("Please Select Requisition Item");
            flag = true;
        }

        return flag;
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
