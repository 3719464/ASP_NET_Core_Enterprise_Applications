#pragma checksum "C:\Users\User\Downloads\8A1C9C9B-2814-4B40-9201-56B2866BDFF9-11 - Deploy via Docker\src\web\NSE.WebApp.MVC\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a765fe28b866ebf6ac7c4490d8387534b60e98be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a765fe28b866ebf6ac7c4490d8387534b60e98be", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93d98b721f55057ac795973b9ba0afeeb6ca1d76", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NSE.WebApp.MVC.Models.ErrorViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Downloads\8A1C9C9B-2814-4B40-9201-56B2866BDFF9-11 - Deploy via Docker\src\web\NSE.WebApp.MVC\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = @Model.Titulo;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div style=\"padding-top: 200px; text-align: center\">\r\n");
#nullable restore
#line 7 "C:\Users\User\Downloads\8A1C9C9B-2814-4B40-9201-56B2866BDFF9-11 - Deploy via Docker\src\web\NSE.WebApp.MVC\Views\Shared\Error.cshtml"
          
            if (Model == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>Ooops! Ocorreu um erro, mas não se preocupe. Nosso time será avisado e iremos corrigir em breve!</h2>\r\n");
#nullable restore
#line 11 "C:\Users\User\Downloads\8A1C9C9B-2814-4B40-9201-56B2866BDFF9-11 - Deploy via Docker\src\web\NSE.WebApp.MVC\Views\Shared\Error.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>");
#nullable restore
#line 14 "C:\Users\User\Downloads\8A1C9C9B-2814-4B40-9201-56B2866BDFF9-11 - Deploy via Docker\src\web\NSE.WebApp.MVC\Views\Shared\Error.cshtml"
           Write(Html.Raw(Model.Mensagem));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 15 "C:\Users\User\Downloads\8A1C9C9B-2814-4B40-9201-56B2866BDFF9-11 - Deploy via Docker\src\web\NSE.WebApp.MVC\Views\Shared\Error.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NSE.WebApp.MVC.Models.ErrorViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
