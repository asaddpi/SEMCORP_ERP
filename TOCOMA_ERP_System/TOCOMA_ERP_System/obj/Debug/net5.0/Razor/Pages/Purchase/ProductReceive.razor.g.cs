#pragma checksum "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7661efaaee5bbb2b8c17ecdb06e704a5b75cfc64"
// <auto-generated/>
#pragma warning disable 1591
namespace TOCOMA_ERP_System.Pages.Purchase
{
    #line hidden
    using System;
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
#nullable restore
#line 3 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CustomLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/ProductReceive")]
    public partial class ProductReceive : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    body {
        font-family: Arial;
    }

    /* Style the tab */
    .tab {
        overflow: hidden;
        border: 1px solid #ccc;
        background-color: #f1f1f1;
    }

        /* Style the buttons inside the tab */
        .tab button {
            background-color: inherit;
            float: left;
            border: none;
            outline: none;
            cursor: pointer;
            padding: 14px 16px;
            transition: 0.3s;
            font-size: 17px;
        }

            /* Change background color of buttons on hover */
            .tab button:hover {
                background-color: #ddd;
            }

            /* Create an active/current tablink class */
            .tab button.active {
                background-color: #ccc;
            }

    /* Style the tab content */
    .tabcontent {
        display: none;
        padding: 6px 12px;
        border: 1px solid #ccc;
        border-top: none;
    }

    table {
        border-collapse: collapse;
    }

