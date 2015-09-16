using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TennisScore;
using TennisScore.Modelo;
namespace TennisScoreTests
{
    [TestClass]
    public class TennisScoreTest
    {
        [TestMethod]
        public void FalleRegistroCuandoFaltenCamposPorLlenar()
        {
            ConfiguracionPartido configuracionPrueba = new ConfiguracionPartido();
            LogicaConfigurarPartido logicaConfigurar = new LogicaConfigurarPartido();
            bool respuesta= logicaConfigurar.ValidarCampos(configuracionPrueba);
            Assert.AreEqual(false, respuesta);
        }


        [TestMethod]
        public void AumentarMarcadorDeSet()
        {
            PuntajePartido configuracionPrueba = new PuntajePartido();
            LogicaRegistrarMarcador logicaRegistrar = new LogicaRegistrarMarcador();
            configuracionPrueba.PuntajeJugador1 = 3;
            configuracionPrueba.PuntajeJugador2 = 2;
            bool respuesta = logicaRegistrar.AumentarSet(configuracionPrueba);
            Assert.AreEqual(true, respuesta);
        }   



        [TestMethod]
        public void SumarSiElMarcadorDeUnJugadorLlegaASeisYElOtroJugadorEsMenorACinco()
        {
            //ConfiguracionPartido configuracionPrueba = new ConfiguracionPartido();
            //LogicaConfigurarPartido logicaConfigurar = new LogicaConfigurarPartido();
            //bool respuesta = logicaConfigurar.ValidarCampos(configuracionPrueba);
            //Assert.AreEqual(false, respuesta);
        }

        [TestMethod]
        public void AumentarMarcadorEnCasoDeQueElMarcadorEsteEnCincoSeisYConcecutivamenteHaciaArriba()
        {
            //ConfiguracionPartido configuracionPrueba = new ConfiguracionPartido();
            //LogicaConfigurarPartido logicaConfigurar = new LogicaConfigurarPartido();
            //bool respuesta = logicaConfigurar.ValidarCampos(configuracionPrueba);
            //Assert.AreEqual(false, respuesta);
        }

        [TestMethod]
        public void VerificarAumentoPuntajeJugador1()
        {
            PuntajePartido puntaje = new PuntajePartido();
            LogicaRegistrarMarcador logica = new LogicaRegistrarMarcador();
            logica.AumentarPunto(ref puntaje, true);
            logica.AumentarPunto(ref puntaje, true);
            Assert.AreEqual(2, puntaje.PuntajeJugador1);
        }

        [TestMethod]
        public void VerificarAumentoPuntajeACEJugador1()
        {
            PuntajePartido puntaje = new PuntajePartido();
            LogicaRegistrarMarcador logica = new LogicaRegistrarMarcador();
            logica.AumentarPuntoACE(ref puntaje, true);
            logica.AumentarPuntoACE(ref puntaje, true);
            Assert.AreEqual(2, puntaje.ACEJ1);
        }

        [TestMethod]
        public void VerificarAumentoPuntajeUsandoACEJugador1()
        {
            PuntajePartido puntaje = new PuntajePartido();
            LogicaRegistrarMarcador logica = new LogicaRegistrarMarcador();
            logica.AumentarPuntoACE(ref puntaje, true);
            logica.AumentarPuntoACE(ref puntaje, true);
            Assert.AreEqual(2, puntaje.PuntajeJugador1);
        }

        [TestMethod]
        public void VerificarAumentoPuntajeUsandoDobleFaltaJugador1()
        {
            PuntajePartido puntaje = new PuntajePartido();
            LogicaRegistrarMarcador logica = new LogicaRegistrarMarcador();
            logica.AumentarDobleFalta(ref puntaje, true);
            logica.AumentarDobleFalta(ref puntaje, true);
            Assert.AreEqual(2, puntaje.PuntajeJugador2);
        }

        [TestMethod]
        public void VerificarAumentoPuntajeUsandoDobleFaltaJugador2()
        {
            PuntajePartido puntaje = new PuntajePartido();
            LogicaRegistrarMarcador logica = new LogicaRegistrarMarcador();
            logica.AumentarDobleFalta(ref puntaje, false);
            logica.AumentarDobleFalta(ref puntaje, false);
            Assert.AreEqual(2, puntaje.PuntajeJugador1);
        }

        [TestMethod]
        public void VerificarActivacionDeuce()
        {
            PuntajePartido puntaje = new PuntajePartido();
            LogicaRegistrarMarcador logica = new LogicaRegistrarMarcador();

            logica.AumentarPunto(ref puntaje, true);
            logica.AumentarPunto(ref puntaje, true);
            logica.AumentarPunto(ref puntaje, true);

            logica.AumentarPunto(ref puntaje, false);
            logica.AumentarPunto(ref puntaje, false);
            logica.AumentarPunto(ref puntaje, false);

            Assert.AreEqual(true, puntaje.Deuce);
        }

        [TestMethod]
        public void ValidarVentaja()
        {
            PuntajePartido puntaje = new PuntajePartido();
            LogicaRegistrarMarcador logica = new LogicaRegistrarMarcador();

            logica.AumentarPunto(ref puntaje, true);
            logica.AumentarPunto(ref puntaje, true);
            logica.AumentarPunto(ref puntaje, true);

            logica.AumentarPunto(ref puntaje, false);
            logica.AumentarPunto(ref puntaje, false);
            logica.AumentarPunto(ref puntaje, false);
            logica.AumentarPunto(ref puntaje, false);

            Assert.AreEqual(true, puntaje.VentajaJ2);
        }

        [TestMethod]
        public void ValidarDeuceDespuesDeAdvance()
        {
            PuntajePartido puntaje = new PuntajePartido();
            LogicaRegistrarMarcador logica = new LogicaRegistrarMarcador();

            logica.AumentarPunto(ref puntaje, true);
            logica.AumentarPunto(ref puntaje, true);
            logica.AumentarPunto(ref puntaje, true);

            logica.AumentarPunto(ref puntaje, false);
            logica.AumentarPunto(ref puntaje, false);
            logica.AumentarPunto(ref puntaje, false);
            logica.AumentarPunto(ref puntaje, false);

            logica.AumentarPunto(ref puntaje, true);

            Assert.AreEqual(true, puntaje.Deuce);
        }

        [TestMethod]
        public void ValidarDobleFaltaDespuesdeDeuceDespuesDeAdvance()
        {
            PuntajePartido puntaje = new PuntajePartido();
            LogicaRegistrarMarcador logica = new LogicaRegistrarMarcador();

            //40  puntos p1
            logica.AumentarPunto(ref puntaje, true);
            logica.AumentarPunto(ref puntaje, true);
            logica.AumentarPunto(ref puntaje, true);

            //40 puntos p2
            logica.AumentarPunto(ref puntaje, false);
            logica.AumentarPunto(ref puntaje, false);
            logica.AumentarPunto(ref puntaje, false);

            //Adv P2
            logica.AumentarPuntoACE(ref puntaje, false);

            //Doble Falta p2
            logica.AumentarDobleFalta(ref puntaje, false);

            //Doble Falta p2
            logica.AumentarDobleFalta(ref puntaje, false);

            Assert.AreEqual(true, puntaje.VentajaJ1);
        }
    }
}
