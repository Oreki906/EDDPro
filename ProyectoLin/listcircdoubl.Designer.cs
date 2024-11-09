namespace ProyectoLin
{
    partial class listcircdoubl
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
            this.cbPosicion = new System.Windows.Forms.ComboBox();
            this.imprecion = new System.Windows.Forms.ListBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btVaciar = new System.Windows.Forms.Button();
            this.btContar = new System.Windows.Forms.Button();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbDatos
            // 
            this.cbDatos.FormattingEnabled = true;
            this.cbDatos.Location = new System.Drawing.Point(242, 59);
            this.cbDatos.Name = "cbDatos";
            this.cbDatos.Size = new System.Drawing.Size(240, 24);
            this.cbDatos.TabIndex = 0;
            // 
            // cbPosicion
            // 
            this.cbPosicion.FormattingEnabled = true;
            this.cbPosicion.Location = new System.Drawing.Point(538, 58);
            this.cbPosicion.Name = "cbPosicion";
            this.cbPosicion.Size = new System.Drawing.Size(243, 24);
            this.cbPosicion.TabIndex = 1;
            // 
            // imprecion
            // 
            this.imprecion.FormattingEnabled = true;
            this.imprecion.ItemHeight = 16;
            this.imprecion.Location = new System.Drawing.Point(41, 49);
            this.imprecion.Name = "imprecion";
            this.imprecion.Size = new System.Drawing.Size(166, 244);
            this.imprecion.TabIndex = 2;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(243, 118);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(200, 64);
            this.btAgregar.TabIndex = 3;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(508, 119);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(201, 62);
            this.btEliminar.TabIndex = 4;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btVaciar
            // 
            this.btVaciar.Location = new System.Drawing.Point(243, 198);
            this.btVaciar.Name = "btVaciar";
            this.btVaciar.Size = new System.Drawing.Size(199, 76);
            this.btVaciar.TabIndex = 5;
            this.btVaciar.Text = "Vaciar";
            this.btVaciar.UseVisualStyleBackColor = true;
            this.btVaciar.Click += new System.EventHandler(this.btVaciar_Click);
            // 
            // btContar
            // 
            this.btContar.Location = new System.Drawing.Point(506, 198);
            this.btContar.Name = "btContar";
            this.btContar.Size = new System.Drawing.Size(202, 75);
            this.btContar.TabIndex = 6;
            this.btContar.Text = "Contar";
            this.btContar.UseVisualStyleBackColor = true;
            this.btContar.Click += new System.EventHandler(this.btContar_Click);
            // 
            // BtBuscar
            // 
            this.BtBuscar.Location = new System.Drawing.Point(265, 304);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(176, 59);
            this.BtBuscar.TabIndex = 7;
            this.BtBuscar.Text = "Buscar";
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // listcircdoubl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.btContar);
            this.Controls.Add(this.btVaciar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.imprecion);
            this.Controls.Add(this.cbPosicion);
            this.Controls.Add(this.cbDatos);
            this.Name = "listcircdoubl";
            this.Text = "listcircdoubl";
            this.Load += new System.EventHandler(this.listcircdoubl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDatos;
        private System.Windows.Forms.ComboBox cbPosicion;
        private System.Windows.Forms.ListBox imprecion;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btVaciar;
        private System.Windows.Forms.Button btContar;
        private System.Windows.Forms.Button BtBuscar;
    }
}