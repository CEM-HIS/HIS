#pragma checksum "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ff8d2bc35991aec8195b9489d05f18b16bd0fa1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persona_Create), @"mvc.1.0.view", @"/Views/Persona/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ff8d2bc35991aec8195b9489d05f18b16bd0fa1", @"/Views/Persona/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Persona_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.DTO.PersonaDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ActionsPersona.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
  
	ViewBag.Title = "Registro";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
	<div class=""col-sm-12"">
		<div class=""row"">
			<div class=""col-sm-12 pb-2"">
				<div class=""card card-primary"">
					<div class=""card-header"">
						<h2>Registro de personal</h2>
					</div>
				</div>
			</div>
		</div>
	</div>
	<div class=""col-sm-12"">
");
#nullable restore
#line 21 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
         using (Html.BeginForm())
		{
			

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col-md-6\">\r\n\t\t\t\t\t<div class=\"box box-primary\">\r\n\t\t\t\t\t\t<div class=\"box-body\">\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label>TIPO DE EMPLEADO</label>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 33 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.DropDownListFor(m => m.personal.idTipoEmpleado, new SelectList(ViewBag.lsttipoempleado, "idtab", "descripcion"), new { @class = "form-control", @id = "cboemple" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label for=\"txtNombres\">NOMBRES</label>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 39 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.TextBoxFor(m => (m.nombres), new { @class = "form-control", tabindex = 2 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 40 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.nombres, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label for=\"txtNroDocumento\">DOCUMENTO DE IDENTIDAD</label>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 46 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.numeroDocumento, new { @class = "form-control", tabindex = 5, @onkeypress = "return isNumberKey(event);" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 47 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.numeroDocumento, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label for=\"txtcargo\">CARGO</label>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 53 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.personal.cargo, new { @class = "form-control", tabindex = 7 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 54 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.personal.cargo, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label for=\"txtTelefono\">TELÉFONO</label>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 60 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.telefono, new { @class = "form-control", tabindex = 9, @onkeypress = "return isNumberKey(event);" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 61 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.telefono, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div id=\"esp1\" class=\"form-group\" style=\"display:none;\">\r\n\t\t\t\t\t\t\t\t<label for=\"txtespecialidad\">ESPECIALIDAD</label>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div id=\"esp2\" class=\"form-group\" style=\"display:none;\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 67 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.DropDownListFor(m => m.personal.idEspecialidad, new SelectList(ViewBag.listaespecialidades, "idtab", "descripcion"), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
							</div>
						</div>
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
#line 79 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.personal.descArea, new { @class = "form-control", tabindex = 1 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 80 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.ValidationMessageFor(m => m.personal.descArea, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label for=\"txtApPaterno\">APELLIDO PATERNO</label>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 86 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.TextBoxFor(m => (m.apellidoPaterno), new { @class = "form-control", tabindex = 3 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 87 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.ValidationMessageFor(m => m.apellidoPaterno, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label for=\"txtApPaterno\">APELLIDO MATERNO</label>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 93 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.TextBoxFor(m => (m.apellidoMaterno), new { @class = "form-control", tabindex = 6 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 94 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.ValidationMessageFor(m => m.apellidoMaterno, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label id=\"txtfecingresopersonal\">FECHA NACIMIENTO</label>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 100 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.fecNacimiento , "{0:yyyy-MM-dd}", new { @class = "form-control", @type = "Date", tabindex = 8, @Value = @DateTime.Now.ToShortDateString() }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 101 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.ValidationMessageFor(m => m.fecNacimiento, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label id=\"txtfecingresopersonal\">FECHA INGRESO</label>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 107 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.personal.fechaIngreso, new { @class = "form-control", @type = "Date", tabindex = 10 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 108 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.ValidationMessageFor(m => m.personal.fechaIngreso, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div id=\"ruc1\" class=\"form-group\" style=\"display:none;\">\r\n\t\t\t\t\t\t\t\t<label for=\"txtruc\">N° DE RUC</label>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div id=\"ruc2\" class=\"form-group\" style=\"display:none;\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 114 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.ruc, new { @class = "form-control", tabindex = 11, @onkeypress = "return isNumberKey(event);" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 115 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.ValidationMessageFor(m => m.ruc, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div id=\"col1\" class=\"form-group\" style=\"display:none;\">\r\n\t\t\t\t\t\t\t\t<label for=\"txtNroColegio\">N° DE COLEGIO</label>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div id=\"col2\" class=\"form-group\" style=\"display:none;\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 121 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.TextBoxFor(m => m.personal.numeroColegio, new { @class = "form-control", tabindex = 12, @onkeypress = "return isNumberKey(event);" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 122 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
                           Write(Html.ValidationMessageFor(m => m.personal.numeroColegio, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
							</div>
						</div>
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
#line 133 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ff8d2bc35991aec8195b9489d05f18b16bd0fa116228", async() => {
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
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 138 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Create.cshtml"
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