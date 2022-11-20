namespace BibliotacaTruco
{
    public class Carta
    {
        #region ATRIBUTOS
        private int numeroCarta;
        private EPalo palo;
        private EIndiceValor indiceCarta;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor de cartas, recibe el numero de la carta, un enum de palo, y su indice de valor
        /// </summary>
        /// <param name="numeroCarta"></param>
        /// <param name="palo"></param>
        /// <param name="indiceCarta"></param>
        public Carta(int numeroCarta, EPalo palo,EIndiceValor indiceCarta)
        {
            this.numeroCarta = numeroCarta;
            this.palo = palo;
            this.indiceCarta = indiceCarta;
        }
        #endregion ATRIBUTOS

        #region PROPIEDADES
        /// <summary>
        /// geter de Numero de carta, retorna int 
        /// </summary>
        public int NumeroCarta { get => this.numeroCarta; }
        /// <summary>
        /// geter del palo de la carta, retorna EPalo
        /// </summary>
        public EPalo Palo { get => this.palo; }
        /// <summary>
        /// Geter del indice de carta, retorna un EIndiceValor
        /// </summary>
        public EIndiceValor IndiceCarta { get => this.indiceCarta; }
        #endregion PROPIEDADES


    }
}