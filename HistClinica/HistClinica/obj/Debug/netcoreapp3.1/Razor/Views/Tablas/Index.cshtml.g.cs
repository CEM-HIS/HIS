#pragma checksum "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fdfeef4be043b302f676d6d22f77cee1c922baa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tablas_Index), @"mvc.1.0.view", @"/Views/Tablas/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fdfeef4be043b302f676d6d22f77cee1c922baa", @"/Views/Tablas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Tablas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HistClinica.Models.TABLA_GENERAL>>
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
#line 2 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\t<div class=\"col-sm-12 pb-5\">\r\n\t\t<h1 align=\"center\">Gestion de Tipos</h1>\r\n\t</div>\r\n\t<div class=\"col-sm-12\">\r\n");
#nullable restore
#line 12 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\Index.cshtml"
         using (Html.BeginForm())
		{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"			<div class=""row"">
				<div class=""col-sm-8 form-inline"">
					<label class=""pr-2"">Codigo:</label>
					<input type=""text"" id=""codigo"" class=""form form-control"" name=""codigo"" />

					<label class=""pl-3 pr-2"">Descripcion:</label>
					<input type=""text"" id=""descripcion"" class=""form form-control"" name=""descripcion"" />
					<input type=""submit"" value=""Buscar"" class=""pl-2 btn btn-primary"" />
				</div>
				<div class=""col-sm-4"">

				</div>
			</div>
");
#nullable restore
#line 27 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n</div>\r\n");
#nullable restore
#line 30 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\Index.cshtml"
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
#line 36 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\Index.cshtml"
   Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t</div>\r\n");
#nullable restore
#line 38 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
	<div class=""col-sm-12 text-right pt-4"">
		<a type=""submit"" style=""color:white;"" class=""btn btn-primary"" onclick=""cargarmodalCrearTipo();"">Crear</a><br /><br />
	</div>
	<div class=""col-sm-12"">
		<table class=""table table-bordered table-hover"" id=""generalgrid"">
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
#line 62 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\Index.cshtml"
                 foreach (var item in Model)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td style=\"visibility:hidden;\">");
#nullable restore
#line 65 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\Index.cshtml"
                                                  Write(item.idTablaGeneral);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 66 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\Index.cshtml"
                       Write(item.codigoTablaGeneral);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 67 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\Index.cshtml"
                       Write(item.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t<a type=\"submit\" style=\"color:white;\" class=\"edit btn btn-primary\" aria-hidden=\"true\">\r\n\t\t\t\t\t\t\t\t<i class=\"fas fa-edit\"></i>\r\n\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 72 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\Index.cshtml"
                       Write(Html.ActionLink("Detalle", "VistaDetalle", new { id = item.idTablaGeneral }, new { @class = "btn btn-primary fas fa-search" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t<a type=\"submit\" style=\"color:white;\" class=\"delete btn btn-danger\" aria-hidden=\"true\">\r\n\t\t\t\t\t\t\t\t<i class=\"fas fa-minus\"></i>\r\n\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 78 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"			</tbody>
		</table>
	</div>
</div>
<div class=""modal fade"" id=""modalagregartipo"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
</div>
<div class=""modal fade"" id=""modaleditartipo"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
</div>
<div class=""modal fade"" id=""modalanulartipo"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9fdfeef4be043b302f676d6d22f77cee1c922baa8684", async() => {
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
#line 91 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HistClinica.Models.TABLA_GENERAL>> Html { get; private set; }
    }
}
#pragma warning restore 1591
