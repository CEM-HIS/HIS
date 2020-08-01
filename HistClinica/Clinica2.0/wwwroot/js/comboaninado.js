$(document).ready(function () {
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
	$('#fechaInicio').val(ano + "-" + mes + "-" + dia);
	$('#fechaFin').val(ano + "-" + mes + "-" + dia);
	$('#fechaIni').val(ano + "-" + mes + "-" + dia);
}

$(document).on('change', '[data-cascade-combo]', function (event) {
	console.log("entro");

	var id = $(this).attr('data-cascade-combo');

	var url = $(this).attr('data-cascade-combo-source');

	var paramName = $(this).attr('data-cascade-combo-param-name');

	var data = {};
	data[paramName] = id;

	$.ajax({
		type: "GET",
		url: url,
		data: {
			id: $(this).val()
		},
		contentType: "application/json; charset=utf-8",
		dataType: "Json",
		success: function (data) {
			$(id).html('');

			$.each(data,
				function (index, type) {
					var content = '<option value="' + type.idtab + '">' + type.descripcion + '</option>';
					console.log(content);
					$(id).append(content);
				});
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
});

$(document).on('change', '[data-cascade-combo-med]', function (event) {
	console.log("entro");

	var id = $(this).attr('data-cascade-combo-med');

	var url = $(this).attr('data-cascade-combo-source-med');

	var paramName = $(this).attr('data-cascade-combo-param-name-med');

	var data = {};
	data[paramName] = id;

	$.ajax({
		type: "GET",
		url: url,
		data: {
			id: $(this).val()
		},
		contentType: "application/json; charset=utf-8",
		dataType: "Json",
		success: function (data) {
			$(id).html('');

			$.each(data,
				function (index, type) {
					var content = '<option value="' + type.idtab + '">' + type.descripcion + '</option>';
					console.log(content);
					$(id).append(content);
				});
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
});