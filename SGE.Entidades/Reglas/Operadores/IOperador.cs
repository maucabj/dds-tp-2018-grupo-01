﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGE.WebconAutenticacion.Reglas.Operadores
{
    public interface IOperador
    {
        bool Verificar(decimal referencia, decimal valor);
    }
}
