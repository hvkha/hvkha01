#pragma checksum "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\Pages\AnPhuocList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2c7484ffe434b24cba15fe7a5b240c89fc5e844"
// <auto-generated/>
#pragma warning disable 1591
namespace AnPhuocShop.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using AnPhuocShop.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\_Imports.razor"
using AnPhuocShop.Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class AnPhuocList : AnPhuocListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-deck");
#nullable restore
#line 4 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\Pages\AnPhuocList.razor"
     foreach (var anphuoc in AnPhuocs)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card m-3");
            __builder.AddAttribute(4, "style", "min-width:18rem; max-width:30%;");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-header");
            __builder.OpenElement(7, "h5");
            __builder.AddContent(8, 
#nullable restore
#line 9 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\Pages\AnPhuocList.razor"
                  anphuoc.Tensp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n        ");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "class", "imageThumbnail");
            __builder.AddAttribute(12, "src", (
#nullable restore
#line 12 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\Pages\AnPhuocList.razor"
                                          anphuoc.Hinhanh

#line default
#line hidden
#nullable disable
            ) + " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "style", "text-align: center; color: red");
            __builder.AddMarkupContent(16, "Giá: ");
            __builder.AddContent(17, 
#nullable restore
#line 13 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\Pages\AnPhuocList.razor"
                                                          anphuoc.Gia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "card-footer text-center");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", 
#nullable restore
#line 17 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\Pages\AnPhuocList.razor"
                       $"anphuocdetails/{anphuoc.AnPhuocId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "class", "btn btn-primary m-1");
            __builder.AddContent(24, " View ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.AddMarkupContent(26, "<a href=\"#\" class=\"btn btn-primary m-1\"> Edit </a>\r\n            ");
            __builder.AddMarkupContent(27, "<a href=\"#\" class=\"btn btn-danger m-1\"> Delete </a>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\Administrator\source\ASPNET\AnPhuocShop\AnPhuocShop.Web\Pages\AnPhuocList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
