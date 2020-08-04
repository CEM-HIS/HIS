using System.ComponentModel.DataAnnotations;

namespace Clinica2._0.Models
{
	public class PERFIL
	{
		[Key]
		public int? idPerfil { get; set; }
		public string codPerfil { get; set; }
		public string nombrePerfil { get; set; }
		public int idUsuario { get; set; }
		public string estado { get; set; }
	}
}
