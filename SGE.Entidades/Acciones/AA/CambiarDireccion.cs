﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGE.WebconAutenticacion.Dispositivos;

namespace SGE.WebconAutenticacion.Acciones.AA
{
    public class CambiarDireccion: Accion
    {
        #region Campos

        private AireAcondicionado dispositivo;

        #endregion

        #region Constructores

        public CambiarDireccion(AireAcondicionado dispositivo)
        {
            this.dispositivo = dispositivo;
        }

        #endregion

        #region Ejecución

        public void Ejecutar()
        {
            this.dispositivo.CambiarDireccion();
        }

        #endregion
    }
}
