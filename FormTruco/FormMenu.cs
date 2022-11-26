using BibliotacaTruco;
using BibliotecaTruco;

namespace FormTruco
{
    public partial class FormMenu : Form
    {       
        static List<Carta> mazo;
        static SemillaSql semillaSql;
        static PuntoJson<string> puntoJson;
        static string path;

        Sala sala;

        static FormMenu()
        {
            semillaSql = new SemillaSql();
            mazo = semillaSql.ObtenerCartasDeLaBase();

            puntoJson = new PuntoJson<string>();         
           
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//obtengo ruta
            path += "\\PruebaSala6.json";//le sumo la expresion xml
        }
        public FormMenu()
        {
            InitializeComponent();
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
           // ActualizarLista();
        }
        private void btnCrearSala_Click(object sender, EventArgs e)
        {
            
            Jugador j1 = new Jugador("Jugador 1");
            Jugador j2 = new Jugador("Jugador 2");
             sala = new Sala(j1,j2,mazo);
           
            FormSala formSala = new FormSala(sala);

            this.Hide();
            if (formSala.ShowDialog() == DialogResult.OK)
            {
                formSala.Hide();
                this.Show();
                ActualizarLista();
            }
           
        }

        private void ActualizarLista()
        {

            string nombreGandor = this.sala.NombreDelGanador;
            puntoJson.GuardarComo(path, nombreGandor);
           // puntoJson.GuardarComo(path, sala.ToString());


            this.dtgMenu.Rows.Add(nombreGandor);
            //this.dtgViajes.Rows.Add(partida, destino, item.FechaInicioViaje.ToShortDateString(), estadoViaje);//
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {

        }

    }
}