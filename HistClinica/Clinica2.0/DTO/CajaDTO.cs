using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.DTO
{
    public class CajaDTO
    {
        public int idEmpleado { get; set; }
        public int idCaja { get; set; }
        public string fecha { get; set; }
        public string tipo { get; set; }
        public string turno { get; set; }
        public int idEstado { get; set; }
    }
}
