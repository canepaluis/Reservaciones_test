#pragma checksum "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\RailService.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e952557134ef99c1c49729ef18e1248815b942ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RailService), @"mvc.1.0.view", @"/Views/Home/RailService.cshtml")]
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
#line 1 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\RailService.cshtml"
using Reservaciones_test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e952557134ef99c1c49729ef18e1248815b942ef", @"/Views/Home/RailService.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb3cf023fb270e5ea8d4eba66c2ec65e25104672", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RailService : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/JsonDos/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\RailService.cshtml"
   
    var data = ViewBag.Message;

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    \r\n        <h2>Descripción y Servicios</h2>\r\n        <br />\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e952557134ef99c1c49729ef18e1248815b942ef4444", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\RailService.cshtml"
             foreach (var item in ViewData["jointables"] as IEnumerable<Reservaciones_test.Models.MultipleTablesJoinClass>)

            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <h5>Selección ");
#nullable restore
#line 14 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\RailService.cshtml"
                         Write(item.t_Habitacioneslist.Tipo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                <p>");
#nullable restore
#line 15 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\RailService.cshtml"
              Write(item.descripcioneslist.Descripcion);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p>Servicios: ");
#nullable restore
#line 16 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\RailService.cshtml"
                         Write(item.servicioslist.Contenido);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 17 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\RailService.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h2>Reserva</h2>\r\n            <br />\r\n\r\n            <div class=\"form-group col-lg-12\">\r\n                <label for=\"formGroupExampleInput\">Modelo: </label>\r\n                <select class=\"form-control\" name=\"modelo\">\r\n");
#nullable restore
#line 25 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\RailService.cshtml"
                     foreach (var modelo in ViewData["jointables"] as IEnumerable<Reservaciones_test.Models.MultipleTablesJoinClass>)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e952557134ef99c1c49729ef18e1248815b942ef6901", async() => {
#nullable restore
#line 27 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\RailService.cshtml"
                           Write(modelo.t_Habitacioneslist.Tipo);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\RailService.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </select>
            </div>
            <div class=""row col-lg-12 col-sm-12"">
                <div class=""form-group col-lg-6"">
                    <label>Adultos: </label>
                    <select class=""form-control "" name=""adultos"">
");
#nullable restore
#line 36 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\RailService.cshtml"
                         for (int i = 1; i <= 10; i++)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e952557134ef99c1c49729ef18e1248815b942ef8969", async() => {
#nullable restore
#line 38 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\RailService.cshtml"
                                          Write(i);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\RailService.cshtml"
                               WriteLiteral(i);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\RailService.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n                </div>\r\n\r\n                <div class=\"form-group col-lg-6\">\r\n                    <label>Menores: </label>\r\n                    <select class=\"form-control \" name=\"menores\">\r\n");
#nullable restore
#line 46 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\RailService.cshtml"
                         for (int i = 1; i <= 10; i++)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e952557134ef99c1c49729ef18e1248815b942ef11685", async() => {
#nullable restore
#line 48 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\RailService.cshtml"
                                          Write(i);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\RailService.cshtml"
                               WriteLiteral(i);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\Alexis Canepa\source\repos\Reservaciones_test\Reservaciones_test\Views\Home\RailService.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
            </div>


            <div class=""container"">
                <div class=""row"">
                    <div class=""col text-center"">
                        <input type=""submit"" name=""name"" class=""btn btn-primary"" value=""¡Reservar!"" />
                    </div>
                </div>
            </div>



        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591