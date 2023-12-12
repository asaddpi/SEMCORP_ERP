// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TOCOMA_ERP_System.Pages.Accounce.Transection
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/ReceiveVoucherList")]
    public partial class ReceiveVoucherList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Transection\ReceiveVoucherList.razor"
       
    List<ACC_COMPANY_VOUCHER_MODEL> accCompanyVoucherList = new List<ACC_COMPANY_VOUCHER_MODEL>();
    string btnLabel;
    int Receive_Voucher_Type = 2;
    List<ACC_VOUCHER_MODEL> voucher = new List<ACC_VOUCHER_MODEL>();
    SessionData session = new SessionData();
    protected override async Task OnInitializedAsync()
    {
        btnLabel = "Save";
        await GetVoucherList();
        StateHasChanged();
        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");

    }
    private async Task GetVoucherList()
    {
        accCompanyVoucherList = await Http.GetJsonAsync<List<ACC_COMPANY_VOUCHER_MODEL>>(Utility.BaseUrl + "api/Transection/GetVoucherList/" + Receive_Voucher_Type);
    }


    private void EditClick(int Code)
    {
        btnLabel = "Update";
        //branch = branchList.FirstOrDefault(x => x.BRANCH_ID == branchCode);
    }
    private async Task DeletePayment(string Code)
    {
        if (!await JSRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to delete ?"))
            return;

        ACC_COMPANY_VOUCHER_MODEL vouchermodel = new ACC_COMPANY_VOUCHER_MODEL();
        vouchermodel.COMP_REF_NO = Code;
        vouchermodel.COMP_VOUCHER_TYPE =2;
        await Http.PostJsonAsync(Utility.BaseUrl + "api/Transection/DeletePaymentByRefNo", vouchermodel);
        await GetVoucherList();
    }
    public async Task PaymentViewReport(string REFNO)
    {

        voucher = new List<ACC_VOUCHER_MODEL>();
        voucher = await Http.GetJsonAsync<List<ACC_VOUCHER_MODEL>>(Utility.BaseUrl + "api/Transection/GetACCVoucherByRefNo/" + REFNO);
        SessionData.paymentDataList = voucher;
        int type = 2;
        await JSRuntime.InvokeAsync<object>("open", "api/RDLCReport/GetPaymentReport/" + REFNO+"/"+ type, "_blank");
        //var postBody = new { Title = "Blazor POST Request Example" };
        //using var response = await Http.PostJsonAsync("https://reqres.in/invalid-url", postBody);
        //var request = new HttpRequestMessage(HttpMethod.Post, "RDLCReport/GetPaymentReport");
        //accCompanyVoucherModel = await Http.GetJsonAsync<ACC_COMPANY_VOUCHER_MODEL>(Utility.BaseUrl + "api/Transection/GetPaymentVoucherByRefNo/" + REFNO);
        //voucher = new List<ACC_VOUCHER_MODEL>();
        //voucher = await Http.GetJsonAsync<List<ACC_VOUCHER_MODEL>>(Utility.BaseUrl + "api/Transection/GetACCVoucherByRefNo/" + REFNO);
        //SessionData.paymentDataList = new List<ACC_VOUCHER_MODEL>();
        //href = "http://localhost:7558/api/RDLCReport/GetPaymentReport/@item.COMP_REF_NO"
        //SessionData.paymentDataList = voucher;

        //navManager.NavigateTo("api/RDLCReport/GetPaymentReport/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
    }
}
#pragma warning restore 1591
