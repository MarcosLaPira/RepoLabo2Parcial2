namespace FormTruco
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearSala = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.dtgMenu = new System.Windows.Forms.DataGridView();
            this.lblSalas = new System.Windows.Forms.Label();
            this.ColumnaIdSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEstadoSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearSala
            // 
            this.btnCrearSala.Location = new System.Drawing.Point(116, 69);
            this.btnCrearSala.Name = "btnCrearSala";
            this.btnCrearSala.Size = new System.Drawing.Size(125, 68);
            this.btnCrearSala.TabIndex = 0;
            this.btnCrearSala.Text = "Crear sala";
            this.btnCrearSala.UseVisualStyleBackColor = true;
            this.btnCrearSala.Click += new System.EventHandler(this.btnCrearSala_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(116, 185);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(125, 71);
            this.btnHistorial.TabIndex = 1;
            this.btnHistorial.Text = "Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // dtgMenu
            // 
            this.dtgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaIdSala,
            this.ColumnaEstadoSala});
            this.dtgMenu.Location = new System.Drawing.Point(408, 69);
            this.dtgMenu.Name = "dtgMenu";
            this.dtgMenu.RowHeadersWidth = 51;
            this.dtgMenu.RowTemplate.Height = 29;
            this.dtgMenu.Size = new System.Drawing.Size(300, 369);
            this.dtgMenu.TabIndex = 2;
            // 
            // lblSalas
            // 
            this.lblSalas.AutoSize = true;
            this.lblSalas.Location = new System.Drawing.Point(408, 36);
            this.lblSalas.Name = "lblSalas";
            this.lblSalas.Size = new System.Drawing.Size(101, 20);
            this.lblSalas.TabIndex = 3;
            this.lblSalas.Text = "Salas actuales";
            // 
            // ColumnaIdSala
            // 
            this.ColumnaIdSala.HeaderText = "Idsala";
            this.ColumnaIdSala.MinimumWidth = 6;
            this.ColumnaIdSala.Name = "ColumnaIdSala";
            this.ColumnaIdSala.ReadOnly = true;
            this.ColumnaIdSala.Width = 125;
            // 
            // ColumnaEstadoSala
            // 
            this.ColumnaEstadoSala.HeaderText = "Estado de partida";
            this.ColumnaEstadoSala.MinimumWidth = 6;
            this.ColumnaEstadoSala.Name = "ColumnaEstadoSala";
            this.ColumnaEstadoSala.ReadOnly = true;
            this.ColumnaEstadoSala.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSalas);
            this.Controls.Add(this.dtgMenu);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnCrearSala);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCrearSala;
        private Button btnHistorial;
        private DataGridView dtgMenu;
        private DataGridViewTextBoxColumn ColumnaIdSala;
        private DataGridViewTextBoxColumn ColumnaEstadoSala;
        private Label lblSalas;
    }
}