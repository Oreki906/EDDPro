using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using EDDemo.Clases;

namespace EDDemo
{
    public partial class frmPilas : Form
    {
        public frmPilas()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            String var2;

            Pilas miPila = new Pilas();
            miPila.Push();          
        }

        private void frmPilas_Load(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            buscar();
            txtDatos.Text = "";//blanquea el ingreso de los dATOS 

            txtDatos.Focus();//para no volver a hacer clic eb la barra 
        }
        //comentario
    }
}
