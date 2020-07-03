using System;
using System.ComponentModel.DataAnnotations;

namespace HistClinica.Models
{
    public class D00_TBDETALLE
    {
        [Key]
        public int idDet { get; set; }

        [Required(ErrorMessage = "Ingrese el codigo")]
        public string coddetTab { get; set; }

        [Required(ErrorMessage = "Ingrese la descripcion")]
        public string descripcion { get; set; }
        public string abrev { get; set; }
        public string fuente { get; set; }
        public string estado { get; set; }
        public int? idTab { get; set; }
        public DateTime? fechabaja { get; set; }
    }
}
