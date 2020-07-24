using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Core.Clinica.Models
{
	public class PLAN_SALUD
	{
		[Key]
		public int idPlan { get; set; }
		public string codigoPlanSalud { get; set; }
		public string asegurado { get; set; }
		public string contratante { get; set; }
		public string numeroContrato { get; set; }
	}
}
