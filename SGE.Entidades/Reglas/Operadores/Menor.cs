﻿namespace SGE.Entidades.Reglas.Operadores {
    public class Menor : Operador {
        public override bool Verificar(string referencia, string valor) {
            return decimal.Parse(valor) < decimal.Parse(referencia);
        }
    }
}
