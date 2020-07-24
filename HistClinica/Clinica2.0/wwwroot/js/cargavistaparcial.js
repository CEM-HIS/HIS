$(document).ready(function () {
	$("#success-alert").fadeOut(1500).slideUp(300, function () {
		$("#success-alert").slideUp(700);
	});
	//iniciar radio button
	var id = $('input:radio[name=radiofiltro]:checked').val();
	if (id == 1) {
		$('#dni').prop('disabled', false);
		$('#nombre').prop('disabled', true);
		$('#apellidos').prop('disabled', true);
	} else {
		$('#dni').prop('disabled', true);
		$('#nombre').prop('disabled', false);
		$('#apellidos').prop('disabled', false);
	}

	//evento click radio button filtro de pacientes
	$("input[name=radiofiltro]").click(function () {
		
		var id = $(this).val();
		if (id == 1) {
			$('#dni').prop('disabled', false);
			$('#nombre').prop('disabled', true);
			$('#apellidos').prop('disabled', true);
		} else {
			$('#dni').prop('disabled', true);
			$('#nombre').prop('disabled', false);
			$('#apellidos').prop('disabled', false);
        }
	});


	$("#cronogramagrid .edit").click(function () {
		var id = $(this).closest("tr").find("td").eq(0).html();
		$.ajax({
			type: "GET",
			url: "/Cronograma/Editar",
			data: { id: id },
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				$('#exampleModal').html(response);
				$('#exampleModal').modal('show');
				$.validator.unobtrusive.parse("#frmeditarcronograma");
			},
			failure: function (response) {
				alert(response.responseText);
			},
			error: function (response) {
				alert(response.responseText);
			}
		});
	});


	$("#personalgrid .edit").click(function () {
		var id = $(this).closest("tr").find("td").eq(0).html();
		$.ajax({
			type: "GET",
			url: "/Persona/Editar",
			data: { idpersona: id },
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				$('#modalestado').html(response);
				$('#modalestado').modal('show');
				$.validator.unobtrusive.parse("#frmeditarpersona");
			},
			failure: function (response) {
				alert(response.responseText);
			},
			error: function (response) {
				alert(response.responseText);
			}
		});
	});

	$("#citamedicogrid .edit").click(function () {
		var id = $(this).closest("tr").find("td").eq(0).html();
		$.ajax({
			type: "GET",
			url: "/Cita/CambiarEstadoCita",
			data: { id: id },
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				$('#modalcambiarestado').html(response);
				$('#modalcambiarestado').modal('show');
			},
			failure: function (response) {
				alert(response.responseText);
			},
			error: function (response) {
				alert(response.responseText);
			}
		});
	});

	$("#citagrid #anular").click(function () {
		var id = $(this).closest("tr").find("td").eq(0).html();
		$.ajax({
			type: "GET",
			url: "/Cita/AnularCita",
			data: { id: id },
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				$('#modalanular').html(response);
				$('#modalanular').modal('show');
			},
			failure: function (response) {
				alert(response.responseText);
			},
			error: function (response) {
				alert(response.responseText);
			}
		});
	});


	$("#citagrid #editar").click(function () {
		var id = $(this).closest("tr").find("td").eq(0).html();
		var idmedico = $("#idmedicocit").val();
		var idespecialidad = $("#idespecialidadcit").val();
		var fechas = $("#fechacita").val();
		$.ajax({
			type: "GET",
			url: "/Cita/Edit",
			data: { id: id, medicocita: idmedico, especialidad: idespecialidad, fechacita:fechas },
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				$('#modalreprogramar').html(response);
				$('#modalreprogramar').modal('show');
				$.validator.unobtrusive.parse("#frmeditcita");
			},
			failure: function (response) {
				alert(response.responseText);
			},
			error: function (response) {
				alert(response.responseText);
			}
		});
	});

	$("#citagrid .detail").click(function () {
		var id = $(this).closest("tr").find("td").eq(0).html();
		$.ajax({
			type: "GET",
			url: "/Cita/Details",
			data: { id: id },
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				$('#modaldetalle').html(response);
				$('#modaldetalle').modal('show');
			},
			failure: function (response) {
				alert(response.responseText);
			},
			error: function (response) {
				alert(response.responseText);
			}
		});
	});


	$("#personalgrid .asig").click(function () {
		var id = $(this).closest("tr").find("td").eq(0).html();
		$.ajax({
			type: "GET",
			url: "/Persona/Asignar",
			data: { id: id },
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				$('#modalasignar').html(response);
				$('#modalasignar').modal('show');
			},
			failure: function (response) {
				alert(response.responseText);
			},
			error: function (response) {
				alert(response.responseText);
			}
		});
	});

	$("#personalgrid .delete").click(function () {
		var id = $(this).closest("tr").find("td").eq(0).html();
		$.ajax({
			type: "GET",
			url: "/Persona/Delete",
			data: { id: id },
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				$('#modaldeletepersona').html(response);
				$('#modaldeletepersona').modal('show');
			},
			failure: function (response) {
				alert(response.responseText);
			},
			error: function (response) {
				alert(response.responseText);
			}
		});
	});


	$("#cronogramagrid .delete").click(function () {
		var id = $(this).closest("tr").find("td").eq(0).html();
		$.ajax({
			type: "GET",
			url: "/Cronograma/Delete",
			data: { id: id },
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				$('#modaldeletecrono').html(response);
				$('#modaldeletecrono').modal('show');
			},
			failure: function (response) {
				alert(response.responseText);
			},
			error: function (response) {
				alert(response.responseText);
			}
		});
	});

	$("#generalgrid .edit").click(function () {
		var id = $(this).closest("tr").find("td").eq(0).html();
		$.ajax({
			type: "GET",
			url: "/Tablas/EditarTipo",
			data: { id: id },
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				$('#modaleditartipo').html(response);
				$('#modaleditartipo').modal('show');
				$.validator.unobtrusive.parse("#frmeditartipo");

			},
			failure: function (response) {
				alert(response.responseText);
			},
			error: function (response) {
				alert(response.responseText);
			}
		});
	});

	$("#detallegrid .edit").click(function () {
		var id = $(this).closest("tr").find("td").eq(0).html();
		$.ajax({
			type: "GET",
			url: "/Tablas/EditarDetalle",
			data: { id: id },
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				console.log(response);
				$('#modaleditardetalle').html(response);
				$('#modaleditardetalle').modal('show');
				$.validator.unobtrusive.parse("#frmeditardetalle");
			},
			failure: function (response) {
				alert(response.responseText);
			},
			error: function (response) {
				alert(response.responseText);
			}
		});
	});

	$("#generalgrid .delete").click(function () {
		var id = $(this).closest("tr").find("td").eq(0).html();
		$.ajax({
			type: "GET",
			url: "/Tablas/DeleteTipo",
			data: { id: id },
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				$('#modalanulartipo').html(response);
				$('#modalanulartipo').modal('show');
			},
			failure: function (response) {
				alert(response.responseText);
			},
			error: function (response) {
				alert(response.responseText);
			}
		});
	});

	$("#detallegrid .delete").click(function () {
		var id = $(this).closest("tr").find("td").eq(0).html();
		$.ajax({
			type: "GET",
			url: "/Tablas/DeleteDetalle",
			data: { id: id },
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				$('#modalanulardetalle').html(response);
				$('#modalanulardetalle').modal('show');
			},
			failure: function (response) {
				alert(response.responseText);
			},
			error: function (response) {
				alert(response.responseText);
			}
		});
	});

});

