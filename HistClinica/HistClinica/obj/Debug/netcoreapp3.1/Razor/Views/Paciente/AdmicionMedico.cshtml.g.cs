#pragma checksum "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Paciente\AdmicionMedico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b16a2500e674b9daccc62796b6e94dafa3b07ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Paciente_AdmicionMedico), @"mvc.1.0.view", @"/Views/Paciente/AdmicionMedico.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b16a2500e674b9daccc62796b6e94dafa3b07ea", @"/Views/Paciente/AdmicionMedico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Paciente_AdmicionMedico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HistClinica.DTO.CitaDTO>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Paciente\AdmicionMedico.cshtml"
  
	ViewBag.Title = "ProgramarCitaAdmision";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t<div class=\"container\">\r\n\t\t<div class=\"row\">\r\n\t\t\t<div class=\"col-sm-12 text-left\">\r\n\t\t\t\t<div");
            BeginWriteAttribute("class", " class=\"", 231, "\"", 239, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t<div");
            BeginWriteAttribute("class", " class=\"", 252, "\"", 260, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t<h2>Listado de citas</h2>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
#nullable restore
#line 61 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Paciente\AdmicionMedico.cshtml"
         if (ViewBag.message != null)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"			<div class=""col-sm-12 alert alert-info alert-dismissible text-center"" role=""alert"" style=""margin-top: 15px;"">
				<button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""close"">
					<span aria-hidden=""true"">&times;</span>
				</button>
				");
#nullable restore
#line 67 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Paciente\AdmicionMedico.cshtml"
           Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n");
#nullable restore
#line 69 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Paciente\AdmicionMedico.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"		<div class=""row"" style=""padding-top: 80px;"">
			<div class=""col-sm-12"">
				<table class=""table table-bordered table-responsive table-hover"" style=""font-size:14px;"" id=""citamedicogrid"">
					<thead>
						<tr>
							<th>#</th>
							<th>N°</th>
							<th>Tipo</th>
							<th>Paciente</th>
							<th>Fecha</th>
							<th>Hora</th>
							<th>Producto</th>
							<th>Descripción</th>
							<th>Medico</th>
							<th>Especialidad</th>
							<th>Estado</th>
							<th>Est.Pago</th>
							<th>Total</th>
							<th>Acciones</th>
						</tr>
					</thead>
					<tbody>
");
#nullable restore
#line 92 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Paciente\AdmicionMedico.cshtml"
                         foreach (var item in Model)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 95 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Paciente\AdmicionMedico.cshtml"
                           Write(item.idCita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 96 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Paciente\AdmicionMedico.cshtml"
                           Write(item.nroCita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 97 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Paciente\AdmicionMedico.cshtml"
                           Write(item.TipoCita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td nowrap>");
#nullable restore
#line 98 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Paciente\AdmicionMedico.cshtml"
                                  Write(item.nombrePaciente);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td nowrap>");
#nullable restore
#line 99 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Paciente\AdmicionMedico.cshtml"
                                  Write(item.fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 100 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Paciente\AdmicionMedico.cshtml"
                           Write(item.hora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 101 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Paciente\AdmicionMedico.cshtml"
                           Write(item.consultorio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 102 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Paciente\AdmicionMedico.cshtml"
                           Write(item.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td nowrap>");
#nullable restore
#line 103 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Paciente\AdmicionMedico.cshtml"
                                  Write(item.medico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 104 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Paciente\AdmicionMedico.cshtml"
                           Write(item.especialidad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 105 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Paciente\AdmicionMedico.cshtml"
                           Write(item.descEstado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 106 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Paciente\AdmicionMedico.cshtml"
                           Write(item.descEstadoPago);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 107 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Paciente\AdmicionMedico.cshtml"
                           Write(item.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t<button title=\"Editar\" class=\"edit btn btn-primary\"><i class=\"fas fa-address-book\"></i></button>\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 112 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Paciente\AdmicionMedico.cshtml"
								}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</tbody>\r\n\t\t\t\t</table>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\r\n\r\n\r\n<div id=\"modalcambiarestado\" class=\"modal fade\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalLabel1\" aria-hidden=\"true\">\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b16a2500e674b9daccc62796b6e94dafa3b07ea10855", async() => {
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
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HistClinica.DTO.CitaDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
