#pragma checksum "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\DeliveryNote\DeliveryNoteList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59b26b76d60b3f059d27dbe68ff91ee5efd9f6e4"
// <auto-generated/>
#pragma warning disable 1591
namespace TOCOMA_ERP_System.Pages.DeliveryNote
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/DeliveryNoteList")]
    public partial class DeliveryNoteList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    table, tr, td {\r\n        border: none;\r\n        text-align: center;\r\n    }\r\n\r\n    table, tbody, tr, td {\r\n        padding: 5px;\r\n    }\r\n    \r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-md-12");
            __builder.AddAttribute(3, "style", "display: flex;align-items:center;justify-content:space-between");
            __builder.AddMarkupContent(4, "<div class=\"col-md-4\"><h5>Delivery Note List</h5></div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class");
            __builder.AddAttribute(7, "style", "display:flex;gap:10px;align-items:center");
            __builder.AddMarkupContent(8, "<a href=\"NewDeliveryNote\"><button class=\"btn btn-primary\" style=\"display:flex;justify-content:center;height:40px;align-items:center;width:max-content;padding:0 10px\"><i class=\"bi bi-plus\" style=\"font-size:30px\"></i> New</button></a>\r\n\r\n\r\n        ");
            __builder.OpenElement(9, "label");
            __builder.AddAttribute(10, "style", "margin-bottom:0!important");
            __builder.AddContent(11, 
#nullable restore
#line 27 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\DeliveryNote\DeliveryNoteList.razor"
                                                  StartNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, "-");
            __builder.AddContent(13, 
#nullable restore
#line 27 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\DeliveryNote\DeliveryNoteList.razor"
                                                               EndNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, " of ");
            __builder.AddContent(15, 
#nullable restore
#line 27 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\DeliveryNote\DeliveryNoteList.razor"
                                                                             quotationList.Count()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "style", "color:Highlight;");
            __builder.OpenElement(19, "i");
            __builder.AddAttribute(20, "class", "bi bi-arrow-left-circle");
            __builder.AddAttribute(21, "style", "font-size:30px");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\DeliveryNote\DeliveryNoteList.razor"
                                                                                  e => NavigatTo("prev")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "style", "color:Highlight");
            __builder.OpenElement(25, "i");
            __builder.AddAttribute(26, "class", "bi bi-arrow-right-circle");
            __builder.AddAttribute(27, "style", "font-size:30px;");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\DeliveryNote\DeliveryNoteList.razor"
                                                                                    e => NavigatTo("next")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(30, "table");
            __builder.AddAttribute(31, "id", "#example");
            __builder.AddAttribute(32, "width", "100%");
            __builder.AddMarkupContent(33, "<thead><tr><td>DN No</td>\r\n            <td>Delivery Date</td>\r\n            <td style=\"text-align:left\">Customer</td>\r\n            <td style=\"text-align:left\">Project</td></tr></thead>\r\n    ");
            __builder.OpenElement(34, "tbody");
#nullable restore
#line 56 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\DeliveryNote\DeliveryNoteList.razor"
         if (AllDeliveryNoteList != null)
        {
            foreach (var item in AllDeliveryNoteList)
            {
                

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "tr");
            __builder.OpenElement(36, "td");
            __builder.AddAttribute(37, "style", "width:150px");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "style", "color:Highlight;cursor:pointer");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\DeliveryNote\DeliveryNoteList.razor"
                                                                                                 () => DeliveryNoteClicked(item.DELIVERY_NOTE_NO)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, 
