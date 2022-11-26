using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace BibliotacaTruco
{
    public class Jugador
    {
        #region ATRIBUTOS
        private string nombre;
        private List<Carta> cartas;
        private int puntaje;
        private int manosActualesGanadas;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public Jugador(string nombre)
        {
            this.nombre = nombre;
            cartas = new List<Carta>();
            this.puntaje = 0;
            this.manosActualesGanadas = 0;
        }
        #endregion CONSTRUCTOR

        #region PROPIEDADES
        /// <summary>
        /// geter de la lista de cartas del jugador
        /// </summary>
        public List<Carta> Cartas 
        {
            get
            {
                return this.cartas;
            }
           
        }

        /// <summary>
        /// retorna la cantidad de envido
        /// </summary>
        public int Envido
        {
            get { return this.CantidadEnvido(); }
        }

        /// <summary>
        /// geter y seter del puntaje del jugador
        /// </summary>
        public int Puntaje { get => puntaje; set => puntaje = value; }
        /// <summary>
        /// Geter y seter de las manos actuales ganadas por el jugador
        /// </summary>
        public int ManosActualesGanadas { get => manosActualesGanadas; set => manosActualesGanadas = value; }
        /// <summary>
        /// Retorna el nombre del jugador
        /// </summary>
        public string Nombre { get => nombre;  }

        #endregion PROPIEDADES

        #region METODOS
        /// <summary>
        /// agreaga carta a la lista
        /// </summary>
        /// <param name="carta"></param>
        public bool AgregarCarta(Carta carta)
        {
            bool retorno = false;
            if (carta is not null)
            {
                this.cartas.Add(carta);
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// retrona cantidad de envido del jugador
        /// </summary>
        /// <returns></returns>
        private int CantidadEnvido()
        {
            int retorno = 0;   
            int aux ;
            bool cartaMasAlta = false;
            int bufferCartaMasAlta =0;
            Carta c1;
            Carta c2;
           //TODO: Buscar las dos cartas del mismo palo mas altas 
            for (int i = 0; i < this.Cartas.Count -1; i++)
            {
                aux = (int)this.cartas[i].Palo;//obtengo indice de palo
                for (int j = 1; j < this.Cartas.Count; j++)
                {
                    if (aux == (int)this.cartas[j].Palo)
                    {
                         c1 = this.Cartas[i];
                         c2 = this.Cartas[j];
                        retorno = CalcularEnvidoDeLaSumaDeDosCartas(c1, c2);
                        return retorno;
                       
                    }
                }                                  
            }
            for (int i = 0; i < this.Cartas.Count; i++)
            {
                int buffer = this.cartas[i].NumeroCarta;
                if (!cartaMasAlta || buffer > bufferCartaMasAlta)
                {
                    bufferCartaMasAlta = buffer;
                    cartaMasAlta = true;
                }

            }

                return bufferCartaMasAlta;
        }

        /// <summary>
        /// Recibe dos cartas y  calcula el envido
        /// </summary>
        /// <param name="indice1"></param>
        /// <param name="indice2"></param>
        /// <returns> retorna el envido de las cartas calculadas</returns>
        public int CalcularEnvidoDeLaSumaDeDosCartas(Carta c1, Carta c2)
        {
            if (c1 is not null && c2 is not null)
            {
                int numeroCarta1 = c1.NumeroCarta;
                int numeroCarta2 = c2.NumeroCarta;


                bool flagReyCarta1 = false;
                bool flagReyCarta2 = false;

                if (numeroCarta1 >= 10 && numeroCarta1 <= 12)
                {
                    flagReyCarta1 = true;
                }
                if (numeroCarta2 >= 10 && numeroCarta2 <= 12)
                {
                    flagReyCarta2 = true;
                }

                if (flagReyCarta1 && flagReyCarta2)
                {
                    return 20;
                }
                else if (flagReyCarta1)//si solo esto es rey
                {
                    return 20 + numeroCarta2;
                }
                else if (flagReyCarta2)
                {
                    return 20 + numeroCarta1;
                }
                else
                {
                    return 20 + numeroCarta1 + numeroCarta2;
                }
            }
            return 0;
           
        }

        /// <summary>
        /// retorna un bool si el jugador va a cantar envido
        /// </summary>
        /// <returns> true= jugador canta envido, false jugador no canta envido</returns>
        public  bool CantarEnvido()
        {
            Random random = new Random();
            int buffer = random.Next(0, 100);
            if (buffer % 2 == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// decide si el jugador quiere o no quiere envido
        /// </summary>
        /// <returns> true quiere envido y flase no quiere envido </returns>
        public bool ContestarEnvido()
        {
            Random random = new Random();
            int buffer = random.Next(0, 100);
            if (buffer % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool CantarTruco()
        {
            Random random = new Random();
            int buffer = random.Next(0, 100);
            if (buffer % 2 == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// decide si el jugador quiere o no quiere envido
        /// </summary>
        /// <returns> true quiere envido y flase no quiere envido </returns>
        public bool ContestarTruco()
        {
            Random random = new Random();
            int buffer = random.Next(0, 100);
            if (buffer % 2 == 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Seleccona una carta al azar de la lista de cartas del jugador
        /// </summary>
        /// <returns>Carta seleccoinada de la lista</returns>
        public Carta SeleccionarCartaAlAzar()
        {
            
            Random random = new Random();
            int indice  = random.Next(0, this.cartas.Count  -1);
            Carta cartaATirar = this.cartas[indice];
            this.cartas.Remove(this.cartas[indice]);
            
            

            return cartaATirar;
        }
        #endregion METODOS
    }
}
