using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Clinica2._0.Models
{
	public class USUARIO:IdentityUser
	{
		public int? idEmpleado { get; set; }
		public int? idEstado { get; set; }
		public string usuarioCreacion { get; set; }
		public string fechaCreacion { get; set; }
		public string usuarioModifica { get; set; }
		public string fechaModifica { get; set; }
		public string fechaBaja { get; set; }
	}
}
