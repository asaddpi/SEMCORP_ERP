// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TOCOMA_ERP_System.Pages.Service
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ServiceSubCategory")]
    public partial class ServiceSubCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 176 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceSubCategory.razor"
       
    ServiceSubCategoryEntity itemCategory = new ServiceSubCategoryEntity();
    List<ServiceSubCategoryEntity> servicesubcategoryList = new List<ServiceSubCategoryEntity>();
    List<ServiceCategoryEntity> servicecategoryList = new List<ServiceCategoryEntity>();
    string submit = "Save";
    protected override async Task OnInitializedAsync()
    {
        await GetItemCategory();
        servicecategoryList = await Http.GetJsonAsync<List<ServiceCategoryEntity>>(Utility.BaseUrl + "api/Setup/GetServiceCategory");
        StateHasChanged();

        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");
    }
    private async Task GetItemCategory()
    {
        servicesubcategoryList = await Http.GetJsonAsync<List<ServiceSubCategoryEntity>>(Utility.BaseUrl + "api/Setup/GetServiceSubCategory");
    }
    public async Task SaveCategory()
    {
        if (IsValidation_Category() != true)
        {
            try
            {
                if (submit == "Save")
                {
                    itemCategory.Operation_Type = 1;
                    var data = await Http.PostJsonAsync<ServiceSubCategoryEntity>(Utility.BaseUrl + "api/Setup/AddServiceSubCategory", itemCategory);
                    toastService.ShowSuccess("Insert Successfully!!!");
                }
                else if (submit == "Update")
                {
                    var data = await Http.PutJsonAsync<ServiceSubCategoryEntity>(Utility.BaseUrl + "api/Setup/UpdateServiceSubCategory", itemCategory);
                    toastService.ShowSuccess("Update Successfully!!!");
                }

                itemCategory = new ServiceSubCategoryEntity();
                submit = "Save";
            }
            catch (Exception ex)
            { }
        }
        await GetItemCategory();
    }
    private async Task Cancel()
    {
        itemCategory = new ServiceSubCategoryEntity();
        submit = "Save";
    }
    private async Task editCategory(int subcategoryId)
    {
        submit = "Update";
        itemCategory = new ServiceSubCategoryEntity();
        itemCategory.SERVICE_SUB_CATEGORY_NAME = servicesubcategoryList.Find(x => x.SERVICE_SUB_CATEGORY_ID == subcategoryId).SERVICE_SUB_CATEGORY_NAME;
        itemCategory.SERVICE_CATEGORY_ID = servicesubcategoryList.Find(x => x.SERVICE_SUB_CATEGORY_ID == subcategoryId).SERVICE_CATEGORY_ID;
        itemCategory.SERVICE_CATEGORY_ID = subcategoryId;
        itemCategory.Operation_Type = 2;
    }
    private async Task DeleteCategory(int categoryId)
    {

        if (!await JSRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to delete ?"))
            return;

        await Http.DeleteAsync(Utility.BaseUrl + "api/Setup/DeleteServiceSubCategory/" + categoryId);
        await GetItemCategory();
    }
    private bool IsValidation_Category()
    {
        bool flag = false;
        if (itemCategory.SERVICE_SUB_CATEGORY_NAME == "" || itemCategory.SERVICE_SUB_CATEGORY_NAME == string.Empty || itemCategory.SERVICE_SUB_CATEGORY_NAME == null)
        {
            toastService.ShowWarning("SubCategory cannot be empty!");
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
