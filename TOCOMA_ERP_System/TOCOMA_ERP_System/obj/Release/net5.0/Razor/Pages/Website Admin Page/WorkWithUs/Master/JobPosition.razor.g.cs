#pragma checksum "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\WorkWithUs\Master\JobPosition.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aae7b05ff72c68c873268ca2822209f62ed4bcc1"
// <auto-generated/>
#pragma warning disable 1591
namespace TOCOMA_ERP_System.Pages.Website_Admin_Page.WorkWithUs.Master
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
#nullable restore
#line 6 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\WorkWithUs\Master\JobPosition.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\WorkWithUs\Master\JobPosition.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebsiteAdminLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Website/JobPosition")]
    public partial class JobPosition : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card text-left");
            __builder.AddAttribute(2, "style", "height:100%");
            __builder.AddMarkupContent(3, "<div class=\"card-header\"><h4>New Job Position</h4></div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\WorkWithUs\Master\JobPosition.razor"
                          item

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "style", "margin-left:10px;margin-right:10px");
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group row");
                __builder2.AddMarkupContent(12, "<label for=\"colFormLabel\" class=\"col-sm-2 col-form-label\">Job Position</label>\r\n                ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "type", "text");
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "placeholder", "project name");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\WorkWithUs\Master\JobPosition.razor"
                                             item.REF_PROJECT_TYPE_NAME

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.REF_PROJECT_TYPE_NAME = __value, item.REF_PROJECT_TYPE_NAME))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => item.REF_PROJECT_TYPE_NAME));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n        <br>\r\n        <br>\r\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-group row");
            __builder.AddMarkupContent(25, "<label for=\"colFormLabel\" class=\"col-sm-2 col-form-label\"></label>\r\n            ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-sm-10");
            __builder.AddMarkupContent(28, "<button class=\"btn btn-danger\" style=\"margin-right:20px;width:100px\">Cancel</button>\r\n                ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "btn btn-success");
            __builder.AddAttribute(31, "style", "width:100px");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\WorkWithUs\Master\JobPosition.razor"
                                                                              SaveProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, 
#nullable restore
#line 32 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\WorkWithUs\Master\JobPosition.razor"
                                                                                            submit

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "testbox");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "tablearea");
            __builder.OpenElement(39, "table");
            __builder.AddAttribute(40, "id", "example");
            __builder.AddAttribute(41, "class", "display");
            __builder.AddAttribute(42, "style", "width:100%");
            __builder.AddMarkupContent(43, "<thead><tr><th style=\"width:40px\"></th>\r\n                    <th style=\"width:40px\"></th>\r\n                    <td style=\"width:80%\">Job Position</td>\r\n                    <td></td></tr></thead>\r\n            ");
            __builder.OpenElement(44, "tbody");
