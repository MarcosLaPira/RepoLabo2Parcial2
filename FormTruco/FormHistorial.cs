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
           
           List<Sala> sala = new List<Sala>();

            sala = puntoJson.Leer(archivo);

           
            
            /*
            List<string> ganadoresDeSalas = puntoJson.Leer(archivo);

            this.lblCantDePartidasJugadas.Text = ganadoresDeSalas[0];

            */

        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
