#pragma checksum "C:\Users\User\Downloads\8A1C9C9B-2814-4B40-9201-56B2866BDFF9-11 - Deploy via Docker\src\web\NSE.WebApp.MVC\Views\Pedido\_Endereco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26c0fb999a32e41dc4926636fa9d9a97e8c68d75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido__Endereco), @"mvc.1.0.view", @"/Views/Pedido/_Endereco.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\Downloads\8A1C9C9B-2814-4B40-9201-56B2866BDFF9-11 - Deploy via Docker\src\web\NSE.WebApp.MVC\Views\_ViewImports.cshtml"
using NSE.WebApp.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Downloads\8A1C9C9B-2814-4B40-9201-56B2866BDFF9-11 - Deploy via Docker\src\web\NSE.WebApp.MVC\Views\_ViewImports.cshtml"
using NSE.WebApp.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26c0fb999a32e41dc4926636fa9d9a97e8c68d75", @"/Views/Pedido/_Endereco.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93d98b721f55057ac795973b9ba0afeeb6ca1d76", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Pedido__Endereco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NSE.WebApp.MVC.Models.PedidoTransacaoViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h4 class=\"card-title\">Endereço</h4>\r\n");
#nullable restore
#line 5 "C:\Users\User\Downloads\8A1C9C9B-2814-4B40-9201-56B2866BDFF9-11 - Deploy via Docker\src\web\NSE.WebApp.MVC\Views\Pedido\_Endereco.cshtml"
  
    if (Model.Endereco == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"text-left\">\r\n            <a href=\"javascript:void(0)\" class=\"btn btn-primary float-md-left\" data-toggle=\"modal\" data-target=\"#enderecoModal\"> <i class=\"fa fa-location-arrow\"></i> Adicionar Endereço</a>\r\n        </div>\r\n");
#nullable restore
#line 11 "C:\Users\User\Downloads\8A1C9C9B-2814-4B40-9201-56B2866BDFF9-11 - Deploy via Docker\src\web\NSE.WebApp.MVC\Views\Pedido\_Endereco.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-9 text-left\">\r\n                ");
#nullable restore
#line 16 "C:\Users\User\Downloads\8A1C9C9B-2814-4B40-9201-56B2866BDFF9-11 - Deploy via Docker\src\web\NSE.WebApp.MVC\Views\Pedido\_Endereco.cshtml"
           Write(Model.Endereco.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-3 text-right\">\r\n                <a href=\"javascript:void(0)\" class=\"btn btn-primary float-md-right\"> <i class=\"fa fa-location-arrow\"></i> Alterar Endereço</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 22 "C:\Users\User\Downloads\8A1C9C9B-2814-4B40-9201-56B2866BDFF9-11 - Deploy via Docker\src\web\NSE.WebApp.MVC\Views\Pedido\_Endereco.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NSE.WebApp.MVC.Models.PedidoTransacaoViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
