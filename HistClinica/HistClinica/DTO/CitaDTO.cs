using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.DTO
{
    public class CitaDTO
    {
        public int? idCita { get; set; }
        public int? nroCita { get; set; }

        [Required(ErrorMessage = "Seleccione el tipo de cita")]
        public int? idTipoCita { get; set; }
        public string TipoCita { get; set; }
        public string fecha { get; set; }

        [Required(ErrorMessage = "Seleccione la hora de cita")]
        public string hora { get; set; }
        public string consultorio { get; set; }
        public string descripcion { get; set; }
        public int? idmedico { get; set; }
        public string medico { get; set; }
        public int? idPaciente { get; set; }

        [Required(ErrorMessage = "Se requiere este campo")]
        public string nombrePaciente { get; set; }

        [Required(ErrorMessage = "Ingrese el dni del paciente")]
        public int? dniPaciente { get; set; }

        [Required(ErrorMessage = "Seleccione el medico")]
        public int? idEmpleado { get; set; }

        [Required(ErrorMessage = "Seleccione el horario de medico")]
        public int? idProgramMedica { get; set; }
        public int? idEspecialidad { get; set; }

        [Required(ErrorMessage = "Seleccione el servicio")]
        public int? idServicioCli { get; set; }
        public string especialidad { get; set; }
        public double? precio { get; set; }
        public double? igv { get; set; }
        public double? total { get; set; }
        public int? estado { get; set; }
        public string descEstado { get; set; }
        public int? estadoPago { get; set; }
        public string descEstadoPago { get; set; }
        public string motivoreprogramacion { get; set; }
        public string motivoanulacion { get; set; }
    }
}
