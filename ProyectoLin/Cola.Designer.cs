namespace ProyectoLin
{
    partial class Cola
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
            this.cbDatos = new System.Windows.Forms.ComboBox();
            this.btEncolar = new System.Windows.Forms.Button();
            this.btDesencolar = new System.Windows.Forms.Button();
            this.Imprecion = new System.Windows.Forms.ListBox();
            this.btVaciar = new System.Windows.Forms.Button();
            this.btContar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbDatos
            // 
            this.cbDatos.FormattingEnabled = true;
            this.cbDatos.Location = new System.Drawing.Point(280, 29);
            this.cbDatos.Name = "cbDatos";
            this.cbDatos.Size = new System.Drawing.Size(259, 24);
            this.cbDatos.TabIndex = 0;
            // 
            // btEncolar
            // 
            this.btEncolar.ForeColor = System.Drawing.Color.Black;
            this.btEncolar.Location = new System.Drawing.Point(294, 110);
            this.btEncolar.Name = "btEncolar";
            this.btEncolar.Size = new System.Drawing.Size(211, 45);
            this.btEncolar.TabIndex = 1;
            this.btEncolar.Text = "Encolar";
            this.btEncolar.UseVisualStyleBackColor = true;
            this.btEncolar.Click += new System.EventHandler(this.btEncolar_Click);
            // 
            // btDesencolar
            // 
            this.btDesencolar.ForeColor = System.Drawing.Color.Black;
            this.btDesencolar.Location = new System.Drawing.Point(294, 170);
            this.btDesencolar.Name = "btDesencolar";
            this.btDesencolar.Size = new System.Drawing.Size(211, 54);
            this.btDesencolar.TabIndex = 2;
            this.btDesencolar.Text = "Desencolar";
            this.btDesencolar.UseVisualStyleBackColor = true;
            this.btDesencolar.Click += new System.EventHandler(this.btDesencolar_Click);
            // 
            // Imprecion
            // 
            this.Imprecion.FormattingEnabled = true;
            this.Imprecion.ItemHeight = 16;
            this.Imprecion.Location = new System.Drawing.Point(50, 38);
            this.Imprecion.Name = "Imprecion";
            this.Imprecion.Size = new System.Drawing.Size(197, 292);
            this.Imprecion.TabIndex = 3;
            // 
            // btVaciar
            // 
            this.btVaciar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btVaciar.Location = new System.Drawing.Point(294, 244);
            this.btVaciar.Name = "btVaciar";
            this.btVaciar.Size = new System.Drawing.Size(210, 51);
            this.btVaciar.TabIndex = 4;
            this.btVaciar.Text = "Vaciar";
            this.btVaciar.UseVisualStyleBackColor = true;
            this.btVaciar.Click += new System.EventHandler(this.btVaciar_Click);
            // 
            // btContar
            // 
            this.btContar.ForeColor = System.Drawing.Color.Black;
            this.btContar.Location = new System.Drawing.Point(294, 309);
            this.btContar.Name = "btContar";
            this.btContar.Size = new System.Drawing.Size(209, 49);
            this.btContar.TabIndex = 5;
            this.btContar.Text = "Contar";
            this.btContar.UseVisualStyleBackColor = true;
            this.btContar.Click += new System.EventHandler(this.btContar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.ForeColor = System.Drawing.Color.Black;
            this.btBuscar.Location = new System.Drawing.Point(543, 112);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(169, 42);
            this.btBuscar.TabIndex = 6;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // Cola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btContar);
            this.Controls.Add(this.btVaciar);
            this.Controls.Add(this.Imprecion);
            this.Controls.Add(this.btDesencolar);
            this.Controls.Add(this.btEncolar);
            this.Controls.Add(this.cbDatos);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Cola";
            this.Text = "Cola";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDatos;
        private System.Windows.Forms.Button btEncolar;
        private System.Windows.Forms.Button btDesencolar;
        private System.Windows.Forms.ListBox Imprecion;
        private System.Windows.Forms.Button btVaciar;
        private System.Windows.Forms.Button btContar;
        private System.Windows.Forms.Button btBuscar;
    }
}