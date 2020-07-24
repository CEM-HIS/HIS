using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Core.Clinica.Models
{
	public class LABORATORIO
	{
		[Key]
		public int idLaboratorio { get; set; }

		public string tipo { get; set; }
		public string codigo { get; set; }
		public string descripcion { get; set; }
		public string precio { get; set; }
	}
}
