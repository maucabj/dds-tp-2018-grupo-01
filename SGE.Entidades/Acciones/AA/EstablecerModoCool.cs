﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGE.WebconAutenticacion.Dispositivos;

namespace SGE.WebconAutenticacion.Acciones.AA
{
    public class EstablecerModoCool: Accion
    {
        #region Campos

        private AireAcondicionado dispositivo;

        #endregion

        #region Constructores

        public EstablecerModoCool(AireAcondicionado dispositivo)
        {
            this.dispositivo = dispositivo;
        }

        #endregion

        #region Ejecución

        public void Ejecutar()
        {
            this.dispositivo.EstablecerModoCool();
        }

        #endregion
    }
}