$(document).on('change', '#idmedico', function (event) {

	console.log("entro");
	BuscarCronograma();

});

$(document).on('click', '#consultacronogrid #btnseleccionar', function (event) {
	var $row = $(this).closest("tr");    // Find the row
	var idespecialidad = $row.find(".especialidad").text();
	var idmedico = $row.find(".idmedico").text();
	var medico = $row.find(".medico").text();// Find the text
	$("#idespecialidad").val(idespecialidad);
	$("#idmedicocro").val(idmedico);
	$("#medico").val(medico);
	$('#modalconsultar').modal('hide');
});

$(document).on('click', '#citareprogrid #reprogramar', function (event) {

	var id = $(this).closest("tr").find("td").eq(0).html();
	var idpaciente = $("#idpaciente").val();
	var idcitaactual = $("#idcita").val();
	$.ajax({
		type: "GET",
		url: "/Cita/Reprogramar",
		data: { idcita: id, idcitaactual: idcitaactual, idpaciente: idpaciente },
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalreprogramar').html(response);
			$('#modalreprogramar').modal('show');
			$('#idcita').val(id);
			$("#idpaciente").val(idpaciente);
			cargarModalConfirmacion(id);
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});

});

$(document).on('click', '#laboratorioGrid #addLab', function (event) {

	var id = $(this).closest("tr").find("td").eq(0).html();
	$.ajax({
		type: "GET",
		url: "/Cita/SeleccionarLaboratorio",
		data: { id: id,},
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalordenes').html(response);
			$('#modalordenes').modal('show');
			$('#modallaboratorio').modal('hide');
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});

});

