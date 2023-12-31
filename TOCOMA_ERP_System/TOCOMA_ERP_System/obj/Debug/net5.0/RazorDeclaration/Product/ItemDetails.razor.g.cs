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
#line 4 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CustomLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/ItemDetails/{ItemCode}")]
    public partial class ItemDetails : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 649 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Product\ItemDetails.razor"
       
    [Parameter]
    public string ItemCode { get; set; }
    ItemViewModel itemDetails = new ItemViewModel();
    List<string> tdslist = new List<string>();
    List<string> sdslist = new List<string>();
    List<string> videolist = new List<string>();
    protected override async Task OnInitializedAsync()
    {
        itemDetails = await Http.GetJsonAsync<ItemViewModel>(Utility.BaseUrl + "api/Product/GetItemByCode/" + ItemCode);
        if (itemDetails.ITEM_CODE != null && itemDetails.ITEM_CODE != "")
        {
            var path = $"{env.WebRootPath}\\images\\File\\ITEM_DOCUMENTS";
            string[] tdsfilelist = Directory.GetFiles(path);

            var sdspath = $"{env.WebRootPath}\\images\\File\\Certificate";
            string[] sdsfilelist = Directory.GetFiles(sdspath);

            var videoPath = $"{env.WebRootPath}\\Video";
            string[] allvideolist = Directory.GetFiles(videoPath);


            List<string> file = new List<string>();
            //itemDetails.ITEM_CODE = "100";
            foreach (var item in tdsfilelist)
            {
                if (item.Contains(itemDetails.ITEM_CODE))
                {
                    tdslist.Add(Path.GetFileName(item));
                }

            }
            //----------------
            foreach (var item in sdsfilelist)
            {
                if (item.Contains(itemDetails.ITEM_CODE))
                {
                    sdslist.Add(Path.GetFileName(item));
                }

            }
            //--------------
            foreach (var item in allvideolist)
            {
                if (item.Contains(itemDetails.ITEM_CODE))
                {
                    videolist.Add(Path.GetFileName(item));
                }

            }


        }


        //await JSRuntime.InvokeVoidAsync("openCity");

    }
    private async Task DownloadTDS(string item)
    {
        try
        {
            //var path = $"{env.WebRootPath}\\images\\File\\TDS";
            var path = "images//File//TDS";
            var fileName = item;
            //var fileURL = "https://localhost:5001/files/quote.txt";
            var fileURL = path + "//" + item;
            await JSRuntime.InvokeVoidAsync("triggerFileDownload", fileName, fileURL);
        }
        catch (Exception EX)
        {

        }

    }
    private async Task DownloadSDS(string item)
    {
        try
        {
            //var path = $"{env.WebRootPath}\\images\\File\\TDS";
            var path = "images//File//SDS";
            var fileName = item;
            //var fileURL = "https://localhost:5001/files/quote.txt";
            var fileURL = path + "//" + item;
            await JSRuntime.InvokeVoidAsync("triggerFileDownload", fileName, fileURL);
        }
        catch (Exception EX)
        {

        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