#nullable restore
#line 80 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\DeliveryNote\DeliveryNoteList.razor"
                                                                                                                                                    item.DELIVERY_NOTE_NO

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n                    ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 82 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\DeliveryNote\DeliveryNoteList.razor"
                         item.DELIVERY_DATE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "td");
            __builder.AddAttribute(47, "style", "text-align:left");
            __builder.AddContent(48, 
#nullable restore
#line 83 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\DeliveryNote\DeliveryNoteList.razor"
                                                 item.CUSTOMER_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "td");
            __builder.AddAttribute(51, "style", "text-align:left");
            __builder.AddContent(52, 
#nullable restore
#line 84 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\DeliveryNote\DeliveryNoteList.razor"
                                                 item.SHIPPING_PROJECT_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 89 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\DeliveryNote\DeliveryNoteList.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\DeliveryNote\DeliveryNoteList.razor"
       

    CustomerModel customer = new CustomerModel();
    List<CustomerViewModel> allcustomerList = new List<CustomerViewModel>();
    List<CustomerViewModel> customerList = new List<CustomerViewModel>();
    List<DeliveryNoteViewModel> AllDeliveryNoteList = new List<DeliveryNoteViewModel>();
    List<DeliveryNoteViewModel> quotationList = new List<DeliveryNoteViewModel>();
    SalesQuotationView salesQuotationInfo = new SalesQuotationView();
    List<SalesQuotationItemView> salesQuotationItemList = new List<SalesQuotationItemView>();
    List<PurchaseTermsConditionsModel> termsConditionList = new List<PurchaseTermsConditionsModel>();
    DeliveryNoteViewModel deliveryNoteMaster = new DeliveryNoteViewModel();
    List<DeliveryNoteViewModel> deliveryDetails = new List<DeliveryNoteViewModel>();


    public int pageSize { get; set; }
    public int TotalPage { get; set; }
    public int Currentpage { get; set; }
    public int StartNumber { get; set; }
    public int EndNumber { get; set; }
    bool checkStatus = false;
    int iOption = 0;
    //[Parameter]
    //public string woNo { get; set; }

    protected override async Task OnInitializedAsync()
    {
        AllDeliveryNoteList = await Http.GetJsonAsync<List<DeliveryNoteViewModel>>(Utility.BaseUrl + "api/Sales/GetAllDeliveryNoteInfo");
        quotationList = await Http.GetJsonAsync<List<DeliveryNoteViewModel>>(Utility.BaseUrl + "api/Sales/GetAllDeliveryNoteInfo");
        //AppState.salesQuotation = quotationList;
        //Pagination();
        StateHasChanged();
        await js.InvokeAsync<object>("TestDataTablesAdd", "#example");
    }

    async void CheckboxClicked(string deliverynoteNo, object checkedValue)
    {
        if ((bool)checkedValue)
        {
            //deliveryNoteMaster = await Http.GetJsonAsync<DeliveryNoteViewModel>(Utility.BaseUrl + "api/Sales/GetDeliveryInfoByDNNo/" + deliverynoteNo);
            deliveryDetails = await Http.GetJsonAsync<List<DeliveryNoteViewModel>>(Utility.BaseUrl + "api/Sales/GetDeliveryInfoByDNNo/" + deliverynoteNo);
            //termsId = salesInfo.TERMS_AND_CONDITION;
            //if (termsId != null)
            //{ termsAndConditionList = await Http.GetJsonAsync<List<PurchaseTermsConditionsModel>>(Utility.BaseUrl + "api/Sales/GetTermsAndConditions/" + termsId); }
            //int i = 1;
            //foreach (var item in termsAndConditionList)
            //{
            //    condition = new PurchaseTermsConditionsModel();
            //    condition.PURCHASE_TERMS_CONDITION_ID = item.PURCHASE_TERMS_CONDITION_ID;
            //    condition.SALES_TERMS_CONDITION_ID = item.SALES_TERMS_CONDITION_ID;
            //    condition.SL = item.SL;
            //    condition.TERMS_AND_CONDITIONS = item.SL + " ." + item.TERMS_AND_CONDITIONS;

            //    termsConditionList.Add(condition);
            //    //i++;
            //}
            AppState.deliveryNoteView = deliveryNoteMaster;
            AppState.DeliveryItemDetails = deliveryDetails;
            //AppState.SalestermsConditionList = termsConditionList;

        }
        this.StateHasChanged();
    }
    private async void GetDeliveryInfoById(string dn_No)
    {
        deliveryNoteMaster = await Http.GetJsonAsync<DeliveryNoteViewModel>(Utility.BaseUrl + "api/Sales/GetDeliveryInfoByDNNo/" + dn_No);
    }
    private async void PrintDeliveryNote()
    {

        try
        {
            await js.InvokeAsync<object>("open", "api/RDLCReport/GetSalesDeliveryNote", "_blank");
        }
        catch { }
    }
    private async void DeliveryNoteClicked(string deliverynoteNo)
    {

        try
        {
            deliveryDetails = await Http.GetJsonAsync<List<DeliveryNoteViewModel>>(Utility.BaseUrl + "api/Sales/GetDeliveryInfoByDNNo/" + deliverynoteNo);
            AppState.deliveryNoteView = deliveryDetails.FirstOrDefault();
            AppState.DeliveryItemDetails = deliveryDetails;
            await js.InvokeAsync<object>("open", "api/RDLCReport/GetSalesDeliveryNote", "_blank");
        }
        catch { }
    }
    private void NavigatTo(string direction)
    {
        if (direction == "prev" && Currentpage != 0)
            Currentpage -= 1;
        if (direction == "next" && Currentpage != TotalPage - 1)
            Currentpage += 1;

        UpdateList(Currentpage);
    }
    private void UpdateList(int pageNumber)
    {
        AllDeliveryNoteList = quotationList.Skip(pageNumber * pageSize).Take(pageSize).ToList();
        Currentpage = pageNumber;
        if (AllDeliveryNoteList.Count > 0)
        {
            StartNumber = AllDeliveryNoteList.FirstOrDefault().SL;
            EndNumber = AllDeliveryNoteList[AllDeliveryNoteList.Count - 1].SL;
        }

    }
    private void Pagination()
    {
        pageSize = 20;
        if (quotationList.Count > 0)
        {
            AllDeliveryNoteList = quotationList.Take(pageSize).ToList();
            TotalPage = (int)Math.Ceiling(quotationList.Count() / (decimal)pageSize);
            StartNumber = AllDeliveryNoteList.FirstOrDefault().SL;
            EndNumber = AllDeliveryNoteList[AllDeliveryNoteList.Count - 1].SL;
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
