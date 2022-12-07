using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotacaTruco
{
    public class SemillaSql
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
            this.cartas = new List<Carta>();
            this.sql = new Sql();
            this.CrearCartas();           
        }
        #endregion CONSTRUCTOR

        #region METODOS

        /// <summary>
        /// Crea las 40 cartas del truco
        /// </summary>
        private void CrearCartas()
        {
            //espada
            this.cartas.Add(new(1, EPalo.espada, EIndiceValor.unoEspada));
            this.cartas.Add(new(1, EPalo.oro, EIndiceValor.unoOro));
            this.cartas.Add(new(1, EPalo.basto, EIndiceValor.unoBasto));
            this.cartas.Add(new(1, EPalo.copa, EIndiceValor.unoCopa));

            this.cartas.Add(new(2, EPalo.espada, EIndiceValor.dosEspada));
            this.cartas.Add(new(2, EPalo.oro, EIndiceValor.dosOro));
            this.cartas.Add(new(2, EPalo.basto, EIndiceValor.dosBasto));
            this.cartas.Add(new(2, EPalo.copa, EIndiceValor.dosCopa));

            this.cartas.Add(new(3, EPalo.espada, EIndiceValor.tresEspada));
            this.cartas.Add(new(3, EPalo.oro, EIndiceValor.tresOro));
            this.cartas.Add(new(3, EPalo.basto, EIndiceValor.tresBasto));
            this.cartas.Add(new(3, EPalo.copa, EIndiceValor.tresCopa));

           
            this.cartas.Add(new(4, EPalo.espada, EIndiceValor.cuatroEspada));
            this.cartas.Add(new(4, EPalo.oro, EIndiceValor.cuatroOro));
            this.cartas.Add(new(4, EPalo.basto, EIndiceValor.cuatroBasto));
            this.cartas.Add(new(4, EPalo.copa, EIndiceValor.cuatroCopa));

            this.cartas.Add(new(5, EPalo.espada, EIndiceValor.cincoEspada));
            this.cartas.Add(new(5, EPalo.oro, EIndiceValor.cincoOro));
            this.cartas.Add(new(5, EPalo.basto, EIndiceValor.cincoBasto));
            this.cartas.Add(new(5, EPalo.copa, EIndiceValor.cincoCopa));

            this.cartas.Add(new(6, EPalo.espada, EIndiceValor.seisEspada));
            this.cartas.Add(new(6, EPalo.oro, EIndiceValor.seisOro));
            this.cartas.Add(new(6, EPalo.basto, EIndiceValor.seisBasto));
            this.cartas.Add(new(6, EPalo.copa, EIndiceValor.seisCopa));

            this.cartas.Add(new(7, EPalo.espada, EIndiceValor.sieteEspada));
            this.cartas.Add(new(7, EPalo.oro, EIndiceValor.sieteOro));
            this.cartas.Add(new(7, EPalo.basto, EIndiceValor.sieteBasto));
            this.cartas.Add(new(7, EPalo.copa, EIndiceValor.sieteCopa));
             
            this.cartas.Add(new(10, EPalo.espada, EIndiceValor.diezEspada));
            this.cartas.Add(new(10, EPalo.oro, EIndiceValor.diezOro));
            this.cartas.Add(new(10, EPalo.basto, EIndiceValor.diezBasto));
            this.cartas.Add(new(10, EPalo.copa, EIndiceValor.diezCopa));

            this.cartas.Add(new(11, EPalo.espada, EIndiceValor.onceEspada));
            this.cartas.Add(new(11, EPalo.oro, EIndiceValor.onceOro));
            this.cartas.Add(new(11, EPalo.basto, EIndiceValor.onceBasto));
            this.cartas.Add(new(11, EPalo.copa, EIndiceValor.onceCopa));

            this.cartas.Add(new(12, EPalo.espada, EIndiceValor.doceEspada));
            this.cartas.Add(new(12, EPalo.oro, EIndiceValor.doceOro));
            this.cartas.Add(new(12, EPalo.basto, EIndiceValor.doceBasto));
            this.cartas.Add(new(12, EPalo.copa, EIndiceValor.doceCopa));
           
        }
      
        /// <summary>
        /// Obtiene cartas de la base si no existen las crea
        /// </summary>
        /// <returns> Lista de cartas para el truco </returns>
        public  List<Carta> ObtenerCartasDeLaBase()
        {
            List<Carta> bufferCartas = new List<Carta>();
            bool flag = false;

            bufferCartas = this.sql.ObtenerCartas();

            if (bufferCartas.Count is <= 0)
            {
                this.AgregarCartasABaseDeDatos();
                flag = true;
            }
            if (flag)
            {
                bufferCartas = this.sql.ObtenerCartas();
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
                foreach (Carta item in this.cartas)
                {
                    this.sql.AgregarCarta(item);
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
