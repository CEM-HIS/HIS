using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HistClinica.DTO
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
        public int? ruc { get; set; }

        //[MaxLength(3)]
        [Required(ErrorMessage = "Ingrese la edad")]
        public int? edad { get; set; }

       // [MaxLength(9)]
        [Required(ErrorMessage = "Ingrese numero de telefono")]
        public string telefono { get; set; }

       [Required(ErrorMessage = "Seleccione el sexo")]
        public int? idSexo { get; set; }
        public int? idGradoInstruccion { get; set; }

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
        public string centroEduca { get; set; }
        public string condicionRuc { get; set; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Correo no valido")]
        [Required(ErrorMessage = "Ingrese el correo")]
        public string correo { get; set; }
        public string domiFiscal { get; set; }
        public int? estado { get; set; }
        public string estadoRuc { get; set; }

        [Required(ErrorMessage = "Ingrese fecha de nacimiento")]
        public string fecNacimiento { get; set; }
        public string fotografia { get; set; }
        public int? idciaSeguro { get; set; }
        public int? iddatoSiteds { get; set; }
        public int? idemprConvenio { get; set; }

        [Required(ErrorMessage = "Seleccione el estado civil")]
        public int? idEstCivil { get; set; }
        public int? idEtnico { get; set; }
        public int? idFactorrh { get; set; }
        public int? idgpoSangre { get; set; }

        [Required(ErrorMessage = "Seleccione el grado de instruccion")]
        public int? idGrdInstruc { get; set; }

        [Required(ErrorMessage = "Seleccione la ocupacion")]
        public int? idOcupacion { get; set; }
        public string descripcionOcupacion { get; set; }
        public int? idParentesco { get; set; }
        public int? idReligion { get; set; }
        public int? idtipoIafa { get; set; }
        public int? idtipoVia { get; set; }
        public int? idUbigeoNace { get; set; }
        public int? idUbigeoResi { get; set; }
        public int? interior { get; set; }
        public int? manzana { get; set; }
        public string nombreVia { get; set; }
        public int? nroBlock { get; set; }
        public int? nroDpto { get; set; }
        public int? nroEtapa { get; set; }
        public int? nroKm { get; set; }
        public int? nroLote { get; set; }
        public int? nroVia { get; set; }
        public string razonSocial { get; set; }
        public int? tpPersona { get; set; }
        public PersonalDTO personal { get; set; }
        public PacienteDTO paciente { get; set; }
        public AsignacionDTO asignacion { get; set; }
        #endregion Persona
    }
}
