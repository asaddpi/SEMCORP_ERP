#pragma checksum "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceSubCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3eb93fda3890bc4754b79bf6d9a6238da47e8adc"
// <auto-generated/>
#pragma warning disable 1591
namespace TOCOMA_ERP_System.Pages.Service
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/ServiceSubCategory")]
    public partial class ServiceSubCategory : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "<div class=\"card-header\">\r\n        Service Sub-Category\r\n\r\n    </div>\r\n\r\n    <br>\r\n    ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 14 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceSubCategory.razor"
                      itemCategory

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "style", (object)("height:20%;margin-left:10px"));
            __builder.AddAttribute(6, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group row");
                __builder2.AddMarkupContent(9, "<label for=\"colFormLabel\" class=\"col-sm-2 col-form-label\">Service Category:</label>\r\n            ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-sm-10");
                global::__Blazor.TOCOMA_ERP_System.Pages.Service.ServiceSubCategory.TypeInference.CreateInputSelect_0(__builder2, 12, 13, "form-control", 14, 
#nullable restore
#line 18 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceSubCategory.razor"
                                           itemCategory.SERVICE_CATEGORY_ID

#line default
#line hidden
#nullable disable
                , 15, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => itemCategory.SERVICE_CATEGORY_ID = __value, itemCategory.SERVICE_CATEGORY_ID)), 16, () => itemCategory.SERVICE_CATEGORY_ID, 17, (__builder3) => {
                    __builder3.AddMarkupContent(18, "<option value>--Select Item Category--</option>");
#nullable restore
#line 20 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceSubCategory.razor"
                     foreach (var item in servicecategoryList)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(19, "option");
                    __builder3.AddAttribute(20, "value", 
#nullable restore
#line 22 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceSubCategory.razor"
                                        item.SERVICE_CATEGORY_ID

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 22 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceSubCategory.razor"
__builder3.AddContent(21, item.SERVICE_CATEGORY_NAME);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 23 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceSubCategory.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\r\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group row");
                __builder2.AddMarkupContent(25, "<label for=\"colFormLabel\" class=\"col-sm-2 col-form-label\">Service Sub-Category:</label>\r\n            ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "col-sm-10");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "class", (object)("form-control"));
                __builder2.AddAttribute(30, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 32 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceSubCategory.razor"
                                         itemCategory.SERVICE_SUB_CATEGORY_NAME

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(31, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => itemCategory.SERVICE_SUB_CATEGORY_NAME = __value, itemCategory.SERVICE_SUB_CATEGORY_NAME)))));
                __builder2.AddAttribute(32, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => itemCategory.SERVICE_SUB_CATEGORY_NAME)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n        \r\n        <br>\r\n        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "row");
                __builder2.AddMarkupContent(36, "<div class=\"col-md-2\"></div>\r\n            ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "col-md-7");
                __builder2.OpenElement(39, "button");
                __builder2.AddAttribute(40, "type", "submit");
                __builder2.AddAttribute(41, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceSubCategory.razor"
                                                SaveCategory

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "class", "btn btn-info");
                __builder2.AddAttribute(43, "style", "width:120px;margin-right:10px");
#nullable restore
#line 40 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceSubCategory.razor"
__builder2.AddContent(44, submit);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                ");
                __builder2.OpenElement(46, "button");
                __builder2.AddAttribute(47, "type", "button");
                __builder2.AddAttribute(48, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceSubCategory.razor"
                                                Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "class", "btn btn-danger");
                __builder2.AddAttribute(50, "style", "width:90px");
                __builder2.AddContent(51, "Cancel");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(52, "\r\n\r\n    <br>\r\n\r\n    ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "testbox");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "tablearea");
            __builder.OpenElement(57, "table");
            __builder.AddAttribute(58, "id", "example");
            __builder.AddAttribute(59, "class", "display");
            __builder.AddAttribute(60, "style", "width:100%");
            __builder.AddMarkupContent(61, "<thead><tr><th style=\"width:40px\"></th>\r\n                        <th style=\"width:40px\"></th>\r\n                        <td>Service Sub-Category</td></tr></thead>\r\n                ");
            __builder.OpenElement(62, "tbody");
#nullable restore
#line 63 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceSubCategory.razor"
                     if (servicesubcategoryList != null)
                    {
                        foreach (var item in servicesubcategoryList)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(63, "tr");
            __builder.OpenElement(64, "td");
            __builder.AddAttribute(65, "style", "text-align:center");
            __builder.OpenElement(66, "a");
            __builder.AddAttribute(67, "style", "color:red");
            __builder.AddAttribute(68, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceSubCategory.razor"
                                                                                              () => DeleteCategory(item.SERVICE_SUB_CATEGORY_ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(69, "<span class=\"oi oi-trash\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                                ");
            __builder.OpenElement(71, "td");
            __builder.AddAttribute(72, "style", "text-align:center");
            __builder.OpenElement(73, "a");
            __builder.AddAttribute(74, "data-toggle", "modal");
            __builder.AddAttribute(75, "data-target", ".bd-example-modal-lg");
            __builder.AddAttribute(76, "href", "#");
            __builder.AddAttribute(77, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceSubCategory.razor"
                                                                                                                                            () => editCategory(item.SERVICE_SUB_CATEGORY_ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(78, "<span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                                ");
            __builder.OpenElement(80, "td");
#nullable restore
#line 70 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceSubCategory.razor"
__builder.AddContent(81, item.SERVICE_CATEGORY_NAME);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                                ");
            __builder.OpenElement(83, "td");
#nullable restore
#line 71 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceSubCategory.razor"
__builder.AddContent(84, item.SERVICE_SUB_CATEGORY_NAME);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 73 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceSubCategory.razor"
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
#line 176 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceSubCategory.razor"
       
    ServiceSubCategoryEntity itemCategory = new ServiceSubCategoryEntity();
    List<ServiceSubCategoryEntity> servicesubcategoryList = new List<ServiceSubCategoryEntity>();
    List<ServiceCategoryEntity> servicecategoryList = new List<ServiceCategoryEntity>();
    string submit = "Save";
    protected override async Task OnInitializedAsync()
    {
        await GetItemCategory();
        servicecategoryList = await Http.GetJsonAsync<List<ServiceCategoryEntity>>(Utility.BaseUrl + "api/Setup/GetServiceCategory");
        StateHasChanged();

        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");
    }
    private async Task GetItemCategory()
    {
        servicesubcategoryList = await Http.GetJsonAsync<List<ServiceSubCategoryEntity>>(Utility.BaseUrl + "api/Setup/GetServiceSubCategory");
    }
    public async Task SaveCategory()
    {
        if (IsValidation_Category() != true)
        {
            try
            {
                if (submit == "Save")
                {
                    itemCategory.Operation_Type = 1;
                    var data = await Http.PostJsonAsync<ServiceSubCategoryEntity>(Utility.BaseUrl + "api/Setup/AddServiceSubCategory", itemCategory);
                    toastService.ShowSuccess("Insert Successfully!!!");
                }
                else if (submit == "Update")
                {
                    var data = await Http.PutJsonAsync<ServiceSubCategoryEntity>(Utility.BaseUrl + "api/Setup/UpdateServiceSubCategory", itemCategory);
                    toastService.ShowSuccess("Update Successfully!!!");
                }

                itemCategory = new ServiceSubCategoryEntity();
                submit = "Save";
            }
            catch (Exception ex)
            { }
        }
        await GetItemCategory();
    }
    private async Task Cancel()
    {
        itemCategory = new ServiceSubCategoryEntity();
        submit = "Save";
    }
    private async Task editCategory(int subcategoryId)
    {
        submit = "Update";
        itemCategory = new ServiceSubCategoryEntity();
        itemCategory.SERVICE_SUB_CATEGORY_NAME = servicesubcategoryList.Find(x => x.SERVICE_SUB_CATEGORY_ID == subcategoryId).SERVICE_SUB_CATEGORY_NAME;
        itemCategory.SERVICE_CATEGORY_ID = servicesubcategoryList.Find(x => x.SERVICE_SUB_CATEGORY_ID == subcategoryId).SERVICE_CATEGORY_ID;
        itemCategory.SERVICE_CATEGORY_ID = subcategoryId;
        itemCategory.Operation_Type = 2;
    }
    private async Task DeleteCategory(int categoryId)
    {

        if (!await JSRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to delete ?"))
            return;

        await Http.DeleteAsync(Utility.BaseUrl + "api/Setup/DeleteServiceSubCategory/" + categoryId);
        await GetItemCategory();
    }
    private bool IsValidation_Category()
    {
        bool flag = false;
        if (itemCategory.SERVICE_SUB_CATEGORY_NAME == "" || itemCategory.SERVICE_SUB_CATEGORY_NAME == string.Empty || itemCategory.SERVICE_SUB_CATEGORY_NAME == null)
        {
            toastService.ShowWarning("SubCategory cannot be empty!");
            flag = true;
        }

        return flag;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.TOCOMA_ERP_System.Pages.Service.ServiceSubCategory
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", (object)__arg0);
        __builder.AddAttribute(__seq1, "Value", (object)__arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", (object)__arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", (object)__arg3);
        __builder.AddAttribute(__seq4, "ChildContent", (object)__arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
