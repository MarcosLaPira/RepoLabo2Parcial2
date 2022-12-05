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
        PuntoJson<Sala> puntoJson = new PuntoJson<Sala>();////
        static string archivo;
        private List<Sala> historialDeSalas;
        public FormHistorial(List<Sala> salas)
        {
            InitializeComponent();
            this.historialDeSalas = salas;
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {
          
                this.lblCantDePartidasJugadas.Text = this.historialDeSalas[0].NombreDelGanador;

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
