﻿using System;
using GestionBancariaAppNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTests //GAG22-23
    {
        /* [TestMethod]
        // unit test code [TestMethod] GAG22-23
        public void validarReintegro()
        {
            // Preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 250;
            double saldoEsperado = 750;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            miApp.RealizarReintegro(reintegro);
            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el reintegro, saldo incorrecto.");
        }

        [TestMethod]
        // unit test code [TestMethod] GAG22-23
        public void validarReintegroNegativo()
        {
            // Preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = -100;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            int resultado = miApp.RealizarReintegro(reintegro);
            Assert.AreEqual(1, resultado, 0.001, "Se produjo un error al realizar el reintegro, saldo incorrecto.");
        }

        [TestMethod]
        // unit test code [TestMethod] GAG22-23
        public void validarReintegroCero()
        {
            // Preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 0;
            double saldoEsperado = 1000;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            miApp.RealizarReintegro(reintegro);
            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el reintegro, saldo incorrecto.");
        }

        [TestMethod]
        // unit test code [TestMethod] GAG22-23
        public void validarReintegroSaldoInsuficiente()
        {
            // Preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 1100;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            int resultado = miApp.RealizarReintegro(reintegro);
            Assert.AreEqual(2, resultado, 0.001, "Se produjo un error al realizar el reintegro, saldo incorrecto.");
        }

        // unit test code [TestMethod] GAG22-23
        public void validarReintegroSaldo()
        {
            // Preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 1000;
            double saldoEsperado = 0;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            miApp.RealizarReintegro(reintegro);
            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el reintegro, saldo incorrecto.");
        }

        // unit test code [TestMethod] GAG22-23
        public void validarSaldoMayor()
        {
            // Preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 1000.1;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            int resultado = miApp.RealizarReintegro(reintegro);
            Assert.AreEqual(2, resultado, 0.001, "Se produjo un error al realizar el reintegro, saldo incorrecto.");
        }

        // unit test code [TestMethod] GAG22-23
        public void validarSaldoMenor()
        {
            // Preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 999.9;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            int resultado = miApp.RealizarReintegro(reintegro);
            Assert.AreEqual(2, resultado, 0.001, "Se produjo un error al realizar el reintegro, saldo incorrecto.");
        }

        //Comprobación de "RealizarIngreso". GAG22-23

        [TestMethod]
        // unit test code [TestMethod] GAG22-23
        public void validarIngresoNegativo()
        {
            // Preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = -1000;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            double resultado = miApp.RealizarIngreso(ingreso);
            Assert.AreEqual(1, resultado, 0.001, "Se produjo un error al realizar el ingreso");
        }

        [TestMethod]
        // unit test code [TestMethod] GAG22-23
        public void validarIngresoPositivo()
        {
            // Preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 1100;
            double saldoEsperado = 2100;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            miApp.RealizarIngreso(ingreso);
            // Método a probar
            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el reintegro, saldo incorrecto.");
        }

        [TestMethod]
        // unit test code [TestMethod] GAG22-23
        public void validarIngresoCero()
        {
            // Preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 0;
            double saldoEsperado = 1000;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            miApp.RealizarIngreso(ingreso);
            // Método a probar
            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "Se produjo un error al realizar el reintegro, saldo incorrecto.");
        }
        

        //Pruebas con manejo de excepciones GAG22-23

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarReintegroCantidadNoValida()
        {
            double saldoInicial = 1000;
            double reintegro = 1250;
            double saldoFinal = saldoInicial - reintegro;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            miApp.RealizarReintegro(reintegro);
        }

        [TestMethod]
        // unit test code [TestMethod] GAG22-23
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void validarIngresoNegativoExcepcion()
        {
            // Preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = -1000;
            double saldoFinal = saldoInicial + ingreso;
            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            // Método a probar
            miApp.RealizarIngreso(ingreso);
        }
        */

        //Métodos de prueba tras implementación de excepciones.

        [TestMethod] //GAG22-23
        public void ValidarIngresoCantidadNoValida()
        {
            double saldoInicial = 1000;
            double ingreso = -250;

            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);
            try
            {
                miApp.RealizarIngreso(ingreso);
            }
            catch (ArgumentException exception)
            {
                StringAssert.Equals(exception.Message, GestionBancariaApp.ERR_CANTIDAD_NO_VALIDA);
            }
        }

        [TestMethod] //GAG22-23
        public void ValidarReintegroMayorSaldo()
        {
            double saldoInicial = 1000;
            double reintegro = 1500;
            double saldoEsperado = saldoInicial - reintegro;

            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);

            try
            {
                miApp.RealizarReintegro(reintegro);
            }
            catch (ArgumentException exception)
            {
                StringAssert.Equals(exception.Message, GestionBancariaApp.ERR_SALDO_INSUFICIENTE);
            }
        }

        [TestMethod] //GAG22-23
        public void ValidarReintegroCantidadNoValida()
        {
            double saldoInicial = 1000;
            double reintegro = -250;
            double saldoEsperado = saldoInicial - reintegro;

            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);

            try
            {
                miApp.RealizarReintegro(reintegro);
            }
            catch (ArgumentException exception)
            {
                StringAssert.Equals(exception.Message, GestionBancariaApp.ERR_CANTIDAD_NO_VALIDA);
            }
        }
    }
}
