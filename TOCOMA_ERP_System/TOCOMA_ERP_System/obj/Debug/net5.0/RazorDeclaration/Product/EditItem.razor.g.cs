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
#line 6 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\EditItem.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\EditItem.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CustomLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/EditItem/{itemCode}")]
    public partial class EditItem : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 467 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\EditItem.razor"
       
    BlazoredTextEditor shortDescription;
    BlazoredTextEditor longDescription;
    BlazoredTextEditor applicationArea;
    BlazoredTextEditor sewistiveness;
    string itemname = "";
    List<string> itemimageUrls = new List<string>();
    List<string> itemtdsUrls = new List<string>();
    List<string> itemimage = new List<string>();
    List<string> itemTDS = new List<string>();
    List<string> allitemTDS = new List<string>();
    List<string> itemSDS = new List<string>();
    List<string> allitemSDS = new List<string>();
    List<string> itemFlyer = new List<string>();
    List<string> allitemFlyer = new List<string>();
    List<string> itemCertificate = new List<string>();
    List<string> ApplicationimageUrls = new List<string>();
    List<ItemEntity> productList = new List<ItemEntity>();
    List<ItemCategory> categoryList = new List<ItemCategory>();
    IReadOnlyList<IBrowserFile> selectedFiles;
    IReadOnlyList<IBrowserFile> selectedItemImage;
    IReadOnlyList<IBrowserFile> selectedTDS;
    IReadOnlyList<IBrowserFile> selectedSDS;
    IReadOnlyList<IBrowserFile> selectedFlayer;
    IReadOnlyList<IBrowserFile> selectedCertificate;
    ItemEntity item = new ItemEntity();
    ItemEntity relatedItem = new ItemEntity();
    List<VendorEntity> vendorList = new List<VendorEntity>();
    List<ItemEntity> itemList = new List<ItemEntity>();
    List<CountryModel> CountryList = new List<CountryModel>();
    List<UnitModel> unitList = new List<UnitModel>();
    List<BrandModel> brandList = new List<BrandModel>();
    List<ColorModel> colorList = new List<ColorModel>();
    List<ItemApplicationAreaModel> itemApplicationList = new List<ItemApplicationAreaModel>();
    ItemApplicationAreaModel relatedApp = new ItemApplicationAreaModel();
    List<ItemApplicationAreaModel> SelectedRelatedApplicationList = new List<ItemApplicationAreaModel>();
    List<ItemEntity> relatedItemList = new List<ItemEntity>();
    List<ItemSewstivenessModel> itemSewstiveness = new List<ItemSewstivenessModel>();
    List<ItemForm_Appearance> itemForm_Appearances = new List<ItemForm_Appearance>();
    List<ImageFile> filesBase64 = new List<ImageFile>();
    ItemViewModel itemView = new ItemViewModel();
    List<clsItemType> itemTypeList = new List<clsItemType>();
    List<ItemSubCategory> subCategoryList = new List<ItemSubCategory>();
    List<InventoryTypeModel> inventoryTypeList = new List<InventoryTypeModel>();

    string categoryName;
    string code;
    string path_withfile = "";
    string saveimageurl = "";
    public int display_image = 1;

    private List<IBrowserFile> loadedFiles = new();
    private long maxFileSize = 1024 * 5000;
    private int maxAllowedFiles = 3;
    private bool isLoading;
    List<string> tdslist = new List<string>();
    List<string> sdslist = new List<string>();
    List<string> videolist = new List<string>();
    // ImageFile.cs
    public class ImageFile
    {
        public string base64data { get; set; }
        public string contentType { get; set; }
        public string fileName { get; set; }
    }
    [Parameter]
    public string itemCode { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await GetItemCategory();
        await GetItemList();
        await GetUnit();
        await GetCountry();
        await GetBrand();
        await GetInventoryType();
        await GetAreaOfApplication();
        await GetItemSewstiveness();
        await GetItemForm_Appearance();
        await GetColor();
        await GetItemType();
        vendorList = await Http.GetJsonAsync<List<VendorEntity>>(Utility.BaseUrl + "api/Vendor");
        subCategoryList = await Http.GetJsonAsync<List<ItemSubCategory>>(Utility.BaseUrl + "api/Setup/GetItemSubCategory");
        itemView = await Http.GetJsonAsync<ItemViewModel>(Utility.BaseUrl + "api/Product/GetItemByCode/" + itemCode);

        item.ITEM_NAME = itemView.ITEM_NAME;
        saveimageurl = itemView.ITEM_IMAGE;
        item.ITEM_CODE = itemView.ITEM_CODE;
        item.CATEGORY_ID = itemView.CATEGORY_ID;
        item.BRAND_NAME = itemView.BRAND_NAME;
        item.MODEL = itemView.MODEL;
        item.VENDOR_ID = itemView.VENDOR_ID;
        item.ITEM_TYPE = itemView.ITEM_TYPE;
        item.MAID_IN_COUNTRY = itemView.MAID_IN_COUNTRY;
        item.ITEM_ID = itemView.ITEM_ID;

        //if (itemView.LONG_DESCRIPTION != null)
        //{
        //    await this.longDescription.LoadHTMLContent(itemView.LONG_DESCRIPTION);
        //}
        //if (itemView.APPLICATION_AREA != null)
        //{
        //    await this.applicationArea.LoadHTMLContent(itemView.APPLICATION_AREA);
        //}
        //if(itemView.SEWSTIVENESS!=null)
        //{
        //    await this.sewistiveness.LoadHTMLContent(itemView.SEWSTIVENESS);
        //}
        //item.UNIT_ID = itemView.UNIT_ID;
        //item.PACK_SIZE = itemView.PACK_SIZE;
        //item.DOSAGE = itemView.DOSAGE;
        //item.COVERAGE_CONSUMPTION = itemView.COVERAGE_CONSUMPTION;
        //item.MAID_IN_COUNTRY = itemView.MAID_IN_COUNTRY;
        //item.IMPORT_FROM = itemView.IMPORT_FROM;
        //item.BRAND_ORIGIN_COUNTRY = itemView.BRAND_ORIGIN_COUNTRY;
        //item.ITEM_KEYWORD = itemView.ITEM_KEYWORD;
        //item.SHELF_LIFE = itemView.SHELF_LIFE;
        //item.ITEM_PRICE = itemView.ITEM_PRICE;
        //item.PACK_TYPE = itemView.PACK_TYPE;
        //item.ITEM_SPECIALTY = itemView.ITEM_SPECIALTY;
        //item.TYPE_OF_INVENTORY = itemView.TYPE_OF_INVENTORY;
        //item.SEWSTIVENESS = itemView.SEWSTIVENESS;
        //item.ITEM_FORM_APPEARANCE = itemView.ITEM_FORM_APPEARANCE;
        //item.COLOR_ID = itemView.COLOR_ID;

        item.ITEM_IMAGE = itemView.ITEM_IMAGE;
        if(item.ITEM_IMAGE!=null)
        {
            itemimageUrls.Add(item.ITEM_IMAGE);
        }

        if (itemView.ITEM_CODE != null && itemView.ITEM_CODE != "")
        {
            var path = $"{env.WebRootPath}\\images\\File\\ITEM_DOCUMENTS";
            string[] tdsfilelist = Directory.GetFiles(path);

            var sdspath = $"{env.WebRootPath}\\images\\File\\Certificate";
            string[] sdsfilelist = Directory.GetFiles(sdspath);

            //var flayerPath = $"{env.WebRootPath}\\images\\File\\FLAYER";
            //string[] flayerList = Directory.GetFiles(flayerPath);

            //var videoPath = $"{env.WebRootPath}\\Video";
            //string[] allvideolist = Directory.GetFiles(videoPath);

            List<string> file = new List<string>();
            //itemDetails.ITEM_CODE = "100";
            foreach (var item in tdsfilelist)
            {
                if (item.Contains(itemView.ITEM_CODE))
                {
                    itemTDS.Add(Path.GetFileName(item));
                    allitemTDS.Add(Path.GetFileName(item));
                }

            }
            //----------------
            foreach (var item in sdsfilelist)
            {
                if (item.Contains(itemView.ITEM_CODE))
                {
                    itemSDS.Add(Path.GetFileName(item));
                    itemCertificate.Add(Path.GetFileName(item));
                }

            }
            //--------------
            //----------------
            //foreach (var item in flayerList)
            //{
            //    if (item.Contains(itemView.ITEM_CODE))
            //    {
            //        itemFlyer.Add(Path.GetFileName(item));
            //        allitemFlyer.Add(Path.GetFileName(item));
            //    }

            //}

            //foreach (var item in allvideolist)
            //{
            //    if (item.Contains(itemView.ITEM_CODE))
            //    {
            //        videolist.Add(Path.GetFileName(item));
            //    }

            //}
        }


    }
    private void CancelTds(string file)
    {
        int index = itemTDS.IndexOf(file);
        itemTDS.RemoveAt(index);
    }
    private void CancelSds(string file)
    {
        int index = itemSDS.IndexOf(file);
        itemSDS.RemoveAt(index);
    }
    private void CancelFlayer(string file)
    {
        int index = itemFlyer.IndexOf(file);
        itemFlyer.RemoveAt(index);
    }

    private async Task GetItemForm_Appearance()
    {
        itemForm_Appearances = await Http.GetJsonAsync<List<ItemForm_Appearance>>(Utility.BaseUrl + "api/Setup/GetItemForm_Appearance");
    }
    private async Task GetItemSewstiveness()
    {
        itemSewstiveness = await Http.GetJsonAsync<List<ItemSewstivenessModel>>(Utility.BaseUrl + "api/Setup/GetItemSewstiveness");
    }
    private async Task GetInventoryType()
    {
        inventoryTypeList = await Http.GetJsonAsync<List<InventoryTypeModel>>(Utility.BaseUrl + "api/Setup/GetInventoryType");
    }
    private async Task GetItemCategory()
    {
        categoryList = await Http.GetJsonAsync<List<ItemCategory>>(Utility.BaseUrl + "api/Setup/GetItemCategory");
    }
    private async Task GetUnit()
    {
        unitList = await Http.GetJsonAsync<List<UnitModel>>(Utility.BaseUrl + "api/Setup/GetUnit");
    }
    private async Task GetColor()
    {
        colorList = await Http.GetJsonAsync<List<ColorModel>>(Utility.BaseUrl + "api/Setup/GetColorList");
    }
    private async Task GetCountry()
    {
        CountryList = await Http.GetJsonAsync<List<CountryModel>>(Utility.BaseUrl + "api/Setup/GetCountry");
    }
    private async Task GetBrand()
    {
        brandList = await Http.GetJsonAsync<List<BrandModel>>(Utility.BaseUrl + "api/Setup/GetBrandList");
    }
    private async Task GetItemList()
    {
        productList = await Http.GetJsonAsync<List<ItemEntity>>(Utility.BaseUrl + "api/Product");
    }
    private async Task GetAreaOfApplication()
    {
        itemApplicationList = await Http.GetJsonAsync<List<ItemApplicationAreaModel>>(Utility.BaseUrl + "api/Setup/GetItemApplicationArea");
    }
    private async Task GetItemType()
    {
        itemTypeList = await Http.GetJsonAsync<List<clsItemType>>(Utility.BaseUrl + "api/Setup/GetItemType");
    }
    private async Task SelectItemImage1111(InputFileChangeEventArgs e)
    {
        selectedFiles = e.GetMultipleFiles();
        this.StateHasChanged();
        foreach (var file in selectedFiles)
        {
            //Stream stream = file.OpenReadStream();
            //var path = $"{env.WebRootPath}\\images\\File\\TDS\\{file.Name}";
            //FileStream fs = File.Create(path);
            //await stream.CopyToAsync(fs);
            //stream.Close();
            //fs.Close();
            itemimage.Add(file.Name);
            //itemTDS.Add(path);
            selectedItemImage = selectedFiles;
            selectedFiles = null;
        }
        this.StateHasChanged();


    }
    private async Task SelectItemImage11(InputFileChangeEventArgs e)
    {
        selectedItemImage = e.GetMultipleFiles();

        foreach (var imageFile in selectedItemImage)
        {
            var resizedImage = await imageFile.RequestImageFileAsync("image/jpg", 100, 100);
            var buffer = new byte[resizedImage.Size];
            await resizedImage.OpenReadStream().ReadAsync(buffer);
            //var imgData = $"data:image/jpg;base64,{Convert.ToBase64String(buffer)}";
            var imgData = $"data:image/jpg;base64,{Convert.ToBase64String(buffer)}";
            itemimageUrls.Add(imgData);

        }

        this.StateHasChanged();
    }
    private async Task SelectItemImage(InputFileChangeEventArgs e)
    {
        //itemView.ITEM_IMAGE = null;
        display_image = 0;
        itemimageUrls = new List<string>();
        selectedItemImage = e.GetMultipleFiles();

        foreach (var imageFile in selectedItemImage)
        {
            //var resizedImage = await imageFile.RequestImageFileAsync("image/jpg", 100, 100);
            var resizedImage = await imageFile.RequestImageFileAsync(imageFile.ContentType, 15000, 15000);
            var buffer = new byte[resizedImage.Size];
            await resizedImage.OpenReadStream().ReadAsync(buffer);
            //var imgData = $"data:image/jpg;base64,{Convert.ToBase64String(buffer)}";
            var imgData = $"data:image/jpg;base64,{Convert.ToBase64String(buffer)}";
            itemimageUrls.Add(imgData);

        }

        this.StateHasChanged();
    }
    async Task SelectItemImage333(InputFileChangeEventArgs e)
    {
        itemView.ITEM_IMAGE = null;
        var files = e.GetMultipleFiles(); // get the files selected by the users
        foreach (var file in files)
        {
            var resizedFile = await file.RequestImageFileAsync(file.ContentType, 640, 480); // resize the image file
            var buf = new byte[resizedFile.Size]; // allocate a buffer to fill with the file's data
            using (var stream = resizedFile.OpenReadStream())
            {
                await stream.ReadAsync(buf); // copy the stream to the buffer
            }
            //itemimageUrls.Add(new ImageFile { base64data = Convert.ToBase64String(buf), contentType = file.ContentType, fileName = file.Name });
            filesBase64.Add(new ImageFile { base64data = Convert.ToBase64String(buf), contentType = file.ContentType, fileName = file.Name }); // convert to a base64 string!!
                                                                                                                                               //itemimageUrls.Add(filesBase64);
            itemimageUrls.Add(Convert.ToBase64String(buf));
            selectedItemImage = files;
        }
        //message = "Click UPLOAD to continue";
    }



    private async Task SelectApplicationImage(InputFileChangeEventArgs e)
    {
        selectedFiles = e.GetMultipleFiles();

        foreach (var imageFile in selectedFiles)
        {
            var resizedImage = await imageFile.RequestImageFileAsync("image/jpg", 100, 100);
            var buffer = new byte[resizedImage.Size];
            await resizedImage.OpenReadStream().ReadAsync(buffer);
            var imgData = $"data:image/jpg;base64,{Convert.ToBase64String(buffer)}";
            ApplicationimageUrls.Add(imgData);

        }
        this.StateHasChanged();
    }
    public async Task SaveProduct()
    {
        if (IsValidation() != true)
        {

            bool IsExistProduct = await Http.GetJsonAsync<bool>(Utility.BaseUrl + "api/Product/GetIsItemExist/" + itemView.ITEM_CODE);
            if (IsExistProduct == true)
            {
                try
                {
                    code = item.ITEM_CODE;
                    if (itemTDS != null)
                    {
                        foreach (var alltds in allitemTDS)
                        {
                            foreach (var tds in itemTDS)
                            {
                                if (alltds != tds)
                                {
                                    if (itemTDS.Contains(alltds))
                                    { }
                                    else
                                    {
                                        var path = $"{env.WebRootPath}\\images\\File\\ITEM_DOCUMENTS\\{alltds}";
                                        if (File.Exists(path))
                                        {
                                            File.Delete(path);
                                        }
                                    }


                                }
                            }
                        }


                    }
                    if (selectedTDS != null)
                    {
                        foreach (var tds in selectedTDS)
                        {
                            var path = $"{env.WebRootPath}\\images\\File\\ITEM_DOCUMENTS\\{code + "_" + tds.Name}";
                            await using FileStream fs = new(path, FileMode.Create);
                            await tds.OpenReadStream(maxFileSize).CopyToAsync(fs);

                            //Stream stream = tds.OpenReadStream();
                            //var path = $"{env.WebRootPath}\\images\\File\\TDS\\{tds.Name}";
                            //FileStream fs = File.Create(path);
                            //await stream.CopyToAsync(fs);
                            //stream.Close();
                            fs.Close();
                        }
                    }
                    if (itemCertificate != null)
                    {
                        foreach (var allsds in allitemSDS)
                        {
                            foreach (var sds in itemCertificate)
                            {
                                if (allsds != sds)
                                {
                                    if (itemCertificate.Contains(allsds))
                                    { }
                                    else
                                    {
                                        var path = $"{env.WebRootPath}\\images\\File\\Certificate\\{allsds}";
                                        if (File.Exists(path))
                                        {
                                            File.Delete(path);
                                        }
                                    }


                                }
                            }
                        }


                    }
                    if (selectedCertificate != null)
                    {
                        foreach (var sds in selectedCertificate)
                        {
                            //Stream stream = sds.OpenReadStream();
                            //var path = $"{env.WebRootPath}\\images\\File\\SDS\\{sds.Name}";
                            //FileStream fs = File.Create(path);
                            //await stream.CopyToAsync(fs);
                            //stream.Close();

                            var path = $"{env.WebRootPath}\\images\\File\\Certificate\\{code + "_" + sds.Name}";
                            await using FileStream fs = new(path, FileMode.Create);
                            await sds.OpenReadStream(maxFileSize).CopyToAsync(fs);
                            fs.Close();
                        }
                    }

                    //if (itemFlyer != null)
                    //{
                    //    foreach (var allflayer in allitemFlyer)
                    //    {
                    //        foreach (var flayer in itemFlyer)
                    //        {
                    //            if (allflayer != flayer)
                    //            {
                    //                if (itemFlyer.Contains(allflayer))
                    //                { }
                    //                else
                    //                {
                    //                    var path = $"{env.WebRootPath}\\images\\File\\FLAYER\\{allflayer}";
                    //                    if (File.Exists(path))
                    //                    {
                    //                        File.Delete(path);
                    //                    }
                    //                }
                    //            }
                    //        }
                    //    }


                    //}
                    //if (selectedFlayer != null)
                    //{
                    //    foreach (var flayer in selectedFlayer)
                    //    {
                    //        //Stream stream = flayer.OpenReadStream();
                    //        //var path = $"{env.WebRootPath}\\images\\File\\FLAYER\\{flayer.Name}";
                    //        //FileStream fs = File.Create(path);
                    //        //await stream.CopyToAsync(fs);
                    //        //stream.Close();

                    //        var path = $"{env.WebRootPath}\\images\\File\\FLAYER\\{code + "_" + flayer.Name}";
                    //        await using FileStream fs = new(path, FileMode.Create);
                    //        await flayer.OpenReadStream(maxFileSize).CopyToAsync(fs);
                    //        fs.Close();
                    //    }
                    //}

                    if (selectedItemImage != null)
                    {
                        foreach (var file in selectedItemImage)
                        {
                            var existImagepath = $"{env.WebRootPath}{itemView.ITEM_IMAGE}";
                            bool exists = System.IO.Directory.Exists(existImagepath);
                            if (File.Exists(existImagepath))
                            {
                                File.Delete(existImagepath);
                            }

                            //string subCategory_Unic_imageid = "";
                            //subCategory_Unic_imageid = GetSubCategoryUnicImageId();
                            //await GetProductUnicImageId();
                            //productModel.ProductCategoryId = Convert.ToInt32(productcategoryid); //Convert.ToInt32(productModel.ProductCategoryid);
                            //productModel.SubCategoryId = Convert.ToInt32(subcategoryId);
                            //string DATE = dateTimeFormatModel.GetDateString();

                            ////PRODUCTINFO_IMAGE_UNIC_ID = DATE + "_" + Convert.ToInt32(productModel.ProductCategoryId) + "_" + ProductInfo_Image_Code;
                            //code = await Http.GetStringAsync(Utility.BaseUrl + "api/Product/GetProductCode");
                            ////Stream stream = file.OpenReadStream();
                            categoryName = categoryList.Find(x => x.CATEGORY_ID == item.CATEGORY_ID).CATEGORY_NAME;
                            // var path = $"{env.WebRootPath}\\images\\Products\\{categoryName}";
                            //var path = $"{env.WebRootPath}\\Images\\Products\\{categoryName}\\{code + "_" + file.Name}";
                            //bool exists = System.IO.Directory.Exists(path);
                            //if (!exists)
                            //    System.IO.Directory.CreateDirectory(path);
                            string p = "";
                            //path_withfile = $"{env.WebRootPath}\\Images\\Products\\{categoryName}\\{code +"_"+ file.Name}";
                            path_withfile = $"{env.WebRootPath}\\images\\Products\\{code + "_" + file.Name}";
                            p = env.WebRootPath;
                            saveimageurl = path_withfile.Replace(p, "");
                            ////await using FileStream fs = new(path_withfile, FileMode.Create);
                            ////await file.OpenReadStream(maxFileSize).CopyToAsync(fs);
                            //FileStream fs = File.Create(path_withfile);
                            //await stream.CopyToAsync(fs);
                            //stream.Close();
                            //fs.Close();



                            //var path1 = $"{env.WebRootPath}\\images\\Products\\{categoryName}";

                            //bool exists = System.IO.Directory.Exists(path1);
                            //if (!exists)
                            //    System.IO.Directory.CreateDirectory(path1);
                            //var path2 = $"{env.WebRootPath}\\Images\\Products\\{categoryName}\\{code + "_" + file.Name}";
                            var path2 = $"{env.WebRootPath}\\images\\Products\\{code + "_" + file.Name}";
                            await using FileStream fs = new(path2, FileMode.Create);
                            await file.OpenReadStream(maxFileSize).CopyToAsync(fs);
                            // await file.OpenReadStream(maxFileSize).CopyToAsync(fs);
                            fs.Close();
                        }
                    }
                    item.ITEM_IMAGE = saveimageurl;
                    if (longDescription != null)
                    {
                        item.LONG_DESCRIPTION = await this.longDescription.GetHTML();
                    }
                    if (applicationArea != null)
                    { item.APPLICATION_AREA = await this.applicationArea.GetHTML(); }
                    if(sewistiveness != null)
                    {
                        item.SEWSTIVENESS= await this.sewistiveness.GetHTML();
                    }
                    item.ITEM_CODE = itemCode;
                    item.OperationType = 2;
                    var data = await Http.PostJsonAsync<ItemEntity>(Utility.BaseUrl + "api/Product", item);
                    if(data.Status==true)
                    {
                        toastService.ShowSuccess("Item Updated Successfully!!!");
                    }
                    else
                    {
                        toastService.ShowError("Not Updated!  "+data.msg);
                    }


                }
                catch (Exception ex)
                {
                    toastService.ShowError(ex.Message);
                }
            }

            await GetItemList();


        }
    }
    //private async Task GetProductUnicImageId()
    //{
    //    var code = await Http.GetJsonAsync<UnicCodeModel>(Utility.BaseUrl + "api/ProductInfo/GetProductInfoImageUnicId");
    //    ProductInfo_Image_Code = Convert.ToInt64(code.Product_ImageUnicCode);
    //}
    private bool IsValidation()
    {
        bool flag = false;
        if (item.ITEM_NAME == "" || item.ITEM_NAME == string.Empty || item.ITEM_NAME == null)
        {
            toastService.ShowWarning("Item Name cannot be empty!");
            flag = true;
        }
        else if (item.CATEGORY_ID == 0)
        {
            toastService.ShowError("Please Select Category!");
            flag = true;
        }

        return flag;
    }
    private void ClearData()
    {


        item.ITEM_CODE = "";
        item.ITEM_NAME = "";
        //item.DESCRIPTION = "";
        item.PACK_SIZE = "";
        item.ITEM_PURCHASE_PRICE = 0;
        item.ITEM_SALE_PRICE = 0;
        item.VENDOR_ID = 0;
        item.UNIT_ID = 0;
        item.COLOR_ID = 0;
        item.BRAND_ID = 0;


    }
    private async Task RelatedApplicationClicked(ChangeEventArgs change)
    {
        relatedApp = new ItemApplicationAreaModel();
        relatedApp.APPLICATION_AREA = change.Value.ToString().Trim();
        relatedApp.APPLICATION_AREA_ID = itemApplicationList.Find(x => x.APPLICATION_AREA == change.Value.ToString().Trim()).APPLICATION_AREA_ID;

        SelectedRelatedApplicationList.Add(relatedApp);

    }
    private async Task Related_Item_Clicked(ChangeEventArgs change)
    {
        relatedItem = new ItemEntity();
        relatedItem.ITEM_NAME = change.Value.ToString();
        relatedItem.ITEM_ID = productList.Find(x => x.ITEM_NAME.ToString().Trim() == change.Value.ToString().Trim()).ITEM_ID;


        relatedItemList.Add(relatedItem);

    }
    public async void DeleteRelatedItem(string item)
    {
        var itemToRemove = relatedItemList.Single(r => r.ITEM_NAME == item);
        relatedItemList.Remove(itemToRemove);

        StateHasChanged();
    }

    private async void SelectItemTDS(InputFileChangeEventArgs e)
    {
        selectedFiles = e.GetMultipleFiles();
        this.StateHasChanged();
        foreach (var file in selectedFiles)
        {
            //Stream stream = file.OpenReadStream();
            var path = $"{env.WebRootPath}\\images\\File\\TDS\\{file.Name}";
            //FileStream fs = File.Create(path);
            //await stream.CopyToAsync(fs);
            //stream.Close();
            //fs.Close();
            itemTDS.Add(file.Name);
            //itemTDS.Add(path);
            selectedTDS = selectedFiles;
            selectedFiles = null;
        }
        this.StateHasChanged();
    }
    private async void SelectItemSDS(InputFileChangeEventArgs e)
    {
        selectedFiles = e.GetMultipleFiles();
        this.StateHasChanged();
        foreach (var file in selectedFiles)
        {
            //Stream stream = file.OpenReadStream();
            //var path = $"{env.WebRootPath}\\images\\File\\SDS\\{file.Name}";
            //FileStream fs = File.Create(path);
            //await stream.CopyToAsync(fs);
            //stream.Close();
            //fs.Close();
            itemSDS.Add(file.Name);
            selectedSDS = selectedFiles;
            selectedFiles = null;
        }
        this.StateHasChanged();
    }
    private async void SelectItemFlyer(InputFileChangeEventArgs e)
    {
        selectedFiles = e.GetMultipleFiles();
        this.StateHasChanged();
        foreach (var file in selectedFiles)
        {
            //Stream stream = file.OpenReadStream();
            //var path = $"{env.WebRootPath}\\images\\File\\FLAYER\\{file.Name}";

            //FileStream fs = File.Create(path);
            //await stream.CopyToAsync(fs);
            //stream.Close();
            //fs.Close();
            itemFlyer.Add(file.Name);
            selectedFlayer = selectedFiles;
            selectedFiles = null;
        }
        this.StateHasChanged();
    }

    private async void SelectItemCertification(InputFileChangeEventArgs e)
    {
        selectedFiles = e.GetMultipleFiles();
        this.StateHasChanged();
        foreach (var file in selectedFiles)
        {
            itemCertificate.Add(file.Name);
            selectedCertificate = selectedFiles;
            selectedFiles = null;
        }
        this.StateHasChanged();
    }
    private async Task LoadFiles(InputFileChangeEventArgs e)
    {
        //selectedFiles = e.GetMultipleFiles();
        isLoading = true;
        loadedFiles.Clear();
        foreach (var file in e.GetMultipleFiles())
        {
            try
            {
                loadedFiles.Add(file);
                selectedFiles = e.GetMultipleFiles();

                var trustedFileNameForFileStorage = Path.GetRandomFileName();

                //var path = Path.Combine(env.ContentRootPath,env.EnvironmentName);

                var path = Path.Combine(env.ContentRootPath + "\\wwwroot\\images\\File\\TDS", file.Name);

                //var path = $"{env.WebRootPath}\\File\\TDS\\{file.Name}";
                //var path = @"C:\Users\Administrator\Downloads\"+file.Name;
                await using FileStream fs = new(path, FileMode.Create);
                await file.OpenReadStream(maxFileSize).CopyToAsync(fs);

                itemTDS.Add(file.Name);
                selectedTDS = selectedFiles;
                selectedFiles = null;
            }
            catch (Exception ex)
            {
                //Logger.LogError("File: {Filename} Error: {Error}",
                //    file.Name, ex.Message);
            }
        }

        isLoading = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
