#pragma checksum "D:\CEM-HIS\HistClinica\HistClinica\Views\Licencia\Registro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "510ec8d0b0edaf0138302548bf27b9fb5383e13d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Licencia_Registro), @"mvc.1.0.view", @"/Views/Licencia/Registro.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"510ec8d0b0edaf0138302548bf27b9fb5383e13d", @"/Views/Licencia/Registro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Licencia_Registro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.Models.LICENCIA>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""modal-dialog modal-lg"" role=""document"">
	<div class=""modal-content"">
		<div class=""modal-header"">
			<h4 class=""modal-title text-center"" id=""exampleModalLabel"">Agregar Licencia</h4>
			<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
				<span aria-hidden=""true"">&times;</span>
			</button>
		</div>
");
#nullable restore
#line 11 "D:\CEM-HIS\HistClinica\HistClinica\Views\Licencia\Registro.cshtml"
         using (Html.BeginForm("Registro", "Licencia", FormMethod.Post, new { @id = "frmregistrartipo" }))
		{
			

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\CEM-HIS\HistClinica\HistClinica\Views\Licencia\Registro.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\CEM-HIS\HistClinica\HistClinica\Views\Licencia\Registro.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"			<div class=""modal-body"">

				<div class=""row"">
					<div class=""col-md-9"">
						<div class=""row"">
							<div class=""col-sm-12"">
								<label>Turno</label>
							</div>
							<div class=""col-sm-12"">
								<div class=""row"">
									<div class=""col-sm-6"">
										<div class=""row"">
											<div class=""col-sm-4"">
												Hora Inicio
											</div>
											<div class=""col-sm-8"">
												");
#nullable restore
#line 31 "D:\CEM-HIS\HistClinica\HistClinica\Views\Licencia\Registro.cshtml"
                                           Write(Html.DropDownListFor(m => m.horaInicio, new SelectList(ViewBag.listahoras), "Seleccione", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t\t\t\t\t\tHora Fin\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 41 "D:\CEM-HIS\HistClinica\HistClinica\Views\Licencia\Registro.cshtml"
                                           Write(Html.DropDownListFor(m => m.horaFin, new SelectList(ViewBag.listahoras), "Seleccione", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>

					</div>
					<div class=""col-sm-3"">

					</div>


				</div>
				<div class=""row"">
					<div class=""col-sm-9"">
						<div class=""row"">
							<div class=""col-sm-12 pt-3"">
								<label>Reemplazo</label>
							</div>
							<div class=""col-sm-12 pb-4"">
								<div class=""row"">
									<div class=""col-sm-2"">
										Mèdico
									</div>
									<div class=""col-sm-5"">
										");
#nullable restore
#line 68 "D:\CEM-HIS\HistClinica\HistClinica\Views\Licencia\Registro.cshtml"
                                   Write(Html.DropDownListFor(m => m.idMedico, new SelectList(ViewBag.listamedicos, "idMedico", "nombres"), "Seleccione", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									</div>
									<div class=""col-sm-5"">

									</div>
								</div>
							</div>
						</div>
						<div class=""row"">
							<div class=""col-sm-12"">
								<div class=""row"">
									<div class=""col-sm-6"">
										<div class=""row"">
											<div class=""col-sm-4"">
												Hora Inicio
											</div>
											<div class=""col-sm-8"">
												");
#nullable restore
#line 85 "D:\CEM-HIS\HistClinica\HistClinica\Views\Licencia\Registro.cshtml"
                                           Write(Html.DropDownListFor(m => m.horaInicio, new SelectList(ViewBag.listahoras), "Seleccione", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t\t\t\t\t\tHora Fin\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 95 "D:\CEM-HIS\HistClinica\HistClinica\Views\Licencia\Registro.cshtml"
                                           Write(Html.DropDownListFor(m => m.horaFin, new SelectList(ViewBag.listahoras), "Seleccione", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class=""row pt-4 pb-3"">
							<div class=""col-sm-12"">
								<div class=""row"">
									<div class=""col-sm-6"">
										<div class=""row"">
											<div class=""col-sm-4"">
												Fecha Inicio
											</div>
											<div class=""col-sm-8"">
												");
#nullable restore
#line 111 "D:\CEM-HIS\HistClinica\HistClinica\Views\Licencia\Registro.cshtml"
                                           Write(Html.TextBoxFor(m => m.fechaInicio, new { @class = "form-control", @type = "Date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t\t\t\t\t\tFecha Fin\r\n\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"col-sm-8\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 121 "D:\CEM-HIS\HistClinica\HistClinica\Views\Licencia\Registro.cshtml"
                                           Write(Html.TextBoxFor(m => m.fechaFin, new { @class = "form-control", @type = "Date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
											</div>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
					<div class=""col-sm-3"">

					</div>
				</div>

				<div class=""modal-footer"">
					<button style=""width: 80px;"" type=""submit"" class=""btn btn-primary"">Guardar</button>
					<button style=""width: 80px;"" type=""submit"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
				</div>
			</div>
");
#nullable restore
#line 139 "D:\CEM-HIS\HistClinica\HistClinica\Views\Licencia\Registro.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HistClinica.Models.LICENCIA> Html { get; private set; }
    }
}
#pragma warning restore 1591
