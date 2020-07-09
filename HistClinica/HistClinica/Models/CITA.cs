using System;
using System.ComponentModel.DataAnnotations;

namespace HistClinica.Models
{
	public class CITA
	{
		[Key]
		public int idCita { get; set; }
		public int? codigoCita { get; set; }
		public int? numeroCita { get; set; }
		public string descripcion { get; set; }
		public DateTime? fechaCita { get; set; }
		public string ultCie10 { get; set; }
		public int? idTipoAtencion { get; set; }
		public string numeroHC { get; set; }
		public string ejecutado { get; set; }
		public string prioridad { get; set; }
		public double? precio { get; set; }
		public double? descuento { get; set; }
		public double? coa { get; set; }
		public double? igv { get; set; }
		public string estadoReprogramacion { get; set; }
		public int? idtipoCita { get; set; }
		public string motivoReprogramacion { get; set; }
		public string motivoAnulacion { get; set; }
		public int? idEstadoCita { get; set; }
		public int? idPaciente { get; set; }
		public int? idEmpleado { get; set; }
		public int? idConsultorio { get; set; }
		public int? idProgramacionMedica { get; set; }
		public int? idServicioClinica { get; set; }
		public DateTime? fechaBaja { get; set; }
	}
}