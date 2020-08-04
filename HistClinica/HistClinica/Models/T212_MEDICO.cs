using System.ComponentModel.DataAnnotations;

namespace HistClinica.Models
{
	public class T212_MEDICO
	{
		[Key]
		public int idMedico { get; set; }
		public string codMedico { get; set; }
		public int? nroColegio { get; set; }
		public string nroRne { get; set; }
		public int? nroRuc { get; set; }
		public int? idtpDocumento { get; set; }
		public string condicion { get; set; }
		public int? idEmpleado { get; set; }
		public int? idEspecialidad { get; set; }
		public int? idPersona { get; set; }
		public int estado { get; set; }
		public string fechabaja { get; set; }
	}
}
