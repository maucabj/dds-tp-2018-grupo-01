﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGE.WebconAutenticacion.Dispositivos;

namespace SGE.WebconAutenticacion.Acciones.Lavarropa
{
    public class LavarRopaAlgodon: Accion
    {
        #region Campos

        private Lavarropas dispositivo;

        #endregion

        #region Constructores

        public LavarRopaAlgodon(Lavarropas dispositivo)
        {
            this.dispositivo = dispositivo;
        }

        #endregion

        #region Ejecución

        public void Ejecutar()
        {
            this.dispositivo.LavarRopaAlgodon();
        }

        #endregion
    }
}
