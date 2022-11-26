using BibliotacaTruco;
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
    public partial class FormSala : Form
    {
        static int numeroSala = 1;
        private int ganadorDeLaSala;
        private Sala sala;

        static FormSala()
        {
            numeroSala++;
        }
        public FormSala(Sala sala)
        {          
            this.sala = sala;
            InitializeComponent();
        }
       
        private void FormSala_Load(object sender, EventArgs e)
        {

            sala.ComenzarPartida();
            string nombreGandor = sala.NombreDelGanador;

            this.lblIdSala.Text = $"Sala numero {numeroSala.ToString()}";
            this.lblGanadorSala.Text = $" El ganador de la sala es: {nombreGandor}";
          
        }

        public int GanadorDeLaSala
        {
            get { return ganadorDeLaSala; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
