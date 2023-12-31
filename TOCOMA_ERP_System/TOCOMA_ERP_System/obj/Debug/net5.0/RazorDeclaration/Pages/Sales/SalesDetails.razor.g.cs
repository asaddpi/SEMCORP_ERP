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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/SalesDetails/{DeliveryNoteNo}")]
    public partial class SalesDetails : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 259 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\SalesDetails.razor"
       
    [Parameter]
    public string DeliveryNoteNo { get; set; }
    SalesOrderViewModel salesInfo = new SalesOrderViewModel();
    List<SalesItemDetailsModel> itemList = new List<SalesItemDetailsModel>();
    List<PurchaseTermsConditionsModel> termsConditionList = new List<PurchaseTermsConditionsModel>();
    List<PurchaseTermsConditionsModel> termsAndConditionList = new List<PurchaseTermsConditionsModel>();
    PurchaseTermsConditionsModel condition = new PurchaseTermsConditionsModel();
    int iOption = 0;
    string termsId = "";
    string _localcolor;
    string _intcolor;
    int IL_OPTION;
    int rptType;
    string Report_URl;
    string ischeckedDN;
    string ischeckedIN;
    string deliveredQuantity;

    protected override async Task OnInitializedAsync()
    {
        salesInfo = await Http.GetJsonAsync<SalesOrderViewModel>(Utility.BaseUrl + "api/Sales/GetSalesInfoByPONo/" + DeliveryNoteNo);
        itemList = await Http.GetJsonAsync<List<SalesItemDetailsModel>>(Utility.BaseUrl + "api/Sales/GetSalesItemByPONo/" + DeliveryNoteNo);
        termsId = salesInfo.TERMS_AND_CONDITION;
        if (termsId != null)
        { termsAndConditionList = await Http.GetJsonAsync<List<PurchaseTermsConditionsModel>>(Utility.BaseUrl + "api/Sales/GetTermsAndConditions/" + termsId); }
        //int i = 1;
        foreach(var item in termsAndConditionList)
        {
            condition = new PurchaseTermsConditionsModel();
            condition.PURCHASE_TERMS_CONDITION_ID = item.PURCHASE_TERMS_CONDITION_ID;
            condition.SALES_TERMS_CONDITION_ID = item.SALES_TERMS_CONDITION_ID;
            condition.SL = item.SL;
            condition.TERMS_AND_CONDITIONS = item.SL+" ."+item.TERMS_AND_CONDITIONS;

            termsConditionList.Add(condition);
            //i++;
        }
        //AppState.salesOrderView = salesInfo;
        //AppState.salesItemDetails = itemList;
        AppState.SalestermsConditionList = termsConditionList;
        iOption = 1;
        //_localcolor = "transparent;color:blueviolet";
        //_intcolor = "transparent;color:black";
        IL_OPTION = 1;
        rptType = 1;
        Report_URl = "Excel/GenerateDeliveryNote";
        ischeckedDN = "checked";
    }
    private async void DeliveryNoteClicked()
    {
        iOption = 1;
        StateHasChanged();
    }
    private async void InvoiceClicked()
    {
        iOption = 2;
        StateHasChanged();
    }

    private void Local_Tab_Click()
    {
        _localcolor = "transparent;color:blueviolet";
        _intcolor = "transparent;color:black;border:none";
        IL_OPTION = 1;
        rptType = 1;
        Report_URl = "Excel/GenerateDeliveryNote";

    }
    private void Int_Tab_Click()
    {
        _intcolor = "transparent;color:blueviolet";
        _localcolor = "transparent;color:black;border:none";
        IL_OPTION = 2;
        rptType = 2;
        Report_URl = "Excel/GenerateSalesInvoice";

    }
    public async Task GetSalesDeliveryNote()
    {
        rptType = 1;
        //AppState.salesOrderView = salesInfo;
        //AppState.salesItemDetails = itemList;
        AppState.SalestermsConditionList = termsConditionList;
        //ischeckedIN = "null";
        //ischeckedDN = "null";
        StateHasChanged();

    }
    public async Task GetSalesInvoice()
    {
        rptType = 2;

        //AppState.salesOrderView = salesInfo;
        //AppState.salesItemDetails = itemList;
        AppState.SalestermsConditionList = termsConditionList;
        //ischeckedDN = "unchecked";
        //ischeckedIN = "checked";
        StateHasChanged();

    }
    private async Task GoPreview()
    {
        //if(rptType==1)
        //{ }
        //else if(rptType==2)
        //{ }
        if(rptType==1)
        { await JsRuntime.InvokeAsync<object>("open", "api/RDLCReport/GetSalesDeliveryNote", "_blank"); }
        else if(rptType==2)
        { await JsRuntime.InvokeAsync<object>("open", "api/RDLCReport/GetSalesInvoice", "_blank"); }

    }
    public void DeliveryCheckboxClicked( object aChecked)
    {
        if ((bool)aChecked)
        {
            IL_OPTION = 1;
            rptType = 1;
            //if (!SelectedValues.Contains(aSelectedId))
            //{
            //    SelectedValues.Add(aSelectedId);
            //}
        }
        else
        {
            //if (SelectedValues.Contains(aSelectedId))
            //{
            //    SelectedValues.Remove(aSelectedId);
            //}
        }
        StateHasChanged();
    }


    public void InvoiceCheckboxClicked(object aChecked)
    {
        if ((bool)aChecked)
        {
            IL_OPTION = 2;
            rptType = 2;
            //if (!SelectedValues.Contains(aSelectedId))
            //{
            //    SelectedValues.Add(aSelectedId);
            //}
        }
        else
        {
            //if (SelectedValues.Contains(aSelectedId))
            //{
            //    SelectedValues.Remove(aSelectedId);
            //}
        }
        StateHasChanged();
    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.JSInterop.IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
