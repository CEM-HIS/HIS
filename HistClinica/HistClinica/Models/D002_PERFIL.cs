using System.ComponentModel.DataAnnotations;

namespace HistClinica.Models
{
	public class D002_PERFIL
	{
		[Key]
		public int idPerfil { get; set; }
		public string codPerfil { get; set; }
		public string nombrePerfil { get; set; }
		public int idUsuario { get; set; }
		public string estado { get; set; }
	}
}
