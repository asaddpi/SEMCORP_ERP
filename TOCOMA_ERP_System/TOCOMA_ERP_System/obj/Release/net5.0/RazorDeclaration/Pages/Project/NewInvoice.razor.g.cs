// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 7 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Project\NewInvoice.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CustomLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/NewInvoice/{woNO}")]
    public partial class NewInvoice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 379 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Project\NewInvoice.razor"
       
    PurchaseOrderModel porderModel = new PurchaseOrderModel();
    List<VendorEntity> vendorList = new List<VendorEntity>();
    List<UnitModel> unitList = new List<UnitModel>();
    UnitModel unit = new UnitModel();
    string vendor_name;
    LedgerModel ledger = new LedgerModel();
    List<ItemEntity> itemNameList = new List<ItemEntity>();
    List<BranchModel> branchList = new List<BranchModel>();
    string MyProperty;
    List<string> itemList = new List<string>();
    private ElementReference inputElement;
    private ElementReference keyDownDiv;
    string EventInfo = "";
    private ElementReference testRef;
    private ElementReference QtyInput;
    private string pressedKey;
    private VendorEntity SelectedVendor;
    List<VendorEntity> options;
    BlazoredTextEditor terms_Condition;

    List<PurchaseOrderDetailsEntity> voucherItemList = new List<PurchaseOrderDetailsEntity>();
    PurchaseOrderDetailsEntity itemdetails = new PurchaseOrderDetailsEntity();
    ItemEntity itemEntity = new ItemEntity();
    VoucherItem paymentvoucher = new VoucherItem();
    ACC_COMPANY_VOUCHER_MODEL accCompanyVoucherModel = new ACC_COMPANY_VOUCHER_MODEL();
    List<PurchaseOrderDetailsEntity> paymentVoucherDetails = new List<PurchaseOrderDetailsEntity>();
    ACC_VOUCHER_MODEL voucherDetails = new ACC_VOUCHER_MODEL();
    List<EmployeeModel> employeeList = new List<EmployeeModel>();
    List<CustomerModel> customerList = new List<CustomerModel>();
    List<CustomerProjectModel> projectList = new List<CustomerProjectModel>();
    InvoiceMasterEntity invoiceMaster = new InvoiceMasterEntity();
    InvoiceDetailsEntity invDetails = new InvoiceDetailsEntity();
    List<InvoiceDetailsEntity> invoicedetailsList = new List<InvoiceDetailsEntity>();
    DeliveryNoteDetailsEntity deliverydetails = new DeliveryNoteDetailsEntity();
    List<SalesItemDetailsModel> workOrderItemList = new List<SalesItemDetailsModel>();
    List<string> workerOrderNoList = new List<string>();
    SalesOrderViewModel salesOrderView = new SalesOrderViewModel();
    List<ServiceEntity> serviceList = new List<ServiceEntity>();
    List<string> deliveryNoteList = new List<string>();
    string voucherNo;
    string all_delivery_note_no;

    decimal amount;
    string KeyPressed = "";
    public string Value { get; set; }
    public string MyDrValue { get; set; }
    public string MyCrValue { get; set; }

    double Qty { get; set; }
    decimal Rate { get; set; }
    public decimal totalAmount { get; set; }

    private ElementReference myref;
    private ElementReference myDr_ref;
    private ElementReference itmInput;
    private ElementReference myCr_ref;
    private ElementReference narrationref;
    ElementReference cusotmerInput;
    ElementReference projectInput;
    private bool isDrDisable { get; set; }
    private bool isCrDisable { get; set; }
    decimal totalDebit;
    decimal totalCredit;
    int visibletext;
    string BranchName;
    string voucherDate;
    string narration;
    int bankStatus = 0;
    List<string> templates = new List<string>() { "Maui", "Hawaii", "Niihau", "Kauai", "Kahoolawe" };
    string SelectedString = "Maui";
    string parent;
    string chequeNo;
    string drawnon;
    string voucherChequedate = "";
    string currentDate;
    string selected_date;
    string itemName;
    string supplierName;
    decimal GrandTotal;
    decimal transport_cost;
    decimal labour_cost;
    decimal others_cost;
    decimal advance;
    string unitName;
    int unitId;
    string carryingBy;
    decimal salesSubTotal = 0;
    decimal Total = 0;
    decimal discount_amount_In_Parcent;
    decimal discount_amount_In_Taka;
    decimal tax_amount_In_Parcent;
    decimal vat_amount_In_Parcent;
    decimal discount_amount;
    decimal tax_amount;
    decimal vat_amount;
    string Inwords;

    //-----

    List<VendorEntity>? customers;
    string? selectedCustomerId;
    string? selectedCustomerName;
    string? filter;

    public string searchVendor { get; set; } = "";
    public string searchCustomer { get; set; } = "";
    public string searchworkOrder { get; set; } = "";
    public string searchDeliveryNoteNo { get; set; } = "";
    public string searchproject { get; set; } = "";
    public string searchitem { get; set; } = "";

    List<string> options1;
    List<string> customer;
    List<string> deliveryNote;
    List<string> project;
    List<string> workOrder;
    List<string> itemnameList;
    [Parameter]
    public string woNO { get; set; }

    protected override async Task OnInitializedAsync()
    {
        MyProperty = "Dr";
        onDisable(MyProperty);
        accCompanyVoucherModel.COMP_REF_NO = await Http.GetStringAsync(Utility.BaseUrl + "api/Transection/GetVoucherNo/" + 1);
        //await GetCountry();
        await GetLedger();
        //await GetBranch();
        workOrderItemList = await Http.GetJsonAsync<List<SalesItemDetailsModel>>(Utility.BaseUrl + "api/Sales/GetworkOrderItemList/"+woNO);
        itemNameList = await Http.GetJsonAsync<List<ItemEntity>>(Utility.BaseUrl + "api/Product/GetProjectItem");
        unitList = await Http.GetJsonAsync<List<UnitModel>>(Utility.BaseUrl + "api/Setup/GetUnit");

        vendorList = await Http.GetJsonAsync<List<VendorEntity>>(Utility.BaseUrl + "api/Vendor");
        employeeList = await Http.GetJsonAsync<List<EmployeeModel>>(Utility.BaseUrl + "api/Employee");
        customerList = await Http.GetJsonAsync<List<CustomerModel>>(Utility.BaseUrl + "api/Customer");

        serviceList = await Http.GetJsonAsync<List<ServiceEntity>>(Utility.BaseUrl+ "api/Setup/GetServiceList");
        currentDate = System.DateTime.Now.Year + "-" + (System.DateTime.Now.Month).ToString().PadLeft(2, '0') + "-" + System.DateTime.Now.Day.ToString().PadLeft(2, '0');
        //currentDate = System.DateTime.Now.Day.ToString().PadLeft(2, '0')+"/"+ (System.DateTime.Now.Month).ToString().PadLeft(2, '0') + System.DateTime.Now.Year ;
        //options1 = employeeList.Select(f => f.EMPLOYEE_NAME).Distinct().ToList();
        //customer = customerList.Select(f => f.CUSTOMER_NAME).Distinct().ToList();
        itemnameList = itemNameList.Select(f => f.ITEM_NAME).Distinct().ToList();
        salesOrderView = await Http.GetJsonAsync<SalesOrderViewModel>(Utility.BaseUrl + "api/Sales/GetSalesOrderInfoByWorkOrderNO/" + woNO);
        deliveryNoteList= await Http.GetJsonAsync<List<string>>(Utility.BaseUrl + "api/Sales/GetDeliveryNoteNoList/" + woNO);
        searchCustomer = salesOrderView.CUSTOMER_NAME;
        searchproject = salesOrderView.SHIPPING_PROJECT_NAME;
        searchworkOrder = salesOrderView.PO_WO_NUMBER;
        int customerid = customerList.Find(x => x.CUSTOMER_NAME == searchCustomer).CUSTOMER_ID;
        projectList = await Http.GetJsonAsync<List<CustomerProjectModel>>(Utility.BaseUrl + "api/Customer/GetCustomerProjectList/" + customerid);
        //await cusotmerInput.FocusAsync();
        StateHasChanged();

    }
    private async Task<IEnumerable<VendorEntity>> SearchLedger(string searchText)
    {
        //return await Task.FromResult(vendorList.Where(x => x.VENDOR_NAME.ToLower().Contains(searchText.ToLower())).ToList());

        return vendorList = vendorList.Where(x => x.VENDOR_NAME.ToLower().Contains(searchText.ToLower())).ToList();
        //return await Task.FromResult(ledgerList);
    }
    async void CheckboxClicked(string service, object checkedValue)
    {
        if ((bool)checkedValue)
        {
            if (!invoicedetailsList.Exists(x => x.SERVICE_NAME == service))
            {

                invDetails = new InvoiceDetailsEntity();
                invDetails.SERVICE_CODE = serviceList.Find(x => x.SERVICE_NAME == service).SERVICE_CODE;
                invDetails.SERVICE_NAME = workOrderItemList.Find(x => x.SERVICE_NAME == service).SERVICE_NAME;
                invDetails.QUANTITY = Convert.ToDecimal(workOrderItemList.Find(x => x.SERVICE_NAME == service).SALES_QUANTITY);
                invDetails.UNIT = workOrderItemList.Find(x => x.SERVICE_NAME == service).UOM;
                invDetails.PRICE = workOrderItemList.Find(x => x.SERVICE_NAME == service).UNIT_PRICE;
                invDetails.AMOUNT = Convert.ToDecimal(workOrderItemList.Find(x => x.SERVICE_NAME == service).AMOUNT);
                invoicedetailsList.Add(invDetails);

                salesSubTotal += invDetails.AMOUNT;
                TotalCalculation();

            }
            else
            {

            }


            //WorkOrderNo = salesOrderNo;
            //salesInfo = await Http.GetJsonAsync<SalesOrderViewModel>(Utility.BaseUrl + "api/Sales/GetSalesInfoByPONo/" + salesOrderNo);
            //itemList = await Http.GetJsonAsync<List<SalesItemDetailsModel>>(Utility.BaseUrl + "api/Sales/GetSalesItemByPONo/" + salesOrderNo);
            //termsId = salesInfo.TERMS_AND_CONDITION;
            //if (termsId != null)
            //{ termsAndConditionList = await Http.GetJsonAsync<List<PurchaseTermsConditionsModel>>(Utility.BaseUrl + "api/Sales/GetTermsAndConditions/" + termsId); }

            //foreach (var item in termsAndConditionList)
            //{
            //    condition = new PurchaseTermsConditionsModel();
            //    condition.PURCHASE_TERMS_CONDITION_ID = item.PURCHASE_TERMS_CONDITION_ID;
            //    condition.SALES_TERMS_CONDITION_ID = item.SALES_TERMS_CONDITION_ID;
            //    condition.SL = item.SL;
            //    condition.TERMS_AND_CONDITIONS = item.SL + " ." + item.TERMS_AND_CONDITIONS;

            //    termsConditionList.Add(condition);

            //}

            //AppState.SalestermsConditionList = termsConditionList;

        }
        this.StateHasChanged();
    }
    public List<string> checkedOtherTermsIds { get; set; } = new List<string>();
    public async Task selectedDeliveryNoteNo(string deliverynote)
    {
        searchDeliveryNoteNo = deliverynote;
        //string terms_And_Conditions_No = String.Join(",", searchDeliveryNoteNo);

        checkedOtherTermsIds.Add(searchDeliveryNoteNo);
        all_delivery_note_no = String.Join(",", checkedOtherTermsIds);
        //all_delivery_note_no = terms_And_Conditions_No;
        deliveryNote = new List<string>();
        searchDeliveryNoteNo = "";
    }
    public async Task selectedcustomer(string ff)
    {
        //searchVendor = ff;
        searchCustomer = ff;
        int customerid = customerList.Find(x => x.CUSTOMER_NAME == searchCustomer).CUSTOMER_ID;
        projectList = await Http.GetJsonAsync<List<CustomerProjectModel>>(Utility.BaseUrl + "api/Customer/GetCustomerProjectList/" + customerid);
        project = projectList.Select(f => f.SHIPPING_PROJECT_NAME).Distinct().ToList();
        vendor_name = null;
        customer = new List<string>();
        await projectInput.FocusAsync();
        StateHasChanged();
    }
    public async Task SelectedProject(string prj)
    {
        searchproject = prj;
        project = new List<string>();
        int customerid = customerList.Find(x => x.CUSTOMER_NAME == searchCustomer).CUSTOMER_ID;
        int projectId = projectList.Find(x => x.SHIPPING_PROJECT_NAME == searchproject).CUSTOMER_PROJECT_ID;
        workerOrderNoList = await Http.GetJsonAsync<List<string>>(Utility.BaseUrl + "api/Customer/GetWorkOrderNoList/" + customerid + "/" + projectId);

        //workOrder= workerOrderNoList.Select(f => f).Distinct().ToList();
        StateHasChanged();
    }
    private async void HandleKeyDown(KeyboardEventArgs e)
    {
        pressedKey = e.Key;
        await testRef.FocusAsync();
    }

    protected async void KeyPress(KeyboardEventArgs e)
    {
        //letter = $"Pressed: [{e.Key}]";
        string s = "";

        await keyDownDiv.FocusAsync();
    }

    private async Task GetEmployeeList(ChangeEventArgs change)
    {
        searchVendor = change.Value.ToString();
        options1 = employeeList.Select(f => f.EMPLOYEE_NAME).Distinct().ToList();
    }
    private async Task GetEmployee()
    {
        options1 = employeeList.Select(f => f.EMPLOYEE_NAME).Distinct().ToList();
    }
    private async Task GetCustomerList(ChangeEventArgs change)
    {
        searchCustomer = change.Value.ToString();
        customer = customerList.Select(f => f.CUSTOMER_NAME).Distinct().ToList();

    }
    private async Task GetDeliveryNoteNoList(ChangeEventArgs change)
    {
        searchDeliveryNoteNo = change.Value.ToString();
        deliveryNote = deliveryNoteList;//.Select(f => f.).Distinct().ToList();

    }
    private async Task GetProjectList(ChangeEventArgs change)
    {
        searchproject = change.Value.ToString();
        project = projectList.Select(f => f.SHIPPING_PROJECT_NAME).Distinct().ToList();
    }
    private async Task GetWorkOrderNoList(ChangeEventArgs change)
    {
        searchworkOrder = change.Value.ToString();
        //project = projectList.Select(f => f.SHIPPING_PROJECT_NAME).Distinct().ToList();
        workOrder = workerOrderNoList; //workerOrderNoList.Select(f => f).Distinct().ToList();
    }
    private async Task OnClickDeliveryNoteList()
    {
        //customer = customerList.Select(f => f.CUSTOMER_NAME).Distinct().ToList();

        deliveryNote = deliveryNoteList;// deliveryNoteList.Select(f => f.).Distinct().ToList();

    }
    private async Task OnClickCustomer()
    {
        customer = customerList.Select(f => f.CUSTOMER_NAME).Distinct().ToList();


    }
    private async Task GetItemList(ChangeEventArgs change)
    {
        searchitem = change.Value.ToString();
        itemnameList = itemNameList.Select(f => f.ITEM_NAME).Distinct().ToList();
    }

    public async Task selectedEmployee(string ff)
    {
        //searchVendor = ff;
        searchVendor = ff;
        //
        //vendor_name = null;
        options1 = new List<string>();
        StateHasChanged();
    }
    public async Task SelectedWorkOrder(string selectedWO)
    {
        searchworkOrder = selectedWO;
        workOrder = new List<string>();
        StateHasChanged();
    }
    public async Task SelectedItm(string param_itm)
    {
        itemName = param_itm;
        searchitem = param_itm;
        itemEntity.UNIT_ID = itemNameList.Find(x => x.ITEM_NAME == searchitem).UNIT_ID;
        unitName = itemNameList.Find(x => x.ITEM_NAME == searchitem).UOM;
        itemEntity.UOM = unitName;
        itemEntity.UNIT_ID = itemEntity.UNIT_ID;

        await QtyInput.FocusAsync();
        itemnameList = new List<string>();


        StateHasChanged();
    }
    async Task HandleInput(ChangeEventArgs e)
    {
        filter = e.Value?.ToString();
        if (filter?.Length > 2)
        {
            customers = await Http.GetJsonAsync<List<VendorEntity>>(Utility.BaseUrl + "api/Vendor/GetVendorDetailsByVendorCode/" + filter);
        }
        else
        {
            customers = null;
            selectedCustomerName = selectedCustomerId = null;
        }
    }

    void SelectCustomer(string id)
    {
        selectedCustomerId = id;
        selectedCustomerName = customers!.First(c => c.VENDOR_ID.Equals(selectedCustomerId)).VENDOR_NAME;
        customers = null;
    }
    async void selectedledger(ChangeEventArgs e)
    {
        SelectedString = e.Value.ToString();
        if (SelectedString == "Bank Accounts") { bankStatus = 1; }
        else { bankStatus = 0; }
        if (MyProperty == "Dr")
        { await myDr_ref.FocusAsync(); }
        else if (MyProperty == "Cr")
        { await myCr_ref.FocusAsync(); }
    }
    public async Task GetBranch()
    {
        branchList = await Http.GetJsonAsync<List<BranchModel>>(Utility.BaseUrl + "api/Setup/GetBranchList");
        if (branchList.Count > 0)
        { BranchName = branchList.FirstOrDefault().BRANCH_NAME; }


    }
    private async Task GetLedger()
    {
        //ledgerList = await Http.GetJsonAsync<List<LedgerModel>>(Utility.BaseUrl + "api/Setup/GetLedger");
    }
    //private async Task GetCountry()
    //{
    //    countryList = await Http.GetJsonAsync<List<CountryModel>>(Utility.BaseUrl + "api/Setup/GetCountry");
    //}
    private void ItemNameClicked(ChangeEventArgs changeEventArgs)
    {
        itemName = changeEventArgs.Value.ToString();
    }
    private void SupplierNameClicked(ChangeEventArgs changeEventArgs)
    {
        supplierName = changeEventArgs.Value.ToString();
    }
    private void rateClicked(ChangeEventArgs changeEventArgs)
    {
        //double sum = requestItemList.Sum(x => Convert.ToDouble(x.Quantity) * Convert.ToDouble(x.Rate));
        //finaltotal = finaltotal + Convert.ToDouble(changeEventArgs.Value.ToString());
        if (changeEventArgs.Value.ToString() != "") { Rate = Convert.ToDecimal(changeEventArgs.Value.ToString()); }
        else { Rate = 0; }
        totalAmount = Convert.ToDecimal(Convert.ToDecimal(Qty) * Convert.ToDecimal(Rate));
        //GetTotal();
        //ADJ = Convert.ToDouble(changeEventArgs.Value.ToString());
    }
    private void TransportClicked(ChangeEventArgs changeEventArgs)
    {
        //double sum = requestItemList.Sum(x => Convert.ToDouble(x.Quantity) * Convert.ToDouble(x.Rate));
        //finaltotal = finaltotal + Convert.ToDouble(changeEventArgs.Value.ToString());
        if (changeEventArgs.Value.ToString() != "") { transport_cost = Convert.ToDecimal(changeEventArgs.Value.ToString()); }
        else { transport_cost = 0; }
        GetTotal();
        //ADJ = Convert.ToDouble(changeEventArgs.Value.ToString());
    }
    private void LabourClicked(ChangeEventArgs changeEventArgs)
    {
        if (changeEventArgs.Value.ToString() != "") { labour_cost = Convert.ToDecimal(changeEventArgs.Value.ToString()); }
        else { labour_cost = 0; }
        GetTotal();
    }
    private void OthersClicked(ChangeEventArgs changeEventArgs)
    {
        if (changeEventArgs.Value.ToString() != "") { others_cost = Convert.ToDecimal(changeEventArgs.Value.ToString()); }
        else { others_cost = 0; }
        GetTotal();
    }
    private void GetTotal()
    {
        //if(AIT== 0 && VAT==0 && ADJ==0)
        //{ finaltotal = requestItemList.Sum(x => Convert.ToDouble(x.Quantity) * Convert.ToDouble(x.Rate)); }
        //finaltotal = requestItemList.Sum(x => Convert.ToDouble(x.Quantity) * Convert.ToDouble(x.Rate));

        //if (Rate !="")
        //{
        //    totalAmount = Convert.ToDecimal(Convert.ToDecimal(Qty)* Convert.ToDecimal(Rate));
        //}

        //if (VAT != 0)
        //{ finaltotal = finaltotal + VAT; }
        //if (ADJ != 0)
        //{ finaltotal = finaltotal + ADJ; }
        //if (SeaFreight != 0)
        //{ finaltotal = finaltotal + SeaFreight; }
        //double inwordValue = Convert.ToDouble(finaltotal);
        // Inwords = NumberToWords.ConvertAmount(inwordValue);
        //else { finaltotal = requestItemList.Sum(x => Convert.ToDouble(x.Quantity) * Convert.ToDouble(x.Rate)); }
        decimal t = voucherItemList.Sum(x => Convert.ToDecimal(x.QUANTITY) * Convert.ToDecimal(x.UNIT_PRICE));
        GrandTotal = t + transport_cost + labour_cost + others_cost;

    }


    //private async Task<IEnumerable<LedgerModel>> KeyPressLedger(string searchText)
    //{
    //    //return await Task.FromResult(ledgerList.Where(x => x.LEDGER_NAME.ToLower().Contains(searchText.ToLower())).ToList());


    //}

    public async Task SaveInvoice()
    {

        if (currentDate == "" || currentDate == null)
        {
            toastService.ShowWarning("Please Select Date.");
            return;
        }
        else
        {

            try
            {

                if (selected_date == "" || selected_date == null)
                {
                    //porderModel.PO_DATE = Convert.ToDateTime(currentDate).Day.ToString().PadLeft(2, '0') + "/" + Convert.ToDateTime(currentDate).Month.ToString().PadLeft(2, '0') + "/" + Convert.ToDateTime(currentDate).Year;

                    invoiceMaster.INVOICE_DATE= Convert.ToDateTime(currentDate); //Convert.ToDateTime(currentDate).Day.ToString().PadLeft(2, '0') + "/" + Convert.ToDateTime(currentDate).Month.ToString().PadLeft(2, '0') + "/" + Convert.ToDateTime(currentDate).Year;
                }
                invoiceMaster.WO_NUMBER = searchworkOrder;
                invoiceMaster.DISCOUNT = discount_amount;
                invoiceMaster.TAX_AMOUNT = tax_amount;
                invoiceMaster.VAT = vat_amount;
                invoiceMaster.ADVANCE = advance;
                invoiceMaster.GRAND_TOTAL = GrandTotal;
                invoiceMaster.IN_WORDS = Inwords;
                invoiceMaster.WORK_NAME = salesOrderView.SHIPPING_PROJECT_NAME;
                invoiceMaster.CUSTOMER_ID = customerList.Find(x => x.CUSTOMER_NAME == searchCustomer).CUSTOMER_ID;
                invoiceMaster.CUSTOMER_PROJECT_ID = projectList.Find(x => x.SHIPPING_PROJECT_NAME == searchproject).CUSTOMER_PROJECT_ID;
                invoiceMaster.DELIVERY_NOTE_NO = all_delivery_note_no;
                if(terms_Condition!=null)
                {
                    invoiceMaster.TERMS_CONDITION= await this.terms_Condition.GetHTML();
                }


                if (voucherItemList != null)
                {
                    foreach (var item in voucherItemList)
                    {
                        itemdetails = new PurchaseOrderDetailsEntity();
                        itemdetails.ITEM_NAME = item.ITEM_NAME;
                        itemdetails.UNIT_ID = item.UNIT_ID;
                        itemdetails.QUANTITY = item.QUANTITY;
                        itemdetails.UNIT_PRICE = item.UNIT_PRICE;
                        itemdetails.TOTAL_AMOUNT = item.TOTAL_AMOUNT;
                        if (porderModel.pOrderDetailsList == null)
                        { porderModel.pOrderDetailsList = new List<PurchaseOrderDetailsEntity>(); }
                        porderModel.pOrderDetailsList.Add(itemdetails);
                    }
                    invoiceMaster.invoiceDetailsList = invoicedetailsList;
                    invoiceMaster.INVOICE_AMOUNT = invoicedetailsList.Sum(x => Convert.ToDecimal(x.AMOUNT));
                    var data = await Http.PostJsonAsync<InvoiceMasterEntity>(Utility.BaseUrl + "api/Sales/AddInvoice", invoiceMaster);
                    toastService.ShowSuccess("Save Successfully!!!");
                    //UriHelper.NavigateTo("InvoiceList/"+ woNO);
                    voucherItemList = new List<PurchaseOrderDetailsEntity>();
                    porderModel = new PurchaseOrderModel();
                    porderModel.pOrderDetailsList = new List<PurchaseOrderDetailsEntity>();
                    voucherNo = "";
                    GrandTotal = 0;
                    currentDate = System.DateTime.Now.Year + "-" + (System.DateTime.Now.Month).ToString().PadLeft(2, '0') + "-" + System.DateTime.Now.Day.ToString().PadLeft(2, '0');

                }
                else
                {
                    toastService.ShowWarning("No Item For Delivery!");
                }
            }
            catch (Exception ex)
            {
                voucherItemList = new List<PurchaseOrderDetailsEntity>();
                porderModel = new PurchaseOrderModel();
                porderModel.pOrderDetailsList = new List<PurchaseOrderDetailsEntity>();
            }
        }
    }

    private async Task LoadPage()
    {
        await GetVoucherNo();
        visibletext = 0;
        MyProperty = "Dr";
        totalDebit = 0;
        totalCredit = 0;
        onDisable(MyProperty);
        StateHasChanged();
    }
    private async Task GetVoucherNo()
    {
        accCompanyVoucherModel.COMP_REF_NO = await Http.GetStringAsync(Utility.BaseUrl + "api/Transection/GetVoucherNo/" + 1);
    }
    private void Keypress(KeyboardEventArgs args)
    {
        string value;
        value = args.Key;
        itemName = value;

    }
    private void onDisable(string property)
    {
        if (property == "Dr")
        {
            this.isDrDisable = false;
            this.isCrDisable = true;
            MyCrValue = "";
        }
        else if (property == "Cr")
        {
            this.isCrDisable = false;
            this.isDrDisable = true;
        }

    }

    private async Task GetSelectedValue(ChangeEventArgs change)
    {
        if (change.Value.ToString() == "Bank Accounts") { bankStatus = 1; }
    }

    private void UnitClicked(ChangeEventArgs change)
    {
        unitId = Convert.ToInt32(change.Value.ToString());
        unitName = unitList.Find(x => x.UNIT_ID == unitId).UNIT_NAME;
    }
    private async void DoTheThing(KeyboardEventArgs eventArgs)
    {
        if (eventArgs.Key == "Enter")
        {
            //deliverydetails = new DeliveryNoteDetailsEntity();
            //deliverydetails.ITEM_NAME = searchitem;
            //deliverydetails.ITEM_CODE = itemNameList.Find(p => p.ITEM_NAME == searchitem).ITEM_CODE;
            //deliverydetails.UNIT = unitList.Find(x => x.UNIT_ID == itemEntity.UNIT_ID).UNIT_NAME;
            //deliverydetails.QUANTITY = Qty;
            //invoicedetailsList.Add(deliverydetails);
            ClearItemAfterAdd();
        }
    }
    private async void AddItem()
    {
        if (Qty != 0)
        {
            //deliverydetails = new DeliveryNoteDetailsEntity();
            //deliverydetails.ITEM_NAME = searchitem;
            //deliverydetails.ITEM_CODE = itemNameList.Find(p => p.ITEM_NAME == searchitem).ITEM_CODE;
            //deliverydetails.UNIT = unitList.Find(x => x.UNIT_ID == itemEntity.UNIT_ID).UNIT_NAME;
            //deliverydetails.QUANTITY = Qty;
            //invoicedetailsList.Add(deliverydetails);
            ClearItemAfterAdd();
        }
    }
    private async void ClearItemAfterAdd()
    {
        searchitem = "";
        Qty = 0;
        itemEntity.UNIT_ID = 0;
        await itmInput.FocusAsync();
    }


    private async void GetDate(ChangeEventArgs change)
    {
        selected_date = change.Value.ToString();
        //porderModel.PO_DATE = Convert.ToDateTime(selected_date).Day.ToString().PadLeft(2, '0') + "/" + Convert.ToDateTime(selected_date).Month.ToString().PadLeft(2, '0') + "/" + Convert.ToDateTime(selected_date).Year;
        invoiceMaster.INVOICE_DATE = Convert.ToDateTime(selected_date); //Convert.ToDateTime(selected_date).Day.ToString().PadLeft(2, '0') + "/" + Convert.ToDateTime(selected_date).Month.ToString().PadLeft(2, '0') + "/" + Convert.ToDateTime(selected_date).Year;
    }


    private void SelectItem(string item)
    {
        itemName = item;

    }
    private void SelectSupplierItem(string item)
    {
        supplierName = item;

    }
    public async void DeleteItem(string item)
    {
        var itemToRemove = invoicedetailsList.Single(r => r.SERVICE_NAME == item);
        invoicedetailsList.Remove(itemToRemove);
        GetTotal();



        StateHasChanged();
    }
    private async Task discount_amount_In_Parcent_Clicked(ChangeEventArgs change)
    {
        if (change.Value != "")
        { discount_amount_In_Parcent = (GrandTotal * Convert.ToDecimal(change.Value)) / 100;
            discount_amount = discount_amount_In_Parcent+ discount_amount_In_Taka;
        }
        else { discount_amount_In_Parcent = 0; }
        TotalCalculation();
    }
    private async Task discount_amount_In_TK_Clicked(ChangeEventArgs change)
    {
        if (change.Value != "") {
            discount_amount_In_Taka = Convert.ToDecimal(change.Value);
            discount_amount = discount_amount_In_Taka + discount_amount_In_Parcent;
        }
        else { discount_amount_In_Taka = 0; }
        TotalCalculation();
    }
    private async Task tax_amount_In_Parcent_Clicked(ChangeEventArgs change)
    {
        if (change.Value != "")
        {
            tax_amount_In_Parcent = (salesSubTotal * Convert.ToDecimal(change.Value)) / 100;
            tax_amount = tax_amount_In_Parcent;
            //discount_amount = discount_amount_In_Parcent + discount_amount_In_Taka;
        }
        else { discount_amount_In_Parcent = 0; }
        TotalCalculation();
    }
    private async Task vat_amount_In_Parcent_Clicked(ChangeEventArgs change)
    {
        if (change.Value != "")
        {
            vat_amount_In_Parcent = (salesSubTotal * Convert.ToDecimal(change.Value)) / 100;
            vat_amount = vat_amount_In_Parcent;
            //discount_amount = discount_amount_In_Parcent + discount_amount_In_Taka;
        }
        else { vat_amount_In_Parcent = 0; }
        TotalCalculation();
    }
    private async Task Other_Cost_Clicked(ChangeEventArgs change)
    {
        if(change.Value !="")
        {
            advance = Convert.ToDecimal(change.Value.ToString());

        }
        else { advance = 0; }
        TotalCalculation();
    }
    private void TotalCalculation()
    {
        ////salesSubTotal = workOrderItemList.Sum(x => Convert.ToDecimal(x.AMOUNT));
        //Total = Convert.ToDecimal(salesSubTotal) + LC_AMOUNT + LC_COMMISSION + INSURANCE + Convert.ToDecimal(othersSubTotal);
        //netAmount = Total;
        //totalNetAmount = Total;
        //GrandTotal = Total;
        //if (discount_amount_In_Parcent != 0)
        //{
        //    GrandTotal = GrandTotal - discount_amount_In_Parcent;
        //}
        //if (discount_amount_In_Taka != 0)
        //{
        //    netAmount = Total - discount_amount_In_Taka;
        //    totalNetAmount = netAmount;
        //    GrandTotal = netAmount;
        //}
        //if (advance_amount_In_Parcent != 0)
        //{
        //    //decimal sum = advance_amount_In_Parcent + discount_amount_In_Parcent + discount_amount_In_Taka;
        //    totalNetAmount = Total - (advance_amount_In_Parcent + discount_amount_In_Parcent + discount_amount_In_Taka);
        //    GrandTotal = totalNetAmount;
        //}
        //if (advance_amount_In_Taka != 0)
        //{
        //    totalNetAmount = Total - (advance_amount_In_Taka + discount_amount_In_Parcent + discount_amount_In_Taka);
        //    GrandTotal = totalNetAmount;
        //}
        //if (deliveryAndOthers != 0)
        //{
        //    GrandTotal = totalNetAmount + deliveryAndOthers;
        //}
        //GrandTotal = salesSubTotal;

        GrandTotal = (Convert.ToDecimal(salesSubTotal) )- discount_amount_In_Parcent;
        GrandTotal = (Convert.ToDecimal(GrandTotal) ) - discount_amount_In_Taka;
        GrandTotal = Convert.ToDecimal(GrandTotal) + tax_amount_In_Parcent;
        GrandTotal = Convert.ToDecimal(GrandTotal) + vat_amount_In_Parcent;
        GrandTotal = Convert.ToDecimal(GrandTotal) + advance;
        double inwordValue = Convert.ToDouble(GrandTotal);
        Inwords = NumberToWords.ConvertAmount(inwordValue);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsruntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
