// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TOCOMA_ERP_System.Pages.Vendor
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/EditVendor/{vendorcode}")]
    public partial class EditVendor : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 633 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\EditVendor.razor"
       
    BankBranchModel branch = new BankBranchModel();
    List<BankModel> bankList = new List<BankModel>();
    List<BankBranchModel> branchList = new List<BankBranchModel>();
    List<CustomerContactModel> customerContactList = new List<CustomerContactModel>();
    CustomerContactModel customerContact = new CustomerContactModel();
    List<DepartmentEntity> departmentList = new List<DepartmentEntity>();
    CustomerContactModel customerContactModel = new CustomerContactModel();
    List<CustomerContactModel> ContactList = new List<CustomerContactModel>();
    VendorEntity vendor = new VendorEntity();
    [Parameter]
    public string vendorcode { get; set; }
    public bool isLocalCheck { get; set; }
    public bool isIntCheck { get; set; }
    protected bool ETD_1st_Date_CheckStatus { get; set; }
    string btnAdd;
    int vendorContactId;

    protected override async Task OnInitializedAsync()
    {
        await GetBankList();
        departmentList = await Http.GetJsonAsync<List<DepartmentEntity>>(Utility.BaseUrl + "api/Department");
        vendor = await Http.GetJsonAsync<VendorEntity>(Utility.BaseUrl + "api/Vendor/GetVendorDetailsByVendorCode/" + vendorcode);

        branchList = await Http.GetJsonAsync<List<BankBranchModel>>(Utility.BaseUrl + "api/Bank/GetBranchList/" + vendor.BANK_ID);
        vendor.BANK_KEY_ROUTING_NUMBER = branchList.Find(x => x.BANK_ID == vendor.BANK_ID).ROUTING_NUMBER;
        vendor.BRANCH_ADDRESS= branchList.Find(x => x.BANK_ID == vendor.BANK_ID).BRANCH_ADDRESS;
        vendor.POSTAL_CODE= branchList.Find(x => x.BANK_ID == vendor.BANK_ID).POSTAL_CODE;
        vendor.SWIFT_CODE= branchList.Find(x => x.BANK_ID == vendor.BANK_ID).SWIFT_CODE;

        customerContactList = await Http.GetJsonAsync<List<CustomerContactModel>>(Utility.BaseUrl + "api/Vendor/GetVendorContactDetailsCode/" + vendorcode);
        if (vendor.VENDOR_TYPE_STATUS == "Local")
        { isLocalCheck = true; }
        else if (vendor.VENDOR_TYPE_STATUS == "International")
        { isIntCheck = true; }
        btnAdd = "ADD";

    }

    private async Task GetBankList()
    {
        bankList = await Http.GetJsonAsync<List<BankModel>>(Utility.BaseUrl + "api/Bank");
    }
    protected async Task SelectedBank(ChangeEventArgs changeEvent)
    {
        int bankId = Convert.ToInt32(changeEvent.Value.ToString());
        vendor.BANK_ID = bankId;
        branchList = await Http.GetJsonAsync<List<BankBranchModel>>(Utility.BaseUrl + "api/Bank/GetBranchList/" + bankId);
        StateHasChanged();
    }
    protected async Task SelectedBranch(ChangeEventArgs branchevent)
    {
        int branchId = Convert.ToInt32(branchevent.Value.ToString());
        vendor.BANK_BRANCH_ID = branchId;
        branch = await Http.GetJsonAsync<BankBranchModel>(Utility.BaseUrl + "api/Bank/GetBranchInfo/" + branchId);
        vendor.BANK_KEY_ROUTING_NUMBER = branch.ROUTING_NUMBER;
        vendor.BRANCH_ADDRESS = branch.BRANCH_ADDRESS;
        vendor.POSTAL_CODE = branch.POSTAL_CODE;
        vendor.SWIFT_CODE = branch.SWIFT_CODE;
        StateHasChanged();
    }
    public async Task SaveVendor()
    {

        if (IsValidation() != true)
        {
            try
            {
                var data = await Http.PutJsonAsync<VendorEntity>(Utility.BaseUrl + "api/Vendor", vendor);
                foreach (var item in customerContactList)
                {
                    customerContactModel = new CustomerContactModel();
                    customerContactModel.CUSTOMER_VENDOR_CODE = vendor.VENDOR_CODE;
                    customerContactModel.CUSTOMER_CONTACT_ID = item.CUSTOMER_CONTACT_ID;
                    customerContactModel.NAME = item.NAME;
                    customerContactModel.DESIGNATION = item.DESIGNATION;
                    customerContactModel.DEPARTMENT_ID = item.DEPARTMENT_ID;
                    customerContactModel.MOBILE = item.MOBILE;
                    customerContactModel.EMAIL = item.EMAIL;
                    customerContactModel.WECHAT = item.WECHAT;
                    customerContactModel.WHATSAPP = item.WHATSAPP;
                    customerContactModel.TYPE = item.TYPE;

                    ContactList.Add(customerContactModel);
                }

                var customercontact = await Http.PutJsonAsync<List<CustomerContactModel>>(Utility.BaseUrl + "api/Customer/UpdateCustomerContact", ContactList);
                toastService.ShowSuccess("Update Successfully!!!");
            }
            catch (Exception ex)
            {
                ContactList = new List<CustomerContactModel>();
            }

        }
    }
    private void close()
    {
        btnAdd = "ADD";
        customerContact = new CustomerContactModel();
    }
    private async Task Cancel()
    {
        vendor = new VendorEntity();
        UriHelper.NavigateTo("VendorList");

    }
    private bool IsValidation()
    {
        bool flag = false;
        if (vendor.VENDOR_NAME == "" || vendor.VENDOR_NAME == string.Empty || vendor.VENDOR_NAME == null)
        {
            toastService.ShowWarning("Vendor Name is empty!");
            flag = true;
        }
        else if (vendor.REGISTERED_ADDRESS == "" || vendor.REGISTERED_ADDRESS == string.Empty || vendor.REGISTERED_ADDRESS == null)
        {
            toastService.ShowWarning("Register Address field is Empty!");
            flag = true;
        }


        return flag;
    }
    async void Incorporation_Certificate_Yes(object checkedValue)
    {
        vendor.INCORPORATION_CERTIFICATE_STATUS = "Yes";
    }
    async void Incorporation_Certificate_No(object checkedValue)
    {
        vendor.INCORPORATION_CERTIFICATE_STATUS = "No";
    }

    async void Company_Profile_Brochur_Yes(object checkedValue)
    {
        vendor.COMPANY_PROFILE_BROCHUR_STATUS = "Yes";
    }
    async void Company_Profile_Brochur_No(object checkedValue)
    {
        vendor.COMPANY_PROFILE_BROCHUR_STATUS = "No";
    }
    async void Trade_License_Yes(object checkedValue)
    {
        vendor.TRADE_LICENSE_STATUS = "Yes";
    }
    async void Trade_License_No(object checkedValue)
    {
        vendor.TRADE_LICENSE_STATUS = "No";
    }
    async void TIN_Certificate_Yes(object checkedValue)
    {
        vendor.TIN_CERTIFICATE_STATUS = "Yes";
    }
    async void TIN_Certificate_No(object checkedValue)
    {
        vendor.TIN_CERTIFICATE_STATUS = "No";
    }
    async void VAT_Registration_Certificate_Yes(object checkedValue)
    {
        vendor.VAT_REGISTRATION_CERTIFICATE_STATUS = "Yes";
    }
    async void VAT_Registration_Certificate_No(object checkedValue)
    {
        vendor.VAT_REGISTRATION_CERTIFICATE_STATUS = "No";
    }
    async void Environment_Clearance_Certificate_Yes(object checkedValue)
    {
        vendor.ENVIRONMENT_CLEARANCE_CERTIFICATE_STATUS = "Yes";
    }
    async void Environment_Clearance_Certificate_No(object checkedValue)
    {
        vendor.ENVIRONMENT_CLEARANCE_CERTIFICATE_STATUS = "No";
    }
    async void CheckboxLocal(object checkedValue)
    {
        if ((bool)checkedValue)
        {
            vendor.VENDOR_TYPE_STATUS = "Local";
        }
    }
    async void CheckboxInternational(object checkedValue)
    {
        if ((bool)checkedValue)
        {
            vendor.VENDOR_TYPE_STATUS = "International";
        }
    }
    public async Task EditItem(int Id)
    {
        btnAdd = "EDIT";
        vendorContactId = Id;
        customerContact.NAME = customerContactList.Find(x => x.CUSTOMER_CONTACT_ID == Id).NAME;
        customerContact.DESIGNATION = customerContactList.Find(x => x.CUSTOMER_CONTACT_ID == Id).DESIGNATION;
        customerContact.DEPARTMENT_ID = customerContactList.Find(x => x.CUSTOMER_CONTACT_ID == Id).DEPARTMENT_ID;
        customerContact.MOBILE = customerContactList.Find(x => x.CUSTOMER_CONTACT_ID == Id).MOBILE;
        customerContact.EMAIL = customerContactList.Find(x => x.CUSTOMER_CONTACT_ID == Id).EMAIL;
        customerContact.WECHAT = customerContactList.Find(x => x.CUSTOMER_CONTACT_ID == Id).WECHAT;
        customerContact.WHATSAPP = customerContactList.Find(x => x.CUSTOMER_CONTACT_ID == Id).WHATSAPP;
    }
    public async Task AddCustomerContact()
    {
        if (btnAdd == "ADD")
        {
            customerContactModel = new CustomerContactModel();
            customerContactModel.CUSTOMER_VENDOR_CODE = customerContact.CUSTOMER_VENDOR_CODE;
            customerContactModel.CUSTOMER_CONTACT_ID = vendorContactId;
            customerContactModel.NAME = customerContact.NAME;
            customerContactModel.DESIGNATION = customerContact.DESIGNATION;
            customerContactModel.DEPARTMENT_ID = customerContact.DEPARTMENT_ID;
            customerContactModel.DEPARTMENT_NAME = departmentList.Find(x => x.DEPARTMENT_ID == customerContact.DEPARTMENT_ID).DEPARTMENT_NAME;
            customerContactModel.MOBILE = customerContact.MOBILE;
            customerContactModel.EMAIL = customerContact.EMAIL;
            customerContactModel.WECHAT = customerContact.WECHAT;
            customerContactModel.WHATSAPP = customerContact.WHATSAPP;
            customerContactModel.TYPE = "V";

            customerContactList.Add(customerContactModel);
        }
        else if (btnAdd == "EDIT")
        {
            customerContactList.Where(w => w.CUSTOMER_CONTACT_ID == vendorContactId).ToList().ForEach(s => s.NAME = Convert.ToString(customerContact.NAME));
            customerContactList.Where(w => w.CUSTOMER_CONTACT_ID == vendorContactId).ToList().ForEach(s => s.DESIGNATION = customerContact.DESIGNATION);
            customerContactList.Where(w => w.CUSTOMER_CONTACT_ID == vendorContactId).ToList().ForEach(s => s.DEPARTMENT_ID = customerContact.DEPARTMENT_ID);
            customerContactList.Where(w => w.CUSTOMER_CONTACT_ID == vendorContactId).ToList().ForEach(s => s.DEPARTMENT_NAME = customerContact.DEPARTMENT_NAME);
            customerContactList.Where(w => w.CUSTOMER_CONTACT_ID == vendorContactId).ToList().ForEach(s => s.MOBILE = customerContact.MOBILE);
            customerContactList.Where(w => w.CUSTOMER_CONTACT_ID == vendorContactId).ToList().ForEach(s => s.EMAIL = customerContact.EMAIL);
            customerContactList.Where(w => w.CUSTOMER_CONTACT_ID == vendorContactId).ToList().ForEach(s => s.WECHAT = customerContact.WECHAT);
            customerContactList.Where(w => w.CUSTOMER_CONTACT_ID == vendorContactId).ToList().ForEach(s => s.WHATSAPP = customerContact.WHATSAPP);
        }

        StateHasChanged();
        close();


    }
    public async Task DeleteItem(int code)
    {
        if (!await JSRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to delete ?"))
            return;

        await Http.DeleteAsync(Utility.BaseUrl + "api/Vendor/DeleteVendorContact/" + code);
        var itemToRemove = customerContactList.Single(r => r.CUSTOMER_CONTACT_ID == code);
        customerContactList.Remove(itemToRemove);
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
