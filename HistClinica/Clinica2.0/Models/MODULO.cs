﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Clinica2._0.Models
{
    public class MODULO
    {
        [Key]
        public int? idModulo { get; set; }
        public string nombre { get; set; }
    }
}