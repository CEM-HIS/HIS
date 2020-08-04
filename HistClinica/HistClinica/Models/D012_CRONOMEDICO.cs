using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
	public class D012_CRONOMEDICO
	{
		[Key]
		public int idProgramMedica { get; set; }
		public string mes { get; set; }
		public string semana { get; set; }
		public string dia { get; set; }

		[Required(ErrorMessage = "Seleccione la fecha de inicio")]
		public DateTime? fechaIni { get; set; }

		[Required(ErrorMessage = "Seleccione la fecha de fin")]
		public DateTime? fechaFin { get; set; }

		[Required(ErrorMessage = "Seleccione un medico")]
		public int? idMedico { get; set; }

		[Required(ErrorMessage = "Seleccione una especialidad")]
		public int? idEspecialidad { get; set; }

		[Required(ErrorMessage = "Seleccione un consultorio")]
		public int? idConsultorio { get; set; }

		[Required(ErrorMessage = "Seleccione una hora de inicio")]
		public string hrInicio { get; set; }

		[Required(ErrorMessage = "Seleccione una hora de fin")]
		public string hrFin { get; set; }
		public int? idEstado { get; set; }
		public string fechaBaja { get; set; }
	}
}
