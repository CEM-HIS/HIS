using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
	public class D024_CAJA
	{
		[Key]
		public int idCaja { get; set; }
		public int? nroCaja { get; set; }
		public double? montoAper { get; set; }
		public string divisa { get; set; }
		public string turno { get; set; }
		public bool? pos { get; set; }
		public string modopago { get; set; }
		public string proveedor { get; set; }
		public string tipo { get; set; }
		public double? montoCierre { get; set; }
		public string motivo { get; set; }
		public string estado { get; set; }
	}
}
