using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Models
{
	public class LICENCIA
	{
		[Key]
		public int idLicencia { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		public int idMedico { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		public string horaInicio { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		public string horaFin { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		public DateTime? fechaInicio { get; set; }

		[Required(ErrorMessage = "Campo requerido")]
		public DateTime? fechaFin { get; set; }
		public int? idEstado { get; set; }
	}
}
