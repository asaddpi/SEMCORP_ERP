#pragma checksum "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\ManageVendor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7095f0a4bf669f22446e763fbc83f174fc7e796"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ManageVendor")]
    public partial class ManageVendor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "dashboard-details");
            __builder.AddMarkupContent(2, "<h4 class=\"p-2\"><img src=\"images/fountain-pen.png\" alt width=\"50\" height=\"50\" class=\"mr-3\"><span class=\"text-uppercase\">VENDOR LIST</span></h4>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "newRequsitionForm-content");
            __builder.OpenElement(5, "form");
            __builder.AddAttribute(6, "action");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container-fluid");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "analytic_details_contain_two");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table table-striped");
            __builder.AddMarkupContent(13, @"<thead style=""background-color:steelblue;color:white""><tr><td scope=""col""></td>
                                <td scope=""col""></td>
                                <td scope=""col"">Vendor Code</td>
                                <td scope=""col"">Vendor Name</td>
                                <td scope=""col"">Contact No</td>
                                <td scope=""col"">Email</td>
                                <td scope=""col"">Fax</td>
                                <td scope=""col"">Vendor Type</td></tr></thead>
                        ");
            __builder.OpenElement(14, "tbody");
#nullable restore
#line 25 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\ManageVendor.razor"
                             if (vendorList != null)
                            {
                                foreach (var item in vendorList)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "tr");
            __builder.OpenElement(16, "td");
            __builder.AddAttribute(17, "scope", "col");
            __builder.OpenElement(18, "a");
            __builder.AddAttribute(19, "href", "EditVendor/" + (
#nullable restore
#line 30 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\ManageVendor.razor"
                                                                             item.VENDOR_ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "UPDATE VENDOR");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                                        ");
            __builder.OpenElement(22, "td");
            __builder.AddAttribute(23, "scope", "col");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "href", "VendorDetailsView/" + (
#nullable restore
#line 31 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\ManageVendor.razor"
                                                                                    item.VENDOR_CODE

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "VIEW DETAILS");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                                        ");
            __builder.OpenElement(28, "td");
            __builder.AddAttribute(29, "scope", "col");
            __builder.AddContent(30, 
#nullable restore
#line 32 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\ManageVendor.razor"
                                                         item.VENDOR_CODE

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                        ");
            __builder.OpenElement(32, "td");
            __builder.AddAttribute(33, "scope", "col");
            __builder.AddContent(34, 
#nullable restore
#line 33 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\ManageVendor.razor"
                                                         item.VENDOR_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                                        ");
            __builder.OpenElement(36, "td");
            __builder.AddAttribute(37, "scope", "col");
            __builder.AddContent(38, 
#nullable restore
#line 34 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\ManageVendor.razor"
                                                         item.CONTACT_NO

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                                        ");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "scope", "col");
            __builder.AddContent(42, 
#nullable restore
#line 35 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\ManageVendor.razor"
                                                         item.EMAIL

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                                        ");
            __builder.OpenElement(44, "td");
            __builder.AddAttribute(45, "scope", "col");
            __builder.AddContent(46, 
#nullable restore
#line 36 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\ManageVendor.razor"
                                                         item.FAX

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                                        ");
            __builder.OpenElement(48, "td");
            __builder.AddAttribute(49, "scope", "col");
            __builder.AddContent(50, 
#nullable restore
#line 37 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\ManageVendor.razor"
                                                         item.VENDOR_TYPE_STATUS

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\ManageVendor.razor"
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
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Vendor\ManageVendor.razor"
       
    List<VendorEntity> vendorList = new List<VendorEntity>();

    protected override async Task OnInitializedAsync()
    {
        await GetVendorList();
    }
    private async Task GetVendorList()
    {
        vendorList = await Http.GetJsonAsync<List<VendorEntity>>(Utility.BaseUrl + "api/Vendor");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
