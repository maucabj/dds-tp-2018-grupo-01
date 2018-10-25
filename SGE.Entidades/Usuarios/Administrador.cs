﻿using SGE.WebconAutenticacion.Dispositivos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.WebconAutenticacion.Usuarios
{
    [Table(name: "Administrador")]
    public class Administrador : Usuario
    {
        public string Nui { get; set; }
 
        public int Antiguedad()
        {
            return (int)Math.Truncate((DateTime.Now - this.FechaAlta).TotalDays);
        }
    }
}
