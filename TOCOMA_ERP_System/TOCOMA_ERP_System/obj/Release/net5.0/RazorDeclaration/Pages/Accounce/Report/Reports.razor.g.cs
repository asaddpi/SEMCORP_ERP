// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TOCOMA_ERP_System.Pages.Accounce.Report
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Reports")]
    public partial class Reports : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 186 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Report\Reports.razor"
       
    string fromdate;
    string todate;
    string currentDate;
    string ReportType;
    IJSObjectReference module;
    [Inject]
    public IJSRuntime JSRuntime { get; set; }
    private IJSObjectReference _jsModule;
    List<ACC_Trial_Balance_Report> trialBalanceReport = new List<ACC_Trial_Balance_Report>();
    List<ACC_PROFIT_LOSS> profitAndLossReport = new List<ACC_PROFIT_LOSS>();
    List<ACC_Balance_Sheet_Report> balanceSheetReport = new List<ACC_Balance_Sheet_Report>();
    List<ACC_General_Ledger_Report> generalLedgerReport = new List<ACC_General_Ledger_Report>();
    LedgerModel ledger = new LedgerModel();
    string SelectedString = "";
    List<LedgerModel> ledgerList = new List<LedgerModel>();
    protected override async Task OnInitializedAsync()
    {
        base.OnInitialized();        
        ledgerList = await Http.GetJsonAsync<List<LedgerModel>>(Utility.BaseUrl + "api/Setup/GetLedger");        
        currentDate = System.DateTime.Now.Year + "-" + (System.DateTime.Now.Month).ToString().PadLeft(2, '0') + "-" + System.DateTime.Now.Day.ToString().PadLeft(2, '0');

    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JsRuntime.InvokeVoidAsync("JsInteropcollaps");
            currentDate = System.DateTime.Now.Year + "-" + (System.DateTime.Now.Month).ToString().PadLeft(2, '0') + "-" + System.DateTime.Now.Day.ToString().PadLeft(2, '0');

        }

    }
    private async void GetFromDate(ChangeEventArgs change)
    {
        fromdate = change.Value.ToString();
        //accCompanyVoucherModel.COMP_VOUCHER_DATE = Convert.ToDateTime(date);
    }
    private async void GetToDate(ChangeEventArgs change)
    {
        todate = change.Value.ToString();
        //accCompanyVoucherModel.COMP_VOUCHER_DATE = Convert.ToDateTime(date);
    }
    public async Task GetGeneralLedger()
    {
        if (fromdate == null)
        { fromdate = currentDate; }
        if (todate == null)
        { todate = currentDate; }
        generalLedgerReport = new List<ACC_General_Ledger_Report>();

        generalLedgerReport = await Http.GetJsonAsync<List<ACC_General_Ledger_Report>>(Utility.BaseUrl + "api/Transection/GetGeneralLedger/" + fromdate + "/" + todate + "/" + SelectedString);
        ledger = await Http.GetJsonAsync<LedgerModel>(Utility.BaseUrl + "api/Transection/GetLedgerDataByLedgerName/" + SelectedString);
        SessionData.From_date = fromdate;
        SessionData.To_date = todate;
        SessionData.generalLedgerList = generalLedgerReport;
        SessionData.sessionLedgerModel = ledger;
        await JSRuntime.InvokeAsync<object>("open", "api/RDLCReport/GetGeneralLedgerReport", "_blank");
    }
    void selectedledger(ChangeEventArgs e)
    {
        SelectedString = e.Value.ToString();
    }
    private void ReportTypeClick(int Type)
    {
        if (Type == 1)
        { ReportType = "Trial Balance"; }
        else if (Type == 2)
        { ReportType = "Balance Sheet"; }
        else if (Type == 3)
        { ReportType = "Profit & Loss"; }
    }
    public async Task GetTrialBalance(string Type)
    {

        ////int type = 4;
        //string REFNO = "1234";

        //int tpe = 1;
        if (fromdate == null)
        { fromdate = currentDate; }
        if (todate == null)
        { todate = currentDate; }
        try
        {
            if (ReportType == "Trial Balance")
            {
                //trialBalanceReport = new List<ACC_Trial_Balance_Report>();
                //string url = Utility.BaseUrl + "api/Transection/GetTrialBalanceInfo/" + fromdate+"/"+ todate;
                //string url = Utility.BaseUrl + "api/Transection/GetTrialBalanceInfo/" + "20220801" + "/" + "20220911";
                //string url = Utility.BaseUrl + "api/Transection/GetTrialBalanceInfo";
                trialBalanceReport = new List<ACC_Trial_Balance_Report>();

                trialBalanceReport = await Http.GetJsonAsync<List<ACC_Trial_Balance_Report>>(Utility.BaseUrl + "api/Transection/Get_ACC_TrialBalanceInfo/" + fromdate + "/" + todate);
                //trialBalanceReport = await Http.GetJsonAsync<List<ACC_Trial_Balance_Report>>(url);
                SessionData.From_date = fromdate;
                SessionData.To_date = todate;
                SessionData.trialBalanceList = trialBalanceReport;
                await JSRuntime.InvokeAsync<object>("open", "api/RDLCReport/GetTrialBalanceReport", "_blank");
            }
            else if (ReportType == "Balance Sheet")
            {
                //await JSRuntime.InvokeAsync<object>("open", "api/RDLCReport/GetBalanceSheetReport/" + REFNO + "/" + tpe, "_blank");
                balanceSheetReport = new List<ACC_Balance_Sheet_Report>();
                balanceSheetReport = await Http.GetJsonAsync<List<ACC_Balance_Sheet_Report>>(Utility.BaseUrl + "api/Transection/GetBalanceSheet/" + fromdate + "/" + todate);
                SessionData.From_date = fromdate;
                SessionData.To_date = todate;
                SessionData.balanceSheetList = balanceSheetReport;
                await JSRuntime.InvokeAsync<object>("open", "api/RDLCReport/GetBalanceSheetReport", "_blank");
            }
            else if (ReportType == "Profit & Loss")
            {

                //await JSRuntime.InvokeAsync<object>("open", "api/RDLCReport/GetProfitLossReport/" + REFNO + "/" + tpe, "_blank");
                profitAndLossReport = new List<ACC_PROFIT_LOSS>();
                profitAndLossReport = await Http.GetJsonAsync<List<ACC_PROFIT_LOSS>>(Utility.BaseUrl + "api/Transection/GetProfitAndLoss/" + fromdate + "/" + todate);
                //decimal income = profitAndLossReport.Sum(x => Convert.ToDecimal(x.));
                decimal income = profitAndLossReport.Where(p => p.GR_PRIMARY_TYPE == "Income" && p.GR_NAME != "Total Income").Sum(p => Convert.ToDecimal(p.GR_AMOUNT));
                decimal expense = profitAndLossReport.Where(p => p.GR_PRIMARY_TYPE == "Expenses" && p.GR_NAME != "Total Expense").Sum(p => Convert.ToDecimal(p.GR_AMOUNT));
                decimal TotalProfitLoss = income - expense;
                SessionData.TotalProfitLoss = TotalProfitLoss;
                SessionData.From_date = fromdate;
                SessionData.To_date = todate;
                SessionData.profitAndLossList = profitAndLossReport;
                await JSRuntime.InvokeAsync<object>("open", "api/RDLCReport/GetProfitLossReport", "_blank");
            }
        }
        catch (Exception EX)
        {

        }


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.JSInterop.IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591