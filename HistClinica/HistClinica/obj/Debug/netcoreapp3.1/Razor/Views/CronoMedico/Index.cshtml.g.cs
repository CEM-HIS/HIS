#pragma checksum "D:\CEM-HIS\HistClinica\HistClinica\Views\CronoMedico\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92a39cd3865bb1fde79217ba1df172d4c7a1ebe5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CronoMedico_Index), @"mvc.1.0.view", @"/Views/CronoMedico/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92a39cd3865bb1fde79217ba1df172d4c7a1ebe5", @"/Views/CronoMedico/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c984c30cb32e7b6efe2821e88d8d5cb74c62abd8", @"/Views/_ViewImports.cshtml")]
    public class Views_CronoMedico_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "red", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "blue", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "black", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "green", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-12 form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\CEM-HIS\HistClinica\HistClinica\Views\CronoMedico\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>
<div id=""calender""></div>

<div id=""myModal"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title""><span id=""eventTitle""></span></h4>
            </div>
            <div class=""modal-body"">
                <button id=""btnDelete"" class=""btn btn-default btn-sm pull-right"">
                    <span class=""glyphicon glyphicon-remove""></span> Remove
                </button>
                <button id=""btnEdit"" class=""btn btn-default btn-sm pull-right"" style=""margin-right:5px;"">
                    <span class=""glyphicon glyphicon-pencil""></span> Edit
                </button>
                <p id=""pDetails""></p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</butto");
            WriteLiteral(@"n>
            </div>
        </div>
    </div>
</div>

<div id=""myModalSave"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 class=""modal-title"">Save Event</h4>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92a39cd3865bb1fde79217ba1df172d4c7a1ebe56996", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" id=""hdEventID"" value=""0"" />
                    <div class=""form-group"">
                        <label>Subject</label>
                        <input type=""text"" id=""txtSubject"" class=""form-control"" />
                    </div>
                    <div class=""form-group"">
                        <label>Start</label>
                        <div class=""input-group date"" id=""dtp1"">
                            <input type=""text"" id=""txtStart"" class=""form-control"" />
                            <span class=""input-group-addon"">
                                <span class=""glyphicon glyphicon-calendar""></span>
                            </span>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""checkbox"">
                            <label><input type=""checkbox"" id=""chkIsFullDay"" checked=""checked"" />  Is Full Day event</label>
                        </div>
        ");
                WriteLiteral(@"            </div>
                    <div class=""form-group"" id=""divEndDate"" style=""display:none"">
                        <label>End</label>
                        <div class=""input-group date"" id=""dtp2"">
                            <input type=""text"" id=""txtEnd"" class=""form-control"" />
                            <span class=""input-group-addon"">
                                <span class=""glyphicon glyphicon-calendar""></span>
                            </span>
                        </div>
                    </div>
                    <div class=""form-group"">
                        <label>Description</label>
                        <textarea id=""txtDescription"" rows=""3"" class=""form-control""></textarea>
                    </div>
                    <div class=""form-group"">
                        <label>Theme Color</label>
                        <select id=""ddThemeColor"" class=""form-control"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92a39cd3865bb1fde79217ba1df172d4c7a1ebe59347", async() => {
                    WriteLiteral("Default");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92a39cd3865bb1fde79217ba1df172d4c7a1ebe510599", async() => {
                    WriteLiteral("Red");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92a39cd3865bb1fde79217ba1df172d4c7a1ebe511848", async() => {
                    WriteLiteral("Blue");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92a39cd3865bb1fde79217ba1df172d4c7a1ebe513098", async() => {
                    WriteLiteral("Black");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92a39cd3865bb1fde79217ba1df172d4c7a1ebe514349", async() => {
                    WriteLiteral("Green");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </select>
                    </div>
                    <button type=""button"" id=""btnSave"" class=""btn btn-success"">Save</button>
                    <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<link href=""//cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.4.0/fullcalendar.min.css"" rel=""stylesheet"" />
<link href=""//cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.4.0/fullcalendar.print.css"" rel=""stylesheet"" media=""print"" />
<link href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.47/css/bootstrap-datetimepicker.min.css"" rel=""stylesheet"" />
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.18.1/moment.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/fullcalendar/3.4.0/fullcalendar.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.47/js/bootstrap-datetimepicker.min.js""></script>
    <script>
        $(document).ready(function () {
            var events = [];
            var selectedEvent = null;
            FetchEventAndRenderCalendar();
            function FetchEventAndRenderCalendar() {
                events = [];
                $.ajax({
                    type: ""GET"",
                    url: ""/home/GetEvents"",
                    success: function (data) {
                        $.each(data, function (i, v) {
                            events.push({
                                id: v.idProgramMedica,
                                mes: v.mes,
                                semana: v.semana,
       ");
                WriteLiteral(@"                         dia: moment(v.dia),
                                fecha: moment(v.fecha),
                                idmedico: moment(v.idmedico),
                                idespecialidad: moment(v.idespecialidad),
                                idconsultorio: moment(v.idconsultorio),
                                horhrInicio: moment(v.horhrInicio),
                                hrFin: moment(v.hrFin),
                                estado: moment(v.idEstado)
                            });
                        })

                        GenerateCalender(events);
                    },
                    error: function (error) {
                        alert('failed');
                    }
                })
            }

            function GenerateCalender(events) {
                $('#calender').fullCalendar('destroy');
                $('#calender').fullCalendar({
                    contentHeight: 400,
                    defaultDate: new Date()");
                WriteLiteral(@",
                    timeFormat: 'h(:mm)a',
                    header: {
                        left: 'prev,next today',
                        center: 'title',
                        right: 'month,basicWeek,basicDay,agenda'
                    },
                    eventLimit: true,
                    eventColor: '#378006',
                    events: events,
                    eventClick: function (calEvent, jsEvent, view) {
                        selectedEvent = calEvent;
                        $('#myModal #eventTitle').text(calEvent.title);
                        var $description = $('<div/>');
                        $description.append($('<p/>').html('<b>Start:</b>' + calEvent.start.format(""DD-MMM-YYYY HH:mm a"")));
                        if (calEvent.end != null) {
                            $description.append($('<p/>').html('<b>End:</b>' + calEvent.end.format(""DD-MMM-YYYY HH:mm a"")));
                        }
                        $description.append($('<p/>').html('<");
                WriteLiteral(@"b>Description:</b>' + calEvent.description));
                        $('#myModal #pDetails').empty().html($description);

                        $('#myModal').modal();
                    },
                    selectable: true,
                    select: function (start, end) {
                        selectedEvent = {
                            eventID: 0,
                            title: '',
                            description: '',
                            start: start,
                            end: end,
                            allDay: false,
                            color: ''
                        };
                        openAddEditForm();
                        $('#calendar').fullCalendar('unselect');
                    },
                    editable: true,
                    eventDrop: function (event) {
                        var data = {
                            EventID: event.eventID,
                            Subject: event.title,
       ");
                WriteLiteral(@"                     Start: event.start.format('DD/MM/YYYY HH:mm A'),
                            End: event.end != null ? event.end.format('DD/MM/YYYY HH:mm A') : null,
                            Description: event.description,
                            ThemeColor: event.color,
                            IsFullDay: event.allDay
                        };
                        SaveEvent(data);
                    }
                })
            }

            $('#btnEdit').click(function () {
                //Open modal dialog for edit event
                openAddEditForm();
            })
            $('#btnDelete').click(function () {
                if (selectedEvent != null && confirm('Are you sure?')) {
                    $.ajax({
                        type: ""POST"",
                        url: '/home/DeleteEvent',
                        data: {'eventID': selectedEvent.eventID},
                        success: function (data) {
                            if (data.stat");
                WriteLiteral(@"us) {
                                //Refresh the calender
                                FetchEventAndRenderCalendar();
                                $('#myModal').modal('hide');
                            }
                        },
                        error: function () {
                            alert('Failed');
                        }
                    })
                }
            })

            $('#dtp1,#dtp2').datetimepicker({
                format: 'DD/MM/YYYY HH:mm A'
            });

            $('#chkIsFullDay').change(function () {
                if ($(this).is(':checked')) {
                    $('#divEndDate').hide();
                }
                else {
                    $('#divEndDate').show();
                }
            });

            function openAddEditForm() {
                if (selectedEvent != null) {
                    $('#hdEventID').val(selectedEvent.eventID);
                    $('#txtSubject').val(selectedEvent.tit");
                WriteLiteral(@"le);
                    $('#txtStart').val(selectedEvent.start.format('DD/MM/YYYY HH:mm A'));
                    $('#chkIsFullDay').prop(""checked"", selectedEvent.allDay || false);
                    $('#chkIsFullDay').change();
                    $('#txtEnd').val(selectedEvent.end != null ? selectedEvent.end.format('DD/MM/YYYY HH:mm A') : '');
                    $('#txtDescription').val(selectedEvent.description);
                    $('#ddThemeColor').val(selectedEvent.color);
                }
                $('#myModal').modal('hide');
                $('#myModalSave').modal();
            }

            $('#btnSave').click(function () {
                //Validation/
                if ($('#txtSubject').val().trim() == """") {
                    alert('Subject required');
                    return;
                }
                if ($('#txtStart').val().trim() == """") {
                    alert('Start date required');
                    return;
                }
            ");
                WriteLiteral(@"    if ($('#chkIsFullDay').is(':checked') == false && $('#txtEnd').val().trim() == """") {
                    alert('End date required');
                    return;
                }
                else {
                    var startDate = moment($('#txtStart').val(), ""DD/MM/YYYY HH:mm A"").toDate();
                    var endDate = moment($('#txtEnd').val(), ""DD/MM/YYYY HH:mm A"").toDate();
                    if (startDate > endDate) {
                        alert('Invalid end date');
                        return;
                    }
                }

                var data = {
                    EventID: $('#hdEventID').val(),
                    Subject: $('#txtSubject').val().trim(),
                    Start: $('#txtStart').val().trim(),
                    End: $('#chkIsFullDay').is(':checked') ? null : $('#txtEnd').val().trim(),
                    Description: $('#txtDescription').val(),
                    ThemeColor: $('#ddThemeColor').val(),
                    IsFull");
                WriteLiteral(@"Day: $('#chkIsFullDay').is(':checked')
                }
                SaveEvent(data);
                // call function for submit data to the server
            })

            function SaveEvent(data) {
                $.ajax({
                    type: ""POST"",
                    url: '/home/SaveEvent',
                    data: data,
                    success: function (data) {
                        if (data.status) {
                            //Refresh the calender
                            FetchEventAndRenderCalendar();
                            $('#myModalSave').modal('hide');
                        }
                    },
                    error: function () {
                        alert('Failed');
                    }
                })
            }
        })
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
