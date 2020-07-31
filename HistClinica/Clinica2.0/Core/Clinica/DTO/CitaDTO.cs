using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Clinica2._0.DTO
{
    public class CitaDTO
    {
        public int idCita { get; set; }
        public int? numeroCita { get; set; }

        [Required(ErrorMessage = "Seleccione el tipo de cita")]
        public int? idTipoCita { get; set; }
        public string TipoCita { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public string consultorio { get; set; }
        public string descripcion { get; set; }
        public int? idMedico { get; set; }
        public string Medico { get; set; }
        public int? idPaciente { get; set; }
        public DateTime? fechaCita { get; set; }

        [Required(ErrorMessage = "Se requiere este campo")]
        public string nombrePaciente { get; set; }

        [Required(ErrorMessage = "Ingrese el dni del paciente")]
        public int? dniPaciente { get; set; }

        [Required(ErrorMessage = "Seleccione el medico")]
        public int? idEmpleado { get; set; }

        [Required(ErrorMessage = "Seleccione el horario de medico")]
        public int? idProgramacionMedica { get; set; }
        public int? idEspecialidad { get; set; }

        [Required(ErrorMessage = "Seleccione el servicio")]
        public int? idServicioClinica { get; set; }
        public string especialidad { get; set; }
        public double? precio { get; set; }
        public double? igv { get; set; }
        public double? total { get; set; }
        public int? idEstado { get; set; }
        public string descripcionEstado { get; set; }
        public int? estadoPago { get; set; }
        public string descripcionEstadoPago { get; set; }
        public string motivoReprogramacion { get; set; }
        public string motivoAnulacion { get; set; }
        public int? CMP { get; set; }
        public string observacion { get; set; }
        public string observacionAfiliacion { get; set; }
        public int? idconsultorio { get; set; }
        public string horaregistro { get; set; }
        public string numeroorden { get; set; }
        public string cuenta { get; set; }

        [Required(ErrorMessage = "Se requiere este campo")]
        public string numeroHc { get; set; }

    }
}
