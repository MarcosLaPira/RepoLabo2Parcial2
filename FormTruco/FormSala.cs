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
            ganadorDeLaSala  = sala.ComenzarPartida();

            lblIdSala.Text = numeroSala.ToString();//seteo id de sala
        }

        public int GanadorDeLaSala
        {
            get { return ganadorDeLaSala; }
        }

       
    }
}
