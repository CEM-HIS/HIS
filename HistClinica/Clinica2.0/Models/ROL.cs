using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HistClinica.Models
{
    public class ROL
    {
        [Key]
        public int? idRol { get; set; }
        public string nombre { get; set; }
         
    }
}