$(document).on('click', '#ordengrid #anular', function (event) {

	var id = $(this).closest("tr").find("td").eq(0).html();
	$.ajax({
		type: "GET",
		url: "/Cita/DeleteDetalleOrden",
		data: { id: id, },
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalordenes').html(response);
			$('#modalordenes').modal('show');
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});

});



$(document).on('change', '#cboafilia', function (event) {

	var id = $("#cboafilia option:selected").val();
	if (id == 1) {
		$("#caja").prop('disabled',false);
	} else {
		$("#caja").prop('disabled', true);
    }
});

/*
$('#nombrePaciente').val(response.nombres + ' ' + response.apellidoPaterno + ' ' + response.apellidoMaterno);
$('#plan').val(response.paciente.numeroPlan);
$('#contrato').val(response.paciente.numeroContrato);
$('#aseguradora').val(response.paciente.aseguradora);
$('#contratante').val(response.paciente.contratante);
$('#idPaciente').val(response.paciente.idPaciente);
$('#cuenta').val(response.paciente.cuenta);*/
function GrabarOrdenAtencion() {
	var objOrden = {
		idorden:0,
		numeroorden: "", 
		idPaciente: $('#idPaciente').val(),
		nombrepaciente:"",
		codigoplan:"", 
	    contratante:"", 
	    aseguradora:"",
		contrato:"", 
		cuenta: $('#cuenta').val(),
		numeroHC: $('#historia').val(),
		idMedico: 0,
		detalleorden: []
	}

	$.ajax({
		type: "GET",
		url: "/Cita/OrdenAtencionAdd",
		data: objOrden,
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			console.log(response);
			$('#modalordenes').html(response);
			$('#modalordenes').modal('show');
			//$("#idpaciente").val(idpaciente);
		/*	$("#idcita").val(idcitaactual);
			$.validator.unobtrusive.parse("#frmeditcita");*/
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
}

function BuscarCita() {
	var id = "0";
	var idpaciente = $("#idpaciente").val();
	var idcitaactual = $("#idcita").val();
	var idmedico = $("#idmedicocit").val();
	var idespecialidad = $("#espe option:selected").val();
	var fechas = $("#fechacita").val();
	$.ajax({
		type: "GET",
		url: "/Cita/Edit",
		data: { id: id, medicocita: idmedico, especialidad: idespecialidad, fechacita: fechas },
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalreprogramar').html(response);
			$('#modalreprogramar').modal('show');
			$("#idpaciente").val(idpaciente);
			$("#idcita").val(idcitaactual);
			$.validator.unobtrusive.parse("#frmeditcita");
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
}

function alerta1() {

	var mensaje;

	var opcion = confirm("Desea Cancelar");

	if (opcion == true) {

		mensaje = "Has clickado Si";

	} else {

		mensaje = "Has clickado No ,Cancelar";

	}

	document.getElementById("ejemplo").innerHTML = mensaje;

}



function alerta() {

	var mensaje;

	var opcion = confirm("Confirma Atencion del paciente");

	if (opcion == true) {

		mensaje = "Has clickado Si";

	} else {

		mensaje = "Has clickado No ,Cancelar";

	}

	document.getElementById("ejemplo").innerHTML = mensaje;

}



function cargarModalCrearLicencia() {
		$.ajax({
			type: "GET",
			url: "/Licencia/Registro",
			//data: { id: id },
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				$('#modalagregarlicencia').html(response);
				$('#modalagregarlicencia').modal('show');
			},
			failure: function (response) {
				alert(response.responseText);
			},
			error: function (response) {
				alert(response.responseText);
			}
		});
}

function cargarModalConfirmacion(id) {
	$.ajax({
		type: "GET",
		url: "/Cita/ConfirmacionReprogramacion",
		data: { id: id },
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalconfirmacion').html(response);
			$('#modalconfirmacion').modal('show');
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
}

function cargarmodalCrearTipo() {
	$.ajax({
		type: "GET",
		url: "/Tablas/AgregarTipo",
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalagregartipo').html(response);
			$('#modalagregartipo').modal('show');
			$.validator.unobtrusive.parse("#frmregistrartipo");
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
}

function cargarReporteConsentimientodatos() {
	var id = $('#paciente_idPaciente').val();
	$.ajax({
		type: "GET",
		url: "/Paciente/ReportConsentimiento",
		data: { id: id },
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalreporte').html(response);
			$('#modalreporte').modal('show');
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
}

function cargarmodalCrearDetalle() {
	var id = $('#idTablaGeneral').val();
	$.ajax({
		type: "GET",
		url: "/Tablas/AgregarDetalle",
		data: { id: id },
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalagregardetalle').html(response);
			$('#modalagregardetalle').modal('show');
			$.validator.unobtrusive.parse("#frmregistrardetalle");
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
}

function CargaConsultaCronograma() {
	$.ajax({
		type: "GET",
		url: "/Cronograma/ConsultarCronograma",
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalcronograma').html(response);
			$('#modalcronograma').modal('show');
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
}


function BuscarCronograma() {

	var idespecialidad = $("#especialidad option:selected").val();
	var nombre = $("#nombremedico").val();
	var apellido = $("#apellidomedico").val();

	$.ajax({
		url: "/Cronograma/ConsultarCronogramapost",
		data: { idespecialidad: idespecialidad, nombre: nombre, apellido: apellido },
		type: "GET",
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalcronograma').html(response);
			$('#modalcronograma').modal('show');
			console.log(response);
			//$('#modalestado').modal('show');
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
}


function CargaModalCitas() {
	var dni = $("#numeroDocumento").val()
	$.ajax({
		type: "GET",
		url: "/Cita/Registro",
		data: { dni: dni },
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalcitas').html(response);
			$('#modalcitas').modal('show');
			$.validator.unobtrusive.parse("#frmregistrarcita");
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
}

function FiltroCronogramaMedEsp() {
	$.ajax({
		type: "GET",
		url: "/Cronograma/ConsultarMedEsp",
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalconsultar').html(response);
			$('#modalconsultar').modal('show');
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
}

function OpenModalOrdenes() {
	$.ajax({
		type: "GET",
		url: "/Cita/OrdenAtencion",
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalordenes').html(response);
			$('#modalordenes').modal('show');
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
}

function FiltroCronogramaMedEspPost() {
	var idespecialidad = $("#especialidad option:selected").val();
	var nombre = $("#nombremedico").val();
	var apellido = $("#apellidomedico").val();
	$.ajax({
		type: "GET",
		url: "/Cronograma/ConsultarMedEspPost",
		data: { idespecialidad: idespecialidad, nombre: nombre, apellido: apellido },
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalconsultar').html(response);
			$('#modalconsultar').modal('show');
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
}

function BuscarPaciente() {
	var id = $('#dnipac').val();
	$.ajax({
		type: "GET",
		url: "/Cita/BuscarDni",
		data: { dni: id },
		contentType: "application/json; charset=utf-8",
		dataType: "Json",
		success: function (response) {
			console.log(response);
			$('#nombrepaciente').val(response.nombres + ' ' + response.apellidoPaterno + ' ' + response.apellidoMaterno);
			$('#historiac').val(response.paciente.numeroHc);
			$('#cuenta').val(response.paciente.cuenta);
			$('#nrorden').val(response.paciente.numeroorden);
			console.log(response.paciente.idPaciente);
			$('#idpaciente').val(response.paciente.idPaciente);

		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
}

function BuscarPacienteHC() {
	var id = $('#historia').val();
	$.ajax({
		type: "GET",
		url: "/Paciente/GetByHC",
		data: { historia: id },
		contentType: "application/json; charset=utf-8",
		dataType: "Json",
		success: function (response) {
			console.log(response);
			$('#nombrePaciente').val(response.nombres + ' ' + response.apellidoPaterno + ' ' + response.apellidoMaterno);
			$('#plan').val(response.paciente.numeroPlan);
			$('#contrato').val(response.paciente.numeroContrato);
			$('#aseguradora').val(response.paciente.aseguradora);
			$('#contratante').val(response.paciente.contratante);
			$('#idPaciente').val(response.paciente.idPaciente);
			$('#cuenta').val(response.paciente.cuenta);

		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
}

function ConsultarLaboratorio() {
	$.ajax({
		type: "GET",
		url: "/Cita/DetalleLaboratorio",
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modallaboratorio').html(response);
			$('#modallaboratorio').modal('show');
			$('#laboratorioGrid').DataTable({
				"language": {
					"url": "//cdn.datatables.net/plug-ins/1.10.21/i18n/Spanish.json"
				},
				"scrollY": "200px",
				"scrollCollapse": true,
			});
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
}