using System;
using System.ComponentModel.DataAnnotations;

namespace Clinica2._0.Models
{
	public class EMPLEADO
	{
		[Key]
		public int idEmpleado { get; set; }
		public string codigoEmpleado { get; set; }
		public string descripcionArea { get; set; }
		public string cargo { get; set; }
		public DateTime? fechaIngreso { get; set; }
		public double? salario { get; set; }
		public int? idGenero { get; set; }
		public int? idTipoEmpleado { get; set; }
		public int? idPersona { get; set; }
		public int? idEstado { get; set; }
		public string fechaBaja { get; set; }
	}
}
