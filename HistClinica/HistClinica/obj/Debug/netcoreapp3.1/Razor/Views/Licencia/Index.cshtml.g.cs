#pragma checksum "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Licencia\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee6a10681e9222bf5e972714960fe9fcfb10377d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Licencia_Index), @"mvc.1.0.view", @"/Views/Licencia/Index.cshtml")]
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
#line 1 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\_ViewImports.cshtml"
using HistClinica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\_ViewImports.cshtml"
using HistClinica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee6a10681e9222bf5e972714960fe9fcfb10377d", @"/Views/Licencia/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Licencia_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HistClinica.DTO.licenciaDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/cargavistaparcial.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Licencia\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container-fluid"">
    <div class=""col-sm-12"">
        <div class=""row"">
            <div class=""col-sm-12 text-left card-height"">
                <div class=""card card-primary card-his"">
                    <div class=""card-header card-shadow"">
                        <h2>Solicitud de licencias</h2>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-sm-12"" style=""padding-top:50px;"">
        <div class=""row"">
            <div class=""col-sm-12"">
                <div class=""row"">
                    <div class=""pd-xs-0 col-sm-3"">
                        <div class=""col-sm-12"">
                            <div class=""input-style"">
                                <label for=""codigo"" class=""form-label"">Codigo</label>
                                <input type=""text"" id=""codigo"" class=""form-control"" name=""codigo"" />

                            </div>
                        </div>
                    </div>
   ");
            WriteLiteral(@"                 <div class=""pd-xs-0 col-sm-3"" style=""height: 100px; display: flex; flex-direction: column; justify-content: center;"">
                        <div class=""col-sm-12"" style=""height: 100px; display: flex; flex-direction: column; justify-content: center;"">
                            <input type=""submit"" style=""width: 70px;"" value=""Buscar"" class=""btn btn-primary"" />
                        </div>
                    </div>
                </div>

            </div>
        </div>
        <div class=""row pt-2"">
            <div class=""col-sm-12 text-right pb-2"">
                <button onclick=""cargarModalCrearLicencia();"" class=""btn btn-primary"">Registrar Solicitud</button>
            </div>
            <div class=""col-sm-12"">
                <table class=""table table-bordered table-hover"" id=""licenciagrid"">
                    <thead>
                        <tr>
                            <th>
                                Nro Solicitud
                            </th>
");
            WriteLiteral(@"                            <th>
                                Mèdico
                            </th>
                            <th>
                                Fecha
                            </th>
                            <th>
                                Estado
                            </th>
                            <th>
                                Acciones
                            </th>
                        </tr>
                    </thead>
                    <tbody class=""tbody"">
");
#nullable restore
#line 69 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Licencia\Index.cshtml"
                         foreach (var item in Model)
                        {



#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 74 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Licencia\Index.cshtml"
                               Write(item.idLicencia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 75 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Licencia\Index.cshtml"
                               Write(item.medico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 77 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Licencia\Index.cshtml"
                               Write(item.fechaIni);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>");
#nullable restore
#line 79 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Licencia\Index.cshtml"
                               Write(item.estado);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                <td>
                                    <a type=""submit"" style=""color:white;"" class=""edit btn btn-primary mt-small-2"" aria-hidden=""true"">
                                        <i class=""fas fa-edit""></i>
                                    </a>
                                </td>
                            </tr>
");
#nullable restore
#line 86 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Licencia\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
    </div>
    </div>

<div class=""modal fade"" id=""modalagregarlicencia"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee6a10681e9222bf5e972714960fe9fcfb10377d8959", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HistClinica.DTO.licenciaDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591