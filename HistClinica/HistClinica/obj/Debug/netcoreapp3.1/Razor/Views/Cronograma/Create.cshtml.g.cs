#pragma checksum "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b1bfe10b8bff778450ad2d875bb125f254ac5d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cronograma_Create), @"mvc.1.0.view", @"/Views/Cronograma/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b1bfe10b8bff778450ad2d875bb125f254ac5d3", @"/Views/Cronograma/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Cronograma_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.Models.CRONOGRAMA_MEDICO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/comboaninado.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
 using (Html.BeginForm("Create", "Cronograma", FormMethod.Post, new { @id = "frmcrearcronograma" }))
{
	

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"row pb-2\">\r\n\t\t<div class=\"col-sm-4\">\r\n\t\t\t<div class=\"row\">\r\n                <div class=\"col-sm-11\">\r\n                    <div class=\"input-style\">\r\n                        <label class=\"form-label\">Medico</label>\r\n\r\n                        ");
#nullable restore
#line 14 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
                   Write(Html.DropDownListFor(m => m.idMedico, new SelectList(ViewBag.listamedicos, "idMedico", "nombres"), "Seleccionar", new
                        {
                            @class = "form-control",
                       data_cascade_combo = "#stypes",
                       data_cascade_combo_source = Url.Action("GetEspecialidad", "Cronograma"),
                       data_cascade_combo_param_name = "id"
                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 21 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.idMedico, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    </div>
                </div>
		</div>
		<div class=""col-sm-4"">
			<div class=""row"">
                <div class=""col-sm-11"">
                    <div class=""input-style"">
                        <label class=""form-label"">Especialidad</label>
                        ");
#nullable restore
#line 31 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
                   Write(Html.DropDownListFor(m => m.idEspecialidad, new SelectList(ViewBag.listaespecialidades, "idtab", "descripcion"), "Seleccionar", new { @class = "form-control", id = "stypes" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 32 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.idEspecialidad, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
             </div>
		</div>
		<div class=""col-sm-4"">
			<div class=""row"">
                <div class=""col-sm-11"">
                    <div class=""input-style"">
                        <label class=""form-label"">Consultorio</label>
                        ");
#nullable restore
#line 42 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
                   Write(Html.DropDownListFor(m => m.idConsultorio, new SelectList(ViewBag.listaconsultorio, "idtab", "descripcion"), "Seleccionar", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 43 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.idConsultorio, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
				</div>
            </div>
		</div>
	</div>
    <div class=""row pb-2"">
        <div class=""col-sm-4"">
            <div class=""row"">
                <div class=""col-sm-11"">
                    <div class=""input-style"">
                        <label class=""form-label"">Fecha Inicio</label>
                        ");
#nullable restore
#line 55 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
                   Write(Html.TextBoxFor(m => m.fechaInicio, new { @class = "form-control", @type = "Date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 56 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.fechaInicio, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </div>

                </div>
            </div>
        </div>
        <div class=""col-sm-4"">
            <div class=""row"">
                <div class=""col-sm-11"">
                    <div class=""input-style"">
                        <label class=""form-label"">Fecha Fin</label>
                        ");
#nullable restore
#line 68 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
                   Write(Html.TextBoxFor(m => m.fechaFin, new { @class = "form-control", @type = "Date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 69 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.fechaFin, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-sm-4"">
            <div class=""row"">
                <div class=""col-sm-11"">
                    <div class=""input-style"">
                        <label class=""form-label"">Hora Inicio</label>
                        ");
#nullable restore
#line 79 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
                   Write(Html.DropDownListFor(m => m.horaInicio, new SelectList(ViewBag.listahoras), "Seleccione", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 80 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.horaInicio, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-sm-4 pt-2"">
            <div class=""row"">
                <div class=""col-sm-11"">
                    <div class=""input-style"">
                        <label class=""form-label"">Hora Fin</label>
                        ");
#nullable restore
#line 90 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
                   Write(Html.DropDownListFor(m => m.horaFin, new SelectList(ViewBag.listahoras), "Seleccione", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 91 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.horaFin, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-sm-4 pt-2"">
            <div class=""row"">
                <div class=""col-sm-11"">
                    <div class=""input-style"">
                        <label class=""form-label"">Intervalo</label>
                        ");
#nullable restore
#line 101 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
                   Write(Html.DropDownListFor(m => m.intervalo, new SelectList(ViewBag.intervalos), "Seleccione", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 102 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.intervalo, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\t<div class=\"row pb-2 text-right\">\r\n\t\t<div class=\"col-sm-12\">\r\n\t\t\t<button class=\"btn btn-primary\" id=\"Crear\">Guardar</button>\r\n\t\t</div>\r\n\t</div>\r\n");
#nullable restore
#line 113 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b1bfe10b8bff778450ad2d875bb125f254ac5d313351", async() => {
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
#line 116 "C:\Users\FABRICIO\Desktop\HIs\HIS\HistClinica\HistClinica\Views\Cronograma\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HistClinica.Models.CRONOGRAMA_MEDICO> Html { get; private set; }
    }
}
#pragma warning restore 1591
