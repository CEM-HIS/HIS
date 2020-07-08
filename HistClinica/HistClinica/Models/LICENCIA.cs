using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
	public class LICENCIA
	{
		[Key]
		public int idLicencia { get; set; }
		public int idMedico { get; set; }
		public string horaIni { get; set; }
		public string horaFin { get; set; }

		public DateTime? fechaIni { get; set; }
		public DateTime? fechaFin { get; set; }
		public int estado { get; set; }
	}
}
