using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Clinica2._0.Models
{
	public class USER:IdentityUser
	{
		public int? idEmployee { get; set; }
		public int? idState { get; set; }
		public string creationUser { get; set; }
		public string creationDate { get; set; }
		public string modifyUser { get; set; }
		public string modifyDate { get; set; }
		public string DropDate { get; set; }
	}
}
