using System.ComponentModel.DataAnnotations;

namespace HistClinica.Models
{
	public class PERSONA
	{
		[Key]
		public int idPersona { get; set; }
		public string apellidoPaterno { get; set; }
		public string apellidoMaterno { get; set; }
		public string nombres { get; set; }
		public int? idTipoDocumento { get; set; }
		public int? dniPersona { get; set; }
		public int? idSexo { get; set; }
		public int? idEtnico { get; set; }
		public string fechaNacimiento { get; set; }
		public int? idUbigeoResidencia { get; set; }
		public int? idtipoVia { get; set; }
		public string nombreVia { get; set; }
		public int? numeroVia { get; set; }
		public int? numeroDepartamento { get; set; }
		public int? interior { get; set; }
		public int? manzana { get; set; }
		public int? numeroLote { get; set; }
		public int? numeroKilometro { get; set; }
		public int? numeroBloque { get; set; }
		public int? numeroEtapa { get; set; }
		public int? edad { get; set; }
		public int? idUbigeoNacimiento { get; set; }
		public string fotografia { get; set; }
		public int? idGradoInstruccion { get; set; }
		public int? idReligion { get; set; }
		public string centroEducativo { get; set; }
		public int? idEstadoCivil { get; set; }
		public int? idOcupacion { get; set; }
		public int? numeroRuc { get; set; }
		public string razonSocial { get; set; }
		public string estadoRuc { get; set; }
		public string condicionRuc { get; set; }
		public string domicioFiscal { get; set; }
		public int? idParentesco { get; set; }
		public string telefono { get; set; }
		public string celular { get; set; }
		public string correo { get; set; }
		public int? idDatoSiteds { get; set; }
		public int? idEmpresaConvenio { get; set; }
		public int? idCompañiaSeguro { get; set; }
		public int? idTipoIafa { get; set; }
		public int? idEstado { get; set; }
		public string fechaBaja { get; set; }
	}
}
