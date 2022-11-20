
using BibliotacaTruco;

namespace PruebasTruco
{
    [TestClass]
    public class TestJugador
    {
        [TestMethod]
        public void TestCalcularEnvidoDeLaSumaDeDosCartasOk()
        {
            // Jugador j = new
            Carta c1 = new Carta(7, EPalo.espada, EIndiceValor.sieteEspada);
            Carta c2 = new Carta(6, EPalo.espada, EIndiceValor.seisEspada);

            Jugador jugador = new Jugador("Marcos");
            jugador.AgregarCarta(c1);
            jugador.AgregarCarta(c2);

            int resultado = jugador.CalcularEnvidoDeLaSumaDeDosCartas(c1, c2);

            Assert.AreEqual(33, resultado);
        }
        [TestMethod]
        public void TestCalcularEnvidoDeLaSumaDeDosCartasFail()
        {
            // Jugador j = new
            Carta c1 = new Carta(7, EPalo.espada, EIndiceValor.sieteEspada);
            Carta c2 = new Carta(6, EPalo.espada, EIndiceValor.seisEspada);

            Jugador jugador = new Jugador("Marcos");
            jugador.AgregarCarta(c1);
            jugador.AgregarCarta(c2);

            int resultado = jugador.CalcularEnvidoDeLaSumaDeDosCartas(c1, c2);
            int resultadoEsperado = 20;
            
           Assert.AreNotEqual(resultado, resultadoEsperado);
        }

        [TestMethod]
        public void TestAgregarCartaOk()
        {
            // Jugador j = new
            Carta c1 = new Carta(7, EPalo.espada, EIndiceValor.sieteEspada);
           

            Jugador jugador = new Jugador("Marcos");

            jugador.AgregarCarta(c1);


            bool retorno =  jugador.AgregarCarta(c1);

            Assert.IsTrue(retorno);

        }

        [TestMethod]
        public void TestCantidadEnvidoOk()
        {
            // Jugador j = new
            Carta c1 = new Carta(7, EPalo.espada, EIndiceValor.sieteEspada);
            Carta c2 = new Carta(6, EPalo.espada, EIndiceValor.seisEspada);
            Carta c3 = new Carta(6, EPalo.basto, EIndiceValor.seisEspada);

            Jugador jugador = new Jugador("Marcos");
            jugador.AgregarCarta(c1);
            jugador.AgregarCarta(c2);
            jugador.AgregarCarta(c3);

            int resultado = jugador.CalcularEnvidoDeLaSumaDeDosCartas(c1, c2);

            Assert.AreEqual(33, resultado);


        }


        [TestMethod]
        public void TestSeleccionCartaAlAzarOk()
        {
           
            Carta c1 = new Carta(7, EPalo.espada, EIndiceValor.sieteEspada);
            Carta c2 = new Carta(6, EPalo.espada, EIndiceValor.seisEspada);
            Carta c3 = new Carta(6, EPalo.basto, EIndiceValor.seisEspada);
            Jugador jugador = new Jugador("Marcos");

            jugador.AgregarCarta(c1);
            jugador.AgregarCarta(c2);
            jugador.AgregarCarta(c3);

            Carta nueva = jugador.SeleccionarCartaAlAzar();

            Assert.IsTrue(nueva is Carta);

        }

        [TestMethod]
        public void TestSeleccionCartaAlAzarTraerTodasLasCartasOk()
        {

            Carta c1 = new Carta(7, EPalo.espada, EIndiceValor.sieteEspada);
            Carta c2 = new Carta(6, EPalo.espada, EIndiceValor.seisEspada);
            Carta c3 = new Carta(6, EPalo.basto, EIndiceValor.seisEspada);

            Jugador jugador = new Jugador("Marcos");

            jugador.AgregarCarta(c1);
            jugador.AgregarCarta(c2);
            jugador.AgregarCarta(c3);

        
            bool retorno = true;

            foreach (Carta item in jugador.Cartas)
            {
                Carta nueva = jugador.SeleccionarCartaAlAzar();
                if (nueva is null)
                {
                    retorno = false;
                }
            }

            Assert.IsTrue(retorno);

        }


    }
}