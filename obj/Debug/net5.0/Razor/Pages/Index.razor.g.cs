#pragma checksum "E:\Des\project\_personal\dotnet\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dfdc8edcfcbbc867f954f21a63d0ae3e2182620"
// <auto-generated/>
#pragma warning disable 1591
namespace dotnet.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Des\project\_personal\dotnet\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Des\project\_personal\dotnet\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Des\project\_personal\dotnet\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Des\project\_personal\dotnet\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Des\project\_personal\dotnet\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Des\project\_personal\dotnet\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Des\project\_personal\dotnet\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Des\project\_personal\dotnet\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Des\project\_personal\dotnet\_Imports.razor"
using dotnet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Des\project\_personal\dotnet\_Imports.razor"
using dotnet.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Des\project\_personal\dotnet\Pages\Index.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/{text?}")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<a href=\"/counter/en\">count/en</a>\r\n");
            __builder.AddMarkupContent(1, "<h1>Hello, world!</h1>\r\n");
            __builder.OpenElement(2, "h3");
            __builder.AddContent(3, "thit is ");
            __builder.AddContent(4, 
#nullable restore
#line 9 "E:\Des\project\_personal\dotnet\Pages\Index.razor"
             Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "E:\Des\project\_personal\dotnet\Pages\Index.razor"
                  SetStock

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "test");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n<h3 data-i18n=\"lang\"></h3>\r\n");
            __builder.AddMarkupContent(10, "<button id=\"btnEN\">EN</button>\r\n");
            __builder.AddMarkupContent(11, "<button id=\"btnTW\">TW</button>\r\n");
            __builder.OpenElement(12, "select");
            __builder.AddAttribute(13, "name", "sec");
            __builder.AddAttribute(14, "id", "select");
            __builder.OpenElement(15, "option");
            __builder.AddAttribute(16, "value", "en");
            __builder.AddContent(17, "EN");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n  ");
            __builder.OpenElement(19, "option");
            __builder.AddAttribute(20, "value", "tw");
            __builder.AddContent(21, "TW");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.AddMarkupContent(23, "<ul class=\"nav\"><li><p data-i18n=\"nav.home\"></p></li>\r\n  <li><p data-i18n=\"nav.page1\"></p></li>\r\n  <li><p data-i18n=\"nav.page2\"></p></li></ul>\r\n\r\n");
            __builder.AddMarkupContent(24, @"<div class=""content""><input data-i18n=""[placeholder]input.placeholder""></div><br>

multiple attributes :
<p data-i18n=""[title]h2;[id]id;[data-test]test;test""></p><br>
Not innerHtml :
<p data-i18n=""lines""></p><br>
innerHtml :
<p data-i18n=""[html]lines""></p>");
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "E:\Des\project\_personal\dotnet\Pages\Index.razor"
       
  [Parameter]
  public string Text { get; set; }

  private async Task SetStock()
  {
    var query = new Uri(NavigationManager.Uri).Query;
    await JS.InvokeVoidAsync("testing", Text, query);
  }


  private string message = "Initial assigned message.";

  protected override void OnAfterRender(bool firstRender)
  {
    if (firstRender)
    {
      Console.WriteLine("fitst");
    }
    else
    {
      Console.WriteLine("not fitst");
    }
  }
  protected override async Task OnAfterRenderAsync(bool firstRender)
  {
    if (firstRender)
    {
      var query = new Uri(NavigationManager.Uri).Query;
      await JS.InvokeVoidAsync("testing", Text, "index");
    }
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Index> Logger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
    }
}
#pragma warning restore 1591
