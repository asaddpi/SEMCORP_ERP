// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TOCOMA_ERP_System.Pages.Accounce.Master
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Ledgers")]
    public partial class Ledgers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 177 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\Ledgers.razor"
       
    LedgerModel ledger = new LedgerModel();
    List<LedgerModel> ledgerList = new List<LedgerModel>();
    List<LedgerModel> ledger_List = new List<LedgerModel>();
    List<BranchModel> branchList = new List<BranchModel>();
    List<LedgerGroupModel> ledgerGroupList = new List<LedgerGroupModel>();
    List<LedgerGroupModel> ledgerGrList = new List<LedgerGroupModel>();
    List<LedgerGroupModel> ledGrList = new List<LedgerGroupModel>();
    LedgerGroupModel lgModel = new LedgerGroupModel();
    string btnLabel;
    protected override async Task OnInitializedAsync()
    {
        btnLabel = "Save";
        await GetLedger();
        ledgerGroupList = await Http.GetJsonAsync<List<LedgerGroupModel>>(Utility.BaseUrl + "api/Transection/GetLedgerGroupList");
        StateHasChanged();
        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");

        foreach (var grItem in ledgerGroupList)
        {
            lgModel = new LedgerGroupModel();
            //lgModel.ledgerNameList = new List<LedgerModel>();
            lgModel = grItem;
            foreach (var lName in ledgerList)
            {

                //var item = ledgerList.Find(o => o.LEDGER_PARENT_GROUP == grItem.GR_NAME);
                if (lName.LEDGER_PARENT_GROUP == grItem.GR_NAME)
                {
                    ledger = new LedgerModel();
                    if (lgModel.ledgerNameList == null)
                    {
                        lgModel.ledgerNameList = new List<LedgerModel>();
                    }

                    ledger.LEDGER_NAME = lName.LEDGER_NAME;
                    lgModel.ledgerNameList.Add(ledger);

                    ledgerGrList.Add(lgModel);

                }
                ledGrList = ledgerGrList;
            }

        }

    }
    public async Task GetLedger()
    {
        ledgerList = new List<LedgerModel>();
        ledger_List = new List<LedgerModel>();
        try
        {
            ledgerList = await Http.GetJsonAsync<List<LedgerModel>>(Utility.BaseUrl + "api/Setup/GetLedger");

            foreach (var item in ledgerList)
            {
                ledger = new LedgerModel();
                ledger.LEDGER_SERIAL = item.LEDGER_SERIAL;
                ledger.LEDGER_PARENT_GROUP = item.LEDGER_PARENT_GROUP;
                ledger.LEDGER_NAME = item.LEDGER_NAME;
                ledger.LEDGER_OPENING_BALANCE = item.LEDGER_OPENING_BALANCE;
                if (item.LEDGER_OPENING_BALANCE < 0)
                {
                    string b = Convert.ToString(item.LEDGER_OPENING_BALANCE).Replace("-", "");
                    ledger.LEDGER_DEBIT_BALANCE = Convert.ToDecimal(b);
                }
                if (item.LEDGER_OPENING_BALANCE > 0)
                { ledger.LEDGER_CREDIT_BALANCE = item.LEDGER_OPENING_BALANCE; }
                ledger_List.Add(ledger);

            }
            StateHasChanged();
            await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");
        }
        catch(Exception ex)
        {

        }

    }
    public async Task SaveGroups()
    {
        if (IsValidation() != true)
        {
            try
            {
                var data = await Http.PostJsonAsync<BranchModel>(Utility.BaseUrl + "api/Setup/AddBranch", ledger);
                toastService.ShowSuccess("Item Added Successfully!!!");
            }
            catch (Exception ex)
            {

            }
        }
    }
    private bool IsValidation()
    {
        bool flag = false;
        if (ledger.LEDGER_NAME == "" || ledger.LEDGER_NAME == string.Empty || ledger.LEDGER_NAME == null)
        {
            toastService.ShowWarning("Branch Name cannot be empty!");
            flag = true;
        }

        return flag;
    }
    private void EditClick(int Code)
    {
        btnLabel = "Update";
        //branch = branchList.FirstOrDefault(x => x.BRANCH_ID == branchCode);
    }
    private async Task DeleteLedger(string name)
    {
        if (!await JSRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to delete ?"))
            return;
        bool isExist = await Http.GetJsonAsync<bool>(Utility.BaseUrl + "api/Setup/GetLedgerByGRName/" + name);
        if (isExist != true)
        { await Http.DeleteAsync(Utility.BaseUrl + "api/Setup/DeleteLedgerByName/" + name); }
        else { toastService.ShowWarning("Default Ledger Can not be deleted."); }
        await GetLedger();
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