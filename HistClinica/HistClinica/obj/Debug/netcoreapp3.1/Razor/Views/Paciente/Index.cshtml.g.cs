#pragma checksum "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00ebd5a3dba2daa337f4bdcb46f0e5e20d0d1087"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Paciente_Index), @"mvc.1.0.view", @"/Views/Paciente/Index.cshtml")]
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
#line 1 "D:\CEM-HIS\HistClinica\HistClinica\Views\_ViewImports.cshtml"
using HistClinica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CEM-HIS\HistClinica\HistClinica\Views\_ViewImports.cshtml"
using HistClinica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00ebd5a3dba2daa337f4bdcb46f0e5e20d0d1087", @"/Views/Paciente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Paciente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.DTO.PersonaDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "value", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Paciente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pago", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 112px;font-size: 16px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/cargavistaparcial.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/combosaninadoscitas.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
   ViewBag.Title = "ProgramarCitaAdmision";
                Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-12 text-center"">
            <div class=""card card-primary"">
                <div class=""card-header"">
                    <h1>Admision</h1>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"" style=""padding-top:20px;"">
        <div class=""col-sm-12 pb-3"">
            <span style=""font-size: 18px;"">Buscar por:</span>
            <div class=""pl-3 form-check form-check-inline"">
                <input class=""form-check-input"" type=""radio"" checked name=""radiofiltro"" id=""inlineRadio1"" value=""1"">
                <label class=""form-check-label"" for=""inlineRadio1"">Por Dni</label>
            </div>
            <div class=""form-check form-check-inline"">
                <input class=""form-check-input"" type=""radio"" name=""radiofiltro"" id=""inlineRadio2"" value=""2"">
                <label class=""form-check-label"" for=""inlineRadio2"">Por Nombre y apellido</label>
            </div>
        </div");
            WriteLiteral(">\r\n        <div class=\"col-sm-12\">\r\n");
#nullable restore
#line 29 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
             using (Html.BeginForm())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    ");
