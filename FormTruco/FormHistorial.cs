using BibliotacaTruco;
using BibliotecaTruco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTruco
{
    public partial class FormHistorial : Form
    {
        #region ATRIBUTOS
        PuntoJson<Sala> puntoJson = new PuntoJson<Sala>();////
        static string archivo;
        int partidasGanadasPorJugador1 = 0;
        int partidasGanadasPorJugador2 = 0;
        int partidasEmpatadas = 0;
        private List<Sala> historialDeSalas;
        #endregion ATRIBUTOS

        #region METODOS
        public FormHistorial(List<Sala> salas)
        {
            InitializeComponent();
            this.historialDeSalas = salas;
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {
            this.CalcularPartidasGanadas();

            this.lblCantDePartidasJugadas.Text = $" Partidas jugadas: {historialDeSalas.Count.ToString()}";
            this.lblVictoriasDejugador1.Text = $" Victorias jugador1: {this.partidasGanadasPorJugador1.ToString()}";
            this.lblVictoriasDeJugador2.Text = $" Victorias jugador2: {this.partidasGanadasPorJugador2.ToString()}";
            this.lblPartidasEmpatadas.Text =$"Empates : {this.partidasEmpatadas.ToString()}" ;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CalcularPartidasGanadas()
        {
            foreach (Sala item in this.historialDeSalas)
            {
                switch(item.GanadorDeLaSala)
                {
                    case 1:
                        this.partidasGanadasPorJugador1++;

                        break;
                    case -1:
                        this.partidasGanadasPorJugador2++;
                        break;

                    case 0:
                        this.partidasEmpatadas++;
                        break;

                }
            }
                   
        }
        #endregion METODOS

    }
}
