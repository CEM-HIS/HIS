using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
	public class PAGO
	{
		[Key]
		public int idPago { get; set; }
		public string codigoTransaccion { get; set; }
		public string codigoTransacccionRetorno { get; set; }
		public int? idFormaPago { get; set; }
		public double? monto { get; set; }
		public DateTime? fechaRegistro { get; set; }
		public DateTime? fechaOkPasarela { get; set; }
		public int? idCita { get; set; }
		public string estado { get; set; }
		public string fechaBaja { get; set; }
	}
}
