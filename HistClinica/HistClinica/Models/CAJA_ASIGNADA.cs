﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HistClinica.Models
{
    public class CAJA_ASIGNADA
    {
        [Key]
        public int idEmpleado { get; set; }
        public int idCaja { get; set; }
        public DateTime fechaApertura { get; set; }
        public DateTime? fechaCierre { get; set; }
        public string turno { get; set; }
        public bool? pos { get; set; }
        public double? montoSolesApertura { get; set; }
        public double? montoDolaresApertura { get; set; }
        public double? montoEurosApertura { get; set; }
        public double? montoSolesCierre { get; set; }
        public double? montoDolaresCierre { get; set; }
        public double? montoEurosCierre { get; set; }
        public string glosa { get; set; }
    }                                       
}