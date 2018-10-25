﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SGE.WebconAutenticacion.Acciones;
using System.Linq;

namespace SGE.WebconAutenticacion.Reglas
{
    [Table("Regla")]
    public class Regla
    {
        #region Propiedades
        [Key]
        public int ReglaId { get; set; }
        [MaxLength(25)]
        public string Nombre { get; set; }

        public virtual List<Accion> Accions{ get; set; } //one to many con Accion  
        public virtual ICollection<Condicion> Condiciones { get; set; } //one to many con condicion

        List<IAccion> Acciones { get; set; }

        #endregion

        #region Constructores
        public Regla() {
        }
        public Regla(string nombre, List<Condicion> condiciones, List<IAccion> acciones)
        {
            this.Nombre = nombre;
            this.Condiciones = condiciones;
            this.Acciones = acciones;
        }

        #endregion

        #region Metodos

        public void Ejecutar()
        {
            bool seVerificanCondiciones = true;

            for (int i = 0; i < this.Condiciones.Count; i++)
            {
                if (!this.Condiciones.FirstOrDefault().Evaluar())
                {
                    seVerificanCondiciones = false;
                    i = this.Condiciones.Count;
                }
            }

            if (seVerificanCondiciones)
            {
                foreach (IAccion accion in this.Acciones)
                    accion.Ejecutar();
            }
        }
       
        #endregion
    }
}
