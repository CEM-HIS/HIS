using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Clinica2._0.DTO
{
    public class PersonaDTO
    {
        #region Persona
        public int? idPersona { get; set; }

        [Required(ErrorMessage = "Ingrese apellido paterno")]
        public string apellidoPaterno { get; set; }

        [Required(ErrorMessage = "Ingrese apellido materno")]
        public string apellidoMaterno { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre")]
        public string nombres { get; set; }

        //  [MaxLength(11)]
        [Required(ErrorMessage = "Ingrese el ruc")]
        public int? numeroRuc { get; set; }

        //[MaxLength(3)]
        [Required(ErrorMessage = "Ingrese la edad")]
        public int? edad { get; set; }

        // [MaxLength(9)]
        [Required(ErrorMessage = "Ingrese numero de telefono")]
        public string telefono { get; set; }

        [Required(ErrorMessage = "Seleccione el sexo")]
        public int? idSexo { get; set; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Correo no valido")]
        public string Email { get; set; }

        //  [MaxLength(9)]
        [Required(ErrorMessage = "Ingrese numero de celular")]
        public string celular { get; set; }

        [Required(ErrorMessage = "Seleccione el tipo de documento")]
        public int? idTipoDocumento { get; set; }

        //  [MaxLength(8)]
        [Required(ErrorMessage = "Ingrese numero de documento")]
        public int? numeroDocumento { get; set; }
        public string centroEducativo { get; set; }
        public string condicionRuc { get; set; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Correo no valido")]
        [Required(ErrorMessage = "Ingrese el correo")]
        public string correo { get; set; }
        public string domicioFiscal { get; set; }
        public int? idEstado { get; set; }
        public string estadoRuc { get; set; }

        [Required(ErrorMessage = "Ingrese fecha de nacimiento")]
        public string fechaNacimiento { get; set; }
        public string fotografia { get; set; }
        public int? idCompañiaSeguro { get; set; }
        public int? idDatoSiteds { get; set; }
        public int? idEmpresaConvenio { get; set; }

        [Required(ErrorMessage = "Seleccione el estado civil")]
        public int? idEstadoCivil { get; set; }
        public int? idEtnico { get; set; }
        public int? idFactorRh { get; set; }
        public int? idGrupoSanguineo { get; set; }

        [Required(ErrorMessage = "Seleccione el grado de instruccion")]
        public int? idGradoInstruccion { get; set; }

        [Required(ErrorMessage = "Seleccione la ocupacion")]
        public int? idOcupacion { get; set; }
        public string descripcionOcupacion { get; set; }
        public int? idParentesco { get; set; }
        public int? idReligion { get; set; }
        public int? idTipoIafa { get; set; }
        public int? idTipoVia { get; set; }
        public int? idUbigeoNacimiento { get; set; }
        public int? idUbigeoResidencia { get; set; }
        public int? interior { get; set; }
        public int? manzana { get; set; }
        public string nombreVia { get; set; }
        public int? numeroBloque { get; set; }
        public int? numeroDepartamento { get; set; }
        public int? numeroEtapa { get; set; }
        public int? numeroKilometro { get; set; }
        public int? numeroLote { get; set; }
        public int? numeroVia { get; set; }
        public string razonSocial { get; set; }
        public int? idtipoPersona { get; set; }
        public string gradoInstruccion { get; set; }
        public string estadoCivil { get; set; }
        public PersonalDTO personal { get; set; }
        public PacienteDTO paciente { get; set; }
        #endregion Persona
    }
}
