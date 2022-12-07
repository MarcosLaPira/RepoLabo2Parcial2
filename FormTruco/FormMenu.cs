using BibliotacaTruco;
using BibliotecaTruco;
using System.Runtime.CompilerServices;

namespace FormTruco
{
    public partial class FormMenu : Form
    {       
        static List<Carta> mazo;
        static SemillaSql semillaSql;
        static List<PuntoJson<Sala>> puntoJsons;
        static PuntoJson<Sala> misSalas;
        static string path;

        private List<Sala> salas = new List<Sala>();

        private static int ultimoIdDeSala;

        static FormMenu()
        {
            FormMenu.semillaSql = new SemillaSql();
            FormMenu.mazo = semillaSql.ObtenerCartasDeLaBase();

            // puntoJson = new PuntoJson<string>();      ////////////   
            FormMenu.puntoJsons = new List<PuntoJson<Sala>>();
            FormMenu.misSalas = new PuntoJson<Sala>();

            FormMenu.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//obtengo ruta
            FormMenu.path += "\\PruebaSala6.json";//le sumo la expresion json

           // ultimoIdDeSala = EncontrarUltimoIdDeSala();

        }
        public FormMenu()
        {
            InitializeComponent();

        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            this.CargarArchivoPrimeraVez();
        }
        private void btnCrearSala_Click(object sender, EventArgs e)
        {
           
            Jugador j1 = new Jugador("Jugador 1");
            Jugador j2 = new Jugador("Jugador 2");
            Sala sala = new Sala(j1, j2,mazo);
            sala.IdSala = this.CalcularIdSala();


            FormSala formSala = new FormSala(sala);           
            formSala.Show();

            this.ActualizarLista(sala);

        }

        private void ActualizarLista(Sala sala)
        {         
            this.salas.Add(sala);

            FormMenu.misSalas.GuardarComo(path,this.salas);    
           
            //this.dtgMenu.Rows.Add(sala.IdSala.ToString(),sala.);
            //this.dtgViajes.Rows.Add(partida, destino, item.FechaInicioViaje.ToShortDateString(), estadoViaje);//
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            this.salas = FormMenu.misSalas.Leer(FormMenu.path);
            FormHistorial formHistorial = new FormHistorial(this.salas);

            this.Hide();
            if (formHistorial.ShowDialog() == DialogResult.OK)
            {
                formHistorial.Hide();
                this.Show();
            }
        }

       /// <summary>
       /// Carga todas las salas
       /// </summary>
        private  void CargarArchivoPrimeraVez()
        {
            try
            {
                this.salas = FormMenu.misSalas.Leer(FormMenu.path);
            }
            catch (Exception)
            {
                throw;
            }
             
        }
        private int CalcularIdSala()
        {
            int bufferInt = this.salas.Count;

            return  bufferInt + 1 ;
        }

    }
}