#nullable restore
#line 32 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
Write(Html.HiddenFor(m => m.paciente.idPaciente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"col-sm-2\">\r\n        <select class=\"form-control\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00ebd5a3dba2daa337f4bdcb46f0e5e20d0d10878992", async() => {
                WriteLiteral("DNI");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </select>
    </div>
    <div class=""col-sm-2"">
        <input type=""text"" id=""dni"" name=""dni"" class=""form-control"" />
    </div>
    <div class=""col-sm-2"">
        <input type=""text"" id=""nombre"" name=""nombre"" class=""form-control"" placeholder=""Ingrese nombre"" />
    </div>
    <div class=""col-sm-2"">
        <input type=""text"" id=""apellidos"" name=""apellidos"" class=""form-control"" placeholder=""Ingrese apellidos"" />
    </div>
    <div class=""col-sm-4"">
        <button class=""btn btn-info"" type=""submit"" id=""btnBuscar""><i class=""fas fa-search""></i></button>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00ebd5a3dba2daa337f4bdcb46f0e5e20d0d108710779", async() => {
                WriteLiteral("<i class=\"fas fa-user-plus\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 50 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
         if (Model != null)
        {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00ebd5a3dba2daa337f4bdcb46f0e5e20d0d108712519", async() => {
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                                                                         WriteLiteral(Model.paciente.idPaciente);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 52 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                                                                                                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
#nullable restore
#line 54 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-4"">
            <div class=""row pt-3"">
                <div class=""col-sm-4"">
                    <label>Paciente</label>
                </div>
                <div class=""col-sm-8"">
                    <div class=""divpac"">
                        <label>");
#nullable restore
#line 65 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                          Write(Html.DisplayFor(m => m.apellidoPaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 65 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                                                   Write(Html.DisplayFor(m => m.apellidoMaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 65 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                                                                                            Write(Html.DisplayFor(m => m.nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </label>
                    </div>
                </div>
            </div>
            <div class=""row"" style=""padding-top: 10px;"">
                <div class=""col-sm-4"">
                    <label>DNI</label>
                </div>
                <div class=""col-sm-8"">
                    ");
#nullable restore
#line 74 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
               Write(Html.TextBoxFor(m => m.numeroDocumento, new { @class = "form-control", @disabled = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
            <div class=""row"" style=""padding-top: 10px;"">
                <div class=""col-sm-4"">
                    <label>Correo</label>
                </div>
                <div class=""col-sm-8"">
                    ");
#nullable restore
#line 82 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
               Write(Html.TextBoxFor(m => m.correo, new { @class = "form-control", @disabled = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
            <div class=""row"" style=""padding-top: 10px;"">
                <div class=""col-sm-4"">
                    <label>Edad</label>
                </div>
                <div class=""col-sm-8"">
                    ");
#nullable restore
#line 90 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
               Write(Html.TextBoxFor(m => m.edad, new { @class = "form-control", @disabled = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
            <div class=""row pb-2"" style=""padding-top: 10px;"">
                <div class=""col-sm-4"">
                    <label>Ocupación</label>
                </div>
                <div class=""col-sm-8"">
                    ");
#nullable restore
#line 98 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
               Write(Html.TextBoxFor(m => m.descripcionOcupacion, new { @class = "form-control", @disabled = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
        </div>

        <div class=""col-sm-4"">
        </div>
        <div class=""col-sm-4"">

        </div>
    </div>
    <div class=""row"" style=""padding-top: 10px;"">
        <div class=""col-sm-12"">
            <button style=""width: 112px; font-size: 15px;"" class=""btn btn-primary"" onclick=""CargaModalCitas();"">Citas</button>
            <button style=""width: 135px; font-size: 15px;"" class=""btn btn-primary"">Orden</button>
            <button onclick=""CargaConsultaCronograma();"" style=""width: 135px; font-size: 15px;"" class=""btn btn-primary"">Cronograma</button>
        </div>
    </div>
");
#nullable restore
#line 116 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
     if (ViewBag.message != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""col-sm-12 alert alert-info alert-dismissible text-center"" id=""success-alert"" role=""alert"" style=""margin-top: 15px;"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""close"">
        <span aria-hidden=""true"">&times;</span>
    </button>
    ");
#nullable restore
#line 122 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
#nullable restore
#line 123 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"" style=""padding-top: 80px;"">
        <div class=""col-sm-12"">
            <table class=""table table-bordered table-responsive table-hover"" style=""font-size:14px;"" id=""citagrid"">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>N°</th>
                        <th>Tipo</th>
                        <th>Fecha</th>
                        <th>Hora</th>
                        <th>Producto</th>
                        <th>Descripción</th>
                        <th>Medico</th>
                        <th>Especialidad</th>
                        <th>Precio</th>
                        <th>IGV</th>
                        <th>Estado</th>
                        <th>Est.Pago</th>
                        <th>Total</th>
                        <th>Acciones</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 147 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                       if (Model != null)
                                    {
                                        foreach (var item in Model.paciente.cita)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 152 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                           Write(item.idCita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 153 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                           Write(item.nroCita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 154 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                           Write(item.TipoCita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td nowrap>");
#nullable restore
#line 155 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                  Write(item.fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 156 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                           Write(item.hora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 157 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                           Write(item.consultorio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 158 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                           Write(item.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td nowrap>");
#nullable restore
#line 159 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                  Write(item.medico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 160 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                           Write(item.especialidad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td nowrap>");
#nullable restore
#line 161 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                  Write(item.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td nowrap>");
#nullable restore
#line 162 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                                  Write(item.igv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 163 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                           Write(item.descEstado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 164 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                           Write(item.descEstadoPago);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 165 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                           Write(item.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            <td nowrap>
                                <button title=""Reprogramar"" class=""edit btn btn-primary""><i class=""fas fa-address-book""></i></button>
                                <button title=""Consultar"" class=""detail btn btn-primary"">
                                    <i class=""fa fa-search"" aria-hidden=""true""></i>
                                </button>
                                <button title=""Anular"" class=""anular btn btn-danger"">
                                    <i class=""fa fa-minus"" aria-hidden=""true""></i>
                                </button>
                            </td>
                        </tr> ");
#nullable restore
#line 175 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
                              }
                                    } 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <div class=""col-sm-12 text-right"">
            <span style=""margin-right:10px;"">TOTAL DE VALOR VENTA - OPERACION GRAVADA</span><span>300</span><br />
            <span style=""margin-right:10px;"">IGV(18%)</span><span>54</span><br />
            <span style=""margin-right:10px;"">IMPORTE TOTAL</span><span>354</span>
        </div>
        <div class=""col-sm-12"" style=""padding-top: 10px;"">
            <div class=""row"">
                <div class=""col-sm-6"">

                </div>
                <div class=""col-sm-6 text-right"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00ebd5a3dba2daa337f4bdcb46f0e5e20d0d108727510", async() => {
                WriteLiteral("Pagar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>

        </div>
    </div>
</div>

<div class=""modal fade"" id=""modalcitas"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">

</div>
<div class=""modal fade"" id=""modalreprogramar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">

</div>

<div id=""modalcronograma"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel1"" aria-hidden=""true"">
</div>
<div id=""modaldetallecro"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel1"" aria-hidden=""true"">
</div>
<div id=""modalanular"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel1"" aria-hidden=""true"">
</div>
<div id=""modaldetalle"" class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel1"" aria-hidden=""true"">
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00ebd5a3dba2daa337f4bdcb46f0e5e20d0d108729967", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00ebd5a3dba2daa337f4bdcb46f0e5e20d0d108731007", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 217 "D:\CEM-HIS\HistClinica\HistClinica\Views\Paciente\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HistClinica.DTO.PersonaDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591