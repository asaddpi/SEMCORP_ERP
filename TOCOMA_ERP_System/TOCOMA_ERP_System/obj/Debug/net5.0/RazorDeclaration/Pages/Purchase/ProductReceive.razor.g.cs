// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TOCOMA_ERP_System.Pages.Purchase
{
    #line hidden
    using System;
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
#line 3 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CustomLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/ProductReceive")]
    public partial class ProductReceive : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 213 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
       
    [Parameter]
    public string requisition_no { get; set; }
    //private ReportService _ReportService = new ReportService();
    DataSet DS_OUTPUT_DATA = new DataSet();
    List<ItemEntity> productList = new List<ItemEntity>();
    PurchaseOrderEntity purchaseOrder = new PurchaseOrderEntity();
    DateTime invoice_Date = System.DateTime.Now;
    DateTime document_Date = System.DateTime.Now;
    PurchaseOrderModel purchaseOrderModel = new PurchaseOrderModel();
    List<VendorEntity> vendorList = new List<VendorEntity>();
    PRE pp = new PRE();
    List<OrderItemEntity> requestItemList = new List<OrderItemEntity>();
    public string searchparam { get; set; }
    PurchaseOrderModel porderModel = new PurchaseOrderModel();

    Stock_Details_Model details = new Stock_Details_Model();
    List<PurchaseOrderViewModel> purchaseDetailsList = new List<PurchaseOrderViewModel>();
    List<Stock_Details_Model> stockDetailsList = new List<Stock_Details_Model>();

    List<EmployeeModel> employeeList = new List<EmployeeModel>();

    StockModel stock = new StockModel();
    List<WarehouseModel> warehouseList = new List<WarehouseModel>();

    //protected bool IsDisabled { get; set; }




    //[Parameter]
    //public string Format { get; set; } = "dd/mm/yyyy";


    public async Task GetProductDetailsBYPO()
    {
        string pono = purchaseOrderModel.PO_NUMBER_LONG_CODE;
        purchaseDetailsList = await Http.GetJsonAsync<List<PurchaseOrderViewModel>>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderDetailsByPO/" + pono);
    }

    protected override async Task OnInitializedAsync()
    {

        ////IsDisabled = true;
        //requestItemList = await Http.GetJsonAsync<List<OrderItemEntity>>(Utility.BaseUrl + "api/Purchase/GetRequisitionItemDetailsByReqNo/" + requisition_no);
        employeeList = await Http.GetJsonAsync<List<EmployeeModel>>(Utility.BaseUrl + "api/Employee");
        warehouseList = await Http.GetJsonAsync<List<WarehouseModel>>(Utility.BaseUrl + "api/Purchase/GetAllWarehouse");
        //purchaseDetailsList= await Http.GetJsonAsync<List<PurchaseOrderDetailsEntity>>(Utility.BaseUrl + "api/Purchase/GetRequisitionItemDetailsByReqNo/" + requisition_no);

    }
    public async Task SavePurchaseOrder()
    {

        if (IsValidation() != true)
        {
            try
            {
                stock.INVOICE_DATE = invoice_Date;
                stock.DOCUMENT_DATE = document_Date;
                stock.DESCRIPTION = "StockIn";
                stock.CUSTOMER_SUPPLIER_ID = purchaseDetailsList.First().VENDOR_ID;
                stock.PO_NO = purchaseDetailsList.First().PO_NUMBER_LONG_CODE;

                porderModel.RECEIVED_DATE = System.DateTime.Now;
                porderModel.PO_NUMBER_LONG_CODE= purchaseDetailsList.First().PO_NUMBER_LONG_CODE;
                porderModel.SHIPMENT_STATUS = "Success";
                var podata = await Http.PutJsonAsync<PurchaseOrderModel>(Utility.BaseUrl + "api/Purchase/UpdateGoodsReceiveInfo", porderModel);
                var data = await Http.PostJsonAsync<StockModel>(Utility.BaseUrl + "api/Stock", stock);
                var id = await Http.GetJsonAsync<int>(Utility.BaseUrl + "api/Stock/GetStockId/" + purchaseOrderModel.PO_NUMBER_LONG_CODE);
                foreach (var item in purchaseDetailsList)
                {
                    details = new Stock_Details_Model();
                    details.STOCK_ID = id;
                    details.ITEM_ID = item.ITEM_ID;
                    details.PACK_SIZE = item.PACK_SIZE;
                    details.UOM = item.UOM;
                    details.STOCK_IN_QUANTITY = Convert.ToDouble(item.QUANTITY);
                    details.UNIT_PRICE = item.UNIT_PRICE;
                    details.WAREHOUSE_ID = stock.WAREHOUSE_ID;

                    stockDetailsList.Add(details);
                }
                var stock_details = await Http.PostJsonAsync<List<Stock_Details_Model>>(Utility.BaseUrl + "api/Stock/AddStockDetails", stockDetailsList);
                var stock_summery = await Http.PostJsonAsync<List<Stock_Details_Model>>(Utility.BaseUrl + "api/Stock/AddStockSummery", stockDetailsList);

                toastService.ShowSuccess("Insert Successfully!!!");
            }
            catch (Exception ex)
            {

            }

        }
    }
    private bool IsValidation()
    {
        bool flag = false;
        //if (purchaseOrderModel.PO_NUMBER_LONG_CODE == "" || purchaseOrderModel.PO_NUMBER_LONG_CODE == string.Empty || purchaseOrderModel.PO_NUMBER_LONG_CODE == null)
        //{
        //    toastService.ShowWarning("Requisition No cannot be empty!");
        //    flag = true;
        //}

        return flag;
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeVoidAsync("JsInteropDatepicker");

    }

    //private void CreateOutputReport(DataSet reprotOutputData)
    //{
    //    PrintInformationOutputItem outputItem = new PrintInformationOutputItem();
    //    try
    //    {
    //        outputItem.dataSet = DS_OUTPUT_DATA;
    //        if (DS_OUTPUT_DATA != null && DS_OUTPUT_DATA.Tables[0].Rows.Count > 0)
    //        { _ReportService.output(OutputReportSupport.GetReportConfig(outputItem), outputItem.dataSet); }
    //        else { MessageBox.Show("", "Info"); }
    //    }
    //    catch (Exception ex)
    //    {  }

    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591