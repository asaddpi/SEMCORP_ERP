// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TOCOMA_ERP_System.HomePage
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
#nullable restore
#line 2 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\HomePage\Home.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CustomLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Home")]
    public partial class Home : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 252 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\HomePage\Home.razor"
       
    int DepartmentId;
    EmployeeModel empModel = new EmployeeModel();
    List<SalesQuotationView> quotationList = new List<SalesQuotationView>();
    SalesQuotationView salesQuotationInfo = new SalesQuotationView();
    List<PurchaseTermsConditionsModel> termsConditionList = new List<PurchaseTermsConditionsModel>();
    List<SalesQuotationItemView> salesQuotationItemList = new List<SalesQuotationItemView>();
    List<PurchaseOrderViewModel> poList = new List<PurchaseOrderViewModel>();
    List<PurchaseOrderDetailsEntity> purchaseOrderDetailsList = new List<PurchaseOrderDetailsEntity>();
    PurchaseOrderViewModel purchaseOrderView = new PurchaseOrderViewModel();
    List<ProjectCostReportModel> projectCostList = new List<ProjectCostReportModel>();
    public static string employeeImage;
    string mvalue ="215,000";
    protected override async Task OnInitializedAsync()
    {
        DepartmentId = 1;
        empModel.EMPLOYEE_ID = await sessionStorage.GetItemAsync<string>("session_employeeId");
        //empModel = await Http.GetJsonAsync<EmployeeModel>(Utility.BaseUrl + "api/Employee/GetEmployeeById/" + empModel.EMPLOYEE_ID);
        quotationList = await Http.GetJsonAsync<List<SalesQuotationView>>(Utility.BaseUrl + "api/Sales/GetAllQuotationCurrentYear");
        poList = await Http.GetJsonAsync<List<PurchaseOrderViewModel>>(Utility.BaseUrl + "api/Purchase/GetPOList");
        employeeImage = await localStorageService.GetItemAsync<string>("employeeImage");
        projectCostList = await Http.GetJsonAsync<List<ProjectCostReportModel>>(Utility.BaseUrl + "api/Purchase/GetProjectwiseCost");
    }
    async void PaymentTypeSelect(ChangeEventArgs e)
    {
        //SelectedPaymentType = e.Value.ToString();
        projectCostList = await Http.GetJsonAsync<List<ProjectCostReportModel>>(Utility.BaseUrl + "api/Purchase/GetProjectwiseCost");

        StateHasChanged();

    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JsRuntime.InvokeVoidAsync("JsInteropcollaps");
            //await ijsruntime.InvokeAsync<string>(
            //    "QuillFunctions.createQuill", divEditorElement);

            employeeImage = await localStorageService.GetItemAsync<string>("employeeImage");
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

        //porder.REPORT_TYPE = "1";
        salesQuotationItemList = await Http.GetJsonAsync<List<SalesQuotationItemView>>(Utility.BaseUrl + "api/Sales/GetSalesQuotationItemListById/" + poId);
        //porder.pOrderDetailsList = purchaseOrderDetailsList;
        AppState.salesQuotation = salesQuotationInfo;
        AppState.salesQuotationitemList = salesQuotationItemList;

        await JsRuntime.InvokeAsync<object>("open", "api/RDLCReport/GetSalesQuotation", "_blank");
    }
    public async Task PurchaseOrderInvoice(string po_number)
    {
        //string packInsId = "";
        //string termsId = "";
        //List<PackagingInstructionModel> packagingInsList = new List<PackagingInstructionModel>();
        //List<PurchaseTermsConditionsModel> termsConditionList = new List<PurchaseTermsConditionsModel>();
        ////purchaseOrderView = new PurchaseOrderViewModel();
        ////purchaseOrderDetailsList = new List<PurchaseOrderDetailsEntity>();





        purchaseOrderView = await Http.GetJsonAsync<PurchaseOrderViewModel>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderInfo/" + po_number);
        if (purchaseOrderView.VENDOR_TYPE_STATUS == "Local")
        {
            await GetLocal(purchaseOrderView.PO_NUMBER_LONG_CODE);
        }
        else if (purchaseOrderView.VENDOR_TYPE_STATUS == "International")
        {
            await GetInt(purchaseOrderView.PO_NUMBER_LONG_CODE);
        }
        //purchaseOrderDetailsList = await Http.GetJsonAsync<List<PurchaseOrderDetailsEntity>>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderDetailsByPO_NO/" + po_number);
        //packInsId = purchaseOrderView.PACKAGING_INSTRUCTION;
        //termsId = purchaseOrderView.OTHER_TERMS_AND_CONDITION;
        //if (packInsId != null && packInsId!="") { packagingInsList = await Http.GetJsonAsync<List<PackagingInstructionModel>>(Utility.BaseUrl + "api/Purchase/GetPackagingInstructionById/" + packInsId); }
        //if (termsId != null && termsId !="") { termsConditionList = await Http.GetJsonAsync<List<PurchaseTermsConditionsModel>>(Utility.BaseUrl + "api/Purchase/GetTermsAndConditions/" + termsId); }
        //AppState.porder = purchaseOrderView;
        //AppState.porderDetails = purchaseOrderDetailsList;
        //AppState.termsConditionList = termsConditionList;
        //if (purchaseOrderView.VENDOR_TYPE_STATUS=="Local")
        //{ await js.InvokeAsync<object>("open", "api/RDLCReport/GetPurchaseOrderInvoiceLocal", "_blank"); }
        //else if(purchaseOrderView.VENDOR_TYPE_STATUS == "International")
        //{ await js.InvokeAsync<object>("open", "api/RDLCReport/GetPurchaseOrderInvoiceInt", "_blank"); }


    }

    private async Task GetLocal(string po_number)
    {
        string packInsId = "";
        string termsId = "";
        List<PackagingInstructionModel> packagingInsList = new List<PackagingInstructionModel>();
        List<PurchaseTermsConditionsModel> termsConditionList = new List<PurchaseTermsConditionsModel>();
        purchaseOrderDetailsList = await Http.GetJsonAsync<List<PurchaseOrderDetailsEntity>>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderDetailsByPO_NO/" + po_number);
        packInsId = purchaseOrderView.PACKAGING_INSTRUCTION;
        termsId = purchaseOrderView.OTHER_TERMS_AND_CONDITION;
        if (packInsId != null && packInsId != "") { packagingInsList = await Http.GetJsonAsync<List<PackagingInstructionModel>>(Utility.BaseUrl + "api/Purchase/GetPackagingInstructionById/" + packInsId); }
        if (termsId != null && termsId != "") { termsConditionList = await Http.GetJsonAsync<List<PurchaseTermsConditionsModel>>(Utility.BaseUrl + "api/Purchase/GetTermsAndConditions/" + termsId); }
        AppState.porder = purchaseOrderView;
        AppState.porderDetails = purchaseOrderDetailsList;
        AppState.termsConditionList = termsConditionList;

        await JsRuntime.InvokeAsync<object>("open", "api/RDLCReport/GetPurchaseOrderInvoiceLocal", "_blank");
    }
    private async Task GetInt(string po_number)
    {
        string packInsId = "";
        string termsId = "";
        List<PackagingInstructionModel> packagingInsList = new List<PackagingInstructionModel>();
        List<PurchaseTermsConditionsModel> termsConditionList = new List<PurchaseTermsConditionsModel>();
        purchaseOrderDetailsList = await Http.GetJsonAsync<List<PurchaseOrderDetailsEntity>>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderDetailsByPO_NO/" + po_number);
        packInsId = purchaseOrderView.PACKAGING_INSTRUCTION;
        termsId = purchaseOrderView.OTHER_TERMS_AND_CONDITION;
        if (packInsId != null && packInsId != "") { packagingInsList = await Http.GetJsonAsync<List<PackagingInstructionModel>>(Utility.BaseUrl + "api/Purchase/GetPackagingInstructionById/" + packInsId); }
        if (termsId != null && termsId != "") { termsConditionList = await Http.GetJsonAsync<List<PurchaseTermsConditionsModel>>(Utility.BaseUrl + "api/Purchase/GetTermsAndConditions/" + termsId); }
        AppState.porder = purchaseOrderView;
        AppState.porderDetails = purchaseOrderDetailsList;
        AppState.termsConditionList = termsConditionList;
        AppState.packagingList = packagingInsList;

        await JsRuntime.InvokeAsync<object>("open", "api/RDLCReport/GetPurchaseOrderInvoiceInt", "_blank");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorageService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.JSInterop.IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
