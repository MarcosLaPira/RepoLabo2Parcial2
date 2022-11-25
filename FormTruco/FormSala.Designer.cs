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
            this.lblRonda.Location = new System.Drawing.Point(42, 187);
            this.lblRonda.Name = "lblRonda";
            this.lblRonda.Size = new System.Drawing.Size(110, 20);
            this.lblRonda.TabIndex = 1;
            this.lblRonda.Text = "Ronda numero:";
            // 
            // lblEstadoPartida
            // 
            this.lblEstadoPartida.AutoSize = true;
            this.lblEstadoPartida.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoPartida.Location = new System.Drawing.Point(329, 30);
            this.lblEstadoPartida.Name = "lblEstadoPartida";
            this.lblEstadoPartida.Size = new System.Drawing.Size(290, 35);
            this.lblEstadoPartida.TabIndex = 2;
            this.lblEstadoPartida.Text = "Estado de partida";
            // 
            // FormSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}