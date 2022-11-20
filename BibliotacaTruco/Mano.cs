using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotacaTruco
{
    public static class Mano   
    {

        #region METODOS
        /// <summary>
        /// compara la carta del jugador 1 contra la del jugador 2
        /// </summary>
        /// <param name="cartaJugador1"></param>
        /// <param name="cartaJugador2"></param>
        /// <returns> retorna 1 si el ganador es el jugador 1 , -1 si el ganador es el jugador 2 y 0 si hay empate</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int GanadorDeTirada(Carta cartaJugador1, Carta cartaJugador2)
        {
            int retorno=0;
            if (cartaJugador1 is not null && cartaJugador2 is not null)
            {
                if (cartaJugador1.IndiceCarta < cartaJugador2.IndiceCarta)
                {
                    retorno = 1;
                }
                else
                {
                    if (cartaJugador1.IndiceCarta > cartaJugador2.IndiceCarta)
                    {
                        retorno = -1;
                    }
                    else
                    {
                        retorno = 0;
                    }
                }
            }
            return retorno;
        }
        /// <summary>
        /// recibe dos juagadores y determina quien gano el envido
        /// </summary>
        /// <param name=""></param>
        /// <returns> retorna 1 si el ganador es el jugador 1 , -1 si el ganador es el jugador 2 y 0 si hay empate</returns>
        public static int GanadorEnvido(Jugador jugador1, Jugador jugador2)
        {
            int retorno = 0;
           
            if (jugador1 is not null && jugador2 is not null)
            {
                int envidoJugador1 = jugador1.Envido;
                int envidoJugador2 = jugador2.Envido;

                if (envidoJugador1 > envidoJugador2)
                {
                    retorno = 1;
                }
                else
                {
                    if (envidoJugador1 < envidoJugador2)
                    {
                        retorno = -1;
                    }
                    else
                    {
                        retorno = 0;
                    }
                }

            }
            return retorno;
        }

        #endregion METODOS

    }
}
