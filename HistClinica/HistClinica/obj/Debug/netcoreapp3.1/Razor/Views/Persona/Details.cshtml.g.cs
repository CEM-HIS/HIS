#pragma checksum "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9279a610fc0e18c75a728a81899a189a926b499"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persona_Details), @"mvc.1.0.view", @"/Views/Persona/Details.cshtml")]
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
#line 1 "D:\HIS\HIS\HistClinica\HistClinica\Views\_ViewImports.cshtml"
using HistClinica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HIS\HIS\HistClinica\HistClinica\Views\_ViewImports.cshtml"
using HistClinica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9279a610fc0e18c75a728a81899a189a926b499", @"/Views/Persona/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_Persona_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HistClinica.Models.PERSONA>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Persona</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.apePaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.apePaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.apeMaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.apeMaterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idtpDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.idtpDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.dniPersona));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.dniPersona));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idSexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.idSexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idEtnico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.idEtnico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.fecNace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.fecNace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idUbigeoResi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.idUbigeoResi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idtipoVia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.idtipoVia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nombreVia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.nombreVia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nroVia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.nroVia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nroDpto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.nroDpto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.interior));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.interior));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.manzana));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.manzana));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nroLote));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.nroLote));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nroKm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 113 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.nroKm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 116 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nroBlock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 119 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.nroBlock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 122 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nroEtapa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 125 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.nroEtapa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 128 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 131 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 134 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idUbigeoNace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 137 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.idUbigeoNace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 140 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.fotografia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 143 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.fotografia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 146 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idGrdInstruc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 149 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.idGrdInstruc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 152 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idReligion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 155 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.idReligion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 158 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.centroEduca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 161 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.centroEduca));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 164 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idEstCivil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 167 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.idEstCivil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 170 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idOcupacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 173 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.idOcupacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 176 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idgpoSangre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 179 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.idgpoSangre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 182 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idFactorrh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 185 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.idFactorrh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 188 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.nroRuc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 191 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.nroRuc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 194 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.razonSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 197 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.razonSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 200 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.estadoRuc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 203 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.estadoRuc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 206 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.condicionRuc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 209 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.condicionRuc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 212 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.domiFiscal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 215 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.domiFiscal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 218 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idParentesco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 221 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.idParentesco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 224 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 227 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 230 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 233 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 236 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 239 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 242 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.iddatoSiteds));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 245 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.iddatoSiteds));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 248 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idemprConvenio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 251 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.idemprConvenio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 254 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idciaSeguro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 257 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.idciaSeguro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 260 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idtipoIafa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 263 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.idtipoIafa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 266 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 269 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
       Write(Html.DisplayFor(model => model.estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9279a610fc0e18c75a728a81899a189a926b49930255", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 274 "D:\HIS\HIS\HistClinica\HistClinica\Views\Persona\Details.cshtml"
                           WriteLiteral(Model.idPersona);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9279a610fc0e18c75a728a81899a189a926b49932390", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HistClinica.Models.PERSONA> Html { get; private set; }
    }
}
#pragma warning restore 1591
