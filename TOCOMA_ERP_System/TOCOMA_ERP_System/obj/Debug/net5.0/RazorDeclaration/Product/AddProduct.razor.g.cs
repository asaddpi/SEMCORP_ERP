// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TOCOMA_ERP_System.Product
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
#nullable restore
#line 6 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\AddProduct.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CustomLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/AddProduct")]
    public partial class AddProduct : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 288 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\AddProduct.razor"
       
    List<ItemEntity> productList = new List<ItemEntity>();
    List<VendorEntity> vendorList = new List<VendorEntity>();
    List<BrandModel> brandList = new List<BrandModel>();
    List<UnitModel> unitList = new List<UnitModel>();
    List<ColorModel> colorList = new List<ColorModel>();
    List<UnitModel> UnitList = new List<UnitModel>();
    ItemEntity item = new ItemEntity();
    BrandModel brand = new BrandModel();
    UnitModel unit = new UnitModel();
    ColorModel color = new ColorModel();
    string btnTEXT;



    protected override async Task OnInitializedAsync()
    {
        btnTEXT = "Save";
        await GetItemList();
        vendorList = await Http.GetJsonAsync<List<VendorEntity>>(Utility.BaseUrl + "api/Vendor");
        brandList = await Http.GetJsonAsync<List<BrandModel>>(Utility.BaseUrl + "api/Brand");
        unitList = await Http.GetJsonAsync<List<UnitModel>>(Utility.BaseUrl + "api/Setup/GetUnitList");
        colorList = await Http.GetJsonAsync<List<ColorModel>>(Utility.BaseUrl + "api/Setup/GetColorList");

    }

    private async Task GetItemList()
    {
        productList = await Http.GetJsonAsync<List<ItemEntity>>(Utility.BaseUrl + "api/Product");
    }

    public async Task SaveProduct()
    {
        if (IsValidation() != true)
        {
            if (btnTEXT == "Save")
            {
                bool IsExistProduct = await Http.GetJsonAsync<bool>(Utility.BaseUrl + "api/Product/GetIsItemExist/" + item.ITEM_CODE);
                if (IsExistProduct != true)
                {
                    try
                    {
                        var data = await Http.PostJsonAsync<ItemEntity>(Utility.BaseUrl + "api/Product", item);
                        toastService.ShowSuccess("Item Added Successfully!!!");
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            else
            {
                try
                {
                    var data = await Http.PutJsonAsync<ItemEntity>(Utility.BaseUrl + "api/Product", item);
                    ClearData();
                    toastService.ShowSuccess("Item Added Successfully!!!");
                }
                catch (Exception ex)
                {

                }
            }
            await GetItemList();


        }
    }
    private bool IsValidation()
    {
        bool flag = false;
        if (item.ITEM_NAME == "" || item.ITEM_NAME == string.Empty || item.ITEM_NAME == null)
        {
            toastService.ShowWarning("Item Name cannot be empty!");
            flag = true;
        }

        return flag;
    }

    public async Task SaveBrand()
    {
        if (IsValidation_Brand() != true)
        {
            try
            {
                var data = await Http.PostJsonAsync<BrandModel>(Utility.BaseUrl + "api/Brand", brand);
                toastService.ShowSuccess("Insert Successfully!!!");
            }
            catch (Exception ex)
            {

            }

        }
        brandList = await Http.GetJsonAsync<List<BrandModel>>(Utility.BaseUrl + "api/Brand");
    }
    private bool IsValidation_Brand()
    {
        bool flag = false;
        if (brand.BRAND_NAME == "" || brand.BRAND_NAME == string.Empty || brand.BRAND_NAME == null)
        {
            toastService.ShowWarning("Brand Name cannot be empty!");
            flag = true;
        }

        return flag;
    }
    public async Task SaveUnit()
    {

        if (IsValidation_Unit() != true)
        {
            try
            {
                var data = await Http.PostJsonAsync<BrandModel>(Utility.BaseUrl + "api/Setup/AddUnit", unit);
                toastService.ShowSuccess("Insert Successfully!!!");
            }
            catch (Exception ex)
            {

            }

        }
        unitList = await Http.GetJsonAsync<List<UnitModel>>(Utility.BaseUrl + "api/Setup/GetUnitList");
    }
    private bool IsValidation_Unit()
    {
        bool flag = false;
        if (unit.UNIT_NAME == "" || unit.UNIT_NAME == string.Empty || unit.UNIT_NAME == null)
        {
            toastService.ShowWarning("Unit Name cannot be empty!");
            flag = true;
        }

        return flag;
    }
    public async Task SaveColor()
    {

        if (IsValidation_Color() != true)
        {
            try
            {
                var data = await Http.PostJsonAsync<ColorModel>(Utility.BaseUrl + "api/Setup/AddColor", color);
                toastService.ShowSuccess("Insert Successfully!!!");
            }
            catch (Exception ex)
            {

            }

        }
        colorList = await Http.GetJsonAsync<List<ColorModel>>(Utility.BaseUrl + "api/Setup/GetColorList");
    }
    private bool IsValidation_Color()
    {
        bool flag = false;
        if (color.COLOR_NAME == "" || color.COLOR_NAME == string.Empty || color.COLOR_NAME == null)
        {
            toastService.ShowWarning("Color Name cannot be empty!");
            flag = true;
        }

        return flag;
    }
    private async void EditItem(int itemId)
    {
        btnTEXT = "Edit";
        item.ITEM_ID= productList.FirstOrDefault(x => x.ITEM_ID == itemId).ITEM_ID;
        item.ITEM_CODE = productList.FirstOrDefault(x => x.ITEM_ID == itemId).ITEM_CODE;
        item.ITEM_NAME = productList.FirstOrDefault(x => x.ITEM_ID == itemId).ITEM_NAME;
        item.SHORT_DESCRIPTION = productList.FirstOrDefault(x => x.ITEM_ID == itemId).SHORT_DESCRIPTION;
        item.ITEM_PURCHASE_PRICE = productList.FirstOrDefault(x => x.ITEM_ID == itemId).ITEM_PURCHASE_PRICE;
        item.ITEM_SALE_PRICE = productList.FirstOrDefault(x => x.ITEM_ID == itemId).ITEM_SALE_PRICE;
        item.PACK_SIZE = productList.FirstOrDefault(x => x.ITEM_ID == itemId).PACK_SIZE;
        item.VENDOR_ID = productList.FirstOrDefault(x => x.ITEM_ID == itemId).VENDOR_ID;
        item.BRAND_ID = productList.FirstOrDefault(x => x.ITEM_ID == itemId).BRAND_ID;
        item.UNIT_ID = productList.FirstOrDefault(x => x.ITEM_ID == itemId).UNIT_ID;
        item.COLOR_ID = productList.FirstOrDefault(x => x.ITEM_ID == itemId).COLOR_ID;
    }
    private  void ClearData()
    {
        btnTEXT = "Save";

        item.ITEM_CODE = "";
        item.ITEM_NAME = "";
        item.SHORT_DESCRIPTION = "";
        item.PACK_SIZE = "";
        item.ITEM_PURCHASE_PRICE = 0;
        item.ITEM_SALE_PRICE = 0;
        item.VENDOR_ID = 0;
        item.UNIT_ID = 0;
        item.COLOR_ID = 0;
        item.BRAND_ID = 0;


    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
