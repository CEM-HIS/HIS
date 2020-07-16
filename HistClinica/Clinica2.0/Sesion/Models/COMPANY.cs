using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Clinica2._0.Models
{
    public class COMPANY
    {
        [Key]
        public int? idCompany { get; set; }
        public string name { get; set; }
    }
}
