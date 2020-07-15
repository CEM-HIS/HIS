using System.ComponentModel.DataAnnotations;

namespace Clinica2._0.Models
{
	public class PROFILE
	{
		[Key]
		public int? idProfile { get; set; }
		public string profileCode { get; set; }
		public string profileName { get; set; }
		public int? idUser { get; set; }
		public int? idState { get; set; }
	}
}
