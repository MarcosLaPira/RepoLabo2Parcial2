using BibliotacaTruco;
using BibliotecaTruco;

namespace FormTruco
{
    public partial class FormMenu : Form
    {       
        static List<Carta> mazo;
        static SemillaSql semillaSql;
        static List<PuntoJson<Sala>> puntoJsons;
        static PuntoJson<Sala> misSalas;
        static string path;

        List<Sala> salas = new List<Sala>();

     

        static FormMenu()
        {
            semillaSql = new SemillaSql();
            mazo = semillaSql.ObtenerCartasDeLaBase();

            // puntoJson = new PuntoJson<string>();      ////////////   
            puntoJsons = new List<PuntoJson<Sala>>();
            misSalas = new PuntoJson<Sala>();

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
             Sala sala ;

            Jugador j1 = new Jugador("Jugador 1");
            Jugador j2 = new Jugador("Jugador 2");
            sala = new Sala(j1, j2,mazo);
           
           
            FormSala formSala = new FormSala(sala);

            this.Hide();
            if (formSala.ShowDialog() == DialogResult.OK)
            {
                formSala.Hide();
                this.Show();
                
                ActualizarLista(sala);
            }
           
        }

        private void ActualizarLista(Sala sala)
        {

            // string nombreGandor = this.sala1.NombreDelGanador;
            //  puntoJson.GuardarComo(path, nombreGandor);//////////
            this.salas.Add(sala);

            misSalas.GuardarComo(path, salas);    
           


            this.dtgMenu.Rows.Add(sala.NombreDelGanador);
            //this.dtgViajes.Rows.Add(partida, destino, item.FechaInicioViaje.ToShortDateString(), estadoViaje);//
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            this.salas = misSalas.Leer(path);
            FormHistorial formHistorial = new FormHistorial(this.salas);

            this.Hide();
            if (formHistorial.ShowDialog() == DialogResult.OK)
            {
                formHistorial.Hide();
                this.Show();
            }
        }

    }
}