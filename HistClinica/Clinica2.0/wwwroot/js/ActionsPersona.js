$(document).ready(function () {
    $('#numeroDocumento').attr('maxlength', '8');
    $('#telefono').attr('maxlength', '9');
    $('#ruc').attr('maxlength', '11');
    $('#personal_numeroColegio').attr('maxlength', '5');
    FechaActual();
});

function FechaActual() {
    var fecha = new Date(); //Fecha actual
    var mes = fecha.getMonth() + 1; //obteniendo mes
    var dia = fecha.getDate(); //obteniendo dia
    var ano = fecha.getFullYear(); //obteniendo año
    if (dia < 10)
        dia = '0' + dia; //agrega cero si el menor de 10
    if (mes < 10)
        mes = '0' + mes //agrega cero si el menor de 10
    $('#fechaingreso').val(ano + "-" + mes + "-" + dia);
    $('#fechanacimiento').val(ano + "-" + mes + "-" + dia);
}

$(document).on('change', '#cboemple', function (event) {

    var id = $("#cboemple option:selected").val();
    if (id == 109) {
        $("#esp1").show();
        $("#esp2").show();
        $("#ruc1").show();
        $("#ruc2").show();
        $("#col1").show();
        $("#col2").show();
    } else {
        $("#esp1").hide();
        $("#esp2").hide();
        $("#ruc1").hide();
        $("#ruc2").hide();
        $("#col1").hide();
        $("#col2").hide();
    }

});

function isNumberKey(evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode;
    if (charCode != 46 && charCode > 31
        && (charCode < 48 || charCode > 57))
        return false;

    return true;
}