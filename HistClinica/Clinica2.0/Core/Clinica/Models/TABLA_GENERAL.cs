using System;
using System.ComponentModel.DataAnnotations;

namespace Clinica2._0.Models
{
	public class TABLA_GENERAL
	{
		[Key]
		public int idTablaGeneral { get; set; }
		[Required(ErrorMessage = "Seleccione el codigo de tipo")]
		public string codigoTablaGeneral { get; set; }
		[Required(ErrorMessage = "Seleccione la descripcion")]
		public string descripcion { get; set; }
		public string tipo { get; set; }
		public DateTime? fechaCreacion { get; set; }
		public string usuarioCreacion { get; set; }
		public string estado { get; set; } 
        public DateTime? fechaBaja { get; set; }
	}

}
