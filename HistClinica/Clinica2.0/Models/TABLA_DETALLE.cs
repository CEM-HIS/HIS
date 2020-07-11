using System;
using System.ComponentModel.DataAnnotations;

namespace Clinica2._0.Models
{
    public class TABLA_DETALLE
    {
        [Key]
        public int idTablaDetalle { get; set; }
        [Required(ErrorMessage = "Ingrese el codigo")]
        public string codigoTablaDetalle { get; set; }
        [Required(ErrorMessage = "Ingrese la descripcion")]
        public string descripcion { get; set; }
        public string abreviatura { get; set; }
        public string fuente { get; set; }
        public int? idEstado { get; set; }
        public int? idTablaGeneral { get; set; }
        public DateTime? fechaBaja { get; set; }
    }
}
