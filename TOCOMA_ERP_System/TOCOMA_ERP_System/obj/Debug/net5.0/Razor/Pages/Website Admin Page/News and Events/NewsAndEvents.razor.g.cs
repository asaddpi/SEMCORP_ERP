#pragma checksum "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\News and Events\NewsAndEvents.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d09975566db6fc460de186207d7c04aa4f1176e9"
// <auto-generated/>
#pragma warning disable 1591
namespace TOCOMA_ERP_System.Pages.Website_Admin_Page.News_and_Events
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
#line 6 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\News and Events\NewsAndEvents.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\News and Events\NewsAndEvents.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(WebsiteAdminLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Website/NewsAndEvents")]
    public partial class NewsAndEvents : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card text-left");
            __builder.AddAttribute(2, "style", "height:100%");
            __builder.AddMarkupContent(3, "<div class=\"card-header\"><h4>News & Events</h4></div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 16 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\News and Events\NewsAndEvents.razor"
                          item

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "style", (object)("margin-left:10px;margin-right:10px"));
            __builder.AddAttribute(9, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group row");
                __builder2.AddMarkupContent(12, "<label for=\"colFormLabel\" class=\"col-sm-2 col-form-label\">Type</label>\r\n                ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-sm-10");
                __builder2.OpenElement(15, "select");
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.OpenElement(17, "option");
                __builder2.AddContent(18, "--Type--");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                        ");
                __builder2.OpenElement(20, "option");
                __builder2.AddContent(21, "News");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                        ");
                __builder2.OpenElement(23, "option");
                __builder2.AddContent(24, "Events");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n            ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group row");
                __builder2.AddMarkupContent(28, "<label for=\"colFormLabel\" class=\"col-sm-2 col-form-label\">Title</label>\r\n                ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "col-sm-10");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "type", (object)("text"));
                __builder2.AddAttribute(33, "class", (object)("form-control"));
                __builder2.AddAttribute(34, "placeholder", (object)("News or Event Title"));
                __builder2.AddAttribute(35, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 32 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\News and Events\NewsAndEvents.razor"
                                             item.REF_PROJECT_TYPE_NAME

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(36, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => item.REF_PROJECT_TYPE_NAME = __value, item.REF_PROJECT_TYPE_NAME)))));
                __builder2.AddAttribute(37, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => item.REF_PROJECT_TYPE_NAME)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n\r\n            <br>\r\n            ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group row");
                __builder2.AddMarkupContent(41, "<label for=\"colFormLabel\" class=\"col-sm-2 col-form-label\">Description</label>\r\n                ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-sm-10");
                __builder2.OpenComponent<global::TOCOMA_ERP_System.BlazoredTextEditor>(44);
                __builder2.AddAttribute(45, "ToolbarContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(46, "select");
                    __builder3.AddAttribute(47, "class", "ql-header");
                    __builder3.OpenElement(48, "option");
                    __builder3.AddAttribute(49, "selected");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "\r\n                                ");
                    __builder3.OpenElement(51, "option");
                    __builder3.AddAttribute(52, "value", "1");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(53, "\r\n                                ");
                    __builder3.OpenElement(54, "option");
                    __builder3.AddAttribute(55, "value", "2");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(56, "\r\n                                ");
                    __builder3.OpenElement(57, "option");
                    __builder3.AddAttribute(58, "value", "3");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(59, "\r\n                                ");
                    __builder3.OpenElement(60, "option");
                    __builder3.AddAttribute(61, "value", "4");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(62, "\r\n                                ");
                    __builder3.OpenElement(63, "option");
                    __builder3.AddAttribute(64, "value", "5");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(65, "\r\n                            ");
                    __builder3.AddMarkupContent(66, @"<span class=""ql-formats""><button class=""ql-bold""></button>
                                <button class=""ql-italic""></button>
                                <button class=""ql-underline""></button>
                                <button class=""ql-strike""></button></span>
                            ");
                    __builder3.AddMarkupContent(67, "<span class=\"ql-formats\"><select class=\"ql-color\"></select>\r\n                                <select class=\"ql-background\"></select></span>\r\n                            ");
                    __builder3.AddMarkupContent(68, "<span class=\"ql-formats\"><button class=\"ql-list\" value=\"ordered\"></button>\r\n                                <button class=\"ql-list\" value=\"bullet\"></button></span>\r\n                            ");
                    __builder3.AddMarkupContent(69, "<span class=\"ql-formats\"><button class=\"ql-link\"></button></span>");
                }
                ));
                __builder2.AddAttribute(70, "EditorContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                }
                ));
                __builder2.AddComponentReferenceCapture(71, (__value) => {
#nullable restore
#line 40 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\News and Events\NewsAndEvents.razor"
                                               shortDescription = (TOCOMA_ERP_System.BlazoredTextEditor)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n            <br>\r\n            <br>\r\n            ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "form-group row");
                __builder2.AddMarkupContent(75, "<label for=\"colFormLabel\" class=\"col-sm-2 col-form-label\">Image</label>\r\n                ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "col-sm-10");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputFile>(78);
                __builder2.AddAttribute(79, "OnChange", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 78 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\News and Events\NewsAndEvents.razor"
                                          SelectItemImage

#line default
#line hidden
#nullable disable
                ))));
                __builder2.AddAttribute(80, "multiple", (object)(true));
                __builder2.CloseComponent();
