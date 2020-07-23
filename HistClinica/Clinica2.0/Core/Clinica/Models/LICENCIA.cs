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
		public int idMedico { get; set; }
		public string horaInicio { get; set; }
		public string horaFin { get; set; }
		public DateTime? fechaInicio { get; set; }
		public DateTime? fechaFin { get; set; }
		public int? idEstado { get; set; }
	}
}
