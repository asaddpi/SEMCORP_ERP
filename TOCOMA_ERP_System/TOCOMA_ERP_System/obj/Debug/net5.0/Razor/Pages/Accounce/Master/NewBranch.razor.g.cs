#pragma checksum "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\NewBranch.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "662f7bd5572c180a8ab71b4899bdde8541768e8f"
// <auto-generated/>
#pragma warning disable 1591
namespace TOCOMA_ERP_System.Pages.Accounce.Master
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/NewBranch")]
    public partial class NewBranch : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-header");
            __builder.AddMarkupContent(6, "\r\n            NewBranch /\r\n            ");
            __builder.AddMarkupContent(7, "<a href=\"BranchList\">BranchList</a>\r\n            ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn btn-success");
            __builder.AddAttribute(10, "style", "float:right;width:100px");
            __builder.AddAttribute(11, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\NewBranch.razor"
                                                                                      SaveBranch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "Save");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n        <br>\r\n        ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(14);
            __builder.AddAttribute(15, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 17 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\NewBranch.razor"
                          branch

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "style", (object)("margin-left:10px;margin-right:10px"));
            __builder.AddAttribute(17, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group row");
                __builder2.AddMarkupContent(20, "<label for=\"colFormLabel\" class=\"col-sm-2 col-form-label\">Name</label>\r\n                ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "col-sm-10");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "type", (object)("text"));
                __builder2.AddAttribute(25, "class", (object)("form-control"));
                __builder2.AddAttribute(26, "placeholder", (object)("Enter Branch Name here..."));
                __builder2.AddAttribute(27, "style", (object)("text-transform:capitalize"));
                __builder2.AddAttribute(28, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 21 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\NewBranch.razor"
                                             branch.BRANCH_NAME

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(29, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => branch.BRANCH_NAME = __value, branch.BRANCH_NAME)))));
                __builder2.AddAttribute(30, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => branch.BRANCH_NAME)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group row");
                __builder2.AddMarkupContent(34, "<label for=\"colFormLabel\" class=\"col-sm-2 col-form-label\">Address 1</label>\r\n                ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "col-sm-10");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputTextArea>(37);
                __builder2.AddAttribute(38, "type", (object)("text"));
                __builder2.AddAttribute(39, "class", (object)("form-control"));
                __builder2.AddAttribute(40, "placeholder", (object)("Enter Address here..."));
                __builder2.AddAttribute(41, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 27 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\NewBranch.razor"
                                                 branch.BRANCH_ADD1

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(42, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => branch.BRANCH_ADD1 = __value, branch.BRANCH_ADD1)))));
                __builder2.AddAttribute(43, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => branch.BRANCH_ADD1)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group row");
                __builder2.AddMarkupContent(47, "<label for=\"colFormLabel\" class=\"col-sm-2 col-form-label\">Address 2</label>\r\n                ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "col-sm-10");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputTextArea>(50);
                __builder2.AddAttribute(51, "type", (object)("text"));
                __builder2.AddAttribute(52, "class", (object)("form-control"));
                __builder2.AddAttribute(53, "placeholder", (object)("Enter Address here..."));
                __builder2.AddAttribute(54, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 33 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\NewBranch.razor"
                                                 branch.BRANCH_ADD2

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(55, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => branch.BRANCH_ADD2 = __value, branch.BRANCH_ADD2)))));
                __builder2.AddAttribute(56, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => branch.BRANCH_ADD2)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n\r\n            ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group row");
                __builder2.AddMarkupContent(60, "<label for=\"colFormLabel\" class=\"col-sm-2 col-form-label\">Country</label>\r\n                ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "col-sm-10");
                global::__Blazor.TOCOMA_ERP_System.Pages.Accounce.Master.NewBranch.TypeInference.CreateInputSelect_0(__builder2, 63, 64, "form-control", 65, 
#nullable restore
#line 40 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\NewBranch.razor"
                                               branch.BRANCH_COUNTRY

#line default
#line hidden
#nullable disable
                , 66, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => branch.BRANCH_COUNTRY = __value, branch.BRANCH_COUNTRY)), 67, () => branch.BRANCH_COUNTRY, 68, (__builder3) => {
                    __builder3.AddMarkupContent(69, "<option>--Select Country--</option>");
#nullable restore
#line 42 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\NewBranch.razor"
                         foreach (var item in countryList)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(70, "option");
                    __builder3.AddAttribute(71, "value", 
#nullable restore
#line 44 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\NewBranch.razor"
                                            item.COUNTRY_NAME

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 44 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\NewBranch.razor"
__builder3.AddContent(72, item.COUNTRY_NAME);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 45 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\NewBranch.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n            ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-group row");
                __builder2.AddMarkupContent(76, "<label for=\"colFormLabel\" class=\"col-sm-2 col-form-label\">Phone</label>\r\n                ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "col-sm-10");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputTextArea>(79);
                __builder2.AddAttribute(80, "type", (object)("text"));
                __builder2.AddAttribute(81, "class", (object)("form-control"));
                __builder2.AddAttribute(82, "placeholder", (object)("Enter Address here..."));
                __builder2.AddAttribute(83, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 53 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\NewBranch.razor"
                                                 branch.BRANCH_ADD2

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(84, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => branch.BRANCH_ADD2 = __value, branch.BRANCH_ADD2)))));
                __builder2.AddAttribute(85, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => branch.BRANCH_ADD2)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n            ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "form-group row");
                __builder2.AddMarkupContent(89, "<label for=\"colFormLabel\" class=\"col-sm-2 col-form-label\">Fax</label>\r\n                ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "col-sm-10");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputTextArea>(92);
                __builder2.AddAttribute(93, "type", (object)("text"));
                __builder2.AddAttribute(94, "class", (object)("form-control"));
                __builder2.AddAttribute(95, "placeholder", (object)("Enter Address here..."));
                __builder2.AddAttribute(96, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 59 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\NewBranch.razor"
                                                 branch.BRANCH_ADD2

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(97, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => branch.BRANCH_ADD2 = __value, branch.BRANCH_ADD2)))));
                __builder2.AddAttribute(98, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => branch.BRANCH_ADD2)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n            ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "form-group row");
                __builder2.AddMarkupContent(102, "<label for=\"colFormLabel\" class=\"col-sm-2 col-form-label\">Email</label>\r\n                ");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "col-sm-10");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputTextArea>(105);
                __builder2.AddAttribute(106, "type", (object)("text"));
                __builder2.AddAttribute(107, "class", (object)("form-control"));
                __builder2.AddAttribute(108, "placeholder", (object)("Enter Address here..."));
                __builder2.AddAttribute(109, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 65 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\NewBranch.razor"
                                                 branch.BRANCH_ADD2

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(110, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => branch.BRANCH_ADD2 = __value, branch.BRANCH_ADD2)))));
                __builder2.AddAttribute(111, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => branch.BRANCH_ADD2)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n            ");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "form-group row");
                __builder2.AddMarkupContent(115, "<label for=\"colFormLabel\" class=\"col-sm-2 col-form-label\">Location</label>\r\n                ");
                __builder2.OpenElement(116, "div");
                __builder2.AddAttribute(117, "class", "col-sm-10");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputTextArea>(118);
                __builder2.AddAttribute(119, "type", (object)("text"));
                __builder2.AddAttribute(120, "class", (object)("form-control"));
                __builder2.AddAttribute(121, "placeholder", (object)("Enter Address here..."));
                __builder2.AddAttribute(122, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 71 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\NewBranch.razor"
                                                 branch.BRANCH_ADD2

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(123, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => branch.BRANCH_ADD2 = __value, branch.BRANCH_ADD2)))));
                __builder2.AddAttribute(124, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => branch.BRANCH_ADD2)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n            ");
                __builder2.OpenElement(126, "div");
                __builder2.AddAttribute(127, "class", "form-group row");
                __builder2.AddMarkupContent(128, "<label for=\"colFormLabel\" class=\"col-sm-2 col-form-label\">Default Branch</label>\r\n                ");
                __builder2.OpenElement(129, "div");
                __builder2.AddAttribute(130, "class", "col-sm-10");
                global::__Blazor.TOCOMA_ERP_System.Pages.Accounce.Master.NewBranch.TypeInference.CreateInputSelect_1(__builder2, 131, 132, "form-control", 133, 
#nullable restore
#line 77 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\NewBranch.razor"
                                               branch.BRANCH_STATUS

#line default
#line hidden
#nullable disable
                , 134, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => branch.BRANCH_STATUS = __value, branch.BRANCH_STATUS)), 135, () => branch.BRANCH_STATUS, 136, (__builder3) => {
                    __builder3.AddMarkupContent(137, "<option></option>\r\n                        ");
                    __builder3.AddMarkupContent(138, "<option value=\"0\">No</option>\r\n                        ");
                    __builder3.AddMarkupContent(139, "<option value=\"1\">Yes</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n            ");
                __builder2.OpenElement(141, "div");
                __builder2.AddAttribute(142, "class", "form-group row");
                __builder2.AddMarkupContent(143, "<label for=\"colFormLabel\" class=\"col-sm-2 col-form-label\">InActive</label>\r\n                ");
                __builder2.OpenElement(144, "div");
                __builder2.AddAttribute(145, "class", "col-sm-10");
                global::__Blazor.TOCOMA_ERP_System.Pages.Accounce.Master.NewBranch.TypeInference.CreateInputSelect_2(__builder2, 146, 147, "form-control", 148, 
#nullable restore
#line 87 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\NewBranch.razor"
                                               branch.BRANCH_ACTIVE

#line default
#line hidden
#nullable disable
                , 149, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => branch.BRANCH_ACTIVE = __value, branch.BRANCH_ACTIVE)), 150, () => branch.BRANCH_ACTIVE, 151, (__builder3) => {
                    __builder3.AddMarkupContent(152, "<option></option>\r\n                        ");
                    __builder3.AddMarkupContent(153, "<option value=\"0\">No</option>\r\n                        ");
                    __builder3.AddMarkupContent(154, "<option value=\"1\">Yes</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(155, "\r\n            ");
                __builder2.OpenElement(156, "div");
                __builder2.AddAttribute(157, "class", "form-group row");
                __builder2.AddMarkupContent(158, "<label for=\"colFormLabel\" class=\"col-sm-2 col-form-label\">Comments</label>\r\n                ");
                __builder2.OpenElement(159, "div");
                __builder2.AddAttribute(160, "class", "col-sm-10");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputTextArea>(161);
                __builder2.AddAttribute(162, "type", (object)("text"));
                __builder2.AddAttribute(163, "class", (object)("form-control"));
                __builder2.AddAttribute(164, "placeholder", (object)("Enter Comments Name here..."));
                __builder2.AddAttribute(165, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 97 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\NewBranch.razor"
                                                 branch.BRANCH_COMMENTS

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(166, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => branch.BRANCH_COMMENTS = __value, branch.BRANCH_COMMENTS)))));
                __builder2.AddAttribute(167, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => branch.BRANCH_COMMENTS)));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "D:\SEMCORP\TOCOMA_ERP_System\TOCOMA_ERP_System\Pages\Accounce\Master\NewBranch.razor"
       
    BranchModel branch = new BranchModel();
    List<CountryModel> countryList = new List<CountryModel>();
    protected override async Task OnInitializedAsync()
    {
        await GetCountry();
    }
    private async Task GetCountry()
    {
        countryList = await Http.GetJsonAsync<List<CountryModel>>(Utility.BaseUrl + "api/Setup/GetCountry");
    }
    public async Task SaveBranch()
    {
        if (IsValidation() != true)
        {
            try
            {
                var data = await Http.PostJsonAsync<BranchModel>(Utility.BaseUrl + "api/Setup/AddBranch", branch);
                toastService.ShowSuccess("Item Added Successfully!!!");
            }
            catch (Exception ex)
            {

            }
        }
    }
    private bool IsValidation()
    {
        bool flag = false;
        if (branch.BRANCH_NAME == "" || branch.BRANCH_NAME == string.Empty || branch.BRANCH_NAME == null)
        {
            toastService.ShowWarning("Branch Name cannot be empty!");
            flag = true;
        }
        else if (branch.BRANCH_COUNTRY == "")
        {
            toastService.ShowError("Please Select Country!");
            flag = true;
        }

        return flag;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
    }
}
namespace __Blazor.TOCOMA_ERP_System.Pages.Accounce.Master.NewBranch
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
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", (object)__arg0);
        __builder.AddAttribute(__seq1, "Value", (object)__arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", (object)__arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", (object)__arg3);
        __builder.AddAttribute(__seq4, "ChildContent", (object)__arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
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
