// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TOCOMA_ERP_System.Pages.Sales
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddCustomer")]
    public partial class AddCustomer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 442 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\AddCustomer.razor"
       
    CustomerModel customer = new CustomerModel();
    CustomerProjectModel customerProject = new CustomerProjectModel();
    CustomerProjectModel cProject = new CustomerProjectModel();
    List<CustomerProjectModel> customerProjectlist = new List<CustomerProjectModel>();
    List<CustomerProjectModel> Projectlist = new List<CustomerProjectModel>();
    List<CustomerTypeModel> customerTypeList = new List<CustomerTypeModel>();
    CustomerContactModel customerContactModel = new CustomerContactModel();
    CustomerContactModel customerContact = new CustomerContactModel();
    List<CustomerContactModel> customerContactList = new List<CustomerContactModel>();
    List<CustomerContactModel> ContactList = new List<CustomerContactModel>();
    List<DepartmentEntity> departmentList = new List<DepartmentEntity>();
    string customerCode;
    protected override async Task OnInitializedAsync()
    {
        customerTypeList = await Http.GetJsonAsync<List<CustomerTypeModel>>(Utility.BaseUrl + "api/Customer/GetCustomerType");
        departmentList = await Http.GetJsonAsync<List<DepartmentEntity>>(Utility.BaseUrl + "api/Department");
    }
    public async Task AddItem()
    {
        //if(cProject.CUSTOMER_ID!=0)
        //{
        customerProject = new CustomerProjectModel();
        customerProject.SHIPPING_PROJECT_NAME = cProject.SHIPPING_PROJECT_NAME;
        customerProject.PROJECT_NAME_SHORT_FORM = cProject.PROJECT_NAME_SHORT_FORM;
        customerProject.PROJECT_ADDRESS = cProject.PROJECT_ADDRESS;
        customerProject.PROJECT_CONTACT_PERSON_NAME = cProject.PROJECT_CONTACT_PERSON_NAME;
        customerProject.PROJECT_CONTACT_PERSON_PHONE = cProject.PROJECT_CONTACT_PERSON_PHONE;
        customerProject.PROJECT_CONTACT_PERSON_EMAIL = cProject.PROJECT_CONTACT_PERSON_EMAIL;

        customerProjectlist.Add(customerProject);
        cProject = new CustomerProjectModel();
        StateHasChanged();
        //    }
        //else { toastService.ShowWarning("Please Select Customer"); }

    }
    public async void EditItem(string item)
    {
        cProject.SHIPPING_PROJECT_NAME = customerProjectlist.Find(x => x.SHIPPING_PROJECT_NAME == item).SHIPPING_PROJECT_NAME;
        cProject.PROJECT_NAME_SHORT_FORM= customerProjectlist.Find(x => x.SHIPPING_PROJECT_NAME == item).PROJECT_NAME_SHORT_FORM;
        StateHasChanged();
    }
    public async void DeleteItem(string item)
    {
        var itemToRemove = customerProjectlist.Single(r => r.SHIPPING_PROJECT_NAME == item);
        customerProjectlist.Remove(itemToRemove);
        StateHasChanged();
    }
    public async Task AddCustomerContact()
    {
        customerContactModel = new CustomerContactModel();
        customerContactModel.NAME = customerContact.NAME;
        customerContactModel.DESIGNATION = customerContact.DESIGNATION;
        customerContactModel.DEPARTMENT_NAME = customerContact.DEPARTMENT_NAME;
        customerContactModel.MOBILE = customerContact.MOBILE;
        customerContactModel.EMAIL = customerContact.EMAIL;
        customerContactModel.WECHAT = customerContact.WECHAT;
        customerContactModel.WHATSAPP = customerContact.WHATSAPP;
        customerContactModel.TYPE = "C";

        customerContactList.Add(customerContactModel);

        customerContact = new CustomerContactModel();
        StateHasChanged();


    }
    public async Task SaveCustomer()
    {
        if (IsValidation() != true)
        {
            try
            {
                customerCode = await Http.GetStringAsync(Utility.BaseUrl + "api/Customer/GetCustomerCode/" + "C");
                customer.CUSTOMER_CODE = customerCode;
                var data = await Http.PostJsonAsync<CustomerModel>(Utility.BaseUrl + "api/Customer", customer);

                var id = await Http.GetJsonAsync<int>(Utility.BaseUrl + "api/Customer/GetCustomerId/" + customerCode);
                foreach (var item in customerProjectlist)
                {
                    customerProject = new CustomerProjectModel();
                    customerProject.CUSTOMER_ID = id;
                    customerProject.SHIPPING_PROJECT_NAME = item.SHIPPING_PROJECT_NAME;
                    customerProject.PROJECT_NAME_SHORT_FORM = item.PROJECT_NAME_SHORT_FORM;
                    customerProject.PROJECT_ADDRESS = item.PROJECT_ADDRESS;
                    customerProject.PROJECT_CONTACT_PERSON_NAME = item.PROJECT_CONTACT_PERSON_NAME;
                    customerProject.PROJECT_CONTACT_PERSON_PHONE = item.PROJECT_CONTACT_PERSON_PHONE;
                    customerProject.PROJECT_CONTACT_PERSON_EMAIL = item.PROJECT_CONTACT_PERSON_EMAIL;

                    Projectlist.Add(customerProject);
                }

                //var project = await Http.PostJsonAsync<List<CustomerProjectModel>>(Utility.BaseUrl + "api/Customer/AddCustomerProject", Projectlist);

                foreach (var item in customerContactList)
                {
                    customerContactModel = new CustomerContactModel();
                    customerContactModel.CUSTOMER_VENDOR_CODE = customerCode;
                    customerContactModel.NAME = item.NAME;
                    customerContactModel.DESIGNATION = item.DESIGNATION;
                    customerContactModel.DEPARTMENT_NAME = item.DEPARTMENT_NAME;
                    customerContactModel.MOBILE = item.MOBILE;
                    customerContactModel.EMAIL = item.EMAIL;
                    customerContactModel.WECHAT = item.WECHAT;
                    customerContactModel.WHATSAPP = item.WHATSAPP;
                    customerContactModel.TYPE = item.TYPE;

                    ContactList.Add(customerContactModel);
                }

                var customercontact = await Http.PostJsonAsync<List<CustomerContactModel>>(Utility.BaseUrl + "api/Customer/AddCustomerContact", ContactList);
                toastService.ShowSuccess("Save Success!!");
            }
            catch (Exception EX)
            {

            }
        }

    }
    private bool IsValidation()
    {
        bool flag = false;
        if (customer.CUSTOMER_NAME == "" || customer.CUSTOMER_NAME == string.Empty || customer.CUSTOMER_NAME == null)
        {
            toastService.ShowWarning("Customer Name Is Empty!");
            flag = true;
        }

        return flag;
    }
    private async Task Cancel()
    {
        customer = new CustomerModel();
        navManager.NavigateTo("Customers");
    }
    private void close()
    {
        customer = new CustomerModel();
        customerContact = new CustomerContactModel();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591