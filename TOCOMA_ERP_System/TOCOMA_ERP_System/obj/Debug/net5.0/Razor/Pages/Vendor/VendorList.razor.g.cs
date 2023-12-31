#pragma checksum "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\VendorList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0079cb4203517bab3e6b66bc22ff64d20a5b1c98"
// <auto-generated/>
#pragma warning disable 1591
namespace TOCOMA_ERP_System.Pages.Vendor
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/VendorList")]
    public partial class VendorList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "<div class=\"card-header\">\r\n        Vendor List &nbsp;\r\n        <a href=\"AddVendor\">New Vendor</a></div>\r\n\r\n\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "testbox");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "tablearea");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "id", "example");
            __builder.AddAttribute(9, "class", "display");
            __builder.AddAttribute(10, "style", "width:100%");
            __builder.AddMarkupContent(11, @"<thead><tr><th></th>
                        <td>Vendor Code</td>
                        <td>Vendor Name</td>
                        <td>Contact No</td>
                        <td>Email</td>
                        <td>Fax</td>
                        <td>Vendor Type</td></tr></thead>
                ");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 30 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\VendorList.razor"
                     if (vendorList != null)
                    {
                        foreach (var item in vendorList)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
            __builder.OpenElement(14, "td");
            __builder.AddAttribute(15, "style", "text-align:center");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "href", "EditVendor/" + (
#nullable restore
#line 35 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\VendorList.razor"
                                                                                   item.VENDOR_CODE

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(18, "<span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                                ");
            __builder.OpenElement(20, "td");
            __builder.AddAttribute(21, "style", "text-align:center");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "href", "VendorDetailsView/" + (
#nullable restore
#line 36 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\VendorList.razor"
                                                                                          item.VENDOR_CODE

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 36 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\VendorList.razor"
__builder.AddContent(24, item.VENDOR_CODE);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                                ");
            __builder.OpenElement(26, "td");
#nullable restore
#line 37 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\VendorList.razor"
__builder.AddContent(27, item.VENDOR_NAME);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                                ");
            __builder.OpenElement(29, "td");
#nullable restore
#line 38 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\VendorList.razor"
__builder.AddContent(30, item.CONTACT_NO);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                ");
            __builder.OpenElement(32, "td");
#nullable restore
#line 39 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\VendorList.razor"
__builder.AddContent(33, item.EMAIL);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                                ");
            __builder.OpenElement(35, "td");
#nullable restore
#line 40 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\VendorList.razor"
__builder.AddContent(36, item.FAX);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                                ");
            __builder.OpenElement(38, "td");
#nullable restore
#line 41 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\VendorList.razor"
__builder.AddContent(39, item.VENDOR_TYPE_STATUS);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\VendorList.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\VendorList.razor"
       
List<VendorEntity> vendorList = new List<VendorEntity>();

    protected override async Task OnInitializedAsync()
    {
        await GetVendorList();
        StateHasChanged();
        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");
    }
    private async Task GetVendorList()
    {
        vendorList = await Http.GetJsonAsync<List<VendorEntity>>(Utility.BaseUrl + "api/Vendor");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
