﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.WebconAutenticacion.Dispositivos
{
    [Table(name: "Dispositivo")]
    public abstract class Dispositivo
    {
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal ConsumoEnergia { get; set; }
        public string IdentificadorFabrica { get; set; }

        #endregion

        #region Constructor
        protected Dispositivo() {
        }

        protected Dispositivo(string nombre, decimal consumo)
        {
            this.Nombre = nombre;
            this.ConsumoEnergia = consumo;
        }
        protected Dispositivo(string nombre)
        {
            this.Nombre = nombre;
        }

        #endregion
    }
}
