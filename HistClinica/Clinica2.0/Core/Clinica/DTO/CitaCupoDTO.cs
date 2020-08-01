using Clinica2._0.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Clinica.DTO
{
	public class CitaCupoDTO
	{
		public int idcita { get; set; }
		public int? idpaciente { get; set; }
		public string hora { get; set; }
		public int? idespecialidad { get; set; }
		public string fecha { get; set; }
		public int? idmedico { get; set; }
		public string medico { get; set; }
		public int? cmp { get; set; }
		public string paciente { get; set; }
		public List<CitaDTO> citas { get; set; }
	}
}
