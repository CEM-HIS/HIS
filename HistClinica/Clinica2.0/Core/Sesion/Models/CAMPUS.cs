using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Clinica2._0.Models
{
    public class CAMPUS
    {

        [Key]
        public int idCampus { get; set; }
        public string description { get; set; }
        public int? idCompany { get; set; }
    }
}
