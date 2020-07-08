using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.DTO
{
	public class licenciaDTO
	{
		public int idLicencia { get; set; }
		public string medico { get; set; }
		public string horaIni { get; set; }
		public string horaFin { get; set; }

		public string fechaIni { get; set; }
		public string fechaFin { get; set; }
		public string estado { get; set; }
	}
}
