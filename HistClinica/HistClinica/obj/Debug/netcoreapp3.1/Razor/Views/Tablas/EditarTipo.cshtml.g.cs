#pragma checksum "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Tablas\EditarTipo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cc9a80a02b64de9efd00afed37cd1ba24041bc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tablas_EditarTipo), @"mvc.1.0.view", @"/Views/Tablas/EditarTipo.cshtml")]
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
#line 1 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\_ViewImports.cshtml"
using HistClinica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\_ViewImports.cshtml"
using HistClinica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc9a80a02b64de9efd00afed37cd1ba24041bc2", @"/Views/Tablas/EditarTipo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Tablas_EditarTipo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.Models.TABLA_GENERAL>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""modal-dialog modal-lg"" role=""document"">
	<div class=""modal-content"">
		<div class=""modal-header"">
			<h4 class=""modal-title text-center"" id=""exampleModalLabel"">Editar Tipo</h4>
			<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
				<span aria-hidden=""true"">&times;</span>
			</button>
		</div>
");
#nullable restore
#line 11 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Tablas\EditarTipo.cshtml"
         using (Html.BeginForm(FormMethod.Post, new { @id = "frmeditartipo" }))
		{
			

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Tablas\EditarTipo.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Tablas\EditarTipo.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Tablas\EditarTipo.cshtml"
       Write(Html.HiddenFor(m => m.idTablaGeneral));

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"modal-body\">\r\n\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t<div class=\"col-md-6\">\r\n\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t<label class=\"control-label\">Codigo</label>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 21 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Tablas\EditarTipo.cshtml"
                       Write(Html.EditorFor(m => m.codigoTablaGeneral, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 22 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Tablas\EditarTipo.cshtml"
                       Write(Html.ValidationMessageFor(m => m.codigoTablaGeneral, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t<label class=\"control-label\">Descripcion</label>\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 26 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Tablas\EditarTipo.cshtml"
                       Write(Html.EditorFor(m => m.descripcion, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 27 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Tablas\EditarTipo.cshtml"
                       Write(Html.ValidationMessageFor(m => m.descripcion, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
							<span class=""text-danger""></span>
						</div>
					</div>
				</div>
			</div>
			<div class=""modal-footer"">
				<button style=""width: 80px;"" type=""submit"" class=""btn btn-primary"">Guardar</button>
				<button style=""width: 80px;"" type=""submit"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
			</div>
");
#nullable restore
#line 37 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Tablas\EditarTipo.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HistClinica.Models.TABLA_GENERAL> Html { get; private set; }
    }
}
#pragma warning restore 1591
