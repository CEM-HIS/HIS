#pragma checksum "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Tablas\VistaDetalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86adb104bbb3bae6b89413dbb02988334db49375"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tablas_VistaDetalle), @"mvc.1.0.view", @"/Views/Tablas/VistaDetalle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86adb104bbb3bae6b89413dbb02988334db49375", @"/Views/Tablas/VistaDetalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Tablas_VistaDetalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.DTO.DetalleDTO>
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
#nullable restore
#line 2 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Tablas\VistaDetalle.cshtml"
  
	ViewData["Title"] = "Actualizar";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\t<div class=\"col-sm-12 pb-2\">\r\n\t\t");
#nullable restore
#line 9 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Tablas\VistaDetalle.cshtml"
   Write(Html.ActionLink("Volver", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</div>\r\n\t<div class=\"col-sm-12 pb-3\">\r\n\t\t<h1>Actualizar Tipo</h1>\r\n\t</div>\r\n\t<div class=\"col-sm-12\">\r\n\t\t<div class=\"row\">\r\n\t\t\t<div class=\"col-sm-6 form-inline\">\r\n\t\t\t\t<label> Codigo:</label>\r\n\t\t\t\t");
#nullable restore
#line 18 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Tablas\VistaDetalle.cshtml"
           Write(Html.HiddenFor(m => m.idTab));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t");
#nullable restore
#line 19 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Tablas\VistaDetalle.cshtml"
           Write(Html.EditorFor(m => m.codTab, new { htmlAttributes = new { @class = "form-control", @disabled = "true" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-sm-6\">\r\n\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n");
#nullable restore
#line 28 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Tablas\VistaDetalle.cshtml"
 if (ViewBag.message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"	<div class=""col-sm-12 alert alert-info alert-dismissible text-center"" id=""success-alert"" role=""alert"" style=""margin-top: 15px;"">
		<button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""close"">
			<span aria-hidden=""true"">&times;</span>
		</button>
		");
#nullable restore
#line 34 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Tablas\VistaDetalle.cshtml"
   Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</div>\r\n");
#nullable restore
#line 36 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Tablas\VistaDetalle.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
	<div class=""col-sm-12 text-right pt-4"">
		<a type=""submit"" style=""color:white;"" class=""btn btn-primary"" onclick=""cargarmodalCrearDetalle()"">Crear</a><br /><br />
	</div>
	<div class=""col-sm-12"">
		<table class=""table table-bordered table-hover"" id=""detallegrid"">
			<thead>
				<tr>
					<th style=""visibility:hidden;"">
						Id
					</th>
					<th>
						Codigo
					</th>
					<th>
						Descripcion
					</th>
					<th>
						Acciones
					</th>
				</tr>
			</thead>
			<tbody class=""tbody"">
");
#nullable restore
#line 61 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Tablas\VistaDetalle.cshtml"
                 foreach (var item in Model.ldetalle)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td style=\"visibility:hidden;\">");
#nullable restore
#line 64 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Tablas\VistaDetalle.cshtml"
                                                  Write(item.idDet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 65 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Tablas\VistaDetalle.cshtml"
                       Write(item.coddetTab);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 66 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Tablas\VistaDetalle.cshtml"
                       Write(item.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
						<td>
							<a style=""color:white;"" type=""submit"" class=""edit btn btn-primary"" aria-hidden=""true"">
								<i class=""fas fa-edit""></i>
							</a>
							<a style=""color:white;"" type=""submit"" class=""delete btn btn-danger"" aria-hidden=""true"">
								<i class=""fas fa-minus""></i>
							</a>
						</td>
					</tr>
");
#nullable restore
#line 76 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Tablas\VistaDetalle.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"			</tbody>
		</table>
	</div>
</div>
<div class=""modal fade"" id=""modalagregardetalle"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
</div>
<div class=""modal fade"" id=""modaleditardetalle"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
</div>
<div class=""modal fade"" id=""modalanulardetalle"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86adb104bbb3bae6b89413dbb02988334db493758901", async() => {
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
#line 90 "C:\Users\FABRICIO\Documents\GitHub\HIS\HistClinica\HistClinica\Views\Tablas\VistaDetalle.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HistClinica.DTO.DetalleDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
