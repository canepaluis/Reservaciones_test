#pragma checksum "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a56bfdb2be9f3dfe88e334d52f6a8b93f2d53810"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\_ViewImports.cshtml"
using Reservaciones_test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\_ViewImports.cshtml"
using Reservaciones_test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a56bfdb2be9f3dfe88e334d52f6a8b93f2d53810", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb3cf023fb270e5ea8d4eba66c2ec65e25104672", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Reservaciones_test.Models.Reservaciones>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Detalle de Reserva";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>");
#nullable restore
#line 10 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h5>Estos son sus detalles de reserva: </h5>\r\n    <div>\r\n        <div class=\"col-lg-6\">\r\n            <h6>Ciudad:</h6>\r\n            <p>");
#nullable restore
#line 15 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\Details.cshtml"
          Write(ViewData["destino"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n\r\n        <div class=\"col-lg-6\">\r\n            <h6>Nombre del hotel:</h6>\r\n            <p>");
#nullable restore
#line 20 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\Details.cshtml"
          Write(ViewData["hotel"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n\r\n        <div class=\"col-lg-6\">\r\n            <h6>Fecha de llegada:</h6>\r\n            <p>");
#nullable restore
#line 25 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\Details.cshtml"
          Write(ViewData["fecha"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n\r\n        <div class=\"col-lg-6\">\r\n\r\n            <h6>Habitaci??n reservada:</h6>\r\n            <p>");
#nullable restore
#line 31 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\Details.cshtml"
          Write(ViewData["habitacion"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n\r\n        <div class=\"col-lg-6\">\r\n            <h6>Cantidad de adultos:</h6>\r\n            <p>");
#nullable restore
#line 36 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\Details.cshtml"
          Write(ViewData["adultos"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n\r\n        <div class=\"col-lg-6\">\r\n            <h6>Cantidad de menores:</h6>\r\n            <p>");
#nullable restore
#line 41 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\Details.cshtml"
          Write(ViewData["menores"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n\r\n        <div class=\"col-lg-6\">\r\n            <h6>Costo total:</h6>\r\n            <p>$ ");
#nullable restore
#line 46 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\Details.cshtml"
            Write(ViewData["total"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@".00 MXN</p>
        </div>

        <div class=""container"">
            <div class=""row"">
                <div class=""col text-center"">
                    <a href=""/home/json/"" class=""btn btn-primary"">Enviar JSON</a>
                    
                </div>
            </div>
        </div>
    </div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Reservaciones_test.Models.Reservaciones> Html { get; private set; }
    }
}
#pragma warning restore 1591
