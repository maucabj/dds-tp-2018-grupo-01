﻿using System;

namespace SGE.Entidades.Sensores.Sensores {
    public class Temperatura : Sensor {
        public override Medicion RealizarMedicion() {
            return new Medicion() {
                Unidad = UnidadEnum.CENTIGRADOS,
                Valor = this.Dispositivo.Temperatura.ToString(),
                FechaRegistro = DateTime.Now
            };
        }
    }
}
