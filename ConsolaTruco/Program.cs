using BibliotacaTruco;
using BibliotecaTruco;

namespace ConsolaTruco
{
    internal class Program
    {
        static void Main(string[] args)
        {
             SemillaSql semilla = new SemillaSql();//instanciamos cartas

            Jugador jugador1 = new Jugador("Marcos");
            Jugador jugador2 = new Jugador("Alvo");
           

            Sala s1 = new Sala(jugador1, jugador2, semilla.ObtenerCartasDeLaBase());

           // int i = s1.ComenzarPartida();
            Console.WriteLine(i);

            /*
            PuntoJson<string> puntoJson = new PuntoJson<string>();
            string path;
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//obtengo ruta
            path += "\\PruebaSala5.json";//le sumo la expresion xml

            
           bool retorno  =  puntoJson.GuardarComo(path, i.ToString());
            if (retorno)
            {
                Console.WriteLine("Lo guardo");
            }
            else
            {
                Console.WriteLine("No lo guardo");
            }
            
            string sala1Leida = puntoJson.Leer(path);

            if (sala1Leida is not null)
            {
                Console.WriteLine(" el ganador de la sala es:");
                Console.WriteLine(sala1Leida);
            }
            else
            {
                Console.WriteLine("hubo error");
            }
         



            /*
            List<Carta> cartas = semilla.ObtenerCartasDeLaBase();

            if (cartas is not null)
            {
                Console.WriteLine("no viene null");
                foreach (Carta carta in cartas)
                {
                    Console.WriteLine(carta.NumeroCarta.ToString());
                }
            }
            else
            {
                Console.WriteLine("viene null");
            }
            */
            
        }
    }
}