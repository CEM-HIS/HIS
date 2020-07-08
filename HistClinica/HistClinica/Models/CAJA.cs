using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
	public class CAJA
	{
		[Key]
		public int idCaja { get; set; }
		public string descripcion { get; set; }	
		public int tipo { get; set; }
		public int estado { get; set; }
	}
}
