// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TOCOMA_ERP_System.Pages.Website_Admin_Page.OurClient
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
#line 6 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\OurClient\ClientDetails.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\OurClient\ClientDetails.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebsiteAdminLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Website/ClientDetails")]
    public partial class ClientDetails : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 526 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\OurClient\ClientDetails.razor"
       
    List<clsClientProjectSectorType> clientProjuctSectorTypeList = new List<clsClientProjectSectorType>();
    clsClientDetails clientDetails = new clsClientDetails();
    //---------
    BlazoredTextEditor shortDescription;
    BlazoredTextEditor longDescription;
    BlazoredTextEditor clientDetailsInfo;
    BlazoredTextEditor projectDetailsInfo;
    BlazoredTextEditor faceProblemDetails;
    BlazoredTextEditor tocomaSolutionsDetails;
    string itemname = "";
    List<string> itemimageUrls = new List<string>();
    List<string> clientLogoUrls = new List<string>();
    List<string> projectimageUrls = new List<string>();
    List<string> tocomaSolutionImageUrls = new List<string>();
    List<string> itemtdsUrls = new List<string>();
    List<string> itemimage = new List<string>();
    List<string> itemTDS = new List<string>();
    List<string> itemSDS = new List<string>();
    List<string> itemFlyer = new List<string>();
    List<string> itemCertificate = new List<string>();
    List<string> ApplicationimageUrls = new List<string>();
    List<ItemEntity> productList = new List<ItemEntity>();
    List<ItemCategory> categoryList = new List<ItemCategory>();
    IReadOnlyList<IBrowserFile> selectedFiles;
    IReadOnlyList<IBrowserFile> selectedBannerImage;
    IReadOnlyList<IBrowserFile> selectedClientLogo;
    IReadOnlyList<IBrowserFile> selectedprojectImage;
    IReadOnlyList<IBrowserFile> selectedsolutionImage;
    IReadOnlyList<IBrowserFile> selectedTDS;
    IReadOnlyList<IBrowserFile> selectedSDS;
    IReadOnlyList<IBrowserFile> selectedFlayer;
    IReadOnlyList<IBrowserFile> selectedCertificate;
    ReferenceProjectTypeModel item = new ReferenceProjectTypeModel();
    ItemEntity relatedItem = new ItemEntity();

    List<ReferenceProjectTypeModel> itemList = new List<ReferenceProjectTypeModel>();


    List<ImageFile> filesBase64 = new List<ImageFile>();
    string categoryName;
    string code;
    string path_withfile = "";
    string saveimageurl = "";
    string savelogourl = "";

    private List<IBrowserFile> loadedFiles = new();
    private long maxFileSize = 1024 * 5000;
    private int maxAllowedFiles = 3;
    private bool isLoading;
    // ImageFile.cs


    Stream fileStream = null;
    ElementReference elementReference;
    string fileName = string.Empty;
    string size = string.Empty;
    string type = string.Empty;
    string submit = "Save";

    public class ImageFile
    {
        public string base64data { get; set; }
        public string contentType { get; set; }
        public string fileName { get; set; }
    }
    protected override async Task OnInitializedAsync()
    {
        await GetClientSector();
        StateHasChanged();
        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");

    }
    private async Task GetClientSector()
    {
        clientProjuctSectorTypeList = await Http.GetJsonAsync<List<clsClientProjectSectorType>>(Utility.BaseUrl + "api/OurClient/GetClientProjectSectorType");
    }

    private async Task SelectBannerImage(InputFileChangeEventArgs e)
    {
        selectedBannerImage = e.GetMultipleFiles();

        foreach (var imageFile in selectedBannerImage)
        {
            //var resizedImage = await imageFile.RequestImageFileAsync("image/jpg", 100, 100);
            var resizedImage = await imageFile.RequestImageFileAsync(imageFile.ContentType, 10000, 10000);
            var buffer = new byte[resizedImage.Size];
            await resizedImage.OpenReadStream().ReadAsync(buffer);
            //var imgData = $"data:image/jpg;base64,{Convert.ToBase64String(buffer)}";
            var imgData = $"data:image/jpg;base64,{Convert.ToBase64String(buffer)}";
            itemimageUrls.Add(imgData);

            //

            //string base64String = "";
            //await using MemoryStream fs = new MemoryStream();
            //await imageFile.OpenReadStream(maxAllowedSize: 104857645125).CopyToAsync(fs);
            //byte[] somBytes = GetBytes(fs);
            //base64String = Convert.ToBase64String(somBytes, 0, somBytes.Length);
            //System.Diagnostics.Debug.Print("Imatge 64: " + base64String + Environment.NewLine);
            //itemimageUrls.Add(base64String);
        }

        this.StateHasChanged();
    }
    private void CancelBannerImage(string file)
    {
        int index = itemimageUrls.IndexOf(file);
        itemimageUrls.RemoveAt(index);
    }
    private async Task ClientLogo(InputFileChangeEventArgs e)
    {
        selectedClientLogo = e.GetMultipleFiles();

        foreach (var imageFile in selectedClientLogo)
        {
            //var resizedImage = await imageFile.RequestImageFileAsync("image/jpg", 100, 100);
            var resizedImage = await imageFile.RequestImageFileAsync(imageFile.ContentType, 10000, 10000);
            var buffer = new byte[resizedImage.Size];
            await resizedImage.OpenReadStream().ReadAsync(buffer);
            //var imgData = $"data:image/jpg;base64,{Convert.ToBase64String(buffer)}";
            var imgData = $"data:image/jpg;base64,{Convert.ToBase64String(buffer)}";
            clientLogoUrls.Add(imgData);

        }

        this.StateHasChanged();
    }
    private async Task SelectProjectImage(InputFileChangeEventArgs e)
    {
        selectedprojectImage = e.GetMultipleFiles();

        foreach (var imageFile in selectedprojectImage)
        {
            //var resizedImage = await imageFile.RequestImageFileAsync("image/jpg", 100, 100);
            var resizedImage = await imageFile.RequestImageFileAsync(imageFile.ContentType, 10000, 10000);
            var buffer = new byte[resizedImage.Size];
            await resizedImage.OpenReadStream().ReadAsync(buffer);
            //var imgData = $"data:image/jpg;base64,{Convert.ToBase64String(buffer)}";
            var imgData = $"data:image/jpg;base64,{Convert.ToBase64String(buffer)}";
            projectimageUrls.Add(imgData);

            //

            //string base64String = "";
            //await using MemoryStream fs = new MemoryStream();
            //await imageFile.OpenReadStream(maxAllowedSize: 104857645125).CopyToAsync(fs);
            //byte[] somBytes = GetBytes(fs);
            //base64String = Convert.ToBase64String(somBytes, 0, somBytes.Length);
            //System.Diagnostics.Debug.Print("Imatge 64: " + base64String + Environment.NewLine);
            //itemimageUrls.Add(base64String);
        }

        this.StateHasChanged();
    }
    private async Task TocomaSolution_Image(InputFileChangeEventArgs e)
    {
        selectedsolutionImage = e.GetMultipleFiles();

        foreach (var imageFile in selectedsolutionImage)
        {
            //var resizedImage = await imageFile.RequestImageFileAsync("image/jpg", 100, 100);
            var resizedImage = await imageFile.RequestImageFileAsync(imageFile.ContentType, 10000, 10000);
            var buffer = new byte[resizedImage.Size];
            await resizedImage.OpenReadStream().ReadAsync(buffer);
            //var imgData = $"data:image/jpg;base64,{Convert.ToBase64String(buffer)}";
            var imgData = $"data:image/jpg;base64,{Convert.ToBase64String(buffer)}";
            tocomaSolutionImageUrls.Add(imgData);

            //

            //string base64String = "";
            //await using MemoryStream fs = new MemoryStream();
            //await imageFile.OpenReadStream(maxAllowedSize: 104857645125).CopyToAsync(fs);
            //byte[] somBytes = GetBytes(fs);
            //base64String = Convert.ToBase64String(somBytes, 0, somBytes.Length);
            //System.Diagnostics.Debug.Print("Imatge 64: " + base64String + Environment.NewLine);
            //itemimageUrls.Add(base64String);
        }

        this.StateHasChanged();
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
    public static byte[] GetBytes(Stream stream)
    {
        var bytes = new byte[stream.Length];
        stream.Seek(0, SeekOrigin.Begin);
        stream.ReadAsync(bytes, 0, bytes.Length);
        stream.Dispose();
        return bytes;
    }
    public async Task SaveClientDetails()
    {
        //string url = "https://localhost:44381/";
        //EmployeeModel empModel = new EmployeeModel();
        //empModel.EMPLOYEE_NAME = itemimageUrls.FirstOrDefault();
        ///var response = await Http.PostAsync($"{url}/Partners/SaveImage", content);
        //var response = await Http.PostJsonAsync<EmployeeModel>($"{url}/Partners/SaveImage", empModel);
        if (IsValidation() != true)
        {

            //bool IsExistProduct = await Http.GetJsonAsync<bool>(Utility.BaseUrl + "api/ReferenceProjectType/GetIsItemExist/" + item.REF_PROJECT_TYPE_NAME);
            //if (IsExistProduct != true)
            //{
            try
            {
                if (selectedBannerImage != null)
                {
                    foreach (var file in selectedBannerImage)
                    {
                        string code = GetCode();
                        string p = "";
                        path_withfile = $"{env.WebRootPath}\\images\\OurClient\\{code + "_" + file.Name}";
                        p = env.WebRootPath;
                        saveimageurl = path_withfile.Replace(p, "");
                        var path2 = $"{env.WebRootPath}\\images\\OurClient\\{code + "_" + file.Name}";
                        await using FileStream fs = new(path2, FileMode.Create);
                        await file.OpenReadStream(maxFileSize).CopyToAsync(fs);
                        fs.Close();
                    }
                }
                if (selectedClientLogo != null)
                {
                    foreach (var file in selectedClientLogo)
                    {
                        string code = GetCode();
                        string p = "";
                        path_withfile = $"{env.WebRootPath}\\images\\OurClient\\{code + "_" + file.Name}";
                        p = env.WebRootPath;
                        savelogourl = path_withfile.Replace(p, "");
                        var path2 = $"{env.WebRootPath}\\images\\OurClient\\{code + "_" + file.Name}";
                        await using FileStream fs = new(path2, FileMode.Create);
                        await file.OpenReadStream(maxFileSize).CopyToAsync(fs);
                        fs.Close();
                    }
                }
                clientDetails.BANNER_IMAGE_LINK = saveimageurl;
                clientDetails.CLIENT_LOGO = savelogourl;
                if (clientDetailsInfo != null)
                { clientDetails.DESCRIPTION = await this.clientDetailsInfo.GetHTML(); }
                clientDetails.OPERATION_TYPE = "1";


                var data = await Http.PostJsonAsync<clsClientDetails>(Utility.BaseUrl + "api/OurClient/AddClientDetails", clientDetails);


                toastService.ShowSuccess(" Save Successfully!!!");
                ClearData();
                //await GetBrand();
            }
            catch (Exception ex)
            {
                toastService.ShowError(ex.Message);
            }
            //}
        }
    }
    public string GetCode()
    {
        string code = "";
        Random random = new Random();
        int num = random.Next(1000);
        int minut = System.DateTime.Now.Minute;
        int second = System.DateTime.Now.Second;
        code = Convert.ToString(num + minut + second);
        return code;
    }
    public async Task SaveProjectDetails()
    {
        //string url = "https://localhost:44381/";
        //EmployeeModel empModel = new EmployeeModel();
        //empModel.EMPLOYEE_NAME = itemimageUrls.FirstOrDefault();
        ///var response = await Http.PostAsync($"{url}/Partners/SaveImage", content);
        //var response = await Http.PostJsonAsync<EmployeeModel>($"{url}/Partners/SaveImage", empModel);
        if (IsValidation() != true)
        {

            bool IsExistProduct = await Http.GetJsonAsync<bool>(Utility.BaseUrl + "api/ReferenceProjectType/GetIsItemExist/" + item.REF_PROJECT_TYPE_NAME);
            if (IsExistProduct != true)
            {
                try
                {

                    if (selectedprojectImage != null)
                    {
                        foreach (var file in selectedprojectImage)
                        {
                            string p = "";
                            path_withfile = $"{env.WebRootPath}\\images\\WebsiteImage\\ProjectType\\{code + "_" + file.Name}";
                            p = env.WebRootPath;
                            saveimageurl = path_withfile.Replace(p, "");
                            var path2 = $"{env.WebRootPath}\\images\\WebsiteImage\\ProjectType\\{code + "_" + file.Name}";
                            await using FileStream fs = new(path2, FileMode.Create);
                            await file.OpenReadStream(maxFileSize).CopyToAsync(fs);
                            fs.Close();
                        }
                    }
                    item.REF_PROJECT_TYPE_IMAGE = saveimageurl;
                    item.OPERATION_TYPE = 1;


                    var data = await Http.PostJsonAsync<ReferenceProjectTypeModel>(Utility.BaseUrl + "api/ReferenceProjectType", item);


                    toastService.ShowSuccess(" Save Successfully!!!");
                    ClearData();
                    //await GetBrand();
                }
                catch (Exception ex)
                {
                    toastService.ShowError(ex.Message);
                }
            }
        }
    }

    public async Task SaveTocomaSolution()
    {
        //string url = "https://localhost:44381/";
        //EmployeeModel empModel = new EmployeeModel();
        //empModel.EMPLOYEE_NAME = itemimageUrls.FirstOrDefault();
        ///var response = await Http.PostAsync($"{url}/Partners/SaveImage", content);
        //var response = await Http.PostJsonAsync<EmployeeModel>($"{url}/Partners/SaveImage", empModel);
        if (IsValidation() != true)
        {

            bool IsExistProduct = await Http.GetJsonAsync<bool>(Utility.BaseUrl + "api/ReferenceProjectType/GetIsItemExist/" + item.REF_PROJECT_TYPE_NAME);
            if (IsExistProduct != true)
            {
                try
                {

                    if (selectedsolutionImage != null)
                    {
                        foreach (var file in selectedsolutionImage)
                        {
                            string p = "";
                            path_withfile = $"{env.WebRootPath}\\images\\WebsiteImage\\ProjectType\\{code + "_" + file.Name}";
                            p = env.WebRootPath;
                            saveimageurl = path_withfile.Replace(p, "");
                            var path2 = $"{env.WebRootPath}\\images\\WebsiteImage\\ProjectType\\{code + "_" + file.Name}";
                            await using FileStream fs = new(path2, FileMode.Create);
                            await file.OpenReadStream(maxFileSize).CopyToAsync(fs);
                            fs.Close();
                        }
                    }
                    item.REF_PROJECT_TYPE_IMAGE = saveimageurl;
                    item.OPERATION_TYPE = 1;


                    var data = await Http.PostJsonAsync<ReferenceProjectTypeModel>(Utility.BaseUrl + "api/ReferenceProjectType", item);


                    toastService.ShowSuccess(" Save Successfully!!!");
                    ClearData();
                    //await GetBrand();
                }
                catch (Exception ex)
                {
                    toastService.ShowError(ex.Message);
                }
            }
        }
    }



    //async Task Upload1()
    //{
    //    //var url = "http://localhost/api/v1/yourendpointhere";
    //    var filePath = @"C:\inetpub\wwwroot\tocoma_erp_system\wwwroot\images\Products\0042_WhatsApp Image 2022-07-03 at 10.20.37 AM.jpeg";
    //    var url = "http://demo.tocoma.co/webroot/Content/images/aboutus";
    //    foreach (var file in selectedItemImage)
    //    {
    //        //string path = Path.Combine(file.Name);
    //        //var filePath = Path.Combine(file.Name);
    //        //var filePath = Path.GetFullPath("wwwroot\\Images\\") + file.FileInfo.Name;
    //        //var filePath = $"{env.WebRootPath}\\{file.Name}";
    //        HttpClient httpClient = new HttpClient();
    //        MultipartFormDataContent form = new MultipartFormDataContent();

    //        FileStream fs = File.OpenRead(filePath);
    //        var streamContent = new StreamContent(fs);

    //        var imageContent = new ByteArrayContent(streamContent.ReadAsByteArrayAsync().Result);
    //        imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");

    //        form.Add(imageContent, "image", Path.GetFileName(filePath));
    //        var response = httpClient.PostAsync(url, form).Result;


    //        var content = new MultipartFormDataContent();

    //        form.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data");
    //        form.Add(new StreamContent(fileStream, (int)fileStream.Length), "image", file.Name);
    //        //var response = await Http.PostAsync($"{url}/Partners/SaveImage", content);
    //        var response1 = await Http.PostAsync($"{url}", form);
    //    }


    //}


    //async Task UploadFileAsync()
    //{

    //    string url = "http://demo.tocoma.co";
    //    foreach (var file in selectedItemImage)
    //    {

    //        var root = "\\demo.tocoma.co";
    //        var folder = @"\webroot\Content\images\aboutus";

    //        string path = Path.Combine(root, folder, file.Name);


    //        await using FileStream fs = new(path, FileMode.Create); //This line throws the error
    //        await file.OpenReadStream(maxFileSize).CopyToAsync(fs);



    //        //var path2 = $"{url}\\webroot\\Content\\images\\aboutus\\{code + "_" + file.Name}";
    //        var path2 = $"{url}/webroot/Content/images/aboutus/{code + "_" + file.Name}";
    //        await using FileStream fs1 = new(path2, FileMode.Create);
    //        await file.OpenReadStream(maxFileSize).CopyToAsync(fs1);
    //        // await file.OpenReadStream(maxFileSize).CopyToAsync(fs);
    //        fs1.Close();
    //    }




    //    var content = new MultipartFormDataContent();

    //    content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data");
    //    content.Add(new StreamContent(fileStream, (int)fileStream.Length), "image", fileName);
    //    //var response = await Http.PostAsync($"{url}/Partners/SaveImage", content);
    //    var response = await Http.PostAsync($"{url}/webroot/Content/images/aboutus", content);
    //}


    private bool IsValidation()
    {
        bool flag = false;
        if (clientDetails.CLIENT_NAME == "" || clientDetails.CLIENT_NAME == string.Empty || clientDetails.CLIENT_NAME == null)
        {
            toastService.ShowWarning("Client Name cannot be empty!");
            flag = true;
        }


        return flag;
    }
    private void ClearData()
    {
        item.REF_PROJECT_TYPE_NAME = "";
        itemimageUrls = new List<string>();
        item = new ReferenceProjectTypeModel();

        StateHasChanged();
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
    private async Task Delete(int Id)
    {

        if (!await JSRuntime.InvokeAsync<bool>("confirm", $"Are you sure you want to delete ?"))
            return;

        await Http.DeleteAsync(Utility.BaseUrl + "api/ReferenceProjectType/DeleteRefProjectType/" + Id);
        //await GetBrand();
    }
    private async Task EditBrand(int Id)
    {
        submit = "Update";
        item = new ReferenceProjectTypeModel();
        item.REF_PROJECT_TYPE_NAME = itemList.Find(x => x.REF_PROJECT_TYPE_ID == Id).REF_PROJECT_TYPE_NAME;
        item.REF_PROJECT_TYPE_ID = Id;
        item.OPERATION_TYPE = 2;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
