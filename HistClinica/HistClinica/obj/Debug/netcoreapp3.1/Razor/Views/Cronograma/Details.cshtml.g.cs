#pragma checksum "D:\HIS\HIS\HistClinica\HistClinica\Views\Cronograma\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12d58c42da8fc6a3a4dfc44394d94f36a1af9ae6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cronograma_Details), @"mvc.1.0.view", @"/Views/Cronograma/Details.cshtml")]
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
#line 1 "D:\HIS\HIS\HistClinica\HistClinica\Views\_ViewImports.cshtml"
using HistClinica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HIS\HIS\HistClinica\HistClinica\Views\_ViewImports.cshtml"
using HistClinica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12d58c42da8fc6a3a4dfc44394d94f36a1af9ae6", @"/Views/Cronograma/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Cronograma_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.DTO.CronogramaDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal-dialog modal-md"" role=""document"">
	<div class=""modal-content"">
		<div class=""modal-header"">
			<h5 class=""modal-title text-center"" id=""exampleModalLabel"">Actualizar cronograma</h5>
			<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
				<span aria-hidden=""true"">&times;</span>
			</button>
		</div>
");
#nullable restore
#line 10 "D:\HIS\HIS\HistClinica\HistClinica\Views\Cronograma\Details.cshtml"
         using (Html.BeginForm("Edit", "Cronograma"))
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"modal-body\">\r\n\t\t\t\t<div class=\"col-sm-12\">\r\n\t\t\t\t\t<div class=\"row pb-2\">\r\n\t\t\t\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 16 "D:\HIS\HIS\HistClinica\HistClinica\Views\Cronograma\Details.cshtml"
                       Write(Html.HiddenFor(m => m.idProgramMedica));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t\t\t<label>Medico</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 23 "D:\HIS\HIS\HistClinica\HistClinica\Views\Cronograma\Details.cshtml"
                               Write(Html.DropDownListFor(m => m.idMedico, new SelectList(ViewBag.listamedicos, "idMedico", "nombres"), "Seleccione", new { @class = "form-control", @disabled="true"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t\t\t<label>Especialidad</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 33 "D:\HIS\HIS\HistClinica\HistClinica\Views\Cronograma\Details.cshtml"
                               Write(Html.DropDownListFor(m => m.idEspecialidad, new SelectList(ViewBag.listaespecialidades, "idtab", "descripcion"), new { @class = "form-control", @disabled = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
								</div>
							</div>
						</div>
					</div>
					<div class=""row pb-2"">
						<div class=""col-sm-6"">
							<div class=""row"">
								<div class=""col-sm-4"">
									<label>Fecha Inicio</label>
								</div>
								<div class=""col-sm-8"">

									");
#nullable restore
#line 46 "D:\HIS\HIS\HistClinica\HistClinica\Views\Cronograma\Details.cshtml"
                               Write(Html.DisplayFor(m => m.fechaIni, new { htmlAttributes = new { @class = "form-control", @type = "Date" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t\t\t<label>Fecha Fin</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 57 "D:\HIS\HIS\HistClinica\HistClinica\Views\Cronograma\Details.cshtml"
                               Write(Html.DisplayFor(m => m.fechaFin, new { htmlAttributes = new { @class = "form-control", @type = "Date" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
								</div>
							</div>
						</div>
					</div>
					<div class=""row pb-2"">
						<div class=""col-sm-6"">
							<div class=""row"">
								<div class=""col-sm-4"">
									<label>Hora Inicio</label>
								</div>
								<div class=""col-sm-8"">
									");
#nullable restore
#line 69 "D:\HIS\HIS\HistClinica\HistClinica\Views\Cronograma\Details.cshtml"
                               Write(Html.DropDownListFor(m => m.hrInicio, new SelectList(ViewBag.listahoras), new { @class = "form-control", @disabled = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t\t\t<label>Hora Fin</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 79 "D:\HIS\HIS\HistClinica\HistClinica\Views\Cronograma\Details.cshtml"
                               Write(Html.DropDownListFor(m => m.hrFin, new SelectList(ViewBag.listahoras), new { @class = "form-control", @disabled = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
								</div>
							</div>
						</div>
					</div>
					<div class=""row pb-2"">
						<div class=""col-sm-6"">
							<div class=""row"">
								<div class=""col-sm-4"">
									<label>Estado</label>
								</div>
								<div class=""col-sm-8"">
									");
#nullable restore
#line 91 "D:\HIS\HIS\HistClinica\HistClinica\Views\Cronograma\Details.cshtml"
                               Write(Html.DropDownListFor(m => m.idEstado, new SelectList(ViewBag.lestado, "idtab", "descripcion"), new { @class = "form-control", @disabled = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t\t\t<label>Consultorio</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 101 "D:\HIS\HIS\HistClinica\HistClinica\Views\Cronograma\Details.cshtml"
                               Write(Html.DropDownListFor(m => m.idConsultorio, new SelectList(ViewBag.listaconsultorio, "idtab", "descripcion"), new { @class = "form-control", @disabled = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
								</div>
							</div>
						</div>
					</div>
				</div>
				<div class=""modal-footer"">
					<button style=""width: 80px;"" type=""submit"" class=""btn btn-primary"">Guardar</button>
					<button style=""width: 80px;"" type=""submit"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
				</div>
			</div>
");
#nullable restore
#line 112 "D:\HIS\HIS\HistClinica\HistClinica\Views\Cronograma\Details.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HistClinica.DTO.CronogramaDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
