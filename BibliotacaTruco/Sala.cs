using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotacaTruco
{
    public class Sala
    {
        #region ATRIBUTOS
        private Jugador jugador1;
        private Jugador jugador2;
        private List<Carta> mazo;
        private int rondasJugadas = 0;
        private int manosJugadas = 0;
        private int ganadorDeLaSala;
      
        #endregion ATRIBUTOS

        #region CONSTRUCTOR     
        /// <summary>
        /// constructor de sala, recibe dos jugadores y nuna lista de cartas
        /// </summary>
        /// <param name="jugador1"></param>
        /// <param name="jugador2"></param>
        /// <param name="mazo"></param>
        public Sala(Jugador jugador1, Jugador jugador2, List<Carta> mazo)
        {
            this.jugador1 = jugador1;
            this.jugador2 = jugador2;
            this.mazo = mazo;           
        }
        #endregion CONSTRUCTOR

        #region PROPIEDADES
        /// <summary>
        /// Retorna ganador de la sala tipo int. 1 si el ganador es el jugador1, -1 si el ganadore es el jugador2 y 0 si es empate
        /// </summary>
        public int GanadorDeLaSala { get => ganadorDeLaSala; set => ganadorDeLaSala = value; }
        #endregion PROPIEDADES

        #region metodos
        /// <summary>
        /// controlador de la partida, se jugaran 4 rondas e ira invocando las diferentes instancias de una ronda
        /// </summary>
        /// <returns>jugador ganador, con mayor puntaje. Retorna 1 ganador jugador1, -1 ganador jugador2 y 0 empate</returns>
        public int ComenzarPartida()
        {
            
            //se jugaran 4 rondas
            while (this.rondasJugadas < 4)
            {

                this.RepartirCartas();

                //zona envido
                if (this.rondasJugadas % 2 == 0)
                {
                    this.ZonaEnvido(this.jugador1, this.jugador2);
                }
                else
                {
                    this.ZonaEnvido(this.jugador2, this.jugador1);
                }

                //zona tirada y truco
                this.ZonaTirarCartasYTruco();

                //ronda finalizada
                this.RondaFinalizada();

            }
              int ganador =  CalcularGanadorDeLaSala(this.jugador1, this.jugador2);

            return ganador;
        }
        /// <summary>
        /// copia el mazo y le setea 3 cartas random a cada jugador
        /// </summary>
        private void RepartirCartas()
        {
            List<Carta> bufferMazo = new List<Carta>(this.mazo);//this.mazo;
            Random rand = new Random();
            int indiceCarta;
            
            for (int i = 0; i < 6; i++)
            {
                indiceCarta = rand.Next(0, bufferMazo.Count-1);///

                if (i < 3)
                {
                    jugador1.AgregarCarta(bufferMazo[indiceCarta]);
                }
                else
                {
                    jugador2.AgregarCarta(bufferMazo[indiceCarta]);
                }
                bufferMazo.Remove(bufferMazo[indiceCarta]);
            }
        }         

        /// <summary>
        /// determina la zona envido y setea puntajes de ser necesario
        /// </summary>
        private void ZonaEnvido(Jugador jugadorMano, Jugador jugadorNoMano)
        {
            bool envido = jugadorMano.CantarEnvido();//retorna booo al azar si quiere cantar envido
            if (envido)
            {
                bool rtaEnvido = jugadorNoMano.ContestarEnvido();
                if (rtaEnvido)//si jugador 2 quiere envido
                {
                    int ganadorEnvido = Mano.GanadorEnvido(jugadorMano, jugadorNoMano);//verifico quien gano envido
                    if (ganadorEnvido == 1)//caso de que gano el jugador1
                    {
                        setearPuntaje(jugadorMano, 2);
                    }
                    else if (ganadorEnvido == -1)//caso de que gano el jugador2
                    {
                        setearPuntaje(jugadorNoMano, 2);
                    }
                }
                else//caso de que no quiera envido jugador no mano
                {
                    setearPuntaje(jugadorMano, 1);
                }
            }
           
        }
        /// <summary>
        /// setea puntajes del jugador
        /// </summary>
        /// <param name="jugador"> jugador a setear puntaje </param>
        /// <param name="puntajeASetear"> cantidad de puntos a setear</param>
        private void setearPuntaje(Jugador jugador, int puntajeASetear)
        {
            jugador.Puntaje = puntajeASetear + jugador.Puntaje;
        } 

        /// <summary>
        /// tira dos cartas al azar, retorna quien gano la mano
        /// </summary>
        /// <param name="jugMano"></param>
        /// <param name="jugNoMano"></param>
        /// <returns> 1 si el ganador es carta mano, -1 si el ganador es carta no mano y 0 empate </returns>
        private int TirarCartas(Jugador jugMano, Jugador jugNoMano)
        {               
            Carta cartaMano = jugMano.SeleccionarCartaAlAzar();
            Carta cartaNoMano = jugNoMano.SeleccionarCartaAlAzar();

            int ganadorMano = Mano.GanadorDeTirada(cartaMano, cartaNoMano);
                                   
            return ganadorMano;
        }

        /// <summary>
        /// Verifica si se canta truco y devuelve lo ocurrido
        /// </summary>
        /// <param name="jugMano"></param>
        /// <param name="jugNoMano"></param>
        /// <returns> 1 si el truco es aceptado, -1 truco rechazado y 0 no se canto truco</returns>
        private int ZonaTruco(Jugador jugMano, Jugador jugNoMano)
        {
            int retorno = 0;
            bool truco = jugMano.CantarTruco();//retorna booo al azar si quiere cantar envido
            if (truco)
            {
                bool rtaTruco = jugNoMano.ContestarTruco();
                if (rtaTruco)//si jugador 2 quiere envido
                {
                    retorno = 1;
                }
                else
                {
                    retorno = -1;
                }
            }
            return retorno;
        }
        /// <summary>
        /// juega las tres manos y verifica si se canto o no truco, setea los puntajes correspondientes al truco
        /// </summary>
        private void ZonaTirarCartasYTruco()
        {
            //juego primer ronda 
            bool flagJug1Mano = false;//determina quien es la mano
            bool flagTruco = false;//para que no lo canten mas de una vez
            bool flagTrucoRechazado = false;//para calcular al moemento de setear puntaje 

            int resultado;
            int respuestaTruco;
            int puntosASetear = 1;

            //determino quien comienza la mano dependiendo de la ronda 
            if (this.rondasJugadas % 2 == 0)//ronda par comienza jug1
            {
                flagJug1Mano = true;           
            }

            /////////
            while ( this.manosJugadas < 3 && jugador1.ManosActualesGanadas < 2 && jugador2.ManosActualesGanadas < 2 )//juego las 3 rondas
            {
                this.manosJugadas++;
                if (flagJug1Mano)//comienza el jugador 1
                {
                    if (!flagTruco)//flag truco en false
                    {
                        respuestaTruco = ZonaTruco(jugador1, jugador2);//se tiene un retorno del truco

                        if (respuestaTruco == 1)//truco aceptado
                        {
                            puntosASetear = 2;
                            flagTruco = true;//flag truco en true, no vuelve a entrar
                        }
                        else if (respuestaTruco == -1)//truco rechazado, finalizo ronda
                        {
                            this.setearPuntaje(jugador1, puntosASetear);//seteo un punto
                            flagTrucoRechazado = true;
                            break;
                        }
                    }
                 
                    resultado = TirarCartas(jugador1, jugador2);
                    if (resultado == 1)
                    {
                        jugador1.ManosActualesGanadas++;
                        flagJug1Mano = true;//significa que volvera a ser mano
                    }
                    else if (resultado == -1)
                    {
                        jugador2.ManosActualesGanadas++;
                        flagJug1Mano = false;//significa que hay un cambio de mano
                    }
                                                        
                }
                else
                {
                    if (!flagTruco)
                    {
                        respuestaTruco = ZonaTruco(jugador2, jugador1);

                        if (respuestaTruco == 1)//truco aceptado
                        {
                            puntosASetear = 2;
                            flagTruco = true;
                        }
                        else if (respuestaTruco == -1)//truco rechazado, finalizo ronda
                        {
                            this.setearPuntaje(jugador2, puntosASetear);//seteo 1 punto
                            flagTrucoRechazado = true;
                            break;
                        }
                    }

                    resultado = TirarCartas(jugador2, jugador1);
                    if (resultado == 1)
                    {
                        jugador2.ManosActualesGanadas++;
                        flagJug1Mano = true;//significa que volvera a tirar carta la mano
                    }
                    else if (resultado == -1)
                    {
                        jugador1.ManosActualesGanadas++;

                        flagJug1Mano = false;//significa que hay un cambio de mano
                    }

                }
            }
            if (!flagTrucoRechazado)
            {
                this.SetearPuntajesDeLaRonda(flagTruco,puntosASetear);
            }
                   

        }
        /// <summary>
        /// recibe un bool si el truco fue cantado y la cantidad de puntos que se deberian de setear
        /// </summary>
        /// <param name="flagTruco"></param>
        /// <param name="puntosASetear"></param>
        private void SetearPuntajesDeLaRonda(bool flagTruco,int puntosASetear)
        {
            if (jugador1.ManosActualesGanadas > jugador2.ManosActualesGanadas)
            {
                if (flagTruco)//si el truco fue querido
                {
                    this.setearPuntaje(jugador1, puntosASetear);//seteo 2 puntos

                }
                else
                {
                    this.setearPuntaje(jugador1, puntosASetear);//seteo 1
                }
            }
            else
            {
                if (flagTruco)
                {
                    this.setearPuntaje(jugador2, puntosASetear);

                }
                else
                {
                    this.setearPuntaje(jugador2, puntosASetear);
                }
            }
        }

        /// <summary>
        /// Calcula el jugador con mayor puntaje
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns>1 ganador j1, -1 ganador j2 y 0 empate</returns>
        private int CalcularGanadorDeLaSala(Jugador j1, Jugador j2)
        {
            int retorno ;

            if (j1.Puntaje > j2.Puntaje)
            {
                retorno = 1;
            }
            else if (j1.Puntaje < j2.Puntaje)
            {
                retorno = -1;
            }
            else
            {
                retorno = 0;
            }
            ganadorDeLaSala = retorno;
            return retorno;
        }
        /// <summary>
        /// finaliza la ronda, limpia la lista de cartas de cada jugador, incrementa las rondas en 1 y setea las manos actuales ganadsas en 0
        /// </summary>
        private void RondaFinalizada()
        {
            this.jugador1.Cartas.Clear();
            this.jugador2.Cartas.Clear();
            this.jugador1.ManosActualesGanadas = 0;
            this.jugador2.ManosActualesGanadas = 0;

            this.rondasJugadas++;
            this.manosJugadas = 0;
        }
        #endregion metodos
    }
}
