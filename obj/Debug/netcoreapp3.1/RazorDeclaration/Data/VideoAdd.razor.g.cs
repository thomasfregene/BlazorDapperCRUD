#pragma checksum "C:\Projects\BlazorDapperCRUD\Data\VideoAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e259d904b4bb39091d7d6db5ee7e8895712d81b8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorDapperCRUD.Data
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\BlazorDapperCRUD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\BlazorDapperCRUD\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\BlazorDapperCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\BlazorDapperCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\BlazorDapperCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\BlazorDapperCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\BlazorDapperCRUD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\BlazorDapperCRUD\_Imports.razor"
using BlazorDapperCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\BlazorDapperCRUD\_Imports.razor"
using BlazorDapperCRUD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Projects\BlazorDapperCRUD\Data\VideoAdd.razor"
using BlazorDapperCRUD.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/videoadd")]
    public partial class VideoAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Projects\BlazorDapperCRUD\Data\VideoAdd.razor"
       
    //create a new, empty video object
    Video video = new Video();

    //Executes on page open,set default on page.
    protected override void OnInitialized()
    {
        DateTime defaultDate = new DateTime(2000, 12, 31);
        video.DatePublished = defaultDate;
        video.IsActive = true;
    }

    protected async Task VideoInsert()
    {
        await VideoService.VideoInsert(video);
        NavigationManager.NavigateTo("/");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVideoService VideoService { get; set; }
    }
}
#pragma warning restore 1591
