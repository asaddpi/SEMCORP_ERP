#pragma checksum "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\ChartOfAccounts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c88927dabaf1a1d68e50a37bc3386f5ef2d2c8a6"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ChartOfAccounts")]
    public partial class ChartOfAccounts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n\r\n    .tree {\r\n        position: relative;\r\n        background: white;\r\n        margin-top: 20px;\r\n        padding: 30px;\r\n        font-family: \"Roboto Mono\", monospace;\r\n        font-size: 0.85rem;\r\n        font-weight: 400;\r\n        line-height: 1.5;\r\n        color: #212529;\r\n    }\r\n\r\n        .tree span {\r\n            font-size: 13px;\r\n            font-style: italic;\r\n            letter-spacing: 0.4px;\r\n            color: #a8a8a8;\r\n        }\r\n\r\n        .tree .fa-folder-open, .tree .fa-folder {\r\n            color: #007bff;\r\n        }\r\n\r\n        .tree .fa-html5 {\r\n            color: #f21f10;\r\n        }\r\n\r\n        .tree ul {\r\n            padding-left: 5px;\r\n            list-style: none;\r\n        }\r\n\r\n            .tree ul li {\r\n                position: relative;\r\n                padding-top: 5px;\r\n                padding-bottom: 5px;\r\n                padding-left: 15px;\r\n                -webkit-box-sizing: border-box;\r\n                -moz-box-sizing: border-box;\r\n                box-sizing: border-box;\r\n            }\r\n\r\n                .tree ul li:before {\r\n                    position: absolute;\r\n                    top: 15px;\r\n                    left: 0;\r\n                    width: 10px;\r\n                    height: 1px;\r\n                    margin: auto;\r\n                    content: \"\";\r\n                    background-color: #666;\r\n                }\r\n\r\n                .tree ul li:after {\r\n                    position: absolute;\r\n                    top: 0;\r\n                    bottom: 0;\r\n                    left: 0;\r\n                    width: 1px;\r\n                    height: 100%;\r\n                    content: \"\";\r\n                    background-color: #666;\r\n                }\r\n\r\n                .tree ul li:last-child:after {\r\n                    height: 15px;\r\n                }\r\n\r\n            .tree ul a {\r\n                cursor: pointer;\r\n            }\r\n\r\n                .tree ul a:hover {\r\n                    text-decoration: none;\r\n                }\r\n\r\n    .teal-color {\r\n        color: teal;\r\n        font-size: 20px;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card");
            __builder.AddMarkupContent(3, "<div class=\"card-header\" style=\"text-align:center;font-size:20px\">Chart of Accounts</div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "tree");
            __builder.OpenElement(8, "ul");
#nullable restore
#line 94 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\ChartOfAccounts.razor"
                 foreach (var item in parentList1)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "li");
            __builder.AddMarkupContent(10, "<i class=\"fa fa-folder-open\"></i> ");
            __builder.AddContent(11, 
#nullable restore
#line 97 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\ChartOfAccounts.razor"
                                                           item.Item

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 98 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\ChartOfAccounts.razor"
                         foreach (var subitem in item.parentGrouplist)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "ul");
            __builder.OpenElement(13, "li");
            __builder.AddMarkupContent(14, "<i class=\"fa fa-folder-open\"></i> ");
            __builder.AddContent(15, 
#nullable restore
#line 102 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\ChartOfAccounts.razor"
                                                                       subitem.GR_NAME

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 103 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\ChartOfAccounts.razor"
                                     foreach (var child in subitem.childList)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "ul");
            __builder.OpenElement(17, "li");
            __builder.AddMarkupContent(18, "<i class=\"fa fa-file-text\"></i> ");
            __builder.AddContent(19, 
#nullable restore
#line 107 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\ChartOfAccounts.razor"
                                                                                 child.LEDGER_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 110 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\ChartOfAccounts.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 113 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\ChartOfAccounts.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 115 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\ChartOfAccounts.razor"
                }                

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 122 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\ChartOfAccounts.razor"
       
    List<LG_Group> ledgerGroupList = new List<LG_Group>();
    LG_Group lg_group = new LG_Group();
    List<string> accountHead = new List<string>();
    List<AccountsHead> parentList = new List<AccountsHead>();
    AccountsHead parent = new AccountsHead();
    List<AccountsHead> parentList1 = new List<AccountsHead>();
    List<LedgerChild> ledgerList = new List<LedgerChild>();
    List<LedgerChild> lgrList = new List<LedgerChild>();

    protected override async Task OnInitializedAsync()
    {
        List<AccountsHead> parentList = new List<AccountsHead>
    {
                new AccountsHead { Item = "Assets" },
                new AccountsHead { Item = "Liabilities" },
                new AccountsHead { Item = "Income" },
                new AccountsHead { Item = "Expenses" }
        };


        ledgerGroupList = await Http.GetJsonAsync<List<LG_Group>>(Utility.BaseUrl + "api/Setup/GetLedgerGroup");
        ledgerList = await Http.GetJsonAsync<List<LedgerChild>>(Utility.BaseUrl + "api/Setup/GetLedger");

        foreach (var item in parentList)
        {            
            foreach (var group in ledgerGroupList)
            {
                if ((group.GR_PARENT == "Assets" || group.GR_PARENT == "Current Assets") && item.Item == "Assets")
                {
                    if (item.parentGrouplist == null)
                    { item.parentGrouplist = new List<LG_Group>(); }
                    item.parentGrouplist.Add(group);
                }
                else if ((group.GR_PARENT == "Liabilities" || group.GR_PARENT == "Current Liabilities") && item.Item == "Liabilities")
                {
                    if (item.parentGrouplist == null)
                    { item.parentGrouplist = new List<LG_Group>(); }
                    item.parentGrouplist.Add(group);
                }
                else if (group.GR_PARENT == "Income" && item.Item == "Income")
                {
                    if (item.parentGrouplist == null)
                    { item.parentGrouplist = new List<LG_Group>(); }
                    item.parentGrouplist.Add(group);
                }
                else if (group.GR_PARENT == "Expenses" && item.Item == "Expenses")
                {
                    if (item.parentGrouplist == null)
                    { item.parentGrouplist = new List<LG_Group>(); }
                    item.parentGrouplist.Add(group);
                }                
            }

            foreach (var group in item.parentGrouplist)
            {
                foreach (var child in ledgerList)
                {
                    if (group.GR_NAME == child.LEDGER_PARENT_GROUP)
                    {
                        if (group.childList == null)
                        { group.childList = new List<LedgerChild>(); }
                        group.childList.Add(child);
                        lgrList = group.childList;
                    }
                }
            }            
            parent = new AccountsHead();
            lg_group = new LG_Group();
            parent.Item = item.Item;
            parent.parentGrouplist = item.parentGrouplist;
            parent.Childlist = lgrList;
            parentList1.Add(parent);
            item.parentGrouplist = new List<LG_Group>();
            lgrList = new List<LedgerChild>();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
