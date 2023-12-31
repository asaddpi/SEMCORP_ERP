// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TOCOMA_ERP_System.Pages.Misc
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/BillRequisition")]
    public partial class BillRequisition : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
       
    clsMiscBillRequisition misc = new clsMiscBillRequisition();
    List<clsMiscBillRequisition> misclist = new List<clsMiscBillRequisition>();
    List<LedgerModel> ledgerList = new List<LedgerModel>();
    List<EmployeeModel> employeeList = new List<EmployeeModel>();
    string submit = "Save";
    string require_date;
    protected override async Task OnInitializedAsync()
    {
        await GetBillReq();
        await GetLedger();
        employeeList = await Http.GetJsonAsync<List<EmployeeModel>>(Utility.BaseUrl + "api/Employee");
        StateHasChanged();
        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");
        await JSRuntime.InvokeVoidAsync("JsInteropDatepicker");
    }
    private async Task GetLedger()
    {
        ledgerList = await Http.GetJsonAsync<List<LedgerModel>>(Utility.BaseUrl + "api/Setup/GetLedger");
    }
    private async Task GetBillReq()
    {
        misclist = await Http.GetJsonAsync<List<clsMiscBillRequisition>>(Utility.BaseUrl + "api/Setup/GetBrandList");
    }
    public async Task SaveBillReq()
    {
        if (IsValidation_Brand() != true)
        {
            try
            {
                if (submit == "Save")
                {
                    misc.Operation_Type = 1;
                    string d = require_date.Substring(0, 2);
                    string m = require_date.Substring(3,2);
                    string y = require_date.Substring(6, 4);
                    string dt = y + "-" + m + "-" + d;
                    misc.DATE = Utility.GetDateFromStringToDate(require_date); //Convert.ToDateTime(dt);
                    misc.STATUS = "Submitted";
                    var data = await Http.PostJsonAsync<clsMiscBillRequisition>(Utility.BaseUrl + "api/Transection/AddBillReq", misc);
                    toastService.ShowSuccess("Insert Successfully!!!");
                }
                else if (submit == "Update")
                {
                    misc.Operation_Type = 2;
                    var data = await Http.PutJsonAsync<clsMiscBillRequisition>(Utility.BaseUrl + "api/Transection/UpdateBrand", misc);
                    toastService.ShowSuccess("Insert Successfully!!!");
                }
                submit = "Save";
                misc = new clsMiscBillRequisition();
            }
            catch (Exception ex)
            {

            }

        }
        await GetBillReq();
    }
    private bool IsValidation_Brand()
    {
        bool flag = false;
        if (misc.LEDGER_NAME == "" || misc.LEDGER_NAME == null)
        {
            toastService.ShowWarning("Please Select LEDGER_NAME!");
            flag = true;
        }

        return flag;
    }
    private async Task Cancel()
    {
        misc = new clsMiscBillRequisition();
        submit = "Save";
    }
    private async Task EditBrand(int Id)
    {
        submit = "Update";
        misc = new clsMiscBillRequisition();
        //misc.LEDGER_NAME = brandList.Find(x => x.BRAND_ID == Id).BRAND_NAME;
        misc.BILL_REQUISITION_ID = Id;
        misc.Operation_Type = 2;
    }
    private async Task Delete(int Id)
    {

        if (!await JSRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to delete ?"))
            return;

        await Http.DeleteAsync(Utility.BaseUrl + "api/Setup/DeleteBrand/" + Id);
        await GetBillReq();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
