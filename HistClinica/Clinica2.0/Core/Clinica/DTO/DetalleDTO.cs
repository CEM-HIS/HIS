using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Clinica2._0.Models;

namespace Clinica2._0.DTO
{
    public class DetalleDTO
    {
      
        public int idTablaGeneral { get; set; }
        public string codigoTablaGeneral { get; set; }
        public List<TABLA_DETALLE> detalles { get; set; }
    }
}