#nullable restore
#line 52 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\WorkWithUs\Master\JobPosition.razor"
                 if (itemList != null)
                {
                    foreach (var item in itemList)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(45, "tr");
            __builder.OpenElement(46, "td");
            __builder.AddAttribute(47, "style", "text-align:center");
            __builder.OpenElement(48, "a");
            __builder.AddAttribute(49, "style", "color:red");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\WorkWithUs\Master\JobPosition.razor"
                                                                                          () => Delete(item.REF_PROJECT_TYPE_ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(51, "<span class=\"oi oi-trash\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                            ");
            __builder.OpenElement(53, "td");
            __builder.AddAttribute(54, "style", "text-align:center");
            __builder.OpenElement(55, "a");
            __builder.AddAttribute(56, "data-toggle", "modal");
            __builder.AddAttribute(57, "data-target", ".bd-example-modal-lg");
            __builder.AddAttribute(58, "href", "#");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\WorkWithUs\Master\JobPosition.razor"
                                                                                                                                        () => EditBrand(item.REF_PROJECT_TYPE_ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(60, "<span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                            ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 59 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\WorkWithUs\Master\JobPosition.razor"
                                 item.REF_PROJECT_TYPE_NAME

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                            ");
            __builder.OpenElement(65, "td");
            __builder.OpenElement(66, "img");
            __builder.AddAttribute(67, "src", 
#nullable restore
#line 61 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\WorkWithUs\Master\JobPosition.razor"
                                           item.REF_PROJECT_TYPE_IMAGE

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(68, "style", "width:100px;height:100px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\WorkWithUs\Master\JobPosition.razor"
                    }
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
#line 72 "D:\Project\Company All Project\SEMCORP\Solution\TOCOMA_ERP_System\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\WorkWithUs\Master\JobPosition.razor"
       
    BlazoredTextEditor shortDescription;
    BlazoredTextEditor longDescription;
    string itemname = "";
    List<string> itemimageUrls = new List<string>();
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
    IReadOnlyList<IBrowserFile> selectedItemImage;
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
        await GetBrand();
        StateHasChanged();
        await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#example");

    }
    private async Task GetBrand()
    {
        itemList = await Http.GetJsonAsync<List<ReferenceProjectTypeModel>>(Utility.BaseUrl + "api/ReferenceProject/GetReferenceProjectType");
    }

    private async Task SelectItemImage(InputFileChangeEventArgs e)
    {
        selectedItemImage = e.GetMultipleFiles();

        foreach (var imageFile in selectedItemImage)
        {
            //var resizedImage = await imageFile.RequestImageFileAsync("image/jpg", 100, 100);
            var resizedImage = await imageFile.RequestImageFileAsync(imageFile.ContentType, 100, 100);
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
    public async Task SaveProduct()
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

                    if (selectedItemImage != null)
                    {
                        foreach (var file in selectedItemImage)
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
                    await GetBrand();
                }
                catch (Exception ex)
                {
                    toastService.ShowError(ex.Message);
                }
            }
        }
    }



    async Task Upload1()
    {
        //var url = "http://localhost/api/v1/yourendpointhere";
        var filePath = @"C:\inetpub\wwwroot\tocoma_erp_system\wwwroot\images\Products\0042_WhatsApp Image 2022-07-03 at 10.20.37 AM.jpeg";
        var url = "http://demo.tocoma.co/webroot/Content/images/aboutus";
        foreach (var file in selectedItemImage)
        {
            //string path = Path.Combine(file.Name);
            //var filePath = Path.Combine(file.Name);
            //var filePath = Path.GetFullPath("wwwroot\\Images\\") + file.FileInfo.Name;
            //var filePath = $"{env.WebRootPath}\\{file.Name}";
            HttpClient httpClient = new HttpClient();
            MultipartFormDataContent form = new MultipartFormDataContent();

            FileStream fs = File.OpenRead(filePath);
            var streamContent = new StreamContent(fs);

            var imageContent = new ByteArrayContent(streamContent.ReadAsByteArrayAsync().Result);
            imageContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");

            form.Add(imageContent, "image", Path.GetFileName(filePath));
            var response = httpClient.PostAsync(url, form).Result;


            var content = new MultipartFormDataContent();

            form.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data");
            form.Add(new StreamContent(fileStream, (int)fileStream.Length), "image", file.Name);
            //var response = await Http.PostAsync($"{url}/Partners/SaveImage", content);
            var response1 = await Http.PostAsync($"{url}", form);
        }


    }


    async Task UploadFileAsync()
    {

        string url = "http://demo.tocoma.co";
        foreach (var file in selectedItemImage)
        {

            var root = "\\demo.tocoma.co";
            var folder = @"\webroot\Content\images\aboutus";

            string path = Path.Combine(root, folder, file.Name);


            await using FileStream fs = new(path, FileMode.Create); //This line throws the error
            await file.OpenReadStream(maxFileSize).CopyToAsync(fs);



            //var path2 = $"{url}\\webroot\\Content\\images\\aboutus\\{code + "_" + file.Name}";
            var path2 = $"{url}/webroot/Content/images/aboutus/{code + "_" + file.Name}";
            await using FileStream fs1 = new(path2, FileMode.Create);
            await file.OpenReadStream(maxFileSize).CopyToAsync(fs1);
            // await file.OpenReadStream(maxFileSize).CopyToAsync(fs);
            fs1.Close();
        }




        var content = new MultipartFormDataContent();

        content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data");
        content.Add(new StreamContent(fileStream, (int)fileStream.Length), "image", fileName);
        //var response = await Http.PostAsync($"{url}/Partners/SaveImage", content);
        var response = await Http.PostAsync($"{url}/webroot/Content/images/aboutus", content);
    }


    private bool IsValidation()
    {
        bool flag = false;
        if (item.REF_PROJECT_TYPE_NAME == "" || item.REF_PROJECT_TYPE_NAME == string.Empty || item.REF_PROJECT_TYPE_NAME == null)
        {
            toastService.ShowWarning("Type Name cannot be empty!");
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
        await GetBrand();
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
