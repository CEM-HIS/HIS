#pragma checksum "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a0942f4a7fd3c15685a075873a5159e2f7ba26f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persona_Index), @"mvc.1.0.view", @"/Views/Persona/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a0942f4a7fd3c15685a075873a5159e2f7ba26f", @"/Views/Persona/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Persona_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HistClinica.DTO.PersonaDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Persona", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 152px;font-size: 16px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/cargavistaparcial.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Index.cshtml"
  
	ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
	<div class=""col-sm-12"">
		<div class=""row"">
			<div class=""col-sm-12 text-center"">
				<div class=""card card-primary"">
					<div class=""card-header"">
						<h2>Gestion de personal</h2>
					</div>
				</div>
			</div>
		</div>
	</div>
	<div class=""col-sm-12"" style=""padding-top:50px;"">
");
#nullable restore
#line 20 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Index.cshtml"
         using (Html.BeginForm())
		{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"			<div class=""row"">
				<div class=""col-sm-9"">
					<div class=""row"">
						<div class=""col-sm-4"">
							<div class=""col-sm-12"">
								<label>
									Dni:
								</label>
							</div>
							<div class=""col-sm-12 form-inline"">
								<input type=""text"" id=""dniper"" name=""dniper"" class=""form-control"" style=""width:200px;"" />
							</div>
						</div>
						<div class=""col-sm-4"">
							<div class=""col-sm-12"">
								<label>
									Nombre:
								</label>
							</div>
							<div class=""col-sm-12 form-inline"">
								<input type=""text"" id=""nombre"" name=""nombre"" class=""form-control"" style=""width:200px;"" />
							</div>
						</div>
						<div class=""col-sm-4"">
							<div class=""col-sm-12"">
								<label>
									Apellidos:
								</label>
							</div>
							<div class=""col-sm-12 form-inline"">
								<input onkeydown=""buscar(event)"" type=""text"" id=""apellido"" name=""apellido"" class=""form-control"" style=""width:200px;"" />
								<button type=""submit"" onclick=""getB");
            WriteLiteral("yNombre();\" class=\"btn btn-primary\"><i class=\"fa fa-search\" aria-hidden=\"true\"></i></button>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-sm-3\">\r\n\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 62 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n\t<div class=\"col-sm-12\" style=\"padding-top: 30px;\">\r\n\t\t<div class=\"row\">\r\n\t\t\t<div class=\"col-sm-6\">\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-sm-6 text-right\" style=\"padding-bottom: 10px\">\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a0942f4a7fd3c15685a075873a5159e2f7ba26f7458", async() => {
                WriteLiteral("Agregar Personal");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n");
#nullable restore
#line 73 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Index.cshtml"
     if (ViewBag.message != null)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"		<div class=""col-sm-12 alert alert-info alert-dismissible text-center"" id=""success-alert"" role=""alert"" style=""margin-top: 15px;"">
			<button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""close"">
				<span aria-hidden=""true"">&times;</span>
			</button>
			");
#nullable restore
#line 79 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Index.cshtml"
       Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n");
#nullable restore
#line 81 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"	<div class=""col-sm-12"">
		<div class=""box-body table-responsive"">
			<table class=""table table-striped table-hover text-center"" id=""personalgrid"">
				<thead>
					<tr>
						<th>Código</th>
						<th>Nombres</th>
						<th>Apellido</th>
						<th>Fecha Ingreso</th>
						<th>Teléfono</th>
						<th>Cargo</th>
						<th>Acciones</th>
					</tr>
				</thead>
				<tbody>
");
#nullable restore
#line 97 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Index.cshtml"
                     foreach (var item in Model)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 100 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Index.cshtml"
                           Write(item.idPersona);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 101 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Index.cshtml"
                           Write(item.nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 102 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Index.cshtml"
                           Write(item.apellidoPaterno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 103 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Index.cshtml"
                           Write(item.personal.fechaIngreso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 104 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Index.cshtml"
                           Write(item.telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t<td>");
#nullable restore
#line 105 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Index.cshtml"
                           Write(item.personal.cargo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
							<td>
								<button title=""Editar"" type=""submit"" class=""edit btn btn-primary""><i class=""fas fa-edit""></i></button>
								<button title=""Asignar"" type=""submit"" class=""asig btn btn-primary""><i class=""fas fa-id-badge""></i></button>
								<button title=""Eliminar"" type=""submit"" class=""delete btn btn-danger""><i class=""fas fa-minus""></i></button>
							</td>
						</tr>
");
#nullable restore
#line 112 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"				</tbody>
			</table>
		</div>
	</div>
</div>

<div class=""modal fade"" id=""modalestado"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
	<div class=""modal-dialog"" role=""document"">
		<div class=""modal-content"">
			<button style=""text-align:right;"" type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
				<span aria-hidden=""true"">&times;</span>
			</button>
			<div class=""modal-body"">
				<div class=""col-sm-12 text-center"" style=""padding-bottom: 10px;"">
					<h2 id=""exampleModalLabel"">Aviso!</h2>
				</div>
				<div class=""col-sm-12 text-center"" style=""padding-top: 10px; padding-bottom:10px;"">
					<h4>¿Desea cambiar el estado del personal?</h4>
				</div>
			</div>
			<div class=""modal-footer"">
				<button style=""width: 80px;"" type=""button"" id=""btnaceptar"" class=""btn btn-primary"">Si</button>
				<button style=""width: 80px;"" type=""button"" data-dismiss=""modal"" class=""btn btn-primary"">No</button>
			</div>
		</div>
	</div>
</div>


            WriteLiteral(@"

<div class=""modal fade"" id=""modalasignar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">
</div>
<div class=""modal fade"" id=""modaleditar"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">

</div>
<div class=""modal fade"" id=""modaldeletepersona"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">

</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a0942f4a7fd3c15685a075873a5159e2f7ba26f14216", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
#line 153 "D:\CEM-HIS\HistClinica\HistClinica\Views\Persona\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HistClinica.DTO.PersonaDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591