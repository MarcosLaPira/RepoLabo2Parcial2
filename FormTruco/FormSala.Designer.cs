namespace FormTruco
{
    partial class FormSala
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
            this.lblIdSala = new System.Windows.Forms.Label();
            this.lblRonda = new System.Windows.Forms.Label();
            this.lblEstadoPartida = new System.Windows.Forms.Label();
            this.lblGanadorSala = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.rtbInforme = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblIdSala
            // 
            this.lblIdSala.AutoSize = true;
            this.lblIdSala.Location = new System.Drawing.Point(42, 115);
            this.lblIdSala.Name = "lblIdSala";
            this.lblIdSala.Size = new System.Drawing.Size(76, 20);
            this.lblIdSala.TabIndex = 0;
            this.lblIdSala.Text = "Id de sala:";
            // 
            // lblRonda
            // 
            this.lblRonda.AutoSize = true;
            this.lblRonda.Location = new System.Drawing.Point(42, 170);
            this.lblRonda.Name = "lblRonda";
            this.lblRonda.Size = new System.Drawing.Size(110, 20);
            this.lblRonda.TabIndex = 1;
            this.lblRonda.Text = "Ronda numero:";
            // 
            // lblEstadoPartida
            // 
            this.lblEstadoPartida.AutoSize = true;
            this.lblEstadoPartida.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoPartida.Location = new System.Drawing.Point(387, 29);
            this.lblEstadoPartida.Name = "lblEstadoPartida";
            this.lblEstadoPartida.Size = new System.Drawing.Size(273, 35);
            this.lblEstadoPartida.TabIndex = 2;
            this.lblEstadoPartida.Text = "Partida en curso";
            // 
            // lblGanadorSala
            // 
            this.lblGanadorSala.AutoSize = true;
            this.lblGanadorSala.Location = new System.Drawing.Point(42, 228);
            this.lblGanadorSala.Name = "lblGanadorSala";
            this.lblGanadorSala.Size = new System.Drawing.Size(99, 20);
            this.lblGanadorSala.TabIndex = 3;
            this.lblGanadorSala.Text = "Ganador sala:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(690, 402);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(98, 36);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // rtbInforme
            // 
            this.rtbInforme.Location = new System.Drawing.Point(329, 85);
            this.rtbInforme.Name = "rtbInforme";
            this.rtbInforme.Size = new System.Drawing.Size(410, 311);
            this.rtbInforme.TabIndex = 5;
            this.rtbInforme.Text = "";
            this.rtbInforme.TextChanged += new System.EventHandler(this.rtbInforme_TextChanged);
            // 
            // FormSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbInforme);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblGanadorSala);
            this.Controls.Add(this.lblEstadoPartida);
            this.Controls.Add(this.lblRonda);
            this.Controls.Add(this.lblIdSala);
            this.Name = "FormSala";
            this.Text = "FormSala";
            this.Load += new System.EventHandler(this.FormSala_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblIdSala;
        private Label lblRonda;
        private Label lblEstadoPartida;
        private Label lblGanadorSala;
        private Button btnOk;
        private RichTextBox rtbInforme;
    }
}