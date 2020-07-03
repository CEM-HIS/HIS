using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.DTO
{
    public class PersonalDTO
    {
        #region Personal
        public int? idEmpleado { get; set; }
        public int? idMedico { get; set; }
        public string codMedico { get; set; }
        public string condicion { get; set; }
        public string nroRne { get; set; }
        public int? nroRucMedico { get; set; }
        public int? idTipoEmpleado { get; set; }

        [Required(ErrorMessage = "Ingrese fecha de ingreso")]
        public string fechaIngreso { get; set; }

        [Required(ErrorMessage = "Ingrese numero de colegio")]
        public int? numeroColegio { get; set; }

        [Required(ErrorMessage = "Ingrese cargo")]
        public string cargo { get; set; }
        public int? idEspecialidad { get; set; }
        public string codEmpleado { get; set; }

        [Required(ErrorMessage = "Ingrese area")]
        public string descArea { get; set; }
        public int? estadoEmpleado { get; set; }
        public int? estadoMedico { get; set; }
        public int? genero { get; set; }
        public double? precio { get; set; }
        public int? salario { get; set; }
        public string fechaBaja { get; set; }
        #endregion
    }
}
