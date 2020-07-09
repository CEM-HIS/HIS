using System.ComponentModel.DataAnnotations;

namespace HistClinica.Models
{
	public class USUARIO
	{
		public int? idEmpleado { get; set; }
		public string loginUser { get; set; }
		public string claveUser { get; set; }
		public int? idEstado { get; set; }
		public string usuCrea { get; set; }
		public string fechaCrea { get; set; }
		public string usuMod { get; set; }
		public string fechaMod { get; set; }
		public string fechaBaja { get; set; }
	}
}