    th,
    td {
        border: 1px solid #888;
        padding: 0.25em 0.5em;
    }
</style>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "dashboard-details");
            __builder.AddMarkupContent(3, "<h4 class=\"p-2\"><img src=\"images/fountain-pen.png\" alt width=\"50\" height=\"50\" class=\"mr-3\"><span class=\"text-uppercase\">PRODUCT RECEIVE IN WAREHOUSE</span></h4>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "newRequsitionForm-content");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container-fluid");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 70 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
                              stock

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 70 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
                                                     SavePurchaseOrder

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(11, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-lg-6");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "row");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-md-7");
                __builder2.AddMarkupContent(20, "<label>PO NO :</label>\r\n                                ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "type", "search");
                __builder2.AddAttribute(23, "placeholder", "po no...");
                __builder2.AddAttribute(24, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 76 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
                                                                   purchaseOrderModel.PO_NUMBER_LONG_CODE

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => purchaseOrderModel.PO_NUMBER_LONG_CODE = __value, purchaseOrderModel.PO_NUMBER_LONG_CODE));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                                ");
                __builder2.OpenElement(27, "button");
                __builder2.AddAttribute(28, "type", "button");
                __builder2.AddAttribute(29, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
                                                                GetProductDetailsBYPO

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "style", "height:35px");
                __builder2.AddAttribute(31, "class", "btn btn-primary");
                __builder2.AddMarkupContent(32, "<i class=\"fas fa-search\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                <br>\r\n                ");
                __builder2.AddMarkupContent(34, "<h5>PURCHASE ITEMS</h5>\r\n                ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "analytic_details_contain_two");
                __builder2.OpenElement(37, "table");
                __builder2.AddAttribute(38, "class", "table table-striped");
                __builder2.AddMarkupContent(39, @"<thead style=""background-color:steelblue;color:white;height:20px""><tr><td scope=""col"">Item Description</td>
                                <td scope=""col"">Pack Size</td>
                                <td scope=""col"">Quantity</td></tr></thead>
                        ");
                __builder2.OpenElement(40, "tbody");
#nullable restore
#line 98 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
                             foreach (var tableitem in purchaseDetailsList)
                            {
                                double total = Convert.ToDouble(tableitem.UNIT_PRICE) * Convert.ToDouble(tableitem.QUANTITY);

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(41, "tr");
                __builder2.OpenElement(42, "td");
                __builder2.AddAttribute(43, "scope", "col");
#nullable restore
#line 102 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
__builder2.AddContent(44, tableitem.ITEM_NAME);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                                    ");
                __builder2.OpenElement(46, "td");
                __builder2.AddAttribute(47, "scope", "col");
#nullable restore
#line 103 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
__builder2.AddContent(48, tableitem.PACK_SIZE);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                                    ");
                __builder2.OpenElement(50, "td");
                __builder2.AddAttribute(51, "scope", "col");
#nullable restore
#line 104 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
__builder2.AddContent(52, tableitem.QUANTITY);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 108 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                <br>\r\n\r\n                ");
                __builder2.OpenElement(54, "fieldset");
                __builder2.AddAttribute(55, "class", "border p-4");
                __builder2.AddMarkupContent(56, "<legend class=\"w-auto\">Receiving Info</legend>\r\n                    ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "row");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-lg-7");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "row");
                __builder2.AddMarkupContent(63, "<div class=\"col-md-5\"><label>Receiving Documents No:</label></div>\r\n                                ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "col-md-7");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(66);
                __builder2.AddAttribute(67, "maxlength", (object)("100"));
                __builder2.AddAttribute(68, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 120 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
                                                                               stock.INVOICE_NO

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(69, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => stock.INVOICE_NO = __value, stock.INVOICE_NO)))));
                __builder2.AddAttribute(70, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => stock.INVOICE_NO)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                            ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "row mt-1");
                __builder2.AddMarkupContent(74, "<div class=\"col-md-5\"><label>Receiving Documents Date:</label></div>\r\n                                ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "col-md-7");
                __builder2.OpenElement(77, "input");
                __builder2.AddAttribute(78, "type", "date");
                __builder2.AddAttribute(79, "style", "width:203px");
                __builder2.AddAttribute(80, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 124 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
                                                                                       invoice_Date

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(81, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => invoice_Date = __value, invoice_Date, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                            ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "row mt-1");
                __builder2.AddMarkupContent(85, "<div class=\"col-md-5\"><label>Good Receive Note:</label></div>\r\n                                ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "col-md-7");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputTextArea>(88);
                __builder2.AddAttribute(89, "style", (object)("width:400px"));
                __builder2.AddAttribute(90, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 150 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
                                                                 stock.GOOD_RECEIVE_NOTE

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(91, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => stock.GOOD_RECEIVE_NOTE = __value, stock.GOOD_RECEIVE_NOTE)))));
                __builder2.AddAttribute(92, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => stock.GOOD_RECEIVE_NOTE)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                            ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "row mt-1");
                __builder2.AddMarkupContent(96, "<div class=\"col-md-5\"><label>Batch NO.:</label></div>\r\n                                ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "col-md-7");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(99);
                __builder2.AddAttribute(100, "style", (object)("width:400px"));
                __builder2.AddAttribute(101, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 166 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
                                                             stock.BATCH_NO

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(102, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => stock.BATCH_NO = __value, stock.BATCH_NO)))));
                __builder2.AddAttribute(103, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => stock.BATCH_NO)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n                            ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "row mt-1");
                __builder2.AddMarkupContent(107, "<div class=\"col-md-5\"><label>Expiry Date:</label></div>\r\n                                ");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "col-md-7");
                __builder2.OpenElement(110, "input");
                __builder2.AddAttribute(111, "style", "width:203px");
                __builder2.AddAttribute(112, "type", "text");
                __builder2.AddAttribute(113, "id", "date_1");
                __builder2.AddAttribute(114, "autocomplete", "off");
                __builder2.AddAttribute(115, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 179 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
                                                                                                                       stock.EXPIRY_DATE

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(116, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => stock.EXPIRY_DATE = __value, stock.EXPIRY_DATE));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n                            ");
                __builder2.OpenElement(118, "div");
                __builder2.AddAttribute(119, "class", "row mt-1");
                __builder2.AddMarkupContent(120, "<div class=\"col-md-5\"><label>Warehouse:</label></div>\r\n                                ");
                __builder2.OpenElement(121, "div");
                __builder2.AddAttribute(122, "class", "col-md-7");
                global::__Blazor.TOCOMA_ERP_System.Pages.Purchase.ProductReceive.TypeInference.CreateInputSelect_0(__builder2, 123, 124, "width:203px;height:28px", 125, 
#nullable restore
#line 184 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
                                                               stock.WAREHOUSE_ID

#line default
#line hidden
#nullable disable
                , 126, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => stock.WAREHOUSE_ID = __value, stock.WAREHOUSE_ID)), 127, () => stock.WAREHOUSE_ID, 128, (__builder3) => {
                    __builder3.AddMarkupContent(129, "<option value>--Select--</option>");
#nullable restore
#line 186 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
                                         foreach (var warehouse in warehouseList)
                                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(130, "option");
                    __builder3.AddAttribute(131, "value", 
#nullable restore
#line 188 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
                                                            warehouse.WAREHOUSE_ID

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 188 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
__builder3.AddContent(132, warehouse.WAREHOUSE_NAME);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 189 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
                                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n                <br>\r\n                ");
                __builder2.AddMarkupContent(134, "<div class=\"col-4 d-flex\" style=\"margin:20px 0 20px\"><button class=\"btn btn-info\" style=\"border:none;border-radius:10px\">Receive</button>&nbsp;&nbsp;&nbsp;\r\n                </div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 213 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Purchase\ProductReceive.razor"
       
    [Parameter]
    public string requisition_no { get; set; }
    //private ReportService _ReportService = new ReportService();
    DataSet DS_OUTPUT_DATA = new DataSet();
    List<ItemEntity> productList = new List<ItemEntity>();
    PurchaseOrderEntity purchaseOrder = new PurchaseOrderEntity();
    DateTime invoice_Date = System.DateTime.Now;
    DateTime document_Date = System.DateTime.Now;
    PurchaseOrderModel purchaseOrderModel = new PurchaseOrderModel();
    List<VendorEntity> vendorList = new List<VendorEntity>();
    PRE pp = new PRE();
    List<OrderItemEntity> requestItemList = new List<OrderItemEntity>();
    public string searchparam { get; set; }
    PurchaseOrderModel porderModel = new PurchaseOrderModel();

    Stock_Details_Model details = new Stock_Details_Model();
    List<PurchaseOrderViewModel> purchaseDetailsList = new List<PurchaseOrderViewModel>();
    List<Stock_Details_Model> stockDetailsList = new List<Stock_Details_Model>();

    List<EmployeeModel> employeeList = new List<EmployeeModel>();

    StockModel stock = new StockModel();
    List<WarehouseModel> warehouseList = new List<WarehouseModel>();

    //protected bool IsDisabled { get; set; }




    //[Parameter]
    //public string Format { get; set; } = "dd/mm/yyyy";


    public async Task GetProductDetailsBYPO()
    {
        string pono = purchaseOrderModel.PO_NUMBER_LONG_CODE;
        purchaseDetailsList = await Http.GetJsonAsync<List<PurchaseOrderViewModel>>(Utility.BaseUrl + "api/Purchase/GetPurchaseOrderDetailsByPO/" + pono);
    }

    protected override async Task OnInitializedAsync()
    {

        ////IsDisabled = true;
        //requestItemList = await Http.GetJsonAsync<List<OrderItemEntity>>(Utility.BaseUrl + "api/Purchase/GetRequisitionItemDetailsByReqNo/" + requisition_no);
        employeeList = await Http.GetJsonAsync<List<EmployeeModel>>(Utility.BaseUrl + "api/Employee");
        warehouseList = await Http.GetJsonAsync<List<WarehouseModel>>(Utility.BaseUrl + "api/Purchase/GetAllWarehouse");
        //purchaseDetailsList= await Http.GetJsonAsync<List<PurchaseOrderDetailsEntity>>(Utility.BaseUrl + "api/Purchase/GetRequisitionItemDetailsByReqNo/" + requisition_no);

    }
    public async Task SavePurchaseOrder()
    {

        if (IsValidation() != true)
        {
            try
            {
                stock.INVOICE_DATE = invoice_Date;
                stock.DOCUMENT_DATE = document_Date;
                stock.DESCRIPTION = "StockIn";
                stock.CUSTOMER_SUPPLIER_ID = purchaseDetailsList.First().VENDOR_ID;
                stock.PO_NO = purchaseDetailsList.First().PO_NUMBER_LONG_CODE;

                porderModel.RECEIVED_DATE = System.DateTime.Now;
                porderModel.PO_NUMBER_LONG_CODE= purchaseDetailsList.First().PO_NUMBER_LONG_CODE;
                porderModel.SHIPMENT_STATUS = "Success";
                var podata = await Http.PutJsonAsync<PurchaseOrderModel>(Utility.BaseUrl + "api/Purchase/UpdateGoodsReceiveInfo", porderModel);
                var data = await Http.PostJsonAsync<StockModel>(Utility.BaseUrl + "api/Stock", stock);
                var id = await Http.GetJsonAsync<int>(Utility.BaseUrl + "api/Stock/GetStockId/" + purchaseOrderModel.PO_NUMBER_LONG_CODE);
                foreach (var item in purchaseDetailsList)
                {
                    details = new Stock_Details_Model();
                    details.STOCK_ID = id;
                    details.ITEM_ID = item.ITEM_ID;
                    details.PACK_SIZE = item.PACK_SIZE;
                    details.UOM = item.UOM;
                    details.STOCK_IN_QUANTITY = Convert.ToDouble(item.QUANTITY);
                    details.UNIT_PRICE = item.UNIT_PRICE;
                    details.WAREHOUSE_ID = stock.WAREHOUSE_ID;

                    stockDetailsList.Add(details);
                }
                var stock_details = await Http.PostJsonAsync<List<Stock_Details_Model>>(Utility.BaseUrl + "api/Stock/AddStockDetails", stockDetailsList);
                var stock_summery = await Http.PostJsonAsync<List<Stock_Details_Model>>(Utility.BaseUrl + "api/Stock/AddStockSummery", stockDetailsList);

                toastService.ShowSuccess("Insert Successfully!!!");
            }
            catch (Exception ex)
            {

            }

        }
    }
    private bool IsValidation()
    {
        bool flag = false;
        //if (purchaseOrderModel.PO_NUMBER_LONG_CODE == "" || purchaseOrderModel.PO_NUMBER_LONG_CODE == string.Empty || purchaseOrderModel.PO_NUMBER_LONG_CODE == null)
        //{
        //    toastService.ShowWarning("Requisition No cannot be empty!");
        //    flag = true;
        //}

        return flag;
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeVoidAsync("JsInteropDatepicker");

    }

    //private void CreateOutputReport(DataSet reprotOutputData)
    //{
    //    PrintInformationOutputItem outputItem = new PrintInformationOutputItem();
    //    try
    //    {
    //        outputItem.dataSet = DS_OUTPUT_DATA;
    //        if (DS_OUTPUT_DATA != null && DS_OUTPUT_DATA.Tables[0].Rows.Count > 0)
    //        { _ReportService.output(OutputReportSupport.GetReportConfig(outputItem), outputItem.dataSet); }
    //        else { MessageBox.Show("", "Info"); }
    //    }
    //    catch (Exception ex)
    //    {  }

    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.TOCOMA_ERP_System.Pages.Purchase.ProductReceive
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", (object)__arg0);
        __builder.AddAttribute(__seq1, "Value", (object)__arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", (object)__arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", (object)__arg3);
        __builder.AddAttribute(__seq4, "ChildContent", (object)__arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
