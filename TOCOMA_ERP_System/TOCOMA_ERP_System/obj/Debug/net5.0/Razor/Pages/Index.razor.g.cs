#pragma checksum "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0129449cf8669ee6706e4f553bf0b3d44171ff33"
// <auto-generated/>
#pragma warning disable 1591
namespace TOCOMA_ERP_System.Pages
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Index")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "p");
                __builder2.AddContent(3, "Welcome, ");
#nullable restore
#line 5 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Index.razor"
__builder2.AddContent(4, context.User.Identity.Name);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(5, "NotAuthorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::TOCOMA_ERP_System.Shared.LoginLayout>(6);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
