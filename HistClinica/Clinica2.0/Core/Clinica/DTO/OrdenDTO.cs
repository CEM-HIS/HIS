using Clinica2._0.Core.Clinica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.DTO
{
	public class OrdenDTO
	{
		public int idorden { get; set; }
		public string numeroorden { get; set; }
		public int idPaciente { get; set; }
		public string nombrepaciente { get; set; }

		public string codigoplan { get; set; }
		public string contratante { get; set; }
		public string aseguradora { get; set; }
		public string contrato { get; set; }
		public string cuenta { get; set; }
		public string numeroHC { get; set; }
		public int idMedico { get; set; }

		public List<ORDEN_ATE_DETALLE> detalleorden { get; set; }
	}
}
