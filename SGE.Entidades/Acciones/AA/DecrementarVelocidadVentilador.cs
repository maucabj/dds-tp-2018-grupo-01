﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGE.Entidades.Dispositivos;

namespace SGE.Entidades.Acciones.AA
{
    public class DecrementarVelocidadVentilador: IAccion
    {
        #region Campos

        private AireAcondicionado dispositivo;

        #endregion

        #region Constructores

        public DecrementarVelocidadVentilador(AireAcondicionado dispositivo)
        {
            this.dispositivo = dispositivo;
        }

        #endregion

        #region Ejecución

        public void Ejecutar()
        {
            this.dispositivo.DecrementarVelocidadVentilador();
        }

        #endregion
    }
}
