using Clinica2._0.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Core.Clinica.DTO
{
	public class AdmisionDTO
	{
		public List<CitaDTO> Citas { get; set; }
		public PersonaDTO Persona { get; set; }
	}
}
