using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Clinica2._0.Models
{
    public class SEDE
    {

        [Key]
        public int? idSede { get; set; }
        public string descripcion { get; set; }
    }
}
