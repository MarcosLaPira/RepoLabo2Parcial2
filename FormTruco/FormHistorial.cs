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
        public FormHistorial(string path)
        {
            InitializeComponent();
            archivo = path;
        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {
           
           Sala sala = new Sala();

            sala = (Sala)puntoJson.Leer(archivo);
            if (sala is not null)
            {
                this.lblCantDePartidasJugadas.Text = sala.NombreDelGanador;
                
            }
           
            
            /*
            List<string> ganadoresDeSalas = puntoJson.Leer(archivo);


            */

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
