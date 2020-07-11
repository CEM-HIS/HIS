using System.ComponentModel.DataAnnotations;

namespace HistClinica.Models
{
	public class USUARIO
	{
		public int? idEmpleado { get; set; }
		public string loginUser { get; set; }
		public string claveUser { get; set; }
		public int? idEstado { get; set; }
		public string usuarioCreacion { get; set; }
		public string fechaCreacion { get; set; }
		public string usuarioModifica { get; set; }
		public string fechaModifica { get; set; }
		public string fechaBaja { get; set; }
	}
}
