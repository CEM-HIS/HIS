#pragma checksum "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9969824cf4dbc850d999ecdf0d5e181c5d540be8"
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
#line 1 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\_ViewImports.cshtml"
using HistClinica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\_ViewImports.cshtml"
using HistClinica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9969824cf4dbc850d999ecdf0d5e181c5d540be8", @"/Views/Persona/Edit.cshtml")]
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
#line 10 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                 using (Html.BeginForm("Edit", "Persona",FormMethod.Post, new { @id = "frmeditarpersona" }))
				{
					

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t<div class=\"col-md-6\">\r\n\t\t\t\t\t\t\t<div class=\"box box-primary\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 17 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                           Write(Html.HiddenFor(m => m.idPersona));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 18 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                           Write(Html.HiddenFor(m => m.personal.idMedico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 19 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                           Write(Html.HiddenFor(m => m.personal.idEmpleado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t<div class=\"box-body\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label>TIPO DE EMPLEADO</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 25 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.DropDownListFor(m => m.personal.idTipoEmpleado, new SelectList(ViewBag.lsttipoempleado, "idtab", "descripcion"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"txtNombres\">NOMBRES</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 31 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.nombres, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 32 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.nombres, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"txtNroDocumento\">DOCUMENTO DE IDENTIDAD</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 38 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.numeroDocumento, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 39 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.numeroDocumento, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"txtTelefono\">TELÉFONO</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 45 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.telefono, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 46 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.telefono, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"txtcargo\">CARGO</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 52 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.personal.cargo, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 53 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.personal.cargo, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 55 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                     if (Model.personal.idTipoEmpleado == 109)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t\t<label for=\"txtespecialidad\">ESPECIALIDAD</label>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 61 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                       Write(Html.DropDownListFor(m => m.personal.idEspecialidad, new SelectList(ViewBag.listaespecialidades, "idtab", "descripcion"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 62 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.personal.idEspecialidad, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 64 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
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
									</div>
									<div class=""form-group"">
										");
#nullable restore
#line 75 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.personal.descArea, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 76 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.personal.descArea, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"txtApPaterno\">APELLIDO PATERNO</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 82 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.apellidoPaterno, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 83 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.apellidoPaterno, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label for=\"txtApPaterno\">APELLIDO MATERNO</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 89 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.apellidoMaterno, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 90 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.apellidoMaterno, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label id=\"txtfecingresopersonal\">FECHA NACIMIENTO</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 96 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.fecNacimiento, new { htmlAttributes = new { @class = "form-control", @type = "Date" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 97 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.fecNacimiento, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label id=\"txtfecingresopersonal\">FECHA INGRESO</label>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 103 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.EditorFor(m => m.personal.fechaIngreso, new { htmlAttributes = new { @class = "form-control", @type = "Date" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 104 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                   Write(Html.ValidationMessageFor(model => model.personal.fechaIngreso, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 106 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                     if (Model.personal.idTipoEmpleado == 109)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t\t<label for=\"txtruc\">N° DE RUC</label>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 112 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                       Write(Html.EditorFor(m => m.ruc, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 113 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.ruc, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t\t<label for=\"txtNroColegio\">N° DE COLEGIO</label>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 119 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                       Write(Html.EditorFor(m => m.personal.numeroColegio, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 120 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.personal.numeroColegio, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 122 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
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
#line 132 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Persona\Edit.cshtml"
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
