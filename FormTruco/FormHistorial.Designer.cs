namespace FormTruco
{
    partial class FormHistorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCantDePartidasJugadas = new System.Windows.Forms.Label();
            this.lblVictoriasDejugador1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnaIdPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaGanador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVictoriasDeJugador2 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblPartidasEmpatadas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCantDePartidasJugadas
            // 
            this.lblCantDePartidasJugadas.AutoSize = true;
            this.lblCantDePartidasJugadas.Location = new System.Drawing.Point(44, 85);
            this.lblCantDePartidasJugadas.Name = "lblCantDePartidasJugadas";
            this.lblCantDePartidasJugadas.Size = new System.Drawing.Size(207, 20);
            this.lblCantDePartidasJugadas.TabIndex = 0;
            this.lblCantDePartidasJugadas.Text = "Cantidad de partidas jugadas:";
            // 
            // lblVictoriasDejugador1
            // 
            this.lblVictoriasDejugador1.AutoSize = true;
            this.lblVictoriasDejugador1.Location = new System.Drawing.Point(44, 161);
            this.lblVictoriasDejugador1.Name = "lblVictoriasDejugador1";
            this.lblVictoriasDejugador1.Size = new System.Drawing.Size(158, 20);
            this.lblVictoriasDejugador1.TabIndex = 1;
            this.lblVictoriasDejugador1.Text = "Victorias de jugador 1:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaIdPartida,
            this.ColumnaGanador});
            this.dataGridView.Location = new System.Drawing.Point(331, 65);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(300, 373);
            this.dataGridView.TabIndex = 2;
            // 
            // ColumnaIdPartida
            // 
            this.ColumnaIdPartida.HeaderText = "Numero sala";
            this.ColumnaIdPartida.MinimumWidth = 6;
            this.ColumnaIdPartida.Name = "ColumnaIdPartida";
            this.ColumnaIdPartida.ReadOnly = true;
            this.ColumnaIdPartida.Width = 125;
            // 
            // ColumnaGanador
            // 
            this.ColumnaGanador.HeaderText = "Ganador";
            this.ColumnaGanador.MinimumWidth = 6;
            this.ColumnaGanador.Name = "ColumnaGanador";
            this.ColumnaGanador.ReadOnly = true;
            this.ColumnaGanador.Width = 125;
            // 
            // lblVictoriasDeJugador2
            // 
            this.lblVictoriasDeJugador2.AutoSize = true;
            this.lblVictoriasDeJugador2.Location = new System.Drawing.Point(44, 235);
            this.lblVictoriasDeJugador2.Name = "lblVictoriasDeJugador2";
            this.lblVictoriasDeJugador2.Size = new System.Drawing.Size(158, 20);
            this.lblVictoriasDeJugador2.TabIndex = 3;
            this.lblVictoriasDeJugador2.Text = "Victorias de jugador 2:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(676, 409);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 29);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblPartidasEmpatadas
            // 
            this.lblPartidasEmpatadas.AutoSize = true;
            this.lblPartidasEmpatadas.Location = new System.Drawing.Point(44, 315);
            this.lblPartidasEmpatadas.Name = "lblPartidasEmpatadas";
            this.lblPartidasEmpatadas.Size = new System.Drawing.Size(154, 20);
            this.lblPartidasEmpatadas.TabIndex = 5;
            this.lblPartidasEmpatadas.Text = "Cantidad de empates:";
            // 
            // FormHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPartidasEmpatadas);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblVictoriasDeJugador2);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblVictoriasDejugador1);
            this.Controls.Add(this.lblCantDePartidasJugadas);
            this.Name = "FormHistorial";
            this.Text = "FormHistorial";
            this.Load += new System.EventHandler(this.FormHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCantDePartidasJugadas;
        private Label lblVictoriasDejugador1;
        private DataGridView dataGridView;
        private Label lblVictoriasDeJugador2;
        private DataGridViewTextBoxColumn ColumnaIdPartida;
        private DataGridViewTextBoxColumn ColumnaGanador;
        private Button btnVolver;
        private Label lblPartidasEmpatadas;
    }
}