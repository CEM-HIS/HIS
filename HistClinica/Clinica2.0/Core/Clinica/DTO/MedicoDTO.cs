using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.DTO
{
	public class MedicoDTO
	{
		public int idmedico { get; set; }
		public string nombres { get; set; }
		public int? idespecialidad { get; set; }
		public string especialidad { get; set; }
		public string fechaingreso { get; set; }
	}
}
