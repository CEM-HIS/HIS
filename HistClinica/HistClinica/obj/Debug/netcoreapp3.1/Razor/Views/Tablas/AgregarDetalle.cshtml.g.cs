#pragma checksum "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\AgregarDetalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb85bc289b0ed0e14ccb1c8c420a348e372325c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tablas_AgregarDetalle), @"mvc.1.0.view", @"/Views/Tablas/AgregarDetalle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb85bc289b0ed0e14ccb1c8c420a348e372325c4", @"/Views/Tablas/AgregarDetalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Tablas_AgregarDetalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.Models.D00_TBDETALLE>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""modal-dialog modal-lg"" role=""document"">
	<div class=""modal-content"">
		<div class=""modal-header"">
			<h4 class=""modal-title text-center"" id=""exampleModalLabel"">Agregar Detalle</h4>
			<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
				<span aria-hidden=""true"">&times;</span>
			</button>
		</div>
");
#nullable restore
#line 12 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\AgregarDetalle.cshtml"
         using (Html.BeginForm("AgregarDetalle", "Tablas", FormMethod.Post, new { @id = "frmregistrardetalle" }))
		{
			

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\AgregarDetalle.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\AgregarDetalle.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\AgregarDetalle.cshtml"
       Write(Html.HiddenFor(m => m.idTab));

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"modal-body\">\r\n\r\n\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t<div class=\"col-md-6\">\r\n\r\n\r\n\t\t\t\t\t\t<div class=\"form-group\">\r\n\r\n\t\t\t\t\t\t\t<label>Codigo</label>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 26 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\AgregarDetalle.cshtml"
                       Write(Html.TextBoxFor(m => m.coddetTab, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 27 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\AgregarDetalle.cshtml"
                       Write(Html.ValidationMessageFor(m => m.coddetTab, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t<span class=\"text-danger\"></span>\r\n\t\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t\t<div class=\"form-group\">\r\n\r\n\t\t\t\t\t\t\t<label>Descripcion</label>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 34 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\AgregarDetalle.cshtml"
                       Write(Html.TextBoxFor(m => m.descripcion, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 35 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\AgregarDetalle.cshtml"
                       Write(Html.ValidationMessageFor(m => m.descripcion, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
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
#line 48 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\AgregarDetalle.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HistClinica.Models.D00_TBDETALLE> Html { get; private set; }
    }
}
#pragma warning restore 1591
