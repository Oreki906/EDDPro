﻿namespace ProyectoLin
{
    partial class ListDobl
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
            this.btAgregar = new System.Windows.Forms.Button();
            this.btVaciar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btContar = new System.Windows.Forms.Button();
            this.Imprecion = new System.Windows.Forms.ListBox();
            this.btAnt = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbDatos
            // 
            this.cbDatos.FormattingEnabled = true;
            this.cbDatos.Location = new System.Drawing.Point(254, 85);
            this.cbDatos.Name = "cbDatos";
            this.cbDatos.Size = new System.Drawing.Size(271, 24);
            this.cbDatos.TabIndex = 0;
            // 
            // cbPosicion
            // 
            this.cbPosicion.FormattingEnabled = true;
            this.cbPosicion.Location = new System.Drawing.Point(554, 85);
            this.cbPosicion.Name = "cbPosicion";
            this.cbPosicion.Size = new System.Drawing.Size(190, 24);
            this.cbPosicion.TabIndex = 1;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(254, 168);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(156, 55);
            this.btAgregar.TabIndex = 2;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btVaciar
            // 
            this.btVaciar.Location = new System.Drawing.Point(259, 256);
            this.btVaciar.Name = "btVaciar";
            this.btVaciar.Size = new System.Drawing.Size(150, 72);
            this.btVaciar.TabIndex = 3;
            this.btVaciar.Text = "Vaciar";
            this.btVaciar.UseVisualStyleBackColor = true;
            this.btVaciar.Click += new System.EventHandler(this.btVaciar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(552, 167);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(151, 55);
            this.btEliminar.TabIndex = 4;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btContar
            // 
            this.btContar.Location = new System.Drawing.Point(554, 249);
            this.btContar.Name = "btContar";
            this.btContar.Size = new System.Drawing.Size(148, 78);
            this.btContar.TabIndex = 5;
            this.btContar.Text = "Contar";
            this.btContar.UseVisualStyleBackColor = true;
            this.btContar.Click += new System.EventHandler(this.btContar_Click);
            // 
            // Imprecion
            // 
            this.Imprecion.FormattingEnabled = true;
            this.Imprecion.ItemHeight = 16;
            this.Imprecion.Location = new System.Drawing.Point(28, 46);
            this.Imprecion.Name = "Imprecion";
            this.Imprecion.Size = new System.Drawing.Size(180, 276);
            this.Imprecion.TabIndex = 6;
            // 
            // btAnt
            // 
            this.btAnt.Location = new System.Drawing.Point(254, 352);
            this.btAnt.Name = "btAnt";
            this.btAnt.Size = new System.Drawing.Size(140, 51);
            this.btAnt.TabIndex = 7;
            this.btAnt.Text = "Imprimir Anteriores";
            this.btAnt.UseVisualStyleBackColor = true;
            this.btAnt.Click += new System.EventHandler(this.btAnt_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(552, 347);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(149, 56);
            this.btBuscar.TabIndex = 8;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // ListDobl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btAnt);
            this.Controls.Add(this.Imprecion);
            this.Controls.Add(this.btContar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btVaciar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.cbPosicion);
            this.Controls.Add(this.cbDatos);
            this.Name = "ListDobl";
            this.Text = "ListDobl";
            this.Load += new System.EventHandler(this.ListDobl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDatos;
        private System.Windows.Forms.ComboBox cbPosicion;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btVaciar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btContar;
        private System.Windows.Forms.ListBox Imprecion;
        private System.Windows.Forms.Button btAnt;
        private System.Windows.Forms.Button btBuscar;
    }
}