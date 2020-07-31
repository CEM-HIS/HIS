using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Core.Clinica.Models
{
	public class ORDEN_ATENCION
	{
		[Key]
		public int idOrden { get; set; }
		public string nroOrden { get; set; }
		public int idPaciente { get; set; }
		public string numeroHC { get; set; }
        public int idMedico { get; set; }
		public string cuenta { get; set; }
	}
}
