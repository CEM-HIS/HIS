#pragma checksum "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dd3038e8bb0facace4cf53cb073af14b18fb8b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cronograma_ConsultarCronograma), @"mvc.1.0.view", @"/Views/Cronograma/ConsultarCronograma.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dd3038e8bb0facace4cf53cb073af14b18fb8b2", @"/Views/Cronograma/ConsultarCronograma.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Cronograma_ConsultarCronograma : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HistClinica.DTO.CronogramaDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""modal-dialog modal-lg"" role=""document"">
    <div class=""modal-content"" style=""width:1200px;position:relative;right:137px;"">
        <div class=""modal-header"">
            <h2 class=""modal-title text-center pl-3"" id=""exampleModalLabel1"">Consultar cronograma</h2>
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
            </button>
        </div>
        <div class=""container"">
            <div class=""col-sm-12 pt-5 pb-5"">


");
#nullable restore
#line 16 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                 using (Html.BeginForm("ConsultarCronogramapost", "Cronograma"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""col-sm-12 form-inline mb-5"">

                            <label class=""pr-2"">Nombre medico:</label>
                            <input type=""text"" id=""nombremedico"" class=""form form-control small-input col-2"" />

                            <label class=""pl-3 pr-2"">Apellido Medico:</label>
                            <input type=""text"" id=""apellidomedico"" class=""form form-control small-input col-2"" />

                            <label class=""pl-3 pr-2"">Especialidad</label>
                            ");
#nullable restore
#line 28 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                       Write(Html.DropDownList("especialidad", new SelectList(ViewBag.listaespecialidades, "idtab", "descripcion"), "Seleccionar", new { @class = "form-control small-input col-2", id = "especialidad" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <a class=\"pl-2 btn btn-primary\" style=\"color:white; margin-left:10px;\" onclick=\"BuscarCronograma();\">Buscar</a>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 32 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <div class=""row pt-3"">
                    <div class=""col-sm-12"">
                        <table class=""table table-bordered table-hover text-center"" id=""consultacronogrid"">
                            <thead>
                                <tr>
                                    <th>Id</th>
                                    <th>Medico</th>
                                    <th>Especialidad</th>
                                    <th>Fecha Ini</th>
                                    <th>Fecha Fin</th>
                                    <th>Hora ini</th>
                                    <th>Hora fin</th>
                                    <th>Estado</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 50 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 53 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                                       Write(item.idProgramMedica);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 54 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                                       Write(item.medico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 55 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                                       Write(item.especialidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 56 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                                       Write(item.fechaIni);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 57 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                                       Write(item.fechaFin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 58 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                                       Write(item.hrInicio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 59 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                                       Write(item.hrFin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 60 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                                       Write(item.desEstado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 62 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\ConsultarCronograma.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HistClinica.DTO.CronogramaDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
