namespace ProyectoLin
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btPila = new System.Windows.Forms.Button();
            this.btCola = new System.Windows.Forms.Button();
            this.btListsimp = new System.Windows.Forms.Button();
            this.btListdou = new System.Windows.Forms.Button();
            this.btCirSimp = new System.Windows.Forms.Button();
            this.btcitcdoubl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(236, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escoge una opcion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btPila
            // 
            this.btPila.Location = new System.Drawing.Point(213, 110);
            this.btPila.Name = "btPila";
            this.btPila.Size = new System.Drawing.Size(173, 47);
            this.btPila.TabIndex = 1;
            this.btPila.Text = "Pila";
            this.btPila.UseVisualStyleBackColor = true;
            this.btPila.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btCola
            // 
            this.btCola.Location = new System.Drawing.Point(213, 191);
            this.btCola.Name = "btCola";
            this.btCola.Size = new System.Drawing.Size(173, 54);
            this.btCola.TabIndex = 2;
            this.btCola.Text = "Cola";
            this.btCola.UseVisualStyleBackColor = true;
            this.btCola.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btListsimp
            // 
            this.btListsimp.Location = new System.Drawing.Point(453, 117);
            this.btListsimp.Name = "btListsimp";
            this.btListsimp.Size = new System.Drawing.Size(163, 39);
            this.btListsimp.TabIndex = 3;
            this.btListsimp.Text = "Lista simple";
            this.btListsimp.UseVisualStyleBackColor = true;
            this.btListsimp.Click += new System.EventHandler(this.btListsimp_Click);
            // 
            // btListdou
            // 
            this.btListdou.Location = new System.Drawing.Point(445, 200);
            this.btListdou.Name = "btListdou";
            this.btListdou.Size = new System.Drawing.Size(170, 44);
            this.btListdou.TabIndex = 4;
            this.btListdou.Text = "Lista Doble";
            this.btListdou.UseVisualStyleBackColor = true;
            this.btListdou.Click += new System.EventHandler(this.btListdou_Click);
            // 
            // btCirSimp
            // 
            this.btCirSimp.Location = new System.Drawing.Point(208, 271);
            this.btCirSimp.Name = "btCirSimp";
            this.btCirSimp.Size = new System.Drawing.Size(177, 60);
            this.btCirSimp.TabIndex = 5;
            this.btCirSimp.Text = "circular simple ";
            this.btCirSimp.UseVisualStyleBackColor = true;
            this.btCirSimp.Click += new System.EventHandler(this.btCirSimp_Click);
            // 
            // btcitcdoubl
            // 
            this.btcitcdoubl.Location = new System.Drawing.Point(444, 277);
            this.btcitcdoubl.Name = "btcitcdoubl";
            this.btcitcdoubl.Size = new System.Drawing.Size(158, 53);
            this.btcitcdoubl.TabIndex = 6;
            this.btcitcdoubl.Text = "circular doble";
            this.btcitcdoubl.UseVisualStyleBackColor = true;
            this.btcitcdoubl.Click += new System.EventHandler(this.btcitcdoubl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btcitcdoubl);
            this.Controls.Add(this.btCirSimp);
            this.Controls.Add(this.btListdou);
            this.Controls.Add(this.btListsimp);
            this.Controls.Add(this.btCola);
            this.Controls.Add(this.btPila);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPila;
        private System.Windows.Forms.Button btCola;
        private System.Windows.Forms.Button btListsimp;
        private System.Windows.Forms.Button btListdou;
        private System.Windows.Forms.Button btCirSimp;
        private System.Windows.Forms.Button btcitcdoubl;
    }
}

