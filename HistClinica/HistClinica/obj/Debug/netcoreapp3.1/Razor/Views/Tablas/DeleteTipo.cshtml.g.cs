#pragma checksum "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\DeleteTipo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7665ca237e42ced3ecbd8b6acd22ac04842fd900"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tablas_DeleteTipo), @"mvc.1.0.view", @"/Views/Tablas/DeleteTipo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7665ca237e42ced3ecbd8b6acd22ac04842fd900", @"/Views/Tablas/DeleteTipo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Tablas_DeleteTipo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.Models.TABLAGENERAL>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"<div class=""modal-dialog modal-md"" role=""document"">
	<div class=""modal-content"">
		<div class=""modal-header"">
			<h2 class=""modal-title text-center"" id=""exampleModalLabel1"">¡Aviso!</h2>
			<button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
				<span aria-hidden=""true"">&times;</span>
			</button>
		</div>
");
#nullable restore
#line 12 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\DeleteTipo.cshtml"
         using (Html.BeginForm("DeleteTipo", "Tablas"))
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"container\">\r\n\t\t\t\t<div class=\"col-sm-12 pt-2 pb-3\">\r\n\t\t\t\t\t¿Esta seguro que desea eliminar el tipo?\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"col-sm-12 pb-3\">\r\n\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t<div class=\"col-sm-6 text-center\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 21 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\DeleteTipo.cshtml"
                       Write(Html.HiddenFor(m => m.idTab));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
							<button style=""width:100px;"" type=""submit"" class=""btn btn-success"">Si</button>
						</div>
						<div class=""col-sm-6 text-center"">
							<a style=""width:100px;color:white"" class=""btn btn-primary"" data-dismiss=""modal"">No</a>
						</div>
					</div>
				</div>
			</div>
");
#nullable restore
#line 30 "D:\CEM-HIS\HistClinica\HistClinica\Views\Tablas\DeleteTipo.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HistClinica.Models.TABLAGENERAL> Html { get; private set; }
    }
}
#pragma warning restore 1591
