#pragma checksum "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09bf1bbc681156a5911e45821367cf7d8ed41079"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persona_Edit), @"mvc.1.0.view", @"/Views/Persona/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09bf1bbc681156a5911e45821367cf7d8ed41079", @"/Views/Persona/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Persona_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.DTO.PersonaDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal-dialog modal-lg"" role=""document"">
	<div class=""modal-content"">
		<button style=""text-align:right"" type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
		<div class=""container"">
			<div class=""col-sm-12 text-center"">
				<h4 class=""modal-title"" id=""myModalLabel"">Actualizar registro</h4>
			</div>
			<div class=""col-sm-12 pt-4"">
");
#nullable restore
#line 10 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                 using (Html.BeginForm("Edit", "Persona",FormMethod.Post, new { @id = "frmeditarpersona" }))
				{
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t<div class=\"col-md-6\">\r\n\t\t\t\t\t\t\t<div class=\"box box-primary\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 17 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                           Write(Html.HiddenFor(m => m.idPersona));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 18 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                           Write(Html.HiddenFor(m => m.personal.idMedico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 19 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                           Write(Html.HiddenFor(m => m.personal.idEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t<div class=\"box-body\">\r\n\t\t\t\t\t\t\t\t\t\r\n                                    <div class=\"form-group\">\r\n                                        <label>TIPO DE EMPLEADO</label>\r\n                                        ");
#nullable restore
#line 24 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.DropDownListFor(m => m.personal.idTipoEmpleado, new SelectList(ViewBag.lsttipoempleado, "idtab", "descripcion"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n\t\t\t\t\t\t\t\t\t\r\n                                    <div class=\"form-group\">\r\n                                        <label for=\"txtNombres\">NOMBRES</label>\r\n                                        ");
#nullable restore
#line 29 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.nombres, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 30 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.nombres, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
									
                                    <div class=""form-group"">
                                        <label for=""txtNroDocumento"">DOCUMENTO DE IDENTIDAD</label>
                                        ");
#nullable restore
#line 35 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.numeroDocumento, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 36 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.numeroDocumento, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n\t\t\t\t\t\t\t\t\t\r\n                                    <div class=\"form-group\">\r\n                                        <label for=\"txtTelefono\">TELÉFONO</label>\r\n                                        ");
#nullable restore
#line 41 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.telefono, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 42 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.telefono, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n\t\t\t\t\t\t\t\t\t\r\n                                    <div class=\"form-group\">\r\n                                        <label for=\"txtcargo\">CARGO</label>\r\n                                        ");
#nullable restore
#line 47 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.personal.cargo, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 48 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.personal.cargo, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 50 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                     if (Model.personal.idTipoEmpleado == 109)
									{
										

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"form-group\">\r\n                                            <label for=\"txtespecialidad\">ESPECIALIDAD</label>\r\n                                            ");
#nullable restore
#line 55 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                       Write(Html.DropDownListFor(m => m.personal.idEspecialidad, new SelectList(ViewBag.listaespecialidades, "idtab", "descripcion"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            ");
#nullable restore
#line 56 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.personal.idEspecialidad, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n");
#nullable restore
#line 58 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"								</div>
							</div>
						</div>
						<div class=""col-md-6"">
							<div class=""box box-primary"">
								<div class=""box-body"">
								
                                    <div class=""form-group"">
                                        <label for=""txtarea"">AREA</label>
                                        ");
#nullable restore
#line 68 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.personal.descripcionArea, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 69 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.personal.descripcionArea, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n\t\t\t\t\t\t\t\t\t\r\n                                    <div class=\"form-group\">\r\n                                        <label for=\"txtApPaterno\">APELLIDO PATERNO</label>\r\n                                        ");
#nullable restore
#line 74 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.apellidoPaterno, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 75 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.apellidoPaterno, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n\t\t\t\t\t\t\t\t\t\r\n                                    <div class=\"form-group\">\r\n                                        <label for=\"txtApPaterno\">APELLIDO MATERNO</label>\r\n                                        ");
#nullable restore
#line 80 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.apellidoMaterno, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 81 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.apellidoMaterno, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
								
                                    <div class=""form-group"">
                                        <label id=""txtfecingresopersonal"">FECHA NACIMIENTO</label>
                                        ");
#nullable restore
#line 86 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.fechaNacimiento, new { htmlAttributes = new { @class = "form-control", @type = "Date" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 87 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.fechaNacimiento, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"form-group\">\r\n                                        <label id=\"txtfecingresopersonal\">FECHA INGRESO</label>\r\n                                        ");
#nullable restore
#line 91 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.personal.fechaIngreso, new { htmlAttributes = new { @class = "form-control", @type = "Date" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 92 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.personal.fechaIngreso, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n");
#nullable restore
#line 94 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                     if (Model.personal.idTipoEmpleado == 109)
									{
										

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"form-group\">\r\n                                            <label for=\"txtruc\">N° DE RUC</label>\r\n                                            ");
#nullable restore
#line 99 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                       Write(Html.EditorFor(m => m.numeroRuc, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            ");
#nullable restore
#line 100 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.numeroRuc, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n");
            WriteLiteral("                                        <div class=\"form-group\">\r\n                                            <label for=\"txtNroColegio\">N° DE COLEGIO</label>\r\n                                            ");
#nullable restore
#line 105 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                       Write(Html.EditorFor(m => m.personal.numeroColegio, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            ");
#nullable restore
#line 106 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.personal.numeroColegio, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n");
#nullable restore
#line 108 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"								</div>
							</div>
						</div>
					</div>
					<div class=""row m-0 p-0 pb-2"">
						<div class=""col-sm-12 text-right"">
							<input type=""submit"" class=""btn btn-primary"" style=""width: 112px;font-size: 16px;"" value=""Guardar"">
						</div>
					</div>
");
#nullable restore
#line 118 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>");
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
