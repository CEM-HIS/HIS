using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using HistClinica.Models;

namespace HistClinica.DTO
{
    public class DetalleDTO
    {
      
        public int idTab { get; set; }
        public string codTab { get; set; }
        public List<D00_TBDETALLE> ldetalle { get; set; }
    }
}
