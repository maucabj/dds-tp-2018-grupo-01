﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SGE.Entidades;

namespace SGE.Tests.Entidades
{
    [TestClass]
    public class AdministradorTest
    {
        [TestMethod]
        public void TieneAntiguedadIgualACero()
        {
            Assert.IsFalse((new Administrador()).Antiguedad > 0);
        }
    }
}