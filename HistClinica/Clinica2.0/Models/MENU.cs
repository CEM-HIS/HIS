﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica2._0.Models
{
    public class MENU
    {
        [Key]
        public int? IdMenu { get; set; }
        public string nombreMenu { get; set; }
        public string linkMenu { get; set; }
    }
}
