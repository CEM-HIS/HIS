using System;
using System.ComponentModel.DataAnnotations;

namespace HistClinica.Models
{
	public class T001_PACIENTE
	{
		[Key]
		public int idPaciente { get; set; }
		public string codPaciente { get; set; }
		public string descripcion { get; set; }
		public string nrohc { get; set; }
		public string nombreAcom { get; set; }
		public int? edadAcom { get; set; }
		public int? dniAcom { get; set; }
		public int? idgpoSangre { get; set; }
		public int? idFactorrh { get; set; }
		public string cobertura { get; set; }
		public string ordenAtenMed { get; set; }
		public string nomAsegurado { get; set; }
		public string codAsegurado { get; set; }
		public string poliza { get; set; }
		public int? parentesco { get; set; }
		public DateTime? iniVigencia { get; set; }
		public DateTime? finVigencia { get; set; }
		public int? tpPlanSalud { get; set; }
		public int? nroPlanSalud { get; set; }
		public int? estadoSeguro { get; set; }
		public int? tpAfiliacion { get; set; }
		public string fecAfiliacion { get; set; }
		public int? codTitular { get; set; }
		public string moneda { get; set; }
		public string nomContratante { get; set; }
		public int? tpDocumento { get; set; }
		public int? dniContratante { get; set; }
		public string planSalud { get; set; }
		public int? codCobertura { get; set; }
		public string beneficio { get; set; }
		public string restriccion { get; set; }
		public int? copagoFijo { get; set; }
		public int? copagoVariable { get; set; }
		public int? finCarencia { get; set; }
		public string convenio { get; set; }
		public double? descuento { get; set; }
		public string codPaConvenio { get; set; }
		public string dsPacConv { get; set; }
		public string statPaconv { get; set; }
		public string codPacSoat { get; set; }
		public string dsPacSoat { get; set; }
		public string statPacSoat { get; set; }
		public string codpacExterno { get; set; }
		public string dspacExter { get; set; }
		public string stapacexter { get; set; }
		public int? tpPaciente { get; set; }
		public int? idPersona { get; set; }
		public bool? hojafiliacion { get; set; }
		public bool? concienteDato { get; set; }
		public int? estado { get; set; }
		public string fechabaja { get; set; }
	}
}
