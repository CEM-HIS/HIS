$(document).ready(function () {
	CargarCita();
	AperturaCaja();
	CargarReporte();
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

	$("#citagrid #add").click(function () {
		var id = $(this).closest("tr").find("td").eq(0).html();
		$.ajax({
			type: "GET",
			url: "/Cita/Registro",
			data: { id: id },
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				$('#modalregistro').html(response);
				$('#modalregistro').modal('show');
				$.validator.unobtrusive.parse("#frmregistrocita");
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
		var idmedico = 0;
		var idespecialidad = 0;
		var fechas = null;
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

	$("#licenciagrid #editar").click(function () {
		var id = $(this).closest("tr").find("td").eq(0).html();
		$.ajax({
			type: "GET",
			url: "/Licencia/Edit",
			data: { id: id },
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				$('#modaleditarlicencia').html(response);
				$('#modaleditarlicencia').modal('show');
				$.validator.unobtrusive.parse("#frmregistrarlicencia");
			},
			failure: function (response) {
				alert(response.responseText);
			},
			error: function (response) {
				alert(response.responseText);
			}
		});
	});

	$("#licenciagrid #anular").click(function () {
		var id = $(this).closest("tr").find("td").eq(0).html();
		$.ajax({
			type: "GET",
			url: "/Licencia/Delete",
			data: { id: id },
			contentType: "application/json; charset=utf-8",
			dataType: "html",
			success: function (response) {
				$('#modaleliminarlicencia').html(response);
				$('#modaleliminarlicencia').modal('show');
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

function CrearPaciente() {
	var nro = 1;
	localStorage.setItem("indicador", nro);
}

function CargarReporte() {
	var indicadorreporte = "@ViewBag.reporte";
	if (indicadorreporte == true) {
		cargarReporteConsentimientodatos();
	} 
}

$(document).on('click', '#consultacronogrid #btnseleccionar', function (event) {
	var $row = $(this).closest("tr");    // Find the row
	var idespecialidad = $row.find(".especialidad").text();
	var idmedico = $row.find(".idmedico").text();
	var medico = $row.find(".medico").text();// Find the text
	$("#idespecialidad").val(idespecialidad);
	$("#idmedicocro").val(idmedico);
	$("#medico").val(medico);
	$("#idespecialidadrepro").val(idespecialidad);
	$("#idmedicorepro").val(idmedico);
	$("#medicorepro").val(medico);
	$('#modalconsultar').modal('hide');
});

$(document).on('click', '#citareprogrid #reprogramar', function (event) {

	var id = $(this).closest("tr").find("td").eq(0).html();
	var idpaciente = $("#idpaciente").val();
	var idcitaactual = $("#idcita").val();
	$.ajax({
		type: "GET",
		url: "/Cita/ConfirmacionReprogramacion",
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalvalidacion').html(response);
			$('#modalvalidacion').modal('show');
			$('#idcitarepro').val(id);
			$("#idpacienterepro").val(idpaciente);
			$("#idcitaactual").val(idcitaactual);
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

function ReprogramarCita() {
	var id = $("#idcitarepro").val();
	var idpaciente = $("#idpacienterepro").val();
	var idcitaactual = $("#idcitaactual").val();
	var url = $("#RedirectTo").val();
	$.ajax({
		type: "GET",
		url: "/Cita/Reprogramar",
		data: { idcita: id, idcitaactual: idcitaactual, idpaciente: idpaciente },
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalvalidacion').modal('hide');
			$('#modalreprogramar').modal('hide');
			location.href = url;
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
}

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


function CargarCita() {
	var id = localStorage.getItem("idCita");
	if (id != null) {
		CargarModalActual(id);
	}
}

function Limpiarid() {
	localStorage.clear();
	$('#modalvalidacion').modal('hide');
}

function CargarModalActual(id) {
	$.ajax({
		type: "GET",
		url: "/Cita/Registro",
		data: { id: id },
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalregistro').html(response);
			$('#modalregistro').modal('show');
			localStorage.clear();
			$.validator.unobtrusive.parse("#frmregistrocita");
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
	var idmedico = $("#idmedicorepro").val();
	var idespecialidad = $("#idespecialidadrepro option:selected").val();
	var fechas = $("#fechacita").val();
	var idcita = $('#id').val();
	var hora = $('#horacita').val();
	var medico = $('#medicocita').val();
	var medicorepro = $('#medicorepro').val();
	var cmp = $('#cmp').val();
	var paciente = $('#pacientecita').val();
	$.ajax({
		type: "GET",
		url: "/Cita/Edit",
		data: { id: idcitaactual, medicocita: idmedico, especialidad: idespecialidad, fechacita: fechas },
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalreprogramar').html(response);
			$('#modalreprogramar').modal('show');
			$("#idpaciente").val(idpaciente);
			$("#idcita").val(idcitaactual);
			$('#id').val(idcita);
			$('#horacita').val(hora);
			$('#medicocita').val(medico);
			$('#cmp').val(cmp);
			$('#pacientecita').val(paciente);
			$('#medicorepro').val(medicorepro);
			$('#idespecialidadrepro').val(idespecialidad);
			$("#fechacita").val(fechas);

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

function ValidacionPaciente() {
	$.ajax({
		type: "GET",
		url: "/Cita/ValidacionPaciente",
		//data: { id: id },
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalvalidacion').html(response);
			$('#modalvalidacion').modal('show');
		},
		failure: function (response) {
			alert(response.responseText);
		},
		error: function (response) {
			alert(response.responseText);
		}
	});
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
				$.validator.unobtrusive.parse("#frmregistrarlicencia");
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
	var id = $('#Persona_paciente_idPaciente').val();
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

function AperturaCaja() {
	$.ajax({
		type: "GET",
		url: "/Caja/Apertura",
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalapertura').html(response);
			$('#modalapertura').modal('show');
			$('#modalapertura').modal({
				backdrop: 'static',
				keyboard: true,
				show: true
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
			$('#consultacronogrid').DataTable({
				"language": {
					"url": "//cdn.datatables.net/plug-ins/1.10.21/i18n/Spanish.json"
				},
				"scrollY": "300px",
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

function OpenModalOrdenes() {
	$.ajax({
		type: "GET",
		url: "/Cita/OrdenAtencion",
		contentType: "application/json; charset=utf-8",
		dataType: "html",
		success: function (response) {
			$('#modalordenes').html(response);
			$('#modalordenes').modal('show');
			$('#ordengrid').DataTable({
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

function BuscarPacienteDni() {
	var id = $('#dnipac').val();
	var idcita = $('#idCita').val();
	$.ajax({
		type: "GET",
		url: "/Cita/BuscarPacienteByDni",
		data: { dni: id },
		contentType: "application/json; charset=utf-8",
		dataType: "Json",
		success: function (response) {
			console.log(response);
			if (response == false) {
				ValidacionPaciente();
				localStorage.setItem('idCita', idcita);
			} else {
				$('#nombrepaciente').val(response.persona.nombres + ' ' + response.persona.apellidoPaterno + ' ' + response.persona.apellidoMaterno);
				$('#plan').val(response.persona.paciente.numeroPlan);
				$('#contrato').val(response.persona.paciente.numeroContrato);
				$('#idpaciente').val(response.persona.paciente.idPaciente);
				$('#aseguradora').val(response.persona.paciente.aseguradora);
				$('#contratante').val(response.persona.paciente.contratante);
				$('#idPaciente').val(response.persona.paciente.idPaciente);
				$('#cuenta').val(response.persona.paciente.cuenta);
				$('#nrorden').val(response.persona.paciente.numeroorden);
				$('#dnipac').val(response.persona.numeroDocumento);
				$('#historiac').val(response.persona.paciente.numeroHc);
            }

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
	var id = $('#historiac').val();
	$.ajax({
		type: "GET",
		url: "/Paciente/GetByHC",
		data: { historia: id },
		contentType: "application/json; charset=utf-8",
		dataType: "Json",
		success: function (response) {
			console.log(response);
			$('#nombrepaciente').val(response.nombres + ' ' + response.apellidoPaterno + ' ' + response.apellidoMaterno);
			$('#plan').val(response.paciente.numeroPlan);
			$('#contrato').val(response.paciente.numeroContrato);
			$('#aseguradora').val(response.paciente.aseguradora);
			$('#contratante').val(response.paciente.contratante);
			$('#idPaciente').val(response.paciente.idPaciente);
			$('#cuenta').val(response.paciente.cuenta);
			$('#nrorden').val(response.paciente.numeroorden);
			$('#dnipac').val(response.numeroDocumento);

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