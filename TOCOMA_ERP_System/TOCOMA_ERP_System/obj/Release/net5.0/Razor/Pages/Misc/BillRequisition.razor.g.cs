#pragma checksum "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e344d42d3800f19982773cb04f72384d07ec51f"
// <auto-generated/>
#pragma warning disable 1591
namespace TOCOMA_ERP_System.Pages.Misc
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/BillRequisition")]
    public partial class BillRequisition : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "<div class=\"card-header\"><h3>Requisition</h3></div>\r\n\r\n    <br>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
                      misc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "style", "height:20%;margin-left:10px");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "style", "padding:10px");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-row");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(13, "<label for=\"inputEmail4\">Date</label>\r\n                    ");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "id", "date_1");
                __builder2.AddAttribute(18, "autocomplete", "off");
                __builder2.AddAttribute(19, "style", "width:203px;height:28px");
                __builder2.AddAttribute(20, "placeholder", "dd/mm/yy");
                __builder2.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
                                                                                      require_date

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => require_date = __value, require_date));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-row");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(28, "<label for=\"inputEmail4\">Employee</label>\r\n                    ");
                __Blazor.TOCOMA_ERP_System.Pages.Misc.BillRequisition.TypeInference.CreateInputSelect_0(__builder2, 29, 30, "", 31, "", 32, "form-control", 33, 
#nullable restore
#line 23 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
                                                             misc.EMPLOYEE

#line default
#line hidden
#nullable disable
                , 34, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => misc.EMPLOYEE = __value, misc.EMPLOYEE)), 35, () => misc.EMPLOYEE, 36, (__builder3) => {
                    __builder3.AddMarkupContent(37, "<option value>--Select Employee--</option>");
#nullable restore
#line 25 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
                         foreach (var employee in employeeList)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(38, "option");
                    __builder3.AddAttribute(39, "value", 
#nullable restore
#line 27 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
                                            employee.EMPLOYEE_NAME

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(40, 
#nullable restore
#line 27 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
                                                                     employee.EMPLOYEE_NAME

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 28 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(44, "<label for=\"inputPassword4\">Subject</label>\r\n                    ");
                __Blazor.TOCOMA_ERP_System.Pages.Misc.BillRequisition.TypeInference.CreateInputSelect_1(__builder2, 45, 46, "", 47, "", 48, "form-control", 49, 
#nullable restore
#line 34 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
                                                             misc.LEDGER_NAME

#line default
#line hidden
#nullable disable
                , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => misc.LEDGER_NAME = __value, misc.LEDGER_NAME)), 51, () => misc.LEDGER_NAME, 52, (__builder3) => {
                    __builder3.AddMarkupContent(53, "<option value></option>");
#nullable restore
#line 36 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
                         foreach (var item in ledgerList)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(54, "option");
                    __builder3.AddAttribute(55, "value", 
#nullable restore
#line 38 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
                                            item.LEDGER_NAME

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(56, 
#nullable restore
#line 38 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
                                                               item.LEDGER_NAME

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 39 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-row");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(62, "<label for=\"inputEmail4\">From</label>                    \r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(63);
                __builder2.AddAttribute(64, "class", "form-control");
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
                                             misc.LOCATION_FROM

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => misc.LOCATION_FROM = __value, misc.LOCATION_FROM))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => misc.LOCATION_FROM));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(71, "<label for=\"inputPassword4\">To</label>                    \r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(72);
                __builder2.AddAttribute(73, "class", "form-control");
                __builder2.AddAttribute(74, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
                                             misc.DESTINATION_TO

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => misc.DESTINATION_TO = __value, misc.DESTINATION_TO))));
                __builder2.AddAttribute(76, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => misc.DESTINATION_TO));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n\r\n            ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "form-row");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "form-group col-md-8");
                __builder2.AddMarkupContent(82, "<label for=\"inputAddress\">Purpose</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(83);
                __builder2.AddAttribute(84, "cols", "30");
                __builder2.AddAttribute(85, "rows", "3");
                __builder2.AddAttribute(86, "class", "form-control");
                __builder2.AddAttribute(87, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
                                                 misc.PURPOSE

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => misc.PURPOSE = __value, misc.PURPOSE))));
                __builder2.AddAttribute(89, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => misc.PURPOSE));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n            ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "form-row");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(95, "<label for=\"inputEmail4\">Tour By</label>                    \r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(96);
                __builder2.AddAttribute(97, "class", "form-control");
                __builder2.AddAttribute(98, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
                                             misc.TOUR_BY

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => misc.TOUR_BY = __value, misc.TOUR_BY))));
                __builder2.AddAttribute(100, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => misc.TOUR_BY));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n            ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "form-row");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "form-group col-md-4");
                __builder2.AddMarkupContent(106, "<label for=\"inputEmail4\">Amount</label>                    \r\n                    ");
                __Blazor.TOCOMA_ERP_System.Pages.Misc.BillRequisition.TypeInference.CreateInputNumber_2(__builder2, 107, 108, "form-control", 109, 
#nullable restore
#line 69 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
                                               misc.AMOUNT

#line default
#line hidden
#nullable disable
                , 110, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => misc.AMOUNT = __value, misc.AMOUNT)), 111, () => misc.AMOUNT);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n\r\n\r\n\r\n\r\n\r\n        <br>\r\n        ");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "row");
                __builder2.AddMarkupContent(115, "<div class=\"col-md-2\"></div>\r\n            ");
                __builder2.OpenElement(116, "div");
                __builder2.AddAttribute(117, "class", "col-md-7");
                __builder2.OpenElement(118, "button");
                __builder2.AddAttribute(119, "type", "submit");
                __builder2.AddAttribute(120, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
                                                SaveBillReq

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(121, "class", "btn btn-info");
                __builder2.AddAttribute(122, "style", "width:120px;margin-right:10px");
                __builder2.AddContent(123, 
#nullable restore
#line 82 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
                                                                                                                         submit

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n                ");
                __builder2.OpenElement(125, "button");
                __builder2.AddAttribute(126, "type", "button");
                __builder2.AddAttribute(127, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
                                                Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(128, "class", "btn btn-danger");
                __builder2.AddAttribute(129, "style", "width:90px");
                __builder2.AddContent(130, "Cancel");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Misc\BillRequisition.razor"
       
    clsMiscBillRequisition misc = new clsMiscBillRequisition();
    List<clsMiscBillRequisition> misclist = new List<clsMiscBillRequisition>();
    List<LedgerModel> ledgerList = new List<LedgerModel>();
    List<EmployeeModel> employeeList = new List<EmployeeModel>();
    string submit = "Save";
    string require_date;
    protected override async Task OnInitializedAsync()
    {
        await GetBillReq();
        await GetLedger();
        employeeList = await Http.GetJsonAsync<List<EmployeeModel>>(Utility.BaseUrl + "api/Employee");
        StateHasChanged();
        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");
        await JSRuntime.InvokeVoidAsync("JsInteropDatepicker");
    }
    private async Task GetLedger()
    {
        ledgerList = await Http.GetJsonAsync<List<LedgerModel>>(Utility.BaseUrl + "api/Setup/GetLedger");
    }
    private async Task GetBillReq()
    {
        misclist = await Http.GetJsonAsync<List<clsMiscBillRequisition>>(Utility.BaseUrl + "api/Setup/GetBrandList");
    }
    public async Task SaveBillReq()
    {
        if (IsValidation_Brand() != true)
        {
            try
            {
                if (submit == "Save")
                {
                    misc.Operation_Type = 1;
                    string d = require_date.Substring(0, 2);
                    string m = require_date.Substring(3,2);
                    string y = require_date.Substring(6, 4);
                    string dt = y + "-" + m + "-" + d;
                    misc.DATE = Utility.GetDateFromStringToDate(require_date); //Convert.ToDateTime(dt);
                    misc.STATUS = "Submitted";
                    var data = await Http.PostJsonAsync<clsMiscBillRequisition>(Utility.BaseUrl + "api/Transection/AddBillReq", misc);
                    toastService.ShowSuccess("Insert Successfully!!!");
                }
                else if (submit == "Update")
                {
                    misc.Operation_Type = 2;
                    var data = await Http.PutJsonAsync<clsMiscBillRequisition>(Utility.BaseUrl + "api/Transection/UpdateBrand", misc);
                    toastService.ShowSuccess("Insert Successfully!!!");
                }
                submit = "Save";
                misc = new clsMiscBillRequisition();
            }
            catch (Exception ex)
            {

            }

        }
        await GetBillReq();
    }
    private bool IsValidation_Brand()
    {
        bool flag = false;
        if (misc.LEDGER_NAME == "" || misc.LEDGER_NAME == null)
        {
            toastService.ShowWarning("Please Select LEDGER_NAME!");
            flag = true;
        }

        return flag;
    }
    private async Task Cancel()
    {
        misc = new clsMiscBillRequisition();
        submit = "Save";
    }
    private async Task EditBrand(int Id)
    {
        submit = "Update";
        misc = new clsMiscBillRequisition();
        //misc.LEDGER_NAME = brandList.Find(x => x.BRAND_ID == Id).BRAND_NAME;
        misc.BILL_REQUISITION_ID = Id;
        misc.Operation_Type = 2;
    }
    private async Task Delete(int Id)
    {

        if (!await JSRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to delete ?"))
            return;

        await Http.DeleteAsync(Utility.BaseUrl + "api/Setup/DeleteBrand/" + Id);
        await GetBillReq();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
namespace __Blazor.TOCOMA_ERP_System.Pages.Misc.BillRequisition
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "name", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "class", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "name", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "class", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.AddAttribute(__seq6, "ChildContent", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
