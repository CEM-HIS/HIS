using System.ComponentModel.DataAnnotations;

namespace HistClinica.Models
{
	public class T109_ESTADOCITA
	{
		[Key]
		public int idEstadoCita { get; set; }
		public string codEstadoCita { get; set; }
		public string estado { get; set; }
		public string origen { get; set; }
	}
}
