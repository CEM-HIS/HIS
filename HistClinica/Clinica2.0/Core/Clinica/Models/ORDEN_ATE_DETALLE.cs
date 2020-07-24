using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Core.Clinica.Models
{
	public class ORDEN_ATE_DETALLE
	{
		[Key]
		public int idDetalleOrden { get; set; }
		public string nroOrden { get; set; }
		public string tarifa { get; set; }
		public int cantidad { get; set; }
		public string PrecioUnitario { get; set; }
		public string descuento { get; set; }
		public string importe { get; set; }
		public string seguro { get; set; }
		public string paciente { get; set; }
		public string interviniente { get; set; }
	}
}
