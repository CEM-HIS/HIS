using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HistClinica.Models
{
    public class EMPRESA
    {
        [Key]
        public int? idempresa { get; set; }
        public string nombre { get; set; }
    }
}
