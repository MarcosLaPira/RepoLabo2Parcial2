using BibliotacaTruco;
namespace PruebasTruco
{
    [TestClass]
    public class TestMano
    {
        [TestMethod]
        public void TestGanadorDeLaTiradaOk()
        {
            //ARANGE 
            Carta c1 = new Carta(1, EPalo.espada, EIndiceValor.unoEspada);
            Carta c2 = new Carta(6, EPalo.espada, EIndiceValor.seisEspada);

            //ACT
            int ganador = Mano.GanadorDeTirada(c1,c2);

            //ASERT
            Assert.AreEqual(1, ganador);

        }
        [TestMethod]
        public void TestGanadorDeLaTiradaEmpateOk()
        {
            //ARANGE 
            Carta c1 = new Carta(5, EPalo.basto, EIndiceValor.cincoBasto);
            Carta c2 = new Carta(5, EPalo.copa, EIndiceValor.cincoCopa);

            //ACT
            int ganador = Mano.GanadorDeTirada(c1, c2);

            //ASERT
            Assert.AreEqual(0, ganador);

        }
        [TestMethod]
        public void TestGanadorDeLaTiradaFail()
        {
            //ARANGE 
            Carta c1 = new Carta(5, EPalo.basto, EIndiceValor.cincoBasto);
            Carta c2 = new Carta(7, EPalo.copa, EIndiceValor.sieteCopa);

            //ACT
            int ganador = Mano.GanadorDeTirada(c1, c2);

            //ASERT
            Assert.AreNotEqual(0, ganador);
        }


        [TestMethod]
        public void TestGanadorDelEnvidioOk()
        {
            //ARANGE 
            Jugador j1 = new Jugador("Marcos");
            Jugador j2 = new Jugador("Agus");

            //ACT
            Carta c1 = new Carta(7, EPalo.espada, EIndiceValor.sieteEspada);
            Carta c2 = new Carta(10, EPalo.basto, EIndiceValor.diezBasto);
            Carta c3 = new Carta(6, EPalo.espada, EIndiceValor.seisEspada);

            Carta c4 = new Carta(3, EPalo.oro, EIndiceValor.tresOro);
            Carta c5 = new Carta(6, EPalo.oro, EIndiceValor.seisOro);
            Carta c6 = new Carta(10, EPalo.espada, EIndiceValor.diezEspada);

            j1.AgregarCarta(c1);
            j1.AgregarCarta(c2);
            j1.AgregarCarta(c3);

            j2.AgregarCarta(c4);
            j2.AgregarCarta(c5);
            j2.AgregarCarta(c6);

            int resultado = Mano.GanadorEnvido(j1,j2);

            //ASERT

            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void TestGanadorDelEnvidioSinPalosIgualesOk()
        {
            //ARANGE 
            Jugador j1 = new Jugador("Marcos");
            Jugador j2 = new Jugador("Agus");

            //ACT
            Carta c1 = new Carta(7, EPalo.espada, EIndiceValor.sieteEspada);
            Carta c2 = new Carta(10, EPalo.basto, EIndiceValor.diezBasto);
            Carta c3 = new Carta(6, EPalo.copa, EIndiceValor.seisCopa);

            Carta c4 = new Carta(3, EPalo.basto, EIndiceValor.tresBasto);
            Carta c5 = new Carta(6, EPalo.oro, EIndiceValor.seisOro);
            Carta c6 = new Carta(10, EPalo.espada, EIndiceValor.diezEspada);

            j1.AgregarCarta(c1);
            j1.AgregarCarta(c2);
            j1.AgregarCarta(c3);

            j2.AgregarCarta(c4);
            j2.AgregarCarta(c5);
            j2.AgregarCarta(c6);

            int resultado = Mano.GanadorEnvido(j1, j2);

            //ASERT

            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void TestGanadorDelEnvidioEmpateOk()
        {
            //ARANGE 
            Jugador j1 = new Jugador("Marcos");
            Jugador j2 = new Jugador("Agus");

            //ACT
            Carta c1 = new Carta(7, EPalo.espada, EIndiceValor.sieteEspada);
            Carta c2 = new Carta(10, EPalo.basto, EIndiceValor.diezBasto);
            Carta c3 = new Carta(6, EPalo.espada, EIndiceValor.seisEspada);

            Carta c4 = new Carta(7, EPalo.copa, EIndiceValor.sieteCopa);
            Carta c5 = new Carta(6, EPalo.oro, EIndiceValor.seisOro);
            Carta c6 = new Carta(6, EPalo.copa, EIndiceValor.diezCopa);

            j1.AgregarCarta(c1);
            j1.AgregarCarta(c2);
            j1.AgregarCarta(c3);

            j2.AgregarCarta(c4);
            j2.AgregarCarta(c5);
            j2.AgregarCarta(c6);

            int resultado = Mano.GanadorEnvido(j1, j2);

            //ASERT

            Assert.AreEqual(0, resultado);

        }

       

    }
}