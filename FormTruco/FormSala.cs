using BibliotacaTruco;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTruco
{
    public partial class FormSala : Form
    {
       
        private int ganadorDeLaSala;
        private Sala sala;
        private string infoPartida;
        private string buffer;
        private int infoRonda;
        public delegate void Delegado();

       
        public FormSala(Sala sala)
        {
            this.sala = sala;
           
            InitializeComponent();
            this.infoPartida = "Comienza partida";
            this.sala.notificacion += this.CambioValor;//me comunico con mi sala y le otorgo un metodo
        }
        private void FormSala_Load(object sender, EventArgs e)
        {
            Task task = new Task(this.sala.ComenzarPartida);//instancioo task
            task.Start(); //ejecuto task

            //this.sala.ComenzarPartida();
            //string nombreGandor = this.sala.NombreDelGanador;

            this.lblIdSala.Text = $"Sala numero {this.sala.IdSala}";


            Task task1 = new Task(this.FinDePartida);
            task1.Start();

        }

        public int GanadorDeLaSala
        {
            get { return this.ganadorDeLaSala; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void rtbInforme_TextChanged(object sender, EventArgs e)
        {
            // this.rtbInforme.Text = "hola";
        }
      
        public bool CambioValor(string st)
        {
            bool retor = false;
            if (st is not null)
            {
                this.infoPartida += $"\n" + st;
                Thread.Sleep(3000);
                retor = true;
            }
            return retor;
        }


        /// <summary>
        /// Hasta que no hay un ganador voy a ir actualizando el rich text box. Es mi timer
        /// </summary>
        public void FinDePartida()
        {
            while (this.sala.NombreDelGanador is null)//bucle hasta que hay un ganador
            {
                Delegado bufferDelegado = new Delegado(this.ActualizarRtb);
                this.Invoke(bufferDelegado);//invoco al delegado

                Thread.Sleep(500);
            }

            this.DeterminarGanador($"El ganador de la sala es: {this.sala.NombreDelGanador}");

            this.DeterminarEstadoDeSala($"Sala finalizada");
        }

        private void DeterminarGanador(string texto)
        {
            if (this.InvokeRequired)//entra por el task
            {                               
                Action<string> d = new Action<string>(this.DeterminarGanador);//instancio delegado y le paso el metodo
                object[] argumentos = { texto};//instamcio lops argumentos
                this.Invoke(d, argumentos);   //invoco. Al invocar se junta el metodo y argumentos ej: DeterminarGanador(string texto)             
            }
            else
            { 
                this.lblGanadorSala.Text = texto;
            }
        }

        private void DeterminarEstadoDeSala(string texto)
        {
            if (this.InvokeRequired)//entra por el task
            {

                Action<string> d = new Action<string>(this.DeterminarEstadoDeSala);//instancio delegado y le paso el metodo
                object[] argumentos = { texto };//instamcio lops argumentos
                this.Invoke(d, argumentos);   //invoco. Al invocar se junta el metodo y argumentos ej: DeterminarGanador(string texto)             
            }
            else
            {
                this.lblEstadoPartida.Text = texto;
            }
        }
        private void ActualizarRtb()
        {
            if (this.infoPartida != this.buffer)//pregunto si la info es igual al buffer
            {
                this.rtbInforme.Text = this.infoPartida;
                this.buffer = this.infoPartida;
            }
        }

      

    }
}
