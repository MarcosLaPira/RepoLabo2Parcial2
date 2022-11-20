using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotacaTruco
{
    public  class SemillaSql
    {
        #region ATRIBUTOS
        private List<Carta> cartas;
        private Sql sql;
        #endregion ATRIBUTOS

        #region COSTRUCTOR
        /// <summary>
        /// constructor vacio controla la base de datos y el programa
        /// </summary>
        public SemillaSql()
        { 
            cartas = new List<Carta>();
            this.sql = new Sql();
            CrearCartas();           
        }
        #endregion CONSTRUCTOR

        #region METODOS

        /// <summary>
        /// Crea las 40 cartas del truco
        /// </summary>
        private void CrearCartas()
        {
            //espada
            cartas.Add(new(1, EPalo.espada, EIndiceValor.unoEspada));
            cartas.Add(new(1, EPalo.oro, EIndiceValor.unoOro));
            cartas.Add(new(1, EPalo.basto, EIndiceValor.unoBasto));
            cartas.Add(new(1, EPalo.copa, EIndiceValor.unoCopa));

            cartas.Add(new(2, EPalo.espada, EIndiceValor.dosEspada));
            cartas.Add(new(2, EPalo.oro, EIndiceValor.dosOro));
            cartas.Add(new(2, EPalo.basto, EIndiceValor.dosBasto));
            cartas.Add(new(2, EPalo.copa, EIndiceValor.dosCopa));

            cartas.Add(new(3, EPalo.espada, EIndiceValor.tresEspada));
            cartas.Add(new(3, EPalo.oro, EIndiceValor.tresOro));
            cartas.Add(new(3, EPalo.basto, EIndiceValor.tresBasto));
            cartas.Add(new(3, EPalo.copa, EIndiceValor.tresCopa));

           
            cartas.Add(new(4, EPalo.espada, EIndiceValor.cuatroEspada));
            cartas.Add(new(4, EPalo.oro, EIndiceValor.cuatroOro));
            cartas.Add(new(4, EPalo.basto, EIndiceValor.cuatroBasto));
            cartas.Add(new(4, EPalo.copa, EIndiceValor.cuatroCopa));

            cartas.Add(new(5, EPalo.espada, EIndiceValor.cincoEspada));
            cartas.Add(new(5, EPalo.oro, EIndiceValor.cincoOro));
            cartas.Add(new(5, EPalo.basto, EIndiceValor.cincoBasto));
            cartas.Add(new(5, EPalo.copa, EIndiceValor.cincoCopa));

            cartas.Add(new(6, EPalo.espada, EIndiceValor.seisEspada));
            cartas.Add(new(6, EPalo.oro, EIndiceValor.seisOro));
            cartas.Add(new(6, EPalo.basto, EIndiceValor.seisBasto));
            cartas.Add(new(6, EPalo.copa, EIndiceValor.seisCopa));

            cartas.Add(new(7, EPalo.espada, EIndiceValor.sieteEspada));
            cartas.Add(new(7, EPalo.oro, EIndiceValor.sieteOro));
            cartas.Add(new(7, EPalo.basto, EIndiceValor.sieteBasto));
            cartas.Add(new(7, EPalo.copa, EIndiceValor.sieteCopa));
             
            cartas.Add(new(10, EPalo.espada, EIndiceValor.diezEspada));
            cartas.Add(new(10, EPalo.oro, EIndiceValor.diezOro));
            cartas.Add(new(10, EPalo.basto, EIndiceValor.diezBasto));
            cartas.Add(new(10, EPalo.copa, EIndiceValor.diezCopa));

            cartas.Add(new(11, EPalo.espada, EIndiceValor.onceEspada));
            cartas.Add(new(11, EPalo.oro, EIndiceValor.onceOro));
            cartas.Add(new(11, EPalo.basto, EIndiceValor.onceBasto));
            cartas.Add(new(11, EPalo.copa, EIndiceValor.onceCopa));

            cartas.Add(new(12, EPalo.espada, EIndiceValor.doceEspada));
            cartas.Add(new(12, EPalo.oro, EIndiceValor.doceOro));
            cartas.Add(new(12, EPalo.basto, EIndiceValor.doceBasto));
            cartas.Add(new(12, EPalo.copa, EIndiceValor.doceCopa));
           
        }
      
        /// <summary>
        /// Obtiene cartas de la base si no existen las crea
        /// </summary>
        /// <returns> Lista de cartas para el truco </returns>
        public  List<Carta> ObtenerCartasDeLaBase()
        {
            List<Carta> bufferCartas = new List<Carta>();
            bool flag = false;

            bufferCartas = sql.ObtenerCartas();

            if (bufferCartas.Count is <= 0)
            {
                this.AgregarCartasABaseDeDatos();
                flag = true;
            }
            if (flag)
            {
                bufferCartas = sql.ObtenerCartas();
            }

            return bufferCartas;
           
        }
        /// <summary>
        /// Agreaga cartas a la base de datos
        /// </summary>
        private void AgregarCartasABaseDeDatos()
        {
            try
            {
                foreach (Carta item in cartas)
                {
                    sql.AgregarCarta(item);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Excepcion {e.Message}");
            }
        }

        #endregion METODOS
    }
}
