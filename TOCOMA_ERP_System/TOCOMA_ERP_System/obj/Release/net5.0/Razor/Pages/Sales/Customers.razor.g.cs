#pragma checksum "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\Customers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "839586e9881014e712b37748bb41f43fefffd813"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Customers")]
    public partial class Customers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.AddMarkupContent(4, "<div class=\"card-header\"><h4>\r\n                Customer List &nbsp;\r\n                <a href=\"AddCustomer\">New Customer</a></h4></div>\r\n        <br>\r\n        ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddAttribute(7, "id", "example");
            __builder.AddMarkupContent(8, "<thead><tr><td></td>\r\n                    <td>Customer Code</td>\r\n                    <th></th></tr></thead>\r\n            ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 30 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\Customers.razor"
                 if (allcustomerList != null)
                {
                    foreach (var item in allcustomerList)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, @"<td style=""width:15%;font-weight:bold;text-align:left"">
                                Code <br>
                                Name <br>
                                Corporate Address <br>
                                Shipping Address <br>
                                Contact Person <br>
                                Phone <br>
                                Email 

                            </td>
                            ");
            __builder.OpenElement(12, "td");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "style", "color:Highlight;cursor:pointer");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\Customers.razor"
                                                                                     () => GetCustomerProfile(item.CUSTOMER_ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, 
#nullable restore
#line 47 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\Customers.razor"
                                                                                                                                  item.CUSTOMER_CODE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, " <br>\r\n                                ");
            __builder.AddContent(18, 
#nullable restore
#line 48 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\Customers.razor"
                                 item.CUSTOMER_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, " <br>\r\n                                ");
            __builder.AddContent(20, 
#nullable restore
#line 49 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\Customers.razor"
                                 item.CORPORATE_ADDRESS

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(21, " <br>\r\n                                ");
            __builder.AddContent(22, 
#nullable restore
#line 50 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\Customers.razor"
                                 item.SHIPPING_ADDRESS

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(23, " <br>\r\n                                ");
            __builder.AddContent(24, 
#nullable restore
#line 51 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\Customers.razor"
                                 item.CONTACT_PERSON_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, " <br>\r\n                                ");
            __builder.AddContent(26, 
#nullable restore
#line 52 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\Customers.razor"
                                 item.CONTACT_PERSON_PHONE

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(27, " <br>\r\n                                ");
            __builder.AddContent(28, 
#nullable restore
#line 53 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\Customers.razor"
                                 item.CONTACT_PERSON_EMAIL

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.OpenElement(30, "td");
            __builder.AddAttribute(31, "style", "text-align:center;width:50px");
            __builder.OpenElement(32, "a");
            __builder.AddAttribute(33, "href", "EditCustomer/" + (
#nullable restore
#line 55 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\Customers.razor"
                                                                                            item.CUSTOMER_ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "<span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\Customers.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        <br>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "modal fade bd-example-modal-lg");
            __builder.AddAttribute(39, "tabindex", "-1");
            __builder.AddAttribute(40, "role", "dialog");
            __builder.AddAttribute(41, "aria-labelledby", "myLargeModalLabel");
            __builder.AddAttribute(42, "aria-hidden", "true");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "modal-dialog modal-xl");
            __builder.AddMarkupContent(45, "<div class=\"col-md-12\"></div>\r\n        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "modal-content");
            __builder.AddMarkupContent(48, @"<div class=""modal-header""><div class=""form-outline""><h4 class=""p-2""><img src=""images/fountain-pen.png"" alt width=""50"" height=""50"" class=""mr-3""><span class=""text-uppercase""> UPDATE SHIPMENT INFORMATION</span></h4></div>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button></div>
            ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(51);
            __builder.AddAttribute(52, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 90 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\Customers.razor"
                                  customer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(54, @"<table class=""table""><thead style=""font-weight:bold""><tr><td>PO NO</td>
                                <td>PO Date</td>
                                <td>Supplier</td>
                                <td>Concern Person</td></tr></thead>

                        <tbody></tbody></table>
                    <br>
                    ");
                __builder2.AddMarkupContent(55, @"<table class=""table table-striped ""><thead style=""font-weight:bold""><tr><td scope=""col"" colspan=""3"">ETD with QTY</td>
                                <td scope=""col"" colspan=""3"">ETA to CTG</td>
                                <td scope=""col"" colspan=""3"">EA at TL-WH</td></tr>
                            <tr><td>1st Date</td>
                                <td>2nd Date</td>
                                <td>3rd Date</td>
                                <td>1st Date</td>
                                <td>2nd Date</td>
                                <td>3rd Date</td>
                                <td>1st Date</td>
                                <td>2nd Date</td>
                                <td>3rd Date</td></tr></thead>
                        <tbody></tbody></table>
                    <br>
                    ");
                __builder2.AddMarkupContent(56, "<table width=\"100%\"><thead style=\"font-weight:bold\"><tr><td>Receive Date</td>\r\n                                <td>Shipment Status</td></tr></thead>\r\n                        <tbody></tbody></table>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n            ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "modal-footer");
            __builder.OpenElement(60, "div");
            __builder.OpenElement(61, "button");
            __builder.AddAttribute(62, "class", "btn btn-info");
            __builder.AddAttribute(63, "data-dismiss", "modal");
            __builder.AddAttribute(64, "style", "border:none;width:120px;float:right;margin-left:10px");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 144 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\Customers.razor"
                                                                                                                                             SaveCustomer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(66, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                    ");
            __builder.AddMarkupContent(68, "<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 156 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Sales\Customers.razor"
       
    CustomerModel customer = new CustomerModel();
    List<CustomerViewModel> allcustomerList = new List<CustomerViewModel>();
    List<CustomerViewModel> customerList = new List<CustomerViewModel>();
    CustomerViewModel customerView = new CustomerViewModel();
    public int pageSize { get; set; }
    public int TotalPage { get; set; }
    public int Currentpage { get; set; }
    public int StartNumber { get; set; }
    public int EndNumber { get; set; }

    protected override async Task OnInitializedAsync()
    {
        allcustomerList = await Http.GetJsonAsync<List<CustomerViewModel>>(Utility.BaseUrl + "api/Customer/GetAllCustomer");
        customerList = await Http.GetJsonAsync<List<CustomerViewModel>>(Utility.BaseUrl + "api/Customer/GetAllCustomer");
        StateHasChanged();
        await js.InvokeAsync<object>("TestDataTablesAdd", "#example");
        ///Pagination();
    }
    private async Task GetCustomerProfile(int customerid)
    {
        customerView = await Http.GetJsonAsync<CustomerViewModel>(Utility.BaseUrl + "api/Customer/GetCustomerAccountById/" + customerid);
        //if (salesQuotationInfo.TERMS_AND_CONDITION != null && salesQuotationInfo.TERMS_AND_CONDITION != "")
        //{
        //    termsConditionList = await Http.GetJsonAsync<List<PurchaseTermsConditionsModel>>(Utility.BaseUrl + "api/Sales/GetSalesTermsAndConditionsByIds/" + salesQuotationInfo.TERMS_AND_CONDITION);
        //    AppState.SalestermsConditionList = termsConditionList;
        //}
        //if (salesQuotationInfo.USED_PRODUCT != null)
        //{
        //    itemList = await Http.GetJsonAsync<List<ItemEntity>>(Utility.BaseUrl + "api/Sales/GetItemListByUsedProduct/" + salesQuotationInfo.USED_PRODUCT);
        //    AppState.usedProductList = itemList;
        //}

        ////porder.REPORT_TYPE = "1";
        //salesQuotationItemList = await Http.GetJsonAsync<List<SalesQuotationItemView>>(Utility.BaseUrl + "api/Sales/GetSalesQuotationItemListById/" + poId);
        //porder.pOrderDetailsList = purchaseOrderDetailsList;
        AppState.customerViewModel = customerView;
        //AppState.salesQuotationitemList = salesQuotationItemList;

        await js.InvokeAsync<object>("open", "api/RDLCReport/GetCustomerProfile", "_blank");
    }
    public async Task SaveCustomer()
    {

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
        allcustomerList = customerList.Skip(pageNumber * pageSize).Take(pageSize).ToList();
        Currentpage = pageNumber;
        if (allcustomerList.Count > 0)
        {
            StartNumber = allcustomerList.FirstOrDefault().SL;
            EndNumber = allcustomerList[allcustomerList.Count - 1].SL;
        }

    }
    private void Pagination()
    {
        pageSize = 20;
        if (customerList.Count > 0)
        {
            allcustomerList = customerList.Take(pageSize).ToList();
            TotalPage = (int)Math.Ceiling(customerList.Count() / (decimal)pageSize);
            StartNumber = allcustomerList.FirstOrDefault().SL;
            EndNumber = allcustomerList[allcustomerList.Count - 1].SL;
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
