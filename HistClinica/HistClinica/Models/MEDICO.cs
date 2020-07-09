using System.ComponentModel.DataAnnotations;

namespace HistClinica.Models
{
	public class MEDICO
	{
		[Key]
		public int idMedico { get; set; }
		public string codigoMedico { get; set; }
		public int? numeroColegio { get; set; }
		public string numeroRne { get; set; }
		public int? numeroRuc { get; set; }
		public int? idTipoDocumento { get; set; }
		public string condicion { get; set; }
		public int? idEmpleado { get; set; }
		public int? idEspecialidad { get; set; }
		public int? idPersona { get; set; }
		public int? idEstado { get; set; }
		public string fechaBaja { get; set; }
	}
}
