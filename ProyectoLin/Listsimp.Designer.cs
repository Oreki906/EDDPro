namespace ProyectoLin
{
    partial class Listsimp
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
            this.Imprecion = new System.Windows.Forms.ListBox();
            this.btIncertP = new System.Windows.Forms.Button();
            this.btElimP = new System.Windows.Forms.Button();
            this.cbDato = new System.Windows.Forms.ComboBox();
            this.cbPosicion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btvaciar = new System.Windows.Forms.Button();
            this.btContar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Imprecion
            // 
            this.Imprecion.FormattingEnabled = true;
            this.Imprecion.ItemHeight = 16;
            this.Imprecion.Location = new System.Drawing.Point(34, 48);
            this.Imprecion.Name = "Imprecion";
            this.Imprecion.Size = new System.Drawing.Size(150, 244);
            this.Imprecion.TabIndex = 0;
            // 
            // btIncertP
            // 
            this.btIncertP.Location = new System.Drawing.Point(264, 207);
            this.btIncertP.Name = "btIncertP";
            this.btIncertP.Size = new System.Drawing.Size(149, 51);
            this.btIncertP.TabIndex = 1;
            this.btIncertP.Text = "Incertar";
            this.btIncertP.UseVisualStyleBackColor = true;
            this.btIncertP.Click += new System.EventHandler(this.btIncertP_Click);
            // 
            // btElimP
            // 
            this.btElimP.Location = new System.Drawing.Point(551, 207);
            this.btElimP.Name = "btElimP";
            this.btElimP.Size = new System.Drawing.Size(161, 51);
            this.btElimP.TabIndex = 3;
            this.btElimP.Text = "Eliminar";
            this.btElimP.UseVisualStyleBackColor = true;
            this.btElimP.Click += new System.EventHandler(this.btElimP_Click);
            // 
            // cbDato
            // 
            this.cbDato.FormattingEnabled = true;
            this.cbDato.Location = new System.Drawing.Point(264, 115);
            this.cbDato.Name = "cbDato";
            this.cbDato.Size = new System.Drawing.Size(257, 24);
            this.cbDato.TabIndex = 5;
            // 
            // cbPosicion
            // 
            this.cbPosicion.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbPosicion.FormattingEnabled = true;
            this.cbPosicion.Location = new System.Drawing.Point(594, 115);
            this.cbPosicion.Name = "cbPosicion";
            this.cbPosicion.Size = new System.Drawing.Size(149, 24);
            this.cbPosicion.TabIndex = 6;
            this.cbPosicion.SelectedIndexChanged += new System.EventHandler(this.cbPosicion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(289, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dato numerico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(621, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Posicion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btvaciar
            // 
            this.btvaciar.Location = new System.Drawing.Point(264, 279);
            this.btvaciar.Name = "btvaciar";
            this.btvaciar.Size = new System.Drawing.Size(148, 50);
            this.btvaciar.TabIndex = 9;
            this.btvaciar.Text = "Vaciar";
            this.btvaciar.UseVisualStyleBackColor = true;
            this.btvaciar.Click += new System.EventHandler(this.btvaciar_Click);
            // 
            // btContar
            // 
            this.btContar.Location = new System.Drawing.Point(551, 279);
            this.btContar.Name = "btContar";
            this.btContar.Size = new System.Drawing.Size(160, 49);
            this.btContar.TabIndex = 10;
            this.btContar.Text = "Contar";
            this.btContar.UseVisualStyleBackColor = true;
            this.btContar.Click += new System.EventHandler(this.btContar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(400, 345);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(151, 65);
            this.btBuscar.TabIndex = 11;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // Listsimp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btContar);
            this.Controls.Add(this.btvaciar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPosicion);
            this.Controls.Add(this.cbDato);
            this.Controls.Add(this.btElimP);
            this.Controls.Add(this.btIncertP);
            this.Controls.Add(this.Imprecion);
            this.Name = "Listsimp";
            this.Text = "Listsimp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Imprecion;
        private System.Windows.Forms.Button btIncertP;
        private System.Windows.Forms.Button btElimP;
        private System.Windows.Forms.ComboBox cbDato;
        private System.Windows.Forms.ComboBox cbPosicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btvaciar;
        private System.Windows.Forms.Button btContar;
        private System.Windows.Forms.Button btBuscar;
    }
}