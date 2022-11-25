using BibliotacaTruco;

namespace FormTruco
{
    public partial class FormMenu : Form
    {       
        static List<Carta> mazo;
        static SemillaSql semillaSql;

        static FormMenu()
        {
            semillaSql = new SemillaSql();
            mazo = semillaSql.ObtenerCartasDeLaBase();
        }
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnCrearSala_Click(object sender, EventArgs e)
        {
            
            Jugador j1 = new Jugador("Jugador 1");
            Jugador j2 = new Jugador("Jugador 2");
            Sala sala = new Sala(j1,j2,mazo);

            FormSala formSala = new FormSala(sala);
            formSala.ShowDialog();

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {

        }
    }
}