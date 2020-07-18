using System;
using System.ComponentModel.DataAnnotations;

namespace Clinica2._0.Models
{
	public class PACIENTE
	{
		[Key]
		public int idPaciente { get; set; }
		public string codigoPaciente { get; set; }
		public string descripcion { get; set; }
		public string numeroHc { get; set; }
		public string nombreAcompañante { get; set; }
		public int? edadAcompañante { get; set; }
		public int? dniAcompañante { get; set; }
		public int? idGrupoSanguineo { get; set; }
		public int? idFactorRh { get; set; }
		public string cobertura { get; set; }
		public string ordenAtenMedica { get; set; }
		public string nombreAsegurado { get; set; }
		public string codigoAsegurado { get; set; }
		public string poliza { get; set; }
		public int? idParentesco { get; set; }
		public DateTime? inicioVigencia { get; set; }
		public DateTime? finVigencia { get; set; }
		public int? idTipoPlanSalud { get; set; }
		public int? numeroPlanSalud { get; set; }
		public int? idEstadoSeguro { get; set; }
		public int? idTipoAfiliacion { get; set; }
		public string fechaAfiliacion { get; set; }
		public int? codigoTitular { get; set; }
		public string moneda { get; set; }
		public string nombreContratante { get; set; }
		public int? idTipoDocumento { get; set; }
		public int? dniContratante { get; set; }
		public string planSalud { get; set; }
		public int? codigoCobertura { get; set; }
		public string beneficio { get; set; }
		public string restriccion { get; set; }
		public int? copagoFijo { get; set; }
		public int? copagoVariable { get; set; }
		public int? finCarencia { get; set; }
		public string convenio { get; set; }
		public double? descuento { get; set; }
		public string codigoPacienteConvenio { get; set; }
		public string descripcionPacienteConvenio { get; set; }
		public string estadoPacienteConvenio { get; set; }
		public string codigoPacienteSoat { get; set; }
		public string descripcionPacienteSoat { get; set; }
		public string estadoPacienteSoat { get; set; }
		public string codigoPacienteExterno { get; set; }
		public string descripcionPacienteExterno { get; set; }
		public string estadoPacienteExterno { get; set; }
		public int? idTipoPaciente { get; set; }
		public int? idPersona { get; set; }
		public bool? hojafiliacion { get; set; }
		public bool? concienteDato { get; set; }
		public int? idEstado { get; set; }
		public string fechaBaja { get; set; }
	}
}
