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
		public List<CitaDTO> citas { get; set; }
	}
}
