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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/JournalVoucher")]
    public partial class JournalVoucher : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 186 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Transection\JournalVoucher.razor"
       
    LedgerModel ledger = new LedgerModel();
    List<LedgerModel> ledgerList = new List<LedgerModel>();
    List<BranchModel> branchList = new List<BranchModel>();
    string MyProperty;
    List<string> itemList = new List<string>();
    List<CountryModel> countryList = new List<CountryModel>();
    private LedgerModel SelectedArticle;
    private string newTodo;
    List<VoucherItem> voucherItemList = new List<VoucherItem>();
    VoucherItem paymentvoucher = new VoucherItem();
    ACC_COMPANY_VOUCHER_MODEL accCompanyVoucherModel = new ACC_COMPANY_VOUCHER_MODEL();
    List<ACC_VOUCHER_MODEL> paymentVoucherDetails = new List<ACC_VOUCHER_MODEL>();
    ACC_VOUCHER_MODEL voucherDetails = new ACC_VOUCHER_MODEL();
    decimal amount;
    string KeyPressed = "";
    public string Value { get; set; }
    public string MyDrValue { get; set; }
    public string MyCrValue { get; set; }
    private ElementReference myref;
    private ElementReference narrationref;
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


    protected override async Task OnInitializedAsync()
    {
        MyProperty = "Dr";
        onDisable(MyProperty);
        accCompanyVoucherModel.COMP_REF_NO = await Http.GetStringAsync(Utility.BaseUrl + "api/Transection/GetVoucherNo/" + 3);
        currentDate = System.DateTime.Now.Year + "-" + (System.DateTime.Now.Month).ToString().PadLeft(2, '0') + "-" + System.DateTime.Now.Day.ToString().PadLeft(2, '0');
        //await GetCountry();
        await GetLedger();
        await GetBranch();
        StateHasChanged();

    }
    void selectedledger(ChangeEventArgs e)
    {
        SelectedString = e.Value.ToString();
        if (SelectedString == "Bank Accounts") { bankStatus = 1; }
        else { bankStatus = 0; }
    }
    public async Task GetBranch()
    {
        branchList = await Http.GetJsonAsync<List<BranchModel>>(Utility.BaseUrl + "api/Setup/GetBranchList");
        if (branchList.Count > 0)
        { BranchName = branchList.FirstOrDefault().BRANCH_NAME; }


    }
    private async Task GetLedger()
    {
        ledgerList = await Http.GetJsonAsync<List<LedgerModel>>(Utility.BaseUrl + "api/Setup/GetLedger");
    }
    //private async Task GetCountry()
    //{
    //    countryList = await Http.GetJsonAsync<List<CountryModel>>(Utility.BaseUrl + "api/Setup/GetCountry");
    //}


    private async Task<IEnumerable<LedgerModel>> SearchLedger(string searchText)
    {


        return await Task.FromResult(ledgerList.Where(x => x.LEDGER_NAME.ToLower().Contains(searchText.ToLower())).ToList());

        //return await Task.FromResult(ledgerList);
    }
    private async Task<IEnumerable<LedgerModel>> KeyPressLedger(string searchText)
    {
        return await Task.FromResult(ledgerList.Where(x => x.LEDGER_NAME.ToLower().Contains(searchText.ToLower())).ToList());


    }

    public async Task SavePaymentVoucher()
    {
        //if (IsValidation() != true)
        //{
        bool exists = voucherItemList.Exists(x => x.symbol == "Cr");
        if (exists != true)
        {
            toastService.ShowWarning("Please Add Credit Info In List");
            return;
        }
        else if (accCompanyVoucherModel.COMP_REF_NO == "")
        {
            toastService.ShowWarning("Please Add Voucher No.");
            return;
        }
        else
        {
            if (!await jsruntime.InvokeAsync<bool>("confirm", $"Do you want to save ?"))
                return;


            try
            {
                if (selected_date == "" || selected_date == null)
                { accCompanyVoucherModel.COMP_VOUCHER_DATE = Convert.ToDateTime(currentDate); }
                accCompanyVoucherModel.BRANCH_ID = branchList.Find(x => x.BRANCH_NAME == BranchName).BRANCH_ID;
                accCompanyVoucherModel.LEDGER_NAME = voucherItemList.FirstOrDefault().particular;
                accCompanyVoucherModel.COMP_VOUCHER_AMOUNT = totalDebit;
                accCompanyVoucherModel.COMP_VOUCHER_ADD_AMOUNT = totalDebit;
                accCompanyVoucherModel.COMP_VOUCHER_LESS_AMOUNT = totalDebit;
                accCompanyVoucherModel.COMP_VOUCHER_NET_AMOUNT = totalDebit;
                accCompanyVoucherModel.COMP_VOUCHER_PROCESS_AMOUNT = totalDebit;
                accCompanyVoucherModel.COMP_VOUCHER_NARRATION = narration;
                accCompanyVoucherModel.COMP_VOUCHER_TYPE =3;
                accCompanyVoucherModel.ENTRYBY = "Asaduzzaman";
                accCompanyVoucherModel.UPDATEBY = "Asaduzzaman";




                //var data = await Http.PostJsonAsync<ACC_COMPANY_VOUCHER_MODEL>(Utility.BaseUrl + "api/Transection/AddPaymentVoucher", accCompanyVoucherModel);
                foreach (var item in voucherItemList)
                {
                    voucherDetails = new ACC_VOUCHER_MODEL();
                    voucherDetails.COMP_REF_NO = accCompanyVoucherModel.COMP_REF_NO;
                    voucherDetails.VOUCHER_REF_KEY = "";
                    voucherDetails.BRANCH_ID = accCompanyVoucherModel.BRANCH_ID;
                    voucherDetails.COMP_VOUCHER_DATE = accCompanyVoucherModel.COMP_VOUCHER_DATE;
                    voucherDetails.COMP_VOUCHER_TYPE =3;
                    voucherDetails.LEDGER_NAME = item.particular;
                    voucherDetails.VOUCHER_DEBIT_AMOUNT = item.debitAmount;
                    voucherDetails.VOUCHER_CREDIT_AMOUNT = item.creditAmount;
                    voucherDetails.VOUCHER_ADD_AMOUNT = item.creditAmount;
                    voucherDetails.VOUCHER_LESS_AMOUNT = item.creditAmount;
                    voucherDetails.VOUCHER_TOBY = item.symbol;
                    voucherDetails.VOUCHER_FC_DEBIT_AMOUNT = 0;
                    voucherDetails.VOUCHER_FC_CREDIT_AMOUNT = 0;
                    if (item.ChequeNo != "" && item.ChequeNo != null && item.ChequeNo != "NULL")
                    {
                        voucherDetails.VOUCHER_CHEQUE_NUMBER = item.ChequeNo;
                        voucherDetails.VOUCHER_CHEQUE_DATE = item.ChequeDate;
                        voucherDetails.VOUCHER_CHEQUE_DRAWN_ON = item.DrawnOn;
                    }
                    paymentVoucherDetails.Add(voucherDetails);
                    accCompanyVoucherModel.accVoucherList.Add(voucherDetails);
                }
                //var voucher = await Http.PostJsonAsync<List<ACC_VOUCHER_MODEL>>(Utility.BaseUrl + "api/Transection/AddPaymentVoucherDetails", paymentVoucherDetails);
                var data = await Http.PostJsonAsync<ACC_COMPANY_VOUCHER_MODEL>(Utility.BaseUrl + "api/Transection/AddPaymentVoucher", accCompanyVoucherModel);
                if (data.status == true)
                {
                    toastService.ShowSuccess("Save Successfully!!!");
                    await LoadPage();
                }
                else { toastService.ShowError("Not Save :" + data.ErrorMessage); }

            }
            catch (Exception ex)
            {

            }
        }


    }
    private async Task GetVoucherNo()
    {
        accCompanyVoucherModel.COMP_REF_NO = await Http.GetStringAsync(Utility.BaseUrl + "api/Transection/GetVoucherNo/" + 3);
    }
    private async Task LoadPage()
    {
        await GetVoucherNo();
        voucherItemList = new List<VoucherItem>();
        visibletext = 0;
        MyProperty = "Dr";
        totalDebit = 0;
        totalCredit = 0;
        onDisable(MyProperty);
        StateHasChanged();
    }
    private void Keypress(KeyboardEventArgs args)
    {
        string value;
        value = args.Key;
        if (value == "c" || value == "C")
        { MyProperty = "Cr"; }
        else if (value == "d" || value == "D")
        { MyProperty = "Dr"; }
        StateHasChanged();
        onDisable(MyProperty);
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
    //private void Enter(KeyboardEventArgs e)
    //private void Enter()
    //{
    //    //if (e.Key == "Enter")
    //    {
    //        if (!string.IsNullOrWhiteSpace(newTodo))
    //        {
    //            //todos.Add(new TodoItem { Title = newTodo });
    //            //newTodo = string.Empty;
    //        }
    //    }
    //}
    private async void DoTheThing(KeyboardEventArgs eventArgs)
    {
        if (eventArgs.Key == "Enter")
        {

            paymentvoucher = new VoucherItem();
            paymentvoucher.symbol = MyProperty;
            paymentvoucher.particular = SelectedString; //SelectedArticle.LEDGER_NAME;
            if (paymentvoucher.particular == "" || paymentvoucher.particular == null)
            {
                toastService.ShowWarning("Please Add Particular");
            }
            else
            {
                if (MyProperty == "Dr")
                {
                    paymentvoucher.debitAmount = Convert.ToDecimal(MyDrValue);
                }
                if (MyProperty == "Cr")
                {
                    paymentvoucher.creditAmount = Convert.ToDecimal(MyCrValue);
                }
                if (chequeNo != "" && chequeNo != null)
                {
                    paymentvoucher.ChequeNo = chequeNo;
                    paymentvoucher.ChequeDate = Convert.ToDateTime(voucherChequedate);
                    paymentvoucher.DrawnOn = drawnon;

                }
                else
                {
                    paymentvoucher.ChequeNo = "NULL";
                    paymentvoucher.ChequeDate = Convert.ToDateTime("1900-01-01");
                    paymentvoucher.DrawnOn = "NULL";
                }


                voucherItemList.Add(paymentvoucher);

                totalDebit = voucherItemList.Sum(item => item.debitAmount);
                totalCredit = voucherItemList.Sum(item => item.debitAmount); //voucherItemList.Sum(item => item.creditAmount);


                bool exists = voucherItemList.Exists(x => x.symbol == "Cr");

                if (exists != true)
                {
                    MyProperty = "Cr";
                    //double total = myList.Sum(item => item.Amount);
                    MyCrValue = Convert.ToString(voucherItemList.Sum(item => item.debitAmount));
                    //SelectedArticle.LEDGER_NAME = "";
                    SelectedString = "";
                    MyDrValue = "";
                    bankStatus = 0;
                    chequeNo = "";
                    drawnon = "";

                    onDisable(MyProperty);
                    await myref.FocusAsync();

                }
                else
                {
                    //visibletext = 1;
                    StateHasChanged();
                    MyProperty = "";
                    //SelectedArticle.LEDGER_NAME = "";
                    SelectedString = "";
                    MyDrValue = "";
                    MyCrValue = "";
                    bankStatus = 0;
                    chequeNo = "";
                    drawnon = "";

                    await narrationref.FocusAsync();
                }
            }
        }
    }
    //public void Enter(KeyboardEventArgs e)
    //{
    //    if (e.Code == "Enter" || e.Code == "NumpadEnter")
    //    {
    //        // ...
    //        KeyPressed = "Key Pressed is " + this.Value;

    //        //amount = e.Key;
    //        paymentvoucher = new VoucherItem();
    //        paymentvoucher.symbol = MyProperty;
    //        paymentvoucher.particular = SelectedArticle.LEDGER_NAME;
    //        if (MyProperty == "Dr")
    //        {
    //            paymentvoucher.debitAmount = amount;
    //        }
    //        if (MyProperty == "Cr")
    //        {
    //            paymentvoucher.creditAmount = amount;
    //        }

    //        voucherItemList.Add(paymentvoucher);



    //    }
    //}
    //public class VoucherItem
    //{
    //    public string symbol { get; set; }
    //    public string particular { get; set; }
    //    public decimal debitAmount { get; set; }
    //    public decimal creditAmount { get; set; }
    //    public string ChequeNo { get; set; }
    //    //public DateTime ChequeDate { get; set; }
    //    public Nullable<DateTime> ChequeDate { get; set; }

    //    public string DrawnOn { get; set; }
    //}
    private async void GetDate(ChangeEventArgs change)
    {
        selected_date = change.Value.ToString();
        accCompanyVoucherModel.COMP_VOUCHER_DATE = Convert.ToDateTime(selected_date);
    }
    private async void GetChequeDate(ChangeEventArgs change)
    {
        voucherChequedate = change.Value.ToString();

    }
    void CloseClicked() { UriHelper.NavigateTo("JournalVoucherList"); }


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
