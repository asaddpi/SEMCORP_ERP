#pragma checksum "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9c6ab84095a80d9ac0cde0876cf095cf7792347"
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/ServiceCategory")]
    public partial class ServiceCategory : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "<div class=\"card-header\">\r\n        Service Category\r\n\r\n    </div>\r\n\r\n    <br>\r\n    ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 16 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceCategory.razor"
                      itemCategory

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "style", (object)("height:20%;margin-left:10px"));
            __builder.AddAttribute(6, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.AddMarkupContent(9, "<div class=\"col-md-2\"><label>Service Category:</label></div>\r\n            ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-md-7");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "style", (object)("width:500px"));
                __builder2.AddAttribute(14, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 20 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceCategory.razor"
                                         itemCategory.SERVICE_CATEGORY_NAME

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(15, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => itemCategory.SERVICE_CATEGORY_NAME = __value, itemCategory.SERVICE_CATEGORY_NAME)))));
                __builder2.AddAttribute(16, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => itemCategory.SERVICE_CATEGORY_NAME)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "row");
                __builder2.AddMarkupContent(20, "<div class=\"col-md-2\"></div>\r\n            ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "col-md-7");
                __builder2.OpenElement(23, "button");
                __builder2.AddAttribute(24, "type", "submit");
                __builder2.AddAttribute(25, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceCategory.razor"
                                                SaveCategory

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "class", "btn btn-info");
                __builder2.AddAttribute(27, "style", "width:120px;margin-right:10px");
#nullable restore
#line 27 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceCategory.razor"
__builder2.AddContent(28, submit);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.OpenElement(30, "button");
                __builder2.AddAttribute(31, "type", "button");
                __builder2.AddAttribute(32, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceCategory.razor"
                                                Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "class", "btn btn-danger");
                __builder2.AddAttribute(34, "style", "width:90px");
                __builder2.AddContent(35, "Cancel");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n\r\n    <br>\r\n\r\n    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "testbox");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "tablearea");
            __builder.OpenElement(41, "table");
            __builder.AddAttribute(42, "id", "example");
            __builder.AddAttribute(43, "class", "display");
            __builder.AddAttribute(44, "style", "width:100%");
            __builder.AddMarkupContent(45, "<thead><tr><th style=\"width:40px\"></th>\r\n                        <th style=\"width:40px\"></th>\r\n                        <td>Service Category</td></tr></thead>\r\n                ");
            __builder.OpenElement(46, "tbody");
#nullable restore
#line 50 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceCategory.razor"
                     if (categoryList != null)
                    {
                        foreach (var item in categoryList)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(47, "tr");
            __builder.OpenElement(48, "td");
            __builder.AddAttribute(49, "style", "text-align:center");
            __builder.OpenElement(50, "a");
            __builder.AddAttribute(51, "style", "color:red");
            __builder.AddAttribute(52, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceCategory.razor"
                                                                                              () => DeleteCategory(item.SERVICE_CATEGORY_ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "<span class=\"oi oi-trash\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                ");
            __builder.OpenElement(55, "td");
            __builder.AddAttribute(56, "style", "text-align:center");
            __builder.OpenElement(57, "a");
            __builder.AddAttribute(58, "data-toggle", "modal");
            __builder.AddAttribute(59, "data-target", ".bd-example-modal-lg");
            __builder.AddAttribute(60, "href", "#");
            __builder.AddAttribute(61, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceCategory.razor"
                                                                                                                                            () => editCategory(item.SERVICE_CATEGORY_ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(62, "<span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                                ");
            __builder.OpenElement(64, "td");
#nullable restore
#line 57 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceCategory.razor"
__builder.AddContent(65, item.SERVICE_CATEGORY_NAME);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceCategory.razor"
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
#line 162 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Service\ServiceCategory.razor"
       
    ServiceCategoryEntity itemCategory = new ServiceCategoryEntity();
    List<ServiceCategoryEntity> categoryList = new List<ServiceCategoryEntity>();
    string submit = "Save";
    protected override async Task OnInitializedAsync()
    {
        await GetItemCategory();
        StateHasChanged();

        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");
    }
    private async Task GetItemCategory()
    {
        categoryList = await Http.GetJsonAsync<List<ServiceCategoryEntity>>(Utility.BaseUrl + "api/Setup/GetServiceCategory");
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
                    var data = await Http.PostJsonAsync<ServiceCategoryEntity>(Utility.BaseUrl + "api/Setup/AddServiceCategory", itemCategory);
                    toastService.ShowSuccess("Insert Successfully!!!");
                }
                else if (submit == "Update")
                {
                    var data = await Http.PutJsonAsync<ServiceCategoryEntity>(Utility.BaseUrl + "api/Setup/UpdateServiceCategory", itemCategory);
                    toastService.ShowSuccess("Update Successfully!!!");
                }

                itemCategory = new ServiceCategoryEntity();
                submit = "Save";
            }
            catch (Exception ex)
            { }
        }
        await GetItemCategory();
    }
    private async Task Cancel()
    {
        itemCategory = new ServiceCategoryEntity();
        submit = "Save";
    }
    private async Task editCategory(int categoryId)
    {
        submit = "Update";
        itemCategory = new ServiceCategoryEntity();
        itemCategory.SERVICE_CATEGORY_NAME = categoryList.Find(x => x.SERVICE_CATEGORY_ID == categoryId).SERVICE_CATEGORY_NAME;
        itemCategory.SERVICE_CATEGORY_ID = categoryId;
        itemCategory.Operation_Type = 2;
    }
    private async Task DeleteCategory(int categoryId)
    {

        if (!await JSRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to delete ?"))
            return;

        await Http.DeleteAsync(Utility.BaseUrl + "api/Setup/DeleteServiceCategory/" + categoryId);
        await GetItemCategory();
    }
    private bool IsValidation_Category()
    {
        bool flag = false;
        if (itemCategory.SERVICE_CATEGORY_NAME == "" || itemCategory.SERVICE_CATEGORY_NAME == string.Empty || itemCategory.SERVICE_CATEGORY_NAME == null)
        {
            toastService.ShowWarning("Category cannot be empty!");
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
#pragma warning restore 1591