#nullable restore
#line 79 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\News and Events\NewsAndEvents.razor"
                     foreach (var itmImage in itemimageUrls)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(81, "img");
                __builder2.AddAttribute(82, "src", 
#nullable restore
#line 81 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\News and Events\NewsAndEvents.razor"
                                   itmImage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 82 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\News and Events\NewsAndEvents.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n            <br>\r\n            <hr>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(84, "\r\n        <br>\r\n        <br>\r\n        ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "form-group row");
            __builder.AddMarkupContent(87, "<label for=\"colFormLabel\" class=\"col-sm-2 col-form-label\"></label>\r\n            ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "col-sm-10");
            __builder.AddMarkupContent(90, "<button class=\"btn btn-danger\" style=\"margin-right:20px;width:100px\">Cancel</button>\r\n                ");
            __builder.OpenElement(91, "button");
            __builder.AddAttribute(92, "class", "btn btn-success");
            __builder.AddAttribute(93, "style", "width:100px");
            __builder.AddAttribute(94, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\News and Events\NewsAndEvents.razor"
                                                                              SaveProduct

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 97 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\News and Events\NewsAndEvents.razor"
__builder.AddContent(95, submit);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "testbox");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "tablearea");
            __builder.OpenElement(101, "table");
            __builder.AddAttribute(102, "id", "example");
            __builder.AddAttribute(103, "class", "display");
            __builder.AddAttribute(104, "style", "width:100%");
            __builder.AddMarkupContent(105, "<thead><tr><th style=\"width:40px\"></th>\r\n                    <th style=\"width:40px\"></th>\r\n                    <td style=\"width:80%\">Project Type</td>\r\n                    <td></td></tr></thead>\r\n            ");
            __builder.OpenElement(106, "tbody");
#nullable restore
#line 122 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\News and Events\NewsAndEvents.razor"
                 if (itemList != null)
                {
                    foreach (var item in itemList)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(107, "tr");
            __builder.OpenElement(108, "td");
            __builder.AddAttribute(109, "style", "text-align:center");
            __builder.OpenElement(110, "a");
            __builder.AddAttribute(111, "style", "color:red");
            __builder.AddAttribute(112, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 127 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\News and Events\NewsAndEvents.razor"
                                                                                          () => Delete(item.REF_PROJECT_TYPE_ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(113, "<span class=\"oi oi-trash\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                            ");
            __builder.OpenElement(115, "td");
            __builder.AddAttribute(116, "style", "text-align:center");
            __builder.OpenElement(117, "a");
            __builder.AddAttribute(118, "data-toggle", "modal");
            __builder.AddAttribute(119, "data-target", ".bd-example-modal-lg");
            __builder.AddAttribute(120, "href", "#");
            __builder.AddAttribute(121, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 128 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\News and Events\NewsAndEvents.razor"
                                                                                                                                        () => EditBrand(item.REF_PROJECT_TYPE_ID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(122, "<span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                            ");
            __builder.OpenElement(124, "td");
#nullable restore
#line 129 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\News and Events\NewsAndEvents.razor"
__builder.AddContent(125, item.REF_PROJECT_TYPE_NAME);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                            ");
            __builder.OpenElement(127, "td");
            __builder.OpenElement(128, "img");
            __builder.AddAttribute(129, "src", 
#nullable restore
#line 131 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\News and Events\NewsAndEvents.razor"
                                           item.REF_PROJECT_TYPE_IMAGE

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(130, "style", "width:100px;height:100px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 134 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\News and Events\NewsAndEvents.razor"
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
#line 142 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Website Admin Page\News and Events\NewsAndEvents.razor"
       
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
