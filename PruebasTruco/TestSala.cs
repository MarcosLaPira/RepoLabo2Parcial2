
using BibliotacaTruco;
namespace PruebasTruco
{
    [TestClass]
    public class TestSala
    {
        [TestMethod]
        public void TestGanadorDeLaSalaOk()
        {
            //ARANGE 
            


            //ACT


            //ACERT

        }

        [TestMethod]
        public void TestGanadorDeLaSalaEmpateOk()
        {
            //ARANGE 
            Jugador j1 = new Jugador("Marcos");
            Jugador j2 = new Jugador("Agustin");
            //ACT
            j1.Puntaje = 5;
            j2.Puntaje = 5;

            //ACERT
        }


        [TestMethod]
        public void TestGanadorDeLaSalaFail()
        {
            //ARANGE 
            //ACT
            //ACERT
        }

    }
}
