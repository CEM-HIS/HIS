using System.ComponentModel.DataAnnotations;

namespace HistClinica.Models
{
	public class T000_PERSONA
	{
		[Key]
		public int idPersona { get; set; }
		public string apePaterno { get; set; }
		public string apeMaterno { get; set; }
		public string nombres { get; set; }
		public int? idtpDocumento { get; set; }
		public int? dniPersona { get; set; }
		public int? idSexo { get; set; }
		public int? idEtnico { get; set; }
		public string fecNace { get; set; }
		public int? idUbigeoResi { get; set; }
		public int? idtipoVia { get; set; }
		public string nombreVia { get; set; }
		public int? nroVia { get; set; }
		public int? nroDpto { get; set; }
		public int? interior { get; set; }
		public int? manzana { get; set; }
		public int? nroLote { get; set; }
		public int? nroKm { get; set; }
		public int? nroBlock { get; set; }
		public int? nroEtapa { get; set; }
		public int? edad { get; set; }
		public int? idUbigeoNace { get; set; }
		public string fotografia { get; set; }
		public int? idGrdInstruc { get; set; }
		public int? idReligion { get; set; }
		public string centroEduca { get; set; }
		public int? idEstCivil { get; set; }
		public int? idOcupacion { get; set; }
		public int? idgpoSangre { get; set; }
		public int? idFactorrh { get; set; }
		public int? nroRuc { get; set; }
		public string razonSocial { get; set; }
		public string estadoRuc { get; set; }
		public string condicionRuc { get; set; }
		public string domiFiscal { get; set; }
		public int? idParentesco { get; set; }
		public string telefono { get; set; }
		public string celular { get; set; }
		public string correo { get; set; }
		public int? tpPersona { get; set; }
		public int? iddatoSiteds { get; set; }
		public int? idemprConvenio { get; set; }
		public int? idciaSeguro { get; set; }
		public int? idtipoIafa { get; set; }
		public string estado { get; set; }
		public string fechabaja { get; set; }
	}
}
