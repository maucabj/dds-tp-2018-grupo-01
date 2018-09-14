﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGE.Entidades.Drivers.Interfaces;
using SGE.Entidades.Reglas;

namespace SGE.Entidades.Drivers
{
    public class DreanLavarropasDriver : Driver
    {
      //  public string Mensaje { get; set; }

        public void Apagar()
        {
            this.Mensaje = "Apagando...";
        }

        public void Encender()
        {
            this.Mensaje = "Encendiendo...";
        }

        public void LavarRopaAlgodon()
        {
            this.Mensaje = "Iniciando lavado de ropa de algodón...";
        }

        public void PonerEnModoAhorroEnergia()
        {
            this.Mensaje = "Colocando en modo ahorro energía..";
        }
    }
}
